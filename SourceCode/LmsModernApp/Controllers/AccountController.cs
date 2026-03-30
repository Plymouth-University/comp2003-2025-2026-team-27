using System.Security.Claims;
using Lms.Data;
using Lms.Data.Models.Delocal;
using LmsModernApp.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace LmsModernApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly IOperatorRepository _operatorRepository;

        public AccountController(IOperatorRepository operatorRepository)
        {
            _operatorRepository = operatorRepository;
        }

        [HttpGet]
        public IActionResult Login(string? returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View(new LoginViewModel { ReturnUrl = returnUrl });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var operatorUser = await _operatorRepository.ValidateOperatorAsync(model.Username, model.Password);

            if (operatorUser != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, operatorUser.OperName),
                    new Claim("OperatorName", operatorUser.OperName),
                    new Claim("SupervisorAccess", operatorUser.SupAccess ?? "N"),
                    new Claim(ClaimTypes.Role, "Staff")
                };

                // Store in session as requested in the old system description
                HttpContext.Session.SetString("OperatorName", operatorUser.OperName);
                HttpContext.Session.SetString("AuthenticatedFlag", "true");

                // Get Allowed Locations
                var allowedLocations = await _operatorRepository.GetAllowedLocationsAsync(operatorUser);

                if (allowedLocations.Count == 1)
                {
                    // Automatic selection
                    var singleLoc = allowedLocations.First();
                    claims.Add(new Claim("WorkingLocation", singleLoc.LlCode));
                    claims.Add(new Claim("WorkingLocationName", singleLoc.LlName ?? singleLoc.LlCode));
                    
                    HttpContext.Session.SetString("SessionLoginLocation", singleLoc.LlCode);

                    await SignInAsync(claims, model.RememberMe);

                    if (!string.IsNullOrEmpty(model.ReturnUrl) && Url.IsLocalUrl(model.ReturnUrl))
                    {
                        return Redirect(model.ReturnUrl);
                    }
                    return RedirectToAction("Home", "Home");
                }
                else if (allowedLocations.Count > 1)
                {
                    // Multiple locations - need selection
                    await SignInAsync(claims, model.RememberMe); // Sign in with basic claims first
                    return RedirectToAction("SelectLocation", new { returnUrl = model.ReturnUrl });
                }
                else
                {
                    // No locations available - check if super-user or configuration error
                    ModelState.AddModelError(string.Empty, "Access denied: No library locations assigned to this account.");
                    return View(model);
                }
            }

            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            return View(model);
        }

        private async Task SignInAsync(List<Claim> claims, bool rememberMe)
        {
            var claimsIdentity = new ClaimsIdentity(claims, "StaffAuth");
            var authProperties = new AuthenticationProperties
            {
                IsPersistent = rememberMe,
                ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(60)
            };
            await HttpContext.SignInAsync("StaffAuth", new ClaimsPrincipal(claimsIdentity), authProperties);
        }

        [HttpGet]
        public async Task<IActionResult> SelectLocation(string? returnUrl = null)
        {
            if (User.Identity?.IsAuthenticated != true) return RedirectToAction("Login");

            var op = await _operatorRepository.GetOperatorByNameAsync(User.Identity.Name!);
            if (op == null) return RedirectToAction("Logout");

            var locations = await _operatorRepository.GetAllowedLocationsAsync(op);
            ViewData["ReturnUrl"] = returnUrl;
            return View(locations);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SelectLocation(string llCode, string? returnUrl = null)
        {
            if (User.Identity?.IsAuthenticated != true) return RedirectToAction("Login");

            var op = await _operatorRepository.GetOperatorByNameAsync(User.Identity.Name!);
            if (op == null) return RedirectToAction("Logout");

            var allowedLocations = await _operatorRepository.GetAllowedLocationsAsync(op);
            var selectedLoc = allowedLocations.FirstOrDefault(l => l.LlCode == llCode);

            if (selectedLoc != null)
            {
                // Re-sign in with the location claim
                var claims = User.Claims.ToList();
                
                // Remove old location claims if they exist
                claims.RemoveAll(c => c.Type == "WorkingLocation" || c.Type == "WorkingLocationName");
                
                claims.Add(new Claim("WorkingLocation", selectedLoc.LlCode));
                claims.Add(new Claim("WorkingLocationName", selectedLoc.LlName ?? selectedLoc.LlCode));

                await SignInAsync(claims, true); // Update cookie

                HttpContext.Session.SetString("SessionLoginLocation", selectedLoc.LlCode);

                if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                {
                    return Redirect(returnUrl);
                }
                return RedirectToAction("Home", "Home");
            }

            ModelState.AddModelError(string.Empty, "Please select a valid location.");
            return View(allowedLocations);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync("StaffAuth");
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Account");
        }

        [HttpGet]
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}

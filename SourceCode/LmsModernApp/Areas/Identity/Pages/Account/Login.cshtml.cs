using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LmsModernApp.Areas.Identity.Pages.Account
{
    public class LoginModel : PageModel
    {
        public class InputModel
        {
            public string UserName { get; set; } = "";
            public string Password { get; set; } = "";
        }

        public InputModel Input { get; set; } = new();
    }
}

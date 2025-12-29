using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class EventAdditionalService
{
    public int EventAdditionalServicesId { get; set; }

    public int StkBkEventId { get; set; }

    public int StkItemNo { get; set; }

    public int? ChangingRoom { get; set; }

    public int? FloodLights { get; set; }

    public int? Water { get; set; }

    public int? Catering { get; set; }

    public string? ChangingRoomCode { get; set; }

    public string? FloodLightsCode { get; set; }

    public string? WaterCode { get; set; }

    public string? CateringCode { get; set; }

    public string? ElectricityCode { get; set; }
}

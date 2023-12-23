using System;
using System.Collections.Generic;

namespace DreamRend.Models;

public partial class Apartment
{
    public long ApartmentId { get; set; }

    public long? UserId { get; set; }

    public int? Cost { get; set; }

    public string? ApName { get; set; }

    public string? Info { get; set; }

    public int? Period { get; set; }

    public int? RoomCount { get; set; }

    public byte[]? MainPhoto { get; set; }

    public int? Area { get; set; }

    public int? Floor { get; set; }

    public virtual User? User { get; set; }
}

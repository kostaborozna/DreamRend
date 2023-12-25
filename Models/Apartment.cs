using System;
using System.Collections.Generic;

namespace DreamRend.Models;

public partial class Apartment
{
    public long ApartmentId { get; set; }

    public long UserId { get; set; }

    public int Cost { get; set; }

    public string ApName { get; set; } = null!;

    public string Info { get; set; } = null!;

    public int Period { get; set; }

    public int RoomCount { get; set; }

    public byte[] MainPhoto { get; set; } = null!;

    public int Area { get; set; }

    public int Floor { get; set; }

    public virtual User User { get; set; } = null!;
}

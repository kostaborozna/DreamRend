using System;
using System.Collections.Generic;

namespace DreamRend.Models;

public partial class User
{
    public long UserId { get; set; }

    public string? EMail { get; set; }

    public string? Fname { get; set; }

    public string? Mname { get; set; }

    public string? Password { get; set; }

    public virtual ICollection<Apartment> Apartments { get; set; } = new List<Apartment>();
}

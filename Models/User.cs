namespace DreamRend.Models;

public partial class User
{
	public long UserId { get; set; }

	public string EMail { get; set; } = null!;

	public string Fname { get; set; } = null!;

	public string Mname { get; set; } = null!;

	public string PasswordHash { get; set; } = null!;

	public string CommMethod { get; set; }

	public string Salt { get; set; } = null!;

	public virtual ICollection<Apartment> Apartments { get; set; } = new List<Apartment>();
}

using Microsoft.EntityFrameworkCore;

namespace DreamRend.Models;

public partial class DreamRendContext : DbContext
{

	public DreamRendContext(DbContextOptions<DreamRendContext> options)
		: base(options)
	{
	}

	public virtual DbSet<Apartment> Apartments { get; set; }

	public virtual DbSet<User> Users { get; set; }

	public DreamRendContext() => Database.EnsureCreated();

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		=> optionsBuilder.UseSqlite("Data Source=dbcontext.db");

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Apartment>(entity =>
		{
			entity.HasKey(e => e.ApartmentId).HasName("apartment_pkey");

			entity.ToTable("apartment");

			entity.Property(e => e.ApartmentId)
				.UseIdentityAlwaysColumn()
				.HasColumnName("apartment_id");
			entity.Property(e => e.ApName)
				.HasMaxLength(120)
				.HasColumnName("ap_name");
			entity.Property(e => e.Area).HasColumnName("area");
			entity.Property(e => e.Cost).HasColumnName("cost");
			entity.Property(e => e.Floor).HasColumnName("floor");
			entity.Property(e => e.Info)
				.HasMaxLength(5000)
				.HasColumnName("info");
			entity.Property(e => e.MainPhoto).HasColumnName("main_photo");
			entity.Property(e => e.Period).HasColumnName("period");
			entity.Property(e => e.RoomCount).HasColumnName("room_count");
			entity.Property(e => e.UserId).HasColumnName("user_id");

			entity.HasOne(d => d.User).WithMany(p => p.Apartments)
				.HasForeignKey(d => d.UserId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("apartment_user_id_fkey");
		});

		modelBuilder.Entity<User>(entity =>
		{
			entity.HasKey(e => e.UserId).HasName("User_pkey");

			entity.ToTable("users");

			entity.Property(e => e.UserId)
				.UseIdentityAlwaysColumn()
				.HasColumnName("user_id");
			entity.Property(e => e.CommMethod).HasColumnName("commMethod");
			entity.Property(e => e.EMail)
				.HasMaxLength(150)
				.HasColumnName("e_mail");
			entity.Property(e => e.Fname)
				.HasMaxLength(150)
				.HasColumnName("fname");
			entity.Property(e => e.Mname)
				.HasMaxLength(150)
				.HasColumnName("mname");
			entity.Property(e => e.PasswordHash).HasColumnName("passwordHash");
		
			entity.Property(e => e.Salt).HasColumnName("salt");
			
		});

		OnModelCreatingPartial(modelBuilder);
	}

	partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

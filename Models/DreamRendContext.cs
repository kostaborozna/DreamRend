using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DreamRend.Models;

public partial class DreamRendContext : DbContext
{
    public DreamRendContext()
    {
    }

    public DreamRendContext(DbContextOptions<DreamRendContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Apartment> Apartments { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=DreamRend;Username=dreamrendadmin;Password=SuperSuc555");

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
            entity.Property(e => e.Info)
                .HasMaxLength(200)
                .HasColumnName("info");
            entity.Property(e => e.MainPhoto).HasColumnName("main_photo");
            entity.Property(e => e.Period).HasColumnName("period");
            entity.Property(e => e.RoomCount).HasColumnName("room_count");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.Apartments)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("apartment_user_id_fkey");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("User_pkey");

            entity.ToTable("users");

            entity.Property(e => e.UserId)
                .UseIdentityAlwaysColumn()
                .HasColumnName("user_id");
            entity.Property(e => e.EMail)
                .HasMaxLength(80)
                .HasColumnName("e_mail");
            entity.Property(e => e.Fname)
                .HasMaxLength(80)
                .HasColumnName("fname");
            entity.Property(e => e.Mname)
                .HasMaxLength(80)
                .HasColumnName("mname");
            entity.Property(e => e.Password)
                .HasMaxLength(45)
                .HasColumnName("password");
            entity.Property(e => e.Rating).HasColumnName("rating");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

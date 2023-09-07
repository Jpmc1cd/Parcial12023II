using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Parcial12023II.Models;

public partial class VeterinariaContext : DbContext
{
    public VeterinariaContext()
    {
    }

    public VeterinariaContext(DbContextOptions<VeterinariaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Comidum> Comida { get; set; }

    public virtual DbSet<Dueño> Dueños { get; set; }

    public virtual DbSet<Mascota> Mascotas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=TEC888-3\\SQLEXPRESS; Database=Veterinaria; Trusted_Connection=True; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Comidum>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.IdMascota).HasColumnName("Id_Mascota");
            entity.Property(e => e.Sabor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoComida)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Tipo_Comida");
        });

        modelBuilder.Entity<Dueño>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Direccion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Genero)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdMascota).HasColumnName("Id_Mascota");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Telefono).HasColumnType("numeric(10, 0)");
        });

        modelBuilder.Entity<Mascota>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Genero)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreMascota)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Mascota");
            entity.Property(e => e.Raza)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoMascota)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Tipo_Mascota");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

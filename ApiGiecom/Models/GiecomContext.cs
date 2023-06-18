using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ApiGiecom.Models;

public partial class GiecomContext : DbContext
{
    public GiecomContext()
    {
    }

    public GiecomContext(DbContextOptions<GiecomContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Persona> Personas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }
    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
    //       => optionsBuilder.UseMySql("server=localhost;port=3306;database=Giecom;uid=root;password=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.32-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_bin")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("persona");

            entity.Property(e => e.PrimerApellido).HasMaxLength(50);
            entity.Property(e => e.PrimerNombre).HasMaxLength(50);
            entity.Property(e => e.SegundoApellido).HasMaxLength(50);
            entity.Property(e => e.SegundoNombre).HasMaxLength(50);
            entity.Property(e => e.Telefono).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

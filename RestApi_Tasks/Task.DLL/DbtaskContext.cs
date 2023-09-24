using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Task.Models;

public partial class DbtaskContext : DbContext
{
    public DbtaskContext()
    {
    }

    public DbtaskContext(DbContextOptions<DbtaskContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Tarea> Tareas { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Tarea>(entity =>
        {
            entity.HasKey(e => e.IdtareaT);

            entity.Property(e => e.IdtareaT).HasColumnName("IDTarea_T");
            entity.Property(e => e.DescripcionT)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasColumnName("Descripcion_T");
            entity.Property(e => e.FechaDeCargaT)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FechaDeCarga_T");
            entity.Property(e => e.FechaDeTareaT)
                .HasColumnType("datetime")
                .HasColumnName("FechaDeTarea_T");
            entity.Property(e => e.HoraDeTareaT).HasColumnName("HoraDeTarea_T");
            entity.Property(e => e.IdusuarioUT).HasColumnName("IDUsuario_U_T");
            entity.Property(e => e.NombreT)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_T");

            entity.HasOne(d => d.IdusuarioUTNavigation).WithMany(p => p.Tareas)
                .HasForeignKey(d => d.IdusuarioUT)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tareas_Usuarios");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdusuarioU).HasName("IDUsuario_U");

            entity.HasIndex(e => e.NombreU, "UK_Nombre").IsUnique();

            entity.Property(e => e.IdusuarioU).HasColumnName("IDUsuario_U");
            entity.Property(e => e.ActivoU)
                .HasDefaultValueSql("((1))")
                .HasColumnName("Activo_U");
            entity.Property(e => e.ClaveU)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Clave_U");
            entity.Property(e => e.EmailU)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Email_U");
            entity.Property(e => e.FechaDeCarga)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.NombreU)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("Nombre_U");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

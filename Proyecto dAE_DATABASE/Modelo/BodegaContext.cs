﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Proyecto_dAE_DATABASE.Modelo;

public partial class BodegaContext : DbContext
{
    public BodegaContext()
    {
    }

    public BodegaContext(DbContextOptions<BodegaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Carrera> Carreras { get; set; }

    public virtual DbSet<DeBaja> DeBajas { get; set; }

    public virtual DbSet<Deporte> Deportes { get; set; }

    public virtual DbSet<DetallePrestamo> DetallePrestamos { get; set; }

    public virtual DbSet<DetallePrestamosView> DetallePrestamosViews { get; set; }

    public virtual DbSet<EncargadoBodega> EncargadoBodegas { get; set; }

    public virtual DbSet<Escuela> Escuelas { get; set; }

    public virtual DbSet<Implemento> Implementos { get; set; }

    public virtual DbSet<Perdido> Perdidos { get; set; }

    public virtual DbSet<Prestamo> Prestamos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=OSW\\SQLEXPRESS;Database=Bodega;Trusted_Connection=True;encrypt=False;Connection Timeout=60;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Carrera>(entity =>
        {
            entity.HasKey(e => e.IdCarrera).HasName("PK__Carrera__7B19E79140613908");

            entity.ToTable("Carrera");

            entity.Property(e => e.IdCarrera)
                .ValueGeneratedNever()
                .HasColumnName("idCarrera");
            entity.Property(e => e.IdEscuela).HasColumnName("idEscuela");
            entity.Property(e => e.NombreCarrera)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombreCarrera");

            entity.HasOne(d => d.IdEscuelaNavigation).WithMany(p => p.Carreras)
                .HasForeignKey(d => d.IdEscuela)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Carrera__idEscue__4BAC3F29");
        });

        modelBuilder.Entity<DeBaja>(entity =>
        {
            entity.HasKey(e => e.IdDeBaja).HasName("PK__DeBaja__CDE025B0C2AF8DED");

            entity.ToTable("DeBaja");

            entity.Property(e => e.IdDeBaja)
                .ValueGeneratedNever()
                .HasColumnName("idDeBaja");
            entity.Property(e => e.IdImplemento).HasColumnName("idImplemento");
            entity.Property(e => e.Razon)
                .HasColumnType("text")
                .HasColumnName("razon");

            entity.HasOne(d => d.IdImplementoNavigation).WithMany(p => p.DeBajas)
                .HasForeignKey(d => d.IdImplemento)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__DeBaja__idImplem__5BE2A6F2");
        });

        modelBuilder.Entity<Deporte>(entity =>
        {
            entity.HasKey(e => e.IdDeporte).HasName("PK__Deporte__51D36C591666204C");

            entity.ToTable("Deporte");

            entity.Property(e => e.IdDeporte)
                .ValueGeneratedNever()
                .HasColumnName("idDeporte");
            entity.Property(e => e.NombreDeporte)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nombreDeporte");
        });

        modelBuilder.Entity<DetallePrestamo>(entity =>
        {
            entity.HasKey(e => e.IdDetallePrestamo).HasName("PK__DetalleP__5D283E2E8B6CFE7D");

            entity.ToTable("DetallePrestamo");

            entity.Property(e => e.IdDetallePrestamo)
                .ValueGeneratedNever()
                .HasColumnName("idDetallePrestamo");
            entity.Property(e => e.CantidadPrestada).HasColumnName("cantidadPrestada");
            entity.Property(e => e.Especificacion)
                .HasColumnType("text")
                .HasColumnName("especificacion");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estado");
            entity.Property(e => e.IdImplemento).HasColumnName("idImplemento");
            entity.Property(e => e.IdPrestamo).HasColumnName("idPrestamo");

            entity.HasOne(d => d.IdImplementoNavigation).WithMany(p => p.DetallePrestamos)
                .HasForeignKey(d => d.IdImplemento)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__DetallePr__idImp__5FB337D6");

            entity.HasOne(d => d.IdPrestamoNavigation).WithMany(p => p.DetallePrestamos)
                .HasForeignKey(d => d.IdPrestamo)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__DetallePr__idPre__5EBF139D");
        });

        modelBuilder.Entity<DetallePrestamosView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DetallePrestamosView");

            entity.Property(e => e.Articulo).HasColumnType("text");
            entity.Property(e => e.Encargado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EncargadoBodega>(entity =>
        {
            entity.HasKey(e => e.IdEncargado).HasName("PK__Encargad__579D6A01F74BF9F4");

            entity.ToTable("EncargadoBodega");

            entity.Property(e => e.IdEncargado)
                .ValueGeneratedNever()
                .HasColumnName("idEncargado");
            entity.Property(e => e.NombreEncargado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombreEncargado");
        });

        modelBuilder.Entity<Escuela>(entity =>
        {
            entity.HasKey(e => e.IdEscuela).HasName("PK__Escuela__9F67B289A7750F81");

            entity.ToTable("Escuela");

            entity.Property(e => e.IdEscuela)
                .ValueGeneratedNever()
                .HasColumnName("idEscuela");
            entity.Property(e => e.NombreEscuela)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombreEscuela");
        });

        modelBuilder.Entity<Implemento>(entity =>
        {
            entity.HasKey(e => e.IdImplemento).HasName("PK__Implemen__7C6043641B550170");

            entity.ToTable("Implemento");

            entity.Property(e => e.IdImplemento)
                .ValueGeneratedNever()
                .HasColumnName("idImplemento");
            entity.Property(e => e.Anio).HasColumnName("anio");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("descripcion");
            entity.Property(e => e.IdDeporte).HasColumnName("idDeporte");
            entity.Property(e => e.Tipo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("tipo");

            entity.HasOne(d => d.IdDeporteNavigation).WithMany(p => p.Implementos)
                .HasForeignKey(d => d.IdDeporte)
                .HasConstraintName("FK__Implement__idDep__59063A47");
        });

        modelBuilder.Entity<Perdido>(entity =>
        {
            entity.HasKey(e => e.IdPerdido).HasName("PK__Perdido__89F29A23B518323A");

            entity.ToTable("Perdido");

            entity.Property(e => e.IdPerdido)
                .ValueGeneratedNever()
                .HasColumnName("idPerdido");
            entity.Property(e => e.CantidadPerdida).HasColumnName("cantidadPerdida");
            entity.Property(e => e.IdDetallePrestamo).HasColumnName("idDetallePrestamo");

            entity.HasOne(d => d.IdDetallePrestamoNavigation).WithMany(p => p.Perdidos)
                .HasForeignKey(d => d.IdDetallePrestamo)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Perdido__idDetal__628FA481");
        });

        modelBuilder.Entity<Prestamo>(entity =>
        {
            entity.HasKey(e => e.IdPrestamo).HasName("PK__Prestamo__A4876C133494AB87");

            entity.ToTable("Prestamo");

            entity.Property(e => e.IdPrestamo)
                .ValueGeneratedNever()
                .HasColumnName("idPrestamo");
            entity.Property(e => e.FechaDevolucion).HasColumnName("fechaDevolucion");
            entity.Property(e => e.FechaPrestamo).HasColumnName("fechaPrestamo");
            entity.Property(e => e.IdEncargadoPrestamo).HasColumnName("idEncargadoPrestamo");
            entity.Property(e => e.IdReceptor).HasColumnName("idReceptor");

            entity.HasOne(d => d.IdEncargadoPrestamoNavigation).WithMany(p => p.Prestamos)
                .HasForeignKey(d => d.IdEncargadoPrestamo)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Prestamo__idEnca__5441852A");

            entity.HasOne(d => d.IdReceptorNavigation).WithMany(p => p.Prestamos)
                .HasForeignKey(d => d.IdReceptor)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Prestamo__idRece__534D60F1");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__Usuario__645723A6BB04B77F");

            entity.ToTable("Usuario");

            entity.Property(e => e.IdUsuario)
                .ValueGeneratedNever()
                .HasColumnName("idUsuario");
            entity.Property(e => e.Contrasenia).HasColumnName("contrasenia");
            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.IdCarrera).HasColumnName("idCarrera");
            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombreUsuario");
            entity.Property(e => e.Rol)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("rol");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("telefono");

            entity.HasOne(d => d.IdCarreraNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdCarrera)
                .HasConstraintName("FK__Usuario__idCarre__4E88ABD4");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

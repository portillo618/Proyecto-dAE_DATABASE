using System;
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

    public virtual DbSet<EncargadoBodega> EncargadoBodegas { get; set; }

    public virtual DbSet<Escuela> Escuelas { get; set; }

    public virtual DbSet<Implemento> Implementos { get; set; }

    public virtual DbSet<Prestamo> Prestamos { get; set; }

    public virtual DbSet<Razone> Razones { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=OSW\\SQLEXPRESS;Database=Bodega;Trusted_Connection=True;encrypt=False;Connection Timeout=60;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Carrera>(entity =>
        {
            entity.HasKey(e => e.IdCarrera).HasName("PK__Carrera__7B19E7913BC89179");

            entity.ToTable("Carrera");

            entity.Property(e => e.IdCarrera).HasColumnName("idCarrera");
            entity.Property(e => e.IdEscuela).HasColumnName("idEscuela");
            entity.Property(e => e.NombreCarrera)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombreCarrera");

            entity.HasOne(d => d.IdEscuelaNavigation).WithMany(p => p.Carreras)
                .HasForeignKey(d => d.IdEscuela)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Carrera__idEscue__4AB81AF0");
        });

        modelBuilder.Entity<DeBaja>(entity =>
        {
            entity.HasKey(e => e.IdDeBaja).HasName("PK__DeBaja__CDE025B0E605F38F");

            entity.ToTable("DeBaja");

            entity.Property(e => e.IdDeBaja).HasColumnName("idDeBaja");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.Estado)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.FechaDeBaja).HasColumnName("fechaDeBaja");
            entity.Property(e => e.IdImplemento).HasColumnName("idImplemento");
            entity.Property(e => e.IdRazon).HasColumnName("idRazon");
            entity.Property(e => e.IdUsuarioResponsable).HasColumnName("idUsuarioResponsable");

            entity.HasOne(d => d.IdImplementoNavigation).WithMany(p => p.DeBajas)
                .HasForeignKey(d => d.IdImplemento)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__DeBaja__idImplem__534D60F1");

            entity.HasOne(d => d.IdRazonNavigation).WithMany(p => p.DeBajas)
                .HasForeignKey(d => d.IdRazon)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK__DeBaja__idRazon__5441852A");

            entity.HasOne(d => d.IdUsuarioResponsableNavigation).WithMany(p => p.DeBajas)
                .HasForeignKey(d => d.IdUsuarioResponsable)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK__DeBaja__idUsuari__52593CB8");
        });

        modelBuilder.Entity<Deporte>(entity =>
        {
            entity.HasKey(e => e.IdDeporte).HasName("PK__Deporte__51D36C59141118D5");

            entity.ToTable("Deporte");

            entity.Property(e => e.IdDeporte).HasColumnName("idDeporte");
            entity.Property(e => e.NombreDeporte)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nombreDeporte");
        });

        modelBuilder.Entity<DetallePrestamo>(entity =>
        {
            entity.HasKey(e => e.IdDetallePrestamo).HasName("PK__DetalleP__5D283E2E4472FB76");

            entity.ToTable("DetallePrestamo");

            entity.Property(e => e.IdDetallePrestamo).HasColumnName("idDetallePrestamo");
            entity.Property(e => e.CantidadPrestada).HasColumnName("cantidadPrestada");
            entity.Property(e => e.Especificacion)
                .HasColumnType("text")
                .HasColumnName("especificacion");
            entity.Property(e => e.Estado)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.IdImplemento).HasColumnName("idImplemento");
            entity.Property(e => e.IdPrestamo).HasColumnName("idPrestamo");

            entity.HasOne(d => d.IdImplementoNavigation).WithMany(p => p.DetallePrestamos)
                .HasForeignKey(d => d.IdImplemento)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK__DetallePr__idImp__5165187F");

            entity.HasOne(d => d.IdPrestamoNavigation).WithMany(p => p.DetallePrestamos)
                .HasForeignKey(d => d.IdPrestamo)
                .HasConstraintName("FK__DetallePr__idPre__5070F446");
        });

        modelBuilder.Entity<EncargadoBodega>(entity =>
        {
            entity.HasKey(e => e.IdEncargado).HasName("PK__Encargad__579D6A01BF29C51E");

            entity.ToTable("EncargadoBodega");

            entity.Property(e => e.IdEncargado).HasColumnName("idEncargado");
            entity.Property(e => e.NombreEncargado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombreEncargado");
        });

        modelBuilder.Entity<Escuela>(entity =>
        {
            entity.HasKey(e => e.IdEscuela).HasName("PK__Escuela__9F67B289C8CE73C9");

            entity.ToTable("Escuela");

            entity.Property(e => e.IdEscuela).HasColumnName("idEscuela");
            entity.Property(e => e.NombreEscuela)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombreEscuela");
        });

        modelBuilder.Entity<Implemento>(entity =>
        {
            entity.HasKey(e => e.IdImplemento).HasName("PK__Implemen__7C6043649650F06D");

            entity.ToTable("Implemento");

            entity.Property(e => e.IdImplemento).HasColumnName("idImplemento");
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
                .HasConstraintName("FK__Implement__idDep__4F7CD00D");
        });

        modelBuilder.Entity<Prestamo>(entity =>
        {
            entity.HasKey(e => e.IdPrestamo).HasName("PK__Prestamo__A4876C13F3177F21");

            entity.ToTable("Prestamo");

            entity.Property(e => e.IdPrestamo).HasColumnName("idPrestamo");
            entity.Property(e => e.FechaDevolucion).HasColumnName("fechaDevolucion");
            entity.Property(e => e.FechaPrestamo).HasColumnName("fechaPrestamo");
            entity.Property(e => e.IdEncargadoPrestamo).HasColumnName("idEncargadoPrestamo");
            entity.Property(e => e.IdReceptor).HasColumnName("idReceptor");

            entity.HasOne(d => d.IdEncargadoPrestamoNavigation).WithMany(p => p.Prestamos)
                .HasForeignKey(d => d.IdEncargadoPrestamo)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK__Prestamo__idEnca__4E88ABD4");

            entity.HasOne(d => d.IdReceptorNavigation).WithMany(p => p.Prestamos)
                .HasForeignKey(d => d.IdReceptor)
                .HasConstraintName("FK__Prestamo__idRece__4D94879B");
        });

        modelBuilder.Entity<Razone>(entity =>
        {
            entity.HasKey(e => e.IdRazon).HasName("PK__Razones__690E73298FC478F2");

            entity.Property(e => e.IdRazon).HasColumnName("idRazon");
            entity.Property(e => e.NombreRazon)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombreRazon");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.IdRol).HasName("PK__Roles__3C872F76628C1019");

            entity.Property(e => e.IdRol).HasColumnName("idRol");
            entity.Property(e => e.NombreRol)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombreRol");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__Usuario__645723A651EBB9E1");

            entity.ToTable("Usuario");

            entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");
            entity.Property(e => e.CarneBiblioteca).HasColumnName("carneBiblioteca");
            entity.Property(e => e.Contrasenia)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("contrasenia");
            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.IdCarrera).HasColumnName("idCarrera");
            entity.Property(e => e.IdRol).HasColumnName("idRol");
            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombreUsuario");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("telefono");

            entity.HasOne(d => d.IdCarreraNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdCarrera)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Usuario__idCarre__4BAC3F29");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdRol)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Usuario__idRol__4CA06362");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

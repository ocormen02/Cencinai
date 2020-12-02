using Cencinai.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Cencinai.Data
{
    public partial class CencinaiContext : DbContext
    {
        public CencinaiContext()
        {
        }

        public CencinaiContext(DbContextOptions<CencinaiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AreasDesarrollo> AreasDesarrollo { get; set; }
        public virtual DbSet<EstadoNutricional> EstadoNutricional { get; set; }
        public virtual DbSet<Canton> Canton { get; set; }
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Distrito> Distrito { get; set; }
        public virtual DbSet<Niño> Niño { get; set; }
        public virtual DbSet<Provincia> Provincia { get; set; }
        public virtual DbSet<Responsable> Responsable { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AreasDesarrollo>(entity =>
            {
                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.HasOne(d => d.Niño)
                    .WithMany(p => p.AreasDesarrollo)
                    .HasForeignKey(d => d.NiñoId)
                    .HasConstraintName("FK_AreasDesarrollo_Niño");
            });

            modelBuilder.Entity<Canton>(entity =>
            {
                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Provincia)
                    .WithMany(p => p.Canton)
                    .HasForeignKey(d => d.ProvinciaId)
                    .HasConstraintName("FK_Canton_Provincia");
            });

            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.Property(e => e.Abreviatura)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Distrito>(entity =>
            {
                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Canton)
                    .WithMany(p => p.Distrito)
                    .HasForeignKey(d => d.CantonId)
                    .HasConstraintName("FK_Distrito_Canton");
            });

            modelBuilder.Entity<Niño>(entity =>
            {
                entity.Property(e => e.FechaNacimiento).HasColumnType("date");

                entity.Property(e => e.InformacionAdicional).IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrimerApellido)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SegundoApellido)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Categoria)
                    .WithMany(p => p.Niño)
                    .HasForeignKey(d => d.CategoriaId)
                    .HasConstraintName("FK_Niño_Categoria");

                entity.HasOne(d => d.Responsable)
                    .WithMany(p => p.Niño)
                    .HasForeignKey(d => d.ResponsableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Niño_Responsable");
            });

            modelBuilder.Entity<EstadoNutricional>(entity =>
            {
                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.HasOne(d => d.Niño)
                    .WithMany(p => p.EstadoNutricional)
                    .HasForeignKey(d => d.NiñoId)
                    .HasConstraintName("FK_EstadoNutricional_Niño");
            });

            modelBuilder.Entity<Provincia>(entity =>
            {
                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Responsable>(entity =>
            {
                entity.Property(e => e.DireccionExacta)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrimerApellido)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SegundoApellido)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoAdicional)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Distrito)
                    .WithMany(p => p.Responsable)
                    .HasForeignKey(d => d.DistritoId)
                    .HasConstraintName("FK_Responsable_Distrito");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.Property(e => e.Contraseña)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NombreUsuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

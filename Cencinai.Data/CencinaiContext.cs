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
        public virtual DbSet<Canton> Canton { get; set; }
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Distrito> Distrito { get; set; }
        public virtual DbSet<IndiceMasaCorporal> IndiceMasaCorporal { get; set; }
        public virtual DbSet<Niño> Niño { get; set; }
        public virtual DbSet<PesoEdad> PesoEdad { get; set; }
        public virtual DbSet<PesoTalla> PesoTalla { get; set; }
        public virtual DbSet<Provincia> Provincia { get; set; }
        public virtual DbSet<PuntuacionAreaDesarrollo> PuntuacionAreaDesarrollo { get; set; }
        public virtual DbSet<Responsable> Responsable { get; set; }
        public virtual DbSet<TallaEdad> TallaEdad { get; set; }
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

            modelBuilder.Entity<IndiceMasaCorporal>(entity =>
            {
                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.HasOne(d => d.Niño)
                    .WithMany(p => p.IndiceMasaCorporal)
                    .HasForeignKey(d => d.NiñoId)
                    .HasConstraintName("FK_IndiceMasaCorporal_Niño");
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

            modelBuilder.Entity<PesoEdad>(entity =>
            {
                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.HasOne(d => d.Niño)
                    .WithMany(p => p.PesoEdad)
                    .HasForeignKey(d => d.NiñoId)
                    .HasConstraintName("FK_PesoEdad_Niño");
            });

            modelBuilder.Entity<PesoTalla>(entity =>
            {
                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.HasOne(d => d.Niño)
                    .WithMany(p => p.PesoTalla)
                    .HasForeignKey(d => d.NiñoId)
                    .HasConstraintName("FK_PesoTalla_Niño");
            });

            modelBuilder.Entity<Provincia>(entity =>
            {
                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PuntuacionAreaDesarrollo>(entity =>
            {
                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.HasOne(d => d.Niño)
                    .WithMany(p => p.PuntuacionAreaDesarrollo)
                    .HasForeignKey(d => d.NiñoId)
                    .HasConstraintName("FK_PuntuacionAreaDesarrollo_Niño");
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

            modelBuilder.Entity<TallaEdad>(entity =>
            {
                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.HasOne(d => d.Niño)
                    .WithMany(p => p.TallaEdad)
                    .HasForeignKey(d => d.NiñoId)
                    .HasConstraintName("FK_TallaEdad_Niño");
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

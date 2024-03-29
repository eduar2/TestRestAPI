﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DataAccess.Models
{
    public partial class TestDBContext : DbContext
    {
        public TestDBContext()
        {
        }

        public TestDBContext(DbContextOptions<TestDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Cuenta> Cuentas { get; set; }
        public virtual DbSet<EstadoCuentum> EstadoCuenta { get; set; }
        public virtual DbSet<Movimiento> Movimientos { get; set; }
        public virtual DbSet<Persona> Personas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.Property(e => e.Contrasena)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Identificacion)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdentificacionNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.Identificacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Clientes_Personas");
            });

            modelBuilder.Entity<Cuenta>(entity =>
            {
                entity.HasKey(e => e.NumeroCuenta)
                    .HasName("PK_Cuentas_1");

                entity.Property(e => e.NumeroCuenta)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SaldoDisponible).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.SaldoInicial).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Cuenta)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cuentas_Clientes");
            });

            modelBuilder.Entity<EstadoCuentum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EstadoCuenta");

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Identificacion)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroCuenta)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SaldoDisponible).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.SaldoInicial).HasColumnType("decimal(11, 2)");

                entity.Property(e => e.Valor).HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<Movimiento>(entity =>
            {
                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.NumeroCuenta)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Saldo).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Valor).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.NumeroCuentaNavigation)
                    .WithMany(p => p.Movimientos)
                    .HasForeignKey(d => d.NumeroCuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Movimientos_Cuentas");
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.HasKey(e => e.Identificacion);

                entity.Property(e => e.Identificacion)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FechaNacimiento).HasColumnType("date");

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(13)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

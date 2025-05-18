using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using InventarioPED.Models;

namespace InventarioPED.Data
{
    internal class InventarioDBContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Envio> Envios { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Prioridad> Prioridades { get; set; }

        private readonly string conexion = Properties.Settings.Default.Connection;
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(conexion);
        }
        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.Property(p => p.FechaCreacion)
                      .HasColumnType("date");  // <-- aquí que sea solo date en la DB
            });

            modelBuilder.Entity<Producto>().HasData(
                new Producto
                {
                    Id = "PROD20251",
                    Nombre = "Computaddora",
                    Descripcion = "Computadora para el uso diario",
                    Precio = 150.2m,
                    Cantidad = 20,
                    Categoria = "Tecnologia",
                    Proveedor = "Mamam",
                    FechaCreacion  = new DateTime(2025, 1, 1)
                },
                new Producto
                {
                    Id = "PROD20252",
                    Nombre = "UPS FORZA",
                    Descripcion = "Ups forza",
                    Precio = 120.0m,
                    Cantidad = 10,
                    Categoria = "Tecnologia",
                    Proveedor = "Nnasd",
                    FechaCreacion = new DateTime(2025, 1, 1)
                }
            ); ;

            modelBuilder.Entity<Estado>().HasData(
                new Estado
                {
                    Id = 1,
                    Nombre = "Pendiente"
                },
                new Estado
                {
                    Id = 2,
                    Nombre = "En Proceso"
                },
                new Estado
                {
                    Id = 3,
                    Nombre = "Completado"
                }
            );

            modelBuilder.Entity<Prioridad>().HasData(
                new Prioridad
                {
                    Id = 1,
                    Nombre = "Alta"
                },
                new Prioridad
                {
                    Id = 2,
                    Nombre = "Media"
                },
                new Prioridad
                {
                    Id = 3,
                    Nombre = "Baja"
                }
            );
        }
        private void AsignarValoresPersonalizados()
        {
            var nuevosProductos = ChangeTracker.Entries<Producto>()
                .Where(e => e.State == EntityState.Added)
                .Select(e => e.Entity);

            foreach (var producto in nuevosProductos)
            {
                if (producto.FechaCreacion == default)
                    producto.FechaCreacion = DateTime.Now;
            }
        }

    }
}

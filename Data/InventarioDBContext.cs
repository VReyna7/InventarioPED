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
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }


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
                    CategoriaId = 1,
                    ProveedorId = 2,
                    FechaCreacion  = new DateTime(2025, 1, 1)
                },
                new Producto
                {
                    Id = "PROD20252",
                    Nombre = "UPS FORZA",
                    Descripcion = "Ups forza",
                    Precio = 120.0m,
                    Cantidad = 10,
                    CategoriaId = 1,
                    ProveedorId = 2,
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

            modelBuilder.Entity<Categoria>().HasData(
               new Categoria
               {
                   Id = 1,
                   Nombre = "Computadoras y Laptops"
               },
               new Categoria
               {
                   Id = 2,
                   Nombre = "Periféricos"
               },
               new Categoria
               {
                   Id = 3,
                   Nombre = "Monitores y Pantallas"
               },
               new Categoria
               {
                   Id = 4,
                   Nombre = "Almacenamiento"
               },
               new Categoria
               {
                   Id = 5,
                   Nombre = "Conectividad"
               },
               new Categoria
               {
                   Id = 6,
                   Nombre = "Impresoras"
               },
               new Categoria
               { 
                   Id = 7, 
                   Nombre = "Monitores"
               }

           );

            modelBuilder.Entity<Proveedor>().HasData(

                new Proveedor { Id = 1, Nombre = "TechGlobal S.A." },
                new Proveedor { Id = 2, Nombre = "InnovaTech Solutions" },
                new Proveedor { Id = 3, Nombre = "Hardware Express" },
                new Proveedor { Id = 4, Nombre = "CompuCentro Mayorista" },
                new Proveedor { Id = 5, Nombre = "RedNet Distribuciones" },
                new Proveedor { Id = 6, Nombre = "Digital Zone Ltd." },
                new Proveedor { Id = 7, Nombre = "PeriTech MX" },
                new Proveedor { Id = 8, Nombre = "SmartComponentes" },
                new Proveedor { Id = 9, Nombre = "SoftWareHouse Corp." },
                new Proveedor { Id = 10, Nombre = "GamingPro Distribuciones" }

            );

            modelBuilder.Entity<Envio>().HasData(
                new Envio
                {
                    Id = "ENV20251",
                    Nombre = "Juan Pérez",
                    Direccion = "Av. Reforma 123, Ciudad de México",
                    Peso = 2.5f,
                    EstadoId = 2,       // En Proceso
                    PrioridadId = 1     // Alta
                },
                new Envio
                {
                    Id = "ENV20252",
                    Nombre = "María López",
                    Direccion = "Calle Juárez 456, Guadalajara",
                    Peso = 1.2f,
                    EstadoId = 3,       // Completado
                    PrioridadId = 2     // Media
                },
                new Envio
                {
                    Id = "ENV20253",
                    Nombre = "Carlos García",
                    Direccion = "Blvd. Independencia 789, Monterrey",
                    Peso = 3.7f,
                    EstadoId = 1,       // Pendiente
                    PrioridadId = 3     // Baja
                }
            );
        }
    }
}

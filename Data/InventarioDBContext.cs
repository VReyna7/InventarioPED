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

        string conexion = Properties.Settings.Default.Connection;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(conexion);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Producto>().HasData(
                new Producto
                {
                    Id = 1,
                    Nombre = "Computaddora",
                    Descripcion = "Computadora para el uso diario",
                    Precio = 150.00f,
                    Cantidad = 20,
                    Categoria = "Tecnologia",
                    Proveedor = "Mamam",
                    FechaCreacion = DateTime.Now.ToString("2025-08-05")
                },
                new Producto
                {
                    Id = 2,
                    Nombre = "UPS FORZA",
                    Descripcion = "Ups forza",
                    Precio = 120.0f,
                    Cantidad = 10,
                    Categoria = "Tecnologia",
                    Proveedor = "Nnasd",
                    FechaCreacion = DateTime.Now.ToString("2026-05-01")
                }
            );

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
    }
}

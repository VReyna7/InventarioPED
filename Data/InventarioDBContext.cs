using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using InventarioPED.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

            modelBuilder.Entity<Envio>(entity =>
            {
                entity.Property(e => e.CreatedAt)
                      .HasColumnType("datetime2")
                      .HasDefaultValueSql("GETDATE()");
            });
            modelBuilder.Entity<Producto>().HasData(
                new Producto { Id = "PROD20251", Nombre = "Computadora", Descripcion = "Computadora para el uso diario", Precio = 150.2m, Cantidad = 20, CategoriaId = 1, ProveedorId = 2, FechaCreacion = new DateTime(2025, 1, 1) },
                new Producto { Id = "PROD20252", Nombre = "UPS FORZA", Descripcion = "UPS Forza 1000VA", Precio = 120.0m, Cantidad = 10, CategoriaId = 1, ProveedorId = 2, FechaCreacion = new DateTime(2025, 1, 1) },
                new Producto { Id = "PROD20253", Nombre = "Mouse Gamer", Descripcion = "Mouse óptico con RGB", Precio = 25.5m, Cantidad = 50, CategoriaId = 2, ProveedorId = 1, FechaCreacion = new DateTime(2025, 2, 1) },
                new Producto { Id = "PROD20254", Nombre = "Teclado Mecánico", Descripcion = "Teclado retroiluminado", Precio = 60.0m, Cantidad = 30, CategoriaId = 2, ProveedorId = 1, FechaCreacion = new DateTime(2025, 2, 1) },
                new Producto { Id = "PROD20255", Nombre = "Monitor 24\"", Descripcion = "Monitor Full HD", Precio = 200.0m, Cantidad = 15, CategoriaId = 1, ProveedorId = 3, FechaCreacion = new DateTime(2025, 3, 1) },
                new Producto { Id = "PROD20256", Nombre = "Router WiFi", Descripcion = "Router doble banda", Precio = 80.0m, Cantidad = 25, CategoriaId = 3, ProveedorId = 2, FechaCreacion = new DateTime(2025, 1, 10) },
                new Producto { Id = "PROD20257", Nombre = "Disco SSD 512GB", Descripcion = "Unidad de estado sólido", Precio = 95.0m, Cantidad = 40, CategoriaId = 4, ProveedorId = 1, FechaCreacion = new DateTime(2025, 4, 1) },
                new Producto { Id = "PROD20258", Nombre = "Laptop i5", Descripcion = "Laptop de gama media", Precio = 600.0m, Cantidad = 12, CategoriaId = 1, ProveedorId = 3, FechaCreacion = new DateTime(2025, 2, 15) },
                new Producto { Id = "PROD20259", Nombre = "Bocinas Bluetooth", Descripcion = "Bocinas portátiles", Precio = 45.0m, Cantidad = 35, CategoriaId = 5, ProveedorId = 2, FechaCreacion = new DateTime(2025, 3, 10) },
                new Producto { Id = "PROD20260", Nombre = "Cable HDMI", Descripcion = "Cable HDMI 2 metros", Precio = 10.0m, Cantidad = 100, CategoriaId = 6, ProveedorId = 1, FechaCreacion = new DateTime(2025, 1, 20) },
                new Producto { Id = "PROD20261", Nombre = "Memoria RAM 16GB", Descripcion = "DDR4 3200MHz", Precio = 85.0m, Cantidad = 25, CategoriaId = 4, ProveedorId = 3, FechaCreacion = new DateTime(2025, 3, 15) },
                new Producto { Id = "PROD20262", Nombre = "Tarjeta Gráfica RTX 3060", Descripcion = "6GB GDDR6", Precio = 350.0m, Cantidad = 8, CategoriaId = 4, ProveedorId = 2, FechaCreacion = new DateTime(2025, 4, 5) },
                new Producto { Id = "PROD20263", Nombre = "Gabinete ATX", Descripcion = "Con ventiladores RGB", Precio = 70.0m, Cantidad = 18, CategoriaId = 7, ProveedorId = 1, FechaCreacion = new DateTime(2025, 1, 30) },
                new Producto { Id = "PROD20264", Nombre = "Fuente 600W", Descripcion = "Certificación 80 Plus", Precio = 60.0m, Cantidad = 22, CategoriaId = 7, ProveedorId = 2, FechaCreacion = new DateTime(2025, 2, 8) },
                new Producto { Id = "PROD20265", Nombre = "Webcam HD", Descripcion = "Cámara 1080p", Precio = 40.0m, Cantidad = 45, CategoriaId = 5, ProveedorId = 3, FechaCreacion = new DateTime(2025, 3, 20) },
                new Producto { Id = "PROD20266", Nombre = "Headset Gamer", Descripcion = "Con micrófono incluido", Precio = 55.0m, Cantidad = 27, CategoriaId = 5, ProveedorId = 1, FechaCreacion = new DateTime(2025, 3, 25) },
                new Producto { Id = "PROD20267", Nombre = "Tablet 10\"", Descripcion = "Sistema Android", Precio = 180.0m, Cantidad = 16, CategoriaId = 8, ProveedorId = 3, FechaCreacion = new DateTime(2025, 4, 10) },
                new Producto { Id = "PROD20268", Nombre = "Cargador USB-C", Descripcion = "Carga rápida", Precio = 18.0m, Cantidad = 60, CategoriaId = 6, ProveedorId = 2, FechaCreacion = new DateTime(2025, 2, 20) },
                new Producto { Id = "PROD20269", Nombre = "Adaptador HDMI-VGA", Descripcion = "Convertidor", Precio = 12.0m, Cantidad = 40, CategoriaId = 6, ProveedorId = 1, FechaCreacion = new DateTime(2025, 3, 1) },
                new Producto { Id = "PROD20270", Nombre = "Switch Ethernet", Descripcion = "8 puertos", Precio = 30.0m, Cantidad = 13, CategoriaId = 3, ProveedorId = 3, FechaCreacion = new DateTime(2025, 2, 28) },
                new Producto { Id = "PROD20271", Nombre = "Impresora Láser", Descripcion = "Impresora monocromática", Precio = 150.0m, Cantidad = 11, CategoriaId = 9, ProveedorId = 2, FechaCreacion = new DateTime(2025, 3, 15) },
                new Producto { Id = "PROD20272", Nombre = "Scanner", Descripcion = "Escáner plano A4", Precio = 90.0m, Cantidad = 14, CategoriaId = 9, ProveedorId = 1, FechaCreacion = new DateTime(2025, 3, 18) },
                new Producto { Id = "PROD20273", Nombre = "Smartwatch", Descripcion = "Monitor de salud", Precio = 130.0m, Cantidad = 19, CategoriaId = 8, ProveedorId = 2, FechaCreacion = new DateTime(2025, 4, 12) },
                new Producto { Id = "PROD20274", Nombre = "Base para Laptop", Descripcion = "Con ventilación", Precio = 22.0m, Cantidad = 30, CategoriaId = 6, ProveedorId = 3, FechaCreacion = new DateTime(2025, 2, 5) },
                new Producto { Id = "PROD20275", Nombre = "Mouse Pad XL", Descripcion = "Superficie extendida", Precio = 15.0m, Cantidad = 55, CategoriaId = 6, ProveedorId = 1, FechaCreacion = new DateTime(2025, 1, 25) }
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
               },
               new Categoria
               {
                   Id = 8,
                   Nombre = "Audio y Video"
               },
               new Categoria
               {
                   Id = 9,
                   Nombre = "Tablets y Relojes"
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
                new Envio { Id = "ENV20251", Nombre = "Juan Pérez", Direccion = "Av. Reforma 123, Ciudad de México", Peso = 2.5f, EstadoId = 2, PrioridadId = 1 },
                new Envio { Id = "ENV20252", Nombre = "María López", Direccion = "Calle Juárez 456, Guadalajara", Peso = 1.2f, EstadoId = 3, PrioridadId = 2 },
                new Envio { Id = "ENV20253", Nombre = "Carlos García", Direccion = "Blvd. Independencia 789, Monterrey", Peso = 3.7f, EstadoId = 1, PrioridadId = 3 },
                new Envio { Id = "ENV20254", Nombre = "Ana Torres", Direccion = "Av. Universidad 321, Puebla", Peso = 1.9f, EstadoId = 1, PrioridadId = 2 },
                new Envio { Id = "ENV20255", Nombre = "Luis Fernández", Direccion = "Calle Morelos 654, Mérida", Peso = 2.2f, EstadoId = 2, PrioridadId = 1 },
                new Envio { Id = "ENV20256", Nombre = "Diana Gómez", Direccion = "Av. Insurgentes 789, CDMX", Peso = 0.9f, EstadoId = 3, PrioridadId = 3 },
                new Envio { Id = "ENV20257", Nombre = "Pedro Ruiz", Direccion = "Calle Hidalgo 321, Querétaro", Peso = 2.7f, EstadoId = 2, PrioridadId = 1 },
                new Envio { Id = "ENV20258", Nombre = "Elena Ríos", Direccion = "Camino Real 456, Toluca", Peso = 1.5f, EstadoId = 1, PrioridadId = 2 },
                new Envio { Id = "ENV20259", Nombre = "Jorge Martínez", Direccion = "Av. Central 123, León", Peso = 3.3f, EstadoId = 3, PrioridadId = 1 },
                new Envio { Id = "ENV20260", Nombre = "Isabel Navarro", Direccion = "Calle Colón 234, Aguascalientes", Peso = 2.0f, EstadoId = 1, PrioridadId = 3 },
                new Envio { Id = "ENV20261", Nombre = "Mario Sosa", Direccion = "Av. del Trabajo 789, Tijuana", Peso = 3.1f, EstadoId = 2, PrioridadId = 2 },
                new Envio { Id = "ENV20262", Nombre = "Lucía Vázquez", Direccion = "Calle Libertad 654, Hermosillo", Peso = 1.8f, EstadoId = 3, PrioridadId = 2 },
                new Envio { Id = "ENV20263", Nombre = "Raúl Mendoza", Direccion = "Av. de las Torres 321, Oaxaca", Peso = 2.9f, EstadoId = 1, PrioridadId = 1 },
                new Envio { Id = "ENV20264", Nombre = "Rosa Jiménez", Direccion = "Calle Reforma 987, Morelia", Peso = 2.4f, EstadoId = 2, PrioridadId = 3 },
                new Envio { Id = "ENV20265", Nombre = "Héctor Silva", Direccion = "Av. Chapultepec 543, CDMX", Peso = 1.3f, EstadoId = 3, PrioridadId = 2 },
                new Envio { Id = "ENV20266", Nombre = "Valeria Cano", Direccion = "Calle Benito Juárez 654, Saltillo", Peso = 2.6f, EstadoId = 1, PrioridadId = 1 },
                new Envio { Id = "ENV20267", Nombre = "Gerardo Salas", Direccion = "Blvd. Las Américas 432, Cancún", Peso = 3.8f, EstadoId = 2, PrioridadId = 2 },
                new Envio { Id = "ENV20268", Nombre = "Andrea Mejía", Direccion = "Av. Constituyentes 111, Zacatecas", Peso = 1.1f, EstadoId = 3, PrioridadId = 3 },
                new Envio { Id = "ENV20269", Nombre = "Eduardo Herrera", Direccion = "Calle Independencia 321, Tepic", Peso = 2.0f, EstadoId = 2, PrioridadId = 1 },
                new Envio { Id = "ENV20270", Nombre = "Patricia Díaz", Direccion = "Av. Hidalgo 999, San Luis Potosí", Peso = 3.5f, EstadoId = 3, PrioridadId = 2 },
                new Envio { Id = "ENV20271", Nombre = "Ignacio Cruz", Direccion = "Calle Oaxaca 654, Chiapas", Peso = 1.6f, EstadoId = 1, PrioridadId = 1 },
                new Envio { Id = "ENV20272", Nombre = "Alejandra Flores", Direccion = "Av. Paseo del Sol 432, Colima", Peso = 2.1f, EstadoId = 2, PrioridadId = 3 },
                new Envio { Id = "ENV20273", Nombre = "Tomás Aguirre", Direccion = "Calle Palma 231, Acapulco", Peso = 3.0f, EstadoId = 3, PrioridadId = 2 },
                new Envio { Id = "ENV20274", Nombre = "Camila Paredes", Direccion = "Av. México 101, CDMX", Peso = 1.4f, EstadoId = 1, PrioridadId = 2 },
                new Envio { Id = "ENV20275", Nombre = "Sebastián Lara", Direccion = "Calle Luna 888, Celaya", Peso = 2.3f, EstadoId = 2, PrioridadId = 1 }
            );
        }
    }
}

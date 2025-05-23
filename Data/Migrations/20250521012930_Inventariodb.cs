﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InventarioPED.Data.Migrations
{
    /// <inheritdoc />
    public partial class Inventariodb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Prioridades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prioridades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Proveedores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false),
                    ProveedorId = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Productos_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Productos_Proveedores_ProveedorId",
                        column: x => x.ProveedorId,
                        principalTable: "Proveedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Envios",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Peso = table.Column<float>(type: "real", nullable: false),
                    EstadoId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    PrioridadId = table.Column<int>(type: "int", nullable: false),
                    ProductoId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Envios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Envios_Estados_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Envios_Prioridades_PrioridadId",
                        column: x => x.PrioridadId,
                        principalTable: "Prioridades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Envios_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "Computadoras y Laptops" },
                    { 2, "Periféricos" },
                    { 3, "Monitores y Pantallas" },
                    { 4, "Almacenamiento" },
                    { 5, "Conectividad" },
                    { 6, "Impresoras" },
                    { 7, "Monitores" },
                    { 8, "Audio y Video" },
                    { 9, "Tablets y Relojes" }
                });

            migrationBuilder.InsertData(
                table: "Estados",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "Pendiente" },
                    { 2, "En Proceso" },
                    { 3, "Completado" }
                });

            migrationBuilder.InsertData(
                table: "Prioridades",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "Alta" },
                    { 2, "Media" },
                    { 3, "Baja" }
                });

            migrationBuilder.InsertData(
                table: "Proveedores",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "TechGlobal S.A." },
                    { 2, "InnovaTech Solutions" },
                    { 3, "Hardware Express" },
                    { 4, "CompuCentro Mayorista" },
                    { 5, "RedNet Distribuciones" },
                    { 6, "Digital Zone Ltd." },
                    { 7, "PeriTech MX" },
                    { 8, "SmartComponentes" },
                    { 9, "SoftWareHouse Corp." },
                    { 10, "GamingPro Distribuciones" }
                });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "Id", "Cantidad", "CategoriaId", "Descripcion", "FechaCreacion", "Nombre", "Precio", "ProveedorId" },
                values: new object[,]
                {
                    { "PROD20251", 20, 1, "Computadora para el uso diario", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Computadora", 150.2m, 2 },
                    { "PROD202510", 100, 6, "Cable HDMI 2 metros", new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cable HDMI", 10.0m, 1 },
                    { "PROD202511", 25, 4, "DDR4 3200MHz", new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Memoria RAM 16GB", 85.0m, 3 },
                    { "PROD202512", 8, 4, "6GB GDDR6", new DateTime(2025, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tarjeta Gráfica RTX 3060", 350.0m, 2 },
                    { "PROD202513", 18, 7, "Con ventiladores RGB", new DateTime(2025, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gabinete ATX", 70.0m, 1 },
                    { "PROD202514", 22, 7, "Certificación 80 Plus", new DateTime(2025, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fuente 600W", 60.0m, 2 },
                    { "PROD202515", 45, 5, "Cámara 1080p", new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam HD", 40.0m, 3 },
                    { "PROD202516", 27, 5, "Con micrófono incluido", new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Headset Gamer", 55.0m, 1 },
                    { "PROD202517", 16, 8, "Sistema Android", new DateTime(2025, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tablet 10\"", 180.0m, 3 },
                    { "PROD202518", 60, 6, "Carga rápida", new DateTime(2025, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cargador USB-C", 18.0m, 2 },
                    { "PROD202519", 40, 6, "Convertidor", new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adaptador HDMI-VGA", 12.0m, 1 },
                    { "PROD20252", 10, 1, "UPS Forza 1000VA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UPS FORZA", 120.0m, 2 },
                    { "PROD202520", 13, 3, "8 puertos", new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Switch Ethernet", 30.0m, 3 },
                    { "PROD202521", 11, 9, "Impresora monocromática", new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Impresora Láser", 150.0m, 2 },
                    { "PROD202522", 14, 9, "Escáner plano A4", new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scanner", 90.0m, 1 },
                    { "PROD202523", 19, 8, "Monitor de salud", new DateTime(2025, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Smartwatch", 130.0m, 2 },
                    { "PROD202524", 30, 6, "Con ventilación", new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Base para Laptop", 22.0m, 3 },
                    { "PROD202525", 55, 6, "Superficie extendida", new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mouse Pad XL", 15.0m, 1 },
                    { "PROD20253", 50, 2, "Mouse óptico con RGB", new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mouse Gamer", 25.5m, 1 },
                    { "PROD20254", 30, 2, "Teclado retroiluminado", new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Teclado Mecánico", 60.0m, 1 },
                    { "PROD20255", 15, 1, "Monitor Full HD", new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Monitor 24\"", 200.0m, 3 },
                    { "PROD20256", 25, 3, "Router doble banda", new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Router WiFi", 80.0m, 2 },
                    { "PROD20257", 40, 4, "Unidad de estado sólido", new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Disco SSD 512GB", 95.0m, 1 },
                    { "PROD20258", 12, 1, "Laptop de gama media", new DateTime(2025, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laptop i5", 600.0m, 3 },
                    { "PROD20259", 35, 5, "Bocinas portátiles", new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bocinas Bluetooth", 45.0m, 2 }
                });

            migrationBuilder.InsertData(
                table: "Envios",
                columns: new[] { "Id", "Direccion", "EstadoId", "Nombre", "Peso", "PrioridadId", "ProductoId" },
                values: new object[,]
                {
                    { "ENV20251", "Av. Reforma 123, Ciudad de México", 2, "Juan Pérez", 2.5f, 1, "PROD20251" },
                    { "ENV20252", "Calle Juárez 456, Guadalajara", 3, "María López", 1.2f, 2, "PROD20252" },
                    { "ENV20253", "Blvd. Independencia 789, Monterrey", 1, "Carlos García", 3.7f, 3, "PROD20253" },
                    { "ENV20254", "Av. Universidad 321, Puebla", 1, "Ana Torres", 1.9f, 2, "PROD20254" },
                    { "ENV20255", "Calle Morelos 654, Mérida", 2, "Luis Fernández", 2.2f, 1, "PROD20255" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Envios_EstadoId",
                table: "Envios",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Envios_PrioridadId",
                table: "Envios",
                column: "PrioridadId");

            migrationBuilder.CreateIndex(
                name: "IX_Envios_ProductoId",
                table: "Envios",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_CategoriaId",
                table: "Productos",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_ProveedorId",
                table: "Productos",
                column: "ProveedorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Envios");

            migrationBuilder.DropTable(
                name: "Estados");

            migrationBuilder.DropTable(
                name: "Prioridades");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Proveedores");
        }
    }
}

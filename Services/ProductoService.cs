using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventarioPED.Data;
using InventarioPED.Models;
using InventarioPED.Utils;

namespace InventarioPED.Services
{
    internal class ProductoService
    {
        public async Task<string> AgregarProductoAsync(Producto producto)
        {
            using var context = new InventarioDBContext();

            if (string.IsNullOrWhiteSpace(producto.Nombre))
                return "El nombre es obligatorio.";

            if (string.IsNullOrWhiteSpace(producto.Categoria))
                return "La categoría es obligatoria.";

            producto.Id = IdGenerator.GenerarIdProducto(context);
            producto.FechaCreacion = DateTime.Now;

            context.Productos.Add(producto);
            await context.SaveChangesAsync();
            return "OK";
        }
    }
}

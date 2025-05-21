using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventarioPED.Data;
using InventarioPED.Models;
using InventarioPED.Utils;
using Microsoft.EntityFrameworkCore;

namespace InventarioPED.Services
{
    internal class EnvioService
    {
        public async Task<string> AgregarEnvioAsync(Envio envio)
        {
            using var context = new InventarioDBContext();

            // Generar el ID para el envío
            envio.Id = IdGenerator.GenerarEnvio(context);

            // Buscar el producto relacionado al envío
            var producto = await context.Productos.FirstOrDefaultAsync(p => p.Id == envio.ProductoId);

            if (producto == null)
                return "Producto no existe.";

            if (producto.Cantidad <= 0)
                return "No hay unidades disponibles de este producto.";

            // Restar 1 a la cantidad del producto
            producto.Cantidad -= 1;

            // Agregar el envío
            context.Envios.Add(envio);

            // Guardar cambios en la BD (envío + producto)
            await context.SaveChangesAsync();

            return "OK";
        }

        public List<Envio> ObtenerTodas()
        {
            using var context = new InventarioDBContext();
            return context.Envios.ToList();
        }
    }
}

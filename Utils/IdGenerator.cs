using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventarioPED.Data;

namespace InventarioPED.Utils
{
    internal class IdGenerator
    {
        public static string GenerarIdProducto(InventarioDBContext context)
        {
            int año = DateTime.Now.Year;
            string prefijo = $"PROD{año}";

            var ultimoId = context.Productos
                .Where(p => p.Id.StartsWith(prefijo))
                .OrderByDescending(p => p.Id)
                .Select(p => p.Id)
                .FirstOrDefault();

            int nuevoNumero = 1;

            if (!string.IsNullOrEmpty(ultimoId) && int.TryParse(ultimoId.Substring(prefijo.Length), out int ultimoNumero))
            {
                nuevoNumero = ultimoNumero + 1;
            }

            return $"{prefijo}{nuevoNumero}";
        }
    }
}

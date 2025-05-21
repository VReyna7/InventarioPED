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

            // Traemos todos los IDs que comienzan con el prefijo
            var ids = context.Productos
                .Where(p => p.Id.StartsWith(prefijo))
                .Select(p => p.Id)
                .ToList();

            int ultimoNumero = 0;

            foreach (var id in ids)
            {
                var numeroStr = id.Substring(prefijo.Length);

                if (int.TryParse(numeroStr, out int numero))
                {
                    if (numero > ultimoNumero)
                    {
                        ultimoNumero = numero;
                    }
                }
            }

            int nuevoNumero = ultimoNumero + 1;

            return $"{prefijo}{nuevoNumero}";
        }

        public static string GenerarEnvio(InventarioDBContext context)
        {
            int año = DateTime.Now.Year;
            string prefijo = $"ENV{año}";

            // Traemos todos los IDs que comienzan con el prefijo
            var ids = context.Envios
                .Where(p => p.Id.StartsWith(prefijo))
                .Select(p => p.Id)
                .ToList();

            int ultimoNumero = 0;

            foreach (var id in ids)
            {
                var numeroStr = id.Substring(prefijo.Length);

                if (int.TryParse(numeroStr, out int numero))
                {
                    if (numero > ultimoNumero)
                    {
                        ultimoNumero = numero;
                    }
                }
            }

            int nuevoNumero = ultimoNumero + 1;

            return $"{prefijo}{nuevoNumero}";
        }
    }
}

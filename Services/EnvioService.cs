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

            envio.Id = IdGenerator.GenerarEnvio(context);

            context.Envios.Add(envio);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventarioPED.Data;
using InventarioPED.Models;

namespace InventarioPED.Services
{
    internal class PrioridadService
    {
        private readonly InventarioDBContext _context;

        public PrioridadService()
        {
            _context = new InventarioDBContext();
        }

        public List<Prioridad> ObtenerTodas()
        {
            return _context.Prioridades.ToList();
        }
    }
}

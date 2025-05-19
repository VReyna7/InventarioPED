using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventarioPED.Data;
using InventarioPED.Models;
using Microsoft.EntityFrameworkCore;

namespace InventarioPED.Services
{
    internal class EstadoService
    {
        private readonly InventarioDBContext _context;
        public EstadoService()
        {
            _context = new InventarioDBContext();
        }

        public List<Estado> ObtenerTodas()
        {
            return _context.Estados.ToList();
        }
    }
}

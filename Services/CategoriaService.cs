using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventarioPED.Data;
using InventarioPED.Models;

namespace InventarioPED.Services
{
    internal class CategoriaService
    {
        private readonly InventarioDBContext _context;

        public CategoriaService()
        {
            _context = new InventarioDBContext();
        }

        public List<Categoria> ObtenerTodas()
        {
            return _context.Categorias.ToList();
        }

        public int ObtenerIdPorNombre(string nombre)
        {
            var categoria = _context.Categorias
                .FirstOrDefault(c => c.Nombre == nombre);
            return categoria?.Id ?? 0;
        }
    }
}

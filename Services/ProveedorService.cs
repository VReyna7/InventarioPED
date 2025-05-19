using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventarioPED.Data;
using InventarioPED.Models;

namespace InventarioPED.Services
{
    internal class ProveedorService
    {
        private readonly InventarioDBContext _context;

        public ProveedorService()
        {
            _context = new InventarioDBContext();
        }

        // Obtener todos los proveedores
        public List<Proveedor> ObtenerTodos()
        {
            return _context.Proveedores.ToList();
        }

        // Obtener proveedor por Id
        public Proveedor ObtenerPorId(int id)
        {
            return _context.Proveedores.FirstOrDefault(p => p.Id == id);
        }

        // Obtener proveedor por Nombre
        public Proveedor ObtenerPorNombre(string nombre)
        {
            return _context.Proveedores.FirstOrDefault(p => p.Nombre == nombre);
        }
    }
}

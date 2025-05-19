using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioPED.Models
{
    public class Proveedor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public List<Producto> Productos { get; set; } = new List<Producto>();
    }
}

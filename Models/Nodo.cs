using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioPED.Models
{
    class Nodo
    {
        public string Id { get; set; } // ID del producto
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public string Categoria { get; set; }
        public string Proveedor { get; set; }

        public Nodo Izquierdo { get; set; }
        public Nodo Derecho { get; set; }

        public Nodo(string id, string nombre, string descripcion, decimal precio, int cantidad, string categoria, string proveedor)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
            Cantidad = cantidad;
            Categoria = categoria;
            Proveedor = proveedor;
            Izquierdo = null;
            Derecho = null;
        }
    }
}

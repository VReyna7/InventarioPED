using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioPED.Models
{
    public class NodoEnvio
    {
        public string Id { get; set; } // ID del producto
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public float Peso { get; set; }
        public string Estado { get; set; }
        public string Prioridad { get; set; }

        public string IdProducto { get; set; }
        public DateTime CreadoEn { get; set; }
        public int NivelPrioridad =>
            Prioridad.Equals("Alta", StringComparison.OrdinalIgnoreCase) ? 1 :
            Prioridad.Equals("Media", StringComparison.OrdinalIgnoreCase) ? 2 : 3;

        public NodoEnvio Izquierdo { get; set; }
        public NodoEnvio Derecho { get; set; }

        public NodoEnvio(string id, string nombre, string direccion, float peso, string prioridad, string estado, DateTime creadoEn, string idProducto)
        {
            Id = id;
            Nombre = nombre;
            Direccion = direccion;
            Peso = peso;
            Prioridad = prioridad;
            Estado = estado;
            CreadoEn = creadoEn;
            IdProducto = idProducto;
        }
    }
}

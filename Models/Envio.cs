using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioPED.Models
{
    internal class Envio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public float Peso { get; set; }
        public Estado Estado { get; set; }
        public Prioridad Prioridad { get; set; }

    }
}

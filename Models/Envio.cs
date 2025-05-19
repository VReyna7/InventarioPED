using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioPED.Models
{
    public class Envio
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public float Peso { get; set; }
        public int EstadoId { get; set; }
        public Estado Estado { get; set; }

        public int PrioridadId { get; set; }
        public Prioridad Prioridad { get; set; }

    }
}

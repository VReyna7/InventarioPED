using InventarioPED.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioPED.Models
{
    public class ArbolBinarioEnvio
    {
        public NodoEnvio Raiz { get; set; }

        public void Insertar(NodoEnvio nuevo)
        {
            if (Raiz == null)
                Raiz = nuevo;
            else
                Raiz = InsertarRecursivo(Raiz, nuevo);
        }

        private NodoEnvio InsertarRecursivo(NodoEnvio actual, NodoEnvio nuevo)
        {
            if (actual == null)
                return nuevo;

            if (string.Compare(nuevo.Id, actual.Id, StringComparison.Ordinal) < 0)
                actual.Izquierdo = InsertarRecursivo(actual.Izquierdo, nuevo);
            else
                actual.Derecho = InsertarRecursivo(actual.Derecho, nuevo);

            return actual;
        }

        //BUSQUEDA POR ID
        public NodoEnvio BuscarPorId(string id)
        {
            return BuscarRecursivo(Raiz, id);
        }

        private NodoEnvio BuscarRecursivo(NodoEnvio nodo, string id)
        {
            if (nodo == null || nodo.Id == id)
                return nodo;

            return string.Compare(id, nodo.Id) < 0 ? BuscarRecursivo(nodo.Izquierdo, id) : BuscarRecursivo(nodo.Derecho, id);
        }

        
        public List<NodoEnvio> BuscarPorEstado(string estado)
        {
            List<NodoEnvio> resultados = new List<NodoEnvio>();
            BuscarEstadoRecursivo(Raiz, estado, resultados);
            return resultados;
        }

        public List<NodoEnvio> BuscarPorPrioridad(string prioridad)
        {
            List<NodoEnvio> resultados = new List<NodoEnvio>();
            BuscarPrioridadRecursivo(Raiz, prioridad, resultados);
            return resultados;
        }


        private void BuscarEstadoRecursivo(NodoEnvio nodo, string estado, List<NodoEnvio> resultados)
        {
            //MessageBox.Show($"Buscando en nodo: {nodo?.Id} con estado: {estado}", "Buscar Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (nodo != null)
            {
                /*if (nodo.Estado.Equals(estado, StringComparison.OrdinalIgnoreCase))
                    resultados.Add(nodo);*/

                if (!string.IsNullOrEmpty(nodo.Estado))
                {
                    if (nodo.Estado.Trim().Equals(estado.Trim(), StringComparison.OrdinalIgnoreCase))
                        resultados.Add(nodo);
                }
                else
                {
                    MessageBox.Show($"Nodo {nodo.Id} tiene estado nulo o vacío");
                }


                BuscarEstadoRecursivo(nodo.Izquierdo, estado, resultados);
                BuscarEstadoRecursivo(nodo.Derecho, estado, resultados);
            }
        }


        private void BuscarPrioridadRecursivo(NodoEnvio nodo, string prioridad, List<NodoEnvio> resultados)
        {
            //MessageBox.Show($"Buscando en nodo: {nodo?.Id} con estado: {estado}", "Buscar Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (nodo != null)
            {
                /*if (nodo.Estado.Equals(estado, StringComparison.OrdinalIgnoreCase))
                    resultados.Add(nodo);*/

                if (!string.IsNullOrEmpty(nodo.Prioridad))
                {
                    if (nodo.Prioridad.Trim().Equals(prioridad.Trim(), StringComparison.OrdinalIgnoreCase))
                        resultados.Add(nodo);
                }
                else
                {
                    MessageBox.Show($"Nodo {nodo.Id} tiene estado nulo o vacío");
                }


                BuscarPrioridadRecursivo(nodo.Izquierdo, prioridad, resultados);
                BuscarPrioridadRecursivo(nodo.Derecho, prioridad, resultados);
            }
        }


        public void RecorridoEnOrden(List<NodoEnvio> lista)
        {
            RecorridoEnOrdenRecursivo(Raiz, lista);
        }

        private void RecorridoEnOrdenRecursivo(NodoEnvio nodo, List<NodoEnvio> lista)
        {
            if (nodo != null)
            {
                RecorridoEnOrdenRecursivo(nodo.Izquierdo, lista);
                lista.Add(nodo);
                RecorridoEnOrdenRecursivo(nodo.Derecho, lista);
            }
        }
    }
}

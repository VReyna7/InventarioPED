using InventarioPED.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioPED.Models
{
    class ArbolBinarioEnvio
    {
        public NodoEnvio Raiz { get; set; }

        public void Insertar(string id, string nombre, string direccion, int peso, string prioridad, string estado)
        {
            if (Raiz == null)
            {
                Raiz = new NodoEnvio(id, nombre, direccion, peso,prioridad,estado);
                Console.WriteLine($"✅ Se asignó la raíz con ID: {id}");
            }
            else
            {
                Raiz = InsertarRecursivo(Raiz, id, nombre, direccion, peso, prioridad, estado);
            }
        }

        private NodoEnvio InsertarRecursivo(NodoEnvio nodo, string id, string nombre, string direccion, int peso, string prioridad, string estado)
        {
            if (nodo == null)
                return new NodoEnvio(id, nombre, direccion, peso, prioridad, estado);

            Console.WriteLine($"📌 Insertando nodo {id} en comparación con {nodo.Id}");

            if (string.Compare(id, nodo.Id) < 0)
                nodo.Izquierdo = InsertarRecursivo(nodo.Izquierdo, id, nombre, direccion, peso, prioridad, estado);
            else
                nodo.Derecho = InsertarRecursivo(nodo.Derecho, id, nombre, direccion, peso, prioridad, estado);

            return nodo;
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

        //BUSQUEDA POR CATEGORIA

        /*
        public List<NodoEnvio> BuscarPorCategoria(string categoria)
        {
            List<NodoEnvio> resultados = new List<NodoEnvio>();
            BuscarCategoriaRecursivo(Raiz, categoria, resultados);
            return resultados;
        }
        */

        /*
        private void BuscarCategoriaRecursivo(NodoEnvio nodo, string categoria, List<NodoEnvio> resultados)
        {
            if (nodo != null)
            {
                if (nodo.Categoria.Equals(categoria, StringComparison.OrdinalIgnoreCase))
                    resultados.Add(nodo);

                BuscarCategoriaRecursivo(nodo.Izquierdo, categoria, resultados);
                BuscarCategoriaRecursivo(nodo.Derecho, categoria, resultados);
            }
        }
        */

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

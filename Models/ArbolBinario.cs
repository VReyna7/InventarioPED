using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioPED.Models
{
    class ArbolBinario
    {
        public Nodo Raiz { get; set; }

        public void Insertar(string id, string nombre, string descripcion, decimal precio, int cantidad, string categoria, string proveedor)
        {
            Raiz = InsertarRecursivo(Raiz, id, nombre, descripcion, precio, cantidad, categoria, proveedor);
        }

        private Nodo InsertarRecursivo(Nodo nodo, string id, string nombre, string descripcion, decimal precio, int cantidad, string categoria, string proveedor)
        {
            if (nodo == null)
                return new Nodo(id, nombre, descripcion, precio, cantidad, categoria, proveedor);

            if (string.Compare(nombre, nodo.Nombre) < 0)
                nodo.Izquierdo = InsertarRecursivo(nodo.Izquierdo, id, nombre, descripcion, precio, cantidad, categoria, proveedor);
            else
                nodo.Derecho = InsertarRecursivo(nodo.Derecho, id, nombre, descripcion, precio, cantidad, categoria, proveedor);

            return nodo;
        }

        public Nodo Buscar(string nombre)
        {
            return BuscarRecursivo(Raiz, nombre);
        }

        private Nodo BuscarRecursivo(Nodo nodo, string nombre)
        {
            if (nodo == null || nodo.Nombre == nombre)
                return nodo;

            return string.Compare(nombre, nodo.Nombre) < 0 ? BuscarRecursivo(nodo.Izquierdo, nombre) : BuscarRecursivo(nodo.Derecho, nombre);
        }

        public void RecorridoEnOrden(List<Nodo> lista)
        {
            RecorridoEnOrdenRecursivo(Raiz, lista);
        }

        private void RecorridoEnOrdenRecursivo(Nodo nodo, List<Nodo> lista)
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

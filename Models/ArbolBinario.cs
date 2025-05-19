using InventarioPED.Data;
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
            if (Raiz == null)
            {
                Raiz = new Nodo(id, nombre, descripcion, precio, cantidad, categoria, proveedor);
                Console.WriteLine($"✅ Se asignó la raíz con ID: {id}");
            }
            else
            {
                Raiz = InsertarRecursivo(Raiz, id, nombre, descripcion, precio, cantidad, categoria, proveedor);
            }
        }

        private Nodo InsertarRecursivo(Nodo nodo, string id, string nombre, string descripcion, decimal precio, int cantidad, string categoria, string proveedor)
        {
            if (nodo == null)
                return new Nodo(id, nombre, descripcion, precio, cantidad, categoria, proveedor);

            Console.WriteLine($"📌 Insertando nodo {id} en comparación con {nodo.Id}");

            if (string.Compare(id, nodo.Id) < 0)
                nodo.Izquierdo = InsertarRecursivo(nodo.Izquierdo, id, nombre, descripcion, precio, cantidad, categoria, proveedor);
            else
                nodo.Derecho = InsertarRecursivo(nodo.Derecho, id, nombre, descripcion, precio, cantidad, categoria, proveedor);

            return nodo;
        }

        //BUSQUEDA POR ID
        public Nodo BuscarPorId(string id)
        {
            return BuscarRecursivo(Raiz, id);
        }

        private Nodo BuscarRecursivo(Nodo nodo, string id)
        {
            if (nodo == null || nodo.Id == id)
                return nodo;

            return string.Compare(id, nodo.Id) < 0 ? BuscarRecursivo(nodo.Izquierdo, id) : BuscarRecursivo(nodo.Derecho, id);
        }

        //BUSQUEDA POR CATEGORIA
        public List<Nodo> BuscarPorCategoria(string categoria)
        {
            List<Nodo> resultados = new List<Nodo>();
            BuscarCategoriaRecursivo(Raiz, categoria, resultados);
            return resultados;
        }

        private void BuscarCategoriaRecursivo(Nodo nodo, string categoria, List<Nodo> resultados)
        {
            if (nodo != null)
            {
                if (nodo.Categoria.Equals(categoria, StringComparison.OrdinalIgnoreCase))
                    resultados.Add(nodo);

                BuscarCategoriaRecursivo(nodo.Izquierdo, categoria, resultados);
                BuscarCategoriaRecursivo(nodo.Derecho, categoria, resultados);
            }
        }


        //BUSQUEDA POR NOMBRE
        /*public Nodo Buscar(string nombre)
        {
            return BuscarRecursivo(Raiz, nombre);
        }

        private Nodo BuscarRecursivo(Nodo nodo, string nombre)
        {
            if (nodo == null || nodo.Nombre == nombre)
                return nodo;

            return string.Compare(nombre, nodo.Nombre) < 0 ? BuscarRecursivo(nodo.Izquierdo, nombre) : BuscarRecursivo(nodo.Derecho, nombre);
        }*/

        //--------------------------------------------------------------------
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

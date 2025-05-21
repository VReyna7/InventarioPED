using InventarioPED.Data;
using InventarioPED.Models;
using InventarioPED.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioPED.Forms
{
    public partial class ProductosAdministracion : Form
    {
        private ArbolBinario arbol = new ArbolBinario();
        public ProductosAdministracion()
        {
            InitializeComponent();
        }

        //FUNCION PARA INICIALIZAR LA CARGA DE TODOS LOS ELEMENTOS
        private void Productos_Load(object sender, EventArgs e)
        {
            //COLOCA LOS CAMPOS PARA ALMACENAR CORRECTAMENTE LOS DATOS DE LOS PRODUCTOS
            ConfigurarDataGridView(dataGridView1);

            //CARGA LOS PRODUCTOS ALMACENADOS DE LA BDD EN EL ARBOL
            CargarProductosEnArbol(arbol);

            //CARGA LOS DATOS ALMACENADOS EN EL ARBOL EN EL GRID
            CargarDatosEnGrid(arbol, dataGridView1);

            //LLENA LOS COMBOBOX CON LOS IDS DE LOS PRODUCTOS
            LlenarComboBoxDesdeArbol(arbol, cmbIdProd);
            LlenarComboBoxDesdeArbol(arbol, cmbElimProd);
            LlenarComboBoxDesdeArbol(arbol, cmbProdEdit);

            //LLENA LOS COMBOBOX CON LAS CATEGORIAS
            LlenarComboBoxConCategorias(cmbCatProd);
            LlenarComboBoxConCategorias(cmbCatElim);
        }
        
        //BOTON QUE FILTRA POR ID DE PRODUCTO
        private void btnBusquedaId_Click(object sender, EventArgs e)
        {
            string idBuscado = cmbIdProd.Text;
            Nodo producto = arbol.BuscarPorId(idBuscado);

            if (producto != null)
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Rows.Add(producto.Id, producto.Nombre, producto.Descripcion, producto.Precio, producto.Cantidad, producto.Categoria, producto.Proveedor);
            }
            else
            {
                MessageBox.Show("Producto no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //BOTON QUE FILTRA PRODUCTOS POR CATEGORIA
        private void btnBusquedaCategoria_Click(object sender, EventArgs e)
        {
            string categoriaBuscada = cmbCatProd.Text;
            List<Nodo> productosCategoria = arbol.BuscarPorCategoria(categoriaBuscada);

            if (productosCategoria.Count > 0)
            {
                dataGridView1.Rows.Clear();
                foreach (var producto in productosCategoria)
                {
                    dataGridView1.Rows.Add(producto.Id, producto.Nombre, producto.Descripcion, producto.Precio, producto.Cantidad, producto.Categoria, producto.Proveedor);
                }
            }
            else
            {
                MessageBox.Show("No se encontraron productos en esta categoría.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //BOTON QUE REINICIA EL GRID Y MUESTRA TODOS LOS DATOS ALMACENADOS EN EL ARBOL
        private void button5_Click(object sender, EventArgs e)
        {
            // Mostrar en DataGridView
            CargarDatosEnGrid(arbol, dataGridView1);
        }

        //BOTON PARA AGREGAR UNA CATEGORIA
        private void button1_Click(object sender, EventArgs e)
        {
            string categoria = txtCategoria.Text;
            AgregarCategoria(categoria);
            txtCategoria.Text = "";
            LlenarComboBoxConCategorias(cmbCatProd);
            LlenarComboBoxConCategorias(cmbCatElim);
        }

        //BOTON PARA ELIMINAR UNA CATEGORIA
        private void btnElimCat_Click(object sender, EventArgs e)
        {
            string categoria = cmbCatElim.Text;

            List<Nodo> productosCategoria = arbol.BuscarPorCategoria(categoria);

            if (productosCategoria.Count > 0)
            {
                MessageBox.Show("No es posible eliminar la categoría, ya que hay productos que pertenecientes a ella.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                EliminarCategoria(categoria);
                MessageBox.Show($"✅ Categoría '{categoria}' eliminada correctamente.", "Eliminacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LlenarComboBoxConCategorias(cmbCatElim);
                LlenarComboBoxConCategorias(cmbCatProd);
            }
        }

        //BOTON PARA ELIMINAR PRODUCTO
        private void button3_Click(object sender, EventArgs e)
        {
            string idProducto = cmbElimProd.Text;
            Nodo prod = arbol.BuscarPorId(idProducto);
            if (prod.Cantidad > 0)
            {
                MessageBox.Show("No es posible eliminar el producto, ya que hay unidades en existencia.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(EliminarProducto(idProducto))
                {
                    MessageBox.Show($"✅ Producto '{idProducto}' eliminado correctamente.", "Eliminacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //LIMPIANDO ARBOL Y GRID
                    dataGridView1.Rows.Clear(); // También vacía el DataGridView

                    //RECARGANDO LOS PRODUCTOS AL ARBOL Y A LA DGV
                    CargarProductosEnArbol(arbol);
                    CargarDatosEnGrid(arbol, dataGridView1);

                    //LLENANDO LOS CMB CORRESPONDIENTES
                    //LlenarComboBoxDesdeArbol(arbol, cmbIdProd);
                    //LlenarComboBoxDesdeArbol(arbol, cmbElimProd);
                }
                else
                {
                    MessageBox.Show($"❌ Error: No se encontró el producto '{idProducto}' en la base de datos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //EVENTO QUE DETECTA CUANDO SE HACE LA SELECCION DE UN ID AL MOMENTO DE EDITAR PRODUCTO
        private void cmbProdEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idSeleccionado = cmbProdEdit.Text;

            if (!string.IsNullOrEmpty(idSeleccionado))
            {
                Nodo producto = arbol.BuscarPorId(idSeleccionado);

                if (producto != null)
                {
                    cmbCatEditProd.DataSource = null;
                    cmbCatEditProd.Items.Clear();
                    cmbProveedorProdEdit.DataSource = null;
                    cmbProveedorProdEdit.Items.Clear();
                    CargarCategoriasCmbs(cmbCatEditProd);
                    CargarProveedoresCmbs(cmbProveedorProdEdit);
                
                    // Llenar los campos con los datos del producto obtenido del árbol
                    txtProdName.Text = producto.Nombre;
                    txtProdDescrpt.Text = producto.Descripcion;
                    txtPrecio.Text = producto.Precio.ToString();
                    txtCantidad.Text = producto.Cantidad.ToString();
                    cmbCatEditProd.Text = producto.Categoria;
                    cmbProveedorProdEdit.Text = producto.Proveedor;
                }
                else
                {
                    MessageBox.Show("Producto no encontrado en el árbol.", "Error");
                }
            }
        }

        //BOTON PARA CONFIRMAR LA EDICION DE PRODUCTOS
        private void btnEditProd_Click(object sender, EventArgs e)
        {
            string idProducto = cmbProdEdit.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(idProducto))
            {
                Nodo producto = arbol.BuscarPorId(idProducto);

                if (producto != null)
                {
                    // Modificar datos en el árbol
                    producto.Nombre = txtProdName.Text.Trim();
                    producto.Descripcion = txtProdDescrpt.Text.Trim();
                    producto.Precio = decimal.Parse(txtPrecio.Text);
                    producto.Cantidad = int.Parse(txtCantidad.Text);
                    producto.Categoria = cmbCatEditProd.SelectedItem.ToString();
                    producto.Categoria = ((Categoria)cmbCatEditProd.SelectedItem).Nombre;
                    producto.Proveedor = ((Proveedor)cmbProveedorProdEdit.SelectedItem).Nombre;

                    //MessageBox.Show($"✅ Producto actualizado en el árbol: {producto.Id}");
                    ActualizarProductoEnBD(idProducto);
                }
                else
                {
                    MessageBox.Show("Error: No se encontró el producto en el árbol.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //LIMPIANDO ARBOL Y GRID
                dataGridView1.Rows.Clear(); // También vacía el DataGridView
                CargarDatosEnGrid(arbol, dataGridView1);
            }
        }

        //--------------------------------------------------------------------------------------------------

        //FUNCION PARA CARGAR LOS PRODUCTOS DE LA BDD EN EL ARBOL
        private void CargarProductosEnArbol(ArbolBinario arbol)
        {
            using (var contexto = new InventarioDBContext())
            {
                var productos = contexto.Productos
                  .Include(p => p.Categoria)
                  .Include(p => p.Proveedor)
                  .ToList();

                foreach (var producto in productos)
                {
                    arbol.Insertar(
                        producto.Id,
                        producto.Nombre,
                        producto.Descripcion,
                        producto.Precio,
                        producto.Cantidad,
                        producto.Categoria.Nombre,
                        producto.Proveedor.Nombre
                    );
                }
            }
        }

        //METODO PARA CARGAR LAS CATEGORIAS DE LA BDD EN ORDEN PARA LOS CMB (SE USA EN LA EDICION DE PROD)
        public void CargarCategoriasCmbs(ComboBox cmb)
        { 
            var categoriaService = new CategoriaService();
            var categorias = categoriaService.ObtenerTodas();

            cmb.DataSource = categorias;
            cmb.DisplayMember = "Nombre";
            cmb.ValueMember = "Id";
        }

        //METODO PARA CARGAR LOS PROVEEDORES DE LA BDD EN ORDEN PARA LOS CMB (SE USA EN LA EDICION DE PROD)
        public void CargarProveedoresCmbs(ComboBox cmb)
        {
            var proveedorService = new ProveedorService();
            var proveedores = proveedorService.ObtenerTodos();

            cmb.DataSource = proveedores;
            cmb.DisplayMember = "Nombre";
            cmb.ValueMember = "Id";
        }

        //FUNCION PARA CARGAR LOS DATOS EN EL GRID
        private void CargarDatosEnGrid(ArbolBinario arbol, DataGridView dataGridView)
        {
            List<Nodo> lista = new List<Nodo>();
            arbol.RecorridoEnOrden(lista);

            dataGridView.Rows.Clear();

            if (lista.Count == 0)
            {
                MessageBox.Show("No hay productos en el árbol binario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (var nodo in lista)
            {
                dataGridView.Rows.Add(nodo.Id, nodo.Nombre, nodo.Descripcion, nodo.Precio, nodo.Cantidad, nodo.Categoria, nodo.Proveedor);
            }
        }

        //FUNCION PARA CONFIGURAR EL DATA GRID VIEW
        private void ConfigurarDataGridView(DataGridView dataGridView)
        {
            dataGridView.Columns.Clear();
            dataGridView.Columns.Add("Id", "Id");
            dataGridView.Columns.Add("Nombre", "Nombre");
            dataGridView.Columns.Add("Descripcion", "Descripción");
            dataGridView.Columns.Add("Precio", "Precio");
            dataGridView.Columns.Add("Cantidad", "Cantidad");
            dataGridView.Columns.Add("Categoria", "Categoría");
            dataGridView.Columns.Add("Proveedor", "Proveedor");
        }

        //METODO PARA LLLENAR EL COMBOBOX CON LOS IDS DE LOS PRODUCTOS REGISTRADOS ALMACENADOS EN EL ARBOL
        private void LlenarComboBoxDesdeArbol(ArbolBinario arbol, ComboBox comboBox)
        {
            List<string> listaIds = new List<string>();
            ObtenerIdsEnOrden(arbol.Raiz, listaIds);

            comboBox.Items.Clear();
            comboBox.Items.AddRange(listaIds.ToArray());
        }

        // Método auxiliar para recorrer el árbol en orden y extraer los IDs
        private void ObtenerIdsEnOrden(Nodo nodo, List<string> lista)
        {
            if (nodo != null)
            {
                ObtenerIdsEnOrden(nodo.Izquierdo, lista);
                lista.Add(nodo.Id); // Agrega el ID del producto al listado
                ObtenerIdsEnOrden(nodo.Derecho, lista);
            }
        }

        private void LlenarComboBoxConCategorias(ComboBox comboBox)
        {
            HashSet<string> categorias = ObtenerCategoriasDesdeBD();

            comboBox.Items.Clear();
            comboBox.Items.AddRange(categorias.ToArray());
        }

        // Método auxiliar para recorrer el árbol y extraer categorías
        private void ObtenerCategorias(Nodo nodo, HashSet<string> lista)
        {
            if (nodo != null)
            {
                lista.Add(nodo.Categoria); // Agregar la categoría (HashSet evita duplicados)
                ObtenerCategorias(nodo.Izquierdo, lista);
                ObtenerCategorias(nodo.Derecho, lista);
            }
        }

        //Metodo para obtener las categorias de la bdd y pasarlas al arbol al momento de cargar el form
        private HashSet<string> ObtenerCategoriasDesdeBD()
        {
            HashSet<string> categoriasUnicas = new HashSet<string>();

            using (var contexto = new InventarioDBContext())
            {
                var categorias = contexto.Categorias.Select(c => c.Nombre).Distinct().ToList();

                foreach (var categoria in categorias)
                {
                    categoriasUnicas.Add(categoria);
                }
            }

            return categoriasUnicas;
        }

        //Metodo para agregar categorias a la BDD
        public void AgregarCategoria(string nombre)
        {
            using (var contexto = new InventarioDBContext())
            {
                Categoria nuevaCategoria = new Categoria
                {
                    Nombre = nombre,
                };

                contexto.Categorias.Add(nuevaCategoria);
                contexto.SaveChanges();
                MessageBox.Show($"✅ Categoría '{nombre}' registrada correctamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Metodo para eliminar categorias de la BDD
        public void EliminarCategoria(string nombreCategoria)
        {
            using (var contexto = new InventarioDBContext())
            {
                // Buscar la categoría en la BD
                var categoria = contexto.Categorias.FirstOrDefault(c => c.Nombre == nombreCategoria);

                if (categoria != null)
                {
                    contexto.Categorias.Remove(categoria);
                    contexto.SaveChanges();
                    Console.WriteLine($"✅ Categoría '{nombreCategoria}' eliminada correctamente.", "Proceso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Console.WriteLine($"❌ La categoría '{nombreCategoria}' no existe en la BD.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Metodo para eliminar productos de la BDD
        public bool EliminarProducto(string idProd)
        {
            using (var contexto = new InventarioDBContext())
            {
                // Buscar la categoría en la BD
                var producto = contexto.Productos.FirstOrDefault(c => c.Id == idProd);

                if (producto != null)
                {
                    contexto.Productos.Remove(producto);
                    contexto.SaveChanges();
                    return true;
                }
                else
                    return false;
                    
                
            }
        }

        private void ActualizarProductoEnBD(string idProducto)
        {
            using (var contexto = new InventarioDBContext())
            {
                var productoBD = contexto.Productos.FirstOrDefault(p => p.Id == idProducto);

                if (productoBD != null)
                {
                    productoBD.Nombre = txtProdName.Text.Trim();
                    productoBD.Descripcion = txtProdDescrpt.Text.Trim();
                    productoBD.Precio = decimal.Parse(txtPrecio.Text);
                    productoBD.Cantidad = int.Parse(txtCantidad.Text);

                    // Obtener ID de la categoría y proveedor desde el ComboBox
                    productoBD.CategoriaId = (int)cmbCatEditProd.SelectedValue;

                    productoBD.ProveedorId = (int)cmbProveedorProdEdit.SelectedValue;


                    contexto.SaveChanges();  // Guarda cambios en la BD
                    MessageBox.Show($"✅ Producto '{idProducto}' actualizado correctamente.", "Proceso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("❌ Error: El producto no existe en la base de datos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}

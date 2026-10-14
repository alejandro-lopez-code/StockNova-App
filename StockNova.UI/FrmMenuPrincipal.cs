using MaterialSkin;
using MaterialSkin.Controls;
using StockNova.DAL;
using StockNova.Entities;
using StockNova.Models;
using System.Drawing;

namespace StockNova.UI
{
    public partial class FrmMenuPrincipal : MaterialForm
    {
        private readonly Usuario _usuarioLogueado;

        public FrmMenuPrincipal(Usuario usuario)
        {
            InitializeComponent();
            _usuarioLogueado = usuario;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800,
                Primary.BlueGrey900,
                Primary.BlueGrey500,
                (Accent)Primary.BlueGrey900,
                TextShade.WHITE
            );

            this.DrawerHighlightWithAccent = false;
            this.DrawerBackgroundWithAccent = false;

            this.Text = $"StockNova - Usuario: {_usuarioLogueado.NombreUsuario} ({_usuarioLogueado.Rol})";

            // Carga las filas de prueba y les aplica el color
            CargarDatosPrueba();

            dgvInventario.ClearSelection();
            dgvInventario.CurrentCell = null;

        }

        private void tcMenuPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcMenuPrincipal.SelectedTab == tabEspacio1 || tcMenuPrincipal.SelectedTab == tabEspacio2)
            {
                return;
            }

            // Muestra el indicador/cuadrito únicamente DESPUÉS de seleccionar una opción
            this.DrawerShowIconsWhenHidden = true;

            // Lógica para cerrar sesión si presiona esa pestaña
            if (tcMenuPrincipal.SelectedTab.Text == "Cerrar Sesión")
            {
                var confirmacion = MessageBox.Show(
                    "¿Estás seguro de que deseas cerrar la sesión actual?",
                    "Cerrar Sesión",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacion == DialogResult.Yes)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    // Regresa a la pestaña inicial si cancela
                    tcMenuPrincipal.SelectedIndex = -1;
                }
            }
        }

        private void AplicarEstiloEstadoInventario()
        {
            foreach (DataGridViewRow row in dgvInventario.Rows)
            {
                if (row.Cells["colEstado"].Value != null)
                {
                    string estado = row.Cells["colEstado"].Value.ToString();

                    Color colorFondo = Color.White;
                    Color colorTexto = Color.Black;

                    switch (estado)
                    {
                        case "Sin Stock":
                            colorFondo = Color.FromArgb(255, 205, 210); // Rojo pastel
                            colorTexto = Color.DarkRed;
                            break;

                        case "Stock Bajo":
                            colorFondo = Color.FromArgb(255, 245, 157); // Amarillo pastel
                            colorTexto = Color.DarkGoldenrod;
                            break;

                        case "Normal":
                            colorFondo = Color.FromArgb(200, 230, 201); // Verde pastel
                            colorTexto = Color.DarkGreen;
                            break;
                    }

                    // Asigna el color normal de la celda
                    row.DefaultCellStyle.BackColor = colorFondo;
                    row.DefaultCellStyle.ForeColor = colorTexto;

                    // SOBREESCRIBE EL COLOR AZUL DE SELECCIÓN DE WINFORMS
                    row.DefaultCellStyle.SelectionBackColor = colorFondo;
                    row.DefaultCellStyle.SelectionForeColor = colorTexto;
                }
            }
        }

        private void CargarDatosPrueba()
        {
            try
            {
                StockNova.DAL.ProductoDAL productoDAL = new StockNova.DAL.ProductoDAL();
                System.Data.DataTable dtProductos = productoDAL.ListarProductos();

                // 1. Evitamos que se dupliquen las columnas creadas a mano
                dgvInventario.AutoGenerateColumns = false;

                // 2. Asignamos los datos
                dgvInventario.DataSource = dtProductos;

                // 3. Aplicamos tus estilos visuales y colores personalizados
                AplicarEstiloEstadoInventario();

                // 4. CENTRAR ÚNICAMENTE CATEGORÍA, STOCK MIN Y STOCK ACTUAL
                if (dgvInventario.Columns.Contains("Categoria"))
                {
                    dgvInventario.Columns["Categoria"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvInventario.Columns["Categoria"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                if (dgvInventario.Columns.Contains("StockMinimo"))
                {
                    dgvInventario.Columns["StockMinimo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvInventario.Columns["StockMinimo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                if (dgvInventario.Columns.Contains("StockActual"))
                {
                    dgvInventario.Columns["StockActual"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvInventario.Columns["StockActual"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                dgvInventario.ClearSelection();
                dgvInventario.CurrentCell = null;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al cargar los datos del inventario: " + ex.Message, "Error de Conexión", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private void dgvInventario_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Limpia la selección azul por defecto al cargar los datos
            dgvInventario.ClearSelection();
        }

        private void FrmMenuPrincipal_Shown(object sender, EventArgs e)
        {
            dgvInventario.ClearSelection();
            dgvInventario.CurrentCell = null;

            this.ActiveControl = null;
        }

        private void dgvInventario_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Verifica que sea la columna de acciones y no la cabecera
            if (e.ColumnIndex >= 0 && dgvInventario.Columns[e.ColumnIndex].Name == "colAcciones" && e.RowIndex >= 0)
            {
                // 1. Obtener el color de fondo actual de la fila (azul/amarillo/verde según el estado)
                Color rowBackColor = dgvInventario.Rows[e.RowIndex].DefaultCellStyle.BackColor;
                if (rowBackColor.IsEmpty)
                {
                    rowBackColor = dgvInventario.DefaultCellStyle.BackColor;
                }

                // 2. Pintar toda la celda con el color de la fila para desaparecer el recuadro blanco
                using (Brush cellBrush = new SolidBrush(rowBackColor))
                {
                    e.Graphics.FillRectangle(cellBrush, e.CellBounds);
                }

                // 3. Definir un tamaño bien estilizado y compacto para el botón "Ver"
                int buttonWidth = 46;  // Ancho compacto
                int buttonHeight = 22; // Altura delgada y elegante
                int posX = e.CellBounds.Left + (e.CellBounds.Width - buttonWidth) / 2;
                int posY = e.CellBounds.Top + (e.CellBounds.Height - buttonHeight) / 2;

                Rectangle buttonRect = new Rectangle(posX, posY, buttonWidth, buttonHeight);

                // 4. Dibujar el botón en el tono #2D3E4E de la interfaz
                using (Brush buttonBrush = new SolidBrush(Color.FromArgb(45, 62, 78)))
                {
                    e.Graphics.FillRectangle(buttonBrush, buttonRect);
                }

                // 5. Dibujar el texto "Ver" centrado en blanco
                TextRenderer.DrawText(
                    e.Graphics,
                    "Ver",
                    dgvInventario.Font,
                    buttonRect,
                    Color.White,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );

                e.Handled = true; // Indicar que la celda ya se dibujó completamente
            }
        }

        private void btnActualizarStock_Click(object sender, EventArgs e)
        {
            try
            {
                // Trae los datos más recientes directo de la base de datos SQL Server
                StockNova.DAL.ProductoDAL productoDAL = new StockNova.DAL.ProductoDAL();
                System.Data.DataTable dtProductos = productoDAL.ListarProductos();

                dgvInventario.AutoGenerateColumns = false;
                dgvInventario.DataSource = dtProductos;

                // Aplicamos tus estilos visuales, colores y centrados
                AplicarEstiloEstadoInventario();

                if (dgvInventario.Columns.Contains("Categoria"))
                {
                    dgvInventario.Columns["Categoria"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
                    dgvInventario.Columns["Categoria"].HeaderCell.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
                }

                if (dgvInventario.Columns.Contains("StockMinimo"))
                {
                    dgvInventario.Columns["StockMinimo"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
                    dgvInventario.Columns["StockMinimo"].HeaderCell.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
                }

                if (dgvInventario.Columns.Contains("StockActual"))
                {
                    dgvInventario.Columns["StockActual"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
                    dgvInventario.Columns["StockActual"].HeaderCell.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
                }

                // Limpiamos cualquier selección por defecto
                dgvInventario.ClearSelection();
                dgvInventario.CurrentCell = null;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al actualizar el stock: " + ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private void btnSoloAlertas_Click(object sender, EventArgs e)
        {
            try
            {
                StockNova.DAL.ProductoDAL productoDAL = new StockNova.DAL.ProductoDAL();
                System.Data.DataTable dt = productoDAL.ListarProductos();

                // Filtramos el DataView para mostrar únicamente las alertas críticas
                System.Data.DataView dv = dt.DefaultView;
                dv.RowFilter = "Estado = 'Sin Stock' OR Estado = 'Stock Bajo'";

                dgvInventario.AutoGenerateColumns = false;
                dgvInventario.DataSource = dv;

                AplicarEstiloEstadoInventario();

                dgvInventario.ClearSelection();
                dgvInventario.CurrentCell = null;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al filtrar las alertas: " + ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private void btnExportarCsv_Click(object sender, EventArgs e)
        {
            using (System.Windows.Forms.SaveFileDialog sfd = new System.Windows.Forms.SaveFileDialog())
            {
                sfd.Filter = "Archivo CSV (*.csv)|*.csv";
                sfd.FileName = "Inventario_StockNova_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".csv";

                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        System.Text.StringBuilder sb = new System.Text.StringBuilder();

                        // Cabeceras de columnas
                        foreach (System.Windows.Forms.DataGridViewColumn col in dgvInventario.Columns)
                        {
                            sb.Append(col.HeaderText + ",");
                        }
                        sb.AppendLine();

                        // Filas de datos visibles en la tabla
                        foreach (System.Windows.Forms.DataGridViewRow row in dgvInventario.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                foreach (System.Windows.Forms.DataGridViewCell cell in row.Cells)
                                {
                                    sb.Append("\"" + (cell.Value?.ToString() ?? "") + "\",");
                                }
                                sb.AppendLine();
                            }
                        }

                        System.IO.File.WriteAllText(sfd.FileName, sb.ToString(), System.Text.Encoding.UTF8);
                        System.Windows.Forms.MessageBox.Show("Inventario exportado exitosamente.", "Éxito", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Error al exportar el archivo: " + ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvInventario_DataBindingComplete_1(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvInventario.ClearSelection();
            dgvInventario.CurrentCell = null;
        }

        // Instancia de la DAL para productos
        private readonly ProductoDAL _productoDAL = new ProductoDAL();

        // Evento del botón REGISTRAR PRODUCTO 💾
        private void btnRegistrarProducto_Click(object sender, EventArgs e)
        {
            // 1. Validaciones básicas de campos obligatorios
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Por favor, ingresa el código del producto.", "Campo Obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Por favor, ingresa el nombre del producto.", "Campo Obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            // 2. Validar stock mínimo
            int stockMinimo = 0;
            if (!string.IsNullOrWhiteSpace(txtStockMinimo.Text) && !int.TryParse(txtStockMinimo.Text.Trim(), out stockMinimo))
            {
                MessageBox.Show("El stock mínimo debe ser un número entero válido.", "Valor Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStockMinimo.Focus();
                return;
            }

            // 3. Crear objeto entidad
            Producto nuevoProducto = new Producto
            {
                Codigo = txtCodigo.Text.Trim(),
                Nombre = txtNombre.Text.Trim(),
                UnidadMedida = cmbUnidadMedida.SelectedItem?.ToString() ?? cmbUnidadMedida.Text.Trim(),
                Categoria = cmbGrupo.SelectedItem?.ToString() ?? cmbGrupo.Text.Trim(),
                StockMinimo = stockMinimo
            };

            // 4. Guardar en base de datos
            try
            {
                bool guardado = _productoDAL.InsertarProducto(nuevoProducto);
                if (guardado)
                {
                    MessageBox.Show("¡Producto registrado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al registrar el producto:\n{ex.Message}", "Error en BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento del botón LIMPIAR 🧹
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormularioProducto();
        }

        // Método auxiliar para limpiar los controles del formulario de productos
        private void LimpiarFormularioProducto()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtStockMinimo.Clear();

            if (cmbUnidadMedida.Items.Count > 0) cmbUnidadMedida.SelectedIndex = 0;
            else cmbUnidadMedida.Text = string.Empty;

            if (cmbGrupo.Items.Count > 0) cmbGrupo.SelectedIndex = 0;
            else cmbGrupo.Text = string.Empty;

            txtCodigo.Focus();
        }
    }
}
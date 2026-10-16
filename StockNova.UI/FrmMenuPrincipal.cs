using MaterialSkin;
using MaterialSkin.Controls;
using StockNova.DAL;
using StockNova.Entities;
using StockNova.Models;
using System.Data;
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

        private MovimientoDAL _movimientoDAL = new MovimientoDAL();

        private void btnGuardarMovimiento_Click(object sender, EventArgs e)
        {
            // 1. Validaciones de entrada
            if (string.IsNullOrWhiteSpace(txtCodigoMovimiento.Text))
            {
                MessageBox.Show("Por favor, ingrese el código del producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtCantidadMovimiento.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida mayor a cero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string codigoProducto = txtCodigoMovimiento.Text.Trim();

                // 2. Obtener el IdProducto desde la capa de datos
                ProductoDAL productoDAL = new ProductoDAL();
                int idProducto = productoDAL.ObtenerIdPorCodigo(codigoProducto);

                if (idProducto == 0)
                {
                    MessageBox.Show("El código de producto ingresado no existe en el sistema.", "Producto No Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DateTime fecha = dtpFechaMovimiento.Value;
                string tipo = cmbTipoMovimiento.SelectedItem?.ToString() ?? "Entrada (Ingreso por Compra)";
                string observaciones = txtObservaciones.Text.Trim();

                // Usamos un ID de usuario por defecto (1) para evitar errores de sesión
                int idUsuario = 1;

                // 3. Registrar el movimiento y actualizar stock
                bool exito = _movimientoDAL.RegistrarMovimiento(idProducto, tipo, cantidad, fecha, idUsuario, observaciones);

                if (exito)
                {
                    MessageBox.Show("¡Movimiento registrado y stock actualizado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el movimiento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiarMovimiento_Click(object sender, EventArgs e)
        {
            LimpiarFormularioMovimientos();
        }

        private void LimpiarFormularioMovimientos()
        {
            txtCodigoMovimiento.Clear();
            txtCantidadMovimiento.Clear();
            txtObservaciones.Clear();
            if (cmbTipoMovimiento.Items.Count > 0) cmbTipoMovimiento.SelectedIndex = 0;
            dtpFechaMovimiento.Value = DateTime.Now;
        }

        // Método principal para refrescar todo el Dashboard (Tarjetas y datos)
        private void CargarDashboardCompleto()
        {
            try
            {
                DashboardDAL dashboardDAL = new DashboardDAL();

                // 1. Actualizar las tarjetas de métricas superiores
                var metricas = dashboardDAL.ObtenerMetricasDashboard();
                lblTotalProductos.Text = metricas.totalProductos.ToString();
                lblTotalMovimientos.Text = metricas.totalMovimientos.ToString();
                lblSinStock.Text = metricas.sinStock.ToString();
                lblStockBajo.Text = metricas.stockBajo.ToString();

                // 2. Cargar por defecto las alertas en la grilla para que siempre tenga datos actualizados
                ActualizarGrillaAlertas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el Dashboard: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para refrescar el DataGridView y desmarcar selecciones
        private void ActualizarGrillaAlertas()
        {
            DashboardDAL dashboardDAL = new DashboardDAL();
            DataTable dtAlertas = dashboardDAL.ObtenerProductosConAlertaStock();

            dgvAlertasStock.DataSource = dtAlertas;

            int totalAlertas = dtAlertas.Rows.Count;

            if (totalAlertas > 0)
            {
                // 1. Estilo del Banner de Alerta en Amarillo (Fondo amarillo suave, texto oscuro/marrón)
                lblMensajeAlerta.BackColor = Color.FromArgb(254, 243, 199); // Amarillo claro
                lblMensajeAlerta.ForeColor = Color.FromArgb(146, 64, 14);   // Marrón/Naranja oscuro
                lblMensajeAlerta.Text = $"   ⚠️  {totalAlertas} producto(s) requieren atención por stock bajo o agotado.";
                lblMensajeAlerta.Visible = true;
            }
            else
            {
                // Banner verde si no hay alertas
                lblMensajeAlerta.BackColor = Color.FromArgb(220, 252, 231);
                lblMensajeAlerta.ForeColor = Color.FromArgb(22, 101, 52);
                lblMensajeAlerta.Text = "   ✅ ¡Todo en orden! No hay productos con alertas de stock.";
                lblMensajeAlerta.Visible = true;
            }

            // 2. Colorear las filas según su estado (Rojo para "Sin Stock" / Rosado-Naranja para "Stock Bajo")
            PintarFilasAlertas();

            // 3. Aplicar estilo moderno a la grilla (Igual al de Reportes)
            EstilizarDataGridViewDashboard(); // <--- ¡Solo agregas esta línea aquí!

            // 4. Quitar la selección de la primera fila por defecto
            dgvAlertasStock.ClearSelection();
        }

        // Método para colorear las filas del DataGridView
        private void PintarFilasAlertas()
        {
            foreach (DataGridViewRow row in dgvAlertasStock.Rows)
            {
                if (row.Cells["Estado"].Value != null)
                {
                    string estado = row.Cells["Estado"].Value.ToString();

                    if (estado == "Sin Stock")
                    {
                        // Fondo rosado/rojo claro con texto rojo oscuro
                        row.DefaultCellStyle.BackColor = Color.FromArgb(254, 226, 226);
                        row.DefaultCellStyle.ForeColor = Color.FromArgb(185, 28, 28);
                    }
                    else if (estado == "Stock Bajo")
                    {
                        // Fondo amarillo/naranja claro
                        row.DefaultCellStyle.BackColor = Color.FromArgb(254, 243, 199);
                        row.DefaultCellStyle.ForeColor = Color.FromArgb(180, 83, 9);
                    }
                }
            }
        }

        private void dgvAlertasStock_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvAlertasStock.ClearSelection();
        }

        private void btnActualizarDashboard_Click(object sender, EventArgs e)
        {
            CargarDashboardCompleto();
            dgvAlertasStock.ClearSelection(); // Asegura limpiar la selección
        }

        private void btnVerAlertasStock_Click(object sender, EventArgs e)
        {
            try
            {
                ActualizarGrillaAlertas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las alertas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 1. Método principal que hace la consulta a la base de datos y pinta las filas
        private void RealizarBusquedaProductos()
        {
            try
            {
                BuscarDAL buscarDAL = new BuscarDAL();
                string criterio = txtCriterioBusqueda.Text.Trim();

                // Consulta los productos filtrados por el criterio escrito en la caja de texto
                DataTable dtResultados = buscarDAL.BuscarProductos(criterio);

                dgvResultadosBusqueda.DataSource = dtResultados;

                // Pinta las filas automáticamente según el estado (Verde, Amarillo, Rojo)
                PintarFilasBusqueda();

                dgvResultadosBusqueda.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la búsqueda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 2. Método de pintado de filas según el estado del stock
        private void PintarFilasBusqueda()
        {
            foreach (DataGridViewRow row in dgvResultadosBusqueda.Rows)
            {
                if (row.Cells["Estado"].Value != null)
                {
                    string estado = row.Cells["Estado"].Value.ToString();

                    if (estado == "Sin Stock")
                    {
                        // Fondo rojo claro con texto rojo oscuro
                        row.DefaultCellStyle.BackColor = Color.FromArgb(254, 226, 226);
                        row.DefaultCellStyle.ForeColor = Color.FromArgb(185, 28, 28);
                    }
                    else if (estado == "Stock Bajo")
                    {
                        // Fondo amarillo claro con texto naranja oscuro
                        row.DefaultCellStyle.BackColor = Color.FromArgb(254, 243, 199);
                        row.DefaultCellStyle.ForeColor = Color.FromArgb(180, 83, 9);
                    }
                    else if (estado == "Normal")
                    {
                        // Fondo verde claro con texto verde oscuro
                        row.DefaultCellStyle.BackColor = Color.FromArgb(220, 252, 231);
                        row.DefaultCellStyle.ForeColor = Color.FromArgb(22, 101, 52);
                    }
                }
            }
        }

        // 3. Evento del botón BUSCAR (La búsqueda se ejecuta SOLAMENTE al dar clic aquí)
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            RealizarBusquedaProductos();
        }

        // 4. Evento opcional: Permite buscar también presionando la tecla ENTER dentro de la caja de texto
        private void txtCriterioBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RealizarBusquedaProductos();
                e.Handled = true;
                e.SuppressKeyPress = true; // Evita el sonido de alerta de Windows al presionar Enter
            }
        }

        // 5. Evento del botón LIMPIAR: Borra el texto, recarga la tabla completa y regresa el foco
        private void btnLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            txtCriterioBusqueda.Clear();
            RealizarBusquedaProductos();
            txtCriterioBusqueda.Focus();
        }

        // 1. Cargar las opciones del ComboBox al iniciar (Llamarlo en el Form_Load)
        private void CargarFiltrosReportes()
        {
            cmbFiltroTipo.Items.Clear();
            cmbFiltroTipo.Items.Add("Todos los movimientos");
            cmbFiltroTipo.Items.Add("Entrada");
            cmbFiltroTipo.Items.Add("Salida");
            cmbFiltroTipo.SelectedIndex = 0;
        }

        // 2. Método principal para generar el reporte de movimientos
        private void GenerarReporteMovimientos()
        {
            try
            {
                DateTime desde = dtpFechaDesde.Value;
                DateTime hasta = dtpFechaHasta.Value;

                if (desde > hasta)
                {
                    MessageBox.Show("La fecha 'Desde' no puede ser mayor que la fecha 'Hasta'.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string tipo = cmbFiltroTipo.SelectedItem != null ? cmbFiltroTipo.SelectedItem.ToString() : "Todos los movimientos";

                ReportesDAL reportesDAL = new ReportesDAL();
                DataTable dtResultados = reportesDAL.ObtenerHistorialMovimientos(desde, hasta, tipo);

                dgvReporteMovimientos.DataSource = dtResultados;

                int totalRegistros = dtResultados.Rows.Count;
                if (lblEstadoReporte != null)
                {
                    lblEstadoReporte.Text = totalRegistros > 0
                        ? $"Se encontraron {totalRegistros} movimientos"
                        : "No se encontraron movimientos en el rango seleccionado";
                }

                // Aplicar estilos modernos a la grilla y pintar tipos
                EstilizarDataGridView();
                PintarTiposMovimiento();

                dgvReporteMovimientos.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte de movimientos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 3. Estilo moderno para el DataGridView (elimina líneas clásicas de Windows)
        private void EstilizarDataGridView()
        {
            // Ocultar encabezados de filas (la columna gris de la izquierda)
            dgvReporteMovimientos.RowHeadersVisible = false;

            // Hacer que las columnas se expandan al ancho total del DataGridView
            dgvReporteMovimientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Ajustar colores de fondo para eliminar el gris de la derecha/abajo
            dgvReporteMovimientos.BackgroundColor = Color.White;
            dgvReporteMovimientos.DefaultCellStyle.BackColor = Color.White;
            dgvReporteMovimientos.BorderStyle = BorderStyle.None;

            // Quitar bordes clásicos
            dgvReporteMovimientos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvReporteMovimientos.GridColor = Color.FromArgb(224, 224, 224);

            // Permitir estilos personalizados en los encabezados
            dgvReporteMovimientos.EnableHeadersVisualStyles = false;
            dgvReporteMovimientos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvReporteMovimientos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(55, 71, 79);
            dgvReporteMovimientos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvReporteMovimientos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvReporteMovimientos.ColumnHeadersHeight = 35;

            // Estilos de filas
            dgvReporteMovimientos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 247, 250);
            dgvReporteMovimientos.DefaultCellStyle.Font = new Font("Segoe UI", 9.5f, FontStyle.Regular);
            dgvReporteMovimientos.DefaultCellStyle.ForeColor = Color.FromArgb(33, 33, 33);
            dgvReporteMovimientos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(63, 81, 181);
            dgvReporteMovimientos.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvReporteMovimientos.RowTemplate.Height = 30;

            // Ocultar la columna ID
            if (dgvReporteMovimientos.Columns["ID"] != null)
            {
                dgvReporteMovimientos.Columns["ID"].Visible = false;
            }
        }

        // 4. Método para colorear dinámicamente la columna "Tipo"
        private void PintarTiposMovimiento()
        {
            foreach (DataGridViewRow row in dgvReporteMovimientos.Rows)
            {
                if (row.Cells["Tipo"].Value != null)
                {
                    string tipo = row.Cells["Tipo"].Value.ToString();

                    if (tipo == "Entrada" || tipo == "Ingreso")
                    {
                        row.Cells["Tipo"].Style.ForeColor = Color.FromArgb(22, 101, 52); 
                row.Cells["Tipo"].Style.SelectionForeColor = Color.FromArgb(22, 101, 52);
                    }
                    else if (tipo == "Salida")
                    {
                        row.Cells["Tipo"].Style.ForeColor = Color.FromArgb(185, 28, 28);
                row.Cells["Tipo"].Style.SelectionForeColor = Color.FromArgb(185, 28, 28);
                    }
                }
            }
        }

        // 5. Método para exportar a formato CSV / Excel
        private void ExportarDataGridViewaCSV()
        {
            try
            {
                if (dgvReporteMovimientos.Rows.Count == 0)
                {
                    MessageBox.Show("No hay datos cargados en la tabla para exportar. Primero genere un reporte.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivo CSV (*.csv)|*.csv|Todos los archivos (*.*)|*.*";
                saveFileDialog.FileName = $"Reporte_Movimientos_{DateTime.Now:yyyyMMdd_HHmmss}.csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (System.IO.StreamWriter writer = new System.IO.StreamWriter(saveFileDialog.FileName, false, System.Text.Encoding.UTF8))
                    {
                        for (int i = 0; i < dgvReporteMovimientos.Columns.Count; i++)
                        {
                            writer.Write(dgvReporteMovimientos.Columns[i].HeaderText);
                            if (i < dgvReporteMovimientos.Columns.Count - 1)
                            {
                                writer.Write(",");
                            }
                        }
                        writer.WriteLine();

                        foreach (DataGridViewRow row in dgvReporteMovimientos.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                for (int i = 0; i < dgvReporteMovimientos.Columns.Count; i++)
                                {
                                    string valor = row.Cells[i].Value != null ? row.Cells[i].Value.ToString() : "";
                                    valor = valor.Replace(",", " ");
                                    writer.Write(valor);

                                    if (i < dgvReporteMovimientos.Columns.Count - 1)
                                    {
                                        writer.Write(",");
                                    }
                                }
                                writer.WriteLine();
                            }
                        }
                    }

                    MessageBox.Show("Reporte exportado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar el reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 6. Eventos de los botones de la interfaz
        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            GenerarReporteMovimientos();
        }

        private void btnExportarReporte_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewaCSV();
        }

        private void EstilizarDataGridViewDashboard()
        {
            if (dgvAlertasStock == null) return;

            dgvAlertasStock.RowHeadersVisible = false;
            dgvAlertasStock.BorderStyle = BorderStyle.None;
            dgvAlertasStock.BackgroundColor = Color.White;
            dgvAlertasStock.DefaultCellStyle.BackColor = Color.White;
            dgvAlertasStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlertasStock.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAlertasStock.GridColor = Color.FromArgb(224, 224, 224);

            dgvAlertasStock.EnableHeadersVisualStyles = false;
            dgvAlertasStock.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvAlertasStock.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(55, 71, 79);
            dgvAlertasStock.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAlertasStock.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvAlertasStock.ColumnHeadersHeight = 35;

            dgvAlertasStock.DefaultCellStyle.Font = new Font("Segoe UI", 9.5f, FontStyle.Regular);
            dgvAlertasStock.DefaultCellStyle.ForeColor = Color.FromArgb(33, 33, 33);
            dgvAlertasStock.DefaultCellStyle.SelectionBackColor = Color.FromArgb(63, 81, 181);
            dgvAlertasStock.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvAlertasStock.RowTemplate.Height = 30;

            if (dgvAlertasStock.Columns["IdProducto"] != null)
            {
                dgvAlertasStock.Columns["IdProducto"].Visible = false;
            }
        }
    }
}
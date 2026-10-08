using System.Drawing;
using MaterialSkin;
using MaterialSkin.Controls;
using StockNova.Entities;

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
                Accent.Orange400,
                TextShade.WHITE
            );

            this.DrawerHighlightWithAccent = false;
            this.DrawerBackgroundWithAccent = false;

            this.Text = $"StockNova - Usuario: {_usuarioLogueado.NombreUsuario} ({_usuarioLogueado.Rol})";

            // Carga las filas de prueba y les aplica el color
            CargarDatosPrueba();
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

                    switch (estado)
                    {
                        case "Sin Stock":
                            row.DefaultCellStyle.BackColor = Color.FromArgb(255, 205, 210); // Rojo pastel
                            row.DefaultCellStyle.ForeColor = Color.DarkRed;
                            break;

                        case "Stock Bajo":
                            row.DefaultCellStyle.BackColor = Color.FromArgb(255, 245, 157); // Amarillo pastel
                            row.DefaultCellStyle.ForeColor = Color.DarkGoldenrod;
                            break;

                        case "Normal":
                            row.DefaultCellStyle.BackColor = Color.FromArgb(200, 230, 201); // Verde pastel
                            row.DefaultCellStyle.ForeColor = Color.DarkGreen;
                            break;
                    }
                }
            }
        }

        private void CargarDatosPrueba()
        {
            // Productos tecnológicos con el formato exacto
            dgvInventario.Rows.Add("TEC-001", "LAPTOP DELL LATITUDE 5500", "Unidades", "Laptops", "5", "0", "Sin Stock");
            dgvInventario.Rows.Add("TEC-002", "MEMORIA RAM DDR4 16GB", "Unidades", "Componentes", "10", "4", "Stock Bajo");
            dgvInventario.Rows.Add("TEC-003", "DISCO SÓLIDO SSD 1TB NVME", "Unidades", "Almacenamiento", "8", "15", "Normal");
            dgvInventario.Rows.Add("TEC-004", "TECLADO MECÁNICO RGB", "Unidades", "Periféricos", "6", "12", "Normal");

            AplicarEstiloEstadoInventario();

            // CENTRAR ÚNICAMENTE CATEGORÍA, STOCK MIN Y STOCK ACTUAL
            if (dgvInventario.Columns.Contains("colCategoria"))
            {
                dgvInventario.Columns["colCategoria"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvInventario.Columns["colCategoria"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvInventario.Columns.Contains("colStockMin"))
            {
                dgvInventario.Columns["colStockMin"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvInventario.Columns["colStockMin"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvInventario.Columns.Contains("colStockActual"))
            {
                dgvInventario.Columns["colStockActual"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvInventario.Columns["colStockActual"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgvInventario.ClearSelection();
            dgvInventario.CurrentCell = null;
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
    }
}
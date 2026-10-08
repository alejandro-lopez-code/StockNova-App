namespace StockNova.UI
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tcMenuPrincipal = new MaterialSkin.Controls.MaterialTabControl();
            tabDashboard = new TabPage();
            tabNuevoProducto = new TabPage();
            tabMovimientos = new TabPage();
            tabInventario = new TabPage();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            dgvInventario = new DataGridView();
            colCodigo = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colUnidad = new DataGridViewTextBoxColumn();
            colCategoria = new DataGridViewTextBoxColumn();
            colStockMin = new DataGridViewTextBoxColumn();
            colStockActual = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            colAcciones = new DataGridViewButtonColumn();
            btnAlertas = new MaterialSkin.Controls.MaterialButton();
            btnExportarCSV = new MaterialSkin.Controls.MaterialButton();
            btnActualizarStock = new MaterialSkin.Controls.MaterialButton();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            tabReportes = new TabPage();
            tabBuscar = new TabPage();
            tabConfiguracion = new TabPage();
            tabEspacio1 = new TabPage();
            tabEspacio2 = new TabPage();
            tabEspacio3 = new TabPage();
            tabCerrarSesion = new TabPage();
            tcMenuPrincipal.SuspendLayout();
            tabInventario.SuspendLayout();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            SuspendLayout();
            // 
            // tcMenuPrincipal
            // 
            tcMenuPrincipal.Controls.Add(tabDashboard);
            tcMenuPrincipal.Controls.Add(tabNuevoProducto);
            tcMenuPrincipal.Controls.Add(tabMovimientos);
            tcMenuPrincipal.Controls.Add(tabInventario);
            tcMenuPrincipal.Controls.Add(tabReportes);
            tcMenuPrincipal.Controls.Add(tabBuscar);
            tcMenuPrincipal.Controls.Add(tabConfiguracion);
            tcMenuPrincipal.Controls.Add(tabEspacio1);
            tcMenuPrincipal.Controls.Add(tabEspacio2);
            tcMenuPrincipal.Controls.Add(tabEspacio3);
            tcMenuPrincipal.Controls.Add(tabCerrarSesion);
            tcMenuPrincipal.Depth = 0;
            tcMenuPrincipal.Dock = DockStyle.Fill;
            tcMenuPrincipal.Location = new Point(3, 64);
            tcMenuPrincipal.MouseState = MaterialSkin.MouseState.HOVER;
            tcMenuPrincipal.Multiline = true;
            tcMenuPrincipal.Name = "tcMenuPrincipal";
            tcMenuPrincipal.SelectedIndex = 0;
            tcMenuPrincipal.Size = new Size(1302, 539);
            tcMenuPrincipal.TabIndex = 0;
            tcMenuPrincipal.SelectedIndexChanged += tcMenuPrincipal_SelectedIndexChanged;
            // 
            // tabDashboard
            // 
            tabDashboard.Location = new Point(4, 29);
            tabDashboard.Name = "tabDashboard";
            tabDashboard.Padding = new Padding(3);
            tabDashboard.Size = new Size(1294, 506);
            tabDashboard.TabIndex = 0;
            tabDashboard.Text = "Dashboard";
            tabDashboard.UseVisualStyleBackColor = true;
            // 
            // tabNuevoProducto
            // 
            tabNuevoProducto.Location = new Point(4, 29);
            tabNuevoProducto.Name = "tabNuevoProducto";
            tabNuevoProducto.Padding = new Padding(3);
            tabNuevoProducto.Size = new Size(1294, 506);
            tabNuevoProducto.TabIndex = 1;
            tabNuevoProducto.Text = "Nuevo Producto";
            tabNuevoProducto.UseVisualStyleBackColor = true;
            // 
            // tabMovimientos
            // 
            tabMovimientos.Location = new Point(4, 29);
            tabMovimientos.Name = "tabMovimientos";
            tabMovimientos.Size = new Size(1294, 506);
            tabMovimientos.TabIndex = 2;
            tabMovimientos.Text = "Movimientos";
            tabMovimientos.UseVisualStyleBackColor = true;
            // 
            // tabInventario
            // 
            tabInventario.Controls.Add(materialCard1);
            tabInventario.Controls.Add(materialLabel1);
            tabInventario.Location = new Point(4, 29);
            tabInventario.Name = "tabInventario";
            tabInventario.Size = new Size(1294, 506);
            tabInventario.TabIndex = 3;
            tabInventario.Text = "Inventario";
            tabInventario.UseVisualStyleBackColor = true;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(dgvInventario);
            materialCard1.Controls.Add(btnAlertas);
            materialCard1.Controls.Add(btnExportarCSV);
            materialCard1.Controls.Add(btnActualizarStock);
            materialCard1.Controls.Add(materialLabel2);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(66, 85);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(1096, 391);
            materialCard1.TabIndex = 1;
            // 
            // dgvInventario
            // 
            dgvInventario.AllowUserToAddRows = false;
            dgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventario.BackgroundColor = Color.White;
            dgvInventario.BorderStyle = BorderStyle.None;
            dgvInventario.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvInventario.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Columns.AddRange(new DataGridViewColumn[] { colCodigo, colNombre, colUnidad, colCategoria, colStockMin, colStockActual, colEstado, colAcciones });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvInventario.DefaultCellStyle = dataGridViewCellStyle3;
            dgvInventario.EnableHeadersVisualStyles = false;
            dgvInventario.GridColor = Color.White;
            dgvInventario.Location = new Point(56, 135);
            dgvInventario.MultiSelect = false;
            dgvInventario.Name = "dgvInventario";
            dgvInventario.ReadOnly = true;
            dgvInventario.RowHeadersVisible = false;
            dgvInventario.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvInventario.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvInventario.RowTemplate.Height = 45;
            dgvInventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventario.Size = new Size(980, 211);
            dgvInventario.TabIndex = 4;
            dgvInventario.CellPainting += dgvInventario_CellPainting;
            // 
            // colCodigo
            // 
            colCodigo.HeaderText = "Código";
            colCodigo.MinimumWidth = 6;
            colCodigo.Name = "colCodigo";
            colCodigo.ReadOnly = true;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 6;
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            // 
            // colUnidad
            // 
            colUnidad.HeaderText = "Unidad";
            colUnidad.MinimumWidth = 6;
            colUnidad.Name = "colUnidad";
            colUnidad.ReadOnly = true;
            // 
            // colCategoria
            // 
            colCategoria.DataPropertyName = "Categoria";
            colCategoria.HeaderText = "Categoría";
            colCategoria.MinimumWidth = 6;
            colCategoria.Name = "colCategoria";
            colCategoria.ReadOnly = true;
            // 
            // colStockMin
            // 
            colStockMin.HeaderText = "Stock Min.";
            colStockMin.MinimumWidth = 6;
            colStockMin.Name = "colStockMin";
            colStockMin.ReadOnly = true;
            // 
            // colStockActual
            // 
            colStockActual.HeaderText = "Stock Actual";
            colStockActual.MinimumWidth = 6;
            colStockActual.Name = "colStockActual";
            colStockActual.ReadOnly = true;
            // 
            // colEstado
            // 
            colEstado.HeaderText = "Estado";
            colEstado.MinimumWidth = 6;
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;
            // 
            // colAcciones
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.DarkSlateGray;
            dataGridViewCellStyle2.Padding = new Padding(4, 4, 8, 8);
            colAcciones.DefaultCellStyle = dataGridViewCellStyle2;
            colAcciones.HeaderText = "Acciones";
            colAcciones.MinimumWidth = 6;
            colAcciones.Name = "colAcciones";
            colAcciones.ReadOnly = true;
            colAcciones.Text = "Ver";
            colAcciones.UseColumnTextForButtonValue = true;
            // 
            // btnAlertas
            // 
            btnAlertas.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAlertas.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAlertas.Depth = 0;
            btnAlertas.HighEmphasis = true;
            btnAlertas.Icon = null;
            btnAlertas.Location = new Point(362, 76);
            btnAlertas.Margin = new Padding(4, 6, 4, 6);
            btnAlertas.MouseState = MaterialSkin.MouseState.HOVER;
            btnAlertas.Name = "btnAlertas";
            btnAlertas.NoAccentTextColor = Color.Empty;
            btnAlertas.Size = new Size(125, 36);
            btnAlertas.TabIndex = 3;
            btnAlertas.Text = "Solo Alertas";
            btnAlertas.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAlertas.UseAccentColor = false;
            btnAlertas.UseVisualStyleBackColor = true;
            // 
            // btnExportarCSV
            // 
            btnExportarCSV.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExportarCSV.BackColor = Color.White;
            btnExportarCSV.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnExportarCSV.Depth = 0;
            btnExportarCSV.ForeColor = Color.SlateGray;
            btnExportarCSV.HighEmphasis = true;
            btnExportarCSV.Icon = null;
            btnExportarCSV.Location = new Point(227, 76);
            btnExportarCSV.Margin = new Padding(4, 6, 4, 6);
            btnExportarCSV.MouseState = MaterialSkin.MouseState.HOVER;
            btnExportarCSV.Name = "btnExportarCSV";
            btnExportarCSV.NoAccentTextColor = Color.Empty;
            btnExportarCSV.Size = new Size(127, 36);
            btnExportarCSV.TabIndex = 2;
            btnExportarCSV.Text = "Exportar CSV";
            btnExportarCSV.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnExportarCSV.UseAccentColor = false;
            btnExportarCSV.UseVisualStyleBackColor = false;
            // 
            // btnActualizarStock
            // 
            btnActualizarStock.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnActualizarStock.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnActualizarStock.Depth = 0;
            btnActualizarStock.HighEmphasis = true;
            btnActualizarStock.Icon = null;
            btnActualizarStock.Location = new Point(60, 76);
            btnActualizarStock.Margin = new Padding(4, 6, 4, 6);
            btnActualizarStock.MouseState = MaterialSkin.MouseState.HOVER;
            btnActualizarStock.Name = "btnActualizarStock";
            btnActualizarStock.NoAccentTextColor = Color.Empty;
            btnActualizarStock.Size = new Size(159, 36);
            btnActualizarStock.TabIndex = 1;
            btnActualizarStock.Text = "Actualizar Stock";
            btnActualizarStock.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnActualizarStock.UseAccentColor = false;
            btnActualizarStock.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel2.Location = new Point(27, 24);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(137, 29);
            materialLabel2.TabIndex = 0;
            materialLabel2.Text = "Stock Actual";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel1.HighEmphasis = true;
            materialLabel1.Location = new Point(66, 23);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(226, 29);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Control de Inventario";
            // 
            // tabReportes
            // 
            tabReportes.Location = new Point(4, 29);
            tabReportes.Name = "tabReportes";
            tabReportes.Size = new Size(1294, 506);
            tabReportes.TabIndex = 4;
            tabReportes.Text = "Reportes";
            tabReportes.UseVisualStyleBackColor = true;
            // 
            // tabBuscar
            // 
            tabBuscar.Location = new Point(4, 29);
            tabBuscar.Name = "tabBuscar";
            tabBuscar.Size = new Size(1294, 506);
            tabBuscar.TabIndex = 5;
            tabBuscar.Text = "Buscar";
            tabBuscar.UseVisualStyleBackColor = true;
            // 
            // tabConfiguracion
            // 
            tabConfiguracion.Location = new Point(4, 29);
            tabConfiguracion.Name = "tabConfiguracion";
            tabConfiguracion.Size = new Size(1294, 506);
            tabConfiguracion.TabIndex = 6;
            tabConfiguracion.Text = "Configuración";
            tabConfiguracion.UseVisualStyleBackColor = true;
            // 
            // tabEspacio1
            // 
            tabEspacio1.Location = new Point(4, 29);
            tabEspacio1.Name = "tabEspacio1";
            tabEspacio1.Size = new Size(1294, 506);
            tabEspacio1.TabIndex = 8;
            tabEspacio1.UseVisualStyleBackColor = true;
            // 
            // tabEspacio2
            // 
            tabEspacio2.Location = new Point(4, 29);
            tabEspacio2.Name = "tabEspacio2";
            tabEspacio2.Size = new Size(1294, 506);
            tabEspacio2.TabIndex = 9;
            tabEspacio2.UseVisualStyleBackColor = true;
            // 
            // tabEspacio3
            // 
            tabEspacio3.Location = new Point(4, 29);
            tabEspacio3.Name = "tabEspacio3";
            tabEspacio3.Size = new Size(1294, 506);
            tabEspacio3.TabIndex = 10;
            tabEspacio3.UseVisualStyleBackColor = true;
            // 
            // tabCerrarSesion
            // 
            tabCerrarSesion.Location = new Point(4, 29);
            tabCerrarSesion.Name = "tabCerrarSesion";
            tabCerrarSesion.Size = new Size(1294, 506);
            tabCerrarSesion.TabIndex = 7;
            tabCerrarSesion.Text = "Cerrar Sesión";
            tabCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1308, 606);
            Controls.Add(tcMenuPrincipal);
            DrawerTabControl = tcMenuPrincipal;
            Name = "FrmMenuPrincipal";
            Text = "FrmMenuPrincipal";
            Shown += FrmMenuPrincipal_Shown;
            tcMenuPrincipal.ResumeLayout(false);
            tabInventario.ResumeLayout(false);
            tabInventario.PerformLayout();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tcMenuPrincipal;
        private TabPage tabDashboard;
        private TabPage tabNuevoProducto;
        private TabPage tabMovimientos;
        private TabPage tabInventario;
        private TabPage tabReportes;
        private TabPage tabBuscar;
        private TabPage tabConfiguracion;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton btnAlertas;
        private MaterialSkin.Controls.MaterialButton btnExportarCSV;
        private MaterialSkin.Controls.MaterialButton btnActualizarStock;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private DataGridView dgvInventario;
        private TabPage tabCerrarSesion;
        private TabPage tabEspacio1;
        private TabPage tabEspacio2;
        private TabPage tabEspacio3;
        private DataGridViewTextBoxColumn colCodigo;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colUnidad;
        private DataGridViewTextBoxColumn colCategoria;
        private DataGridViewTextBoxColumn colStockMin;
        private DataGridViewTextBoxColumn colStockActual;
        private DataGridViewTextBoxColumn colEstado;
        private DataGridViewButtonColumn colAcciones;
    }
}
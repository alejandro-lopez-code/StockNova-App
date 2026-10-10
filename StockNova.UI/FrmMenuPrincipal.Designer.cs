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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tcMenuPrincipal = new MaterialSkin.Controls.MaterialTabControl();
            tabDashboard = new TabPage();
            cardAlertasStock = new MaterialSkin.Controls.MaterialCard();
            dataGridView1 = new DataGridView();
            btnVerAlertas = new MaterialSkin.Controls.MaterialButton();
            btnActualizarDashboard = new MaterialSkin.Controls.MaterialButton();
            materialLabel23 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel18 = new MaterialSkin.Controls.MaterialLabel();
            materialCard5 = new MaterialSkin.Controls.MaterialCard();
            lblStockBajo = new MaterialSkin.Controls.MaterialLabel();
            materialLabel28 = new MaterialSkin.Controls.MaterialLabel();
            materialCard4 = new MaterialSkin.Controls.MaterialCard();
            lblSinStock = new MaterialSkin.Controls.MaterialLabel();
            materialLabel26 = new MaterialSkin.Controls.MaterialLabel();
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            lblTotalMovimientos = new MaterialSkin.Controls.MaterialLabel();
            materialLabel24 = new MaterialSkin.Controls.MaterialLabel();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            lblTotalProductos = new MaterialSkin.Controls.MaterialLabel();
            materialLabel22 = new MaterialSkin.Controls.MaterialLabel();
            tabNuevoProducto = new TabPage();
            materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            cardNuevoProducto = new MaterialSkin.Controls.MaterialCard();
            btnLimpiar = new MaterialSkin.Controls.MaterialButton();
            btnRegistrarProducto = new MaterialSkin.Controls.MaterialButton();
            materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            txtStockMinimo = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            cmbGrupo = new MaterialSkin.Controls.MaterialComboBox();
            cmbUnidadMedida = new MaterialSkin.Controls.MaterialComboBox();
            txtNombre = new MaterialSkin.Controls.MaterialTextBox2();
            txtCodigo = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            tabMovimientos = new TabPage();
            materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            cardNuevoMovimiento = new MaterialSkin.Controls.MaterialCard();
            btnLimpiarMovimiento = new MaterialSkin.Controls.MaterialButton();
            btnGuardarMovimiento = new MaterialSkin.Controls.MaterialButton();
            materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            txtObservaciones = new MaterialSkin.Controls.MaterialTextBox2();
            cmbTipoMovimiento = new MaterialSkin.Controls.MaterialComboBox();
            dtpFechaMovimiento = new DateTimePicker();
            txtCantidadMovimiento = new MaterialSkin.Controls.MaterialTextBox2();
            txtCodigoMovimiento = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
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
            materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            cardReporteMovimientos = new MaterialSkin.Controls.MaterialCard();
            btnExportarReporte = new MaterialSkin.Controls.MaterialButton();
            btnGenerarReporte = new MaterialSkin.Controls.MaterialButton();
            cmbFiltroTipo = new MaterialSkin.Controls.MaterialComboBox();
            dtpFechaHasta = new DateTimePicker();
            dtpFechaDesde = new DateTimePicker();
            materialLabel21 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel20 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel19 = new MaterialSkin.Controls.MaterialLabel();
            lblTituloReportes = new MaterialSkin.Controls.MaterialLabel();
            tabBuscar = new TabPage();
            materialLabel27 = new MaterialSkin.Controls.MaterialLabel();
            cardBuscarProductos = new MaterialSkin.Controls.MaterialCard();
            materialLabel29 = new MaterialSkin.Controls.MaterialLabel();
            dgvResultadosBusqueda = new DataGridView();
            btnLimpiarBusqueda = new MaterialSkin.Controls.MaterialButton();
            btnBuscarProducto = new MaterialSkin.Controls.MaterialButton();
            txtCriterioBusqueda = new MaterialSkin.Controls.MaterialTextBox2();
            lblTituloBuscar = new MaterialSkin.Controls.MaterialLabel();
            tabConfiguracion = new TabPage();
            materialLabel25 = new MaterialSkin.Controls.MaterialLabel();
            cardHerramientasAdmin = new MaterialSkin.Controls.MaterialCard();
            pnlEstadoConfig = new Panel();
            lblEstadoConfig = new MaterialSkin.Controls.MaterialLabel();
            btnResetSistema = new MaterialSkin.Controls.MaterialButton();
            btnLimpiarTodo = new MaterialSkin.Controls.MaterialButton();
            btnInicializarSistema = new MaterialSkin.Controls.MaterialButton();
            btnValidarIntegridad = new MaterialSkin.Controls.MaterialButton();
            lblHerramientasAdmin = new MaterialSkin.Controls.MaterialLabel();
            tabEspacio1 = new TabPage();
            tabEspacio2 = new TabPage();
            tabEspacio3 = new TabPage();
            tabCerrarSesion = new TabPage();
            tcMenuPrincipal.SuspendLayout();
            tabDashboard.SuspendLayout();
            cardAlertasStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            materialCard5.SuspendLayout();
            materialCard4.SuspendLayout();
            materialCard3.SuspendLayout();
            materialCard2.SuspendLayout();
            tabNuevoProducto.SuspendLayout();
            cardNuevoProducto.SuspendLayout();
            tabMovimientos.SuspendLayout();
            cardNuevoMovimiento.SuspendLayout();
            tabInventario.SuspendLayout();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            tabReportes.SuspendLayout();
            cardReporteMovimientos.SuspendLayout();
            tabBuscar.SuspendLayout();
            cardBuscarProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultadosBusqueda).BeginInit();
            tabConfiguracion.SuspendLayout();
            cardHerramientasAdmin.SuspendLayout();
            pnlEstadoConfig.SuspendLayout();
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
            tcMenuPrincipal.Size = new Size(1302, 564);
            tcMenuPrincipal.TabIndex = 0;
            tcMenuPrincipal.SelectedIndexChanged += tcMenuPrincipal_SelectedIndexChanged;
            // 
            // tabDashboard
            // 
            tabDashboard.Controls.Add(cardAlertasStock);
            tabDashboard.Controls.Add(materialLabel18);
            tabDashboard.Controls.Add(materialCard5);
            tabDashboard.Controls.Add(materialCard4);
            tabDashboard.Controls.Add(materialCard3);
            tabDashboard.Controls.Add(materialCard2);
            tabDashboard.Location = new Point(4, 29);
            tabDashboard.Name = "tabDashboard";
            tabDashboard.Padding = new Padding(3);
            tabDashboard.Size = new Size(1294, 531);
            tabDashboard.TabIndex = 0;
            tabDashboard.Text = "Dashboard";
            tabDashboard.UseVisualStyleBackColor = true;
            // 
            // cardAlertasStock
            // 
            cardAlertasStock.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cardAlertasStock.BackColor = Color.FromArgb(255, 255, 255);
            cardAlertasStock.Controls.Add(dataGridView1);
            cardAlertasStock.Controls.Add(btnVerAlertas);
            cardAlertasStock.Controls.Add(btnActualizarDashboard);
            cardAlertasStock.Controls.Add(materialLabel23);
            cardAlertasStock.Depth = 0;
            cardAlertasStock.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cardAlertasStock.Location = new Point(89, 250);
            cardAlertasStock.Margin = new Padding(14);
            cardAlertasStock.MouseState = MaterialSkin.MouseState.HOVER;
            cardAlertasStock.Name = "cardAlertasStock";
            cardAlertasStock.Padding = new Padding(14);
            cardAlertasStock.Size = new Size(1078, 235);
            cardAlertasStock.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Navy;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(35, 131);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1004, 66);
            dataGridView1.TabIndex = 3;
            // 
            // btnVerAlertas
            // 
            btnVerAlertas.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVerAlertas.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnVerAlertas.Depth = 0;
            btnVerAlertas.HighEmphasis = true;
            btnVerAlertas.Icon = null;
            btnVerAlertas.Location = new Point(258, 69);
            btnVerAlertas.Margin = new Padding(4, 6, 4, 6);
            btnVerAlertas.MouseState = MaterialSkin.MouseState.HOVER;
            btnVerAlertas.Name = "btnVerAlertas";
            btnVerAlertas.NoAccentTextColor = Color.Empty;
            btnVerAlertas.Size = new Size(187, 36);
            btnVerAlertas.TabIndex = 2;
            btnVerAlertas.Text = "VER ALERTAS DE STOCK";
            btnVerAlertas.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnVerAlertas.UseAccentColor = false;
            btnVerAlertas.UseVisualStyleBackColor = true;
            // 
            // btnActualizarDashboard
            // 
            btnActualizarDashboard.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnActualizarDashboard.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnActualizarDashboard.Depth = 0;
            btnActualizarDashboard.HighEmphasis = true;
            btnActualizarDashboard.Icon = null;
            btnActualizarDashboard.Location = new Point(35, 69);
            btnActualizarDashboard.Margin = new Padding(4, 6, 4, 6);
            btnActualizarDashboard.MouseState = MaterialSkin.MouseState.HOVER;
            btnActualizarDashboard.Name = "btnActualizarDashboard";
            btnActualizarDashboard.NoAccentTextColor = Color.Empty;
            btnActualizarDashboard.Size = new Size(199, 36);
            btnActualizarDashboard.TabIndex = 1;
            btnActualizarDashboard.Text = "ACTUALIZAR DASHBOARD";
            btnActualizarDashboard.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnActualizarDashboard.UseAccentColor = false;
            btnActualizarDashboard.UseVisualStyleBackColor = true;
            // 
            // materialLabel23
            // 
            materialLabel23.AutoSize = true;
            materialLabel23.Depth = 0;
            materialLabel23.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel23.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel23.Location = new Point(35, 25);
            materialLabel23.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel23.Name = "materialLabel23";
            materialLabel23.Size = new Size(177, 29);
            materialLabel23.TabIndex = 0;
            materialLabel23.Text = "Alertas de Stock";
            // 
            // materialLabel18
            // 
            materialLabel18.AutoSize = true;
            materialLabel18.Depth = 0;
            materialLabel18.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel18.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel18.Location = new Point(92, 26);
            materialLabel18.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel18.Name = "materialLabel18";
            materialLabel18.Size = new Size(211, 29);
            materialLabel18.TabIndex = 0;
            materialLabel18.Text = "Dashboard General ";
            // 
            // materialCard5
            // 
            materialCard5.BackColor = Color.FromArgb(255, 255, 255);
            materialCard5.Controls.Add(lblStockBajo);
            materialCard5.Controls.Add(materialLabel28);
            materialCard5.Depth = 0;
            materialCard5.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard5.Location = new Point(926, 82);
            materialCard5.Margin = new Padding(14);
            materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard5.Name = "materialCard5";
            materialCard5.Padding = new Padding(14);
            materialCard5.Size = new Size(250, 125);
            materialCard5.TabIndex = 3;
            // 
            // lblStockBajo
            // 
            lblStockBajo.AutoSize = true;
            lblStockBajo.Depth = 0;
            lblStockBajo.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblStockBajo.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            lblStockBajo.Location = new Point(106, 30);
            lblStockBajo.MouseState = MaterialSkin.MouseState.HOVER;
            lblStockBajo.Name = "lblStockBajo";
            lblStockBajo.Size = new Size(20, 41);
            lblStockBajo.TabIndex = 1;
            lblStockBajo.Text = "0";
            // 
            // materialLabel28
            // 
            materialLabel28.AutoSize = true;
            materialLabel28.Depth = 0;
            materialLabel28.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel28.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            materialLabel28.Location = new Point(83, 85);
            materialLabel28.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel28.Name = "materialLabel28";
            materialLabel28.Size = new Size(68, 17);
            materialLabel28.TabIndex = 0;
            materialLabel28.Text = "Stock Bajo";
            // 
            // materialCard4
            // 
            materialCard4.BackColor = Color.FromArgb(255, 255, 255);
            materialCard4.Controls.Add(lblSinStock);
            materialCard4.Controls.Add(materialLabel26);
            materialCard4.Depth = 0;
            materialCard4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard4.Location = new Point(648, 82);
            materialCard4.Margin = new Padding(14);
            materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard4.Name = "materialCard4";
            materialCard4.Padding = new Padding(14);
            materialCard4.Size = new Size(250, 125);
            materialCard4.TabIndex = 2;
            // 
            // lblSinStock
            // 
            lblSinStock.AutoSize = true;
            lblSinStock.Depth = 0;
            lblSinStock.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblSinStock.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            lblSinStock.Location = new Point(104, 30);
            lblSinStock.MouseState = MaterialSkin.MouseState.HOVER;
            lblSinStock.Name = "lblSinStock";
            lblSinStock.Size = new Size(20, 41);
            lblSinStock.TabIndex = 1;
            lblSinStock.Text = "0";
            // 
            // materialLabel26
            // 
            materialLabel26.AutoSize = true;
            materialLabel26.Depth = 0;
            materialLabel26.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel26.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            materialLabel26.Location = new Point(88, 85);
            materialLabel26.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel26.Name = "materialLabel26";
            materialLabel26.Size = new Size(59, 17);
            materialLabel26.TabIndex = 0;
            materialLabel26.Text = "Sin Stock";
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(lblTotalMovimientos);
            materialCard3.Controls.Add(materialLabel24);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(370, 82);
            materialCard3.Margin = new Padding(14);
            materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14);
            materialCard3.Size = new Size(250, 125);
            materialCard3.TabIndex = 1;
            // 
            // lblTotalMovimientos
            // 
            lblTotalMovimientos.AutoSize = true;
            lblTotalMovimientos.Depth = 0;
            lblTotalMovimientos.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblTotalMovimientos.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            lblTotalMovimientos.Location = new Point(108, 30);
            lblTotalMovimientos.MouseState = MaterialSkin.MouseState.HOVER;
            lblTotalMovimientos.Name = "lblTotalMovimientos";
            lblTotalMovimientos.Size = new Size(20, 41);
            lblTotalMovimientos.TabIndex = 1;
            lblTotalMovimientos.Text = "0";
            // 
            // materialLabel24
            // 
            materialLabel24.AutoSize = true;
            materialLabel24.Depth = 0;
            materialLabel24.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel24.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            materialLabel24.Location = new Point(66, 85);
            materialLabel24.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel24.Name = "materialLabel24";
            materialLabel24.Size = new Size(121, 17);
            materialLabel24.TabIndex = 0;
            materialLabel24.Text = "Total Movimientos";
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(lblTotalProductos);
            materialCard2.Controls.Add(materialLabel22);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(92, 82);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(250, 125);
            materialCard2.TabIndex = 0;
            // 
            // lblTotalProductos
            // 
            lblTotalProductos.AutoSize = true;
            lblTotalProductos.Depth = 0;
            lblTotalProductos.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblTotalProductos.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            lblTotalProductos.Location = new Point(107, 30);
            lblTotalProductos.MouseState = MaterialSkin.MouseState.HOVER;
            lblTotalProductos.Name = "lblTotalProductos";
            lblTotalProductos.Size = new Size(20, 41);
            lblTotalProductos.TabIndex = 1;
            lblTotalProductos.Text = "0";
            // 
            // materialLabel22
            // 
            materialLabel22.AutoSize = true;
            materialLabel22.Depth = 0;
            materialLabel22.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel22.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            materialLabel22.Location = new Point(64, 85);
            materialLabel22.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel22.Name = "materialLabel22";
            materialLabel22.Size = new Size(103, 17);
            materialLabel22.TabIndex = 0;
            materialLabel22.Text = "Total Productos";
            // 
            // tabNuevoProducto
            // 
            tabNuevoProducto.Controls.Add(materialLabel16);
            tabNuevoProducto.Controls.Add(cardNuevoProducto);
            tabNuevoProducto.Location = new Point(4, 29);
            tabNuevoProducto.Name = "tabNuevoProducto";
            tabNuevoProducto.Padding = new Padding(3);
            tabNuevoProducto.Size = new Size(1294, 531);
            tabNuevoProducto.TabIndex = 1;
            tabNuevoProducto.Text = "Nuevo Producto";
            tabNuevoProducto.UseVisualStyleBackColor = true;
            // 
            // materialLabel16
            // 
            materialLabel16.AutoSize = true;
            materialLabel16.Depth = 0;
            materialLabel16.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel16.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel16.Location = new Point(69, 33);
            materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel16.Name = "materialLabel16";
            materialLabel16.Size = new Size(239, 29);
            materialLabel16.TabIndex = 1;
            materialLabel16.Text = "Gestión de Productos ";
            // 
            // cardNuevoProducto
            // 
            cardNuevoProducto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cardNuevoProducto.BackColor = Color.FromArgb(255, 255, 255);
            cardNuevoProducto.Controls.Add(btnLimpiar);
            cardNuevoProducto.Controls.Add(btnRegistrarProducto);
            cardNuevoProducto.Controls.Add(materialLabel8);
            cardNuevoProducto.Controls.Add(txtStockMinimo);
            cardNuevoProducto.Controls.Add(materialLabel7);
            cardNuevoProducto.Controls.Add(materialLabel6);
            cardNuevoProducto.Controls.Add(materialLabel5);
            cardNuevoProducto.Controls.Add(materialLabel4);
            cardNuevoProducto.Controls.Add(cmbGrupo);
            cardNuevoProducto.Controls.Add(cmbUnidadMedida);
            cardNuevoProducto.Controls.Add(txtNombre);
            cardNuevoProducto.Controls.Add(txtCodigo);
            cardNuevoProducto.Controls.Add(materialLabel3);
            cardNuevoProducto.Depth = 0;
            cardNuevoProducto.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cardNuevoProducto.Location = new Point(69, 92);
            cardNuevoProducto.Margin = new Padding(30);
            cardNuevoProducto.MouseState = MaterialSkin.MouseState.HOVER;
            cardNuevoProducto.Name = "cardNuevoProducto";
            cardNuevoProducto.Padding = new Padding(14);
            cardNuevoProducto.Size = new Size(1168, 377);
            cardNuevoProducto.TabIndex = 0;
            // 
            // btnLimpiar
            // 
            btnLimpiar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLimpiar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLimpiar.Depth = 0;
            btnLimpiar.HighEmphasis = true;
            btnLimpiar.Icon = null;
            btnLimpiar.Location = new Point(263, 302);
            btnLimpiar.Margin = new Padding(4, 6, 4, 6);
            btnLimpiar.MouseState = MaterialSkin.MouseState.HOVER;
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.NoAccentTextColor = Color.Empty;
            btnLimpiar.Size = new Size(79, 36);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnLimpiar.UseAccentColor = false;
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarProducto
            // 
            btnRegistrarProducto.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRegistrarProducto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRegistrarProducto.Depth = 0;
            btnRegistrarProducto.HighEmphasis = true;
            btnRegistrarProducto.Icon = null;
            btnRegistrarProducto.Location = new Point(51, 302);
            btnRegistrarProducto.Margin = new Padding(4, 6, 4, 6);
            btnRegistrarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            btnRegistrarProducto.Name = "btnRegistrarProducto";
            btnRegistrarProducto.NoAccentTextColor = Color.Empty;
            btnRegistrarProducto.Size = new Size(179, 36);
            btnRegistrarProducto.TabIndex = 11;
            btnRegistrarProducto.Text = "REGISTRAR PRODUCTO";
            btnRegistrarProducto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRegistrarProducto.UseAccentColor = false;
            btnRegistrarProducto.UseVisualStyleBackColor = true;
            // 
            // materialLabel8
            // 
            materialLabel8.AutoSize = true;
            materialLabel8.Depth = 0;
            materialLabel8.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel8.Location = new Point(51, 187);
            materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(99, 19);
            materialLabel8.TabIndex = 10;
            materialLabel8.Text = "Stock Mínimo";
            // 
            // txtStockMinimo
            // 
            txtStockMinimo.AnimateReadOnly = false;
            txtStockMinimo.BackgroundImageLayout = ImageLayout.None;
            txtStockMinimo.CharacterCasing = CharacterCasing.Normal;
            txtStockMinimo.Depth = 0;
            txtStockMinimo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtStockMinimo.HideSelection = true;
            txtStockMinimo.LeadingIcon = null;
            txtStockMinimo.Location = new Point(51, 222);
            txtStockMinimo.MaxLength = 32767;
            txtStockMinimo.MouseState = MaterialSkin.MouseState.OUT;
            txtStockMinimo.Name = "txtStockMinimo";
            txtStockMinimo.PasswordChar = '\0';
            txtStockMinimo.PrefixSuffixText = null;
            txtStockMinimo.ReadOnly = false;
            txtStockMinimo.RightToLeft = RightToLeft.No;
            txtStockMinimo.SelectedText = "";
            txtStockMinimo.SelectionLength = 0;
            txtStockMinimo.SelectionStart = 0;
            txtStockMinimo.ShortcutsEnabled = true;
            txtStockMinimo.Size = new Size(180, 48);
            txtStockMinimo.TabIndex = 9;
            txtStockMinimo.TabStop = false;
            txtStockMinimo.TextAlign = HorizontalAlignment.Left;
            txtStockMinimo.TrailingIcon = null;
            txtStockMinimo.UseSystemPasswordChar = false;
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(772, 77);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(52, 19);
            materialLabel7.TabIndex = 8;
            materialLabel7.Text = "Grupos";
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(550, 77);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(129, 19);
            materialLabel6.TabIndex = 7;
            materialLabel6.Text = "Unidad de Medida";
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(270, 77);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(72, 19);
            materialLabel5.TabIndex = 6;
            materialLabel5.Text = "Nombre * ";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(51, 77);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(62, 19);
            materialLabel4.TabIndex = 5;
            materialLabel4.Text = "Código *";
            // 
            // cmbGrupo
            // 
            cmbGrupo.AutoResize = false;
            cmbGrupo.BackColor = Color.FromArgb(255, 255, 255);
            cmbGrupo.Depth = 0;
            cmbGrupo.DrawMode = DrawMode.OwnerDrawVariable;
            cmbGrupo.DropDownHeight = 174;
            cmbGrupo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGrupo.DropDownWidth = 121;
            cmbGrupo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbGrupo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbGrupo.FormattingEnabled = true;
            cmbGrupo.IntegralHeight = false;
            cmbGrupo.ItemHeight = 43;
            cmbGrupo.Items.AddRange(new object[] { "Laptops y Computadoras", "Componentes (RAM, SSD, GPU)", "Periféricos (Teclado, Mouse)", "Monitores y Pantallas", "Redes y Conectividad", "Accesorios y Cables", "Almacenamiento Externo", "Audio y Sonido" });
            cmbGrupo.Location = new Point(772, 109);
            cmbGrupo.MaxDropDownItems = 4;
            cmbGrupo.MouseState = MaterialSkin.MouseState.OUT;
            cmbGrupo.Name = "cmbGrupo";
            cmbGrupo.Size = new Size(288, 49);
            cmbGrupo.StartIndex = 0;
            cmbGrupo.TabIndex = 4;
            // 
            // cmbUnidadMedida
            // 
            cmbUnidadMedida.AutoResize = false;
            cmbUnidadMedida.BackColor = Color.FromArgb(255, 255, 255);
            cmbUnidadMedida.Depth = 0;
            cmbUnidadMedida.DrawMode = DrawMode.OwnerDrawVariable;
            cmbUnidadMedida.DropDownHeight = 174;
            cmbUnidadMedida.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUnidadMedida.DropDownWidth = 121;
            cmbUnidadMedida.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbUnidadMedida.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbUnidadMedida.FormattingEnabled = true;
            cmbUnidadMedida.IntegralHeight = false;
            cmbUnidadMedida.ItemHeight = 43;
            cmbUnidadMedida.Items.AddRange(new object[] { "Unidad (Unid)", "Pieza (Pza)", "Kit / Combo", "Caja", "Par" });
            cmbUnidadMedida.Location = new Point(550, 109);
            cmbUnidadMedida.MaxDropDownItems = 4;
            cmbUnidadMedida.MouseState = MaterialSkin.MouseState.OUT;
            cmbUnidadMedida.Name = "cmbUnidadMedida";
            cmbUnidadMedida.Size = new Size(180, 49);
            cmbUnidadMedida.StartIndex = 0;
            cmbUnidadMedida.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.AnimateReadOnly = false;
            txtNombre.BackgroundImageLayout = ImageLayout.None;
            txtNombre.CharacterCasing = CharacterCasing.Normal;
            txtNombre.Depth = 0;
            txtNombre.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNombre.HideSelection = true;
            txtNombre.LeadingIcon = null;
            txtNombre.Location = new Point(270, 110);
            txtNombre.MaxLength = 32767;
            txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            txtNombre.Name = "txtNombre";
            txtNombre.PasswordChar = '\0';
            txtNombre.PrefixSuffixText = null;
            txtNombre.ReadOnly = false;
            txtNombre.RightToLeft = RightToLeft.No;
            txtNombre.SelectedText = "";
            txtNombre.SelectionLength = 0;
            txtNombre.SelectionStart = 0;
            txtNombre.ShortcutsEnabled = true;
            txtNombre.Size = new Size(240, 48);
            txtNombre.TabIndex = 2;
            txtNombre.TabStop = false;
            txtNombre.TextAlign = HorizontalAlignment.Left;
            txtNombre.TrailingIcon = null;
            txtNombre.UseSystemPasswordChar = false;
            // 
            // txtCodigo
            // 
            txtCodigo.AnimateReadOnly = false;
            txtCodigo.BackgroundImageLayout = ImageLayout.None;
            txtCodigo.CharacterCasing = CharacterCasing.Normal;
            txtCodigo.Depth = 0;
            txtCodigo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCodigo.HideSelection = true;
            txtCodigo.LeadingIcon = null;
            txtCodigo.Location = new Point(51, 109);
            txtCodigo.MaxLength = 32767;
            txtCodigo.MouseState = MaterialSkin.MouseState.OUT;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.PasswordChar = '\0';
            txtCodigo.PrefixSuffixText = null;
            txtCodigo.ReadOnly = false;
            txtCodigo.RightToLeft = RightToLeft.No;
            txtCodigo.SelectedText = "";
            txtCodigo.SelectionLength = 0;
            txtCodigo.SelectionStart = 0;
            txtCodigo.ShortcutsEnabled = true;
            txtCodigo.Size = new Size(180, 48);
            txtCodigo.TabIndex = 1;
            txtCodigo.TabStop = false;
            txtCodigo.TextAlign = HorizontalAlignment.Left;
            txtCodigo.TrailingIcon = null;
            txtCodigo.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel3.Location = new Point(39, 26);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(277, 29);
            materialLabel3.TabIndex = 0;
            materialLabel3.Text = "Registrar Nuevo Producto";
            // 
            // tabMovimientos
            // 
            tabMovimientos.Controls.Add(materialLabel15);
            tabMovimientos.Controls.Add(cardNuevoMovimiento);
            tabMovimientos.Location = new Point(4, 29);
            tabMovimientos.Name = "tabMovimientos";
            tabMovimientos.Size = new Size(1294, 531);
            tabMovimientos.TabIndex = 2;
            tabMovimientos.Text = "Movimientos";
            tabMovimientos.UseVisualStyleBackColor = true;
            // 
            // materialLabel15
            // 
            materialLabel15.AutoSize = true;
            materialLabel15.Depth = 0;
            materialLabel15.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel15.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel15.Location = new Point(62, 36);
            materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel15.Name = "materialLabel15";
            materialLabel15.Size = new Size(275, 29);
            materialLabel15.TabIndex = 1;
            materialLabel15.Text = "Registro de Movimientos ";
            // 
            // cardNuevoMovimiento
            // 
            cardNuevoMovimiento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cardNuevoMovimiento.BackColor = Color.FromArgb(255, 255, 255);
            cardNuevoMovimiento.Controls.Add(btnLimpiarMovimiento);
            cardNuevoMovimiento.Controls.Add(btnGuardarMovimiento);
            cardNuevoMovimiento.Controls.Add(materialLabel14);
            cardNuevoMovimiento.Controls.Add(materialLabel13);
            cardNuevoMovimiento.Controls.Add(materialLabel12);
            cardNuevoMovimiento.Controls.Add(materialLabel11);
            cardNuevoMovimiento.Controls.Add(materialLabel10);
            cardNuevoMovimiento.Controls.Add(txtObservaciones);
            cardNuevoMovimiento.Controls.Add(cmbTipoMovimiento);
            cardNuevoMovimiento.Controls.Add(dtpFechaMovimiento);
            cardNuevoMovimiento.Controls.Add(txtCantidadMovimiento);
            cardNuevoMovimiento.Controls.Add(txtCodigoMovimiento);
            cardNuevoMovimiento.Controls.Add(materialLabel9);
            cardNuevoMovimiento.Depth = 0;
            cardNuevoMovimiento.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cardNuevoMovimiento.Location = new Point(62, 95);
            cardNuevoMovimiento.Margin = new Padding(30);
            cardNuevoMovimiento.MouseState = MaterialSkin.MouseState.HOVER;
            cardNuevoMovimiento.Name = "cardNuevoMovimiento";
            cardNuevoMovimiento.Padding = new Padding(14);
            cardNuevoMovimiento.Size = new Size(1181, 381);
            cardNuevoMovimiento.TabIndex = 0;
            // 
            // btnLimpiarMovimiento
            // 
            btnLimpiarMovimiento.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLimpiarMovimiento.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLimpiarMovimiento.Depth = 0;
            btnLimpiarMovimiento.HighEmphasis = true;
            btnLimpiarMovimiento.Icon = null;
            btnLimpiarMovimiento.Location = new Point(275, 307);
            btnLimpiarMovimiento.Margin = new Padding(4, 6, 4, 6);
            btnLimpiarMovimiento.MouseState = MaterialSkin.MouseState.HOVER;
            btnLimpiarMovimiento.Name = "btnLimpiarMovimiento";
            btnLimpiarMovimiento.NoAccentTextColor = Color.Empty;
            btnLimpiarMovimiento.Size = new Size(79, 36);
            btnLimpiarMovimiento.TabIndex = 12;
            btnLimpiarMovimiento.Text = "LIMPIAR";
            btnLimpiarMovimiento.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnLimpiarMovimiento.UseAccentColor = false;
            btnLimpiarMovimiento.UseVisualStyleBackColor = true;
            // 
            // btnGuardarMovimiento
            // 
            btnGuardarMovimiento.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGuardarMovimiento.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnGuardarMovimiento.Depth = 0;
            btnGuardarMovimiento.HighEmphasis = true;
            btnGuardarMovimiento.Icon = null;
            btnGuardarMovimiento.Location = new Point(71, 307);
            btnGuardarMovimiento.Margin = new Padding(4, 6, 4, 6);
            btnGuardarMovimiento.MouseState = MaterialSkin.MouseState.HOVER;
            btnGuardarMovimiento.Name = "btnGuardarMovimiento";
            btnGuardarMovimiento.NoAccentTextColor = Color.Empty;
            btnGuardarMovimiento.Size = new Size(184, 36);
            btnGuardarMovimiento.TabIndex = 11;
            btnGuardarMovimiento.Text = "GUARDAR MOVIMIENTO";
            btnGuardarMovimiento.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnGuardarMovimiento.UseAccentColor = false;
            btnGuardarMovimiento.UseVisualStyleBackColor = true;
            // 
            // materialLabel14
            // 
            materialLabel14.AutoSize = true;
            materialLabel14.Depth = 0;
            materialLabel14.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel14.Location = new Point(71, 189);
            materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel14.Name = "materialLabel14";
            materialLabel14.Size = new Size(105, 19);
            materialLabel14.TabIndex = 10;
            materialLabel14.Text = "Observaciones";
            // 
            // materialLabel13
            // 
            materialLabel13.AutoSize = true;
            materialLabel13.Depth = 0;
            materialLabel13.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel13.Location = new Point(855, 79);
            materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel13.Name = "materialLabel13";
            materialLabel13.Size = new Size(76, 19);
            materialLabel13.TabIndex = 9;
            materialLabel13.Text = "Cantidad *";
            // 
            // materialLabel12
            // 
            materialLabel12.AutoSize = true;
            materialLabel12.Depth = 0;
            materialLabel12.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel12.Location = new Point(537, 79);
            materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel12.Name = "materialLabel12";
            materialLabel12.Size = new Size(153, 19);
            materialLabel12.TabIndex = 8;
            materialLabel12.Text = "Tipo de Movimiento *";
            // 
            // materialLabel11
            // 
            materialLabel11.AutoSize = true;
            materialLabel11.Depth = 0;
            materialLabel11.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel11.Location = new Point(300, 79);
            materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel11.Name = "materialLabel11";
            materialLabel11.Size = new Size(92, 19);
            materialLabel11.TabIndex = 7;
            materialLabel11.Text = "Fecha actual";
            // 
            // materialLabel10
            // 
            materialLabel10.AutoSize = true;
            materialLabel10.Depth = 0;
            materialLabel10.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel10.Location = new Point(71, 79);
            materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel10.Name = "materialLabel10";
            materialLabel10.Size = new Size(155, 19);
            materialLabel10.TabIndex = 6;
            materialLabel10.Text = "Código del Producto *";
            // 
            // txtObservaciones
            // 
            txtObservaciones.AnimateReadOnly = false;
            txtObservaciones.BackgroundImageLayout = ImageLayout.None;
            txtObservaciones.CharacterCasing = CharacterCasing.Normal;
            txtObservaciones.Depth = 0;
            txtObservaciones.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtObservaciones.HideSelection = true;
            txtObservaciones.LeadingIcon = null;
            txtObservaciones.Location = new Point(71, 225);
            txtObservaciones.MaxLength = 32767;
            txtObservaciones.MouseState = MaterialSkin.MouseState.OUT;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.PasswordChar = '\0';
            txtObservaciones.PrefixSuffixText = null;
            txtObservaciones.ReadOnly = false;
            txtObservaciones.RightToLeft = RightToLeft.No;
            txtObservaciones.SelectedText = "";
            txtObservaciones.SelectionLength = 0;
            txtObservaciones.SelectionStart = 0;
            txtObservaciones.ShortcutsEnabled = true;
            txtObservaciones.Size = new Size(714, 48);
            txtObservaciones.TabIndex = 5;
            txtObservaciones.TabStop = false;
            txtObservaciones.TextAlign = HorizontalAlignment.Left;
            txtObservaciones.TrailingIcon = null;
            txtObservaciones.UseSystemPasswordChar = false;
            // 
            // cmbTipoMovimiento
            // 
            cmbTipoMovimiento.AutoResize = false;
            cmbTipoMovimiento.BackColor = Color.FromArgb(255, 255, 255);
            cmbTipoMovimiento.Depth = 0;
            cmbTipoMovimiento.DrawMode = DrawMode.OwnerDrawVariable;
            cmbTipoMovimiento.DropDownHeight = 174;
            cmbTipoMovimiento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoMovimiento.DropDownWidth = 121;
            cmbTipoMovimiento.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbTipoMovimiento.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbTipoMovimiento.FormattingEnabled = true;
            cmbTipoMovimiento.IntegralHeight = false;
            cmbTipoMovimiento.ItemHeight = 43;
            cmbTipoMovimiento.Items.AddRange(new object[] { "Entrada (Ingreso por Compra)", "", "", "Salida (Venta / Ajuste)", "", "", "Ajuste de Inventario", "", "", "Devolución" });
            cmbTipoMovimiento.Location = new Point(537, 110);
            cmbTipoMovimiento.MaxDropDownItems = 4;
            cmbTipoMovimiento.MouseState = MaterialSkin.MouseState.OUT;
            cmbTipoMovimiento.Name = "cmbTipoMovimiento";
            cmbTipoMovimiento.Size = new Size(259, 49);
            cmbTipoMovimiento.StartIndex = 0;
            cmbTipoMovimiento.TabIndex = 4;
            // 
            // dtpFechaMovimiento
            // 
            dtpFechaMovimiento.CustomFormat = "dd/MM/yyyy";
            dtpFechaMovimiento.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaMovimiento.Format = DateTimePickerFormat.Custom;
            dtpFechaMovimiento.Location = new Point(300, 110);
            dtpFechaMovimiento.Name = "dtpFechaMovimiento";
            dtpFechaMovimiento.Size = new Size(192, 30);
            dtpFechaMovimiento.TabIndex = 3;
            // 
            // txtCantidadMovimiento
            // 
            txtCantidadMovimiento.AnimateReadOnly = false;
            txtCantidadMovimiento.BackgroundImageLayout = ImageLayout.None;
            txtCantidadMovimiento.CharacterCasing = CharacterCasing.Normal;
            txtCantidadMovimiento.Depth = 0;
            txtCantidadMovimiento.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCantidadMovimiento.HideSelection = true;
            txtCantidadMovimiento.LeadingIcon = null;
            txtCantidadMovimiento.Location = new Point(855, 111);
            txtCantidadMovimiento.MaxLength = 32767;
            txtCantidadMovimiento.MouseState = MaterialSkin.MouseState.OUT;
            txtCantidadMovimiento.Name = "txtCantidadMovimiento";
            txtCantidadMovimiento.PasswordChar = '\0';
            txtCantidadMovimiento.PrefixSuffixText = null;
            txtCantidadMovimiento.ReadOnly = false;
            txtCantidadMovimiento.RightToLeft = RightToLeft.No;
            txtCantidadMovimiento.SelectedText = "";
            txtCantidadMovimiento.SelectionLength = 0;
            txtCantidadMovimiento.SelectionStart = 0;
            txtCantidadMovimiento.ShortcutsEnabled = true;
            txtCantidadMovimiento.Size = new Size(180, 48);
            txtCantidadMovimiento.TabIndex = 2;
            txtCantidadMovimiento.TabStop = false;
            txtCantidadMovimiento.TextAlign = HorizontalAlignment.Left;
            txtCantidadMovimiento.TrailingIcon = null;
            txtCantidadMovimiento.UseSystemPasswordChar = false;
            // 
            // txtCodigoMovimiento
            // 
            txtCodigoMovimiento.AnimateReadOnly = false;
            txtCodigoMovimiento.BackgroundImageLayout = ImageLayout.None;
            txtCodigoMovimiento.CharacterCasing = CharacterCasing.Normal;
            txtCodigoMovimiento.Depth = 0;
            txtCodigoMovimiento.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCodigoMovimiento.HideSelection = true;
            txtCodigoMovimiento.LeadingIcon = null;
            txtCodigoMovimiento.Location = new Point(71, 111);
            txtCodigoMovimiento.MaxLength = 32767;
            txtCodigoMovimiento.MouseState = MaterialSkin.MouseState.OUT;
            txtCodigoMovimiento.Name = "txtCodigoMovimiento";
            txtCodigoMovimiento.PasswordChar = '\0';
            txtCodigoMovimiento.PrefixSuffixText = null;
            txtCodigoMovimiento.ReadOnly = false;
            txtCodigoMovimiento.RightToLeft = RightToLeft.No;
            txtCodigoMovimiento.SelectedText = "";
            txtCodigoMovimiento.SelectionLength = 0;
            txtCodigoMovimiento.SelectionStart = 0;
            txtCodigoMovimiento.ShortcutsEnabled = true;
            txtCodigoMovimiento.Size = new Size(180, 48);
            txtCodigoMovimiento.TabIndex = 1;
            txtCodigoMovimiento.TabStop = false;
            txtCodigoMovimiento.TextAlign = HorizontalAlignment.Left;
            txtCodigoMovimiento.TrailingIcon = null;
            txtCodigoMovimiento.UseSystemPasswordChar = false;
            // 
            // materialLabel9
            // 
            materialLabel9.AutoSize = true;
            materialLabel9.Depth = 0;
            materialLabel9.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel9.Location = new Point(39, 26);
            materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel9.Name = "materialLabel9";
            materialLabel9.Size = new Size(204, 29);
            materialLabel9.TabIndex = 0;
            materialLabel9.Text = "Nuevo Movimiento";
            // 
            // tabInventario
            // 
            tabInventario.Controls.Add(materialCard1);
            tabInventario.Controls.Add(materialLabel1);
            tabInventario.Location = new Point(4, 29);
            tabInventario.Name = "tabInventario";
            tabInventario.Size = new Size(1294, 531);
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
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Columns.AddRange(new DataGridViewColumn[] { colCodigo, colNombre, colUnidad, colCategoria, colStockMin, colStockActual, colEstado, colAcciones });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvInventario.DefaultCellStyle = dataGridViewCellStyle4;
            dgvInventario.EnableHeadersVisualStyles = false;
            dgvInventario.GridColor = Color.White;
            dgvInventario.Location = new Point(56, 135);
            dgvInventario.MultiSelect = false;
            dgvInventario.Name = "dgvInventario";
            dgvInventario.ReadOnly = true;
            dgvInventario.RowHeadersVisible = false;
            dgvInventario.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvInventario.RowsDefaultCellStyle = dataGridViewCellStyle5;
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.DarkSlateGray;
            dataGridViewCellStyle3.Padding = new Padding(4, 4, 8, 8);
            colAcciones.DefaultCellStyle = dataGridViewCellStyle3;
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
            tabReportes.Controls.Add(materialLabel17);
            tabReportes.Controls.Add(cardReporteMovimientos);
            tabReportes.Location = new Point(4, 29);
            tabReportes.Name = "tabReportes";
            tabReportes.Size = new Size(1294, 531);
            tabReportes.TabIndex = 4;
            tabReportes.Text = "Reportes";
            tabReportes.UseVisualStyleBackColor = true;
            // 
            // materialLabel17
            // 
            materialLabel17.AutoSize = true;
            materialLabel17.Depth = 0;
            materialLabel17.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel17.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel17.Location = new Point(73, 48);
            materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel17.Name = "materialLabel17";
            materialLabel17.Size = new Size(204, 29);
            materialLabel17.TabIndex = 1;
            materialLabel17.Text = "Reportes y Análisis";
            // 
            // cardReporteMovimientos
            // 
            cardReporteMovimientos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cardReporteMovimientos.BackColor = Color.FromArgb(255, 255, 255);
            cardReporteMovimientos.Controls.Add(btnExportarReporte);
            cardReporteMovimientos.Controls.Add(btnGenerarReporte);
            cardReporteMovimientos.Controls.Add(cmbFiltroTipo);
            cardReporteMovimientos.Controls.Add(dtpFechaHasta);
            cardReporteMovimientos.Controls.Add(dtpFechaDesde);
            cardReporteMovimientos.Controls.Add(materialLabel21);
            cardReporteMovimientos.Controls.Add(materialLabel20);
            cardReporteMovimientos.Controls.Add(materialLabel19);
            cardReporteMovimientos.Controls.Add(lblTituloReportes);
            cardReporteMovimientos.Depth = 0;
            cardReporteMovimientos.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cardReporteMovimientos.Location = new Point(73, 107);
            cardReporteMovimientos.Margin = new Padding(30);
            cardReporteMovimientos.MouseState = MaterialSkin.MouseState.HOVER;
            cardReporteMovimientos.Name = "cardReporteMovimientos";
            cardReporteMovimientos.Padding = new Padding(14);
            cardReporteMovimientos.Size = new Size(1139, 330);
            cardReporteMovimientos.TabIndex = 0;
            // 
            // btnExportarReporte
            // 
            btnExportarReporte.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExportarReporte.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnExportarReporte.Depth = 0;
            btnExportarReporte.HighEmphasis = true;
            btnExportarReporte.Icon = null;
            btnExportarReporte.Location = new Point(265, 225);
            btnExportarReporte.Margin = new Padding(4, 6, 4, 6);
            btnExportarReporte.MouseState = MaterialSkin.MouseState.HOVER;
            btnExportarReporte.Name = "btnExportarReporte";
            btnExportarReporte.NoAccentTextColor = Color.Empty;
            btnExportarReporte.Size = new Size(163, 36);
            btnExportarReporte.TabIndex = 8;
            btnExportarReporte.Text = "EXPORTAR REPORTE";
            btnExportarReporte.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnExportarReporte.UseAccentColor = false;
            btnExportarReporte.UseVisualStyleBackColor = true;
            // 
            // btnGenerarReporte
            // 
            btnGenerarReporte.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGenerarReporte.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnGenerarReporte.Depth = 0;
            btnGenerarReporte.HighEmphasis = true;
            btnGenerarReporte.Icon = null;
            btnGenerarReporte.Location = new Point(73, 225);
            btnGenerarReporte.Margin = new Padding(4, 6, 4, 6);
            btnGenerarReporte.MouseState = MaterialSkin.MouseState.HOVER;
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.NoAccentTextColor = Color.Empty;
            btnGenerarReporte.Size = new Size(154, 36);
            btnGenerarReporte.TabIndex = 7;
            btnGenerarReporte.Text = "GENERAR REPORTE";
            btnGenerarReporte.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnGenerarReporte.UseAccentColor = false;
            btnGenerarReporte.UseVisualStyleBackColor = true;
            // 
            // cmbFiltroTipo
            // 
            cmbFiltroTipo.AutoResize = false;
            cmbFiltroTipo.BackColor = Color.FromArgb(255, 255, 255);
            cmbFiltroTipo.Depth = 0;
            cmbFiltroTipo.DrawMode = DrawMode.OwnerDrawVariable;
            cmbFiltroTipo.DropDownHeight = 174;
            cmbFiltroTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltroTipo.DropDownWidth = 121;
            cmbFiltroTipo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbFiltroTipo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbFiltroTipo.FormattingEnabled = true;
            cmbFiltroTipo.IntegralHeight = false;
            cmbFiltroTipo.ItemHeight = 43;
            cmbFiltroTipo.Items.AddRange(new object[] { "Todos los movimientos", "Entradas (Compras a Proveedores)", "Salidas (Ventas)", "Garantías y Reemplazos", "Devoluciones de Clientes", "Ajustes de Inventario (Mermas / Daños)" });
            cmbFiltroTipo.Location = new Point(559, 107);
            cmbFiltroTipo.MaxDropDownItems = 4;
            cmbFiltroTipo.MouseState = MaterialSkin.MouseState.OUT;
            cmbFiltroTipo.Name = "cmbFiltroTipo";
            cmbFiltroTipo.Size = new Size(243, 49);
            cmbFiltroTipo.StartIndex = 0;
            cmbFiltroTipo.TabIndex = 6;
            // 
            // dtpFechaHasta
            // 
            dtpFechaHasta.CustomFormat = "dd/MM/yyyy";
            dtpFechaHasta.Format = DateTimePickerFormat.Custom;
            dtpFechaHasta.Location = new Point(303, 124);
            dtpFechaHasta.Name = "dtpFechaHasta";
            dtpFechaHasta.Size = new Size(159, 27);
            dtpFechaHasta.TabIndex = 5;
            // 
            // dtpFechaDesde
            // 
            dtpFechaDesde.CustomFormat = "dd/MM/yyyy";
            dtpFechaDesde.Format = DateTimePickerFormat.Custom;
            dtpFechaDesde.Location = new Point(73, 124);
            dtpFechaDesde.Name = "dtpFechaDesde";
            dtpFechaDesde.Size = new Size(156, 27);
            dtpFechaDesde.TabIndex = 4;
            // 
            // materialLabel21
            // 
            materialLabel21.AutoSize = true;
            materialLabel21.Depth = 0;
            materialLabel21.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel21.Location = new Point(559, 85);
            materialLabel21.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel21.Name = "materialLabel21";
            materialLabel21.Size = new Size(109, 19);
            materialLabel21.TabIndex = 3;
            materialLabel21.Text = "Filtrar por Tipo ";
            // 
            // materialLabel20
            // 
            materialLabel20.AutoSize = true;
            materialLabel20.Depth = 0;
            materialLabel20.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel20.Location = new Point(303, 85);
            materialLabel20.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel20.Name = "materialLabel20";
            materialLabel20.Size = new Size(90, 19);
            materialLabel20.TabIndex = 2;
            materialLabel20.Text = "Fecha Hasta";
            // 
            // materialLabel19
            // 
            materialLabel19.AutoSize = true;
            materialLabel19.Depth = 0;
            materialLabel19.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel19.Location = new Point(73, 85);
            materialLabel19.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel19.Name = "materialLabel19";
            materialLabel19.Size = new Size(96, 19);
            materialLabel19.TabIndex = 1;
            materialLabel19.Text = "Fecha Desde ";
            // 
            // lblTituloReportes
            // 
            lblTituloReportes.AutoSize = true;
            lblTituloReportes.Depth = 0;
            lblTituloReportes.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblTituloReportes.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            lblTituloReportes.Location = new Point(31, 29);
            lblTituloReportes.MouseState = MaterialSkin.MouseState.HOVER;
            lblTituloReportes.Name = "lblTituloReportes";
            lblTituloReportes.Size = new Size(276, 29);
            lblTituloReportes.TabIndex = 0;
            lblTituloReportes.Text = "Historial de Movimientos ";
            // 
            // tabBuscar
            // 
            tabBuscar.Controls.Add(materialLabel27);
            tabBuscar.Controls.Add(cardBuscarProductos);
            tabBuscar.Location = new Point(4, 29);
            tabBuscar.Name = "tabBuscar";
            tabBuscar.Size = new Size(1294, 531);
            tabBuscar.TabIndex = 5;
            tabBuscar.Text = "Buscar";
            tabBuscar.UseVisualStyleBackColor = true;
            // 
            // materialLabel27
            // 
            materialLabel27.AutoSize = true;
            materialLabel27.Depth = 0;
            materialLabel27.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel27.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel27.Location = new Point(77, 27);
            materialLabel27.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel27.Name = "materialLabel27";
            materialLabel27.Size = new Size(258, 29);
            materialLabel27.TabIndex = 1;
            materialLabel27.Text = "Búsqueda de Productos";
            // 
            // cardBuscarProductos
            // 
            cardBuscarProductos.BackColor = Color.FromArgb(255, 255, 255);
            cardBuscarProductos.Controls.Add(materialLabel29);
            cardBuscarProductos.Controls.Add(dgvResultadosBusqueda);
            cardBuscarProductos.Controls.Add(btnLimpiarBusqueda);
            cardBuscarProductos.Controls.Add(btnBuscarProducto);
            cardBuscarProductos.Controls.Add(txtCriterioBusqueda);
            cardBuscarProductos.Controls.Add(lblTituloBuscar);
            cardBuscarProductos.Depth = 0;
            cardBuscarProductos.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cardBuscarProductos.Location = new Point(77, 89);
            cardBuscarProductos.Margin = new Padding(14);
            cardBuscarProductos.MouseState = MaterialSkin.MouseState.HOVER;
            cardBuscarProductos.Name = "cardBuscarProductos";
            cardBuscarProductos.Padding = new Padding(14);
            cardBuscarProductos.Size = new Size(1069, 408);
            cardBuscarProductos.TabIndex = 0;
            // 
            // materialLabel29
            // 
            materialLabel29.AutoSize = true;
            materialLabel29.Depth = 0;
            materialLabel29.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel29.Location = new Point(61, 86);
            materialLabel29.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel29.Name = "materialLabel29";
            materialLabel29.Size = new Size(273, 19);
            materialLabel29.TabIndex = 5;
            materialLabel29.Text = "Buscar por código, nombre o categoría";
            // 
            // dgvResultadosBusqueda
            // 
            dgvResultadosBusqueda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResultadosBusqueda.BackgroundColor = Color.White;
            dgvResultadosBusqueda.BorderStyle = BorderStyle.None;
            dgvResultadosBusqueda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultadosBusqueda.EnableHeadersVisualStyles = false;
            dgvResultadosBusqueda.Location = new Point(61, 252);
            dgvResultadosBusqueda.Name = "dgvResultadosBusqueda";
            dgvResultadosBusqueda.RowHeadersVisible = false;
            dgvResultadosBusqueda.RowHeadersWidth = 51;
            dgvResultadosBusqueda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResultadosBusqueda.Size = new Size(937, 120);
            dgvResultadosBusqueda.TabIndex = 4;
            // 
            // btnLimpiarBusqueda
            // 
            btnLimpiarBusqueda.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLimpiarBusqueda.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLimpiarBusqueda.Depth = 0;
            btnLimpiarBusqueda.HighEmphasis = true;
            btnLimpiarBusqueda.Icon = null;
            btnLimpiarBusqueda.Location = new Point(160, 192);
            btnLimpiarBusqueda.Margin = new Padding(4, 6, 4, 6);
            btnLimpiarBusqueda.MouseState = MaterialSkin.MouseState.HOVER;
            btnLimpiarBusqueda.Name = "btnLimpiarBusqueda";
            btnLimpiarBusqueda.NoAccentTextColor = Color.Empty;
            btnLimpiarBusqueda.Size = new Size(79, 36);
            btnLimpiarBusqueda.TabIndex = 3;
            btnLimpiarBusqueda.Text = "LIMPIAR";
            btnLimpiarBusqueda.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnLimpiarBusqueda.UseAccentColor = false;
            btnLimpiarBusqueda.UseVisualStyleBackColor = true;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBuscarProducto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnBuscarProducto.Depth = 0;
            btnBuscarProducto.HighEmphasis = true;
            btnBuscarProducto.Icon = null;
            btnBuscarProducto.Location = new Point(61, 192);
            btnBuscarProducto.Margin = new Padding(4, 6, 4, 6);
            btnBuscarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.NoAccentTextColor = Color.Empty;
            btnBuscarProducto.Size = new Size(77, 36);
            btnBuscarProducto.TabIndex = 2;
            btnBuscarProducto.Text = "BUSCAR";
            btnBuscarProducto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnBuscarProducto.UseAccentColor = false;
            btnBuscarProducto.UseVisualStyleBackColor = true;
            // 
            // txtCriterioBusqueda
            // 
            txtCriterioBusqueda.AnimateReadOnly = false;
            txtCriterioBusqueda.BackgroundImageLayout = ImageLayout.None;
            txtCriterioBusqueda.CharacterCasing = CharacterCasing.Normal;
            txtCriterioBusqueda.Depth = 0;
            txtCriterioBusqueda.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCriterioBusqueda.HideSelection = true;
            txtCriterioBusqueda.LeadingIcon = null;
            txtCriterioBusqueda.Location = new Point(61, 126);
            txtCriterioBusqueda.MaxLength = 32767;
            txtCriterioBusqueda.MouseState = MaterialSkin.MouseState.OUT;
            txtCriterioBusqueda.Name = "txtCriterioBusqueda";
            txtCriterioBusqueda.PasswordChar = '\0';
            txtCriterioBusqueda.PrefixSuffixText = null;
            txtCriterioBusqueda.ReadOnly = false;
            txtCriterioBusqueda.RightToLeft = RightToLeft.No;
            txtCriterioBusqueda.SelectedText = "";
            txtCriterioBusqueda.SelectionLength = 0;
            txtCriterioBusqueda.SelectionStart = 0;
            txtCriterioBusqueda.ShortcutsEnabled = true;
            txtCriterioBusqueda.Size = new Size(312, 48);
            txtCriterioBusqueda.TabIndex = 1;
            txtCriterioBusqueda.TabStop = false;
            txtCriterioBusqueda.TextAlign = HorizontalAlignment.Left;
            txtCriterioBusqueda.TrailingIcon = null;
            txtCriterioBusqueda.UseSystemPasswordChar = false;
            // 
            // lblTituloBuscar
            // 
            lblTituloBuscar.AutoSize = true;
            lblTituloBuscar.Depth = 0;
            lblTituloBuscar.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblTituloBuscar.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            lblTituloBuscar.Location = new Point(26, 25);
            lblTituloBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            lblTituloBuscar.Name = "lblTituloBuscar";
            lblTituloBuscar.Size = new Size(192, 29);
            lblTituloBuscar.TabIndex = 0;
            lblTituloBuscar.Text = "Buscar Productos";
            // 
            // tabConfiguracion
            // 
            tabConfiguracion.Controls.Add(materialLabel25);
            tabConfiguracion.Controls.Add(cardHerramientasAdmin);
            tabConfiguracion.Location = new Point(4, 29);
            tabConfiguracion.Name = "tabConfiguracion";
            tabConfiguracion.Size = new Size(1294, 531);
            tabConfiguracion.TabIndex = 6;
            tabConfiguracion.Text = "Configuración";
            tabConfiguracion.UseVisualStyleBackColor = true;
            // 
            // materialLabel25
            // 
            materialLabel25.AutoSize = true;
            materialLabel25.Depth = 0;
            materialLabel25.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel25.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel25.Location = new Point(80, 40);
            materialLabel25.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel25.Name = "materialLabel25";
            materialLabel25.Size = new Size(283, 29);
            materialLabel25.TabIndex = 1;
            materialLabel25.Text = "Configuración del Sistema";
            // 
            // cardHerramientasAdmin
            // 
            cardHerramientasAdmin.BackColor = Color.FromArgb(255, 255, 255);
            cardHerramientasAdmin.Controls.Add(pnlEstadoConfig);
            cardHerramientasAdmin.Controls.Add(btnResetSistema);
            cardHerramientasAdmin.Controls.Add(btnLimpiarTodo);
            cardHerramientasAdmin.Controls.Add(btnInicializarSistema);
            cardHerramientasAdmin.Controls.Add(btnValidarIntegridad);
            cardHerramientasAdmin.Controls.Add(lblHerramientasAdmin);
            cardHerramientasAdmin.Depth = 0;
            cardHerramientasAdmin.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cardHerramientasAdmin.Location = new Point(77, 100);
            cardHerramientasAdmin.Margin = new Padding(14);
            cardHerramientasAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            cardHerramientasAdmin.Name = "cardHerramientasAdmin";
            cardHerramientasAdmin.Padding = new Padding(14);
            cardHerramientasAdmin.Size = new Size(1072, 272);
            cardHerramientasAdmin.TabIndex = 0;
            // 
            // pnlEstadoConfig
            // 
            pnlEstadoConfig.BackColor = Color.White;
            pnlEstadoConfig.Controls.Add(lblEstadoConfig);
            pnlEstadoConfig.Location = new Point(70, 185);
            pnlEstadoConfig.Name = "pnlEstadoConfig";
            pnlEstadoConfig.Size = new Size(867, 39);
            pnlEstadoConfig.TabIndex = 5;
            // 
            // lblEstadoConfig
            // 
            lblEstadoConfig.AutoSize = true;
            lblEstadoConfig.Depth = 0;
            lblEstadoConfig.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblEstadoConfig.Location = new Point(15, 9);
            lblEstadoConfig.MouseState = MaterialSkin.MouseState.HOVER;
            lblEstadoConfig.Name = "lblEstadoConfig";
            lblEstadoConfig.Size = new Size(1, 0);
            lblEstadoConfig.TabIndex = 0;
            // 
            // btnResetSistema
            // 
            btnResetSistema.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnResetSistema.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnResetSistema.Depth = 0;
            btnResetSistema.HighEmphasis = true;
            btnResetSistema.Icon = null;
            btnResetSistema.Location = new Point(619, 103);
            btnResetSistema.Margin = new Padding(4, 6, 4, 6);
            btnResetSistema.MouseState = MaterialSkin.MouseState.HOVER;
            btnResetSistema.Name = "btnResetSistema";
            btnResetSistema.NoAccentTextColor = Color.Empty;
            btnResetSistema.Size = new Size(130, 36);
            btnResetSistema.TabIndex = 4;
            btnResetSistema.Text = "RESET SISTEMA";
            btnResetSistema.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnResetSistema.UseAccentColor = false;
            btnResetSistema.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarTodo
            // 
            btnLimpiarTodo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLimpiarTodo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLimpiarTodo.Depth = 0;
            btnLimpiarTodo.HighEmphasis = true;
            btnLimpiarTodo.Icon = null;
            btnLimpiarTodo.Location = new Point(463, 103);
            btnLimpiarTodo.Margin = new Padding(4, 6, 4, 6);
            btnLimpiarTodo.MouseState = MaterialSkin.MouseState.HOVER;
            btnLimpiarTodo.Name = "btnLimpiarTodo";
            btnLimpiarTodo.NoAccentTextColor = Color.Empty;
            btnLimpiarTodo.Size = new Size(121, 36);
            btnLimpiarTodo.TabIndex = 3;
            btnLimpiarTodo.Text = "LIMPIAR TODO";
            btnLimpiarTodo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnLimpiarTodo.UseAccentColor = false;
            btnLimpiarTodo.UseVisualStyleBackColor = true;
            // 
            // btnInicializarSistema
            // 
            btnInicializarSistema.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnInicializarSistema.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnInicializarSistema.Depth = 0;
            btnInicializarSistema.HighEmphasis = true;
            btnInicializarSistema.Icon = null;
            btnInicializarSistema.Location = new Point(267, 103);
            btnInicializarSistema.Margin = new Padding(4, 6, 4, 6);
            btnInicializarSistema.MouseState = MaterialSkin.MouseState.HOVER;
            btnInicializarSistema.Name = "btnInicializarSistema";
            btnInicializarSistema.NoAccentTextColor = Color.Empty;
            btnInicializarSistema.Size = new Size(169, 36);
            btnInicializarSistema.TabIndex = 2;
            btnInicializarSistema.Text = "INICIALIZAR SISTEMA";
            btnInicializarSistema.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnInicializarSistema.UseAccentColor = false;
            btnInicializarSistema.UseVisualStyleBackColor = true;
            // 
            // btnValidarIntegridad
            // 
            btnValidarIntegridad.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnValidarIntegridad.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnValidarIntegridad.Depth = 0;
            btnValidarIntegridad.HighEmphasis = true;
            btnValidarIntegridad.Icon = null;
            btnValidarIntegridad.Location = new Point(67, 103);
            btnValidarIntegridad.Margin = new Padding(4, 6, 4, 6);
            btnValidarIntegridad.MouseState = MaterialSkin.MouseState.HOVER;
            btnValidarIntegridad.Name = "btnValidarIntegridad";
            btnValidarIntegridad.NoAccentTextColor = Color.Empty;
            btnValidarIntegridad.Size = new Size(170, 36);
            btnValidarIntegridad.TabIndex = 1;
            btnValidarIntegridad.Text = "VALIDAR INTEGRIDAD";
            btnValidarIntegridad.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnValidarIntegridad.UseAccentColor = false;
            btnValidarIntegridad.UseVisualStyleBackColor = true;
            // 
            // lblHerramientasAdmin
            // 
            lblHerramientasAdmin.AutoSize = true;
            lblHerramientasAdmin.Depth = 0;
            lblHerramientasAdmin.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblHerramientasAdmin.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            lblHerramientasAdmin.Location = new Point(34, 42);
            lblHerramientasAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            lblHerramientasAdmin.Name = "lblHerramientasAdmin";
            lblHerramientasAdmin.Size = new Size(348, 29);
            lblHerramientasAdmin.TabIndex = 0;
            lblHerramientasAdmin.Text = "Herramientas de Administración";
            // 
            // tabEspacio1
            // 
            tabEspacio1.Location = new Point(4, 29);
            tabEspacio1.Name = "tabEspacio1";
            tabEspacio1.Size = new Size(1294, 531);
            tabEspacio1.TabIndex = 8;
            tabEspacio1.UseVisualStyleBackColor = true;
            // 
            // tabEspacio2
            // 
            tabEspacio2.Location = new Point(4, 29);
            tabEspacio2.Name = "tabEspacio2";
            tabEspacio2.Size = new Size(1294, 531);
            tabEspacio2.TabIndex = 9;
            tabEspacio2.UseVisualStyleBackColor = true;
            // 
            // tabEspacio3
            // 
            tabEspacio3.Location = new Point(4, 29);
            tabEspacio3.Name = "tabEspacio3";
            tabEspacio3.Size = new Size(1294, 531);
            tabEspacio3.TabIndex = 10;
            tabEspacio3.UseVisualStyleBackColor = true;
            // 
            // tabCerrarSesion
            // 
            tabCerrarSesion.Location = new Point(4, 29);
            tabCerrarSesion.Name = "tabCerrarSesion";
            tabCerrarSesion.Size = new Size(1294, 531);
            tabCerrarSesion.TabIndex = 7;
            tabCerrarSesion.Text = "Cerrar Sesión";
            tabCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1308, 631);
            Controls.Add(tcMenuPrincipal);
            DrawerTabControl = tcMenuPrincipal;
            Name = "FrmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMenuPrincipal";
            Shown += FrmMenuPrincipal_Shown;
            tcMenuPrincipal.ResumeLayout(false);
            tabDashboard.ResumeLayout(false);
            tabDashboard.PerformLayout();
            cardAlertasStock.ResumeLayout(false);
            cardAlertasStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            materialCard5.ResumeLayout(false);
            materialCard5.PerformLayout();
            materialCard4.ResumeLayout(false);
            materialCard4.PerformLayout();
            materialCard3.ResumeLayout(false);
            materialCard3.PerformLayout();
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            tabNuevoProducto.ResumeLayout(false);
            tabNuevoProducto.PerformLayout();
            cardNuevoProducto.ResumeLayout(false);
            cardNuevoProducto.PerformLayout();
            tabMovimientos.ResumeLayout(false);
            tabMovimientos.PerformLayout();
            cardNuevoMovimiento.ResumeLayout(false);
            cardNuevoMovimiento.PerformLayout();
            tabInventario.ResumeLayout(false);
            tabInventario.PerformLayout();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            tabReportes.ResumeLayout(false);
            tabReportes.PerformLayout();
            cardReporteMovimientos.ResumeLayout(false);
            cardReporteMovimientos.PerformLayout();
            tabBuscar.ResumeLayout(false);
            tabBuscar.PerformLayout();
            cardBuscarProductos.ResumeLayout(false);
            cardBuscarProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultadosBusqueda).EndInit();
            tabConfiguracion.ResumeLayout(false);
            tabConfiguracion.PerformLayout();
            cardHerramientasAdmin.ResumeLayout(false);
            cardHerramientasAdmin.PerformLayout();
            pnlEstadoConfig.ResumeLayout(false);
            pnlEstadoConfig.PerformLayout();
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
        private MaterialSkin.Controls.MaterialCard cardNuevoProducto;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialComboBox cmbGrupo;
        private MaterialSkin.Controls.MaterialComboBox cmbUnidadMedida;
        private MaterialSkin.Controls.MaterialTextBox2 txtNombre;
        private MaterialSkin.Controls.MaterialTextBox2 txtCodigo;
        private MaterialSkin.Controls.MaterialTextBox2 txtStockMinimo;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialButton btnLimpiar;
        private MaterialSkin.Controls.MaterialButton btnRegistrarProducto;
        private MaterialSkin.Controls.MaterialCard cardNuevoMovimiento;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialTextBox2 txtCantidadMovimiento;
        private MaterialSkin.Controls.MaterialTextBox2 txtCodigoMovimiento;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialTextBox2 txtObservaciones;
        private MaterialSkin.Controls.MaterialComboBox cmbTipoMovimiento;
        private MaterialSkin.Controls.MaterialButton btnLimpiarMovimiento;
        private MaterialSkin.Controls.MaterialButton btnGuardarMovimiento;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private DateTimePicker dtpFechaMovimiento;
        private MaterialSkin.Controls.MaterialCard cardReporteMovimientos;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
        private MaterialSkin.Controls.MaterialLabel materialLabel21;
        private MaterialSkin.Controls.MaterialLabel materialLabel20;
        private MaterialSkin.Controls.MaterialLabel materialLabel19;
        private MaterialSkin.Controls.MaterialLabel lblTituloReportes;
        private MaterialSkin.Controls.MaterialButton btnExportarReporte;
        private MaterialSkin.Controls.MaterialButton btnGenerarReporte;
        private MaterialSkin.Controls.MaterialComboBox cmbFiltroTipo;
        private DateTimePicker dtpFechaHasta;
        private DateTimePicker dtpFechaDesde;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialLabel materialLabel18;
        private MaterialSkin.Controls.MaterialLabel lblStockBajo;
        private MaterialSkin.Controls.MaterialLabel materialLabel28;
        private MaterialSkin.Controls.MaterialLabel lblSinStock;
        private MaterialSkin.Controls.MaterialLabel materialLabel26;
        private MaterialSkin.Controls.MaterialLabel lblTotalMovimientos;
        private MaterialSkin.Controls.MaterialLabel materialLabel24;
        private MaterialSkin.Controls.MaterialLabel lblTotalProductos;
        private MaterialSkin.Controls.MaterialLabel materialLabel22;
        private MaterialSkin.Controls.MaterialCard cardAlertasStock;
        private MaterialSkin.Controls.MaterialButton btnVerAlertas;
        private MaterialSkin.Controls.MaterialButton btnActualizarDashboard;
        private MaterialSkin.Controls.MaterialLabel materialLabel23;
        private DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialLabel materialLabel25;
        private MaterialSkin.Controls.MaterialCard cardHerramientasAdmin;
        private Panel pnlEstadoConfig;
        private MaterialSkin.Controls.MaterialButton btnResetSistema;
        private MaterialSkin.Controls.MaterialButton btnLimpiarTodo;
        private MaterialSkin.Controls.MaterialButton btnInicializarSistema;
        private MaterialSkin.Controls.MaterialButton btnValidarIntegridad;
        private MaterialSkin.Controls.MaterialLabel lblHerramientasAdmin;
        private MaterialSkin.Controls.MaterialLabel lblEstadoConfig;
        private MaterialSkin.Controls.MaterialLabel materialLabel27;
        private MaterialSkin.Controls.MaterialCard cardBuscarProductos;
        private MaterialSkin.Controls.MaterialLabel lblTituloBuscar;
        private DataGridView dgvResultadosBusqueda;
        private MaterialSkin.Controls.MaterialButton btnLimpiarBusqueda;
        private MaterialSkin.Controls.MaterialButton btnBuscarProducto;
        private MaterialSkin.Controls.MaterialTextBox2 txtCriterioBusqueda;
        private MaterialSkin.Controls.MaterialLabel materialLabel29;
    }
}
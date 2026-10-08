namespace StockNova.UI
{
    partial class FrmLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtUsuario = new MaterialSkin.Controls.MaterialTextBox2();
            txtContrasena = new MaterialSkin.Controls.MaterialTextBox2();
            btnIngresar = new MaterialSkin.Controls.MaterialButton();
            pbUserIcon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbUserIcon).BeginInit();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.AnimateReadOnly = false;
            txtUsuario.BackgroundImageLayout = ImageLayout.None;
            txtUsuario.CharacterCasing = CharacterCasing.Normal;
            txtUsuario.Depth = 0;
            txtUsuario.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUsuario.HideSelection = true;
            txtUsuario.Hint = "Usuario";
            txtUsuario.LeadingIcon = null;
            txtUsuario.Location = new Point(57, 287);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.MaxLength = 32767;
            txtUsuario.MouseState = MaterialSkin.MouseState.OUT;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PasswordChar = '\0';
            txtUsuario.PrefixSuffixText = null;
            txtUsuario.ReadOnly = false;
            txtUsuario.RightToLeft = RightToLeft.No;
            txtUsuario.SelectedText = "";
            txtUsuario.SelectionLength = 0;
            txtUsuario.SelectionStart = 0;
            txtUsuario.ShortcutsEnabled = true;
            txtUsuario.Size = new Size(343, 48);
            txtUsuario.TabIndex = 0;
            txtUsuario.TabStop = false;
            txtUsuario.TextAlign = HorizontalAlignment.Left;
            txtUsuario.TrailingIcon = null;
            txtUsuario.UseSystemPasswordChar = false;
            // 
            // txtContrasena
            // 
            txtContrasena.AnimateReadOnly = false;
            txtContrasena.BackgroundImageLayout = ImageLayout.None;
            txtContrasena.CharacterCasing = CharacterCasing.Normal;
            txtContrasena.Depth = 0;
            txtContrasena.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtContrasena.HideSelection = true;
            txtContrasena.Hint = "Contraseña";
            txtContrasena.LeadingIcon = null;
            txtContrasena.Location = new Point(57, 378);
            txtContrasena.Margin = new Padding(3, 4, 3, 4);
            txtContrasena.MaxLength = 32767;
            txtContrasena.MouseState = MaterialSkin.MouseState.OUT;
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '*';
            txtContrasena.PrefixSuffixText = null;
            txtContrasena.ReadOnly = false;
            txtContrasena.RightToLeft = RightToLeft.No;
            txtContrasena.SelectedText = "";
            txtContrasena.SelectionLength = 0;
            txtContrasena.SelectionStart = 0;
            txtContrasena.ShortcutsEnabled = true;
            txtContrasena.Size = new Size(343, 48);
            txtContrasena.TabIndex = 1;
            txtContrasena.TabStop = false;
            txtContrasena.TextAlign = HorizontalAlignment.Left;
            txtContrasena.TrailingIcon = null;
            txtContrasena.UseSystemPasswordChar = false;
            // 
            // btnIngresar
            // 
            btnIngresar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnIngresar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnIngresar.Depth = 0;
            btnIngresar.HighEmphasis = true;
            btnIngresar.Icon = null;
            btnIngresar.Location = new Point(57, 486);
            btnIngresar.Margin = new Padding(5, 8, 5, 8);
            btnIngresar.MouseState = MaterialSkin.MouseState.HOVER;
            btnIngresar.Name = "btnIngresar";
            btnIngresar.NoAccentTextColor = Color.Empty;
            btnIngresar.Size = new Size(91, 36);
            btnIngresar.TabIndex = 2;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnIngresar.UseAccentColor = false;
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // pbUserIcon
            // 
            pbUserIcon.BackColor = Color.Transparent;
            pbUserIcon.Image = Properties.Resources.circle_user;
            pbUserIcon.Location = new Point(128, 100);
            pbUserIcon.Name = "pbUserIcon";
            pbUserIcon.Size = new Size(199, 135);
            pbUserIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pbUserIcon.TabIndex = 3;
            pbUserIcon.TabStop = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 566);
            Controls.Add(pbUserIcon);
            Controls.Add(btnIngresar);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmLogin";
            Padding = new Padding(3, 85, 3, 4);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StockNova - Inicio de Sesión";
            ((System.ComponentModel.ISupportInitialize)pbUserIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txtUsuario;
        private MaterialSkin.Controls.MaterialTextBox2 txtContrasena;
        private MaterialSkin.Controls.MaterialButton btnIngresar;
        private PictureBox pbUserIcon;
    }
}
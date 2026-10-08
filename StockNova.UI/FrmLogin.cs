using MaterialSkin;
using MaterialSkin.Controls;
using StockNova.BLL;
using StockNova.Entities;

namespace StockNova.UI
{
    public partial class FrmLogin : MaterialForm
    {
        private readonly UsuarioBLL _usuarioBLL = new UsuarioBLL();

        public FrmLogin()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800,
                Primary.BlueGrey900,
                Primary.BlueGrey500,
                Accent.Cyan400,
                TextShade.WHITE
            );

            txtUsuario.UseAccent = false;
            txtContrasena.UseAccent = false;

            this.Text = "StockNova - Inicio de Sesión";
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                string usuarioInput = txtUsuario.Text.Trim();
                string contrasenaInput = txtContrasena.Text.Trim();

                Usuario usuario = _usuarioBLL.IniciarSesion(usuarioInput, contrasenaInput);

                MessageBox.Show($"¡Bienvenido {usuario.NombreUsuario}!", "Acceso Concedido",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();

                using (FrmMenuPrincipal frmMenu = new FrmMenuPrincipal(usuario))
                {
                    if (frmMenu.ShowDialog() == DialogResult.OK)
                    {
                        // Si confirmó cerrar sesión en el menú, vuelve a mostrar el login limpio
                        this.Show();
                        txtUsuario.Clear();
                        txtContrasena.Clear(); // Nota que tu textbox se llama txtContrasena
                        txtUsuario.Focus();
                    }
                    else
                    {
                        // Si cerró la ventana desde la 'X', cierra la aplicación completamente
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Inicio de Sesión",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
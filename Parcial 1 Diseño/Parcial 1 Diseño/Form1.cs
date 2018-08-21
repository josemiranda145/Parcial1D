using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_1_Diseño
{
    public partial class Inicial : Form
    {
        public Inicial()
        {
            InitializeComponent();
            txtContraseña.PasswordChar = '•';
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string NombreUsuarioAdmin = "Administrador";
            string ContraseñaAdmin = "admin";
            string tipoDeUsuario = "Administrador";

            string NombreAdministradorInventario = "AdminInventario";
            string ContraseñaAdInv = "adminv";
            string tipoDeUsuario2 = "AdministradorInventario";
            if (txtUsuario.Text == NombreUsuarioAdmin && txtContraseña.Text == ContraseñaAdmin && comboBox1.Text == tipoDeUsuario)
            {
                FormAdmin FRMAdmin = new FormAdmin();
                FRMAdmin.Show();
                this.Hide();
            }
            else if (txtUsuario.Text == NombreAdministradorInventario && txtContraseña.Text == ContraseñaAdInv && comboBox1.Text == tipoDeUsuario2)
            {
                FormAdminInventario frminv = new FormAdminInventario();
                frminv.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("El usuario, la contraseña o tipo de usuario es incorrecto . Intente nuevamente");
            }
            
        }
    }
}

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
    public partial class FormAdmin : Form
    {
        int i = 1;
        int pos;
        public FormAdmin()
        {
            InitializeComponent();
            MessageBox.Show("Bienvenido");
            Limpiar();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para agregar nueva información llene los campos y despues haga click en agregar. \nPara Modificar coloquese en la fila que desee modificar llene los campos con los nuevos datos y despues dar click en modificar \nPara Eliminar coloquese en la fila que desea eliminar y despues haga click en eliminar");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string co, no, d;
            co = txtCodigoAlmacen.Text;
            no = txtNombre.Text;
            d = txtDirección.Text;
           
            tablDatos.Rows.Add(i + "", co, no, d);
            i = i + 1;
            Limpiar();
        }

        void Limpiar()
        {
            txtCodigoAlmacen.Text = "";
            txtNombre.Text = "";
            txtDirección.Text = "";
           

            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }

        private void tablDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pos = tablDatos.CurrentRow.Index;

            txtCodigoAlmacen.Text = tablDatos[1, pos].Value.ToString();
            txtNombre.Text = tablDatos[2, pos].Value.ToString();
            txtDirección.Text = tablDatos[3, pos].Value.ToString();

            btnAgregar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string co, no, d;
            co = txtCodigoAlmacen.Text;
            no = txtNombre.Text;
            d = txtDirección.Text;
            
            tablDatos[1, pos].Value = txtCodigoAlmacen.Text;
            tablDatos[2, pos].Value = txtNombre.Text;
            tablDatos[3, pos].Value = txtDirección.Text;

            Limpiar();
            btnAgregar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            tablDatos.Rows.RemoveAt(pos);
            Limpiar();
            btnAgregar.Enabled = true;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            
            DialogResult d = MessageBox.Show("¿esta seguro?", "esta por cerrar sesión", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                this.Close();
                Inicial inici = new Inicial();
                inici.Show();
            }
            else if (d == DialogResult.No)
            {
               
            }
        }
    }
    
}

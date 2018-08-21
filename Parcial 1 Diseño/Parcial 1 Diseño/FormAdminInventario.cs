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
    public partial class FormAdminInventario : Form
    {
        int i = 1;
        int pos;
        public FormAdminInventario()
        {
            InitializeComponent();
            MessageBox.Show("Bienvenido");
            Limpiar();
           
        }

        void Limpiar()
        {
            txtCodigoDeProducto.Text = "";
            txtNombre.Text = "";
            txtCantidad.Text = "";
            txtValor.Text = "";
            txtDescripcion.Text = "";
            txtAlmacen.Text = "";

            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string co, no, va, num, des, alm;
            co = txtCodigoDeProducto.Text;
            no = txtNombre.Text;
            num = txtCantidad.Text;
            va = txtValor.Text;
            des = txtDescripcion.Text;
            alm = txtAlmacen.Text;
            tablDatos.Rows.Add(i + "", co, no, num, va, des, alm);
            i = i + 1;
            Limpiar();
        }





        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para agregar nueva información llene los campos y despues haga click en agregar. \nPara Modificar coloquese en la fila que desee modificar llene los campos con los nuevos datos y despues dar click en modificar. \nPara Eliminar coloquese en la fila que desea eliminar y despues haga click en eliminar.");
        }

        

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string co, no, va, num, des, alm;
            co = txtCodigoDeProducto.Text;
            no = txtNombre.Text;
            num = txtCantidad.Text;
            va = txtValor.Text;
            des = txtDescripcion.Text;
            alm = txtAlmacen.Text;

            tablDatos[1, pos].Value = txtCodigoDeProducto.Text;
            tablDatos[2, pos].Value = txtNombre.Text;
            tablDatos[3, pos].Value = txtCantidad.Text;
            tablDatos[4, pos].Value = txtValor.Text;
            tablDatos[5, pos].Value = txtDescripcion.Text;
            tablDatos[6, pos].Value = txtAlmacen.Text;

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

        void tablDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pos = tablDatos.CurrentRow.Index;

            txtCodigoDeProducto.Text = tablDatos[1, pos].Value.ToString();
            txtNombre.Text = tablDatos[2, pos].Value.ToString();
            txtCantidad.Text = tablDatos[3, pos].Value.ToString();
            txtValor.Text = tablDatos[4, pos].Value.ToString();
            txtDescripcion.Text = tablDatos[5, pos].Value.ToString();
            txtAlmacen.Text = tablDatos[6, pos].Value.ToString();

            btnAgregar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }
    }
}

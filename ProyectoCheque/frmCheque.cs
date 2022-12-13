using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCheque
{
    public partial class frmCheque : Form
    {
        public frmCheque()
        {
            InitializeComponent();
        }

        private void frmCheque_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {

            if (!(this.txtNombre.Text.Length == 0) && ValidarUsuario.isString(txtNombre.Text))
            {
                if (this.txtCantidad.Text.Length == 0)
                {
                    MessageBox.Show("Por favor ingrese una cantidad.");
                    this.txtCantidad.Focus();
                    return;

                }
                // Actividad para el estudiante:
                // Validar que txtCantidad tenga valores númericos, con TryParse.
                if (!(Int32.TryParse(this.txtCantidad.Text, out int num)))
                {
                    MessageBox.Show("Debe ingresar una cantidad");
                    txtCantidad.Focus();
                    return;
                }
                num = Convert.ToInt32(this.txtCantidad.Text);
                string nombre = this.txtNombre.Text;
                string res = Funciones.Utilidades.getMillon(num);
                this.txtResultado.Text = $"Pague se a orden de {nombre} la cantiadad de {res} dolares";
            }
            else
            {
                MessageBox.Show("Debes ingresar un nombre");
                this.txtNombre.Focus();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
            if (this.txtCantidad.Text.Length == 0)
            {
                MessageBox.Show("Por favor ingrese un nombre y una cantidad");
                this.txtCantidad.Focus();
                return;

            }
            //Actividad pa los estudiantes:
            //Validar que txt cantidad tenga valores  numericos con truParse
            //Validar que se haya ingresado el nombre
            int num = Int32.Parse(txtCantidad.Text);
            string res = Funciones.Utilidades.getCentenas(num);
            string nombre = this.txtNombre.Text;
            this.txtResultado.Text = $"Pague se a orden de {nombre} la cantiadad de {res} dolares";

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

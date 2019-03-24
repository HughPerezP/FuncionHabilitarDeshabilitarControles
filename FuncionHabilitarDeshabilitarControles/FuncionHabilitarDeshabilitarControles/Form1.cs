using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FuncionHabilitarDeshabilitarControles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bloquear_Click(object sender, EventArgs e)
        {
            List<Control> ListaControles = new List<Control>() { this.txtEmpleado, this.txtNombre, this.dtpnacimiento, this.GroupBox1 };
            FuncionesBasicas.BloqueadorCajasdeTexto(ListaControles, false);
        }

        private void btnDesbloquear_Click(object sender, EventArgs e)
        {
            List<Control> ListaControles = new List<Control>() { this.txtEmpleado, this.txtNombre, this.dtpnacimiento, this.GroupBox1 };
            FuncionesBasicas.BloqueadorCajasdeTexto(ListaControles, true);
        }



    }
}

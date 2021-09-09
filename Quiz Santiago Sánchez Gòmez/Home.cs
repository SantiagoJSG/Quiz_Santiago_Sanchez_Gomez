using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Santiago_Sánchez_Gòmez
{
    public partial class Home : Form
    {
        Form Report;

        public Home()
        {
            InitializeComponent();            
        }
        public string texto = "";

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text == "" | txtID.Text == "" | txtcorreo.Text == "" | txtfacultad.Text == "")
            {
                MessageBox.Show("Falta algun campo por responder del formulario.");
                return;
            }
            rtxtResults.Text +=  "Nombre: " + txtnombre.Text + "\nID: " + txtID.Text  +  "\nCorreo: " + txtcorreo.Text + "\nFacultad: " + txtfacultad.Text + "\nFecha: " + dtfecha.Value + "\n\n";
            txtnombre.Clear();
            txtID.Clear();
            txtcorreo.Clear();
            txtfacultad.Clear();
            texto = rtxtResults.Text;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {            
            if (Report == null || Report.IsDisposed)
            {
                Form Formulario2 = new Report(texto);
                Formulario2.Show();
            }
        }
    }
}

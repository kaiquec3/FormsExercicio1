using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsExercício1
{
    public partial class frmRetangulo : Form
    {
       
        public frmRetangulo()
        {
            InitializeComponent();

            lblArea.Text = "0";
        }

        private void clickou_calcular_area(object sender, EventArgs e)
        {
            Retangulo ret = new Retangulo(double.Parse(txtBase.Text), double.Parse(txtAltura.Text));
            ret.CalcularArea();
            lblArea.Text = ret.GetArea().ToString();
        }
    }
}

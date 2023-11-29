using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion_II_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnresul_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;

            num1 = Convert.ToInt32(Num1.Text);
            num2 = Convert.ToInt32(Num2.Text);

            if (num1>num2)
                {
                btnresul.Text = "El primer nùmero es mayor" ;
            }
            else
                    {
                btnresul.Text = "El segundo nùmero es mayor";
            }

            Mostrar.Text= btnresul.Text;
        }

        private void Num1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            Num1.Clear();
            Num2.Clear();
            Mostrar.Clear();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Exc2 : Form
    {
        public Exc2()
        {
            InitializeComponent();
        }

        private void BtnCalculoAB_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtValorA.Text);
            int b = Convert.ToInt32(txtValorB.Text);
            double X = ((a * 9) / (87 - b)) * 2;

            double sum = X;

            MessageBox.Show($"A soma é : {sum}");

            txtValorA.Text = string.Empty;
            txtValorB.Text = string.Empty;
        }
    }
}

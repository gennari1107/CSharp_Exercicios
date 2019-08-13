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
    public partial class Exc3 : Form
    {
        public Exc3()
        {
            InitializeComponent();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            double salario = Convert.ToDouble(txtSalario.Text);
            double reajuste = Convert.ToDouble(txtReajust.Text);

            double sum = (salario * reajuste) / 100;

            double Totalsalario = salario + sum;

            MessageBox.Show(string.Format(" O Valor total a receber é : {0:0,0.00}", Totalsalario));

            txtSalario.Text = string.Empty;
            txtReajust.Text = string.Empty;
        }
    }
}

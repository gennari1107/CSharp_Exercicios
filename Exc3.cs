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

            //variável com nome maiúsculo, substituir para totalSalario
            double Totalsalario = salario + sum;

            //Eu trocaria por esse código aqui...
            MessageBox.Show($"O Valor total a receber é : {Totalsalario.ToString("C")}");
            

            txtSalario.Text = string.Empty;
            txtReajust.Text = string.Empty;
        }
    }
}

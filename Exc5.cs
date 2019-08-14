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
    public partial class Exc5 : Form
    {
        public Exc5()
        {
            InitializeComponent();
        }

        private void BtnNovoSalario_Click(object sender, EventArgs e)
        {
            //variável string sem aplicação em lugar nenhuma
            //alocou espaço em memória atoa
            string nome = txtNomeFunc.Text;

            double salarioFix = Convert.ToDouble(txtSlrFixo.Text);
            double vendaMed = Convert.ToDouble(txtVendas.Text);

            double calcVenda = salarioFix + (vendaMed * 0.10);

            //não usou string interpolation EX MALANDRO
            MessageBox.Show("Funcionário: " + txtNomeFunc.Text+ "\n"
                            + "Salario base: " + txtSlrFixo.Text + "\n"
                            + "Venda Total do Mês: " + txtVendas.Text + "\n"
                            + "Total Salário mais bonificação: " + calcVenda + "\n");

            txtNomeFunc.Text = string.Empty;
            txtSlrFixo.Text = string.Empty;
            txtVendas.Text= string.Empty;
        }
    }
}

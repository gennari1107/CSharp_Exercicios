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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            var vlr = Convert.ToInt32(txtNum.Text);
            if (vlr % 2 == 0)
            {
                MessageBox.Show($"{vlr} O Valor informado é divisivel por ele mesmo");
            }
            else
            {
                MessageBox.Show($"{vlr} O Valor informado não é divisivel por ele");
            }



            //fiz o mesmo código, porém com um nó a menos
            if (vlr % 2 == 0)
            {
                MessageBox.Show($"{vlr} O Valor informado é divisivel por ele mesmo");
                return;
            }

            MessageBox.Show($"{vlr} O Valor informado não é divisivel por ele");

        }
    }
}

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
    public partial class Exc4 : Form
    {
        public Exc4()
        {
            InitializeComponent();
        }

        private void BtnCalculo_Click(object sender, EventArgs e)
        {
            double aut = 12;
            double Dist, Litrs;
            double tempViagem = Convert.ToDouble(txtTempGast.Text);
            double vlMedia = Convert.ToDouble(txtVelocMedia.Text);

            Dist = vlMedia * tempViagem;

            Litrs = Dist / aut;

            MessageBox.Show("Tempo gasto: " + txtTempGast + "\n"
                    + "Velocidade Média: " + txtVelocMedia.Text + "\n"
                    + "Distância Percorrida: " + Dist + "\n"
                    + "Litros Utilizados: " + Litrs + "\n");

            txtTempGast.Text = string.Empty;
            txtVelocMedia.Text = string.Empty;
        }
    }
}

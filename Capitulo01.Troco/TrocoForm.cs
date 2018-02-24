using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capitulo01.Troco
{
    public partial class TrocoForm : Form
    {
        public TrocoForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void moedasListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            decimal valorCompra = Convert.ToDecimal(valorCompraTextBox.Text);

            decimal valorPago = Convert.ToDecimal(valorPagoTextBox.Text);

            decimal troco = valorPago - valorCompra;

            trocoTextBox.Text = troco.ToString("c"); //"c" moedas//

            //ToDo: refaturar para usar estrutura de repetição

            var moedas1 = (int)troco;

            //troco = troco % 1;
            troco %= 1;

            var moedas050 = (int)(troco / 0.5m);
            troco %= 0.5m;

            var moedas025 = (int)(troco / 0.25m);
            troco %= 0.25m;

            var moedas010 = (int)(troco / 0.1m);
            troco %= 0.1m;

            var moedas005 = (int)(troco / 0.05m);
            troco %= 0.05m;

            var moedas001 = (int)(troco / 0.01m);
            troco %= 0.01m;

            moedasListView.Items[0].Text = moedas1.ToString();
            moedasListView.Items[1].Text = moedas050.ToString();
            moedasListView.Items[2].Text = moedas025.ToString();
            moedasListView.Items[3].Text = moedas010.ToString();
            moedasListView.Items[4].Text = moedas005.ToString();
            moedasListView.Items[5].Text = moedas001.ToString();

            



        }
    }
}

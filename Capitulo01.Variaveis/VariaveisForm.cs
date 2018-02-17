using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capitulo01.Variaveis
{
    public partial class VariaveisForm : Form
    {
        int _x = 32;
        int _w = 45;
        int _y = 16;
        int _z = 32;

        public VariaveisForm()
        {
            InitializeComponent();
        }

        private void aritmeticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //obs.comentario//
            int a = 2;
            int b = 6, c = 10, d = 13;

            resultadoListBox.Items.Add("a = " + a);
            resultadoListBox.Items.Add("b = " + b);
            resultadoListBox.Items.Add("c = " + c);
            resultadoListBox.Items.Add("d = " + d.ToString());

            resultadoListBox.Items.Add(new string('_',50));
        

            resultadoListBox.Items.Add("c * d = " + (c * d)); //multiplicação//
            resultadoListBox.Items.Add("c / a = " + (c / a)); //divisão//
            resultadoListBox.Items.Add("d % a = " + (d % a)); //resto, não resultado//
           








            //int A = 42;

            //decimal valor = 10;
            //string nomeCliente = "Andressa"; //var//
            //bool habilitado = false;
            //DateTime data = new DateTime(1986,07,04);

            /*if (a==14)
            {

            }*/
        }

        private void reduzidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var x = 5;
            resultadoListBox.Items.Add("x = " + x);

            x = x - 3; // ou x-= 3;//

            resultadoListBox.Items.Add("x = " + x);
        }

        private void incrementaisDecrementaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a;
            a = 5;

            resultadoListBox.Items.Add("Exemplo de Pré-Incremental");
            resultadoListBox.Items.Add("a = " + a);
            resultadoListBox.Items.Add("2 + ++a =" + (2 + ++a)); //= 8 (++após variável)//
            resultadoListBox.Items.Add("2 = " + a);


            a = 5;

            resultadoListBox.Items.Add("Exemplo de Pós-Incremental");
            resultadoListBox.Items.Add("a = " + a);
            resultadoListBox.Items.Add("2 + a++ =" + (2 + a++)); //7 (váriavel antes ++)//
            resultadoListBox.Items.Add("2 = " + a);



        }

        private void booleanasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarVariaveis();

            resultadoListBox.Items.Add("w < x " + (_w < _x));
            resultadoListBox.Items.Add("x == z = " + (_x == _z)); //comparação dobra o sinal de =//
            resultadoListBox.Items.Add("x != z = " + (_x != _z)); //! sinal de diferente// 


        }

        private void MostrarVariaveis()
        {
            resultadoListBox.Items.Add("x = " + _x);
            resultadoListBox.Items.Add("w = " + _w);
            resultadoListBox.Items.Add("y = " + _y);
            resultadoListBox.Items.Add("z = " + _z);
        }

        private void logicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarVariaveis(); //CTRL+R+M//

            resultadoListBox.Items.Add("_w <= x || _y == 16 =" + (_w <= _x || _y ==16));
            resultadoListBox.Items.Add("_w <= x || _y == 16 =" + (_w <= _x || _y ==16));
        }

        private void ternariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ano;
                   
            ano = 2014;

            resultadoListBox.Items.Add("Ano = " + ano);
            resultadoListBox.Items.Add(string.Format("O ano {0} é bissexto? {1}.",ano,
                ano % 4 ==0 ? "Sim" : "Não")); //Para saber se é um ano bissexto//


            ano = 2016;

            resultadoListBox.Items.Add("Ano = " + ano);
            resultadoListBox.Items.Add(string.Format("O ano {0} é bissexto? {1}.", ano,
                            DateTime.IsLeapYear(ano) ? "Sim" : "Não"));
            

        }
    }
}

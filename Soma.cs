using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomaLogin
{
    public partial class Soma : Form
    {
        public Soma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Variável para receber o resultado da soma 
            int result = 0;

            // Loop iterando por cada número de 1 a 1000
            for (int i = 1; i <= 1000; i++)
            {
                // Condicional que soma o número à variável result, caso ele seja ímpar
                if (i % 2 != 0)
                {
                    result += i;
                }
            }
            // Convertendo o resultado para uma String para que posso ser mostrado na textBox
            textBox1.Text = result.ToString();
        }


    }
}

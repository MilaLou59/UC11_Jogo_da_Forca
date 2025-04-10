using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC11_JOGO_DA_FORCA
{
    public partial class Form1 : Form
    {
        private string palavraSecreta;
        private int tentativas;
       
        public Form1()
        {
            InitializeComponent();

            palavraSecreta = "palavra";
            tentativas = 6;
            


        }
      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonVERIFICAR_Click(object sender, EventArgs e)
        {
            string letra = textBoxLETRA.Text;

            if (letra.Length == 1)
            {
                if (palavraSecreta.Contains(letra))
                {
                  
                }

            }
        }

        private void buttonINICIAR_Click(object sender, EventArgs e)
        {
            string= "Laranja";

        }
    }
}

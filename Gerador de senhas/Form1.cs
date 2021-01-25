using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerador_de_senhas
{
    public partial class Form1 : Form
    {
        int senhas = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            string caracteres = "abcdefghijklmnopqrstuvwxyz";
            if (ckbM.Checked)
                caracteres += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (ckbN.Checked)
                caracteres += "0123456789";
            if (ckbS.Checked)
                caracteres += "!@#$%¨&*()_-+=§°?/;:.,[{]}ºª|";

            lstSenhas.Items.Clear();
            Random rnd = new Random();
            for (int n = 1; n <= senhas; n++)
            {
                StringBuilder str = new StringBuilder();
                for(int m = 1; m <= nudChars.Value; m++)
                {
                    int pos = rnd.Next(0, caracteres.Length);
                    str.Append(caracteres[pos].ToString());
                }
                lstSenhas.Items.Add(str.ToString());
            }

        }
    }
}

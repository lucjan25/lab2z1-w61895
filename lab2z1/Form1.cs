using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2z1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLicz_Click(object sender, EventArgs e)
        {
            try
            {
                double wzrost = Convert.ToDouble(tbWzrost.Text);
                bool standardowa = cbStandardowa.Checked;
                bool idealna = cbIdealna.Checked;
                double waga;

                if (standardowa == true)
                {
                    waga = wzrost - 100;
                    lblWynik.Text = "Wynik: " + waga.ToString();
                }
                else if (idealna == true)
                {
                    waga = wzrost - 100;
                    if (rdoKobieta.Checked)
                    {
                        waga = waga * 0.85;
                        lblWynik.Text = "Wynik: " + waga.ToString();
                    }
                    else if (rdoMezczyzna.Checked)
                    {
                        waga = waga * 0.90;
                        lblWynik.Text = "Wynik: " + waga.ToString();
                    }
                    else
                        lblWynik.Text = "Wynik: nie wybrano płci";

                }
                else lblWynik.Text = "Wynik: nie wybrano wagi do obliczenia.";


            }
            catch (Exception)
            {
                MessageBox.Show("Podaj poprawny wzrost", "Uwaga!", MessageBoxButtons.OK);
            }
        }

        private void cbStandardowa_CheckedChanged(object sender, EventArgs e)
        {
            cbIdealna.Enabled = !cbStandardowa.Checked;
        }

        private void cbIdealna_CheckedChanged(object sender, EventArgs e)
        {
            cbStandardowa.Enabled = !cbIdealna.Checked;
        }
    }
}

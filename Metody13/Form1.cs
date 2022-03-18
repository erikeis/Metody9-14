using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool JeAlfanum(string vstup, out int pocetMalych, out int pocetVelkych, out int pocetJinych)
        {
            bool vstupJeAlfanum = false;
            pocetMalych = 0;
            pocetVelkych = 0;
            pocetJinych = 0;
            foreach (char znak in vstup)
            {
                if (char.IsLetterOrDigit(znak))
                {
                    vstupJeAlfanum = true;
                    if (char.IsUpper(znak))
                    {
                        ++pocetVelkych;
                    }
                    else if (char.IsLower(znak))
                    {
                        ++pocetMalych;
                    }
                }
                else
                {
                    ++pocetJinych;
                    vstupJeAlfanum = false;
                }
            }
            return vstupJeAlfanum;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string retezec = textBox1.Text;
            int pocetM;
            int pocetV;
            int pocetJ;
            if (JeAlfanum(retezec, out pocetM, out pocetV, out pocetJ))
            {
                MessageBox.Show("Retezec je alfanumerum.");
            }
            else MessageBox.Show("Retezec neni alfanumericky.\n" + "Pocet velkych pismen: " + pocetV + "\nPocet malych pismen: " + pocetM + "\nPocet jinych znaku: " + pocetJ);
        }
    }
}

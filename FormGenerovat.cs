using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autoskola
{
    public partial class FormGenerovat : Form
    {
        public static string hesloGen;
        public string[] poleznaku = { "a", "b", "c", "d", "e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z","A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
        public FormGenerovat()
        {
            InitializeComponent();
        }

        private void FormGenerovat_Load(object sender, EventArgs e)
        {
            bool cyklus = true;
            string heslo = "";
            Random rndznak = new Random();
            int pocetcisel = 0;
            int pocetvelkych = 0;
            while (cyklus == true)
            {
                for (int i = 0; i < 8; i++)
                {
                    int index = rndznak.Next(0, 62);
                    heslo += poleznaku[index];

                    if (char.IsNumber(heslo[i]))
                    {
                        pocetcisel++;
                    }
                    if (char.IsUpper(heslo[i]))
                    {
                        pocetvelkych++;
                    }

                }
                if (pocetvelkych >= 1 && pocetcisel >= 1)
                {
                    
                    labelHeslo.Text = heslo;
                    cyklus = false;
                }
                if (pocetvelkych < 1 || pocetcisel < 1)
                {
                    heslo = "";
                }
            }
            
            
        }

        private void buttonKopirovat_Click(object sender, EventArgs e)
        {
            labelKopirovat.Text = "Heslo úspěšně zkopírováno!";
            
            System.Windows.Forms.Clipboard.SetText(labelHeslo.Text);
        }

        private void buttonGenerovat_Click(object sender, EventArgs e)
        {
            labelKopirovat.Text = "";
            bool cyklus = true;
            string heslo = "";
            Random rndznak = new Random();
            int pocetcisel = 0;
            int pocetvelkych = 0;
            while (cyklus == true)
            {
                for (int i = 0; i < 8; i++)
                {
                    int index = rndznak.Next(0, 62);
                    heslo += poleznaku[index];

                    if (char.IsNumber(heslo[i]))
                    {
                        pocetcisel++;
                    }
                    if (char.IsUpper(heslo[i]))
                    {
                        pocetvelkych++;
                    }

                }
                if (pocetvelkych >= 1 && pocetcisel >= 1)
                {
                    labelHeslo.Text = heslo;
                    cyklus = false;
                }
                if (pocetvelkych < 1 || pocetcisel < 1)
                {
                    heslo = "";
                }
            }
        }

        private void buttonPotvrdit_Click(object sender, EventArgs e)
        {
            hesloGen = labelHeslo.Text;
        }
    }
}

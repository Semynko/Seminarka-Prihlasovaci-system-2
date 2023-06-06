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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPrihlasit_Click(object sender, EventArgs e)
        {
            
            FormPrihlaseni fo = new FormPrihlaseni();
            fo.ShowDialog
                ();
            
            
        }

        private void buttonInformace_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autoři:" + "\n" + "Michal Voráček" + "\n" + "Miroslav Petruška"
                + "\n" + "Ondřej Semenec" + "\n" + "Adam Kašpar" + "\n" +"\n" +"Aplikace slouží pro rezervaci cvičných jízd při řidičském výcviku." + "\n" + 
                "Uživatel se musí podle daných kritérií registrovat do systému, po úspěšné registraci a přihlášení je přesměrován na samotnou rezervaci jízd");
        }
    }
}

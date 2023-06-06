using System;
using System.IO;
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
    public partial class FormVlastniHeslo : Form
    {
        public static string heslo;
        
        public FormVlastniHeslo()
        {
            InitializeComponent();
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (textBoxNoveHeslo.Text == textBoxPotvrdit.Text)
            {
                labelKopirovat.Text = "Heslo úspěšně zkopírováno!";
                System.Windows.Forms.Clipboard.SetText(textBoxNoveHeslo.Text);
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            labelKopirovat.Text = "";
            int indexemailu = 0;
            Hash hash = new Hash();
            Uzivatel uz = new Uzivatel(FormZapomenute.jmenoZapomel, "", "", FormZapomenute.emailZapomel, 0, 0, 0, null, null, null, "", "", ""); ;
            using (StreamReader emaily = new StreamReader("emaily.txt"))
            {
                uz.Pocetradkuemail = 0;
                string radek;
                while ((radek = emaily.ReadLine()) != null)
                {
                    uz.Pocetradkuemail++;
                    uz.Email += (radek + "\n");
                    if(radek == uz.Emailus)
                    {
                        indexemailu = uz.Pocetradkuemail;
                    }
                }
                if (uz.Pocetradkuemail != 0)
                {
                    uz.Rademail = uz.Email.Split('\n');
                }
                emaily.Close();
            }
            using (StreamReader jmena = new StreamReader("jmena.txt"))
            {
                uz.Pocetradkujmen = 0;
                string radek;
                while ((radek = jmena.ReadLine()) != null)
                {
                    uz.Pocetradkujmen++;
                    uz.Jmen += (radek + "\n");
                }
                if (uz.Pocetradkujmen != 0)
                {
                    uz.Radjmen = uz.Jmen.Split('\n');
                }
                jmena.Close();
            }
            using (StreamReader hesla = new StreamReader("hesla.txt"))
            {
                uz.Pocetradkuhes = 0;
                string radek;
                while ((radek = hesla.ReadLine()) != null)
                {
                    uz.Pocetradkuhes++;
                    uz.Hes += (radek + "\n");
                }
                uz.Radhes = null;
                uz.Radhes = uz.Hes.Split('\n');
                hesla.Close();
            }
            if (textBoxNoveHeslo.Text == textBoxPotvrdit.Text)
            {
                if(textBoxNoveHeslo.Text.Length >= 8)
                {
                    int pocetvelkych = 0;
                    for(int i = 0; i < textBoxNoveHeslo.Text.Length; i++)
                    {
                        if (char.IsUpper(textBoxNoveHeslo.Text[i]))
                        {
                            pocetvelkych++;
                        }
                    }
                    if (pocetvelkych > 0)
                    {
                        int pocetcisel = 0;
                        for(int j = 0; j < textBoxNoveHeslo.Text.Length; j++)
                        {
                            if (char.IsNumber(textBoxNoveHeslo.Text[j]))
                            {
                                pocetcisel++;
                            }
                        }
                        if (pocetcisel > 0)
                        {
                            heslo = textBoxNoveHeslo.Text;    
                        }
                        else
                        {
                            MessageBox.Show("Heslo musí obsahovat alespoň jednu číslici!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Heslo musí obsahovat alespoň jedno velké písmeno!");
                    }
                }
                else
                {
                    MessageBox.Show("Heslo musí obsahovat nejméně 8 znaků!");
                }
            }
            else
            {
                MessageBox.Show("Zadaná hesla se neshodují!");
            }
        }

    }
}

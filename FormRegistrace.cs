using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Autoskola
{
    public partial class FormRegistrace : Form
    {
        public static string jmeno;
        public static string heslo;
        public static string potvrdit;
        public static string email;

        public FormRegistrace()
        {
            InitializeComponent();
        }

        private void buttonRegistrovat_Click(object sender, EventArgs e)
        {
            Hash hash = new Hash();
            FormPrihlaseni prihla = new FormPrihlaseni();
            Uzivatel uz = new Uzivatel(textBoxJmeno.Text, textBoxHeslo.Text, textBoxPotvrdit.Text, textBoxEmail.Text, 0, 0, 0, null, null, null, "", "", "");
            int pocetvelkych = 0;
            int pocetcisel = 0;
            int pocetzavinacu = 0;
            int pocettecek = 0;
            if (uz.Uzjmeno.Length > 0 && uz.Emailus.Length > 0)
            {
                if (uz.Heslo.Length >= 8)
                {
                    for (int i = 0; i < uz.Heslo.Length; i++)
                    {
                        if (char.IsUpper(uz.Heslo[i]))
                        {
                            pocetvelkych++;
                        }
                    }
                    if (pocetvelkych >= 1)
                    {
                        for (int j = 0; j < uz.Heslo.Length; j++)
                        {
                            if (char.IsNumber(uz.Heslo[j]))
                            {
                                pocetcisel++;
                            }
                        }
                        if (pocetcisel >= 1)
                        {
                            int indexzavinace = 0;
                            for (int y = 0; y < uz.Emailus.Length; y++)
                            {
                                if (char.Equals(uz.Emailus[y], '@'))                                
                                {
                                    pocetzavinacu++;
                                    indexzavinace = y;
                                }
                            }
                            if(pocetzavinacu == 1)
                            {    
                                int indextecky = 0;
                                for (int u = 0; u < uz.Emailus.Length; u++)
                                {
                                    if (char.Equals(uz.Emailus[u], '.'))
                                    {
                                        pocettecek++;
                                        indextecky = u;
                                    }
                                }    
                                if(indexzavinace+1 < indextecky && pocettecek>0)
                                {
                                    if (uz.Heslo == uz.Potvrditheslo)
                                    {
                                        heslo = textBoxHeslo.Text;
                                        jmeno = textBoxJmeno.Text;
                                        email = textBoxEmail.Text;
                                        potvrdit = textBoxPotvrdit.Text;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Neshodná hesla!");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Neplatná emailová adresa!");
                                } 
                            }
                            else
                            {
                                MessageBox.Show("Neplatná emailová adresa!");
                            }
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
                MessageBox.Show("Zadejte jméno a heslo!");
            }
        }

        private void FormRegistrace_Load(object sender, EventArgs e)
        {

        }
    }    
}

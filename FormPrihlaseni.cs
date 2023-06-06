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
using System.Diagnostics;
using System.Security.Policy;

namespace Autoskola
{
    public partial class FormPrihlaseni : Form
    {
        public FormRegistrace reg = new FormRegistrace();
        public FormSystem sys = new FormSystem();
       
        public FormPrihlaseni()
        {
            InitializeComponent();    
        }

        private void buttonRegistr_Click(object sender, EventArgs e)
        {
            Hash hash = new Hash();
            

            if (reg.ShowDialog() == DialogResult.OK)
            {
                Uzivatel uz = new Uzivatel(FormRegistrace.jmeno, FormRegistrace.heslo, FormRegistrace.potvrdit, FormRegistrace.email, 0, 0, 0, null, null, null, "", "", "");
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
                using (StreamReader emaily = new StreamReader("emaily.txt"))
                {
                    uz.Pocetradkuemail = 0;
                    string radek;
                    while ((radek = emaily.ReadLine()) != null)
                    {
                        uz.Pocetradkuemail++;
                        uz.Email += (radek + "\n");
                    }
                    if (uz.Pocetradkuemail != 0)
                    {
                        uz.Rademail = uz.Email.Split('\n');
                    }
                    emaily.Close();
                }
                if (uz.Pocetradkujmen == 0)
                {
                    using (StreamWriter jmena = new StreamWriter("jmena.txt", true))
                    {
                        jmena.WriteLine(uz.Uzjmeno.ToString());
                        jmena.Close();
                    }
                    using (StreamWriter emaily = new StreamWriter("emaily.txt", true))
                    {
                        emaily.WriteLine(uz.Emailus.ToString());
                        emaily.Close();
                    }
                    using (StreamWriter hesla = new StreamWriter("hesla.txt", true))
                    {
                        hesla.WriteLine(hash.PokusOHash(uz.Heslo).ToString());
                        hesla.Close();
                    }

                }
                if (uz.Pocetradkujmen != 0)
                {
                    for (int i = 0; i < uz.Pocetradkujmen; i++)
                    {
                        if (uz.Radjmen[i].ToString() != uz.Uzjmeno && uz.Rademail[i].ToString() != uz.Emailus)
                        {
                            using (StreamWriter jmena = new StreamWriter("jmena.txt", true))
                            {
                                jmena.WriteLine(uz.Uzjmeno.ToString());
                                jmena.Close();
                            }
                            using (StreamWriter emaily = new StreamWriter("emaily.txt", true))
                            {
                                emaily.WriteLine(uz.Emailus.ToString());
                                emaily.Close();
                            }
                            using (StreamWriter hesla = new StreamWriter("hesla.txt", true))
                            {
                                hesla.WriteLine(hash.PokusOHash(uz.Heslo).ToString());
                                hesla.Close();
                            }

                            break;
                        }
                        if (uz.Radjmen[i].ToString() == uz.Uzjmeno)
                        {
                            MessageBox.Show("Toto uživatelské jméno je již používané!");
                            break;
                        }
                        if (uz.Rademail[i].ToString() == uz.Emailus)
                        {
                            MessageBox.Show("Tento email je již používán!");
                            break;
                        }
                    }
                }
            }
        }

        private void buttonPrihlasit_Click(object sender, EventArgs e)
        {
            Hash hash = new Hash();
            Uzivatel uz = new Uzivatel(textBoxJmeno.Text, textBoxHeslo.Text,"","", 0, 0, 0, null, null, null, "", "", "");
            using (StreamReader hesla = new StreamReader("hesla.txt"))
            {
                uz.Pocetradkuhes = 0;
                string radek;
                while((radek = hesla.ReadLine()) != null)
                {
                    uz.Pocetradkuhes++;
                    uz.Hes += (radek + "\n");
                    
                }
                uz.Radhes = null;
                uz.Radhes = uz.Hes.Split('\n');
                hesla.Close();
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
                jmena.Close();
            }
            using (StreamReader emaily = new StreamReader("emaily.txt"))
            {
                uz.Pocetradkuemail = 0;
                string radek;
                while((radek = emaily.ReadLine()) != null)
                {
                    uz.Pocetradkuemail++;
                    uz.Email += (radek + "\n");
                }
                emaily.Close();
            }
            string pomocnahes = textBoxHeslo.Text;
            string pomocnajmen = textBoxJmeno.Text;
            for (int i = 0; i < uz.Pocetradkujmen; i++)
            {
                uz.Radjmen = null;
                uz.Radjmen = uz.Jmen.Split('\n');
                uz.Rademail = null;
                uz.Rademail = uz.Email.Split('\n');
 
                if (hash.PokusOHash(pomocnahes) == uz.Radhes[i].ToString() && pomocnajmen == uz.Radjmen[i].ToString())
                {
                    this.Close();
                    sys.ShowDialog();
                    break;   
                }
                if (hash.PokusOHash(pomocnahes) != uz.Radhes[i].ToString() && pomocnajmen == uz.Radjmen[i].ToString()) 
                {    
                    MessageBox.Show("Špatné heslo!");
                    break;
                }

            }
            
        }

        private void buttonZapomel_Click(object sender, EventArgs e)
        {
            
            FormZapomenute fr = new FormZapomenute();
            fr.ShowDialog();
            this.Close();
        }

        private void FormPrihlaseni_Enter(object sender, EventArgs e)
        {
            
        }
    }
}

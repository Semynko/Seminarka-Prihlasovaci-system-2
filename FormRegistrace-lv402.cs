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
        /*
        public static string uzjmeno;
        public static string heslo;
        public static string potvrditheslo;
        public static string emailus;
        public static int pocetradkuhes = 0;
        public static int pocetradkujmen = 0;
        public static int pocetradkuemail = 0;
        public static string[] radhes;
        public static string[] radjmen;
        public static string[] rademail;
        public static string jmen;
        public static string hes;
        public static string email;
        */
        public FormPrihlaseni prihla = new FormPrihlaseni();
        public FormRegistrace()
        {
            InitializeComponent();
        }

        private void buttonRegistrovat_Click(object sender, EventArgs e)
        {

            Uzivatel uz = new Uzivatel(textBoxJmeno.Text, textBoxHeslo.Text, textBoxPotvrdit.Text, textBoxEmail.Text, 0, 0, 0, null, null, null, "", "", "");
            
            //uzjmeno = textBoxJmeno.Text;
            //heslo = textBoxHeslo.Text;
            //potvrditheslo = textBoxPotvrdit.Text;
            //email = textBoxEmail.Text;
            int pocetvelkych = 0;
            int pocetcisel = 0;
            if(uz.Uzjmeno.Length > 0 && uz.Emailus.Length > 0)
            {
                if(uz.Heslo.Length >= 8)
                {
                    for(int i = 0; i < uz.Heslo.Length; i++)
                    {
                        if (char.IsUpper(uz.Heslo[i]))
                        {
                            pocetvelkych++;
                        }
                    }
                    if(pocetvelkych >= 1)
                    {
                        for (int j = 0;  j< uz.Heslo.Length; j++)
                        {
                            if (char.IsNumber(uz.Heslo[j]))
                            {
                                pocetcisel++;
                            }
                        }
                        if (pocetcisel >= 1)
                        {
                            if (uz.Heslo == uz.Potvrditheslo)
                            {
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
                                if(uz.Pocetradkujmen == 0)
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
                                        hesla.WriteLine(uz.Heslo.ToString());
                                        hesla.Close();
                                    }
                                    
                                    //this.Close();
                                    prihla.ShowDialog();
                                       
                                }
                                if(uz.Pocetradkujmen!=0)
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
                                                hesla.WriteLine(uz.Heslo.ToString());
                                                hesla.Close();
                                            }
                                            //this.Close();
                                            
                                            prihla.ShowDialog();
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
                                
                                
                                
                                //tohle dodelat
                                
                                
                                
                                
                                

                            }
                            else
                            {
                                MessageBox.Show("Neshodná hesla!");
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
    }
}

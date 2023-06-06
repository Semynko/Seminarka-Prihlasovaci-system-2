using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autoskola
{
    public partial class FormZapomenute : Form
    {
        public static string emailZapomel;
        public static string jmenoZapomel;
        public FormZapomenute()
        {
            InitializeComponent();
        }

        private void radioButtonZadane_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonPotvrdit_Click(object sender, EventArgs e)
        {
            Hash hash = new Hash();
            emailZapomel = textBoxEmail.Text;
            jmenoZapomel = textBoxUsername.Text;
            Uzivatel uz = new Uzivatel(jmenoZapomel, "", "", emailZapomel, 0, 0, 0, null, null, null, "", "", ""); ;
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
            int index=0;
            using (StreamReader jmena = new StreamReader("jmena.txt"))
            {
                uz.Pocetradkujmen = 0;
                string radek;
                while ((radek = jmena.ReadLine()) != null)
                {
                    uz.Pocetradkujmen++;
                    uz.Jmen += (radek + "\n");
                    if(radek == uz.Uzjmeno)
                    {
                        index = uz.Pocetradkujmen;
                        MessageBox.Show("index = " + index);
                    }

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
            for (int i = 0; i < uz.Pocetradkujmen; i++)
            {
                if (uz.Radjmen[i].ToString() == textBoxUsername.Text && textBoxEmail.Text == uz.Rademail[i].ToString())
                {
                    if (radioButtonZadane.Checked)
                    {
                        for(int j = 0; j < uz.Radhes.Length; j++)
                        {
                            MessageBox.Show("Radhes na indexu " + j + ": " + "\n" + uz.Radhes[j].ToString());
                        }
                        FormVlastniHeslo vl = new FormVlastniHeslo();
                        
                        if(vl.ShowDialog() == DialogResult.OK)
                        {
                            MessageBox.Show("Radhes na indexu " + index + ": " +uz.Radhes[index].ToString());
                            string tmp = "";

                            tmp = uz.Hes.Replace(uz.Radhes[index-1].ToString(), hash.PokusOHash(FormVlastniHeslo.heslo));
                            using (StreamWriter hesla = new StreamWriter("hesla.txt", false))
                            {
                                hesla.Write(string.Empty);
                                hesla.Write(tmp);
                                hesla.Close();
                            }
                            MessageBox.Show(tmp);
                        }
                        break;

                    }
                    if (radioButtonNahodne.Checked)
                    {
                        FormGenerovat gen = new FormGenerovat();
                        
                        if(gen.ShowDialog() == DialogResult.OK)
                        {
                            string tmp = "";
                            tmp = uz.Hes.Replace(uz.Radhes[index - 1].ToString(), hash.PokusOHash(FormGenerovat.hesloGen));
                            using (StreamWriter hesla = new StreamWriter("hesla.txt", false))
                            {
                                hesla.Write(string.Empty);
                                hesla.Write(tmp);
                                hesla.Close();
                            }
                        }
                        break;
                    }
                    if(!radioButtonZadane.Checked && !radioButtonNahodne.Checked)
                    {
                        MessageBox.Show("Prosím vyberte jednu z možností");
                    }
                }
            }
            
        }
    }
}

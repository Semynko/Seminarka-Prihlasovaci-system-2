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

namespace Autoskola
{
    public partial class FormPrihlaseni : Form
    {
        
        
        /* 
         public static string jmen;
         public static string hes;
         public static string email;
         public static int pocetradkuhes = 0;
         public static int pocetradkujmen = 0;
         public static int pocetradkuemail = 0;
         public static string[] radhes;
         public static string[] radjmen;
         public static string[] rademail;
         */
        public FormPrihlaseni()
        {
            InitializeComponent();
            
        }

        private void buttonRegistr_Click(object sender, EventArgs e)
        {
            
            FormRegistrace reg = new FormRegistrace();

            reg.ShowDialog();
            
        }

        private void buttonPrihlasit_Click(object sender, EventArgs e)
        {
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
                //FormRegistrace.radjmen = null;
                //FormRegistrace.radjmen = FormRegistrace.jmen.Split('\n');


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
                //FormRegistrace.rademail = null;
                //FormRegistrace.rademail = FormRegistrace.email.Split('\n');
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
                
                /*
                MessageBox.Show(FormRegistrace.radhes[i].ToString().Trim());
                MessageBox.Show(FormRegistrace.radjmen[i].ToString().Trim());
                MessageBox.Show("Prvni v radhes:" + FormRegistrace.radhes[0].ToString().Trim());
                MessageBox.Show("Prvni v radjmen: " + FormRegistrace.radjmen[0].ToString().Trim());
                MessageBox.Show("Druhy v radhes:" + FormRegistrace.radhes[1].ToString().Trim());
                MessageBox.Show("Druhy v radjmen: " + FormRegistrace.radjmen[1].ToString().Trim());
                MessageBox.Show("Počet radku v heslech:" + FormRegistrace.pocetradkuhes.ToString());
                MessageBox.Show("Počet radku v jmenech:" + FormRegistrace.pocetradkujmen.ToString());
                MessageBox.Show("Velikost poli:" + Environment.NewLine + "Radhes:" + FormRegistrace.radhes.Length.ToString() + Environment.NewLine + "Radjmen:" + FormRegistrace.radjmen.Length.ToString());
                */
                if (pomocnahes == uz.Radhes[i].ToString() && pomocnajmen == uz.Radjmen[i].ToString())
                {
                    FormSystem sys=new FormSystem();
                    sys.ShowDialog();
                    
                    break;
                    
                }
                if(pomocnahes != uz.Radhes[i].ToString() && pomocnajmen == uz.Radjmen[i].ToString())
                {
                    MessageBox.Show("Špatné heslo!");
                    break;
                }
                else
                {
                    MessageBox.Show("rahes na indexu " + i.ToString() + " = " + uz.Radhes[i].ToString() + "\n" + "radjmen na indexu " + i.ToString() + " = " + uz.Radjmen[i].ToString());
                }
                
            }
            for(int i = 0; i < uz.Radjmen.Length; i++)
            {
                MessageBox.Show("Radjmen na indexu: " + i.ToString() + "\n" + uz.Radjmen[i].ToString());
            }
            
            
        }

        private void buttonZapomel_Click(object sender, EventArgs e)
        {

        }
    }
}

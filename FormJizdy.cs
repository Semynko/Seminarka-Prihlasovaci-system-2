using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autoskola
{
    public partial class FormJizdy : Form
    {
        //Pomocné globální proměné
        public static string[] jizdalist; //pole jednotlivých záznamů
        public static string text;
        public FormJizdy()
        {
            InitializeComponent();
            ZapsaniDoListboxu(this);
        }


        //----------------------Funkce komponent----------------------
        private void BtnVytvoritJizdu_Click(object sender, EventArgs e)
        //po zmáčknutí talčítka Vytvořit jídzu
        {
            //FormJizdy fj = this;
            

            FormVytvoritJizdu fvj = new FormVytvoritJizdu();
            if(fvj.ShowDialog() == DialogResult.OK)
            {
                Jizda j = new Jizda(FormVytvoritJizdu.datum, FormVytvoritJizdu.student, FormVytvoritJizdu.instrukt);
                j.ZapsatNovouJizdu();
                ZapsaniHned(FormVytvoritJizdu.datum, FormVytvoritJizdu.student, FormVytvoritJizdu.instrukt);
            }
        }


        private void BtnUpravitJizdu_Click(object sender, EventArgs e)
        //po zmáčknutí tlačítka Upravit jízdu
        {

        }


        private void BtnOdstranitJizdu_Click(object sender, EventArgs e)
        //po zmáčknutí tlačítka
        {
            lbxSeznamJizd.Items.Remove(lbxSeznamJizd.SelectedItem);
            string t = "";
            for (int i = 0; i < lbxSeznamJizd.Items.Count; i++)
            {
                t += lbxSeznamJizd.Items[i].ToString();
            }

            using (StreamWriter sw = new StreamWriter("jizdy.txt", false, Encoding.UTF8))
            {
                sw.Write(t);
            }

        }




        //-------------------Ostatní funkce-----------------------




        public static void ZapsaniDoListboxu(FormJizdy formJizdy)
        //Funkce sloužící pro zapsání hodnot z jizdy.txt to list boxu
        {
            Jizda.VycistHodnotyZJizdy();

            for (int i = 0; i < jizdalist.Length; i++)
            {
                formJizdy.lbxSeznamJizd.Items.Add(jizdalist[i]);
            }
            formJizdy.lbxSeznamJizd.Refresh();
        }
        public void ZapsaniHned(string datum, string student, string instrkutor)
        {
            lbxSeznamJizd.Items.Add(datum + ";" + student + ";" + instrkutor);
        }
        
    }
}
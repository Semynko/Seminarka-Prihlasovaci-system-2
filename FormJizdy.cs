using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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
            FormVytvoritJizdu fvj = new FormVytvoritJizdu();
            if(fvj.ShowDialog() == DialogResult.OK)
            {
                Jizda j = new Jizda(FormVytvoritJizdu.datum, FormVytvoritJizdu.student, FormVytvoritJizdu.instrukt);
                j.Podminky(); //podmínky pro vyplnení všch polí
                j.ZapsatNovouJizdu();
                lbxSeznamJizd.Items.Add(j.EditaceJizdy());
            }
        }

        private void BtnUpravitJizdu_Click(object sender, EventArgs e)
        //po zmáčknutí tlačítka Upravit jízdu
        {
            string[] radek = lbxSeznamJizd.SelectedItem.ToString().Split(';'); //vybraný zápis se splitne na 3 samostatný záznamy
            DateTime datumACas = DateTime.Parse(radek[0]); //1. záznam datum a čas
            string student = radek[1];                  //2. záznam jméno studenta
            string instruktor = radek[2];               //3. záznam jméno instruktora
            FormVytvoritJizdu fvj = new FormVytvoritJizdu(); 
            fvj.EditaceJizdyPrepis(datumACas, student, instruktor); //vepsání záznamu do textboxu/comboboxu .... pro editaci
            fvj.PrejmenovaniBtn(1); //přejmenuje tlačítko na Upravit jízdu


            if (fvj.ShowDialog() == DialogResult.OK) //otevře FormVytvoritJizdu
            {
                string[] EJizda = fvj.PrepsaniJizdy();  //pole už editlého záznamu
                Jizda j = new Jizda(EJizda[0], EJizda[1], EJizda[2]); //vytvoření objektu s upravenými hodnotami
                string tmp = j.EditaceJizdy(); //vrátí upravený záznam pro zapsání (př. "12.10.2024 12:35;Herbert;Daniel Pašík")
                j.Podminky(); //podmínky pro vyplnení všch polí
                lbxSeznamJizd.Items[lbxSeznamJizd.SelectedIndex] = tmp; //upraví vybraný záznam v listboxu
                text = "";
                for(int i = 0; i < lbxSeznamJizd.Items.Count; i++)
                {
                    if (i != 0)
                        text += Environment.NewLine;
                    text += lbxSeznamJizd.Items[i];
                }

                //text = lbxSeznamJizd.Text; //uloží hodnoty z listboxu do proměné _text_
                using (StreamWriter sw = new StreamWriter("jizdy.txt", false, Encoding.UTF8))
                {//uloží veškeré jízdy do souboru jizdy.txt
                    sw.Write(text);
                }
            }
            fvj.PrejmenovaniBtn(0); //přejmenuje tlačítko na zpátky na Vytvořit jízdu

        }


        private void BtnOdstranitJizdu_Click(object sender, EventArgs e)
        //po zmáčknutí tlačítka
        {
            lbxSeznamJizd.Items.Remove(lbxSeznamJizd.SelectedItem);
            text = "";
            for (int i = 0; i < lbxSeznamJizd.Items.Count; i++)
            {
                if (i != 0)
                {
                    text += Environment.NewLine;
                }
                text += lbxSeznamJizd.Items[i].ToString();
            }
            using (StreamWriter sw = new StreamWriter("jizdy.txt", false, Encoding.UTF8))
            {
                sw.Write(text);
            }

        }




        //-------------------Ostatní funkce-----------------------




        public static void ZapsaniDoListboxu(FormJizdy formJizdy)
        //Funkce sloužící pro zapsání hodnot z jizdy.txt to list boxu
        {
            Jizda.VycistHodnotyZJizdy();
            if (text != "")
            {
                for (int i = 0; i < jizdalist.Length; i++)
                {
                    formJizdy.lbxSeznamJizd.Items.Add(jizdalist[i]);
                }

            }
            formJizdy.lbxSeznamJizd.Refresh();
        }
        public void ZapsaniHned(string datum, string student, string instrkutor)
        {
            lbxSeznamJizd.Items.Add(datum + ";" + student + ";" + instrkutor);
        }
        
    }
}
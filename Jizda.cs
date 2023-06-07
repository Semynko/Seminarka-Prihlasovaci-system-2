using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Autoskola
{
    internal class Jizda
    {
        private string datum;
        //private string zformatovanyDatum;
        private string student;
        private string instruktor;
        public Jizda(string dat, string stud, string inst)
        {
            datum = dat;
            student = stud;
            instruktor = inst;
        }


        public string ZformatovaniDatumu()
        //Funkce pro upravení datumu před zapsáním
        //Upraví "01.01.2023 08:30:30" na "01.01.2023 08:30"
        {
            string[] pomocna = datum.Split(':');
            string[] pomo2 = pomocna[0].Split(' ');
            if (pomo2[1].Length == 2)
            {
                return datum = $"{pomocna[0] + ":" + pomocna[1]}";
            }
            else
            {
                return datum = $"{pomo2[0]} 0{pomo2[1]}:{pomocna[1]}";
            }
        }

        public string EditaceJizdy()
        {
            Jizda j = new Jizda(datum, student, instruktor);
            string zformatovanyDatum = j.ZformatovaniDatumu();
            Jizda.VycistHodnotyZJizdy();
            return $"{datum};{student};{instruktor}";
        }

        /*public string ZformatovaniDatumu2(string s)
        //Funkce pro upravení datumu před zapsáním
        //Upraví "01.01.2023 08:30:30" na "01.01.2023 08:30"
        {
            string[] pomocna = s.Split(':');
            string[] pomo2 = pomocna[0].Split(' ');
            if (pomo2[1].Length == 2)
            {
                return s = $"{pomocna[0] + ":" + pomocna[1]}";
            }
            else
            {
                return s = $"{pomo2[0]} 0{pomo2[1]}:{pomocna[1]}";
            }
        }*/




        public void ZapsatNovouJizdu()
        //Funkce na zapsání nově naplánované jízdy do souboru
        //a do listboxu (dodělat)
        {
            Jizda j = new Jizda(datum, student, instruktor);
            string zformatovanyDatumu = j.ZformatovaniDatumu();
            Jizda.VycistHodnotyZJizdy();
            using (StreamWriter sw = new StreamWriter("jizdy.txt", false, Encoding.UTF8))
            {
                string doplneni = $"{zformatovanyDatumu};{student};{instruktor}";
                if (FormJizdy.text == "")
                {
                    sw.Write(doplneni);
                }
                else
                {
                    sw.Write(FormJizdy.text + Environment.NewLine + doplneni);
                }
            }
            VycistHodnotyZJizdy();
        }

        public static void VycistHodnotyZJizdy()
        //Funkce pro načtení jizda.txt textu do "string text" a "string[] jizda"
        {
            using (StreamReader sr = new StreamReader("jizdy.txt"))
            {
                FormJizdy.text = sr.ReadToEnd();
                FormJizdy.jizdalist = FormJizdy.text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            }
        }


    }
}

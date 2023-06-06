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
    public partial class FormVytvoritJizdu : Form
    {
        
        public static string datum; //
        public static string text; //celkový text bez úprav z jizdy.txt
        public static string instrukt;
        public static string student;
        public FormVytvoritJizdu()
        {
            InitializeComponent();
            using (StreamReader sr = new StreamReader("instruktor.txt", Encoding.UTF8))
            {
                string[] poleInstruktori = sr.ReadToEnd().Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                for (int i = 0; i < poleInstruktori.Length; i++)
                {
                    cmbxRidic.Items.Add(poleInstruktori[i]);
                }
            }

            //Nastavení DateTimePickeru na vybrání datumu i času
            dtpJizda.Format = DateTimePickerFormat.Custom;
            dtpJizda.CustomFormat = "dd/MM/yyyy  HH:mm";
            //if (FormVytvoritJizdu.        
        }

        private void BtnVytvoritJizdu_Click(object sender, EventArgs e)
        //Funkce po zmáčknutí tlačítka Vytvořit jízdu
        {
            instrukt = cmbxRidic.Text;
            datum = dtpJizda.Value.ToString();
            student = txtbxStudent.Text;

            //MessageBox.Show(dtpJizda.Value.ToString());
            //Jizda.ZapsatNovouJizdu(dtpJizda.Value.ToString());
            

        }

        private void FormVytvoritJizdu_Load(object sender, EventArgs e)
        {
            FormJizdy fj = new FormJizdy();
            fj.Refresh();
            //qfj.lbx
        }

        private void cmbxRidic_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}

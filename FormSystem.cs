using System;
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
    public partial class FormSystem : Form
    {
        public FormSystem()
        {
            InitializeComponent();
        }


        private void FormSystem_Enter(object sender, EventArgs e)
        {

            
        }

        private void BtnJizdy_Click(object sender, EventArgs e)
        {
            FormJizdy fj = new FormJizdy();
            fj.Show();
            //op
        }
    }
}

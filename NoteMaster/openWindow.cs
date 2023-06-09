using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteMaster
{
    public partial class openWindow : Form
    {

        private Note noteForm;

        public openWindow(Note noteForm)
        {
            InitializeComponent();
            this.noteForm = noteForm;
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
        private void Açbutton1_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            noteForm.sayfaIcerik(); // Note formuna ait bir metodu çağırma
        }
    }


}

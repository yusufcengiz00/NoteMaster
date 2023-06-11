using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
      
        private void kaydedilenlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            noteForm.sayfaIcerik();
        }

    }

}

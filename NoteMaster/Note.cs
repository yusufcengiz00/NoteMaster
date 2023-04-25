using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteMaster
{
    public partial class Note : Form
    {

        private int sekmeSayısı = 0;
        public Note()
        {
            InitializeComponent();
        }
        #region Fonksiyonlar
        #region TümSekmeler

        private void sekmeEkle()
        {

        }
        private void sekmeKapat()
        {

        }
        private void tümSekmeleriKapat()
        {

        }
        private void hariciSekmeleriKapat()
        {

        }
        #endregion
        #region KaydetveAç
        private void kaydet()
        {

        }
        private void farklıKaydet()
        {

        }
        private void belgeAç()
        {

        }


        #endregion
        #region Özellikler
        private RichTextBox getCurrentDocument 
        {
            get { return (RichTextBox)tabControl1.SelectedTab.Controls["Body"]; }
        }
        
        #endregion
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void toolStripButtonBold_Click(object sender, EventArgs e)
        {
           
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

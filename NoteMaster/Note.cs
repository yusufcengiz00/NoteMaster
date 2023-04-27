using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
       
        private void sekmeEkle()
        {
           RichTextBox body = new RichTextBox();
           body.Name = "Body";
           body.Dock = DockStyle.Fill;
           body.ContextMenuStrip = contextMenuStrip1;

           TabPage NewPage = new TabPage();
           sekmeSayısı += 1;

            string documentText = "Sayfa " + sekmeSayısı;
            NewPage.Name = documentText;
            NewPage.Text = documentText;
            NewPage.Controls.Add(body);

            tabControl2.TabPages.Add(NewPage);
        }
         
        private void sekmeKapat()
        {
            if (tabControl2.TabPages.Count > 1)
            {
                // Mevcut sekmenin kapatılması
                tabControl2.TabPages.Remove(tabControl2.SelectedTab);
            }
            else
            {
                tabControl2.TabPages.Remove(tabControl2.SelectedTab);
                sekmeEkle();
            }
        }

        private void kaydet()
        {
            saveFileDialog1.FileName = tabControl2.SelectedTab.Name;
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog1.Filter = "Text Dosyası|*.txt";
            saveFileDialog1.Title = "Kaydet";

            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (saveFileDialog1.FileName.Length > 0)
                {
                    getCurrentDocument.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                }
            }
        }
        private void farklıKaydet()
        {
            saveFileDialog1.FileName = tabControl2.SelectedTab.Name;
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog1.Filter = "Pdf dosyası|*.t |Tüm Dosyalar|*.*";
            saveFileDialog1.Title = "Farklı Kaydet";
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (saveFileDialog1.FileName.Length > 0)
                {
                    getCurrentDocument.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                }
            }
        }
        private void belgeAç()
        {
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog1.Filter = "Pdf Dosyası|*.pdf|Text dosyası|*.txt|Tüm Dosyalar|*.*";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (openFileDialog1.FileName.Length > 0)
                {
                    getCurrentDocument.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                }
            }
        }
        
        private RichTextBox getCurrentDocument // Aktif belgeyi almak
        {
            get { return (RichTextBox)tabControl2.SelectedTab.Controls["Body"]; }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sekmeEkle();
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kaydet();
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            belgeAç();
        }

        private void farklıKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            farklıKaydet();
        }

        private void yeniToolStripButton_Click(object sender, EventArgs e)
        {
           sekmeEkle();
        }

        private void removeToolStripButton1_Click(object sender, EventArgs e)
        {
            sekmeKapat();
        }

        private void açToolStripButton_Click(object sender, EventArgs e)
        {
            belgeAç();
        }

        private void kaydetToolStripButton_Click(object sender, EventArgs e)
        {
            kaydet();
        }
        private void toolStripButtonIncrease_Click(object sender, EventArgs e)
        {
            float NewFontSize = getCurrentDocument.SelectionFont.SizeInPoints + 1;

            Font NewSize = new Font(getCurrentDocument.SelectionFont.Name, NewFontSize, getCurrentDocument.SelectionFont.Style);
            getCurrentDocument.SelectionFont = NewSize;
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Mevcut sayfayı kaydetmek istiyor musunuz?", "Uygulamadan Çık", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                // Mevcut sayfayı kaydet
                kaydet();

                // Uygulamadan çık
                Application.Exit();
            }
            else if (result == DialogResult.No)
            {
                // Uygulamadan çık
                Application.Exit();
            }
           
        }

        private void toolStripButtonDecrease_Click(object sender, EventArgs e)
        {
            float NewFontSize = getCurrentDocument.SelectionFont.SizeInPoints - 1;

            Font NewSize = new Font(getCurrentDocument.SelectionFont.Name, NewFontSize, getCurrentDocument.SelectionFont.Style);
            getCurrentDocument.SelectionFont = NewSize;
        }

        private void toolStripButtonFontColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                getCurrentDocument.SelectionColor = colorDialog1.Color;
            }

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            getCurrentDocument.Undo();
        }

        private void toolStripMenuItemkopyala_Click(object sender, EventArgs e)
        {
            getCurrentDocument.Copy();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            getCurrentDocument.Paste();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            getCurrentDocument.Cut();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            getCurrentDocument.SelectAll();
        }
    }
}

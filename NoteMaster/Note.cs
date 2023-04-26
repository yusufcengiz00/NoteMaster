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
            // Yeni bir RichTextBox nesnesi oluşturmak
            RichTextBox newRichTextBox = new RichTextBox();
            newRichTextBox.Name = "Body";
            newRichTextBox.Dock = DockStyle.Fill;
            newRichTextBox.ContextMenuStrip = contextMenuStrip1;

            // Yeni bir TabPage nesnesi oluşturmak
            TabPage newTabPage = new TabPage();
            sekmeSayısı += 1;

            string documentText = "Belge" + sekmeSayısı;
            newTabPage.Name = "DocumentText";
            newTabPage.Text = documentText;

            // TabPage nesnesinin Controls koleksiyonuna RichTextBox nesnesi eklemek
            newTabPage.Controls.Add(newRichTextBox);

            // TabControl nesnesine yeni sekme eklemek
            tabControl1.TabPages.Add(newTabPage);
        }
        private void sekmeKapat()
        {
           // Eğer mevcut sekmeden fazla sekme varsa
            if (tabControl1.TabPages.Count > 1)
            {
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);  // Mevcut seçili sekme kaldırılır
            }
            else
            {
                tabControl1.TabPages.Add(tabControl1.SelectedTab);
                sekmeEkle(); // En az 1 sekme olmalı
            }
        }

        private void tümSekmeleriKapat()
        {
            foreach(TabPage page in tabControl1.TabPages)
            {
                tabControl1.TabPages.Remove(page);
            }
            sekmeEkle();
        }
        private void hariciSekmeleriKapat()
        {
            foreach (TabPage page in tabControl1.TabPages)
            {
                if(page.Name != tabControl1.SelectedTab.Name)
                {
                    tabControl1.TabPages.Remove(page);
                }
            }
        }
       
        private void kaydet()
        {
            saveFileDialog1.FileName = tabControl1.SelectedTab.Name;
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog1.Filter = "RTF | *.rtf";
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
            saveFileDialog1.FileName = tabControl1.SelectedTab.Name;
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog1.Filter = "Text dosya | *.txt | Tüm Dosyalar|*.*";
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
            openFileDialog1.Filter = "RTF |*.rtf|Text dosya|*.txt|Tüm Dosyalar|*.*";
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
            get { return (RichTextBox)tabControl1.SelectedTab.Controls["Body"]; }
        }
        
        
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

using Firebase.Auth;
using Firebase.Database;
using Firebase.Database.Query;
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
        private UserCredential userCredential;
        private FirebaseClient firebaseClient;
        public Note(UserCredential userCredential)
        {
            InitializeComponent();
            this.userCredential = userCredential;
            this.Text = this.Text + " | "+ userCredential.User.Info.Email;

            firebaseClient = new FirebaseClient("https://notemaster-939e5-default-rtdb.firebaseio.com/",
                   new FirebaseOptions
                   {
                       AuthTokenAsyncFactory = () => userCredential.User.GetIdTokenAsync()
                   });
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

      private async void kaydet()
        {
          //  await firebaseClient.Child("Sayfalar").Child(textBox1.Text);

           // MessageBox.Show("Notlarınız kaydedildi.");
        }
      /*  private void farklıKaydet()
        {
            saveFileDialog1.FileName = tabControl2.SelectedTab.Name;
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog1.Filter = "Pdf dosyası|*.pdf |Tüm Dosyalar|*.*";
            saveFileDialog1.Title = "Farklı Kaydet";
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (saveFileDialog1.FileName.Length > 0)
                {
                    getCurrentDocument.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                }
            }
        }*/
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

        private async void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Tüm sayfaların içeriğini toplamak için bir StringBuilder kullanın
            StringBuilder builder = new StringBuilder();

            // Tüm sayfaları dolaşın ve içeriklerini StringBuilder'a ekleyin
            foreach (TabPage tabPage in tabControl1.TabPages)
            {
                TextBox textBox = (TextBox)tabPage.Controls["textBox1"];
                builder.Append(textBox.Text);
            }

            // Firebase Realtime Database'de /Notlarınız/sayfalar yolunda veri kaydedin
            await firebaseClient.Child("Notlarınız").Child("sayfalar").PutAsync<string>(builder.ToString());
       
    }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            belgeAç();
        }

        private void farklıKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // farklıKaydet();
        }

        private async void yeniToolStripButton_Click(object sender, EventArgs e)
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

        private async void kaydetToolStripButton_Click(object sender, EventArgs e)
        {
            // Tüm sayfaların içeriğini toplamak için bir StringBuilder kullanın
            StringBuilder builder = new StringBuilder();

            // Tüm sayfaları dolaşın ve içeriklerini StringBuilder'a ekleyin
            foreach (TabPage tabPage in tabControl1.TabPages)
            {
                TextBox textBox = (TextBox)tabPage.Controls["textBox1"];
                builder.Append(textBox.Text);
            }

            // Firebase Realtime Database'de /Notlarınız/sayfalar yolunda veri kaydedin
            await firebaseClient.Child("Notlarınız").Child("sayfalar").PutAsync<string>(builder.ToString());
        

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

        private void Note_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

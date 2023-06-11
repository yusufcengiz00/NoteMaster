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
        private bool kaydedildi = false;
        private openWindow openWindow; // OpenWindow penceresine erişim sağlayacak bir nesne tanımlayın
        public int sekmeSayısı = 0;
        private UserCredential userCredential;
        private FirebaseClient firebaseClient;

        public Note(UserCredential userCredential)
        {
            InitializeComponent();
            this.userCredential = userCredential;
            this.Text = this.Text + " | " + userCredential.User.Info.Email;

            firebaseClient = new FirebaseClient("https://notemaster-939e5-default-rtdb.firebaseio.com/",
                   new FirebaseOptions
                   {
                       AuthTokenAsyncFactory = () => userCredential.User.GetIdTokenAsync()
                   });
        }
        public void YeniSayfaOlustur()
        {
            // Yeni bir RichTextBox nesnesi oluşturmak
            RichTextBox newRichTextBox = new RichTextBox();
            newRichTextBox.Name = "Body";
            newRichTextBox.Dock = DockStyle.Fill;
            newRichTextBox.ContextMenuStrip = contextMenuStrip1;

            // Yeni bir TabPage nesnesi oluşturmak
            TabPage newTabPage = new TabPage();
            sekmeSayısı += 1;

            string documentText = "Sayfa" + sekmeSayısı;
            newTabPage.Name = "DocumentText";
            newTabPage.Text = documentText;

            // TabPage nesnesinin Controls koleksiyonuna RichTextBox nesnesi eklemek
            newTabPage.Controls.Add(newRichTextBox);
            // TabControl nesnesine yeni sekme eklemek
            tabControl2.TabPages.Add(newTabPage);
        }
        
        public void sayfaIcerik()
        {
            if (!kaydedildi) // Kaydedilmediyse metodu çalıştırmayın
                return;

            // Aktif sekme üzerindeki RichTextBox kontrolünü bulma
            RichTextBox activeRichTextBox = tabControl2.SelectedTab.Controls.OfType<RichTextBox>().FirstOrDefault();

            if (activeRichTextBox != null)
            {
                string pageText = activeRichTextBox.Text;
                

                string documentText = "Sayfa " + sekmeSayısı;
                MessageBox.Show(documentText);
                MessageBox.Show(pageText); // Sayfa metnini gösterme
            }
        }

        public void sekmeKapat()
        {
            if (tabControl2.TabPages.Count > 1)
            {
                // Mevcut sekmenin kapatılması
                tabControl2.TabPages.Remove(tabControl2.SelectedTab);
            }
            else
            {
                tabControl2.TabPages.Remove(tabControl2.SelectedTab);
                YeniSayfaOlustur();
            }
        }
 
        public RichTextBox getCurrentDocument // Aktif belgeyi almak
        {
            get { return (RichTextBox)tabControl2.SelectedTab.Controls["Body"]; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YeniSayfaOlustur();
        }

        private async void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openWindow openWindowForm = new openWindow(this);
            openWindowForm.Show();
        }

        private void yeniToolStripButton_Click(object sender, EventArgs e)
        {
            YeniSayfaOlustur();

        }

        private void removeToolStripButton1_Click(object sender, EventArgs e)
        {
            sekmeKapat();
        }

        private async void açToolStripButton_Click(object sender, EventArgs e)
        {
            openWindow openWindowForm = new openWindow(this);
            openWindowForm.Show();
        }

        private async void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string documentText = "Sayfa" + sekmeSayısı;

            // Firebase Realtime Database'de /Notlarınız/Sayfa yolunda veri kaydet
            await firebaseClient.Child("Kaydedilenler").Child("Notlarınız: ").Child("Sayfa").PutAsync<string>(documentText);
            kaydedildi = true; 
        }

        private async void kaydetToolStripButton_Click(object sender, EventArgs e)
        {
            string documentText = "Sayfa" + sekmeSayısı;

            // Firebase Realtime Database'de /Notlarınız/Sayfa yolunda veri kaydet
            await firebaseClient.Child("Kaydedilenler").Child("Notlarınız: ").Child("Sayfa").PutAsync<string>(documentText);
            kaydedildi = true; 
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
                kaydedildi = true;

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

namespace NoteMaster
{
    partial class Login
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.importloginBtn = new System.Windows.Forms.Button();
            this.importsignupBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(7, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 292);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // importloginBtn
            // 
            this.importloginBtn.BackColor = System.Drawing.SystemColors.Window;
            this.importloginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.importloginBtn.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importloginBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.importloginBtn.Location = new System.Drawing.Point(7, 46);
            this.importloginBtn.Name = "importloginBtn";
            this.importloginBtn.Size = new System.Drawing.Size(102, 34);
            this.importloginBtn.TabIndex = 0;
            this.importloginBtn.Text = "Giriş Yap";
            this.importloginBtn.UseVisualStyleBackColor = false;
            this.importloginBtn.Click += new System.EventHandler(this.importLoginBtn_Click);
            // 
            // importsignupBtn
            // 
            this.importsignupBtn.BackColor = System.Drawing.SystemColors.Window;
            this.importsignupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.importsignupBtn.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importsignupBtn.Location = new System.Drawing.Point(115, 46);
            this.importsignupBtn.Name = "importsignupBtn";
            this.importsignupBtn.Size = new System.Drawing.Size(102, 34);
            this.importsignupBtn.TabIndex = 1;
            this.importsignupBtn.Text = "Üye Ol";
            this.importsignupBtn.UseVisualStyleBackColor = false;
            this.importsignupBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(527, 433);
            this.Controls.Add(this.importsignupBtn);
            this.Controls.Add(this.importloginBtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoteMaster";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button importloginBtn;
        private System.Windows.Forms.Button importsignupBtn;
    }
}


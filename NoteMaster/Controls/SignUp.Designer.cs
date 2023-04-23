namespace NoteMaster.Controls
{
    partial class SignUp
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.SignUpBtn = new System.Windows.Forms.Button();
            this.gösterBtn = new System.Windows.Forms.CheckBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.password2Btn = new System.Windows.Forms.Label();
            this.email2Btn = new System.Windows.Forms.Label();
            this.AdBtn = new System.Windows.Forms.Label();
            this.SoyadBtn = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SignUpBtn.Location = new System.Drawing.Point(159, 188);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(121, 47);
            this.SignUpBtn.TabIndex = 11;
            this.SignUpBtn.Text = "Üye Ol";
            this.SignUpBtn.UseVisualStyleBackColor = true;
            // 
            // gösterBtn
            // 
            this.gösterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gösterBtn.AutoSize = true;
            this.gösterBtn.Location = new System.Drawing.Point(353, 135);
            this.gösterBtn.Name = "gösterBtn";
            this.gösterBtn.Size = new System.Drawing.Size(69, 20);
            this.gösterBtn.TabIndex = 10;
            this.gösterBtn.Text = "Göster";
            this.gösterBtn.UseVisualStyleBackColor = true;
            this.gösterBtn.CheckedChanged += new System.EventHandler(this.gösterBtn_CheckedChanged);
            // 
            // passwordTxt
            // 
            this.passwordTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTxt.Location = new System.Drawing.Point(109, 135);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(220, 22);
            this.passwordTxt.TabIndex = 9;
            // 
            // emailTxt
            // 
            this.emailTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTxt.Location = new System.Drawing.Point(109, 97);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(220, 22);
            this.emailTxt.TabIndex = 8;
            this.emailTxt.TextChanged += new System.EventHandler(this.emailTxt_TextChanged);
            // 
            // password2Btn
            // 
            this.password2Btn.AutoSize = true;
            this.password2Btn.Location = new System.Drawing.Point(53, 141);
            this.password2Btn.Name = "password2Btn";
            this.password2Btn.Size = new System.Drawing.Size(40, 16);
            this.password2Btn.TabIndex = 7;
            this.password2Btn.Text = "Şifre :";
            this.password2Btn.Click += new System.EventHandler(this.label2_Click);
            // 
            // email2Btn
            // 
            this.email2Btn.AutoSize = true;
            this.email2Btn.Location = new System.Drawing.Point(53, 103);
            this.email2Btn.Name = "email2Btn";
            this.email2Btn.Size = new System.Drawing.Size(50, 16);
            this.email2Btn.TabIndex = 6;
            this.email2Btn.Text = "E Mail :";
            // 
            // AdBtn
            // 
            this.AdBtn.AutoSize = true;
            this.AdBtn.Location = new System.Drawing.Point(53, 36);
            this.AdBtn.Name = "AdBtn";
            this.AdBtn.Size = new System.Drawing.Size(30, 16);
            this.AdBtn.TabIndex = 12;
            this.AdBtn.Text = "Ad :";
            this.AdBtn.Click += new System.EventHandler(this.label3_Click);
            // 
            // SoyadBtn
            // 
            this.SoyadBtn.AutoSize = true;
            this.SoyadBtn.Location = new System.Drawing.Point(53, 69);
            this.SoyadBtn.Name = "SoyadBtn";
            this.SoyadBtn.Size = new System.Drawing.Size(53, 16);
            this.SoyadBtn.TabIndex = 13;
            this.SoyadBtn.Text = "Soyad :";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(109, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 22);
            this.textBox1.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(107, 69);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(220, 22);
            this.textBox3.TabIndex = 18;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SoyadBtn);
            this.Controls.Add(this.AdBtn);
            this.Controls.Add(this.SignUpBtn);
            this.Controls.Add(this.gösterBtn);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.password2Btn);
            this.Controls.Add(this.email2Btn);
            this.Name = "SignUp";
            this.Size = new System.Drawing.Size(559, 321);
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox gösterBtn;
        private System.Windows.Forms.Label password2Btn;
        private System.Windows.Forms.Label email2Btn;
        private System.Windows.Forms.Label AdBtn;
        private System.Windows.Forms.Label SoyadBtn;
        public System.Windows.Forms.Button SignUpBtn;
        public System.Windows.Forms.TextBox passwordTxt;
        public System.Windows.Forms.TextBox emailTxt;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox3;
    }
}

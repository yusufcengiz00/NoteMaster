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
            this.adTxt = new System.Windows.Forms.TextBox();
            this.soyadTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.BackColor = System.Drawing.SystemColors.Info;
            this.SignUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SignUpBtn.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpBtn.Location = new System.Drawing.Point(285, 193);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(120, 44);
            this.SignUpBtn.TabIndex = 11;
            this.SignUpBtn.Text = "Üye Ol";
            this.SignUpBtn.UseVisualStyleBackColor = false;
            // 
            // gösterBtn
            // 
            this.gösterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gösterBtn.AutoSize = true;
            this.gösterBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.gösterBtn.Location = new System.Drawing.Point(422, 153);
            this.gösterBtn.Name = "gösterBtn";
            this.gösterBtn.Size = new System.Drawing.Size(69, 20);
            this.gösterBtn.TabIndex = 10;
            this.gösterBtn.Text = "Göster";
            this.gösterBtn.UseVisualStyleBackColor = false;
            this.gösterBtn.CheckedChanged += new System.EventHandler(this.gösterBtn_CheckedChanged);
            // 
            // passwordTxt
            // 
            this.passwordTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTxt.BackColor = System.Drawing.SystemColors.Window;
            this.passwordTxt.Location = new System.Drawing.Point(104, 153);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(301, 22);
            this.passwordTxt.TabIndex = 9;
            // 
            // emailTxt
            // 
            this.emailTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTxt.BackColor = System.Drawing.SystemColors.Window;
            this.emailTxt.Location = new System.Drawing.Point(104, 125);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(301, 22);
            this.emailTxt.TabIndex = 8;
            this.emailTxt.TextChanged += new System.EventHandler(this.emailTxt_TextChanged);
            // 
            // password2Btn
            // 
            this.password2Btn.AutoSize = true;
            this.password2Btn.BackColor = System.Drawing.Color.Gainsboro;
            this.password2Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.password2Btn.Location = new System.Drawing.Point(33, 157);
            this.password2Btn.Name = "password2Btn";
            this.password2Btn.Size = new System.Drawing.Size(53, 18);
            this.password2Btn.TabIndex = 7;
            this.password2Btn.Text = "Şifre :";
            this.password2Btn.Click += new System.EventHandler(this.label2_Click);
            // 
            // email2Btn
            // 
            this.email2Btn.AutoSize = true;
            this.email2Btn.BackColor = System.Drawing.Color.Gainsboro;
            this.email2Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.email2Btn.Location = new System.Drawing.Point(21, 126);
            this.email2Btn.Name = "email2Btn";
            this.email2Btn.Size = new System.Drawing.Size(65, 18);
            this.email2Btn.TabIndex = 6;
            this.email2Btn.Text = "E Mail :";
            // 
            // AdBtn
            // 
            this.AdBtn.AutoSize = true;
            this.AdBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.AdBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AdBtn.Location = new System.Drawing.Point(49, 69);
            this.AdBtn.Name = "AdBtn";
            this.AdBtn.Size = new System.Drawing.Size(37, 18);
            this.AdBtn.TabIndex = 12;
            this.AdBtn.Text = "Ad :";
            this.AdBtn.Click += new System.EventHandler(this.label3_Click);
            // 
            // SoyadBtn
            // 
            this.SoyadBtn.AutoSize = true;
            this.SoyadBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.SoyadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SoyadBtn.Location = new System.Drawing.Point(21, 97);
            this.SoyadBtn.Name = "SoyadBtn";
            this.SoyadBtn.Size = new System.Drawing.Size(65, 18);
            this.SoyadBtn.TabIndex = 13;
            this.SoyadBtn.Text = "Soyad :";
            // 
            // adTxt
            // 
            this.adTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adTxt.BackColor = System.Drawing.SystemColors.Window;
            this.adTxt.Location = new System.Drawing.Point(104, 68);
            this.adTxt.Name = "adTxt";
            this.adTxt.Size = new System.Drawing.Size(301, 22);
            this.adTxt.TabIndex = 15;
            // 
            // soyadTxt
            // 
            this.soyadTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.soyadTxt.BackColor = System.Drawing.SystemColors.Window;
            this.soyadTxt.Location = new System.Drawing.Point(104, 97);
            this.soyadTxt.Name = "soyadTxt";
            this.soyadTxt.Size = new System.Drawing.Size(301, 22);
            this.soyadTxt.TabIndex = 18;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.soyadTxt);
            this.Controls.Add(this.adTxt);
            this.Controls.Add(this.SoyadBtn);
            this.Controls.Add(this.AdBtn);
            this.Controls.Add(this.SignUpBtn);
            this.Controls.Add(this.gösterBtn);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.password2Btn);
            this.Controls.Add(this.email2Btn);
            this.Name = "SignUp";
            this.Size = new System.Drawing.Size(601, 343);
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
        public System.Windows.Forms.TextBox adTxt;
        public System.Windows.Forms.TextBox soyadTxt;
    }
}

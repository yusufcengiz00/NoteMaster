﻿namespace NoteMaster.Controls
{
    partial class LoginUC
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.gösterBtn = new System.Windows.Forms.CheckBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(53, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "E Mail :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(65, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // emailTxt
            // 
            this.emailTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTxt.BackColor = System.Drawing.SystemColors.Window;
            this.emailTxt.Location = new System.Drawing.Point(124, 68);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(255, 22);
            this.emailTxt.TabIndex = 2;
            this.emailTxt.TextChanged += new System.EventHandler(this.emailTxt_TextChanged);
            // 
            // passwordTxt
            // 
            this.passwordTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTxt.BackColor = System.Drawing.SystemColors.Window;
            this.passwordTxt.Location = new System.Drawing.Point(124, 95);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(255, 22);
            this.passwordTxt.TabIndex = 3;
            this.passwordTxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // gösterBtn
            // 
            this.gösterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gösterBtn.AutoSize = true;
            this.gösterBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.gösterBtn.Location = new System.Drawing.Point(398, 97);
            this.gösterBtn.Name = "gösterBtn";
            this.gösterBtn.Size = new System.Drawing.Size(69, 20);
            this.gösterBtn.TabIndex = 4;
            this.gösterBtn.Text = "Göster";
            this.gösterBtn.UseVisualStyleBackColor = false;
            this.gösterBtn.CheckedChanged += new System.EventHandler(this.gösterBtn_CheckedChanged);
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.SystemColors.Info;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginBtn.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LoginBtn.Location = new System.Drawing.Point(259, 147);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(120, 42);
            this.LoginBtn.TabIndex = 5;
            this.LoginBtn.Text = "Giriş Yap";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.gösterBtn);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginUC";
            this.Size = new System.Drawing.Size(601, 343);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox gösterBtn;
        public System.Windows.Forms.TextBox emailTxt;
        public System.Windows.Forms.TextBox passwordTxt;
        public System.Windows.Forms.Button LoginBtn;
    }
}

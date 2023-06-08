namespace NoteMaster
{
    partial class openWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(openWindow));
            this.opentabControl1 = new System.Windows.Forms.TabControl();
            this.SuspendLayout();
            // 
            // opentabControl1
            // 
            this.opentabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.opentabControl1.Location = new System.Drawing.Point(0, 0);
            this.opentabControl1.Name = "opentabControl1";
            this.opentabControl1.SelectedIndex = 0;
            this.opentabControl1.Size = new System.Drawing.Size(800, 450);
            this.opentabControl1.TabIndex = 0;
            this.opentabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // openWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.opentabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "openWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notlarınız";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl opentabControl1;
    }
}
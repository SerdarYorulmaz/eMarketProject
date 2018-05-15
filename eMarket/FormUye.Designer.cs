namespace eMarket
{
    partial class FormUye
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabProfil = new System.Windows.Forms.TabPage();
            this.tabSepet = new System.Windows.Forms.TabPage();
            this.tabArama = new System.Windows.Forms.TabPage();
            this.tabSiparislerim = new System.Windows.Forms.TabPage();
            this.tabCıkıs = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabProfil);
            this.tabControl1.Controls.Add(this.tabSiparislerim);
            this.tabControl1.Controls.Add(this.tabSepet);
            this.tabControl1.Controls.Add(this.tabArama);
            this.tabControl1.Controls.Add(this.tabCıkıs);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(946, 608);
            this.tabControl1.TabIndex = 0;
            // 
            // tabProfil
            // 
            this.tabProfil.Location = new System.Drawing.Point(4, 25);
            this.tabProfil.Name = "tabProfil";
            this.tabProfil.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfil.Size = new System.Drawing.Size(938, 579);
            this.tabProfil.TabIndex = 0;
            this.tabProfil.Text = "Profilim";
            this.tabProfil.UseVisualStyleBackColor = true;
            // 
            // tabSepet
            // 
            this.tabSepet.Location = new System.Drawing.Point(4, 25);
            this.tabSepet.Name = "tabSepet";
            this.tabSepet.Padding = new System.Windows.Forms.Padding(3);
            this.tabSepet.Size = new System.Drawing.Size(938, 579);
            this.tabSepet.TabIndex = 1;
            this.tabSepet.Text = "Sepet";
            this.tabSepet.UseVisualStyleBackColor = true;
            // 
            // tabArama
            // 
            this.tabArama.Location = new System.Drawing.Point(4, 25);
            this.tabArama.Name = "tabArama";
            this.tabArama.Size = new System.Drawing.Size(938, 579);
            this.tabArama.TabIndex = 2;
            this.tabArama.Text = "Arama";
            this.tabArama.UseVisualStyleBackColor = true;
            // 
            // tabSiparislerim
            // 
            this.tabSiparislerim.Location = new System.Drawing.Point(4, 25);
            this.tabSiparislerim.Name = "tabSiparislerim";
            this.tabSiparislerim.Size = new System.Drawing.Size(938, 579);
            this.tabSiparislerim.TabIndex = 3;
            this.tabSiparislerim.Text = "Siparişlerim";
            this.tabSiparislerim.UseVisualStyleBackColor = true;
            // 
            // tabCıkıs
            // 
            this.tabCıkıs.Location = new System.Drawing.Point(4, 25);
            this.tabCıkıs.Name = "tabCıkıs";
            this.tabCıkıs.Size = new System.Drawing.Size(938, 579);
            this.tabCıkıs.TabIndex = 4;
            this.tabCıkıs.Text = "Çıkış";
            this.tabCıkıs.UseVisualStyleBackColor = true;
            // 
            // FormUye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 632);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormUye";
            this.Text = "FormUye";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabProfil;
        private System.Windows.Forms.TabPage tabSepet;
        private System.Windows.Forms.TabPage tabSiparislerim;
        private System.Windows.Forms.TabPage tabArama;
        private System.Windows.Forms.TabPage tabCıkıs;
    }
}
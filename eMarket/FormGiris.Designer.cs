namespace eMarket
{
    partial class FormGiris
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
            this.tabGiris = new System.Windows.Forms.TabControl();
            this.tabPersonelGiris = new System.Windows.Forms.TabPage();
            this.btnPerGiris = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPerAdi = new System.Windows.Forms.TextBox();
            this.txtPerSifre = new System.Windows.Forms.TextBox();
            this.tabUyeGiris = new System.Windows.Forms.TabPage();
            this.btnUyeGiris = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUyeAdi = new System.Windows.Forms.TextBox();
            this.txtUyeSifre = new System.Windows.Forms.TextBox();
            this.tabGiris.SuspendLayout();
            this.tabPersonelGiris.SuspendLayout();
            this.tabUyeGiris.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabGiris
            // 
            this.tabGiris.Controls.Add(this.tabPersonelGiris);
            this.tabGiris.Controls.Add(this.tabUyeGiris);
            this.tabGiris.Location = new System.Drawing.Point(121, 110);
            this.tabGiris.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabGiris.Name = "tabGiris";
            this.tabGiris.SelectedIndex = 0;
            this.tabGiris.Size = new System.Drawing.Size(276, 204);
            this.tabGiris.TabIndex = 0;
            // 
            // tabPersonelGiris
            // 
            this.tabPersonelGiris.Controls.Add(this.btnPerGiris);
            this.tabPersonelGiris.Controls.Add(this.label2);
            this.tabPersonelGiris.Controls.Add(this.label1);
            this.tabPersonelGiris.Controls.Add(this.txtPerAdi);
            this.tabPersonelGiris.Controls.Add(this.txtPerSifre);
            this.tabPersonelGiris.Location = new System.Drawing.Point(4, 22);
            this.tabPersonelGiris.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPersonelGiris.Name = "tabPersonelGiris";
            this.tabPersonelGiris.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPersonelGiris.Size = new System.Drawing.Size(268, 178);
            this.tabPersonelGiris.TabIndex = 0;
            this.tabPersonelGiris.Text = "Personel Girişi";
            this.tabPersonelGiris.UseVisualStyleBackColor = true;
            // 
            // btnPerGiris
            // 
            this.btnPerGiris.Location = new System.Drawing.Point(178, 113);
            this.btnPerGiris.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPerGiris.Name = "btnPerGiris";
            this.btnPerGiris.Size = new System.Drawing.Size(56, 23);
            this.btnPerGiris.TabIndex = 13;
            this.btnPerGiris.Text = "Giriş";
            this.btnPerGiris.UseVisualStyleBackColor = true;
            this.btnPerGiris.Click += new System.EventHandler(this.btnPerGiris_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // txtPerAdi
            // 
            this.txtPerAdi.Location = new System.Drawing.Point(116, 50);
            this.txtPerAdi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPerAdi.Name = "txtPerAdi";
            this.txtPerAdi.Size = new System.Drawing.Size(120, 20);
            this.txtPerAdi.TabIndex = 3;
            // 
            // txtPerSifre
            // 
            this.txtPerSifre.Location = new System.Drawing.Point(116, 72);
            this.txtPerSifre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPerSifre.Name = "txtPerSifre";
            this.txtPerSifre.PasswordChar = '*';
            this.txtPerSifre.Size = new System.Drawing.Size(120, 20);
            this.txtPerSifre.TabIndex = 4;
            // 
            // tabUyeGiris
            // 
            this.tabUyeGiris.Controls.Add(this.btnUyeGiris);
            this.tabUyeGiris.Controls.Add(this.label3);
            this.tabUyeGiris.Controls.Add(this.label4);
            this.tabUyeGiris.Controls.Add(this.txtUyeAdi);
            this.tabUyeGiris.Controls.Add(this.txtUyeSifre);
            this.tabUyeGiris.Location = new System.Drawing.Point(4, 22);
            this.tabUyeGiris.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabUyeGiris.Name = "tabUyeGiris";
            this.tabUyeGiris.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabUyeGiris.Size = new System.Drawing.Size(268, 178);
            this.tabUyeGiris.TabIndex = 1;
            this.tabUyeGiris.Text = "Üye Girişi";
            this.tabUyeGiris.UseVisualStyleBackColor = true;
            // 
            // btnUyeGiris
            // 
            this.btnUyeGiris.Location = new System.Drawing.Point(178, 113);
            this.btnUyeGiris.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUyeGiris.Name = "btnUyeGiris";
            this.btnUyeGiris.Size = new System.Drawing.Size(56, 23);
            this.btnUyeGiris.TabIndex = 12;
            this.btnUyeGiris.Text = "Giriş";
            this.btnUyeGiris.UseVisualStyleBackColor = true;
            this.btnUyeGiris.Click += new System.EventHandler(this.btnUyeGiris_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Şifre :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Kullanıcı Adı :";
            // 
            // txtUyeAdi
            // 
            this.txtUyeAdi.Location = new System.Drawing.Point(116, 50);
            this.txtUyeAdi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUyeAdi.Name = "txtUyeAdi";
            this.txtUyeAdi.Size = new System.Drawing.Size(120, 20);
            this.txtUyeAdi.TabIndex = 8;
            // 
            // txtUyeSifre
            // 
            this.txtUyeSifre.Location = new System.Drawing.Point(116, 72);
            this.txtUyeSifre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUyeSifre.Name = "txtUyeSifre";
            this.txtUyeSifre.PasswordChar = '*';
            this.txtUyeSifre.Size = new System.Drawing.Size(120, 20);
            this.txtUyeSifre.TabIndex = 9;
            // 
            // FormGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 392);
            this.Controls.Add(this.tabGiris);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormGiris";
            this.Text = "FormGiris";
            this.tabGiris.ResumeLayout(false);
            this.tabPersonelGiris.ResumeLayout(false);
            this.tabPersonelGiris.PerformLayout();
            this.tabUyeGiris.ResumeLayout(false);
            this.tabUyeGiris.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabGiris;
        private System.Windows.Forms.TabPage tabPersonelGiris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPerAdi;
        private System.Windows.Forms.TextBox txtPerSifre;
        private System.Windows.Forms.TabPage tabUyeGiris;
        private System.Windows.Forms.Button btnUyeGiris;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUyeAdi;
        private System.Windows.Forms.TextBox txtUyeSifre;
        private System.Windows.Forms.Button btnPerGiris;
    }
}
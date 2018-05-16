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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabUyeGiris = new System.Windows.Forms.TabPage();
            this.btnUyeGiris = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnPerGiris = new System.Windows.Forms.Button();
            this.tabGiris.SuspendLayout();
            this.tabPersonelGiris.SuspendLayout();
            this.tabUyeGiris.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabGiris
            // 
            this.tabGiris.Controls.Add(this.tabPersonelGiris);
            this.tabGiris.Controls.Add(this.tabUyeGiris);
            this.tabGiris.Location = new System.Drawing.Point(161, 135);
            this.tabGiris.Name = "tabGiris";
            this.tabGiris.SelectedIndex = 0;
            this.tabGiris.Size = new System.Drawing.Size(368, 251);
            this.tabGiris.TabIndex = 0;
            // 
            // tabPersonelGiris
            // 
            this.tabPersonelGiris.Controls.Add(this.btnPerGiris);
            this.tabPersonelGiris.Controls.Add(this.label2);
            this.tabPersonelGiris.Controls.Add(this.label1);
            this.tabPersonelGiris.Controls.Add(this.textBox2);
            this.tabPersonelGiris.Controls.Add(this.textBox1);
            this.tabPersonelGiris.Location = new System.Drawing.Point(4, 25);
            this.tabPersonelGiris.Name = "tabPersonelGiris";
            this.tabPersonelGiris.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonelGiris.Size = new System.Drawing.Size(360, 222);
            this.tabPersonelGiris.TabIndex = 0;
            this.tabPersonelGiris.Text = "Personel Girişi";
            this.tabPersonelGiris.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(155, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 22);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(158, 22);
            this.textBox1.TabIndex = 4;
            // 
            // tabUyeGiris
            // 
            this.tabUyeGiris.Controls.Add(this.btnUyeGiris);
            this.tabUyeGiris.Controls.Add(this.label3);
            this.tabUyeGiris.Controls.Add(this.label4);
            this.tabUyeGiris.Controls.Add(this.textBox3);
            this.tabUyeGiris.Controls.Add(this.textBox4);
            this.tabUyeGiris.Location = new System.Drawing.Point(4, 25);
            this.tabUyeGiris.Name = "tabUyeGiris";
            this.tabUyeGiris.Padding = new System.Windows.Forms.Padding(3);
            this.tabUyeGiris.Size = new System.Drawing.Size(360, 222);
            this.tabUyeGiris.TabIndex = 1;
            this.tabUyeGiris.Text = "Üye Girişi";
            this.tabUyeGiris.UseVisualStyleBackColor = true;
            // 
            // btnUyeGiris
            // 
            this.btnUyeGiris.Location = new System.Drawing.Point(238, 139);
            this.btnUyeGiris.Name = "btnUyeGiris";
            this.btnUyeGiris.Size = new System.Drawing.Size(75, 28);
            this.btnUyeGiris.TabIndex = 12;
            this.btnUyeGiris.Text = "Giriş";
            this.btnUyeGiris.UseVisualStyleBackColor = true;
            this.btnUyeGiris.Click += new System.EventHandler(this.btnUyeGiris_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Şifre :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Kullanıcı Adı :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(155, 61);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(158, 22);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(155, 89);
            this.textBox4.Name = "textBox4";
            this.textBox4.PasswordChar = '*';
            this.textBox4.Size = new System.Drawing.Size(158, 22);
            this.textBox4.TabIndex = 9;
            // 
            // btnPerGiris
            // 
            this.btnPerGiris.Location = new System.Drawing.Point(238, 139);
            this.btnPerGiris.Name = "btnPerGiris";
            this.btnPerGiris.Size = new System.Drawing.Size(75, 28);
            this.btnPerGiris.TabIndex = 13;
            this.btnPerGiris.Text = "Giriş";
            this.btnPerGiris.UseVisualStyleBackColor = true;
            this.btnPerGiris.Click += new System.EventHandler(this.btnPerGiris_Click);
            // 
            // FormGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 482);
            this.Controls.Add(this.tabGiris);
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabUyeGiris;
        private System.Windows.Forms.Button btnUyeGiris;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnPerGiris;
    }
}
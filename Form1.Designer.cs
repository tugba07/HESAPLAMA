namespace $safeprojectname$
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDaire = new System.Windows.Forms.RadioButton();
            this.rbDikdortgen = new System.Windows.Forms.RadioButton();
            this.rbUcgen = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbCarpma = new System.Windows.Forms.RadioButton();
            this.rbBolme = new System.Windows.Forms.RadioButton();
            this.rbCıkarma = new System.Windows.Forms.RadioButton();
            this.rbToplama = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValue3 = new System.Windows.Forms.TextBox();
            this.txtValue4 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtYukseklik1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTabanAlan = new System.Windows.Forms.TextBox();
            this.txtHacimSonuc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.alan = new System.Windows.Forms.GroupBox();
            this.lblYariCap = new System.Windows.Forms.Label();
            this.txtYariCap = new System.Windows.Forms.TextBox();
            this.lblValue1 = new System.Windows.Forms.Label();
            this.txtAlanSonuc = new System.Windows.Forms.TextBox();
            this.lblAlan = new System.Windows.Forms.Label();
            this.lblYukseklik = new System.Windows.Forms.Label();
            this.lblValue2 = new System.Windows.Forms.Label();
            this.txtYukseklik = new System.Windows.Forms.TextBox();
            this.txtValue1 = new System.Windows.Forms.TextBox();
            this.txtValue2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.alan.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDaire);
            this.groupBox1.Controls.Add(this.rbDikdortgen);
            this.groupBox1.Controls.Add(this.rbUcgen);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 54);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ŞEKİL SEÇ";
            // 
            // rbDaire
            // 
            this.rbDaire.AutoSize = true;
            this.rbDaire.Location = new System.Drawing.Point(203, 19);
            this.rbDaire.Name = "rbDaire";
            this.rbDaire.Size = new System.Drawing.Size(50, 17);
            this.rbDaire.TabIndex = 2;
            this.rbDaire.TabStop = true;
            this.rbDaire.Text = "Daire";
            this.rbDaire.UseVisualStyleBackColor = true;
            this.rbDaire.CheckedChanged += new System.EventHandler(this.rbDaire_CheckedChanged);
            // 
            // rbDikdortgen
            // 
            this.rbDikdortgen.AutoSize = true;
            this.rbDikdortgen.Location = new System.Drawing.Point(120, 19);
            this.rbDikdortgen.Name = "rbDikdortgen";
            this.rbDikdortgen.Size = new System.Drawing.Size(77, 17);
            this.rbDikdortgen.TabIndex = 1;
            this.rbDikdortgen.TabStop = true;
            this.rbDikdortgen.Text = "Dikdortgen";
            this.rbDikdortgen.UseVisualStyleBackColor = true;
            this.rbDikdortgen.CheckedChanged += new System.EventHandler(this.rbDikdortgen_CheckedChanged);
            // 
            // rbUcgen
            // 
            this.rbUcgen.AutoSize = true;
            this.rbUcgen.Location = new System.Drawing.Point(22, 19);
            this.rbUcgen.Name = "rbUcgen";
            this.rbUcgen.Size = new System.Drawing.Size(57, 17);
            this.rbUcgen.TabIndex = 0;
            this.rbUcgen.TabStop = true;
            this.rbUcgen.Text = "Üçgen";
            this.rbUcgen.UseVisualStyleBackColor = true;
            this.rbUcgen.CheckedChanged += new System.EventHandler(this.rbUcgen_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbCarpma);
            this.groupBox2.Controls.Add(this.rbBolme);
            this.groupBox2.Controls.Add(this.rbCıkarma);
            this.groupBox2.Controls.Add(this.rbToplama);
            this.groupBox2.Location = new System.Drawing.Point(321, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 54);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İŞLEM SEÇ";
            // 
            // rbCarpma
            // 
            this.rbCarpma.AutoSize = true;
            this.rbCarpma.Location = new System.Drawing.Point(228, 19);
            this.rbCarpma.Name = "rbCarpma";
            this.rbCarpma.Size = new System.Drawing.Size(61, 17);
            this.rbCarpma.TabIndex = 4;
            this.rbCarpma.TabStop = true;
            this.rbCarpma.Text = "Çarpma";
            this.rbCarpma.UseVisualStyleBackColor = true;
            // 
            // rbBolme
            // 
            this.rbBolme.AutoSize = true;
            this.rbBolme.Location = new System.Drawing.Point(159, 19);
            this.rbBolme.Name = "rbBolme";
            this.rbBolme.Size = new System.Drawing.Size(54, 17);
            this.rbBolme.TabIndex = 2;
            this.rbBolme.TabStop = true;
            this.rbBolme.Text = "Bolme";
            this.rbBolme.UseVisualStyleBackColor = true;
            // 
            // rbCıkarma
            // 
            this.rbCıkarma.AutoSize = true;
            this.rbCıkarma.Location = new System.Drawing.Point(90, 19);
            this.rbCıkarma.Name = "rbCıkarma";
            this.rbCıkarma.Size = new System.Drawing.Size(63, 17);
            this.rbCıkarma.TabIndex = 1;
            this.rbCıkarma.TabStop = true;
            this.rbCıkarma.Text = "Çıkarma";
            this.rbCıkarma.UseVisualStyleBackColor = true;
            // 
            // rbToplama
            // 
            this.rbToplama.AutoSize = true;
            this.rbToplama.Location = new System.Drawing.Point(9, 19);
            this.rbToplama.Name = "rbToplama";
            this.rbToplama.Size = new System.Drawing.Size(66, 17);
            this.rbToplama.TabIndex = 0;
            this.rbToplama.TabStop = true;
            this.rbToplama.Text = "Toplama";
            this.rbToplama.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblSonuc);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtValue3);
            this.groupBox3.Controls.Add(this.txtValue4);
            this.groupBox3.Location = new System.Drawing.Point(321, 105);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(306, 134);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İŞLEM";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(142, 111);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(45, 13);
            this.lblSonuc.TabIndex = 48;
            this.lblSonuc.Text = "SONUC";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(106, 73);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 33);
            this.button3.TabIndex = 47;
            this.button3.Text = "Hesapla";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "İlk Value :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Son Value:";
            // 
            // txtValue3
            // 
            this.txtValue3.Location = new System.Drawing.Point(106, 19);
            this.txtValue3.Name = "txtValue3";
            this.txtValue3.Size = new System.Drawing.Size(185, 20);
            this.txtValue3.TabIndex = 44;
            this.txtValue3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue3_KeyPress);
            // 
            // txtValue4
            // 
            this.txtValue4.Location = new System.Drawing.Point(106, 46);
            this.txtValue4.Name = "txtValue4";
            this.txtValue4.Size = new System.Drawing.Size(185, 20);
            this.txtValue4.TabIndex = 43;
            this.txtValue4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue4_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtYukseklik1);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtTabanAlan);
            this.groupBox4.Controls.Add(this.txtHacimSonuc);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Location = new System.Drawing.Point(321, 245);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(306, 154);
            this.groupBox4.TabIndex = 44;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "HACİM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Yukseklik";
            // 
            // txtYukseklik1
            // 
            this.txtYukseklik1.Location = new System.Drawing.Point(110, 39);
            this.txtYukseklik1.Name = "txtYukseklik1";
            this.txtYukseklik1.Size = new System.Drawing.Size(185, 20);
            this.txtYukseklik1.TabIndex = 51;
            this.txtYukseklik1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYukseklik1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Taban ALan";
            // 
            // txtTabanAlan
            // 
            this.txtTabanAlan.Location = new System.Drawing.Point(110, 13);
            this.txtTabanAlan.Name = "txtTabanAlan";
            this.txtTabanAlan.Size = new System.Drawing.Size(185, 20);
            this.txtTabanAlan.TabIndex = 49;
            this.txtTabanAlan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTabanAlan_KeyPress);
            // 
            // txtHacimSonuc
            // 
            this.txtHacimSonuc.Location = new System.Drawing.Point(110, 109);
            this.txtHacimSonuc.Name = "txtHacimSonuc";
            this.txtHacimSonuc.Size = new System.Drawing.Size(104, 20);
            this.txtHacimSonuc.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Haciminiz";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(110, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 39);
            this.button2.TabIndex = 46;
            this.button2.Text = "Hacim Hesapla";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // alan
            // 
            this.alan.Controls.Add(this.lblYariCap);
            this.alan.Controls.Add(this.txtYariCap);
            this.alan.Controls.Add(this.lblValue1);
            this.alan.Controls.Add(this.txtAlanSonuc);
            this.alan.Controls.Add(this.lblAlan);
            this.alan.Controls.Add(this.lblYukseklik);
            this.alan.Controls.Add(this.lblValue2);
            this.alan.Controls.Add(this.txtYukseklik);
            this.alan.Controls.Add(this.txtValue1);
            this.alan.Controls.Add(this.txtValue2);
            this.alan.Controls.Add(this.button1);
            this.alan.Location = new System.Drawing.Point(12, 105);
            this.alan.Name = "alan";
            this.alan.Size = new System.Drawing.Size(271, 294);
            this.alan.TabIndex = 45;
            this.alan.TabStop = false;
            this.alan.Text = "ALAN";
            // 
            // lblYariCap
            // 
            this.lblYariCap.AutoSize = true;
            this.lblYariCap.Location = new System.Drawing.Point(9, 93);
            this.lblYariCap.Name = "lblYariCap";
            this.lblYariCap.Size = new System.Drawing.Size(47, 13);
            this.lblYariCap.TabIndex = 43;
            this.lblYariCap.Text = "Yarı Çap";
            // 
            // txtYariCap
            // 
            this.txtYariCap.Location = new System.Drawing.Point(90, 93);
            this.txtYariCap.Name = "txtYariCap";
            this.txtYariCap.Size = new System.Drawing.Size(172, 20);
            this.txtYariCap.TabIndex = 42;
            this.txtYariCap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYariCap_KeyPress_1);
            // 
            // lblValue1
            // 
            this.lblValue1.AutoSize = true;
            this.lblValue1.Location = new System.Drawing.Point(9, 30);
            this.lblValue1.Name = "lblValue1";
            this.lblValue1.Size = new System.Drawing.Size(49, 13);
            this.lblValue1.TabIndex = 41;
            this.lblValue1.Text = "İlk Kenar";
            // 
            // txtAlanSonuc
            // 
            this.txtAlanSonuc.Location = new System.Drawing.Point(90, 253);
            this.txtAlanSonuc.Name = "txtAlanSonuc";
            this.txtAlanSonuc.Size = new System.Drawing.Size(74, 20);
            this.txtAlanSonuc.TabIndex = 40;
            // 
            // lblAlan
            // 
            this.lblAlan.AutoSize = true;
            this.lblAlan.Location = new System.Drawing.Point(9, 256);
            this.lblAlan.Name = "lblAlan";
            this.lblAlan.Size = new System.Drawing.Size(43, 13);
            this.lblAlan.TabIndex = 39;
            this.lblAlan.Text = "Alanınız";
            // 
            // lblYukseklik
            // 
            this.lblYukseklik.AutoSize = true;
            this.lblYukseklik.Location = new System.Drawing.Point(9, 147);
            this.lblYukseklik.Name = "lblYukseklik";
            this.lblYukseklik.Size = new System.Drawing.Size(53, 13);
            this.lblYukseklik.TabIndex = 38;
            this.lblYukseklik.Text = "Yukseklik";
            // 
            // lblValue2
            // 
            this.lblValue2.AutoSize = true;
            this.lblValue2.Location = new System.Drawing.Point(9, 58);
            this.lblValue2.Name = "lblValue2";
            this.lblValue2.Size = new System.Drawing.Size(57, 13);
            this.lblValue2.TabIndex = 37;
            this.lblValue2.Text = "Son Kenar";
            // 
            // txtYukseklik
            // 
            this.txtYukseklik.Location = new System.Drawing.Point(90, 140);
            this.txtYukseklik.Name = "txtYukseklik";
            this.txtYukseklik.Size = new System.Drawing.Size(172, 20);
            this.txtYukseklik.TabIndex = 36;
            this.txtYukseklik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYukseklik_KeyPress_1);
            // 
            // txtValue1
            // 
            this.txtValue1.Location = new System.Drawing.Point(90, 23);
            this.txtValue1.Name = "txtValue1";
            this.txtValue1.Size = new System.Drawing.Size(172, 20);
            this.txtValue1.TabIndex = 35;
            this.txtValue1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue1_KeyPress_1);
            // 
            // txtValue2
            // 
            this.txtValue2.Location = new System.Drawing.Point(90, 58);
            this.txtValue2.Name = "txtValue2";
            this.txtValue2.Size = new System.Drawing.Size(172, 20);
            this.txtValue2.TabIndex = 34;
            this.txtValue2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue2_KeyPress_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 31);
            this.button1.TabIndex = 33;
            this.button1.Text = "Alan Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 411);
            this.Controls.Add(this.alan);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.alan.ResumeLayout(false);
            this.alan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDaire;
        private System.Windows.Forms.RadioButton rbDikdortgen;
        private System.Windows.Forms.RadioButton rbUcgen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbCarpma;
        private System.Windows.Forms.RadioButton rbBolme;
        private System.Windows.Forms.RadioButton rbCıkarma;
        private System.Windows.Forms.RadioButton rbToplama;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValue3;
        private System.Windows.Forms.TextBox txtValue4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtYukseklik1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTabanAlan;
        private System.Windows.Forms.TextBox txtHacimSonuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox alan;
        private System.Windows.Forms.Label lblYariCap;
        private System.Windows.Forms.TextBox txtYariCap;
        private System.Windows.Forms.Label lblValue1;
        private System.Windows.Forms.TextBox txtAlanSonuc;
        private System.Windows.Forms.Label lblAlan;
        private System.Windows.Forms.Label lblYukseklik;
        private System.Windows.Forms.Label lblValue2;
        private System.Windows.Forms.TextBox txtYukseklik;
        private System.Windows.Forms.TextBox txtValue1;
        private System.Windows.Forms.TextBox txtValue2;
        private System.Windows.Forms.Button button1;
    }
}


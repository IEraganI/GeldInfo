namespace WindowsFormsApplication1
{
    partial class frmGeldausgabe
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdAusgebn = new System.Windows.Forms.Button();
            this.txtAusgabebetrag = new System.Windows.Forms.TextBox();
            this.lstGeldscheine = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRestbetrag = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt100er = new System.Windows.Forms.TextBox();
            this.txt50er = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt20er = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt10er = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt5er = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdAusgebn
            // 
            this.cmdAusgebn.Location = new System.Drawing.Point(245, 78);
            this.cmdAusgebn.Name = "cmdAusgebn";
            this.cmdAusgebn.Size = new System.Drawing.Size(101, 48);
            this.cmdAusgebn.TabIndex = 0;
            this.cmdAusgebn.Text = "Geld rausrücken!";
            this.cmdAusgebn.UseVisualStyleBackColor = true;
            this.cmdAusgebn.Click += new System.EventHandler(this.cmdAusgebn_Click);
            // 
            // txtAusgabebetrag
            // 
            this.txtAusgabebetrag.Location = new System.Drawing.Point(243, 43);
            this.txtAusgabebetrag.Name = "txtAusgabebetrag";
            this.txtAusgabebetrag.Size = new System.Drawing.Size(102, 20);
            this.txtAusgabebetrag.TabIndex = 1;
            // 
            // lstGeldscheine
            // 
            this.lstGeldscheine.FormattingEnabled = true;
            this.lstGeldscheine.Location = new System.Drawing.Point(245, 156);
            this.lstGeldscheine.Name = "lstGeldscheine";
            this.lstGeldscheine.Size = new System.Drawing.Size(114, 290);
            this.lstGeldscheine.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Abhebebetrag:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Geldscheine:";
            // 
            // lblRestbetrag
            // 
            this.lblRestbetrag.AutoSize = true;
            this.lblRestbetrag.Location = new System.Drawing.Point(248, 467);
            this.lblRestbetrag.Name = "lblRestbetrag";
            this.lblRestbetrag.Size = new System.Drawing.Size(13, 13);
            this.lblRestbetrag.TabIndex = 5;
            this.lblRestbetrag.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 449);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Restbetrag:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt5er);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt10er);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt20er);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt50er);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt100er);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(22, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 176);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Geldvorrat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "100er";
            // 
            // txt100er
            // 
            this.txt100er.Location = new System.Drawing.Point(60, 27);
            this.txt100er.Name = "txt100er";
            this.txt100er.Size = new System.Drawing.Size(71, 20);
            this.txt100er.TabIndex = 1;
            this.txt100er.Text = "12";
            // 
            // txt50er
            // 
            this.txt50er.Location = new System.Drawing.Point(60, 57);
            this.txt50er.Name = "txt50er";
            this.txt50er.Size = new System.Drawing.Size(71, 20);
            this.txt50er.TabIndex = 3;
            this.txt50er.Text = "12";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "50er";
            // 
            // txt20er
            // 
            this.txt20er.Location = new System.Drawing.Point(60, 83);
            this.txt20er.Name = "txt20er";
            this.txt20er.Size = new System.Drawing.Size(71, 20);
            this.txt20er.TabIndex = 5;
            this.txt20er.Text = "12";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "20er";
            // 
            // txt10er
            // 
            this.txt10er.Location = new System.Drawing.Point(60, 109);
            this.txt10er.Name = "txt10er";
            this.txt10er.Size = new System.Drawing.Size(71, 20);
            this.txt10er.TabIndex = 7;
            this.txt10er.Text = "12";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "10er";
            // 
            // txt5er
            // 
            this.txt5er.Location = new System.Drawing.Point(60, 135);
            this.txt5er.Name = "txt5er";
            this.txt5er.Size = new System.Drawing.Size(71, 20);
            this.txt5er.TabIndex = 9;
            this.txt5er.Text = "12";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "5er";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Scheine;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(23, 237);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // frmGeldausgabe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 494);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRestbetrag);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstGeldscheine);
            this.Controls.Add(this.txtAusgabebetrag);
            this.Controls.Add(this.cmdAusgebn);
            this.Name = "frmGeldausgabe";
            this.Text = "Geldausgabeautomat";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdAusgebn;
        private System.Windows.Forms.TextBox txtAusgabebetrag;
        private System.Windows.Forms.ListBox lstGeldscheine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRestbetrag;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt100er;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt50er;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt5er;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt10er;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt20er;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


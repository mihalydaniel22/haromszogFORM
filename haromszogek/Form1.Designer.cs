﻿namespace haromszogek
{
    partial class frmfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAoldal = new System.Windows.Forms.TextBox();
            this.tbBoldal = new System.Windows.Forms.TextBox();
            this.tbColdal = new System.Windows.Forms.TextBox();
            this.BTNkilepes = new System.Windows.Forms.Button();
            this.btnSzamol = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbHaromszoglista = new System.Windows.Forms.ListBox();
            this.btnTorol = new System.Windows.Forms.Button();
            this.btnFajlbol = new System.Windows.Forms.Button();
            this.ofdMegnyitas = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "A Háromszög oldalai:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "a:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "b:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "c:";
            // 
            // tbAoldal
            // 
            this.tbAoldal.Location = new System.Drawing.Point(41, 39);
            this.tbAoldal.Name = "tbAoldal";
            this.tbAoldal.Size = new System.Drawing.Size(100, 29);
            this.tbAoldal.TabIndex = 4;
            // 
            // tbBoldal
            // 
            this.tbBoldal.Location = new System.Drawing.Point(41, 74);
            this.tbBoldal.Name = "tbBoldal";
            this.tbBoldal.Size = new System.Drawing.Size(100, 29);
            this.tbBoldal.TabIndex = 5;
            // 
            // tbColdal
            // 
            this.tbColdal.Location = new System.Drawing.Point(41, 109);
            this.tbColdal.Name = "tbColdal";
            this.tbColdal.Size = new System.Drawing.Size(100, 29);
            this.tbColdal.TabIndex = 6;
            // 
            // BTNkilepes
            // 
            this.BTNkilepes.Location = new System.Drawing.Point(128, 298);
            this.BTNkilepes.Name = "BTNkilepes";
            this.BTNkilepes.Size = new System.Drawing.Size(100, 45);
            this.BTNkilepes.TabIndex = 7;
            this.BTNkilepes.Text = "Kilépés";
            this.BTNkilepes.UseVisualStyleBackColor = true;
            this.BTNkilepes.Click += new System.EventHandler(this.BTNkilepes_Click);
            // 
            // btnSzamol
            // 
            this.btnSzamol.Location = new System.Drawing.Point(205, 63);
            this.btnSzamol.Name = "btnSzamol";
            this.btnSzamol.Size = new System.Drawing.Size(100, 52);
            this.btnSzamol.TabIndex = 8;
            this.btnSzamol.Text = "Számolás";
            this.btnSzamol.UseVisualStyleBackColor = true;
            this.btnSzamol.Click += new System.EventHandler(this.btnSzamol_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.btnSzamol);
            this.panel1.Controls.Add(this.tbColdal);
            this.panel1.Controls.Add(this.tbBoldal);
            this.panel1.Controls.Add(this.tbAoldal);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 185);
            this.panel1.TabIndex = 9;
            // 
            // lbHaromszoglista
            // 
            this.lbHaromszoglista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbHaromszoglista.FormattingEnabled = true;
            this.lbHaromszoglista.ItemHeight = 16;
            this.lbHaromszoglista.Location = new System.Drawing.Point(360, 53);
            this.lbHaromszoglista.Name = "lbHaromszoglista";
            this.lbHaromszoglista.Size = new System.Drawing.Size(206, 292);
            this.lbHaromszoglista.TabIndex = 10;
            this.lbHaromszoglista.SelectedIndexChanged += new System.EventHandler(this.lbHaromszoglista_SelectedIndexChanged);
            // 
            // btnTorol
            // 
            this.btnTorol.Location = new System.Drawing.Point(422, 12);
            this.btnTorol.Name = "btnTorol";
            this.btnTorol.Size = new System.Drawing.Size(75, 35);
            this.btnTorol.TabIndex = 11;
            this.btnTorol.Text = "Törlés";
            this.btnTorol.UseVisualStyleBackColor = true;
            this.btnTorol.Click += new System.EventHandler(this.btnTorol_Click);
            // 
            // btnFajlbol
            // 
            this.btnFajlbol.Location = new System.Drawing.Point(124, 210);
            this.btnFajlbol.Name = "btnFajlbol";
            this.btnFajlbol.Size = new System.Drawing.Size(104, 35);
            this.btnFajlbol.TabIndex = 9;
            this.btnFajlbol.Text = "Fájl-ból";
            this.btnFajlbol.UseVisualStyleBackColor = true;
            this.btnFajlbol.Click += new System.EventHandler(this.btnFajlbol_Click);
            // 
            // ofdMegnyitas
            // 
            this.ofdMegnyitas.FileName = "openFileDialog1";
            this.ofdMegnyitas.Filter = "Text files |*.txt";
            this.ofdMegnyitas.InitialDirectory = "C:\\Users\\c16MIHÁLYD\\source\\repos\\haromszogek\\haromszogek\\bin\\Debug";
            // 
            // frmfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 355);
            this.Controls.Add(this.btnFajlbol);
            this.Controls.Add(this.btnTorol);
            this.Controls.Add(this.lbHaromszoglista);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BTNkilepes);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmfo";
            this.Text = "Háromszög";
            this.Load += new System.EventHandler(this.frmfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAoldal;
        private System.Windows.Forms.TextBox tbBoldal;
        private System.Windows.Forms.TextBox tbColdal;
        private System.Windows.Forms.Button BTNkilepes;
        private System.Windows.Forms.Button btnSzamol;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbHaromszoglista;
        private System.Windows.Forms.Button btnTorol;
        private System.Windows.Forms.Button btnFajlbol;
        private System.Windows.Forms.OpenFileDialog ofdMegnyitas;
    }
}


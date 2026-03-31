namespace KorKeruletTerulet_Eletkor
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
            this.korTK_gb = new System.Windows.Forms.GroupBox();
            this.szamol_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.terulet_tb = new System.Windows.Forms.TextBox();
            this.kerulet_tb = new System.Windows.Forms.TextBox();
            this.r_tb = new System.Windows.Forms.TextBox();
            this.Eletkor_gb = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bekuld_btn = new System.Windows.Forms.Button();
            this.eletkor_tb = new System.Windows.Forms.TextBox();
            this.korTK_gb.SuspendLayout();
            this.Eletkor_gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // korTK_gb
            // 
            this.korTK_gb.Controls.Add(this.szamol_btn);
            this.korTK_gb.Controls.Add(this.label3);
            this.korTK_gb.Controls.Add(this.label2);
            this.korTK_gb.Controls.Add(this.label1);
            this.korTK_gb.Controls.Add(this.terulet_tb);
            this.korTK_gb.Controls.Add(this.kerulet_tb);
            this.korTK_gb.Controls.Add(this.r_tb);
            this.korTK_gb.Location = new System.Drawing.Point(101, 70);
            this.korTK_gb.Name = "korTK_gb";
            this.korTK_gb.Size = new System.Drawing.Size(234, 285);
            this.korTK_gb.TabIndex = 0;
            this.korTK_gb.TabStop = false;
            this.korTK_gb.Text = "Kör számítások";
            // 
            // szamol_btn
            // 
            this.szamol_btn.Location = new System.Drawing.Point(74, 233);
            this.szamol_btn.Name = "szamol_btn";
            this.szamol_btn.Size = new System.Drawing.Size(75, 23);
            this.szamol_btn.TabIndex = 8;
            this.szamol_btn.Text = "Számol";
            this.szamol_btn.UseVisualStyleBackColor = true;
            this.szamol_btn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.szamol_btn_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Terület:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kerület:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sugár:";
            // 
            // terulet_tb
            // 
            this.terulet_tb.Location = new System.Drawing.Point(85, 173);
            this.terulet_tb.Name = "terulet_tb";
            this.terulet_tb.ReadOnly = true;
            this.terulet_tb.Size = new System.Drawing.Size(100, 20);
            this.terulet_tb.TabIndex = 4;
            this.terulet_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kerulet_tb
            // 
            this.kerulet_tb.Location = new System.Drawing.Point(85, 137);
            this.kerulet_tb.Name = "kerulet_tb";
            this.kerulet_tb.ReadOnly = true;
            this.kerulet_tb.Size = new System.Drawing.Size(100, 20);
            this.kerulet_tb.TabIndex = 3;
            this.kerulet_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // r_tb
            // 
            this.r_tb.Location = new System.Drawing.Point(85, 58);
            this.r_tb.Name = "r_tb";
            this.r_tb.Size = new System.Drawing.Size(100, 20);
            this.r_tb.TabIndex = 2;
            this.r_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Eletkor_gb
            // 
            this.Eletkor_gb.Controls.Add(this.label4);
            this.Eletkor_gb.Controls.Add(this.bekuld_btn);
            this.Eletkor_gb.Controls.Add(this.eletkor_tb);
            this.Eletkor_gb.Location = new System.Drawing.Point(437, 70);
            this.Eletkor_gb.Name = "Eletkor_gb";
            this.Eletkor_gb.Size = new System.Drawing.Size(234, 285);
            this.Eletkor_gb.TabIndex = 1;
            this.Eletkor_gb.TabStop = false;
            this.Eletkor_gb.Text = "Életkor vizsgáló";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(45, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Írd be az életkorod";
            // 
            // bekuld_btn
            // 
            this.bekuld_btn.Location = new System.Drawing.Point(81, 166);
            this.bekuld_btn.Name = "bekuld_btn";
            this.bekuld_btn.Size = new System.Drawing.Size(75, 23);
            this.bekuld_btn.TabIndex = 10;
            this.bekuld_btn.Text = "Beküldés";
            this.bekuld_btn.UseVisualStyleBackColor = true;
            this.bekuld_btn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bekuld_btn_MouseClick);
            // 
            // eletkor_tb
            // 
            this.eletkor_tb.Location = new System.Drawing.Point(81, 96);
            this.eletkor_tb.Name = "eletkor_tb";
            this.eletkor_tb.Size = new System.Drawing.Size(75, 20);
            this.eletkor_tb.TabIndex = 9;
            this.eletkor_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.Eletkor_gb);
            this.Controls.Add(this.korTK_gb);
            this.Name = "Form1";
            this.Text = "Kör kerület, terület + Életkor program";
            this.korTK_gb.ResumeLayout(false);
            this.korTK_gb.PerformLayout();
            this.Eletkor_gb.ResumeLayout(false);
            this.Eletkor_gb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox korTK_gb;
        private System.Windows.Forms.Button szamol_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox terulet_tb;
        private System.Windows.Forms.TextBox kerulet_tb;
        private System.Windows.Forms.TextBox r_tb;
        private System.Windows.Forms.GroupBox Eletkor_gb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bekuld_btn;
        private System.Windows.Forms.TextBox eletkor_tb;
    }
}


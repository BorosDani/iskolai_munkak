namespace Gyakorlo_bevezeto_feladatok
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
            this.Eltunes_btn = new System.Windows.Forms.Button();
            this.lathatatlan_btn = new System.Windows.Forms.Button();
            this.inaktiv_btn = new System.Windows.Forms.Button();
            this.kilepes_btn = new System.Windows.Forms.Button();
            this.ugras_btn = new System.Windows.Forms.Button();
            this.eger_poz = new System.Windows.Forms.Label();
            this.xy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Eltunes_btn
            // 
            this.Eltunes_btn.Location = new System.Drawing.Point(121, 70);
            this.Eltunes_btn.Name = "Eltunes_btn";
            this.Eltunes_btn.Size = new System.Drawing.Size(75, 23);
            this.Eltunes_btn.TabIndex = 0;
            this.Eltunes_btn.Text = "Eltűnés";
            this.Eltunes_btn.UseVisualStyleBackColor = true;
            this.Eltunes_btn.MouseEnter += new System.EventHandler(this.Eltunes_btn_MouseEnter);
            this.Eltunes_btn.MouseLeave += new System.EventHandler(this.Eltunes_btn_MouseLeave);
            // 
            // lathatatlan_btn
            // 
            this.lathatatlan_btn.Location = new System.Drawing.Point(121, 127);
            this.lathatatlan_btn.Name = "lathatatlan_btn";
            this.lathatatlan_btn.Size = new System.Drawing.Size(75, 23);
            this.lathatatlan_btn.TabIndex = 1;
            this.lathatatlan_btn.Text = "Láthatatlan";
            this.lathatatlan_btn.UseVisualStyleBackColor = true;
            this.lathatatlan_btn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lathatatlan_btn_MouseClick);
            // 
            // inaktiv_btn
            // 
            this.inaktiv_btn.Location = new System.Drawing.Point(121, 181);
            this.inaktiv_btn.Name = "inaktiv_btn";
            this.inaktiv_btn.Size = new System.Drawing.Size(75, 23);
            this.inaktiv_btn.TabIndex = 2;
            this.inaktiv_btn.Text = "Inaktív";
            this.inaktiv_btn.UseVisualStyleBackColor = true;
            this.inaktiv_btn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.inaktiv_btn_MouseClick);
            // 
            // kilepes_btn
            // 
            this.kilepes_btn.Location = new System.Drawing.Point(230, 238);
            this.kilepes_btn.Name = "kilepes_btn";
            this.kilepes_btn.Size = new System.Drawing.Size(75, 23);
            this.kilepes_btn.TabIndex = 3;
            this.kilepes_btn.Text = "Kilépés";
            this.kilepes_btn.UseVisualStyleBackColor = true;
            this.kilepes_btn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.kilepes_btn_MouseClick);
            // 
            // ugras_btn
            // 
            this.ugras_btn.Location = new System.Drawing.Point(330, 70);
            this.ugras_btn.Name = "ugras_btn";
            this.ugras_btn.Size = new System.Drawing.Size(75, 23);
            this.ugras_btn.TabIndex = 4;
            this.ugras_btn.Text = "Ugrás";
            this.ugras_btn.UseVisualStyleBackColor = true;
            this.ugras_btn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ugras_btn_MouseClick);
            // 
            // eger_poz
            // 
            this.eger_poz.AutoSize = true;
            this.eger_poz.Location = new System.Drawing.Point(327, 127);
            this.eger_poz.Name = "eger_poz";
            this.eger_poz.Size = new System.Drawing.Size(78, 13);
            this.eger_poz.TabIndex = 5;
            this.eger_poz.Text = "Egér pozíciója:";
            // 
            // xy
            // 
            this.xy.AutoSize = true;
            this.xy.Location = new System.Drawing.Point(327, 154);
            this.xy.Name = "xy";
            this.xy.Size = new System.Drawing.Size(17, 13);
            this.xy.TabIndex = 6;
            this.xy.Text = "xy";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 321);
            this.Controls.Add(this.xy);
            this.Controls.Add(this.eger_poz);
            this.Controls.Add(this.ugras_btn);
            this.Controls.Add(this.kilepes_btn);
            this.Controls.Add(this.inaktiv_btn);
            this.Controls.Add(this.lathatatlan_btn);
            this.Controls.Add(this.Eltunes_btn);
            this.Name = "Form1";
            this.Text = "Gyakorló bevezető feladatok";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.xy_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Eltunes_btn;
        private System.Windows.Forms.Button lathatatlan_btn;
        private System.Windows.Forms.Button inaktiv_btn;
        private System.Windows.Forms.Button kilepes_btn;
        private System.Windows.Forms.Button ugras_btn;
        private System.Windows.Forms.Label eger_poz;
        private System.Windows.Forms.Label xy;
    }
}


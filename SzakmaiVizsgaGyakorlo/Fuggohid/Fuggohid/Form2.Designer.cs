namespace Fuggohid
{
    partial class Form2
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
            this.nevLB = new System.Windows.Forms.ListBox();
            this.keresesGB = new System.Windows.Forms.GroupBox();
            this.orszagLbl = new System.Windows.Forms.Label();
            this.egyKmHosszabbCBx = new System.Windows.Forms.CheckBox();
            this.keresesBtn = new System.Windows.Forms.Button();
            this.bezarBtn = new System.Windows.Forms.Button();
            this.orszagCB = new System.Windows.Forms.ComboBox();
            this.keresesGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // nevLB
            // 
            this.nevLB.FormattingEnabled = true;
            this.nevLB.Location = new System.Drawing.Point(48, 12);
            this.nevLB.Name = "nevLB";
            this.nevLB.Size = new System.Drawing.Size(384, 225);
            this.nevLB.TabIndex = 0;
            // 
            // keresesGB
            // 
            this.keresesGB.Controls.Add(this.orszagCB);
            this.keresesGB.Controls.Add(this.bezarBtn);
            this.keresesGB.Controls.Add(this.keresesBtn);
            this.keresesGB.Controls.Add(this.egyKmHosszabbCBx);
            this.keresesGB.Controls.Add(this.orszagLbl);
            this.keresesGB.Location = new System.Drawing.Point(71, 261);
            this.keresesGB.Name = "keresesGB";
            this.keresesGB.Size = new System.Drawing.Size(338, 173);
            this.keresesGB.TabIndex = 1;
            this.keresesGB.TabStop = false;
            this.keresesGB.Text = "Keresés";
            // 
            // orszagLbl
            // 
            this.orszagLbl.AutoSize = true;
            this.orszagLbl.Location = new System.Drawing.Point(32, 30);
            this.orszagLbl.Name = "orszagLbl";
            this.orszagLbl.Size = new System.Drawing.Size(40, 13);
            this.orszagLbl.TabIndex = 1;
            this.orszagLbl.Text = "Ország";
            // 
            // egyKmHosszabbCBx
            // 
            this.egyKmHosszabbCBx.AutoSize = true;
            this.egyKmHosszabbCBx.Location = new System.Drawing.Point(35, 75);
            this.egyKmHosszabbCBx.Name = "egyKmHosszabbCBx";
            this.egyKmHosszabbCBx.Size = new System.Drawing.Size(126, 17);
            this.egyKmHosszabbCBx.TabIndex = 2;
            this.egyKmHosszabbCBx.Text = "1 km-nél hosszabbak";
            this.egyKmHosszabbCBx.UseVisualStyleBackColor = true;
            // 
            // keresesBtn
            // 
            this.keresesBtn.Location = new System.Drawing.Point(55, 130);
            this.keresesBtn.Name = "keresesBtn";
            this.keresesBtn.Size = new System.Drawing.Size(75, 23);
            this.keresesBtn.TabIndex = 3;
            this.keresesBtn.Text = "Keresés";
            this.keresesBtn.UseVisualStyleBackColor = true;
            this.keresesBtn.Click += new System.EventHandler(this.keresesBtn_Click);
            // 
            // bezarBtn
            // 
            this.bezarBtn.Location = new System.Drawing.Point(212, 130);
            this.bezarBtn.Name = "bezarBtn";
            this.bezarBtn.Size = new System.Drawing.Size(75, 23);
            this.bezarBtn.TabIndex = 4;
            this.bezarBtn.Text = "Bezárás";
            this.bezarBtn.UseVisualStyleBackColor = true;
            this.bezarBtn.Click += new System.EventHandler(this.bezarBtn_Click);
            // 
            // orszagCB
            // 
            this.orszagCB.FormattingEnabled = true;
            this.orszagCB.Location = new System.Drawing.Point(80, 27);
            this.orszagCB.Name = "orszagCB";
            this.orszagCB.Size = new System.Drawing.Size(121, 21);
            this.orszagCB.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.keresesGB);
            this.Controls.Add(this.nevLB);
            this.Name = "Form2";
            this.Text = "Keresés";
            this.keresesGB.ResumeLayout(false);
            this.keresesGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox nevLB;
        private System.Windows.Forms.GroupBox keresesGB;
        private System.Windows.Forms.Button bezarBtn;
        private System.Windows.Forms.Button keresesBtn;
        private System.Windows.Forms.CheckBox egyKmHosszabbCBx;
        private System.Windows.Forms.Label orszagLbl;
        private System.Windows.Forms.ComboBox orszagCB;
    }
}
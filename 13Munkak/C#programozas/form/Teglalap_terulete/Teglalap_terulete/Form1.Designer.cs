namespace Teglalap_terulete
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
            this.aOldalTxt = new System.Windows.Forms.TextBox();
            this.bOldalTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.szamitas_btn = new System.Windows.Forms.Button();
            this.teruletLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aOldalTxt
            // 
            this.aOldalTxt.Location = new System.Drawing.Point(97, 37);
            this.aOldalTxt.Name = "aOldalTxt";
            this.aOldalTxt.Size = new System.Drawing.Size(100, 20);
            this.aOldalTxt.TabIndex = 0;
            this.aOldalTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bOldalTxt
            // 
            this.bOldalTxt.Location = new System.Drawing.Point(97, 75);
            this.bOldalTxt.Name = "bOldalTxt";
            this.bOldalTxt.Size = new System.Drawing.Size(100, 20);
            this.bOldalTxt.TabIndex = 1;
            this.bOldalTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "b:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Terület:";
            // 
            // szamitas_btn
            // 
            this.szamitas_btn.Location = new System.Drawing.Point(110, 192);
            this.szamitas_btn.Name = "szamitas_btn";
            this.szamitas_btn.Size = new System.Drawing.Size(75, 23);
            this.szamitas_btn.TabIndex = 6;
            this.szamitas_btn.Text = "Számítás";
            this.szamitas_btn.UseVisualStyleBackColor = true;
            this.szamitas_btn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.szamitas_btn_MouseClick);
            // 
            // teruletLbl
            // 
            this.teruletLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teruletLbl.Location = new System.Drawing.Point(97, 142);
            this.teruletLbl.Name = "teruletLbl";
            this.teruletLbl.Size = new System.Drawing.Size(100, 23);
            this.teruletLbl.TabIndex = 7;
            this.teruletLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.teruletLbl);
            this.Controls.Add(this.szamitas_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bOldalTxt);
            this.Controls.Add(this.aOldalTxt);
            this.Name = "Form1";
            this.Text = "Terület és kerület számítás";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox aOldalTxt;
        private System.Windows.Forms.TextBox bOldalTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button szamitas_btn;
        private System.Windows.Forms.Label teruletLbl;
    }
}


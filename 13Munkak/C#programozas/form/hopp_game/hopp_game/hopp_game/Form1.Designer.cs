namespace hopp_game
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
            this.xKoordTxt = new System.Windows.Forms.TextBox();
            this.yKoordTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hopp_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // xKoordTxt
            // 
            this.xKoordTxt.Location = new System.Drawing.Point(159, 60);
            this.xKoordTxt.Name = "xKoordTxt";
            this.xKoordTxt.Size = new System.Drawing.Size(100, 20);
            this.xKoordTxt.TabIndex = 0;
            this.xKoordTxt.Text = "100";
            this.xKoordTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // yKoordTxt
            // 
            this.yKoordTxt.Location = new System.Drawing.Point(345, 60);
            this.yKoordTxt.Name = "yKoordTxt";
            this.yKoordTxt.Size = new System.Drawing.Size(100, 20);
            this.yKoordTxt.TabIndex = 1;
            this.yKoordTxt.Text = "100";
            this.yKoordTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Y:";
            // 
            // hopp_btn
            // 
            this.hopp_btn.Location = new System.Drawing.Point(246, 189);
            this.hopp_btn.Name = "hopp_btn";
            this.hopp_btn.Size = new System.Drawing.Size(70, 30);
            this.hopp_btn.TabIndex = 4;
            this.hopp_btn.Text = "Hopp";
            this.hopp_btn.UseVisualStyleBackColor = true;
            this.hopp_btn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.hopp_btn_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.hopp_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yKoordTxt);
            this.Controls.Add(this.xKoordTxt);
            this.Name = "Form1";
            this.Text = "Hopp játék";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox xKoordTxt;
        private System.Windows.Forms.TextBox yKoordTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button hopp_btn;
    }
}


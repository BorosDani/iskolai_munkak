namespace sajat
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
            this.karakter_btn = new System.Windows.Forms.Button();
            this.point_btn = new System.Windows.Forms.Button();
            this.pont_poz_Lbl = new System.Windows.Forms.Label();
            this.karakter_position_Lbl = new System.Windows.Forms.Label();
            this.pont_lbl = new System.Windows.Forms.Label();
            this.kilepes_btn = new System.Windows.Forms.Button();
            this.info_lbl = new System.Windows.Forms.Label();
            this.reset_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // karakter_btn
            // 
            this.karakter_btn.Location = new System.Drawing.Point(10, 10);
            this.karakter_btn.Name = "karakter_btn";
            this.karakter_btn.Size = new System.Drawing.Size(60, 25);
            this.karakter_btn.TabIndex = 0;
            this.karakter_btn.TabStop = false;
            this.karakter_btn.Text = "Karakter";
            this.karakter_btn.UseVisualStyleBackColor = true;
            this.karakter_btn.KeyUp += new System.Windows.Forms.KeyEventHandler(this.karakter_btn_OnKeyUp);
            this.karakter_btn.Move += new System.EventHandler(this.karakter_btn_Move);
            // 
            // point_btn
            // 
            this.point_btn.Enabled = false;
            this.point_btn.Location = new System.Drawing.Point(70, 40);
            this.point_btn.Name = "point_btn";
            this.point_btn.Size = new System.Drawing.Size(15, 15);
            this.point_btn.TabIndex = 1;
            this.point_btn.TabStop = false;
            this.point_btn.UseVisualStyleBackColor = true;
            this.point_btn.Move += new System.EventHandler(this.point_btn_Move);
            // 
            // pont_poz_Lbl
            // 
            this.pont_poz_Lbl.AutoSize = true;
            this.pont_poz_Lbl.BackColor = System.Drawing.Color.Transparent;
            this.pont_poz_Lbl.Location = new System.Drawing.Point(318, 329);
            this.pont_poz_Lbl.Name = "pont_poz_Lbl";
            this.pont_poz_Lbl.Size = new System.Drawing.Size(81, 13);
            this.pont_poz_Lbl.TabIndex = 2;
            this.pont_poz_Lbl.Text = "Pont pozíciója: ";
            this.pont_poz_Lbl.Visible = false;
            // 
            // karakter_position_Lbl
            // 
            this.karakter_position_Lbl.AutoSize = true;
            this.karakter_position_Lbl.BackColor = System.Drawing.Color.Transparent;
            this.karakter_position_Lbl.Location = new System.Drawing.Point(300, 342);
            this.karakter_position_Lbl.Name = "karakter_position_Lbl";
            this.karakter_position_Lbl.Size = new System.Drawing.Size(99, 13);
            this.karakter_position_Lbl.TabIndex = 3;
            this.karakter_position_Lbl.Text = "Karakter pozíciója: ";
            this.karakter_position_Lbl.Visible = false;
            // 
            // pont_lbl
            // 
            this.pont_lbl.AutoSize = true;
            this.pont_lbl.BackColor = System.Drawing.Color.Transparent;
            this.pont_lbl.Location = new System.Drawing.Point(424, 18);
            this.pont_lbl.Name = "pont_lbl";
            this.pont_lbl.Size = new System.Drawing.Size(35, 13);
            this.pont_lbl.TabIndex = 4;
            this.pont_lbl.Text = "Pont: ";
            // 
            // kilepes_btn
            // 
            this.kilepes_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kilepes_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.kilepes_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kilepes_btn.ForeColor = System.Drawing.Color.Red;
            this.kilepes_btn.Location = new System.Drawing.Point(185, 170);
            this.kilepes_btn.Name = "kilepes_btn";
            this.kilepes_btn.Size = new System.Drawing.Size(100, 50);
            this.kilepes_btn.TabIndex = 5;
            this.kilepes_btn.TabStop = false;
            this.kilepes_btn.Text = "Kilépés";
            this.kilepes_btn.UseVisualStyleBackColor = false;
            this.kilepes_btn.Visible = false;
            this.kilepes_btn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.kilepes_btn_MouseClick);
            // 
            // info_lbl
            // 
            this.info_lbl.AutoSize = true;
            this.info_lbl.BackColor = System.Drawing.Color.Transparent;
            this.info_lbl.Location = new System.Drawing.Point(399, 31);
            this.info_lbl.Name = "info_lbl";
            this.info_lbl.Size = new System.Drawing.Size(73, 13);
            this.info_lbl.TabIndex = 6;
            this.info_lbl.Text = "( i ) Információ";
            // 
            // reset_btn
            // 
            this.reset_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.reset_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.reset_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset_btn.ForeColor = System.Drawing.Color.White;
            this.reset_btn.Location = new System.Drawing.Point(185, 114);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(100, 50);
            this.reset_btn.TabIndex = 7;
            this.reset_btn.TabStop = false;
            this.reset_btn.Text = "Újrakezdés";
            this.reset_btn.UseVisualStyleBackColor = false;
            this.reset_btn.Visible = false;
            this.reset_btn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.reset_btn_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.ControlBox = false;
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.info_lbl);
            this.Controls.Add(this.kilepes_btn);
            this.Controls.Add(this.pont_lbl);
            this.Controls.Add(this.karakter_position_Lbl);
            this.Controls.Add(this.pont_poz_Lbl);
            this.Controls.Add(this.point_btn);
            this.Controls.Add(this.karakter_btn);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Pontszerzős játék";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button karakter_btn;
        private System.Windows.Forms.Button point_btn;
        private System.Windows.Forms.Label pont_poz_Lbl;
        private System.Windows.Forms.Label karakter_position_Lbl;
        private System.Windows.Forms.Label pont_lbl;
        private System.Windows.Forms.Button kilepes_btn;
        private System.Windows.Forms.Label info_lbl;
        private System.Windows.Forms.Button reset_btn;
    }
}


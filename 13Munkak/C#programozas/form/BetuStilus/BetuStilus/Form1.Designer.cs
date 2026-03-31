namespace BetuStilus
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
            this.cimke_lbl = new System.Windows.Forms.Label();
            this.betustilus_gb = new System.Windows.Forms.GroupBox();
            this.athuzott_cb = new System.Windows.Forms.CheckBox();
            this.alahuzott_cb = new System.Windows.Forms.CheckBox();
            this.dolt_cb = new System.Windows.Forms.CheckBox();
            this.felkover_cb = new System.Windows.Forms.CheckBox();
            this.betumeret_gb = new System.Windows.Forms.GroupBox();
            this.tizennyolc_rb = new System.Windows.Forms.RadioButton();
            this.tizenhat_rb = new System.Windows.Forms.RadioButton();
            this.tizennegy_rb = new System.Windows.Forms.RadioButton();
            this.tizenketto_rb = new System.Windows.Forms.RadioButton();
            this.tizenegy_rb = new System.Windows.Forms.RadioButton();
            this.tiz_rb = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fekete_btn = new System.Windows.Forms.RadioButton();
            this.kek_btn = new System.Windows.Forms.RadioButton();
            this.piros_btn = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.betustilus_gb.SuspendLayout();
            this.betumeret_gb.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cimke_lbl
            // 
            this.cimke_lbl.AutoSize = true;
            this.cimke_lbl.Location = new System.Drawing.Point(305, 42);
            this.cimke_lbl.Name = "cimke_lbl";
            this.cimke_lbl.Size = new System.Drawing.Size(113, 13);
            this.cimke_lbl.TabIndex = 0;
            this.cimke_lbl.Text = "Árvíztűrő tükörfurógép";
            // 
            // betustilus_gb
            // 
            this.betustilus_gb.Controls.Add(this.athuzott_cb);
            this.betustilus_gb.Controls.Add(this.alahuzott_cb);
            this.betustilus_gb.Controls.Add(this.dolt_cb);
            this.betustilus_gb.Controls.Add(this.felkover_cb);
            this.betustilus_gb.Location = new System.Drawing.Point(66, 111);
            this.betustilus_gb.Name = "betustilus_gb";
            this.betustilus_gb.Size = new System.Drawing.Size(200, 239);
            this.betustilus_gb.TabIndex = 1;
            this.betustilus_gb.TabStop = false;
            this.betustilus_gb.Text = "Betűstílus";
            // 
            // athuzott_cb
            // 
            this.athuzott_cb.AutoSize = true;
            this.athuzott_cb.Location = new System.Drawing.Point(57, 175);
            this.athuzott_cb.Name = "athuzott_cb";
            this.athuzott_cb.Size = new System.Drawing.Size(65, 17);
            this.athuzott_cb.TabIndex = 3;
            this.athuzott_cb.Text = "Áthúzott";
            this.athuzott_cb.UseVisualStyleBackColor = true;
            this.athuzott_cb.CheckedChanged += new System.EventHandler(this.athuzott_cb_CheckedChanged);
            // 
            // alahuzott_cb
            // 
            this.alahuzott_cb.AutoSize = true;
            this.alahuzott_cb.Location = new System.Drawing.Point(57, 140);
            this.alahuzott_cb.Name = "alahuzott_cb";
            this.alahuzott_cb.Size = new System.Drawing.Size(70, 17);
            this.alahuzott_cb.TabIndex = 2;
            this.alahuzott_cb.Text = "Aláhúzott";
            this.alahuzott_cb.UseVisualStyleBackColor = true;
            this.alahuzott_cb.CheckedChanged += new System.EventHandler(this.alahuzott_cb_CheckedChanged);
            // 
            // dolt_cb
            // 
            this.dolt_cb.AutoSize = true;
            this.dolt_cb.Location = new System.Drawing.Point(57, 99);
            this.dolt_cb.Name = "dolt_cb";
            this.dolt_cb.Size = new System.Drawing.Size(45, 17);
            this.dolt_cb.TabIndex = 1;
            this.dolt_cb.Text = "Dőlt";
            this.dolt_cb.UseVisualStyleBackColor = true;
            this.dolt_cb.CheckedChanged += new System.EventHandler(this.dolt_cb_CheckedChanged);
            // 
            // felkover_cb
            // 
            this.felkover_cb.AutoSize = true;
            this.felkover_cb.Location = new System.Drawing.Point(57, 55);
            this.felkover_cb.Name = "felkover_cb";
            this.felkover_cb.Size = new System.Drawing.Size(67, 17);
            this.felkover_cb.TabIndex = 0;
            this.felkover_cb.Text = "Félkövér";
            this.felkover_cb.UseVisualStyleBackColor = true;
            this.felkover_cb.CheckedChanged += new System.EventHandler(this.felkover_cb_CheckedChanged);
            // 
            // betumeret_gb
            // 
            this.betumeret_gb.Controls.Add(this.tizennyolc_rb);
            this.betumeret_gb.Controls.Add(this.tizenhat_rb);
            this.betumeret_gb.Controls.Add(this.tizennegy_rb);
            this.betumeret_gb.Controls.Add(this.tizenketto_rb);
            this.betumeret_gb.Controls.Add(this.tizenegy_rb);
            this.betumeret_gb.Controls.Add(this.tiz_rb);
            this.betumeret_gb.Controls.Add(this.groupBox4);
            this.betumeret_gb.Location = new System.Drawing.Point(308, 111);
            this.betumeret_gb.Name = "betumeret_gb";
            this.betumeret_gb.Size = new System.Drawing.Size(200, 239);
            this.betumeret_gb.TabIndex = 2;
            this.betumeret_gb.TabStop = false;
            this.betumeret_gb.Text = "Betűméret";
            // 
            // tizennyolc_rb
            // 
            this.tizennyolc_rb.AutoSize = true;
            this.tizennyolc_rb.Location = new System.Drawing.Point(115, 140);
            this.tizennyolc_rb.Name = "tizennyolc_rb";
            this.tizennyolc_rb.Size = new System.Drawing.Size(37, 17);
            this.tizennyolc_rb.TabIndex = 9;
            this.tizennyolc_rb.TabStop = true;
            this.tizennyolc_rb.Text = "18";
            this.tizennyolc_rb.UseVisualStyleBackColor = true;
            this.tizennyolc_rb.CheckedChanged += new System.EventHandler(this.tizennyolc_rb_CheckedChanged);
            // 
            // tizenhat_rb
            // 
            this.tizenhat_rb.AutoSize = true;
            this.tizenhat_rb.Location = new System.Drawing.Point(115, 98);
            this.tizenhat_rb.Name = "tizenhat_rb";
            this.tizenhat_rb.Size = new System.Drawing.Size(37, 17);
            this.tizenhat_rb.TabIndex = 8;
            this.tizenhat_rb.TabStop = true;
            this.tizenhat_rb.Text = "16";
            this.tizenhat_rb.UseVisualStyleBackColor = true;
            this.tizenhat_rb.CheckedChanged += new System.EventHandler(this.tizenhat_rb_CheckedChanged);
            // 
            // tizennegy_rb
            // 
            this.tizennegy_rb.AutoSize = true;
            this.tizennegy_rb.Location = new System.Drawing.Point(115, 55);
            this.tizennegy_rb.Name = "tizennegy_rb";
            this.tizennegy_rb.Size = new System.Drawing.Size(37, 17);
            this.tizennegy_rb.TabIndex = 7;
            this.tizennegy_rb.TabStop = true;
            this.tizennegy_rb.Text = "14";
            this.tizennegy_rb.UseVisualStyleBackColor = true;
            this.tizennegy_rb.CheckedChanged += new System.EventHandler(this.tizennegy_rb_CheckedChanged);
            // 
            // tizenketto_rb
            // 
            this.tizenketto_rb.AutoSize = true;
            this.tizenketto_rb.Location = new System.Drawing.Point(54, 139);
            this.tizenketto_rb.Name = "tizenketto_rb";
            this.tizenketto_rb.Size = new System.Drawing.Size(37, 17);
            this.tizenketto_rb.TabIndex = 6;
            this.tizenketto_rb.TabStop = true;
            this.tizenketto_rb.Text = "12";
            this.tizenketto_rb.UseVisualStyleBackColor = true;
            this.tizenketto_rb.CheckedChanged += new System.EventHandler(this.tizenketto_rb_CheckedChanged);
            // 
            // tizenegy_rb
            // 
            this.tizenegy_rb.AutoSize = true;
            this.tizenegy_rb.Location = new System.Drawing.Point(54, 98);
            this.tizenegy_rb.Name = "tizenegy_rb";
            this.tizenegy_rb.Size = new System.Drawing.Size(37, 17);
            this.tizenegy_rb.TabIndex = 5;
            this.tizenegy_rb.TabStop = true;
            this.tizenegy_rb.Text = "11";
            this.tizenegy_rb.UseVisualStyleBackColor = true;
            this.tizenegy_rb.CheckedChanged += new System.EventHandler(this.tizenegy_rb_CheckedChanged);
            // 
            // tiz_rb
            // 
            this.tiz_rb.AutoSize = true;
            this.tiz_rb.Location = new System.Drawing.Point(54, 54);
            this.tiz_rb.Name = "tiz_rb";
            this.tiz_rb.Size = new System.Drawing.Size(37, 17);
            this.tiz_rb.TabIndex = 4;
            this.tiz_rb.TabStop = true;
            this.tiz_rb.Text = "10";
            this.tiz_rb.UseVisualStyleBackColor = true;
            this.tiz_rb.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(206, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fekete_btn);
            this.panel1.Controls.Add(this.kek_btn);
            this.panel1.Controls.Add(this.piros_btn);
            this.panel1.Location = new System.Drawing.Point(549, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 228);
            this.panel1.TabIndex = 3;
            // 
            // fekete_btn
            // 
            this.fekete_btn.AutoSize = true;
            this.fekete_btn.Location = new System.Drawing.Point(77, 162);
            this.fekete_btn.Name = "fekete_btn";
            this.fekete_btn.Size = new System.Drawing.Size(58, 17);
            this.fekete_btn.TabIndex = 2;
            this.fekete_btn.TabStop = true;
            this.fekete_btn.Text = "Fekete";
            this.fekete_btn.UseVisualStyleBackColor = true;
            this.fekete_btn.CheckedChanged += new System.EventHandler(this.radioButton9_CheckedChanged);
            // 
            // kek_btn
            // 
            this.kek_btn.AutoSize = true;
            this.kek_btn.Location = new System.Drawing.Point(77, 103);
            this.kek_btn.Name = "kek_btn";
            this.kek_btn.Size = new System.Drawing.Size(44, 17);
            this.kek_btn.TabIndex = 1;
            this.kek_btn.TabStop = true;
            this.kek_btn.Text = "Kék";
            this.kek_btn.UseVisualStyleBackColor = true;
            this.kek_btn.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // piros_btn
            // 
            this.piros_btn.AutoSize = true;
            this.piros_btn.Location = new System.Drawing.Point(77, 43);
            this.piros_btn.Name = "piros_btn";
            this.piros_btn.Size = new System.Drawing.Size(48, 17);
            this.piros_btn.TabIndex = 0;
            this.piros_btn.TabStop = true;
            this.piros_btn.Text = "Piros";
            this.piros_btn.UseVisualStyleBackColor = true;
            this.piros_btn.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.betumeret_gb);
            this.Controls.Add(this.betustilus_gb);
            this.Controls.Add(this.cimke_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Betűstílus";
            this.betustilus_gb.ResumeLayout(false);
            this.betustilus_gb.PerformLayout();
            this.betumeret_gb.ResumeLayout(false);
            this.betumeret_gb.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cimke_lbl;
        private System.Windows.Forms.GroupBox betustilus_gb;
        private System.Windows.Forms.GroupBox betumeret_gb;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox athuzott_cb;
        private System.Windows.Forms.CheckBox alahuzott_cb;
        private System.Windows.Forms.CheckBox dolt_cb;
        private System.Windows.Forms.CheckBox felkover_cb;
        private System.Windows.Forms.RadioButton tizennyolc_rb;
        private System.Windows.Forms.RadioButton tizenhat_rb;
        private System.Windows.Forms.RadioButton tizennegy_rb;
        private System.Windows.Forms.RadioButton tizenketto_rb;
        private System.Windows.Forms.RadioButton tizenegy_rb;
        private System.Windows.Forms.RadioButton tiz_rb;
        private System.Windows.Forms.RadioButton fekete_btn;
        private System.Windows.Forms.RadioButton kek_btn;
        private System.Windows.Forms.RadioButton piros_btn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}


namespace Pizza_rendeles
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
            this.PizzaTul_gb = new System.Windows.Forms.GroupBox();
            this.PizzaRendeles_btn = new System.Windows.Forms.Button();
            this.FeltetExSajt_cb = new System.Windows.Forms.CheckBox();
            this.FeltetGomba_cb = new System.Windows.Forms.CheckBox();
            this.FeltetOliva_cb = new System.Windows.Forms.CheckBox();
            this.FeltetKukorica_cb = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MeretCsaladi_rbtn = new System.Windows.Forms.RadioButton();
            this.MeretKozepes_rbtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Ar_lbl = new System.Windows.Forms.Label();
            this.RendelesMegt_gb = new System.Windows.Forms.GroupBox();
            this.RMVissza_btn = new System.Windows.Forms.Button();
            this.RMrendeles_btn = new System.Windows.Forms.Button();
            this.RendelesMegtekintes_lbl = new System.Windows.Forms.Label();
            this.FeltetPepperoni_cb = new System.Windows.Forms.CheckBox();
            this.PizzaTul_gb.SuspendLayout();
            this.RendelesMegt_gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // PizzaTul_gb
            // 
            this.PizzaTul_gb.Controls.Add(this.FeltetPepperoni_cb);
            this.PizzaTul_gb.Controls.Add(this.PizzaRendeles_btn);
            this.PizzaTul_gb.Controls.Add(this.FeltetExSajt_cb);
            this.PizzaTul_gb.Controls.Add(this.FeltetGomba_cb);
            this.PizzaTul_gb.Controls.Add(this.FeltetOliva_cb);
            this.PizzaTul_gb.Controls.Add(this.FeltetKukorica_cb);
            this.PizzaTul_gb.Controls.Add(this.label2);
            this.PizzaTul_gb.Controls.Add(this.MeretCsaladi_rbtn);
            this.PizzaTul_gb.Controls.Add(this.MeretKozepes_rbtn);
            this.PizzaTul_gb.Controls.Add(this.label1);
            this.PizzaTul_gb.Location = new System.Drawing.Point(65, 40);
            this.PizzaTul_gb.Name = "PizzaTul_gb";
            this.PizzaTul_gb.Size = new System.Drawing.Size(350, 250);
            this.PizzaTul_gb.TabIndex = 0;
            this.PizzaTul_gb.TabStop = false;
            this.PizzaTul_gb.Text = "Pizza tulajdonságai";
            // 
            // PizzaRendeles_btn
            // 
            this.PizzaRendeles_btn.Location = new System.Drawing.Point(97, 212);
            this.PizzaRendeles_btn.Name = "PizzaRendeles_btn";
            this.PizzaRendeles_btn.Size = new System.Drawing.Size(150, 20);
            this.PizzaRendeles_btn.TabIndex = 8;
            this.PizzaRendeles_btn.Text = "Tovább a rendeléshez";
            this.PizzaRendeles_btn.UseVisualStyleBackColor = true;
            this.PizzaRendeles_btn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PizzaRendeles_btn_MouseClick);
            // 
            // FeltetExSajt_cb
            // 
            this.FeltetExSajt_cb.AutoSize = true;
            this.FeltetExSajt_cb.Location = new System.Drawing.Point(227, 152);
            this.FeltetExSajt_cb.Name = "FeltetExSajt_cb";
            this.FeltetExSajt_cb.Size = new System.Drawing.Size(69, 17);
            this.FeltetExSajt_cb.TabIndex = 7;
            this.FeltetExSajt_cb.Text = "Extra sajt";
            this.FeltetExSajt_cb.UseVisualStyleBackColor = true;
            // 
            // FeltetGomba_cb
            // 
            this.FeltetGomba_cb.AutoSize = true;
            this.FeltetGomba_cb.Location = new System.Drawing.Point(227, 129);
            this.FeltetGomba_cb.Name = "FeltetGomba_cb";
            this.FeltetGomba_cb.Size = new System.Drawing.Size(60, 17);
            this.FeltetGomba_cb.TabIndex = 6;
            this.FeltetGomba_cb.Text = "Gomba";
            this.FeltetGomba_cb.UseVisualStyleBackColor = true;
            // 
            // FeltetOliva_cb
            // 
            this.FeltetOliva_cb.AutoSize = true;
            this.FeltetOliva_cb.Location = new System.Drawing.Point(137, 152);
            this.FeltetOliva_cb.Name = "FeltetOliva_cb";
            this.FeltetOliva_cb.Size = new System.Drawing.Size(79, 17);
            this.FeltetOliva_cb.TabIndex = 5;
            this.FeltetOliva_cb.Text = "Olivabogyó";
            this.FeltetOliva_cb.UseVisualStyleBackColor = true;
            // 
            // FeltetKukorica_cb
            // 
            this.FeltetKukorica_cb.AutoSize = true;
            this.FeltetKukorica_cb.Location = new System.Drawing.Point(137, 129);
            this.FeltetKukorica_cb.Name = "FeltetKukorica_cb";
            this.FeltetKukorica_cb.Size = new System.Drawing.Size(68, 17);
            this.FeltetKukorica_cb.TabIndex = 4;
            this.FeltetKukorica_cb.Text = "Kukorica";
            this.FeltetKukorica_cb.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(33, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Feltétek:";
            // 
            // MeretCsaladi_rbtn
            // 
            this.MeretCsaladi_rbtn.AutoSize = true;
            this.MeretCsaladi_rbtn.Location = new System.Drawing.Point(227, 69);
            this.MeretCsaladi_rbtn.Name = "MeretCsaladi_rbtn";
            this.MeretCsaladi_rbtn.Size = new System.Drawing.Size(59, 17);
            this.MeretCsaladi_rbtn.TabIndex = 2;
            this.MeretCsaladi_rbtn.TabStop = true;
            this.MeretCsaladi_rbtn.Text = "Családi";
            this.MeretCsaladi_rbtn.UseVisualStyleBackColor = true;
            // 
            // MeretKozepes_rbtn
            // 
            this.MeretKozepes_rbtn.AutoSize = true;
            this.MeretKozepes_rbtn.Location = new System.Drawing.Point(137, 69);
            this.MeretKozepes_rbtn.Name = "MeretKozepes_rbtn";
            this.MeretKozepes_rbtn.Size = new System.Drawing.Size(66, 17);
            this.MeretKozepes_rbtn.TabIndex = 1;
            this.MeretKozepes_rbtn.TabStop = true;
            this.MeretKozepes_rbtn.Text = "Közepes";
            this.MeretKozepes_rbtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(33, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Méretek:";
            // 
            // Ar_lbl
            // 
            this.Ar_lbl.AutoSize = true;
            this.Ar_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Ar_lbl.Location = new System.Drawing.Point(32, 26);
            this.Ar_lbl.Name = "Ar_lbl";
            this.Ar_lbl.Size = new System.Drawing.Size(55, 25);
            this.Ar_lbl.TabIndex = 8;
            this.Ar_lbl.Text = "Ára:";
            // 
            // RendelesMegt_gb
            // 
            this.RendelesMegt_gb.Controls.Add(this.RMVissza_btn);
            this.RendelesMegt_gb.Controls.Add(this.RMrendeles_btn);
            this.RendelesMegt_gb.Controls.Add(this.RendelesMegtekintes_lbl);
            this.RendelesMegt_gb.Controls.Add(this.Ar_lbl);
            this.RendelesMegt_gb.Location = new System.Drawing.Point(60, 307);
            this.RendelesMegt_gb.Name = "RendelesMegt_gb";
            this.RendelesMegt_gb.Size = new System.Drawing.Size(350, 130);
            this.RendelesMegt_gb.TabIndex = 9;
            this.RendelesMegt_gb.TabStop = false;
            this.RendelesMegt_gb.Text = "Rendelés részletek";
            this.RendelesMegt_gb.Visible = false;
            // 
            // RMVissza_btn
            // 
            this.RMVissza_btn.Location = new System.Drawing.Point(77, 101);
            this.RMVissza_btn.Name = "RMVissza_btn";
            this.RMVissza_btn.Size = new System.Drawing.Size(75, 23);
            this.RMVissza_btn.TabIndex = 10;
            this.RMVissza_btn.Text = "Vissza";
            this.RMVissza_btn.UseVisualStyleBackColor = true;
            this.RMVissza_btn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RMVissza_btn_MouseClick);
            // 
            // RMrendeles_btn
            // 
            this.RMrendeles_btn.Location = new System.Drawing.Point(194, 101);
            this.RMrendeles_btn.Name = "RMrendeles_btn";
            this.RMrendeles_btn.Size = new System.Drawing.Size(75, 23);
            this.RMrendeles_btn.TabIndex = 9;
            this.RMrendeles_btn.Text = "Rendelés";
            this.RMrendeles_btn.UseVisualStyleBackColor = true;
            this.RMrendeles_btn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RMrendeles_btn_MouseClick);
            // 
            // RendelesMegtekintes_lbl
            // 
            this.RendelesMegtekintes_lbl.AutoSize = true;
            this.RendelesMegtekintes_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RendelesMegtekintes_lbl.Location = new System.Drawing.Point(34, 61);
            this.RendelesMegtekintes_lbl.Name = "RendelesMegtekintes_lbl";
            this.RendelesMegtekintes_lbl.Size = new System.Drawing.Size(160, 17);
            this.RendelesMegtekintes_lbl.TabIndex = 9;
            this.RendelesMegtekintes_lbl.Text = "Rendelés megtekintése:";
            // 
            // FeltetPepperoni_cb
            // 
            this.FeltetPepperoni_cb.AutoSize = true;
            this.FeltetPepperoni_cb.Location = new System.Drawing.Point(176, 175);
            this.FeltetPepperoni_cb.Name = "FeltetPepperoni_cb";
            this.FeltetPepperoni_cb.Size = new System.Drawing.Size(74, 17);
            this.FeltetPepperoni_cb.TabIndex = 9;
            this.FeltetPepperoni_cb.Text = "Pepperoni";
            this.FeltetPepperoni_cb.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.RendelesMegt_gb);
            this.Controls.Add(this.PizzaTul_gb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Pizza rendelés";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PizzaTul_gb.ResumeLayout(false);
            this.PizzaTul_gb.PerformLayout();
            this.RendelesMegt_gb.ResumeLayout(false);
            this.RendelesMegt_gb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PizzaTul_gb;
        private System.Windows.Forms.CheckBox FeltetGomba_cb;
        private System.Windows.Forms.CheckBox FeltetOliva_cb;
        private System.Windows.Forms.CheckBox FeltetKukorica_cb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton MeretCsaladi_rbtn;
        private System.Windows.Forms.RadioButton MeretKozepes_rbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PizzaRendeles_btn;
        private System.Windows.Forms.CheckBox FeltetExSajt_cb;
        private System.Windows.Forms.Label Ar_lbl;
        private System.Windows.Forms.GroupBox RendelesMegt_gb;
        private System.Windows.Forms.Label RendelesMegtekintes_lbl;
        private System.Windows.Forms.Button RMrendeles_btn;
        private System.Windows.Forms.Button RMVissza_btn;
        private System.Windows.Forms.CheckBox FeltetPepperoni_cb;
    }
}


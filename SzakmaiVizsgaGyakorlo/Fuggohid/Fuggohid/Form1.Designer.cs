namespace Fuggohid
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
            this.nevLB = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fajlTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.keresesTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.kilepesTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.helyLbl = new System.Windows.Forms.Label();
            this.orszagLbl = new System.Windows.Forms.Label();
            this.hosszLbl = new System.Windows.Forms.Label();
            this.evLbl = new System.Windows.Forms.Label();
            this.helyTxt = new System.Windows.Forms.TextBox();
            this.orszagTxt = new System.Windows.Forms.TextBox();
            this.hosszTxt = new System.Windows.Forms.TextBox();
            this.evTxt = new System.Windows.Forms.TextBox();
            this.hidSzamGB = new System.Windows.Forms.GroupBox();
            this.darabLbl = new System.Windows.Forms.Label();
            this.darabTxt = new System.Windows.Forms.TextBox();
            this.kettobenRB = new System.Windows.Forms.RadioButton();
            this.kettoElottRB = new System.Windows.Forms.RadioButton();
            this.kilepesBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.hidSzamGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // nevLB
            // 
            this.nevLB.FormattingEnabled = true;
            this.nevLB.Location = new System.Drawing.Point(23, 37);
            this.nevLB.Name = "nevLB";
            this.nevLB.Size = new System.Drawing.Size(218, 212);
            this.nevLB.TabIndex = 0;
            this.nevLB.SelectedIndexChanged += new System.EventHandler(this.nevLB_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fajlTSM,
            this.keresesTSM,
            this.kilepesTSM});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fajlTSM
            // 
            this.fajlTSM.Name = "fajlTSM";
            this.fajlTSM.Size = new System.Drawing.Size(37, 20);
            this.fajlTSM.Text = "Fájl";
            this.fajlTSM.Click += new System.EventHandler(this.fajlTSM_Click);
            // 
            // keresesTSM
            // 
            this.keresesTSM.Name = "keresesTSM";
            this.keresesTSM.Size = new System.Drawing.Size(58, 20);
            this.keresesTSM.Text = "Keresés";
            this.keresesTSM.Click += new System.EventHandler(this.keresesTSM_Click);
            // 
            // kilepesTSM
            // 
            this.kilepesTSM.Name = "kilepesTSM";
            this.kilepesTSM.Size = new System.Drawing.Size(56, 20);
            this.kilepesTSM.Text = "Kilépés";
            // 
            // helyLbl
            // 
            this.helyLbl.AutoSize = true;
            this.helyLbl.Location = new System.Drawing.Point(275, 54);
            this.helyLbl.Name = "helyLbl";
            this.helyLbl.Size = new System.Drawing.Size(28, 13);
            this.helyLbl.TabIndex = 2;
            this.helyLbl.Text = "Hely";
            // 
            // orszagLbl
            // 
            this.orszagLbl.AutoSize = true;
            this.orszagLbl.Location = new System.Drawing.Point(275, 107);
            this.orszagLbl.Name = "orszagLbl";
            this.orszagLbl.Size = new System.Drawing.Size(40, 13);
            this.orszagLbl.TabIndex = 3;
            this.orszagLbl.Text = "Ország";
            // 
            // hosszLbl
            // 
            this.hosszLbl.AutoSize = true;
            this.hosszLbl.Location = new System.Drawing.Point(275, 157);
            this.hosszLbl.Name = "hosszLbl";
            this.hosszLbl.Size = new System.Drawing.Size(36, 13);
            this.hosszLbl.TabIndex = 4;
            this.hosszLbl.Text = "Hossz";
            // 
            // evLbl
            // 
            this.evLbl.AutoSize = true;
            this.evLbl.Location = new System.Drawing.Point(275, 206);
            this.evLbl.Name = "evLbl";
            this.evLbl.Size = new System.Drawing.Size(20, 13);
            this.evLbl.TabIndex = 5;
            this.evLbl.Text = "Év";
            // 
            // helyTxt
            // 
            this.helyTxt.Location = new System.Drawing.Point(328, 54);
            this.helyTxt.Name = "helyTxt";
            this.helyTxt.Size = new System.Drawing.Size(126, 20);
            this.helyTxt.TabIndex = 6;
            // 
            // orszagTxt
            // 
            this.orszagTxt.Location = new System.Drawing.Point(328, 107);
            this.orszagTxt.Name = "orszagTxt";
            this.orszagTxt.Size = new System.Drawing.Size(126, 20);
            this.orszagTxt.TabIndex = 7;
            // 
            // hosszTxt
            // 
            this.hosszTxt.Location = new System.Drawing.Point(328, 157);
            this.hosszTxt.Name = "hosszTxt";
            this.hosszTxt.Size = new System.Drawing.Size(126, 20);
            this.hosszTxt.TabIndex = 8;
            // 
            // evTxt
            // 
            this.evTxt.Location = new System.Drawing.Point(328, 206);
            this.evTxt.Name = "evTxt";
            this.evTxt.Size = new System.Drawing.Size(126, 20);
            this.evTxt.TabIndex = 9;
            // 
            // hidSzamGB
            // 
            this.hidSzamGB.Controls.Add(this.darabLbl);
            this.hidSzamGB.Controls.Add(this.darabTxt);
            this.hidSzamGB.Controls.Add(this.kettobenRB);
            this.hidSzamGB.Controls.Add(this.kettoElottRB);
            this.hidSzamGB.Location = new System.Drawing.Point(23, 289);
            this.hidSzamGB.Name = "hidSzamGB";
            this.hidSzamGB.Size = new System.Drawing.Size(218, 148);
            this.hidSzamGB.TabIndex = 10;
            this.hidSzamGB.TabStop = false;
            this.hidSzamGB.Text = "Hidak száma";
            // 
            // darabLbl
            // 
            this.darabLbl.AutoSize = true;
            this.darabLbl.Location = new System.Drawing.Point(142, 114);
            this.darabLbl.Name = "darabLbl";
            this.darabLbl.Size = new System.Drawing.Size(34, 13);
            this.darabLbl.TabIndex = 11;
            this.darabLbl.Text = "darab";
            // 
            // darabTxt
            // 
            this.darabTxt.Location = new System.Drawing.Point(36, 111);
            this.darabTxt.Name = "darabTxt";
            this.darabTxt.Size = new System.Drawing.Size(100, 20);
            this.darabTxt.TabIndex = 11;
            // 
            // kettobenRB
            // 
            this.kettobenRB.AutoSize = true;
            this.kettobenRB.Location = new System.Drawing.Point(36, 70);
            this.kettobenRB.Name = "kettobenRB";
            this.kettobenRB.Size = new System.Drawing.Size(126, 17);
            this.kettobenRB.TabIndex = 1;
            this.kettobenRB.TabStop = true;
            this.kettobenRB.Text = "2000-ben vagy utána";
            this.kettobenRB.UseVisualStyleBackColor = true;
            this.kettobenRB.CheckedChanged += new System.EventHandler(this.kettobenRB_CheckedChanged);
            // 
            // kettoElottRB
            // 
            this.kettoElottRB.AutoSize = true;
            this.kettoElottRB.Location = new System.Drawing.Point(36, 32);
            this.kettoElottRB.Name = "kettoElottRB";
            this.kettoElottRB.Size = new System.Drawing.Size(98, 17);
            this.kettoElottRB.TabIndex = 0;
            this.kettoElottRB.TabStop = true;
            this.kettoElottRB.Text = "2000 előtt épült";
            this.kettoElottRB.UseVisualStyleBackColor = true;
            this.kettoElottRB.CheckedChanged += new System.EventHandler(this.kettoElottRB_CheckedChanged);
            // 
            // kilepesBtn
            // 
            this.kilepesBtn.Location = new System.Drawing.Point(328, 359);
            this.kilepesBtn.Name = "kilepesBtn";
            this.kilepesBtn.Size = new System.Drawing.Size(75, 23);
            this.kilepesBtn.TabIndex = 11;
            this.kilepesBtn.Text = "Kilépés";
            this.kilepesBtn.UseVisualStyleBackColor = true;
            this.kilepesBtn.Click += new System.EventHandler(this.kilepesBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.kilepesBtn);
            this.Controls.Add(this.hidSzamGB);
            this.Controls.Add(this.evTxt);
            this.Controls.Add(this.hosszTxt);
            this.Controls.Add(this.orszagTxt);
            this.Controls.Add(this.helyTxt);
            this.Controls.Add(this.evLbl);
            this.Controls.Add(this.hosszLbl);
            this.Controls.Add(this.orszagLbl);
            this.Controls.Add(this.helyLbl);
            this.Controls.Add(this.nevLB);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Függőhidak";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.hidSzamGB.ResumeLayout(false);
            this.hidSzamGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox nevLB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fajlTSM;
        private System.Windows.Forms.ToolStripMenuItem keresesTSM;
        private System.Windows.Forms.ToolStripMenuItem kilepesTSM;
        private System.Windows.Forms.Label helyLbl;
        private System.Windows.Forms.Label orszagLbl;
        private System.Windows.Forms.Label hosszLbl;
        private System.Windows.Forms.Label evLbl;
        private System.Windows.Forms.TextBox helyTxt;
        private System.Windows.Forms.TextBox orszagTxt;
        private System.Windows.Forms.TextBox hosszTxt;
        private System.Windows.Forms.TextBox evTxt;
        private System.Windows.Forms.GroupBox hidSzamGB;
        private System.Windows.Forms.Label darabLbl;
        private System.Windows.Forms.TextBox darabTxt;
        private System.Windows.Forms.RadioButton kettobenRB;
        private System.Windows.Forms.RadioButton kettoElottRB;
        private System.Windows.Forms.Button kilepesBtn;
    }
}


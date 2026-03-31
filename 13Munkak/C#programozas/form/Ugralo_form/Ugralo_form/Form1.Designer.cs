namespace Ugralo_form
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
            this.balfelso_btn = new System.Windows.Forms.Button();
            this.jobbfelso_btn = new System.Windows.Forms.Button();
            this.balalso_btn = new System.Windows.Forms.Button();
            this.jobbalso_btn = new System.Windows.Forms.Button();
            this.kozepso_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // balfelso_btn
            // 
            this.balfelso_btn.Location = new System.Drawing.Point(12, 12);
            this.balfelso_btn.Name = "balfelso_btn";
            this.balfelso_btn.Size = new System.Drawing.Size(70, 40);
            this.balfelso_btn.TabIndex = 0;
            this.balfelso_btn.Text = "Bal felső";
            this.balfelso_btn.UseVisualStyleBackColor = true;
            this.balfelso_btn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // jobbfelso_btn
            // 
            this.jobbfelso_btn.Location = new System.Drawing.Point(197, 12);
            this.jobbfelso_btn.Name = "jobbfelso_btn";
            this.jobbfelso_btn.Size = new System.Drawing.Size(70, 40);
            this.jobbfelso_btn.TabIndex = 1;
            this.jobbfelso_btn.Text = "Jobb felső";
            this.jobbfelso_btn.UseVisualStyleBackColor = true;
            this.jobbfelso_btn.Click += new System.EventHandler(this.jobbfelso_btn_Click);
            // 
            // balalso_btn
            // 
            this.balalso_btn.Location = new System.Drawing.Point(12, 209);
            this.balalso_btn.Name = "balalso_btn";
            this.balalso_btn.Size = new System.Drawing.Size(70, 40);
            this.balalso_btn.TabIndex = 2;
            this.balalso_btn.Text = "Bal alsó";
            this.balalso_btn.UseVisualStyleBackColor = true;
            this.balalso_btn.Click += new System.EventHandler(this.balalso_btn_Click);
            // 
            // jobbalso_btn
            // 
            this.jobbalso_btn.Location = new System.Drawing.Point(197, 209);
            this.jobbalso_btn.Name = "jobbalso_btn";
            this.jobbalso_btn.Size = new System.Drawing.Size(70, 40);
            this.jobbalso_btn.TabIndex = 3;
            this.jobbalso_btn.Text = "Jobb alsó";
            this.jobbalso_btn.UseVisualStyleBackColor = true;
            this.jobbalso_btn.Click += new System.EventHandler(this.jobbalso_btn_Click);
            // 
            // kozepso_btn
            // 
            this.kozepso_btn.Location = new System.Drawing.Point(106, 110);
            this.kozepso_btn.Name = "kozepso_btn";
            this.kozepso_btn.Size = new System.Drawing.Size(70, 40);
            this.kozepso_btn.TabIndex = 4;
            this.kozepso_btn.Text = "Középre";
            this.kozepso_btn.UseVisualStyleBackColor = true;
            this.kozepso_btn.Click += new System.EventHandler(this.kozepso_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.kozepso_btn);
            this.Controls.Add(this.jobbalso_btn);
            this.Controls.Add(this.balalso_btn);
            this.Controls.Add(this.jobbfelso_btn);
            this.Controls.Add(this.balfelso_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Ugró ablak";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button balfelso_btn;
        private System.Windows.Forms.Button jobbfelso_btn;
        private System.Windows.Forms.Button balalso_btn;
        private System.Windows.Forms.Button jobbalso_btn;
        private System.Windows.Forms.Button kozepso_btn;
    }
}


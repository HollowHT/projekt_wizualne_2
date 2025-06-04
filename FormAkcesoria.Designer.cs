namespace _23
{
    partial class FormAkcesoria
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
            this.OK = new System.Windows.Forms.Button();
            this.Monitor = new System.Windows.Forms.CheckBox();
            this.Klawiatura = new System.Windows.Forms.CheckBox();
            this.Mysz = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(348, 236);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(100, 40);
            this.OK.TabIndex = 9;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Monitor
            // 
            this.Monitor.AutoSize = true;
            this.Monitor.Location = new System.Drawing.Point(365, 203);
            this.Monitor.Name = "Monitor";
            this.Monitor.Size = new System.Drawing.Size(61, 17);
            this.Monitor.TabIndex = 7;
            this.Monitor.Text = "Monitor";
            this.Monitor.UseVisualStyleBackColor = true;
            // 
            // Klawiatura
            // 
            this.Klawiatura.AutoSize = true;
            this.Klawiatura.Location = new System.Drawing.Point(365, 169);
            this.Klawiatura.Name = "Klawiatura";
            this.Klawiatura.Size = new System.Drawing.Size(75, 17);
            this.Klawiatura.TabIndex = 6;
            this.Klawiatura.Text = "Klawiatura";
            this.Klawiatura.UseVisualStyleBackColor = true;
            // 
            // Mysz
            // 
            this.Mysz.AutoSize = true;
            this.Mysz.Location = new System.Drawing.Point(365, 130);
            this.Mysz.Name = "Mysz";
            this.Mysz.Size = new System.Drawing.Size(50, 17);
            this.Mysz.TabIndex = 5;
            this.Mysz.Text = "Mysz";
            this.Mysz.UseVisualStyleBackColor = true;
            // 
            // FormAkcesoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Monitor);
            this.Controls.Add(this.Klawiatura);
            this.Controls.Add(this.Mysz);
            this.Name = "FormAkcesoria";
            this.Text = "FormAkcesoria";
            this.Load += new System.EventHandler(this.FormAkcesoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.CheckBox Monitor;
        private System.Windows.Forms.CheckBox Klawiatura;
        private System.Windows.Forms.CheckBox Mysz;
    }
}
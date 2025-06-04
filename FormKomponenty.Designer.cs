namespace _23
{
    partial class FormKomponenty
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
            this.Ram = new System.Windows.Forms.CheckBox();
            this.GPU = new System.Windows.Forms.CheckBox();
            this.CPU = new System.Windows.Forms.CheckBox();
            this.PlytaGlowna = new System.Windows.Forms.CheckBox();
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ram
            // 
            this.Ram.AutoSize = true;
            this.Ram.Location = new System.Drawing.Point(420, 142);
            this.Ram.Name = "Ram";
            this.Ram.Size = new System.Drawing.Size(48, 17);
            this.Ram.TabIndex = 0;
            this.Ram.Text = "Ram";
            this.Ram.UseVisualStyleBackColor = true;
            this.Ram.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // GPU
            // 
            this.GPU.AutoSize = true;
            this.GPU.Location = new System.Drawing.Point(420, 181);
            this.GPU.Name = "GPU";
            this.GPU.Size = new System.Drawing.Size(49, 17);
            this.GPU.TabIndex = 1;
            this.GPU.Text = "GPU";
            this.GPU.UseVisualStyleBackColor = true;
            // 
            // CPU
            // 
            this.CPU.AutoSize = true;
            this.CPU.Location = new System.Drawing.Point(420, 215);
            this.CPU.Name = "CPU";
            this.CPU.Size = new System.Drawing.Size(48, 17);
            this.CPU.TabIndex = 2;
            this.CPU.Text = "CPU";
            this.CPU.UseVisualStyleBackColor = true;
            this.CPU.CheckedChanged += new System.EventHandler(this.CPU_CheckedChanged);
            // 
            // PlytaGlowna
            // 
            this.PlytaGlowna.AutoSize = true;
            this.PlytaGlowna.Location = new System.Drawing.Point(420, 254);
            this.PlytaGlowna.Name = "PlytaGlowna";
            this.PlytaGlowna.Size = new System.Drawing.Size(85, 17);
            this.PlytaGlowna.TabIndex = 3;
            this.PlytaGlowna.Text = "PlytaGlowna";
            this.PlytaGlowna.UseVisualStyleBackColor = true;
            this.PlytaGlowna.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(405, 293);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(100, 40);
            this.OK.TabIndex = 4;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // FormKomponenty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.PlytaGlowna);
            this.Controls.Add(this.CPU);
            this.Controls.Add(this.GPU);
            this.Controls.Add(this.Ram);
            this.Name = "FormKomponenty";
            this.Text = "FormKomponenty";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Ram;
        private System.Windows.Forms.CheckBox GPU;
        private System.Windows.Forms.CheckBox CPU;
        private System.Windows.Forms.CheckBox PlytaGlowna;
        private System.Windows.Forms.Button OK;
    }
}
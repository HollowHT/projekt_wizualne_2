namespace _23
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOblicz = new System.Windows.Forms.Button();
            this.btnAkcesoria = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKomponenty = new System.Windows.Forms.Button();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOblicz
            // 
            this.btnOblicz.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnOblicz.Location = new System.Drawing.Point(322, 241);
            this.btnOblicz.Name = "btnOblicz";
            this.btnOblicz.Size = new System.Drawing.Size(120, 50);
            this.btnOblicz.TabIndex = 0;
            this.btnOblicz.Text = "Cena";
            this.btnOblicz.UseVisualStyleBackColor = true;
            this.btnOblicz.Click += new System.EventHandler(this.btnOblicz_Click);
            // 
            // btnAkcesoria
            // 
            this.btnAkcesoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnAkcesoria.Location = new System.Drawing.Point(416, 130);
            this.btnAkcesoria.Name = "btnAkcesoria";
            this.btnAkcesoria.Size = new System.Drawing.Size(129, 58);
            this.btnAkcesoria.TabIndex = 2;
            this.btnAkcesoria.Text = " Akcesoria";
            this.btnAkcesoria.UseVisualStyleBackColor = true;
            this.btnAkcesoria.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(335, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "CENA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnKomponenty
            // 
            this.btnKomponenty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnKomponenty.Location = new System.Drawing.Point(217, 129);
            this.btnKomponenty.Name = "btnKomponenty";
            this.btnKomponenty.Size = new System.Drawing.Size(129, 59);
            this.btnKomponenty.TabIndex = 4;
            this.btnKomponenty.Text = "Komponenty";
            this.btnKomponenty.UseVisualStyleBackColor = true;
            this.btnKomponenty.Click += new System.EventHandler(this.btnKomponenty_Click);
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(302, 342);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(176, 20);
            this.txtCena.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.btnKomponenty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAkcesoria);
            this.Controls.Add(this.btnOblicz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOblicz;
        private System.Windows.Forms.Button btnAkcesoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKomponenty;
        private System.Windows.Forms.TextBox txtCena;
    }
}


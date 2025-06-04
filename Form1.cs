using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAkcesoria formAks = new FormAkcesoria();
            if (formAks.ShowDialog() == DialogResult.OK)
            {
                cenaDod = formAks.CenaDod;
            }
        }
        decimal cenaKomponentow = 0;
        decimal cenaDod = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnKomponenty_Click(object sender, EventArgs e)
        {
            FormKomponenty formKomp = new FormKomponenty();
            if (formKomp.ShowDialog() == DialogResult.OK)
            {
                cenaKomponentow = formKomp.CenaKomponentow;
            }
        }

        private void btnOblicz_Click(object sender, EventArgs e)
        {
            decimal suma = cenaKomponentow + cenaDod;
            txtCena.Text = suma.ToString("C");
        }
    }
}

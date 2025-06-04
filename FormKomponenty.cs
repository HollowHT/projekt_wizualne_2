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
    public partial class FormKomponenty : Form
    {
        public FormKomponenty()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }
        public decimal CenaKomponentow { get; private set; }

        private void OK_Click(object sender, EventArgs e)
        {
            CenaKomponentow = 0;
            if (CPU.Checked) CenaKomponentow += 1000;
            if (Ram.Checked) CenaKomponentow += 400;
            if (GPU.Checked) CenaKomponentow += 4000;
            if (PlytaGlowna.Checked) CenaKomponentow += 850;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CPU_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

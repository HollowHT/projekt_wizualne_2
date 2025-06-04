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
    public partial class FormAkcesoria : Form
    {
        public FormAkcesoria()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        public decimal CenaDod { get; private set; }
        private void FormAkcesoria_Load(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {
            CenaDod = 0;
            if (Mysz.Checked) CenaDod += 100;
            if (Klawiatura.Checked) CenaDod += 80;
            if (Monitor.Checked) CenaDod += 1200;
           

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

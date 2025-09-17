using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPlayer2.Checked)
            {
                textBoxPlayer2.Enabled = true;
                textBoxPlayer2.Text = "Input Name";
            }
            else
            {
                textBoxPlayer2.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            var settings = new GameSettings
            {
                Player1Name = txtPlayer1.Text.Trim(),
                Player2Name = (rdoVsComputer.Checked ? "Computer" : txtPlayer2.Text.Trim()),
                VsComputer = rdoVsComputer.Checked,
                Rows = (int)nudRows.Value,
                Cols = (int)nudCols.Value
            };

            this.Tag = settings;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

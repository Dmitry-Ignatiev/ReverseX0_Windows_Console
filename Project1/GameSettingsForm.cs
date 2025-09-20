using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameForm
{
    public partial class GameSettingsForm : Form
    {
        Label m_labelPlayer1;
        Label m_labelPlayer2;
        TextBox m_textBoxPlayer1;
        TextBox m_textBoxPlayer2;
        CheckBox m_checkBoxPlayer2;
        RadioButton m_radioButtonVsComputer;
        Label m_labelRows;
        Label m_labelCols;
        NumericUpDown m_numericUpDownRows;
        NumericUpDown m_numericUpDownCols;
        Button m_buttonPlay;
        int i_rows;
        int i_cols;
        string Player1Name;
        string Player2Name;
        const int MIN_VALUE = 4;
        const int MAX_VALUE = 10;
        private GameSettings m_Settings { get; set; }
        public GameSettingsForm()
        {
            InitializeComponents();     
        }

        private void InitializeComponents()
        {
            this.i_rows = (int)numRows.Value;
            this.i_cols = (int)numCols.Value;
            this.Text = "Game Settings";

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
            this.Player1Name = m_textBoxPlayer1.Text.Trim();

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            this.i_rows = (int)numRows.Value;
        }
        private void numCols_ValueChanged(object sender, EventArgs e)
        {
            if ((int)numCols.Value<)
            this.i_cols = (int)numCols.Value;
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            var Settings = new GameSettings
            {
                Player1Name = m_textBoxPlayer1.Text.Trim(),
                Player2Name = checkBoxPlayer2.Checked ? m_textBoxPlayer2.Text.Trim() : "Computer",
                VsComputer = checkBoxPlayer2.Checked,
                Rows = (int)numRows.Value,
                Cols = (int)numCols.Value
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private void GameSettingsForm_Load(object sender, EventArgs e)
        {

        }

        private void textBoxPlayer2_TextChanged(object sender, EventArgs e)
        {
            if (checkBoxPlayer2.Checked)
            {
                this.Player2Name = m_textBoxPlayer2.Text.Trim();
            }
        }
    }

  
}

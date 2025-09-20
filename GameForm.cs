using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameForm;

namespace GameForm
{
    public partial class GameForm : Form
    {
        private int defaultRows = 4, defaultCcols = 7; // defaults for Designer
        private Button[,] _buttons;
        private int rows;
        private int cols;
        public GameForm()
        {
            Board game=new Board();

            if (GameSettingsForm.NumRows > 0) _rows = GameSettingsForm.m_rows;












            InitializeComponent();
        }

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {


        }
        private void AddButton(string text, int x, int y)
        {
            Button btn = new Button();
            btn.Text = text;
            btn.Size = new Size(100, 30);
            btn.Location = new Point(x, y);

            btn.Click += (s, e) =>
            {
                MessageBox.Show($"You clicked {btn.Text}");
            };

            this.Controls.Add(btn);
        }
        private void GameForm_Load(object sender, EventArgs e)
        {
            
            


            tableBoard.Controls.Clear();
            tableBoard.RowStyles.Clear();
            tableBoard.ColumnStyles.Clear();

            tableBoard.RowCount = rows;
            tableBoard.ColumnCount = cols;

        }
        private void Cell_Click(object sender, EventArgs e)
        {
            
            Button btn = sender as Button;
            if (btn != null)
            {
                if (btn.Text == "")
                    btn.Text = "X";
                else if (btn.Text == "X")
                    btn.Text = "O";
                else
                    btn.Text = "";
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

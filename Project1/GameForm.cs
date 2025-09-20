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
            
            if (GameSettingsForm.i_rows>defaultRows&& GameSettingsForm.Cols>defaultCols)
            {
                rows = GameSettingsForm.I;
                cols = GameSettingsForm.i_cols;
            }
            else
            {
                rows = defaultRows;
                cols = defaultCcols;
            }












            InitializeComponent();
        }

        private void InitializeComponent()
        {
           
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
            GameForm.SuspendLayout();

            GameForm.Controls.Clear();
            GameForm.RowStyles.Clear();
            GameForm.ColumnStyles.Clear();

            GameForm.RowCount = rows;
            GameForm.ColumnCount = cols;

        }

        private void GameForm_Load_1(object sender, EventArgs e)
        {

        }

        private void GameForm_Load_2(object sender, EventArgs e)
        {

        }

        private void GameForm_Load_3(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

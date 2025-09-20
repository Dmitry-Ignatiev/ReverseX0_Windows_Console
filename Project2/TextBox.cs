using System;
using System.Drawing;
using System.Windows.Forms;

namespace SomeClass  // better: give namespace a distinct name
{
    class TextBoxProgram : Form
    {
        public TextBoxProgram()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // TextBoxProgram
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "TextBoxProgram";
            this.Load += new System.EventHandler(this.TextBoxProgram_Load);
            this.ResumeLayout(false);
        }

        private void TextBoxProgram_Load(object sender, EventArgs e)
        {
            // put code to run when the form loads
        }
    }

    class FormPink : Form
    {
        TextBox m_TextBoxStart;

        public FormPink()
        {
            this.Text = "Pink Form";
            this.Size = new Size(300, 200);
            this.Location = new Point(100, 100);
            this.BackColor = Color.Pink;

            m_TextBoxStart = new TextBox();
            m_TextBoxStart.Text = "Start";
            m_TextBoxStart.BackColor = Color.Pink;
            m_TextBoxStart.Size = new Size(300, 200);
            m_TextBoxStart.Location = new Point(0, 0);
            m_TextBoxStart.Click += new EventHandler(m_TextBoxStart_Click);
            this.Controls.Add(m_TextBoxStart);

            this.LocationChanged += this_LocationChanged;
            this.SizeChanged += this_SizeChanged;
        }

        void m_TextBoxStart_Click(object sender, EventArgs e)
        {
            CreateRandomTextBox();
        }

        private void CreateRandomTextBox()
        {
            TextBox textBox = new TextBox();
            textBox.BackColor = Color.Pink;
            textBox.Width = 100;
            int location = new Random().Next(0, this.ClientSize.Width - textBox.Width);
            textBox.Left = location;
            textBox.Top = location;
            textBox.Click += new EventHandler(m_TextBoxStart_Click);
            this.Controls.Add(textBox);
        }

        void this_LocationChanged(object sender, EventArgs e)
        {
            this.Text = $"Location: {this.Location.X}, {this.Location.Y}";
        }

        void this_SizeChanged(object sender, EventArgs e)
        {
            this.Text = this.Size.ToString();
        }
    }
}

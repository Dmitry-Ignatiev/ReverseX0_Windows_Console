using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using System.Drawing;


class TextBoxProgram
{
    static void Main() { }
    FormPink formPink = new FormPink();
    formPink.ShowDialog();
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
        this.ClientSize = new Size(300, 200);
        this.LocationChanged += this_LocationChanged;
        this.SizeChanged += this_SizeChanged;

        m_TextBoxStart = new TextBox();
        m_TextBoxStart.Text = "Start";
        m_TextBoxStart.BackColor = Color.Pink;
        m_TextBoxStart.Size = new Size(300, 200);
        m_TextBoxStart.Location = new Point(0, 0);
        m_TextBoxStart.Click += new EventHandler(m_TextBoxStart_Click);
        this.Controls.Add(m_TextBoxStart);
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
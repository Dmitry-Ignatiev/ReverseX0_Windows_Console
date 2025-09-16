using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Button.cs;

namespace formsBuilder { 
class Program
{
    static void Main() 
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new FormPink());
    }
}
}

public class FormPink : Form
{
    PictureBox m_PictureBoxStart;

    public FormPink()
    {
        this.Text = "Pink Form";
        this.Size = new Size(300, 200);
        this.Location = new Point(100, 100);
        this.BackColor = Color.Pink;
        this.ClientSize = new Size(300, 200);
        this.LocationChanged += this_LocationChanged;
        this.SizeChanged += this_SizeChanged;

        m_PictureBoxStart = new PictureBox();
        m_PictureBoxStart.BackColor = Color.Pink;
        m_PictureBoxStart.Size = new Size(100, 100);
        m_PictureBoxStart.Location = new Point(100, 50);
        m_PictureBoxStart.Click += new EventHandler(m_PictureBoxStart_Click);
        this.Controls.Add(m_PictureBoxStart);
    }

    void m_PictureBoxStart_Click(object sender, EventArgs e )
    {
        CreateRandomPictureBox();
    }

    private void CreateRandomPictureBox()
    {
        PictureBox pictureBox = new PictureBox();
        pictureBox.BackColor = Color.Pink;
        pictureBox.Size = new Size(100, 100);
        int location = new Random().Next(0, this.ClientSize.Width - pictureBox.Width);
        pictureBox.Left = location;
        pictureBox.Top = location;
        pictureBox.Click += new EventHandler(m_PictureBoxStart_Click);
        this.Controls.Add(pictureBox);
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
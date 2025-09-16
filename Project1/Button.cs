using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using System.Drawing;


class Program {
    static void Main() { }
    FormPink formPink = new FormPink();
    formPink.ShowDialog();
}
}
class FormPink : Form {
    Button m_ButtonStart;
    
    public FormPink() {
        this.Text = "Pink Form";
        this.Size=new Size(300, 200);
        this.Location=new Loca
        this.BackColor = Color.Pink;
        this.ClientSize = new Size(300, 200);
        this.LocationChanged += this_LocationChanged;   
        this.SizeChanged+= this_SizeChanged(this_SizeChanged);


        m_ButtonStart = new Button();
        m_ButtonStart.Text = "Start";
        
        m_ButtonStart.BackColor = Color.Pink;
        m_ButtonStart.ClientSize = new Size(300, 200);
        m_ButtonStart.LocationChanged += this_LocationChanged;
        m_ButtonStart.SizeChanged += this_SizeChanged(this_SizeChanged);
        m_ButtonStart.Click = new EventHandler(m_ButtonStart_Click);
        this.Controls.Add(m_ButtonStart);

    }

    void m_ButtonStart_Click(object sender, EventArgs e) {
        CreadterRandomButton();
    }
    private void CreadterRandomButton() 
    { 
    Button button = new Button();
    button.BackColor = Color.Pink;
    button.width = 100; 
    int location=new Random().Next(0, this.ClientSize.Width - button.Width);
        button.left = location;
        button.top = location;
        button.Click += new EventHandler(m_ButtonStart_Click);
        this.Controls.Add(button);

    }
    void button_Click(object sender, EventArgs e)
    {
        Button theSender = sender as Button;
        theSender.Left += 10;
        theSender.Click-=button_Click;
        theSender.Click+=new EventHandler(button_Click);
    }
    void m_ButtonStart_Click(object sender, EventArgs e)
    {
        this.Left+=10;
    }
    public override void ShowDialog() {
        m_ButtonStart.Show();
        base.ShowDialog();
    }
    void this_LocationChanged(object sender, EventArgs e) {
        this.Text = $"Location: {this.Location.X}, {this.Location.Y}";
    }
    void this_SizeChanged(object sender, EventArgs e) {
        this.Text =this.Size.ToString();
    }
}
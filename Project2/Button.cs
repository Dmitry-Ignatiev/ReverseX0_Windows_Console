using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormsBuilder
{
    static class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPink());
        }
    }

    public class FormPink : Form
    {
        private Button _buttonStart;
        private readonly Random _rnd = new Random();

        public FormPink()
        {
            Text = "Pink Form";
            Size = new Size(300, 200);
            Location = new Point(100, 100);
            BackColor = Color.Pink;

            LocationChanged += Form_LocationChanged;
            SizeChanged += Form_SizeChanged;

            _buttonStart = new Button
            {
                Text = "Start",
                BackColor = Color.LightPink,
                Size = new Size(120, 40),
                Location = new Point(10, 10)
            };
            _buttonStart.Click += StartButton_Click;
            Controls.Add(_buttonStart);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            CreateRandomButton();
        }

        private void CreateRandomButton()
        {
            var btn = new Button
            {
                BackColor = Color.MistyRose,
                Width = 100,
                Height = 30
            };

            btn.Left = _rnd.Next(0, Math.Max(1, ClientSize.Width - btn.Width));
            btn.Top = _rnd.Next(0, Math.Max(1, ClientSize.Height - btn.Height));

            btn.Click += RandomButton_Click;
            Controls.Add(btn);
        }

        private void RandomButton_Click(object sender, EventArgs e)
        {
            if (sender is Button b)
            {
                b.Left = Math.Min(ClientSize.Width - b.Width, b.Left + 10);
            }
        }

        private void Form_LocationChanged(object sender, EventArgs e)
        {
            Text = $"Location: {Location.X}, {Location.Y}";
        }

        private void Form_SizeChanged(object sender, EventArgs e)
        {
            Text = Size.ToString();
        }
    }
}

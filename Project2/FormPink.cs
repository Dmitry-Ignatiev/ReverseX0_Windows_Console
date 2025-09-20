using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormsBuilder
{
    public partial class FormPink : Form
    {
        private readonly Random _rnd = new Random();
        private PictureBox _start;

        public FormPink()
        {
            InitializeComponent();   // <-- keep this call here

            _start = new PictureBox
            {
                BackColor = Color.HotPink,
                Size = new Size(100, 100),
                Location = new Point(100, 50),
                Cursor = Cursors.Hand
            };
            _start.Click += Start_Click;
            Controls.Add(_start);

            LocationChanged += (s, e) => Text = $"Location: {Location.X}, {Location.Y}";
            SizeChanged += (s, e) => Text = Size.ToString();
        }

        private void Start_Click(object sender, EventArgs e) => CreateRandomPictureBox();

        private void CreateRandomPictureBox()
        {
            var pb = new PictureBox
            {
                BackColor = Color.MistyRose,
                Size = new Size(100, 100)
            };

            pb.Left = _rnd.Next(0, Math.Max(1, ClientSize.Width - pb.Width));
            pb.Top = _rnd.Next(0, Math.Max(1, ClientSize.Height - pb.Height));

            pb.Click += Start_Click;
            Controls.Add(pb);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextBox.cs;
namespace SomeClass
{

    class SomeClass:Form
    {
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button1;

        public SomeClass()
        {
            this.Text = "SomeClass Form";
            initializeComponent();
        }

        private void initializeComponent()
        {
            throw new NotImplementedException();
        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(149, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 65);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(22, 94);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 65);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(149, 94);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 65);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // SomeClass
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "SomeClass";
            this.Load += new System.EventHandler(this.SomeClass_Load);
            this.ResumeLayout(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SomeClass_Load(object sender, EventArgs e)
        {

        }
    }
  
}

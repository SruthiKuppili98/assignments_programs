using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCSharpHelloWorld
{
    public partial class HelloWorld : Form
    {
        public HelloWorld()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b.Text = "click me";
            b.Size = new Size(100, 50);
            b.Location = new Point(200, 250);
            this.Controls.Add(b);
            b.Click += new EventHandler(button1_Click1);

          
        }
        private void button1_Click1(object sender1, EventArgs e1)
        {
            MessageBox.Show("HelloWorld");
        }

    }
}
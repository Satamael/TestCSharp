using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public void CreateAnswer(String Text, int x, int y)
        {
            Label l1 = new Label();
            l1.Text = Text;
            l1.Left = x;
            l1.Top = y;
            l1.Width = 100;
            l1.Height = 100;
            this.Controls.Add(l1);
        }

        public Form1()
        {
            InitializeComponent();
            CreateAnswer("sdfsfd", 100, 300);
            CreateAnswer("sdfsfd2", 200, 400);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

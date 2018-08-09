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
    public struct Question
    {
        public int answers;
        public string text;
        public int x;
        public int y;
        public int Width;
        public int Height;
    };

    public struct SumPoints
    {
        int Horse;
        int Legs;
        int Fly;
    };

    public struct Answer
    {
        public Button b1;
        public int x;
        public int y;
        public int Width;
        public int Height;
        public string text;
        public string picture;
        public int pointHorse;
        public int pointLegs;
        public int pointFly;

        public Answer(int _x, int _y, int _Width, int _Height, String _text, String _picture, 
            int _pointHorse, int _pointLegs, int _pointFly)
        {
            b1 = new Button();
            x = _x;
            y = _y;
            Width = _Width;
            Height = _Height;
            text = _text;
            picture = _picture;
            pointHorse = _pointHorse;
            pointLegs = _pointLegs;
            pointFly = _pointFly;
        }
    };

    public partial class Form1 : Form
    {
        Answer ans1;
        Answer ans2;
        List<Answer> ans = new List<Answer>();

        private Button button1;
        private Label labelQustion;

        public void CreateAnswer(ref Answer ans, SumPoints sum)
        {
            ans.b1 = new Button();
            ans.b1.Text = ans.text;
            ans.b1.Left = ans.x;
            ans.b1.Top = ans.y;
            ans.b1.Width = ans.Width;
            ans.b1.Height = ans.Height;
            ans.b1.Click += new System.EventHandler(this.button2_Click);
            this.Controls.Add(ans.b1);
            /*sum.Horse = sum.Horse + once.pointHorse;
            sum.Legs = sum.Legs + once.pointLegs;
            sum.Fly = sum.Fly + once.pointFly; 
            */
        }

        public void CreateQuestion(Question once)
        {
            Label l1 = new Label();
            l1.Text = once.text;
            l1.Left = once.x;
            l1.Top = once.y;
            l1.Width = once.Width;
            l1.Height = once.Height;
            this.Controls.Add(l1);
            
        }

        public Form1()
        {
            ans1 = new Answer (100, 30,100,100,"Всадник (СЛ)", "pics\\horses\\h1.jpg", 1, 2, 3);
            ans2 = new Answer(600, 30, 100, 100, "Гимли (ВК)", "pics\\legs\\l1.jpg", 1, 2, 3);
            SumPoints sum = new SumPoints();

            CreateAnswer(ref ans1, sum);
            CreateAnswer(ref ans2, sum);

            ans.Add(ans1);
            ans.Add(ans2);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            /*if (sender.Equals(ans1.b1))
            {
                MessageBox.Show(ans1.b1.Text);
            }
            if (sender.Equals(ans2.b1))
            {
                MessageBox.Show(ans2.b1.Text);
            }*/

            for (int nomer = 0; nomer < ans.Count; nomer++)
            {
                if (sender.Equals(ans[nomer].b1))
                {
                    MessageBox.Show(ans[nomer].b1.Text);
                    //SumPoints.fly += ans[nomer].pointFly;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1");
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

    }
}

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
        public Label l1;
        public int answers;
        public string text;
        public int x;
        public int y;
        public int Width;
        public int Height;

        public Question(int _answers, string _text, int _x, int _y, int _Width, int _Height){
            l1 = new Label();
            answers = _answers;
            text = _text;
            x = _x;
            y = _y;
            Width = _Width;
            Height = _Height;

}
    };

    public struct SumPoints
    {
        public int Horse;
        public int Legs;
        public int Fly;
        public int Pirat;

        public SumPoints(int _Horse, int _Legs, int _Fly, int _Pirat)
        {
            Horse = _Horse;
            Legs = _Legs;
            Fly = _Fly;
            Pirat = _Pirat;
        }
    };

    public struct Answer
    {
        public PictureBox p1;
        public Button b1;
        public int x;
        public int y;
        public int Width;
        public int Height;
        public int picx;
        public int picy;
        public int picWidth;
        public int picHeight;
        public string text;
        public string picture;
        public int pointHorse;
        public int pointLegs;
        public int pointFly;
        public int pointPirat;

        public Answer(int _x, int _y, int _Width, int _Height, int _picx, int _picy, int _picWidth, int _picHeight, String _text, String _picture, 
            int _pointHorse, int _pointLegs, int _pointFly, int _pointPirat)
        {
            p1 = new PictureBox();
            b1 = new Button();
            x = _x;
            y = _y;
            Width = _Width;
            Height = _Height;
            picx = _picx;
            picy = _picy;
            picWidth = _picWidth;
            picHeight = _picHeight;
            text = _text;
            picture = _picture;
            pointHorse = _pointHorse;
            pointLegs = _pointLegs;
            pointFly = _pointFly;
            pointPirat = _pointPirat;
        }
    };

    public partial class Form1 : Form
    {
        SumPoints sum;
        Answer ans1;
        Answer ans2;
        Answer ans3;
        Answer ans4;
        Question quest1;
        List<Answer> ans = new List<Answer>();
        List<Question> quest = new List<Question>();

        private Button button1;
        private Label labelQustion;

        public void CreateAnswer(ref Answer ans)
        {
            ans.b1 = new Button();
            ans.b1.Text = ans.text;
            ans.b1.Left = ans.x;
            ans.b1.Top = ans.y;
            ans.b1.Width = ans.Width;
            ans.b1.Height = ans.Height;
            ans.b1.Click += new System.EventHandler(this.button2_Click);
            this.Controls.Add(ans.b1);

            ans.p1 = new PictureBox();
            ans.p1.Left = ans.picx;
            ans.p1.Top = ans.picy;
            ans.p1.Width = ans.picWidth;
            ans.p1.Height = ans.picHeight;
            ans.p1.Image = Image.FromFile(ans.picture);
            this.Controls.Add(ans.p1);
            /*sum.Horse = sum.Horse + once.pointHorse;
            sum.Legs = sum.Legs + once.pointLegs;
            sum.Fly = sum.Fly + once.pointFly; 
            */
        }

        public void CreateQuestion(ref Question once)
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
            this.Width = 600;
            this.Height = 600;
            this.BackgroundImage = ..\\..\\pics\\backgraund.jpg
            sum = new SumPoints(0, 0, 0, 0);
            quest1 = new Question(4, "кто круче?", 120, 20, 400, 60);
            ans1 = new Answer (40, 400,120,80,40,240,120,120,"Всадник (СЛ)", "..\\..\\pics\\horses\\h1.jpg", 1, 0, 0, 0);
            ans2 = new Answer(180, 400, 120, 80,180, 240, 120, 120, "Гимли (ВК)", "..\\..\\pics\\legs\\l1.jpg", 0, 1, 0, 0);
            ans3 = new Answer(320, 400, 120, 80,320, 240, 120, 120, "Гальбаторикс (Эр)", "..\\..\\pics\\fly\\f1.jpg", 0, 0, 1, 0);
            ans4 = new Answer(460, 400, 120, 80,460, 240, 120, 120, "Кристин Ван Дер Вельде (Эт)", "..\\..\\pics\\pirats\\p1.jpg", 0, 0, 0, 1);
            
         
            CreateQuestion(ref quest1);
            CreateAnswer(ref ans1);
            CreateAnswer(ref ans2);
            CreateAnswer(ref ans3);
            CreateAnswer(ref ans4);

            ans.Add(ans1);
            ans.Add(ans2);
            ans.Add(ans3);
            ans.Add(ans4);
            quest.Add(quest1);
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
            MessageBox.Show("Э, ты дурак? тыкать надо ниже!");
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
            this.ClientSize = new System.Drawing.Size(582, 555);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_2);
            this.ResumeLayout(false);

        }

        private void Form1_Load_2(object sender, EventArgs e)
        {

        }
    }
}

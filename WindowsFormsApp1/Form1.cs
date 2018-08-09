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
        public Question(int _answers, string _text){
        answers = _answers;
            text = _text;
    }
}
    public struct SumPoints
    {
        public int Horse;
        public int Legs;
        public int Fly;

        public SumPoints(int _Horse, int _Legs, int _Fly)
        {
            Horse = _Horse;
            Legs = _Legs;
            Fly = _Fly;
        }
}
public struct Answer
    {
    public int x;
    public int y;
    public int Width;
    public int Height;
    public string text;
    public string picture;
    public int pointHorse;
    public int pointLegs;
    public int pointFly;

        public Answer(int _x, int _y, int _Width, int _Height, string _text, string _picture, int _pointHorse, int _pointLegs, int _pointFly)
        {
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
    }
    public partial class Form1 : Form
    {
        private Label labelQustion;

        public void CreateAnswer(Answer ans, SumPoints sum)
        {
            Button b1 = new Button();
            b1.Text = ans.text;
            b1.Left = ans.x;
            b1.Top = ans.y;
            b1.Width = ans.Width;
            b1.Height = ans.Height;
            this.Controls.Add(b1);
            /*sum.Horse = sum.Horse + once.pointHorse;
            sum.Legs = sum.Legs + once.pointLegs;
            sum.Fly = sum.Fly + once.pointFly; 
            */
        }

        public void CreateQuestion(Question once)
        {
            Label l1 = new Label();
            l1.Text = once.text;
            l1.Left = 100;
            l1.Top = 500;
            l1.Width = 100;
            l1.Height = 100;
            this.Controls.Add(l1);
            
        }

        public Form1()
        {
            Answer ans1 = new Answer (100, 30,100,100,"Всадник (СЛ)", "pics\\horses\\h1.jpg",1,2,3);
            Answer ans2 = new Answer (100, 30,100,100,"Гимли (ВК)", "pics\\legs\\l1.jpg",3,2,1);
            SumPoints sum = new SumPoints();
            CreateAnswer(ans1, sum);
            CreateAnswer(ans2, sum);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

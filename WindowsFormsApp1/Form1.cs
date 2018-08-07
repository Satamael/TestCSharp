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
        int answers;
        string Text;
    }
    public struct SumPoints
    {
        int Horse;
        int Legs;
        int Fly;
    }
    public struct Answer
    {
        int x;
        int y;
        int Width;
        int Height;
        string text;
        string picture;
        int pointHorse;
        int pointLegs;
        int pointFly;

        public Answer(_x, _y, _Width, _Height, _text, _picture, _pointHorse, _pointLegs, pointFly)
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
            l1 = new Label();
            l1.Text = once.text;
            l1.Left = once.x;
            l1.Top = once.y;
            l1.Width = once.Width;
            l1.Height = once.Height;
            this.Controls.Add(l1);
            
        }

        public Form1()
        {
            Answer ans1 = new Answer (100, 30,100,100,"Всадник (СЛ)", "C:\Users\demid\source\repos\WindowsFormsApp1\pics\horses\h1.jpg"};
            Answer ans2 = new Answer ( 100, 30,100,100,"Гимли (ВК)", "C:\Users\demid\source\repos\WindowsFormsApp1\pics\legs\l1.jpg"};
            InitializeComponent();
            CreateAnswer(ans1);
            CreateAnswer(ans2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.labelQustion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelQustion
            // 
            this.labelQustion.AutoSize = true;
            this.labelQustion.Location = new System.Drawing.Point(93, 9);
            this.labelQustion.Name = "labelQustion";
            this.labelQustion.Size = new System.Drawing.Size(178, 17);
            this.labelQustion.TabIndex = 0;
            this.labelQustion.Text = "Не, ну я тебя спрашиваю!";
            this.labelQustion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelQustion.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(574, 442);
            this.Controls.Add(this.labelQustion);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

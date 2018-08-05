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
        int Width = 100;
        int Height = 100;
        string text;
        string picture;
        int pointHorse;
        int pointLegs;
        int pointFly;
    }
    public partial class Form1 : Form
    {
        private Label labelQustion;

        public void CreateAnswer(Answer once, SumPoints sum)
        {
            Button b1 = new Label();
            b1.Text = once.text;
            b1.Left = once.x;
            b1.Top = once.y;
            b1.Width = once.Width;
            b1.Height = once.Height;
            this.Controls.Add(b1);
            /*sum.Horse = sum.Horse + once.pointHorse;
            sum.Legs = sum.Legs + once.pointLegs;
            sum.Fly = sum.Fly + once.pointFly; 
            
            //FIXME 
            добавление баллов по клику вообще сюда? 
            Если да, то как правильно? 
            Как вообще правильно обращаться к структурам? 
            Чтобы в итоге оно считало эти баллы, и вообще структуры так? А переменную под структуру где лучше  объявлять? Принцип того как тест будет примерно работать, есть в ридми, но я так понимаю я от этого ещё далеко.
            ответьте на это всё пожалуйста в вк,
            ото в таком комментарии не найду)*/
        }

        public void CreateQuestion(Question once)
        {
            l1 = LabelQuestion();
            l1.Text = once.text;
            l1.Left = once.x;
            l1.Top = once.y;
            l1.Width = once.Width;
            l1.Height = once.Height;
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
        public List<Answer> ans;

        public Question(int _answers, string _text, int _x, int _y, int _Width, int _Height){
            l1 = new Label();
            answers = _answers;
            text = _text;
            x = _x;
            y = _y;
            Width = _Width;
            Height = _Height;
            ans = new List<Answer>();
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

            b1 = new Button();
            b1.Text = text;
            b1.Left = x;
            b1.Top = y;
            b1.Width = Width;
            b1.Height = Height;

            p1 = new PictureBox();
            p1.Left = picx;
            p1.Top = picy;
            p1.Width = picWidth;
            p1.Height = picHeight;
            p1.Image = Image.FromFile(picture);
        }
    };

    public partial class Form1 : Form
    {
        /// <summary>
        /// Сумма ответов по группам
        /// </summary>
        SumPoints sum;
        /// <summary>
        /// Все вопросы
        /// </summary>
        List<Question> quest = new List<Question>();
        /// <summary>
        /// Текущий вопрос
        /// </summary>
        Question quest1;
        /// <summary>
        /// Номер текущего вопроса
        /// </summary>
        int nomer_voprosa = -1;

        public void PointsPlus(Answer ans, ref SumPoints sum)
        {
            sum.Horse = sum.Horse + ans.pointHorse;
            sum.Legs = sum.Legs + ans.pointLegs;
            sum.Fly = sum.Fly + ans.pointFly;
        }

        public void CreateAnswer(Answer ans)
        {
            ans.b1.Click += new System.EventHandler(this.answer_Click);
            this.Controls.Add(ans.b1);
            this.Controls.Add(ans.p1);
        }

        //Эту кнопку тоже создай в дизайнере. На фиг ее каждый раз конструктором вызывать?
        public void RaedmeButton()
        {
            Button readmebat = new Button();
            readmebat.Text = "Шо це??? ";
            readmebat.Left = 20;
            readmebat.Top = 20;
            readmebat.Width = 60;
            readmebat.Height = 60;
            //readmebat.Click += new System.EventHandler(this.answer_Click);
            this.Controls.Add(readmebat);
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
            //сцук, задолбало искать. МЕЙН ТУТ
            //Так вынеси структуры в отдельные файлы
            string backgraund =  "..\\..\\pics\\backgraund.jpg";
            this.Width = 600;
            this.Height = 600;
            this.BackgroundImage = Image.FromFile(backgraund);
            
            sum = new SumPoints(0, 0, 0, 0);

            #region Заполняем вопросы
            quest1 = new Question(4, "кто круче?", 120, 20, 400, 60);
            quest1.ans.Add(new Answer(40, 400, 120, 80, 40, 240, 120, 120, "Всадник (СЛ)", "..\\..\\pics\\horses\\h1.jpg", 1, 0, 0, 0));
            quest1.ans.Add(new Answer(180, 400, 120, 80, 180, 240, 120, 120, "Гимли (ВК)", "..\\..\\pics\\legs\\l1.jpg", 0, 1, 0, 0));
            quest1.ans.Add(new Answer(320, 400, 120, 80, 320, 240, 120, 120, "Гальбаторикс (Эр)", "..\\..\\pics\\fly\\f1.jpg", 0, 0, 1, 0));
            quest1.ans.Add(new Answer(460, 400, 120, 80, 460, 240, 120, 120, "Кристин Ван Дер Вельде (Эт)", "..\\..\\pics\\pirats\\p1.jpg", 0, 0, 0, 1));
            quest.Add(quest1);

            quest1 = new Question(4, "кто круче-2?", 120, 20, 400, 60);
            quest1.ans.Add(new Answer(40, 400, 120, 80, 40, 240, 120, 120, "Всадник (СЛ)", "..\\..\\pics\\horses\\h1.jpg", 1, 0, 0, 0));
            quest1.ans.Add(new Answer(180, 400, 120, 80, 180, 240, 120, 120, "Гимли (ВК)", "..\\..\\pics\\legs\\l1.jpg", 0, 1, 0, 0));
            quest1.ans.Add(new Answer(320, 400, 120, 80, 320, 240, 120, 120, "Гальбаторикс (Эр)", "..\\..\\pics\\fly\\f1.jpg", 0, 0, 1, 0));
            quest1.ans.Add(new Answer(460, 400, 120, 80, 460, 240, 120, 120, "Кристин Ван Дер Вельде (Эт)", "..\\..\\pics\\pirats\\p1.jpg", 0, 0, 0, 1));
            quest.Add(quest1);

            quest1 = new Question(4, "кто круче-3?", 120, 20, 400, 60);
            quest1.ans.Add(new Answer(40, 400, 120, 80, 40, 240, 120, 120, "Всадник (СЛ)", "..\\..\\pics\\horses\\h1.jpg", 1, 0, 0, 0));
            quest1.ans.Add(new Answer(180, 400, 120, 80, 180, 240, 120, 120, "Гимли (ВК)", "..\\..\\pics\\legs\\l1.jpg", 0, 1, 0, 0));
            quest1.ans.Add(new Answer(320, 400, 120, 80, 320, 240, 120, 120, "Гальбаторикс (Эр)", "..\\..\\pics\\fly\\f1.jpg", 0, 0, 1, 0));
            quest1.ans.Add(new Answer(460, 400, 120, 80, 460, 240, 120, 120, "Кристин Ван Дер Вельде (Эт)", "..\\..\\pics\\pirats\\p1.jpg", 0, 0, 0, 1));
            quest.Add(quest1);
            #endregion

            //Переходим к первому вопросу (был "минус первый")
            batnotback_Click(null, null);
            
            InitializeComponent();
        }

        private void answer_Click(object sender, EventArgs e)
        {
            //Бегаем по всем ответам текущего вопроса
            for (int nomer = 0; nomer < quest1.ans.Count; nomer++)
            {
                //И если где-то совпало, прибаляем к сумме
                if (sender.Equals(quest1.ans[nomer].b1))
                {
                    PointsPlus(quest1.ans[nomer], ref sum);

                    MessageBox.Show(quest1.ans[nomer].b1.Text + " Конина" + sum.Horse.ToString());                    
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Э, ты дурак? тыкать надо ниже!");
        }

        private void batback_Click(object sender, EventArgs e)
        {
            //Если это не первый вопрос
            if (nomer_voprosa > 0)
            {
                //Переходим к предыдущему вопросу
                nomer_voprosa--;
                quest1 = quest[nomer_voprosa];
                //Форму очищаем
                this.Controls.Clear();
                //Добавляем на нее кнопки
                this.Controls.Add(batback);
                this.Controls.Add(batnotback);
                RaedmeButton();

                //И рисуем текущий вопрос
                CreateQuestion(quest1);
                CreateAnswer(quest1.ans[0]);
                CreateAnswer(quest1.ans[1]);
                CreateAnswer(quest1.ans[2]);
                CreateAnswer(quest1.ans[3]);
            }
        }

        private void batnotback_Click(object sender, EventArgs e)
        {
            //Если это не последний вопрос
            if (nomer_voprosa < 2)
            {
                //Переходим к следующему вопросу
                nomer_voprosa++;
                quest1 = quest[nomer_voprosa];
                //Форму очищаем
                this.Controls.Clear();
                //Добавляем на нее кнопки
                this.Controls.Add(batback);
                this.Controls.Add(batnotback);
                RaedmeButton();

                //И рисуем текущий вопрос
                CreateQuestion(quest1);
                CreateAnswer(quest1.ans[0]);
                CreateAnswer(quest1.ans[1]);
                CreateAnswer(quest1.ans[2]);
                CreateAnswer(quest1.ans[3]);
            }
        }
    }
}

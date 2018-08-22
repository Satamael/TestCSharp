using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;



namespace WindowsFormsApp1
{  

    
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
        private Button button1;

        /// <summary>
        /// Номер текущего вопроса
        /// </summary>
        int nomer_voprosa = -1;

        public void PointsPlus(Answer ans, ref SumPoints sum)
        {
            sum.Horse = sum.Horse + ans.pointHorse;
            sum.Legs = sum.Legs + ans.pointLegs;
            sum.Fly = sum.Fly + ans.pointFly;
            sum.Pirat = sum.Pirat + ans.pointPirat;
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

        public void Results(string pic, string resulttext)
        {
            Label l1 = new Label();
            l1.Text = resulttext;
            l1.Left = 100;
            l1.Top = 440;
            l1.Width = 300;
            l1.Height = 40;
            this.Controls.Add(l1);

            PictureBox p1 = new PictureBox();
            p1.Left = 100;
            p1.Top = 120;
            p1.Width = 300;
            p1.Height = 300;
            p1.Image = Image.FromFile(pic);
            this.Controls.Add(p1);

        }
        
        public Form1()
        {

            this.Width = 600;
            this.Height = 600;
            string backgraund =  "..\\..\\pics\\backgraund.jpg";
           
            this.BackgroundImage = Image.FromFile(backgraund);
            
            sum = new SumPoints(0, 0, 0, 0);

            #region Заполняем вопросы
            quest1 = new Question(4, "Кто круче?", 120, 20, 400, 60);
            quest1.ans.Add(new Answer(40, 400, 120, 80, 20, 240, 120, 120, "Всадник (СЛ)", "..\\..\\pics\\horses\\h1.jpg", 1, 0, 0, 0));
            quest1.ans.Add(new Answer(180, 400, 120, 80, 180, 240, 120, 120, "Гимли (ВК)", "..\\..\\pics\\legs\\l1.jpg", 0, 1, 0, 0));
            quest1.ans.Add(new Answer(320, 400, 120, 80, 320, 240, 120, 120, "Гальбаторикс (Эр)", "..\\..\\pics\\fly\\f1.jpg", 0, 0, 1, 0));
            quest1.ans.Add(new Answer(460, 400, 120, 80, 460, 240, 120, 120, "Кристин Ван Дер Вельде (Эт)", "..\\..\\pics\\pirats\\p1.jpg", 0, 0, 0, 1));
            quest.Add(quest1);

            #region Второй вопрос
            quest1 = new Question(4, "Кто нравится тебе больше?", 120, 20, 400, 60);
            quest1.ans.Add(new Answer(40, 400, 120, 80, 40, 240, 120, 120, "Джонни Блейз (ПГ)", "..\\..\\pics\\horses\\h2.jpg", 1, 0, 0, 0));
            quest1.ans.Add(new Answer(180, 400, 120, 80, 180, 240, 120, 120, "Тео (М)", "..\\..\\pics\\legs\\l2.jpg", 0, 1, 0, 0));
            quest1.ans.Add(new Answer(320, 400, 120, 80, 320, 240, 120, 120, "Эрагон (Эр)", "..\\..\\pics\\fly\\f2.jpg", 0, 0, 1, 0));
            quest1.ans.Add(new Answer(460, 400, 120, 80, 460, 240, 120, 120, "Лео Вальдес (ПД)", "..\\..\\pics\\pirats\\p2.jpg", 0, 0, 0, 1));
            quest.Add(quest1);
            #endregion
            #region Третий вопрос
            quest1 = new Question(4, "Кто интереснее?", 120, 20, 400, 60);
            quest1.ans.Add(new Answer(40, 400, 120, 80, 40, 240, 120, 120, "Эомер (ВК)", "..\\..\\pics\\horses\\h3.jpg", 1, 0, 0, 0));
            quest1.ans.Add(new Answer(180, 400, 120, 80, 180, 240, 120, 120, "Мефодий Буслаев (МБ)", "..\\..\\pics\\legs\\l3.jpg", 0, 1, 0, 0));
            quest1.ans.Add(new Answer(320, 400, 120, 80, 320, 240, 120, 120, "Рина (ШНыр)", "..\\..\\pics\\fly\\f3.jpg", 0, 0, 1, 0));
            quest1.ans.Add(new Answer(460, 400, 120, 80, 460, 240, 120, 120, "Эдвард Кенуэй (КУ)", "..\\..\\pics\\pirats\\p3.jpg", 0, 0, 0, 1));
            quest.Add(quest1);
            #endregion
            #region четвёртый вопрос
            quest1 = new Question(4, "Кто тебе ближе?", 120, 20, 400, 60);
            quest1.ans.Add(new Answer(40, 400, 120, 80, 40, 240, 120, 120, "Вестники Конца Света", "..\\..\\pics\\horses\\h4.jpg", 1, 0, 0, 0));
            quest1.ans.Add(new Answer(180, 400, 120, 80, 180, 240, 120, 120, "Фродо (ВК)", "..\\..\\pics\\legs\\l4.jpg", 0, 1, 0, 0));
            quest1.ans.Add(new Answer(320, 400, 120, 80, 320, 240, 120, 120, "Перси Джексон (ПД)", "..\\..\\pics\\fly\\f4.jpg", 0, 0, 1, 0));
            quest1.ans.Add(new Answer(460, 400, 120, 80, 460, 240, 120, 120, "Джек Воробей (ПКМ)", "..\\..\\pics\\pirats\\p4.jpg", 0, 0, 0, 1));
            quest.Add(quest1);
            #endregion
            #region Пятый вопрос
            quest1 = new Question(4, "Какую фитчу выберешь ты?", 120, 20, 400, 60);
            quest1.ans.Add(new Answer(40, 400, 120, 80, 40, 240, 120, 120, "Плотва (В)", "..\\..\\pics\\horses\\h5.jpg", 1, 0, 0, 0));
            quest1.ans.Add(new Answer(180, 400, 120, 80, 180, 240, 120, 120, "Единое кольцо (ВК)", "..\\..\\pics\\legs\\l5.jpg", 0, 1, 0, 0));
            quest1.ans.Add(new Answer(320, 400, 120, 80, 320, 240, 120, 120, "Золотая Пчела (ШНыр)", "..\\..\\pics\\fly\\f5.jpg", 0, 0, 1, 0));
            quest1.ans.Add(new Answer(460, 400, 120, 80, 460, 240, 120, 120, "Атстекская монета (ПКМ)", "..\\..\\pics\\pirats\\p5.jpg", 0, 0, 0, 1));
            quest.Add(quest1);
            #endregion
            #region Шестой вопрос
            quest1 = new Question(3, "Какое оружие тебе ближе?", 120, 20, 400, 60);
            quest1.ans.Add(new Answer(40, 400, 120, 80, 40, 240, 120, 120, "Копьё рыцаря", "..\\..\\pics\\horses\\h6.jpg", 1, 0, 0, 0));
            quest1.ans.Add(new Answer(180, 400, 120, 80, 180, 240, 120, 120, "Кинжал", "..\\..\\pics\\legs\\l6.jpg", 0, 1, 0, 0));
            quest1.ans.Add(new Answer(320, 400, 120, 80, 320, 240, 120, 120, "Ручной арбалет", "..\\..\\pics\\fly\\f6.jpg", 0, 0, 1, 0));
            quest.Add(quest1);
            #endregion
            #region Седьмой вопрос
            quest1 = new Question(3, "Кто нравится больше?", 120, 20, 400, 60);
            quest1.ans.Add(new Answer(180, 400, 120, 80, 180, 240, 120, 120, "Матвей Багров (МБ)", "..\\..\\pics\\legs\\l7.jpg", 0, 1, 0, 0));
            quest1.ans.Add(new Answer(320, 400, 120, 80, 320, 240, 120, 120, "Захарра Драгоций (Ч)", "..\\..\\pics\\fly\\f7.jpg", 0, 0, 1, 0));
            quest1.ans.Add(new Answer(460, 400, 120, 80, 460, 240, 120, 120, "Элизабет Суонн (ПКМ)", "..\\..\\pics\\pirats\\p6.jpg", 0, 0, 0, 1));
            quest.Add(quest1);
            #endregion
            #region Восьмой вопрос
            quest1 = new Question(3, "Чей путь важнее?", 120, 20, 400, 60);
            quest1.ans.Add(new Answer(180, 400, 120, 80, 180, 240, 120, 120, "Арья (Эр)", "..\\..\\pics\\legs\\l8.jpg", 0, 1, 0, 0));
            quest1.ans.Add(new Answer(320, 400, 120, 80, 320, 240, 120, 120, "Иккинг (КПД)", "..\\..\\pics\\fly\\f8.jpg", 0, 0, 1, 0));
            quest1.ans.Add(new Answer(460, 400, 120, 80, 460, 240, 120, 120, "Уилл Тёрнер (ПКМ)", "..\\..\\pics\\pirats\\p7.jpg", 0, 0, 0, 1));
            quest.Add(quest1);
            #endregion
            #endregion
            
            batnotback_Click(null, null);
            
  
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

                    //MessageBox.Show(quest1.ans[nomer].b1.Text + " Конина" + sum.Horse.ToString());

                    if (nomer_voprosa < 7)
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
                        for (int N = 0; N < quest1.answers; N++)
                        {
                            CreateAnswer(quest1.ans[N]);
                        }
                      
                    }

                
                  if(nomer_voprosa == 7)
                    {
                        this.Controls.Clear();
                        if(sum.Horse>sum.Legs && sum.Horse > sum.Fly && sum.Horse > sum.Pirat)
                        {
                            Results("..\\..\\pics\\horses\\hr.jpg", "Верхом на лошади, это про вас. Седлайте коней, и вперёд!");
                        } else if(sum.Legs > sum.Horse && sum.Legs > sum.Fly && sum.Legs > sum.Pirat)
                        {
                            Results("..\\..\\pics\\legs\\lr.jpg", "Верхом? Зачем? На своих двоих надёжнее. Вперёд пешком!");
                        } else if (sum.Fly > sum.Horse && sum.Fly > sum.Legs && sum.Fly > sum.Pirat)
                        {
                            Results("..\\..\\pics\\fly\\fr.jpg", "Что может быть лучше, чем полёт? Небо ждёт, седлайте крылатых!");
                        } else if (sum.Pirat > sum.Horse && sum.Pirat > sum.Legs && sum.Pirat > sum.Fly)
                        {
                            Results("..\\..\\pics\\pirats\\pr.jpg", "17 человек на сундук мертвеца! Ваш выбор - корабль. Попутного ветра!");
                        }
                    }  
                    
                }
            }
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
            if (nomer_voprosa < 7)
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {

        }

       

        private void Form1_Load_2(object sender, EventArgs e)
        {

        }

       /* private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "назад должно";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.batback_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(578, 551);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Text = "Тест про сёдла";
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_3);
            this.ResumeLayout(false);

        }*/

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load_3(object sender, EventArgs e)
        {

        }
    }
}

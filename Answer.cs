﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public struct Answer
    {
        public PictureBox p1;
        public Button b1;
        /// <summary>
        /// координаты по иксу кнопки
        /// </summary>
        public int x;
        /// <summary>
        /// координаты по угрику кнопки
        /// </summary>
        public int y;
        /// <summary>
        /// Это ширина кнопки
        /// </summary>
        public int Width;
        /// <summary>
        /// высота кнопки
        /// </summary>
        public int Height;
        /// <summary>
        /// x picB
        /// </summary>
        public int picx;
        /// <summary>
        /// y picB
        /// </summary>
        public int picy;
        /// <summary>
        /// shir picB
        /// </summary>
        public int picWidth;
        /// <summary>
        /// visita picB
        /// </summary>
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

}

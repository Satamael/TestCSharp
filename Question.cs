using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{    public struct Question
    {
        /// <summary>
        /// лейбл с вопросом
        /// </summary>
        public Label l1;
        /// <summary>
        /// колличество ответов в вопросе
        /// </summary>
        public int answers;
        /// <summary>
        /// текст вопроса
        /// </summary>
        public string text;
        /// <summary>
        /// координаты по X
        /// </summary>
        public int x;
        /// <summary>
        /// координаты по Y
        /// </summary>
        public int y;
        /// <summary>
        /// Ширина
        /// </summary>
        public int Width;
        /// <summary>
        /// Высота
        /// </summary>
        public int Height;
        /// <summary>
        /// список ответов
        /// </summary>
        public List<Answer> ans;

        public Question(int _answers, string _text, int _x, int _y, int _Width, int _Height)
        {
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
}

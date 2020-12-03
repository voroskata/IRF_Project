using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Project
{
    class AnswerSheet : Button
    {
        private int _answer;
        public int Answer {
            get { return _answer; }
            set {
                _answer = value;
                if (_answer < 0)
                    _answer = 4;
                else if (_answer > 4)
                    _answer = 0;

                if (_answer == 0)
                    Text = "";
                else
                    Text = _answer.ToString(); }
        }

        public AnswerSheet()
        {
            Height = 50;
            Width = Height;
            BackColor = Color.White;
            Answer = 0;
            MouseDown += AnswerSheet_MouseDown;
        }

        private void AnswerSheet_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Answer++;
            if (e.Button == MouseButtons.Right)
                Answer--;
        }
    }
}

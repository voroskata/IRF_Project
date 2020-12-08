using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Project
{
    public partial class Form1 : Form
    {
        PlayerEntities1 context = new PlayerEntities1();


        public Form1()
        {
            InitializeComponent();
            CreateAnswerSheet();

            context.Questions.Load();
        }

        private void CreateAnswerSheet()
        {
            for (int i = 0; i < 10; i++)
            {
                AnswerSheet answer = new AnswerSheet();
                answer.Left = i * answer.Width;
                panel1.Controls.Add(answer);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}

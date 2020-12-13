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
        GameEntities context = new GameEntities();

        Random rnd = new Random();

        int counter = 0;
        int countdown = 20;

        public Form1()
        {
            InitializeComponent();

            CreateAnswerSheet();

            context.Quizs.Load();
            context.Participants.Load();

            GetQuestions();

            GetBestParticipant();
            
            CountDown();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            countdown--;

            if (countdown==0)
            {
                GetQuestions();
                Coloring();
                CountDown();
            }

            label3.Text = countdown.ToString();
        }

        private void CountDown()
        {
            timer1.Tick += Timer1_Tick;
            timer1.Interval = 1000;
            timer1.Start();
            label3.Text = countdown.ToString();
        }

        private void GetBestParticipant()
        {
            var maxValue = context.Participants.Max(x => x.Points);

            string legjobbNev = ((from p in context.Participants
                               where p.Points == maxValue
                               select p.Nickname).SingleOrDefault()).ToString();

            string legjobbPont = ((from p in context.Participants
                               where p.Points == maxValue
                               select p.Points).SingleOrDefault()).ToString();

            nickname.Text = legjobbNev.ToString();
            points.Text = legjobbPont.ToString();
        }

        public void GetQuestions()
        {
            panel2.Controls.Clear();

            int kerdes_id = rnd.Next(40);

            string kerdes = ((from k in context.Quizs
                              where k.Id == kerdes_id
                              select k.Question).SingleOrDefault()).ToString();

            string v1 = ((from k in context.Quizs
                          where k.Id == kerdes_id
                          select k.Answer_1).SingleOrDefault()).ToString();

            string v2 = ((from k in context.Quizs
                          where k.Id == kerdes_id
                          select k.Answer_2).SingleOrDefault()).ToString();

            string v3 = ((from k in context.Quizs
                          where k.Id == kerdes_id
                          select k.Answer_3).SingleOrDefault()).ToString();

            string v4 = ((from k in context.Quizs
                          where k.Id == kerdes_id
                          select k.Answer_4).SingleOrDefault()).ToString();

            Solution.jovalasz = ((from k in context.Quizs
                         where k.Id == kerdes_id
                         select k.Correct).SingleOrDefault());

            KerdesUserControl kuc = new KerdesUserControl(kerdes, v1, v2, v3, v4, Solution.jovalasz);
            panel2.Controls.Add(kuc);
            kuc.Dock = DockStyle.Fill;
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

        private void button2_Click(object sender, EventArgs e)
        {
            GetQuestions();

            counter++;

            if (counter == 10)
            {
                Coloring();
                button2.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Coloring();
        }

        private void Coloring()
        {
            foreach (var ans in panel1.Controls.OfType<AnswerSheet>())
            {
                if (ans.Answer == Solution.jovalasz)
                {
                    ans.BackColor = Color.Green;
                }
                else
                {
                    ans.BackColor = Color.Red;
                }

            }
        }
    }
}

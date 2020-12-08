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

        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            CreateAnswerSheet();

            context.Questions.Load();

            int kerdes_id = rnd.Next(40)+1;

            string kerdes = ((from k in context.Questions
                              where k.Id == kerdes_id
                              select k.Question1).SingleOrDefault()).ToString();

            string v1 = ((from k in context.Questions
                          where k.Id == kerdes_id
                          select k.Answer_1).SingleOrDefault()).ToString();

            string v2 = ((from k in context.Questions
                          where k.Id == kerdes_id
                          select k.Answer_2).SingleOrDefault()).ToString();

            string v3 = ((from k in context.Questions
                          where k.Id == kerdes_id
                          select k.Answer_3).SingleOrDefault()).ToString();

            string v4 = ((from k in context.Questions
                          where k.Id == kerdes_id
                          select k.Answer_4)).SingleOrDefault().ToString();

            //int jovalasz = from k in context.Questions
            //                where k.Id == kerdes_id
            //                select k.Correct

            int jovalasz = 1;

            KerdesUserControl kuc = new KerdesUserControl(kerdes, v1, v2, v3, v4, jovalasz);
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
    }
}

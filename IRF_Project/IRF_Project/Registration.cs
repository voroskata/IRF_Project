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
    public partial class Registration : Form
    {
        GameEntities context = new GameEntities();

        public Registration()
        {
            InitializeComponent();

            context.Participants.Load();
        }

        private bool ValidNev(string név)
        {
            return !string.IsNullOrEmpty(név);
        }

        //Név mező validálása
        private void TextBox1_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidNev(textBox1.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox1, "A név nem lehet üres!");
            }

            if (textBox1.Text.Contains(" "))
            {
                textBox1.BackColor = Color.LightGreen;
            }
            else
            {
                textBox1.BackColor = Color.IndianRed;
                e.Cancel = true;
            }
        }

        private void TextBox1_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox1, "");
        }

        //mezők validálása
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            this.Validate();
        }        

        private bool ValidFNev(string fnév)
        {
            return !string.IsNullOrEmpty(fnév);
        }

        //Felhasználónév mező validálása
        private void TextBox2_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidFNev(textBox2.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox2, "A név nem lehet üres!");
            }

            if (textBox2.Text.Contains(" "))
            {
                textBox2.BackColor = Color.LightGreen;
            }
            else
            {
                textBox2.BackColor = Color.IndianRed;
                e.Cancel = true;
            }
        }

        private void TextBox2_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox2, "");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Participant rv = new Participant();
            rv.Name = textBox1.Text;
            rv.Nickname = textBox2.Text;

            context.Participants.Add(rv);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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

        private void TextBox3_TextChanged(object sender, EventArgs e)
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
    }
}

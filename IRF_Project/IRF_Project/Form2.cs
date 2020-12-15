using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Project
{
    public partial class Form2 : Form
    {
        GameEntities context = new GameEntities();

        public Form2()
        {
            InitializeComponent();

            context.Participants.Load();
            getPlayers();
        }

        private void getPlayers()
        {
            var jatekosok = from p in context.Participants
                          select new
                          {
                              p.Id,
                              p.Name,
                              p.Nickname,
                              p.Points
                          };

            participantBindingSource.DataSource = jatekosok.ToList();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var jatekosok = from p in context.Participants
                            select p;

            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Comma Seperated Values (*.csv)|*.csv";
            sfd.DefaultExt = "csv";
            sfd.AddExtension = true;

            if (sfd.ShowDialog() != DialogResult.OK) return;

            using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
            {
                foreach (var p in jatekosok)
                {
                    sw.Write(p.Id);
                    sw.Write(";");
                    sw.Write(p.Name);
                    sw.Write(";");
                    sw.Write(p.Nickname);
                    sw.Write(";");
                    sw.Write(p.Points.ToString());
                    sw.WriteLine();
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
        }
    }
}

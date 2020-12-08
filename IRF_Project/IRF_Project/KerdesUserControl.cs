using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Project
{
    public partial class KerdesUserControl : UserControl
    {
        int jv; 

        public KerdesUserControl(string kerdes, string v1, string v2, string v3, string v4, int jv)
        {
            InitializeComponent();

            lblQuestion.Text = kerdes;
            lblAnswer1.Text = v1;
            lblAnswer2.Text = v2;
            lblAnswer3.Text = v3;
            lblAnswer4.Text = v4;

            this.jv = jv;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Project
{
    class RegistrationButtons : Button
    {
        public RegistrationButtons()
        {
            Width = 300;
            Height = 40;

            BackColor = Color.White;
            ForeColor = Color.DarkBlue;    
            
            this.Font = new Font("Century Gothic", 11, FontStyle.Bold);
        }
    }
}

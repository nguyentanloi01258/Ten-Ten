using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ProjectLogin.UC_Control
{
    public partial class Cpn_Thoat : Button
    {
        public Cpn_Thoat()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(160, 60);
            this.BackColor = Color.OrangeRed;
            this.ForeColor = Color.White; 
        }

        
    }
}

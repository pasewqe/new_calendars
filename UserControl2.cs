using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace new_calendars
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        public void days(int numday)
        {
            label1.Text = numday + "";

        }
        public void Years(int numday)
        {
            label1.Text = numday + "";

        }
        public void Months(int numday)
        {
            label1.Text = numday + "";

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

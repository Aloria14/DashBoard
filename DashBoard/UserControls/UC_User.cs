﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashBoard.UserControls
{
    public partial class UC_User : UserControl
    {
        public UC_User()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
            /*
            intiantiation nung login
            */
        }
    }
}

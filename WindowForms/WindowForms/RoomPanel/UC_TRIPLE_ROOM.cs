﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowForms
{
    public partial class UC_TRIPLE_ROOM : UserControl
    {
        public event EventHandler TripleReserveClicked, arrowClicked;
        public UC_TRIPLE_ROOM()
        {
            InitializeComponent();
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            TripleReserveClicked?.Invoke(this, EventArgs.Empty);
        }

        private void pbArrow2_Click(object sender, EventArgs e)
        {
            arrowClicked?.Invoke(this, EventArgs.Empty);
        }

        int guestnum = 1;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            guestnum++;
            if (guestnum >= 7)
            {
                guestnum = 1;
            }
            lblNumberOfGuests.Text = Convert.ToString(guestnum);
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            guestnum--;
            if (guestnum <= 0)
            {
                guestnum = 1;
            }
            lblNumberOfGuests.Text = Convert.ToString(guestnum);
        }
    }
}

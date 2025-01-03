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
    public partial class UC_OFFERS : UserControl
    {
        public event EventHandler LearnMoreClicked,
            roomAVAILClicked, viewRoomsClicked;
        public UC_OFFERS()
        {
            InitializeComponent();
        }

        private void UC_OFFERS_Load(object sender, EventArgs e)
        {
            pictureBox5.TabStop = true;
            pictureBox5.Focus();
            ScrollToControl(pictureBox5);
        }

        private void ScrollToControl(Control control)
        {
            if (control.Parent is Panel parentPanel && parentPanel.AutoScroll)
            {
                parentPanel.ScrollControlIntoView(control);
            }
        }

        private void btnViewCode_Click(object sender, EventArgs e)
        {
            DiscountCode_PopUp discountCode_PopUp = new DiscountCode_PopUp();
            discountCode_PopUp.Show();
        }

        private void btnLearnMore_Click(object sender, EventArgs e)
        {
            LearnMoreClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnViewAllRooms_Click(object sender, EventArgs e)
        {
            viewRoomsClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (dtpCheckIn.Value.Date < DateTime.Now.Date && dtpCheckIn.Value.Date < DateTime.Now.Date)
            {
                string title = "Invalid Date";
                string message = "Please select current date";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Warning;
                MessageBox.Show(message, title, buttons, icon);
                return;
            }
            else if (dtpCheckIn.Value.Date < DateTime.Now.Date)
            {
                string title = "Invalid Date";
                string message = "Please select current date";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Warning;
                MessageBox.Show(message, title, buttons, icon);
                return;
            }
            else if (dtpCheckOut.Value.Date < DateTime.Now.Date)
            {
                string title = "Invalid Date";
                string message = "Please select current date";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Warning;
                MessageBox.Show(message, title, buttons, icon);
                return;
            }
            else
            {
                roomAVAILClicked?.Invoke(this, EventArgs.Empty);
            }
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

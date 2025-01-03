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
    public partial class UC_ROOMS : UserControl
    {
        public event EventHandler StandardRoomClicked, SingleRoomClicked,
            TripleRoomClicked, SuiteRoomClicked, DeluxeRoom, roomSearchClicked;
        public UC_ROOMS()
        {
            InitializeComponent();
        }

        private void btnStandardRoomDetails_Click(object sender, EventArgs e)
        {
            StandardRoomClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnSingleRoomDetails_Click(object sender, EventArgs e)
        {
            SingleRoomClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnTripleRoomDetails_Click(object sender, EventArgs e)
        {
            TripleRoomClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnSuiteRoomDetails_Click(object sender, EventArgs e)
        {
            SuiteRoomClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnDeluxeRoomDetails_Click(object sender, EventArgs e)
        {
            DeluxeRoom?.Invoke(this, EventArgs.Empty);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (dtpCheckIn.Value.Date < DateTime.Now.Date && dtpCheckOut.Value.Date < DateTime.Now.Date)
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
                roomSearchClicked?.Invoke(this, EventArgs.Empty);
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

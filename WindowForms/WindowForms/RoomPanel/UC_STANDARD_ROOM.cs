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
    public partial class UC_STANDARD_ROOM : UserControl
    {
        public event EventHandler StandardReserveClicked, arrowClicked;

        public UC_STANDARD_ROOM()
        {
            InitializeComponent();
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            StandardReserveClicked?.Invoke(this, EventArgs.Empty);
        }

        private void UC_STANDARD_ROOM_Load(object sender, EventArgs e)
        {

        }

        private void pbArrow_Click(object sender, EventArgs e)
        {
            arrowClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
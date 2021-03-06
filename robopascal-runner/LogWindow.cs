﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace robopascal_runner
{
    public partial class LogWindow : Form
    {
        public LogWindow()
        {
            InitializeComponent();
        }

        private void LogWindow_Shown(object sender, EventArgs e)
        {
            Location = new Point(Owner.Location.X - Width, Owner.Location.Y);
            logListBox.DataSource = (Owner as MainWindow).Log;
        }

        private void LogWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Hide();
                e.Cancel = true;
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (Owner as MainWindow).Log.Clear();
        }
    }
}
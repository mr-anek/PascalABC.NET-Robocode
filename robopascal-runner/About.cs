﻿using System;
using System.Windows.Forms;
using robopascal_runner.Properties;

namespace robopascal_runner
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();

            versionLabel.Text = string.Format(Resources.AppVersion, Application.ProductName, Application.ProductVersion);
        }

        private void siteLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(siteLinkLabel.Text);
            Hide();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}

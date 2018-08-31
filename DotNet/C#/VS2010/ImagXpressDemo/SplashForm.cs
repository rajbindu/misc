/***************************************************************
* Copyright 2011-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ImagXpressDemo
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
        
        private Timer splashTimer;

        private void SplashForm_Load(object sender, EventArgs e)
        {
            splashTimer = new Timer();
            splashTimer.Interval = 500;
            splashTimer.Tick += new EventHandler(splashTimer_Tick);
            splashTimer.Start();
        }

        private void splashTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity == 0)
            {
                this.Close();
            }

            //after 90% opacity, speed up fade
            if (this.Opacity <= .9)
            {
                this.Opacity -= 0.1;
            }
            else
            {
                //slowly fade until 90% opacity
                this.Opacity -= 0.02;
            }
        }

        private void AccusoftLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Constants.accusoftString);
        }

        private void SplashForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DemoLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CopyrightLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
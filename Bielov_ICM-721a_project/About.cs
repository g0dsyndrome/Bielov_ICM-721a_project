﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bielov_ICM_721a_project
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void tAbout_Tick(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
            }
            timer1.Start();
        }
    }
}

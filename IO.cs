﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SU
{
    public partial class IO : Form
    {
        public IO()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void IDC_IOOK_BUTTON_Click(object sender, EventArgs e)
        {
            GV.lp = Int32.Parse(m_lp.Text);
            GV.lm = Int32.Parse(m_lm.Text);
            GV.kp = Int32.Parse(m_kp.Text);
            GV.km = Int32.Parse(m_km.Text);
            this.Close();
        }

        private void IO_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SU
{
    public partial class l : Form
    {
        public l()
        {
            InitializeComponent();
        }

        private void l_Load(object sender, EventArgs e)
        {
   
        }

        private void IDC_NEXTl_BUTTON_Click(object sender, EventArgs e)
        {
            int i = Int32.Parse(m_nextl.Text);
            GV.in_l[i, 0] = Int32.Parse(m_npl.Text);
            GV.in_l[i, 1] = Int32.Parse(m_nml.Text);
            GV.z_l[i] = Single.Parse(m_zl.Text);
            i++;
            m_nextl.Text = i.ToString();
            if (i <= GV.nr)
            {
                m_npl.Text = "0";
                m_nml.Text = "0";
                m_zl.Text = "0";
                m_npl.Focus();
            }
            else
                this.Close();
        }
    }
}

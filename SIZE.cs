using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SU
{
    public partial class SIZE : Form
    {
        public SIZE()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {
            GV.nv = Int32.Parse(m_nv.Text);
            GV.nr = Int32.Parse(m_nr.Text);
            GV.nc = Int32.Parse(m_nc.Text);
            GV.nl = Int32.Parse(m_nl.Text);


            this.Close();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void SIZE_Load(object sender, EventArgs e)
        {

        }
    }
}

namespace SU
{

  

    class GV
    {
        public static int M = 100, MR = 50, MC = 50, MF = 20, Ml=50;
        public static int nv, n, nr, lp, lm, kp, nf, k, km, nl,nc, c;

        public static int[,] in_r = new int[MR + 1, 2];
        public static int[,] in_c = new int[MC + 1, 2];
        public static int[,] in_l = new int[Ml + 1, 2];
        //...
        public static float[] z_r = new float[MR + 1];
        public static float[] z_c = new float[MC + 1];
        public static float[] z_l = new float[Ml + 1];
        //...
        public static float[] f = new float[MF + 1];
        //...
        public static String filename;
        public static bool flag = false;
    }
}

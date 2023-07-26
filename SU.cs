using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SU
{
    public partial class SU : Form
    {
        public SU()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SU_Load(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void iDFILEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ID_CONSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SIZE size = new SIZE();
            size.ShowDialog(this);
            size.Dispose();

            if (GV.nr > 0)
            {
                R ir = new R();
                ir.ShowDialog(this);
                ir.Dispose();
            }

            if (GV.nc > 0)
            {
                C ic = new C();
                ic.ShowDialog(this);
                ic.Dispose();
            }

            if (GV.nl > 0)
            {
                l il = new l();
                il.ShowDialog(this);
                il.Dispose();
            }

            DialogResult res = MessageBox.Show("Выводить описание схемы в файл?",
                "Вывод в файл", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                File ofile = new File();
                GV.k = 0;
                ofile.ShowDialog(this);
                ofile.Dispose();
            }

            F f = new F();
            f.ShowDialog(this);
            f.Dispose();
            IO io = new IO();
            io.ShowDialog(this);
            io.Dispose();

        }
        private void ID_FILEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GV.k = 1;
            File file = new File();
            try
            {
                file.ShowDialog(this);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return;
            }
            file.Dispose();

            F f = new F();
            f.ShowDialog(this);
            f.Dispose();
            IO io = new IO();
            io.ShowDialog(this);
            io.Dispose();

        }

        private void IDREDToolStripMenuItem_Click(object sender, EventArgs e)
        {               
            RED red = new RED();
            red.ShowDialog(this);
            red.Dispose();    
        }

        private void директивырасчетаToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void ID_FtoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            F f = new F();
            f.ShowDialog(this);
            f.Dispose();
        }

        private void ID_IOtoolStripMenuItem2_Click(object sender, EventArgs e)
        {
            IO io = new IO();
            io.ShowDialog(this);
            io.Dispose();
        }

        private void видToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ID_PRIVToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GV.flag = false;
        }

        private void ID_SYSToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            GV.flag = true;
        }

        private void ID_INTERNETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!GV.flag)
            {
                INT cint = new INT();
                cint.Show(this);
            }
            else
            {
                System.Diagnostics.Process.Start("iexplore.exe", "http://127.0.0.1/MF/Int3d.htm");
            }

        }

        private void ID_EXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

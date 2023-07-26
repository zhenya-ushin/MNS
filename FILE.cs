﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SU
{
    public partial class File : Form
    {
        public File()
        {
            InitializeComponent();
        }

        private void fileout(String filename)      //Вывод описания схемы в файл
        {
            StreamWriter fout = new StreamWriter(GV.filename);
            String str = "";
            int i;
            str = GV.nv.ToString() + " " + GV.nr.ToString();

            fout.WriteLine(str);
            for (i = 1; i <= GV.nr; i++)
            {
                str = GV.in_r[i, 0].ToString() + " " + GV.in_r[i, 1].ToString() + " "
                    + GV.z_r[i].ToString();
                fout.WriteLine(str);

            }

            
            str = GV.nv.ToString() + " " + GV.nc.ToString();
            for (i = 1; i <= GV.nc; i++)
            {
                str = GV.in_c[i, 0].ToString() + " " + GV.in_c[i, 1].ToString() + " "
                    + GV.z_c[i].ToString();
                fout.WriteLine(str);

            }

            str = GV.nv.ToString() + " " + GV.nl.ToString();
            for (i = 1; i <= GV.nl; i++)
            {
                str = GV.in_l[i, 0].ToString() + " " + GV.in_l[i, 1].ToString() + " "
                    + GV.z_l[i].ToString();
                fout.WriteLine(str);

            }

            //...
            fout.Close();
        }


        private void filein(String filename)      //Ввод описания схемы из файла
        {
            StreamReader fin = new StreamReader(GV.filename);
            char[] sep = { ' ' };
            string str = "";
            str = fin.ReadLine();
            String[] s = str.Split(sep, 2);//Значение второго аргумента!!!
            GV.nv = Int32.Parse(s[0]);
            GV.nr = Int32.Parse(s[1]);
            GV.nc = Int32.Parse(s[1]);
            GV.nl = Int32.Parse(s[1]);
            //...
            for (int i = 1; i <= GV.nr; i++)
            {
                str = fin.ReadLine();
                s = str.Split(sep, 3);
                GV.in_r[i, 0] = Int32.Parse(s[0]);
                GV.in_r[i, 1] = Int32.Parse(s[1]);
                GV.z_r[i] = Single.Parse(s[2]);
            }
            for (int i = 1; i <= GV.nc; i++)
            {
                str = fin.ReadLine();
                s = str.Split(sep, 3);
                GV.in_c[i, 0] = Int32.Parse(s[0]);
                GV.in_c[i, 1] = Int32.Parse(s[1]);
                GV.z_c[i] = Single.Parse(s[2]);
            }
            for (int i = 1; i <= GV.nl; i++)
            {
                str = fin.ReadLine();
                s = str.Split(sep, 3);
                GV.in_l[i, 0] = Int32.Parse(s[0]);
                GV.in_l[i, 1] = Int32.Parse(s[1]);
                GV.z_l[i] = Single.Parse(s[2]);
            }
            //...
            fin.Close();
        }


        private void IDC_FILEOK_BUTTON_Click(object sender, EventArgs e)
        {
            switch (GV.k)
            {
                case 0:
                    GV.filename = m_file.Text;
                    if (GV.filename != "")
                        fileout(GV.filename);
                    else
                        MessageBox.Show("Введите имя файла");
                    break;
                case 1:
                    GV.filename = m_file.Text;
                    try
                    {
                        filein(GV.filename);
                    }
                    catch (Exception err)
                    {
                        throw new Exception(err.Message);
                    }

                    break;
            }
            this.Close();
        }

        private void File_Load(object sender, EventArgs e)
        {

        }
    }
}

﻿
namespace SU
{
    partial class SU
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.описаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ID_CONS = new System.Windows.Forms.ToolStripMenuItem();
            this.ID_FILE = new System.Windows.Forms.ToolStripMenuItem();
            this.ID_RED = new System.Windows.Forms.ToolStripMenuItem();
            this.директивырасчетаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ID_F = new System.Windows.Forms.ToolStripMenuItem();
            this.ID_IO = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ID_PRIV = new System.Windows.Forms.ToolStripMenuItem();
            this.ID_SYS = new System.Windows.Forms.ToolStripMenuItem();
            this.ID_CALC = new System.Windows.Forms.ToolStripMenuItem();
            this.ID_INTERNET = new System.Windows.Forms.ToolStripMenuItem();
            this.ID_EXIT = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(428, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.описаниеToolStripMenuItem,
            this.ID_RED,
            this.директивырасчетаToolStripMenuItem,
            this.видToolStripMenuItem,
            this.ID_CALC,
            this.ID_INTERNET,
            this.ID_EXIT});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.menuToolStripMenuItem.Text = "Меню";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // описаниеToolStripMenuItem
            // 
            this.описаниеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ID_CONS,
            this.ID_FILE});
            this.описаниеToolStripMenuItem.Name = "описаниеToolStripMenuItem";
            this.описаниеToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.описаниеToolStripMenuItem.Text = "Описание";
            this.описаниеToolStripMenuItem.Click += new System.EventHandler(this.iDFILEToolStripMenuItem_Click);
            // 
            // ID_CONS
            // 
            this.ID_CONS.Name = "ID_CONS";
            this.ID_CONS.Size = new System.Drawing.Size(184, 22);
            this.ID_CONS.Text = "Ввод с клавиатуры";
            this.ID_CONS.Click += new System.EventHandler(this.ID_CONSToolStripMenuItem_Click);
            // 
            // ID_FILE
            // 
            this.ID_FILE.Name = "ID_FILE";
            this.ID_FILE.Size = new System.Drawing.Size(184, 22);
            this.ID_FILE.Text = "Ввод с файла";
            this.ID_FILE.Click += new System.EventHandler(this.ID_FILEToolStripMenuItem_Click);
            // 
            // ID_RED
            // 
            this.ID_RED.Name = "ID_RED";
            this.ID_RED.Size = new System.Drawing.Size(189, 22);
            this.ID_RED.Text = "Редактирование";
            this.ID_RED.Click += new System.EventHandler(this.IDREDToolStripMenuItem_Click);
            // 
            // директивырасчетаToolStripMenuItem
            // 
            this.директивырасчетаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ID_F,
            this.ID_IO});
            this.директивырасчетаToolStripMenuItem.Name = "директивырасчетаToolStripMenuItem";
            this.директивырасчетаToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.директивырасчетаToolStripMenuItem.Text = "Директивы расчета";
            this.директивырасчетаToolStripMenuItem.Click += new System.EventHandler(this.директивырасчетаToolStripMenuItem_Click);
            // 
            // ID_F
            // 
            this.ID_F.Name = "ID_F";
            this.ID_F.Size = new System.Drawing.Size(255, 22);
            this.ID_F.Text = "Вид частотной характеристики";
            this.ID_F.Click += new System.EventHandler(this.ID_FtoolStripMenuItem1_Click);
            // 
            // ID_IO
            // 
            this.ID_IO.Name = "ID_IO";
            this.ID_IO.Size = new System.Drawing.Size(255, 22);
            this.ID_IO.Text = "Вх/вых узлы";
            this.ID_IO.Click += new System.EventHandler(this.ID_IOtoolStripMenuItem2_Click);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ID_PRIV,
            this.ID_SYS});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.видToolStripMenuItem.Text = "Вид";
            this.видToolStripMenuItem.Click += new System.EventHandler(this.видToolStripMenuItem_Click);
            // 
            // ID_PRIV
            // 
            this.ID_PRIV.Name = "ID_PRIV";
            this.ID_PRIV.Size = new System.Drawing.Size(202, 22);
            this.ID_PRIV.Text = "Собственный броузер";
            this.ID_PRIV.Click += new System.EventHandler(this.ID_PRIVToolStripMenuItem1_Click);
            // 
            // ID_SYS
            // 
            this.ID_SYS.Name = "ID_SYS";
            this.ID_SYS.Size = new System.Drawing.Size(202, 22);
            this.ID_SYS.Text = "Системный броузер";
            this.ID_SYS.Click += new System.EventHandler(this.ID_SYSToolStripMenuItem2_Click);
            // 
            // ID_CALC
            // 
            this.ID_CALC.Name = "ID_CALC";
            this.ID_CALC.Size = new System.Drawing.Size(189, 22);
            this.ID_CALC.Text = "Расчет";
            // 
            // ID_INTERNET
            // 
            this.ID_INTERNET.Name = "ID_INTERNET";
            this.ID_INTERNET.Size = new System.Drawing.Size(189, 22);
            this.ID_INTERNET.Text = "Интернет";
            this.ID_INTERNET.Click += new System.EventHandler(this.ID_INTERNETToolStripMenuItem_Click);
            // 
            // ID_EXIT
            // 
            this.ID_EXIT.Name = "ID_EXIT";
            this.ID_EXIT.Size = new System.Drawing.Size(189, 22);
            this.ID_EXIT.Text = "Выход";
            this.ID_EXIT.Click += new System.EventHandler(this.ID_EXITToolStripMenuItem_Click);
            // 
            // SU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 278);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SU";
            this.Text = " ";
            this.Load += new System.EventHandler(this.SU_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem описаниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ID_RED;
        private System.Windows.Forms.ToolStripMenuItem директивырасчетаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ID_CALC;
        private System.Windows.Forms.ToolStripMenuItem ID_INTERNET;
        private System.Windows.Forms.ToolStripMenuItem ID_EXIT;
        private System.Windows.Forms.ToolStripMenuItem ID_CONS;
        private System.Windows.Forms.ToolStripMenuItem ID_FILE;
        private System.Windows.Forms.ToolStripMenuItem ID_F;
        private System.Windows.Forms.ToolStripMenuItem ID_IO;
        private System.Windows.Forms.ToolStripMenuItem ID_PRIV;
        private System.Windows.Forms.ToolStripMenuItem ID_SYS;
    }
}


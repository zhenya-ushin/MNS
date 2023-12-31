﻿
namespace SU
{
    partial class F
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IDC_F = new System.Windows.Forms.RadioButton();
            this.IDC_DF = new System.Windows.Forms.RadioButton();
            this.IDC_KF = new System.Windows.Forms.RadioButton();
            this.IDC_T1 = new System.Windows.Forms.TextBox();
            this.IDC_T2 = new System.Windows.Forms.TextBox();
            this.IDC_T3 = new System.Windows.Forms.TextBox();
            this.IDC_F1 = new System.Windows.Forms.TextBox();
            this.IDC_F2 = new System.Windows.Forms.TextBox();
            this.IDC_F3 = new System.Windows.Forms.TextBox();
            this.IDC_FOK_BUTTON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IDC_F
            // 
            this.IDC_F.AutoSize = true;
            this.IDC_F.Checked = true;
            this.IDC_F.Location = new System.Drawing.Point(13, 37);
            this.IDC_F.Name = "IDC_F";
            this.IDC_F.Size = new System.Drawing.Size(199, 19);
            this.IDC_F.TabIndex = 0;
            this.IDC_F.TabStop = true;
            this.IDC_F.Text = "Единственная частотная точка";
            this.IDC_F.UseVisualStyleBackColor = true;
            this.IDC_F.CheckedChanged += new System.EventHandler(this.IDC_F_CheckedChanged);
            // 
            // IDC_DF
            // 
            this.IDC_DF.AutoSize = true;
            this.IDC_DF.Location = new System.Drawing.Point(13, 77);
            this.IDC_DF.Name = "IDC_DF";
            this.IDC_DF.Size = new System.Drawing.Size(243, 19);
            this.IDC_DF.TabIndex = 1;
            this.IDC_DF.Text = "Линейный закон изменения частоты";
            this.IDC_DF.UseVisualStyleBackColor = true;
            this.IDC_DF.CheckedChanged += new System.EventHandler(this.IDC_DF_CheckedChanged);
            // 
            // IDC_KF
            // 
            this.IDC_KF.AutoSize = true;
            this.IDC_KF.Location = new System.Drawing.Point(13, 117);
            this.IDC_KF.Name = "IDC_KF";
            this.IDC_KF.Size = new System.Drawing.Size(290, 19);
            this.IDC_KF.TabIndex = 2;
            this.IDC_KF.Text = "Логарифмический закон изменения частоты";
            this.IDC_KF.UseVisualStyleBackColor = true;
            this.IDC_KF.CheckedChanged += new System.EventHandler(this.IDC_KF_CheckedChanged);
            // 
            // IDC_T1
            // 
            this.IDC_T1.Location = new System.Drawing.Point(13, 163);
            this.IDC_T1.Name = "IDC_T1";
            this.IDC_T1.ReadOnly = true;
            this.IDC_T1.Size = new System.Drawing.Size(277, 23);
            this.IDC_T1.TabIndex = 3;
            this.IDC_T1.Text = "Значение частоты (КГц)";
            // 
            // IDC_T2
            // 
            this.IDC_T2.Location = new System.Drawing.Point(13, 207);
            this.IDC_T2.Name = "IDC_T2";
            this.IDC_T2.ReadOnly = true;
            this.IDC_T2.Size = new System.Drawing.Size(277, 23);
            this.IDC_T2.TabIndex = 4;
            // 
            // IDC_T3
            // 
            this.IDC_T3.Location = new System.Drawing.Point(13, 251);
            this.IDC_T3.Name = "IDC_T3";
            this.IDC_T3.ReadOnly = true;
            this.IDC_T3.Size = new System.Drawing.Size(277, 23);
            this.IDC_T3.TabIndex = 5;
            // 
            // IDC_F1
            // 
            this.IDC_F1.Location = new System.Drawing.Point(340, 162);
            this.IDC_F1.Name = "IDC_F1";
            this.IDC_F1.Size = new System.Drawing.Size(100, 23);
            this.IDC_F1.TabIndex = 6;
            this.IDC_F1.Text = "0";
            this.IDC_F1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // IDC_F2
            // 
            this.IDC_F2.Location = new System.Drawing.Point(340, 206);
            this.IDC_F2.Name = "IDC_F2";
            this.IDC_F2.Size = new System.Drawing.Size(100, 23);
            this.IDC_F2.TabIndex = 7;
            this.IDC_F2.Text = "0";
            this.IDC_F2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // IDC_F3
            // 
            this.IDC_F3.Location = new System.Drawing.Point(340, 250);
            this.IDC_F3.Name = "IDC_F3";
            this.IDC_F3.Size = new System.Drawing.Size(100, 23);
            this.IDC_F3.TabIndex = 8;
            this.IDC_F3.Text = "0";
            this.IDC_F3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // IDC_FOK_BUTTON
            // 
            this.IDC_FOK_BUTTON.Location = new System.Drawing.Point(161, 319);
            this.IDC_FOK_BUTTON.Name = "IDC_FOK_BUTTON";
            this.IDC_FOK_BUTTON.Size = new System.Drawing.Size(75, 23);
            this.IDC_FOK_BUTTON.TabIndex = 9;
            this.IDC_FOK_BUTTON.Text = "OK";
            this.IDC_FOK_BUTTON.UseVisualStyleBackColor = true;
            this.IDC_FOK_BUTTON.Click += new System.EventHandler(this.IDC_FOK_BUTTON_Click);
            // 
            // F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IDC_FOK_BUTTON);
            this.Controls.Add(this.IDC_F3);
            this.Controls.Add(this.IDC_F2);
            this.Controls.Add(this.IDC_F1);
            this.Controls.Add(this.IDC_T3);
            this.Controls.Add(this.IDC_T2);
            this.Controls.Add(this.IDC_T1);
            this.Controls.Add(this.IDC_KF);
            this.Controls.Add(this.IDC_DF);
            this.Controls.Add(this.IDC_F);
            this.Name = "F";
            this.Text = "F";
            this.Load += new System.EventHandler(this.F_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton IDC_F;
        private System.Windows.Forms.RadioButton IDC_DF;
        private System.Windows.Forms.RadioButton IDC_KF;
        private System.Windows.Forms.TextBox IDC_T1;
        private System.Windows.Forms.TextBox IDC_T2;
        private System.Windows.Forms.TextBox IDC_T3;
        private System.Windows.Forms.TextBox IDC_F1;
        private System.Windows.Forms.TextBox IDC_F2;
        private System.Windows.Forms.TextBox IDC_F3;
        private System.Windows.Forms.Button IDC_FOK_BUTTON;
    }
}
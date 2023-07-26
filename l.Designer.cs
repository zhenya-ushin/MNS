
namespace SU
{
    partial class l
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IDC_NEXTl_BUTTON = new System.Windows.Forms.Button();
            this.m_nextl = new System.Windows.Forms.TextBox();
            this.m_npl = new System.Windows.Forms.TextBox();
            this.m_nml = new System.Windows.Forms.TextBox();
            this.m_zl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Индуктивность";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Узел n+";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Узел n-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Генри";
            // 
            // IDC_NEXTl_BUTTON
            // 
            this.IDC_NEXTl_BUTTON.Location = new System.Drawing.Point(84, 248);
            this.IDC_NEXTl_BUTTON.Name = "IDC_NEXTl_BUTTON";
            this.IDC_NEXTl_BUTTON.Size = new System.Drawing.Size(116, 23);
            this.IDC_NEXTl_BUTTON.TabIndex = 4;
            this.IDC_NEXTl_BUTTON.Text = "Следующий";
            this.IDC_NEXTl_BUTTON.UseVisualStyleBackColor = true;
            this.IDC_NEXTl_BUTTON.Click += new System.EventHandler(this.IDC_NEXTl_BUTTON_Click);
            // 
            // m_nextl
            // 
            this.m_nextl.Location = new System.Drawing.Point(147, 38);
            this.m_nextl.Name = "m_nextl";
            this.m_nextl.ReadOnly = true;
            this.m_nextl.Size = new System.Drawing.Size(100, 23);
            this.m_nextl.TabIndex = 5;
            this.m_nextl.Tag = "";
            this.m_nextl.Text = "1";
            this.m_nextl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // m_npl
            // 
            this.m_npl.Location = new System.Drawing.Point(147, 78);
            this.m_npl.Name = "m_npl";
            this.m_npl.Size = new System.Drawing.Size(100, 23);
            this.m_npl.TabIndex = 6;
            this.m_npl.Text = "0";
            this.m_npl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // m_nml
            // 
            this.m_nml.Location = new System.Drawing.Point(147, 120);
            this.m_nml.Name = "m_nml";
            this.m_nml.Size = new System.Drawing.Size(100, 23);
            this.m_nml.TabIndex = 7;
            this.m_nml.Text = "0";
            this.m_nml.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // m_zl
            // 
            this.m_zl.Location = new System.Drawing.Point(147, 159);
            this.m_zl.Name = "m_zl";
            this.m_zl.Size = new System.Drawing.Size(100, 23);
            this.m_zl.TabIndex = 8;
            this.m_zl.Text = "0";
            this.m_zl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // l
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 289);
            this.Controls.Add(this.m_zl);
            this.Controls.Add(this.m_nml);
            this.Controls.Add(this.m_npl);
            this.Controls.Add(this.m_nextl);
            this.Controls.Add(this.IDC_NEXTl_BUTTON);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "l";
            this.Text = "l";
            this.Load += new System.EventHandler(this.l_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button IDC_NEXTl_BUTTON;
        private System.Windows.Forms.TextBox m_nextl;
        private System.Windows.Forms.TextBox m_npl;
        private System.Windows.Forms.TextBox m_nml;
        private System.Windows.Forms.TextBox m_zl;
    }
}
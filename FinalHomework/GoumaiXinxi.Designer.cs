namespace FinalHomework
{
    partial class GoumaiXinxi
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.McTextBox = new System.Windows.Forms.TextBox();
            this.LxrTextBox = new System.Windows.Forms.TextBox();
            this.LxdhTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "商品名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "公司名称：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "联系人：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 432);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "联系电话：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(184, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "数量：";
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Location = new System.Drawing.Point(333, 146);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(207, 35);
            this.NumberTextBox.TabIndex = 6;
            this.NumberTextBox.TextChanged += new System.EventHandler(this.GoumaiXinxics_Load);
            // 
            // McTextBox
            // 
            this.McTextBox.Location = new System.Drawing.Point(333, 282);
            this.McTextBox.Name = "McTextBox";
            this.McTextBox.Size = new System.Drawing.Size(207, 35);
            this.McTextBox.TabIndex = 7;
            // 
            // LxrTextBox
            // 
            this.LxrTextBox.Location = new System.Drawing.Point(333, 352);
            this.LxrTextBox.Name = "LxrTextBox";
            this.LxrTextBox.Size = new System.Drawing.Size(207, 35);
            this.LxrTextBox.TabIndex = 8;
            // 
            // LxdhTextBox
            // 
            this.LxdhTextBox.Location = new System.Drawing.Point(333, 432);
            this.LxdhTextBox.Name = "LxdhTextBox";
            this.LxdhTextBox.Size = new System.Drawing.Size(207, 35);
            this.LxdhTextBox.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(180, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "总价格：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(333, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 24);
            this.label8.TabIndex = 11;
            this.label8.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 55);
            this.button1.TabIndex = 12;
            this.button1.Text = "购买";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GoumaiXinxi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 673);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LxdhTextBox);
            this.Controls.Add(this.LxrTextBox);
            this.Controls.Add(this.McTextBox);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GoumaiXinxi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GoumaiXinxics";
            this.Load += new System.EventHandler(this.GoumaiXinxics_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NumberTextBox;
        private System.Windows.Forms.TextBox McTextBox;
        private System.Windows.Forms.TextBox LxrTextBox;
        private System.Windows.Forms.TextBox LxdhTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}
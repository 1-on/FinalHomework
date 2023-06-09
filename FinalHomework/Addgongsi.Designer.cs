namespace FinalHomework
{
    partial class Addgongsi
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
            this.Submitbutton = new System.Windows.Forms.Button();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.PeopleNameTextBox = new System.Windows.Forms.TextBox();
            this.CompanyNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Submitbutton
            // 
            this.Submitbutton.Location = new System.Drawing.Point(233, 376);
            this.Submitbutton.Name = "Submitbutton";
            this.Submitbutton.Size = new System.Drawing.Size(318, 98);
            this.Submitbutton.TabIndex = 21;
            this.Submitbutton.Text = "确定";
            this.Submitbutton.UseVisualStyleBackColor = true;
            this.Submitbutton.Click += new System.EventHandler(this.Submitbutton_Click);
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(340, 268);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(258, 35);
            this.PhoneTextBox.TabIndex = 18;
            // 
            // PeopleNameTextBox
            // 
            this.PeopleNameTextBox.Location = new System.Drawing.Point(340, 177);
            this.PeopleNameTextBox.Name = "PeopleNameTextBox";
            this.PeopleNameTextBox.Size = new System.Drawing.Size(258, 35);
            this.PeopleNameTextBox.TabIndex = 17;
            // 
            // CompanyNameTextBox
            // 
            this.CompanyNameTextBox.Location = new System.Drawing.Point(340, 96);
            this.CompanyNameTextBox.Name = "CompanyNameTextBox";
            this.CompanyNameTextBox.Size = new System.Drawing.Size(258, 35);
            this.CompanyNameTextBox.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "联系电话";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "联系人";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "公司名称";
            // 
            // Addgongsi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.Submitbutton);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.PeopleNameTextBox);
            this.Controls.Add(this.CompanyNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Addgongsi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新增买方公司";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submitbutton;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.TextBox PeopleNameTextBox;
        private System.Windows.Forms.TextBox CompanyNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
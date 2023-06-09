namespace FinalHomework
{
    partial class RegistratiomForm
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
            this.UserIDTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.Submitbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "确认密码";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "昵称";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 433);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "类型";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // UserIDTextBox
            // 
            this.UserIDTextBox.Location = new System.Drawing.Point(334, 78);
            this.UserIDTextBox.Name = "UserIDTextBox";
            this.UserIDTextBox.Size = new System.Drawing.Size(258, 35);
            this.UserIDTextBox.TabIndex = 5;
            this.UserIDTextBox.TextChanged += new System.EventHandler(this.UserIDTextBox_TextChanged);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(334, 159);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(258, 35);
            this.PasswordTextBox.TabIndex = 6;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(334, 250);
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(258, 35);
            this.ConfirmPasswordTextBox.TabIndex = 7;
            this.ConfirmPasswordTextBox.TextChanged += new System.EventHandler(this.ConfirmPasswordTextBox_TextChanged);
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(334, 339);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(258, 35);
            this.UserNameTextBox.TabIndex = 8;
            this.UserNameTextBox.TextChanged += new System.EventHandler(this.UserNameTextBox_TextChanged);
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Items.AddRange(new object[] {
            "管理员",
            "普通用户"});
            this.TypeComboBox.Location = new System.Drawing.Point(334, 433);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(258, 32);
            this.TypeComboBox.TabIndex = 9;
            this.TypeComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeComboBox_SelectedIndexChanged);
            // 
            // Submitbutton
            // 
            this.Submitbutton.Location = new System.Drawing.Point(203, 519);
            this.Submitbutton.Name = "Submitbutton";
            this.Submitbutton.Size = new System.Drawing.Size(318, 98);
            this.Submitbutton.TabIndex = 10;
            this.Submitbutton.Text = "确定";
            this.Submitbutton.UseVisualStyleBackColor = true;
            this.Submitbutton.Click += new System.EventHandler(this.Submitbutton_Click);
            // 
            // RegistratiomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 723);
            this.Controls.Add(this.Submitbutton);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.ConfirmPasswordTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UserIDTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistratiomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户注册";
            this.Load += new System.EventHandler(this.RegistratiomForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UserIDTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox ConfirmPasswordTextBox;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.Button Submitbutton;
    }
}
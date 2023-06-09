namespace FinalHomework
{
    partial class AddxiaoleiName
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
            this.button1 = new System.Windows.Forms.Button();
            this.McTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DaleiComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 71);
            this.button1.TabIndex = 14;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // McTextBox
            // 
            this.McTextBox.Location = new System.Drawing.Point(362, 230);
            this.McTextBox.Name = "McTextBox";
            this.McTextBox.Size = new System.Drawing.Size(190, 35);
            this.McTextBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(227, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 24);
            this.label3.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(234, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 37);
            this.label4.TabIndex = 16;
            this.label4.Text = "大类：";
            // 
            // DaleiComboBox
            // 
            this.DaleiComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DaleiComboBox.FormattingEnabled = true;
            this.DaleiComboBox.Location = new System.Drawing.Point(362, 61);
            this.DaleiComboBox.Name = "DaleiComboBox";
            this.DaleiComboBox.Size = new System.Drawing.Size(190, 32);
            this.DaleiComboBox.TabIndex = 17;
            // 
            // AddxiaoleiName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DaleiComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.McTextBox);
            this.Controls.Add(this.label1);
            this.Name = "AddxiaoleiName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新增小类";
            this.Load += new System.EventHandler(this.AddxiaoleiName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox McTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox DaleiComboBox;
    }
}
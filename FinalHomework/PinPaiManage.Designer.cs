namespace FinalHomework
{
    partial class PinPaiManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.代码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.修改 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.删除 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.新增 = new System.Windows.Forms.Button();
            this.刷新 = new System.Windows.Forms.Button();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UserIDTextBox = new System.Windows.Forms.TextBox();
            this.Lable1 = new System.Windows.Forms.Label();
            this.查询 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.代码,
            this.名称,
            this.修改,
            this.删除});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(1, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(1405, 408);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // 代码
            // 
            this.代码.HeaderText = "代码";
            this.代码.MinimumWidth = 10;
            this.代码.Name = "代码";
            this.代码.ReadOnly = true;
            // 
            // 名称
            // 
            this.名称.HeaderText = "名称";
            this.名称.MinimumWidth = 10;
            this.名称.Name = "名称";
            // 
            // 修改
            // 
            this.修改.HeaderText = "";
            this.修改.MinimumWidth = 10;
            this.修改.Name = "修改";
            // 
            // 删除
            // 
            this.删除.HeaderText = "";
            this.删除.MinimumWidth = 10;
            this.删除.Name = "删除";
            // 
            // 新增
            // 
            this.新增.Location = new System.Drawing.Point(1, 13);
            this.新增.Name = "新增";
            this.新增.Size = new System.Drawing.Size(165, 50);
            this.新增.TabIndex = 1;
            this.新增.Text = "新增";
            this.新增.UseVisualStyleBackColor = true;
            this.新增.Click += new System.EventHandler(this.新增_Click);
            // 
            // 刷新
            // 
            this.刷新.Location = new System.Drawing.Point(172, 13);
            this.刷新.Name = "刷新";
            this.刷新.Size = new System.Drawing.Size(165, 50);
            this.刷新.TabIndex = 2;
            this.刷新.Text = "刷新";
            this.刷新.UseVisualStyleBackColor = true;
            this.刷新.Click += new System.EventHandler(this.刷新_Click);
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(1055, 22);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(165, 35);
            this.UserNameTextBox.TabIndex = 11;
            this.UserNameTextBox.TextChanged += new System.EventHandler(this.UserNameTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(990, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "名称";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UserIDTextBox
            // 
            this.UserIDTextBox.Location = new System.Drawing.Point(802, 22);
            this.UserIDTextBox.Name = "UserIDTextBox";
            this.UserIDTextBox.Size = new System.Drawing.Size(165, 35);
            this.UserIDTextBox.TabIndex = 9;
            this.UserIDTextBox.TextChanged += new System.EventHandler(this.UserIDTextBox_TextChanged);
            // 
            // Lable1
            // 
            this.Lable1.AutoSize = true;
            this.Lable1.Location = new System.Drawing.Point(714, 25);
            this.Lable1.Name = "Lable1";
            this.Lable1.Size = new System.Drawing.Size(58, 24);
            this.Lable1.TabIndex = 8;
            this.Lable1.Text = "代码";
            this.Lable1.Click += new System.EventHandler(this.Lable1_Click);
            // 
            // 查询
            // 
            this.查询.Location = new System.Drawing.Point(1241, 12);
            this.查询.Name = "查询";
            this.查询.Size = new System.Drawing.Size(165, 50);
            this.查询.TabIndex = 12;
            this.查询.Text = "查询";
            this.查询.UseVisualStyleBackColor = true;
            this.查询.Click += new System.EventHandler(this.查询_Click);
            // 
            // PinPaiManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 767);
            this.Controls.Add(this.查询);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserIDTextBox);
            this.Controls.Add(this.Lable1);
            this.Controls.Add(this.刷新);
            this.Controls.Add(this.新增);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PinPaiManage";
            this.Text = "品牌管理";
            this.Load += new System.EventHandler(this.PinPaiManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 代码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名称;
        private System.Windows.Forms.DataGridViewButtonColumn 修改;
        private System.Windows.Forms.DataGridViewButtonColumn 删除;
        private System.Windows.Forms.Button 新增;
        private System.Windows.Forms.Button 刷新;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserIDTextBox;
        private System.Windows.Forms.Label Lable1;
        private System.Windows.Forms.Button 查询;
    }
}
namespace FinalHomework
{
    partial class UserManage
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Bh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yhm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qxjb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zcrq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.修改 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.删除 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.新增用户 = new System.Windows.Forms.Button();
            this.刷新 = new System.Windows.Forms.Button();
            this.Lable1 = new System.Windows.Forms.Label();
            this.UserIDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TypeTextBox = new System.Windows.Forms.TextBox();
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
            this.Bh,
            this.Yhm,
            this.Nc,
            this.Mm,
            this.Qxjb,
            this.Zcrq,
            this.修改,
            this.删除});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(0, 70);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(1405, 385);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Bh
            // 
            this.Bh.HeaderText = "编号";
            this.Bh.MinimumWidth = 10;
            this.Bh.Name = "Bh";
            this.Bh.ReadOnly = true;
            // 
            // Yhm
            // 
            this.Yhm.HeaderText = "用户名";
            this.Yhm.MinimumWidth = 10;
            this.Yhm.Name = "Yhm";
            this.Yhm.ReadOnly = true;
            // 
            // Nc
            // 
            this.Nc.HeaderText = "昵称";
            this.Nc.MinimumWidth = 10;
            this.Nc.Name = "Nc";
            // 
            // Mm
            // 
            this.Mm.HeaderText = "密码";
            this.Mm.MinimumWidth = 10;
            this.Mm.Name = "Mm";
            // 
            // Qxjb
            // 
            this.Qxjb.HeaderText = "权限级别";
            this.Qxjb.MinimumWidth = 10;
            this.Qxjb.Name = "Qxjb";
            this.Qxjb.ReadOnly = true;
            // 
            // Zcrq
            // 
            this.Zcrq.HeaderText = "注册日期";
            this.Zcrq.MinimumWidth = 10;
            this.Zcrq.Name = "Zcrq";
            this.Zcrq.ReadOnly = true;
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
            // 新增用户
            // 
            this.新增用户.Location = new System.Drawing.Point(0, 13);
            this.新增用户.Name = "新增用户";
            this.新增用户.Size = new System.Drawing.Size(165, 50);
            this.新增用户.TabIndex = 2;
            this.新增用户.Text = "新增用户";
            this.新增用户.UseVisualStyleBackColor = true;
            this.新增用户.Click += new System.EventHandler(this.新增用户_Click);
            // 
            // 刷新
            // 
            this.刷新.Location = new System.Drawing.Point(171, 12);
            this.刷新.Name = "刷新";
            this.刷新.Size = new System.Drawing.Size(165, 50);
            this.刷新.TabIndex = 3;
            this.刷新.Text = "刷新";
            this.刷新.UseVisualStyleBackColor = true;
            this.刷新.Click += new System.EventHandler(this.刷新_Click);
            // 
            // Lable1
            // 
            this.Lable1.AutoSize = true;
            this.Lable1.Location = new System.Drawing.Point(375, 25);
            this.Lable1.Name = "Lable1";
            this.Lable1.Size = new System.Drawing.Size(82, 24);
            this.Lable1.TabIndex = 4;
            this.Lable1.Text = "用户名";
            // 
            // UserIDTextBox
            // 
            this.UserIDTextBox.Location = new System.Drawing.Point(463, 22);
            this.UserIDTextBox.Name = "UserIDTextBox";
            this.UserIDTextBox.Size = new System.Drawing.Size(165, 35);
            this.UserIDTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(651, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "昵称";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(716, 22);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(165, 35);
            this.UserNameTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(901, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "权限";
            // 
            // TypeTextBox
            // 
            this.TypeTextBox.Location = new System.Drawing.Point(966, 22);
            this.TypeTextBox.Name = "TypeTextBox";
            this.TypeTextBox.Size = new System.Drawing.Size(165, 35);
            this.TypeTextBox.TabIndex = 9;
            // 
            // 查询
            // 
            this.查询.Location = new System.Drawing.Point(1164, 12);
            this.查询.Name = "查询";
            this.查询.Size = new System.Drawing.Size(165, 50);
            this.查询.TabIndex = 10;
            this.查询.Text = "查询";
            this.查询.UseVisualStyleBackColor = true;
            this.查询.Click += new System.EventHandler(this.查询_Click);
            // 
            // UserManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 467);
            this.Controls.Add(this.查询);
            this.Controls.Add(this.TypeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserIDTextBox);
            this.Controls.Add(this.Lable1);
            this.Controls.Add(this.刷新);
            this.Controls.Add(this.新增用户);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yhm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qxjb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zcrq;
        private System.Windows.Forms.DataGridViewButtonColumn 修改;
        private System.Windows.Forms.DataGridViewButtonColumn 删除;
        private System.Windows.Forms.Button 新增用户;
        private System.Windows.Forms.Button 刷新;
        private System.Windows.Forms.Label Lable1;
        private System.Windows.Forms.TextBox UserIDTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TypeTextBox;
        private System.Windows.Forms.Button 查询;
    }
}
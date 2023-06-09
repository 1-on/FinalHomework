namespace FinalHomework
{
    partial class MaiFangGongSi
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
            this.查询 = new System.Windows.Forms.Button();
            this.PeopleNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CompanyNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.刷新 = new System.Windows.Forms.Button();
            this.新增公司 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Bh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.联系人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.联系电话 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.修改 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.删除 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // 查询
            // 
            this.查询.Location = new System.Drawing.Point(1164, 12);
            this.查询.Name = "查询";
            this.查询.Size = new System.Drawing.Size(165, 50);
            this.查询.TabIndex = 20;
            this.查询.Text = "查询";
            this.查询.UseVisualStyleBackColor = true;
            this.查询.Click += new System.EventHandler(this.查询_Click);
            // 
            // PeopleNameTextBox
            // 
            this.PeopleNameTextBox.Location = new System.Drawing.Point(966, 22);
            this.PeopleNameTextBox.Name = "PeopleNameTextBox";
            this.PeopleNameTextBox.Size = new System.Drawing.Size(165, 35);
            this.PeopleNameTextBox.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(878, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "联系人";
            // 
            // CompanyNameTextBox
            // 
            this.CompanyNameTextBox.Location = new System.Drawing.Point(707, 22);
            this.CompanyNameTextBox.Name = "CompanyNameTextBox";
            this.CompanyNameTextBox.Size = new System.Drawing.Size(165, 35);
            this.CompanyNameTextBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(585, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "公司名称";
            // 
            // 刷新
            // 
            this.刷新.Location = new System.Drawing.Point(171, 12);
            this.刷新.Name = "刷新";
            this.刷新.Size = new System.Drawing.Size(165, 50);
            this.刷新.TabIndex = 13;
            this.刷新.Text = "刷新";
            this.刷新.UseVisualStyleBackColor = true;
            this.刷新.Click += new System.EventHandler(this.刷新_Click);
            // 
            // 新增公司
            // 
            this.新增公司.Location = new System.Drawing.Point(0, 13);
            this.新增公司.Name = "新增公司";
            this.新增公司.Size = new System.Drawing.Size(165, 50);
            this.新增公司.TabIndex = 12;
            this.新增公司.Text = "新增公司";
            this.新增公司.UseVisualStyleBackColor = true;
            this.新增公司.Click += new System.EventHandler(this.新增公司_Click);
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
            this.名称,
            this.联系人,
            this.联系电话,
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
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(1405, 385);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Bh
            // 
            this.Bh.HeaderText = "编号";
            this.Bh.MinimumWidth = 10;
            this.Bh.Name = "Bh";
            this.Bh.ReadOnly = true;
            // 
            // 名称
            // 
            this.名称.HeaderText = "名称";
            this.名称.MinimumWidth = 10;
            this.名称.Name = "名称";
            // 
            // 联系人
            // 
            this.联系人.HeaderText = "联系人";
            this.联系人.MinimumWidth = 10;
            this.联系人.Name = "联系人";
            // 
            // 联系电话
            // 
            this.联系电话.HeaderText = "联系电话";
            this.联系电话.MinimumWidth = 10;
            this.联系电话.Name = "联系电话";
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
            // MaiFangGongSi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 467);
            this.Controls.Add(this.查询);
            this.Controls.Add(this.PeopleNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CompanyNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.刷新);
            this.Controls.Add(this.新增公司);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MaiFangGongSi";
            this.Text = "买方公司表管理";
            this.Load += new System.EventHandler(this.MaiFangGongSi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 查询;
        private System.Windows.Forms.TextBox PeopleNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CompanyNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button 刷新;
        private System.Windows.Forms.Button 新增公司;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bh;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 联系人;
        private System.Windows.Forms.DataGridViewTextBoxColumn 联系电话;
        private System.Windows.Forms.DataGridViewButtonColumn 修改;
        private System.Windows.Forms.DataGridViewButtonColumn 删除;
    }
}
namespace FinalHomework
{
    partial class JiaDian
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
            this.McTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PpTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.刷新 = new System.Windows.Forms.Button();
            this.新增家电 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Bh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.品牌 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.小类代码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.型号规格 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.单价 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.库存量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            // McTextBox
            // 
            this.McTextBox.Location = new System.Drawing.Point(966, 22);
            this.McTextBox.Name = "McTextBox";
            this.McTextBox.Size = new System.Drawing.Size(165, 35);
            this.McTextBox.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(901, 22);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "名称";
            // 
            // PpTextBox
            // 
            this.PpTextBox.Location = new System.Drawing.Point(716, 22);
            this.PpTextBox.Name = "PpTextBox";
            this.PpTextBox.Size = new System.Drawing.Size(165, 35);
            this.PpTextBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(651, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "品牌";
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
            // 新增家电
            // 
            this.新增家电.Location = new System.Drawing.Point(0, 13);
            this.新增家电.Name = "新增家电";
            this.新增家电.Size = new System.Drawing.Size(165, 50);
            this.新增家电.TabIndex = 12;
            this.新增家电.Text = "新增家电";
            this.新增家电.UseVisualStyleBackColor = true;
            this.新增家电.Click += new System.EventHandler(this.新增家电_Click);
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
            this.品牌,
            this.名称,
            this.小类代码,
            this.型号规格,
            this.单价,
            this.库存量,
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
            // 品牌
            // 
            this.品牌.HeaderText = "品牌";
            this.品牌.MinimumWidth = 10;
            this.品牌.Name = "品牌";
            // 
            // 名称
            // 
            this.名称.HeaderText = "名称";
            this.名称.MinimumWidth = 10;
            this.名称.Name = "名称";
            // 
            // 小类代码
            // 
            this.小类代码.HeaderText = "小类代码";
            this.小类代码.MinimumWidth = 10;
            this.小类代码.Name = "小类代码";
            // 
            // 型号规格
            // 
            this.型号规格.HeaderText = "型号规格";
            this.型号规格.MinimumWidth = 10;
            this.型号规格.Name = "型号规格";
            // 
            // 单价
            // 
            this.单价.HeaderText = "单价";
            this.单价.MinimumWidth = 10;
            this.单价.Name = "单价";
            // 
            // 库存量
            // 
            this.库存量.HeaderText = "库存量";
            this.库存量.MinimumWidth = 10;
            this.库存量.Name = "库存量";
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
            // JiaDian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 467);
            this.Controls.Add(this.查询);
            this.Controls.Add(this.McTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PpTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.刷新);
            this.Controls.Add(this.新增家电);
            this.Controls.Add(this.dataGridView1);
            this.Name = "JiaDian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "家电管理";
            this.Load += new System.EventHandler(this.JiaDian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 查询;
        private System.Windows.Forms.TextBox McTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PpTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button 刷新;
        private System.Windows.Forms.Button 新增家电;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bh;
        private System.Windows.Forms.DataGridViewTextBoxColumn 品牌;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 小类代码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 型号规格;
        private System.Windows.Forms.DataGridViewTextBoxColumn 单价;
        private System.Windows.Forms.DataGridViewTextBoxColumn 库存量;
        private System.Windows.Forms.DataGridViewButtonColumn 修改;
        private System.Windows.Forms.DataGridViewButtonColumn 删除;
    }
}
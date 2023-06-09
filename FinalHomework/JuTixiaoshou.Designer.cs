namespace FinalHomework
{
    partial class JuTixiaoshou
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
            this.公司名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.销售数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.销售日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.销售金额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.查看明细 = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.公司名称,
            this.销售数量,
            this.销售日期,
            this.销售金额,
            this.查看明细});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(0, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(1405, 385);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // 公司名称
            // 
            this.公司名称.HeaderText = "公司名称";
            this.公司名称.MinimumWidth = 10;
            this.公司名称.Name = "公司名称";
            this.公司名称.ReadOnly = true;
            // 
            // 销售数量
            // 
            this.销售数量.HeaderText = "销售数量";
            this.销售数量.MinimumWidth = 10;
            this.销售数量.Name = "销售数量";
            this.销售数量.ReadOnly = true;
            // 
            // 销售日期
            // 
            this.销售日期.HeaderText = "销售日期";
            this.销售日期.MinimumWidth = 10;
            this.销售日期.Name = "销售日期";
            this.销售日期.ReadOnly = true;
            // 
            // 销售金额
            // 
            this.销售金额.HeaderText = "销售金额";
            this.销售金额.MinimumWidth = 10;
            this.销售金额.Name = "销售金额";
            this.销售金额.ReadOnly = true;
            // 
            // 查看明细
            // 
            this.查看明细.HeaderText = "";
            this.查看明细.MinimumWidth = 10;
            this.查看明细.Name = "查看明细";
            // 
            // JuTixiaoshou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 479);
            this.Controls.Add(this.dataGridView1);
            this.Name = "JuTixiaoshou";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "具体销售单";
            this.Load += new System.EventHandler(this.GuTixiaoshou_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 公司名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 销售数量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 销售日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 销售金额;
        private System.Windows.Forms.DataGridViewButtonColumn 查看明细;
    }
}
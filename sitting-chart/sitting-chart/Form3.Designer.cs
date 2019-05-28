namespace sitting_chart
{
    partial class Form3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lesson01 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lesson02 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lesson03 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lesson04 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lesson05 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lesson06 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lesson07 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lesson08 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data,
            this.lesson01,
            this.lesson02,
            this.lesson03,
            this.lesson04,
            this.lesson05,
            this.lesson06,
            this.lesson07,
            this.lesson08});
            this.dataGridView1.Location = new System.Drawing.Point(25, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(593, 609);
            this.dataGridView1.TabIndex = 0;
            // 
            // data
            // 
            this.data.HeaderText = "日付";
            this.data.Name = "data";
            this.data.Width = 70;
            // 
            // lesson01
            // 
            this.lesson01.HeaderText = "1講目";
            this.lesson01.Name = "lesson01";
            this.lesson01.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.lesson01.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.lesson01.Width = 60;
            // 
            // lesson02
            // 
            this.lesson02.HeaderText = "2講目";
            this.lesson02.Name = "lesson02";
            this.lesson02.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.lesson02.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.lesson02.Width = 60;
            // 
            // lesson03
            // 
            this.lesson03.HeaderText = "3講目";
            this.lesson03.Name = "lesson03";
            this.lesson03.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.lesson03.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.lesson03.Width = 60;
            // 
            // lesson04
            // 
            this.lesson04.HeaderText = "4講目";
            this.lesson04.Name = "lesson04";
            this.lesson04.Width = 60;
            // 
            // lesson05
            // 
            this.lesson05.HeaderText = "5講目";
            this.lesson05.Name = "lesson05";
            this.lesson05.Width = 60;
            // 
            // lesson06
            // 
            this.lesson06.HeaderText = "6講目";
            this.lesson06.Name = "lesson06";
            this.lesson06.Width = 60;
            // 
            // lesson07
            // 
            this.lesson07.HeaderText = "7講目";
            this.lesson07.Name = "lesson07";
            this.lesson07.Width = 60;
            // 
            // lesson08
            // 
            this.lesson08.HeaderText = "8講目";
            this.lesson08.Name = "lesson08";
            this.lesson08.Width = 60;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Location = new System.Drawing.Point(25, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(173, 19);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(519, 34);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(99, 16);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "長期休みモード";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 711);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "s";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewCheckBoxColumn lesson01;
        private System.Windows.Forms.DataGridViewCheckBoxColumn lesson02;
        private System.Windows.Forms.DataGridViewCheckBoxColumn lesson03;
        private System.Windows.Forms.DataGridViewCheckBoxColumn lesson04;
        private System.Windows.Forms.DataGridViewCheckBoxColumn lesson05;
        private System.Windows.Forms.DataGridViewCheckBoxColumn lesson06;
        private System.Windows.Forms.DataGridViewCheckBoxColumn lesson07;
        private System.Windows.Forms.DataGridViewCheckBoxColumn lesson08;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
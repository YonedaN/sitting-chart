using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // カラム数を指定
            dataGridView1.ColumnCount = 5;

            // カラム名を指定
            dataGridView1.Columns[0].HeaderText = "i";
            dataGridView1.Columns[1].HeaderText = "点数";
            dataGridView1.Columns[2].HeaderText = "氏名";
            dataGridView1.Columns[3].HeaderText = "クラス名";
            dataGridView1.Columns[4].HeaderText = "クラス名";

            // データを追加
            //dataGridView1.Rows.Add("国語", 90, "田中　一郎", "A");
            //dataGridView1.Rows.Add("数学", 50, "鈴木　二郎", "A");
            //dataGridView1.Rows.Add("英語", 90, "佐藤　三郎", "B");

            var today = DateTime.Now;
            var date = new DateTime( today.Year, today.Month, 1 );
            var thisMonth = date.Month;
            while( date.Month == thisMonth )
            {
                dataGridView1.Rows.Add(date.ToString("yyyy-MM-dd"));
                date = date.AddDays(1);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

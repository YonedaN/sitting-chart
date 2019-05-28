using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sitting_chart
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 削除ボタン列かどうかを確認 
            if (e.ColumnIndex == this.dataGridView1.Columns["delete"].Index)
            {
                if (DialogResult.Yes == MessageBox.Show("削除しますか", "確認",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    this.dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
    }
}

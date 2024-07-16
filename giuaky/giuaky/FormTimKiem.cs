using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace giuaky
{
    public partial class FormTimKiem : Form
    {
        public string SearchCondition { get; private set; }
        public FormTimKiem()
        {
            InitializeComponent();
        }
        public void SetColumnName(string columnName)
        {
            lb_tencot.Text = $"Tên cột được tìm: {columnName}";
        }

        private void lb_tencot_Click(object sender, EventArgs e)
        {

        }

        private void tb_locdk_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_huylocdk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void lb_locdk_Click(object sender, EventArgs e)
        {
            // Append the search condition
            if (!string.IsNullOrEmpty(tb_locdk.Text))
            {
                string newCondition = $"{lb_tencot.Text} LIKE '%{tb_locdk.Text}%'";

                if (string.IsNullOrEmpty(SearchCondition))
                {
                    SearchCondition = newCondition;
                }
                else
                {
                    SearchCondition += $" AND {newCondition}";
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

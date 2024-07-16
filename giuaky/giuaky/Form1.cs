using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace giuaky
{
    public partial class FormGK2 : Form
    {
        private FormTimKiem formTimKiem;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem toolStripMenuItemSearch;
        public FormGK2()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            // Initialize context menu
            contextMenuStrip = new ContextMenuStrip();
            toolStripMenuItemSearch = new ToolStripMenuItem("Tìm kiếm");
            contextMenuStrip.Items.Add(toolStripMenuItemSearch);
            dgv_data.CellFormatting += dgv_data_CellFormatting;

            // Assign the context menu to the DataGridView
            dgv_data.ContextMenuStrip = contextMenuStrip;

            // Add context menu event
            toolStripMenuItemSearch.Click += ToolStripMenuItemSearch_Click;

            // Initialize FormTimKiem
            formTimKiem = new FormTimKiem();
        }

        private void ToolStripMenuItemSearch_Click(object sender, EventArgs e)
        {
            if (dgv_data.CurrentCell != null)
            {
                string columnName = dgv_data.Columns[dgv_data.CurrentCell.ColumnIndex].HeaderText;
                formTimKiem.SetColumnName(columnName);

                if (formTimKiem.ShowDialog() == DialogResult.OK)
                {
                    string searchCondition = formTimKiem.SearchCondition;
                    ApplySearchCondition(searchCondition);
                }
            }
        }

        private void ApplySearchCondition(string searchCondition)
        {
            if (!string.IsNullOrEmpty(searchCondition))
            {
                string query = $@"
            SELECT sv.sMaSV as 'Mã sinh viên', sv.sHoTen as 'Họ và tên', sv.dNgaySinh as 'Ngày sinh', mh.sTenHocPhan as 'Tên môn học',
                   (0.3 * d.fDiemQT + 0.7 * d.fDiemCK, 1) AS 'Điểm môn học'
            FROM tblSINHVIEN sv
            JOIN tblDIEM d ON sv.sMaSV = d.sMaSV
            JOIN tblMONHOC mh ON d.sMaHocPhan = mh.sMaHocPhan
            WHERE {searchCondition}";

                try
                {
                    DataTable dt = ExecuteQuery(query);
                    dgv_data.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi trong quá trình tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Nếu searchCondition rỗng, hiển thị tất cả dữ liệu
                LoadStudentData();
            }
        }

        private void LoadStudentData()
        {
            string query = @"
        SELECT sv.sMaSV as 'Mã sinh viên', sv.sHoTen as 'Họ và tên', sv.dNgaySinh as 'Ngày sinh', mh.sTenHocPhan as 'Tên môn học',
              (0.3 * d.fDiemQT + 0.7 * d.fDiemCK) AS 'Điểm môn học'
        FROM tblSINHVIEN sv
        JOIN tblDIEM d ON sv.sMaSV = d.sMaSV
        JOIN tblMONHOC mh ON d.sMaHocPhan = mh.sMaHocPhan";

            DataTable dt = ExecuteQuery(query);
            dgv_data.DataSource = dt;
        }

        private void dgv_data_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgv_data.Columns["Điểm môn học"].Index && e.Value != null)
            {
                double value;
                if (double.TryParse(e.Value.ToString(), out value))
                {
                    e.Value = value.ToString("0.0"); // Định dạng lại số với 1 chữ số thập phân
                    e.FormattingApplied = true;
                }
            }
        }

        private DataTable ExecuteQuery(string query, params SqlParameter[] parameters)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=QLSV1;Integrated Security=True;"; // Update with your connection string
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

            private void rb_tatca_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_tatca.Checked)
            {
                // Load and display the student data
                LoadStudentData();
            }
        }

        private void rb_ctdt_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_ctdt.Checked)
            {
                // Enable the ComboBox
                cb_ctdt.Enabled = true;

                // Load the list of training programs
                LoadTrainingPrograms();
            }
            else
            {
                // Disable the ComboBox and clear selection
                cb_ctdt.Enabled = false;
                cb_ctdt.SelectedIndex = -1;
            }
        }

        private void LoadTrainingPrograms()
        {
            // Clear existing items
            cb_ctdt.Items.Clear();

            // Add the training programs (hard-coded for now)
            //cb_ctdt.Items.Add("CTĐT2017");
            //cb_ctdt.Items.Add("CTĐT2022");

            // Optionally, you can load the programs from the database
           string query = "SELECT sMaCTDT FROM tblCTDT";
            DataTable dt = ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                 cb_ctdt.Items.Add(row["sMaCTDT"].ToString());
            }
        }

        private void cb_ctdt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_ctdt.SelectedItem != null)
            {
                string selectedCTDT = cb_ctdt.SelectedItem.ToString();

                // SQL query to get students and their scores based on the selected CTDT
                string query = @"
            SELECT sv.sMaSV as 'Mã sinh viên', sv.sHoTen as 'Họ và tên', sv.dNgaySinh as 'Ngày sinh', mh.sTenHocPhan as 'Tên môn học',
               (0.3 * d.fDiemQT + 0.7 * d.fDiemCK) AS 'Điểm môn học'
            FROM tblSINHVIEN sv
            JOIN tblDIEM d ON sv.sMaSV = d.sMaSV
            JOIN tblMONHOC mh ON d.sMaHocPhan = mh.sMaHocPhan
            WHERE mh.sMaCTDT = @sMaCTDT";

                // Execute query with parameter
                DataTable dt = ExecuteQuery(query, new SqlParameter("@sMaCTDT", selectedCTDT));
                dgv_data.DataSource = dt;
            }
        }

        private void dgv_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gb_ttsv_Enter(object sender, EventArgs e)
        {

        }

        private void FormGK2_Load(object sender, EventArgs e)
        {
            // Set RadioButton "Tất cả" as default
            rb_tatca.Checked = true;

            // Load and display the student data
            LoadStudentData();

            // Initially disable ComboBox
            cb_ctdt.Enabled = false;
        }
    }
}

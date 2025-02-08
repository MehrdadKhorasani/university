using System;
using System.Data;
using System.Windows.Forms;

namespace Library
{
    public partial class ManageFineForm : Form
    {
        private int selectedBorrowId = -1;

        public ManageFineForm()
        {
            InitializeComponent();
            LoadOverdueBorrows();
            dataGridViewFines.CellClick += DataGridViewFines_CellClick;
            btnUpdateFine.Click += BtnUpdateFine_Click;
            btnSearch.Click += BtnSearch_Click;
        }

        private void DataGridViewFines_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var cellValue = dataGridViewFines.Rows[e.RowIndex].Cells["BRNo"].Value;
            if (cellValue == DBNull.Value || cellValue == null)
            {
                MessageBox.Show("لطفاً ردیف معتبر را انتخاب کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // جلوگیری از انتخاب ردیف خالی
            }

            selectedBorrowId = Convert.ToInt32(dataGridViewFines.Rows[e.RowIndex].Cells["BRNo"].Value);

            // نمایش ابزارهای مدیریت جریمه
            txtFineAmount.Visible = true;
            cmbFineAction.Visible = true;
            btnUpdateFine.Visible = true;
        }

        private void LoadOverdueBorrows()
        {
            string query = @"
                SELECT BRNo, MNo, BNo, BFine, BEDate 
                FROM Borrow 
                WHERE DATEDIFF(day, BEDate, GETDATE()) > 7 AND BRRET = 'No'";
            DataTable overdueBorrows = DatabaseHelper.GetData(query);
            dataGridViewFines.DataSource = overdueBorrows;

            // پنهان کردن ابزارهای مدیریت جریمه
            txtFineAmount.Visible = false;
            cmbFineAction.Visible = false;
            btnUpdateFine.Visible = false;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string borrowId = txtSearchBorrowId.Text.Trim();
            if (string.IsNullOrWhiteSpace(borrowId))
            {
                LoadOverdueBorrows();
                return;
            }

            string query = @"
                SELECT BRNo, MNo, BNo, BFine, BEDate 
                FROM Borrow 
                WHERE BRNo = @BRNo AND DATEDIFF(day, BEDate, GETDATE()) > 7 AND BRRET = 'No'";
            DataTable result = DatabaseHelper.GetData(query, command =>
            {
                command.Parameters.AddWithValue("@BRNo", borrowId);
            });

            if (result.Rows.Count == 0)
            {
                MessageBox.Show("این امانت شامل جریمه نمی‌شود یا وجود ندارد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadOverdueBorrows();
            }
            else
            {
                dataGridViewFines.DataSource = result;
            }
        }

        private void BtnUpdateFine_Click(object sender, EventArgs e)
        {
            if (selectedBorrowId == -1) return;

            string fineAction = cmbFineAction.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(fineAction))
            {
                MessageBox.Show("لطفاً یک عملیات انتخاب کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtFineAmount.Text.Trim(), out decimal fineAmount) || fineAmount <= 0)
            {
                MessageBox.Show("لطفاً یک مبلغ معتبر وارد کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // دریافت اطلاعات فعلی جریمه و بدهی
                string query = "SELECT MNo, BFine FROM Borrow WHERE BRNo = @BRNo";
                DataTable result = DatabaseHelper.GetData(query, command =>
                {
                    command.Parameters.AddWithValue("@BRNo", selectedBorrowId);
                });

                if (result.Rows.Count == 0)
                {
                    MessageBox.Show("امانتی با این BRNo یافت نشد.");
                    return;
                }

                string memberMNo = result.Rows[0]["MNo"].ToString();
                decimal currentFine = Convert.ToDecimal(result.Rows[0]["BFine"]);

                // عملیات پرداخت جریمه
                if (fineAction == "پرداخت جریمه")
                {
                    if (fineAmount > currentFine)
                    {
                        MessageBox.Show($"مبلغ وارد شده ({fineAmount}) بیشتر از جریمه فعلی ({currentFine}) است.",
                                        "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // کاهش جریمه و بدهی کاربر
                    DatabaseHelper.ExecuteQuery("UPDATE Borrow SET BFine = BFine - @Amount WHERE BRNo = @BRNo", command =>
                    {
                        command.Parameters.AddWithValue("@Amount", fineAmount);
                        command.Parameters.AddWithValue("@BRNo", selectedBorrowId);
                    });

                    DatabaseHelper.ExecuteQuery("UPDATE Member SET MDebt = MDebt - @Amount WHERE MNo = @MNo", command =>
                    {
                        command.Parameters.AddWithValue("@Amount", fineAmount);
                        command.Parameters.AddWithValue("@MNo", memberMNo);
                    });
                }
                // عملیات افزایش جریمه
                else if (fineAction == "افزایش جریمه")
                {
                    // افزایش جریمه و بدهی کاربر
                    DatabaseHelper.ExecuteQuery("UPDATE Borrow SET BFine = BFine + @Amount WHERE BRNo = @BRNo", command =>
                    {
                        command.Parameters.AddWithValue("@Amount", fineAmount);
                        command.Parameters.AddWithValue("@BRNo", selectedBorrowId);
                    });

                    DatabaseHelper.ExecuteQuery("UPDATE Member SET MDebt = MDebt + @Amount WHERE MNo = @MNo", command =>
                    {
                        command.Parameters.AddWithValue("@Amount", fineAmount);
                        command.Parameters.AddWithValue("@MNo", memberMNo);
                    });
                }

                MessageBox.Show("عملیات با موفقیت انجام شد.", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadOverdueBorrows();

                // ریست کردن ابزارها
                txtSearchBorrowId.Clear();
                txtFineAmount.Visible = false;
                cmbFineAction.Visible = false;
                btnUpdateFine.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطا در به‌روزرسانی جریمه: {ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

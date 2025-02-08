using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadDashboardData();
        }
        private void menuExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }
        private void menuAddBook_Click(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm();
            addBookForm.ShowDialog();
        }
        
        private void menuEditEditBook_Click(object sender, EventArgs e)
        {
            EditBookForm editBookForm = new EditBookForm();
            editBookForm.ShowDialog();
        }

        private void menuEditDeleteBook_click(object sender, EventArgs e) {
            DeleteBookForm deleteBookForm= new DeleteBookForm();
            deleteBookForm.ShowDialog();
        }


        private void menuEdit_Click(object sender, EventArgs e)
        {

        }

        private void menuEditAddMember_Click(object sender, EventArgs e)
        {
            AddMemberForm addMemberForm = new AddMemberForm();
            addMemberForm.ShowDialog();

        }

        private void menuEditEditMember_Click(object sender, EventArgs e)
        {
            EditMemberForm editMemberForm = new EditMemberForm();
            editMemberForm.ShowDialog();
        }

        private void menuEditDeleteMember_Click(object sender, EventArgs e)
        {
            DeleteMemberForm deleteMemberForm = new DeleteMemberForm();
            deleteMemberForm.ShowDialog();
        }

        private void menuBorrowBook_Click(object sender, EventArgs e)
        {
            AddBorrowForm addBorrowForm = new AddBorrowForm();
            addBorrowForm.ShowDialog();
        }

        private void menuSettingExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }

        private void menuReturnRenewBook_Click(object sender, EventArgs e)
        {
            ManageBorrowsForm manageBorrowsForm = new ManageBorrowsForm();
            manageBorrowsForm.ShowDialog();
        }

        private void menuReturnFine_Click(object sender, EventArgs e)
        {
            ManageFineForm manageFineForm = new ManageFineForm();
            manageFineForm.ShowDialog();
        }

        private void menuSettingChangePassword_Click(object sender, EventArgs e)
        {
            ManagePasswordForm managePasswordForm = new ManagePasswordForm();
            managePasswordForm.ShowDialog();
        }

        private void رزروکتابToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddReserveForm addReserveForm = new AddReserveForm();
            addReserveForm.ShowDialog();
        }

        private void menuEditReserve_Click(object sender, EventArgs e)
        {
            EditReserveForm editReserveForm = new EditReserveForm();   
            editReserveForm.ShowDialog();
        }

        private void menuReportsBorrowings_Click(object sender, EventArgs e)
        {
            BorrowsReportForm borrowsReportForm = new BorrowsReportForm();
            borrowsReportForm.ShowDialog();
        }

        private void menuReportReserves_Click(object sender, EventArgs e)
        {
            ReservesReportForm reservesReportForm = new ReservesReportForm();
            reservesReportForm.ShowDialog();
        }

        private void MenuReportMembers_Click(object sender, EventArgs e)
        {
            MemberReportForm memberReportForm = new MemberReportForm();
            memberReportForm.ShowDialog();
        }

        private void MenuReportBooks_Click(object sender, EventArgs e)
        {
            BookReportForm bookReportForm = new BookReportForm();
            bookReportForm.ShowDialog();
        }

        private void LoadDashboardData()
        {
            try
            {
                // دریافت تعداد کل کتاب‌ها، کاربران، امانات و رزروهای جاری
                lblAllBooksNumber.Text = DatabaseHelper.ExecuteScalar("SELECT COUNT(*) FROM Book")?.ToString() ?? "0";
                lblAllMembersNumber.Text = DatabaseHelper.ExecuteScalar("SELECT COUNT(*) FROM Member")?.ToString() ?? "0";
                lblCurrentBorrowsNumber.Text = DatabaseHelper.ExecuteScalar("SELECT COUNT(*) FROM Borrow WHERE BRRET = 'No'")?.ToString() ?? "0";
                lblCurrentReservesNumber.Text = DatabaseHelper.ExecuteScalar("SELECT COUNT(*) FROM Reserve WHERE isBorrowed = 'No'")?.ToString() ?? "0";

                // داده‌های آماری با کنترل `NULL`
                object avgBorrowDays = DatabaseHelper.ExecuteScalar("SELECT AVG(DATEDIFF(day, BSdate, BRRDate)) FROM Borrow WHERE BRRDate IS NOT NULL");
                lblBorrowedAvgNumber.Text = avgBorrowDays != null && avgBorrowDays != DBNull.Value
                    ? Convert.ToInt32(Math.Floor(Convert.ToDecimal(avgBorrowDays))).ToString("N0")
                    : "0";

                lblAllDebtersNumber.Text = DatabaseHelper.ExecuteScalar("SELECT COUNT(*) FROM Member WHERE MDebt > 0")?.ToString() ?? "0";
                lblAllBorrowedBooksNumber.Text = DatabaseHelper.ExecuteScalar("SELECT COUNT(*) FROM Borrow WHERE BRRET = 'No'")?.ToString() ?? "0";
                lblAvailableBooksNumber.Text = DatabaseHelper.ExecuteScalar("SELECT COUNT(*) FROM Book WHERE BCCNT > 0")?.ToString() ?? "0";

                // محاسبه مجموع جریمه‌ها
                object fineResult = DatabaseHelper.ExecuteScalar("SELECT SUM(MDebt) FROM Member");
                lblAllFinesNumber.Text = fineResult != null && fineResult != DBNull.Value
                    ? Convert.ToInt32(Math.Floor(Convert.ToDecimal(fineResult))).ToString("N0")
                    : "0";

                // محاسبه درصد بازگشت به‌موقع
                object returnPercentageResult = DatabaseHelper.ExecuteScalar(@"
                    SELECT (COUNT(CASE WHEN BRRDate <= BEDate THEN 1 END) * 100.0 / COUNT(*)) 
                    FROM Borrow WHERE BRRDate IS NOT NULL");

                lblReturnPercentageNumber.Text = returnPercentageResult != null && returnPercentageResult != DBNull.Value
                    ? Convert.ToInt32(Math.Floor(Convert.ToDecimal(returnPercentageResult))).ToString() + "%"
                    : "0%";

                // دریافت 3 کتاب پرامانت
                DataTable topBooks = DatabaseHelper.GetData(@"
                    SELECT TOP 3 b.BTitle FROM Borrow br 
                    JOIN Book b ON br.BNo = b.BNo 
                    GROUP BY b.BTitle 
                    ORDER BY COUNT(*) DESC");

                List<string> booksList = topBooks.AsEnumerable()
                    .Select(row => row["BTitle"].ToString())
                    .ToList();

                while (booksList.Count < 3)
                {
                    booksList.Add("بدون داده");
                }

                lblFaveBooksNames.Text = string.Join("  -  ", booksList);


                // دریافت 3 کاربر پرامانت
                // 👤 دریافت 3 کاربر پرامانت با نام و نام خانوادگی
                DataTable topUsers = DatabaseHelper.GetData(@"
                    SELECT TOP 3 m.MName, m.MLastName FROM Borrow br 
                    JOIN Member m ON br.MNo = m.MNo 
                    GROUP BY m.MName, m.MLastName
                    ORDER BY COUNT(*) DESC");

                List<string> usersList = topUsers.AsEnumerable()
                    .Select(row => $"{row["MName"].ToString().Trim()} {row["MLastName"].ToString().Trim()}")
                    .ToList();

                while (usersList.Count < 3)
                {
                    usersList.Add("بدون داده");
                }

                lblActiveMembersNames.Text = string.Join("  -  ", usersList);

                // دریافت 3 روز شلوغ بر اساس تعداد امانات
                DataTable busiestDays = DatabaseHelper.GetData(@"
                    SELECT TOP 3 DATENAME(WEEKDAY, BSdate) AS BusyDay FROM Borrow
                    GROUP BY DATENAME(WEEKDAY, BSdate)
                    ORDER BY COUNT(*) DESC");

                Dictionary<string, string> weekDaysFA = new Dictionary<string, string>()
                {
                    { "Saturday", "شنبه" },
                    { "Sunday", "یکشنبه" },
                    { "Monday", "دوشنبه" },
                    { "Tuesday", "سه‌شنبه" },
                    { "Wednesday", "چهارشنبه" },
                    { "Thursday", "پنج‌شنبه" },
                    { "Friday", "جمعه" }
                };

                lblDaysNames.Text = busiestDays.Rows.Count > 0
                    ? string.Join("  -  ", busiestDays.AsEnumerable().Select(row =>
                        weekDaysFA.ContainsKey(row["BusyDay"].ToString())
                            ? weekDaysFA[row["BusyDay"].ToString()]
                            : row["BusyDay"].ToString()))
                    : "داده‌ای موجود نیست";
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در بارگذاری اطلاعات داشبورد: " + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDashboardData();
        }
    }
}
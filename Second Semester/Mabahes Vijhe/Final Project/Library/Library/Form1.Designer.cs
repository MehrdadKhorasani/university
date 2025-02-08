using System;
using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    partial class Form1 : Form
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditAddBook = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditEditBook = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditDeleteBook = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuEditAddMember = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditEditMember = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditDeleteMember = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBorrow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBorrowBook = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReturnRenewBook = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReserveBook = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditReserve = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReturnFine = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReports = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReportsBorrowings = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReportReserves = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuReportMembers = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuReportBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettingChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSettingExit = new System.Windows.Forms.ToolStripMenuItem();
            this.GBGeneral = new System.Windows.Forms.GroupBox();
            this.lblCurrentReservesNumber = new System.Windows.Forms.Label();
            this.lblCurrentReserves = new System.Windows.Forms.Label();
            this.lblCurrentBorrowsNumber = new System.Windows.Forms.Label();
            this.lblCurrentBorrows = new System.Windows.Forms.Label();
            this.lblAllMembersNumber = new System.Windows.Forms.Label();
            this.lblAllMembers = new System.Windows.Forms.Label();
            this.lblAllBooksNumber = new System.Windows.Forms.Label();
            this.lblAllBooks = new System.Windows.Forms.Label();
            this.GBPolitics = new System.Windows.Forms.GroupBox();
            this.lblAvailableBooksNumber = new System.Windows.Forms.Label();
            this.lblAvailableBooks = new System.Windows.Forms.Label();
            this.lblAllBorrowedBooksNumber = new System.Windows.Forms.Label();
            this.lblAllBorrowedBooks = new System.Windows.Forms.Label();
            this.lblReturnPercentageNumber = new System.Windows.Forms.Label();
            this.lblReturnPercentage = new System.Windows.Forms.Label();
            this.lblBorrowedAvgNumber = new System.Windows.Forms.Label();
            this.lblBorrowedAvg = new System.Windows.Forms.Label();
            this.lblAllDebtersNumber = new System.Windows.Forms.Label();
            this.lblAllDebters = new System.Windows.Forms.Label();
            this.lblAllFinesNumber = new System.Windows.Forms.Label();
            this.lblAllFines = new System.Windows.Forms.Label();
            this.GBAnalytic = new System.Windows.Forms.GroupBox();
            this.lblDaysNames = new System.Windows.Forms.Label();
            this.lblActiveMembersNames = new System.Windows.Forms.Label();
            this.lblFaveBooksNames = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.lblActiveMembers = new System.Windows.Forms.Label();
            this.lblFaveBooks = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.GBGeneral.SuspendLayout();
            this.GBPolitics.SuspendLayout();
            this.GBAnalytic.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEdit,
            this.menuBorrow,
            this.menuReports,
            this.menuSetting});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // menuEdit
            // 
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditAddBook,
            this.menuEditEditBook,
            this.menuEditDeleteBook,
            this.toolStripSeparator1,
            this.menuEditAddMember,
            this.menuEditEditMember,
            this.menuEditDeleteMember});
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(133, 20);
            this.menuEdit.Text = "ورود و ویرایش اطلاعات";
            this.menuEdit.Click += new System.EventHandler(this.menuEdit_Click);
            // 
            // menuEditAddBook
            // 
            this.menuEditAddBook.Name = "menuEditAddBook";
            this.menuEditAddBook.Size = new System.Drawing.Size(181, 22);
            this.menuEditAddBook.Text = "ورود اطلاعات کتاب";
            this.menuEditAddBook.Click += new System.EventHandler(this.menuAddBook_Click);
            // 
            // menuEditEditBook
            // 
            this.menuEditEditBook.Name = "menuEditEditBook";
            this.menuEditEditBook.Size = new System.Drawing.Size(181, 22);
            this.menuEditEditBook.Text = "ویرایش اطلاعات کتاب";
            this.menuEditEditBook.Click += new System.EventHandler(this.menuEditEditBook_Click);
            // 
            // menuEditDeleteBook
            // 
            this.menuEditDeleteBook.Name = "menuEditDeleteBook";
            this.menuEditDeleteBook.Size = new System.Drawing.Size(181, 22);
            this.menuEditDeleteBook.Text = "حذف اطلاعات کتاب";
            this.menuEditDeleteBook.Click += new System.EventHandler(this.menuEditDeleteBook_click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // menuEditAddMember
            // 
            this.menuEditAddMember.Name = "menuEditAddMember";
            this.menuEditAddMember.Size = new System.Drawing.Size(181, 22);
            this.menuEditAddMember.Text = "ورود اطلاعات کاربر";
            this.menuEditAddMember.Click += new System.EventHandler(this.menuEditAddMember_Click);
            // 
            // menuEditEditMember
            // 
            this.menuEditEditMember.Name = "menuEditEditMember";
            this.menuEditEditMember.Size = new System.Drawing.Size(181, 22);
            this.menuEditEditMember.Text = "ویرایش اطلاعات کاربر";
            this.menuEditEditMember.Click += new System.EventHandler(this.menuEditEditMember_Click);
            // 
            // menuEditDeleteMember
            // 
            this.menuEditDeleteMember.Name = "menuEditDeleteMember";
            this.menuEditDeleteMember.Size = new System.Drawing.Size(181, 22);
            this.menuEditDeleteMember.Text = "حذف اطلاعات کاربر";
            this.menuEditDeleteMember.Click += new System.EventHandler(this.menuEditDeleteMember_Click);
            // 
            // menuBorrow
            // 
            this.menuBorrow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBorrowBook,
            this.menuReturnRenewBook,
            this.menuReserveBook,
            this.menuEditReserve,
            this.menuReturnFine});
            this.menuBorrow.Name = "menuBorrow";
            this.menuBorrow.Size = new System.Drawing.Size(96, 20);
            this.menuBorrow.Text = "امانت / بازگشت";
            // 
            // menuBorrowBook
            // 
            this.menuBorrowBook.Name = "menuBorrowBook";
            this.menuBorrowBook.Size = new System.Drawing.Size(187, 22);
            this.menuBorrowBook.Text = "امانت دادن کتاب";
            this.menuBorrowBook.Click += new System.EventHandler(this.menuBorrowBook_Click);
            // 
            // menuReturnRenewBook
            // 
            this.menuReturnRenewBook.Name = "menuReturnRenewBook";
            this.menuReturnRenewBook.Size = new System.Drawing.Size(187, 22);
            this.menuReturnRenewBook.Text = "بازگرداندن / تمدید کتاب";
            this.menuReturnRenewBook.Click += new System.EventHandler(this.menuReturnRenewBook_Click);
            // 
            // menuReserveBook
            // 
            this.menuReserveBook.Name = "menuReserveBook";
            this.menuReserveBook.Size = new System.Drawing.Size(187, 22);
            this.menuReserveBook.Text = "رزرو کتاب";
            this.menuReserveBook.Click += new System.EventHandler(this.رزروکتابToolStripMenuItem_Click);
            // 
            // menuEditReserve
            // 
            this.menuEditReserve.Name = "menuEditReserve";
            this.menuEditReserve.Size = new System.Drawing.Size(187, 22);
            this.menuEditReserve.Text = "تبدیل وضعیت رزرو";
            this.menuEditReserve.Click += new System.EventHandler(this.menuEditReserve_Click);
            // 
            // menuReturnFine
            // 
            this.menuReturnFine.Name = "menuReturnFine";
            this.menuReturnFine.Size = new System.Drawing.Size(187, 22);
            this.menuReturnFine.Text = "جریمه دیرکرد";
            this.menuReturnFine.Click += new System.EventHandler(this.menuReturnFine_Click);
            // 
            // menuReports
            // 
            this.menuReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuReportsBorrowings,
            this.menuReportReserves,
            this.MenuReportMembers,
            this.MenuReportBooks});
            this.menuReports.Name = "menuReports";
            this.menuReports.Size = new System.Drawing.Size(60, 20);
            this.menuReports.Text = "گزارشات";
            // 
            // menuReportsBorrowings
            // 
            this.menuReportsBorrowings.Name = "menuReportsBorrowings";
            this.menuReportsBorrowings.Size = new System.Drawing.Size(109, 22);
            this.menuReportsBorrowings.Text = "امانات";
            this.menuReportsBorrowings.Click += new System.EventHandler(this.menuReportsBorrowings_Click);
            // 
            // menuReportReserves
            // 
            this.menuReportReserves.Name = "menuReportReserves";
            this.menuReportReserves.Size = new System.Drawing.Size(109, 22);
            this.menuReportReserves.Text = "رزروها";
            this.menuReportReserves.Click += new System.EventHandler(this.menuReportReserves_Click);
            // 
            // MenuReportMembers
            // 
            this.MenuReportMembers.Name = "MenuReportMembers";
            this.MenuReportMembers.Size = new System.Drawing.Size(109, 22);
            this.MenuReportMembers.Text = "کاربران";
            this.MenuReportMembers.Click += new System.EventHandler(this.MenuReportMembers_Click);
            // 
            // MenuReportBooks
            // 
            this.MenuReportBooks.Name = "MenuReportBooks";
            this.MenuReportBooks.Size = new System.Drawing.Size(109, 22);
            this.MenuReportBooks.Text = "کتاب‌ها";
            this.MenuReportBooks.Click += new System.EventHandler(this.MenuReportBooks_Click);
            // 
            // menuSetting
            // 
            this.menuSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSettingChangePassword,
            this.toolStripSeparator2,
            this.menuSettingExit});
            this.menuSetting.Name = "menuSetting";
            this.menuSetting.Size = new System.Drawing.Size(62, 20);
            this.menuSetting.Text = "تنظیمات";
            this.menuSetting.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menuSettingChangePassword
            // 
            this.menuSettingChangePassword.Name = "menuSettingChangePassword";
            this.menuSettingChangePassword.Size = new System.Drawing.Size(142, 22);
            this.menuSettingChangePassword.Text = "تغییر رمز عبور";
            this.menuSettingChangePassword.Click += new System.EventHandler(this.menuSettingChangePassword_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripSeparator2.Size = new System.Drawing.Size(139, 6);
            // 
            // menuSettingExit
            // 
            this.menuSettingExit.Name = "menuSettingExit";
            this.menuSettingExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuSettingExit.Size = new System.Drawing.Size(142, 22);
            this.menuSettingExit.Text = "خروج";
            this.menuSettingExit.Click += new System.EventHandler(this.menuSettingExit_Click);
            // 
            // GBGeneral
            // 
            this.GBGeneral.Controls.Add(this.lblCurrentReservesNumber);
            this.GBGeneral.Controls.Add(this.lblCurrentReserves);
            this.GBGeneral.Controls.Add(this.lblCurrentBorrowsNumber);
            this.GBGeneral.Controls.Add(this.lblCurrentBorrows);
            this.GBGeneral.Controls.Add(this.lblAllMembersNumber);
            this.GBGeneral.Controls.Add(this.lblAllMembers);
            this.GBGeneral.Controls.Add(this.lblAllBooksNumber);
            this.GBGeneral.Controls.Add(this.lblAllBooks);
            this.GBGeneral.Location = new System.Drawing.Point(411, 63);
            this.GBGeneral.Name = "GBGeneral";
            this.GBGeneral.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GBGeneral.Size = new System.Drawing.Size(354, 124);
            this.GBGeneral.TabIndex = 1;
            this.GBGeneral.TabStop = false;
            this.GBGeneral.Text = "اطلاعات آمار کلی";
            // 
            // lblCurrentReservesNumber
            // 
            this.lblCurrentReservesNumber.AutoSize = true;
            this.lblCurrentReservesNumber.Location = new System.Drawing.Point(42, 82);
            this.lblCurrentReservesNumber.Name = "lblCurrentReservesNumber";
            this.lblCurrentReservesNumber.Size = new System.Drawing.Size(19, 13);
            this.lblCurrentReservesNumber.TabIndex = 7;
            this.lblCurrentReservesNumber.Text = "۲۶";
            // 
            // lblCurrentReserves
            // 
            this.lblCurrentReserves.AutoSize = true;
            this.lblCurrentReserves.Location = new System.Drawing.Point(77, 82);
            this.lblCurrentReserves.Name = "lblCurrentReserves";
            this.lblCurrentReserves.Size = new System.Drawing.Size(104, 13);
            this.lblCurrentReserves.TabIndex = 6;
            this.lblCurrentReserves.Text = "تعداد رزروهای جاری";
            // 
            // lblCurrentBorrowsNumber
            // 
            this.lblCurrentBorrowsNumber.AutoSize = true;
            this.lblCurrentBorrowsNumber.Location = new System.Drawing.Point(42, 39);
            this.lblCurrentBorrowsNumber.Name = "lblCurrentBorrowsNumber";
            this.lblCurrentBorrowsNumber.Size = new System.Drawing.Size(19, 13);
            this.lblCurrentBorrowsNumber.TabIndex = 5;
            this.lblCurrentBorrowsNumber.Text = "۲۶";
            // 
            // lblCurrentBorrows
            // 
            this.lblCurrentBorrows.AutoSize = true;
            this.lblCurrentBorrows.Location = new System.Drawing.Point(77, 39);
            this.lblCurrentBorrows.Name = "lblCurrentBorrows";
            this.lblCurrentBorrows.Size = new System.Drawing.Size(90, 13);
            this.lblCurrentBorrows.TabIndex = 4;
            this.lblCurrentBorrows.Text = "تعداد امانات جاری";
            // 
            // lblAllMembersNumber
            // 
            this.lblAllMembersNumber.AutoSize = true;
            this.lblAllMembersNumber.Location = new System.Drawing.Point(202, 82);
            this.lblAllMembersNumber.Name = "lblAllMembersNumber";
            this.lblAllMembersNumber.Size = new System.Drawing.Size(19, 13);
            this.lblAllMembersNumber.TabIndex = 3;
            this.lblAllMembersNumber.Text = "۲۶";
            // 
            // lblAllMembers
            // 
            this.lblAllMembers.AutoSize = true;
            this.lblAllMembers.Location = new System.Drawing.Point(237, 82);
            this.lblAllMembers.Name = "lblAllMembers";
            this.lblAllMembers.Size = new System.Drawing.Size(85, 13);
            this.lblAllMembers.TabIndex = 2;
            this.lblAllMembers.Text = "تعداد کل کاربران";
            // 
            // lblAllBooksNumber
            // 
            this.lblAllBooksNumber.AutoSize = true;
            this.lblAllBooksNumber.Location = new System.Drawing.Point(202, 39);
            this.lblAllBooksNumber.Name = "lblAllBooksNumber";
            this.lblAllBooksNumber.Size = new System.Drawing.Size(19, 13);
            this.lblAllBooksNumber.TabIndex = 1;
            this.lblAllBooksNumber.Text = "۲۶";
            // 
            // lblAllBooks
            // 
            this.lblAllBooks.AutoSize = true;
            this.lblAllBooks.Location = new System.Drawing.Point(237, 39);
            this.lblAllBooks.Name = "lblAllBooks";
            this.lblAllBooks.Size = new System.Drawing.Size(84, 13);
            this.lblAllBooks.TabIndex = 0;
            this.lblAllBooks.Text = "تعداد کل کتاب‌ها";
            // 
            // GBPolitics
            // 
            this.GBPolitics.Controls.Add(this.lblAvailableBooksNumber);
            this.GBPolitics.Controls.Add(this.lblAvailableBooks);
            this.GBPolitics.Controls.Add(this.lblAllBorrowedBooksNumber);
            this.GBPolitics.Controls.Add(this.lblAllBorrowedBooks);
            this.GBPolitics.Controls.Add(this.lblReturnPercentageNumber);
            this.GBPolitics.Controls.Add(this.lblReturnPercentage);
            this.GBPolitics.Controls.Add(this.lblBorrowedAvgNumber);
            this.GBPolitics.Controls.Add(this.lblBorrowedAvg);
            this.GBPolitics.Controls.Add(this.lblAllDebtersNumber);
            this.GBPolitics.Controls.Add(this.lblAllDebters);
            this.GBPolitics.Controls.Add(this.lblAllFinesNumber);
            this.GBPolitics.Controls.Add(this.lblAllFines);
            this.GBPolitics.Location = new System.Drawing.Point(411, 218);
            this.GBPolitics.Name = "GBPolitics";
            this.GBPolitics.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GBPolitics.Size = new System.Drawing.Size(354, 172);
            this.GBPolitics.TabIndex = 8;
            this.GBPolitics.TabStop = false;
            this.GBPolitics.Text = "مدیریت موجودی و سیاست‌ها";
            // 
            // lblAvailableBooksNumber
            // 
            this.lblAvailableBooksNumber.AutoSize = true;
            this.lblAvailableBooksNumber.Location = new System.Drawing.Point(42, 125);
            this.lblAvailableBooksNumber.Name = "lblAvailableBooksNumber";
            this.lblAvailableBooksNumber.Size = new System.Drawing.Size(19, 13);
            this.lblAvailableBooksNumber.TabIndex = 13;
            this.lblAvailableBooksNumber.Text = "۲۶";
            // 
            // lblAvailableBooks
            // 
            this.lblAvailableBooks.AutoSize = true;
            this.lblAvailableBooks.Location = new System.Drawing.Point(77, 125);
            this.lblAvailableBooks.Name = "lblAvailableBooks";
            this.lblAvailableBooks.Size = new System.Drawing.Size(109, 13);
            this.lblAvailableBooks.TabIndex = 12;
            this.lblAvailableBooks.Text = "تعداد کتاب‌های موجود";
            // 
            // lblAllBorrowedBooksNumber
            // 
            this.lblAllBorrowedBooksNumber.AutoSize = true;
            this.lblAllBorrowedBooksNumber.Location = new System.Drawing.Point(202, 125);
            this.lblAllBorrowedBooksNumber.Name = "lblAllBorrowedBooksNumber";
            this.lblAllBorrowedBooksNumber.Size = new System.Drawing.Size(19, 13);
            this.lblAllBorrowedBooksNumber.TabIndex = 9;
            this.lblAllBorrowedBooksNumber.Text = "۲۶";
            // 
            // lblAllBorrowedBooks
            // 
            this.lblAllBorrowedBooks.AutoSize = true;
            this.lblAllBorrowedBooks.Location = new System.Drawing.Point(237, 125);
            this.lblAllBorrowedBooks.Name = "lblAllBorrowedBooks";
            this.lblAllBorrowedBooks.Size = new System.Drawing.Size(110, 13);
            this.lblAllBorrowedBooks.TabIndex = 8;
            this.lblAllBorrowedBooks.Text = "تعداد کتاب‌های امانتی";
            // 
            // lblReturnPercentageNumber
            // 
            this.lblReturnPercentageNumber.AutoSize = true;
            this.lblReturnPercentageNumber.Location = new System.Drawing.Point(42, 87);
            this.lblReturnPercentageNumber.Name = "lblReturnPercentageNumber";
            this.lblReturnPercentageNumber.Size = new System.Drawing.Size(19, 13);
            this.lblReturnPercentageNumber.TabIndex = 7;
            this.lblReturnPercentageNumber.Text = "۲۶";
            // 
            // lblReturnPercentage
            // 
            this.lblReturnPercentage.AutoSize = true;
            this.lblReturnPercentage.Location = new System.Drawing.Point(77, 87);
            this.lblReturnPercentage.Name = "lblReturnPercentage";
            this.lblReturnPercentage.Size = new System.Drawing.Size(110, 13);
            this.lblReturnPercentage.TabIndex = 6;
            this.lblReturnPercentage.Text = "درصد بازگشت به موقع";
            // 
            // lblBorrowedAvgNumber
            // 
            this.lblBorrowedAvgNumber.AutoSize = true;
            this.lblBorrowedAvgNumber.Location = new System.Drawing.Point(42, 44);
            this.lblBorrowedAvgNumber.Name = "lblBorrowedAvgNumber";
            this.lblBorrowedAvgNumber.Size = new System.Drawing.Size(19, 13);
            this.lblBorrowedAvgNumber.TabIndex = 5;
            this.lblBorrowedAvgNumber.Text = "۲۶";
            // 
            // lblBorrowedAvg
            // 
            this.lblBorrowedAvg.AutoSize = true;
            this.lblBorrowedAvg.Location = new System.Drawing.Point(77, 44);
            this.lblBorrowedAvg.Name = "lblBorrowedAvg";
            this.lblBorrowedAvg.Size = new System.Drawing.Size(90, 13);
            this.lblBorrowedAvg.TabIndex = 4;
            this.lblBorrowedAvg.Text = "میانگین مدت امانت";
            // 
            // lblAllDebtersNumber
            // 
            this.lblAllDebtersNumber.AutoSize = true;
            this.lblAllDebtersNumber.Location = new System.Drawing.Point(202, 87);
            this.lblAllDebtersNumber.Name = "lblAllDebtersNumber";
            this.lblAllDebtersNumber.Size = new System.Drawing.Size(19, 13);
            this.lblAllDebtersNumber.TabIndex = 3;
            this.lblAllDebtersNumber.Text = "۲۶";
            // 
            // lblAllDebters
            // 
            this.lblAllDebters.AutoSize = true;
            this.lblAllDebters.Location = new System.Drawing.Point(237, 87);
            this.lblAllDebters.Name = "lblAllDebters";
            this.lblAllDebters.Size = new System.Drawing.Size(103, 13);
            this.lblAllDebters.TabIndex = 2;
            this.lblAllDebters.Text = "تعداد کاربران بدهکار";
            // 
            // lblAllFinesNumber
            // 
            this.lblAllFinesNumber.AutoSize = true;
            this.lblAllFinesNumber.Location = new System.Drawing.Point(202, 44);
            this.lblAllFinesNumber.Name = "lblAllFinesNumber";
            this.lblAllFinesNumber.Size = new System.Drawing.Size(19, 13);
            this.lblAllFinesNumber.TabIndex = 1;
            this.lblAllFinesNumber.Text = "۲۶";
            // 
            // lblAllFines
            // 
            this.lblAllFines.AutoSize = true;
            this.lblAllFines.Location = new System.Drawing.Point(237, 44);
            this.lblAllFines.Name = "lblAllFines";
            this.lblAllFines.Size = new System.Drawing.Size(88, 13);
            this.lblAllFines.TabIndex = 0;
            this.lblAllFines.Text = "میزان کل جریمه‌ها";
            // 
            // GBAnalytic
            // 
            this.GBAnalytic.Controls.Add(this.lblDaysNames);
            this.GBAnalytic.Controls.Add(this.lblActiveMembersNames);
            this.GBAnalytic.Controls.Add(this.lblFaveBooksNames);
            this.GBAnalytic.Controls.Add(this.lblDays);
            this.GBAnalytic.Controls.Add(this.lblActiveMembers);
            this.GBAnalytic.Controls.Add(this.lblFaveBooks);
            this.GBAnalytic.Location = new System.Drawing.Point(29, 63);
            this.GBAnalytic.Name = "GBAnalytic";
            this.GBAnalytic.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GBAnalytic.Size = new System.Drawing.Size(354, 327);
            this.GBAnalytic.TabIndex = 14;
            this.GBAnalytic.TabStop = false;
            this.GBAnalytic.Text = "آمار تحلیلی";
            // 
            // lblDaysNames
            // 
            this.lblDaysNames.AutoSize = true;
            this.lblDaysNames.Location = new System.Drawing.Point(171, 291);
            this.lblDaysNames.Name = "lblDaysNames";
            this.lblDaysNames.Size = new System.Drawing.Size(51, 13);
            this.lblDaysNames.TabIndex = 22;
            this.lblDaysNames.Text = "سه تا روز";
            this.lblDaysNames.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblActiveMembersNames
            // 
            this.lblActiveMembersNames.Location = new System.Drawing.Point(82, 184);
            this.lblActiveMembersNames.Name = "lblActiveMembersNames";
            this.lblActiveMembersNames.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblActiveMembersNames.Size = new System.Drawing.Size(250, 13);
            this.lblActiveMembersNames.TabIndex = 21;
            this.lblActiveMembersNames.Text = "سه تا کاربر";
            this.lblActiveMembersNames.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFaveBooksNames
            // 
            this.lblFaveBooksNames.AutoSize = true;
            this.lblFaveBooksNames.Location = new System.Drawing.Point(171, 82);
            this.lblFaveBooksNames.Name = "lblFaveBooksNames";
            this.lblFaveBooksNames.Size = new System.Drawing.Size(58, 13);
            this.lblFaveBooksNames.TabIndex = 16;
            this.lblFaveBooksNames.Text = "سه تا کتاب";
            this.lblFaveBooksNames.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(257, 257);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(75, 13);
            this.lblDays.TabIndex = 20;
            this.lblDays.Text = "روزهای شلوغ:";
            // 
            // lblActiveMembers
            // 
            this.lblActiveMembers.AutoSize = true;
            this.lblActiveMembers.Location = new System.Drawing.Point(261, 148);
            this.lblActiveMembers.Name = "lblActiveMembers";
            this.lblActiveMembers.Size = new System.Drawing.Size(71, 13);
            this.lblActiveMembers.TabIndex = 18;
            this.lblActiveMembers.Text = "کاربران فعال:";
            // 
            // lblFaveBooks
            // 
            this.lblFaveBooks.AutoSize = true;
            this.lblFaveBooks.Location = new System.Drawing.Point(245, 39);
            this.lblFaveBooks.Name = "lblFaveBooks";
            this.lblFaveBooks.Size = new System.Drawing.Size(87, 13);
            this.lblFaveBooks.TabIndex = 17;
            this.lblFaveBooks.Text = "کتاب‌های محبوب:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnRefresh.Location = new System.Drawing.Point(29, 27);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(36, 39);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "⟳";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 424);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.GBAnalytic);
            this.Controls.Add(this.GBPolitics);
            this.Controls.Add(this.GBGeneral);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "سیستم مدیریت کتابخانه";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.GBGeneral.ResumeLayout(false);
            this.GBGeneral.PerformLayout();
            this.GBPolitics.ResumeLayout(false);
            this.GBPolitics.PerformLayout();
            this.GBAnalytic.ResumeLayout(false);
            this.GBAnalytic.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuEditAddBook;
        private System.Windows.Forms.ToolStripMenuItem menuEditEditBook;
        private System.Windows.Forms.ToolStripMenuItem menuEditDeleteBook;
        private System.Windows.Forms.ToolStripMenuItem menuBorrow;
        private System.Windows.Forms.ToolStripMenuItem menuBorrowBook;
        private System.Windows.Forms.ToolStripMenuItem menuReturnRenewBook;
        private System.Windows.Forms.ToolStripMenuItem menuReports;
        private System.Windows.Forms.ToolStripMenuItem menuReportsBorrowings;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem menuEditAddMember;
        private ToolStripMenuItem menuEditEditMember;
        private ToolStripMenuItem menuEditDeleteMember;
        private ToolStripMenuItem menuSetting;
        private ToolStripMenuItem menuSettingChangePassword;
        private ToolStripMenuItem menuSettingExit;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem menuReturnFine;
        private ToolStripMenuItem menuReserveBook;
        private ToolStripMenuItem menuReportReserves;
        private ToolStripMenuItem menuEditReserve;
        private ToolStripMenuItem MenuReportMembers;
        private ToolStripMenuItem MenuReportBooks;
        private GroupBox GBGeneral;
        private Label lblAllBooks;
        private Label lblCurrentReservesNumber;
        private Label lblCurrentReserves;
        private Label lblCurrentBorrowsNumber;
        private Label lblCurrentBorrows;
        private Label lblAllMembersNumber;
        private Label lblAllMembers;
        private Label lblAllBooksNumber;
        private GroupBox GBPolitics;
        private Label lblReturnPercentageNumber;
        private Label lblReturnPercentage;
        private Label lblBorrowedAvgNumber;
        private Label lblBorrowedAvg;
        private Label lblAllDebtersNumber;
        private Label lblAllDebters;
        private Label lblAllFines;
        private Label lblAvailableBooksNumber;
        private Label lblAvailableBooks;
        private Label lblAllBorrowedBooksNumber;
        private Label lblAllBorrowedBooks;
        private GroupBox GBAnalytic;
        private Label lblDays;
        private Label lblActiveMembers;
        private Label lblFaveBooks;
        private Button btnRefresh;
        private Label lblAllFinesNumber;
        private Label lblFaveBooksNames;
        private Label lblDaysNames;
        private Label lblActiveMembersNames;
    }
}

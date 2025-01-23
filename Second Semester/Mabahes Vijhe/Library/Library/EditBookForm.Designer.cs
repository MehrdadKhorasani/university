namespace Library
{
    partial class EditBookForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            // تعریف ابزارها
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.txtStandardCode = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthorFName1 = new System.Windows.Forms.TextBox();
            this.txtAuthorLName1 = new System.Windows.Forms.TextBox();
            this.txtAuthorFName2 = new System.Windows.Forms.TextBox();
            this.txtAuthorLName2 = new System.Windows.Forms.TextBox();
            this.txtTranslatorFName1 = new System.Windows.Forms.TextBox();
            this.txtTranslatorLName1 = new System.Windows.Forms.TextBox();
            this.txtTranslatorFName2 = new System.Windows.Forms.TextBox();
            this.txtTranslatorLName2 = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtPubCNT = new System.Windows.Forms.TextBox();
            this.txtCopies = new System.Windows.Forms.TextBox();

            this.lblBookId = new System.Windows.Forms.Label();
            this.lblStandardCode = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor1 = new System.Windows.Forms.Label();
            this.lblAuthor2 = new System.Windows.Forms.Label();
            this.lblTranslator1 = new System.Windows.Forms.Label();
            this.lblTranslator2 = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPubCNT = new System.Windows.Forms.Label();
            this.lblCopies = new System.Windows.Forms.Label();

            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // تنظیم فرم
            this.ClientSize = new System.Drawing.Size(600, 900);
            this.Text = "ویرایش کتاب";
            this.AutoScroll = true;

            int labelX = 50, textBoxX = 200, y = 20, step = 40;

            // ابزارهای کد کتاب
            this.lblBookId.Text = "کد کتاب:";
            this.lblBookId.Location = new System.Drawing.Point(labelX, y);
            this.txtBookId.Location = new System.Drawing.Point(textBoxX, y);
            this.txtBookId.ReadOnly = true;

            y += step;

            // ابزارهای کد استاندارد
            this.lblStandardCode.Text = "کد استاندارد:";
            this.lblStandardCode.Location = new System.Drawing.Point(labelX, y);
            this.txtStandardCode.Location = new System.Drawing.Point(textBoxX, y);

            y += step;

            // ابزارهای عنوان
            this.lblTitle.Text = "عنوان:";
            this.lblTitle.Location = new System.Drawing.Point(labelX, y);
            this.txtTitle.Location = new System.Drawing.Point(textBoxX, y);

            y += step;

            // ابزارهای نویسنده 1
            this.lblAuthor1.Text = "نام و نام‌خانوادگی نویسنده 1:";
            this.lblAuthor1.Location = new System.Drawing.Point(labelX, y);
            this.txtAuthorFName1.Location = new System.Drawing.Point(textBoxX, y);
            y += step;
            this.txtAuthorLName1.Location = new System.Drawing.Point(textBoxX, y);

            y += step;

            // ابزارهای نویسنده 2
            this.lblAuthor2.Text = "نام و نام‌خانوادگی نویسنده 2:";
            this.lblAuthor2.Location = new System.Drawing.Point(labelX, y);
            this.txtAuthorFName2.Location = new System.Drawing.Point(textBoxX, y);
            y += step;
            this.txtAuthorLName2.Location = new System.Drawing.Point(textBoxX, y);

            y += step;

            // ابزارهای مترجم 1
            this.lblTranslator1.Text = "نام و نام‌خانوادگی مترجم 1:";
            this.lblTranslator1.Location = new System.Drawing.Point(labelX, y);
            this.txtTranslatorFName1.Location = new System.Drawing.Point(textBoxX, y);
            y += step;
            this.txtTranslatorLName1.Location = new System.Drawing.Point(textBoxX, y);

            y += step;

            // ابزارهای مترجم 2
            this.lblTranslator2.Text = "نام و نام‌خانوادگی مترجم 2:";
            this.lblTranslator2.Location = new System.Drawing.Point(labelX, y);
            this.txtTranslatorFName2.Location = new System.Drawing.Point(textBoxX, y);
            y += step;
            this.txtTranslatorLName2.Location = new System.Drawing.Point(textBoxX, y);

            y += step;

            // ابزارهای ناشر
            this.lblPublisher.Text = "ناشر:";
            this.lblPublisher.Location = new System.Drawing.Point(labelX, y);
            this.txtPublisher.Location = new System.Drawing.Point(textBoxX, y);

            y += step;

            // ابزارهای سال انتشار
            this.lblYear.Text = "سال انتشار:";
            this.lblYear.Location = new System.Drawing.Point(labelX, y);
            this.txtYear.Location = new System.Drawing.Point(textBoxX, y);

            y += step;

            // ابزارهای قیمت
            this.lblPrice.Text = "قیمت:";
            this.lblPrice.Location = new System.Drawing.Point(labelX, y);
            this.txtPrice.Location = new System.Drawing.Point(textBoxX, y);

            y += step;

            // ابزارهای تعداد چاپ
            this.lblPubCNT.Text = "تعداد چاپ:";
            this.lblPubCNT.Location = new System.Drawing.Point(labelX, y);
            this.txtPubCNT.Location = new System.Drawing.Point(textBoxX, y);

            y += step;

            // ابزارهای تعداد نسخه
            this.lblCopies.Text = "تعداد نسخه:";
            this.lblCopies.Location = new System.Drawing.Point(labelX, y);
            this.txtCopies.Location = new System.Drawing.Point(textBoxX, y);

            y += step + 20;

            // دکمه ذخیره
            this.btnSave.Text = "ذخیره";
            this.btnSave.Location = new System.Drawing.Point(250, y);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // اضافه کردن ابزارها به فرم
            this.Controls.Add(this.txtBookId);
            this.Controls.Add(this.txtStandardCode);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtAuthorFName1);
            this.Controls.Add(this.txtAuthorLName1);
            this.Controls.Add(this.txtAuthorFName2);
            this.Controls.Add(this.txtAuthorLName2);
            this.Controls.Add(this.txtTranslatorFName1);
            this.Controls.Add(this.txtTranslatorLName1);
            this.Controls.Add(this.txtTranslatorFName2);
            this.Controls.Add(this.txtTranslatorLName2);
            this.Controls.Add(this.txtPublisher);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtPubCNT);
            this.Controls.Add(this.txtCopies);

            this.Controls.Add(this.lblBookId);
            this.Controls.Add(this.lblStandardCode);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblAuthor1);
            this.Controls.Add(this.lblAuthor2);
            this.Controls.Add(this.lblTranslator1);
            this.Controls.Add(this.lblTranslator2);
            this.Controls.Add(this.lblPublisher);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblPubCNT);
            this.Controls.Add(this.lblCopies);

            this.Controls.Add(this.btnSave);

            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.TextBox txtStandardCode;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthorFName1;
        private System.Windows.Forms.TextBox txtAuthorLName1;
        private System.Windows.Forms.TextBox txtAuthorFName2;
        private System.Windows.Forms.TextBox txtAuthorLName2;
        private System.Windows.Forms.TextBox txtTranslatorFName1;
        private System.Windows.Forms.TextBox txtTranslatorLName1;
        private System.Windows.Forms.TextBox txtTranslatorFName2;
        private System.Windows.Forms.TextBox txtTranslatorLName2;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtPubCNT;
        private System.Windows.Forms.TextBox txtCopies;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.Label lblStandardCode;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor1;
        private System.Windows.Forms.Label lblAuthor2;
        private System.Windows.Forms.Label lblTranslator1;
        private System.Windows.Forms.Label lblTranslator2;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPubCNT;
        private System.Windows.Forms.Label lblCopies;
        private System.Windows.Forms.Button btnSave;
    }
}

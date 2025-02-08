namespace Library
{
    partial class EditBookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNewBook;
        private System.Windows.Forms.Label[] labels;
        private System.Windows.Forms.TextBox[] textBoxes;

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
            this.components = new System.ComponentModel.Container();

            // تنظیمات کلی فرم
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 700);
            this.Text = "ویرایش اطلاعات کتاب";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            // ایجاد آرایه برای لیبل‌ها و تکست‌باکس‌ها
            string[] labelTexts = new string[]
            {
                "شماره کتاب (غیرقابل تغییر)",
                "کد استاندارد کتاب",
                "عنوان کتاب",
                "نام نویسنده",
                "نام خانوادگی نویسنده",
                "نام نویسنده دوم",
                "نام خانوادگی نویسنده دوم",
                "نام مترجم",
                "نام خانوادگی مترجم",
                "نام مترجم دوم",
                "نام خانوادگی مترجم دوم",
                "ناشر",
                "سال انتشار",
                "قیمت",
                "تعداد موجودی کل",
                "تعداد تیراژ",
                "تعداد موجودی فعلی"
            };

            int startX = 300, startY = 20;
            int labelWidth = 160, textBoxWidth = 200, height = 25, spacing = 10;

            // تعداد فیلدها
            int fieldCount = labelTexts.Length;

            // تعریف آرایه‌ها
            this.labels = new System.Windows.Forms.Label[fieldCount];
            this.textBoxes = new System.Windows.Forms.TextBox[fieldCount];

            for (int i = 0; i < fieldCount; i++)
            {
                // ایجاد تکست‌باکس
                this.textBoxes[i] = new global::System.Windows.Forms.TextBox
                {
                    Location = new System.Drawing.Point(startX, startY + i * (height + spacing)),
                    Size = new System.Drawing.Size(textBoxWidth, height),
                    ReadOnly = true // پیش‌فرض غیرفعال
                };

                // تنظیم غیرقابل تغییر بودن شماره کتاب
                if (i == 0)
                {
                    this.textBoxes[i].ReadOnly = false;
                }

                // ایجاد لیبل
                this.labels[i] = new System.Windows.Forms.Label
                {
                    Text = labelTexts[i],
                    Location = new System.Drawing.Point(startX - labelWidth - 10, startY + i * (height + spacing)),
                    Size = new System.Drawing.Size(labelWidth, height),
                    TextAlign = System.Drawing.ContentAlignment.MiddleRight
                };

                // افزودن به کنترل‌های فرم
                this.Controls.Add(this.labels[i]);
                this.Controls.Add(this.textBoxes[i]);
            }

            // تنظیم موقعیت پایین‌ترین ردیف
            int lastRowY = startY + fieldCount * (height + spacing);

            // ایجاد دکمه ذخیره
            this.btnSave = new System.Windows.Forms.Button
            {
                Text = "ذخیره تغییرات",
                Location = new System.Drawing.Point(100, lastRowY + 20),
                Size = new System.Drawing.Size(100, 35)
            };

            // ایجاد دکمه خروج
            this.btnExit = new System.Windows.Forms.Button
            {
                Text = "خروج",
                Location = new System.Drawing.Point(210, lastRowY + 20),
                Size = new System.Drawing.Size(100, 35)
            };
            this.btnExit.Click += (sender, e) => this.Close(); // بستن فرم

            // ایجاد دکمه کتاب جدید
            this.btnNewBook = new System.Windows.Forms.Button
            {
                Text = "کتاب جدید",
                Location = new System.Drawing.Point(320, lastRowY + 20),
                Size = new System.Drawing.Size(100, 35)
            };

            // افزودن دکمه‌ها به کنترل‌های فرم
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNewBook);
        }

        #endregion
    }
}

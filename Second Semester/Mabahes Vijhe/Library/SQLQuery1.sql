CREATE TABLE Member (
    MNumber INT IDENTITY(1,1) PRIMARY KEY,  
    MNCode NVARCHAR(20),
    MFName NVARCHAR(50),                    
    MLName NVARCHAR(50),                
    MStartDate DATE,                    
    MExpireDate DATE,                       
    MBMax INT DEFAULT 5,                            
    MGender NVARCHAR(10),                 
    MBirthDate DATE,                    
    MAddress NVARCHAR(200),                
    MTellNo NVARCHAR(15),                  
    MPostCode NVARCHAR(10),                
    MFatherName NVARCHAR(50),               
    MDebt DECIMAL(10, 2) DEFAULT 0.0,     
    MStatus NVARCHAR(20) DEFAULT 'فعال'
);

CREATE TABLE Book (
    BNumber INT IDENTITY(1,1) PRIMARY KEY,  -- کد یکتای کتاب
    BStandardCode NVARCHAR(20),             -- کد استاندارد کتاب
    BTitle NVARCHAR(100),                   -- عنوان کتاب
    BAuthorFName1 NVARCHAR(50),             -- نام نویسنده اول
    BAuthorLName1 NVARCHAR(50),             -- فامیل نویسنده اول
    BAuthorFName2 NVARCHAR(50),             -- نام نویسنده دوم
    BAuthorLName2 NVARCHAR(50),             -- فامیل نویسنده دوم
    BPublisher NVARCHAR(100),               -- ناشر
    BTranslatorFName1 NVARCHAR(50),         -- نام مترجم اول
    BTranslatorLName1 NVARCHAR(50),         -- فامیل مترجم اول
    BTranslatorFName2 NVARCHAR(50),         -- نام مترجم دوم
    BTranslatorLName2 NVARCHAR(50),         -- فامیل مترجم دوم
    BPubYear INT,                           -- سال انتشار
    BPrice DECIMAL(10, 2),                  -- قیمت
    BCNT INT,                               -- تعداد کلی در کتابخانه
    BPubCNT INT,                            -- تعداد نسخه زمان چاپ
    BCCNT INT                               -- تعداد موجود در کتابخانه
);

CREATE TABLE Borrow (
    BRNo INT IDENTITY(1,1) PRIMARY KEY,     -- کد یکتای امانت
    MNumber INT FOREIGN KEY REFERENCES Member(MNumber),  -- کد یکتای عضو
    BNumber INT FOREIGN KEY REFERENCES Book(BNumber),    -- کد یکتای کتاب
    BRStartDate DATE,                       -- تاریخ شروع امانت
    BRDueDate DATE,                         -- تاریخ مقرر بازگرداندن
    BRReturnDate DATE,                      -- تاریخ بازگرداندن واقعی
    BRFineAmount DECIMAL(10, 2)             -- مبلغ جریمه
);

CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,  
    Username NVARCHAR(50) UNIQUE NOT NULL,
    Password NVARCHAR(100) NOT NULL,
    Role NVARCHAR(20) NOT NULL DEFAULT 'User',
    MemberID INT NULL,
    CONSTRAINT FK_Users_MemberID FOREIGN KEY (MemberID) REFERENCES Member(MNumber)
);

INSERT INTO Users (Username, Password, Role)
VALUES ('AdminUser', 'SecurePassword123', 'Admin');

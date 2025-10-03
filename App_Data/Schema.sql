-- MySQL Database Schema converted from Access Database: Test_Db.accdb
-- Generated: October 2, 2025

-- Drop existing tables if they exist
DROP TABLE IF EXISTS StoreReconcilation;
DROP TABLE IF EXISTS PaymentDetails;
DROP TABLE IF EXISTS Payments;
DROP TABLE IF EXISTS BillPaymentDetails;
DROP TABLE IF EXISTS BillPayments;
DROP TABLE IF EXISTS CustomerCreditNoteDetails;
DROP TABLE IF EXISTS CustomerCreditNote;
DROP TABLE IF EXISTS DistributorCreditNoteDetail;
DROP TABLE IF EXISTS DistributorCreditNote;
DROP TABLE IF EXISTS InvoiceDetails;
DROP TABLE IF EXISTS Invoices;
DROP TABLE IF EXISTS BillDetails;
DROP TABLE IF EXISTS Bills;
DROP TABLE IF EXISTS QuickBills;
DROP TABLE IF EXISTS QuickInvoices;
DROP TABLE IF EXISTS QuickCustomerNote;
DROP TABLE IF EXISTS QuickDistributorNote;
DROP TABLE IF EXISTS ItemsAvailable;
DROP TABLE IF EXISTS ItemPricesAndTaxes;
DROP TABLE IF EXISTS ItemList;
DROP TABLE IF EXISTS CustomerItemControl;
DROP TABLE IF EXISTS DistributorItemControl;
DROP TABLE IF EXISTS ExpenseLog;
DROP TABLE IF EXISTS ExpenseCodes;
DROP TABLE IF EXISTS Communication;
DROP TABLE IF EXISTS Address;
DROP TABLE IF EXISTS AddressTemplate;
DROP TABLE IF EXISTS GroupDetail;
DROP TABLE IF EXISTS Groups;
DROP TABLE IF EXISTS Accounts;
DROP TABLE IF EXISTS CustomLists;
DROP TABLE IF EXISTS CutomLabels;
DROP TABLE IF EXISTS Filters;
DROP TABLE IF EXISTS FilterType;
DROP TABLE IF EXISTS GlobalSetting;
DROP TABLE IF EXISTS Settings;
DROP TABLE IF EXISTS Users;
DROP TABLE IF EXISTS Version;

-- Create database
CREATE DATABASE IF NOT EXISTS Test_Db 
CHARACTER SET utf8mb4 
COLLATE utf8mb4_unicode_ci;

USE Test_Db;

-- =============================================
-- Table: Accounts
-- =============================================
CREATE TABLE Accounts (
    Account_ID VARCHAR(50) NOT NULL PRIMARY KEY,
    Salutation VARCHAR(255),
    FirstName TEXT,
    MiddleName TEXT,
    LastName TEXT,
    Parent TEXT,
    GroupID VARCHAR(255),
    IsCustomer BOOLEAN DEFAULT FALSE,
    Website VARCHAR(255),
    AccountMemo TEXT,
    RetainerAvailable DECIMAL(19,4),
    CreditAvailable DECIMAL(19,4),
    LockStatus BOOLEAN DEFAULT FALSE,
    LockDate DATETIME,
    Status INT,
    CreatedOn DATETIME,
    LastUpdated DATETIME,
    LicenseNumber VARCHAR(255),
    GSTTINNumber VARCHAR(255),
    CSTNumber VARCHAR(255),
    Balance DECIMAL(19,4),
    INDEX idx_accounts_groupid (GroupID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- =============================================
-- Table: Address
-- =============================================
CREATE TABLE Address (
    Address_ID INT AUTO_INCREMENT PRIMARY KEY,
    Entity_ID VARCHAR(255),
    EntityType INT,
    AddressName TEXT,
    Address1 TEXT,
    Address2 TEXT,
    City TEXT,
    State TEXT,
    Country TEXT,
    Zip TEXT,
    Longitude DECIMAL(18,10),
    Latitude DECIMAL(18,10),
    CreatedOn DATETIME,
    LastUpdated DATETIME,
    SortOrder INT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- =============================================
-- Table: AddressTemplate
-- =============================================
CREATE TABLE AddressTemplate (
    AddressName VARCHAR(255) NOT NULL PRIMARY KEY,
    Address1 TEXT,
    Address2 TEXT,
    City TEXT,
    State TEXT,
    Country VARCHAR(255),
    Zip VARCHAR(255),
    Longitude VARCHAR(255),
    Latitude VARCHAR(255)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- =============================================
-- Table: Bills
-- =============================================
CREATE TABLE Bills (
    BillNumber VARCHAR(50) NOT NULL,
    Account_ID VARCHAR(255) NOT NULL,
    TotalAmount DECIMAL(19,4),
    DiscountAmount DECIMAL(19,4),
    VATAmount DECIMAL(19,4),
    BillAmount DECIMAL(19,4),
    BillType INT,
    Balance DECIMAL(19,4),
    Paid BOOLEAN DEFAULT FALSE,
    BillDate DATETIME,
    BillMemo TEXT,
    LastUpdated DATETIME,
    PRIMARY KEY (BillNumber, Account_ID),
    INDEX idx_bills_paid (Paid)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- =============================================
-- Table: BillDetails
-- =============================================
CREATE TABLE BillDetails (
    BillDetailID TEXT NOT NULL,
    BillNumber VARCHAR(50),
    itemName VARCHAR(50),
    Pack VARCHAR(255),
    QTY DOUBLE,
    TotalUnits INT,
    Batch VARCHAR(255),
    MRP DECIMAL(19,4),
    EXPDate DATETIME,
    Rate DECIMAL(19,4),
    Discount DECIMAL(19,4),
    VAT DECIMAL(19,4),
    Amount DECIMAL(19,4),
    Free INT,
    HSNCODE VARCHAR(255),
    PRIMARY KEY (BillDetailID(100)),
    INDEX idx_billdetails_hsncode (HSNCODE)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- =============================================
-- Table: BillPayments
-- =============================================
CREATE TABLE BillPayments (
    BillPayment_ID INT NOT NULL PRIMARY KEY,
    Payee_ID VARCHAR(255),
    Amount DECIMAL(19,4),
    PayMethod INT,
    Credit BOOLEAN DEFAULT FALSE,
    CreditAmount DECIMAL(19,4),
    PaymentMemo TEXT,
    PaymentDate DATETIME,
    ReceiptNo VARCHAR(255),
    LastUpdated VARCHAR(255),
    UNIQUE INDEX idx_billpayments_id (BillPayment_ID),
    INDEX idx_billpayments_payee (Payee_ID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- =============================================
-- Table: BillPaymentDetails
-- =============================================
CREATE TABLE BillPaymentDetails (
    BillPaymentDetail_ID INT AUTO_INCREMENT PRIMARY KEY,
    BillPayment_ID INT,
    BillNumber VARCHAR(255),
    AmountPaid DECIMAL(19,4),
    BillBalance DECIMAL(19,4),
    UNIQUE INDEX idx_billpaymentdetails_id (BillPaymentDetail_ID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- =============================================
-- Table: Communication
-- =============================================
CREATE TABLE Communication (
    Communication_ID INT NOT NULL PRIMARY KEY,
    Address_ID INT NOT NULL,
    Phone TEXT NOT NULL,
    Mobile TEXT,
    Home TEXT,
    WorkContact TEXT,
    Email TEXT,
    Fax TEXT,
    Skype TEXT,
    Facebook TEXT,
    Web TEXT,
    CreatedOn DATETIME,
    LastUpdated DATETIME
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- =============================================
-- Table: CustomerCreditNote
-- =============================================
CREATE TABLE CustomerCreditNote (
    InvoiceNumber INT NOT NULL PRIMARY KEY,
    TotalAmount DECIMAL(19,4),
    DiscountAmount DECIMAL(19,4),
    VATAmount DECIMAL(19,4),
    InvoiceAmount DECIMAL(19,4),
    Balance DECIMAL(19,4),
    Paid BOOLEAN DEFAULT FALSE,
    Account_ID VARCHAR(50),
    InvoiceDate DATETIME,
    Client TEXT,
    InvMemo TEXT,
    Lastupdated DATETIME,
    UNIQUE INDEX idx_customercreditnote_invoice (InvoiceNumber),
    INDEX idx_customercreditnote_paid (Paid)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- =============================================
-- Table: CustomerCreditNoteDetails
-- =============================================
CREATE TABLE CustomerCreditNoteDetails (
    InvoiceDetailID TEXT NOT NULL,
    InvoiceNumber INT,
    ItemName VARCHAR(50),
    Pack VARCHAR(255),
    QTY DOUBLE,
    TotalUnits INT,
    Batch VARCHAR(255),
    MRP DECIMAL(19,4),
    EXPDate DATETIME,
    Discount DECIMAL(19,4),
    VAT DECIMAL(19,4),
    Amount DECIMAL(19,4),
    PRIMARY KEY (InvoiceDetailID(100)),
    UNIQUE INDEX idx_customercreditnotedetails_id (InvoiceDetailID(100))
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- =============================================
-- Table: CustomerItemControl
-- =============================================
CREATE TABLE CustomerItemControl (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    Account_ID VARCHAR(255),
    ItemName VARCHAR(255),
    CreatedOn DATETIME,
    INDEX idx_customeritemcontrol_account (Account_ID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- =============================================
-- Table: CustomLists
-- =============================================
CREATE TABLE CustomLists (
    ListName TEXT NOT NULL,
    Value TEXT NOT NULL,
    PRIMARY KEY (ListName(100), Value(100))
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- =============================================
-- Table: CutomLabels
-- =============================================
CREATE TABLE CutomLabels (
    LabelKey VARCHAR(255) NOT NULL PRIMARY KEY,
    LabelValue VARCHAR(255)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- =============================================
-- Table: DistributorCreditNote
-- =============================================
CREATE TABLE DistributorCreditNote (
    BillNumber VARCHAR(50) NOT NULL PRIMARY KEY,
    TotalAmount DECIMAL(19,4),
    DiscountAmount DECIMAL(19,4),
    VATAmount DECIMAL(19,4),
    BillAmount DECIMAL(19,4),
    Account_ID VARCHAR(255),
    Balance DECIMAL(19,4),
    Paid BOOLEAN DEFAULT FALSE,
    BillDate DATETIME,
    BillMemo TEXT,
    LastUpdated DATETIME,
    UNIQUE INDEX idx_distributorcreditnote_bill (BillNumber),
    INDEX idx_distributorcreditnote_paid (Paid)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- =============================================
-- Table: DistributorCreditNoteDetail
-- =============================================
CREATE TABLE DistributorCreditNoteDetail (
    BillDetailID TEXT NOT NULL,
    BillNumber VARCHAR(50),
    itemName VARCHAR(50),
    Pack VARCHAR(255),
    QTY DOUBLE,
    TotalUnits INT,
    Batch VARCHAR(255),
    MRP DECIMAL(19,4),
    EXPDate DATETIME,
    Rate DECIMAL(19,4),
    Discount DECIMAL(19,4),
    VAT DECIMAL(19,4),
    Amount DECIMAL(19,4),
    Free INT,
    PRIMARY KEY (BillDetailID(100)),
    UNIQUE INDEX idx_distributorcreditnotedetail_id (BillDetailID(100))
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- =============================================
-- Table: DistributorItemControl
-- =============================================
CREATE TABLE DistributorItemControl (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    Account_ID VARCHAR(255),
    ItemName VARCHAR(255),
    CreatedOn DATETIME,
    INDEX idx_distributoritemcontrol_account (Account_ID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- =============================================
-- Table: ExpenseCodes
-- =============================================
CREATE TABLE ExpenseCodes (
    Expense VARCHAR(255) NOT NULL PRIMARY KEY,
    Description TEXT,
    Rate DECIMAL(19,4),
    CreatedOn DATETIME,
    LastUpdated DATETIME,
    INDEX idx_expensecodes_expense (Expense)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- =============================================
-- Table: ExpenseLog
-- =============================================
CREATE TABLE ExpenseLog (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    Expense VARCHAR(255),
    Description TEXT,
    EntryDate DATETIME,
    Discount DECIMAL(19,4),
    Markup DECIMAL(19,4),
    Rate DECIMAL(19,4),
    QTY DOUBLE,
    Amount DECIMAL(19,4),
    CreatedOn DATETIME,
    Lastupdated DATETIME,
    INDEX idx_expenselog_expense (Expense)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- =============================================
-- Table: Filters
-- =============================================
CREATE TABLE Filters (
    ScreenCode VARCHAR(255) NOT NULL PRIMARY KEY,
    Screen VARCHAR(255),
    FilterType_ID VARCHAR(255),
    ShowByEntity BOOLEAN DEFAULT FALSE,
    ShowByDate BOOLEAN DEFAULT FALSE,
    ToEntity VARCHAR(255),
    FromEntity VARCHAR(255),
    Status BOOLEAN DEFAULT FALSE,
    LastUpdated DATETIME,
    INDEX idx_filters_showbyentity (ShowByEntity),
    INDEX idx_filters_filtertype (FilterType_ID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- =============================================
-- Table: FilterType
-- =============================================
CREATE TABLE FilterType (
    FilterType_ID VARCHAR(255) NOT NULL PRIMARY KEY,
    FilterType VARCHAR(255),
    FromDate VARCHAR(255),
    ToDate VARCHAR(255),
    LastUpdated DATETIME
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- =============================================
-- Table: GlobalSetting
-- =============================================
CREATE TABLE GlobalSetting (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    ParamName VARCHAR(255),
    ParamValue VARCHAR(255),
    TabName VARCHAR(255),
    Lastupdated DATETIME
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- =============================================
-- Table: GroupDetail
-- =============================================
CREATE TABLE GroupDetail (
    GroupsDetail_ID INT AUTO_INCREMENT,
    GroupName VARCHAR(255) NOT NULL,
    Entity_ID VARCHAR(255) NOT NULL,
    EntityType INT NOT NULL,
    Lastupdated DATETIME,
    PRIMARY KEY (GroupName, Entity_ID, EntityType),
    INDEX idx_groupdetail_entity (Entity_ID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- =============================================
-- Table: Groups
-- =============================================
CREATE TABLE Groups (
    GroupName VARCHAR(255) NOT NULL PRIMARY KEY,
    GroupDescription TEXT,
    CreatedOn DATETIME,
    LastUpdated DATETIME
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- =============================================
-- Table: Invoices
-- =============================================
CREATE TABLE Invoices (
    InvoiceNumber INT NOT NULL PRIMARY KEY,
    TotalAmount DECIMAL(19,4),
    DiscountAmount DECIMAL(19,4),
    VATAmount DECIMAL(19,4),
    InvoiceAmount DECIMAL(19,4),
    Balance DECIMAL(19,4),
    InvoiceType INT,
    Paid BOOLEAN DEFAULT FALSE,
    Account_ID VARCHAR(50),
    InvoiceDate DATETIME,
    Client TEXT,
    InvMemo TEXT,
    Lastupdated DATETIME,
    HSNCODE VARCHAR(255),
    INDEX idx_invoices_hsncode (HSNCODE),
    INDEX idx_invoices_paid (Paid)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- =============================================
-- Table: InvoiceDetails
-- =============================================
CREATE TABLE InvoiceDetails (
    InvoiceDetailID TEXT NOT NULL,
    InvoiceNumber INT,
    ItemName VARCHAR(50),
    Pack VARCHAR(255),
    QTY DOUBLE,
    TotalUnits INT,
    Batch VARCHAR(255),
    MRP DECIMAL(19,4),
    EXPDate DATETIME,
    Discount DECIMAL(19,4),
    VAT DECIMAL(19,4),
    Amount DECIMAL(19,4),
    Rate DECIMAL(19,4),
    free DOUBLE,
    HSNCODE VARCHAR(255),
    PRIMARY KEY (InvoiceDetailID(100)),
    INDEX idx_invoicedetails_hsncode (HSNCODE)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- =============================================
-- Table: ItemList
-- =============================================
CREATE TABLE ItemList (
    ItemName VARCHAR(50) NOT NULL PRIMARY KEY,
    ItemPack VARCHAR(255),
    ItemLocation TEXT,
    GroupID VARCHAR(255),
    ItemDescription TEXT,
    CreateOn DATETIME,
    LastUpdated DATETIME,
    Manufacturer VARCHAR(255)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- =============================================
-- Table: ItemPricesAndTaxes
-- =============================================
CREATE TABLE ItemPricesAndTaxes (
    ItemName VARCHAR(255) NOT NULL,
    Batch VARCHAR(255) NOT NULL,
    BillDiscount DOUBLE,
    BillVat DOUBLE,
    InvoiceDiscount DOUBLE,
    InvoiceMarkup DOUBLE,
    DefaultMRP DOUBLE,
    DefaultRate DOUBLE,
    CreatedOn DATETIME,
    Lastupdated DATETIME,
    PRIMARY KEY (ItemName, Batch)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- =============================================
-- Table: ItemsAvailable
-- =============================================
CREATE TABLE ItemsAvailable (
    ItemName VARCHAR(50) NOT NULL,
    Batch VARCHAR(255) NOT NULL,
    Pack VARCHAR(255),
    QTY DOUBLE,
    Units INT,
    MRP DECIMAL(19,4),
    ExpDate DATETIME,
    CreatedOn DATETIME,
    LastUpdated DATETIME,
    PRIMARY KEY (ItemName, Batch)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- =============================================
-- Table: PaymentDetails
-- =============================================
CREATE TABLE PaymentDetails (
    PaymentDetail_ID INT AUTO_INCREMENT PRIMARY KEY,
    Payment_ID INT,
    InvoiceNumber INT,
    AmountPaid DECIMAL(19,4),
    InvoiceBalance DECIMAL(19,4)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- =============================================
-- Table: Payments
-- =============================================
CREATE TABLE Payments (
    Payment_ID INT NOT NULL PRIMARY KEY,
    Payee_ID VARCHAR(255),
    Amount DECIMAL(19,4),
    PayMethod INT,
    Retainer BOOLEAN DEFAULT FALSE,
    RetainerAmount DECIMAL(19,4),
    PaymentMemo TEXT,
    PaymentDate DATETIME,
    ReceiptNo VARCHAR(255),
    LastUpdated VARCHAR(255),
    INDEX idx_payments_payee (Payee_ID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- =============================================
-- Table: QuickBills
-- =============================================
CREATE TABLE QuickBills (
    QuickBill_ID INT AUTO_INCREMENT PRIMARY KEY,
    BillNumber VARCHAR(50),
    DistributorName TEXT,
    Address TEXT,
    Phone VARCHAR(255),
    Email VARCHAR(255),
    LastUpdated DATETIME,
    UNIQUE INDEX idx_quickbills_id (QuickBill_ID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- =============================================
-- Table: QuickCustomerNote
-- =============================================
CREATE TABLE QuickCustomerNote (
    QuickInvoice_ID INT AUTO_INCREMENT PRIMARY KEY,
    InvoiceNumber INT,
    CustomerName TEXT,
    Address TEXT,
    Phone VARCHAR(255),
    LastUpdated DATETIME,
    UNIQUE INDEX idx_quickcustomernote_id (QuickInvoice_ID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- =============================================
-- Table: QuickDistributorNote
-- =============================================
CREATE TABLE QuickDistributorNote (
    QuickBill_ID INT AUTO_INCREMENT PRIMARY KEY,
    BillNumber VARCHAR(50),
    DistributorName TEXT,
    Address TEXT,
    Phone VARCHAR(255),
    LastUpdated DATETIME,
    UNIQUE INDEX idx_quickdistributornote_id (QuickBill_ID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- =============================================
-- Table: QuickInvoices
-- =============================================
CREATE TABLE QuickInvoices (
    QuickInvoice_ID INT AUTO_INCREMENT PRIMARY KEY,
    InvoiceNumber INT,
    CustomerName TEXT,
    Address TEXT,
    Phone VARCHAR(255),
    Email VARCHAR(255),
    LastUpdated DATETIME
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- =============================================
-- Table: Settings
-- =============================================
CREATE TABLE Settings (
    SettingName VARCHAR(255),
    BackupPath VARCHAR(255),
    FileLocation VARCHAR(255),
    RememberUserName BOOLEAN DEFAULT FALSE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- =============================================
-- Table: StoreReconcilation
-- =============================================
CREATE TABLE StoreReconcilation (
    Recon_ID INT AUTO_INCREMENT PRIMARY KEY,
    IsUp BOOLEAN DEFAULT FALSE,
    itemName VARCHAR(255),
    QTY DOUBLE,
    TotalUnits DOUBLE,
    Batch VARCHAR(255),
    MRP DECIMAL(19,4),
    EXPDate DATETIME,
    Rate DECIMAL(19,4),
    Discount DECIMAL(19,4),
    VAT DECIMAL(19,4),
    Amount DECIMAL(19,4),
    CreatedOn DATETIME,
    UpdatedOn DATETIME
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- =============================================
-- Table: Users
-- =============================================
CREATE TABLE Users (
    LoginName VARCHAR(255) NOT NULL PRIMARY KEY,
    LoginPassword VARCHAR(255),
    ShopName VARCHAR(255),
    ShopAddress VARCHAR(255),
    ShopCity VARCHAR(255),
    ShopState VARCHAR(255),
    ShopPhone VARCHAR(255),
    ShopEmail VARCHAR(255),
    ShopPIN VARCHAR(255),
    Logopath LONGBLOB,
    greeting TEXT,
    CreatedOn DATETIME,
    LastUpdated DATETIME,
    LicenseNumber VARCHAR(255),
    GSTTINNumber VARCHAR(255),
    CSTNumber VARCHAR(255),
    IsDistributor BOOLEAN DEFAULT FALSE,
    WebSite VARCHAR(255)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- =============================================
-- Table: Version
-- =============================================
CREATE TABLE Version (
    Name VARCHAR(255),
    Version VARCHAR(255),
    Year VARCHAR(255),
    `Key` VARCHAR(255),
    INDEX idx_version_key (`Key`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- End of schema creation
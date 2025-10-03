using Microsoft.EntityFrameworkCore;
using ECom.Domain.Models;

namespace ECom.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Accounts> Accounts { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<AddressTemplate> AddressTemplate { get; set; }
        public DbSet<Bills> Bills { get; set; }
        public DbSet<BillDetails> BillDetails { get; set; }
        public DbSet<BillPayments> BillPayments { get; set; }
        public DbSet<BillPaymentDetails> BillPaymentDetails { get; set; }
        public DbSet<Communication> Communication { get; set; }
        public DbSet<CustomerCreditNote> CustomerCreditNote { get; set; }
        public DbSet<CustomerCreditNoteDetails> CustomerCreditNoteDetails { get; set; }
        public DbSet<CustomerItemControl> CustomerItemControl { get; set; }
        public DbSet<CustomLists> CustomLists { get; set; }
        public DbSet<CutomLabels> CutomLabels { get; set; }
        public DbSet<DistributorCreditNote> DistributorCreditNote { get; set; }
        public DbSet<DistributorCreditNoteDetail> DistributorCreditNoteDetail { get; set; }
        public DbSet<DistributorItemControl> DistributorItemControl { get; set; }
        public DbSet<ExpenseCodes> ExpenseCodes { get; set; }
        public DbSet<ExpenseLog> ExpenseLog { get; set; }
        public DbSet<Filters> Filters { get; set; }
        public DbSet<FilterType> FilterType { get; set; }
        public DbSet<GlobalSetting> GlobalSetting { get; set; }
        public DbSet<GroupDetail> GroupDetail { get; set; }
        public DbSet<Groups> Groups { get; set; }
        public DbSet<Invoices> Invoices { get; set; }
        public DbSet<InvoiceDetails> InvoiceDetails { get; set; }
        public DbSet<ItemList> ItemList { get; set; }
        public DbSet<ItemPricesAndTaxes> ItemPricesAndTaxes { get; set; }
        public DbSet<ItemsAvailable> ItemsAvailable { get; set; }
        public DbSet<PaymentDetails> PaymentDetails { get; set; }
        public DbSet<Payments> Payments { get; set; }
        public DbSet<QuickBills> QuickBills { get; set; }
        public DbSet<QuickCustomerNote> QuickCustomerNote { get; set; }
        public DbSet<QuickDistributorNote> QuickDistributorNote { get; set; }
        public DbSet<QuickInvoices> QuickInvoices { get; set; }
        public DbSet<Settings> Settings { get; set; }
        public DbSet<StoreReconcilation> StoreReconcilation { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Version> Version { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Further configuration (composite keys, indexes) can be added here.
        }
    }
}
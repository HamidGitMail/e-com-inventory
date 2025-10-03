using ECom.Application.Repositories;
using ECom.Application.Services;
using ECom.Application.Services.Interfaces;
using ECom.Data;
using ECom.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ECom.Api.DependencyInjection
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddEComServices(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ApplicationDbContext>(opt => opt.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

            // Register generic types
            services.AddScoped(typeof(GenericRepository<>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));

            // Per-entity registrations
            services.AddScoped<IAccountsRepository, AccountsRepository>();
            services.AddScoped<IAccountsService, AccountsService>();

            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<IAddressService, AddressService>();

            services.AddScoped<IAddressTemplateRepository, AddressTemplateRepository>();
            services.AddScoped<IAddressTemplateService, AddressTemplateService>();

            services.AddScoped<IBillsRepository, BillsRepository>();
            services.AddScoped<IBillsService, BillsService>();

            services.AddScoped<IBillDetailsRepository, BillDetailsRepository>();
            services.AddScoped<IBillDetailsService, BillDetailsService>();

            services.AddScoped<IBillPaymentsRepository, BillPaymentsRepository>();
            services.AddScoped<IBillPaymentsService, BillPaymentsService>();

            services.AddScoped<IBillPaymentDetailsRepository, BillPaymentDetailsRepository>();
            services.AddScoped<IBillPaymentDetailsService, BillPaymentDetailsService>();

            services.AddScoped<ICommunicationRepository, CommunicationRepository>();
            services.AddScoped<ICommunicationService, CommunicationService>();

            services.AddScoped<ICustomerCreditNoteRepository, CustomerCreditNoteRepository>();
            services.AddScoped<ICustomerCreditNoteService, CustomerCreditNoteService>();

            services.AddScoped<ICustomerCreditNoteDetailsRepository, CustomerCreditNoteDetailsRepository>();
            services.AddScoped<ICustomerCreditNoteDetailsService, CustomerCreditNoteDetailsService>();

            services.AddScoped<ICustomerItemControlRepository, CustomerItemControlRepository>();
            services.AddScoped<ICustomerItemControlService, CustomerItemControlService>();

            services.AddScoped<ICustomListsRepository, CustomListsRepository>();
            services.AddScoped<ICustomListsService, CustomListsService>();

            services.AddScoped<ICutomLabelsRepository, CutomLabelsRepository>();
            services.AddScoped<ICutomLabelsService, CutomLabelsService>();

            services.AddScoped<IDistributorCreditNoteRepository, DistributorCreditNoteRepository>();
            services.AddScoped<IDistributorCreditNoteService, DistributorCreditNoteService>();

            services.AddScoped<IDistributorCreditNoteDetailRepository, DistributorCreditNoteDetailRepository>();
            services.AddScoped<IDistributorCreditNoteDetailService, DistributorCreditNoteDetailService>();

            services.AddScoped<IDistributorItemControlRepository, DistributorItemControlRepository>();
            services.AddScoped<IDistributorItemControlService, DistributorItemControlService>();

            services.AddScoped<IExpenseCodesRepository, ExpenseCodesRepository>();
            services.AddScoped<IExpenseCodesService, ExpenseCodesService>();

            services.AddScoped<IExpenseLogRepository, ExpenseLogRepository>();
            services.AddScoped<IExpenseLogService, ExpenseLogService>();

            services.AddScoped<IFiltersRepository, FiltersRepository>();
            services.AddScoped<IFiltersService, FiltersService>();

            services.AddScoped<IFilterTypeRepository, FilterTypeRepository>();
            services.AddScoped<IFilterTypeService, FilterTypeService>();

            services.AddScoped<IGlobalSettingRepository, GlobalSettingRepository>();
            services.AddScoped<IGlobalSettingService, GlobalSettingService>();

            services.AddScoped<IGroupDetailRepository, GroupDetailRepository>();
            services.AddScoped<IGroupDetailService, GroupDetailService>();

            services.AddScoped<IGroupsRepository, GroupsRepository>();
            services.AddScoped<IGroupsService, GroupsService>();

            services.AddScoped<IInvoicesRepository, InvoicesRepository>();
            services.AddScoped<IInvoicesService, InvoicesService>();

            services.AddScoped<IInvoiceDetailsRepository, InvoiceDetailsRepository>();
            services.AddScoped<IInvoiceDetailsService, InvoiceDetailsService>();

            services.AddScoped<IItemListRepository, ItemListRepository>();
            services.AddScoped<IItemListService, ItemListService>();

            services.AddScoped<IItemPricesAndTaxesRepository, ItemPricesAndTaxesRepository>();
            services.AddScoped<IItemPricesAndTaxesService, ItemPricesAndTaxesService>();

            services.AddScoped<IItemsAvailableRepository, ItemsAvailableRepository>();
            services.AddScoped<IItemsAvailableService, ItemsAvailableService>();

            services.AddScoped<IPaymentDetailsRepository, PaymentDetailsRepository>();
            services.AddScoped<IPaymentDetailsService, PaymentDetailsService>();

            services.AddScoped<IPaymentsRepository, PaymentsRepository>();
            services.AddScoped<IPaymentsService, PaymentsService>();

            services.AddScoped<IQuickBillsRepository, QuickBillsRepository>();
            services.AddScoped<IQuickBillsService, QuickBillsService>();

            services.AddScoped<IQuickCustomerNoteRepository, QuickCustomerNoteRepository>();
            services.AddScoped<IQuickCustomerNoteService, QuickCustomerNoteService>();

            services.AddScoped<IQuickDistributorNoteRepository, QuickDistributorNoteRepository>();
            services.AddScoped<IQuickDistributorNoteService, QuickDistributorNoteService>();

            services.AddScoped<IQuickInvoicesRepository, QuickInvoicesRepository>();
            services.AddScoped<IQuickInvoicesService, QuickInvoicesService>();

            services.AddScoped<ISettingsRepository, SettingsRepository>();
            services.AddScoped<ISettingsService, SettingsService>();

            services.AddScoped<IStoreReconcilationRepository, StoreReconcilationRepository>();
            services.AddScoped<IStoreReconcilationService, StoreReconcilationService>();

            services.AddScoped<IUsersRepository, UsersRepository>();
            services.AddScoped<IUsersService, UsersService>();

            services.AddScoped<IVersionRepository, VersionRepository>();
            services.AddScoped<IVersionService, VersionService>();

            return services;
        }
    }
}
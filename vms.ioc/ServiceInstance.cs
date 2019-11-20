using vms.service.dbo;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using URF.Core.Abstractions;
using URF.Core.EF;
using vms.entity.models;
using vms.entity.viewModels;
using vms.repository.dbo;

//using vms.repository.dbo.StoredProcedure;

//using vms.service.dbo.acc;
//using vms.service.dbo.StoredProdecure;

namespace vms.ioc
{
    public static class ServiceInstance
    {
        public static void RegisterVMSServiceInstance(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("dev");
            services.AddDbContext<InventoryContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<DbContext, InventoryContext>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            
            services.AddSingleton<PurposeStringConstants>();

            


            //services.AddScoped<IAutocompleteRepository, AutocompleteRepository>();
            //services.AddScoped<IAutocompleteService, AutocompleteService>();
            //services.AddScoped<IBankRepository, BankRepository>();
            //services.AddScoped<IBankService, BankService>();
            //services.AddScoped<IMushok6P3ViewRepositoy, Mushok6P3ViewRepositoy>();
            //services.AddScoped<IMushok6P3ViewService, Mushok6P3ViewService>();
            //services.AddScoped<ISpGetSalePagedRepository, SpGetSalePagedRepository>();
            //services.AddScoped<ISpGetSalePagedService, SpGetSalePagedService>();
            //services.AddScoped<IDamageInvoiceListRepository, DamageInvoiceListRepository>();
            //services.AddScoped<IDamageInvoiceListService, DamageInvoiceListService>();

            //services.AddTransient<IOrganizationRepository, OrganizationRepository>();
            //services.AddTransient<IOrganizationService, OrganizationService>();

            //services.AddTransient<INbrEconomicCodeRepository, NbrEconomicCodeRepository>();
            //services.AddTransient<INbrEconomicCodeService, NbrEconomicCodeService>();
            //services.AddTransient<IBankBranchRepository, BankBranchRepository>();
            //services.AddTransient<IBankBranchService, BankBranchService>();

            //services.AddTransient<IMeasurementUnitRepository, MeasurementUnitRepository>();
            //services.AddTransient<IMeasurementUnitService, MeasurementUnitService>();

            //services.AddTransient<IOrderRepository, OrderRepository>();
            //services.AddTransient<IOrderService, OrderService>();

            //services.AddTransient<IProductRepository, ProductRepository>();
            //services.AddTransient<IProductService, ProductService>();

            //services.AddTransient<IProductGroupRepository, ProductGroupRepository>();
            //services.AddTransient<IProductGroupService, ProductGroupService>();

            //services.AddTransient<IDebitNoteRepository, DebitNoteRepository>();
            //services.AddTransient<IDebitNoteService, DebitNoteService>();

            //services.AddTransient<ICreditNoteRepository, CreditNoteRepository>();
            //services.AddTransient<ICreditNoteService, CreditNoteService>();



            //services.AddTransient<IPurchaseOrderRepository, PurchaseOrderRepository>();
            //services.AddTransient<IPurchaseOrderService, PurchaseOrderService>();
            //services.AddTransient<ISaleOrderRepository, SaleOrderRepository>();
            //services.AddTransient<ISaleOrdersService, SaleOrdersService>();
            //services.AddTransient<ISaleOrderDetailsRepository, SaleOrderDetailRepository>();
            //services.AddTransient<ISaleOrderDetailService, SaleOrderDetailService>();

            //services.AddTransient<IPurchaseOrderDetailsRepository, PurchaseOrderDetailRepository>();
            //services.AddTransient<IPurchaseOrderDetailService, PurchaseOrderDetailService>();

            //services.AddTransient<IPurchaseTypeRepository, PurchaseTypeRepository>();
            //services.AddTransient<IPurchaseTypeService, PurchaseTypeService>();

            //services.AddTransient<IRightRepository, RightRepository>();
            //services.AddTransient<IRightService, RightService>();

            //services.AddTransient<IRoleRepository, RoleRepository>();
            //services.AddTransient<IRoleService, RoleService>();

            //services.AddTransient<IRoleRightRepository, RoleRightRepository>();
            //services.AddTransient<IRoleRightService, RoleRightService>();

            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IVatRepository, VatRepository>();
            services.AddTransient<IVatService, VatService>();

            //services.AddTransient<ICoagroupRepository, CoagroupRepository>();
            //services.AddTransient<ICoagroupService, CoagroupService>();

            //services.AddTransient<ICustomerRepository, CustomerRepository>();
            //services.AddTransient<ICustomerService, CustomerService>();
            //services.AddTransient<IPriceSetupProductCostRepository, PriceSetupProductCostRepository>();
            //services.AddTransient<IPriceSetupProductCostService, PriceSetupProductCostService>();

            //services.AddTransient<IExportTypeRepository, ExportTypeRepository>();
            //services.AddTransient<IExportTypeService, ExportTypeService>();

            //services.AddTransient<IPurchaseDetailRepository, PurchaseDetailRepository>();
            //services.AddTransient<IPurchaseDetailService, PurchaseDetailService>();

            //services.AddTransient<IVendorRepository, VendorRepository>();
            //services.AddTransient<IVendorService, VendorService>();

            //services.AddTransient<IProductVatRepository, ProductVatRepository>();
            //services.AddTransient<IProductVatService, ProductVatService>();

            //services.AddTransient<ISaleRepository, SaleRepository>();
            //services.AddTransient<ISaleService, SaleService>();

            //services.AddTransient<ISalesDeliveryTypeRepository, SalesDeliveryTypeRepository>();
            //services.AddTransient<ISalesDeliveryTypeService, SalesDeliveryTypeService>();

            //services.AddTransient<ISalesDetailRepository, SalesDetailRepository>();
            //services.AddTransient<ISalesDetailService, SalesDetailService>();

            //services.AddTransient<ISalesTypeRepository, SalesTypeRepository>();
            //services.AddTransient<ISalesTypeService, SalesTypeService>();

            //services.AddTransient<ITransectionTypeRepository, TransectionTypeRepository>();
            //services.AddTransient<ITransectionTypeService, TransectionTypeService>();

            //services.AddTransient<IProductVatTypeRepository, ProductVatTypeRepository>();
            //services.AddTransient<IProductVatTypeService, ProductVatTypeService>();

            //services.AddTransient<IAuditLogRepository, AuditLogRepository>();
            //services.AddTransient<IAuditLogService, AuditLogService>();
            //services.AddTransient<IOverHeadCostRepository, OverHeadCostRepository>();
            //services.AddTransient<IOverHeadCostService, OverHeadCostService>();

            //services.AddTransient<IAuditOperationRepository, AuditOperationRepository>();
            //services.AddTransient<IAuditOperationService, AuditOperationService>();

            //services.AddTransient<IObjectTypeRepository, ObjectTypeRepository>();
            //services.AddTransient<IObjectTypeService, ObjectTypeService>();

            //services.AddTransient<IPurchaseReasonRepository, PurchaseReasonRepository>();
            //services.AddTransient<IPurchaseReasonService, PurchaseReasonService>();

            //services.AddTransient<IPriceSetupRepository, PriceSetupRepository>();
            //services.AddTransient<IPriceSetupService, PriceSetupService>();

            //services.AddTransient<IProductTypeRepository, ProductTypeRepository>();
            //services.AddTransient<IProductTypeService, ProductTypeService>();

            //services.AddTransient<IProductProductTypeMappingRepository, ProductProductTypeMappingRepository>();
            //services.AddTransient<IProductProductTypeMappingService, ProductProductTypeMappingService>();

            //services.AddTransient<IProductionRepository, ProductionRepository>();
            //services.AddTransient<IProductionService, ProductionService>();

            //services.AddTransient<IProductionDetailRepository, ProductionDetailRepository>();
            //services.AddTransient<IProductionDetailService, ProductionDetailService>();

            //services.AddTransient<IProductCategoryRepository, ProductCategoryRepository>();
            //services.AddTransient<IProductCategoryService, ProductCategoryService>();

            //services.AddTransient<IMushakGenerationRepository, MushakGenerationRepository>();
            //services.AddTransient<IMushakGenerationService, MushakGenerationService>();

            //services.AddTransient<ISupplimentaryDutyRepository, SupplimentaryDutyRepository>();
            //services.AddTransient<ISupplimentaryDutyService, SupplimentaryDutyService>();

            //services.AddTransient<IDamageTypeRepository, DamageTypeRepository>();
            //services.AddTransient<IDamageTypeService, DamageTypeService>();





            //services.AddTransient<IDeliveryMethodRepository, DeliveryMethodRepository>();
            //services.AddTransient<IDeliveryMethodService, DeliveryMethodService>();

            //services.AddTransient<IDeliveryMethodRepository, DeliveryMethodRepository>();
            //services.AddTransient<IDeliveryMethodService, DeliveryMethodService>();

            //services.AddTransient<IDocumentTypeRepository, DocumentTypeRepository>();
            //services.AddTransient<IDocumentTypeService, DocumentTypeService>();

            //services.AddTransient<IPaymentMethodRepository, PaymentMethodRepository>();
            //services.AddTransient<IPaymentMethodService, PaymentMethodService>();

            //services.AddTransient<IPurchasePaymentRepository, PurchasePaymentRepository>();
            //services.AddTransient<IPurchasePaymentService, PurchasePaymentService>();

            //services.AddTransient<ISalesPaymentReceiveRepository, SalesPaymentReceiveRepository>();
            //services.AddTransient<ISalesPaymentReceiveService, SalesPaymentReceiveService>();
        }
    }
}
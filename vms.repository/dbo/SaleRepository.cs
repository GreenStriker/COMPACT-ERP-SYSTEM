using Dapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using vms.entity.models;
using vms.entity.viewModels;
using vms.entity.viewModels.ReportsViewModel;

namespace vms.repository.dbo
{
   
    public interface ISaleRepository : IRepositoryBase<Sale>
    {
        Task<bool> InsertData(vmSaleOrder saleOrder);
        Task<bool> InsertCreditNote(vmCreditNote vmCreditNote);
        Task<Sale> GetSalesDetailsAsync(vmSalesDetails salesDetails);
        //IEnumerable<vmSaleOrder> GetAll();
    }

    public class SaleRepository : RepositoryBase<Sale>, ISaleRepository
    {
        private readonly DbContext _context;

        public SaleRepository(DbContext context) : base(context)
        {
            this._context = context;
        }

        public  Task<Sale> GetSalesDetailsAsync(vmSalesDetails salesDetails)
        {
            try
            {
              
                var parameter = new DynamicParameters();
                parameter.Add("@FromDate", salesDetails.FromDate);
                parameter.Add("@ToDate", salesDetails.ToDate);
                parameter.Add("@InvoiceNo", salesDetails.InvoiceNo);
                parameter.Add("@CustomerName", salesDetails.CustomerName);
             
                //var data =  _context.Database.(
                //      $"EXEC [dbo].[GetMushok6.3Info]  " +
                //      $"@FromDate," +
                //      $"@ToDate," +
                //      $"@InvoiceNo," +
                //      $"@CustomerName"

                //      , new SqlParameter("@FromDate",Convert.ToDateTime(salesDetails.FromDate))
                //      , new SqlParameter("@ToDate", Convert.ToDateTime(salesDetails.ToDate))
                //      , new SqlParameter("@InvoiceNo", salesDetails.InvoiceNo)
                //      , new SqlParameter("@CustomerName", salesDetails.CustomerId)

                //  );
                
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
          
        }
        public async Task<bool> InsertCreditNote(vmCreditNote vmCreditNote)
        {
            var creditNoteDetails = Newtonsoft.Json.JsonConvert.SerializeObject(vmCreditNote.CreditNoteDetails);
            try
            {
                this._context.Database.ExecuteSqlCommand(
                    $"EXEC [dbo].[SpCreditNote]  " +
                    $"@SalesId," +
                    $"@ReasonOfReturn," +
                    $"@ReturnDate," +
                    $"@CreatedBy," +
                    $"@CreatedTime," +
                    $"@CreditNoteDetails"
                    , new SqlParameter("@SalesId", (object)vmCreditNote.SalesId ?? DBNull.Value)
                    , new SqlParameter("@ReasonOfReturn", (object)vmCreditNote.ReasonOfReturn ?? DBNull.Value)
                    , new SqlParameter("@ReturnDate", (object)vmCreditNote.ReturnDate ?? DBNull.Value)
                    , new SqlParameter("@CreatedBy", (object)vmCreditNote.CreatedBy ?? DBNull.Value)
                    , new SqlParameter("@CreatedTime", (object)vmCreditNote.CreatedTime ?? DBNull.Value)
                    , new SqlParameter("@CreditNoteDetails", (object)creditNoteDetails ?? DBNull.Value)
                );

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return await Task.FromResult(true);
        }
        public async Task<bool> InsertData(vmSaleOrder saleOrder)
        {
            var saleDetailsJson = Newtonsoft.Json.JsonConvert.SerializeObject(saleOrder.SalesDetailList);
            var PaymentReceiveJson = Newtonsoft.Json.JsonConvert.SerializeObject(saleOrder.SalesPaymentReceiveJson);
            string ContentJson = null;//
            if (saleOrder.ContentInfoJson!=null)
            {
                ContentJson= Newtonsoft.Json.JsonConvert.SerializeObject(saleOrder.ContentInfoJson);
            }
            var IsCanceled = false;
            saleOrder.CreatedTime = DateTime.Today;
            try
            {
                this._context.Database.ExecuteSqlCommand(
                    $"EXEC [dbo].[SpInsertSale]  " +
                    $"@InvoiceNo," +
                    $"@VatChallanNo," +
                    $"@OrganizationId," +
                    $"@DiscountOnTotalPrice," +
                    $"@IsVatDeductedInSource," +
                    $"@CustomerId," +
                    $"@ReceiverName," +
                    $"@ReceiverContactNo," +
                    $"@ShippingAddress," +
                    $"@ShippingCountryId," +
                    $"@SalesTypeId," +
                    $"@SalesDeliveryTypeId," +
                    $"@WorkOrderNo ," +
                    $"@SalesDate," +
                    $"@ExpectedDeliveryDate," +
                    $"@DeliveryDate ," +
                    $"@DeliveryMethodId," +
                    $"@ExportTypeId ," +
                    $"@LcNo," +
                    $"@LcDate," +
                    $"@BillOfEntry," +
                    $"@BillOfEntryDate," +
                    $"@DueDate," +
                    $"@TermsOfLc," +
                    $"@CustomerPoNumber," +
                    $"@OtherBranchOrganizationId," +
                    $"@IsComplete," +
                    $"@IsTaxInvoicePrined," +
                    $"@CreatedBy," +
                    $"@CreatedTime," +
                    $"@SalesDetailsJson," +
                    $"@PaymentReceiveJson," +
                    $"@ContentJson"
                    , new SqlParameter("@InvoiceNo", (object) saleOrder.InvoiceNo ?? DBNull.Value)
                    , new SqlParameter("@VatChallanNo", (object)saleOrder.VatChallanNo ?? DBNull.Value)
                    , new SqlParameter("@OrganizationId", (object)saleOrder.OrganizationId ?? DBNull.Value)
                    , new SqlParameter("@DiscountOnTotalPrice", (object)saleOrder.DiscountOnTotalPrice ?? DBNull.Value)
                    , new SqlParameter("@IsVatDeductedInSource", (object)saleOrder.IsVatDeductedInSource ?? DBNull.Value)
                    , new SqlParameter("@CustomerId", (object)saleOrder.CustomerId ?? DBNull.Value)
                    , new SqlParameter("@ReceiverName", (object)saleOrder.ReceiverName ?? DBNull.Value)
                    , new SqlParameter("@ReceiverContactNo",(object) saleOrder.ReceiverContactNo??DBNull.Value)
                    , new SqlParameter("@ShippingAddress",(object) saleOrder.ShippingAddress??DBNull.Value)
               
                    , new SqlParameter("@ShippingCountryId", (object)saleOrder.ShippingCountryId ?? DBNull.Value)
                    , new SqlParameter("@SalesTypeId",(object) saleOrder.SalesTypeId??DBNull.Value)
                    , new SqlParameter("@SalesDeliveryTypeId", saleOrder.SalesDeliveryTypeId)
                    , new SqlParameter("@WorkOrderNo", (object)saleOrder.WorkOrderNo ?? DBNull.Value)
                    , new SqlParameter("@SalesDate", saleOrder.SalesDate)
                    , new SqlParameter("@ExpectedDeliveryDate", (object) saleOrder.ExpectedDeliveryDate ?? DBNull.Value)
                    , new SqlParameter("@DeliveryDate", (object) saleOrder.DeliveryDate ?? DBNull.Value)
                    , new SqlParameter("@DeliveryMethodId", (object) saleOrder.DeliveryMethodId ?? DBNull.Value)
                    , new SqlParameter("@ExportTypeId", (object)saleOrder.ExportTypeId ?? DBNull.Value)
                    , new SqlParameter("@LcNo", (object)saleOrder.LcNo ?? DBNull.Value)
                    , new SqlParameter("@LcDate", (object)saleOrder.LcDate ?? DBNull.Value)
                    , new SqlParameter("@BillOfEntry", (object)saleOrder.BillOfEntry ?? DBNull.Value)
                    , new SqlParameter("@BillOfEntryDate", (object)saleOrder.BillOfEntryDate ?? DBNull.Value)
                    , new SqlParameter("@DueDate", (object)saleOrder.DueDate ?? DBNull.Value)
                    , new SqlParameter("@TermsOfLc", (object)saleOrder.TermsOfLc ?? DBNull.Value)
                    , new SqlParameter("@CustomerPoNumber", (object)saleOrder.CustomerPoNumber ?? DBNull.Value)
                    , new SqlParameter("@OtherBranchOrganizationId", (object)saleOrder.OtherBranchOrganizationId ?? DBNull.Value)
                    , new SqlParameter("@IsComplete", (object)saleOrder.IsComplete ?? DBNull.Value)
                    , new SqlParameter("@IsTaxInvoicePrined", (object)saleOrder.IsTaxInvoicePrined ?? DBNull.Value)
                    , new SqlParameter("@CreatedBy", (object)saleOrder.CreatedBy ?? DBNull.Value)
                    , new SqlParameter("@CreatedTime", (object)saleOrder.CreatedTime ?? DBNull.Value)
                    , new SqlParameter("@SalesDetailsJson", (object)saleDetailsJson ?? DBNull.Value)
                    , new SqlParameter("@PaymentReceiveJson", (object)PaymentReceiveJson ?? DBNull.Value)
                    , new SqlParameter("@ContentJson", (object)ContentJson ?? DBNull.Value)
                );

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
 
            return await Task.FromResult(true);
        }
    }
}

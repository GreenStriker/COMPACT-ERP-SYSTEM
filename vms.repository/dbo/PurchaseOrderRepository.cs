using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.SqlServer.Metadata.Conventions.Internal;
using Newtonsoft.Json;
using vms.entity.models;
using vms.entity.viewModels;

namespace vms.repository.dbo
{
    public interface IPurchaseOrderRepository : IRepositoryBase<Purchase>
    {
        Task<bool> InsertData(VmPurchase purchase);
        Task<bool> InsertDebitNote(vmDebitNote vmDebitNote);
        Task<bool> ManagePurchaseDue(vmPurchasePayment vmPurchase);
    }

    public class PurchaseOrderRepository : RepositoryBase<Purchase>, IPurchaseOrderRepository
    {
        private readonly DbContext _context;

        public PurchaseOrderRepository(DbContext context) : base(context)
        {
            this._context = context;
        }

        //public async Task<bool> InsertData(VmPurchase purchase)
        //{
        //    var purchaseDetails = Newtonsoft.Json.JsonConvert.SerializeObject(purchase.PurchaseOrderDetailList);

        //    var CanceledPurchaseId = 0;
        //    purchase.CreatedBy = purchase.CreatedBy; //TODO AFTER Global Session Implement
        //    purchase.CreatedTime=DateTime.Today;
        //  //  purchase.CancelTime=DateTime.Today;
        //    if (purchase.Flag==1)
        //    {
        //        CanceledPurchaseId = purchase.PurchaseId;
        //        purchase.CancelTime=DateTime.Today;
        //        purchase.CancelBy = purchase.CreatedBy;//TODO AFTER Session Implement
        //    }
        //    var currentDate = DateTime.Today;
        //    var isCanceled = false;
        //    try
        //    {
        //        this._context.Database.ExecuteSqlCommand(
        //            $"EXEC [dbo].[SpInsertPurchase]  " +
        //            $"@VendorId " +
        //            $",@VendorInvoiceNo " +
        //            $",@InvoiceNo " +
        //            $",@OrganizationId " +
        //            $",@PurchaseDate ," +
        //            $" @PurchaseTypeId " +
        //            $",@PurchaseReasonId " +
        //            $",@Discount " +
        //            $",@ExpectedDeliveryDate " +
        //            $",@DeleveryDate" +
        //            $" , @IsComplete" +
        //            $" ,@IsCanceled" +
        //            $" , @CreatedBy " +
        //            $",@CreatedTime " +
        //            $",@CanceledPurchaseId " +
        //            $",@ReasonOfCancel " +
        //            $",@CancelBy " +
        //            $",@CancelTime " +
        //            $",@PurchaseOrderDetailsJson  "
        //            , new SqlParameter("@VendorId", purchase.VendorId)
        //            , new SqlParameter("@VendorInvoiceNo", purchase.VendorInvoiceNo)
        //            , new SqlParameter("@InvoiceNo", purchase.InvoiceNo)
        //            , new SqlParameter("@OrganizationId", purchase.OrganizationId)
        //            , new SqlParameter("@PurchaseDate", currentDate)
        //            , new SqlParameter("@PurchaseTypeId", purchase.PurchaseTypeId)
        //            , new SqlParameter("@PurchaseReasonId", purchase.PurchaseReasonId)
        //            , new SqlParameter("@Discount", purchase.Discount)
        //            , new SqlParameter("@ExpectedDeliveryDate", purchase.ExpectedDeliveryDate)
        //            , new SqlParameter("@DeleveryDate", purchase.DeliveryDate)
        //            , new SqlParameter("@IsComplete", purchase.IsComplete)
        //            , new SqlParameter("@IsCanceled", isCanceled)
        //            , new SqlParameter("@CreatedBy", purchase.CreatedBy)
        //            , new SqlParameter("@CreatedTime", purchase.CreatedTime)
        //            , new SqlParameter("@CanceledPurchaseId", (object)CanceledPurchaseId ?? DBNull.Value)
        //            , new SqlParameter("@ReasonOfCancel", (object)purchase.ReasonOfCancel ?? DBNull.Value)
        //            , new SqlParameter("@CancelBy", (object)purchase.CancelBy ?? DBNull.Value)
        //            , new SqlParameter("@CancelTime",(object)purchase.CancelTime ?? DBNull.Value )
        //            , new SqlParameter("@PurchaseOrderDetailsJson", purchaseDetails)
        //        );

        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //        throw;
        //    }

        //    return await Task.FromResult(true);
        //}
        public async Task<bool> InsertData(VmPurchase purchase)
        {
            var purchaseDetails = Newtonsoft.Json.JsonConvert.SerializeObject(purchase.PurchaseOrderDetailList);
            
            string purchasePaymentJson = null;
            if (purchase.PurchasePaymenJson != null)
                 purchasePaymentJson = Newtonsoft.Json.JsonConvert.SerializeObject(purchase.PurchasePaymenJson);

            string ContentInfoJson = null;
            if (purchase.ContentInfoJson != null)
                ContentInfoJson = Newtonsoft.Json.JsonConvert.SerializeObject(purchase.ContentInfoJson);

            var CanceledPurchaseId = 0;
            purchase.CreatedBy = purchase.CreatedBy; //TODO AFTER Global Session Implement
            purchase.CreatedTime = DateTime.Today;
            //  purchase.CancelTime=DateTime.Today;
           
            var currentDate = DateTime.Today;
            var isCanceled = false;
            try
            {
                this._context.Database.ExecuteSqlCommand(
                    $"EXEC [dbo].[SpInsertPurchase]" +
                    $"@OrganizationId " +
                    $",@VendorId" +
                    $",@VatChallanNo" +
                    $",@VatChallanIssueDate" +
                    $",@VendorInvoiceNo " +
                    $",@InvoiceNo" +
                    $",@PurchaseDate" +
                    $",@PurchaseTypeId " +
                    $",@PurchaseReasonId " +
                    $",@DiscountOnTotalPrice" +
                    $",@IsVatDeductedInSource" +
                    $",@VDSAmount" +
                    $",@ExpectedDeliveryDate " +
                    $",@DeliveryDate" +
                    $",@LcNo" +
                    $",@LcDate" +
                    $",@BillOfEntry" +
                    $",@BillOfEntryDate" +
                    $",@DueDate" +
                    $",@TermsOfLc" +
                    $",@PoNumber" +
                    $",@MushakGenerationId" +
                    $",@IsComplete" +
                    $",@CreatedBy" +
                    $",@CreatedTime" +
                    $",@PurchaseOrderDetailsJson" +
                    $",@PurchasePaymentJson" +
                    $",@ContentJson"
                    , new SqlParameter("@OrganizationId", purchase.OrganizationId)
                    , new SqlParameter("@VendorId", purchase.VendorId)
                    , new SqlParameter("@VatChallanNo", purchase.VatChallanNo)
                    , new SqlParameter("@VatChallanIssueDate", (object)purchase.VatChallanIssueDate ?? DBNull.Value)
                    , new SqlParameter("@VendorInvoiceNo", (object)purchase.VendorInvoiceNo ?? DBNull.Value)
                    , new SqlParameter("@InvoiceNo", (object)purchase.InvoiceNo ?? DBNull.Value)
                    , new SqlParameter("@PurchaseDate", (object)currentDate ?? DBNull.Value)
                    , new SqlParameter("@PurchaseTypeId", (object)purchase.PurchaseTypeId ?? DBNull.Value)
                    , new SqlParameter("@PurchaseReasonId", (object)purchase.PurchaseReasonId ?? DBNull.Value)
                    , new SqlParameter("@DiscountOnTotalPrice", (object)purchase.DiscountOnTotalPrice ?? DBNull.Value)
                    , new SqlParameter("@IsVatDeductedInSource", (object)purchase.IsVatDeductedInSource ?? DBNull.Value)
                    , new SqlParameter("@VDSAmount", (object)purchase.VDSAmount ?? DBNull.Value)
                    , new SqlParameter("@ExpectedDeliveryDate", (object)purchase.ExpectedDeliveryDate ?? DBNull.Value)
                    , new SqlParameter("@DeliveryDate", (object)purchase.DeliveryDate ?? DBNull.Value)
                    , new SqlParameter("@LcNo", (object)purchase.LcNo ?? DBNull.Value)
                    , new SqlParameter("@LcDate", (object)purchase.LcDate ?? DBNull.Value)
                    , new SqlParameter("@BillOfEntry", (object)purchase.BillOfEntry ?? DBNull.Value)
                    , new SqlParameter("@BillOfEntryDate", (object)purchase.BillOfEntryDate ?? DBNull.Value)
                    , new SqlParameter("@DueDate", (object)purchase.DueDate ?? DBNull.Value)
                    , new SqlParameter("@TermsOfLc", (object)purchase.TermsOfLc ?? DBNull.Value)
                    , new SqlParameter("@PoNumber", (object)purchase.PoNumber ?? DBNull.Value)
                    , new SqlParameter("@MushakGenerationId", (object)purchase.MushakGenerationId ?? DBNull.Value)
                    , new SqlParameter("@IsComplete", (object)purchase.IsComplete ?? DBNull.Value)
                    , new SqlParameter("@CreatedBy", (object)purchase.CreatedBy ?? DBNull.Value)
                    , new SqlParameter("@CreatedTime", (object)purchase.CreatedTime ?? DBNull.Value)
                    , new SqlParameter("@PurchaseOrderDetailsJson", (object)purchaseDetails ?? DBNull.Value)
                    , new SqlParameter("@PurchasePaymentJson", (object)purchasePaymentJson ?? DBNull.Value)
                    , new SqlParameter("@ContentJson", (object)ContentInfoJson ?? DBNull.Value)
                );
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return await Task.FromResult(true);
        }

        public async Task<bool> InsertDebitNote(vmDebitNote vmDebitNote)
        {
            var debitNoteDetails = Newtonsoft.Json.JsonConvert.SerializeObject(vmDebitNote.DebitNoteDetails);
            try
            {
                this._context.Database.ExecuteSqlCommand(
                    $"EXEC [dbo].[spInsertDebitNote]  " +
                    $"@PurchaseId," +
                    $"@ReasonOfReturn," +
                    $"@ReturnDate," +
                    $"@CreatedBy," +
                    $"@CreatedTime," +
                    $"@DebitNoteDetails"
                    , new SqlParameter("@PurchaseId", (object)vmDebitNote.PurchaseId ?? DBNull.Value)
                    , new SqlParameter("@ReasonOfReturn", (object)vmDebitNote.ReasonOfReturn ?? DBNull.Value)
                    , new SqlParameter("@ReturnDate", (object)vmDebitNote.ReturnDate ?? DBNull.Value)
                    , new SqlParameter("@CreatedBy", (object)vmDebitNote.CreatedBy ?? DBNull.Value)
                    , new SqlParameter("@CreatedTime", (object)vmDebitNote.CreatedTime ?? DBNull.Value)
                    , new SqlParameter("@DebitNoteDetails", (object)debitNoteDetails ?? DBNull.Value)
                );

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return await Task.FromResult(true);
        }

        public async Task<bool> ManagePurchaseDue(vmPurchasePayment vmPurchase)
        {
            try
            {
                this._context.Database.ExecuteSqlCommand(
                    $"EXEC [dbo].[SPManagePurchaseDue]" +
                    $"@PurchaseId " +
                    $",@PaymentMethodId" +
                    $",@PaidAmount" +
                    $",@CreatedBy "

                    , new SqlParameter("@PurchaseId", vmPurchase.PurchaseId)
                    , new SqlParameter("@PaymentMethodId", vmPurchase.PaymentMethodId)
                    , new SqlParameter("@PaidAmount", vmPurchase.PaidAmount)
                    , new SqlParameter("@CreatedBy", vmPurchase.CreatedBy)
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
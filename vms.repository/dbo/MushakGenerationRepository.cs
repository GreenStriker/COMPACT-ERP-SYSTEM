using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using vms.entity.models;
using vms.entity.StoredProcedureModel;

namespace vms.repository.dbo
{
  
    public interface IMushakGenerationRepository : IRepositoryBase<MushakGeneration>
    {
        Task<bool> InsertMushak(SpAddMushakReturnBasicInfo vm);
        Task<bool> InsertReturnPlanToPaymentInfo(SpAddMushakReturnPlanToPaymentInfo model);
        Task<bool> InsertReturnPaymentInfo(SpAddMushakReturnPaymentInfo model);
        Task<bool> InsertSubmissionInfo(SpAddMushakReturnSubmissionInfo vm);
        Task<bool> InsertReturnReturnedAmountInfo(SpAddMushakReturnReturnedAmountInfo vm);
        Task<bool> InsertAddMushakReturnCompleteProcess(int id);
    }
    public class MushakGenerationRepository : RepositoryBase<MushakGeneration>, IMushakGenerationRepository
    {
        private readonly DbContext _context;

        public MushakGenerationRepository(DbContext context) : base(context)
        {
            this._context = context;
        }


        public async Task<bool> InsertMushak(SpAddMushakReturnBasicInfo vm)
        { 
            try
            {
                this._context.Database.ExecuteSqlCommand(
                    $"EXEC [dbo].[SpAddMushakReturnBasicInfo]" +
                    $"@OrganizationId," +
                    $"@Year," +
                    $"@Month," +
                    $"@GenerateDate," +
                    $"@InterestForDueVat," +
                    $"@InterestForDueSd,"+
                    $"@FinancialPenalty," +
                    $"@ExciseDuty," +
                    $"@DevelopmentSurcharge," +
                    $"@ItDevelopmentSurcharge," +
                    $"@HealthDevelopmentSurcharge," +
                    $"@EnvironmentProtectSurcharge," +
                    $"@IsWantToGetBackClosingAmount"
                    , new SqlParameter("@OrganizationId", (object)vm.OrganizationId ?? DBNull.Value)
                    , new SqlParameter("@Year", (object)vm.Year ?? DBNull.Value)
                    , new SqlParameter("@Month", (object)vm.Month ?? DBNull.Value)
                    , new SqlParameter("@GenerateDate", (object)vm.GenerateDate ?? DBNull.Value)
                    , new SqlParameter("@InterestForDueVat", (object)vm.InterestForDueVat ?? DBNull.Value)
                    , new SqlParameter("@InterestForDueSd", (object)vm.InterestForDueSd ?? DBNull.Value)
                    , new SqlParameter("@FinancialPenalty", (object)vm.FinancialPenalty ?? DBNull.Value)
                    , new SqlParameter("@ExciseDuty", (object)vm.ExciseDuty ?? DBNull.Value)
                    , new SqlParameter("@DevelopmentSurcharge", (object)vm.DevelopmentSurcharge ?? DBNull.Value)
                    , new SqlParameter("@ItDevelopmentSurcharge", (object)vm.ItDevelopmentSurcharge ?? DBNull.Value)
                    , new SqlParameter("@HealthDevelopmentSurcharge", (object)vm.HealthDevelopmentSurcharge ?? DBNull.Value)
                    , new SqlParameter("@EnvironmentProtectSurcharge", (object)vm.EnvironmentProtectSurcharge ?? DBNull.Value)
                    , new SqlParameter("@IsWantToGetBackClosingAmount", (object)vm.IsWantToGetBackClosingAmount ?? DBNull.Value)
                );
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return await Task.FromResult(true);
        }

        public async Task<bool> InsertReturnPaymentInfo(SpAddMushakReturnPaymentInfo model)
        {
            try
            {
                this._context.Database.ExecuteSqlCommand(
                    $"EXEC [dbo].[SpAddMushakReturnPaymentInfo]" +
                    $"@MushakGenerationId," +
                    $"@VatPaymentChallanNo," +
                    $"@SuppDutyChallanNo," +
                    $"@InterestForDueVatChallanNo," +
                    $"@InterestForDueSuppDutyChallanNo," +
                    $"@FinancialPenaltyChallanNo," +
                    $"@ExciseDutyChallanNo," +
                    $"@DevelopmentSurchargeChallanNo," +
                    $"@ItDevelopmentSurchargeChallanNo," +
                    $"@HealthDevelopmentSurchargeChallanNo," +
                    $"@EnvironmentProtectSurchargeChallanNo" 
                    , new SqlParameter("@MushakGenerationId", (object)model.MushakGenerationId ?? DBNull.Value)
                    , new SqlParameter("@VatPaymentChallanNo", (object)model.VatPaymentChallanNo ?? DBNull.Value)
                    , new SqlParameter("@SuppDutyChallanNo", (object)model.SuppDutyChallanNo ?? DBNull.Value)
                    , new SqlParameter("@InterestForDueVatChallanNo", (object)model.InterestForDueVatChallanNo ?? DBNull.Value)
                    , new SqlParameter("@InterestForDueSuppDutyChallanNo", (object)model.InterestForDueSuppDutyChallanNo ?? DBNull.Value)
                    , new SqlParameter("@FinancialPenaltyChallanNo", (object)model.FinancialPenaltyChallanNo ?? DBNull.Value)
                    , new SqlParameter("@ExciseDutyChallanNo", (object)model.ExciseDutyChallanNo ?? DBNull.Value)
                    , new SqlParameter("@DevelopmentSurchargeChallanNo", (object)model.DevelopmentSurchargeChallanNo ?? DBNull.Value)
                    , new SqlParameter("@ItDevelopmentSurchargeChallanNo", (object)model.ItDevelopmentSurchargeChallanNo ?? DBNull.Value)
                    , new SqlParameter("@HealthDevelopmentSurchargeChallanNo", (object)model.HealthDevelopmentSurchargeChallanNo ?? DBNull.Value)
                    , new SqlParameter("@EnvironmentProtectSurchargeChallanNo", (object)model.EnvironmentProtectSurchargeChallanNo ?? DBNull.Value)
                   
                );
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return await Task.FromResult(true);
        }

        public async Task<bool> InsertReturnPlanToPaymentInfo(SpAddMushakReturnPlanToPaymentInfo model)
        {
            try
            {
                this._context.Database.ExecuteSqlCommand(
                    $"EXEC [dbo].[SpAddMushakReturnPlanToPaymentInfo]" +
                                        $"@MushakGenerationId," +
                    $"@PaidVatAmount," +
                    $"@VatEconomicCodeId," +
                    $"@VatPaymentDate," +
                    $"@VatPaymentBankBranchId," +
                    $"@PaidSuppDutyAmount," +
                    $"@SuppDutyEconomicCodeId," +
                    $"@SuppDutyPaymentDate," +
                    $"@SuppDutyBankBranchId," +
                    $"@PaidInterestAmountForDueVat," +
                    $"@InterestForDueVatEconomicCodeId," +
                    $"@InterestForDueVatPaymentDate," +
                    $"@InterestForDueVatBankBranchId," +
                    $"@PaidInterestAmountForDueSuppDuty," +
                    $"@InterestForDueSuppDutyEconomicCodeId," +
                    $"@InterestForDueSuppDutyPaymentDate," +
                    $"@InterestForDueSuppDutyBankBranchId," +
                    $"@PaidFinancialPenalty," +
                    $"@FinancialPenaltyEconomicCodeId," +
                    $"@FinancialPenaltyPaymentDate," +
                    $"@FinancialPenaltyBankBranchId," +
                    $"@PaidExciseDuty," +
                    $"@ExciseDutyEconomicCodeId," +
                    $"@ExciseDutyPaymentDate," +
                    $"@ExciseDutyBankBranchId," +
                    $"@PaidDevelopmentSurcharge," +
                    $"@DevelopmentSurchargeEconomicCodeId," +
                    $"@DevelopmentSurchargePaymentDate," +
                    $"@DevelopmentSurchargeBankBranchId," +
                    $"@PaidItDevelopmentSurcharge," +
                    $"@ItDevelopmentSurchargeEconomicCodeId," +
                    $"@ItDevelopmentSurchargePaymentDate," +
                    $"@ItDevelopmentSurchargeBankBranchId," +
                    $"@PaidHealthDevelopmentSurcharge," +
                    $"@HealthDevelopmentSurchargeEconomicCodeId," +
                    $"@HealthDevelopmentSurchargePaymentDate," +
                    $"@HealthDevelopmentSurchargeBankBranchId," +
                    $"@PaidEnvironmentProtectSurcharge," +
                    $"@EnvironmentProtectSurchargeEconomicCodeId," +
                    $"@EnvironmentProtectSurchargePaymentDate," +
                    $"@EnvironmentProtectSurchargeBankBranchId"
                    , new SqlParameter("@MushakGenerationId", (object)model.MushakGenerationId ?? DBNull.Value)
                    , new SqlParameter("@PaidVatAmount", (object)model.PaidVatAmount ?? DBNull.Value)
                    , new SqlParameter("@VatEconomicCodeId", (object)model.VatEconomicCodeId ?? DBNull.Value)
                    , new SqlParameter("@VatPaymentDate", (object)model.VatPaymentDate ?? DBNull.Value)
                    , new SqlParameter("@VatPaymentBankBranchId", (object)model.VatPaymentBankBranchId ?? DBNull.Value)
                    , new SqlParameter("@PaidSuppDutyAmount", (object)model.PaidSuppDutyAmount ?? DBNull.Value)
                    , new SqlParameter("@SuppDutyEconomicCodeId", (object)model.SuppDutyEconomicCodeId ?? DBNull.Value)
                    , new SqlParameter("@SuppDutyPaymentDate", (object)model.SuppDutyPaymentDate ?? DBNull.Value)
                    , new SqlParameter("@SuppDutyBankBranchId", (object)model.SuppDutyBankBranchId ?? DBNull.Value)
                    , new SqlParameter("@PaidInterestAmountForDueVat", (object)model.PaidInterestAmountForDueVat ?? DBNull.Value)
                    , new SqlParameter("@InterestForDueVatEconomicCodeId", (object)model.InterestForDueVatEconomicCodeId ?? DBNull.Value)
                    , new SqlParameter("@InterestForDueVatPaymentDate", (object)model.InterestForDueVatPaymentDate ?? DBNull.Value)
                    , new SqlParameter("@InterestForDueVatBankBranchId", (object)model.InterestForDueVatBankBranchId ?? DBNull.Value)

                    , new SqlParameter("@PaidInterestAmountForDueSuppDuty", (object)model.PaidInterestAmountForDueSuppDuty ?? DBNull.Value)
                    , new SqlParameter("@InterestForDueSuppDutyEconomicCodeId", (object)model.InterestForDueSuppDutyEconomicCodeId ?? DBNull.Value)
                    , new SqlParameter("@InterestForDueSuppDutyPaymentDate", (object)model.InterestForDueSuppDutyPaymentDate ?? DBNull.Value)
                    , new SqlParameter("@InterestForDueSuppDutyBankBranchId", (object)model.InterestForDueSuppDutyBankBranchId ?? DBNull.Value)
                    , new SqlParameter("@PaidFinancialPenalty", (object)model.PaidFinancialPenalty ?? DBNull.Value)
                    , new SqlParameter("@FinancialPenaltyEconomicCodeId", (object)model.FinancialPenaltyEconomicCodeId ?? DBNull.Value)
                    , new SqlParameter("@FinancialPenaltyPaymentDate", (object)model.FinancialPenaltyPaymentDate ?? DBNull.Value)
                    , new SqlParameter("@FinancialPenaltyBankBranchId", (object)model.FinancialPenaltyBankBranchId ?? DBNull.Value)

                    , new SqlParameter("@PaidExciseDuty", (object)model.PaidExciseDuty ?? DBNull.Value)
                    , new SqlParameter("@ExciseDutyEconomicCodeId", (object)model.ExciseDutyEconomicCodeId ?? DBNull.Value)
                    , new SqlParameter("@ExciseDutyPaymentDate", (object)model.ExciseDutyPaymentDate ?? DBNull.Value)
                    , new SqlParameter("@ExciseDutyBankBranchId", (object)model.ExciseDutyBankBranchId ?? DBNull.Value)
                    , new SqlParameter("@PaidDevelopmentSurcharge", (object)model.PaidDevelopmentSurcharge ?? DBNull.Value)

                    , new SqlParameter("@DevelopmentSurchargeEconomicCodeId", (object)model.DevelopmentSurchargeEconomicCodeId ?? DBNull.Value)
                    , new SqlParameter("@DevelopmentSurchargePaymentDate", (object)model.DevelopmentSurchargePaymentDate ?? DBNull.Value)
                    , new SqlParameter("@DevelopmentSurchargeBankBranchId", (object)model.DevelopmentSurchargeBankBranchId ?? DBNull.Value)
                    , new SqlParameter("@PaidItDevelopmentSurcharge", (object)model.PaidItDevelopmentSurcharge ?? DBNull.Value)
                    , new SqlParameter("@ItDevelopmentSurchargeEconomicCodeId", (object)model.ItDevelopmentSurchargeEconomicCodeId ?? DBNull.Value)
                    , new SqlParameter("@ItDevelopmentSurchargePaymentDate", (object)model.ItDevelopmentSurchargePaymentDate ?? DBNull.Value)
                    , new SqlParameter("@ItDevelopmentSurchargeBankBranchId", (object)model.ItDevelopmentSurchargeBankBranchId ?? DBNull.Value)

                    , new SqlParameter("@PaidHealthDevelopmentSurcharge", (object)model.PaidHealthDevelopmentSurcharge ?? DBNull.Value)
                    , new SqlParameter("@HealthDevelopmentSurchargeEconomicCodeId", (object)model.HealthDevelopmentSurchargeEconomicCodeId ?? DBNull.Value)
                    , new SqlParameter("@HealthDevelopmentSurchargePaymentDate", (object)model.HealthDevelopmentSurchargePaymentDate ?? DBNull.Value)
                    , new SqlParameter("@HealthDevelopmentSurchargeBankBranchId", (object)model.HealthDevelopmentSurchargeBankBranchId ?? DBNull.Value)


                    , new SqlParameter("@PaidEnvironmentProtectSurcharge", (object)model.PaidEnvironmentProtectSurcharge ?? DBNull.Value)
                    , new SqlParameter("@EnvironmentProtectSurchargeEconomicCodeId", (object)model.EnvironmentProtectSurchargeEconomicCodeId ?? DBNull.Value)
                    , new SqlParameter("@EnvironmentProtectSurchargePaymentDate", (object)model.EnvironmentProtectSurchargePaymentDate ?? DBNull.Value)
                    , new SqlParameter("@EnvironmentProtectSurchargeBankBranchId", (object)model.EnvironmentProtectSurchargeBankBranchId ?? DBNull.Value)
                );
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return await Task.FromResult(true);
        }

        public async Task<bool> InsertReturnReturnedAmountInfo(SpAddMushakReturnReturnedAmountInfo vm)
        {
            try
            {
                this._context.Database.ExecuteSqlCommand(
                    $"EXEC [dbo].[SpAddMushakReturnReturnedAmountInfo]" +
                    $"@MushakGenerationId," +
                    $"@ReturnAmountFromClosingVat,"+
                    $"@ReturnFromClosingVatChequeBankId," +
                    $"@ReturnFromClosingVatChequeNo," +
                    $"@ReturnFromClosingVatChequeDate," +
                    $"@ReturnAmountFromClosingSd," +
                    $"@ReturnFromClosingSdChequeBankId," +
                    $"@ReturnFromClosingSdChequeNo,"+
                    $"@ReturnFromClosingSdChequeDate"
                    , new SqlParameter("@MushakGenerationId", (object)vm.MushakGenerationId ?? DBNull.Value)
                    , new SqlParameter("@ReturnAmountFromClosingVat", (object)vm.ReturnAmountFromClosingVat ?? DBNull.Value)
                    , new SqlParameter("@ReturnFromClosingVatChequeBankId", (object)vm.ReturnFromClosingVatChequeBankId ?? DBNull.Value)
                    , new SqlParameter("@ReturnFromClosingVatChequeNo", (object)vm.ReturnFromClosingVatChequeNo ?? DBNull.Value)
                    , new SqlParameter("@ReturnFromClosingVatChequeDate", (object)vm.ReturnFromClosingVatChequeDate ?? DBNull.Value)
                    , new SqlParameter("@ReturnAmountFromClosingSd", (object)vm.ReturnAmountFromClosingSd ?? DBNull.Value)
                    , new SqlParameter("@ReturnFromClosingSdChequeBankId", (object)vm.ReturnFromClosingSdChequeBankId ?? DBNull.Value)
                    , new SqlParameter("@ReturnFromClosingSdChequeNo", (object)vm.ReturnFromClosingSdChequeNo ?? DBNull.Value)
                    , new SqlParameter("@ReturnFromClosingSdChequeDate", (object)vm.ReturnFromClosingSdChequeDate ?? DBNull.Value)
                );
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return await Task.FromResult(true);
        }

        public async Task<bool> InsertSubmissionInfo(SpAddMushakReturnSubmissionInfo vm)
        {
            try
            {
                this._context.Database.ExecuteSqlCommand(
                    $"EXEC [dbo].[SpAddMushakReturnSubmissionInfo]" +
                    $"@MushakGenerationId," +
                    $"@SubmissionDate" 
                    , new SqlParameter("@MushakGenerationId", (object)vm.MushakGenerationId ?? DBNull.Value)
                    , new SqlParameter("@SubmissionDate", (object)vm.SubmissionDate ?? DBNull.Value)
                );
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return await Task.FromResult(true);
        }


        public async Task<bool> InsertAddMushakReturnCompleteProcess(int id)
        {
            try
            {
                this._context.Database.ExecuteSqlCommand(
                    $"EXEC [dbo].[SpAddMushakReturnCompleteProcess]" +
                    $"@MushakGenerationId"
                   
                    , new SqlParameter("@MushakGenerationId", (object)id ?? DBNull.Value)
                    
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

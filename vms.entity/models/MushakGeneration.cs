using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class MushakGeneration
    {
        public int MushakGenerationId { get; set; }
        public int OrganizationId { get; set; }
        public int MushakForYear { get; set; }
        public int MushakForMonth { get; set; }
        public DateTime GenerateDate { get; set; }
        public decimal? AmountForVat { get; set; }
        public decimal? AmountForSuppDuty { get; set; }
        public decimal? InterestForDueVat { get; set; }
        public decimal? InterestForDueSuppDuty { get; set; }
        public decimal? FinancialPenalty { get; set; }
        public decimal? ExciseDuty { get; set; }
        public decimal? DevelopmentSurcharge { get; set; }
        public decimal? ItDevelopmentSurcharge { get; set; }
        public decimal? HealthDevelopmentSurcharge { get; set; }
        public decimal? EnvironmentProtectSurcharge { get; set; }
        public decimal? LastClosingVatAmount { get; set; }
        public decimal? LastClosingSuppDutyAmount { get; set; }
        public decimal? PaidVatAmount { get; set; }
        public int? VatEconomicCodeId { get; set; }
        public DateTime? VatPaymentDate { get; set; }
        public string VatPaymentChallanNo { get; set; }
        public int? VatPaymentBankBranchId { get; set; }
        public decimal? PaidSuppDutyAmount { get; set; }
        public int? SuppDutyEconomicCodeId { get; set; }
        public DateTime? SuppDutyPaymentDate { get; set; }
        public string SuppDutyChallanNo { get; set; }
        public int? SuppDutyBankBranchId { get; set; }
        public decimal? PaidInterestAmountForDueVat { get; set; }
        public int? InterestForDueVatEconomicCodeId { get; set; }
        public DateTime? InterestForDueVatPaymentDate { get; set; }
        public string InterestForDueVatChallanNo { get; set; }
        public int? InterestForDueVatBankBranchId { get; set; }
        public decimal? PaidInterestAmountForDueSuppDuty { get; set; }
        public int? InterestForDueSuppDutyEconomicCodeId { get; set; }
        public DateTime? InterestForDueSuppDutyPaymentDate { get; set; }
        public string InterestForDueSuppDutyChallanNo { get; set; }
        public int? InterestForDueSuppDutyBankBranchId { get; set; }
        public decimal? PaidFinancialPenalty { get; set; }
        public int? FinancialPenaltyEconomicCodeId { get; set; }
        public DateTime? FinancialPenaltyPaymentDate { get; set; }
        public string FinancialPenaltyChallanNo { get; set; }
        public int? FinancialPenaltyBankBranchId { get; set; }
        public decimal? PaidExciseDuty { get; set; }
        public int? ExciseDutyEconomicCodeId { get; set; }
        public DateTime? ExciseDutyPaymentDate { get; set; }
        public string ExciseDutyChallanNo { get; set; }
        public int? ExciseDutyBankBranchId { get; set; }
        public decimal? PaidDevelopmentSurcharge { get; set; }
        public int? DevelopmentSurchargeEconomicCodeId { get; set; }
        public DateTime? DevelopmentSurchargePaymentDate { get; set; }
        public string DevelopmentSurchargeChallanNo { get; set; }
        public int? DevelopmentSurchargeBankBranchId { get; set; }
        public decimal? PaidItDevelopmentSurcharge { get; set; }
        public int? ItDevelopmentSurchargeEconomicCodeId { get; set; }
        public DateTime? ItDevelopmentSurchargePaymentDate { get; set; }
        public string ItDevelopmentSurchargeChallanNo { get; set; }
        public int? ItDevelopmentSurchargeBankBranchId { get; set; }
        public decimal? PaidHealthDevelopmentSurcharge { get; set; }
        public int? HealthDevelopmentSurchargeEconomicCodeId { get; set; }
        public DateTime? HealthDevelopmentSurchargePaymentDate { get; set; }
        public string HealthDevelopmentSurchargeChallanNo { get; set; }
        public int? HealthDevelopmentSurchargeBankBranchId { get; set; }
        public decimal? PaidEnvironmentProtectSurcharge { get; set; }
        public int? EnvironmentProtectSurchargeEconomicCodeId { get; set; }
        public DateTime? EnvironmentProtectSurchargePaymentDate { get; set; }
        public string EnvironmentProtectSurchargeChallanNo { get; set; }
        public int? EnvironmentProtectSurchargeBankBranchId { get; set; }
        public bool? IsSubmitted { get; set; }
        public DateTime? SubmissionDate { get; set; }
        public bool IsWantToGetBackClosingAmount { get; set; }
        public decimal? ReturnAmountFromClosingVat { get; set; }
        public int? ReturnFromClosingVatChequeBankId { get; set; }
        public string ReturnFromClosingVatChequeNo { get; set; }
        public DateTime? ReturnFromClosingVatChequeDate { get; set; }
        public decimal? ReturnAmountFromClosingSd { get; set; }
        public int? ReturnFromClosingSdChequeBankId { get; set; }
        public string ReturnFromClosingSdChequeNo { get; set; }
        public DateTime? ReturnFromClosingSdChequeDate { get; set; }
        public bool IsActive { get; set; }
        public byte MushakGenerationStageId { get; set; }

        public virtual BankBranch DevelopmentSurchargeBankBranch { get; set; }
        public virtual NbrEconomicCode DevelopmentSurchargeEconomicCode { get; set; }
        public virtual BankBranch EnvironmentProtectSurchargeBankBranch { get; set; }
        public virtual NbrEconomicCode EnvironmentProtectSurchargeEconomicCode { get; set; }
        public virtual BankBranch ExciseDutyBankBranch { get; set; }
        public virtual NbrEconomicCode ExciseDutyEconomicCode { get; set; }
        public virtual BankBranch FinancialPenaltyBankBranch { get; set; }
        public virtual NbrEconomicCode FinancialPenaltyEconomicCode { get; set; }
        public virtual BankBranch HealthDevelopmentSurchargeBankBranch { get; set; }
        public virtual NbrEconomicCode HealthDevelopmentSurchargeEconomicCode { get; set; }
        public virtual BankBranch InterestForDueSuppDutyBankBranch { get; set; }
        public virtual NbrEconomicCode InterestForDueSuppDutyEconomicCode { get; set; }
        public virtual BankBranch InterestForDueVatBankBranch { get; set; }
        public virtual NbrEconomicCode InterestForDueVatEconomicCode { get; set; }
        public virtual BankBranch ItDevelopmentSurchargeBankBranch { get; set; }
        public virtual NbrEconomicCode ItDevelopmentSurchargeEconomicCode { get; set; }
        public virtual MushakGenerationStage MushakGenerationStage { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual Bank ReturnFromClosingSdChequeBank { get; set; }
        public virtual Bank ReturnFromClosingVatChequeBank { get; set; }
        public virtual BankBranch SuppDutyBankBranch { get; set; }
        public virtual NbrEconomicCode SuppDutyEconomicCode { get; set; }
        public virtual NbrEconomicCode VatEconomicCode { get; set; }
        public virtual BankBranch VatPaymentBankBranch { get; set; }
    }
}
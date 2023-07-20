namespace Models
{
    public class Message
    {
        public int Id { get; set; }

        public string? BankIdentifier { get; set; }

        public string? TypeAndReference { get; set; }

        public string? Tag15_SendersReference { get; set; }

        public string? Tag20_TransactionReferenceNumber { get; set; }

        public string? Tag21_RelatedReference { get; set; }

        public string? Tag22_TypeOfOperation { get; set; }

        public string? Tag23_FurtherIndetification { get; set; }

        public string? Tag25_ProcessingFrequency { get; set; }

        public string? Tag26_NumberOfAvailableTenors { get; set; }

        public string? Tag27_SequenceOfTotal { get; set; }

        public string? Tag30_Date { get; set; }

        public string? Tag31_DateTimePeriod { get; set; }

        public string? Tag32_CurrencyAmount { get; set; }

        public string? Tag33_CurrencyOriginalOrderedAmount { get; set; }

        public string? Tag34_Percentage { get; set; }

        public string? Tag35_SequenceOfFormOfDocumentary { get; set; }

        public string? Tag36_DescriptionOfGoodsAndServices { get; set; }

        public string? Tag37_DocumentsRequired { get; set; }

        public string? Tag39_PercentageCreditAmountTolerance { get; set; }

        public string? Tag40_FormOfPresentation { get; set; }

        public string? Tag41_AvailableWith { get; set; }

        public string? Tag42_DraftsAt { get; set; }

        public string? Tag43_Shipments { get; set; }

        public string? Tag44_PlaceOfTakingInCharge { get; set; }

        public string? Tag45_DescriptionOfGoodsOrServices { get; set; }

        public string? Tag46_DocumentsRequired { get; set; }

        public string? Tag47_AdditionalConditions { get; set; }

        public string? Tag48_PeriodFroPresentation { get; set; }

        public string? Tag49_ConfirmationInstructions { get; set; }

        public string? Tag50_Applicant { get; set; }

        public string? Tag51_ApplicantBank { get; set; }

        public string? Tag52_IssuingBank { get; set; }

        public string? Tag53_ReimbursingBank { get; set; }

        public string? Tag54_AdvisingBank { get; set; }

        public string? Tag55_SecondAdvisingBank { get; set; }

        public string? Tag56_IntermediaryBank { get; set; }

        public string? Tag57_AccountWithInstitution { get; set; }

        public string? Tag58_Beneficiary { get; set; }

        public string? Tag59_BeneficiaryBank { get; set; }

        public string? Tag70_RemittanceInformation { get; set; }

        public string? Tag71_Reimbursement { get; set; }

        public string? Tag72_SenderToReceiverInformation { get; set; }

        public string? Tag73_ChargeDetails { get; set; }

        public string? Tag74_SendersCharges { get; set; }

        public string? Tag75_InstructionToPayingAcceptingNegotiatingBank { get; set; }

        public string? Tag79_Narrative { get; set; }

        public string? Tag80_InstructionsToTheBeneficiarysBank { get; set; }

        public string? Tag82_NIntermediaryBankCharges { get; set; }

        public string? Tag83_ReimbursingBankCharges { get; set; }

        public string? Tag84_AdviseThroughBankCharges { get; set; }

        public string? Tag85_SecondAdvisingBankCharges { get; set; }

        public string? MAC { get; set; }

        public string? CHK { get; set; }
    }
}

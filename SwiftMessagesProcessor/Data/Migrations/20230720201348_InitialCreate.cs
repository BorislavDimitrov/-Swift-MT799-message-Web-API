using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BankIdentifier = table.Column<string>(type: "TEXT", nullable: true),
                    TypeAndReference = table.Column<string>(type: "TEXT", nullable: true),
                    Tag15_SendersReference = table.Column<string>(type: "TEXT", nullable: true),
                    Tag20_TransactionReferenceNumber = table.Column<string>(type: "TEXT", nullable: true),
                    Tag21_RelatedReference = table.Column<string>(type: "TEXT", nullable: true),
                    Tag22_TypeOfOperation = table.Column<string>(type: "TEXT", nullable: true),
                    Tag23_FurtherIdentification = table.Column<string>(type: "TEXT", nullable: true),
                    Tag25_ProcessingFrequency = table.Column<string>(type: "TEXT", nullable: true),
                    Tag26_NumberOfAvailableTenors = table.Column<string>(type: "TEXT", nullable: true),
                    Tag27_SequenceOfTotal = table.Column<string>(type: "TEXT", nullable: true),
                    Tag30_Date = table.Column<string>(type: "TEXT", nullable: true),
                    Tag31_DateTimePeriod = table.Column<string>(type: "TEXT", nullable: true),
                    Tag32_CurrencyAmount = table.Column<string>(type: "TEXT", nullable: true),
                    Tag33_CurrencyOriginalOrderedAmount = table.Column<string>(type: "TEXT", nullable: true),
                    Tag34_Percentage = table.Column<string>(type: "TEXT", nullable: true),
                    Tag35_SequenceOfFormOfDocumentary = table.Column<string>(type: "TEXT", nullable: true),
                    Tag36_DescriptionOfGoodsAndServices = table.Column<string>(type: "TEXT", nullable: true),
                    Tag37_DocumentsRequired = table.Column<string>(type: "TEXT", nullable: true),
                    Tag39_PercentageCreditAmountTolerance = table.Column<string>(type: "TEXT", nullable: true),
                    Tag40_FormOfPresentation = table.Column<string>(type: "TEXT", nullable: true),
                    Tag41_AvailableWith = table.Column<string>(type: "TEXT", nullable: true),
                    Tag42_DraftsAt = table.Column<string>(type: "TEXT", nullable: true),
                    Tag43_Shipments = table.Column<string>(type: "TEXT", nullable: true),
                    Tag44_PlaceOfTakingInCharge = table.Column<string>(type: "TEXT", nullable: true),
                    Tag45_DescriptionOfGoodsOrServices = table.Column<string>(type: "TEXT", nullable: true),
                    Tag46_DocumentsRequired = table.Column<string>(type: "TEXT", nullable: true),
                    Tag47_AdditionalConditions = table.Column<string>(type: "TEXT", nullable: true),
                    Tag48_PeriodFroPresentation = table.Column<string>(type: "TEXT", nullable: true),
                    Tag49_ConfirmationInstructions = table.Column<string>(type: "TEXT", nullable: true),
                    Tag50_Applicant = table.Column<string>(type: "TEXT", nullable: true),
                    Tag51_ApplicantBank = table.Column<string>(type: "TEXT", nullable: true),
                    Tag52_IssuingBank = table.Column<string>(type: "TEXT", nullable: true),
                    Tag53_ReimbursingBank = table.Column<string>(type: "TEXT", nullable: true),
                    Tag54_AdvisingBank = table.Column<string>(type: "TEXT", nullable: true),
                    Tag55_SecondAdvisingBank = table.Column<string>(type: "TEXT", nullable: true),
                    Tag56_IntermediaryBank = table.Column<string>(type: "TEXT", nullable: true),
                    Tag57_AccountWithInstitution = table.Column<string>(type: "TEXT", nullable: true),
                    Tag58_Beneficiary = table.Column<string>(type: "TEXT", nullable: true),
                    Tag59_BeneficiaryBank = table.Column<string>(type: "TEXT", nullable: true),
                    Tag70_RemittanceInformation = table.Column<string>(type: "TEXT", nullable: true),
                    Tag71_Reimbursement = table.Column<string>(type: "TEXT", nullable: true),
                    Tag72_SenderToReceiverInformation = table.Column<string>(type: "TEXT", nullable: true),
                    Tag73_ChargeDetails = table.Column<string>(type: "TEXT", nullable: true),
                    Tag74_SendersCharges = table.Column<string>(type: "TEXT", nullable: true),
                    Tag75_InstructionToPayingAcceptingNegotiatingBank = table.Column<string>(type: "TEXT", nullable: true),
                    Tag79_Narrative = table.Column<string>(type: "TEXT", nullable: true),
                    Tag80_InstructionsToTheBeneficiarysBank = table.Column<string>(type: "TEXT", nullable: true),
                    Tag82_NIntermediaryBankCharges = table.Column<string>(type: "TEXT", nullable: true),
                    Tag83_ReimbursingBankCharges = table.Column<string>(type: "TEXT", nullable: true),
                    Tag84_AdviseThroughBankCharges = table.Column<string>(type: "TEXT", nullable: true),
                    Tag85_SecondAdvisingBankCharges = table.Column<string>(type: "TEXT", nullable: true),
                    MAC = table.Column<string>(type: "TEXT", nullable: true),
                    CHK = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");
        }
    }
}

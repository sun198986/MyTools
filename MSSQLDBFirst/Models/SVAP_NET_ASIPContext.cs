using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MSSQLDBFirst.Models
{
    public partial class SVAP_NET_ASIPContext : DbContext
    {
        public SVAP_NET_ASIPContext()
        {
        }

        public SVAP_NET_ASIPContext(DbContextOptions<SVAP_NET_ASIPContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BiFactReceipt> BiFactReceipt { get; set; }
        public virtual DbSet<BiFactSr> BiFactSr { get; set; }
        public virtual DbSet<BiFactWarrantyBeforeSale> BiFactWarrantyBeforeSale { get; set; }
        public virtual DbSet<BiFactWarrantyExtended> BiFactWarrantyExtended { get; set; }
        public virtual DbSet<BiFactWarrantyIn> BiFactWarrantyIn { get; set; }
        public virtual DbSet<BiFactWarrantyNotIn> BiFactWarrantyNotIn { get; set; }
        public virtual DbSet<CpuMonitor> CpuMonitor { get; set; }
        public virtual DbSet<IbgAccessory> IbgAccessory { get; set; }
        public virtual DbSet<IbgActualParts> IbgActualParts { get; set; }
        public virtual DbSet<IbgActualPartsBak20191031> IbgActualPartsBak20191031 { get; set; }
        public virtual DbSet<IbgActualPartsTmp20191031> IbgActualPartsTmp20191031 { get; set; }
        public virtual DbSet<IbgApprice> IbgApprice { get; set; }
        public virtual DbSet<IbgArchivedProduct> IbgArchivedProduct { get; set; }
        public virtual DbSet<IbgBgptask> IbgBgptask { get; set; }
        public virtual DbSet<IbgBranch> IbgBranch { get; set; }
        public virtual DbSet<IbgBranchRole> IbgBranchRole { get; set; }
        public virtual DbSet<IbgBranchRoleTask> IbgBranchRoleTask { get; set; }
        public virtual DbSet<IbgBranchTypeRole> IbgBranchTypeRole { get; set; }
        public virtual DbSet<IbgCalendar> IbgCalendar { get; set; }
        public virtual DbSet<IbgCategory> IbgCategory { get; set; }
        public virtual DbSet<IbgCategoryNew> IbgCategoryNew { get; set; }
        public virtual DbSet<IbgCommonPriceRate> IbgCommonPriceRate { get; set; }
        public virtual DbSet<IbgCompany> IbgCompany { get; set; }
        public virtual DbSet<IbgCompanyTaxPolicy> IbgCompanyTaxPolicy { get; set; }
        public virtual DbSet<IbgCompanyTaxPolicyParameter> IbgCompanyTaxPolicyParameter { get; set; }
        public virtual DbSet<IbgConsignHis> IbgConsignHis { get; set; }
        public virtual DbSet<IbgConsignIv> IbgConsignIv { get; set; }
        public virtual DbSet<IbgConsignRelation> IbgConsignRelation { get; set; }
        public virtual DbSet<IbgContactMethod> IbgContactMethod { get; set; }
        public virtual DbSet<IbgCost> IbgCost { get; set; }
        public virtual DbSet<IbgCostBak201904> IbgCostBak201904 { get; set; }
        public virtual DbSet<IbgCurrency> IbgCurrency { get; set; }
        public virtual DbSet<IbgCustomer> IbgCustomer { get; set; }
        public virtual DbSet<IbgCustomerContactMethod> IbgCustomerContactMethod { get; set; }
        public virtual DbSet<IbgCustomerHoldProduct> IbgCustomerHoldProduct { get; set; }
        public virtual DbSet<IbgDisableOrder> IbgDisableOrder { get; set; }
        public virtual DbSet<IbgDiscountRate> IbgDiscountRate { get; set; }
        public virtual DbSet<IbgErrorList> IbgErrorList { get; set; }
        public virtual DbSet<IbgEstimationParts> IbgEstimationParts { get; set; }
        public virtual DbSet<IbgExchangeRate> IbgExchangeRate { get; set; }
        public virtual DbSet<IbgInStockComment> IbgInStockComment { get; set; }
        public virtual DbSet<IbgIndividualLaborChargeDetails> IbgIndividualLaborChargeDetails { get; set; }
        public virtual DbSet<IbgInvoice> IbgInvoice { get; set; }
        public virtual DbSet<IbgInvoiceAccount> IbgInvoiceAccount { get; set; }
        public virtual DbSet<IbgInvoiceDetail> IbgInvoiceDetail { get; set; }
        public virtual DbSet<IbgInvoiceSubAccount> IbgInvoiceSubAccount { get; set; }
        public virtual DbSet<IbgKpi> IbgKpi { get; set; }
        public virtual DbSet<IbgLaborCharge> IbgLaborCharge { get; set; }
        public virtual DbSet<IbgLaborChargeDetails> IbgLaborChargeDetails { get; set; }
        public virtual DbSet<IbgLaborChargeRank> IbgLaborChargeRank { get; set; }
        public virtual DbSet<IbgLmndlvrInfo> IbgLmndlvrInfo { get; set; }
        public virtual DbSet<IbgLmnproduct> IbgLmnproduct { get; set; }
        public virtual DbSet<IbgMapping> IbgMapping { get; set; }
        public virtual DbSet<IbgMessage> IbgMessage { get; set; }
        public virtual DbSet<IbgMovePattern> IbgMovePattern { get; set; }
        public virtual DbSet<IbgNeed> IbgNeed { get; set; }
        public virtual DbSet<IbgNeed20190321> IbgNeed20190321 { get; set; }
        public virtual DbSet<IbgNeedHis> IbgNeedHis { get; set; }
        public virtual DbSet<IbgNeedHis20190321> IbgNeedHis20190321 { get; set; }
        public virtual DbSet<IbgNotFinishedWoh> IbgNotFinishedWoh { get; set; }
        public virtual DbSet<IbgNt> IbgNt { get; set; }
        public virtual DbSet<IbgNt20190321> IbgNt20190321 { get; set; }
        public virtual DbSet<IbgNthis> IbgNthis { get; set; }
        public virtual DbSet<IbgNthis20190321> IbgNthis20190321 { get; set; }
        public virtual DbSet<IbgNthisBackup20201112> IbgNthisBackup20201112 { get; set; }
        public virtual DbSet<IbgNtmgtD> IbgNtmgtD { get; set; }
        public virtual DbSet<IbgNtmgtD20190321> IbgNtmgtD20190321 { get; set; }
        public virtual DbSet<IbgNtmgtD20190806> IbgNtmgtD20190806 { get; set; }
        public virtual DbSet<IbgNtmgtDBackup20201112> IbgNtmgtDBackup20201112 { get; set; }
        public virtual DbSet<IbgNtmgtH> IbgNtmgtH { get; set; }
        public virtual DbSet<IbgNtmgtH20190321> IbgNtmgtH20190321 { get; set; }
        public virtual DbSet<IbgNtrelation> IbgNtrelation { get; set; }
        public virtual DbSet<IbgNttempD> IbgNttempD { get; set; }
        public virtual DbSet<IbgNttempD20190321> IbgNttempD20190321 { get; set; }
        public virtual DbSet<IbgNttempH> IbgNttempH { get; set; }
        public virtual DbSet<IbgNttempH20190321> IbgNttempH20190321 { get; set; }
        public virtual DbSet<IbgPara> IbgPara { get; set; }
        public virtual DbSet<IbgParaPart> IbgParaPart { get; set; }
        public virtual DbSet<IbgParaType> IbgParaType { get; set; }
        public virtual DbSet<IbgPart> IbgPart { get; set; }
        public virtual DbSet<IbgPartCodeConvert> IbgPartCodeConvert { get; set; }
        public virtual DbSet<IbgParticularPriceRule> IbgParticularPriceRule { get; set; }
        public virtual DbSet<IbgPaymentHis> IbgPaymentHis { get; set; }
        public virtual DbSet<IbgPgm> IbgPgm { get; set; }
        public virtual DbSet<IbgPrice> IbgPrice { get; set; }
        public virtual DbSet<IbgPriceBak20180925> IbgPriceBak20180925 { get; set; }
        public virtual DbSet<IbgPriceBak20190830> IbgPriceBak20190830 { get; set; }
        public virtual DbSet<IbgPriceCalcPara> IbgPriceCalcPara { get; set; }
        public virtual DbSet<IbgPriceCalcParaPerPrice> IbgPriceCalcParaPerPrice { get; set; }
        public virtual DbSet<IbgPriceChange> IbgPriceChange { get; set; }
        public virtual DbSet<IbgPriceTmpbak20200331> IbgPriceTmpbak20200331 { get; set; }
        public virtual DbSet<IbgPriceType> IbgPriceType { get; set; }
        public virtual DbSet<IbgProcedureResult> IbgProcedureResult { get; set; }
        public virtual DbSet<IbgProdMovHis> IbgProdMovHis { get; set; }
        public virtual DbSet<IbgProdWod> IbgProdWod { get; set; }
        public virtual DbSet<IbgProdWoh> IbgProdWoh { get; set; }
        public virtual DbSet<IbgProduct> IbgProduct { get; set; }
        public virtual DbSet<IbgProductNew> IbgProductNew { get; set; }
        public virtual DbSet<IbgProductRp> IbgProductRp { get; set; }
        public virtual DbSet<IbgProductSalesEx> IbgProductSalesEx { get; set; }
        public virtual DbSet<IbgReason> IbgReason { get; set; }
        public virtual DbSet<IbgReceipt> IbgReceipt { get; set; }
        public virtual DbSet<IbgReceiptExcGespic> IbgReceiptExcGespic { get; set; }
        public virtual DbSet<IbgReceiptExcIn> IbgReceiptExcIn { get; set; }
        public virtual DbSet<IbgReceiptExcOut> IbgReceiptExcOut { get; set; }
        public virtual DbSet<IbgReceiptExchange> IbgReceiptExchange { get; set; }
        public virtual DbSet<IbgRefundLaborCharge> IbgRefundLaborCharge { get; set; }
        public virtual DbSet<IbgRegion> IbgRegion { get; set; }
        public virtual DbSet<IbgRole> IbgRole { get; set; }
        public virtual DbSet<IbgRoleTask> IbgRoleTask { get; set; }
        public virtual DbSet<IbgRoleTaskBak20190317> IbgRoleTaskBak20190317 { get; set; }
        public virtual DbSet<IbgServiceStateChk> IbgServiceStateChk { get; set; }
        public virtual DbSet<IbgShelf> IbgShelf { get; set; }
        public virtual DbSet<IbgShprice> IbgShprice { get; set; }
        public virtual DbSet<IbgSmstask> IbgSmstask { get; set; }
        public virtual DbSet<IbgSmstaskHis> IbgSmstaskHis { get; set; }
        public virtual DbSet<IbgSncollection> IbgSncollection { get; set; }
        public virtual DbSet<IbgStaff> IbgStaff { get; set; }
        public virtual DbSet<IbgStaffRole> IbgStaffRole { get; set; }
        public virtual DbSet<IbgStaffTask> IbgStaffTask { get; set; }
        public virtual DbSet<IbgStatusHis> IbgStatusHis { get; set; }
        public virtual DbSet<IbgStock> IbgStock { get; set; }
        public virtual DbSet<IbgStock20190321> IbgStock20190321 { get; set; }
        public virtual DbSet<IbgStockAccount> IbgStockAccount { get; set; }
        public virtual DbSet<IbgStockAccountType> IbgStockAccountType { get; set; }
        public virtual DbSet<IbgStockHis> IbgStockHis { get; set; }
        public virtual DbSet<IbgStockHis20190321> IbgStockHis20190321 { get; set; }
        public virtual DbSet<IbgStockHisBak20161026> IbgStockHisBak20161026 { get; set; }
        public virtual DbSet<IbgStockHisBak20161208Archive> IbgStockHisBak20161208Archive { get; set; }
        public virtual DbSet<IbgStockHisSum> IbgStockHisSum { get; set; }
        public virtual DbSet<IbgStockHisSum4D> IbgStockHisSum4D { get; set; }
        public virtual DbSet<IbgStockHisSum4DBak20170505> IbgStockHisSum4DBak20170505 { get; set; }
        public virtual DbSet<IbgStockHisSum4DBak20170929> IbgStockHisSum4DBak20170929 { get; set; }
        public virtual DbSet<IbgStockHisSumBak20161101> IbgStockHisSumBak20161101 { get; set; }
        public virtual DbSet<IbgStockHisSumBak20170505> IbgStockHisSumBak20170505 { get; set; }
        public virtual DbSet<IbgStockHisSumBak20170929> IbgStockHisSumBak20170929 { get; set; }
        public virtual DbSet<IbgStockHisTmp20191031> IbgStockHisTmp20191031 { get; set; }
        public virtual DbSet<IbgStockTakingList> IbgStockTakingList { get; set; }
        public virtual DbSet<IbgStockTmp20191031> IbgStockTmp20191031 { get; set; }
        public virtual DbSet<IbgStolenProd> IbgStolenProd { get; set; }
        public virtual DbSet<IbgSupply> IbgSupply { get; set; }
        public virtual DbSet<IbgSupply20190321> IbgSupply20190321 { get; set; }
        public virtual DbSet<IbgSupplyHis> IbgSupplyHis { get; set; }
        public virtual DbSet<IbgSupplyHis20190321> IbgSupplyHis20190321 { get; set; }
        public virtual DbSet<IbgTask> IbgTask { get; set; }
        public virtual DbSet<IbgTaxPolicyParameter> IbgTaxPolicyParameter { get; set; }
        public virtual DbSet<IbgTestResult> IbgTestResult { get; set; }
        public virtual DbSet<IbgTmpRptServiceStatusAll> IbgTmpRptServiceStatusAll { get; set; }
        public virtual DbSet<IbgTmpRptServiceStatusAll201506> IbgTmpRptServiceStatusAll201506 { get; set; }
        public virtual DbSet<IbgTrade> IbgTrade { get; set; }
        public virtual DbSet<IbgTroublePhenomenon> IbgTroublePhenomenon { get; set; }
        public virtual DbSet<IbgTroublePhenomenonBak> IbgTroublePhenomenonBak { get; set; }
        public virtual DbSet<IbgTroublePhenomenonBak201711130006> IbgTroublePhenomenonBak201711130006 { get; set; }
        public virtual DbSet<IbgTroublePhenomenonEx> IbgTroublePhenomenonEx { get; set; }
        public virtual DbSet<IbgTroubleReason> IbgTroubleReason { get; set; }
        public virtual DbSet<IbgTroubleReasonBak> IbgTroubleReasonBak { get; set; }
        public virtual DbSet<IbgTroubleRelation> IbgTroubleRelation { get; set; }
        public virtual DbSet<IbgTroubleRelationBak201711130006> IbgTroubleRelationBak201711130006 { get; set; }
        public virtual DbSet<IbgTroubleSolution> IbgTroubleSolution { get; set; }
        public virtual DbSet<IbgTroubleSpot> IbgTroubleSpot { get; set; }
        public virtual DbSet<IbgTroubleSpotBak> IbgTroubleSpotBak { get; set; }
        public virtual DbSet<IbgTroubleSpotBak201711130006> IbgTroubleSpotBak201711130006 { get; set; }
        public virtual DbSet<IbgTroubleType> IbgTroubleType { get; set; }
        public virtual DbSet<IbgWoactionD> IbgWoactionD { get; set; }
        public virtual DbSet<IbgWoactionD20190321> IbgWoactionD20190321 { get; set; }
        public virtual DbSet<IbgWoactionH> IbgWoactionH { get; set; }
        public virtual DbSet<IbgWoactionH20190321> IbgWoactionH20190321 { get; set; }
        public virtual DbSet<IbgWod> IbgWod { get; set; }
        public virtual DbSet<IbgWod20190321> IbgWod20190321 { get; set; }
        public virtual DbSet<IbgWodate> IbgWodate { get; set; }
        public virtual DbSet<IbgWoh> IbgWoh { get; set; }
        public virtual DbSet<IbgWoh20190321> IbgWoh20190321 { get; set; }
        public virtual DbSet<IbgWorelation> IbgWorelation { get; set; }
        public virtual DbSet<IbgWorelationAction> IbgWorelationAction { get; set; }
        public virtual DbSet<IbgWork4Bolist> IbgWork4Bolist { get; set; }
        public virtual DbSet<IbgWork4ExcIn> IbgWork4ExcIn { get; set; }
        public virtual DbSet<IbgWork4ExcOut> IbgWork4ExcOut { get; set; }
        public virtual DbSet<IbgWork4ExcOutInFailureResponse> IbgWork4ExcOutInFailureResponse { get; set; }
        public virtual DbSet<IbgWork4ExcOutInFailureResponseHis> IbgWork4ExcOutInFailureResponseHis { get; set; }
        public virtual DbSet<IbgWork4ExcOutInHis> IbgWork4ExcOutInHis { get; set; }
        public virtual DbSet<IbgWork4ExcOutInSuccessResponse> IbgWork4ExcOutInSuccessResponse { get; set; }
        public virtual DbSet<IbgWork4ExcOutInSuccessResponseHis> IbgWork4ExcOutInSuccessResponseHis { get; set; }
        public virtual DbSet<IbgWork4H85> IbgWork4H85 { get; set; }
        public virtual DbSet<IbgWork4H85his> IbgWork4H85his { get; set; }
        public virtual DbSet<IbgWork4H91> IbgWork4H91 { get; set; }
        public virtual DbSet<IbgWork4H91his> IbgWork4H91his { get; set; }
        public virtual DbSet<IbgWork4H91his20190321> IbgWork4H91his20190321 { get; set; }
        public virtual DbSet<IbgWork4H92> IbgWork4H92 { get; set; }
        public virtual DbSet<IbgWork4H92his> IbgWork4H92his { get; set; }
        public virtual DbSet<IbgWork4H93> IbgWork4H93 { get; set; }
        public virtual DbSet<IbgWork4H93his> IbgWork4H93his { get; set; }
        public virtual DbSet<IbgWork4H94> IbgWork4H94 { get; set; }
        public virtual DbSet<IbgWork4H94his> IbgWork4H94his { get; set; }
        public virtual DbSet<IbgWork4H95> IbgWork4H95 { get; set; }
        public virtual DbSet<IbgWork4H95his> IbgWork4H95his { get; set; }
        public virtual DbSet<IbgWork4H96> IbgWork4H96 { get; set; }
        public virtual DbSet<IbgWork4H96Bld> IbgWork4H96Bld { get; set; }
        public virtual DbSet<IbgWork4H96his> IbgWork4H96his { get; set; }
        public virtual DbSet<IbgWork4H96his20190321> IbgWork4H96his20190321 { get; set; }
        public virtual DbSet<IbgWork4H97> IbgWork4H97 { get; set; }
        public virtual DbSet<IbgWork4H97his> IbgWork4H97his { get; set; }
        public virtual DbSet<IbgWork4H97tmp> IbgWork4H97tmp { get; set; }
        public virtual DbSet<IbgWork4NapcIn> IbgWork4NapcIn { get; set; }
        public virtual DbSet<IbgWork4NapcInhis> IbgWork4NapcInhis { get; set; }
        public virtual DbSet<IbgWork4NapcOut> IbgWork4NapcOut { get; set; }
        public virtual DbSet<IbgWork4NapcOuthis> IbgWork4NapcOuthis { get; set; }
        public virtual DbSet<IbgWork4NapcStock> IbgWork4NapcStock { get; set; }
        public virtual DbSet<IbgWork4NapcStockhis> IbgWork4NapcStockhis { get; set; }
        public virtual DbSet<IbgWork4Npcsreceive> IbgWork4Npcsreceive { get; set; }
        public virtual DbSet<IbgWork4NpcsreceiveHis> IbgWork4NpcsreceiveHis { get; set; }
        public virtual DbSet<IbgWork4Npcsso> IbgWork4Npcsso { get; set; }
        public virtual DbSet<IbgWork4Npcssohis> IbgWork4Npcssohis { get; set; }
        public virtual DbSet<IbgWork4Nwni67> IbgWork4Nwni67 { get; set; }
        public virtual DbSet<IbgWork4Nwni67his> IbgWork4Nwni67his { get; set; }
        public virtual DbSet<IbgWork4Nwni68> IbgWork4Nwni68 { get; set; }
        public virtual DbSet<IbgWork4Nwni68his> IbgWork4Nwni68his { get; set; }
        public virtual DbSet<IbgWork4Nwni69> IbgWork4Nwni69 { get; set; }
        public virtual DbSet<IbgWork4Nwni69his> IbgWork4Nwni69his { get; set; }
        public virtual DbSet<IbgWork4Nwni70> IbgWork4Nwni70 { get; set; }
        public virtual DbSet<IbgWork4Nwni70his> IbgWork4Nwni70his { get; set; }
        public virtual DbSet<IbgWork4Nwni83> IbgWork4Nwni83 { get; set; }
        public virtual DbSet<IbgWork4Nwni84> IbgWork4Nwni84 { get; set; }
        public virtual DbSet<IbgWork4R01> IbgWork4R01 { get; set; }
        public virtual DbSet<IbgWork4R0120190321> IbgWork4R0120190321 { get; set; }
        public virtual DbSet<IbgWork4R01Dm> IbgWork4R01Dm { get; set; }
        public virtual DbSet<IbgWork4R01his> IbgWork4R01his { get; set; }
        public virtual DbSet<IbgWork4R01his20190321> IbgWork4R01his20190321 { get; set; }
        public virtual DbSet<IbgWork4TaskOrient> IbgWork4TaskOrient { get; set; }
        public virtual DbSet<IbgWorkIflog> IbgWorkIflog { get; set; }
        public virtual DbSet<IbgWotempD> IbgWotempD { get; set; }
        public virtual DbSet<IbgWotempH> IbgWotempH { get; set; }
        public virtual DbSet<KpiSummary> KpiSummary { get; set; }
        public virtual DbSet<MemMonitor> MemMonitor { get; set; }
        public virtual DbSet<PnameDic> PnameDic { get; set; }
        public virtual DbSet<Temp4expenseoutstk> Temp4expenseoutstk { get; set; }
        public virtual DbSet<TempCost> TempCost { get; set; }
        public virtual DbSet<WebAccount> WebAccount { get; set; }
        public virtual DbSet<WebCategory> WebCategory { get; set; }
        public virtual DbSet<WebDataControl> WebDataControl { get; set; }
        public virtual DbSet<WebProduct> WebProduct { get; set; }
        public virtual DbSet<WebReceipt> WebReceipt { get; set; }
        public virtual DbSet<WebReceiptA> WebReceiptA { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;User Id=sa;Password=11;Database=SVAP_NET_ASIP;Persist Security Info=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BiFactReceipt>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BI_FactReceipt");

                entity.Property(e => e.CateCode).HasMaxLength(64);

                entity.Property(e => e.CloseDate).HasMaxLength(10);

                entity.Property(e => e.PartList)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.PartNameList)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.ProdCode)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.ProdName).HasMaxLength(4000);

                entity.Property(e => e.RcptNo).HasMaxLength(65);

                entity.Property(e => e.RepairDate).HasMaxLength(10);

                entity.Property(e => e.ServiceBranCode).HasMaxLength(64);

                entity.Property(e => e.ServiceBranName).HasMaxLength(4000);

                entity.Property(e => e.ServiceType).HasMaxLength(2);
            });

            modelBuilder.Entity<BiFactSr>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BI_FactSR");

                entity.Property(e => e.CloseDate).HasMaxLength(10);

                entity.Property(e => e.PartAmountSr)
                    .HasColumnName("PartAmountSR")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.RcptNo).HasMaxLength(65);

                entity.Property(e => e.Srqty).HasColumnName("SRQty");
            });

            modelBuilder.Entity<BiFactWarrantyBeforeSale>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BI_FactWarrantyBeforeSale");

                entity.Property(e => e.CloseDate).HasMaxLength(10);

                entity.Property(e => e.PartAmountBeforeSale).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.RcptNo).HasMaxLength(65);
            });

            modelBuilder.Entity<BiFactWarrantyExtended>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BI_FactWarrantyExtended");

                entity.Property(e => e.CloseDate).HasMaxLength(10);

                entity.Property(e => e.PartAmountExtended).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.RcptNo).HasMaxLength(65);
            });

            modelBuilder.Entity<BiFactWarrantyIn>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BI_FactWarrantyIn");

                entity.Property(e => e.CloseDate).HasMaxLength(10);

                entity.Property(e => e.PartAmountIn)
                    .HasColumnName("PartAmountIN")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.RcptNo).HasMaxLength(65);

                entity.Property(e => e.WarrantyPeriod4In).HasColumnName("WarrantyPeriod4IN");
            });

            modelBuilder.Entity<BiFactWarrantyNotIn>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BI_FactWarrantyNotIn");

                entity.Property(e => e.CloseDate).HasMaxLength(10);

                entity.Property(e => e.PartAmountNotIn).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.RcptNo).HasMaxLength(65);
            });

            modelBuilder.Entity<CpuMonitor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CPU_Monitor");

                entity.Property(e => e.Cmd)
                    .HasColumnName("cmd")
                    .HasMaxLength(64);

                entity.Property(e => e.Cpu)
                    .HasColumnName("cpu")
                    .HasMaxLength(64);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Memusage)
                    .HasColumnName("memusage")
                    .HasMaxLength(64);

                entity.Property(e => e.PhysicalIo)
                    .HasColumnName("physical_io")
                    .HasMaxLength(64);

                entity.Property(e => e.Spid)
                    .HasColumnName("spid")
                    .HasMaxLength(64);

                entity.Property(e => e.SqlText).HasColumnName("sql_text");
            });

            modelBuilder.Entity<IbgAccessory>(entity =>
            {
                entity.HasKey(e => e.AccessoryGuid);

                entity.ToTable("ibg_Accessory");

                entity.Property(e => e.AccessoryGuid)
                    .HasColumnName("AccessoryGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.AccessoryCode)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.FullName).HasMaxLength(4000);

                entity.Property(e => e.FullNameChn)
                    .HasColumnName("FullNameCHN")
                    .HasMaxLength(4000);

                entity.Property(e => e.FullNameJpn)
                    .HasColumnName("FullNameJPN")
                    .HasMaxLength(4000);

                entity.Property(e => e.OrgCode).HasMaxLength(64);

                entity.Property(e => e.OrgLevel).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.SortKey).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgActualParts>(entity =>
            {
                entity.HasKey(e => new { e.RcptGuid, e.PartCode });

                entity.ToTable("ibg_ActualParts");

                entity.HasIndex(e => e.PartCode);

                entity.Property(e => e.RcptGuid)
                    .HasColumnName("RcptGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.DisplayOutPut).HasMaxLength(64);

                entity.Property(e => e.NdQty4Rp).HasColumnName("NdQty4RP");

                entity.Property(e => e.Ntqty4Rp2wh).HasColumnName("NTQty4RP2WH");

                entity.Property(e => e.Reason4Free).HasMaxLength(64);

                entity.Property(e => e.Reason4OutOfMgt).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.StkQty4Fn).HasColumnName("StkQty4FN");

                entity.Property(e => e.StkQty4Rp).HasColumnName("StkQty4RP");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);

                entity.Property(e => e.Wo4rp2damage).HasColumnName("WO4RP2Damage");

                entity.Property(e => e.Wo4rp2lost).HasColumnName("WO4RP2Lost");

                entity.Property(e => e.Wo4rp2wh).HasColumnName("WO4RP2WH");

                entity.Property(e => e.Wo4wh2rp).HasColumnName("WO4WH2RP");
            });

            modelBuilder.Entity<IbgActualPartsBak20191031>(entity =>
            {
                entity.HasKey(e => new { e.RcptGuid, e.PartCode });

                entity.ToTable("ibg_ActualParts_bak20191031");

                entity.Property(e => e.RcptGuid)
                    .HasColumnName("RcptGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.DisplayOutPut).HasMaxLength(64);

                entity.Property(e => e.NdQty4Rp).HasColumnName("NdQty4RP");

                entity.Property(e => e.Ntqty4Rp2wh).HasColumnName("NTQty4RP2WH");

                entity.Property(e => e.Reason4Free).HasMaxLength(64);

                entity.Property(e => e.Reason4OutOfMgt).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.StkQty4Fn).HasColumnName("StkQty4FN");

                entity.Property(e => e.StkQty4Rp).HasColumnName("StkQty4RP");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);

                entity.Property(e => e.Wo4rp2damage).HasColumnName("WO4RP2Damage");

                entity.Property(e => e.Wo4rp2lost).HasColumnName("WO4RP2Lost");

                entity.Property(e => e.Wo4rp2wh).HasColumnName("WO4RP2WH");

                entity.Property(e => e.Wo4wh2rp).HasColumnName("WO4WH2RP");
            });

            modelBuilder.Entity<IbgActualPartsTmp20191031>(entity =>
            {
                entity.HasKey(e => new { e.RcptGuid, e.PartCode });

                entity.ToTable("ibg_ActualParts_tmp20191031");

                entity.Property(e => e.RcptGuid)
                    .HasColumnName("RcptGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.DisplayOutPut).HasMaxLength(64);

                entity.Property(e => e.NdQty4Rp).HasColumnName("NdQty4RP");

                entity.Property(e => e.Ntqty4Rp2wh).HasColumnName("NTQty4RP2WH");

                entity.Property(e => e.Reason4Free).HasMaxLength(64);

                entity.Property(e => e.Reason4OutOfMgt).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.StkQty4Fn).HasColumnName("StkQty4FN");

                entity.Property(e => e.StkQty4Rp).HasColumnName("StkQty4RP");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);

                entity.Property(e => e.Wo4rp2damage).HasColumnName("WO4RP2Damage");

                entity.Property(e => e.Wo4rp2lost).HasColumnName("WO4RP2Lost");

                entity.Property(e => e.Wo4rp2wh).HasColumnName("WO4RP2WH");

                entity.Property(e => e.Wo4wh2rp).HasColumnName("WO4WH2RP");
            });

            modelBuilder.Entity<IbgApprice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ibg_APPrice");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.DisplayOutPut).HasMaxLength(64);

                entity.Property(e => e.NdQty4Rp).HasColumnName("NdQty4RP");

                entity.Property(e => e.Ntqty4Rp2wh).HasColumnName("NTQty4RP2WH");

                entity.Property(e => e.PartCode)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.Price).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.RcptGuid)
                    .IsRequired()
                    .HasColumnName("RcptGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.ShortName).HasMaxLength(4000);

                entity.Property(e => e.StkQty4Fn).HasColumnName("StkQty4FN");

                entity.Property(e => e.StkQty4Rp).HasColumnName("StkQty4RP");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);

                entity.Property(e => e.Wo4rp2damage).HasColumnName("WO4RP2Damage");

                entity.Property(e => e.Wo4rp2lost).HasColumnName("WO4RP2Lost");

                entity.Property(e => e.Wo4rp2wh).HasColumnName("WO4RP2WH");

                entity.Property(e => e.Wo4wh2rp).HasColumnName("WO4WH2RP");
            });

            modelBuilder.Entity<IbgArchivedProduct>(entity =>
            {
                entity.HasKey(e => new { e.RcptNo, e.ProdCode, e.ProdSn });

                entity.ToTable("ibg_ArchivedProduct");

                entity.Property(e => e.RcptNo).HasMaxLength(64);

                entity.Property(e => e.ProdCode).HasMaxLength(64);

                entity.Property(e => e.ProdSn)
                    .HasColumnName("ProdSN")
                    .HasMaxLength(64);

                entity.Property(e => e.StockRepairRank).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgBgptask>(entity =>
            {
                entity.HasKey(e => e.BgptaskGuid);

                entity.ToTable("ibg_BGPTask");

                entity.Property(e => e.BgptaskGuid)
                    .HasColumnName("BGPTaskGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.BgptaskName)
                    .HasColumnName("BGPTaskName")
                    .HasMaxLength(64);

                entity.Property(e => e.BgptaskSta)
                    .HasColumnName("BGPTaskSta")
                    .HasMaxLength(64);

                entity.Property(e => e.Command).HasMaxLength(4000);

                entity.Property(e => e.Comment).HasMaxLength(64);

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.Para).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgBranch>(entity =>
            {
                entity.HasKey(e => e.BranCode);

                entity.ToTable("ibg_Branch");

                entity.Property(e => e.BranCode).HasMaxLength(64);

                entity.Property(e => e.Address).HasMaxLength(4000);

                entity.Property(e => e.AvailableFlag).HasMaxLength(64);

                entity.Property(e => e.BranCodeNpcs)
                    .HasColumnName("BranCodeNPCS")
                    .HasMaxLength(64);

                entity.Property(e => e.BranCodeSvap)
                    .HasColumnName("BranCodeSVAP")
                    .HasMaxLength(64);

                entity.Property(e => e.BranType).HasMaxLength(64);

                entity.Property(e => e.ComCode).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.FaxNo).HasMaxLength(64);

                entity.Property(e => e.FullName).HasMaxLength(4000);

                entity.Property(e => e.Pic4payment)
                    .HasColumnName("PIC4Payment")
                    .HasMaxLength(64);

                entity.Property(e => e.Pic4rcpt)
                    .HasColumnName("PIC4Rcpt")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.ServiceTime).HasMaxLength(4000);

                entity.Property(e => e.ShortName).HasMaxLength(4000);

                entity.Property(e => e.SysType).HasMaxLength(64);

                entity.Property(e => e.TelNo).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);

                entity.Property(e => e.ZipNo).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgBranchRole>(entity =>
            {
                entity.HasKey(e => new { e.BranCode, e.RoleCode });

                entity.ToTable("ibg_BranchRole");

                entity.Property(e => e.BranCode).HasMaxLength(64);

                entity.Property(e => e.RoleCode).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgBranchRoleTask>(entity =>
            {
                entity.HasKey(e => new { e.BranCode, e.RoleCode, e.TaskCode });

                entity.ToTable("ibg_BranchRoleTask");

                entity.Property(e => e.BranCode).HasMaxLength(64);

                entity.Property(e => e.RoleCode).HasMaxLength(64);

                entity.Property(e => e.TaskCode).HasMaxLength(64);

                entity.Property(e => e.AvailableFlag).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgBranchTypeRole>(entity =>
            {
                entity.HasKey(e => new { e.BranType, e.RoleCode });

                entity.ToTable("ibg_BranchTypeRole");

                entity.Property(e => e.BranType).HasMaxLength(64);

                entity.Property(e => e.RoleCode).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgCalendar>(entity =>
            {
                entity.HasKey(e => new { e.BranCode, e.Date });

                entity.ToTable("ibg_Calendar");

                entity.Property(e => e.BranCode).HasMaxLength(64);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.DateAttribute).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgCategory>(entity =>
            {
                entity.HasKey(e => e.CateCode);

                entity.ToTable("ibg_Category");

                entity.Property(e => e.CateCode).HasMaxLength(64);

                entity.Property(e => e.CateType).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.FullName).HasMaxLength(4000);

                entity.Property(e => e.Ifval)
                    .HasColumnName("IFVal")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.ShortName).HasMaxLength(4000);

                entity.Property(e => e.SortKey).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgCategoryNew>(entity =>
            {
                entity.HasKey(e => e.CateCode);

                entity.ToTable("ibg_Category_new");

                entity.Property(e => e.CateCode).HasMaxLength(64);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Creator)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(N'System')");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .IsRequired()
                    .HasColumnName("RecordID")
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.RecordVersion)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Updator)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(N'System')");
            });

            modelBuilder.Entity<IbgCommonPriceRate>(entity =>
            {
                entity.HasKey(e => e.ComnPriceRateCode);

                entity.ToTable("ibg_CommonPriceRate");

                entity.Property(e => e.ComnPriceRateCode).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.OddHandlingType).HasMaxLength(64);

                entity.Property(e => e.PriceRate4Part).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.PriceRate4Tool).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgCompany>(entity =>
            {
                entity.HasKey(e => e.ComCode);

                entity.ToTable("ibg_Company");

                entity.Property(e => e.ComCode).HasMaxLength(64);

                entity.Property(e => e.AccName).HasMaxLength(64);

                entity.Property(e => e.AccNo).HasMaxLength(64);

                entity.Property(e => e.AccTermStartDate).HasColumnType("datetime");

                entity.Property(e => e.Address).HasMaxLength(4000);

                entity.Property(e => e.AvailableFlag).HasMaxLength(64);

                entity.Property(e => e.BankAddress).HasMaxLength(4000);

                entity.Property(e => e.ComCodeParent).HasMaxLength(64);

                entity.Property(e => e.ComType).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.FaxNo).HasMaxLength(64);

                entity.Property(e => e.FullName).HasMaxLength(4000);

                entity.Property(e => e.Pic4payment)
                    .HasColumnName("PIC4Payment")
                    .HasMaxLength(64);

                entity.Property(e => e.Pic4rcpt)
                    .HasColumnName("PIC4Rcpt")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.RegionCode).HasMaxLength(64);

                entity.Property(e => e.ShortName).HasMaxLength(4000);

                entity.Property(e => e.TelNo).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);

                entity.Property(e => e.VatinpTax)
                    .HasColumnName("VATInpTax")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.ZipNo).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgCompanyTaxPolicy>(entity =>
            {
                entity.HasKey(e => new { e.CompanyCode, e.ISoulOperationProcessingId });

                entity.ToTable("ibg_CompanyTaxPolicy");

                entity.Property(e => e.CompanyCode).HasMaxLength(64);

                entity.Property(e => e.ISoulOperationProcessingId)
                    .HasColumnName("iSoulOperationProcessingID")
                    .HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgCompanyTaxPolicyParameter>(entity =>
            {
                entity.HasKey(e => new { e.CompanyCode, e.ISoulOperationProcessingId, e.ParameterId });

                entity.ToTable("ibg_CompanyTaxPolicyParameter");

                entity.Property(e => e.CompanyCode).HasMaxLength(64);

                entity.Property(e => e.ISoulOperationProcessingId)
                    .HasColumnName("iSoulOperationProcessingID")
                    .HasMaxLength(64);

                entity.Property(e => e.ParameterId)
                    .HasColumnName("ParameterID")
                    .HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.ParameterValue).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgConsignHis>(entity =>
            {
                entity.HasKey(e => e.RcptGuid);

                entity.ToTable("ibg_ConsignHis");

                entity.Property(e => e.RcptGuid)
                    .HasColumnName("RcptGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.RcptBran).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.ServiceBran).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgConsignIv>(entity =>
            {
                entity.HasKey(e => e.RcptGuid);

                entity.ToTable("ibg_ConsignIV");

                entity.Property(e => e.RcptGuid)
                    .HasColumnName("RcptGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.Chargeable).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.DiscountAmt).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.DiscountComment).HasMaxLength(4000);

                entity.Property(e => e.DiscountReason).HasMaxLength(64);

                entity.Property(e => e.LaborCharge).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.OtherCharge).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.OtherChargeReason).HasMaxLength(4000);

                entity.Property(e => e.PartCharge).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.RcptBran).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.RepairDate).HasColumnType("datetime");

                entity.Property(e => e.ServiceBran).HasMaxLength(64);

                entity.Property(e => e.TestCharge).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);

                entity.Property(e => e.WarrantyPeriod).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgConsignRelation>(entity =>
            {
                entity.HasKey(e => new { e.ConsignerBran, e.ConsigneeBran });

                entity.ToTable("ibg_ConsignRelation");

                entity.Property(e => e.ConsignerBran).HasMaxLength(64);

                entity.Property(e => e.ConsigneeBran).HasMaxLength(64);

                entity.Property(e => e.AvailableFlag).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.RelationType).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgContactMethod>(entity =>
            {
                entity.HasKey(e => new { e.RcptGuid, e.ContactMethodGuid });

                entity.ToTable("ibg_ContactMethod");

                entity.Property(e => e.RcptGuid)
                    .HasColumnName("RcptGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.ContactMethodGuid)
                    .HasColumnName("ContactMethodGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.ContactMethod).HasMaxLength(64);

                entity.Property(e => e.ContactMethodType).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgCost>(entity =>
            {
                entity.HasKey(e => new { e.ComCode, e.PartCode, e.AvailFmDate });

                entity.ToTable("ibg_Cost");

                entity.Property(e => e.ComCode).HasMaxLength(64);

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.AvailFmDate).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.PriceCost).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgCostBak201904>(entity =>
            {
                entity.HasKey(e => new { e.ComCode, e.PartCode, e.AvailFmDate });

                entity.ToTable("ibg_CostBAK201904");

                entity.Property(e => e.ComCode).HasMaxLength(64);

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.AvailFmDate).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.PriceCost).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgCurrency>(entity =>
            {
                entity.HasKey(e => e.CurrencyType);

                entity.ToTable("ibg_Currency");

                entity.Property(e => e.CurrencyType).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.FullName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.FullNameChn)
                    .HasColumnName("FullNameCHN")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.FullNameJpn)
                    .HasColumnName("FullNameJPN")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Ifval)
                    .HasColumnName("IFVal")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.ShortName).HasMaxLength(4000);

                entity.Property(e => e.ShortNameChn)
                    .HasColumnName("ShortNameCHN")
                    .HasMaxLength(4000);

                entity.Property(e => e.ShortNameJpn)
                    .HasColumnName("ShortNameJPN")
                    .HasMaxLength(4000);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgCustomer>(entity =>
            {
                entity.HasKey(e => e.CustomerGuid);

                entity.ToTable("ibg_Customer");

                entity.HasIndex(e => e.CustomerSearchCode);

                entity.Property(e => e.CustomerGuid)
                    .HasColumnName("CustomerGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.Address).HasMaxLength(4000);

                entity.Property(e => e.AvailableFlag).HasMaxLength(64);

                entity.Property(e => e.Bizdiv)
                    .HasColumnName("BIZDiv")
                    .HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.CustomerSearchCode).HasMaxLength(64);

                entity.Property(e => e.CustomerType).HasMaxLength(64);

                entity.Property(e => e.DateFm).HasColumnType("datetime");

                entity.Property(e => e.DateTo).HasColumnType("datetime");

                entity.Property(e => e.DeptDiv).HasMaxLength(64);

                entity.Property(e => e.FullName).HasMaxLength(4000);

                entity.Property(e => e.Npsno)
                    .HasColumnName("NPSNo")
                    .HasMaxLength(64);

                entity.Property(e => e.OrgCode).HasMaxLength(64);

                entity.Property(e => e.OrgLevel).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.Sex).HasMaxLength(64);

                entity.Property(e => e.ShortName).HasMaxLength(4000);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);

                entity.Property(e => e.Zip).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgCustomerContactMethod>(entity =>
            {
                entity.HasKey(e => e.ContactMethodGuid);

                entity.ToTable("ibg_CustomerContactMethod");

                entity.HasIndex(e => e.CustomerGuid);

                entity.Property(e => e.ContactMethodGuid)
                    .HasColumnName("ContactMethodGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.ContactMethod).HasMaxLength(64);

                entity.Property(e => e.ContactMethodType).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.CustomerGuid)
                    .HasColumnName("CustomerGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgCustomerHoldProduct>(entity =>
            {
                entity.HasKey(e => new { e.CustomerGuid, e.ProdCode, e.ProdSn });

                entity.ToTable("ibg_CustomerHoldProduct");

                entity.Property(e => e.CustomerGuid)
                    .HasColumnName("CustomerGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.ProdCode).HasMaxLength(64);

                entity.Property(e => e.ProdSn)
                    .HasColumnName("ProdSN")
                    .HasMaxLength(64);

                entity.Property(e => e.AvailableFlag).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.DateFm).HasColumnType("datetime");

                entity.Property(e => e.DateTo).HasColumnType("datetime");

                entity.Property(e => e.DiscountRate).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.OddHandlingType).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);

                entity.Property(e => e.WarrantyMonths).HasColumnType("decimal(20, 6)");
            });

            modelBuilder.Entity<IbgDisableOrder>(entity =>
            {
                entity.HasKey(e => new { e.BranCode, e.PartCode });

                entity.ToTable("ibg_DisableOrder");

                entity.Property(e => e.BranCode).HasMaxLength(64);

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.BranName).HasMaxLength(4000);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.PartName).HasMaxLength(4000);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgDiscountRate>(entity =>
            {
                entity.HasKey(e => new { e.OrgLevel, e.OrgCode, e.CustomerType });

                entity.ToTable("ibg_DiscountRate");

                entity.Property(e => e.OrgLevel).HasMaxLength(64);

                entity.Property(e => e.OrgCode).HasMaxLength(64);

                entity.Property(e => e.CustomerType).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.DiscountRate).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.DiscountRateOwflag)
                    .HasColumnName("DiscountRateOWFlag")
                    .HasMaxLength(64);

                entity.Property(e => e.OddHandlingType).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgErrorList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ibg_ErrorList");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Creator)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(N'System')");

                entity.Property(e => e.Error).HasMaxLength(4000);

                entity.Property(e => e.ProcedureNm).HasMaxLength(64);

                entity.Property(e => e.ProgramNm).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.RecordVersion)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.RequestId)
                    .HasColumnName("RequestID")
                    .HasMaxLength(64);

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Updator)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(N'System')");
            });

            modelBuilder.Entity<IbgEstimationParts>(entity =>
            {
                entity.HasKey(e => new { e.RcptGuid, e.PartCode });

                entity.ToTable("ibg_EstimationParts");

                entity.Property(e => e.RcptGuid)
                    .HasColumnName("RcptGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.DisplayOutPut).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgExchangeRate>(entity =>
            {
                entity.HasKey(e => new { e.ExchangeType, e.CurrencyTypeFm, e.CurrencyTypeTo, e.AvailFmDate });

                entity.ToTable("ibg_ExchangeRate");

                entity.Property(e => e.ExchangeType).HasMaxLength(64);

                entity.Property(e => e.CurrencyTypeFm).HasMaxLength(64);

                entity.Property(e => e.CurrencyTypeTo).HasMaxLength(64);

                entity.Property(e => e.AvailFmDate).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.OddHandlingType).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgInStockComment>(entity =>
            {
                entity.HasKey(e => e.WoactGuid);

                entity.ToTable("ibg_InStockComment");

                entity.Property(e => e.WoactGuid)
                    .HasColumnName("WOActGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.Censor).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.InStkComment).HasMaxLength(4000);

                entity.Property(e => e.InStkCommentSta).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgIndividualLaborChargeDetails>(entity =>
            {
                entity.HasKey(e => new { e.BranCode, e.ProdCode, e.RepairRank });

                entity.ToTable("ibg_IndividualLaborChargeDetails");

                entity.Property(e => e.BranCode).HasMaxLength(64);

                entity.Property(e => e.ProdCode).HasMaxLength(64);

                entity.Property(e => e.RepairRank).HasMaxLength(64);

                entity.Property(e => e.AvailableFlag).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.LaborChargeLimit).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgInvoice>(entity =>
            {
                entity.HasKey(e => e.InvoiceGuid);

                entity.ToTable("ibg_Invoice");

                entity.Property(e => e.InvoiceGuid)
                    .HasColumnName("InvoiceGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.BuyBranchCode).HasMaxLength(64);

                entity.Property(e => e.Comment).HasMaxLength(4000);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.Paid).HasMaxLength(64);

                entity.Property(e => e.PaymentConfirmed).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.RelationGuid)
                    .HasColumnName("RelationGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.RelationType).HasMaxLength(64);

                entity.Property(e => e.SellBranchCode).HasMaxLength(64);

                entity.Property(e => e.Status).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgInvoiceAccount>(entity =>
            {
                entity.HasKey(e => new { e.SalesRegionCode, e.InvoiceAccount });

                entity.ToTable("ibg_InvoiceAccount");

                entity.Property(e => e.SalesRegionCode).HasMaxLength(64);

                entity.Property(e => e.InvoiceAccount).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.Name).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgInvoiceDetail>(entity =>
            {
                entity.HasKey(e => e.InvoiceDetailGuid);

                entity.ToTable("ibg_InvoiceDetail");

                entity.Property(e => e.InvoiceDetailGuid)
                    .HasColumnName("InvoiceDetailGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.Comment).HasMaxLength(4000);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.DevisionOfTax).HasMaxLength(64);

                entity.Property(e => e.InvoiceAccount).HasMaxLength(64);

                entity.Property(e => e.InvoiceAmount).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.InvoiceCurrency).HasMaxLength(64);

                entity.Property(e => e.InvoiceGuid)
                    .HasColumnName("InvoiceGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.InvoiceSubAccount).HasMaxLength(64);

                entity.Property(e => e.InvoiceSubAccountName).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.TaxAmount).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgInvoiceSubAccount>(entity =>
            {
                entity.HasKey(e => new { e.SalesRegionCode, e.InvoiceAccount, e.InvoiceSubAccount });

                entity.ToTable("ibg_InvoiceSubAccount");

                entity.Property(e => e.SalesRegionCode).HasMaxLength(64);

                entity.Property(e => e.InvoiceAccount).HasMaxLength(64);

                entity.Property(e => e.InvoiceSubAccount).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.Name).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.TaxationFlag).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgKpi>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ibg_KPI");

                entity.Property(e => e.BranCode)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.DeliveryTime10).HasColumnName("DeliveryTime_10");

                entity.Property(e => e.DeliveryTime2).HasColumnName("DeliveryTime_2");

                entity.Property(e => e.DeliveryTime20).HasColumnName("DeliveryTime_20");

                entity.Property(e => e.DeliveryTime5).HasColumnName("DeliveryTime_5");

                entity.Property(e => e.DeliveryTimeOver20).HasColumnName("DeliveryTime_Over20");

                entity.Property(e => e.DeliveryTimeTtl).HasColumnName("DeliveryTimeTTL");

                entity.Property(e => e.ExportUnit)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.FinishedTtl).HasColumnName("FinishedTTL");

                entity.Property(e => e.QuickServiceFinishedYes).HasColumnName("QuickServiceFinished_Yes");

                entity.Property(e => e.QuickServiceRequest).HasColumnName("QuickService_Request");

                entity.Property(e => e.ThisHandlingTtl).HasColumnName("ThisHandlingTTL");

                entity.Property(e => e.ThisReturnTtl).HasColumnName("ThisReturnTTL");

                entity.Property(e => e.ThisServicingTtl).HasColumnName("ThisServicingTTL");

                entity.Property(e => e.ThisSr).HasColumnName("ThisSR");

                entity.Property(e => e.WarrantyPeriodBeforeSale).HasColumnName("WarrantyPeriod_BeforeSale");

                entity.Property(e => e.WarrantyPeriodExtended).HasColumnName("WarrantyPeriod_Extended");

                entity.Property(e => e.WarrantyPeriodIn).HasColumnName("WarrantyPeriod_In");

                entity.Property(e => e.WarrantyPeriodNotIn).HasColumnName("WarrantyPeriod_NotIn");
            });

            modelBuilder.Entity<IbgLaborCharge>(entity =>
            {
                entity.HasKey(e => e.LaborChargeCode);

                entity.ToTable("ibg_LaborCharge");

                entity.Property(e => e.LaborChargeCode).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.FullName).HasMaxLength(4000);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.RegionCode).HasMaxLength(64);

                entity.Property(e => e.ShortName).HasMaxLength(4000);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgLaborChargeDetails>(entity =>
            {
                entity.HasKey(e => new { e.LaborChargeCode, e.RepairRank, e.AvailFmDate });

                entity.ToTable("ibg_LaborChargeDetails");

                entity.Property(e => e.LaborChargeCode).HasMaxLength(64);

                entity.Property(e => e.RepairRank).HasMaxLength(64);

                entity.Property(e => e.AvailFmDate).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.LaborChargeLimit).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgLaborChargeRank>(entity =>
            {
                entity.HasKey(e => new { e.BranCode, e.RepairRank });

                entity.ToTable("ibg_LaborChargeRank");

                entity.Property(e => e.BranCode).HasMaxLength(64);

                entity.Property(e => e.RepairRank).HasMaxLength(64);

                entity.Property(e => e.AvailableFlag).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgLmndlvrInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ibg_LMNDlvrInfo");

                entity.Property(e => e.DlvrCd).HasMaxLength(64);

                entity.Property(e => e.DlvrPic).HasColumnName("DlvrPIC");
            });

            modelBuilder.Entity<IbgLmnproduct>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ibg_LMNProduct");

                entity.Property(e => e.Kitbom)
                    .HasColumnName("KITBOM")
                    .HasMaxLength(64);

                entity.Property(e => e.LmnprodCd)
                    .HasColumnName("LMNProdCd")
                    .HasMaxLength(64);

                entity.Property(e => e.LmnprodNm)
                    .HasColumnName("LMNProdNm")
                    .HasMaxLength(64);

                entity.Property(e => e.ProdType)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.RelaType)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.Sapcd).HasColumnName("SAPCd");
            });

            modelBuilder.Entity<IbgMapping>(entity =>
            {
                entity.HasKey(e => e.Old);

                entity.ToTable("ibg_Mapping");

                entity.Property(e => e.Old).HasMaxLength(64);

                entity.Property(e => e.New).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgMessage>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ibg_Message");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Creator)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(N'System')");

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.RecordVersion)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Text).HasMaxLength(200);

                entity.Property(e => e.TextId)
                    .HasColumnName("TextID")
                    .HasMaxLength(64);

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Updator)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(N'System')");
            });

            modelBuilder.Entity<IbgMovePattern>(entity =>
            {
                entity.HasKey(e => new { e.AccTypeSource, e.AccTypeTarget });

                entity.ToTable("ibg_MovePattern");

                entity.Property(e => e.AccTypeSource).HasMaxLength(64);

                entity.Property(e => e.AccTypeTarget).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.FullName).HasMaxLength(4000);

                entity.Property(e => e.FullNameChn)
                    .HasColumnName("FullNameCHN")
                    .HasMaxLength(4000);

                entity.Property(e => e.FullNameJpn)
                    .HasColumnName("FullNameJPN")
                    .HasMaxLength(4000);

                entity.Property(e => e.MovePatternType).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.ShortName).HasMaxLength(4000);

                entity.Property(e => e.ShortNameChn)
                    .HasColumnName("ShortNameCHN")
                    .HasMaxLength(4000);

                entity.Property(e => e.ShortNameJpn)
                    .HasColumnName("ShortNameJPN")
                    .HasMaxLength(4000);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgNeed>(entity =>
            {
                entity.HasKey(e => new { e.StkAccCode, e.PartCode });

                entity.ToTable("ibg_Need");

                entity.HasIndex(e => e.PartCode);

                entity.Property(e => e.StkAccCode).HasMaxLength(64);

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgNeed20190321>(entity =>
            {
                entity.HasKey(e => new { e.StkAccCode, e.PartCode });

                entity.ToTable("ibg_Need_20190321");

                entity.Property(e => e.StkAccCode).HasMaxLength(64);

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgNeedHis>(entity =>
            {
                entity.HasKey(e => new { e.NdGuid, e.StkAccCode, e.PartCode });

                entity.ToTable("ibg_NeedHis");

                entity.HasIndex(e => e.ChangeDate);

                entity.HasIndex(e => e.PartCode);

                entity.HasIndex(e => e.RelaGuid);

                entity.Property(e => e.NdGuid)
                    .HasColumnName("NdGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.StkAccCode).HasMaxLength(64);

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.ChangeDate).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.OperationId)
                    .HasColumnName("OperationID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.RelaGuid)
                    .HasColumnName("RelaGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.RelaType).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgNeedHis20190321>(entity =>
            {
                entity.HasKey(e => new { e.NdGuid, e.StkAccCode, e.PartCode });

                entity.ToTable("ibg_NeedHis_20190321");

                entity.Property(e => e.NdGuid)
                    .HasColumnName("NdGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.StkAccCode).HasMaxLength(64);

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.ChangeDate).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.OperationId)
                    .HasColumnName("OperationID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.RelaGuid)
                    .HasColumnName("RelaGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.RelaType).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgNotFinishedWoh>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ibg_NotFinishedWOH");

                entity.Property(e => e.Woguid)
                    .IsRequired()
                    .HasColumnName("WOGUID")
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<IbgNt>(entity =>
            {
                entity.HasKey(e => new { e.StkAccCodeNd, e.StkAccCodeSupl, e.PartCode });

                entity.ToTable("ibg_NT");

                entity.HasIndex(e => e.PartCode);

                entity.HasIndex(e => e.StkAccCodeNd);

                entity.HasIndex(e => e.StkAccCodeSupl);

                entity.Property(e => e.StkAccCodeNd).HasMaxLength(64);

                entity.Property(e => e.StkAccCodeSupl).HasMaxLength(64);

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgNt20190321>(entity =>
            {
                entity.HasKey(e => new { e.StkAccCodeNd, e.StkAccCodeSupl, e.PartCode });

                entity.ToTable("ibg_NT_20190321");

                entity.Property(e => e.StkAccCodeNd).HasMaxLength(64);

                entity.Property(e => e.StkAccCodeSupl).HasMaxLength(64);

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgNthis>(entity =>
            {
                entity.HasKey(e => new { e.NthisGuid, e.StkAccCodeNd, e.StkAccCodeSupl, e.PartCode });

                entity.ToTable("ibg_NTHis");

                entity.HasIndex(e => e.ChangeDate);

                entity.HasIndex(e => e.PartCode);

                entity.HasIndex(e => e.RelaGuid);

                entity.Property(e => e.NthisGuid)
                    .HasColumnName("NTHisGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.StkAccCodeNd).HasMaxLength(64);

                entity.Property(e => e.StkAccCodeSupl).HasMaxLength(64);

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.ChangeDate).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.OperationId)
                    .HasColumnName("OperationID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.RelaGuid)
                    .HasColumnName("RelaGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.RelaType).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgNthis20190321>(entity =>
            {
                entity.HasKey(e => new { e.NthisGuid, e.StkAccCodeNd, e.StkAccCodeSupl, e.PartCode });

                entity.ToTable("ibg_NTHis_20190321");

                entity.Property(e => e.NthisGuid)
                    .HasColumnName("NTHisGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.StkAccCodeNd).HasMaxLength(64);

                entity.Property(e => e.StkAccCodeSupl).HasMaxLength(64);

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.ChangeDate).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.OperationId)
                    .HasColumnName("OperationID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.RelaGuid)
                    .HasColumnName("RelaGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.RelaType).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgNthisBackup20201112>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ibg_NTHis_backup20201112");

                entity.Property(e => e.ChangeDate).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.NthisGuid)
                    .IsRequired()
                    .HasColumnName("NTHisGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.OperationId)
                    .HasColumnName("OperationID")
                    .HasMaxLength(64);

                entity.Property(e => e.PartCode)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.RelaGuid)
                    .HasColumnName("RelaGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.RelaType).HasMaxLength(64);

                entity.Property(e => e.StkAccCodeNd)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.StkAccCodeSupl)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgNtmgtD>(entity =>
            {
                entity.HasKey(e => new { e.NtmgtGuid, e.PartCode });

                entity.ToTable("ibg_NTMgtD");

                entity.HasIndex(e => e.NtmgtGuid);

                entity.HasIndex(e => e.PartCode);

                entity.Property(e => e.NtmgtGuid)
                    .HasColumnName("NTMgtGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.Comment).HasMaxLength(4000);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.ExpecteArrivalDate).HasColumnType("datetime");

                entity.Property(e => e.NcmanualOrderDate)
                    .HasColumnName("NCManualOrderDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.OnetimeFlag).HasMaxLength(64);

                entity.Property(e => e.PartNo).HasMaxLength(64);

                entity.Property(e => e.ProdCode).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.ShelfCodeStkAccNd).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgNtmgtD20190321>(entity =>
            {
                entity.HasKey(e => new { e.NtmgtGuid, e.PartCode });

                entity.ToTable("ibg_NTMgtD_20190321");

                entity.Property(e => e.NtmgtGuid)
                    .HasColumnName("NTMgtGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.Comment).HasMaxLength(4000);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.PartNo).HasMaxLength(64);

                entity.Property(e => e.ProdCode).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.ShelfCodeStkAccNd).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgNtmgtD20190806>(entity =>
            {
                entity.HasKey(e => new { e.NtmgtGuid, e.PartCode });

                entity.ToTable("ibg_NTMgtD_20190806");

                entity.Property(e => e.NtmgtGuid)
                    .HasColumnName("NTMgtGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.Comment).HasMaxLength(4000);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.PartNo).HasMaxLength(64);

                entity.Property(e => e.ProdCode).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.ShelfCodeStkAccNd).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgNtmgtDBackup20201112>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ibg_NTMgtD_backup20201112");

                entity.Property(e => e.Comment).HasMaxLength(4000);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.ExpecteArrivalDate).HasColumnType("datetime");

                entity.Property(e => e.NcmanualOrderDate)
                    .HasColumnName("NCManualOrderDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.NtmgtGuid)
                    .IsRequired()
                    .HasColumnName("NTMgtGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.OnetimeFlag).HasMaxLength(64);

                entity.Property(e => e.PartCode)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.PartNo).HasMaxLength(64);

                entity.Property(e => e.ProdCode).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.ShelfCodeStkAccNd).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgNtmgtH>(entity =>
            {
                entity.HasKey(e => new { e.StkAccCodeNd, e.StkAccCodeSupl, e.NtmgtGuid });

                entity.ToTable("ibg_NTMgtH");

                entity.HasIndex(e => e.NtmgtGuid);

                entity.HasIndex(e => e.NtrelaNo);

                entity.HasIndex(e => e.StkAccCodeNd);

                entity.HasIndex(e => e.StkAccCodeSupl);

                entity.Property(e => e.StkAccCodeNd).HasMaxLength(64);

                entity.Property(e => e.StkAccCodeSupl).HasMaxLength(64);

                entity.Property(e => e.NtmgtGuid)
                    .HasColumnName("NTMgtGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.AvailableFlag).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.DisableDate).HasColumnType("datetime");

                entity.Property(e => e.ExeDate).HasColumnType("datetime");

                entity.Property(e => e.IssueDate).HasColumnType("datetime");

                entity.Property(e => e.MainProdCode).HasMaxLength(64);

                entity.Property(e => e.NtrelaNo)
                    .HasColumnName("NTRelaNo")
                    .HasMaxLength(64);

                entity.Property(e => e.OrderSta).HasMaxLength(64);

                entity.Property(e => e.OrderType).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.SonoNpcs)
                    .HasColumnName("SONoNPCS")
                    .HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgNtmgtH20190321>(entity =>
            {
                entity.HasKey(e => new { e.StkAccCodeNd, e.StkAccCodeSupl, e.NtmgtGuid });

                entity.ToTable("ibg_NTMgtH_20190321");

                entity.Property(e => e.StkAccCodeNd).HasMaxLength(64);

                entity.Property(e => e.StkAccCodeSupl).HasMaxLength(64);

                entity.Property(e => e.NtmgtGuid)
                    .HasColumnName("NTMgtGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.AvailableFlag).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.DisableDate).HasColumnType("datetime");

                entity.Property(e => e.ExeDate).HasColumnType("datetime");

                entity.Property(e => e.IssueDate).HasColumnType("datetime");

                entity.Property(e => e.MainProdCode).HasMaxLength(64);

                entity.Property(e => e.NtrelaNo)
                    .HasColumnName("NTRelaNo")
                    .HasMaxLength(64);

                entity.Property(e => e.OrderSta).HasMaxLength(64);

                entity.Property(e => e.OrderType).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.SonoNpcs)
                    .HasColumnName("SONoNPCS")
                    .HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgNtrelation>(entity =>
            {
                entity.HasKey(e => new { e.StkAccCodeNd, e.StkAccCodeSupl });

                entity.ToTable("ibg_NTRelation");

                entity.Property(e => e.StkAccCodeNd).HasMaxLength(64);

                entity.Property(e => e.StkAccCodeSupl).HasMaxLength(64);

                entity.Property(e => e.BranCodeMaintain).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.NtrelaGuid)
                    .HasColumnName("NTRelaGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.Nttype)
                    .HasColumnName("NTType")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgNttempD>(entity =>
            {
                entity.HasKey(e => new { e.NttempGuid, e.PartCode });

                entity.ToTable("ibg_NTTempD");

                entity.Property(e => e.NttempGuid)
                    .HasColumnName("NTTempGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.Comment).HasMaxLength(4000);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgNttempD20190321>(entity =>
            {
                entity.HasKey(e => new { e.NttempGuid, e.PartCode });

                entity.ToTable("ibg_NTTempD_20190321");

                entity.Property(e => e.NttempGuid)
                    .HasColumnName("NTTempGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.Comment).HasMaxLength(4000);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgNttempH>(entity =>
            {
                entity.HasKey(e => new { e.NttempGuid, e.StkAccCodeNd, e.StkAccCodeSupl });

                entity.ToTable("ibg_NTTempH");

                entity.Property(e => e.NttempGuid)
                    .HasColumnName("NTTempGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.StkAccCodeNd).HasMaxLength(64);

                entity.Property(e => e.StkAccCodeSupl).HasMaxLength(64);

                entity.Property(e => e.AvailableFlag).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.MainProdCode).HasMaxLength(64);

                entity.Property(e => e.NtrelaNo)
                    .HasColumnName("NTRelaNo")
                    .HasMaxLength(64);

                entity.Property(e => e.OrderType).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgNttempH20190321>(entity =>
            {
                entity.HasKey(e => new { e.NttempGuid, e.StkAccCodeNd, e.StkAccCodeSupl });

                entity.ToTable("ibg_NTTempH_20190321");

                entity.Property(e => e.NttempGuid)
                    .HasColumnName("NTTempGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.StkAccCodeNd).HasMaxLength(64);

                entity.Property(e => e.StkAccCodeSupl).HasMaxLength(64);

                entity.Property(e => e.AvailableFlag).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.MainProdCode).HasMaxLength(64);

                entity.Property(e => e.NtrelaNo)
                    .HasColumnName("NTRelaNo")
                    .HasMaxLength(64);

                entity.Property(e => e.OrderType).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgPara>(entity =>
            {
                entity.HasKey(e => new { e.ParaGuid, e.LevelGuid });

                entity.ToTable("ibg_Para");

                entity.Property(e => e.ParaGuid)
                    .HasColumnName("ParaGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.LevelGuid)
                    .HasColumnName("LevelGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);

                entity.Property(e => e.Val).HasMaxLength(4000);
            });

            modelBuilder.Entity<IbgParaPart>(entity =>
            {
                entity.HasKey(e => new { e.ParaGuid, e.LevelGuid, e.PartCode });

                entity.ToTable("ibg_ParaPart");

                entity.HasIndex(e => e.PartCode);

                entity.Property(e => e.ParaGuid)
                    .HasColumnName("ParaGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.LevelGuid)
                    .HasColumnName("LevelGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);

                entity.Property(e => e.Val).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgParaType>(entity =>
            {
                entity.HasKey(e => new { e.ParaLevelGuid, e.ParaCode });

                entity.ToTable("ibg_ParaType");

                entity.HasIndex(e => e.ParaGuid)
                    .HasName("UK_ibg_ParaType")
                    .IsUnique();

                entity.Property(e => e.ParaLevelGuid)
                    .HasColumnName("ParaLevelGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.ParaCode).HasMaxLength(64);

                entity.Property(e => e.Comment).HasMaxLength(4000);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.ParaGuid)
                    .HasColumnName("ParaGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.ParaType).HasMaxLength(64);

                entity.Property(e => e.PartUnit).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgPart>(entity =>
            {
                entity.HasKey(e => e.PartCode);

                entity.ToTable("ibg_Part");

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.AvailableFlag).HasMaxLength(64);

                entity.Property(e => e.BeppyoNo).HasMaxLength(64);

                entity.Property(e => e.CirculationFlag).HasMaxLength(64);

                entity.Property(e => e.ComnFlag).HasMaxLength(64);

                entity.Property(e => e.ContryOfOrigin).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.DangerousFlag).HasMaxLength(64);

                entity.Property(e => e.DistributeAttitude).HasMaxLength(64);

                entity.Property(e => e.Earflag)
                    .HasColumnName("EARFlag")
                    .HasMaxLength(64);

                entity.Property(e => e.Eccncode)
                    .HasColumnName("ECCNCode")
                    .HasMaxLength(64);

                entity.Property(e => e.FullName).HasMaxLength(4000);

                entity.Property(e => e.FullNameChn)
                    .HasColumnName("FullNameCHN")
                    .HasMaxLength(4000);

                entity.Property(e => e.FullNameJpn)
                    .HasColumnName("FullNameJPN")
                    .HasMaxLength(4000);

                entity.Property(e => e.LicenceType).HasMaxLength(64);

                entity.Property(e => e.MainProdCode).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.RpinfoCode)
                    .HasColumnName("RPInfoCode")
                    .HasMaxLength(64);

                entity.Property(e => e.ShortName).HasMaxLength(4000);

                entity.Property(e => e.ShortNameChn)
                    .HasColumnName("ShortNameCHN")
                    .HasMaxLength(4000);

                entity.Property(e => e.ShortNameJpn)
                    .HasColumnName("ShortNameJPN")
                    .HasMaxLength(4000);

                entity.Property(e => e.ToolFlag).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgPartCodeConvert>(entity =>
            {
                entity.HasKey(e => new { e.ProdCode, e.PartNo });

                entity.ToTable("ibg_PartCodeConvert");

                entity.HasIndex(e => e.PartCode);

                entity.HasIndex(e => e.PartNo);

                entity.Property(e => e.ProdCode).HasMaxLength(64);

                entity.Property(e => e.PartNo).HasMaxLength(64);

                entity.Property(e => e.AvailableFlag).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgParticularPriceRule>(entity =>
            {
                entity.HasKey(e => new { e.TradeGuid, e.PartCode, e.AvailFmDate });

                entity.ToTable("ibg_ParticularPriceRule");

                entity.Property(e => e.TradeGuid)
                    .HasColumnName("TradeGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.AvailFmDate).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.ExistFlag).HasMaxLength(64);

                entity.Property(e => e.OddHandlingType).HasMaxLength(64);

                entity.Property(e => e.PriceFixed).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.PriceRate).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.SpecialPriceType).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgPaymentHis>(entity =>
            {
                entity.HasKey(e => new { e.PaymentGuid, e.BranCodeFm, e.BranCodeTo });

                entity.ToTable("ibg_PaymentHis");

                entity.HasIndex(e => e.RcptGuid);

                entity.Property(e => e.PaymentGuid)
                    .HasColumnName("PaymentGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.BranCodeFm).HasMaxLength(64);

                entity.Property(e => e.BranCodeTo).HasMaxLength(64);

                entity.Property(e => e.Amt).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Comment).HasMaxLength(4000);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentMethod).HasMaxLength(64);

                entity.Property(e => e.RcptGuid)
                    .HasColumnName("RcptGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgPgm>(entity =>
            {
                entity.HasKey(e => e.ProgramId);

                entity.ToTable("ibg_PGM");

                entity.Property(e => e.ProgramId)
                    .HasColumnName("ProgramID")
                    .HasMaxLength(64);

                entity.Property(e => e.Attributes).HasMaxLength(4000);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.ProgramUrl)
                    .HasColumnName("ProgramURL")
                    .HasMaxLength(4000);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgPrice>(entity =>
            {
                entity.HasKey(e => new { e.PriceType, e.PartCode, e.AvailFmDate });

                entity.ToTable("ibg_Price");

                entity.HasIndex(e => e.PartCode);

                entity.Property(e => e.PriceType).HasMaxLength(64);

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.AvailFmDate).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.Price).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgPriceBak20180925>(entity =>
            {
                entity.HasKey(e => new { e.PriceType, e.PartCode, e.AvailFmDate });

                entity.ToTable("ibg_Price_bak_20180925");

                entity.Property(e => e.PriceType).HasMaxLength(64);

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.AvailFmDate).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.Price).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgPriceBak20190830>(entity =>
            {
                entity.HasKey(e => new { e.PriceType, e.PartCode, e.AvailFmDate });

                entity.ToTable("ibg_Price_bak_20190830");

                entity.Property(e => e.PriceType).HasMaxLength(64);

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.AvailFmDate).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.Price).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgPriceCalcPara>(entity =>
            {
                entity.HasKey(e => e.PriceType);

                entity.ToTable("ibg_PriceCalcPara");

                entity.Property(e => e.PriceType).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.OddHandlingType).HasMaxLength(64);

                entity.Property(e => e.PriceRate4Part).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.PriceRate4Tool).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgPriceCalcParaPerPrice>(entity =>
            {
                entity.HasKey(e => new { e.PriceType, e.PriceFm });

                entity.ToTable("ibg_PriceCalcParaPerPrice");

                entity.Property(e => e.PriceType).HasMaxLength(64);

                entity.Property(e => e.PriceFm).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.OddHandlingType).HasMaxLength(64);

                entity.Property(e => e.PriceRate4Part).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.PriceRate4Tool).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgPriceChange>(entity =>
            {
                entity.HasKey(e => new { e.PriceType, e.PartCode, e.AvailFmDate });

                entity.ToTable("ibg_PriceChange");

                entity.Property(e => e.PriceType).HasMaxLength(64);

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.AvailFmDate).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.Price).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgPriceTmpbak20200331>(entity =>
            {
                entity.HasKey(e => new { e.PriceType, e.PartCode, e.AvailFmDate });

                entity.ToTable("ibg_Price_tmpbak_20200331");

                entity.Property(e => e.PriceType).HasMaxLength(64);

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.AvailFmDate).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.Price).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgPriceType>(entity =>
            {
                entity.HasKey(e => e.PriceType);

                entity.ToTable("ibg_PriceType");

                entity.Property(e => e.PriceType).HasMaxLength(64);

                entity.Property(e => e.BranCodeMaintain).HasMaxLength(64);

                entity.Property(e => e.ComnPriceRateCode).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.CurrencyType).HasMaxLength(64);

                entity.Property(e => e.ExchangeType).HasMaxLength(64);

                entity.Property(e => e.FullName).HasMaxLength(4000);

                entity.Property(e => e.Owflag)
                    .HasColumnName("OWFlag")
                    .HasMaxLength(64);

                entity.Property(e => e.PriceTypeParent).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.ShortName).HasMaxLength(4000);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgProcedureResult>(entity =>
            {
                entity.HasKey(e => e.ProcedureId);

                entity.ToTable("ibg_ProcedureResult");

                entity.Property(e => e.ProcedureId)
                    .HasColumnName("ProcedureID")
                    .HasMaxLength(64);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Creator)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(N'System')");

                entity.Property(e => e.Detail).HasMaxLength(64);

                entity.Property(e => e.ProcedureType).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.RecordVersion)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Result).HasMaxLength(64);

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Updator)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(N'System')");
            });

            modelBuilder.Entity<IbgProdMovHis>(entity =>
            {
                entity.HasKey(e => e.ProdMovHisGuid);

                entity.ToTable("ibg_ProdMovHis");

                entity.HasIndex(e => e.RcptGuid)
                    .HasName("IX_ibg_RcptGUID");

                entity.Property(e => e.ProdMovHisGuid)
                    .HasColumnName("ProdMovHisGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.BranCodeAfterExe).HasMaxLength(64);

                entity.Property(e => e.BranCodeSource).HasMaxLength(64);

                entity.Property(e => e.BranCodeTarget).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.MovDate).HasColumnType("datetime");

                entity.Property(e => e.OperationId)
                    .HasColumnName("OperationID")
                    .HasMaxLength(64);

                entity.Property(e => e.OutStkType).HasMaxLength(64);

                entity.Property(e => e.ProdWoguid)
                    .HasColumnName("ProdWOGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.RcptGuid)
                    .HasColumnName("RcptGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.StaAfterExe).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgProdWod>(entity =>
            {
                entity.HasKey(e => new { e.RcptGuid, e.ProdWoguid });

                entity.ToTable("ibg_ProdWOD");

                entity.Property(e => e.RcptGuid)
                    .HasColumnName("RcptGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.ProdWoguid)
                    .HasColumnName("ProdWOGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.AvailableFlag).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.DisableDate).HasColumnType("datetime");

                entity.Property(e => e.DisableUpdator).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgProdWoh>(entity =>
            {
                entity.HasKey(e => e.ProdWoguid);

                entity.ToTable("ibg_ProdWOH");

                entity.Property(e => e.ProdWoguid)
                    .HasColumnName("ProdWOGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.AvailableFlag).HasMaxLength(64);

                entity.Property(e => e.BranCodeSource).HasMaxLength(64);

                entity.Property(e => e.BranCodeTarget).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.DisableDate).HasColumnType("datetime");

                entity.Property(e => e.DisableUpdator).HasMaxLength(64);

                entity.Property(e => e.InStkExeDate).HasColumnType("datetime");

                entity.Property(e => e.InStkExecutor).HasMaxLength(64);

                entity.Property(e => e.IssueDate).HasColumnType("datetime");

                entity.Property(e => e.IssuePerson).HasMaxLength(64);

                entity.Property(e => e.OutStkExeDate).HasColumnType("datetime");

                entity.Property(e => e.OutStkExecutor).HasMaxLength(64);

                entity.Property(e => e.OutStkType).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);

                entity.Property(e => e.WorelaNo)
                    .HasColumnName("WORelaNo")
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<IbgProduct>(entity =>
            {
                entity.HasKey(e => e.ProdCode);

                entity.ToTable("ibg_Product");

                entity.Property(e => e.ProdCode).HasMaxLength(64);

                entity.Property(e => e.AvailableFlag).HasMaxLength(64);

                entity.Property(e => e.CateCode).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.EndOfSalesDate).HasMaxLength(64);

                entity.Property(e => e.FullName).HasMaxLength(4000);

                entity.Property(e => e.FullName4ProdSales).HasMaxLength(4000);

                entity.Property(e => e.KeepPeriodToYm)
                    .HasColumnName("KeepPeriodToYM")
                    .HasMaxLength(64);

                entity.Property(e => e.ProdCode4Sales).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.SalesStartDate).HasMaxLength(64);

                entity.Property(e => e.ShortName).HasMaxLength(4000);

                entity.Property(e => e.ShortName4ProdSales).HasMaxLength(4000);

                entity.Property(e => e.SortKey).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgProductNew>(entity =>
            {
                entity.HasKey(e => e.ProdCode);

                entity.ToTable("ibg_Product_new");

                entity.Property(e => e.ProdCode).HasMaxLength(64);

                entity.Property(e => e.CateCode).HasMaxLength(64);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Creator)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(N'System')");

                entity.Property(e => e.RecordId)
                    .IsRequired()
                    .HasColumnName("RecordID")
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.RecordVersion)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Updator)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(N'System')");
            });

            modelBuilder.Entity<IbgProductRp>(entity =>
            {
                entity.HasKey(e => new { e.ProdSn, e.ProdCode });

                entity.ToTable("ibg_ProductRP");

                entity.HasIndex(e => e.ProdSnnew);

                entity.HasIndex(e => e.ProdSnold);

                entity.Property(e => e.ProdSn)
                    .HasColumnName("ProdSN")
                    .HasMaxLength(64);

                entity.Property(e => e.ProdCode).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.GrayProdFlag).HasMaxLength(64);

                entity.Property(e => e.GuaranteeCertificateInfo).HasMaxLength(64);

                entity.Property(e => e.ProdSnnew)
                    .HasColumnName("ProdSNNew")
                    .HasMaxLength(64);

                entity.Property(e => e.ProdSnold)
                    .HasColumnName("ProdSNOld")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.SaleDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgProductSalesEx>(entity =>
            {
                entity.HasKey(e => new { e.RegionCode, e.ProdCode });

                entity.ToTable("ibg_ProductSalesEx");

                entity.Property(e => e.RegionCode).HasMaxLength(64);

                entity.Property(e => e.ProdCode).HasMaxLength(64);

                entity.Property(e => e.AvailableFlag).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.LaborChargeCode).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgReason>(entity =>
            {
                entity.HasKey(e => new { e.ReasonType, e.OrgLevel, e.OrgCode, e.ReasonCode });

                entity.ToTable("ibg_Reason");

                entity.HasIndex(e => e.ReasonGuid)
                    .HasName("UK_ibg_Reason")
                    .IsUnique();

                entity.Property(e => e.ReasonType).HasMaxLength(64);

                entity.Property(e => e.OrgLevel).HasMaxLength(64);

                entity.Property(e => e.OrgCode).HasMaxLength(64);

                entity.Property(e => e.ReasonCode).HasMaxLength(64);

                entity.Property(e => e.AvailableFlag).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.FullName).HasMaxLength(4000);

                entity.Property(e => e.FullNameChn)
                    .HasColumnName("FullNameCHN")
                    .HasMaxLength(4000);

                entity.Property(e => e.FullNameJpn)
                    .HasColumnName("FullNameJPN")
                    .HasMaxLength(4000);

                entity.Property(e => e.Ifval)
                    .HasColumnName("IFVal")
                    .HasMaxLength(64);

                entity.Property(e => e.ReasonGuid)
                    .HasColumnName("ReasonGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.ShortName).HasMaxLength(4000);

                entity.Property(e => e.ShortNameChn)
                    .HasColumnName("ShortNameCHN")
                    .HasMaxLength(4000);

                entity.Property(e => e.ShortNameJpn)
                    .HasColumnName("ShortNameJPN")
                    .HasMaxLength(4000);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgReceipt>(entity =>
            {
                entity.HasKey(e => e.RcptGuid);

                entity.ToTable("ibg_Receipt");

                entity.HasIndex(e => e.CloseDate);

                entity.HasIndex(e => e.ProdCode);

                entity.HasIndex(e => e.ProdSn);

                entity.HasIndex(e => e.RcptDate);

                entity.HasIndex(e => e.RcptNo);

                entity.HasIndex(e => e.RecordId);

                entity.HasIndex(e => e.RepairDate);

                entity.HasIndex(e => e.StaCode);

                entity.Property(e => e.RcptGuid)
                    .HasColumnName("RcptGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.Accessary).HasMaxLength(4000);

                entity.Property(e => e.BranCodeMgt).HasMaxLength(64);

                entity.Property(e => e.Chargeable).HasMaxLength(64);

                entity.Property(e => e.CloseComment).HasMaxLength(4000);

                entity.Property(e => e.CloseDate).HasColumnType("datetime");

                entity.Property(e => e.ClosePerson).HasMaxLength(64);

                entity.Property(e => e.ContactAddress).HasMaxLength(4000);

                entity.Property(e => e.ContactPerson).HasMaxLength(4000);

                entity.Property(e => e.ContactZip).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.CustomerGuid)
                    .HasColumnName("CustomerGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.CustomerType).HasMaxLength(64);

                entity.Property(e => e.DeliveryBran).HasMaxLength(64);

                entity.Property(e => e.DeliveryMethod).HasMaxLength(64);

                entity.Property(e => e.DeliveryTime).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.DisRepairReason).HasMaxLength(64);

                entity.Property(e => e.DiscountAmt).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.DiscountComment).HasMaxLength(4000);

                entity.Property(e => e.DiscountRate).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.DiscountRateOwcomment)
                    .HasColumnName("DiscountRateOWComment")
                    .HasMaxLength(4000);

                entity.Property(e => e.DiscountReason).HasMaxLength(64);

                entity.Property(e => e.EstmContactDate).HasColumnType("datetime");

                entity.Property(e => e.EstmDiscountAmt).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.EstmDiscountComment).HasMaxLength(4000);

                entity.Property(e => e.EstmDiscountRate).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.EstmDiscountRateOwcomment)
                    .HasColumnName("EstmDiscountRateOWComment")
                    .HasMaxLength(4000);

                entity.Property(e => e.EstmDiscountReason).HasMaxLength(64);

                entity.Property(e => e.EstmLaborCharge).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.EstmOtherCharge).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.EstmOtherChargeReason).HasMaxLength(4000);

                entity.Property(e => e.EstmPerson).HasMaxLength(64);

                entity.Property(e => e.EstmPostFee).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.EstmReplyDate).HasColumnType("datetime");

                entity.Property(e => e.EstmReplyDateOriginal).HasColumnType("datetime");

                entity.Property(e => e.EstmTestCharge).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.ExchangeReason).HasMaxLength(64);

                entity.Property(e => e.FinishedContactComment).HasMaxLength(4000);

                entity.Property(e => e.FinishedContactDate).HasColumnType("datetime");

                entity.Property(e => e.FinishedContactPerson).HasMaxLength(64);

                entity.Property(e => e.Ivno)
                    .HasColumnName("IVNo")
                    .HasMaxLength(64);

                entity.Property(e => e.LaborCharge).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.LaboratoryResults).HasMaxLength(4000);

                entity.Property(e => e.OddHandlingType).HasMaxLength(64);

                entity.Property(e => e.OtherCharge).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.OtherChargeReason).HasMaxLength(4000);

                entity.Property(e => e.PostComment).HasMaxLength(4000);

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.PostFee).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.PostPerson).HasMaxLength(64);

                entity.Property(e => e.ProdCode).HasMaxLength(64);

                entity.Property(e => e.ProdExchange).HasMaxLength(64);

                entity.Property(e => e.ProdSn)
                    .HasColumnName("ProdSN")
                    .HasMaxLength(64);

                entity.Property(e => e.ProdSta).HasMaxLength(64);

                entity.Property(e => e.QuickService).HasMaxLength(64);

                entity.Property(e => e.QuickServiceFinished).HasMaxLength(64);

                entity.Property(e => e.RcptBran).HasMaxLength(64);

                entity.Property(e => e.RcptComment).HasMaxLength(4000);

                entity.Property(e => e.RcptDate).HasColumnType("datetime");

                entity.Property(e => e.RcptMethod).HasMaxLength(64);

                entity.Property(e => e.RcptNo).HasMaxLength(64);

                entity.Property(e => e.Rcptor).HasMaxLength(64);

                entity.Property(e => e.ReRepairType).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.RepairContent).HasMaxLength(4000);

                entity.Property(e => e.RepairDate).HasColumnType("datetime");

                entity.Property(e => e.RepairPerson).HasMaxLength(64);

                entity.Property(e => e.RepairRank).HasMaxLength(64);

                entity.Property(e => e.RepairTime).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.RepairType).HasMaxLength(64);

                entity.Property(e => e.ResultCheckDate).HasColumnType("datetime");

                entity.Property(e => e.ResultCheckPerson).HasMaxLength(64);

                entity.Property(e => e.ReturnType).HasMaxLength(64);

                entity.Property(e => e.ServiceBran).HasMaxLength(64);

                entity.Property(e => e.ServiceType).HasMaxLength(64);

                entity.Property(e => e.Sex).HasMaxLength(64);

                entity.Property(e => e.SpecialRequest).HasMaxLength(4000);

                entity.Property(e => e.Srcomment)
                    .HasColumnName("SRComment")
                    .HasMaxLength(64);

                entity.Property(e => e.Srflag)
                    .HasColumnName("SRFlag")
                    .HasMaxLength(64);

                entity.Property(e => e.Srquality)
                    .HasColumnName("SRQuality")
                    .HasMaxLength(64);

                entity.Property(e => e.Srtype)
                    .HasColumnName("SRType")
                    .HasMaxLength(64);

                entity.Property(e => e.StaCode).HasMaxLength(64);

                entity.Property(e => e.StockRepairRank).HasMaxLength(64);

                entity.Property(e => e.TargetRepairDate).HasColumnType("datetime");

                entity.Property(e => e.TaxRate)
                    .HasColumnType("decimal(20, 6)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TestCharge).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.TestDate).HasColumnType("datetime");

                entity.Property(e => e.Tester).HasMaxLength(64);

                entity.Property(e => e.TroublePhenomenonEx).HasMaxLength(4000);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);

                entity.Property(e => e.ViaBran).HasMaxLength(64);

                entity.Property(e => e.Wait4PartsContactDate).HasColumnType("datetime");

                entity.Property(e => e.Wait4PartsContactMemo).HasMaxLength(4000);

                entity.Property(e => e.Wait4PartsContactPerson).HasMaxLength(64);

                entity.Property(e => e.WarrantyPeriod).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgReceiptExcGespic>(entity =>
            {
                entity.HasKey(e => e.Picguid);

                entity.ToTable("ibg_ReceiptExcGESPIC");

                entity.Property(e => e.Picguid)
                    .HasColumnName("PICGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.DlvrAddr).HasMaxLength(64);

                entity.Property(e => e.DlvrCd)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.DlvrCity).HasMaxLength(64);

                entity.Property(e => e.DlvrNm).HasMaxLength(64);

                entity.Property(e => e.DlvrPic)
                    .HasColumnName("DlvrPIC")
                    .HasMaxLength(64);

                entity.Property(e => e.DlvrTel).HasMaxLength(64);

                entity.Property(e => e.DlvrZip).HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgReceiptExcIn>(entity =>
            {
                entity.HasKey(e => e.RcptExcInGuid);

                entity.ToTable("ibg_ReceiptExcIn");

                entity.Property(e => e.RcptExcInGuid)
                    .HasColumnName("RcptExcInGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.InStkDo)
                    .HasColumnName("InStkDO")
                    .HasMaxLength(64);

                entity.Property(e => e.InStkSo)
                    .HasColumnName("InStkSO")
                    .HasMaxLength(64);

                entity.Property(e => e.InStkSta).HasMaxLength(64);

                entity.Property(e => e.RcptExcGuid)
                    .IsRequired()
                    .HasColumnName("RcptExcGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.RcptExcInNo).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgReceiptExcOut>(entity =>
            {
                entity.HasKey(e => e.RcptExcOutGuid);

                entity.ToTable("ibg_ReceiptExcOut");

                entity.Property(e => e.RcptExcOutGuid)
                    .HasColumnName("RcptExcOutGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.OutStkDate).HasColumnType("datetime");

                entity.Property(e => e.OutStkDo)
                    .HasColumnName("OutStkDO")
                    .HasMaxLength(64);

                entity.Property(e => e.OutStkSo)
                    .HasColumnName("OutStkSO")
                    .HasMaxLength(64);

                entity.Property(e => e.OutStkSta).HasMaxLength(64);

                entity.Property(e => e.RcptExcGuid)
                    .IsRequired()
                    .HasColumnName("RcptExcGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.RcptExcOutNo).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgReceiptExchange>(entity =>
            {
                entity.HasKey(e => e.RcptExcGuid);

                entity.ToTable("ibg_ReceiptExchange");

                entity.Property(e => e.RcptExcGuid)
                    .HasColumnName("RcptExcGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.ComponentSn1)
                    .HasColumnName("ComponentSN1")
                    .HasMaxLength(64);

                entity.Property(e => e.ComponentSn2)
                    .HasColumnName("ComponentSN2")
                    .HasMaxLength(64);

                entity.Property(e => e.ContactAddress).HasMaxLength(4000);

                entity.Property(e => e.ContactPerson).HasMaxLength(64);

                entity.Property(e => e.ContactZip).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.CustomerSearchCode).HasMaxLength(64);

                entity.Property(e => e.ExcProductCd)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.ExcProductNm)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.KitFlag)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.KitPrimaryFlag).HasMaxLength(64);

                entity.Property(e => e.KitRepairFlagMajorRcptNo).HasMaxLength(64);

                entity.Property(e => e.ProductCd)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.ProductNm)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.RcptGuid)
                    .IsRequired()
                    .HasColumnName("RcptGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.SischkSn)
                    .IsRequired()
                    .HasColumnName("SISchkSN")
                    .HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgRefundLaborCharge>(entity =>
            {
                entity.HasKey(e => new { e.OrgLevel, e.OrgCode, e.ProdCode });

                entity.ToTable("ibg_RefundLaborCharge");

                entity.Property(e => e.OrgLevel).HasMaxLength(64);

                entity.Property(e => e.OrgCode).HasMaxLength(64);

                entity.Property(e => e.ProdCode).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.RefundLaborCharge).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgRegion>(entity =>
            {
                entity.HasKey(e => e.RegionCode);

                entity.ToTable("ibg_Region");

                entity.Property(e => e.RegionCode).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.CurrencyType).HasMaxLength(64);

                entity.Property(e => e.FullName).HasMaxLength(4000);

                entity.Property(e => e.FullNameChn)
                    .HasColumnName("FullNameCHN")
                    .HasMaxLength(4000);

                entity.Property(e => e.FullNameJpn)
                    .HasColumnName("FullNameJPN")
                    .HasMaxLength(4000);

                entity.Property(e => e.OddHandlingType).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.ShortName).HasMaxLength(4000);

                entity.Property(e => e.ShortNameChn)
                    .HasColumnName("ShortNameCHN")
                    .HasMaxLength(4000);

                entity.Property(e => e.ShortNameJpn)
                    .HasColumnName("ShortNameJPN")
                    .HasMaxLength(4000);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgRole>(entity =>
            {
                entity.HasKey(e => e.RoleCode);

                entity.ToTable("ibg_Role");

                entity.Property(e => e.RoleCode).HasMaxLength(64);

                entity.Property(e => e.BranType).HasMaxLength(64);

                entity.Property(e => e.Comment).HasMaxLength(4000);

                entity.Property(e => e.CommentChn)
                    .HasColumnName("CommentCHN")
                    .HasMaxLength(4000);

                entity.Property(e => e.CommentJpn)
                    .HasColumnName("CommentJPN")
                    .HasMaxLength(4000);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.FullName).HasMaxLength(4000);

                entity.Property(e => e.FullNameChn)
                    .HasColumnName("FullNameCHN")
                    .HasMaxLength(4000);

                entity.Property(e => e.FullNameJpn)
                    .HasColumnName("FullNameJPN")
                    .HasMaxLength(4000);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.ShortName).HasMaxLength(4000);

                entity.Property(e => e.ShortNameChn)
                    .HasColumnName("ShortNameCHN")
                    .HasMaxLength(4000);

                entity.Property(e => e.ShortNameJpn)
                    .HasColumnName("ShortNameJPN")
                    .HasMaxLength(4000);

                entity.Property(e => e.SortKey).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgRoleTask>(entity =>
            {
                entity.HasKey(e => new { e.RoleCode, e.TaskCode });

                entity.ToTable("ibg_RoleTask");

                entity.Property(e => e.RoleCode).HasMaxLength(64);

                entity.Property(e => e.TaskCode).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgRoleTaskBak20190317>(entity =>
            {
                entity.HasKey(e => new { e.RoleCode, e.TaskCode });

                entity.ToTable("ibg_RoleTask_bak20190317");

                entity.Property(e => e.RoleCode).HasMaxLength(64);

                entity.Property(e => e.TaskCode).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgServiceStateChk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ibg_ServiceStateChk");

                entity.Property(e => e.CheckResult).HasMaxLength(200);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<IbgShelf>(entity =>
            {
                entity.HasKey(e => new { e.StkAccCode, e.PartCode });

                entity.ToTable("ibg_Shelf");

                entity.HasIndex(e => e.PartCode);

                entity.Property(e => e.StkAccCode).HasMaxLength(64);

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.Comment).HasMaxLength(4000);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.ShelfCode).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgShprice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ibg_SHPrice");

                entity.Property(e => e.AccTypeS).HasMaxLength(64);

                entity.Property(e => e.AccTypeT).HasMaxLength(64);

                entity.Property(e => e.BranTarget)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.BranTargetName).HasMaxLength(4000);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.CurrencyType).HasMaxLength(64);

                entity.Property(e => e.MoveDate).HasColumnType("datetime");

                entity.Property(e => e.OperationId)
                    .HasColumnName("OperationID")
                    .HasMaxLength(64);

                entity.Property(e => e.PartCode)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.Price).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.ReasonGuid)
                    .HasColumnName("ReasonGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.RelaGuid)
                    .HasColumnName("RelaGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.RelaType).HasMaxLength(64);

                entity.Property(e => e.StkAccCodeSource)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.StkAccCodeTarget)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.StkHisGuid)
                    .IsRequired()
                    .HasColumnName("StkHisGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgSmstask>(entity =>
            {
                entity.HasKey(e => e.TaskId);

                entity.ToTable("ibg_SMSTask");

                entity.Property(e => e.TaskId)
                    .HasColumnName("TaskID")
                    .HasMaxLength(64);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Creator)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(N'System')");

                entity.Property(e => e.MessageId)
                    .HasColumnName("MessageID")
                    .HasMaxLength(64);

                entity.Property(e => e.RcptGuid)
                    .IsRequired()
                    .HasColumnName("RcptGUID")
                    .HasMaxLength(128);

                entity.Property(e => e.RcptNo)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.RecordVersion)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Result).HasMaxLength(4000);

                entity.Property(e => e.SequenceId)
                    .HasColumnName("SequenceID")
                    .HasMaxLength(64);

                entity.Property(e => e.Smsno)
                    .IsRequired()
                    .HasColumnName("SMSNo")
                    .HasMaxLength(64);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.TextContent)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.TextId)
                    .IsRequired()
                    .HasColumnName("TextID")
                    .HasMaxLength(64);

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.Updator)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(N'System')");
            });

            modelBuilder.Entity<IbgSmstaskHis>(entity =>
            {
                entity.HasKey(e => e.TaskId);

                entity.ToTable("ibg_SMSTaskHis");

                entity.Property(e => e.TaskId)
                    .HasColumnName("TaskID")
                    .HasMaxLength(64);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Creator)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(N'System')");

                entity.Property(e => e.MessageId)
                    .HasColumnName("MessageID")
                    .HasMaxLength(64);

                entity.Property(e => e.RcptGuid)
                    .IsRequired()
                    .HasColumnName("RcptGUID")
                    .HasMaxLength(128);

                entity.Property(e => e.RcptNo)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.RecordVersion)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Result).HasMaxLength(4000);

                entity.Property(e => e.SequenceId)
                    .HasColumnName("SequenceID")
                    .HasMaxLength(64);

                entity.Property(e => e.Smsno)
                    .IsRequired()
                    .HasColumnName("SMSNo")
                    .HasMaxLength(64);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.TextContent)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.TextId)
                    .IsRequired()
                    .HasColumnName("TextID")
                    .HasMaxLength(64);

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.Updator)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(N'System')");
            });

            modelBuilder.Entity<IbgSncollection>(entity =>
            {
                entity.HasKey(e => new { e.Sntype, e.RelaGuid });

                entity.ToTable("ibg_SNCollection");

                entity.Property(e => e.Sntype)
                    .HasColumnName("SNType")
                    .HasMaxLength(64);

                entity.Property(e => e.RelaGuid)
                    .HasColumnName("RelaGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.Postfix).HasMaxLength(64);

                entity.Property(e => e.Prefix).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgStaff>(entity =>
            {
                entity.HasKey(e => e.StaffCode);

                entity.ToTable("ibg_Staff");

                entity.Property(e => e.StaffCode).HasMaxLength(64);

                entity.Property(e => e.AvailableFlag).HasMaxLength(64);

                entity.Property(e => e.BranCode).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.FullName).HasMaxLength(4000);

                entity.Property(e => e.OrgLevel).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.ShortName).HasMaxLength(4000);

                entity.Property(e => e.StaffType).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);

                entity.Property(e => e.UserName).HasMaxLength(64);

                entity.Property(e => e.WorkBranCode).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgStaffRole>(entity =>
            {
                entity.HasKey(e => new { e.StaffCode, e.RoleCode });

                entity.ToTable("ibg_StaffRole");

                entity.Property(e => e.StaffCode).HasMaxLength(64);

                entity.Property(e => e.RoleCode).HasMaxLength(64);

                entity.Property(e => e.AccessCtrl).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.OrgLevel).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgStaffTask>(entity =>
            {
                entity.HasKey(e => new { e.StaffCode, e.TaskCode });

                entity.ToTable("ibg_StaffTask");

                entity.Property(e => e.StaffCode).HasMaxLength(64);

                entity.Property(e => e.TaskCode).HasMaxLength(64);

                entity.Property(e => e.AccessCtrl).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.OrgLevel).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgStatusHis>(entity =>
            {
                entity.HasKey(e => new { e.RcptGuid, e.AvailFmDate });

                entity.ToTable("ibg_StatusHis");

                entity.HasIndex(e => e.RcptGuid);

                entity.Property(e => e.RcptGuid)
                    .HasColumnName("RcptGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.AvailFmDate).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.StaCode).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgStock>(entity =>
            {
                entity.HasKey(e => new { e.StkAccCode, e.PartCode });

                entity.ToTable("ibg_Stock");

                entity.HasIndex(e => e.PartCode);

                entity.Property(e => e.StkAccCode).HasMaxLength(64);

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgStock20190321>(entity =>
            {
                entity.HasKey(e => new { e.StkAccCode, e.PartCode });

                entity.ToTable("ibg_Stock_20190321");

                entity.Property(e => e.StkAccCode).HasMaxLength(64);

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgStockAccount>(entity =>
            {
                entity.HasKey(e => e.StkAccCode);

                entity.ToTable("ibg_StockAccount");

                entity.Property(e => e.StkAccCode).HasMaxLength(64);

                entity.Property(e => e.AccType).HasMaxLength(64);

                entity.Property(e => e.BranCodeMgt).HasMaxLength(64);

                entity.Property(e => e.BranCodeMgtLast).HasMaxLength(64);

                entity.Property(e => e.BranCodeMgtNext).HasMaxLength(64);

                entity.Property(e => e.BranCodeOwner).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.FullName).HasMaxLength(4000);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.ShortName).HasMaxLength(4000);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgStockAccountType>(entity =>
            {
                entity.HasKey(e => e.AccType);

                entity.ToTable("ibg_StockAccountType");

                entity.Property(e => e.AccType).HasMaxLength(64);

                entity.Property(e => e.AccNdType).HasMaxLength(64);

                entity.Property(e => e.AccStkType).HasMaxLength(64);

                entity.Property(e => e.AccSuplType).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.FullName).HasMaxLength(4000);

                entity.Property(e => e.FullNameChn)
                    .HasColumnName("FullNameCHN")
                    .HasMaxLength(4000);

                entity.Property(e => e.FullNameJpn)
                    .HasColumnName("FullNameJPN")
                    .HasMaxLength(4000);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.ShortName).HasMaxLength(4000);

                entity.Property(e => e.ShortNameChn)
                    .HasColumnName("ShortNameCHN")
                    .HasMaxLength(4000);

                entity.Property(e => e.ShortNameJpn)
                    .HasColumnName("ShortNameJPN")
                    .HasMaxLength(4000);

                entity.Property(e => e.SortKey).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgStockHis>(entity =>
            {
                entity.HasKey(e => new { e.StkAccCodeSource, e.StkAccCodeTarget, e.PartCode, e.StkHisGuid });

                entity.ToTable("ibg_StockHis");

                entity.HasIndex(e => e.MoveDate);

                entity.HasIndex(e => e.PartCode);

                entity.Property(e => e.StkAccCodeSource).HasMaxLength(64);

                entity.Property(e => e.StkAccCodeTarget).HasMaxLength(64);

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.StkHisGuid)
                    .HasColumnName("StkHisGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.MoveDate).HasColumnType("datetime");

                entity.Property(e => e.OperationId)
                    .HasColumnName("OperationID")
                    .HasMaxLength(64);

                entity.Property(e => e.ReasonGuid)
                    .HasColumnName("ReasonGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.RelaGuid)
                    .HasColumnName("RelaGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.RelaType).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgStockHis20190321>(entity =>
            {
                entity.HasKey(e => new { e.StkAccCodeSource, e.StkAccCodeTarget, e.PartCode, e.StkHisGuid });

                entity.ToTable("ibg_StockHis_20190321");

                entity.Property(e => e.StkAccCodeSource).HasMaxLength(64);

                entity.Property(e => e.StkAccCodeTarget).HasMaxLength(64);

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.StkHisGuid)
                    .HasColumnName("StkHisGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.MoveDate).HasColumnType("datetime");

                entity.Property(e => e.OperationId)
                    .HasColumnName("OperationID")
                    .HasMaxLength(64);

                entity.Property(e => e.ReasonGuid)
                    .HasColumnName("ReasonGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.RelaGuid)
                    .HasColumnName("RelaGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.RelaType).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgStockHisBak20161026>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ibg_StockHis_bak20161026");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.MoveDate).HasColumnType("datetime");

                entity.Property(e => e.OperationId)
                    .HasColumnName("OperationID")
                    .HasMaxLength(64);

                entity.Property(e => e.PartCode)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.ReasonGuid)
                    .HasColumnName("ReasonGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.RelaGuid)
                    .HasColumnName("RelaGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.RelaType).HasMaxLength(64);

                entity.Property(e => e.StkAccCodeSource)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.StkAccCodeTarget)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.StkHisGuid)
                    .IsRequired()
                    .HasColumnName("StkHisGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgStockHisBak20161208Archive>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ibg_StockHis_bak20161208Archive");

                entity.Property(e => e.AccTypeS).HasMaxLength(64);

                entity.Property(e => e.AccTypeT).HasMaxLength(64);

                entity.Property(e => e.BranTarget).HasMaxLength(64);

                entity.Property(e => e.BranTargetName).HasMaxLength(4000);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.CurrencyType).HasMaxLength(64);

                entity.Property(e => e.DistributeAttitude).HasMaxLength(64);

                entity.Property(e => e.MainProdCode).HasMaxLength(64);

                entity.Property(e => e.MoveDate).HasColumnType("datetime");

                entity.Property(e => e.OperationId)
                    .HasColumnName("OperationID")
                    .HasMaxLength(64);

                entity.Property(e => e.PartCode)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.PartName).HasMaxLength(64);

                entity.Property(e => e.Price).HasColumnType("numeric(20, 6)");

                entity.Property(e => e.ReasonGuid)
                    .HasColumnName("ReasonGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.RelaGuid)
                    .HasColumnName("RelaGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.RelaType).HasMaxLength(64);

                entity.Property(e => e.StkAccCodeSource)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.StkAccCodeTarget)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.StkHisGuid)
                    .IsRequired()
                    .HasColumnName("StkHisGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.ToolFlag).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgStockHisSum>(entity =>
            {
                entity.HasKey(e => new { e.Ym, e.StkAccCode, e.PartCode });

                entity.ToTable("ibg_StockHisSum");

                entity.HasIndex(e => e.PartCode);

                entity.Property(e => e.Ym)
                    .HasColumnName("YM")
                    .HasColumnType("datetime");

                entity.Property(e => e.StkAccCode).HasMaxLength(64);

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.StkQtyMend).HasColumnName("StkQtyMEnd");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgStockHisSum4D>(entity =>
            {
                entity.HasKey(e => new { e.Ym, e.StkAccCodeSource, e.StkAccCodeTarget, e.PartCode });

                entity.ToTable("ibg_StockHisSum4D");

                entity.HasIndex(e => e.PartCode);

                entity.Property(e => e.Ym)
                    .HasColumnName("YM")
                    .HasColumnType("datetime");

                entity.Property(e => e.StkAccCodeSource).HasMaxLength(64);

                entity.Property(e => e.StkAccCodeTarget).HasMaxLength(64);

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgStockHisSum4DBak20170505>(entity =>
            {
                entity.HasKey(e => new { e.Ym, e.StkAccCodeSource, e.StkAccCodeTarget, e.PartCode });

                entity.ToTable("ibg_StockHisSum4D_bak20170505");

                entity.Property(e => e.Ym)
                    .HasColumnName("YM")
                    .HasColumnType("datetime");

                entity.Property(e => e.StkAccCodeSource).HasMaxLength(64);

                entity.Property(e => e.StkAccCodeTarget).HasMaxLength(64);

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgStockHisSum4DBak20170929>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ibg_StockHisSum4D_bak20170929");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.PartCode)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.StkAccCodeSource)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.StkAccCodeTarget)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);

                entity.Property(e => e.Ym)
                    .HasColumnName("YM")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<IbgStockHisSumBak20161101>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ibg_StockHisSum_bak20161101");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.PartCode)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.StkAccCode)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.StkQtyMend).HasColumnName("StkQtyMEnd");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);

                entity.Property(e => e.Ym)
                    .HasColumnName("YM")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<IbgStockHisSumBak20170505>(entity =>
            {
                entity.HasKey(e => new { e.Ym, e.StkAccCode, e.PartCode });

                entity.ToTable("ibg_StockHisSum_bak20170505");

                entity.Property(e => e.Ym)
                    .HasColumnName("YM")
                    .HasColumnType("datetime");

                entity.Property(e => e.StkAccCode).HasMaxLength(64);

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.StkQtyMend).HasColumnName("StkQtyMEnd");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgStockHisSumBak20170929>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ibg_StockHisSum_bak20170929");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.PartCode)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.StkAccCode)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.StkQtyMend).HasColumnName("StkQtyMEnd");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);

                entity.Property(e => e.Ym)
                    .HasColumnName("YM")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<IbgStockHisTmp20191031>(entity =>
            {
                entity.HasKey(e => new { e.StkAccCodeSource, e.StkAccCodeTarget, e.PartCode, e.StkHisGuid });

                entity.ToTable("ibg_StockHis_tmp20191031");

                entity.Property(e => e.StkAccCodeSource).HasMaxLength(64);

                entity.Property(e => e.StkAccCodeTarget).HasMaxLength(64);

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.StkHisGuid)
                    .HasColumnName("StkHisGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.MoveDate).HasColumnType("datetime");

                entity.Property(e => e.OperationId)
                    .HasColumnName("OperationID")
                    .HasMaxLength(64);

                entity.Property(e => e.ReasonGuid)
                    .HasColumnName("ReasonGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.RelaGuid)
                    .HasColumnName("RelaGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.RelaType).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgStockTakingList>(entity =>
            {
                entity.HasKey(e => new { e.StkAccCode, e.PartCode });

                entity.ToTable("ibg_StockTakingList");

                entity.HasIndex(e => e.PartCode);

                entity.Property(e => e.StkAccCode).HasMaxLength(64);

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.ReasonGuid)
                    .HasColumnName("ReasonGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgStockTmp20191031>(entity =>
            {
                entity.HasKey(e => new { e.StkAccCode, e.PartCode });

                entity.ToTable("ibg_Stock_tmp20191031");

                entity.Property(e => e.StkAccCode).HasMaxLength(64);

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgStolenProd>(entity =>
            {
                entity.HasKey(e => new { e.ProdCode, e.ProdSn })
                    .HasName("PK_ibg_StolenItem");

                entity.ToTable("ibg_StolenProd");

                entity.Property(e => e.ProdCode).HasMaxLength(64);

                entity.Property(e => e.ProdSn)
                    .HasColumnName("ProdSN")
                    .HasMaxLength(64);

                entity.Property(e => e.ApplicantName).HasMaxLength(4000);

                entity.Property(e => e.ApplicantType).HasMaxLength(64);

                entity.Property(e => e.BranCode).HasMaxLength(64);

                entity.Property(e => e.Comment).HasMaxLength(4000);

                entity.Property(e => e.ContactTel).HasMaxLength(4000);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.DeleteComment).HasMaxLength(4000);

                entity.Property(e => e.DeleteFlag).HasMaxLength(64);

                entity.Property(e => e.OptNo).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.StaffCode).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgSupply>(entity =>
            {
                entity.HasKey(e => new { e.StkAccCode, e.PartCode });

                entity.ToTable("ibg_Supply");

                entity.HasIndex(e => e.PartCode);

                entity.Property(e => e.StkAccCode).HasMaxLength(64);

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgSupply20190321>(entity =>
            {
                entity.HasKey(e => new { e.StkAccCode, e.PartCode });

                entity.ToTable("ibg_Supply_20190321");

                entity.Property(e => e.StkAccCode).HasMaxLength(64);

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgSupplyHis>(entity =>
            {
                entity.HasKey(e => new { e.SuplHisGuid, e.StkAccCode, e.PartCode });

                entity.ToTable("ibg_SupplyHis");

                entity.HasIndex(e => e.ChangeDate);

                entity.HasIndex(e => e.PartCode);

                entity.Property(e => e.SuplHisGuid)
                    .HasColumnName("SuplHisGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.StkAccCode).HasMaxLength(64);

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.ChangeDate).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.OperationId)
                    .HasColumnName("OperationID")
                    .HasMaxLength(64);

                entity.Property(e => e.ReasonGuid)
                    .HasColumnName("ReasonGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.RelaGuid)
                    .HasColumnName("RelaGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.RelaType).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgSupplyHis20190321>(entity =>
            {
                entity.HasKey(e => new { e.SuplHisGuid, e.StkAccCode, e.PartCode });

                entity.ToTable("ibg_SupplyHis_20190321");

                entity.Property(e => e.SuplHisGuid)
                    .HasColumnName("SuplHisGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.StkAccCode).HasMaxLength(64);

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.ChangeDate).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.OperationId)
                    .HasColumnName("OperationID")
                    .HasMaxLength(64);

                entity.Property(e => e.ReasonGuid)
                    .HasColumnName("ReasonGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.RelaGuid)
                    .HasColumnName("RelaGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.RelaType).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgTask>(entity =>
            {
                entity.HasKey(e => e.TaskCode);

                entity.ToTable("ibg_Task");

                entity.Property(e => e.TaskCode).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.ProgramId)
                    .HasColumnName("ProgramID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.SortKey).HasMaxLength(64);

                entity.Property(e => e.TaskCodeParent).HasMaxLength(64);

                entity.Property(e => e.Title).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgTaxPolicyParameter>(entity =>
            {
                entity.HasKey(e => new { e.ISoulOperationProcessingId, e.ParameterId });

                entity.ToTable("ibg_TaxPolicyParameter");

                entity.Property(e => e.ISoulOperationProcessingId)
                    .HasColumnName("iSoulOperationProcessingID")
                    .HasMaxLength(64);

                entity.Property(e => e.ParameterId)
                    .HasColumnName("ParameterID")
                    .HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgTestResult>(entity =>
            {
                entity.HasKey(e => new { e.TestResultGuid, e.RcptGuid });

                entity.ToTable("ibg_TestResult");

                entity.HasIndex(e => e.RcptGuid);

                entity.Property(e => e.TestResultGuid)
                    .HasColumnName("TestResultGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.RcptGuid)
                    .HasColumnName("RcptGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.TroublePhenomenonCode).HasMaxLength(64);

                entity.Property(e => e.TroubleReasonCode).HasMaxLength(64);

                entity.Property(e => e.TroubleSpotCode).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgTmpRptServiceStatusAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ibg_TmpRptServiceStatusALL");

                entity.Property(e => e.BranCode)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.BranName)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.DateFm)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateTo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExportDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExportUnit)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastServicingTtl).HasColumnName("LastServicingTTL");

                entity.Property(e => e.ThisHandlingTtl).HasColumnName("ThisHandlingTTL");

                entity.Property(e => e.ThisReceiptSelfTtl).HasColumnName("ThisReceiptSelfTTL");

                entity.Property(e => e.ThisReceiptTtl).HasColumnName("ThisReceiptTTL");

                entity.Property(e => e.ThisRepairFinishedTtl).HasColumnName("ThisRepairFinishedTTL");

                entity.Property(e => e.ThisReturnTtl).HasColumnName("ThisReturnTTL");

                entity.Property(e => e.ThisServicingTtl).HasColumnName("ThisServicingTTL");

                entity.Property(e => e.ThisSr).HasColumnName("ThisSR");

                entity.Property(e => e.WarrantyPeriodBeforeSale).HasColumnName("WarrantyPeriod_BeforeSale");

                entity.Property(e => e.WarrantyPeriodIn).HasColumnName("WarrantyPeriod_In");

                entity.Property(e => e.WarrantyPeriodNotIn).HasColumnName("WarrantyPeriod_NotIn");
            });

            modelBuilder.Entity<IbgTmpRptServiceStatusAll201506>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ibg_TmpRptServiceStatusALL201506");

                entity.Property(e => e.BranCode)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.BranName)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.DateFm)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateTo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExportDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExportUnit)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastServicingTtl).HasColumnName("LastServicingTTL");

                entity.Property(e => e.ThisHandlingTtl).HasColumnName("ThisHandlingTTL");

                entity.Property(e => e.ThisReceiptSelfTtl).HasColumnName("ThisReceiptSelfTTL");

                entity.Property(e => e.ThisReceiptTtl).HasColumnName("ThisReceiptTTL");

                entity.Property(e => e.ThisRepairFinishedTtl).HasColumnName("ThisRepairFinishedTTL");

                entity.Property(e => e.ThisReturnTtl).HasColumnName("ThisReturnTTL");

                entity.Property(e => e.ThisServicingTtl).HasColumnName("ThisServicingTTL");

                entity.Property(e => e.ThisSr).HasColumnName("ThisSR");

                entity.Property(e => e.WarrantyPeriodBeforeSale).HasColumnName("WarrantyPeriod_BeforeSale");

                entity.Property(e => e.WarrantyPeriodExtended).HasColumnName("WarrantyPeriod_Extended");

                entity.Property(e => e.WarrantyPeriodIn).HasColumnName("WarrantyPeriod_In");

                entity.Property(e => e.WarrantyPeriodNotIn).HasColumnName("WarrantyPeriod_NotIn");
            });

            modelBuilder.Entity<IbgTrade>(entity =>
            {
                entity.HasKey(e => new { e.ComCodeSale, e.ComCodeBuy, e.AvailFmDate });

                entity.ToTable("ibg_Trade");

                entity.HasIndex(e => e.TradeGuid)
                    .HasName("UK_ibg_Trade_TradeGUID")
                    .IsUnique();

                entity.Property(e => e.ComCodeSale).HasMaxLength(64);

                entity.Property(e => e.ComCodeBuy).HasMaxLength(64);

                entity.Property(e => e.AvailFmDate).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.ExistFlag).HasMaxLength(64);

                entity.Property(e => e.OddHandlingType).HasMaxLength(64);

                entity.Property(e => e.PriceRate).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.PriceType).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.TradeGuid)
                    .HasColumnName("TradeGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgTroublePhenomenon>(entity =>
            {
                entity.HasKey(e => e.TroublePhenomenonCode);

                entity.ToTable("ibg_TroublePhenomenon");

                entity.Property(e => e.TroublePhenomenonCode).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.FullName).HasMaxLength(4000);

                entity.Property(e => e.FullNameChn)
                    .HasColumnName("FullNameCHN")
                    .HasMaxLength(4000);

                entity.Property(e => e.FullNameJpn)
                    .HasColumnName("FullNameJPN")
                    .HasMaxLength(4000);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.ShortName).HasMaxLength(4000);

                entity.Property(e => e.ShortNameChn)
                    .HasColumnName("ShortNameCHN")
                    .HasMaxLength(4000);

                entity.Property(e => e.ShortNameJpn)
                    .HasColumnName("ShortNameJPN")
                    .HasMaxLength(4000);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgTroublePhenomenonBak>(entity =>
            {
                entity.HasKey(e => e.TroublePhenomenonCode);

                entity.ToTable("ibg_TroublePhenomenon_bak");

                entity.Property(e => e.TroublePhenomenonCode).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.FullName).HasMaxLength(4000);

                entity.Property(e => e.FullNameChn)
                    .HasColumnName("FullNameCHN")
                    .HasMaxLength(4000);

                entity.Property(e => e.FullNameJpn)
                    .HasColumnName("FullNameJPN")
                    .HasMaxLength(4000);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.ShortName).HasMaxLength(4000);

                entity.Property(e => e.ShortNameChn)
                    .HasColumnName("ShortNameCHN")
                    .HasMaxLength(4000);

                entity.Property(e => e.ShortNameJpn)
                    .HasColumnName("ShortNameJPN")
                    .HasMaxLength(4000);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgTroublePhenomenonBak201711130006>(entity =>
            {
                entity.HasKey(e => e.TroublePhenomenonCode);

                entity.ToTable("ibg_TroublePhenomenon_bak201711130006");

                entity.Property(e => e.TroublePhenomenonCode).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.FullName).HasMaxLength(4000);

                entity.Property(e => e.FullNameChn)
                    .HasColumnName("FullNameCHN")
                    .HasMaxLength(4000);

                entity.Property(e => e.FullNameJpn)
                    .HasColumnName("FullNameJPN")
                    .HasMaxLength(4000);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.ShortName).HasMaxLength(4000);

                entity.Property(e => e.ShortNameChn)
                    .HasColumnName("ShortNameCHN")
                    .HasMaxLength(4000);

                entity.Property(e => e.ShortNameJpn)
                    .HasColumnName("ShortNameJPN")
                    .HasMaxLength(4000);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgTroublePhenomenonEx>(entity =>
            {
                entity.HasKey(e => new { e.OrgLevel, e.OrgCode, e.PheExGuid });

                entity.ToTable("ibg_TroublePhenomenonEx");

                entity.Property(e => e.OrgLevel).HasMaxLength(64);

                entity.Property(e => e.OrgCode).HasMaxLength(64);

                entity.Property(e => e.PheExGuid)
                    .HasColumnName("PheExGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.SortKey).HasMaxLength(64);

                entity.Property(e => e.TroublePhenomenonEx).HasMaxLength(4000);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgTroubleReason>(entity =>
            {
                entity.HasKey(e => e.TroubleReasonCode);

                entity.ToTable("ibg_TroubleReason");

                entity.Property(e => e.TroubleReasonCode).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.FullName).HasMaxLength(4000);

                entity.Property(e => e.FullNameChn)
                    .HasColumnName("FullNameCHN")
                    .HasMaxLength(4000);

                entity.Property(e => e.FullNameJpn)
                    .HasColumnName("FullNameJPN")
                    .HasMaxLength(4000);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.ShortName).HasMaxLength(4000);

                entity.Property(e => e.ShortNameChn)
                    .HasColumnName("ShortNameCHN")
                    .HasMaxLength(4000);

                entity.Property(e => e.ShortNameJpn)
                    .HasColumnName("ShortNameJPN")
                    .HasMaxLength(4000);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgTroubleReasonBak>(entity =>
            {
                entity.HasKey(e => e.TroubleReasonCode);

                entity.ToTable("ibg_TroubleReason_bak");

                entity.Property(e => e.TroubleReasonCode).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.FullName).HasMaxLength(4000);

                entity.Property(e => e.FullNameChn)
                    .HasColumnName("FullNameCHN")
                    .HasMaxLength(4000);

                entity.Property(e => e.FullNameJpn)
                    .HasColumnName("FullNameJPN")
                    .HasMaxLength(4000);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.ShortName).HasMaxLength(4000);

                entity.Property(e => e.ShortNameChn)
                    .HasColumnName("ShortNameCHN")
                    .HasMaxLength(4000);

                entity.Property(e => e.ShortNameJpn)
                    .HasColumnName("ShortNameJPN")
                    .HasMaxLength(4000);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgTroubleRelation>(entity =>
            {
                entity.HasKey(e => new { e.RelationType, e.CodeLeft, e.CodeRight });

                entity.ToTable("ibg_TroubleRelation");

                entity.Property(e => e.RelationType).HasMaxLength(64);

                entity.Property(e => e.CodeLeft).HasMaxLength(64);

                entity.Property(e => e.CodeRight).HasMaxLength(64);

                entity.Property(e => e.Comment).HasMaxLength(4000);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgTroubleRelationBak201711130006>(entity =>
            {
                entity.HasKey(e => new { e.RelationType, e.CodeLeft, e.CodeRight });

                entity.ToTable("ibg_TroubleRelation_bak201711130006");

                entity.Property(e => e.RelationType).HasMaxLength(64);

                entity.Property(e => e.CodeLeft).HasMaxLength(64);

                entity.Property(e => e.CodeRight).HasMaxLength(64);

                entity.Property(e => e.Comment).HasMaxLength(4000);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgTroubleSolution>(entity =>
            {
                entity.HasKey(e => e.TroubleSolutionCode);

                entity.ToTable("ibg_TroubleSolution");

                entity.Property(e => e.TroubleSolutionCode).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.FullName).HasMaxLength(4000);

                entity.Property(e => e.FullNameChn)
                    .HasColumnName("FullNameCHN")
                    .HasMaxLength(4000);

                entity.Property(e => e.FullNameJpn)
                    .HasColumnName("FullNameJPN")
                    .HasMaxLength(4000);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.ShortName).HasMaxLength(4000);

                entity.Property(e => e.ShortNameChn)
                    .HasColumnName("ShortNameCHN")
                    .HasMaxLength(4000);

                entity.Property(e => e.ShortNameJpn)
                    .HasColumnName("ShortNameJPN")
                    .HasMaxLength(4000);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgTroubleSpot>(entity =>
            {
                entity.HasKey(e => e.TroubleSpotCode);

                entity.ToTable("ibg_TroubleSpot");

                entity.Property(e => e.TroubleSpotCode).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.FullName).HasMaxLength(4000);

                entity.Property(e => e.FullNameChn)
                    .HasColumnName("FullNameCHN")
                    .HasMaxLength(4000);

                entity.Property(e => e.FullNameJpn)
                    .HasColumnName("FullNameJPN")
                    .HasMaxLength(4000);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.ShortName).HasMaxLength(4000);

                entity.Property(e => e.ShortNameChn)
                    .HasColumnName("ShortNameCHN")
                    .HasMaxLength(4000);

                entity.Property(e => e.ShortNameJpn)
                    .HasColumnName("ShortNameJPN")
                    .HasMaxLength(4000);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgTroubleSpotBak>(entity =>
            {
                entity.HasKey(e => e.TroubleSpotCode);

                entity.ToTable("ibg_TroubleSpot_bak");

                entity.Property(e => e.TroubleSpotCode).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.FullName).HasMaxLength(4000);

                entity.Property(e => e.FullNameChn)
                    .HasColumnName("FullNameCHN")
                    .HasMaxLength(4000);

                entity.Property(e => e.FullNameJpn)
                    .HasColumnName("FullNameJPN")
                    .HasMaxLength(4000);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.ShortName).HasMaxLength(4000);

                entity.Property(e => e.ShortNameChn)
                    .HasColumnName("ShortNameCHN")
                    .HasMaxLength(4000);

                entity.Property(e => e.ShortNameJpn)
                    .HasColumnName("ShortNameJPN")
                    .HasMaxLength(4000);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgTroubleSpotBak201711130006>(entity =>
            {
                entity.HasKey(e => e.TroubleSpotCode);

                entity.ToTable("ibg_TroubleSpot_bak201711130006");

                entity.Property(e => e.TroubleSpotCode).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.FullName).HasMaxLength(4000);

                entity.Property(e => e.FullNameChn)
                    .HasColumnName("FullNameCHN")
                    .HasMaxLength(4000);

                entity.Property(e => e.FullNameJpn)
                    .HasColumnName("FullNameJPN")
                    .HasMaxLength(4000);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.ShortName).HasMaxLength(4000);

                entity.Property(e => e.ShortNameChn)
                    .HasColumnName("ShortNameCHN")
                    .HasMaxLength(4000);

                entity.Property(e => e.ShortNameJpn)
                    .HasColumnName("ShortNameJPN")
                    .HasMaxLength(4000);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgTroubleType>(entity =>
            {
                entity.HasKey(e => e.TroubleTypeGuid);

                entity.ToTable("ibg_TroubleType");

                entity.Property(e => e.TroubleTypeGuid)
                    .HasColumnName("TroubleTypeGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.FullName).HasMaxLength(4000);

                entity.Property(e => e.FullNameChn)
                    .HasColumnName("FullNameCHN")
                    .HasMaxLength(4000);

                entity.Property(e => e.FullNameJpn)
                    .HasColumnName("FullNameJPN")
                    .HasMaxLength(4000);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.ShortName).HasMaxLength(4000);

                entity.Property(e => e.ShortNameChn)
                    .HasColumnName("ShortNameCHN")
                    .HasMaxLength(4000);

                entity.Property(e => e.ShortNameJpn)
                    .HasColumnName("ShortNameJPN")
                    .HasMaxLength(4000);

                entity.Property(e => e.TroubleTypeType).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgWoactionD>(entity =>
            {
                entity.HasKey(e => new { e.WoactGuidd, e.WoactGuid, e.PartCode });

                entity.ToTable("ibg_WOActionD");

                entity.HasIndex(e => e.PartCode);

                entity.HasIndex(e => e.WoactGuid);

                entity.Property(e => e.WoactGuidd)
                    .HasColumnName("WOActGUIDD")
                    .HasMaxLength(64);

                entity.Property(e => e.WoactGuid)
                    .HasColumnName("WOActGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.LotNo).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgWoactionD20190321>(entity =>
            {
                entity.HasKey(e => new { e.WoactGuidd, e.WoactGuid, e.PartCode });

                entity.ToTable("ibg_WOActionD_20190321");

                entity.Property(e => e.WoactGuidd)
                    .HasColumnName("WOActGUIDD")
                    .HasMaxLength(64);

                entity.Property(e => e.WoactGuid)
                    .HasColumnName("WOActGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.LotNo).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgWoactionH>(entity =>
            {
                entity.HasKey(e => new { e.WoactGuid, e.Woguid, e.StkAccCodeSource, e.StkAccCodeTarget });

                entity.ToTable("ibg_WOActionH");

                entity.HasIndex(e => e.WoactGuid);

                entity.HasIndex(e => e.Woguid);

                entity.Property(e => e.WoactGuid)
                    .HasColumnName("WOActGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.Woguid)
                    .HasColumnName("WOGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.StkAccCodeSource).HasMaxLength(64);

                entity.Property(e => e.StkAccCodeTarget).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.ExeDate).HasColumnType("datetime");

                entity.Property(e => e.Executor).HasMaxLength(64);

                entity.Property(e => e.IssueDate).HasColumnType("datetime");

                entity.Property(e => e.IssuePerson).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.StaUpdator).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);

                entity.Property(e => e.WoactGuidnext)
                    .HasColumnName("WOActGUIDNext")
                    .HasMaxLength(64);

                entity.Property(e => e.WoactSta)
                    .HasColumnName("WOActSta")
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<IbgWoactionH20190321>(entity =>
            {
                entity.HasKey(e => new { e.WoactGuid, e.Woguid, e.StkAccCodeSource, e.StkAccCodeTarget });

                entity.ToTable("ibg_WOActionH_20190321");

                entity.Property(e => e.WoactGuid)
                    .HasColumnName("WOActGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.Woguid)
                    .HasColumnName("WOGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.StkAccCodeSource).HasMaxLength(64);

                entity.Property(e => e.StkAccCodeTarget).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.ExeDate).HasColumnType("datetime");

                entity.Property(e => e.Executor).HasMaxLength(64);

                entity.Property(e => e.IssueDate).HasColumnType("datetime");

                entity.Property(e => e.IssuePerson).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.StaUpdator).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);

                entity.Property(e => e.WoactGuidnext)
                    .HasColumnName("WOActGUIDNext")
                    .HasMaxLength(64);

                entity.Property(e => e.WoactSta)
                    .HasColumnName("WOActSta")
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<IbgWod>(entity =>
            {
                entity.HasKey(e => new { e.Woguidd, e.Woguid, e.PartCode });

                entity.ToTable("ibg_WOD");

                entity.HasIndex(e => e.PartCode);

                entity.HasIndex(e => e.RelaGuid);

                entity.HasIndex(e => e.Woguid);

                entity.Property(e => e.Woguidd)
                    .HasColumnName("WOGUIDD")
                    .HasMaxLength(64);

                entity.Property(e => e.Woguid)
                    .HasColumnName("WOGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.RelaGuid)
                    .HasColumnName("RelaGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.RelaType).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgWod20190321>(entity =>
            {
                entity.HasKey(e => new { e.Woguidd, e.Woguid, e.PartCode });

                entity.ToTable("ibg_WOD_20190321");

                entity.Property(e => e.Woguidd)
                    .HasColumnName("WOGUIDD")
                    .HasMaxLength(64);

                entity.Property(e => e.Woguid)
                    .HasColumnName("WOGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.RelaGuid)
                    .HasColumnName("RelaGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.RelaType).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgWodate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ibg_WODate");

                entity.Property(e => e.Wodate)
                    .HasColumnName("WODate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Woguid)
                    .IsRequired()
                    .HasColumnName("WOGUID")
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<IbgWoh>(entity =>
            {
                entity.HasKey(e => new { e.Woguid, e.StkAccCodeSource, e.StkAccCodeTarget });

                entity.ToTable("ibg_WOH");

                entity.HasIndex(e => e.Woguid);

                entity.HasIndex(e => e.WorelaNo);

                entity.Property(e => e.Woguid)
                    .HasColumnName("WOGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.StkAccCodeSource).HasMaxLength(64);

                entity.Property(e => e.StkAccCodeTarget).HasMaxLength(64);

                entity.Property(e => e.AvailableFlag).HasMaxLength(64);

                entity.Property(e => e.Comment).HasMaxLength(4000);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.DisableDate).HasColumnType("datetime");

                entity.Property(e => e.DisableUpdator).HasMaxLength(64);

                entity.Property(e => e.IssueDate).HasColumnType("datetime");

                entity.Property(e => e.IssuePerson).HasMaxLength(64);

                entity.Property(e => e.PartInfoConfirm).HasMaxLength(64);

                entity.Property(e => e.PfmConfirm).HasMaxLength(64);

                entity.Property(e => e.ReasonGuid)
                    .HasColumnName("ReasonGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.Rpcno)
                    .HasColumnName("RPCNo")
                    .HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);

                entity.Property(e => e.WorelaNo)
                    .HasColumnName("WORelaNo")
                    .HasMaxLength(64);

                entity.Property(e => e.Wotype)
                    .HasColumnName("WOType")
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<IbgWoh20190321>(entity =>
            {
                entity.HasKey(e => new { e.Woguid, e.StkAccCodeSource, e.StkAccCodeTarget });

                entity.ToTable("ibg_WOH_20190321");

                entity.Property(e => e.Woguid)
                    .HasColumnName("WOGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.StkAccCodeSource).HasMaxLength(64);

                entity.Property(e => e.StkAccCodeTarget).HasMaxLength(64);

                entity.Property(e => e.AvailableFlag).HasMaxLength(64);

                entity.Property(e => e.Comment).HasMaxLength(4000);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.DisableDate).HasColumnType("datetime");

                entity.Property(e => e.DisableUpdator).HasMaxLength(64);

                entity.Property(e => e.IssueDate).HasColumnType("datetime");

                entity.Property(e => e.IssuePerson).HasMaxLength(64);

                entity.Property(e => e.PartInfoConfirm).HasMaxLength(64);

                entity.Property(e => e.PfmConfirm).HasMaxLength(64);

                entity.Property(e => e.ReasonGuid)
                    .HasColumnName("ReasonGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.Rpcno)
                    .HasColumnName("RPCNo")
                    .HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);

                entity.Property(e => e.WorelaNo)
                    .HasColumnName("WORelaNo")
                    .HasMaxLength(64);

                entity.Property(e => e.Wotype)
                    .HasColumnName("WOType")
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<IbgWorelation>(entity =>
            {
                entity.HasKey(e => new { e.StkAccCodeSource, e.StkAccCodeTarget });

                entity.ToTable("ibg_WORelation");

                entity.HasIndex(e => e.WorelaGuid)
                    .HasName("UK_ibg_WORelation_WORelaGUID")
                    .IsUnique();

                entity.Property(e => e.StkAccCodeSource).HasMaxLength(64);

                entity.Property(e => e.StkAccCodeTarget).HasMaxLength(64);

                entity.Property(e => e.BranCodeMaintain).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);

                entity.Property(e => e.WorelaGuid)
                    .HasColumnName("WORelaGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.Wotype)
                    .HasColumnName("WOType")
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<IbgWorelationAction>(entity =>
            {
                entity.HasKey(e => new { e.WorelaGuid, e.StkAccCodeSource, e.StkAccCodeTarget });

                entity.ToTable("ibg_WORelationAction");

                entity.HasIndex(e => e.WorelaActGuid)
                    .HasName("UK_ibg_WORelationAction")
                    .IsUnique();

                entity.Property(e => e.WorelaGuid)
                    .HasColumnName("WORelaGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.StkAccCodeSource).HasMaxLength(64);

                entity.Property(e => e.StkAccCodeTarget).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);

                entity.Property(e => e.WoactOrder)
                    .HasColumnName("WOActOrder")
                    .HasMaxLength(64);

                entity.Property(e => e.WorelaActGuid)
                    .HasColumnName("WORelaActGUID")
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<IbgWork4Bolist>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ibg_Work4BOList");

                entity.Property(e => e.Bldate)
                    .HasColumnName("BLDate")
                    .IsUnicode(false);

                entity.Property(e => e.BranCodeSvap)
                    .HasColumnName("BranCodeSVAP")
                    .IsUnicode(false);

                entity.Property(e => e.BranName).IsUnicode(false);

                entity.Property(e => e.CateType).IsUnicode(false);

                entity.Property(e => e.Category).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.PartCode).IsUnicode(false);

                entity.Property(e => e.PartName).IsUnicode(false);

                entity.Property(e => e.PartNo).IsUnicode(false);

                entity.Property(e => e.Poboqty)
                    .HasColumnName("POBOQty")
                    .IsUnicode(false);

                entity.Property(e => e.PodateNew)
                    .HasColumnName("PODateNew")
                    .IsUnicode(false);

                entity.Property(e => e.PodateOld)
                    .HasColumnName("PODateOld")
                    .IsUnicode(false);

                entity.Property(e => e.PriceCost).IsUnicode(false);

                entity.Property(e => e.PriceHs)
                    .HasColumnName("PriceHS")
                    .IsUnicode(false);

                entity.Property(e => e.ProdCode).IsUnicode(false);

                entity.Property(e => e.ProdName).IsUnicode(false);

                entity.Property(e => e.Rpcno)
                    .HasColumnName("RPCNo")
                    .IsUnicode(false);

                entity.Property(e => e.Soboqty)
                    .HasColumnName("SOBOQty")
                    .IsUnicode(false);

                entity.Property(e => e.Sodate)
                    .HasColumnName("SODate")
                    .IsUnicode(false);

                entity.Property(e => e.Sono)
                    .HasColumnName("SONo")
                    .IsUnicode(false);

                entity.Property(e => e.SonoNpcs)
                    .HasColumnName("SONoNPCS")
                    .IsUnicode(false);

                entity.Property(e => e.SuplQtyPc)
                    .HasColumnName("SuplQtyPC")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IbgWork4ExcIn>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ibg_Work4ExcIn");

                entity.Property(e => e.Addr)
                    .HasColumnName("ADDR")
                    .HasMaxLength(640);

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Outno)
                    .HasColumnName("OUTNO")
                    .HasMaxLength(64);

                entity.Property(e => e.Pc)
                    .HasColumnName("PC")
                    .HasMaxLength(64);

                entity.Property(e => e.Qty).HasColumnName("QTY");

                entity.Property(e => e.RequestId)
                    .HasColumnName("RequestID")
                    .HasMaxLength(64);

                entity.Property(e => e.Stf)
                    .HasColumnName("STF")
                    .HasMaxLength(64);

                entity.Property(e => e.Stid)
                    .HasColumnName("STID")
                    .HasMaxLength(64);

                entity.Property(e => e.Whfm)
                    .HasColumnName("WHFM")
                    .HasMaxLength(64);

                entity.Property(e => e.Whto)
                    .HasColumnName("WHTO")
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<IbgWork4ExcOut>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ibg_Work4ExcOut");

                entity.Property(e => e.Addr)
                    .HasColumnName("ADDR")
                    .HasMaxLength(640);

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Outno)
                    .HasColumnName("OUTNO")
                    .HasMaxLength(64);

                entity.Property(e => e.Pc)
                    .HasColumnName("PC")
                    .HasMaxLength(64);

                entity.Property(e => e.Qty).HasColumnName("QTY");

                entity.Property(e => e.RequestId)
                    .HasColumnName("RequestID")
                    .HasMaxLength(64);

                entity.Property(e => e.Stf)
                    .HasColumnName("STF")
                    .HasMaxLength(64);

                entity.Property(e => e.Stid)
                    .HasColumnName("STID")
                    .HasMaxLength(64);

                entity.Property(e => e.Whfm)
                    .HasColumnName("WHFM")
                    .HasMaxLength(64);

                entity.Property(e => e.Whto)
                    .HasColumnName("WHTO")
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<IbgWork4ExcOutInFailureResponse>(entity =>
            {
                entity.HasKey(e => new { e.Stid, e.Stf })
                    .HasName("PK_TEMP_SAPSTInstockFailureResponse");

                entity.ToTable("ibg_Work4ExcOutInFailureResponse");

                entity.Property(e => e.Stid)
                    .HasColumnName("STID")
                    .HasMaxLength(64);

                entity.Property(e => e.Stf)
                    .HasColumnName("STF")
                    .HasMaxLength(64);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Creator)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(N'System')");

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.RecordVersion)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Updator)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(N'System')");
            });

            modelBuilder.Entity<IbgWork4ExcOutInFailureResponseHis>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ibg_Work4ExcOutInFailureResponseHis");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Creator)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(N'System')");

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.RecordVersion)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.RequestId)
                    .HasColumnName("RequestID")
                    .HasMaxLength(64);

                entity.Property(e => e.Stf)
                    .IsRequired()
                    .HasColumnName("STF")
                    .HasMaxLength(64);

                entity.Property(e => e.Stid)
                    .IsRequired()
                    .HasColumnName("STID")
                    .HasMaxLength(64);

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Updator)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(N'System')");
            });

            modelBuilder.Entity<IbgWork4ExcOutInHis>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ibg_Work4ExcOutInHis");

                entity.Property(e => e.Addr)
                    .HasColumnName("ADDR")
                    .HasMaxLength(640);

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Outno)
                    .HasColumnName("OUTNO")
                    .HasMaxLength(64);

                entity.Property(e => e.Pc)
                    .HasColumnName("PC")
                    .HasMaxLength(64);

                entity.Property(e => e.Qty).HasColumnName("QTY");

                entity.Property(e => e.RequestId)
                    .HasColumnName("RequestID")
                    .HasMaxLength(64);

                entity.Property(e => e.Stf)
                    .HasColumnName("STF")
                    .HasMaxLength(64);

                entity.Property(e => e.Stid)
                    .HasColumnName("STID")
                    .HasMaxLength(64);

                entity.Property(e => e.Whfm)
                    .HasColumnName("WHFM")
                    .HasMaxLength(64);

                entity.Property(e => e.Whto)
                    .HasColumnName("WHTO")
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<IbgWork4ExcOutInSuccessResponse>(entity =>
            {
                entity.HasKey(e => new { e.Stid, e.Stf })
                    .HasName("PK_TEMP_SAPSTInstockSuccessResponse");

                entity.ToTable("ibg_Work4ExcOutInSuccessResponse");

                entity.Property(e => e.Stid)
                    .HasColumnName("STID")
                    .HasMaxLength(64);

                entity.Property(e => e.Stf)
                    .HasColumnName("STF")
                    .HasMaxLength(64);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Creator)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(N'System')");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasColumnName("DATE")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.RecordVersion)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Sapdo)
                    .HasColumnName("SAPDO")
                    .HasMaxLength(64);

                entity.Property(e => e.Sapso)
                    .HasColumnName("SAPSO")
                    .HasMaxLength(64);

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Updator)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(N'System')");
            });

            modelBuilder.Entity<IbgWork4ExcOutInSuccessResponseHis>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ibg_Work4ExcOutInSuccessResponseHis");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Creator)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(N'System')");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasColumnName("DATE")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.RecordVersion)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.RequestId)
                    .HasColumnName("RequestID")
                    .HasMaxLength(64);

                entity.Property(e => e.Sapdo)
                    .HasColumnName("SAPDO")
                    .HasMaxLength(64);

                entity.Property(e => e.Sapso)
                    .HasColumnName("SAPSO")
                    .HasMaxLength(64);

                entity.Property(e => e.Stf)
                    .IsRequired()
                    .HasColumnName("STF")
                    .HasMaxLength(64);

                entity.Property(e => e.Stid)
                    .IsRequired()
                    .HasColumnName("STID")
                    .HasMaxLength(64);

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Updator)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(N'System')");
            });

            modelBuilder.Entity<IbgWork4H85>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ibg_Work4H85");

                entity.Property(e => e.BranCodeService)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CateCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CurrencyType)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CustomerCode)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CustomerType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DataType)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DeliveryTime)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DisRepairReason)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DiscountAmt)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ediservcode)
                    .HasColumnName("EDISERVCode")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ExchangeReason)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FileId)
                    .HasColumnName("FileID")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LaborCharge)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OutSoucing)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PartCode1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PartCode10)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PartCode11)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PartCode12)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PartCode13)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PartCode14)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PartCode15)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PartCode2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PartCode3)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PartCode4)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PartCode5)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PartCode6)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PartCode7)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PartCode8)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PartCode9)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PartFee)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProdCode4Sales)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProdName)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProdSn)
                    .HasColumnName("ProdSN")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Qty1)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Qty10)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Qty11)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Qty12)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Qty13)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Qty14)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Qty15)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Qty2)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Qty3)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Qty4)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Qty5)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Qty6)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Qty7)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Qty8)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Qty9)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RcptDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RcptMethod)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RcptNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Rcptor)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ReRepairType)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ReleaseCount)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RepairFinishedDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RepairPerson)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RepairRank)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RepairStartDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RepairTime)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Reverse)
                    .HasMaxLength(26)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Srcomment)
                    .HasColumnName("SRComment")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Srflag)
                    .HasColumnName("SRFlag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TroublePhenomenonCode1)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TroublePhenomenonCode2)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TroublePhenomenonCode3)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TroubleReasonCode1)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TroubleReasonCode2)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TroubleReasonCode3)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TroubleSpotCode1)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TroubleSpotCode2)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TroubleSpotCode3)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdateDate)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WarrantyPeriod)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.YearMonth)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<IbgWork4H85his>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("ibg_Work4H85His");

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.BranCodeService).HasMaxLength(64);

                entity.Property(e => e.CateCode).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CurrencyType).HasMaxLength(64);

                entity.Property(e => e.CustomerCode).HasMaxLength(64);

                entity.Property(e => e.CustomerType).HasMaxLength(64);

                entity.Property(e => e.DataType).HasMaxLength(64);

                entity.Property(e => e.DeliveryTime).HasMaxLength(64);

                entity.Property(e => e.DisRepairReason).HasMaxLength(64);

                entity.Property(e => e.DiscountAmt).HasMaxLength(64);

                entity.Property(e => e.Ediservcode)
                    .HasColumnName("EDISERVCode")
                    .HasMaxLength(64);

                entity.Property(e => e.ExchangeReason).HasMaxLength(64);

                entity.Property(e => e.FileId)
                    .HasColumnName("FileID")
                    .HasMaxLength(64);

                entity.Property(e => e.LaborCharge).HasMaxLength(64);

                entity.Property(e => e.OperationType).HasMaxLength(64);

                entity.Property(e => e.OutSoucing).HasMaxLength(64);

                entity.Property(e => e.PartCode1).HasMaxLength(64);

                entity.Property(e => e.PartCode10).HasMaxLength(64);

                entity.Property(e => e.PartCode11).HasMaxLength(64);

                entity.Property(e => e.PartCode12).HasMaxLength(64);

                entity.Property(e => e.PartCode13).HasMaxLength(64);

                entity.Property(e => e.PartCode14).HasMaxLength(64);

                entity.Property(e => e.PartCode15).HasMaxLength(64);

                entity.Property(e => e.PartCode2).HasMaxLength(64);

                entity.Property(e => e.PartCode3).HasMaxLength(64);

                entity.Property(e => e.PartCode4).HasMaxLength(64);

                entity.Property(e => e.PartCode5).HasMaxLength(64);

                entity.Property(e => e.PartCode6).HasMaxLength(64);

                entity.Property(e => e.PartCode7).HasMaxLength(64);

                entity.Property(e => e.PartCode8).HasMaxLength(64);

                entity.Property(e => e.PartCode9).HasMaxLength(64);

                entity.Property(e => e.PartFee).HasMaxLength(64);

                entity.Property(e => e.ProdCode4Sales).HasMaxLength(64);

                entity.Property(e => e.ProdName).HasMaxLength(64);

                entity.Property(e => e.ProdSn)
                    .HasColumnName("ProdSN")
                    .HasMaxLength(64);

                entity.Property(e => e.Qty1).HasMaxLength(64);

                entity.Property(e => e.Qty10).HasMaxLength(64);

                entity.Property(e => e.Qty11).HasMaxLength(64);

                entity.Property(e => e.Qty12).HasMaxLength(64);

                entity.Property(e => e.Qty13).HasMaxLength(64);

                entity.Property(e => e.Qty14).HasMaxLength(64);

                entity.Property(e => e.Qty15).HasMaxLength(64);

                entity.Property(e => e.Qty2).HasMaxLength(64);

                entity.Property(e => e.Qty3).HasMaxLength(64);

                entity.Property(e => e.Qty4).HasMaxLength(64);

                entity.Property(e => e.Qty5).HasMaxLength(64);

                entity.Property(e => e.Qty6).HasMaxLength(64);

                entity.Property(e => e.Qty7).HasMaxLength(64);

                entity.Property(e => e.Qty8).HasMaxLength(64);

                entity.Property(e => e.Qty9).HasMaxLength(64);

                entity.Property(e => e.RcptDate).HasMaxLength(64);

                entity.Property(e => e.RcptMethod).HasMaxLength(64);

                entity.Property(e => e.RcptNo).HasMaxLength(64);

                entity.Property(e => e.Rcptor).HasMaxLength(64);

                entity.Property(e => e.ReRepairType).HasMaxLength(64);

                entity.Property(e => e.ReleaseCount).HasMaxLength(64);

                entity.Property(e => e.RepairFinishedDate).HasMaxLength(64);

                entity.Property(e => e.RepairPerson).HasMaxLength(64);

                entity.Property(e => e.RepairRank).HasMaxLength(64);

                entity.Property(e => e.RepairStartDate).HasMaxLength(64);

                entity.Property(e => e.RepairTime).HasMaxLength(64);

                entity.Property(e => e.Reverse).HasMaxLength(64);

                entity.Property(e => e.Srcomment)
                    .HasColumnName("SRComment")
                    .HasMaxLength(64);

                entity.Property(e => e.Srflag)
                    .HasColumnName("SRFlag")
                    .HasMaxLength(64);

                entity.Property(e => e.TroublePhenomenonCode1).HasMaxLength(64);

                entity.Property(e => e.TroublePhenomenonCode2).HasMaxLength(64);

                entity.Property(e => e.TroublePhenomenonCode3).HasMaxLength(64);

                entity.Property(e => e.TroubleReasonCode1).HasMaxLength(64);

                entity.Property(e => e.TroubleReasonCode2).HasMaxLength(64);

                entity.Property(e => e.TroubleReasonCode3).HasMaxLength(64);

                entity.Property(e => e.TroubleSpotCode1).HasMaxLength(64);

                entity.Property(e => e.TroubleSpotCode2).HasMaxLength(64);

                entity.Property(e => e.TroubleSpotCode3).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasMaxLength(64);

                entity.Property(e => e.WarrantyPeriod).HasMaxLength(64);

                entity.Property(e => e.YearMonth).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgWork4H91>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ibg_Work4H91");

                entity.Property(e => e.Amount)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CaseNo)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Exno)
                    .HasColumnName("EXNo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HeaderCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrderNumber)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PartsNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Quantity)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.Reserve)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ShippingDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<IbgWork4H91his>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("ibg_Work4H91His");

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.Amount).HasMaxLength(64);

                entity.Property(e => e.CaseNo).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Datasta)
                    .HasColumnName("datasta")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Exno)
                    .HasColumnName("EXNo")
                    .HasMaxLength(64);

                entity.Property(e => e.HeaderCode).HasMaxLength(64);

                entity.Property(e => e.OrderNumber).HasMaxLength(64);

                entity.Property(e => e.PartsNumber).HasMaxLength(64);

                entity.Property(e => e.Pc)
                    .HasColumnName("PC")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode).HasMaxLength(64);

                entity.Property(e => e.Quantity).HasMaxLength(64);

                entity.Property(e => e.Reserve).HasMaxLength(64);

                entity.Property(e => e.ShippingDate).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgWork4H91his20190321>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("ibg_Work4H91His_20190321");

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.Amount).HasMaxLength(64);

                entity.Property(e => e.CaseNo).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Datasta)
                    .HasColumnName("datasta")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Exno)
                    .HasColumnName("EXNo")
                    .HasMaxLength(64);

                entity.Property(e => e.HeaderCode).HasMaxLength(64);

                entity.Property(e => e.OrderNumber).HasMaxLength(64);

                entity.Property(e => e.PartsNumber).HasMaxLength(64);

                entity.Property(e => e.Pc)
                    .HasColumnName("PC")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode).HasMaxLength(64);

                entity.Property(e => e.Quantity).HasMaxLength(64);

                entity.Property(e => e.Reserve).HasMaxLength(64);

                entity.Property(e => e.ShippingDate).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgWork4H92>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ibg_Work4H92");

                entity.Property(e => e.BeppyoNo)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CirculationFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ComnFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContryOfOrigin)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DangerousFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DataType)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DelFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DistributeAttitude)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Earflag)
                    .HasColumnName("EARFlag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Eccncode)
                    .HasColumnName("ECCNCode")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ediservcode)
                    .HasColumnName("EDISERVCode")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FileId)
                    .HasColumnName("FileID")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LicenceType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MainFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PackingUnit)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PartCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PartName)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PartNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PriceRetail)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProdCode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Reverse)
                    .HasMaxLength(419)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Rpinfo)
                    .HasColumnName("RPInfo")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ToolFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdateDate)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<IbgWork4H92his>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("ibg_Work4H92His");

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.BeppyoNo).HasMaxLength(64);

                entity.Property(e => e.CirculationFlag).HasMaxLength(64);

                entity.Property(e => e.ComnFlag).HasMaxLength(64);

                entity.Property(e => e.ContryOfOrigin).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DangerousFlag).HasMaxLength(64);

                entity.Property(e => e.DataType).HasMaxLength(64);

                entity.Property(e => e.DelFlag).HasMaxLength(64);

                entity.Property(e => e.DistributeAttitude).HasMaxLength(64);

                entity.Property(e => e.Earflag)
                    .HasColumnName("EARFlag")
                    .HasMaxLength(64);

                entity.Property(e => e.Eccncode)
                    .HasColumnName("ECCNCode")
                    .HasMaxLength(64);

                entity.Property(e => e.Ediservcode)
                    .HasColumnName("EDISERVCode")
                    .HasMaxLength(64);

                entity.Property(e => e.FileId)
                    .HasColumnName("FileID")
                    .HasMaxLength(64);

                entity.Property(e => e.LicenceType).HasMaxLength(64);

                entity.Property(e => e.MainFlag).HasMaxLength(64);

                entity.Property(e => e.PackingUnit).HasMaxLength(64);

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.PartName).HasMaxLength(64);

                entity.Property(e => e.PartNo).HasMaxLength(64);

                entity.Property(e => e.PriceRetail).HasMaxLength(64);

                entity.Property(e => e.ProdCode).HasMaxLength(64);

                entity.Property(e => e.Reverse).HasMaxLength(4000);

                entity.Property(e => e.Rpinfo)
                    .HasColumnName("RPInfo")
                    .HasMaxLength(64);

                entity.Property(e => e.ToolFlag).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgWork4H93>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ibg_Work4H93");

                entity.Property(e => e.CateCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Comment)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Datatype)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ediservcode)
                    .HasColumnName("EDISERVCode")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FileId)
                    .HasColumnName("FileID")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.KeepPeriodToYm)
                    .HasColumnName("KeepPeriodToYM")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProdCode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProdName)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SalesStartDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdateDate)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<IbgWork4H93his>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("ibg_Work4H93His");

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.CateCode).HasMaxLength(64);

                entity.Property(e => e.Comment).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Datatype).HasMaxLength(64);

                entity.Property(e => e.Ediservcode)
                    .HasColumnName("EDISERVCode")
                    .HasMaxLength(64);

                entity.Property(e => e.FileId)
                    .HasColumnName("FileID")
                    .HasMaxLength(64);

                entity.Property(e => e.KeepPeriodToYm)
                    .HasColumnName("KeepPeriodToYM")
                    .HasMaxLength(64);

                entity.Property(e => e.ProdCode).HasMaxLength(64);

                entity.Property(e => e.ProdName).HasMaxLength(64);

                entity.Property(e => e.SalesStartDate).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgWork4H94>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ibg_Work4H94");

                entity.Property(e => e.Amount).HasMaxLength(18);

                entity.Property(e => e.BranchCode)
                    .HasColumnName("branchCode")
                    .HasMaxLength(3);

                entity.Property(e => e.BranchType)
                    .HasColumnName("branchType")
                    .HasMaxLength(2);

                entity.Property(e => e.CreateDate).HasMaxLength(10);

                entity.Property(e => e.CurrencyCode).HasMaxLength(3);

                entity.Property(e => e.DataType).HasMaxLength(5);

                entity.Property(e => e.Dmbtr)
                    .HasColumnName("dmbtr")
                    .HasMaxLength(18);

                entity.Property(e => e.Ediserver)
                    .HasColumnName("EDIServer")
                    .HasMaxLength(5);

                entity.Property(e => e.ExtractDate1).HasMaxLength(12);

                entity.Property(e => e.FileId).HasMaxLength(3);

                entity.Property(e => e.Id).HasMaxLength(18);

                entity.Property(e => e.InvoiceNumber).HasMaxLength(12);

                entity.Property(e => e.Ivdate)
                    .HasColumnName("IVDate")
                    .HasMaxLength(10);

                entity.Property(e => e.Remark).HasMaxLength(13);

                entity.Property(e => e.TaxAmount).HasMaxLength(18);
            });

            modelBuilder.Entity<IbgWork4H94his>(entity =>
            {
                entity.ToTable("ibg_Work4H94His");

                entity.Property(e => e.Id)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BranchCode)
                    .HasColumnName("branchCode")
                    .HasMaxLength(3);

                entity.Property(e => e.BranchType)
                    .HasColumnName("branchType")
                    .HasMaxLength(2);

                entity.Property(e => e.CreateDate).HasMaxLength(10);

                entity.Property(e => e.CurrencyCode).HasMaxLength(3);

                entity.Property(e => e.Dmbtr)
                    .HasColumnName("dmbtr")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ediserver)
                    .HasColumnName("EDIServer")
                    .HasMaxLength(5);

                entity.Property(e => e.ExtractDate).HasMaxLength(10);

                entity.Property(e => e.InvoiceNumber).HasMaxLength(12);

                entity.Property(e => e.Ivdate)
                    .HasColumnName("IVDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.TaxAmount).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<IbgWork4H95>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ibg_Work4H95");

                entity.Property(e => e.BranchCode)
                    .HasColumnName("branchCode")
                    .HasMaxLength(3);

                entity.Property(e => e.BranchType)
                    .HasColumnName("branchType")
                    .HasMaxLength(2);

                entity.Property(e => e.Cost).HasMaxLength(18);

                entity.Property(e => e.CurrencyCode).HasMaxLength(3);

                entity.Property(e => e.DataType).HasMaxLength(5);

                entity.Property(e => e.Ediserver)
                    .HasColumnName("EDIServer")
                    .HasMaxLength(5);

                entity.Property(e => e.ExtractDate).HasMaxLength(10);

                entity.Property(e => e.ExtractDate1).HasMaxLength(12);

                entity.Property(e => e.FileId).HasMaxLength(3);

                entity.Property(e => e.Id).HasMaxLength(18);

                entity.Property(e => e.Remark).HasMaxLength(65);

                entity.Property(e => e.YearMonth).HasMaxLength(6);
            });

            modelBuilder.Entity<IbgWork4H95his>(entity =>
            {
                entity.ToTable("ibg_Work4H95His");

                entity.Property(e => e.Id)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BranchCode)
                    .HasColumnName("branchCode")
                    .HasMaxLength(3);

                entity.Property(e => e.BranchType)
                    .HasColumnName("branchType")
                    .HasMaxLength(2);

                entity.Property(e => e.Cost).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CurrencyCode).HasMaxLength(3);

                entity.Property(e => e.ExtractDate).HasMaxLength(10);

                entity.Property(e => e.YearMonth).HasMaxLength(6);
            });

            modelBuilder.Entity<IbgWork4H96>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ibg_Work4H96");

                entity.Property(e => e.Amount)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Bldate)
                    .HasColumnName("BLDate")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CaseNo)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Exno)
                    .HasColumnName("EXNo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HeaderCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrderNumber)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PartsNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Quantity)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.Reserve)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ShippingDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<IbgWork4H96Bld>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ibg_Work4H96_BLD");

                entity.Property(e => e.Amount)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Bldate)
                    .HasColumnName("BLDate")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CaseNo)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Exno)
                    .HasColumnName("EXNo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HeaderCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrderNumber)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PartsNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Quantity)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.Reserve)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ShippingDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<IbgWork4H96his>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("ibg_Work4H96His");

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.Amount).HasMaxLength(64);

                entity.Property(e => e.Bldate)
                    .HasColumnName("BLDate")
                    .HasMaxLength(64);

                entity.Property(e => e.CaseNo).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Datasta)
                    .HasColumnName("datasta")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Exno)
                    .HasColumnName("EXNo")
                    .HasMaxLength(64);

                entity.Property(e => e.HeaderCode).HasMaxLength(64);

                entity.Property(e => e.OrderNumber).HasMaxLength(64);

                entity.Property(e => e.PartsNumber).HasMaxLength(64);

                entity.Property(e => e.Pc)
                    .HasColumnName("PC")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode).HasMaxLength(64);

                entity.Property(e => e.Quantity).HasMaxLength(64);

                entity.Property(e => e.Reserve).HasMaxLength(64);

                entity.Property(e => e.ShippingDate).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgWork4H96his20190321>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("ibg_Work4H96His_20190321");

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.Amount).HasMaxLength(64);

                entity.Property(e => e.Bldate)
                    .HasColumnName("BLDate")
                    .HasMaxLength(64);

                entity.Property(e => e.CaseNo).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Datasta)
                    .HasColumnName("datasta")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Exno)
                    .HasColumnName("EXNo")
                    .HasMaxLength(64);

                entity.Property(e => e.HeaderCode).HasMaxLength(64);

                entity.Property(e => e.OrderNumber).HasMaxLength(64);

                entity.Property(e => e.PartsNumber).HasMaxLength(64);

                entity.Property(e => e.Pc)
                    .HasColumnName("PC")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode).HasMaxLength(64);

                entity.Property(e => e.Quantity).HasMaxLength(64);

                entity.Property(e => e.Reserve).HasMaxLength(64);

                entity.Property(e => e.ShippingDate).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgWork4H97>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ibg_Work4H97");

                entity.Property(e => e.Amount)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Bldate)
                    .HasColumnName("BLDate")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CaseNo)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CaseQuantity)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CountryOfOrigin)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Currency)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EquipmentCategory)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Exno)
                    .HasColumnName("EXNo")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExnoSeq)
                    .HasColumnName("EXNoSEQ")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.FileId)
                    .HasColumnName("FileID")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.FreightAmount)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.InsuranceAmount)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDate)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceFobamount)
                    .HasColumnName("InvoiceFOBAmount")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MachineTool)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NonChargeable)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNumberForImagingRp)
                    .HasColumnName("OrderNumberForImagingRP")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.OtherAmount)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PartCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Receiver1)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Receiver2)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.ShippingMethod)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAmount)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TradeTerms)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IbgWork4H97his>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("ibg_Work4H97His");

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.Amount)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Bldate)
                    .HasColumnName("BLDate")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CaseNo)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CaseQuantity)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CountryOfOrigin)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Currency)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EquipmentCategory)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Exno)
                    .HasColumnName("EXNo")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExnoSeq)
                    .HasColumnName("EXNoSEQ")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.FileId)
                    .HasColumnName("FileID")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.FreightAmount)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.InsuranceAmount)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDate)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceFobamount)
                    .HasColumnName("InvoiceFOBAmount")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MachineTool)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NonChargeable)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNumberForImagingRp)
                    .HasColumnName("OrderNumberForImagingRP")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.OtherAmount)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PartCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Receiver1)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Receiver2)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingMethod)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAmount)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TradeTerms)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IbgWork4H97tmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ibg_Work4H97Tmp");

                entity.Property(e => e.Amount)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Bldate)
                    .HasColumnName("BLDate")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CaseNo)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CaseQuantity)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CountryOfOrigin)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Currency)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EquipmentCategory)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Exno)
                    .HasColumnName("EXNo")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExnoSeq)
                    .HasColumnName("EXNoSEQ")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.FileId)
                    .HasColumnName("FileID")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.FreightAmount)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.InsuranceAmount)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDate)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceFobamount)
                    .HasColumnName("InvoiceFOBAmount")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MachineTool)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NonChargeable)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNumberForImagingRp)
                    .HasColumnName("OrderNumberForImagingRP")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.OtherAmount)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PartCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Receiver1)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Receiver2)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.ShippingMethod)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAmount)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TradeTerms)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IbgWork4NapcIn>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ibg_Work4NAPC_IN");

                entity.Property(e => e.ArrivalDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BondFree)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CountryOfOrigin)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CustomerCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Danger)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InvoiceNumber)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LoadingPlace)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PartsCode)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Quantity)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SupplierCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Time)
                    .HasColumnName("TIME")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TransportationType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Whcode)
                    .HasColumnName("WHCode")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<IbgWork4NapcInhis>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("ibg_Work4NAPC_INHis");

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.ArrivalDate).HasMaxLength(64);

                entity.Property(e => e.BondFree).HasMaxLength(64);

                entity.Property(e => e.CountryOfOrigin).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerCode).HasMaxLength(64);

                entity.Property(e => e.Danger).HasMaxLength(64);

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasMaxLength(64);

                entity.Property(e => e.InvoiceNumber).HasMaxLength(64);

                entity.Property(e => e.LoadingPlace).HasMaxLength(64);

                entity.Property(e => e.PartsCode).HasMaxLength(64);

                entity.Property(e => e.Quantity).HasMaxLength(64);

                entity.Property(e => e.SupplierCode).HasMaxLength(64);

                entity.Property(e => e.SupplierName).HasMaxLength(64);

                entity.Property(e => e.Time)
                    .HasColumnName("TIME")
                    .HasMaxLength(64);

                entity.Property(e => e.TransportationType).HasMaxLength(64);

                entity.Property(e => e.Whcode)
                    .HasColumnName("WHCode")
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<IbgWork4NapcOut>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ibg_Work4NAPC_OUT");

                entity.Property(e => e.Carrier)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ConsigneeCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ConsigneeName)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CountryOfOrigin)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CustomerCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Danger)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DeliveryOrderNumber)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PartsCode)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PartsNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductsCode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Quantity)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ShipOutDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TaskId)
                    .HasColumnName("TaskID")
                    .HasMaxLength(64);

                entity.Property(e => e.Time)
                    .HasColumnName("TIME")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TransportationType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Whcode)
                    .HasColumnName("WHCode")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<IbgWork4NapcOuthis>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("ibg_Work4NAPC_OUTHis");

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.Carrier).HasMaxLength(64);

                entity.Property(e => e.ConsigneeCode).HasMaxLength(64);

                entity.Property(e => e.ConsigneeName).HasMaxLength(64);

                entity.Property(e => e.CountryOfOrigin).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerCode).HasMaxLength(64);

                entity.Property(e => e.Danger).HasMaxLength(64);

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasMaxLength(64);

                entity.Property(e => e.DeliveryOrderNumber).HasMaxLength(64);

                entity.Property(e => e.PartsCode).HasMaxLength(64);

                entity.Property(e => e.PartsNumber).HasMaxLength(64);

                entity.Property(e => e.ProductsCode).HasMaxLength(64);

                entity.Property(e => e.Quantity).HasMaxLength(64);

                entity.Property(e => e.ShipOutDate).HasMaxLength(64);

                entity.Property(e => e.Time)
                    .HasColumnName("TIME")
                    .HasMaxLength(64);

                entity.Property(e => e.TransportationType).HasMaxLength(64);

                entity.Property(e => e.Whcode)
                    .HasColumnName("WHCode")
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<IbgWork4NapcStock>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ibg_Work4NAPC_STOCK");

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasMaxLength(64);

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.Qty).HasMaxLength(64);

                entity.Property(e => e.Time)
                    .HasColumnName("TIME")
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<IbgWork4NapcStockhis>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("ibg_Work4NAPC_STOCKHis");

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasMaxLength(64);

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.Qty).HasMaxLength(64);

                entity.Property(e => e.Time)
                    .HasColumnName("TIME")
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<IbgWork4Npcsreceive>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ibg_Work4NPCSReceive");

                entity.Property(e => e.Amt).HasMaxLength(64);

                entity.Property(e => e.PartNo).HasMaxLength(64);

                entity.Property(e => e.Price).HasMaxLength(64);

                entity.Property(e => e.ProdCode).HasMaxLength(64);

                entity.Property(e => e.Reverse).HasMaxLength(64);

                entity.Property(e => e.ShelfCode).HasMaxLength(64);

                entity.Property(e => e.SonoNpcs)
                    .HasColumnName("SONoNPCS")
                    .HasMaxLength(64);

                entity.Property(e => e.Soqty)
                    .HasColumnName("SOQty")
                    .HasMaxLength(64);

                entity.Property(e => e.TaskId)
                    .HasColumnName("TaskID")
                    .HasMaxLength(64);

                entity.Property(e => e.WoactGuid)
                    .HasColumnName("WOActGUID")
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<IbgWork4NpcsreceiveHis>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("ibg_Work4NPCSReceiveHis");

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.Amt).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.PartNo).HasMaxLength(64);

                entity.Property(e => e.Price).HasMaxLength(64);

                entity.Property(e => e.ProdCode).HasMaxLength(64);

                entity.Property(e => e.Reverse).HasMaxLength(64);

                entity.Property(e => e.ShelfCode).HasMaxLength(64);

                entity.Property(e => e.SonoNpcs)
                    .HasColumnName("SONoNPCS")
                    .HasMaxLength(64);

                entity.Property(e => e.Soqty)
                    .HasColumnName("SOQty")
                    .HasMaxLength(64);

                entity.Property(e => e.WoactGuid)
                    .HasColumnName("WOActGUID")
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<IbgWork4Npcsso>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ibg_Work4NPCSSO");

                entity.Property(e => e.Amt)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PartNo)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Price)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProdCode)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Reverse)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ShelfCode)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SonoNpcs)
                    .HasColumnName("SONoNPCS")
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Soqty)
                    .HasColumnName("SOQty")
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<IbgWork4Npcssohis>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("ibg_Work4NPCSSOHis");

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.Amt).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.PartNo).HasMaxLength(64);

                entity.Property(e => e.Price).HasMaxLength(64);

                entity.Property(e => e.ProdCode).HasMaxLength(64);

                entity.Property(e => e.Reverse).HasMaxLength(64);

                entity.Property(e => e.ShelfCode).HasMaxLength(64);

                entity.Property(e => e.SonoNpcs)
                    .HasColumnName("SONoNPCS")
                    .HasMaxLength(64);

                entity.Property(e => e.Soqty)
                    .HasColumnName("SOQty")
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<IbgWork4Nwni67>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ibg_Work4NWNI67");

                entity.Property(e => e.AlocatedQty).HasColumnName("Alocated_QTY");

                entity.Property(e => e.AvailableQty).HasColumnName("Available_QTY");

                entity.Property(e => e.DataReferenceDate)
                    .HasColumnName("Data_Reference_Date")
                    .HasMaxLength(8);

                entity.Property(e => e.DataSendingKyotenCode)
                    .HasColumnName("Data_Sending_KYOTEN_Code")
                    .HasMaxLength(4);

                entity.Property(e => e.ExtensionColumn1)
                    .HasColumnName("Extension_Column1")
                    .HasMaxLength(20);

                entity.Property(e => e.ExtensionColumn2)
                    .HasColumnName("Extension_Column2")
                    .HasMaxLength(20);

                entity.Property(e => e.ExtensionColumn3)
                    .HasColumnName("Extension_Column3")
                    .HasMaxLength(20);

                entity.Property(e => e.IntransitQtyFromNc).HasColumnName("Intransit_QTY_from_NC");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(20);

                entity.Property(e => e.LocationName)
                    .HasColumnName("Location_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.OrderRemainingQtyToNc).HasColumnName("Order_Remaining_QTY_to_NC");

                entity.Property(e => e.PartsCode)
                    .HasColumnName("Parts_Code")
                    .HasMaxLength(20);

                entity.Property(e => e.PartsNumber)
                    .HasColumnName("Parts_Number")
                    .HasMaxLength(20);

                entity.Property(e => e.ProductCode)
                    .HasColumnName("Product_Code")
                    .HasMaxLength(20);

                entity.Property(e => e.TotalQty).HasColumnName("Total_QTY");

                entity.Property(e => e.UnavailableQty).HasColumnName("Unavailable_QTY");

                entity.Property(e => e.WaitingBackOrderedQty).HasColumnName("Waiting(Back_ordered)_QTY");
            });

            modelBuilder.Entity<IbgWork4Nwni67his>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ibg_Work4NWNI67His");

                entity.Property(e => e.AlocatedQty).HasColumnName("Alocated_QTY");

                entity.Property(e => e.AvailableQty).HasColumnName("Available_QTY");

                entity.Property(e => e.CreateDate).HasMaxLength(20);

                entity.Property(e => e.DataReferenceDate)
                    .HasColumnName("Data_Reference_Date")
                    .HasMaxLength(8);

                entity.Property(e => e.DataSendingKyotenCode)
                    .HasColumnName("Data_Sending_KYOTEN_Code")
                    .HasMaxLength(4);

                entity.Property(e => e.ExtensionColumn1)
                    .HasColumnName("Extension_Column1")
                    .HasMaxLength(20);

                entity.Property(e => e.ExtensionColumn2)
                    .HasColumnName("Extension_Column2")
                    .HasMaxLength(20);

                entity.Property(e => e.ExtensionColumn3)
                    .HasColumnName("Extension_Column3")
                    .HasMaxLength(20);

                entity.Property(e => e.IntransitQtyFromNc).HasColumnName("Intransit_QTY_from_NC");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(20);

                entity.Property(e => e.LocationName)
                    .HasColumnName("Location_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.OrderRemainingQtyToNc).HasColumnName("Order_Remaining_QTY_to_NC");

                entity.Property(e => e.PartsCode)
                    .HasColumnName("Parts_Code")
                    .HasMaxLength(20);

                entity.Property(e => e.PartsNumber)
                    .HasColumnName("Parts_Number")
                    .HasMaxLength(20);

                entity.Property(e => e.ProductCode)
                    .HasColumnName("Product_Code")
                    .HasMaxLength(20);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(50);

                entity.Property(e => e.TotalQty).HasColumnName("Total_QTY");

                entity.Property(e => e.UnavailableQty).HasColumnName("Unavailable_QTY");

                entity.Property(e => e.WaitingBackOrderedQty).HasColumnName("Waiting(Back_ordered)_QTY");
            });

            modelBuilder.Entity<IbgWork4Nwni68>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ibg_Work4NWNI68");

                entity.Property(e => e.CorrectionCode)
                    .HasColumnName("Correction_Code")
                    .HasMaxLength(1);

                entity.Property(e => e.DataReferenceDate)
                    .HasColumnName("Data_Reference_Date")
                    .HasMaxLength(8);

                entity.Property(e => e.DataSendingKyotenCode)
                    .HasColumnName("Data_Sending_KYOTEN_Code")
                    .HasMaxLength(4);

                entity.Property(e => e.ExtensionColumn1)
                    .HasColumnName("Extension_Column1")
                    .HasMaxLength(20);

                entity.Property(e => e.ExtensionColumn2)
                    .HasColumnName("Extension_Column2")
                    .HasMaxLength(20);

                entity.Property(e => e.ExtensionColumn3)
                    .HasColumnName("Extension_Column3")
                    .HasMaxLength(20);

                entity.Property(e => e.FromLocationCode)
                    .HasColumnName("From_Location_Code")
                    .HasMaxLength(20);

                entity.Property(e => e.FromLocationName)
                    .HasColumnName("From_Location_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.PartsCode)
                    .HasColumnName("Parts_Code")
                    .HasMaxLength(20);

                entity.Property(e => e.PartsNumber)
                    .HasColumnName("Parts_Number")
                    .HasMaxLength(20);

                entity.Property(e => e.PostingDate)
                    .HasColumnName("Posting_Date")
                    .HasMaxLength(8);

                entity.Property(e => e.ProductCode)
                    .HasColumnName("Product_Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ReceivedQty).HasColumnName("Received_QTY");

                entity.Property(e => e.ReceivingKeyNumber)
                    .HasColumnName("Receiving_Key_Number")
                    .HasMaxLength(20);

                entity.Property(e => e.ReferenceDocument)
                    .HasColumnName("Reference_Document")
                    .HasMaxLength(20);

                entity.Property(e => e.StockTransferFlag)
                    .HasColumnName("Stock_Transfer_Flag")
                    .HasMaxLength(1);

                entity.Property(e => e.ToLocationCode)
                    .HasColumnName("To_Location_Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ToLocationName)
                    .HasColumnName("To_Location_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.TransactionType)
                    .HasColumnName("Transaction_Type")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<IbgWork4Nwni68his>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ibg_Work4NWNI68His");

                entity.Property(e => e.CorrectionCode)
                    .HasColumnName("Correction_Code")
                    .HasMaxLength(1);

                entity.Property(e => e.CreateDate).HasMaxLength(20);

                entity.Property(e => e.DataReferenceDate)
                    .HasColumnName("Data_Reference_Date")
                    .HasMaxLength(8);

                entity.Property(e => e.DataSendingKyotenCode)
                    .HasColumnName("Data_Sending_KYOTEN_Code")
                    .HasMaxLength(4);

                entity.Property(e => e.ExtensionColumn1)
                    .HasColumnName("Extension_Column1")
                    .HasMaxLength(20);

                entity.Property(e => e.ExtensionColumn2)
                    .HasColumnName("Extension_Column2")
                    .HasMaxLength(20);

                entity.Property(e => e.ExtensionColumn3)
                    .HasColumnName("Extension_Column3")
                    .HasMaxLength(20);

                entity.Property(e => e.FromLocationCode)
                    .HasColumnName("From_Location_Code")
                    .HasMaxLength(20);

                entity.Property(e => e.FromLocationName)
                    .HasColumnName("From_Location_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.PartsCode)
                    .HasColumnName("Parts_Code")
                    .HasMaxLength(20);

                entity.Property(e => e.PartsNumber)
                    .HasColumnName("Parts_Number")
                    .HasMaxLength(20);

                entity.Property(e => e.PostingDate)
                    .HasColumnName("Posting_Date")
                    .HasMaxLength(8);

                entity.Property(e => e.ProductCode)
                    .HasColumnName("Product_Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ReceivedQty).HasColumnName("Received_QTY");

                entity.Property(e => e.ReceivingKeyNumber)
                    .HasColumnName("Receiving_Key_Number")
                    .HasMaxLength(20);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(50);

                entity.Property(e => e.ReferenceDocument)
                    .HasColumnName("Reference_Document")
                    .HasMaxLength(20);

                entity.Property(e => e.StockTransferFlag)
                    .HasColumnName("Stock_Transfer_Flag")
                    .HasMaxLength(1);

                entity.Property(e => e.ToLocationCode)
                    .HasColumnName("To_Location_Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ToLocationName)
                    .HasColumnName("To_Location_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.TransactionType)
                    .HasColumnName("Transaction_Type")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<IbgWork4Nwni69>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ibg_Work4NWNI69");

                entity.Property(e => e.CorrectionCode)
                    .HasColumnName("Correction_Code")
                    .HasMaxLength(1);

                entity.Property(e => e.DataReferenceDate)
                    .HasColumnName("Data_Reference_Date")
                    .HasMaxLength(8);

                entity.Property(e => e.DataSendingKyotenCode)
                    .HasColumnName("Data_Sending_KYOTEN_Code")
                    .HasMaxLength(4);

                entity.Property(e => e.ExtensionColumn1)
                    .HasColumnName("Extension_Column1")
                    .HasMaxLength(20);

                entity.Property(e => e.ExtensionColumn2)
                    .HasColumnName("Extension_Column2")
                    .HasMaxLength(20);

                entity.Property(e => e.ExtensionColumn3)
                    .HasColumnName("Extension_Column3")
                    .HasMaxLength(20);

                entity.Property(e => e.FromLocationCode)
                    .HasColumnName("From_Location_Code")
                    .HasMaxLength(20);

                entity.Property(e => e.FromLocationName)
                    .HasColumnName("From_Location_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.PartsCode)
                    .HasColumnName("Parts_Code")
                    .HasMaxLength(20);

                entity.Property(e => e.PartsNumber)
                    .HasColumnName("Parts_Number")
                    .HasMaxLength(20);

                entity.Property(e => e.PostingDate)
                    .HasColumnName("Posting_Date")
                    .HasMaxLength(8);

                entity.Property(e => e.ProductCode)
                    .HasColumnName("Product_Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ReferenceDocument)
                    .HasColumnName("Reference_Document")
                    .HasMaxLength(20);

                entity.Property(e => e.ShippedQty).HasColumnName("Shipped_QTY");

                entity.Property(e => e.ShippingKeyNumber)
                    .HasColumnName("Shipping_Key_Number")
                    .HasMaxLength(20);

                entity.Property(e => e.StockTransferFlag)
                    .HasColumnName("Stock_Transfer_Flag")
                    .HasMaxLength(1);

                entity.Property(e => e.ToLocationCode)
                    .HasColumnName("To_Location_Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ToLocationName)
                    .HasColumnName("To_Location_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.TransactionType)
                    .HasColumnName("Transaction_Type")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<IbgWork4Nwni69his>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ibg_Work4NWNI69His");

                entity.Property(e => e.CorrectionCode)
                    .HasColumnName("Correction_Code")
                    .HasMaxLength(1);

                entity.Property(e => e.CreateDate).HasMaxLength(20);

                entity.Property(e => e.DataReferenceDate)
                    .HasColumnName("Data_Reference_Date")
                    .HasMaxLength(8);

                entity.Property(e => e.DataSendingKyotenCode)
                    .HasColumnName("Data_Sending_KYOTEN_Code")
                    .HasMaxLength(4);

                entity.Property(e => e.ExtensionColumn1)
                    .HasColumnName("Extension_Column1")
                    .HasMaxLength(20);

                entity.Property(e => e.ExtensionColumn2)
                    .HasColumnName("Extension_Column2")
                    .HasMaxLength(20);

                entity.Property(e => e.ExtensionColumn3)
                    .HasColumnName("Extension_Column3")
                    .HasMaxLength(20);

                entity.Property(e => e.FromLocationCode)
                    .HasColumnName("From_Location_Code")
                    .HasMaxLength(20);

                entity.Property(e => e.FromLocationName)
                    .HasColumnName("From_Location_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.PartsCode)
                    .HasColumnName("Parts_Code")
                    .HasMaxLength(20);

                entity.Property(e => e.PartsNumber)
                    .HasColumnName("Parts_Number")
                    .HasMaxLength(20);

                entity.Property(e => e.PostingDate)
                    .HasColumnName("Posting_Date")
                    .HasMaxLength(8);

                entity.Property(e => e.ProductCode)
                    .HasColumnName("Product_Code")
                    .HasMaxLength(20);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(50);

                entity.Property(e => e.ReferenceDocument)
                    .HasColumnName("Reference_Document")
                    .HasMaxLength(20);

                entity.Property(e => e.ShippedQty).HasColumnName("Shipped_QTY");

                entity.Property(e => e.ShippingKeyNumber)
                    .HasColumnName("Shipping_Key_Number")
                    .HasMaxLength(20);

                entity.Property(e => e.StockTransferFlag)
                    .HasColumnName("Stock_Transfer_Flag")
                    .HasMaxLength(1);

                entity.Property(e => e.ToLocationCode)
                    .HasColumnName("To_Location_Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ToLocationName)
                    .HasColumnName("To_Location_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.TransactionType)
                    .HasColumnName("Transaction_Type")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<IbgWork4Nwni70>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ibg_Work4NWNI70");

                entity.Property(e => e.BackOrderQty).HasColumnName("Back_Order_QTY");

                entity.Property(e => e.CorrectionCode)
                    .HasColumnName("Correction_Code")
                    .HasMaxLength(1);

                entity.Property(e => e.CumtomerOrderNumber)
                    .HasColumnName("Cumtomer_Order_Number")
                    .HasMaxLength(20);

                entity.Property(e => e.CustomerCode)
                    .HasColumnName("Customer_Code")
                    .HasMaxLength(20);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("Customer_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.DataReferenceDate)
                    .HasColumnName("Data_Reference_Date")
                    .HasMaxLength(8);

                entity.Property(e => e.DataSendingKyotenCode)
                    .HasColumnName("Data_Sending_KYOTEN_Code")
                    .HasMaxLength(4);

                entity.Property(e => e.ExtensionColumn1)
                    .HasColumnName("Extension_Column1")
                    .HasMaxLength(20);

                entity.Property(e => e.ExtensionColumn2)
                    .HasColumnName("Extension_Column2")
                    .HasMaxLength(20);

                entity.Property(e => e.ExtensionColumn3)
                    .HasColumnName("Extension_Column3")
                    .HasMaxLength(20);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasMaxLength(8);

                entity.Property(e => e.OrderQty).HasColumnName("Order_QTY");

                entity.Property(e => e.OrderReceivedCompany)
                    .HasColumnName("Order_Received_Company")
                    .HasMaxLength(50);

                entity.Property(e => e.OrderReceivedCompanyCode)
                    .HasColumnName("Order_Received_Company_Code")
                    .HasMaxLength(20);

                entity.Property(e => e.PartsCode)
                    .HasColumnName("Parts_Code")
                    .HasMaxLength(20);

                entity.Property(e => e.PartsNumber)
                    .HasColumnName("Parts_Number")
                    .HasMaxLength(20);

                entity.Property(e => e.ProductCode)
                    .HasColumnName("Product_Code")
                    .HasMaxLength(20);

                entity.Property(e => e.SalesOrderNumber)
                    .HasColumnName("Sales_Order_Number")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<IbgWork4Nwni70his>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ibg_Work4NWNI70His");

                entity.Property(e => e.BackOrderQty).HasColumnName("Back_Order_QTY");

                entity.Property(e => e.CorrectionCode)
                    .HasColumnName("Correction_Code")
                    .HasMaxLength(1);

                entity.Property(e => e.CreateDate).HasMaxLength(20);

                entity.Property(e => e.CumtomerOrderNumber)
                    .HasColumnName("Cumtomer_Order_Number")
                    .HasMaxLength(20);

                entity.Property(e => e.CustomerCode)
                    .HasColumnName("Customer_Code")
                    .HasMaxLength(20);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("Customer_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.DataReferenceDate)
                    .HasColumnName("Data_Reference_Date")
                    .HasMaxLength(8);

                entity.Property(e => e.DataSendingKyotenCode)
                    .HasColumnName("Data_Sending_KYOTEN_Code")
                    .HasMaxLength(4);

                entity.Property(e => e.ExtensionColumn1)
                    .HasColumnName("Extension_Column1")
                    .HasMaxLength(20);

                entity.Property(e => e.ExtensionColumn2)
                    .HasColumnName("Extension_Column2")
                    .HasMaxLength(20);

                entity.Property(e => e.ExtensionColumn3)
                    .HasColumnName("Extension_Column3")
                    .HasMaxLength(20);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasMaxLength(8);

                entity.Property(e => e.OrderQty).HasColumnName("Order_QTY");

                entity.Property(e => e.OrderReceivedCompany)
                    .HasColumnName("Order_Received_Company")
                    .HasMaxLength(50);

                entity.Property(e => e.OrderReceivedCompanyCode)
                    .HasColumnName("Order_Received_Company_Code")
                    .HasMaxLength(20);

                entity.Property(e => e.PartsCode)
                    .HasColumnName("Parts_Code")
                    .HasMaxLength(20);

                entity.Property(e => e.PartsNumber)
                    .HasColumnName("Parts_Number")
                    .HasMaxLength(20);

                entity.Property(e => e.ProductCode)
                    .HasColumnName("Product_Code")
                    .HasMaxLength(20);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(50);

                entity.Property(e => e.SalesOrderNumber)
                    .HasColumnName("Sales_Order_Number")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<IbgWork4Nwni83>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ibg_Work4NWNI83");

                entity.Property(e => e.CauseCode1)
                    .HasColumnName("Cause_Code1")
                    .HasMaxLength(10);

                entity.Property(e => e.CauseCode2)
                    .HasColumnName("Cause_Code2")
                    .HasMaxLength(10);

                entity.Property(e => e.CauseCode3)
                    .HasColumnName("Cause_Code3")
                    .HasMaxLength(10);

                entity.Property(e => e.CauseCode4)
                    .HasColumnName("Cause_Code4")
                    .HasMaxLength(10);

                entity.Property(e => e.CauseCode5)
                    .HasColumnName("Cause_Code5")
                    .HasMaxLength(10);

                entity.Property(e => e.CostCurrencySubcon)
                    .HasColumnName("Cost_Currency_Subcon")
                    .HasMaxLength(3);

                entity.Property(e => e.CostSubcon)
                    .HasColumnName("Cost_Subcon")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.CustomerType)
                    .HasColumnName("Customer_Type")
                    .HasMaxLength(10);

                entity.Property(e => e.DataSendingDate)
                    .IsRequired()
                    .HasColumnName("Data_Sending_Date")
                    .HasMaxLength(8);

                entity.Property(e => e.DataType)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ExtensionColumn1)
                    .HasColumnName("Extension_Column1")
                    .HasMaxLength(20);

                entity.Property(e => e.ExtensionColumn2)
                    .HasColumnName("Extension_Column2")
                    .HasMaxLength(20);

                entity.Property(e => e.ExtensionColumn3)
                    .HasColumnName("Extension_Column3")
                    .HasMaxLength(20);

                entity.Property(e => e.ExtensionColumn4)
                    .HasColumnName("Extension_Column4")
                    .HasMaxLength(20);

                entity.Property(e => e.ExtensionColumn5)
                    .HasColumnName("Extension_Column5")
                    .HasMaxLength(20);

                entity.Property(e => e.GenpoCode)
                    .HasColumnName("GENPO_Code")
                    .HasMaxLength(5);

                entity.Property(e => e.InOutFlag)
                    .HasColumnName("In_Out_Flag")
                    .HasMaxLength(20);

                entity.Property(e => e.KyotenCode)
                    .IsRequired()
                    .HasColumnName("KYOTEN_Code")
                    .HasMaxLength(4);

                entity.Property(e => e.PhenomenonCode1)
                    .HasColumnName("Phenomenon_Code1")
                    .HasMaxLength(10);

                entity.Property(e => e.PhenomenonCode2)
                    .HasColumnName("Phenomenon_Code2")
                    .HasMaxLength(10);

                entity.Property(e => e.PhenomenonCode3)
                    .HasColumnName("Phenomenon_Code3")
                    .HasMaxLength(10);

                entity.Property(e => e.PhenomenonCode4)
                    .HasColumnName("Phenomenon_Code4")
                    .HasMaxLength(10);

                entity.Property(e => e.PhenomenonCode5)
                    .HasColumnName("Phenomenon_Code5")
                    .HasMaxLength(10);

                entity.Property(e => e.ProductCode)
                    .IsRequired()
                    .HasColumnName("Product_Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ProductExchangeType)
                    .HasColumnName("Product_Exchange_Type")
                    .HasMaxLength(40);

                entity.Property(e => e.ProductName)
                    .HasColumnName("Product_Name")
                    .HasMaxLength(60);

                entity.Property(e => e.ProductPurchasedDate)
                    .HasColumnName("Product_Purchased_Date")
                    .HasMaxLength(8);

                entity.Property(e => e.ReRepairType)
                    .IsRequired()
                    .HasColumnName("Re_Repair_Type")
                    .HasMaxLength(40);

                entity.Property(e => e.ReceiptDate)
                    .IsRequired()
                    .HasColumnName("Receipt_Date")
                    .HasMaxLength(8);

                entity.Property(e => e.ReceiptFacilityCode)
                    .HasColumnName("Receipt_Facility_Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ReceiptFacilityName)
                    .HasColumnName("Receipt_Facility_Name")
                    .HasMaxLength(60);

                entity.Property(e => e.ReleaseTimes)
                    .HasColumnName("Release_Times")
                    .HasColumnType("decimal(9, 0)");

                entity.Property(e => e.RepairComment1)
                    .HasColumnName("Repair_Comment1")
                    .HasMaxLength(255);

                entity.Property(e => e.RepairComment2)
                    .HasColumnName("Repair_Comment2")
                    .HasMaxLength(255);

                entity.Property(e => e.RepairComment3)
                    .HasColumnName("Repair_Comment3")
                    .HasMaxLength(255);

                entity.Property(e => e.RepairEndDate)
                    .HasColumnName("Repair_End_Date")
                    .HasMaxLength(8);

                entity.Property(e => e.RepairFacilityCode)
                    .IsRequired()
                    .HasColumnName("Repair_Facility_Code")
                    .HasMaxLength(20);

                entity.Property(e => e.RepairFacilityName)
                    .HasColumnName("Repair_Facility_Name")
                    .HasMaxLength(60);

                entity.Property(e => e.RepairNo)
                    .IsRequired()
                    .HasColumnName("Repair_No")
                    .HasMaxLength(20);

                entity.Property(e => e.RepairStartDate)
                    .HasColumnName("Repair_Start_Date")
                    .HasMaxLength(8);

                entity.Property(e => e.RepairTime)
                    .HasColumnName("Repair_Time")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.RevenueCustomerChare)
                    .HasColumnName("Revenue_Customer_Chare")
                    .HasMaxLength(3);

                entity.Property(e => e.RevenueDiscount)
                    .HasColumnName("Revenue_Discount")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.RevenueQuotationCharge)
                    .HasColumnName("Revenue_Quotation_Charge")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.RevenueRepairFee)
                    .HasColumnName("Revenue_Repair_Fee")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.RevenueRepairWorkFee)
                    .HasColumnName("Revenue_Repair_Work_Fee")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.RevenueShippingCharge)
                    .HasColumnName("Revenue_Shipping_Charge")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.RevenueTotalPartsCharge)
                    .HasColumnName("Revenue_Total_Parts_Charge")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.SerialNo)
                    .HasColumnName("Serial_No")
                    .HasMaxLength(20);

                entity.Property(e => e.StockRepairType)
                    .HasColumnName("Stock_Repair_Type")
                    .HasMaxLength(40);

                entity.Property(e => e.TargetDateOfInterface)
                    .IsRequired()
                    .HasColumnName("Target_Date_of_Interface")
                    .HasMaxLength(8);

                entity.Property(e => e.TatExcludingPartsWaiting)
                    .HasColumnName("TAT_Excluding_PartsWaiting")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.TatTimeIncludingPartsWaiting)
                    .HasColumnName("TAT_Time_Including_PartsWaiting")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.TreatAsReRepairType)
                    .IsRequired()
                    .HasColumnName("Treat_as_Re_Repair_Type")
                    .HasMaxLength(40);

                entity.Property(e => e.TreatmentCode1)
                    .HasColumnName("Treatment_Code1")
                    .HasMaxLength(10);

                entity.Property(e => e.TreatmentCode2)
                    .HasColumnName("Treatment_Code2")
                    .HasMaxLength(10);

                entity.Property(e => e.TreatmentCode3)
                    .HasColumnName("Treatment_Code3")
                    .HasMaxLength(10);

                entity.Property(e => e.TreatmentCode4)
                    .HasColumnName("Treatment_Code4")
                    .HasMaxLength(10);

                entity.Property(e => e.TreatmentCode5)
                    .HasColumnName("Treatment_Code5")
                    .HasMaxLength(10);

                entity.Property(e => e.TroubledAreaCode1)
                    .HasColumnName("Troubled_Area_Code1")
                    .HasMaxLength(10);

                entity.Property(e => e.TroubledAreaCode2)
                    .HasColumnName("Troubled_Area_Code2")
                    .HasMaxLength(10);

                entity.Property(e => e.TroubledAreaCode3)
                    .HasColumnName("Troubled_Area_Code3")
                    .HasMaxLength(10);

                entity.Property(e => e.TroubledAreaCode4)
                    .HasColumnName("Troubled_Area_Code4")
                    .HasMaxLength(10);

                entity.Property(e => e.TroubledAreaCode5)
                    .HasColumnName("Troubled_Area_Code5")
                    .HasMaxLength(10);

                entity.Property(e => e.UnrepairReason)
                    .HasColumnName("Unrepair_Reason")
                    .HasMaxLength(40);

                entity.Property(e => e.UnrepairType)
                    .IsRequired()
                    .HasColumnName("Unrepair_Type")
                    .HasMaxLength(40);

                entity.Property(e => e.WarrantyType)
                    .IsRequired()
                    .HasColumnName("Warranty_Type")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<IbgWork4Nwni84>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ibg_Work4NWNI84");

                entity.Property(e => e.DataSendingDate)
                    .IsRequired()
                    .HasColumnName("Data_Sending_Date")
                    .HasMaxLength(8);

                entity.Property(e => e.DataType)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ExtensionColumn1)
                    .HasColumnName("Extension_Column1")
                    .HasMaxLength(20);

                entity.Property(e => e.ExtensionColumn2)
                    .HasColumnName("Extension_Column2")
                    .HasMaxLength(20);

                entity.Property(e => e.ExtensionColumn3)
                    .HasColumnName("Extension_Column3")
                    .HasMaxLength(20);

                entity.Property(e => e.KyotenCode)
                    .IsRequired()
                    .HasColumnName("KYOTEN_Code")
                    .HasMaxLength(4);

                entity.Property(e => e.PartsCode)
                    .IsRequired()
                    .HasColumnName("Parts_Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ProductCode)
                    .IsRequired()
                    .HasColumnName("Product_Code")
                    .HasMaxLength(20);

                entity.Property(e => e.Quantity).HasColumnType("decimal(3, 0)");

                entity.Property(e => e.RepairFacilityCode)
                    .IsRequired()
                    .HasColumnName("Repair_Facility_Code")
                    .HasMaxLength(20);

                entity.Property(e => e.RepairNo)
                    .IsRequired()
                    .HasColumnName("Repair_No")
                    .HasMaxLength(20);

                entity.Property(e => e.SerialNo)
                    .HasColumnName("Serial_No")
                    .HasMaxLength(20);

                entity.Property(e => e.TargetDateOfInterface)
                    .IsRequired()
                    .HasColumnName("Target_Date_of_Interface")
                    .HasMaxLength(8);
            });

            modelBuilder.Entity<IbgWork4R01>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ibg_Work4R01");

                entity.Property(e => e.Amount)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DivisionCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FileId)
                    .HasColumnName("FileID")
                    .HasMaxLength(64);

                entity.Property(e => e.HeaderCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrederNumber1)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrederNumber2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrederNumber3)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrederNumber4)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PartsNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Quantity)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Reserve1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Reserve2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TaskId)
                    .HasColumnName("TaskID")
                    .HasMaxLength(64);

                entity.Property(e => e.Updatedate)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<IbgWork4R0120190321>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ibg_Work4R01_20190321");

                entity.Property(e => e.Amount)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DivisionCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FileId)
                    .HasColumnName("FileID")
                    .HasMaxLength(64);

                entity.Property(e => e.HeaderCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrederNumber1)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrederNumber2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrederNumber3)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrederNumber4)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PartsNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Quantity)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Reserve1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Reserve2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TaskId)
                    .HasColumnName("TaskID")
                    .HasMaxLength(64);

                entity.Property(e => e.Updatedate)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<IbgWork4R01Dm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ibg_Work4R01_DM");

                entity.Property(e => e.Amount)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DivisionCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FileId)
                    .HasColumnName("FileID")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HeaderCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrederNumber1)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrederNumber2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrederNumber3)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrederNumber4)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PartsNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Quantity)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Reserve1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Reserve2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TaskId)
                    .HasColumnName("TaskID")
                    .HasMaxLength(64);

                entity.Property(e => e.Updatedate)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<IbgWork4R01his>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("ibg_Work4R01His");

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.Amount).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DivisionCode).HasMaxLength(64);

                entity.Property(e => e.FileId)
                    .HasColumnName("FileID")
                    .HasMaxLength(64);

                entity.Property(e => e.HeaderCode).HasMaxLength(64);

                entity.Property(e => e.OrederNumber1).HasMaxLength(64);

                entity.Property(e => e.OrederNumber2).HasMaxLength(64);

                entity.Property(e => e.OrederNumber3).HasMaxLength(64);

                entity.Property(e => e.OrederNumber4).HasMaxLength(64);

                entity.Property(e => e.PartsNumber).HasMaxLength(64);

                entity.Property(e => e.ProductCode).HasMaxLength(64);

                entity.Property(e => e.Quantity).HasMaxLength(64);

                entity.Property(e => e.Reserve1).HasMaxLength(64);

                entity.Property(e => e.Reserve2).HasMaxLength(64);

                entity.Property(e => e.Updatedate).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgWork4R01his20190321>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("ibg_Work4R01His_20190321");

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.Amount).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DivisionCode).HasMaxLength(64);

                entity.Property(e => e.FileId)
                    .HasColumnName("FileID")
                    .HasMaxLength(64);

                entity.Property(e => e.HeaderCode).HasMaxLength(64);

                entity.Property(e => e.OrederNumber1).HasMaxLength(64);

                entity.Property(e => e.OrederNumber2).HasMaxLength(64);

                entity.Property(e => e.OrederNumber3).HasMaxLength(64);

                entity.Property(e => e.OrederNumber4).HasMaxLength(64);

                entity.Property(e => e.PartsNumber).HasMaxLength(64);

                entity.Property(e => e.ProductCode).HasMaxLength(64);

                entity.Property(e => e.Quantity).HasMaxLength(64);

                entity.Property(e => e.Reserve1).HasMaxLength(64);

                entity.Property(e => e.Reserve2).HasMaxLength(64);

                entity.Property(e => e.Updatedate).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgWork4TaskOrient>(entity =>
            {
                entity.HasKey(e => new { e.BranCode, e.TaskType });

                entity.ToTable("ibg_Work4TaskOrient");

                entity.Property(e => e.BranCode).HasMaxLength(64);

                entity.Property(e => e.TaskType).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgWorkIflog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ibg_Work_IFLog");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Creator)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(N'System')");

                entity.Property(e => e.Error).HasMaxLength(4000);

                entity.Property(e => e.Ifnm)
                    .HasColumnName("IFNm")
                    .HasMaxLength(64);

                entity.Property(e => e.ProcedureNm).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.RecordVersion)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.RequestId)
                    .HasColumnName("RequestID")
                    .HasMaxLength(64);

                entity.Property(e => e.Result).HasMaxLength(64);

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Updator)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(N'System')");
            });

            modelBuilder.Entity<IbgWotempD>(entity =>
            {
                entity.HasKey(e => new { e.WotempGuid, e.PartCode, e.StkAccCodeNd });

                entity.ToTable("ibg_WOTempD");

                entity.HasIndex(e => e.PartCode);

                entity.HasIndex(e => e.WotempGuid);

                entity.Property(e => e.WotempGuid)
                    .HasColumnName("WOTempGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.StkAccCodeNd).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.NtqtyOrg).HasColumnName("NTQtyOrg");

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<IbgWotempH>(entity =>
            {
                entity.HasKey(e => new { e.WotempGuid, e.PartCode });

                entity.ToTable("ibg_WOTempH");

                entity.Property(e => e.WotempGuid)
                    .HasColumnName("WOTempGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.PartCode).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.DistributeSta).HasMaxLength(64);

                entity.Property(e => e.OperateSta).HasMaxLength(64);

                entity.Property(e => e.OutStkFlag).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.StkAccCodeSupl).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);
            });

            modelBuilder.Entity<KpiSummary>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KPI_Summary");

                entity.Property(e => e.BranCode)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.DataUpdateTime)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryTime10).HasColumnName("DeliveryTime_10");

                entity.Property(e => e.DeliveryTime2).HasColumnName("DeliveryTime_2");

                entity.Property(e => e.DeliveryTime20).HasColumnName("DeliveryTime_20");

                entity.Property(e => e.DeliveryTime5).HasColumnName("DeliveryTime_5");

                entity.Property(e => e.DeliveryTimeOver20).HasColumnName("DeliveryTime_Over20");

                entity.Property(e => e.DeliveryTimeTtl).HasColumnName("DeliveryTimeTTL");

                entity.Property(e => e.ExportUnit)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.FinishedTtl).HasColumnName("FinishedTTL");

                entity.Property(e => e.QuickServiceFinishedYes).HasColumnName("QuickServiceFinished_Yes");

                entity.Property(e => e.QuickServiceRequest).HasColumnName("QuickService_Request");

                entity.Property(e => e.ThisHandlingTtl).HasColumnName("ThisHandlingTTL");

                entity.Property(e => e.ThisReturnTtl).HasColumnName("ThisReturnTTL");

                entity.Property(e => e.ThisServicingTtl).HasColumnName("ThisServicingTTL");

                entity.Property(e => e.ThisSr).HasColumnName("ThisSR");

                entity.Property(e => e.WarrantyPeriodBeforeSale).HasColumnName("WarrantyPeriod_BeforeSale");

                entity.Property(e => e.WarrantyPeriodExtended).HasColumnName("WarrantyPeriod_Extended");

                entity.Property(e => e.WarrantyPeriodIn).HasColumnName("WarrantyPeriod_In");

                entity.Property(e => e.WarrantyPeriodNotIn).HasColumnName("WarrantyPeriod_NotIn");
            });

            modelBuilder.Entity<MemMonitor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Mem_Monitor");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Objtype)
                    .HasColumnName("objtype")
                    .HasMaxLength(64);

                entity.Property(e => e.SizeInBytes)
                    .HasColumnName("size_in_bytes")
                    .HasMaxLength(64);

                entity.Property(e => e.Text).HasColumnName("text");

                entity.Property(e => e.Usecounts)
                    .HasColumnName("usecounts")
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<PnameDic>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PNAME_DIC");

                entity.Property(e => e.Honpartname)
                    .HasColumnName("HONPARTNAME")
                    .HasMaxLength(4000);

                entity.Property(e => e.Partcode)
                    .HasColumnName("PARTCODE")
                    .HasMaxLength(64);

                entity.Property(e => e.Partname)
                    .HasColumnName("PARTNAME")
                    .HasMaxLength(4000);

                entity.Property(e => e.Partnumber)
                    .IsRequired()
                    .HasColumnName("PARTNUMBER")
                    .HasMaxLength(64);

                entity.Property(e => e.Productcode)
                    .IsRequired()
                    .HasColumnName("PRODUCTCODE")
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<Temp4expenseoutstk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp4expenseoutstk");

                entity.Property(e => e.PartCode).HasMaxLength(64);
            });

            modelBuilder.Entity<TempCost>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp_Cost");

                entity.Property(e => e.Cost).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.PartCode)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<WebAccount>(entity =>
            {
                entity.HasKey(e => e.UserGuid);

                entity.ToTable("web_Account");

                entity.Property(e => e.UserGuid)
                    .HasColumnName("UserGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Creator)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(N'System')");

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.RecordVersion)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Updator)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(N'System')");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("UserID")
                    .HasMaxLength(64);

                entity.Property(e => e.UserPw)
                    .HasColumnName("UserPW")
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<WebCategory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("web_Category");

                entity.Property(e => e.CateCode)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<WebDataControl>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.ServiceMethod });

                entity.ToTable("web_DataControl");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(64);

                entity.Property(e => e.ServiceMethod).HasMaxLength(64);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Creator)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(N'System')");

                entity.Property(e => e.LastUpdateTime).HasColumnType("datetime");

                entity.Property(e => e.RecordId)
                    .IsRequired()
                    .HasColumnName("RecordID")
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.RecordVersion)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Updator)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(N'System')");
            });

            modelBuilder.Entity<WebProduct>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("web_Product");

                entity.Property(e => e.AvailableFlag)
                    .IsRequired()
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.CateCode).HasMaxLength(64);

                entity.Property(e => e.FullName).HasMaxLength(4000);

                entity.Property(e => e.KeepPeriodToYm)
                    .HasColumnName("KeepPeriodToYM")
                    .HasMaxLength(64);

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.ProdCode)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<WebReceipt>(entity =>
            {
                entity.HasKey(e => e.WebRcptGuid);

                entity.ToTable("web_Receipt");

                entity.HasIndex(e => e.RequestId);

                entity.HasIndex(e => e.TranId);

                entity.HasIndex(e => e.WebProdCode);

                entity.HasIndex(e => e.WebProdSn);

                entity.HasIndex(e => e.WebRcptNo);

                entity.Property(e => e.WebRcptGuid)
                    .HasColumnName("WebRcptGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Creator)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(N'System')");

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.RecordVersion)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.RequestId)
                    .IsRequired()
                    .HasColumnName("RequestID")
                    .HasMaxLength(64);

                entity.Property(e => e.TranId)
                    .IsRequired()
                    .HasColumnName("TranID")
                    .HasMaxLength(64);

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Updator)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(N'System')");

                entity.Property(e => e.WebAttachment).HasMaxLength(4000);

                entity.Property(e => e.WebComCode)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.WebContactAddress).HasMaxLength(64);

                entity.Property(e => e.WebContactMethod).HasMaxLength(64);

                entity.Property(e => e.WebContactPerson).HasMaxLength(64);

                entity.Property(e => e.WebMyNikonEmail).HasMaxLength(4000);

                entity.Property(e => e.WebMyNikonMobile).HasMaxLength(64);

                entity.Property(e => e.WebMyNikonName).HasMaxLength(64);

                entity.Property(e => e.WebNikkorId)
                    .HasColumnName("WebNikkorID")
                    .HasMaxLength(64);

                entity.Property(e => e.WebNikkorName).HasMaxLength(4000);

                entity.Property(e => e.WebProdCode)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.WebProdSn)
                    .IsRequired()
                    .HasColumnName("WebProdSN")
                    .HasMaxLength(64);

                entity.Property(e => e.WebRcptNo)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.WebSaleDate).HasColumnType("datetime");

                entity.Property(e => e.WebSubmitDate).HasColumnType("datetime");

                entity.Property(e => e.WebTroublePhenomenonEx).HasMaxLength(4000);
            });

            modelBuilder.Entity<WebReceiptA>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("web_Receipt_A");

                entity.Property(e => e.Accessary).HasMaxLength(4000);

                entity.Property(e => e.BranCodeMgt).HasMaxLength(64);

                entity.Property(e => e.Chargeable).HasMaxLength(64);

                entity.Property(e => e.CloseComment).HasMaxLength(4000);

                entity.Property(e => e.CloseDate).HasColumnType("datetime");

                entity.Property(e => e.ClosePerson).HasMaxLength(64);

                entity.Property(e => e.ContactAddress).HasMaxLength(4000);

                entity.Property(e => e.ContactPerson).HasMaxLength(4000);

                entity.Property(e => e.ContactZip).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(64);

                entity.Property(e => e.CustomerGuid)
                    .HasColumnName("CustomerGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.CustomerType).HasMaxLength(64);

                entity.Property(e => e.DeliveryBran).HasMaxLength(64);

                entity.Property(e => e.DeliveryMethod).HasMaxLength(64);

                entity.Property(e => e.DeliveryTime).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.DisRepairReason).HasMaxLength(64);

                entity.Property(e => e.DiscountAmt).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.DiscountComment).HasMaxLength(4000);

                entity.Property(e => e.DiscountRate).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.DiscountRateOwcomment)
                    .HasColumnName("DiscountRateOWComment")
                    .HasMaxLength(4000);

                entity.Property(e => e.DiscountReason).HasMaxLength(64);

                entity.Property(e => e.EstmContactDate).HasColumnType("datetime");

                entity.Property(e => e.EstmDiscountAmt).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.EstmDiscountComment).HasMaxLength(4000);

                entity.Property(e => e.EstmDiscountRate).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.EstmDiscountRateOwcomment)
                    .HasColumnName("EstmDiscountRateOWComment")
                    .HasMaxLength(4000);

                entity.Property(e => e.EstmDiscountReason).HasMaxLength(64);

                entity.Property(e => e.EstmLaborCharge).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.EstmOtherCharge).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.EstmOtherChargeReason).HasMaxLength(4000);

                entity.Property(e => e.EstmPartsAmt).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.EstmPerson).HasMaxLength(64);

                entity.Property(e => e.EstmPostFee).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.EstmReplyDate).HasColumnType("datetime");

                entity.Property(e => e.EstmTestCharge).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.ExchangeReason).HasMaxLength(64);

                entity.Property(e => e.FinishedContactComment).HasMaxLength(4000);

                entity.Property(e => e.FinishedContactDate).HasColumnType("datetime");

                entity.Property(e => e.FinishedContactPerson).HasMaxLength(64);

                entity.Property(e => e.Ivno)
                    .HasColumnName("IVNo")
                    .HasMaxLength(64);

                entity.Property(e => e.LaborCharge).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.LaboratoryResults).HasMaxLength(4000);

                entity.Property(e => e.OddHandlingType).HasMaxLength(64);

                entity.Property(e => e.OtherCharge).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.OtherChargeReason).HasMaxLength(4000);

                entity.Property(e => e.PartsAmt).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.PostComment).HasMaxLength(4000);

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.PostFee).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.PostPerson).HasMaxLength(64);

                entity.Property(e => e.ProdCode).HasMaxLength(64);

                entity.Property(e => e.ProdExchange).HasMaxLength(64);

                entity.Property(e => e.ProdSn)
                    .HasColumnName("ProdSN")
                    .HasMaxLength(64);

                entity.Property(e => e.ProdSta).HasMaxLength(64);

                entity.Property(e => e.QuickService).HasMaxLength(64);

                entity.Property(e => e.QuickServiceFinished).HasMaxLength(64);

                entity.Property(e => e.RcptBran).HasMaxLength(64);

                entity.Property(e => e.RcptComment).HasMaxLength(4000);

                entity.Property(e => e.RcptDate).HasColumnType("datetime");

                entity.Property(e => e.RcptGuid)
                    .IsRequired()
                    .HasColumnName("RcptGUID")
                    .HasMaxLength(64);

                entity.Property(e => e.RcptMethod).HasMaxLength(64);

                entity.Property(e => e.RcptNo).HasMaxLength(64);

                entity.Property(e => e.Rcptor).HasMaxLength(64);

                entity.Property(e => e.ReRepairType).HasMaxLength(64);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(64);

                entity.Property(e => e.RecordVersion).HasMaxLength(64);

                entity.Property(e => e.RepairContent).HasMaxLength(4000);

                entity.Property(e => e.RepairDate).HasColumnType("datetime");

                entity.Property(e => e.RepairPerson).HasMaxLength(64);

                entity.Property(e => e.RepairRank).HasMaxLength(64);

                entity.Property(e => e.RepairTime).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.RepairType).HasMaxLength(64);

                entity.Property(e => e.ResultCheckDate).HasColumnType("datetime");

                entity.Property(e => e.ResultCheckPerson).HasMaxLength(64);

                entity.Property(e => e.ReturnType).HasMaxLength(64);

                entity.Property(e => e.ServiceBran).HasMaxLength(64);

                entity.Property(e => e.ServiceType).HasMaxLength(64);

                entity.Property(e => e.Sex).HasMaxLength(64);

                entity.Property(e => e.SpecialRequest).HasMaxLength(4000);

                entity.Property(e => e.Srcomment)
                    .HasColumnName("SRComment")
                    .HasMaxLength(64);

                entity.Property(e => e.Srflag)
                    .HasColumnName("SRFlag")
                    .HasMaxLength(64);

                entity.Property(e => e.Srquality)
                    .HasColumnName("SRQuality")
                    .HasMaxLength(64);

                entity.Property(e => e.Srtype)
                    .HasColumnName("SRType")
                    .HasMaxLength(64);

                entity.Property(e => e.StaCode).HasMaxLength(64);

                entity.Property(e => e.StockRepairRank).HasMaxLength(64);

                entity.Property(e => e.TargetRepairDate).HasColumnType("datetime");

                entity.Property(e => e.TaxRate).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.TestCharge).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.TestDate).HasColumnType("datetime");

                entity.Property(e => e.Tester).HasMaxLength(64);

                entity.Property(e => e.TroublePhenomenonEx).HasMaxLength(4000);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Updator).HasMaxLength(64);

                entity.Property(e => e.ViaBran).HasMaxLength(64);

                entity.Property(e => e.Wait4PartsContactDate).HasColumnType("datetime");

                entity.Property(e => e.Wait4PartsContactMemo).HasMaxLength(4000);

                entity.Property(e => e.Wait4PartsContactPerson).HasMaxLength(64);

                entity.Property(e => e.WarrantyPeriod).HasMaxLength(64);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

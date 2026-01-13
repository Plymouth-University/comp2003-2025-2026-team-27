using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Lms.Data.Models.Delib;

public partial class DelibContext : DbContext
{
    public DelibContext()
    {
    }

    public DelibContext(DbContextOptions<DelibContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ABorAddressType> ABorAddressTypes { get; set; }

    public virtual DbSet<ABorOpacPicture> ABorOpacPictures { get; set; }

    public virtual DbSet<ABorPicture> ABorPictures { get; set; }

    public virtual DbSet<ABorQr> ABorQrs { get; set; }

    public virtual DbSet<ABorReadingChallengeList> ABorReadingChallengeLists { get; set; }

    public virtual DbSet<ABorReadingList> ABorReadingLists { get; set; }

    public virtual DbSet<ABorRecurringFee> ABorRecurringFees { get; set; }

    public virtual DbSet<ABorSavedSearch> ABorSavedSearches { get; set; }

    public virtual DbSet<ABorSearch> ABorSearches { get; set; }

    public virtual DbSet<ACalendar> ACalendars { get; set; }

    public virtual DbSet<ACatReadingList> ACatReadingLists { get; set; }

    public virtual DbSet<AFileSetLibCat> AFileSetLibCats { get; set; }

    public virtual DbSet<AOpacBorSearch> AOpacBorSearches { get; set; }

    public virtual DbSet<AOpacBorSearchAuthOrNonauth> AOpacBorSearchAuthOrNonauths { get; set; }

    public virtual DbSet<AOpacBorSearchCatFilter> AOpacBorSearchCatFilters { get; set; }

    public virtual DbSet<AOpacBorSearchDefinition> AOpacBorSearchDefinitions { get; set; }

    public virtual DbSet<AOpacBorWatchedVideo> AOpacBorWatchedVideos { get; set; }

    public virtual DbSet<ARef> ARefs { get; set; }

    public virtual DbSet<AReportCache> AReportCaches { get; set; }

    public virtual DbSet<AStkQr> AStkQrs { get; set; }

    public virtual DbSet<AccnoBudget> AccnoBudgets { get; set; }

    public virtual DbSet<AccnoGroup> AccnoGroups { get; set; }

    public virtual DbSet<AccnoGroupOld> AccnoGroupOlds { get; set; }

    public virtual DbSet<AccnoGroupTranslation> AccnoGroupTranslations { get; set; }

    public virtual DbSet<AccnoHdr> AccnoHdrs { get; set; }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<AccountBudget> AccountBudgets { get; set; }

    public virtual DbSet<AccountComponent> AccountComponents { get; set; }

    public virtual DbSet<AccountHdr> AccountHdrs { get; set; }

    public virtual DbSet<AccountHeader> AccountHeaders { get; set; }

    public virtual DbSet<AccountOld> AccountOlds { get; set; }

    public virtual DbSet<AccountTrType> AccountTrTypes { get; set; }

    public virtual DbSet<AccountTran> AccountTrans { get; set; }

    public virtual DbSet<AccountTranslation> AccountTranslations { get; set; }

    public virtual DbSet<ActEmailLog> ActEmailLogs { get; set; }

    public virtual DbSet<AdABorPicture> AdABorPictures { get; set; }

    public virtual DbSet<AdBorAddDatum> AdBorAddData { get; set; }

    public virtual DbSet<AdBorAddr> AdBorAddrs { get; set; }

    public virtual DbSet<AdBorHistory> AdBorHistories { get; set; }

    public virtual DbSet<AdBorrower> AdBorrowers { get; set; }

    public virtual DbSet<AdBorrowerLogin> AdBorrowerLogins { get; set; }

    public virtual DbSet<AdFinTran> AdFinTrans { get; set; }

    public virtual DbSet<AdStkItem> AdStkItems { get; set; }

    public virtual DbSet<AddrSystab> AddrSystabs { get; set; }

    public virtual DbSet<AmlibMedchief> AmlibMedchiefs { get; set; }

    public virtual DbSet<AmlibMedium> AmlibMedia { get; set; }

    public virtual DbSet<AspNetRole> AspNetRoles { get; set; }

    public virtual DbSet<AspNetUser> AspNetUsers { get; set; }

    public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }

    public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }

    public virtual DbSet<Assignment> Assignments { get; set; }

    public virtual DbSet<AtrSystab> AtrSystabs { get; set; }

    public virtual DbSet<BhnGroupBorrower> BhnGroupBorrowers { get; set; }

    public virtual DbSet<BoSystab> BoSystabs { get; set; }

    public virtual DbSet<BorAddDatum> BorAddData { get; set; }

    public virtual DbSet<BorAddr> BorAddrs { get; set; }

    public virtual DbSet<BorAlias> BorAliases { get; set; }

    public virtual DbSet<BorAnswer> BorAnswers { get; set; }

    public virtual DbSet<BorAnswerOld> BorAnswerOlds { get; set; }

    public virtual DbSet<BorBiometric> BorBiometrics { get; set; }

    public virtual DbSet<BorCircWork> BorCircWorks { get; set; }

    public virtual DbSet<BorColumnsViewConfig> BorColumnsViewConfigs { get; set; }

    public virtual DbSet<BorColumnsViewDetailsConfig> BorColumnsViewDetailsConfigs { get; set; }

    public virtual DbSet<BorCoursePeriod> BorCoursePeriods { get; set; }

    public virtual DbSet<BorDomainuser> BorDomainusers { get; set; }

    public virtual DbSet<BorFileImport> BorFileImports { get; set; }

    public virtual DbSet<BorFileMap> BorFileMaps { get; set; }

    public virtual DbSet<BorFriend> BorFriends { get; set; }

    public virtual DbSet<BorFriendStatus> BorFriendStatuses { get; set; }

    public virtual DbSet<BorGroupDetail> BorGroupDetails { get; set; }

    public virtual DbSet<BorGroupMsg> BorGroupMsgs { get; set; }

    public virtual DbSet<BorHistory> BorHistories { get; set; }

    public virtual DbSet<BorHistoryNote> BorHistoryNotes { get; set; }

    public virtual DbSet<BorImport> BorImports { get; set; }

    public virtual DbSet<BorInterestWork> BorInterestWorks { get; set; }

    public virtual DbSet<BorLearningdeliveryfam> BorLearningdeliveryfams { get; set; }

    public virtual DbSet<BorLlddandhealthproblem> BorLlddandhealthproblems { get; set; }

    public virtual DbSet<BorMemo> BorMemos { get; set; }

    public virtual DbSet<BorMessageRelThread> BorMessageRelThreads { get; set; }

    public virtual DbSet<BorMessageThread> BorMessageThreads { get; set; }

    public virtual DbSet<BorNote> BorNotes { get; set; }

    public virtual DbSet<BorOrder> BorOrders { get; set; }

    public virtual DbSet<BorOrderBasket> BorOrderBaskets { get; set; }

    public virtual DbSet<BorOrderDetail> BorOrderDetails { get; set; }

    public virtual DbSet<BorOrderPackage> BorOrderPackages { get; set; }

    public virtual DbSet<BorPayment> BorPayments { get; set; }

    public virtual DbSet<BorPaymentFinTran> BorPaymentFinTrans { get; set; }

    public virtual DbSet<BorPicImport> BorPicImports { get; set; }

    public virtual DbSet<BorPrePw> BorPrePws { get; set; }

    public virtual DbSet<BorQuestionComment> BorQuestionComments { get; set; }

    public virtual DbSet<BorQuestionCommentOld> BorQuestionCommentOlds { get; set; }

    public virtual DbSet<BorSpecial> BorSpecials { get; set; }

    public virtual DbSet<BorStatsbenefit> BorStatsbenefits { get; set; }

    public virtual DbSet<BorStreet> BorStreets { get; set; }

    public virtual DbSet<BorSurvey> BorSurveys { get; set; }

    public virtual DbSet<BorSurveyOld> BorSurveyOlds { get; set; }

    public virtual DbSet<BorToken> BorTokens { get; set; }

    public virtual DbSet<Borrower> Borrowers { get; set; }

    public virtual DbSet<BorrowerTeam> BorrowerTeams { get; set; }

    public virtual DbSet<BorrowerTransfLog> BorrowerTransfLogs { get; set; }

    public virtual DbSet<CashCount> CashCounts { get; set; }

    public virtual DbSet<CashTillReconcile> CashTillReconciles { get; set; }

    public virtual DbSet<CatBorLike> CatBorLikes { get; set; }

    public virtual DbSet<CatDynamicTemplate> CatDynamicTemplates { get; set; }

    public virtual DbSet<CatDynamicTemplateConfig> CatDynamicTemplateConfigs { get; set; }

    public virtual DbSet<Checkdigit> Checkdigits { get; set; }

    public virtual DbSet<CiBookFlag> CiBookFlags { get; set; }

    public virtual DbSet<CiBooking> CiBookings { get; set; }

    public virtual DbSet<CiDiscountDet> CiDiscountDets { get; set; }

    public virtual DbSet<CiDiscountList> CiDiscountLists { get; set; }

    public virtual DbSet<CiEquipment> CiEquipments { get; set; }

    public virtual DbSet<CiFacCost> CiFacCosts { get; set; }

    public virtual DbSet<CiFacGroup> CiFacGroups { get; set; }

    public virtual DbSet<CiFacGroupList> CiFacGroupLists { get; set; }

    public virtual DbSet<CiFacHour> CiFacHours { get; set; }

    public virtual DbSet<CiFacMaster> CiFacMasters { get; set; }

    public virtual DbSet<CiFacStatsCode> CiFacStatsCodes { get; set; }

    public virtual DbSet<CiFacility> CiFacilities { get; set; }

    public virtual DbSet<CiFileKeyword> CiFileKeywords { get; set; }

    public virtual DbSet<CiFileKwOper> CiFileKwOpers { get; set; }

    public virtual DbSet<CiHoliday> CiHolidays { get; set; }

    public virtual DbSet<CiStatsCode> CiStatsCodes { get; set; }

    public virtual DbSet<CiSysHeader> CiSysHeaders { get; set; }

    public virtual DbSet<CiUniqNum> CiUniqNums { get; set; }

    public virtual DbSet<CiWebDatum> CiWebData { get; set; }

    public virtual DbSet<CiWebHmtl> CiWebHmtls { get; set; }

    public virtual DbSet<CiWebSystab> CiWebSystabs { get; set; }

    public virtual DbSet<CircExportBor> CircExportBors { get; set; }

    public virtual DbSet<CircExportMemo> CircExportMemos { get; set; }

    public virtual DbSet<CircExportStk> CircExportStks { get; set; }

    public virtual DbSet<CircImportOffline> CircImportOfflines { get; set; }

    public virtual DbSet<CirculationTransfLog> CirculationTransfLogs { get; set; }

    public virtual DbSet<CivisionMedchief> CivisionMedchiefs { get; set; }

    public virtual DbSet<CivisionMedium> CivisionMedia { get; set; }

    public virtual DbSet<ClaimCode> ClaimCodes { get; set; }

    public virtual DbSet<ClaimCodesTran> ClaimCodesTrans { get; set; }

    public virtual DbSet<Convertfile> Convertfiles { get; set; }

    public virtual DbSet<CopyrightNotice> CopyrightNotices { get; set; }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<CoursePeriod> CoursePeriods { get; set; }

    public virtual DbSet<DelegateStatus> DelegateStatuses { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<DigitalHistory> DigitalHistories { get; set; }

    public virtual DbSet<DigitalWallet> DigitalWallets { get; set; }

    public virtual DbSet<Discussion> Discussions { get; set; }

    public virtual DbSet<Dynamiclabel> Dynamiclabels { get; set; }

    public virtual DbSet<DynamiclabelsTran> DynamiclabelsTrans { get; set; }

    public virtual DbSet<EventAdditionalService> EventAdditionalServices { get; set; }

    public virtual DbSet<FileSetDatum> FileSetData { get; set; }

    public virtual DbSet<FileSetName> FileSetNames { get; set; }

    public virtual DbSet<FileSetSystab> FileSetSystabs { get; set; }

    public virtual DbSet<FileWhere> FileWheres { get; set; }

    public virtual DbSet<FinAlloc> FinAllocs { get; set; }

    public virtual DbSet<FinAllocOld> FinAllocOlds { get; set; }

    public virtual DbSet<FinAllocTranslation> FinAllocTranslations { get; set; }

    public virtual DbSet<FinConfiguration> FinConfigurations { get; set; }

    public virtual DbSet<FinCurrency> FinCurrencies { get; set; }

    public virtual DbSet<FinCurrencyOld> FinCurrencyOlds { get; set; }

    public virtual DbSet<FinCurrencyTranslation> FinCurrencyTranslations { get; set; }

    public virtual DbSet<FinOwingWork> FinOwingWorks { get; set; }

    public virtual DbSet<FinStdJnl> FinStdJnls { get; set; }

    public virtual DbSet<FinSystab> FinSystabs { get; set; }

    public virtual DbSet<FinTaxAccount> FinTaxAccounts { get; set; }

    public virtual DbSet<FinTaxCode> FinTaxCodes { get; set; }

    public virtual DbSet<FinTaxCodesOld> FinTaxCodesOlds { get; set; }

    public virtual DbSet<FinTaxCodesTranslation> FinTaxCodesTranslations { get; set; }

    public virtual DbSet<FinTran> FinTrans { get; set; }

    public virtual DbSet<FinYear> FinYears { get; set; }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<GroupMember> GroupMembers { get; set; }

    public virtual DbSet<IllLibrary> IllLibraries { get; set; }

    public virtual DbSet<IllLibraryOld> IllLibraryOlds { get; set; }

    public virtual DbSet<IllLibraryTranslation> IllLibraryTranslations { get; set; }

    public virtual DbSet<IllService> IllServices { get; set; }

    public virtual DbSet<IllServicesTranslation> IllServicesTranslations { get; set; }

    public virtual DbSet<IlrAdditionalField> IlrAdditionalFields { get; set; }

    public virtual DbSet<IlrField> IlrFields { get; set; }

    public virtual DbSet<ImageTable> ImageTables { get; set; }

    public virtual DbSet<IssueAudit> IssueAudits { get; set; }

    public virtual DbSet<ItemSystab> ItemSystabs { get; set; }

    public virtual DbSet<LibLanguage> LibLanguages { get; set; }

    public virtual DbSet<LibLanguages1> LibLanguages1s { get; set; }

    public virtual DbSet<LibLanguages2> LibLanguages2s { get; set; }

    public virtual DbSet<LibLanguagesOld> LibLanguagesOlds { get; set; }

    public virtual DbSet<LibLanguagesOld2> LibLanguagesOld2s { get; set; }

    public virtual DbSet<LibLanguagesTemp> LibLanguagesTemps { get; set; }

    public virtual DbSet<LibOption> LibOptions { get; set; }

    public virtual DbSet<LibOptionLanguage> LibOptionLanguages { get; set; }

    public virtual DbSet<LibOptions1> LibOptions1s { get; set; }

    public virtual DbSet<LibSection> LibSections { get; set; }

    public virtual DbSet<LibSectionsOld> LibSectionsOlds { get; set; }

    public virtual DbSet<LibSectionsTranslation> LibSectionsTranslations { get; set; }

    public virtual DbSet<LibTab> LibTabs { get; set; }

    public virtual DbSet<LoadedApp> LoadedApps { get; set; }

    public virtual DbSet<Meeting> Meetings { get; set; }

    public virtual DbSet<MeetingDelegate> MeetingDelegates { get; set; }

    public virtual DbSet<MeetingStatus> MeetingStatuses { get; set; }

    public virtual DbSet<MigrationHistory> MigrationHistories { get; set; }

    public virtual DbSet<NcipStatus> NcipStatuses { get; set; }

    public virtual DbSet<NcipTransArchive> NcipTransArchives { get; set; }

    public virtual DbSet<NcipTransDetail> NcipTransDetails { get; set; }

    public virtual DbSet<NcipTransMaster> NcipTransMasters { get; set; }

    public virtual DbSet<OpacFileSetLibCat> OpacFileSetLibCats { get; set; }

    public virtual DbSet<Opacuseraction> Opacuseractions { get; set; }

    public virtual DbSet<Opacusercomment> Opacusercomments { get; set; }

    public virtual DbSet<Opacuserreply> Opacuserreplies { get; set; }

    public virtual DbSet<OperMessage> OperMessages { get; set; }

    public virtual DbSet<OrdComponent> OrdComponents { get; set; }

    public virtual DbSet<OrdGroup> OrdGroups { get; set; }

    public virtual DbSet<OrdHeader> OrdHeaders { get; set; }

    public virtual DbSet<OrdStkItem> OrdStkItems { get; set; }

    public virtual DbSet<OrdSystab> OrdSystabs { get; set; }

    public virtual DbSet<PaypalCountry> PaypalCountries { get; set; }

    public virtual DbSet<PerCopy> PerCopies { get; set; }

    public virtual DbSet<PerIssue> PerIssues { get; set; }

    public virtual DbSet<PerList> PerLists { get; set; }

    public virtual DbSet<PerName> PerNames { get; set; }

    public virtual DbSet<PerStock> PerStocks { get; set; }

    public virtual DbSet<PerSub> PerSubs { get; set; }

    public virtual DbSet<PerSubsFormat> PerSubsFormats { get; set; }

    public virtual DbSet<PerSubsInstruct> PerSubsInstructs { get; set; }

    public virtual DbSet<PerSupplier> PerSuppliers { get; set; }

    public virtual DbSet<PerSystab> PerSystabs { get; set; }

    public virtual DbSet<Periodical> Periodicals { get; set; }

    public virtual DbSet<RepOrder> RepOrders { get; set; }

    public virtual DbSet<RepPrint> RepPrints { get; set; }

    public virtual DbSet<RepPrintf> RepPrintfs { get; set; }

    public virtual DbSet<RepPrintr> RepPrintrs { get; set; }

    public virtual DbSet<RepSystab> RepSystabs { get; set; }

    public virtual DbSet<RepTypeDef> RepTypeDefs { get; set; }

    public virtual DbSet<RepWhere> RepWheres { get; set; }

    public virtual DbSet<ReportControl> ReportControls { get; set; }

    public virtual DbSet<ReportEmailAttachment> ReportEmailAttachments { get; set; }

    public virtual DbSet<ReportFile> ReportFiles { get; set; }

    public virtual DbSet<ReportNoText> ReportNoTexts { get; set; }

    public virtual DbSet<Reportw> Reportws { get; set; }

    public virtual DbSet<ResSystab> ResSystabs { get; set; }

    public virtual DbSet<Reservation> Reservations { get; set; }

    public virtual DbSet<RetentionCode> RetentionCodes { get; set; }

    public virtual DbSet<RotaScheduleHeader> RotaScheduleHeaders { get; set; }

    public virtual DbSet<RotaScheduleItem> RotaScheduleItems { get; set; }

    public virtual DbSet<RotaScheduleItemHistory> RotaScheduleItemHistories { get; set; }

    public virtual DbSet<RotaSchool> RotaSchools { get; set; }

    public virtual DbSet<RotaSchoolGroup> RotaSchoolGroups { get; set; }

    public virtual DbSet<RotaSchoolHistory> RotaSchoolHistories { get; set; }

    public virtual DbSet<RotaVehicle> RotaVehicles { get; set; }

    public virtual DbSet<RotaVehicleSchedule> RotaVehicleSchedules { get; set; }

    public virtual DbSet<RotaVehicleScheduleHistory> RotaVehicleScheduleHistories { get; set; }

    public virtual DbSet<SalesItem> SalesItems { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    public virtual DbSet<ServiceName> ServiceNames { get; set; }

    public virtual DbSet<SmsMessage> SmsMessages { get; set; }

    public virtual DbSet<SrSystab> SrSystabs { get; set; }

    public virtual DbSet<StatsCode> StatsCodes { get; set; }

    public virtual DbSet<StatsCodesOld> StatsCodesOlds { get; set; }

    public virtual DbSet<StatsCodesTranslation> StatsCodesTranslations { get; set; }

    public virtual DbSet<StkBookingEvent> StkBookingEvents { get; set; }

    public virtual DbSet<StkCheckMiss> StkCheckMisses { get; set; }

    public virtual DbSet<StkEventAttendance> StkEventAttendances { get; set; }

    public virtual DbSet<StkFormsCopyrightNotice> StkFormsCopyrightNotices { get; set; }

    public virtual DbSet<StkHistory> StkHistories { get; set; }

    public virtual DbSet<StkIll> StkIlls { get; set; }

    public virtual DbSet<StkItem> StkItems { get; set; }

    public virtual DbSet<StkItem880> StkItem880s { get; set; }

    public virtual DbSet<StkItemDiary> StkItemDiaries { get; set; }

    public virtual DbSet<StkItemPotentialCharge> StkItemPotentialCharges { get; set; }

    public virtual DbSet<StkMemo> StkMemos { get; set; }

    public virtual DbSet<StkReview> StkReviews { get; set; }

    public virtual DbSet<StkRotationPlan> StkRotationPlans { get; set; }

    public virtual DbSet<StkRotationPlanTran> StkRotationPlanTrans { get; set; }

    public virtual DbSet<StkRotationSequence> StkRotationSequences { get; set; }

    public virtual DbSet<StkSubscriber> StkSubscribers { get; set; }

    public virtual DbSet<StockTake> StockTakes { get; set; }

    public virtual DbSet<SupplierResponse> SupplierResponses { get; set; }

    public virtual DbSet<SupplierStatus> SupplierStatuses { get; set; }

    public virtual DbSet<Survey> Surveys { get; set; }

    public virtual DbSet<SurveyCategory> SurveyCategories { get; set; }

    public virtual DbSet<SurveyRestriction> SurveyRestrictions { get; set; }

    public virtual DbSet<SurveySmileyFaceImage> SurveySmileyFaceImages { get; set; }

    public virtual DbSet<SurveyType> SurveyTypes { get; set; }

    public virtual DbSet<SurveyTypesTranslation> SurveyTypesTranslations { get; set; }

    public virtual DbSet<SurveysAnswer> SurveysAnswers { get; set; }

    public virtual DbSet<SurveysQuestion> SurveysQuestions { get; set; }

    public virtual DbSet<SurveysStatus> SurveysStatuses { get; set; }

    public virtual DbSet<SysHeader> SysHeaders { get; set; }

    public virtual DbSet<SysSsheet> SysSsheets { get; set; }

    public virtual DbSet<Team> Teams { get; set; }

    public virtual DbSet<TeamsRetCode> TeamsRetCodes { get; set; }

    public virtual DbSet<TempBorAddrImport> TempBorAddrImports { get; set; }

    public virtual DbSet<TempBorImport> TempBorImports { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserBorClass> UserBorClasses { get; set; }

    public virtual DbSet<UserBorGroup> UserBorGroups { get; set; }

    public virtual DbSet<UserListDatum> UserListData { get; set; }

    public virtual DbSet<UserListName> UserListNames { get; set; }

    public virtual DbSet<VBorMainAddr> VBorMainAddrs { get; set; }

    public virtual DbSet<VBorrower> VBorrowers { get; set; }

    public virtual DbSet<VCashTill> VCashTills { get; set; }

    public virtual DbSet<VStkItem> VStkItems { get; set; }

    public virtual DbSet<VisBackupDb> VisBackupDbs { get; set; }

    public virtual DbSet<WaiveTran> WaiveTrans { get; set; }

    public virtual DbSet<WebHmtl> WebHmtls { get; set; }

    public virtual DbSet<WindowName> WindowNames { get; set; }

    public virtual DbSet<ZwebCache> ZwebCaches { get; set; }

    public virtual DbSet<ZwebMarcDatum> ZwebMarcData { get; set; }

    public virtual DbSet<ZwebOption> ZwebOptions { get; set; }

    public virtual DbSet<ZwebPageCache> ZwebPageCaches { get; set; }

    public virtual DbSet<ZwebQuery> ZwebQueries { get; set; }

    public virtual DbSet<ZwebScanCache> ZwebScanCaches { get; set; }

    public virtual DbSet<ZwebSystab> ZwebSystabs { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ABorAddressType>(entity =>
        {
            entity.HasKey(e => e.AddressTypeId).HasName("PK_A_ADDRESS_TYPE");

            entity.ToTable("A_BOR_ADDRESS_TYPE");

            entity.Property(e => e.AddressTypeId)
                .ValueGeneratedNever()
                .HasColumnName("ADDRESS_TYPE_ID");
            entity.Property(e => e.AdddressTypeDescription)
                .HasMaxLength(50)
                .HasColumnName("ADDDRESS_TYPE_DESCRIPTION");
        });

        modelBuilder.Entity<ABorOpacPicture>(entity =>
        {
            entity.HasKey(e => e.BorPicId);

            entity.ToTable("A_BOR_OPAC_PICTURE");

            entity.Property(e => e.BorPicId)
                .ValueGeneratedNever()
                .HasColumnName("BOR_PIC_ID");
            entity.Property(e => e.BorBarNo)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("BOR_BAR_NO");
            entity.Property(e => e.BorData).HasColumnName("BOR_DATA");
            entity.Property(e => e.BorPicDescription).HasColumnName("BOR_PIC_DESCRIPTION");
            entity.Property(e => e.BorPicFilename).HasColumnName("BOR_PIC_FILENAME");
            entity.Property(e => e.BorPicType).HasColumnName("BOR_PIC_TYPE");
            entity.Property(e => e.BorPicUsed)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("BOR_PIC_USED");
        });

        modelBuilder.Entity<ABorPicture>(entity =>
        {
            entity.HasKey(e => e.BorNo);

            entity.ToTable("A_BOR_PICTURE", tb => tb.HasTrigger("trg_bor_picture_audit"));

            entity.Property(e => e.BorNo)
                .ValueGeneratedNever()
                .HasColumnName("BOR_NO");
            entity.Property(e => e.BorPicData).HasColumnName("BOR_PIC_DATA");
            entity.Property(e => e.BorPicFilename)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BOR_PIC_FILENAME");
            entity.Property(e => e.BorPicType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BOR_PIC_TYPE");
        });

        modelBuilder.Entity<ABorQr>(entity =>
        {
            entity.HasKey(e => e.BorNo);

            entity.ToTable("A_BOR_QR");

            entity.Property(e => e.BorNo)
                .ValueGeneratedNever()
                .HasColumnName("BOR_NO");
            entity.Property(e => e.BorQrData).HasColumnName("BOR_QR_DATA");
            entity.Property(e => e.BorQrFilename)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BOR_QR_FILENAME");
            entity.Property(e => e.BorQrType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BOR_QR_TYPE");
        });

        modelBuilder.Entity<ABorReadingChallengeList>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("A_BOR_READING_CHALLENGE_LIST");

            entity.Property(e => e.BorBarNo)
                .HasMaxLength(75)
                .HasColumnName("BOR_BAR_NO");
            entity.Property(e => e.ChallengeCatNo).HasColumnName("CHALLENGE_CAT_NO");
            entity.Property(e => e.CurrentYear).HasColumnName("CURRENT_YEAR");
            entity.Property(e => e.DeleteFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DELETE_FLAG");
        });

        modelBuilder.Entity<ABorReadingList>(entity =>
        {
            entity.HasKey(e => e.ListId).HasName("PK_LISTS");

            entity.ToTable("A_BOR_READING_LIST");

            entity.Property(e => e.ListId)
                .ValueGeneratedNever()
                .HasColumnName("LIST_ID");
            entity.Property(e => e.BorBarNo)
                .HasMaxLength(75)
                .HasColumnName("BOR_BAR_NO");
            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DefaultList)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("DEFAULT_LIST");
            entity.Property(e => e.DeleteFlag)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("DELETE_FLAG");
            entity.Property(e => e.ListDescription)
                .HasMaxLength(250)
                .HasColumnName("LIST_DESCRIPTION");
            entity.Property(e => e.ListName)
                .HasMaxLength(50)
                .HasColumnName("LIST_NAME");
            entity.Property(e => e.ListType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LIST_TYPE");
            entity.Property(e => e.SubTypeId).HasColumnName("SUB_TYPE_ID");
        });

        modelBuilder.Entity<ABorRecurringFee>(entity =>
        {
            entity.HasKey(e => e.UniqueId).HasName("A_BOR_RECURRING_FEE_pk");

            entity.ToTable("A_BOR_RECURRING_FEE");

            entity.Property(e => e.UniqueId)
                .ValueGeneratedNever()
                .HasColumnName("UNIQUE_ID");
            entity.Property(e => e.AutoRenew).HasColumnName("AUTO_RENEW");
            entity.Property(e => e.BorBarNo)
                .HasMaxLength(75)
                .HasColumnName("BOR_BAR_NO");
            entity.Property(e => e.CancellationFee)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("CANCELLATION_FEE");
            entity.Property(e => e.DeleteFlag).HasColumnName("DELETE_FLAG");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.ExpirationDate)
                .HasColumnType("datetime")
                .HasColumnName("EXPIRATION_DATE");
            entity.Property(e => e.Fee)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("FEE");
            entity.Property(e => e.Frequency)
                .HasMaxLength(10)
                .HasColumnName("FREQUENCY");
            entity.Property(e => e.Startdate)
                .HasColumnType("datetime")
                .HasColumnName("STARTDATE");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasColumnName("STATUS");
            entity.Property(e => e.StkItemNo)
                .HasMaxLength(25)
                .HasColumnName("STK_ITEM_NO");
        });

        modelBuilder.Entity<ABorSavedSearch>(entity =>
        {
            entity.HasKey(e => e.SearchesId).HasName("PK_SAVED_SEARCHES_1");

            entity.ToTable("A_BOR_SAVED_SEARCHES");

            entity.Property(e => e.SearchesId)
                .ValueGeneratedNever()
                .HasColumnName("SEARCHES_ID");
            entity.Property(e => e.BorBarNo)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("BOR_BAR_NO");
        });

        modelBuilder.Entity<ABorSearch>(entity =>
        {
            entity.HasKey(e => new { e.SsId, e.SearchId }).HasName("PK_A_SEARCH");

            entity.ToTable("A_BOR_SEARCH");

            entity.Property(e => e.SsId).HasColumnName("SS_ID");
            entity.Property(e => e.SearchId).HasColumnName("SEARCH_ID");
            entity.Property(e => e.Etype).HasColumnName("EType");
            entity.Property(e => e.Keyword).HasMaxLength(50);
            entity.Property(e => e.Location).HasMaxLength(50);
            entity.Property(e => e.LocationName).HasMaxLength(50);
            entity.Property(e => e.Operator).HasMaxLength(50);
            entity.Property(e => e.Parameter).HasMaxLength(50);
            entity.Property(e => e.Result).HasMaxLength(50);

            entity.HasOne(d => d.Ss).WithMany(p => p.ABorSearches)
                .HasForeignKey(d => d.SsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_A_SEARCH_SAVED_SEARCHES");
        });

        modelBuilder.Entity<ACalendar>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("A_CALENDAR");

            entity.Property(e => e.Day).HasColumnName("DAY");
            entity.Property(e => e.IsWeekend).HasColumnName("IS_WEEKEND");
            entity.Property(e => e.TheDate).HasColumnName("THE_DATE");
            entity.Property(e => e.TheDayName)
                .HasMaxLength(15)
                .HasColumnName("THE_DAY_NAME");
        });

        modelBuilder.Entity<ACatReadingList>(entity =>
        {
            entity.HasKey(e => new { e.ListId, e.CatNo }).HasName("PK_ITEM_LIST");

            entity.ToTable("A_CAT_READING_LIST");

            entity.Property(e => e.ListId).HasColumnName("LIST_ID");
            entity.Property(e => e.CatNo).HasColumnName("CAT_NO");
            entity.Property(e => e.CreateDatetime)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATETIME");
            entity.Property(e => e.Priority).HasColumnName("PRIORITY");

            entity.HasOne(d => d.List).WithMany(p => p.ACatReadingLists)
                .HasForeignKey(d => d.ListId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ITEM_LIST_LISTS");
        });

        modelBuilder.Entity<AFileSetLibCat>(entity =>
        {
            entity.HasKey(e => new { e.FileNumberLib, e.FileNumberCat }).HasName("PK_FILE_SET_LIB_CAT");

            entity.ToTable("A_FILE_SET_LIB_CAT");

            entity.Property(e => e.FileNumberLib).HasColumnName("FILE_NUMBER_LIB");
            entity.Property(e => e.FileNumberCat).HasColumnName("FILE_NUMBER_CAT");
            entity.Property(e => e.ExpirationDate)
                .HasColumnType("datetime")
                .HasColumnName("EXPIRATION_DATE");
            entity.Property(e => e.LastModifyBy)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("LAST_MODIFY_BY");
            entity.Property(e => e.LastModifyOn)
                .HasColumnType("datetime")
                .HasColumnName("LAST_MODIFY_ON");
        });

        modelBuilder.Entity<AOpacBorSearch>(entity =>
        {
            entity.HasKey(e => e.SearchId).HasName("PK_A_OPAC_BOR_SEARCH_1");

            entity.ToTable("A_OPAC_BOR_SEARCH");

            entity.Property(e => e.SearchId)
                .ValueGeneratedNever()
                .HasColumnName("SEARCH_ID");
            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");
            entity.Property(e => e.CatOrderColumn)
                .HasMaxLength(100)
                .HasColumnName("CAT_ORDER_COLUMN");
            entity.Property(e => e.LlCode)
                .HasMaxLength(20)
                .HasColumnName("LL_CODE");
            entity.Property(e => e.QuantityResult).HasColumnName("QUANTITY_RESULT");
            entity.Property(e => e.ShortDescription)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("SHORT_DESCRIPTION");
            entity.Property(e => e.StkCode)
                .HasMaxLength(3)
                .HasColumnName("STK_CODE");
            entity.Property(e => e.StkForm)
                .HasMaxLength(3)
                .HasColumnName("STK_FORM");
            entity.Property(e => e.StkGroup)
                .HasMaxLength(3)
                .HasColumnName("STK_GROUP");
            entity.Property(e => e.StkIsOnLoan)
                .HasMaxLength(1)
                .HasColumnName("STK_IS_ON_LOAN");
            entity.Property(e => e.StkIsOnOrder)
                .HasMaxLength(1)
                .HasColumnName("STK_IS_ON_ORDER");
            entity.Property(e => e.StkIsReserved).HasColumnName("STK_IS_RESERVED");
        });

        modelBuilder.Entity<AOpacBorSearchAuthOrNonauth>(entity =>
        {
            entity.HasKey(e => new { e.SearchId, e.SubSearchId });

            entity.ToTable("A_OPAC_BOR_SEARCH_AUTH_OR_NONAUTH");

            entity.Property(e => e.SearchId).HasColumnName("SEARCH_ID");
            entity.Property(e => e.SubSearchId).HasColumnName("SUB_SEARCH_ID");
            entity.Property(e => e.Isauth).HasColumnName("ISAUTH");
            entity.Property(e => e.KdCode)
                .HasMaxLength(2)
                .HasColumnName("KD_CODE");
            entity.Property(e => e.Keyword)
                .HasMaxLength(100)
                .HasColumnName("KEYWORD");
            entity.Property(e => e.PreOperator)
                .HasMaxLength(8)
                .HasColumnName("PRE_OPERATOR");
            entity.Property(e => e.TnWhere)
                .HasMaxLength(200)
                .HasColumnName("TN_WHERE");
        });

        modelBuilder.Entity<AOpacBorSearchCatFilter>(entity =>
        {
            entity.HasKey(e => new { e.SearchId, e.CatFilterId });

            entity.ToTable("A_OPAC_BOR_SEARCH_CAT_FILTER");

            entity.Property(e => e.SearchId).HasColumnName("SEARCH_ID");
            entity.Property(e => e.CatFilterId).HasColumnName("CAT_FILTER_ID");
            entity.Property(e => e.CatColumn)
                .HasMaxLength(100)
                .HasColumnName("CAT_COLUMN");
            entity.Property(e => e.FilterDatetimeValue)
                .HasColumnType("datetime")
                .HasColumnName("FILTER_DATETIME_VALUE");
            entity.Property(e => e.FilterOperator)
                .HasMaxLength(15)
                .HasColumnName("FILTER_OPERATOR");
            entity.Property(e => e.FilterStrValue)
                .HasMaxLength(50)
                .HasColumnName("FILTER_STR_VALUE");

            entity.HasOne(d => d.Search).WithMany(p => p.AOpacBorSearchCatFilters)
                .HasForeignKey(d => d.SearchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_A_DEF_SEARCH_CAT_FIL");
        });

        modelBuilder.Entity<AOpacBorSearchDefinition>(entity =>
        {
            entity.HasKey(e => new { e.SearchId, e.SubSearchId });

            entity.ToTable("A_OPAC_BOR_SEARCH_DEFINITION");

            entity.Property(e => e.SearchId).HasColumnName("SEARCH_ID");
            entity.Property(e => e.SubSearchId).HasColumnName("SUB_SEARCH_ID");
            entity.Property(e => e.KdCode)
                .HasMaxLength(2)
                .HasColumnName("KD_CODE");
            entity.Property(e => e.Keyword)
                .HasMaxLength(100)
                .HasColumnName("KEYWORD");
            entity.Property(e => e.PreOperator)
                .HasMaxLength(8)
                .HasColumnName("PRE_OPERATOR");
            entity.Property(e => e.QueryOptionType).HasColumnName("QUERY_OPTION_TYPE");
            entity.Property(e => e.TnWhere)
                .HasMaxLength(200)
                .HasColumnName("TN_WHERE");

            entity.HasOne(d => d.Search).WithMany(p => p.AOpacBorSearchDefinitions)
                .HasForeignKey(d => d.SearchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_A_OPAC_BOR_SEARCH_REF_DEF");
        });

        modelBuilder.Entity<AOpacBorWatchedVideo>(entity =>
        {
            entity.HasKey(e => new { e.BorBarNo, e.VideoCatNo }).HasName("A_OPAC_BOR_WATCHED_VIDEO_pk");

            entity.ToTable("A_OPAC_BOR_WATCHED_VIDEO");

            entity.Property(e => e.BorBarNo)
                .HasMaxLength(75)
                .HasColumnName("BOR_BAR_NO");
            entity.Property(e => e.VideoCatNo).HasColumnName("VIDEO_CAT_NO");
            entity.Property(e => e.CreateDatetime)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATETIME");
        });

        modelBuilder.Entity<ARef>(entity =>
        {
            entity.HasKey(e => e.Ref);

            entity.ToTable("A_REF");

            entity.Property(e => e.Ref)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("REF");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("LAST_UPDATED_BY");
            entity.Property(e => e.LastUpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATED_ON");
            entity.Property(e => e.Value).HasColumnName("VALUE");
        });

        modelBuilder.Entity<AReportCache>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("A_REPORT_CACHE");

            entity.HasIndex(e => new { e.OperName, e.SessionId }, "IX_A_REPORT_CACHE");

            entity.Property(e => e.ColumnBinary1)
                .HasMaxLength(1)
                .HasColumnName("COLUMN_BINARY1");
            entity.Property(e => e.ColumnBinary2)
                .HasMaxLength(1)
                .HasColumnName("COLUMN_BINARY2");
            entity.Property(e => e.ColumnChar1)
                .HasMaxLength(240)
                .HasColumnName("COLUMN_CHAR1");
            entity.Property(e => e.ColumnChar10)
                .HasMaxLength(240)
                .HasColumnName("COLUMN_CHAR10");
            entity.Property(e => e.ColumnChar11)
                .HasMaxLength(240)
                .HasColumnName("COLUMN_CHAR11");
            entity.Property(e => e.ColumnChar12)
                .HasMaxLength(240)
                .HasColumnName("COLUMN_CHAR12");
            entity.Property(e => e.ColumnChar13)
                .HasMaxLength(240)
                .HasColumnName("COLUMN_CHAR13");
            entity.Property(e => e.ColumnChar14)
                .HasMaxLength(240)
                .HasColumnName("COLUMN_CHAR14");
            entity.Property(e => e.ColumnChar15)
                .HasMaxLength(240)
                .HasColumnName("COLUMN_CHAR15");
            entity.Property(e => e.ColumnChar16)
                .HasMaxLength(240)
                .HasColumnName("COLUMN_CHAR16");
            entity.Property(e => e.ColumnChar17)
                .HasMaxLength(240)
                .HasColumnName("COLUMN_CHAR17");
            entity.Property(e => e.ColumnChar18)
                .HasMaxLength(240)
                .HasColumnName("COLUMN_CHAR18");
            entity.Property(e => e.ColumnChar19)
                .HasMaxLength(240)
                .HasColumnName("COLUMN_CHAR19");
            entity.Property(e => e.ColumnChar2)
                .HasMaxLength(240)
                .HasColumnName("COLUMN_CHAR2");
            entity.Property(e => e.ColumnChar20)
                .HasMaxLength(240)
                .HasColumnName("COLUMN_CHAR20");
            entity.Property(e => e.ColumnChar3)
                .HasMaxLength(240)
                .HasColumnName("COLUMN_CHAR3");
            entity.Property(e => e.ColumnChar4)
                .HasMaxLength(240)
                .HasColumnName("COLUMN_CHAR4");
            entity.Property(e => e.ColumnChar5)
                .HasMaxLength(240)
                .HasColumnName("COLUMN_CHAR5");
            entity.Property(e => e.ColumnChar6)
                .HasMaxLength(240)
                .HasColumnName("COLUMN_CHAR6");
            entity.Property(e => e.ColumnChar7)
                .HasMaxLength(240)
                .HasColumnName("COLUMN_CHAR7");
            entity.Property(e => e.ColumnChar8)
                .HasMaxLength(240)
                .HasColumnName("COLUMN_CHAR8");
            entity.Property(e => e.ColumnChar9)
                .HasMaxLength(240)
                .HasColumnName("COLUMN_CHAR9");
            entity.Property(e => e.ColumnDatetime1)
                .HasColumnType("datetime")
                .HasColumnName("COLUMN_DATETIME1");
            entity.Property(e => e.ColumnDatetime2)
                .HasColumnType("datetime")
                .HasColumnName("COLUMN_DATETIME2");
            entity.Property(e => e.ColumnDatetime3)
                .HasColumnType("datetime")
                .HasColumnName("COLUMN_DATETIME3");
            entity.Property(e => e.ColumnDatetime4)
                .HasColumnType("datetime")
                .HasColumnName("COLUMN_DATETIME4");
            entity.Property(e => e.ColumnDatetime5)
                .HasColumnType("datetime")
                .HasColumnName("COLUMN_DATETIME5");
            entity.Property(e => e.ColumnNumeric1)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("COLUMN_NUMERIC1");
            entity.Property(e => e.ColumnNumeric10)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("COLUMN_NUMERIC10");
            entity.Property(e => e.ColumnNumeric11)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("COLUMN_NUMERIC11");
            entity.Property(e => e.ColumnNumeric12)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("COLUMN_NUMERIC12");
            entity.Property(e => e.ColumnNumeric13)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("COLUMN_NUMERIC13");
            entity.Property(e => e.ColumnNumeric14)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("COLUMN_NUMERIC14");
            entity.Property(e => e.ColumnNumeric15)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("COLUMN_NUMERIC15");
            entity.Property(e => e.ColumnNumeric16)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("COLUMN_NUMERIC16");
            entity.Property(e => e.ColumnNumeric17)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("COLUMN_NUMERIC17");
            entity.Property(e => e.ColumnNumeric18)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("COLUMN_NUMERIC18");
            entity.Property(e => e.ColumnNumeric19)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("COLUMN_NUMERIC19");
            entity.Property(e => e.ColumnNumeric2)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("COLUMN_NUMERIC2");
            entity.Property(e => e.ColumnNumeric20)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("COLUMN_NUMERIC20");
            entity.Property(e => e.ColumnNumeric3)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("COLUMN_NUMERIC3");
            entity.Property(e => e.ColumnNumeric4)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("COLUMN_NUMERIC4");
            entity.Property(e => e.ColumnNumeric5)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("COLUMN_NUMERIC5");
            entity.Property(e => e.ColumnNumeric6)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("COLUMN_NUMERIC6");
            entity.Property(e => e.ColumnNumeric7)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("COLUMN_NUMERIC7");
            entity.Property(e => e.ColumnNumeric8)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("COLUMN_NUMERIC8");
            entity.Property(e => e.ColumnNumeric9)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("COLUMN_NUMERIC9");
            entity.Property(e => e.ColumnText1).HasColumnName("COLUMN_TEXT1");
            entity.Property(e => e.ColumnText2).HasColumnName("COLUMN_TEXT2");
            entity.Property(e => e.ColumnText3).HasColumnName("COLUMN_TEXT3");
            entity.Property(e => e.ColumnText4).HasColumnName("COLUMN_TEXT4");
            entity.Property(e => e.ColumnText5).HasColumnName("COLUMN_TEXT5");
            entity.Property(e => e.OperName)
                .HasMaxLength(25)
                .HasColumnName("OPER_NAME");
            entity.Property(e => e.SessionId)
                .HasMaxLength(50)
                .HasColumnName("SESSION_ID");
        });

        modelBuilder.Entity<AStkQr>(entity =>
        {
            entity.HasKey(e => e.UniqueItemNo);

            entity.ToTable("A_STK_QR");

            entity.Property(e => e.UniqueItemNo)
                .ValueGeneratedNever()
                .HasColumnName("UNIQUE_ITEM_NO");
            entity.Property(e => e.StkItemNo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("STK_ITEM_NO");
            entity.Property(e => e.StkQrData).HasColumnName("STK_QR_DATA");
            entity.Property(e => e.StkQrType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STK_QR_TYPE");
        });

        modelBuilder.Entity<AccnoBudget>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ACCNO_BUDGET");

            entity.Property(e => e.AnbBudget)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("ANB_BUDGET");
            entity.Property(e => e.AnbGroup)
                .HasMaxLength(8)
                .HasColumnName("ANB_GROUP");
            entity.Property(e => e.AnbGroup1)
                .HasMaxLength(20)
                .HasColumnName("ANB_GROUP1");
            entity.Property(e => e.AnbGroup2)
                .HasMaxLength(20)
                .HasColumnName("ANB_GROUP2");
            entity.Property(e => e.AnbGroup3)
                .HasMaxLength(20)
                .HasColumnName("ANB_GROUP3");
            entity.Property(e => e.AnbGroup4)
                .HasMaxLength(20)
                .HasColumnName("ANB_GROUP4");
            entity.Property(e => e.AnbLibGroup)
                .HasMaxLength(30)
                .HasColumnName("ANB_LIB_GROUP");
            entity.Property(e => e.AnbPrevactual)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("ANB_PREVACTUAL");
            entity.Property(e => e.AnbPrevyear).HasColumnName("ANB_PREVYEAR");
            entity.Property(e => e.AnbYear).HasColumnName("ANB_YEAR");
        });

        modelBuilder.Entity<AccnoGroup>(entity =>
        {
            entity.HasKey(e => new { e.AccnoLibGroup, e.AccnoCode });

            entity.ToTable("ACCNO_GROUP");

            entity.Property(e => e.AccnoLibGroup)
                .HasMaxLength(30)
                .HasColumnName("ACCNO_LIB_GROUP");
            entity.Property(e => e.AccnoCode)
                .HasMaxLength(30)
                .HasColumnName("ACCNO_CODE");
            entity.Property(e => e.AccnoCodeDesc)
                .HasMaxLength(50)
                .HasColumnName("ACCNO_CODE_DESC");
            entity.Property(e => e.AccnoCodeLevel).HasColumnName("ACCNO_CODE_LEVEL");
            entity.Property(e => e.AccnoStop).HasColumnName("ACCNO_STOP");
        });

        modelBuilder.Entity<AccnoGroupOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ACCNO_GROUP_OLD");

            entity.Property(e => e.AccnoCode)
                .HasMaxLength(30)
                .HasColumnName("ACCNO_CODE");
            entity.Property(e => e.AccnoCodeDesc)
                .HasMaxLength(50)
                .HasColumnName("ACCNO_CODE_DESC");
            entity.Property(e => e.AccnoCodeLevel).HasColumnName("ACCNO_CODE_LEVEL");
            entity.Property(e => e.AccnoLibGroup)
                .HasMaxLength(30)
                .HasColumnName("ACCNO_LIB_GROUP");
            entity.Property(e => e.AccnoStop).HasColumnName("ACCNO_STOP");
        });

        modelBuilder.Entity<AccnoGroupTranslation>(entity =>
        {
            entity.HasKey(e => new { e.Lcid, e.AccnoLibGroup, e.AccnoCode });

            entity.ToTable("ACCNO_GROUP_TRANSLATION");

            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.AccnoLibGroup)
                .HasMaxLength(30)
                .HasColumnName("ACCNO_LIB_GROUP");
            entity.Property(e => e.AccnoCode)
                .HasMaxLength(30)
                .HasColumnName("ACCNO_CODE");
            entity.Property(e => e.AccnoCodeDesc)
                .HasMaxLength(50)
                .HasColumnName("ACCNO_CODE_DESC");

            entity.HasOne(d => d.AccnoGroup).WithMany(p => p.AccnoGroupTranslations)
                .HasForeignKey(d => new { d.AccnoLibGroup, d.AccnoCode })
                .HasConstraintName("FK_ACCNO_GROUP_ACCNO_GROUP_TRANSLATION");
        });

        modelBuilder.Entity<AccnoHdr>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ACCNO_HDR");

            entity.Property(e => e.AnhActual)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("ANH_ACTUAL");
            entity.Property(e => e.AnhBudget)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("ANH_BUDGET");
            entity.Property(e => e.AnhCommit)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("ANH_COMMIT");
            entity.Property(e => e.AnhDesc)
                .HasMaxLength(50)
                .HasColumnName("ANH_DESC");
            entity.Property(e => e.AnhGroup1)
                .HasMaxLength(10)
                .HasColumnName("ANH_GROUP1");
            entity.Property(e => e.AnhGroup2)
                .HasMaxLength(10)
                .HasColumnName("ANH_GROUP2");
            entity.Property(e => e.AnhGroup3)
                .HasMaxLength(10)
                .HasColumnName("ANH_GROUP3");
            entity.Property(e => e.AnhGroup4)
                .HasMaxLength(10)
                .HasColumnName("ANH_GROUP4");
            entity.Property(e => e.AnhLibGroup)
                .HasMaxLength(30)
                .HasColumnName("ANH_LIB_GROUP");
            entity.Property(e => e.AnhUnique).HasColumnName("ANH_UNIQUE");
            entity.Property(e => e.AnhYear).HasColumnName("ANH_YEAR");
        });

        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => new { e.AccnoLibGroup, e.Accno });

            entity.ToTable("ACCOUNT");

            entity.Property(e => e.AccnoLibGroup)
                .HasMaxLength(30)
                .HasColumnName("ACCNO_LIB_GROUP");
            entity.Property(e => e.Accno)
                .HasMaxLength(30)
                .HasColumnName("ACCNO");
            entity.Property(e => e.AccnoCode1)
                .HasMaxLength(10)
                .HasColumnName("ACCNO_CODE1");
            entity.Property(e => e.AccnoCode2)
                .HasMaxLength(10)
                .HasColumnName("ACCNO_CODE2");
            entity.Property(e => e.AccnoCode3)
                .HasMaxLength(10)
                .HasColumnName("ACCNO_CODE3");
            entity.Property(e => e.AccnoCode4)
                .HasMaxLength(10)
                .HasColumnName("ACCNO_CODE4");
            entity.Property(e => e.AccnoDesc)
                .HasMaxLength(100)
                .HasColumnName("ACCNO_DESC");
            entity.Property(e => e.AccnoStop).HasColumnName("ACCNO_STOP");
            entity.Property(e => e.AccnoType)
                .HasMaxLength(1)
                .HasColumnName("ACCNO_TYPE");
        });

        modelBuilder.Entity<AccountBudget>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ACCOUNT_BUDGET");

            entity.Property(e => e.AcbAccount)
                .HasMaxLength(30)
                .HasColumnName("ACB_ACCOUNT");
            entity.Property(e => e.AcbBudget)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("ACB_BUDGET");
            entity.Property(e => e.AcbLibGroup)
                .HasMaxLength(30)
                .HasColumnName("ACB_LIB_GROUP");
            entity.Property(e => e.AcbYear).HasColumnName("ACB_YEAR");
        });

        modelBuilder.Entity<AccountComponent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ACCOUNT_COMPONENT");

            entity.HasIndex(e => e.AcCompNo, "AC_COMP_NOX").IsUnique();

            entity.HasIndex(e => e.AcHeaderNo, "AC_HEADER_NOX");

            entity.HasIndex(e => new { e.AcOrderNo, e.AcOrderLno }, "AC_ORDER_NOLNX");

            entity.Property(e => e.AcAccno)
                .HasMaxLength(30)
                .HasColumnName("AC_ACCNO");
            entity.Property(e => e.AcAlloc)
                .HasMaxLength(10)
                .HasColumnName("AC_ALLOC");
            entity.Property(e => e.AcCompNo).HasColumnName("AC_COMP_NO");
            entity.Property(e => e.AcCost)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("AC_COST");
            entity.Property(e => e.AcDiscount)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("AC_DISCOUNT");
            entity.Property(e => e.AcDiscountInd)
                .HasMaxLength(1)
                .HasColumnName("AC_DISCOUNT_IND");
            entity.Property(e => e.AcHeaderNo).HasColumnName("AC_HEADER_NO");
            entity.Property(e => e.AcLine1)
                .HasMaxLength(100)
                .HasColumnName("AC_LINE1");
            entity.Property(e => e.AcLine2)
                .HasMaxLength(100)
                .HasColumnName("AC_LINE2");
            entity.Property(e => e.AcLineNo).HasColumnName("AC_LINE_NO");
            entity.Property(e => e.AcNotes)
                .HasMaxLength(250)
                .HasColumnName("AC_NOTES");
            entity.Property(e => e.AcOrderLno).HasColumnName("AC_ORDER_LNO");
            entity.Property(e => e.AcOrderNo)
                .HasMaxLength(25)
                .HasColumnName("AC_ORDER_NO");
            entity.Property(e => e.AcQtyInvoiced).HasColumnName("AC_QTY_INVOICED");
            entity.Property(e => e.AcStockitemyn)
                .HasMaxLength(1)
                .HasColumnName("AC_STOCKITEMYN");
            entity.Property(e => e.AcTaxAccno)
                .HasMaxLength(30)
                .HasColumnName("AC_TAX_ACCNO");
            entity.Property(e => e.AcTaxCode)
                .HasMaxLength(4)
                .HasColumnName("AC_TAX_CODE");
            entity.Property(e => e.AcTaxRate)
                .HasColumnType("decimal(10, 4)")
                .HasColumnName("AC_TAX_RATE");
            entity.Property(e => e.AcTaxTranNo).HasColumnName("AC_TAX_TRAN_NO");
            entity.Property(e => e.AcTotal)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("AC_TOTAL");
            entity.Property(e => e.AcTranNo).HasColumnName("AC_TRAN_NO");
        });

        modelBuilder.Entity<AccountHdr>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ACCOUNT_HDR");

            entity.Property(e => e.AchAccount)
                .HasMaxLength(30)
                .HasColumnName("ACH_ACCOUNT");
            entity.Property(e => e.AchActual)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("ACH_ACTUAL");
            entity.Property(e => e.AchBudget)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("ACH_BUDGET");
            entity.Property(e => e.AchCommit)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("ACH_COMMIT");
            entity.Property(e => e.AchDesc)
                .HasMaxLength(50)
                .HasColumnName("ACH_DESC");
            entity.Property(e => e.AchGroup1)
                .HasMaxLength(10)
                .HasColumnName("ACH_GROUP1");
            entity.Property(e => e.AchGroup2)
                .HasMaxLength(10)
                .HasColumnName("ACH_GROUP2");
            entity.Property(e => e.AchGroup3)
                .HasMaxLength(10)
                .HasColumnName("ACH_GROUP3");
            entity.Property(e => e.AchGroup4)
                .HasMaxLength(10)
                .HasColumnName("ACH_GROUP4");
            entity.Property(e => e.AchLibGroup)
                .HasMaxLength(30)
                .HasColumnName("ACH_LIB_GROUP");
            entity.Property(e => e.AchUnique).HasColumnName("ACH_UNIQUE");
            entity.Property(e => e.AchUnique1).HasColumnName("ACH_UNIQUE1");
            entity.Property(e => e.AchUnique2).HasColumnName("ACH_UNIQUE2");
            entity.Property(e => e.AchUnique3).HasColumnName("ACH_UNIQUE3");
            entity.Property(e => e.AchUnique4).HasColumnName("ACH_UNIQUE4");
            entity.Property(e => e.AchYear).HasColumnName("ACH_YEAR");
        });

        modelBuilder.Entity<AccountHeader>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ACCOUNT_HEADER");

            entity.HasIndex(e => e.AhHeaderNo, "AH_HEADER_NOX").IsUnique();

            entity.HasIndex(e => e.AhInvoiceNo, "AH_INVOICE_NOX");

            entity.HasIndex(e => e.AhSuppNo, "AH_SUPP_NOX");

            entity.Property(e => e.AhCost)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("AH_COST");
            entity.Property(e => e.AhDatetime)
                .HasColumnType("datetime")
                .HasColumnName("AH_DATETIME");
            entity.Property(e => e.AhFccode)
                .HasMaxLength(4)
                .HasColumnName("AH_FCCODE");
            entity.Property(e => e.AhFcdate)
                .HasColumnType("datetime")
                .HasColumnName("AH_FCDATE");
            entity.Property(e => e.AhFcrate)
                .HasColumnType("decimal(10, 4)")
                .HasColumnName("AH_FCRATE");
            entity.Property(e => e.AhFcvalue)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("AH_FCVALUE");
            entity.Property(e => e.AhHeaderNo).HasColumnName("AH_HEADER_NO");
            entity.Property(e => e.AhInvoiceDate)
                .HasColumnType("datetime")
                .HasColumnName("AH_INVOICE_DATE");
            entity.Property(e => e.AhInvoiceNo)
                .HasMaxLength(25)
                .HasColumnName("AH_INVOICE_NO");
            entity.Property(e => e.AhLibGroup)
                .HasMaxLength(30)
                .HasColumnName("AH_LIB_GROUP");
            entity.Property(e => e.AhNotes)
                .HasMaxLength(250)
                .HasColumnName("AH_NOTES");
            entity.Property(e => e.AhOper)
                .HasMaxLength(25)
                .HasColumnName("AH_OPER");
            entity.Property(e => e.AhReportDate)
                .HasColumnType("datetime")
                .HasColumnName("AH_REPORT_DATE");
            entity.Property(e => e.AhStatus)
                .HasMaxLength(25)
                .HasColumnName("AH_STATUS");
            entity.Property(e => e.AhSuppNo)
                .HasMaxLength(25)
                .HasColumnName("AH_SUPP_NO");
            entity.Property(e => e.AhSuppRef)
                .HasMaxLength(50)
                .HasColumnName("AH_SUPP_REF");
            entity.Property(e => e.AhTotal)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("AH_TOTAL");
        });

        modelBuilder.Entity<AccountOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ACCOUNT_OLD");

            entity.HasIndex(e => e.Accno, "ACCNOX");

            entity.Property(e => e.Accno)
                .HasMaxLength(30)
                .HasColumnName("ACCNO");
            entity.Property(e => e.AccnoCode1)
                .HasMaxLength(10)
                .HasColumnName("ACCNO_CODE1");
            entity.Property(e => e.AccnoCode2)
                .HasMaxLength(10)
                .HasColumnName("ACCNO_CODE2");
            entity.Property(e => e.AccnoCode3)
                .HasMaxLength(10)
                .HasColumnName("ACCNO_CODE3");
            entity.Property(e => e.AccnoCode4)
                .HasMaxLength(10)
                .HasColumnName("ACCNO_CODE4");
            entity.Property(e => e.AccnoDesc)
                .HasMaxLength(100)
                .HasColumnName("ACCNO_DESC");
            entity.Property(e => e.AccnoLibGroup)
                .HasMaxLength(30)
                .HasColumnName("ACCNO_LIB_GROUP");
            entity.Property(e => e.AccnoStop).HasColumnName("ACCNO_STOP");
            entity.Property(e => e.AccnoType)
                .HasMaxLength(1)
                .HasColumnName("ACCNO_TYPE");
        });

        modelBuilder.Entity<AccountTrType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ACCOUNT_TR_TYPES");

            entity.Property(e => e.AtrtAddTo)
                .HasMaxLength(1)
                .HasColumnName("ATRT_ADD_TO");
            entity.Property(e => e.AtrtAllocHead)
                .HasMaxLength(15)
                .HasColumnName("ATRT_ALLOC_HEAD");
            entity.Property(e => e.AtrtAm1Head)
                .HasMaxLength(15)
                .HasColumnName("ATRT_AM1_HEAD");
            entity.Property(e => e.AtrtAm2Head)
                .HasMaxLength(15)
                .HasColumnName("ATRT_AM2_HEAD");
            entity.Property(e => e.AtrtAm3Head)
                .HasMaxLength(15)
                .HasColumnName("ATRT_AM3_HEAD");
            entity.Property(e => e.AtrtCode)
                .HasMaxLength(3)
                .HasColumnName("ATRT_CODE");
            entity.Property(e => e.AtrtCostHead)
                .HasMaxLength(15)
                .HasColumnName("ATRT_COST_HEAD");
            entity.Property(e => e.AtrtDefaccount)
                .HasMaxLength(8)
                .HasColumnName("ATRT_DEFACCOUNT");
            entity.Property(e => e.AtrtDefsign)
                .HasMaxLength(1)
                .HasColumnName("ATRT_DEFSIGN");
            entity.Property(e => e.AtrtDesc)
                .HasMaxLength(20)
                .HasColumnName("ATRT_DESC");
            entity.Property(e => e.AtrtExt1Head)
                .HasMaxLength(15)
                .HasColumnName("ATRT_EXT1_HEAD");
            entity.Property(e => e.AtrtExt2Head)
                .HasMaxLength(15)
                .HasColumnName("ATRT_EXT2_HEAD");
            entity.Property(e => e.AtrtLibGroup)
                .HasMaxLength(30)
                .HasColumnName("ATRT_LIB_GROUP");
            entity.Property(e => e.AtrtMhalloc)
                .HasMaxLength(1)
                .HasColumnName("ATRT_MHALLOC");
            entity.Property(e => e.AtrtMham1)
                .HasMaxLength(1)
                .HasColumnName("ATRT_MHAM1");
            entity.Property(e => e.AtrtMham2)
                .HasMaxLength(1)
                .HasColumnName("ATRT_MHAM2");
            entity.Property(e => e.AtrtMham3)
                .HasMaxLength(1)
                .HasColumnName("ATRT_MHAM3");
            entity.Property(e => e.AtrtMhcost)
                .HasMaxLength(1)
                .HasColumnName("ATRT_MHCOST");
            entity.Property(e => e.AtrtMhext1)
                .HasMaxLength(1)
                .HasColumnName("ATRT_MHEXT1");
            entity.Property(e => e.AtrtMhext2)
                .HasMaxLength(1)
                .HasColumnName("ATRT_MHEXT2");
            entity.Property(e => e.AtrtMhqty)
                .HasMaxLength(1)
                .HasColumnName("ATRT_MHQTY");
            entity.Property(e => e.AtrtMhtrdesc)
                .HasMaxLength(1)
                .HasColumnName("ATRT_MHTRDESC");
            entity.Property(e => e.AtrtMhvalue)
                .HasMaxLength(1)
                .HasColumnName("ATRT_MHVALUE");
            entity.Property(e => e.AtrtProcess)
                .HasMaxLength(20)
                .HasColumnName("ATRT_PROCESS");
            entity.Property(e => e.AtrtQtyHead)
                .HasMaxLength(15)
                .HasColumnName("ATRT_QTY_HEAD");
            entity.Property(e => e.AtrtSubtractFrom)
                .HasMaxLength(1)
                .HasColumnName("ATRT_SUBTRACT_FROM");
            entity.Property(e => e.AtrtValueHead)
                .HasMaxLength(15)
                .HasColumnName("ATRT_VALUE_HEAD");
            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");
        });

        modelBuilder.Entity<AccountTran>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ACCOUNT_TRANS");

            entity.Property(e => e.AtrAccount)
                .HasMaxLength(30)
                .HasColumnName("ATR_ACCOUNT");
            entity.Property(e => e.AtrAlloc)
                .HasMaxLength(10)
                .HasColumnName("ATR_ALLOC");
            entity.Property(e => e.AtrAmref1)
                .HasMaxLength(25)
                .HasColumnName("ATR_AMREF1");
            entity.Property(e => e.AtrAmref2)
                .HasMaxLength(25)
                .HasColumnName("ATR_AMREF2");
            entity.Property(e => e.AtrAmref3)
                .HasMaxLength(25)
                .HasColumnName("ATR_AMREF3");
            entity.Property(e => e.AtrBeforeDate)
                .HasColumnType("datetime")
                .HasColumnName("ATR_BEFORE_DATE");
            entity.Property(e => e.AtrBudget)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("ATR_BUDGET");
            entity.Property(e => e.AtrCommit)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("ATR_COMMIT");
            entity.Property(e => e.AtrCost)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("ATR_COST");
            entity.Property(e => e.AtrDatetime)
                .HasColumnType("datetime")
                .HasColumnName("ATR_DATETIME");
            entity.Property(e => e.AtrExtref1)
                .HasMaxLength(25)
                .HasColumnName("ATR_EXTREF1");
            entity.Property(e => e.AtrExtref2)
                .HasMaxLength(25)
                .HasColumnName("ATR_EXTREF2");
            entity.Property(e => e.AtrFccode)
                .HasMaxLength(4)
                .HasColumnName("ATR_FCCODE");
            entity.Property(e => e.AtrFccost)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("ATR_FCCOST");
            entity.Property(e => e.AtrFcdate)
                .HasColumnType("datetime")
                .HasColumnName("ATR_FCDATE");
            entity.Property(e => e.AtrFcrate)
                .HasColumnType("decimal(10, 4)")
                .HasColumnName("ATR_FCRATE");
            entity.Property(e => e.AtrFcvalue)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("ATR_FCVALUE");
            entity.Property(e => e.AtrFinYear).HasColumnName("ATR_FIN_YEAR");
            entity.Property(e => e.AtrLibGroup)
                .HasMaxLength(30)
                .HasColumnName("ATR_LIB_GROUP");
            entity.Property(e => e.AtrLoc)
                .HasMaxLength(20)
                .HasColumnName("ATR_LOC");
            entity.Property(e => e.AtrOper)
                .HasMaxLength(25)
                .HasColumnName("ATR_OPER");
            entity.Property(e => e.AtrQty)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("ATR_QTY");
            entity.Property(e => e.AtrRepeat)
                .HasMaxLength(1)
                .HasColumnName("ATR_REPEAT");
            entity.Property(e => e.AtrStatus)
                .HasMaxLength(1)
                .HasColumnName("ATR_STATUS");
            entity.Property(e => e.AtrTranNo).HasColumnName("ATR_TRAN_NO");
            entity.Property(e => e.AtrTransDate)
                .HasColumnType("datetime")
                .HasColumnName("ATR_TRANS_DATE");
            entity.Property(e => e.AtrTransDesc)
                .HasMaxLength(75)
                .HasColumnName("ATR_TRANS_DESC");
            entity.Property(e => e.AtrType)
                .HasMaxLength(3)
                .HasColumnName("ATR_TYPE");
            entity.Property(e => e.AtrValue)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("ATR_VALUE");
        });

        modelBuilder.Entity<AccountTranslation>(entity =>
        {
            entity.HasKey(e => new { e.Lcid, e.AccnoLibGroup, e.Accno });

            entity.ToTable("ACCOUNT_TRANSLATION");

            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.AccnoLibGroup)
                .HasMaxLength(30)
                .HasColumnName("ACCNO_LIB_GROUP");
            entity.Property(e => e.Accno)
                .HasMaxLength(30)
                .HasColumnName("ACCNO");
            entity.Property(e => e.AccnoDesc)
                .HasMaxLength(100)
                .HasColumnName("ACCNO_DESC");

            entity.HasOne(d => d.Account).WithMany(p => p.AccountTranslations)
                .HasForeignKey(d => new { d.AccnoLibGroup, d.Accno })
                .HasConstraintName("FK_ACCOUNT_ACCOUNT_TRANSLATION");
        });

        modelBuilder.Entity<ActEmailLog>(entity =>
        {
            entity.HasKey(e => e.ActEmailLog1);

            entity.ToTable("ACT_EMAIL_LOG");

            entity.HasIndex(e => e.DateTimeRequest, "NDXACTEMAILLOGDATETIMEREQUEST");

            entity.HasIndex(e => e.EmailStatus, "NDXACTEMAILLOGEMAILSTATUS");

            entity.Property(e => e.ActEmailLog1).HasColumnName("ACT_EMAIL_LOG");
            entity.Property(e => e.AddAttachments).HasColumnName("ADD_ATTACHMENTS");
            entity.Property(e => e.AttachFileNames)
                .IsUnicode(false)
                .HasColumnName("ATTACH_FILE_NAMES");
            entity.Property(e => e.BccEmail)
                .IsUnicode(false)
                .HasColumnName("BCC_EMAIL");
            entity.Property(e => e.BodyHtml)
                .IsUnicode(false)
                .HasColumnName("BODY_HTML");
            entity.Property(e => e.BodyText)
                .IsUnicode(false)
                .HasColumnName("BODY_TEXT");
            entity.Property(e => e.CcEmail)
                .IsUnicode(false)
                .HasColumnName("CC_EMAIL");
            entity.Property(e => e.DateTimeDelivery)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_DELIVERY");
            entity.Property(e => e.DateTimeRequest)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_REQUEST");
            entity.Property(e => e.DateTimeSent)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_SENT");
            entity.Property(e => e.EmailSentBy)
                .HasMaxLength(18)
                .IsUnicode(false)
                .HasColumnName("EMAIL_SENT_BY");
            entity.Property(e => e.EmailStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EMAIL_STATUS");
            entity.Property(e => e.FromEmail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FROM_EMAIL");
            entity.Property(e => e.FromName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("FROM_NAME");
            entity.Property(e => e.IcalMime)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ICAL_MIME");
            entity.Property(e => e.IsIcalendar).HasColumnName("IS_ICALENDAR");
            entity.Property(e => e.LastUpDate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("LAST_UP_DATE");
            entity.Property(e => e.NonMimeWarning)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("NON_MIME_WARNING");
            entity.Property(e => e.NumbAttach).HasColumnName("NUMB_ATTACH");
            entity.Property(e => e.ReadReceipt).HasColumnName("READ_RECEIPT");
            entity.Property(e => e.SendHtml).HasColumnName("SEND_HTML");
            entity.Property(e => e.Subject)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SUBJECT");
            entity.Property(e => e.ToEmail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TO_EMAIL");
            entity.Property(e => e.ToName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("TO_NAME");
        });

        modelBuilder.Entity<AdABorPicture>(entity =>
        {
            entity.HasKey(e => new { e.BorNo, e.AuditType, e.BorPicType, e.UpdatedOn });

            entity.ToTable("AD_A_BOR_PICTURE");

            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");
            entity.Property(e => e.AuditType)
                .HasMaxLength(1)
                .HasColumnName("AUDIT_TYPE");
            entity.Property(e => e.BorPicType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BOR_PIC_TYPE");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.BorPicData).HasColumnName("BOR_PIC_DATA");
            entity.Property(e => e.BorPicFilename)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BOR_PIC_FILENAME");
        });

        modelBuilder.Entity<AdBorAddDatum>(entity =>
        {
            entity.HasKey(e => new { e.BorNo, e.Rowid, e.Columnid });

            entity.ToTable("AD_BOR_ADD_DATA");

            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");
            entity.Property(e => e.Rowid).HasColumnName("ROWID");
            entity.Property(e => e.Columnid).HasColumnName("COLUMNID");
            entity.Property(e => e.Actiontime)
                .HasPrecision(3)
                .HasColumnName("ACTIONTIME");
            entity.Property(e => e.Actiontype)
                .HasMaxLength(10)
                .HasColumnName("ACTIONTYPE");
            entity.Property(e => e.Checkedvalue).HasColumnName("CHECKEDVALUE");
            entity.Property(e => e.Datetimevalue).HasColumnName("DATETIMEVALUE");
            entity.Property(e => e.Intvalue).HasColumnName("INTVALUE");
            entity.Property(e => e.Stringvalue)
                .HasMaxLength(300)
                .HasColumnName("STRINGVALUE");
            entity.Property(e => e.TbColumnid)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_COLUMNID");
        });

        modelBuilder.Entity<AdBorAddr>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AD_BOR_ADDR");

            entity.HasIndex(e => new { e.BaAddrNo, e.BaBorNo, e.UpdatedOn }, "NDXADBORADDR");

            entity.Property(e => e.AuditType)
                .HasMaxLength(1)
                .HasColumnName("AUDIT_TYPE");
            entity.Property(e => e.BaAddr1)
                .HasMaxLength(300)
                .HasColumnName("BA_ADDR1");
            entity.Property(e => e.BaAddr2)
                .HasMaxLength(300)
                .HasColumnName("BA_ADDR2");
            entity.Property(e => e.BaAddr3)
                .HasMaxLength(300)
                .HasColumnName("BA_ADDR3");
            entity.Property(e => e.BaAddr4)
                .HasMaxLength(300)
                .HasColumnName("BA_ADDR4");
            entity.Property(e => e.BaAddr5)
                .HasMaxLength(300)
                .HasColumnName("BA_ADDR5");
            entity.Property(e => e.BaAddrNo).HasColumnName("BA_ADDR_NO");
            entity.Property(e => e.BaAddressTypeId).HasColumnName("BA_ADDRESS_TYPE_ID");
            entity.Property(e => e.BaAreaCd)
                .HasMaxLength(8)
                .HasColumnName("BA_AREA_CD");
            entity.Property(e => e.BaBorNo).HasColumnName("BA_BOR_NO");
            entity.Property(e => e.BaCountryid).HasColumnName("BA_COUNTRYID");
            entity.Property(e => e.BaDatetime)
                .HasColumnType("datetime")
                .HasColumnName("BA_DATETIME");
            entity.Property(e => e.BaDpbarcode)
                .HasMaxLength(300)
                .HasColumnName("BA_DPBARCODE");
            entity.Property(e => e.BaMailing).HasColumnName("BA_MAILING");
            entity.Property(e => e.BaMain).HasColumnName("BA_MAIN");
            entity.Property(e => e.BaOper)
                .HasMaxLength(25)
                .HasColumnName("BA_OPER");
            entity.Property(e => e.BaPcode)
                .HasMaxLength(20)
                .HasColumnName("BA_PCODE");
            entity.Property(e => e.BaPopup)
                .HasMaxLength(1)
                .HasColumnName("BA_POPUP");
            entity.Property(e => e.BaSalutation)
                .HasMaxLength(50)
                .HasColumnName("BA_SALUTATION");
            entity.Property(e => e.BaSuburbCd)
                .HasMaxLength(4)
                .HasColumnName("BA_SUBURB_CD");
            entity.Property(e => e.BaTelephone)
                .HasMaxLength(80)
                .HasColumnName("BA_TELEPHONE");
            entity.Property(e => e.BaValidFrom)
                .HasColumnType("datetime")
                .HasColumnName("BA_VALID_FROM");
            entity.Property(e => e.BaValidTo)
                .HasColumnType("datetime")
                .HasColumnName("BA_VALID_TO");
            entity.Property(e => e.BaWardCd)
                .HasMaxLength(4)
                .HasColumnName("BA_WARD_CD");
            entity.Property(e => e.UpdatedOn).HasColumnName("UPDATED_ON");
            entity.Property(e => e.VerifiedBy)
                .HasMaxLength(25)
                .HasColumnName("VERIFIED_BY");
            entity.Property(e => e.VerifyAddress).HasColumnName("VERIFY_ADDRESS");
        });

        modelBuilder.Entity<AdBorHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AD_BOR_HISTORY");

            entity.Property(e => e.AuditDate)
                .HasPrecision(2)
                .HasColumnName("AUDIT_DATE");
            entity.Property(e => e.AuditType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("AUDIT_TYPE");
            entity.Property(e => e.BhCode)
                .HasMaxLength(3)
                .HasColumnName("BH_CODE");
            entity.Property(e => e.BhComments)
                .HasMaxLength(50)
                .HasColumnName("BH_COMMENTS");
            entity.Property(e => e.BhDate)
                .HasColumnType("datetime")
                .HasColumnName("BH_DATE");
            entity.Property(e => e.BhDueDate)
                .HasColumnType("datetime")
                .HasColumnName("BH_DUE_DATE");
            entity.Property(e => e.BhReport)
                .HasMaxLength(25)
                .HasColumnName("BH_REPORT");
            entity.Property(e => e.BhType)
                .HasMaxLength(8)
                .HasColumnName("BH_TYPE");
            entity.Property(e => e.BorBarNo)
                .HasMaxLength(75)
                .HasColumnName("BOR_BAR_NO");
            entity.Property(e => e.StkItemNo)
                .HasMaxLength(25)
                .HasColumnName("STK_ITEM_NO");
            entity.Property(e => e.StkTitle)
                .HasMaxLength(100)
                .HasColumnName("STK_TITLE");
        });

        modelBuilder.Entity<AdBorrower>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AD_BORROWER");

            entity.HasIndex(e => e.BorBarNo, "AUD_BORBARX");

            entity.HasIndex(e => e.BorDatetime, "AUD_BORDATEX");

            entity.HasIndex(e => e.BorNo, "AUD_BORNOXX");

            entity.Property(e => e.AuditDate)
                .HasPrecision(2)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnName("AUDIT_DATE");
            entity.Property(e => e.AuditId)
                .ValueGeneratedOnAdd()
                .HasColumnName("AUDIT_ID");
            entity.Property(e => e.AuditType)
                .HasMaxLength(1)
                .HasColumnName("AUDIT_TYPE");
            entity.Property(e => e.BorAddr1No).HasColumnName("BOR_ADDR1_NO");
            entity.Property(e => e.BorAddr1Txt)
                .HasMaxLength(85)
                .HasColumnName("BOR_ADDR1_TXT");
            entity.Property(e => e.BorAddr2No).HasColumnName("BOR_ADDR2_NO");
            entity.Property(e => e.BorAddr2Txt)
                .HasMaxLength(85)
                .HasColumnName("BOR_ADDR2_TXT");
            entity.Property(e => e.BorAddr3No).HasColumnName("BOR_ADDR3_NO");
            entity.Property(e => e.BorAddr3Txt)
                .HasMaxLength(85)
                .HasColumnName("BOR_ADDR3_TXT");
            entity.Property(e => e.BorApproved)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("BOR_APPROVED");
            entity.Property(e => e.BorBarNo)
                .HasMaxLength(75)
                .HasColumnName("BOR_BAR_NO");
            entity.Property(e => e.BorClass)
                .HasMaxLength(10)
                .HasColumnName("BOR_CLASS");
            entity.Property(e => e.BorDatetime).HasColumnName("BOR_DATETIME");
            entity.Property(e => e.BorDob).HasColumnName("BOR_DOB");
            entity.Property(e => e.BorDobDt).HasColumnName("BOR_DOB_DT");
            entity.Property(e => e.BorEmail)
                .HasMaxLength(75)
                .HasColumnName("BOR_EMAIL");
            entity.Property(e => e.BorEmail2)
                .HasMaxLength(75)
                .HasColumnName("BOR_EMAIL2");
            entity.Property(e => e.BorEmailPin)
                .HasMaxLength(1)
                .HasColumnName("BOR_EMAIL_PIN");
            entity.Property(e => e.BorEmailPinReset)
                .HasMaxLength(1)
                .HasColumnName("BOR_EMAIL_PIN_RESET");
            entity.Property(e => e.BorGiven)
                .HasMaxLength(50)
                .HasColumnName("BOR_GIVEN");
            entity.Property(e => e.BorGroup)
                .HasMaxLength(10)
                .HasColumnName("BOR_GROUP");
            entity.Property(e => e.BorInit)
                .HasMaxLength(25)
                .HasColumnName("BOR_INIT");
            entity.Property(e => e.BorLastactive).HasColumnName("BOR_LASTACTIVE");
            entity.Property(e => e.BorLibGroup)
                .HasMaxLength(30)
                .HasColumnName("BOR_LIB_GROUP");
            entity.Property(e => e.BorLocation)
                .HasMaxLength(20)
                .HasColumnName("BOR_LOCATION");
            entity.Property(e => e.BorMobUsfn)
                .HasMaxLength(1)
                .HasColumnName("BOR_MOB_USFN");
            entity.Property(e => e.BorMobileTel)
                .HasMaxLength(25)
                .HasColumnName("BOR_MOBILE_TEL");
            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");
            entity.Property(e => e.BorNoLoans).HasColumnName("BOR_NO_LOANS");
            entity.Property(e => e.BorNoOpacs).HasColumnName("BOR_NO_OPACS");
            entity.Property(e => e.BorNoRenews).HasColumnName("BOR_NO_RENEWS");
            entity.Property(e => e.BorNoReserves).HasColumnName("BOR_NO_RESERVES");
            entity.Property(e => e.BorNoSee).HasColumnName("BOR_NO_SEE");
            entity.Property(e => e.BorNoVisits).HasColumnName("BOR_NO_VISITS");
            entity.Property(e => e.BorOper)
                .HasMaxLength(25)
                .HasColumnName("BOR_OPER");
            entity.Property(e => e.BorOwing)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("BOR_OWING");
            entity.Property(e => e.BorPhoUsfn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BOR_PHO_USFN");
            entity.Property(e => e.BorPhoneTel)
                .HasMaxLength(25)
                .HasColumnName("BOR_PHONE_TEL");
            entity.Property(e => e.BorPin)
                .HasMaxLength(25)
                .HasColumnName("BOR_PIN");
            entity.Property(e => e.BorPotentialCharge)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("BOR_POTENTIAL_CHARGE");
            entity.Property(e => e.BorRamdomKey)
                .HasMaxLength(8)
                .HasColumnName("BOR_RAMDOM_KEY");
            entity.Property(e => e.BorRef1)
                .HasMaxLength(75)
                .HasColumnName("BOR_REF1");
            entity.Property(e => e.BorRef2)
                .HasMaxLength(150)
                .HasColumnName("BOR_REF2");
            entity.Property(e => e.BorRef3)
                .HasMaxLength(150)
                .HasColumnName("BOR_REF3");
            entity.Property(e => e.BorRegdate).HasColumnName("BOR_REGDATE");
            entity.Property(e => e.BorRejectedEmail)
                .HasMaxLength(1)
                .HasColumnName("BOR_REJECTED_EMAIL");
            entity.Property(e => e.BorRelType)
                .HasMaxLength(1)
                .HasColumnName("BOR_REL_TYPE");
            entity.Property(e => e.BorReqPinChange)
                .HasMaxLength(1)
                .HasColumnName("BOR_REQ_PIN_CHANGE");
            entity.Property(e => e.BorSecurity).HasColumnName("BOR_SECURITY");
            entity.Property(e => e.BorSex)
                .HasMaxLength(1)
                .HasColumnName("BOR_SEX");
            entity.Property(e => e.BorSoundex)
                .HasMaxLength(35)
                .HasColumnName("BOR_SOUNDEX");
            entity.Property(e => e.BorStartLocation)
                .HasMaxLength(25)
                .HasColumnName("BOR_START_LOCATION");
            entity.Property(e => e.BorStartMship).HasColumnName("BOR_START_MSHIP");
            entity.Property(e => e.BorStatus)
                .HasMaxLength(10)
                .HasColumnName("BOR_STATUS");
            entity.Property(e => e.BorSurname)
                .HasMaxLength(100)
                .HasColumnName("BOR_SURNAME");
            entity.Property(e => e.BorSurnameKey)
                .HasMaxLength(100)
                .HasColumnName("BOR_SURNAME_KEY");
            entity.Property(e => e.BorTitle)
                .HasMaxLength(25)
                .HasColumnName("BOR_TITLE");
            entity.Property(e => e.BorType)
                .HasMaxLength(3)
                .HasColumnName("BOR_TYPE");
            entity.Property(e => e.BorUseEmail)
                .HasMaxLength(1)
                .HasColumnName("BOR_USE_EMAIL");
            entity.Property(e => e.BorUseEmail2)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BOR_USE_EMAIL2");
            entity.Property(e => e.ContactTel)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CONTACT_TEL");
            entity.Property(e => e.Encryptedid).HasColumnName("ENCRYPTEDID");
            entity.Property(e => e.Gdpr)
                .HasMaxLength(1)
                .HasColumnName("GDPR");
            entity.Property(e => e.HashedBorPin)
                .HasMaxLength(256)
                .HasColumnName("HASHED_BOR_PIN");
            entity.Property(e => e.Isshowinitial).HasColumnName("ISSHOWINITIAL");
            entity.Property(e => e.ParentBorNoSee).HasColumnName("PARENT_BOR_NO_SEE");
            entity.Property(e => e.PreBorNoSee).HasColumnName("PRE_BOR_NO_SEE");
            entity.Property(e => e.Primarycontact).HasColumnName("PRIMARYCONTACT");
            entity.Property(e => e.ReadingChallenge).HasColumnName("READING_CHALLENGE");
            entity.Property(e => e.ReceiveEmails)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RECEIVE_EMAILS");
            entity.Property(e => e.ReceiveInfoByPost)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RECEIVE_INFO_BY_POST");
            entity.Property(e => e.Salutation)
                .HasMaxLength(50)
                .HasColumnName("SALUTATION");
        });

        modelBuilder.Entity<AdBorrowerLogin>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AD_BORROWER_LOGIN");

            entity.Property(e => e.AuditId)
                .ValueGeneratedOnAdd()
                .HasColumnName("AUDIT_ID");
            entity.Property(e => e.LoginBorbarcode)
                .HasMaxLength(35)
                .HasColumnName("LOGIN_BORBARCODE");
            entity.Property(e => e.LoginSite)
                .HasMaxLength(10)
                .HasColumnName("LOGIN_SITE");
            entity.Property(e => e.LoginStatus)
                .HasMaxLength(1)
                .HasColumnName("LOGIN_STATUS");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<AdFinTran>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AD_FIN_TRANS");

            entity.Property(e => e.AuditDate)
                .HasPrecision(2)
                .HasColumnName("AUDIT_DATE");
            entity.Property(e => e.AuditType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("AUDIT_TYPE");
            entity.Property(e => e.FinAccYear).HasColumnName("FIN_ACC_YEAR");
            entity.Property(e => e.FinAccount)
                .HasMaxLength(10)
                .HasColumnName("FIN_ACCOUNT");
            entity.Property(e => e.FinAllocCode)
                .HasMaxLength(20)
                .HasColumnName("FIN_ALLOC_CODE");
            entity.Property(e => e.FinBor)
                .HasMaxLength(75)
                .HasColumnName("FIN_BOR");
            entity.Property(e => e.FinComments)
                .HasMaxLength(100)
                .HasColumnName("FIN_COMMENTS");
            entity.Property(e => e.FinCr)
                .HasMaxLength(2)
                .HasColumnName("FIN_CR");
            entity.Property(e => e.FinCurrRate)
                .HasColumnType("decimal(10, 4)")
                .HasColumnName("FIN_CURR_RATE");
            entity.Property(e => e.FinCurrency)
                .HasMaxLength(4)
                .HasColumnName("FIN_CURRENCY");
            entity.Property(e => e.FinDate)
                .HasColumnType("datetime")
                .HasColumnName("FIN_DATE");
            entity.Property(e => e.FinDateMod)
                .HasColumnType("datetime")
                .HasColumnName("FIN_DATE_MOD");
            entity.Property(e => e.FinInvDate)
                .HasColumnType("datetime")
                .HasColumnName("FIN_INV_DATE");
            entity.Property(e => e.FinInvNo)
                .HasMaxLength(12)
                .HasColumnName("FIN_INV_NO");
            entity.Property(e => e.FinItem)
                .HasMaxLength(25)
                .HasColumnName("FIN_ITEM");
            entity.Property(e => e.FinLoc)
                .HasMaxLength(20)
                .HasColumnName("FIN_LOC");
            entity.Property(e => e.FinMarkfordelete)
                .HasMaxLength(1)
                .HasColumnName("FIN_MARKFORDELETE");
            entity.Property(e => e.FinMfdRef).HasColumnName("FIN_MFD_REF");
            entity.Property(e => e.FinName)
                .HasMaxLength(100)
                .HasColumnName("FIN_NAME");
            entity.Property(e => e.FinOper)
                .HasMaxLength(20)
                .HasColumnName("FIN_OPER");
            entity.Property(e => e.FinPaid)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("FIN_PAID");
            entity.Property(e => e.FinPaymentType).HasColumnName("FIN_PAYMENT_TYPE");
            entity.Property(e => e.FinQty)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("FIN_QTY");
            entity.Property(e => e.FinReceipt).HasColumnName("FIN_RECEIPT");
            entity.Property(e => e.FinReport)
                .HasMaxLength(25)
                .HasColumnName("FIN_REPORT");
            entity.Property(e => e.FinSuppNo)
                .HasMaxLength(25)
                .HasColumnName("FIN_SUPP_NO");
            entity.Property(e => e.FinTitle)
                .HasMaxLength(250)
                .HasColumnName("FIN_TITLE");
            entity.Property(e => e.FinTranNo).HasColumnName("FIN_TRAN_NO");
            entity.Property(e => e.FinType)
                .HasMaxLength(15)
                .HasColumnName("FIN_TYPE");
            entity.Property(e => e.FinValue)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("FIN_VALUE");
        });

        modelBuilder.Entity<AdStkItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AD_STK_ITEM");

            entity.HasIndex(e => e.StkItemNo, "AUD_STKBARX");

            entity.HasIndex(e => e.StkDatetime, "AUD_STKDATEX");

            entity.HasIndex(e => e.UniqueItemNo, "AUD_STKUNOX");

            entity.Property(e => e.AuditId)
                .ValueGeneratedOnAdd()
                .HasColumnName("AUDIT_ID");
            entity.Property(e => e.AuditType)
                .HasMaxLength(1)
                .HasColumnName("AUDIT_TYPE");
            entity.Property(e => e.StkCatRef).HasColumnName("STK_CAT_REF");
            entity.Property(e => e.StkConvertValue)
                .HasMaxLength(50)
                .HasColumnName("STK_CONVERT_VALUE");
            entity.Property(e => e.StkCost)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("STK_COST");
            entity.Property(e => e.StkDateAcc)
                .HasColumnType("datetime")
                .HasColumnName("STK_DATE_ACC");
            entity.Property(e => e.StkDateDue)
                .HasColumnType("datetime")
                .HasColumnName("STK_DATE_DUE");
            entity.Property(e => e.StkDateRecd)
                .HasColumnType("datetime")
                .HasColumnName("STK_DATE_RECD");
            entity.Property(e => e.StkDatetime)
                .HasColumnType("datetime")
                .HasColumnName("STK_DATETIME");
            entity.Property(e => e.StkDescription)
                .HasMaxLength(250)
                .HasColumnName("STK_DESCRIPTION");
            entity.Property(e => e.StkEdition)
                .HasMaxLength(25)
                .HasColumnName("STK_EDITION");
            entity.Property(e => e.StkForLoan)
                .HasMaxLength(1)
                .HasColumnName("STK_FOR_LOAN");
            entity.Property(e => e.StkForm)
                .HasMaxLength(3)
                .HasColumnName("STK_FORM");
            entity.Property(e => e.StkIsOnLoan)
                .HasMaxLength(1)
                .HasColumnName("STK_IS_ON_LOAN");
            entity.Property(e => e.StkIsOnOrder)
                .HasMaxLength(1)
                .HasColumnName("STK_IS_ON_ORDER");
            entity.Property(e => e.StkIsReserved).HasColumnName("STK_IS_RESERVED");
            entity.Property(e => e.StkItemNo)
                .HasMaxLength(75)
                .HasColumnName("STK_ITEM_NO");
            entity.Property(e => e.StkKey1)
                .HasMaxLength(200)
                .HasColumnName("STK_KEY1");
            entity.Property(e => e.StkKey2)
                .HasMaxLength(200)
                .HasColumnName("STK_KEY2");
            entity.Property(e => e.StkKey3)
                .HasMaxLength(200)
                .HasColumnName("STK_KEY3");
            entity.Property(e => e.StkKey4)
                .HasMaxLength(200)
                .HasColumnName("STK_KEY4");
            entity.Property(e => e.StkKey5)
                .HasMaxLength(200)
                .HasColumnName("STK_KEY5");
            entity.Property(e => e.StkKey6)
                .HasMaxLength(200)
                .HasColumnName("STK_KEY6");
            entity.Property(e => e.StkLastResno).HasColumnName("STK_LAST_RESNO");
            entity.Property(e => e.StkLastTake)
                .HasColumnType("datetime")
                .HasColumnName("STK_LAST_TAKE");
            entity.Property(e => e.StkLastactive)
                .HasColumnType("datetime")
                .HasColumnName("STK_LASTACTIVE");
            entity.Property(e => e.StkLibGroup)
                .HasMaxLength(30)
                .HasColumnName("STK_LIB_GROUP");
            entity.Property(e => e.StkLine1)
                .HasMaxLength(250)
                .HasColumnName("STK_LINE1");
            entity.Property(e => e.StkLine2)
                .HasMaxLength(250)
                .HasColumnName("STK_LINE2");
            entity.Property(e => e.StkLine3)
                .HasMaxLength(250)
                .HasColumnName("STK_LINE3");
            entity.Property(e => e.StkLine4)
                .HasMaxLength(250)
                .HasColumnName("STK_LINE4");
            entity.Property(e => e.StkLine5)
                .HasMaxLength(250)
                .HasColumnName("STK_LINE5");
            entity.Property(e => e.StkLine6)
                .HasMaxLength(250)
                .HasColumnName("STK_LINE6");
            entity.Property(e => e.StkLocFloor)
                .HasMaxLength(40)
                .HasColumnName("STK_LOC_FLOOR");
            entity.Property(e => e.StkLocPerm)
                .HasMaxLength(40)
                .HasColumnName("STK_LOC_PERM");
            entity.Property(e => e.StkLocTemp)
                .HasMaxLength(40)
                .HasColumnName("STK_LOC_TEMP");
            entity.Property(e => e.StkOper)
                .HasMaxLength(25)
                .HasColumnName("STK_OPER");
            entity.Property(e => e.StkOrigCost)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("STK_ORIG_COST");
            entity.Property(e => e.StkStatsCode)
                .HasMaxLength(10)
                .HasColumnName("STK_STATS_CODE");
            entity.Property(e => e.StkStockTake)
                .HasMaxLength(1)
                .HasColumnName("STK_STOCK_TAKE");
            entity.Property(e => e.StkTimesBorrowed).HasColumnName("STK_TIMES_BORROWED");
            entity.Property(e => e.StkTimesRenewed).HasColumnName("STK_TIMES_RENEWED");
            entity.Property(e => e.StkTimesReserved).HasColumnName("STK_TIMES_RESERVED");
            entity.Property(e => e.StkVolume)
                .HasMaxLength(25)
                .HasColumnName("STK_VOLUME");
            entity.Property(e => e.UniqueItemNo).HasColumnName("UNIQUE_ITEM_NO");
        });

        modelBuilder.Entity<AddrSystab>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ADDR_SYSTAB");

            entity.Property(e => e.AddrNo).HasColumnName("ADDR_NO");
        });

        modelBuilder.Entity<AmlibMedchief>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AMLIB_MEDCHIEF");

            entity.Property(e => e.AmcUnique).HasColumnName("AMC_UNIQUE");
        });

        modelBuilder.Entity<AmlibMedium>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AMLIB_MEDIA");

            entity.Property(e => e.AsBrief)
                .HasMaxLength(50)
                .HasColumnName("AS_BRIEF");
            entity.Property(e => e.AsDate)
                .HasColumnType("datetime")
                .HasColumnName("AS_DATE");
            entity.Property(e => e.AsEntity).HasColumnName("AS_ENTITY");
            entity.Property(e => e.AsFilename)
                .HasMaxLength(50)
                .HasColumnName("AS_FILENAME");
            entity.Property(e => e.AsGroup)
                .HasMaxLength(3)
                .HasColumnName("AS_GROUP");
            entity.Property(e => e.AsLibGroup)
                .HasMaxLength(30)
                .HasColumnName("AS_LIB_GROUP");
            entity.Property(e => e.AsPlayVia)
                .HasMaxLength(50)
                .HasColumnName("AS_PLAY_VIA");
            entity.Property(e => e.AsSecurity)
                .HasColumnType("decimal(2, 0)")
                .HasColumnName("AS_SECURITY");
            entity.Property(e => e.AsSequence).HasColumnName("AS_SEQUENCE");
            entity.Property(e => e.AsType)
                .HasMaxLength(1)
                .HasColumnName("AS_TYPE");
            entity.Property(e => e.AsWho)
                .HasMaxLength(25)
                .HasColumnName("AS_WHO");
        });

        modelBuilder.Entity<AspNetRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AspNetRoles");

            entity.HasIndex(e => e.Name, "RoleNameIndex").IsUnique();

            entity.Property(e => e.Id).HasMaxLength(128);
            entity.Property(e => e.Name).HasMaxLength(256);
        });

        modelBuilder.Entity<AspNetUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AspNetUsers");

            entity.HasIndex(e => e.UserName, "UserNameIndex").IsUnique();

            entity.Property(e => e.Id).HasMaxLength(128);
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(256);

            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "AspNetUserRole",
                    r => r.HasOne<AspNetRole>().WithMany()
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId"),
                    l => l.HasOne<AspNetUser>().WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId").HasName("PK_dbo.AspNetUserRoles");
                        j.ToTable("AspNetUserRoles");
                        j.HasIndex(new[] { "RoleId" }, "IX_RoleId");
                        j.HasIndex(new[] { "UserId" }, "IX_UserId");
                        j.IndexerProperty<string>("UserId").HasMaxLength(128);
                        j.IndexerProperty<string>("RoleId").HasMaxLength(128);
                    });
        });

        modelBuilder.Entity<AspNetUserClaim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AspNetUserClaims");

            entity.HasIndex(e => e.UserId, "IX_UserId");

            entity.Property(e => e.UserId).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserClaims)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId");
        });

        modelBuilder.Entity<AspNetUserLogin>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId }).HasName("PK_dbo.AspNetUserLogins");

            entity.HasIndex(e => e.UserId, "IX_UserId");

            entity.Property(e => e.LoginProvider).HasMaxLength(128);
            entity.Property(e => e.ProviderKey).HasMaxLength(128);
            entity.Property(e => e.UserId).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserLogins)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId");
        });

        modelBuilder.Entity<Assignment>(entity =>
        {
            entity.ToTable("ASSIGNMENTS");

            entity.Property(e => e.AssignmentId).HasColumnName("ASSIGNMENT_ID");
            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");
            entity.Property(e => e.CatNo).HasColumnName("CAT_NO");
            entity.Property(e => e.DateCreated).HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateUpdated).HasColumnName("DATE_UPDATED");
            entity.Property(e => e.ExpiryDate).HasColumnName("EXPIRY_DATE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
        });

        modelBuilder.Entity<AtrSystab>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ATR_SYSTAB");

            entity.Property(e => e.AtrNumber).HasColumnName("ATR_NUMBER");
        });

        modelBuilder.Entity<BhnGroupBorrower>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BHN_GROUP_BORROWER");

            entity.Property(e => e.BhnGroupid).HasColumnName("BHN_GROUPID");
            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");
        });

        modelBuilder.Entity<BoSystab>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BO_SYSTAB");

            entity.Property(e => e.BaAddrNo).HasColumnName("BA_ADDR_NO");
            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");
        });

        modelBuilder.Entity<BorAddDatum>(entity =>
        {
            entity.HasKey(e => new { e.BorNo, e.Rowid, e.Columnid });

            entity.ToTable("BOR_ADD_DATA");

            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");
            entity.Property(e => e.Rowid).HasColumnName("ROWID");
            entity.Property(e => e.Columnid).HasColumnName("COLUMNID");
            entity.Property(e => e.Checkedvalue).HasColumnName("CHECKEDVALUE");
            entity.Property(e => e.Datetimevalue).HasColumnName("DATETIMEVALUE");
            entity.Property(e => e.Intvalue).HasColumnName("INTVALUE");
            entity.Property(e => e.Stringvalue)
                .HasMaxLength(300)
                .HasColumnName("STRINGVALUE");
            entity.Property(e => e.TbColumnid)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_COLUMNID");
        });

        modelBuilder.Entity<BorAddr>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BOR_ADDR", tb => tb.HasTrigger("trg_bor_addr_audit"));

            entity.HasIndex(e => e.BaAddrNo, "BAADDR_NOX").IsUnique();

            entity.Property(e => e.BaAddr1)
                .HasMaxLength(300)
                .HasColumnName("BA_ADDR1");
            entity.Property(e => e.BaAddr2)
                .HasMaxLength(300)
                .HasColumnName("BA_ADDR2");
            entity.Property(e => e.BaAddr3)
                .HasMaxLength(300)
                .HasColumnName("BA_ADDR3");
            entity.Property(e => e.BaAddr4)
                .HasMaxLength(300)
                .HasColumnName("BA_ADDR4");
            entity.Property(e => e.BaAddr5)
                .HasMaxLength(300)
                .HasColumnName("BA_ADDR5");
            entity.Property(e => e.BaAddrNo).HasColumnName("BA_ADDR_NO");
            entity.Property(e => e.BaAddressTypeId).HasColumnName("BA_ADDRESS_TYPE_ID");
            entity.Property(e => e.BaAreaCd)
                .HasMaxLength(8)
                .HasColumnName("BA_AREA_CD");
            entity.Property(e => e.BaBorNo).HasColumnName("BA_BOR_NO");
            entity.Property(e => e.BaCountryid).HasColumnName("BA_COUNTRYID");
            entity.Property(e => e.BaDatetime)
                .HasColumnType("datetime")
                .HasColumnName("BA_DATETIME");
            entity.Property(e => e.BaDpbarcode)
                .HasMaxLength(300)
                .HasColumnName("BA_DPBARCODE");
            entity.Property(e => e.BaMailing).HasColumnName("BA_MAILING");
            entity.Property(e => e.BaMain).HasColumnName("BA_MAIN");
            entity.Property(e => e.BaOper)
                .HasMaxLength(25)
                .HasColumnName("BA_OPER");
            entity.Property(e => e.BaPcode)
                .HasMaxLength(20)
                .HasColumnName("BA_PCODE");
            entity.Property(e => e.BaPopup)
                .HasMaxLength(1)
                .HasColumnName("BA_POPUP");
            entity.Property(e => e.BaSalutation)
                .HasMaxLength(50)
                .HasColumnName("BA_SALUTATION");
            entity.Property(e => e.BaSuburbCd)
                .HasMaxLength(4)
                .HasColumnName("BA_SUBURB_CD");
            entity.Property(e => e.BaTelephone)
                .HasMaxLength(80)
                .HasColumnName("BA_TELEPHONE");
            entity.Property(e => e.BaValidFrom)
                .HasColumnType("datetime")
                .HasColumnName("BA_VALID_FROM");
            entity.Property(e => e.BaValidTo)
                .HasColumnType("datetime")
                .HasColumnName("BA_VALID_TO");
            entity.Property(e => e.BaWardCd)
                .HasMaxLength(4)
                .HasColumnName("BA_WARD_CD");
            entity.Property(e => e.VerifiedBy)
                .HasMaxLength(25)
                .HasColumnName("VERIFIED_BY");
            entity.Property(e => e.VerifyAddress).HasColumnName("VERIFY_ADDRESS");
        });

        modelBuilder.Entity<BorAlias>(entity =>
        {
            entity.HasKey(e => e.AliasBorNo);

            entity.ToTable("BOR_ALIAS");

            entity.Property(e => e.AliasBorNo)
                .ValueGeneratedNever()
                .HasColumnName("ALIAS_BOR_NO");
            entity.Property(e => e.AliasEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ALIAS_EMAIL");
            entity.Property(e => e.AliasName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ALIAS_NAME");
            entity.Property(e => e.AliasPicData)
                .IsUnicode(false)
                .HasColumnName("ALIAS_PIC_DATA");
            entity.Property(e => e.AliasPicFilename)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ALIAS_PIC_FILENAME");
        });

        modelBuilder.Entity<BorAnswer>(entity =>
        {
            entity.HasKey(e => new { e.BorNo, e.SurveyId, e.QuestionId, e.AnswerId, e.AnonymousId, e.SerialNum }).HasName("PK_bor_answers");

            entity.ToTable("BOR_ANSWER");

            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");
            entity.Property(e => e.SurveyId).HasColumnName("SURVEY_ID");
            entity.Property(e => e.QuestionId).HasColumnName("QUESTION_ID");
            entity.Property(e => e.AnswerId).HasColumnName("ANSWER_ID");
            entity.Property(e => e.AnonymousId).HasColumnName("ANONYMOUS_ID");
            entity.Property(e => e.SerialNum).HasColumnName("SERIAL_NUM");
            entity.Property(e => e.Approve).HasColumnName("APPROVE");
            entity.Property(e => e.ApproveBy)
                .HasMaxLength(50)
                .HasColumnName("APPROVE_BY");
            entity.Property(e => e.ApproveDate)
                .HasColumnType("datetime")
                .HasColumnName("APPROVE_DATE");
            entity.Property(e => e.Other)
                .HasMaxLength(500)
                .HasColumnName("OTHER");

            entity.HasOne(d => d.BorNoNavigation).WithMany(p => p.BorAnswers)
                .HasForeignKey(d => d.BorNo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_bor_answers_BORROWER");

            entity.HasOne(d => d.Survey).WithMany(p => p.BorAnswers)
                .HasForeignKey(d => d.SurveyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_bor_answer_survey");

            entity.HasOne(d => d.SurveysQuestion).WithMany(p => p.BorAnswers)
                .HasForeignKey(d => new { d.QuestionId, d.SurveyId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_bor_answer_surveys_question");

            entity.HasOne(d => d.SurveysAnswer).WithMany(p => p.BorAnswers)
                .HasForeignKey(d => new { d.AnswerId, d.SurveyId, d.QuestionId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_bor_answer_surveys_answer");

            entity.HasOne(d => d.BorSurvey).WithMany(p => p.BorAnswers)
                .HasForeignKey(d => new { d.SurveyId, d.BorNo, d.AnonymousId, d.SerialNum })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_bor_answer_bor_survey");
        });

        modelBuilder.Entity<BorAnswerOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("bor_answer_old");

            entity.Property(e => e.AnonymousId).HasColumnName("anonymous_id");
            entity.Property(e => e.AnswerId).HasColumnName("answer_id");
            entity.Property(e => e.Approve).HasColumnName("approve");
            entity.Property(e => e.ApproveBy)
                .HasMaxLength(50)
                .HasColumnName("approve_by");
            entity.Property(e => e.ApproveDate)
                .HasColumnType("datetime")
                .HasColumnName("approve_date");
            entity.Property(e => e.BorNo).HasColumnName("bor_no");
            entity.Property(e => e.Other)
                .HasMaxLength(500)
                .HasColumnName("other");
            entity.Property(e => e.QuestionId).HasColumnName("question_id");
            entity.Property(e => e.SurveyId).HasColumnName("survey_id");

            entity.HasOne(d => d.BorNoNavigation).WithMany()
                .HasForeignKey(d => d.BorNo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_bor_answers_BORROWER_old");

            entity.HasOne(d => d.Survey).WithMany()
                .HasForeignKey(d => d.SurveyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_bor_answer_survey_old");

            entity.HasOne(d => d.SurveysQuestion).WithMany()
                .HasForeignKey(d => new { d.QuestionId, d.SurveyId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_bor_answer_surveys_question_old");

            entity.HasOne(d => d.SurveysAnswer).WithMany()
                .HasForeignKey(d => new { d.AnswerId, d.SurveyId, d.QuestionId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_bor_answer_surveys_answer_old");

            entity.HasOne(d => d.BorSurveyOld).WithMany()
                .HasForeignKey(d => new { d.SurveyId, d.BorNo, d.AnonymousId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_bor_answer_bor_survey_old");
        });

        modelBuilder.Entity<BorBiometric>(entity =>
        {
            entity.HasKey(e => new { e.BorNo, e.BorFingernumber }).HasName("PK_CATALOGUE_ELECTRONIC");

            entity.ToTable("BOR_BIOMETRIC");

            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");
            entity.Property(e => e.BorFingernumber).HasColumnName("BOR_FINGERNUMBER");
            entity.Property(e => e.BorFingerprint).HasColumnName("BOR_FINGERPRINT");
            entity.Property(e => e.DeleteFlag).HasColumnName("DELETE_FLAG");
        });

        modelBuilder.Entity<BorCircWork>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BOR_CIRC_WORK");

            entity.Property(e => e.BcwBorBarNo)
                .HasMaxLength(75)
                .HasColumnName("BCW_BOR_BAR_NO");
        });

        modelBuilder.Entity<BorColumnsViewConfig>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BOR_COLUMNS_VIEW_CONFIG");

            entity.Property(e => e.ColumnDesc)
                .HasMaxLength(70)
                .HasColumnName("COLUMN_DESC");
            entity.Property(e => e.ColumnId)
                .HasMaxLength(35)
                .HasColumnName("COLUMN_ID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Isshow)
                .HasDefaultValue(true)
                .HasColumnName("ISSHOW");
        });

        modelBuilder.Entity<BorColumnsViewDetailsConfig>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BOR_COLUMNS_VIEW_DETAILS_CONFIG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.LabelId)
                .HasMaxLength(35)
                .HasColumnName("LABEL_ID");
            entity.Property(e => e.TypeOfLabel)
                .HasMaxLength(5)
                .HasColumnName("TYPE_OF_LABEL");
        });

        modelBuilder.Entity<BorCoursePeriod>(entity =>
        {
            entity.HasKey(e => new { e.BorNo, e.BorCoCode, e.BorCpDateFrom, e.BorCpDateTo });

            entity.ToTable("BOR_COURSE_PERIOD");

            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");
            entity.Property(e => e.BorCoCode)
                .HasMaxLength(20)
                .HasColumnName("BOR_CO_CODE");
            entity.Property(e => e.BorCpDateFrom)
                .HasColumnType("datetime")
                .HasColumnName("BOR_CP_DATE_FROM");
            entity.Property(e => e.BorCpDateTo)
                .HasColumnType("datetime")
                .HasColumnName("BOR_CP_DATE_TO");
        });

        modelBuilder.Entity<BorDomainuser>(entity =>
        {
            entity.HasKey(e => e.BorNo);

            entity.ToTable("BOR_DOMAINUSER");

            entity.Property(e => e.BorNo)
                .ValueGeneratedNever()
                .HasColumnName("BOR_NO");
            entity.Property(e => e.DomainUsername)
                .HasMaxLength(300)
                .HasColumnName("DOMAIN_USERNAME");
        });

        modelBuilder.Entity<BorFileImport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BOR_FILE_IMPORT");

            entity.Property(e => e.AmAction)
                .HasMaxLength(10)
                .HasColumnName("AM_ACTION");
            entity.Property(e => e.AmBorno)
                .HasMaxLength(50)
                .HasColumnName("AM_BORNO");
            entity.Property(e => e.AmEntrydate)
                .HasMaxLength(50)
                .HasColumnName("AM_ENTRYDATE");
            entity.Property(e => e.BaAddr11)
                .HasMaxLength(300)
                .HasColumnName("BA_ADDR11");
            entity.Property(e => e.BaAddr12)
                .HasMaxLength(300)
                .HasColumnName("BA_ADDR12");
            entity.Property(e => e.BaAddr13)
                .HasMaxLength(300)
                .HasColumnName("BA_ADDR13");
            entity.Property(e => e.BaAddr31)
                .HasMaxLength(300)
                .HasColumnName("BA_ADDR31");
            entity.Property(e => e.BaAddr32)
                .HasMaxLength(300)
                .HasColumnName("BA_ADDR32");
            entity.Property(e => e.BaAddr33)
                .HasMaxLength(300)
                .HasColumnName("BA_ADDR33");
            entity.Property(e => e.BaAddr34)
                .HasMaxLength(300)
                .HasColumnName("BA_ADDR34");
            entity.Property(e => e.BaPcode1)
                .HasMaxLength(20)
                .HasColumnName("BA_PCODE1");
            entity.Property(e => e.BaPcode3)
                .HasMaxLength(20)
                .HasColumnName("BA_PCODE3");
            entity.Property(e => e.BaState)
                .HasMaxLength(32)
                .HasColumnName("BA_STATE");
            entity.Property(e => e.BaState3)
                .HasMaxLength(32)
                .HasColumnName("BA_STATE3");
            entity.Property(e => e.BaSuburb)
                .HasMaxLength(4)
                .HasColumnName("BA_SUBURB");
            entity.Property(e => e.BaSuburb3)
                .HasMaxLength(4)
                .HasColumnName("BA_SUBURB3");
            entity.Property(e => e.BaTelephone1)
                .HasMaxLength(30)
                .HasColumnName("BA_TELEPHONE1");
            entity.Property(e => e.BaTelephone3)
                .HasMaxLength(30)
                .HasColumnName("BA_TELEPHONE3");
            entity.Property(e => e.BorBarNo)
                .HasMaxLength(12)
                .HasColumnName("BOR_BAR_NO");
            entity.Property(e => e.BorClass)
                .HasMaxLength(50)
                .HasColumnName("BOR_CLASS");
            entity.Property(e => e.BorDob)
                .HasMaxLength(50)
                .HasColumnName("BOR_DOB");
            entity.Property(e => e.BorEmail)
                .HasMaxLength(75)
                .HasColumnName("BOR_EMAIL");
            entity.Property(e => e.BorGiven)
                .HasMaxLength(50)
                .HasColumnName("BOR_GIVEN");
            entity.Property(e => e.BorGroup)
                .HasMaxLength(50)
                .HasColumnName("BOR_GROUP");
            entity.Property(e => e.BorInit)
                .HasMaxLength(25)
                .HasColumnName("BOR_INIT");
            entity.Property(e => e.BorLocation)
                .HasMaxLength(50)
                .HasColumnName("BOR_LOCATION");
            entity.Property(e => e.BorPreferred)
                .HasMaxLength(20)
                .HasColumnName("BOR_PREFERRED");
            entity.Property(e => e.BorRef2)
                .HasMaxLength(20)
                .HasColumnName("BOR_REF2");
            entity.Property(e => e.BorSex)
                .HasMaxLength(1)
                .HasColumnName("BOR_SEX");
            entity.Property(e => e.BorSurname)
                .HasMaxLength(40)
                .HasColumnName("BOR_SURNAME");
            entity.Property(e => e.BorType)
                .HasMaxLength(50)
                .HasColumnName("BOR_TYPE");
            entity.Property(e => e.ItemNo).HasColumnName("ITEM_NO");
        });

        modelBuilder.Entity<BorFileMap>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BOR_FILE_MAP");

            entity.Property(e => e.BfmAmlibCode)
                .HasMaxLength(20)
                .HasColumnName("BFM_AMLIB_CODE");
            entity.Property(e => e.BfmColumn)
                .HasMaxLength(50)
                .HasColumnName("BFM_COLUMN");
            entity.Property(e => e.BfmDateCreated)
                .HasColumnType("datetime")
                .HasColumnName("BFM_DATE_CREATED");
            entity.Property(e => e.BfmImportCode)
                .HasMaxLength(50)
                .HasColumnName("BFM_IMPORT_CODE");
        });

        modelBuilder.Entity<BorFriend>(entity =>
        {
            entity.HasKey(e => new { e.BorNo, e.BorNoFriend });

            entity.ToTable("BOR_FRIEND");

            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");
            entity.Property(e => e.BorNoFriend).HasColumnName("BOR_NO_FRIEND");
            entity.Property(e => e.BorFriendStatusId).HasColumnName("BOR_FRIEND_STATUS_ID");

            entity.HasOne(d => d.BorFriendStatus).WithMany(p => p.BorFriends)
                .HasForeignKey(d => d.BorFriendStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BOR_FRIEND_BOR_FRIEND_STATUS");

            entity.HasOne(d => d.BorNoNavigation).WithMany(p => p.BorFriendBorNoNavigations)
                .HasForeignKey(d => d.BorNo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BOR_FRIEND_BORROWER");

            entity.HasOne(d => d.BorNoFriendNavigation).WithMany(p => p.BorFriendBorNoFriendNavigations)
                .HasForeignKey(d => d.BorNoFriend)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BOR_FRIEND_BOR_INVITED");
        });

        modelBuilder.Entity<BorFriendStatus>(entity =>
        {
            entity.ToTable("BOR_FRIEND_STATUS");

            entity.Property(e => e.BorFriendStatusId)
                .ValueGeneratedNever()
                .HasColumnName("BOR_FRIEND_STATUS_ID");
            entity.Property(e => e.BorFriendStatusDesc)
                .HasMaxLength(50)
                .HasColumnName("BOR_FRIEND_STATUS_DESC");
        });

        modelBuilder.Entity<BorGroupDetail>(entity =>
        {
            entity.HasKey(e => new { e.BgId, e.BorFriendNo });

            entity.ToTable("BOR_GROUP_DETAIL");

            entity.Property(e => e.BgId).HasColumnName("BG_ID");
            entity.Property(e => e.BorFriendNo).HasColumnName("BOR_FRIEND_NO");

            entity.HasOne(d => d.Bg).WithMany(p => p.BorGroupDetails)
                .HasForeignKey(d => d.BgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BOR_GROUP_DETAIL_BOR_GROUP_MSG");
        });

        modelBuilder.Entity<BorGroupMsg>(entity =>
        {
            entity.HasKey(e => e.BgId);

            entity.ToTable("BOR_GROUP_MSG");

            entity.Property(e => e.BgId)
                .ValueGeneratedNever()
                .HasColumnName("BG_ID");
            entity.Property(e => e.BgDescription)
                .HasMaxLength(50)
                .HasColumnName("BG_DESCRIPTION");
            entity.Property(e => e.BgOwnerId).HasColumnName("BG_OWNER_ID");

            entity.HasOne(d => d.BgOwner).WithMany(p => p.BorGroupMsgs)
                .HasForeignKey(d => d.BgOwnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BOR_GROUP_MSG_BORROWER");
        });

        modelBuilder.Entity<BorHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BOR_HISTORY");

            entity.HasIndex(e => new { e.BorBarNo, e.BhType, e.StkTitle }, "BH_BARTYPX");

            entity.HasIndex(e => e.StkItemNo, "STK_NOX");

            entity.Property(e => e.BhCode)
                .HasMaxLength(3)
                .HasColumnName("BH_CODE");
            entity.Property(e => e.BhComments)
                .HasMaxLength(245)
                .IsUnicode(false)
                .HasColumnName("BH_COMMENTS");
            entity.Property(e => e.BhDate)
                .HasColumnType("datetime")
                .HasColumnName("BH_DATE");
            entity.Property(e => e.BhDueDate)
                .HasColumnType("datetime")
                .HasColumnName("BH_DUE_DATE");
            entity.Property(e => e.BhReport)
                .HasMaxLength(25)
                .HasColumnName("BH_REPORT");
            entity.Property(e => e.BhType)
                .HasMaxLength(11)
                .HasColumnName("BH_TYPE");
            entity.Property(e => e.BorBarNo)
                .HasMaxLength(75)
                .HasColumnName("BOR_BAR_NO");
            entity.Property(e => e.StkItemNo)
                .HasMaxLength(25)
                .HasColumnName("STK_ITEM_NO");
            entity.Property(e => e.StkTitle)
                .HasMaxLength(100)
                .HasColumnName("STK_TITLE");
        });

        modelBuilder.Entity<BorHistoryNote>(entity =>
        {
            entity.HasKey(e => e.HistoryId);

            entity.ToTable("BOR_HISTORY_NOTES");

            entity.Property(e => e.HistoryId).HasColumnName("HISTORY_ID");
            entity.Property(e => e.BhnCategoryId).HasColumnName("BHN_CATEGORY_ID");
            entity.Property(e => e.BhnResultId).HasColumnName("BHN_RESULT_ID");
            entity.Property(e => e.BhnTypeId).HasColumnName("BHN_TYPE_ID");
            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");
            entity.Property(e => e.CreateDate)
                .HasPrecision(3)
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(25)
                .HasColumnName("CREATE_USER");
            entity.Property(e => e.Notes).HasColumnName("NOTES");
            entity.Property(e => e.ResultCode)
                .HasMaxLength(8)
                .HasColumnName("RESULT_CODE");
            entity.Property(e => e.ShortDesc)
                .HasMaxLength(200)
                .HasColumnName("SHORT_DESC");
        });

        modelBuilder.Entity<BorImport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BOR_IMPORT");

            entity.Property(e => e.BorAddr11)
                .HasMaxLength(300)
                .HasColumnName("BOR_ADDR11");
            entity.Property(e => e.BorAddr12)
                .HasMaxLength(300)
                .HasColumnName("BOR_ADDR12");
            entity.Property(e => e.BorAddr13)
                .HasMaxLength(300)
                .HasColumnName("BOR_ADDR13");
            entity.Property(e => e.BorAddr14)
                .HasMaxLength(300)
                .HasColumnName("BOR_ADDR14");
            entity.Property(e => e.BorAddr21)
                .HasMaxLength(300)
                .HasColumnName("BOR_ADDR21");
            entity.Property(e => e.BorAddr22)
                .HasMaxLength(300)
                .HasColumnName("BOR_ADDR22");
            entity.Property(e => e.BorAddr23)
                .HasMaxLength(300)
                .HasColumnName("BOR_ADDR23");
            entity.Property(e => e.BorAddr24)
                .HasMaxLength(300)
                .HasColumnName("BOR_ADDR24");
            entity.Property(e => e.BorAddr31)
                .HasMaxLength(300)
                .HasColumnName("BOR_ADDR31");
            entity.Property(e => e.BorAddr32)
                .HasMaxLength(300)
                .HasColumnName("BOR_ADDR32");
            entity.Property(e => e.BorAddr33)
                .HasMaxLength(300)
                .HasColumnName("BOR_ADDR33");
            entity.Property(e => e.BorAddr34)
                .HasMaxLength(300)
                .HasColumnName("BOR_ADDR34");
            entity.Property(e => e.BorAreaCd)
                .HasMaxLength(8)
                .HasColumnName("BOR_AREA_CD");
            entity.Property(e => e.BorBarNo)
                .HasMaxLength(25)
                .HasColumnName("BOR_BAR_NO");
            entity.Property(e => e.BorChangeType)
                .HasMaxLength(1)
                .HasColumnName("BOR_CHANGE_TYPE");
            entity.Property(e => e.BorClass)
                .HasMaxLength(10)
                .HasColumnName("BOR_CLASS");
            entity.Property(e => e.BorComplete)
                .HasMaxLength(1)
                .HasColumnName("BOR_COMPLETE");
            entity.Property(e => e.BorDateModified)
                .HasColumnType("datetime")
                .HasColumnName("BOR_DATE_MODIFIED");
            entity.Property(e => e.BorDob)
                .HasColumnType("datetime")
                .HasColumnName("BOR_DOB");
            entity.Property(e => e.BorDpbarcode1)
                .HasMaxLength(300)
                .HasColumnName("BOR_DPBARCODE1");
            entity.Property(e => e.BorDpbarcode2)
                .HasMaxLength(300)
                .HasColumnName("BOR_DPBARCODE2");
            entity.Property(e => e.BorDpbarcode3)
                .HasMaxLength(300)
                .HasColumnName("BOR_DPBARCODE3");
            entity.Property(e => e.BorEmail)
                .HasMaxLength(75)
                .HasColumnName("BOR_EMAIL");
            entity.Property(e => e.BorGiven)
                .HasMaxLength(50)
                .HasColumnName("BOR_GIVEN");
            entity.Property(e => e.BorGroup)
                .HasMaxLength(10)
                .HasColumnName("BOR_GROUP");
            entity.Property(e => e.BorInit)
                .HasMaxLength(25)
                .HasColumnName("BOR_INIT");
            entity.Property(e => e.BorLocation)
                .HasMaxLength(20)
                .HasColumnName("BOR_LOCATION");
            entity.Property(e => e.BorMobUsfn)
                .HasMaxLength(1)
                .HasColumnName("BOR_MOB_USFN");
            entity.Property(e => e.BorMobileTel)
                .HasMaxLength(25)
                .HasColumnName("BOR_MOBILE_TEL");
            entity.Property(e => e.BorOucrNo).HasColumnName("BOR_OUCR_NO");
            entity.Property(e => e.BorPcode1)
                .HasMaxLength(20)
                .HasColumnName("BOR_PCODE1");
            entity.Property(e => e.BorPcode2)
                .HasMaxLength(20)
                .HasColumnName("BOR_PCODE2");
            entity.Property(e => e.BorPcode3)
                .HasMaxLength(20)
                .HasColumnName("BOR_PCODE3");
            entity.Property(e => e.BorPin)
                .HasMaxLength(25)
                .HasColumnName("BOR_PIN");
            entity.Property(e => e.BorRef1)
                .HasMaxLength(20)
                .HasColumnName("BOR_REF1");
            entity.Property(e => e.BorRef2)
                .HasMaxLength(20)
                .HasColumnName("BOR_REF2");
            entity.Property(e => e.BorRegdate)
                .HasColumnType("datetime")
                .HasColumnName("BOR_REGDATE");
            entity.Property(e => e.BorSex)
                .HasMaxLength(1)
                .HasColumnName("BOR_SEX");
            entity.Property(e => e.BorStartLocation)
                .HasMaxLength(25)
                .HasColumnName("BOR_START_LOCATION");
            entity.Property(e => e.BorStartMship)
                .HasColumnType("datetime")
                .HasColumnName("BOR_START_MSHIP");
            entity.Property(e => e.BorStatus)
                .HasMaxLength(10)
                .HasColumnName("BOR_STATUS");
            entity.Property(e => e.BorSuburb1)
                .HasMaxLength(4)
                .HasColumnName("BOR_SUBURB1");
            entity.Property(e => e.BorSuburb2)
                .HasMaxLength(4)
                .HasColumnName("BOR_SUBURB2");
            entity.Property(e => e.BorSuburb3)
                .HasMaxLength(4)
                .HasColumnName("BOR_SUBURB3");
            entity.Property(e => e.BorSurname)
                .HasMaxLength(40)
                .HasColumnName("BOR_SURNAME");
            entity.Property(e => e.BorTelephone1)
                .HasMaxLength(30)
                .HasColumnName("BOR_TELEPHONE1");
            entity.Property(e => e.BorTelephone2)
                .HasMaxLength(30)
                .HasColumnName("BOR_TELEPHONE2");
            entity.Property(e => e.BorTelephone3)
                .HasMaxLength(30)
                .HasColumnName("BOR_TELEPHONE3");
            entity.Property(e => e.BorTitle)
                .HasMaxLength(25)
                .HasColumnName("BOR_TITLE");
            entity.Property(e => e.BorType)
                .HasMaxLength(3)
                .HasColumnName("BOR_TYPE");
            entity.Property(e => e.BorUseEmail)
                .HasMaxLength(1)
                .HasColumnName("BOR_USE_EMAIL");
            entity.Property(e => e.BorWardCd)
                .HasMaxLength(4)
                .HasColumnName("BOR_WARD_CD");
            entity.Property(e => e.ExternalId)
                .HasMaxLength(50)
                .HasColumnName("EXTERNAL_ID");
            entity.Property(e => e.SeqNo).HasColumnName("SEQ_NO");
        });

        modelBuilder.Entity<BorInterestWork>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BOR_INTEREST_WORK");

            entity.Property(e => e.BiAuthMarc)
                .HasMaxLength(250)
                .HasColumnName("BI_AUTH_MARC");
            entity.Property(e => e.BiBorBarNo)
                .HasMaxLength(75)
                .HasColumnName("BI_BOR_BAR_NO");
            entity.Property(e => e.BiCatNo).HasColumnName("BI_CAT_NO");
        });

        modelBuilder.Entity<BorLearningdeliveryfam>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BOR_LEARNINGDELIVERYFAMS");

            entity.Property(e => e.Borno).HasColumnName("BORNO");
            entity.Property(e => e.Learndelfamcode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("LEARNDELFAMCODE");
        });

        modelBuilder.Entity<BorLlddandhealthproblem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BOR_LLDDANDHEALTHPROBLEMS");

            entity.Property(e => e.Borno).HasColumnName("BORNO");
            entity.Property(e => e.Llddcat).HasColumnName("LLDDCAT");
            entity.Property(e => e.Primarylldd).HasColumnName("PRIMARYLLDD");
        });

        modelBuilder.Entity<BorMemo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BOR_MEMOS");

            entity.HasIndex(e => e.BmBorBarNo, "BM_BORBARNOX");

            entity.HasIndex(e => e.BmBorNo, "BM_BORNOX");

            entity.HasIndex(e => new { e.BmEffDate, e.BmDisplay }, "BM_DISP_DATEX");

            entity.HasIndex(e => e.BmStkItemNo, "BM_STK_NOX");

            entity.HasIndex(e => e.BmType, "BM_TYPEX");

            entity.HasIndex(e => e.BmUniqueNo, "BM_UNIQUENOX");

            entity.Property(e => e.BmBorBarNo)
                .HasMaxLength(75)
                .HasColumnName("BM_BOR_BAR_NO");
            entity.Property(e => e.BmBorNo).HasColumnName("BM_BOR_NO");
            entity.Property(e => e.BmData)
                .HasColumnType("ntext")
                .HasColumnName("BM_DATA");
            entity.Property(e => e.BmDisplay)
                .HasMaxLength(1)
                .HasColumnName("BM_DISPLAY");
            entity.Property(e => e.BmEffDate)
                .HasColumnType("datetime")
                .HasColumnName("BM_EFF_DATE");
            entity.Property(e => e.BmEndDate)
                .HasColumnType("datetime")
                .HasColumnName("BM_END_DATE");
            entity.Property(e => e.BmStkItemNo)
                .HasMaxLength(25)
                .HasColumnName("BM_STK_ITEM_NO");
            entity.Property(e => e.BmType)
                .HasMaxLength(10)
                .HasColumnName("BM_TYPE");
            entity.Property(e => e.BmUniqueNo)
                .HasMaxLength(35)
                .HasColumnName("BM_UNIQUE_NO");
        });

        modelBuilder.Entity<BorMessageRelThread>(entity =>
        {
            entity.HasKey(e => new { e.BorNo, e.ThreadId, e.SubThreadId });

            entity.ToTable("BOR_MESSAGE_REL_THREAD");

            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");
            entity.Property(e => e.ThreadId).HasColumnName("THREAD_ID");
            entity.Property(e => e.SubThreadId).HasColumnName("SUB_THREAD_ID");
            entity.Property(e => e.Display).HasColumnName("DISPLAY");
            entity.Property(e => e.OwnerNo).HasColumnName("OWNER_NO");
            entity.Property(e => e.Unread).HasColumnName("UNREAD");

            entity.HasOne(d => d.BorNoNavigation).WithMany(p => p.BorMessageRelThreads)
                .HasForeignKey(d => d.BorNo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BOR_MESSAGE_REL_THREAD_BORROWER");

            entity.HasOne(d => d.BorMessageThread).WithMany(p => p.BorMessageRelThreads)
                .HasForeignKey(d => new { d.ThreadId, d.SubThreadId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BOR_MESSAGE_REL_THREAD_BOR_MESSAGE_THREAD1");
        });

        modelBuilder.Entity<BorMessageThread>(entity =>
        {
            entity.HasKey(e => new { e.ThreadId, e.SubThreadId });

            entity.ToTable("BOR_MESSAGE_THREAD");

            entity.Property(e => e.ThreadId).HasColumnName("THREAD_ID");
            entity.Property(e => e.SubThreadId).HasColumnName("SUB_THREAD_ID");
            entity.Property(e => e.Message).HasColumnName("MESSAGE");
            entity.Property(e => e.ParentSubThreadId).HasColumnName("PARENT_SUB_THREAD_ID");
            entity.Property(e => e.Subject)
                .HasMaxLength(250)
                .HasColumnName("SUBJECT");
            entity.Property(e => e.ThreadDatetime)
                .HasColumnType("datetime")
                .HasColumnName("THREAD_DATETIME");
        });

        modelBuilder.Entity<BorNote>(entity =>
        {
            entity.HasKey(e => e.BorNo);

            entity.ToTable("BOR_NOTE");

            entity.Property(e => e.BorNo)
                .ValueGeneratedNever()
                .HasColumnName("BOR_NO");
            entity.Property(e => e.Note).HasColumnName("NOTE");
            entity.Property(e => e.UpdateDate)
                .HasPrecision(3)
                .HasColumnName("UPDATE_DATE");
            entity.Property(e => e.UpdateUser)
                .HasMaxLength(25)
                .HasColumnName("UPDATE_USER");
        });

        modelBuilder.Entity<BorOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BOR_ORDER");

            entity.Property(e => e.BaAreaCd)
                .HasMaxLength(20)
                .HasColumnName("BA_AREA_CD");
            entity.Property(e => e.BaPcode)
                .HasMaxLength(20)
                .HasColumnName("BA_PCODE");
            entity.Property(e => e.BaTelephone)
                .HasMaxLength(30)
                .HasColumnName("BA_TELEPHONE");
            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");
            entity.Property(e => e.CompletedDate)
                .HasColumnType("datetime")
                .HasColumnName("COMPLETED_DATE");
            entity.Property(e => e.DeliveryAddr).HasColumnName("DELIVERY_ADDR");
            entity.Property(e => e.DeliveryAddr1)
                .HasMaxLength(75)
                .HasColumnName("DELIVERY_ADDR1");
            entity.Property(e => e.DeliveryAddr2)
                .HasMaxLength(75)
                .HasColumnName("DELIVERY_ADDR2");
            entity.Property(e => e.DeliveryAddr3)
                .HasMaxLength(75)
                .HasColumnName("DELIVERY_ADDR3");
            entity.Property(e => e.DeliveryAddr4)
                .HasMaxLength(75)
                .HasColumnName("DELIVERY_ADDR4");
            entity.Property(e => e.DeliveryAddr5)
                .HasMaxLength(75)
                .HasColumnName("DELIVERY_ADDR5");
            entity.Property(e => e.DeliveryDate)
                .HasColumnType("datetime")
                .HasColumnName("DELIVERY_DATE");
            entity.Property(e => e.OrderBy)
                .HasMaxLength(50)
                .HasColumnName("ORDER_BY");
            entity.Property(e => e.OrderDate)
                .HasColumnType("datetime")
                .HasColumnName("ORDER_DATE");
            entity.Property(e => e.OrderId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ORDER_ID");
            entity.Property(e => e.OrderStatus)
                .HasMaxLength(10)
                .HasColumnName("ORDER_STATUS");
        });

        modelBuilder.Entity<BorOrderBasket>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BOR_ORDER_BASKET");

            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");
            entity.Property(e => e.CreateDatetime).HasColumnName("CREATE_DATETIME");
            entity.Property(e => e.UniqueItemNo).HasColumnName("UNIQUE_ITEM_NO");
        });

        modelBuilder.Entity<BorOrderDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BOR_ORDER_DETAILS");

            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");
            entity.Property(e => e.PackageLabel)
                .HasMaxLength(11)
                .HasColumnName("PACKAGE_LABEL");
            entity.Property(e => e.PackingNumber).HasColumnName("PACKING_NUMBER");
            entity.Property(e => e.ResNumber).HasColumnName("RES_NUMBER");
            entity.Property(e => e.ResPrintedItem).HasColumnName("RES_PRINTED_ITEM");
        });

        modelBuilder.Entity<BorOrderPackage>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BOR_ORDER_PACKAGE");

            entity.Property(e => e.BaAreaCd)
                .HasMaxLength(20)
                .HasColumnName("BA_AREA_CD");
            entity.Property(e => e.BaPcode)
                .HasMaxLength(20)
                .HasColumnName("BA_PCODE");
            entity.Property(e => e.BaTelephone)
                .HasMaxLength(30)
                .HasColumnName("BA_TELEPHONE");
            entity.Property(e => e.DeliveryAddr1)
                .HasMaxLength(75)
                .HasColumnName("DELIVERY_ADDR1");
            entity.Property(e => e.DeliveryAddr2)
                .HasMaxLength(75)
                .HasColumnName("DELIVERY_ADDR2");
            entity.Property(e => e.DeliveryAddr3)
                .HasMaxLength(75)
                .HasColumnName("DELIVERY_ADDR3");
            entity.Property(e => e.DeliveryAddr4)
                .HasMaxLength(75)
                .HasColumnName("DELIVERY_ADDR4");
            entity.Property(e => e.DeliveryAddr5)
                .HasMaxLength(75)
                .HasColumnName("DELIVERY_ADDR5");
            entity.Property(e => e.DeliveryDate)
                .HasColumnType("datetime")
                .HasColumnName("DELIVERY_DATE");
            entity.Property(e => e.DeliveryReceiver)
                .HasMaxLength(50)
                .HasColumnName("DELIVERY_RECEIVER");
            entity.Property(e => e.DispatchLabel)
                .HasMaxLength(50)
                .HasColumnName("DISPATCH_LABEL");
            entity.Property(e => e.PackageId)
                .ValueGeneratedOnAdd()
                .HasColumnName("PACKAGE_ID");
            entity.Property(e => e.PackageLabel)
                .HasMaxLength(11)
                .HasColumnName("PACKAGE_LABEL");
            entity.Property(e => e.PackingBy)
                .HasMaxLength(50)
                .HasColumnName("PACKING_BY");
            entity.Property(e => e.PackingDate)
                .HasColumnType("datetime")
                .HasColumnName("PACKING_DATE");
        });

        modelBuilder.Entity<BorPayment>(entity =>
        {
            entity.HasKey(e => e.PayNo);

            entity.ToTable("BOR_PAYMENT");

            entity.Property(e => e.PayNo)
                .ValueGeneratedNever()
                .HasColumnName("PAY_NO");
            entity.Property(e => e.CashTill).HasColumnName("CASH_TILL");
            entity.Property(e => e.FinType)
                .HasMaxLength(15)
                .HasColumnName("FIN_TYPE");
            entity.Property(e => e.PayLibGroup)
                .HasMaxLength(30)
                .HasColumnName("PAY_LIB_GROUP");
            entity.Property(e => e.PayLocation)
                .HasMaxLength(40)
                .HasColumnName("PAY_LOCATION");
            entity.Property(e => e.PayOperator)
                .HasMaxLength(25)
                .HasColumnName("PAY_OPERATOR");
            entity.Property(e => e.PayTransDate)
                .HasColumnType("datetime")
                .HasColumnName("PAY_TRANS_DATE");
            entity.Property(e => e.PayValue)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("PAY_VALUE");
        });

        modelBuilder.Entity<BorPaymentFinTran>(entity =>
        {
            entity.HasKey(e => new { e.PayNo, e.FinTranNo });

            entity.ToTable("BOR_PAYMENT_FIN_TRANS");

            entity.Property(e => e.PayNo).HasColumnName("PAY_NO");
            entity.Property(e => e.FinTranNo).HasColumnName("FIN_TRAN_NO");
            entity.Property(e => e.PayValue)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("PAY_VALUE");
        });

        modelBuilder.Entity<BorPicImport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BOR_PIC_IMPORT");

            entity.Property(e => e.BpiFileName)
                .HasMaxLength(300)
                .HasColumnName("BPI_FILE_NAME");
            entity.Property(e => e.BpiFileNo).HasColumnName("BPI_FILE_NO");
            entity.Property(e => e.BpiImportKey)
                .HasMaxLength(50)
                .HasColumnName("BPI_IMPORT_KEY");
        });

        modelBuilder.Entity<BorPrePw>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_BOR_PRE_PWS_1");

            entity.ToTable("BOR_PRE_PWS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BorBarNo)
                .HasMaxLength(75)
                .HasColumnName("BOR_BAR_NO");
            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");
            entity.Property(e => e.BorPin)
                .HasMaxLength(256)
                .HasColumnName("BOR_PIN");
            entity.Property(e => e.DateRenewed)
                .HasColumnType("datetime")
                .HasColumnName("DATE_RENEWED");
            entity.Property(e => e.ResetBy)
                .HasMaxLength(75)
                .HasColumnName("RESET_BY");
        });

        modelBuilder.Entity<BorQuestionComment>(entity =>
        {
            entity.HasKey(e => new { e.BorNo, e.SurveyId, e.QuestionId, e.AnonymousId, e.SerialNum }).HasName("PK_bor_question_comment");

            entity.ToTable("BOR_QUESTION_COMMENT");

            entity.Property(e => e.BorNo).HasColumnName("bor_no");
            entity.Property(e => e.SurveyId).HasColumnName("survey_id");
            entity.Property(e => e.QuestionId).HasColumnName("question_id");
            entity.Property(e => e.AnonymousId).HasColumnName("anonymous_id");
            entity.Property(e => e.SerialNum).HasColumnName("SERIAL_NUM");
            entity.Property(e => e.Approve).HasColumnName("approve");
            entity.Property(e => e.ApproveBy)
                .HasMaxLength(50)
                .HasColumnName("approve_by");
            entity.Property(e => e.ApproveDate)
                .HasColumnType("datetime")
                .HasColumnName("approve_date");
            entity.Property(e => e.Comment)
                .HasMaxLength(500)
                .HasColumnName("comment");

            entity.HasOne(d => d.SurveysQuestion).WithMany(p => p.BorQuestionComments)
                .HasForeignKey(d => new { d.QuestionId, d.SurveyId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_bor_question_comment_surveys_question");

            entity.HasOne(d => d.BorSurvey).WithMany(p => p.BorQuestionComments)
                .HasForeignKey(d => new { d.SurveyId, d.BorNo, d.AnonymousId, d.SerialNum })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_bor_question_comment_bor_survey");
        });

        modelBuilder.Entity<BorQuestionCommentOld>(entity =>
        {
            entity.HasKey(e => new { e.BorNo, e.SurveyId, e.QuestionId, e.AnonymousId });

            entity.ToTable("bor_question_comment_old");

            entity.Property(e => e.BorNo).HasColumnName("bor_no");
            entity.Property(e => e.SurveyId).HasColumnName("survey_id");
            entity.Property(e => e.QuestionId).HasColumnName("question_id");
            entity.Property(e => e.AnonymousId).HasColumnName("anonymous_id");
            entity.Property(e => e.Approve).HasColumnName("approve");
            entity.Property(e => e.ApproveBy)
                .HasMaxLength(50)
                .HasColumnName("approve_by");
            entity.Property(e => e.ApproveDate)
                .HasColumnType("datetime")
                .HasColumnName("approve_date");
            entity.Property(e => e.Comment)
                .HasMaxLength(500)
                .HasColumnName("comment");

            entity.HasOne(d => d.SurveysQuestion).WithMany(p => p.BorQuestionCommentOlds)
                .HasForeignKey(d => new { d.QuestionId, d.SurveyId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_bor_question_comment_surveys_question_old");

            entity.HasOne(d => d.BorSurveyOld).WithMany(p => p.BorQuestionCommentOlds)
                .HasForeignKey(d => new { d.SurveyId, d.BorNo, d.AnonymousId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_bor_question_comment_bor_survey_old");
        });

        modelBuilder.Entity<BorSpecial>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BOR_SPECIAL");

            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");
            entity.Property(e => e.CatOfProcedure)
                .HasMaxLength(50)
                .HasColumnName("CAT_OF_PROCEDURE");
            entity.Property(e => e.DateOfOperation)
                .HasColumnType("datetime")
                .HasColumnName("DATE_OF_OPERATION");
            entity.Property(e => e.SerialNum).HasColumnName("SERIAL_NUM");
            entity.Property(e => e.Surveyid).HasColumnName("SURVEYID");
        });

        modelBuilder.Entity<BorStatsbenefit>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BOR_STATSBENEFIT");

            entity.Property(e => e.Borno).HasColumnName("BORNO");
            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
        });

        modelBuilder.Entity<BorStreet>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BOR_STREET");

            entity.HasIndex(e => e.BsStreet, "BS_STREETX");

            entity.Property(e => e.BsEndNo).HasColumnName("BS_END_NO");
            entity.Property(e => e.BsOddEven)
                .HasMaxLength(1)
                .HasColumnName("BS_ODD_EVEN");
            entity.Property(e => e.BsStartNo).HasColumnName("BS_START_NO");
            entity.Property(e => e.BsStreet)
                .HasMaxLength(75)
                .HasColumnName("BS_STREET");
            entity.Property(e => e.BsWard)
                .HasMaxLength(3)
                .HasColumnName("BS_WARD");
        });

        modelBuilder.Entity<BorSurvey>(entity =>
        {
            entity.HasKey(e => new { e.SurveyId, e.BorNo, e.AnonymousId, e.SerialNum }).HasName("PK_bor_surveys");

            entity.ToTable("BOR_SURVEY");

            entity.Property(e => e.SurveyId).HasColumnName("SURVEY_ID");
            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");
            entity.Property(e => e.AnonymousId).HasColumnName("ANONYMOUS_ID");
            entity.Property(e => e.SerialNum).HasColumnName("SERIAL_NUM");
            entity.Property(e => e.Approve).HasColumnName("APPROVE");
            entity.Property(e => e.ApproveBy)
                .HasMaxLength(50)
                .HasColumnName("APPROVE_BY");
            entity.Property(e => e.ApproveDate)
                .HasColumnType("datetime")
                .HasColumnName("APPROVE_DATE");
            entity.Property(e => e.BorEmail)
                .HasMaxLength(250)
                .HasColumnName("BOR_EMAIL");
            entity.Property(e => e.Comment).HasColumnName("COMMENT");
            entity.Property(e => e.DateTaken)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TAKEN");
            entity.Property(e => e.DateTakenBy)
                .HasMaxLength(25)
                .HasColumnName("DATE_TAKEN_BY");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATED");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(25)
                .HasColumnName("LAST_UPDATED_BY");
            entity.Property(e => e.Showdetails).HasColumnName("SHOWDETAILS");

            entity.HasOne(d => d.BorNoNavigation).WithMany(p => p.BorSurveys)
                .HasForeignKey(d => d.BorNo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_bor_surveys_BORROWER");

            entity.HasOne(d => d.Survey).WithMany(p => p.BorSurveys)
                .HasForeignKey(d => d.SurveyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_bor_survey_survey");
        });

        modelBuilder.Entity<BorSurveyOld>(entity =>
        {
            entity.HasKey(e => new { e.SurveyId, e.BorNo, e.AnonymousId }).HasName("PK_bor_surveys_old");

            entity.ToTable("bor_survey_old");

            entity.Property(e => e.SurveyId).HasColumnName("survey_id");
            entity.Property(e => e.BorNo).HasColumnName("bor_no");
            entity.Property(e => e.AnonymousId).HasColumnName("anonymous_id");
            entity.Property(e => e.Approve).HasColumnName("approve");
            entity.Property(e => e.ApproveBy)
                .HasMaxLength(50)
                .HasColumnName("approve_by");
            entity.Property(e => e.ApproveDate)
                .HasColumnType("datetime")
                .HasColumnName("approve_date");
            entity.Property(e => e.Comment)
                .HasMaxLength(500)
                .HasColumnName("comment");
            entity.Property(e => e.DateTaken)
                .HasColumnType("datetime")
                .HasColumnName("date_taken");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("last_updated");
            entity.Property(e => e.Showdetails).HasColumnName("showdetails");
        });

        modelBuilder.Entity<BorToken>(entity =>
        {
            entity.HasKey(e => e.TokenId).HasName("PK__BOR_TOKE__8481DA1EB8DA2483");

            entity.ToTable("BOR_TOKEN");

            entity.Property(e => e.TokenId).HasColumnName("TOKEN_ID");
            entity.Property(e => e.Borno).HasColumnName("BORNO");
            entity.Property(e => e.ExpiresOn)
                .HasColumnType("datetime")
                .HasColumnName("EXPIRES_ON");
            entity.Property(e => e.IssuedOn)
                .HasColumnType("datetime")
                .HasColumnName("ISSUED_ON");
            entity.Property(e => e.Token)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("TOKEN");
        });

        modelBuilder.Entity<Borrower>(entity =>
        {
            entity.HasKey(e => e.BorNo);

            entity.ToTable("BORROWER");

            entity.HasIndex(e => e.BorBarNo, "A_BOR_BAR_NO").IsUnique();

            entity.HasIndex(e => e.BorDob, "BORDOBX");

            entity.HasIndex(e => e.BorType, "BORTYPEX");

            entity.HasIndex(e => e.BorAddr1No, "BOR_ADDR1NOX");

            entity.HasIndex(e => e.BorAddr2No, "BOR_ADDR2NOX");

            entity.HasIndex(e => e.BorAddr3No, "BOR_ADDR3NOX");

            entity.HasIndex(e => e.BorBarNo, "BOR_BORBORNOX");

            entity.HasIndex(e => e.BorNo, "BOR_BORNOX").IsUnique();

            entity.HasIndex(e => e.BorGiven, "BOR_GIVENX");

            entity.HasIndex(e => e.BorLocation, "BOR_LOCATIONX");

            entity.HasIndex(e => e.BorSex, "BOR_SEXX");

            entity.HasIndex(e => e.BorSurname, "BOR_SURNAMEX");

            entity.HasIndex(e => e.BorSurnameKey, "BOR_SURNAME_KEYX");

            entity.HasIndex(e => e.BorRef1, "IX_Borrower_BOR_REF1");

            entity.HasIndex(e => e.BorRef2, "IX_Borrower_BOR_REF2");

            entity.Property(e => e.BorNo)
                .ValueGeneratedNever()
                .HasColumnName("BOR_NO");
            entity.Property(e => e.BorAddr1No).HasColumnName("BOR_ADDR1_NO");
            entity.Property(e => e.BorAddr1Txt)
                .HasMaxLength(85)
                .HasColumnName("BOR_ADDR1_TXT");
            entity.Property(e => e.BorAddr2No).HasColumnName("BOR_ADDR2_NO");
            entity.Property(e => e.BorAddr2Txt)
                .HasMaxLength(85)
                .HasColumnName("BOR_ADDR2_TXT");
            entity.Property(e => e.BorAddr3No).HasColumnName("BOR_ADDR3_NO");
            entity.Property(e => e.BorAddr3Txt)
                .HasMaxLength(85)
                .HasColumnName("BOR_ADDR3_TXT");
            entity.Property(e => e.BorApproved)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("BOR_APPROVED");
            entity.Property(e => e.BorBarNo)
                .HasMaxLength(75)
                .HasColumnName("BOR_BAR_NO");
            entity.Property(e => e.BorClass)
                .HasMaxLength(10)
                .HasColumnName("BOR_CLASS");
            entity.Property(e => e.BorDatetime).HasColumnName("BOR_DATETIME");
            entity.Property(e => e.BorDob).HasColumnName("BOR_DOB");
            entity.Property(e => e.BorDobDt).HasColumnName("BOR_DOB_DT");
            entity.Property(e => e.BorEmail)
                .HasMaxLength(75)
                .HasColumnName("BOR_EMAIL");
            entity.Property(e => e.BorEmail2)
                .HasMaxLength(75)
                .HasColumnName("BOR_EMAIL2");
            entity.Property(e => e.BorEmailPin)
                .HasMaxLength(1)
                .HasColumnName("BOR_EMAIL_PIN");
            entity.Property(e => e.BorEmailPinReset)
                .HasMaxLength(1)
                .HasColumnName("BOR_EMAIL_PIN_RESET");
            entity.Property(e => e.BorGiven)
                .HasMaxLength(50)
                .HasColumnName("BOR_GIVEN");
            entity.Property(e => e.BorGroup)
                .HasMaxLength(10)
                .HasColumnName("BOR_GROUP");
            entity.Property(e => e.BorInit)
                .HasMaxLength(25)
                .HasColumnName("BOR_INIT");
            entity.Property(e => e.BorLastactive).HasColumnName("BOR_LASTACTIVE");
            entity.Property(e => e.BorLibGroup)
                .HasMaxLength(30)
                .HasColumnName("BOR_LIB_GROUP");
            entity.Property(e => e.BorLocation)
                .HasMaxLength(20)
                .HasColumnName("BOR_LOCATION");
            entity.Property(e => e.BorMobUsfn)
                .HasMaxLength(1)
                .HasColumnName("BOR_MOB_USFN");
            entity.Property(e => e.BorMobileTel)
                .HasMaxLength(25)
                .HasColumnName("BOR_MOBILE_TEL");
            entity.Property(e => e.BorNoLoans).HasColumnName("BOR_NO_LOANS");
            entity.Property(e => e.BorNoOpacs).HasColumnName("BOR_NO_OPACS");
            entity.Property(e => e.BorNoRenews).HasColumnName("BOR_NO_RENEWS");
            entity.Property(e => e.BorNoReserves).HasColumnName("BOR_NO_RESERVES");
            entity.Property(e => e.BorNoSee).HasColumnName("BOR_NO_SEE");
            entity.Property(e => e.BorNoVisits).HasColumnName("BOR_NO_VISITS");
            entity.Property(e => e.BorOper)
                .HasMaxLength(25)
                .HasColumnName("BOR_OPER");
            entity.Property(e => e.BorOwing)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("BOR_OWING");
            entity.Property(e => e.BorPhoUsfn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BOR_PHO_USFN");
            entity.Property(e => e.BorPhoneTel)
                .HasMaxLength(25)
                .HasColumnName("BOR_PHONE_TEL");
            entity.Property(e => e.BorPin)
                .HasMaxLength(25)
                .HasColumnName("BOR_PIN");
            entity.Property(e => e.BorPotentialCharge)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("BOR_POTENTIAL_CHARGE");
            entity.Property(e => e.BorRamdomKey)
                .HasMaxLength(8)
                .HasColumnName("BOR_RAMDOM_KEY");
            entity.Property(e => e.BorRef1)
                .HasMaxLength(75)
                .HasColumnName("BOR_REF1");
            entity.Property(e => e.BorRef2)
                .HasMaxLength(150)
                .HasColumnName("BOR_REF2");
            entity.Property(e => e.BorRef3)
                .HasMaxLength(150)
                .HasColumnName("BOR_REF3");
            entity.Property(e => e.BorRegdate).HasColumnName("BOR_REGDATE");
            entity.Property(e => e.BorRejectedEmail)
                .HasMaxLength(1)
                .HasColumnName("BOR_REJECTED_EMAIL");
            entity.Property(e => e.BorRelType)
                .HasMaxLength(1)
                .HasColumnName("BOR_REL_TYPE");
            entity.Property(e => e.BorReqPinChange)
                .HasMaxLength(1)
                .HasColumnName("BOR_REQ_PIN_CHANGE");
            entity.Property(e => e.BorSecurity).HasColumnName("BOR_SECURITY");
            entity.Property(e => e.BorSex)
                .HasMaxLength(1)
                .HasColumnName("BOR_SEX");
            entity.Property(e => e.BorSoundex)
                .HasMaxLength(35)
                .HasColumnName("BOR_SOUNDEX");
            entity.Property(e => e.BorStartLocation)
                .HasMaxLength(25)
                .HasColumnName("BOR_START_LOCATION");
            entity.Property(e => e.BorStartMship).HasColumnName("BOR_START_MSHIP");
            entity.Property(e => e.BorStatus)
                .HasMaxLength(10)
                .HasColumnName("BOR_STATUS");
            entity.Property(e => e.BorSurname)
                .HasMaxLength(100)
                .HasColumnName("BOR_SURNAME");
            entity.Property(e => e.BorSurnameKey)
                .HasMaxLength(100)
                .HasColumnName("BOR_SURNAME_KEY");
            entity.Property(e => e.BorTitle)
                .HasMaxLength(25)
                .HasColumnName("BOR_TITLE");
            entity.Property(e => e.BorType)
                .HasMaxLength(3)
                .HasColumnName("BOR_TYPE");
            entity.Property(e => e.BorUseEmail)
                .HasMaxLength(1)
                .HasColumnName("BOR_USE_EMAIL");
            entity.Property(e => e.BorUseEmail2)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BOR_USE_EMAIL2");
            entity.Property(e => e.ContactTel)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CONTACT_TEL");
            entity.Property(e => e.Encryptedid).HasColumnName("ENCRYPTEDID");
            entity.Property(e => e.Gdpr)
                .HasMaxLength(1)
                .HasColumnName("GDPR");
            entity.Property(e => e.HashedBorPin)
                .HasMaxLength(256)
                .HasColumnName("HASHED_BOR_PIN");
            entity.Property(e => e.Isshowinitial).HasColumnName("ISSHOWINITIAL");
            entity.Property(e => e.ParentBorNoSee).HasColumnName("PARENT_BOR_NO_SEE");
            entity.Property(e => e.ParentConsentRestricted)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("PARENT_CONSENT_RESTRICTED");
            entity.Property(e => e.PreBorNoSee).HasColumnName("PRE_BOR_NO_SEE");
            entity.Property(e => e.Primarycontact).HasColumnName("PRIMARYCONTACT");
            entity.Property(e => e.ReadingChallenge).HasColumnName("READING_CHALLENGE");
            entity.Property(e => e.ReceiveEmails)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RECEIVE_EMAILS");
            entity.Property(e => e.ReceiveInfoByPost)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RECEIVE_INFO_BY_POST");
            entity.Property(e => e.Salutation)
                .HasMaxLength(50)
                .HasColumnName("SALUTATION");
            entity.Property(e => e.UserPwdDue).HasColumnName("USER_PWD_DUE");
            entity.Property(e => e.WondeId)
                .HasMaxLength(20)
                .HasColumnName("WONDE_ID");
        });

        modelBuilder.Entity<BorrowerTeam>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BORROWER_TEAMS");

            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");
            entity.Property(e => e.TeamId).HasColumnName("TEAM_ID");
        });

        modelBuilder.Entity<BorrowerTransfLog>(entity =>
        {
            entity.HasKey(e => e.BorBarNo).HasName("PK__BORROWER__5A546724D4D8A728");

            entity.ToTable("BORROWER_TRANSF_LOG");

            entity.Property(e => e.BorBarNo)
                .HasMaxLength(25)
                .HasColumnName("BOR_BAR_NO");
            entity.Property(e => e.DateTimeProcess)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_PROCESS");
            entity.Property(e => e.ErrorNo)
                .HasMaxLength(50)
                .HasColumnName("ERROR_NO");
            entity.Property(e => e.LibGroup)
                .HasMaxLength(50)
                .HasColumnName("LIB_GROUP");
            entity.Property(e => e.LlCode)
                .HasMaxLength(50)
                .HasColumnName("LL_CODE");
            entity.Property(e => e.OperName)
                .HasMaxLength(25)
                .HasColumnName("OPER_NAME");
            entity.Property(e => e.Status)
                .HasMaxLength(25)
                .HasColumnName("STATUS");
            entity.Property(e => e.StatusMessage)
                .HasMaxLength(250)
                .HasColumnName("STATUS_MESSAGE");
        });

        modelBuilder.Entity<CashCount>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CASH_COUNT");

            entity.Property(e => e.CashCountId)
                .ValueGeneratedOnAdd()
                .HasColumnName("CASH_COUNT_ID");
            entity.Property(e => e.CashValue)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("CASH_VALUE");
            entity.Property(e => e.ReconcileId).HasColumnName("RECONCILE_ID");
            entity.Property(e => e.TotalCount).HasColumnName("TOTAL_COUNT");
            entity.Property(e => e.TotalValue)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("TOTAL_VALUE");
        });

        modelBuilder.Entity<CashTillReconcile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CASH_TIL__3214EC272387B672");

            entity.ToTable("CASH_TILL_RECONCILE");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BalDifference)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("BAL_DIFFERENCE");
            entity.Property(e => e.ClosingBalance)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("CLOSING_BALANCE");
            entity.Property(e => e.Comment)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("COMMENT");
            entity.Property(e => e.OpeningBalance)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("OPENING_BALANCE");
            entity.Property(e => e.ReconcileId).HasColumnName("RECONCILE_ID");
            entity.Property(e => e.RecordedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RECORDED_BY");
            entity.Property(e => e.RecordedOn)
                .HasColumnType("datetime")
                .HasColumnName("RECORDED_ON");
            entity.Property(e => e.TillId).HasColumnName("TILL_ID");
            entity.Property(e => e.TotalWithdrawn)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("TOTAL_WITHDRAWN");
        });

        modelBuilder.Entity<CatBorLike>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CAT_BOR_LIKE");

            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");
            entity.Property(e => e.CatNo).HasColumnName("CAT_NO");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.LastUpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATED_ON");
        });

        modelBuilder.Entity<CatDynamicTemplate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CAT_DYNAMIC_TEMPLATE");

            entity.Property(e => e.ContentStyle)
                .HasMaxLength(50)
                .HasColumnName("CONTENT_STYLE");
            entity.Property(e => e.ContentType)
                .HasMaxLength(15)
                .HasColumnName("CONTENT_TYPE");
            entity.Property(e => e.CurrentTemplate)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CURRENT_TEMPLATE");
            entity.Property(e => e.KwordSearch)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("KWORD_SEARCH");
            entity.Property(e => e.LabelDesc)
                .HasMaxLength(50)
                .HasColumnName("LABEL_DESC");
            entity.Property(e => e.LibGroup)
                .HasMaxLength(30)
                .HasColumnName("LIB_GROUP");
            entity.Property(e => e.LookupOnly).HasColumnName("LOOKUP_ONLY");
            entity.Property(e => e.MarcTag).HasColumnName("MARC_TAG");
            entity.Property(e => e.MarcTagGroupId).HasColumnName("MARC_TAG_GROUP_ID");
            entity.Property(e => e.OpacShow)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("OPAC_SHOW");
            entity.Property(e => e.Pkid)
                .ValueGeneratedOnAdd()
                .HasColumnName("PKID");
            entity.Property(e => e.Searchable)
                .HasDefaultValue(true)
                .HasColumnName("SEARCHABLE");
            entity.Property(e => e.Subfield)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SUBFIELD");
            entity.Property(e => e.TagLabelDesc)
                .HasMaxLength(100)
                .HasColumnName("TAG_LABEL_DESC");
            entity.Property(e => e.TemplateId)
                .HasMaxLength(15)
                .HasColumnName("TEMPLATE_ID");
        });

        modelBuilder.Entity<CatDynamicTemplateConfig>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CAT_DYNAMIC_TEMPLATE_CONFIG");

            entity.Property(e => e.EnableDuplication).HasColumnName("ENABLE_DUPLICATION");
            entity.Property(e => e.ShowMatchCheck).HasColumnName("SHOW_MATCH_CHECK");
            entity.Property(e => e.ShowUniqueCheck).HasColumnName("SHOW_UNIQUE_CHECK");
            entity.Property(e => e.TempDesc)
                .HasMaxLength(100)
                .HasColumnName("TEMP_DESC");
            entity.Property(e => e.TemplateId)
                .HasMaxLength(15)
                .HasColumnName("TEMPLATE_ID");
        });

        modelBuilder.Entity<Checkdigit>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CHECKDIGITS");

            entity.Property(e => e.CdEndChars).HasColumnName("CD_END_CHARS");
            entity.Property(e => e.CdLeading)
                .HasMaxLength(10)
                .HasColumnName("CD_LEADING");
            entity.Property(e => e.CdLength).HasColumnName("CD_LENGTH");
            entity.Property(e => e.CdModulus).HasColumnName("CD_MODULUS");
            entity.Property(e => e.CdStartChars).HasColumnName("CD_START_CHARS");
            entity.Property(e => e.CdTrailing)
                .HasMaxLength(10)
                .HasColumnName("CD_TRAILING");
            entity.Property(e => e.CdType)
                .HasMaxLength(1)
                .HasColumnName("CD_TYPE");
            entity.Property(e => e.CdUnique).HasColumnName("CD_UNIQUE");
            entity.Property(e => e.CdUnusual)
                .HasMaxLength(1)
                .HasColumnName("CD_UNUSUAL");
            entity.Property(e => e.CdUse)
                .HasMaxLength(25)
                .HasColumnName("CD_USE");
            entity.Property(e => e.CdWeights)
                .HasMaxLength(100)
                .HasColumnName("CD_WEIGHTS");
        });

        modelBuilder.Entity<CiBookFlag>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_BOOK_FLAG");

            entity.HasIndex(e => new { e.BkfFacNo, e.BkfTimecode }, "BKF_FAC_NOX");

            entity.HasIndex(e => e.BkfUnique, "BKF_UNIQUEX");

            entity.Property(e => e.BkfDatetime)
                .HasColumnType("datetime")
                .HasColumnName("BKF_DATETIME");
            entity.Property(e => e.BkfExpires)
                .HasColumnType("datetime")
                .HasColumnName("BKF_EXPIRES");
            entity.Property(e => e.BkfFacNo).HasColumnName("BKF_FAC_NO");
            entity.Property(e => e.BkfFgNo).HasColumnName("BKF_FG_NO");
            entity.Property(e => e.BkfOper)
                .HasMaxLength(25)
                .HasColumnName("BKF_OPER");
            entity.Property(e => e.BkfTemp)
                .HasMaxLength(1)
                .HasColumnName("BKF_TEMP");
            entity.Property(e => e.BkfTimeactual)
                .HasColumnType("datetime")
                .HasColumnName("BKF_TIMEACTUAL");
            entity.Property(e => e.BkfTimecode).HasColumnName("BKF_TIMECODE");
            entity.Property(e => e.BkfUnique).HasColumnName("BKF_UNIQUE");
        });

        modelBuilder.Entity<CiBooking>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_BOOKING");

            entity.HasIndex(e => e.BkBorKey, "BK_BOR_KEYX");

            entity.HasIndex(e => e.BkBorNo, "BK_BOR_NOX");

            entity.HasIndex(e => e.BkFacNo, "BK_FAC_NOX");

            entity.HasIndex(e => e.BkFgNo, "BK_GRP_NOX");

            entity.HasIndex(e => e.BkKey, "BK_KEYX");

            entity.Property(e => e.BkBondDue)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("BK_BOND_DUE");
            entity.Property(e => e.BkBondPaid)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("BK_BOND_PAID");
            entity.Property(e => e.BkBorKey)
                .HasMaxLength(50)
                .HasColumnName("BK_BOR_KEY");
            entity.Property(e => e.BkBorName)
                .HasMaxLength(50)
                .HasColumnName("BK_BOR_NAME");
            entity.Property(e => e.BkBorNo).HasColumnName("BK_BOR_NO");
            entity.Property(e => e.BkCatNo).HasColumnName("BK_CAT_NO");
            entity.Property(e => e.BkCost)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("BK_COST");
            entity.Property(e => e.BkCostPaid)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("BK_COST_PAID");
            entity.Property(e => e.BkDatetime)
                .HasColumnType("datetime")
                .HasColumnName("BK_DATETIME");
            entity.Property(e => e.BkDesc)
                .HasMaxLength(100)
                .HasColumnName("BK_DESC");
            entity.Property(e => e.BkEndDate)
                .HasColumnType("datetime")
                .HasColumnName("BK_END_DATE");
            entity.Property(e => e.BkFacNo).HasColumnName("BK_FAC_NO");
            entity.Property(e => e.BkFgNo).HasColumnName("BK_FG_NO");
            entity.Property(e => e.BkKey)
                .HasMaxLength(100)
                .HasColumnName("BK_KEY");
            entity.Property(e => e.BkNotes)
                .HasMaxLength(250)
                .HasColumnName("BK_NOTES");
            entity.Property(e => e.BkOper)
                .HasMaxLength(25)
                .HasColumnName("BK_OPER");
            entity.Property(e => e.BkReceipt)
                .HasMaxLength(100)
                .HasColumnName("BK_RECEIPT");
            entity.Property(e => e.BkStartDate)
                .HasColumnType("datetime")
                .HasColumnName("BK_START_DATE");
            entity.Property(e => e.BkTaxDue)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("BK_TAX_DUE");
            entity.Property(e => e.BkTotal).HasColumnName("BK_TOTAL");
            entity.Property(e => e.BkUnique).HasColumnName("BK_UNIQUE");
        });

        modelBuilder.Entity<CiDiscountDet>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_DISCOUNT_DETS");

            entity.Property(e => e.DdAfttime).HasColumnName("DD_AFTTIME");
            entity.Property(e => e.DdBeftime).HasColumnName("DD_BEFTIME");
            entity.Property(e => e.DdCode)
                .HasMaxLength(3)
                .HasColumnName("DD_CODE");
            entity.Property(e => e.DdDayIn)
                .HasMaxLength(30)
                .HasColumnName("DD_DAY_IN");
            entity.Property(e => e.DdPatIn)
                .HasMaxLength(100)
                .HasColumnName("DD_PAT_IN");
            entity.Property(e => e.DdPercentage)
                .HasColumnType("decimal(10, 4)")
                .HasColumnName("DD_PERCENTAGE");
        });

        modelBuilder.Entity<CiDiscountList>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_DISCOUNT_LIST");

            entity.Property(e => e.DlCode)
                .HasMaxLength(3)
                .HasColumnName("DL_CODE");
            entity.Property(e => e.DlDesc)
                .HasMaxLength(30)
                .HasColumnName("DL_DESC");
        });

        modelBuilder.Entity<CiEquipment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_EQUIPMENT");

            entity.Property(e => e.EqBond)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("EQ_BOND");
            entity.Property(e => e.EqBookingId)
                .HasMaxLength(25)
                .HasColumnName("EQ_BOOKING_ID");
            entity.Property(e => e.EqDaily)
                .HasMaxLength(1)
                .HasColumnName("EQ_DAILY");
            entity.Property(e => e.EqDesc)
                .HasMaxLength(100)
                .HasColumnName("EQ_DESC");
            entity.Property(e => e.EqFacNo).HasColumnName("EQ_FAC_NO");
            entity.Property(e => e.EqFeeDay)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("EQ_FEE_DAY");
            entity.Property(e => e.EqFeeHour)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("EQ_FEE_HOUR");
            entity.Property(e => e.EqFeeWeek)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("EQ_FEE_WEEK");
            entity.Property(e => e.EqFeeWeekend)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("EQ_FEE_WEEKEND");
            entity.Property(e => e.EqHourly)
                .HasMaxLength(1)
                .HasColumnName("EQ_HOURLY");
            entity.Property(e => e.EqKey)
                .HasMaxLength(100)
                .HasColumnName("EQ_KEY");
            entity.Property(e => e.EqNo).HasColumnName("EQ_NO");
            entity.Property(e => e.EqUnits)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("EQ_UNITS");
            entity.Property(e => e.EqWeekly)
                .HasMaxLength(1)
                .HasColumnName("EQ_WEEKLY");
        });

        modelBuilder.Entity<CiFacCost>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_FAC_COST");

            entity.HasIndex(e => e.FcFacNo, "FC_FAC_NOX");

            entity.Property(e => e.FcCost)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("FC_COST");
            entity.Property(e => e.FcDay).HasColumnName("FC_DAY");
            entity.Property(e => e.FcEnd)
                .HasColumnType("datetime")
                .HasColumnName("FC_END");
            entity.Property(e => e.FcFacNo).HasColumnName("FC_FAC_NO");
            entity.Property(e => e.FcStart)
                .HasColumnType("datetime")
                .HasColumnName("FC_START");
        });

        modelBuilder.Entity<CiFacGroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_FAC_GROUP");

            entity.HasIndex(e => e.FgCatNo, "FG_CAT_NOX");

            entity.HasIndex(e => e.FgKey, "FG_KEYX");

            entity.HasIndex(e => e.FgNo, "FG_NOX").IsUnique();

            entity.Property(e => e.FgCatNo).HasColumnName("FG_CAT_NO");
            entity.Property(e => e.FgComments)
                .HasMaxLength(250)
                .HasColumnName("FG_COMMENTS");
            entity.Property(e => e.FgDesc)
                .HasMaxLength(100)
                .HasColumnName("FG_DESC");
            entity.Property(e => e.FgFacCount).HasColumnName("FG_FAC_COUNT");
            entity.Property(e => e.FgKey)
                .HasMaxLength(100)
                .HasColumnName("FG_KEY");
            entity.Property(e => e.FgNo).HasColumnName("FG_NO");
        });

        modelBuilder.Entity<CiFacGroupList>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_FAC_GROUP_LIST");

            entity.HasIndex(e => e.FglFacNo, "GL_FAC_NOX");

            entity.HasIndex(e => e.FglFgNo, "GL_GRP_NOX");

            entity.Property(e => e.FglFacNo).HasColumnName("FGL_FAC_NO");
            entity.Property(e => e.FglFgNo).HasColumnName("FGL_FG_NO");
        });

        modelBuilder.Entity<CiFacHour>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_FAC_HOURS");

            entity.HasIndex(e => e.FhFacNo, "FH_FAC_NOX");

            entity.Property(e => e.FhClose)
                .HasColumnType("datetime")
                .HasColumnName("FH_CLOSE");
            entity.Property(e => e.FhDay).HasColumnName("FH_DAY");
            entity.Property(e => e.FhFacNo).HasColumnName("FH_FAC_NO");
            entity.Property(e => e.FhOpen)
                .HasColumnType("datetime")
                .HasColumnName("FH_OPEN");
        });

        modelBuilder.Entity<CiFacMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_FAC_MASTER");

            entity.HasIndex(e => e.CifmCatNo, "CI_FMCATX");

            entity.Property(e => e.CifmCatNo).HasColumnName("CIFM_CAT_NO");
            entity.Property(e => e.CifmLine1)
                .HasMaxLength(100)
                .HasColumnName("CIFM_LINE1");
            entity.Property(e => e.CifmLine2)
                .HasMaxLength(100)
                .HasColumnName("CIFM_LINE2");
            entity.Property(e => e.CifmLine3)
                .HasMaxLength(100)
                .HasColumnName("CIFM_LINE3");
            entity.Property(e => e.CifmLine4)
                .HasMaxLength(100)
                .HasColumnName("CIFM_LINE4");
            entity.Property(e => e.CifmLine5)
                .HasMaxLength(100)
                .HasColumnName("CIFM_LINE5");
            entity.Property(e => e.CifmLine6)
                .HasMaxLength(100)
                .HasColumnName("CIFM_LINE6");
        });

        modelBuilder.Entity<CiFacStatsCode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_FAC_STATS_CODES");

            entity.Property(e => e.FsCode)
                .HasMaxLength(10)
                .HasColumnName("FS_CODE");
            entity.Property(e => e.FsDesc)
                .HasMaxLength(50)
                .HasColumnName("FS_DESC");
        });

        modelBuilder.Entity<CiFacility>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_FACILITY");

            entity.HasIndex(e => e.FacCatNo, "FAC_CAT_NOX");

            entity.HasIndex(e => e.FacKey, "FAC_KEYX");

            entity.HasIndex(e => e.FacNo, "FAC_NOX").IsUnique();

            entity.Property(e => e.FacBarCode)
                .HasMaxLength(25)
                .HasColumnName("FAC_BAR_CODE");
            entity.Property(e => e.FacBookings)
                .HasMaxLength(1)
                .HasColumnName("FAC_BOOKINGS");
            entity.Property(e => e.FacCatNo).HasColumnName("FAC_CAT_NO");
            entity.Property(e => e.FacComments)
                .HasMaxLength(250)
                .HasColumnName("FAC_COMMENTS");
            entity.Property(e => e.FacCost)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("FAC_COST");
            entity.Property(e => e.FacDeposit)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("FAC_DEPOSIT");
            entity.Property(e => e.FacDesc)
                .HasMaxLength(100)
                .HasColumnName("FAC_DESC");
            entity.Property(e => e.FacEBond)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("FAC_E_BOND");
            entity.Property(e => e.FacEDisc)
                .HasMaxLength(1)
                .HasColumnName("FAC_E_DISC");
            entity.Property(e => e.FacEDiscsched)
                .HasMaxLength(3)
                .HasColumnName("FAC_E_DISCSCHED");
            entity.Property(e => e.FacEFeeDay)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("FAC_E_FEE_DAY");
            entity.Property(e => e.FacEFeeHalf)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("FAC_E_FEE_HALF");
            entity.Property(e => e.FacEFeeHour)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("FAC_E_FEE_HOUR");
            entity.Property(e => e.FacEFeeWeek)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("FAC_E_FEE_WEEK");
            entity.Property(e => e.FacEFeeWkend)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("FAC_E_FEE_WKEND");
            entity.Property(e => e.FacEMax)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("FAC_E_MAX");
            entity.Property(e => e.FacEOcc)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("FAC_E_OCC");
            entity.Property(e => e.FacEUnits)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("FAC_E_UNITS");
            entity.Property(e => e.FacEndDate)
                .HasColumnType("datetime")
                .HasColumnName("FAC_END_DATE");
            entity.Property(e => e.FacEquipHire)
                .HasMaxLength(1)
                .HasColumnName("FAC_EQUIP_HIRE");
            entity.Property(e => e.FacHolClose)
                .HasMaxLength(1)
                .HasColumnName("FAC_HOL_CLOSE");
            entity.Property(e => e.FacKey)
                .HasMaxLength(100)
                .HasColumnName("FAC_KEY");
            entity.Property(e => e.FacNo).HasColumnName("FAC_NO");
            entity.Property(e => e.FacPatron)
                .HasMaxLength(1)
                .HasColumnName("FAC_PATRON");
            entity.Property(e => e.FacStartDate)
                .HasColumnType("datetime")
                .HasColumnName("FAC_START_DATE");
            entity.Property(e => e.FacStatsClass)
                .HasMaxLength(10)
                .HasColumnName("FAC_STATS_CLASS");
        });

        modelBuilder.Entity<CiFileKeyword>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_FILE_KEYWORD");

            entity.HasIndex(e => e.FkFileNo, "CI_FK_FILE_NOX");

            entity.HasIndex(e => e.FkUniqueNo, "CI_FK_UNIQUE_NOX");

            entity.Property(e => e.FkFileNo).HasColumnName("FK_FILE_NO");
            entity.Property(e => e.FkUniqueNo).HasColumnName("FK_UNIQUE_NO");
        });

        modelBuilder.Entity<CiFileKwOper>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_FILE_KW_OPER");

            entity.HasIndex(e => e.FoOperName, "CI_FO_OPER_NAMEX");

            entity.Property(e => e.FoDatetime)
                .HasColumnType("datetime")
                .HasColumnName("FO_DATETIME");
            entity.Property(e => e.FoFileNo).HasColumnName("FO_FILE_NO");
            entity.Property(e => e.FoOperName)
                .HasMaxLength(8)
                .HasColumnName("FO_OPER_NAME");
        });

        modelBuilder.Entity<CiHoliday>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_HOLIDAY");

            entity.Property(e => e.HolDate)
                .HasColumnType("datetime")
                .HasColumnName("HOL_DATE");
            entity.Property(e => e.HolDesc)
                .HasMaxLength(50)
                .HasColumnName("HOL_DESC");
        });

        modelBuilder.Entity<CiStatsCode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_STATS_CODES");

            entity.HasIndex(e => new { e.StatsType, e.StatsYear, e.StatsMonth, e.StatsDay }, "CIST_CODEX");

            entity.Property(e => e.StatsAreaCd)
                .HasMaxLength(1)
                .HasColumnName("STATS_AREA_CD");
            entity.Property(e => e.StatsBorrower)
                .HasMaxLength(1)
                .HasColumnName("STATS_BORROWER");
            entity.Property(e => e.StatsClass)
                .HasMaxLength(1)
                .HasColumnName("STATS_CLASS");
            entity.Property(e => e.StatsCount)
                .HasMaxLength(1)
                .HasColumnName("STATS_COUNT");
            entity.Property(e => e.StatsDay)
                .HasMaxLength(1)
                .HasColumnName("STATS_DAY");
            entity.Property(e => e.StatsDescription)
                .HasMaxLength(50)
                .HasColumnName("STATS_DESCRIPTION");
            entity.Property(e => e.StatsDiscCode)
                .HasMaxLength(1)
                .HasColumnName("STATS_DISC_CODE");
            entity.Property(e => e.StatsFacEquip)
                .HasMaxLength(1)
                .HasColumnName("STATS_FAC_EQUIP");
            entity.Property(e => e.StatsFacNo)
                .HasMaxLength(1)
                .HasColumnName("STATS_FAC_NO");
            entity.Property(e => e.StatsHour)
                .HasMaxLength(1)
                .HasColumnName("STATS_HOUR");
            entity.Property(e => e.StatsLocation)
                .HasMaxLength(1)
                .HasColumnName("STATS_LOCATION");
            entity.Property(e => e.StatsMoney)
                .HasMaxLength(1)
                .HasColumnName("STATS_MONEY");
            entity.Property(e => e.StatsMonth)
                .HasMaxLength(1)
                .HasColumnName("STATS_MONTH");
            entity.Property(e => e.StatsSuburb)
                .HasMaxLength(1)
                .HasColumnName("STATS_SUBURB");
            entity.Property(e => e.StatsTax)
                .HasMaxLength(1)
                .HasColumnName("STATS_TAX");
            entity.Property(e => e.StatsType).HasColumnName("STATS_TYPE");
            entity.Property(e => e.StatsWard)
                .HasMaxLength(1)
                .HasColumnName("STATS_WARD");
            entity.Property(e => e.StatsYear)
                .HasMaxLength(1)
                .HasColumnName("STATS_YEAR");
        });

        modelBuilder.Entity<CiSysHeader>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_SYS_HEADER");

            entity.Property(e => e.BfUnique).HasColumnName("BF_UNIQUE");
            entity.Property(e => e.BkUnique).HasColumnName("BK_UNIQUE");
            entity.Property(e => e.CiTax)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("CI_TAX");
            entity.Property(e => e.CltUnique).HasColumnName("CLT_UNIQUE");
            entity.Property(e => e.CtUnique).HasColumnName("CT_UNIQUE");
            entity.Property(e => e.EqNo).HasColumnName("EQ_NO");
            entity.Property(e => e.FacNo).HasColumnName("FAC_NO");
            entity.Property(e => e.FileNo).HasColumnName("FILE_NO");
            entity.Property(e => e.GroupNo).HasColumnName("GROUP_NO");
            entity.Property(e => e.SysBookequipPrt)
                .HasMaxLength(50)
                .HasColumnName("SYS_BOOKEQUIP_PRT");
            entity.Property(e => e.SysBookfacPrt)
                .HasMaxLength(50)
                .HasColumnName("SYS_BOOKFAC_PRT");
            entity.Property(e => e.SysRound)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("SYS_ROUND");
            entity.Property(e => e.SysUser)
                .HasMaxLength(8)
                .HasColumnName("SYS_USER");
        });

        modelBuilder.Entity<CiUniqNum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_UNIQ_NUM");

            entity.Property(e => e.UniqBookNo).HasColumnName("UNIQ_BOOK_NO");
            entity.Property(e => e.UniqEqNum).HasColumnName("UNIQ_EQ_NUM");
        });

        modelBuilder.Entity<CiWebDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_WEB_DATA");

            entity.HasIndex(e => e.WebDate, "WEB_DATEX");

            entity.HasIndex(e => new { e.WebSerial, e.WebSeqStart, e.WebSet }, "WEB_SERIALX");

            entity.Property(e => e.WebDate)
                .HasColumnType("datetime")
                .HasColumnName("WEB_DATE");
            entity.Property(e => e.WebSeqStart).HasColumnName("WEB_SEQ_START");
            entity.Property(e => e.WebSerial).HasColumnName("WEB_SERIAL");
            entity.Property(e => e.WebSet)
                .HasMaxLength(12)
                .HasColumnName("WEB_SET");
            entity.Property(e => e.WebString)
                .HasMaxLength(240)
                .HasColumnName("WEB_STRING");
        });

        modelBuilder.Entity<CiWebHmtl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_WEB_HMTL");

            entity.Property(e => e.WebArea)
                .HasMaxLength(1)
                .HasColumnName("WEB_AREA");
            entity.Property(e => e.WebBackground)
                .HasMaxLength(50)
                .HasColumnName("WEB_BACKGROUND");
            entity.Property(e => e.WebHtmFile)
                .HasMaxLength(76)
                .HasColumnName("WEB_HTM_FILE");
            entity.Property(e => e.WebLineList1)
                .HasMaxLength(240)
                .HasColumnName("WEB_LINE_LIST1");
            entity.Property(e => e.WebLineList2)
                .HasMaxLength(240)
                .HasColumnName("WEB_LINE_LIST2");
            entity.Property(e => e.WebLineList3)
                .HasMaxLength(240)
                .HasColumnName("WEB_LINE_LIST3");
            entity.Property(e => e.WebLinkCodeIn)
                .HasMaxLength(120)
                .HasColumnName("WEB_LINK_CODE_IN");
            entity.Property(e => e.WebLinkCodeOut)
                .HasMaxLength(120)
                .HasColumnName("WEB_LINK_CODE_OUT");
            entity.Property(e => e.WebNoteline)
                .HasMaxLength(1)
                .HasColumnName("WEB_NOTELINE");
            entity.Property(e => e.WebScreen).HasColumnName("WEB_SCREEN");
            entity.Property(e => e.WebSequence).HasColumnName("WEB_SEQUENCE");
            entity.Property(e => e.WebStatsCode).HasColumnName("WEB_STATS_CODE");
            entity.Property(e => e.WebTagList1)
                .HasMaxLength(60)
                .HasColumnName("WEB_TAG_LIST1");
            entity.Property(e => e.WebTagList2)
                .HasMaxLength(60)
                .HasColumnName("WEB_TAG_LIST2");
            entity.Property(e => e.WebTagList3)
                .HasMaxLength(60)
                .HasColumnName("WEB_TAG_LIST3");
            entity.Property(e => e.WebText1)
                .HasMaxLength(240)
                .HasColumnName("WEB_TEXT1");
            entity.Property(e => e.WebText2)
                .HasMaxLength(240)
                .HasColumnName("WEB_TEXT2");
            entity.Property(e => e.WebTextlink)
                .HasMaxLength(120)
                .HasColumnName("WEB_TEXTLINK");
            entity.Property(e => e.WebTlwidth).HasColumnName("WEB_TLWIDTH");
            entity.Property(e => e.WebTwidth1).HasColumnName("WEB_TWIDTH1");
            entity.Property(e => e.WebTwidth2).HasColumnName("WEB_TWIDTH2");
            entity.Property(e => e.WebType)
                .HasMaxLength(1)
                .HasColumnName("WEB_TYPE");
            entity.Property(e => e.WebUser)
                .HasMaxLength(10)
                .HasColumnName("WEB_USER");
        });

        modelBuilder.Entity<CiWebSystab>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_WEB_SYSTAB");

            entity.Property(e => e.WebSerial).HasColumnName("WEB_SERIAL");
        });

        modelBuilder.Entity<CircExportBor>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CIRC_EXPORT_BOR");

            entity.Property(e => e.CebBanned)
                .HasMaxLength(1)
                .HasColumnName("CEB_BANNED");
            entity.Property(e => e.CebBarcode)
                .HasMaxLength(30)
                .HasColumnName("CEB_BARCODE");
            entity.Property(e => e.CebBorName)
                .HasMaxLength(40)
                .HasColumnName("CEB_BOR_NAME");
            entity.Property(e => e.CebBorStatus)
                .HasMaxLength(6)
                .HasColumnName("CEB_BOR_STATUS");
            entity.Property(e => e.CebBorType)
                .HasMaxLength(3)
                .HasColumnName("CEB_BOR_TYPE");
            entity.Property(e => e.CebHasMemo)
                .HasMaxLength(1)
                .HasColumnName("CEB_HAS_MEMO");
            entity.Property(e => e.CebOverride)
                .HasMaxLength(1)
                .HasColumnName("CEB_OVERRIDE");
            entity.Property(e => e.CebOwing)
                .HasMaxLength(7)
                .HasColumnName("CEB_OWING");
        });

        modelBuilder.Entity<CircExportMemo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CIRC_EXPORT_MEMO");

            entity.Property(e => e.CemBarcode)
                .HasMaxLength(30)
                .HasColumnName("CEM_BARCODE");
            entity.Property(e => e.CemData)
                .HasMaxLength(249)
                .HasColumnName("CEM_DATA");
            entity.Property(e => e.CemDatefr)
                .HasMaxLength(12)
                .HasColumnName("CEM_DATEFR");
            entity.Property(e => e.CemDateto)
                .HasMaxLength(12)
                .HasColumnName("CEM_DATETO");
            entity.Property(e => e.CemShow)
                .HasMaxLength(1)
                .HasColumnName("CEM_SHOW");
            entity.Property(e => e.CemType)
                .HasMaxLength(10)
                .HasColumnName("CEM_TYPE");
        });

        modelBuilder.Entity<CircExportStk>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CIRC_EXPORT_STK");

            entity.Property(e => e.CesAlert)
                .HasMaxLength(1)
                .HasColumnName("CES_ALERT");
            entity.Property(e => e.CesAllowLoan)
                .HasMaxLength(1)
                .HasColumnName("CES_ALLOW_LOAN");
            entity.Property(e => e.CesBarcode)
                .HasMaxLength(30)
                .HasColumnName("CES_BARCODE");
            entity.Property(e => e.CesBorname)
                .HasMaxLength(40)
                .HasColumnName("CES_BORNAME");
            entity.Property(e => e.CesForm)
                .HasMaxLength(3)
                .HasColumnName("CES_FORM");
            entity.Property(e => e.CesHasMemo)
                .HasMaxLength(1)
                .HasColumnName("CES_HAS_MEMO");
            entity.Property(e => e.CesIllRenew)
                .HasMaxLength(1)
                .HasColumnName("CES_ILL_RENEW");
            entity.Property(e => e.CesLoanType)
                .HasMaxLength(3)
                .HasColumnName("CES_LOAN_TYPE");
            entity.Property(e => e.CesProcess)
                .HasMaxLength(20)
                .HasColumnName("CES_PROCESS");
            entity.Property(e => e.CesReserved)
                .HasMaxLength(3)
                .HasColumnName("CES_RESERVED");
            entity.Property(e => e.CesStats)
                .HasMaxLength(6)
                .HasColumnName("CES_STATS");
            entity.Property(e => e.CesTitle)
                .HasMaxLength(40)
                .HasColumnName("CES_TITLE");
        });

        modelBuilder.Entity<CircImportOffline>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CIRC_IMPORT_OFFLINE");

            entity.Property(e => e.CioBarcode)
                .HasMaxLength(30)
                .HasColumnName("CIO_BARCODE");
            entity.Property(e => e.CioDatetime)
                .HasColumnType("datetime")
                .HasColumnName("CIO_DATETIME");
            entity.Property(e => e.CioInMessages)
                .HasMaxLength(100)
                .HasColumnName("CIO_IN_MESSAGES");
            entity.Property(e => e.CioIssuedItem)
                .HasMaxLength(30)
                .HasColumnName("CIO_ISSUED_ITEM");
            entity.Property(e => e.CioLocation)
                .HasMaxLength(30)
                .HasColumnName("CIO_LOCATION");
            entity.Property(e => e.CioOperator)
                .HasMaxLength(30)
                .HasColumnName("CIO_OPERATOR");
            entity.Property(e => e.CioProcMessages)
                .HasMaxLength(100)
                .HasColumnName("CIO_PROC_MESSAGES");
            entity.Property(e => e.CioProcess)
                .HasMaxLength(1)
                .HasColumnName("CIO_PROCESS");
            entity.Property(e => e.CioProcessDtime)
                .HasColumnType("datetime")
                .HasColumnName("CIO_PROCESS_DTIME");
            entity.Property(e => e.CioType)
                .HasMaxLength(1)
                .HasColumnName("CIO_TYPE");
            entity.Property(e => e.CioUniqueNo).HasColumnName("CIO_UNIQUE_NO");
        });

        modelBuilder.Entity<CirculationTransfLog>(entity =>
        {
            entity.HasKey(e => new { e.StkItemNo, e.BorBarNo }).HasName("PK__CIRCULAT__9DF658D407786CF1");

            entity.ToTable("CIRCULATION_TRANSF_LOG");

            entity.Property(e => e.StkItemNo)
                .HasMaxLength(25)
                .HasColumnName("STK_ITEM_NO");
            entity.Property(e => e.BorBarNo)
                .HasMaxLength(25)
                .HasColumnName("BOR_BAR_NO");
            entity.Property(e => e.DateTimeProcess)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_PROCESS");
            entity.Property(e => e.ErrorNo)
                .HasMaxLength(50)
                .HasColumnName("ERROR_NO");
            entity.Property(e => e.LibGroup)
                .HasMaxLength(50)
                .HasColumnName("LIB_GROUP");
            entity.Property(e => e.LlCode)
                .HasMaxLength(50)
                .HasColumnName("LL_CODE");
            entity.Property(e => e.OperName)
                .HasMaxLength(25)
                .HasColumnName("OPER_NAME");
            entity.Property(e => e.Status)
                .HasMaxLength(25)
                .HasColumnName("STATUS");
            entity.Property(e => e.StatusMessage)
                .HasMaxLength(250)
                .HasColumnName("STATUS_MESSAGE");
            entity.Property(e => e.TransactionType)
                .HasMaxLength(25)
                .HasColumnName("TRANSACTION_TYPE");
        });

        modelBuilder.Entity<CivisionMedchief>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CIVISION_MEDCHIEF");

            entity.Property(e => e.AmcUnique).HasColumnName("AMC_UNIQUE");
        });

        modelBuilder.Entity<CivisionMedium>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CIVISION_MEDIA");

            entity.Property(e => e.AsBrief)
                .HasMaxLength(50)
                .HasColumnName("AS_BRIEF");
            entity.Property(e => e.AsDate)
                .HasColumnType("datetime")
                .HasColumnName("AS_DATE");
            entity.Property(e => e.AsEntity).HasColumnName("AS_ENTITY");
            entity.Property(e => e.AsFilename)
                .HasMaxLength(50)
                .HasColumnName("AS_FILENAME");
            entity.Property(e => e.AsGroup)
                .HasMaxLength(3)
                .HasColumnName("AS_GROUP");
            entity.Property(e => e.AsPlayVia)
                .HasMaxLength(50)
                .HasColumnName("AS_PLAY_VIA");
            entity.Property(e => e.AsSequence).HasColumnName("AS_SEQUENCE");
            entity.Property(e => e.AsType)
                .HasMaxLength(1)
                .HasColumnName("AS_TYPE");
            entity.Property(e => e.AsWho)
                .HasMaxLength(25)
                .HasColumnName("AS_WHO");
        });

        modelBuilder.Entity<ClaimCode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CLAIM_CODES");

            entity.Property(e => e.ClCode)
                .HasMaxLength(3)
                .HasColumnName("CL_CODE");
            entity.Property(e => e.ClDays).HasColumnName("CL_DAYS");
            entity.Property(e => e.ClDesc)
                .HasMaxLength(50)
                .HasColumnName("CL_DESC");
            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");
        });

        modelBuilder.Entity<ClaimCodesTran>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CLAIM_CODES_TRANS");

            entity.Property(e => e.ClCode)
                .HasMaxLength(3)
                .HasColumnName("CL_CODE");
            entity.Property(e => e.ClDescTrans)
                .HasMaxLength(50)
                .HasColumnName("CL_DESC_TRANS");
            entity.Property(e => e.Lcid).HasColumnName("LCID");
        });

        modelBuilder.Entity<Convertfile>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CONVERTFILES");

            entity.Property(e => e.ConvAveprice)
                .HasMaxLength(1)
                .HasColumnName("CONV_AVEPRICE");
            entity.Property(e => e.ConvDepritem)
                .HasMaxLength(1)
                .HasColumnName("CONV_DEPRITEM");
            entity.Property(e => e.ConvDone).HasColumnName("CONV_DONE");
            entity.Property(e => e.ConvDothismany).HasColumnName("CONV_DOTHISMANY");
            entity.Property(e => e.ConvEndtime)
                .HasColumnType("datetime")
                .HasColumnName("CONV_ENDTIME");
            entity.Property(e => e.ConvInprocess)
                .HasMaxLength(1)
                .HasColumnName("CONV_INPROCESS");
            entity.Property(e => e.ConvItemonly)
                .HasMaxLength(1)
                .HasColumnName("CONV_ITEMONLY");
            entity.Property(e => e.ConvOrder)
                .HasMaxLength(1)
                .HasColumnName("CONV_ORDER");
            entity.Property(e => e.ConvStartfrom).HasColumnName("CONV_STARTFROM");
            entity.Property(e => e.ConvStarttime)
                .HasColumnType("datetime")
                .HasColumnName("CONV_STARTTIME");
            entity.Property(e => e.Convfilename)
                .HasMaxLength(76)
                .HasColumnName("CONVFILENAME");
            entity.Property(e => e.Convpath)
                .HasMaxLength(50)
                .HasColumnName("CONVPATH");
        });

        modelBuilder.Entity<CopyrightNotice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__COPYRIGH__3214EC27A91E19AE");

            entity.ToTable("COPYRIGHT_NOTICE");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(100)
                .HasColumnName("LAST_UPDATED_BY");
            entity.Property(e => e.LastUpdatedOn).HasColumnName("LAST_UPDATED_ON");
            entity.Property(e => e.LlCode)
                .HasMaxLength(50)
                .HasColumnName("LL_CODE");
            entity.Property(e => e.LlGroup)
                .HasMaxLength(50)
                .HasColumnName("LL_GROUP");
            entity.Property(e => e.TextContent).HasColumnName("TEXT_CONTENT");
            entity.Property(e => e.UniqueId)
                .HasMaxLength(150)
                .HasColumnName("UNIQUE_ID");
        });

        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.CoCode);

            entity.ToTable("COURSE");

            entity.Property(e => e.CoCode)
                .HasMaxLength(20)
                .HasColumnName("CO_CODE");
            entity.Property(e => e.CoDescription)
                .HasMaxLength(100)
                .HasColumnName("CO_DESCRIPTION");
        });

        modelBuilder.Entity<CoursePeriod>(entity =>
        {
            entity.HasKey(e => new { e.CpCoCode, e.CpDateFrom, e.CpDateTo });

            entity.ToTable("COURSE_PERIOD");

            entity.Property(e => e.CpCoCode)
                .HasMaxLength(20)
                .HasColumnName("CP_CO_CODE");
            entity.Property(e => e.CpDateFrom)
                .HasColumnType("datetime")
                .HasColumnName("CP_DATE_FROM");
            entity.Property(e => e.CpDateTo)
                .HasColumnType("datetime")
                .HasColumnName("CP_DATE_TO");
        });

        modelBuilder.Entity<DelegateStatus>(entity =>
        {
            entity.HasKey(e => e.DelegateStatusid).HasName("PK_dbo.DELEGATE_STATUS");

            entity.ToTable("DELEGATE_STATUS");

            entity.Property(e => e.DelegateStatusid).HasColumnName("DELEGATE_STATUSID");
            entity.Property(e => e.StatusDescription).HasColumnName("STATUS_DESCRIPTION");
            entity.Property(e => e.Visible).HasColumnName("VISIBLE");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DEPARTMENTS_1");

            entity.ToTable("DEPARTMENTS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DepCode)
                .HasMaxLength(50)
                .HasColumnName("DEP_CODE");
            entity.Property(e => e.DepCreated)
                .HasColumnType("datetime")
                .HasColumnName("DEP_CREATED");
            entity.Property(e => e.DepDesc)
                .HasMaxLength(250)
                .HasColumnName("DEP_DESC");
            entity.Property(e => e.DepId).HasColumnName("DEP_ID");
        });

        modelBuilder.Entity<DigitalHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DIGITAL_HISTORY");

            entity.Property(e => e.DhBorNo).HasColumnName("DH_BOR_NO");
            entity.Property(e => e.DhDate).HasColumnName("DH_DATE");
            entity.Property(e => e.DhDwType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DH_DW_TYPE");
            entity.Property(e => e.DhId)
                .ValueGeneratedOnAdd()
                .HasColumnName("DH_ID");
            entity.Property(e => e.DhStkUniqueNo).HasColumnName("DH_STK_UNIQUE_NO");
        });

        modelBuilder.Entity<DigitalWallet>(entity =>
        {
            entity.HasKey(e => e.DwId);

            entity.ToTable("DIGITAL_WALLET");

            entity.Property(e => e.DwId).HasColumnName("DW_ID");
            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");
            entity.Property(e => e.DateCreated).HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateUpdated).HasColumnName("DATE_UPDATED");
            entity.Property(e => e.DwOper)
                .HasMaxLength(25)
                .HasColumnName("DW_OPER");
            entity.Property(e => e.DwStatus)
                .HasMaxLength(20)
                .HasColumnName("DW_STATUS");
            entity.Property(e => e.DwType)
                .HasMaxLength(25)
                .HasColumnName("DW_TYPE");
            entity.Property(e => e.ExpiryDate).HasColumnName("EXPIRY_DATE");
            entity.Property(e => e.FileName)
                .HasMaxLength(25)
                .HasColumnName("FILE_NAME");
            entity.Property(e => e.LibGroup)
                .HasMaxLength(30)
                .HasColumnName("LIB_GROUP");
            entity.Property(e => e.RenewCount).HasColumnName("RENEW_COUNT");
            entity.Property(e => e.StkUniqueItemNo).HasColumnName("STK_UNIQUE_ITEM_NO");
        });

        modelBuilder.Entity<Discussion>(entity =>
        {
            entity.HasKey(e => e.DisId);

            entity.ToTable("DISCUSSION");

            entity.Property(e => e.DisId).HasColumnName("DIS_ID");
            entity.Property(e => e.DisApprovalDatetime)
                .HasColumnType("datetime")
                .HasColumnName("DIS_APPROVAL_DATETIME");
            entity.Property(e => e.DisApprovalOper)
                .HasMaxLength(50)
                .HasColumnName("DIS_APPROVAL_OPER");
            entity.Property(e => e.DisApprovalStatus).HasColumnName("DIS_APPROVAL_STATUS");
            entity.Property(e => e.DisBorNo).HasColumnName("DIS_BOR_NO");
            entity.Property(e => e.DisCatNo).HasColumnName("DIS_CAT_NO");
            entity.Property(e => e.DisEmail)
                .HasMaxLength(50)
                .HasColumnName("DIS_EMAIL");
            entity.Property(e => e.DisName)
                .HasMaxLength(50)
                .HasColumnName("DIS_NAME");
            entity.Property(e => e.DisResDatetime)
                .HasColumnType("datetime")
                .HasColumnName("DIS_RES_DATETIME");
            entity.Property(e => e.DisResponse).HasColumnName("DIS_RESPONSE");
        });

        modelBuilder.Entity<Dynamiclabel>(entity =>
        {
            entity.HasKey(e => e.LabelCode).HasName("PK__DYNAMICL__598B232408362A7C");

            entity.ToTable("DYNAMICLABELS");

            entity.Property(e => e.LabelCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LABEL_CODE");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.LabelDesc)
                .HasMaxLength(50)
                .HasColumnName("LABEL_DESC");
        });

        modelBuilder.Entity<DynamiclabelsTran>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DYNAMICLABELS_TRANS");

            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.LabelCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LABEL_CODE");
            entity.Property(e => e.Lcid).HasColumnName("LCID");
        });

        modelBuilder.Entity<EventAdditionalService>(entity =>
        {
            entity.HasKey(e => e.EventAdditionalServicesId).HasName("PK_dbo.EVENT_ADDITIONAL_SERVICES");

            entity.ToTable("EVENT_ADDITIONAL_SERVICES");

            entity.Property(e => e.EventAdditionalServicesId).HasColumnName("EVENT_ADDITIONAL_SERVICES_ID");
            entity.Property(e => e.Catering).HasColumnName("CATERING");
            entity.Property(e => e.CateringCode).HasColumnName("CATERING_CODE");
            entity.Property(e => e.ChangingRoom).HasColumnName("CHANGING_ROOM");
            entity.Property(e => e.ChangingRoomCode).HasColumnName("CHANGING_ROOM_CODE");
            entity.Property(e => e.ElectricityCode).HasColumnName("ELECTRICITY_CODE");
            entity.Property(e => e.FloodLights).HasColumnName("FLOOD_LIGHTS");
            entity.Property(e => e.FloodLightsCode).HasColumnName("FLOOD_LIGHTS_CODE");
            entity.Property(e => e.StkBkEventId).HasColumnName("STK_BK_EVENT_ID");
            entity.Property(e => e.StkItemNo).HasColumnName("STK_ITEM_NO");
            entity.Property(e => e.Water).HasColumnName("WATER");
            entity.Property(e => e.WaterCode).HasColumnName("WATER_CODE");
        });

        modelBuilder.Entity<FileSetDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FILE_SET_DATA");

            entity.HasIndex(e => new { e.FileItem, e.FileNumber }, "FSDS_ITEMNOX");

            entity.HasIndex(e => new { e.FileNumber, e.FileItem }, "FSDS_NOXITEMX");

            entity.Property(e => e.FileItem)
                .HasMaxLength(75)
                .HasColumnName("FILE_ITEM");
            entity.Property(e => e.FileNitem).HasColumnName("FILE_NITEM");
            entity.Property(e => e.FileNumber).HasColumnName("FILE_NUMBER");
            entity.Property(e => e.FileSequence).HasColumnName("FILE_SEQUENCE");
        });

        modelBuilder.Entity<FileSetName>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FILE_SET_NAMES");

            entity.Property(e => e.FileDate)
                .HasColumnType("datetime")
                .HasColumnName("FILE_DATE");
            entity.Property(e => e.FileDesc)
                .HasMaxLength(100)
                .HasColumnName("FILE_DESC");
            entity.Property(e => e.FileKey)
                .HasMaxLength(100)
                .HasColumnName("FILE_KEY");
            entity.Property(e => e.FileMaxSequence).HasColumnName("FILE_MAX_SEQUENCE");
            entity.Property(e => e.FileNumber).HasColumnName("FILE_NUMBER");
            entity.Property(e => e.FileOper)
                .HasMaxLength(25)
                .HasColumnName("FILE_OPER");
            entity.Property(e => e.FileOperAccess)
                .HasMaxLength(20)
                .HasColumnName("FILE_OPER_ACCESS");
            entity.Property(e => e.FileQty).HasColumnName("FILE_QTY");
            entity.Property(e => e.FileType)
                .HasMaxLength(1)
                .HasColumnName("FILE_TYPE");
        });

        modelBuilder.Entity<FileSetSystab>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FILE_SET_SYSTAB");

            entity.Property(e => e.FileNumber).HasColumnName("FILE_NUMBER");
        });

        modelBuilder.Entity<FileWhere>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FILE_WHERE");

            entity.Property(e => e.FwDesc)
                .HasMaxLength(100)
                .HasColumnName("FW_DESC");
            entity.Property(e => e.FwOper)
                .HasMaxLength(25)
                .HasColumnName("FW_OPER");
            entity.Property(e => e.FwOrder)
                .HasMaxLength(250)
                .HasColumnName("FW_ORDER");
            entity.Property(e => e.FwType)
                .HasMaxLength(1)
                .HasColumnName("FW_TYPE");
            entity.Property(e => e.FwUniqueNo).HasColumnName("FW_UNIQUE_NO");
            entity.Property(e => e.FwWhere)
                .HasColumnType("ntext")
                .HasColumnName("FW_WHERE");
            entity.Property(e => e.FwWhereEquation).HasColumnName("FW_WHERE_EQUATION");
            entity.Property(e => e.IsGlobal)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("IS_GLOBAL");
        });

        modelBuilder.Entity<FinAlloc>(entity =>
        {
            entity.HasKey(e => new { e.FaLibGroup, e.FaCode });

            entity.ToTable("FIN_ALLOC");

            entity.Property(e => e.FaLibGroup)
                .HasMaxLength(30)
                .HasColumnName("FA_LIB_GROUP");
            entity.Property(e => e.FaCode)
                .HasMaxLength(20)
                .HasColumnName("FA_CODE");
            entity.Property(e => e.FaDesc)
                .HasMaxLength(50)
                .HasColumnName("FA_DESC");
            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");
        });

        modelBuilder.Entity<FinAllocOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FIN_ALLOC_OLD");

            entity.Property(e => e.FaCode)
                .HasMaxLength(20)
                .HasColumnName("FA_CODE");
            entity.Property(e => e.FaDesc)
                .HasMaxLength(50)
                .HasColumnName("FA_DESC");
            entity.Property(e => e.FaLibGroup)
                .HasMaxLength(30)
                .HasColumnName("FA_LIB_GROUP");
        });

        modelBuilder.Entity<FinAllocTranslation>(entity =>
        {
            entity.HasKey(e => new { e.Lcid, e.FaLibGroup, e.FaCode });

            entity.ToTable("FIN_ALLOC_TRANSLATION");

            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.FaLibGroup)
                .HasMaxLength(30)
                .HasColumnName("FA_LIB_GROUP");
            entity.Property(e => e.FaCode)
                .HasMaxLength(20)
                .HasColumnName("FA_CODE");
            entity.Property(e => e.FaDesc)
                .HasMaxLength(50)
                .HasColumnName("FA_DESC");

            entity.HasOne(d => d.FinAlloc).WithMany(p => p.FinAllocTranslations)
                .HasForeignKey(d => new { d.FaLibGroup, d.FaCode })
                .HasConstraintName("FK_FIN_ALLOC_FIN_ALLOC_TRANSLATION");
        });

        modelBuilder.Entity<FinConfiguration>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FIN_CONFIGURATION");

            entity.Property(e => e.FinKey)
                .HasMaxLength(30)
                .HasColumnName("FIN_KEY");
            entity.Property(e => e.FinLibGroup)
                .HasMaxLength(30)
                .HasColumnName("FIN_LIB_GROUP");
            entity.Property(e => e.FinValue)
                .HasMaxLength(30)
                .HasColumnName("FIN_VALUE");
        });

        modelBuilder.Entity<FinCurrency>(entity =>
        {
            entity.HasKey(e => e.FcCode);

            entity.ToTable("FIN_CURRENCY");

            entity.Property(e => e.FcCode)
                .HasMaxLength(4)
                .HasColumnName("FC_CODE");
            entity.Property(e => e.FcDate)
                .HasColumnType("datetime")
                .HasColumnName("FC_DATE");
            entity.Property(e => e.FcDesc)
                .HasMaxLength(50)
                .HasColumnName("FC_DESC");
            entity.Property(e => e.FcRate)
                .HasColumnType("decimal(10, 4)")
                .HasColumnName("FC_RATE");
            entity.Property(e => e.FcSymbol)
                .HasMaxLength(10)
                .HasColumnName("FC_SYMBOL");
            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");
        });

        modelBuilder.Entity<FinCurrencyOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FIN_CURRENCY_OLD");

            entity.Property(e => e.FcCode)
                .HasMaxLength(4)
                .HasColumnName("FC_CODE");
            entity.Property(e => e.FcDate)
                .HasColumnType("datetime")
                .HasColumnName("FC_DATE");
            entity.Property(e => e.FcDesc)
                .HasMaxLength(50)
                .HasColumnName("FC_DESC");
            entity.Property(e => e.FcRate)
                .HasColumnType("decimal(10, 4)")
                .HasColumnName("FC_RATE");
            entity.Property(e => e.FcSymbol)
                .HasMaxLength(10)
                .HasColumnName("FC_SYMBOL");
        });

        modelBuilder.Entity<FinCurrencyTranslation>(entity =>
        {
            entity.HasKey(e => new { e.Lcid, e.FcCode });

            entity.ToTable("FIN_CURRENCY_TRANSLATION");

            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.FcCode)
                .HasMaxLength(4)
                .HasColumnName("FC_CODE");
            entity.Property(e => e.FcDesc)
                .HasMaxLength(50)
                .HasColumnName("FC_DESC");

            entity.HasOne(d => d.FcCodeNavigation).WithMany(p => p.FinCurrencyTranslations)
                .HasForeignKey(d => d.FcCode)
                .HasConstraintName("FK_FIN_CURRENCY_FIN_CURRENCY_TRANSLATION");
        });

        modelBuilder.Entity<FinOwingWork>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FIN_OWING_WORK");

            entity.Property(e => e.WBorBarNo)
                .HasMaxLength(75)
                .HasColumnName("W_BOR_BAR_NO");
            entity.Property(e => e.WLoanCount).HasColumnName("W_LOAN_COUNT");
            entity.Property(e => e.WOper)
                .HasMaxLength(20)
                .HasColumnName("W_OPER");
            entity.Property(e => e.WOwing)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("W_OWING");
        });

        modelBuilder.Entity<FinStdJnl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FIN_STD_JNL");

            entity.Property(e => e.FinAmount)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("FIN_AMOUNT");
            entity.Property(e => e.FinDesc)
                .HasMaxLength(50)
                .HasColumnName("FIN_DESC");
            entity.Property(e => e.FinReport)
                .HasMaxLength(250)
                .HasColumnName("FIN_REPORT");
        });

        modelBuilder.Entity<FinSystab>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FIN_SYSTAB");

            entity.Property(e => e.FinAcctNumber).HasColumnName("FIN_ACCT_NUMBER");
            entity.Property(e => e.FinNumber).HasColumnName("FIN_NUMBER");
            entity.Property(e => e.FinPeriods).HasColumnName("FIN_PERIODS");
            entity.Property(e => e.FinReceiptNo).HasColumnName("FIN_RECEIPT_NO");
            entity.Property(e => e.FinReconcileNo).HasColumnName("FIN_RECONCILE_NO");
            entity.Property(e => e.FinRemitNo).HasColumnName("FIN_REMIT_NO");
        });

        modelBuilder.Entity<FinTaxAccount>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FIN_TAX_ACCOUNT");

            entity.Property(e => e.FtaAccno)
                .HasMaxLength(30)
                .HasColumnName("FTA_ACCNO");
            entity.Property(e => e.FtaCode)
                .HasMaxLength(4)
                .HasColumnName("FTA_CODE");
            entity.Property(e => e.FtaLibGroup)
                .HasMaxLength(30)
                .HasColumnName("FTA_LIB_GROUP");
        });

        modelBuilder.Entity<FinTaxCode>(entity =>
        {
            entity.HasKey(e => e.FtcCode);

            entity.ToTable("FIN_TAX_CODES");

            entity.Property(e => e.FtcCode)
                .HasMaxLength(4)
                .HasColumnName("FTC_CODE");
            entity.Property(e => e.FtcDesc)
                .HasMaxLength(50)
                .HasColumnName("FTC_DESC");
            entity.Property(e => e.FtcRate)
                .HasColumnType("decimal(10, 4)")
                .HasColumnName("FTC_RATE");
        });

        modelBuilder.Entity<FinTaxCodesOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FIN_TAX_CODES_OLD");

            entity.Property(e => e.FtcCode)
                .HasMaxLength(4)
                .HasColumnName("FTC_CODE");
            entity.Property(e => e.FtcDesc)
                .HasMaxLength(50)
                .HasColumnName("FTC_DESC");
            entity.Property(e => e.FtcRate)
                .HasColumnType("decimal(10, 4)")
                .HasColumnName("FTC_RATE");
        });

        modelBuilder.Entity<FinTaxCodesTranslation>(entity =>
        {
            entity.HasKey(e => new { e.Lcid, e.FtcCode });

            entity.ToTable("FIN_TAX_CODES_TRANSLATION");

            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.FtcCode)
                .HasMaxLength(4)
                .HasColumnName("FTC_CODE");
            entity.Property(e => e.FtcDesc)
                .HasMaxLength(50)
                .HasColumnName("FTC_DESC");

            entity.HasOne(d => d.FtcCodeNavigation).WithMany(p => p.FinTaxCodesTranslations)
                .HasForeignKey(d => d.FtcCode)
                .HasConstraintName("FK_FIN_TAX_CODES_FIN_TAX_CODES_TRANSLATION");
        });

        modelBuilder.Entity<FinTran>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FIN_TRANS");

            entity.HasIndex(e => e.FinBor, "FIN_BORX");

            entity.HasIndex(e => e.FinItem, "FIN_ITEMX");

            entity.HasIndex(e => e.FinTranNo, "FIN_TRANNOX");

            entity.HasIndex(e => e.FinOs, "FIN_TRANSX");

            entity.HasIndex(e => e.FinType, "FIN_TYPEX");

            entity.Property(e => e.FinAccYear).HasColumnName("FIN_ACC_YEAR");
            entity.Property(e => e.FinAccount)
                .HasMaxLength(10)
                .HasColumnName("FIN_ACCOUNT");
            entity.Property(e => e.FinAllocCode)
                .HasMaxLength(20)
                .HasColumnName("FIN_ALLOC_CODE");
            entity.Property(e => e.FinBor)
                .HasMaxLength(75)
                .HasColumnName("FIN_BOR");
            entity.Property(e => e.FinComments)
                .HasMaxLength(100)
                .HasColumnName("FIN_COMMENTS");
            entity.Property(e => e.FinCr)
                .HasMaxLength(2)
                .HasColumnName("FIN_CR");
            entity.Property(e => e.FinCurrRate)
                .HasColumnType("decimal(10, 4)")
                .HasColumnName("FIN_CURR_RATE");
            entity.Property(e => e.FinCurrency)
                .HasMaxLength(4)
                .HasColumnName("FIN_CURRENCY");
            entity.Property(e => e.FinDate)
                .HasColumnType("datetime")
                .HasColumnName("FIN_DATE");
            entity.Property(e => e.FinDateMod)
                .HasColumnType("datetime")
                .HasColumnName("FIN_DATE_MOD");
            entity.Property(e => e.FinInvDate)
                .HasColumnType("datetime")
                .HasColumnName("FIN_INV_DATE");
            entity.Property(e => e.FinInvNo)
                .HasMaxLength(12)
                .HasColumnName("FIN_INV_NO");
            entity.Property(e => e.FinItem)
                .HasMaxLength(25)
                .HasColumnName("FIN_ITEM");
            entity.Property(e => e.FinLoc)
                .HasMaxLength(20)
                .HasColumnName("FIN_LOC");
            entity.Property(e => e.FinMarkfordelete)
                .HasMaxLength(1)
                .HasColumnName("FIN_MARKFORDELETE");
            entity.Property(e => e.FinMfdRef).HasColumnName("FIN_MFD_REF");
            entity.Property(e => e.FinName)
                .HasMaxLength(100)
                .HasColumnName("FIN_NAME");
            entity.Property(e => e.FinOper)
                .HasMaxLength(20)
                .HasColumnName("FIN_OPER");
            entity.Property(e => e.FinOs)
                .HasComputedColumnSql("([FIN_VALUE]-[FIN_PAID])", true)
                .HasColumnType("decimal(11, 2)")
                .HasColumnName("FIN_OS");
            entity.Property(e => e.FinPaid)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("FIN_PAID");
            entity.Property(e => e.FinPaymentType).HasColumnName("FIN_PAYMENT_TYPE");
            entity.Property(e => e.FinQty)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("FIN_QTY");
            entity.Property(e => e.FinReceipt)
                .HasMaxLength(20)
                .HasColumnName("FIN_RECEIPT");
            entity.Property(e => e.FinReport)
                .HasMaxLength(25)
                .HasColumnName("FIN_REPORT");
            entity.Property(e => e.FinSuppNo)
                .HasMaxLength(25)
                .HasColumnName("FIN_SUPP_NO");
            entity.Property(e => e.FinTitle)
                .HasMaxLength(250)
                .HasColumnName("FIN_TITLE");
            entity.Property(e => e.FinTranNo).HasColumnName("FIN_TRAN_NO");
            entity.Property(e => e.FinType)
                .HasMaxLength(15)
                .HasColumnName("FIN_TYPE");
            entity.Property(e => e.FinValue)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("FIN_VALUE");
        });

        modelBuilder.Entity<FinYear>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FIN_YEAR");

            entity.Property(e => e.FyCurUsed)
                .HasMaxLength(1)
                .HasColumnName("FY_CUR_USED");
            entity.Property(e => e.FyEnd)
                .HasColumnType("datetime")
                .HasColumnName("FY_END");
            entity.Property(e => e.FyLibGroup)
                .HasMaxLength(30)
                .HasColumnName("FY_LIB_GROUP");
            entity.Property(e => e.FyStart)
                .HasColumnType("datetime")
                .HasColumnName("FY_START");
            entity.Property(e => e.FyYear).HasColumnName("FY_YEAR");
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.HasKey(e => e.GroupId).HasName("PK_dbo.GROUPs");

            entity.ToTable("GROUPS");

            entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
            entity.Property(e => e.GroupName)
                .HasMaxLength(450)
                .HasColumnName("GROUP_NAME");
        });

        modelBuilder.Entity<GroupMember>(entity =>
        {
            entity.HasKey(e => new { e.GroupId, e.BorNo }).HasName("PK_dbo.GROUPMEMBERS");

            entity.ToTable("GROUP_MEMBERS");

            entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");

            entity.HasOne(d => d.Group).WithMany(p => p.GroupMembers)
                .HasForeignKey(d => d.GroupId)
                .HasConstraintName("FK_dbo.GROUPMEMBERS_dbo.GROUPS_GROUP_ID");
        });

        modelBuilder.Entity<IllLibrary>(entity =>
        {
            entity.HasKey(e => e.IllCode);

            entity.ToTable("ILL_LIBRARY");

            entity.Property(e => e.IllCode)
                .HasMaxLength(25)
                .HasColumnName("ILL_CODE");
            entity.Property(e => e.IllAddr1)
                .HasMaxLength(100)
                .HasColumnName("ILL_ADDR1");
            entity.Property(e => e.IllAddr2)
                .HasMaxLength(100)
                .HasColumnName("ILL_ADDR2");
            entity.Property(e => e.IllAddr3)
                .HasMaxLength(100)
                .HasColumnName("ILL_ADDR3");
            entity.Property(e => e.IllCommType)
                .HasMaxLength(10)
                .HasColumnName("ILL_COMM_TYPE");
            entity.Property(e => e.IllCost)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("ILL_COST");
            entity.Property(e => e.IllEmail)
                .HasMaxLength(75)
                .HasColumnName("ILL_EMAIL");
            entity.Property(e => e.IllFax)
                .HasMaxLength(20)
                .HasColumnName("ILL_FAX");
            entity.Property(e => e.IllName)
                .HasMaxLength(100)
                .HasColumnName("ILL_NAME");
            entity.Property(e => e.IllNcipAgency)
                .HasMaxLength(100)
                .HasColumnName("ILL_NCIP_AGENCY");
            entity.Property(e => e.IllNcipHost)
                .HasMaxLength(250)
                .HasColumnName("ILL_NCIP_HOST");
            entity.Property(e => e.IllNcipLocation)
                .HasMaxLength(20)
                .HasColumnName("ILL_NCIP_LOCATION");
            entity.Property(e => e.IllNcipPort).HasColumnName("ILL_NCIP_PORT");
            entity.Property(e => e.IllPassword)
                .HasMaxLength(50)
                .HasColumnName("ILL_PASSWORD");
            entity.Property(e => e.IllPcode)
                .HasMaxLength(6)
                .HasColumnName("ILL_PCODE");
            entity.Property(e => e.IllPerson)
                .HasMaxLength(20)
                .HasColumnName("ILL_PERSON");
            entity.Property(e => e.IllPhone)
                .HasMaxLength(12)
                .HasColumnName("ILL_PHONE");
            entity.Property(e => e.IllUsername)
                .HasMaxLength(50)
                .HasColumnName("ILL_USERNAME");
            entity.Property(e => e.IllZserverUniqueNo).HasColumnName("ILL_ZSERVER_UNIQUE_NO");
        });

        modelBuilder.Entity<IllLibraryOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ILL_LIBRARY_OLD");

            entity.Property(e => e.IllAddr1)
                .HasMaxLength(100)
                .HasColumnName("ILL_ADDR1");
            entity.Property(e => e.IllAddr2)
                .HasMaxLength(100)
                .HasColumnName("ILL_ADDR2");
            entity.Property(e => e.IllAddr3)
                .HasMaxLength(100)
                .HasColumnName("ILL_ADDR3");
            entity.Property(e => e.IllCode)
                .HasMaxLength(25)
                .HasColumnName("ILL_CODE");
            entity.Property(e => e.IllCommType)
                .HasMaxLength(10)
                .HasColumnName("ILL_COMM_TYPE");
            entity.Property(e => e.IllCost)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("ILL_COST");
            entity.Property(e => e.IllEmail)
                .HasMaxLength(75)
                .HasColumnName("ILL_EMAIL");
            entity.Property(e => e.IllFax)
                .HasMaxLength(20)
                .HasColumnName("ILL_FAX");
            entity.Property(e => e.IllName)
                .HasMaxLength(100)
                .HasColumnName("ILL_NAME");
            entity.Property(e => e.IllNcipAgency)
                .HasMaxLength(100)
                .HasColumnName("ILL_NCIP_AGENCY");
            entity.Property(e => e.IllNcipHost)
                .HasMaxLength(250)
                .HasColumnName("ILL_NCIP_HOST");
            entity.Property(e => e.IllNcipLocation)
                .HasMaxLength(20)
                .HasColumnName("ILL_NCIP_LOCATION");
            entity.Property(e => e.IllNcipPort).HasColumnName("ILL_NCIP_PORT");
            entity.Property(e => e.IllPassword)
                .HasMaxLength(50)
                .HasColumnName("ILL_PASSWORD");
            entity.Property(e => e.IllPcode)
                .HasMaxLength(6)
                .HasColumnName("ILL_PCODE");
            entity.Property(e => e.IllPerson)
                .HasMaxLength(20)
                .HasColumnName("ILL_PERSON");
            entity.Property(e => e.IllPhone)
                .HasMaxLength(12)
                .HasColumnName("ILL_PHONE");
            entity.Property(e => e.IllUsername)
                .HasMaxLength(50)
                .HasColumnName("ILL_USERNAME");
            entity.Property(e => e.IllZserverUniqueNo).HasColumnName("ILL_ZSERVER_UNIQUE_NO");
        });

        modelBuilder.Entity<IllLibraryTranslation>(entity =>
        {
            entity.HasKey(e => new { e.Lcid, e.IllCode });

            entity.ToTable("ILL_LIBRARY_TRANSLATION");

            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.IllCode)
                .HasMaxLength(25)
                .HasColumnName("ILL_CODE");
            entity.Property(e => e.IllName)
                .HasMaxLength(100)
                .HasColumnName("ILL_NAME");

            entity.HasOne(d => d.IllCodeNavigation).WithMany(p => p.IllLibraryTranslations)
                .HasForeignKey(d => d.IllCode)
                .HasConstraintName("FK_ILL_LIBRARY_ILL_LIBRARY_TRANSLATION");
        });

        modelBuilder.Entity<IllService>(entity =>
        {
            entity.HasKey(e => new { e.IllsCode, e.IllsIllCode });

            entity.ToTable("ILL_SERVICES");

            entity.Property(e => e.IllsCode)
                .HasMaxLength(20)
                .HasColumnName("ILLS_CODE");
            entity.Property(e => e.IllsIllCode)
                .HasMaxLength(25)
                .HasColumnName("ILLS_ILL_CODE");
            entity.Property(e => e.IllsCost)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("ILLS_COST");
            entity.Property(e => e.IllsKeywordDescription)
                .HasMaxLength(100)
                .HasColumnName("ILLS_KEYWORD_DESCRIPTION");
        });

        modelBuilder.Entity<IllServicesTranslation>(entity =>
        {
            entity.HasKey(e => new { e.Lcid, e.IllsCode, e.IllsIllCode });

            entity.ToTable("ILL_SERVICES_TRANSLATION");

            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.IllsCode)
                .HasMaxLength(20)
                .HasColumnName("ILLS_CODE");
            entity.Property(e => e.IllsIllCode)
                .HasMaxLength(25)
                .HasColumnName("ILLS_ILL_CODE");
            entity.Property(e => e.IllsKeywordDescription)
                .HasMaxLength(100)
                .HasColumnName("ILLS_KEYWORD_DESCRIPTION");

            entity.HasOne(d => d.IllService).WithMany(p => p.IllServicesTranslations)
                .HasForeignKey(d => new { d.IllsCode, d.IllsIllCode })
                .HasConstraintName("FK_ILL_SERVICES_ILL_SERVICES_TRANSLATION");
        });

        modelBuilder.Entity<IlrAdditionalField>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ILR_ADDITIONAL_FIELD");

            entity.Property(e => e.Advlapplied).HasColumnName("ADVLAPPLIED");
            entity.Property(e => e.Advlladvice).HasColumnName("ADVLLADVICE");
            entity.Property(e => e.Asylumseeker).HasColumnName("ASYLUMSEEKER");
            entity.Property(e => e.Borninuk).HasColumnName("BORNINUK");
            entity.Property(e => e.Borno).HasColumnName("BORNO");
            entity.Property(e => e.Countryofdomicile)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COUNTRYOFDOMICILE");
            entity.Property(e => e.Depbenefit).HasColumnName("DEPBENEFIT");
            entity.Property(e => e.Employauth).HasColumnName("EMPLOYAUTH");
            entity.Property(e => e.Evidenceseen)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EVIDENCESEEN");
            entity.Property(e => e.Expiredateofvisa).HasColumnName("EXPIREDATEOFVISA");
            entity.Property(e => e.Firstlanguage)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FIRSTLANGUAGE");
            entity.Property(e => e.Fulltimeedu).HasColumnName("FULLTIMEEDU");
            entity.Property(e => e.Hllivedinprecountry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HLLIVEDINPRECOUNTRY");
            entity.Property(e => e.Hllivedinuk)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HLLIVEDINUK");
            entity.Property(e => e.Howtopay)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HOWTOPAY");
            entity.Property(e => e.Initials)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("INITIALS");
            entity.Property(e => e.Lowincome).HasColumnName("LOWINCOME");
            entity.Property(e => e.Ninumdate).HasColumnName("NINUMDATE");
            entity.Property(e => e.Ninumseenby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NINUMSEENBY");
            entity.Property(e => e.Preeducation)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PREEDUCATION");
            entity.Property(e => e.Preempaddress)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PREEMPADDRESS");
            entity.Property(e => e.Preemployername)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("PREEMPLOYERNAME");
            entity.Property(e => e.Preemppostcode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PREEMPPOSTCODE");
            entity.Property(e => e.Prelivedcountry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PRELIVEDCOUNTRY");
            entity.Property(e => e.Statsbenefitnotes)
                .HasMaxLength(350)
                .IsUnicode(false)
                .HasColumnName("STATSBENEFITNOTES");
            entity.Property(e => e.Typeofvisa)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TYPEOFVISA");
            entity.Property(e => e.Ukpassport).HasColumnName("UKPASSPORT");
            entity.Property(e => e.Unspentcriminal).HasColumnName("UNSPENTCRIMINAL");
            entity.Property(e => e.Visaorppno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VISAORPPNO");
            entity.Property(e => e.Visarequired).HasColumnName("VISAREQUIRED");
            entity.Property(e => e.Whowillpay)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WHOWILLPAY");
        });

        modelBuilder.Entity<IlrField>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ILR_FIELD");

            entity.Property(e => e.EmpStatusMonitor)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.EngGrade)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.LlddhealthProb).HasColumnName("LLDDHealthProb");
            entity.Property(e => e.MathGrade)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.Ninumber)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("NINumber");
        });

        modelBuilder.Entity<ImageTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IMAGE_TABLE");

            entity.HasIndex(e => e.BorNo, "IMA_BOR_NOX");

            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");
            entity.Property(e => e.CatNo).HasColumnName("CAT_NO");
            entity.Property(e => e.PictureNo).HasColumnName("PICTURE_NO");
            entity.Property(e => e.PictureString)
                .HasColumnType("ntext")
                .HasColumnName("PICTURE_STRING");
            entity.Property(e => e.PictureTitle)
                .HasMaxLength(25)
                .HasColumnName("PICTURE_TITLE");
            entity.Property(e => e.UniqueItemNo).HasColumnName("UNIQUE_ITEM_NO");
        });

        modelBuilder.Entity<IssueAudit>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ISSUE_AUDIT");

            entity.HasIndex(e => e.IssueDate, "AUD_ISSDATEX");

            entity.HasIndex(e => e.IssueItem, "AUD_ISSSTKBARX");

            entity.HasIndex(e => e.IssueBorrower, "ISSUE_BORX");

            entity.Property(e => e.IssueBorrower)
                .HasMaxLength(25)
                .HasColumnName("ISSUE_BORROWER");
            entity.Property(e => e.IssueDate)
                .HasColumnType("datetime")
                .HasColumnName("ISSUE_DATE");
            entity.Property(e => e.IssueItem)
                .HasMaxLength(25)
                .HasColumnName("ISSUE_ITEM");
            entity.Property(e => e.IssueLocation)
                .HasMaxLength(20)
                .HasColumnName("ISSUE_LOCATION");
            entity.Property(e => e.IssueMessages)
                .HasColumnType("ntext")
                .HasColumnName("ISSUE_MESSAGES");
            entity.Property(e => e.IssueOper)
                .HasMaxLength(25)
                .HasColumnName("ISSUE_OPER");
        });

        modelBuilder.Entity<ItemSystab>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ITEM_SYSTAB");

            entity.Property(e => e.UniqueItemNo).HasColumnName("UNIQUE_ITEM_NO");
        });

        modelBuilder.Entity<LibLanguage>(entity =>
        {
            entity.HasKey(e => e.LanguageId);

            entity.ToTable("LIB_LANGUAGES");

            entity.Property(e => e.LanguageId)
                .ValueGeneratedNever()
                .HasColumnName("LANGUAGE_ID");
            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.Description)
                .HasMaxLength(300)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.Righttoleft).HasColumnName("RIGHTTOLEFT");
        });

        modelBuilder.Entity<LibLanguages1>(entity =>
        {
            entity.HasKey(e => e.LanguageId);

            entity.ToTable("LIB_LANGUAGES1");

            entity.Property(e => e.LanguageId)
                .ValueGeneratedNever()
                .HasColumnName("LANGUAGE_ID");
            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.Description)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Lcid).HasColumnName("LCID");
        });

        modelBuilder.Entity<LibLanguages2>(entity =>
        {
            entity.HasKey(e => e.LanguageId);

            entity.ToTable("LIB_LANGUAGES2");

            entity.Property(e => e.LanguageId)
                .ValueGeneratedNever()
                .HasColumnName("LANGUAGE_ID");
            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.Description)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Lcid).HasColumnName("LCID");
        });

        modelBuilder.Entity<LibLanguagesOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LIB_LANGUAGES_OLD");

            entity.Property(e => e.Description)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.LanguageId).HasColumnName("LANGUAGE_ID");
        });

        modelBuilder.Entity<LibLanguagesOld2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LIB_LANGUAGES_OLD2");

            entity.Property(e => e.Description)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.LanguageId).HasColumnName("LANGUAGE_ID");
        });

        modelBuilder.Entity<LibLanguagesTemp>(entity =>
        {
            entity.HasKey(e => e.LanguageId).HasName("PK_LIB_LANGUAGES_OLD2");

            entity.ToTable("LIB_LANGUAGES_Temp");

            entity.Property(e => e.LanguageId)
                .ValueGeneratedNever()
                .HasColumnName("LANGUAGE_ID");
            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.Description)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Lcid).HasColumnName("LCID");
        });

        modelBuilder.Entity<LibOption>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LIB_OPTIONS");

            entity.HasIndex(e => new { e.LlCode, e.LoCode }, "LO_CODEX");

            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.LlCode)
                .HasMaxLength(20)
                .HasColumnName("LL_CODE");
            entity.Property(e => e.LoCode)
                .HasMaxLength(32)
                .HasColumnName("LO_CODE");
            entity.Property(e => e.LoValue)
                .HasMaxLength(300)
                .HasColumnName("LO_VALUE");
        });

        modelBuilder.Entity<LibOptionLanguage>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LIB_OPTION_LANGUAGES");

            entity.Property(e => e.Description).HasColumnName("DESCRIPTION");
            entity.Property(e => e.LanguageId).HasColumnName("LANGUAGE_ID");
            entity.Property(e => e.LoCode)
                .HasMaxLength(50)
                .HasColumnName("LO_CODE");
            entity.Property(e => e.OptionType)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("OPTION_TYPE");
        });

        modelBuilder.Entity<LibOptions1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LIB_OPTIONS1");

            entity.Property(e => e.LlCode)
                .HasMaxLength(20)
                .HasColumnName("LL_CODE");
            entity.Property(e => e.LoCode)
                .HasMaxLength(32)
                .HasColumnName("LO_CODE");
            entity.Property(e => e.LoValue)
                .HasMaxLength(300)
                .HasColumnName("LO_VALUE");
        });

        modelBuilder.Entity<LibSection>(entity =>
        {
            entity.HasKey(e => e.SectionId);

            entity.ToTable("LIB_SECTIONS");

            entity.Property(e => e.SectionId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SECTION_ID");
            entity.Property(e => e.Description)
                .HasMaxLength(300)
                .HasColumnName("DESCRIPTION");
        });

        modelBuilder.Entity<LibSectionsOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LIB_SECTIONS_OLD");

            entity.Property(e => e.Description)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.SectionId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SECTION_ID");
        });

        modelBuilder.Entity<LibSectionsTranslation>(entity =>
        {
            entity.HasKey(e => new { e.Lcid, e.SectionId });

            entity.ToTable("LIB_SECTIONS_TRANSLATION");

            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.SectionId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SECTION_ID");
            entity.Property(e => e.Description)
                .HasMaxLength(300)
                .HasColumnName("DESCRIPTION");

            entity.HasOne(d => d.Section).WithMany(p => p.LibSectionsTranslations)
                .HasForeignKey(d => d.SectionId)
                .HasConstraintName("FK_LIB_SECTIONS_LIB_SECTIONS_TRANSLATION");
        });

        modelBuilder.Entity<LibTab>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LIB_TABS");

            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.TabId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TAB_ID");
        });

        modelBuilder.Entity<LoadedApp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LOADED_APPS");

            entity.Property(e => e.Appname)
                .HasMaxLength(3)
                .HasColumnName("APPNAME");
            entity.Property(e => e.Opname)
                .HasMaxLength(25)
                .HasColumnName("OPNAME");
        });

        modelBuilder.Entity<Meeting>(entity =>
        {
            entity.HasKey(e => e.MeetingId).HasName("PK_dbo.MEETINGS");

            entity.ToTable("MEETINGS");

            entity.Property(e => e.MeetingId).HasColumnName("MEETING_ID");
            entity.Property(e => e.LlCode)
                .HasMaxLength(40)
                .HasColumnName("LL_CODE");
            entity.Property(e => e.MeetingBarcode).HasColumnName("MEETING_BARCODE");
            entity.Property(e => e.MeetingDescription).HasColumnName("MEETING_DESCRIPTION");
            entity.Property(e => e.MeetingEndDate)
                .HasColumnType("datetime")
                .HasColumnName("MEETING_END_DATE");
            entity.Property(e => e.MeetingStartDate)
                .HasColumnType("datetime")
                .HasColumnName("MEETING_START_DATE");
            entity.Property(e => e.MeetingStatus)
                .HasMaxLength(1)
                .HasColumnName("MEETING_STATUS");
            entity.Property(e => e.MeetingTitle)
                .HasMaxLength(250)
                .HasColumnName("MEETING_TITLE");
            entity.Property(e => e.RoomId).HasColumnName("ROOM_ID");
        });

        modelBuilder.Entity<MeetingDelegate>(entity =>
        {
            entity.HasKey(e => new { e.MeetingId, e.BorNo }).HasName("PK_dbo.MEETINGDELEGATES");

            entity.ToTable("MEETING_DELEGATES");

            entity.Property(e => e.MeetingId).HasColumnName("MEETING_ID");
            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");
            entity.Property(e => e.CStatus).HasColumnName("C_STATUS");
            entity.Property(e => e.CarRegistration)
                .HasMaxLength(50)
                .HasColumnName("CAR_REGISTRATION");
            entity.Property(e => e.CheckInTime)
                .HasColumnType("datetime")
                .HasColumnName("CHECK_IN_TIME");
            entity.Property(e => e.CheckOutTime)
                .HasColumnType("datetime")
                .HasColumnName("CHECK_OUT_TIME");
            entity.Property(e => e.DelegateType)
                .HasMaxLength(50)
                .HasColumnName("DELEGATE_TYPE");
            entity.Property(e => e.UserMeetingBarcode)
                .HasMaxLength(50)
                .HasColumnName("USER_MEETING_BARCODE");

            entity.HasOne(d => d.Meeting).WithMany(p => p.MeetingDelegates)
                .HasForeignKey(d => d.MeetingId)
                .HasConstraintName("FK_dbo.MEETINGDELEGATES_dbo.MEETINGs_MEETING_ID");
        });

        modelBuilder.Entity<MeetingStatus>(entity =>
        {
            entity.HasKey(e => e.MeetingStatusId).HasName("PK_dbo.MEETING_STATUS");

            entity.ToTable("MEETING_STATUS");

            entity.Property(e => e.MeetingStatusId)
                .HasMaxLength(1)
                .HasColumnName("MEETING_STATUS_ID");
            entity.Property(e => e.MeetingStatusDescription)
                .HasMaxLength(40)
                .HasColumnName("MEETING_STATUS_DESCRIPTION");
        });

        modelBuilder.Entity<MigrationHistory>(entity =>
        {
            entity.HasKey(e => new { e.MigrationId, e.ContextKey }).HasName("PK_dbo.__MigrationHistory");

            entity.ToTable("__MigrationHistory");

            entity.Property(e => e.MigrationId).HasMaxLength(150);
            entity.Property(e => e.ContextKey).HasMaxLength(300);
            entity.Property(e => e.ProductVersion).HasMaxLength(32);
        });

        modelBuilder.Entity<NcipStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NCIP_STATUS");

            entity.HasIndex(e => e.StatusNo, "PK_NCIP_STATUS");

            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.StatusNo).HasColumnName("STATUS_NO");
        });

        modelBuilder.Entity<NcipTransArchive>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NCIP_TRANS_ARCHIVE");

            entity.Property(e => e.NcAction).HasColumnName("NC_ACTION");
            entity.Property(e => e.NcAmlibItemBc)
                .HasMaxLength(25)
                .HasColumnName("NC_AMLIB_ITEM_BC");
            entity.Property(e => e.NcBorrower)
                .HasMaxLength(300)
                .HasColumnName("NC_BORROWER");
            entity.Property(e => e.NcCollectLocation)
                .HasMaxLength(20)
                .HasColumnName("NC_COLLECT_LOCATION");
            entity.Property(e => e.NcComments)
                .HasMaxLength(200)
                .HasColumnName("NC_COMMENTS");
            entity.Property(e => e.NcDateDue)
                .HasColumnType("datetime")
                .HasColumnName("NC_DATE_DUE");
            entity.Property(e => e.NcDateDueLender)
                .HasColumnType("datetime")
                .HasColumnName("NC_DATE_DUE_LENDER");
            entity.Property(e => e.NcEnduserBc)
                .HasMaxLength(25)
                .HasColumnName("NC_ENDUSER_BC");
            entity.Property(e => e.NcFromAgency)
                .HasMaxLength(100)
                .HasColumnName("NC_FROM_AGENCY");
            entity.Property(e => e.NcItemDetails)
                .HasColumnType("ntext")
                .HasColumnName("NC_ITEM_DETAILS");
            entity.Property(e => e.NcLibraryborBc)
                .HasMaxLength(25)
                .HasColumnName("NC_LIBRARYBOR_BC");
            entity.Property(e => e.NcLockDate)
                .HasColumnType("datetime")
                .HasColumnName("NC_LOCK_DATE");
            entity.Property(e => e.NcLockOwner).HasColumnName("NC_LOCK_OWNER");
            entity.Property(e => e.NcOnbehalfAgency)
                .HasMaxLength(100)
                .HasColumnName("NC_ONBEHALF_AGENCY");
            entity.Property(e => e.NcOrigDatetime)
                .HasColumnType("datetime")
                .HasColumnName("NC_ORIG_DATETIME");
            entity.Property(e => e.NcRequestId)
                .HasMaxLength(200)
                .HasColumnName("NC_REQUEST_ID");
            entity.Property(e => e.NcRequestLocation)
                .HasMaxLength(20)
                .HasColumnName("NC_REQUEST_LOCATION");
            entity.Property(e => e.NcResCharge)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("NC_RES_CHARGE");
            entity.Property(e => e.NcResnoFrom).HasColumnName("NC_RESNO_FROM");
            entity.Property(e => e.NcResnoTo).HasColumnName("NC_RESNO_TO");
            entity.Property(e => e.NcStatusNo).HasColumnName("NC_STATUS_NO");
            entity.Property(e => e.NcToAgency)
                .HasMaxLength(100)
                .HasColumnName("NC_TO_AGENCY");
            entity.Property(e => e.NcToItemBc)
                .HasMaxLength(50)
                .HasColumnName("NC_TO_ITEM_BC");
            entity.Property(e => e.NcUpdateDatetime)
                .HasColumnType("datetime")
                .HasColumnName("NC_UPDATE_DATETIME");
            entity.Property(e => e.NcipNo).HasColumnName("NCIP_NO");
            entity.Property(e => e.NcipToNo).HasColumnName("NCIP_TO_NO");
            entity.Property(e => e.WebSerialNo).HasColumnName("WEB_SERIAL_NO");
        });

        modelBuilder.Entity<NcipTransDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NCIP_TRANS_DETAIL");

            entity.Property(e => e.NcAction).HasColumnName("NC_ACTION");
            entity.Property(e => e.NcAmlibItemBc)
                .HasMaxLength(25)
                .HasColumnName("NC_AMLIB_ITEM_BC");
            entity.Property(e => e.NcBorrower)
                .HasMaxLength(300)
                .HasColumnName("NC_BORROWER");
            entity.Property(e => e.NcCollectLocation)
                .HasMaxLength(20)
                .HasColumnName("NC_COLLECT_LOCATION");
            entity.Property(e => e.NcComments)
                .HasMaxLength(200)
                .HasColumnName("NC_COMMENTS");
            entity.Property(e => e.NcDateDue)
                .HasColumnType("datetime")
                .HasColumnName("NC_DATE_DUE");
            entity.Property(e => e.NcDateDueLender)
                .HasColumnType("datetime")
                .HasColumnName("NC_DATE_DUE_LENDER");
            entity.Property(e => e.NcEnduserBc)
                .HasMaxLength(25)
                .HasColumnName("NC_ENDUSER_BC");
            entity.Property(e => e.NcFromAgency)
                .HasMaxLength(100)
                .HasColumnName("NC_FROM_AGENCY");
            entity.Property(e => e.NcItemDetails)
                .HasColumnType("ntext")
                .HasColumnName("NC_ITEM_DETAILS");
            entity.Property(e => e.NcLibraryborBc)
                .HasMaxLength(25)
                .HasColumnName("NC_LIBRARYBOR_BC");
            entity.Property(e => e.NcLockDate)
                .HasColumnType("datetime")
                .HasColumnName("NC_LOCK_DATE");
            entity.Property(e => e.NcLockOwner).HasColumnName("NC_LOCK_OWNER");
            entity.Property(e => e.NcOnbehalfAgency)
                .HasMaxLength(100)
                .HasColumnName("NC_ONBEHALF_AGENCY");
            entity.Property(e => e.NcOrigDatetime)
                .HasColumnType("datetime")
                .HasColumnName("NC_ORIG_DATETIME");
            entity.Property(e => e.NcRequestId)
                .HasMaxLength(200)
                .HasColumnName("NC_REQUEST_ID");
            entity.Property(e => e.NcRequestLocation)
                .HasMaxLength(20)
                .HasColumnName("NC_REQUEST_LOCATION");
            entity.Property(e => e.NcResCharge)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("NC_RES_CHARGE");
            entity.Property(e => e.NcResnoFrom).HasColumnName("NC_RESNO_FROM");
            entity.Property(e => e.NcResnoTo).HasColumnName("NC_RESNO_TO");
            entity.Property(e => e.NcStatusNo).HasColumnName("NC_STATUS_NO");
            entity.Property(e => e.NcToAgency)
                .HasMaxLength(100)
                .HasColumnName("NC_TO_AGENCY");
            entity.Property(e => e.NcToItemBc)
                .HasMaxLength(50)
                .HasColumnName("NC_TO_ITEM_BC");
            entity.Property(e => e.NcUpdateDatetime)
                .HasColumnType("datetime")
                .HasColumnName("NC_UPDATE_DATETIME");
            entity.Property(e => e.NcipNo).HasColumnName("NCIP_NO");
            entity.Property(e => e.NcipToNo).HasColumnName("NCIP_TO_NO");
            entity.Property(e => e.WebSerialNo).HasColumnName("WEB_SERIAL_NO");
        });

        modelBuilder.Entity<NcipTransMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NCIP_TRANS_MASTER");

            entity.Property(e => e.NcAction).HasColumnName("NC_ACTION");
            entity.Property(e => e.NcAmlibItemBc)
                .HasMaxLength(25)
                .HasColumnName("NC_AMLIB_ITEM_BC");
            entity.Property(e => e.NcBorrower)
                .HasMaxLength(300)
                .HasColumnName("NC_BORROWER");
            entity.Property(e => e.NcCollectLocation)
                .HasMaxLength(20)
                .HasColumnName("NC_COLLECT_LOCATION");
            entity.Property(e => e.NcComments)
                .HasMaxLength(200)
                .HasColumnName("NC_COMMENTS");
            entity.Property(e => e.NcDateDue)
                .HasColumnType("datetime")
                .HasColumnName("NC_DATE_DUE");
            entity.Property(e => e.NcDateDueLender)
                .HasColumnType("datetime")
                .HasColumnName("NC_DATE_DUE_LENDER");
            entity.Property(e => e.NcEnduserBc)
                .HasMaxLength(25)
                .HasColumnName("NC_ENDUSER_BC");
            entity.Property(e => e.NcFromAgency)
                .HasMaxLength(100)
                .HasColumnName("NC_FROM_AGENCY");
            entity.Property(e => e.NcItemDetails)
                .HasColumnType("ntext")
                .HasColumnName("NC_ITEM_DETAILS");
            entity.Property(e => e.NcLibraryborBc)
                .HasMaxLength(25)
                .HasColumnName("NC_LIBRARYBOR_BC");
            entity.Property(e => e.NcLockDate)
                .HasColumnType("datetime")
                .HasColumnName("NC_LOCK_DATE");
            entity.Property(e => e.NcLockOwner).HasColumnName("NC_LOCK_OWNER");
            entity.Property(e => e.NcOnbehalfAgency)
                .HasMaxLength(100)
                .HasColumnName("NC_ONBEHALF_AGENCY");
            entity.Property(e => e.NcOrigDatetime)
                .HasColumnType("datetime")
                .HasColumnName("NC_ORIG_DATETIME");
            entity.Property(e => e.NcRequestId)
                .HasMaxLength(200)
                .HasColumnName("NC_REQUEST_ID");
            entity.Property(e => e.NcRequestLocation)
                .HasMaxLength(20)
                .HasColumnName("NC_REQUEST_LOCATION");
            entity.Property(e => e.NcResCharge)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("NC_RES_CHARGE");
            entity.Property(e => e.NcResnoFrom).HasColumnName("NC_RESNO_FROM");
            entity.Property(e => e.NcResnoTo).HasColumnName("NC_RESNO_TO");
            entity.Property(e => e.NcStatusNo).HasColumnName("NC_STATUS_NO");
            entity.Property(e => e.NcToAgency)
                .HasMaxLength(100)
                .HasColumnName("NC_TO_AGENCY");
            entity.Property(e => e.NcToItemBc)
                .HasMaxLength(50)
                .HasColumnName("NC_TO_ITEM_BC");
            entity.Property(e => e.NcUpdateDatetime)
                .HasColumnType("datetime")
                .HasColumnName("NC_UPDATE_DATETIME");
            entity.Property(e => e.NcipNo).HasColumnName("NCIP_NO");
            entity.Property(e => e.NcipToNo).HasColumnName("NCIP_TO_NO");
            entity.Property(e => e.WebSerialNo).HasColumnName("WEB_SERIAL_NO");
        });

        modelBuilder.Entity<OpacFileSetLibCat>(entity =>
        {
            entity.HasKey(e => new { e.SharedFileId, e.FileNumberLib, e.FileNumberCat });

            entity.ToTable("OPAC_FILE_SET_LIB_CAT");

            entity.Property(e => e.SharedFileId).HasColumnName("SHARED_FILE_ID");
            entity.Property(e => e.FileNumberLib).HasColumnName("FILE_NUMBER_LIB");
            entity.Property(e => e.FileNumberCat).HasColumnName("FILE_NUMBER_CAT");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.ExpirationDate)
                .HasColumnType("datetime")
                .HasColumnName("EXPIRATION_DATE");
            entity.Property(e => e.FileOwnerBorNo).HasColumnName("FILE_OWNER_BOR_NO");
            entity.Property(e => e.LastModifyOn)
                .HasColumnType("datetime")
                .HasColumnName("LAST_MODIFY_ON");
        });

        modelBuilder.Entity<Opacuseraction>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OPACUSERACTION");

            entity.Property(e => e.OucaAction)
                .HasColumnType("ntext")
                .HasColumnName("OUCA_ACTION");
            entity.Property(e => e.OucaDate)
                .HasColumnType("datetime")
                .HasColumnName("OUCA_DATE");
            entity.Property(e => e.OucaNo).HasColumnName("OUCA_NO");
            entity.Property(e => e.OucaOper)
                .HasMaxLength(25)
                .HasColumnName("OUCA_OPER");
        });

        modelBuilder.Entity<Opacusercomment>(entity =>
        {
            entity.ToTable("OPACUSERCOMMENT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.OucBorrower)
                .HasMaxLength(25)
                .HasColumnName("OUC_BORROWER");
            entity.Property(e => e.OucComments).HasColumnName("OUC_COMMENTS");
            entity.Property(e => e.OucCostaccept)
                .HasMaxLength(1)
                .HasColumnName("OUC_COSTACCEPT");
            entity.Property(e => e.OucDate)
                .HasColumnType("datetime")
                .HasColumnName("OUC_DATE");
            entity.Property(e => e.OucDeliveryOption)
                .HasMaxLength(15)
                .HasColumnName("OUC_DELIVERY_OPTION");
            entity.Property(e => e.OucDynamicline1)
                .HasMaxLength(100)
                .HasColumnName("OUC_DYNAMICLINE1");
            entity.Property(e => e.OucDynamicline2)
                .HasMaxLength(100)
                .HasColumnName("OUC_DYNAMICLINE2");
            entity.Property(e => e.OucDynamicline3)
                .HasMaxLength(100)
                .HasColumnName("OUC_DYNAMICLINE3");
            entity.Property(e => e.OucDynamicline4)
                .HasMaxLength(100)
                .HasColumnName("OUC_DYNAMICLINE4");
            entity.Property(e => e.OucDynamicline5)
                .HasMaxLength(100)
                .HasColumnName("OUC_DYNAMICLINE5");
            entity.Property(e => e.OucEmailStatus)
                .HasMaxLength(1)
                .HasColumnName("OUC_EMAIL_STATUS");
            entity.Property(e => e.OucEstcost)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("OUC_ESTCOST");
            entity.Property(e => e.OucForm)
                .HasMaxLength(3)
                .HasColumnName("OUC_FORM");
            entity.Property(e => e.OucIsbn)
                .HasMaxLength(14)
                .HasColumnName("OUC_ISBN");
            entity.Property(e => e.OucLibdate)
                .HasColumnType("datetime")
                .HasColumnName("OUC_LIBDATE");
            entity.Property(e => e.OucLine1)
                .HasMaxLength(200)
                .HasColumnName("OUC_LINE1");
            entity.Property(e => e.OucLine10)
                .HasMaxLength(100)
                .HasColumnName("OUC_LINE10");
            entity.Property(e => e.OucLine2)
                .HasMaxLength(100)
                .HasColumnName("OUC_LINE2");
            entity.Property(e => e.OucLine3)
                .HasMaxLength(100)
                .HasColumnName("OUC_LINE3");
            entity.Property(e => e.OucLine4)
                .HasMaxLength(100)
                .HasColumnName("OUC_LINE4");
            entity.Property(e => e.OucLine5)
                .HasMaxLength(100)
                .HasColumnName("OUC_LINE5");
            entity.Property(e => e.OucLine6)
                .HasMaxLength(100)
                .HasColumnName("OUC_LINE6");
            entity.Property(e => e.OucLine7)
                .HasMaxLength(100)
                .HasColumnName("OUC_LINE7");
            entity.Property(e => e.OucLine8)
                .HasMaxLength(100)
                .HasColumnName("OUC_LINE8");
            entity.Property(e => e.OucLine9)
                .HasMaxLength(100)
                .HasColumnName("OUC_LINE9");
            entity.Property(e => e.OucLocation)
                .HasMaxLength(20)
                .HasColumnName("OUC_LOCATION");
            entity.Property(e => e.OucNo).HasColumnName("OUC_NO");
            entity.Property(e => e.OucNotes)
                .HasMaxLength(2000)
                .HasColumnName("OUC_NOTES");
            entity.Property(e => e.OucOpacshow)
                .HasMaxLength(1)
                .HasColumnName("OUC_OPACSHOW");
            entity.Property(e => e.OucOper)
                .HasMaxLength(25)
                .HasColumnName("OUC_OPER");
            entity.Property(e => e.OucOperRes)
                .HasMaxLength(25)
                .HasColumnName("OUC_OPER_RES");
            entity.Property(e => e.OucResponse)
                .HasMaxLength(1)
                .HasColumnName("OUC_RESPONSE");
            entity.Property(e => e.OucType)
                .HasMaxLength(1)
                .HasColumnName("OUC_TYPE");
            entity.Property(e => e.UserEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USER_EMAIL");
            entity.Property(e => e.UserGiven)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USER_GIVEN");
            entity.Property(e => e.UserSurname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USER_SURNAME");
            entity.Property(e => e.UserTitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USER_TITLE");
        });

        modelBuilder.Entity<Opacuserreply>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OPACUSERREPLY");

            entity.Property(e => e.OucrBorrower)
                .HasMaxLength(25)
                .HasColumnName("OUCR_BORROWER");
            entity.Property(e => e.OucrDate)
                .HasColumnType("datetime")
                .HasColumnName("OUCR_DATE");
            entity.Property(e => e.OucrEmailStatus)
                .HasMaxLength(1)
                .HasColumnName("OUCR_EMAIL_STATUS");
            entity.Property(e => e.OucrLibdate)
                .HasColumnType("datetime")
                .HasColumnName("OUCR_LIBDATE");
            entity.Property(e => e.OucrLibresponse).HasColumnName("OUCR_LIBRESPONSE");
            entity.Property(e => e.OucrLocation)
                .HasMaxLength(20)
                .HasColumnName("OUCR_LOCATION");
            entity.Property(e => e.OucrNo).HasColumnName("OUCR_NO");
            entity.Property(e => e.OucrOper)
                .HasMaxLength(25)
                .HasColumnName("OUCR_OPER");
            entity.Property(e => e.OucrResponse)
                .HasMaxLength(1)
                .HasColumnName("OUCR_RESPONSE");
            entity.Property(e => e.OucrType)
                .HasMaxLength(1)
                .HasColumnName("OUCR_TYPE");
        });

        modelBuilder.Entity<OperMessage>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OPER_MESSAGE");

            entity.HasIndex(e => e.OmOperFrom, "OM_OPER_FRX");

            entity.HasIndex(e => e.OmOperTo, "OM_OPER_TOX");

            entity.Property(e => e.OmMessage)
                .HasColumnType("ntext")
                .HasColumnName("OM_MESSAGE");
            entity.Property(e => e.OmOperFrom)
                .HasMaxLength(25)
                .HasColumnName("OM_OPER_FROM");
            entity.Property(e => e.OmOperTo)
                .HasMaxLength(25)
                .HasColumnName("OM_OPER_TO");
            entity.Property(e => e.OmReference)
                .HasMaxLength(25)
                .HasColumnName("OM_REFERENCE");
            entity.Property(e => e.OmSeen)
                .HasMaxLength(1)
                .HasColumnName("OM_SEEN");
            entity.Property(e => e.OmSubject)
                .HasMaxLength(30)
                .HasColumnName("OM_SUBJECT");
            entity.Property(e => e.OmTimeToShow)
                .HasColumnType("datetime")
                .HasColumnName("OM_TIME_TO_SHOW");
            entity.Property(e => e.OmUnique).HasColumnName("OM_UNIQUE");
        });

        modelBuilder.Entity<OrdComponent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ORD_COMPONENT");

            entity.HasIndex(e => e.OcCompNo, "OC_COMP_NOX").IsUnique();

            entity.HasIndex(e => e.OcGroupNo, "OC_GROUP_NOX");

            entity.HasIndex(e => e.OcKey1, "OC_KEY1X");

            entity.HasIndex(e => e.OcKey2, "OC_KEY2X");

            entity.HasIndex(e => e.OcKey3, "OC_KEY3X");

            entity.HasIndex(e => e.OcKey4, "OC_KEY4X");

            entity.HasIndex(e => e.OcKey5, "OC_KEY5X");

            entity.HasIndex(e => e.OcKey6, "OC_KEY6X");

            entity.HasIndex(e => e.OcOrderNo, "OC_ORDER_NOX");

            entity.HasIndex(e => e.OcSuppNo, "OC_SUPP_NOX");

            entity.Property(e => e.OcAccno)
                .HasMaxLength(30)
                .HasColumnName("OC_ACCNO");
            entity.Property(e => e.OcAlloc)
                .HasMaxLength(10)
                .HasColumnName("OC_ALLOC");
            entity.Property(e => e.OcCatRef).HasColumnName("OC_CAT_REF");
            entity.Property(e => e.OcCompNo).HasColumnName("OC_COMP_NO");
            entity.Property(e => e.OcCost)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("OC_COST");
            entity.Property(e => e.OcDiscount)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("OC_DISCOUNT");
            entity.Property(e => e.OcDiscountInd)
                .HasMaxLength(1)
                .HasColumnName("OC_DISCOUNT_IND");
            entity.Property(e => e.OcEdition)
                .HasMaxLength(25)
                .HasColumnName("OC_EDITION");
            entity.Property(e => e.OcFinYear).HasColumnName("OC_FIN_YEAR");
            entity.Property(e => e.OcForm)
                .HasMaxLength(3)
                .HasColumnName("OC_FORM");
            entity.Property(e => e.OcGroupNo)
                .HasMaxLength(25)
                .HasColumnName("OC_GROUP_NO");
            entity.Property(e => e.OcIsbn)
                .HasMaxLength(25)
                .HasColumnName("OC_ISBN");
            entity.Property(e => e.OcIssn)
                .HasMaxLength(13)
                .HasColumnName("OC_ISSN");
            entity.Property(e => e.OcKey1)
                .HasMaxLength(100)
                .HasColumnName("OC_KEY1");
            entity.Property(e => e.OcKey2)
                .HasMaxLength(100)
                .HasColumnName("OC_KEY2");
            entity.Property(e => e.OcKey3)
                .HasMaxLength(100)
                .HasColumnName("OC_KEY3");
            entity.Property(e => e.OcKey4)
                .HasMaxLength(100)
                .HasColumnName("OC_KEY4");
            entity.Property(e => e.OcKey5)
                .HasMaxLength(100)
                .HasColumnName("OC_KEY5");
            entity.Property(e => e.OcKey6)
                .HasMaxLength(100)
                .HasColumnName("OC_KEY6");
            entity.Property(e => e.OcLibGroup)
                .HasMaxLength(30)
                .HasColumnName("OC_LIB_GROUP");
            entity.Property(e => e.OcLine1)
                .HasMaxLength(100)
                .HasColumnName("OC_LINE1");
            entity.Property(e => e.OcLine2)
                .HasMaxLength(100)
                .HasColumnName("OC_LINE2");
            entity.Property(e => e.OcLine3)
                .HasMaxLength(100)
                .HasColumnName("OC_LINE3");
            entity.Property(e => e.OcLine4)
                .HasMaxLength(100)
                .HasColumnName("OC_LINE4");
            entity.Property(e => e.OcLine5)
                .HasMaxLength(100)
                .HasColumnName("OC_LINE5");
            entity.Property(e => e.OcLine6)
                .HasMaxLength(100)
                .HasColumnName("OC_LINE6");
            entity.Property(e => e.OcNotes)
                .HasMaxLength(250)
                .HasColumnName("OC_NOTES");
            entity.Property(e => e.OcOrderLno).HasColumnName("OC_ORDER_LNO");
            entity.Property(e => e.OcOrderNo)
                .HasMaxLength(25)
                .HasColumnName("OC_ORDER_NO");
            entity.Property(e => e.OcProcess)
                .HasMaxLength(25)
                .HasColumnName("OC_PROCESS");
            entity.Property(e => e.OcPubNumber)
                .HasMaxLength(50)
                .HasColumnName("OC_PUB_NUMBER");
            entity.Property(e => e.OcQtyInvoiced).HasColumnName("OC_QTY_INVOICED");
            entity.Property(e => e.OcQtyOrdered)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("OC_QTY_ORDERED");
            entity.Property(e => e.OcQtyRecd)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("OC_QTY_RECD");
            entity.Property(e => e.OcStatsCode)
                .HasMaxLength(6)
                .HasColumnName("OC_STATS_CODE");
            entity.Property(e => e.OcStockitemyn)
                .HasMaxLength(1)
                .HasColumnName("OC_STOCKITEMYN");
            entity.Property(e => e.OcSuppNo)
                .HasMaxLength(25)
                .HasColumnName("OC_SUPP_NO");
            entity.Property(e => e.OcTaxAccno)
                .HasMaxLength(30)
                .HasColumnName("OC_TAX_ACCNO");
            entity.Property(e => e.OcTaxCode)
                .HasMaxLength(3)
                .HasColumnName("OC_TAX_CODE");
            entity.Property(e => e.OcTaxRate)
                .HasColumnType("decimal(10, 4)")
                .HasColumnName("OC_TAX_RATE");
            entity.Property(e => e.OcTotal)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("OC_TOTAL");
            entity.Property(e => e.OcTranNo).HasColumnName("OC_TRAN_NO");
            entity.Property(e => e.OcVolume)
                .HasMaxLength(25)
                .HasColumnName("OC_VOLUME");
        });

        modelBuilder.Entity<OrdGroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ORD_GROUP");

            entity.HasIndex(e => e.OgGroupNo, "OG_GROUP_NOX");

            entity.HasIndex(e => e.OgKey, "OG_KEYX");

            entity.Property(e => e.OgDatetime)
                .HasColumnType("datetime")
                .HasColumnName("OG_DATETIME");
            entity.Property(e => e.OgDescription)
                .HasMaxLength(300)
                .HasColumnName("OG_DESCRIPTION");
            entity.Property(e => e.OgGroupNo)
                .HasMaxLength(25)
                .HasColumnName("OG_GROUP_NO");
            entity.Property(e => e.OgKey)
                .HasMaxLength(100)
                .HasColumnName("OG_KEY");
            entity.Property(e => e.OgOper)
                .HasMaxLength(25)
                .HasColumnName("OG_OPER");
            entity.Property(e => e.OgSummary)
                .HasMaxLength(100)
                .HasColumnName("OG_SUMMARY");
        });

        modelBuilder.Entity<OrdHeader>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ORD_HEADER");

            entity.HasIndex(e => e.OhGroupNo, "OH_GROUP_NOX");

            entity.HasIndex(e => e.OhKey, "OH_KEYX");

            entity.HasIndex(e => e.OhOrderNo, "OH_ORDER_NOX");

            entity.HasIndex(e => e.OhSuppNo, "OH_SUPP_NOX");

            entity.Property(e => e.OhAccno)
                .HasMaxLength(30)
                .HasColumnName("OH_ACCNO");
            entity.Property(e => e.OhAlloc)
                .HasMaxLength(10)
                .HasColumnName("OH_ALLOC");
            entity.Property(e => e.OhAuthoriseFlag)
                .HasMaxLength(1)
                .HasColumnName("OH_AUTHORISE_FLAG");
            entity.Property(e => e.OhCatRef).HasColumnName("OH_CAT_REF");
            entity.Property(e => e.OhCondition)
                .HasMaxLength(10)
                .HasColumnName("OH_CONDITION");
            entity.Property(e => e.OhCost)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("OH_COST");
            entity.Property(e => e.OhDatePlaced)
                .HasColumnType("datetime")
                .HasColumnName("OH_DATE_PLACED");
            entity.Property(e => e.OhDatePrinted)
                .HasColumnType("datetime")
                .HasColumnName("OH_DATE_PRINTED");
            entity.Property(e => e.OhDateToClaim)
                .HasColumnType("datetime")
                .HasColumnName("OH_DATE_TO_CLAIM");
            entity.Property(e => e.OhDatetime)
                .HasColumnType("datetime")
                .HasColumnName("OH_DATETIME");
            entity.Property(e => e.OhDescription)
                .HasMaxLength(300)
                .HasColumnName("OH_DESCRIPTION");
            entity.Property(e => e.OhExpectedDate)
                .HasColumnType("datetime")
                .HasColumnName("OH_EXPECTED_DATE");
            entity.Property(e => e.OhFccode)
                .HasMaxLength(4)
                .HasColumnName("OH_FCCODE");
            entity.Property(e => e.OhFcdate)
                .HasColumnType("datetime")
                .HasColumnName("OH_FCDATE");
            entity.Property(e => e.OhFcrate)
                .HasColumnType("decimal(10, 4)")
                .HasColumnName("OH_FCRATE");
            entity.Property(e => e.OhFcvalue)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("OH_FCVALUE");
            entity.Property(e => e.OhForm)
                .HasMaxLength(3)
                .HasColumnName("OH_FORM");
            entity.Property(e => e.OhGroupNo)
                .HasMaxLength(25)
                .HasColumnName("OH_GROUP_NO");
            entity.Property(e => e.OhInvAll)
                .HasMaxLength(1)
                .HasColumnName("OH_INV_ALL");
            entity.Property(e => e.OhKey)
                .HasMaxLength(100)
                .HasColumnName("OH_KEY");
            entity.Property(e => e.OhLibGroup)
                .HasMaxLength(30)
                .HasColumnName("OH_LIB_GROUP");
            entity.Property(e => e.OhOper)
                .HasMaxLength(25)
                .HasColumnName("OH_OPER");
            entity.Property(e => e.OhOrderNo)
                .HasMaxLength(25)
                .HasColumnName("OH_ORDER_NO");
            entity.Property(e => e.OhPaid)
                .HasMaxLength(1)
                .HasColumnName("OH_PAID");
            entity.Property(e => e.OhQuoteFlag)
                .HasMaxLength(1)
                .HasColumnName("OH_QUOTE_FLAG");
            entity.Property(e => e.OhRecdAll)
                .HasMaxLength(1)
                .HasColumnName("OH_RECD_ALL");
            entity.Property(e => e.OhStatsCode)
                .HasMaxLength(6)
                .HasColumnName("OH_STATS_CODE");
            entity.Property(e => e.OhStatus)
                .HasMaxLength(25)
                .HasColumnName("OH_STATUS");
            entity.Property(e => e.OhSummary)
                .HasMaxLength(100)
                .HasColumnName("OH_SUMMARY");
            entity.Property(e => e.OhSuppNo)
                .HasMaxLength(25)
                .HasColumnName("OH_SUPP_NO");
            entity.Property(e => e.OhSuppRef)
                .HasMaxLength(50)
                .HasColumnName("OH_SUPP_REF");
            entity.Property(e => e.OhTotal)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("OH_TOTAL");
            entity.Property(e => e.OhTranNo).HasColumnName("OH_TRAN_NO");
            entity.Property(e => e.OhType)
                .HasMaxLength(10)
                .HasColumnName("OH_TYPE");
            entity.Property(e => e.RotationPlanId).HasColumnName("ROTATION_PLAN_ID");
        });

        modelBuilder.Entity<OrdStkItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ORD_STK_ITEM");

            entity.HasIndex(e => e.OsCompNo, "OS_COMP_NOX");

            entity.HasIndex(e => e.OsInvNo, "OS_INV_NOX");

            entity.HasIndex(e => e.OsNewItemNo, "OS_NEW_ITEM_NOX");

            entity.HasIndex(e => e.OsStkItemNo, "OS_STK_ITEM_NOX");

            entity.Property(e => e.OsAccessionNo)
                .HasMaxLength(25)
                .HasColumnName("OS_ACCESSION_NO");
            entity.Property(e => e.OsCompNo).HasColumnName("OS_COMP_NO");
            entity.Property(e => e.OsDateOrdered)
                .HasColumnType("datetime")
                .HasColumnName("OS_DATE_ORDERED");
            entity.Property(e => e.OsInstructions)
                .HasMaxLength(100)
                .HasColumnName("OS_INSTRUCTIONS");
            entity.Property(e => e.OsInvNo).HasColumnName("OS_INV_NO");
            entity.Property(e => e.OsInvoiceCompNo).HasColumnName("OS_INVOICE_COMP_NO");
            entity.Property(e => e.OsInvoiceDate)
                .HasColumnType("datetime")
                .HasColumnName("OS_INVOICE_DATE");
            entity.Property(e => e.OsInvoicedyn)
                .HasMaxLength(1)
                .HasColumnName("OS_INVOICEDYN");
            entity.Property(e => e.OsLlCode)
                .HasMaxLength(20)
                .HasColumnName("OS_LL_CODE");
            entity.Property(e => e.OsNewItemNo)
                .HasMaxLength(25)
                .HasColumnName("OS_NEW_ITEM_NO");
            entity.Property(e => e.OsRotationPlanId).HasColumnName("OS_ROTATION_PLAN_ID");
            entity.Property(e => e.OsStatus)
                .HasMaxLength(15)
                .HasColumnName("OS_STATUS");
            entity.Property(e => e.OsStatusDate)
                .HasColumnType("datetime")
                .HasColumnName("OS_STATUS_DATE");
            entity.Property(e => e.OsStkItemNo)
                .HasMaxLength(25)
                .HasColumnName("OS_STK_ITEM_NO");
        });

        modelBuilder.Entity<OrdSystab>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ORD_SYSTAB");

            entity.Property(e => e.CompNumber).HasColumnName("COMP_NUMBER");
            entity.Property(e => e.InvCompNumber).HasColumnName("INV_COMP_NUMBER");
            entity.Property(e => e.InvoiceNumber).HasColumnName("INVOICE_NUMBER");
            entity.Property(e => e.ItemNumber).HasColumnName("ITEM_NUMBER");
            entity.Property(e => e.OrdAccNo).HasColumnName("ORD_ACC_NO");
            entity.Property(e => e.OrdAccPart1)
                .HasMaxLength(4)
                .HasColumnName("ORD_ACC_PART1");
            entity.Property(e => e.OrdAccPart2)
                .HasMaxLength(4)
                .HasColumnName("ORD_ACC_PART2");
            entity.Property(e => e.OrdAccPart3)
                .HasMaxLength(4)
                .HasColumnName("ORD_ACC_PART3");
            entity.Property(e => e.OrdAccPart4)
                .HasMaxLength(4)
                .HasColumnName("ORD_ACC_PART4");
            entity.Property(e => e.OrdAccPart5)
                .HasMaxLength(4)
                .HasColumnName("ORD_ACC_PART5");
            entity.Property(e => e.OrdAccPart6)
                .HasMaxLength(4)
                .HasColumnName("ORD_ACC_PART6");
            entity.Property(e => e.OrderNumber).HasColumnName("ORDER_NUMBER");
            entity.Property(e => e.OrderlinesNo).HasColumnName("ORDERLINES_NO");
        });

        modelBuilder.Entity<PaypalCountry>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PAYPAL_COUNTRIES");

            entity.Property(e => e.CountryRegion)
                .HasMaxLength(20)
                .HasColumnName("COUNTRY_REGION");
            entity.Property(e => e.CountryRegionCode)
                .HasMaxLength(2)
                .HasColumnName("COUNTRY_REGION_CODE");
            entity.Property(e => e.PostalCodeRequired).HasColumnName("POSTAL CODE_REQUIRED");
        });

        modelBuilder.Entity<PerCopy>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PER_COPY");

            entity.HasIndex(e => e.PcCopyNo, "PC_COPY_NOX").IsUnique();

            entity.HasIndex(e => e.PcIssueNo, "PC_ISSUE_NOX");

            entity.HasIndex(e => e.PcStkItemNo, "PC_ITEM_NOX");

            entity.HasIndex(e => e.PcPerNo, "PC_PER_NOX");

            entity.HasIndex(e => e.PcSubsNo, "PC_SUBS_NOX");

            entity.Property(e => e.PcCallNo)
                .HasMaxLength(25)
                .HasColumnName("PC_CALL_NO");
            entity.Property(e => e.PcClaimed)
                .HasMaxLength(1)
                .HasColumnName("PC_CLAIMED");
            entity.Property(e => e.PcCopy).HasColumnName("PC_COPY");
            entity.Property(e => e.PcCopyNo).HasColumnName("PC_COPY_NO");
            entity.Property(e => e.PcCost)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("PC_COST");
            entity.Property(e => e.PcDateRecd)
                .HasColumnType("datetime")
                .HasColumnName("PC_DATE_RECD");
            entity.Property(e => e.PcDescription)
                .HasMaxLength(100)
                .HasColumnName("PC_DESCRIPTION");
            entity.Property(e => e.PcExpDate)
                .HasColumnType("datetime")
                .HasColumnName("PC_EXP_DATE");
            entity.Property(e => e.PcForLoan)
                .HasMaxLength(1)
                .HasColumnName("PC_FOR_LOAN");
            entity.Property(e => e.PcInstructions)
                .HasMaxLength(100)
                .HasColumnName("PC_INSTRUCTIONS");
            entity.Property(e => e.PcIssueNo).HasColumnName("PC_ISSUE_NO");
            entity.Property(e => e.PcLikelyDate)
                .HasColumnType("datetime")
                .HasColumnName("PC_LIKELY_DATE");
            entity.Property(e => e.PcLlCode)
                .HasMaxLength(20)
                .HasColumnName("PC_LL_CODE");
            entity.Property(e => e.PcPerNo).HasColumnName("PC_PER_NO");
            entity.Property(e => e.PcStkItemNo)
                .HasMaxLength(25)
                .HasColumnName("PC_STK_ITEM_NO");
            entity.Property(e => e.PcSubsNo).HasColumnName("PC_SUBS_NO");
        });

        modelBuilder.Entity<PerIssue>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PER_ISSUES");

            entity.HasIndex(e => e.PiIssueNo, "PI_ISSUE_NOX").IsUnique();

            entity.HasIndex(e => e.PiSubsNo, "PI_SUBS_NOX");

            entity.Property(e => e.PiCatRef).HasColumnName("PI_CAT_REF");
            entity.Property(e => e.PiClaim)
                .HasMaxLength(1)
                .HasColumnName("PI_CLAIM");
            entity.Property(e => e.PiComments)
                .HasMaxLength(100)
                .HasColumnName("PI_COMMENTS");
            entity.Property(e => e.PiDate)
                .HasColumnType("datetime")
                .HasColumnName("PI_DATE");
            entity.Property(e => e.PiDescription)
                .HasMaxLength(100)
                .HasColumnName("PI_DESCRIPTION");
            entity.Property(e => e.PiDueDate)
                .HasColumnType("datetime")
                .HasColumnName("PI_DUE_DATE");
            entity.Property(e => e.PiIssueNo).HasColumnName("PI_ISSUE_NO");
            entity.Property(e => e.PiLikelyDate)
                .HasColumnType("datetime")
                .HasColumnName("PI_LIKELY_DATE");
            entity.Property(e => e.PiPerNo).HasColumnName("PI_PER_NO");
            entity.Property(e => e.PiQtyRecd).HasColumnName("PI_QTY_RECD");
            entity.Property(e => e.PiQtySub).HasColumnName("PI_QTY_SUB");
            entity.Property(e => e.PiRecdDate)
                .HasColumnType("datetime")
                .HasColumnName("PI_RECD_DATE");
            entity.Property(e => e.PiSpecial)
                .HasMaxLength(1)
                .HasColumnName("PI_SPECIAL");
            entity.Property(e => e.PiSubsNo).HasColumnName("PI_SUBS_NO");
        });

        modelBuilder.Entity<PerList>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PER_LIST");

            entity.Property(e => e.PlCircList).HasColumnName("PL_CIRC_LIST");
            entity.Property(e => e.PlCopyNo).HasColumnName("PL_COPY_NO");
            entity.Property(e => e.PlPerNo).HasColumnName("PL_PER_NO");
            entity.Property(e => e.PlSubsNo).HasColumnName("PL_SUBS_NO");
        });

        modelBuilder.Entity<PerName>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PER_NAMES");

            entity.Property(e => e.PnDatetime)
                .HasColumnType("datetime")
                .HasColumnName("PN_DATETIME");
            entity.Property(e => e.PnDay)
                .HasMaxLength(25)
                .HasColumnName("PN_DAY");
            entity.Property(e => e.PnDelay).HasColumnName("PN_DELAY");
            entity.Property(e => e.PnExceptions)
                .HasMaxLength(100)
                .HasColumnName("PN_EXCEPTIONS");
            entity.Property(e => e.PnFormat)
                .HasMaxLength(250)
                .HasColumnName("PN_FORMAT");
            entity.Property(e => e.PnMonth)
                .HasMaxLength(25)
                .HasColumnName("PN_MONTH");
            entity.Property(e => e.PnNum1Disp)
                .HasMaxLength(25)
                .HasColumnName("PN_NUM1_DISP");
            entity.Property(e => e.PnNum1Rotate).HasColumnName("PN_NUM1_ROTATE");
            entity.Property(e => e.PnNum1Start).HasColumnName("PN_NUM1_START");
            entity.Property(e => e.PnNum2Disp)
                .HasMaxLength(25)
                .HasColumnName("PN_NUM2_DISP");
            entity.Property(e => e.PnNum2Reset).HasColumnName("PN_NUM2_RESET");
            entity.Property(e => e.PnNum2Rotate).HasColumnName("PN_NUM2_ROTATE");
            entity.Property(e => e.PnNum2Start).HasColumnName("PN_NUM2_START");
            entity.Property(e => e.PnNum3Disp)
                .HasMaxLength(25)
                .HasColumnName("PN_NUM3_DISP");
            entity.Property(e => e.PnNum3Reset).HasColumnName("PN_NUM3_RESET");
            entity.Property(e => e.PnNum3Rotate).HasColumnName("PN_NUM3_ROTATE");
            entity.Property(e => e.PnNum3Start).HasColumnName("PN_NUM3_START");
            entity.Property(e => e.PnOper)
                .HasMaxLength(25)
                .HasColumnName("PN_OPER");
            entity.Property(e => e.PnPerNo).HasColumnName("PN_PER_NO");
            entity.Property(e => e.PnTitlePrefix)
                .HasMaxLength(250)
                .HasColumnName("PN_TITLE_PREFIX");
            entity.Property(e => e.PnTitleSuffix)
                .HasMaxLength(250)
                .HasColumnName("PN_TITLE_SUFFIX");
            entity.Property(e => e.PnWeekday)
                .HasMaxLength(25)
                .HasColumnName("PN_WEEKDAY");
            entity.Property(e => e.PnYear)
                .HasMaxLength(25)
                .HasColumnName("PN_YEAR");
        });

        modelBuilder.Entity<PerStock>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PER_STOCK");

            entity.HasIndex(e => e.PstPerNo, "PSTKPERNOX");

            entity.Property(e => e.PstAlertOper)
                .HasMaxLength(1)
                .HasColumnName("PST_ALERT_OPER");
            entity.Property(e => e.PstCopy).HasColumnName("PST_COPY");
            entity.Property(e => e.PstDescription)
                .HasMaxLength(100)
                .HasColumnName("PST_DESCRIPTION");
            entity.Property(e => e.PstForLoan)
                .HasMaxLength(1)
                .HasColumnName("PST_FOR_LOAN");
            entity.Property(e => e.PstForm)
                .HasMaxLength(3)
                .HasColumnName("PST_FORM");
            entity.Property(e => e.PstLine1)
                .HasMaxLength(100)
                .HasColumnName("PST_LINE1");
            entity.Property(e => e.PstLine2)
                .HasMaxLength(100)
                .HasColumnName("PST_LINE2");
            entity.Property(e => e.PstLine3)
                .HasMaxLength(100)
                .HasColumnName("PST_LINE3");
            entity.Property(e => e.PstLine4)
                .HasMaxLength(100)
                .HasColumnName("PST_LINE4");
            entity.Property(e => e.PstLine5)
                .HasMaxLength(100)
                .HasColumnName("PST_LINE5");
            entity.Property(e => e.PstLine6)
                .HasMaxLength(100)
                .HasColumnName("PST_LINE6");
            entity.Property(e => e.PstLocFloor)
                .HasMaxLength(20)
                .HasColumnName("PST_LOC_FLOOR");
            entity.Property(e => e.PstLocPerm)
                .HasMaxLength(20)
                .HasColumnName("PST_LOC_PERM");
            entity.Property(e => e.PstLocTemp)
                .HasMaxLength(20)
                .HasColumnName("PST_LOC_TEMP");
            entity.Property(e => e.PstOpacShow)
                .HasMaxLength(1)
                .HasColumnName("PST_OPAC_SHOW");
            entity.Property(e => e.PstPerNo).HasColumnName("PST_PER_NO");
            entity.Property(e => e.PstProcess)
                .HasMaxLength(20)
                .HasColumnName("PST_PROCESS");
            entity.Property(e => e.PstProcessDate)
                .HasColumnType("datetime")
                .HasColumnName("PST_PROCESS_DATE");
            entity.Property(e => e.PstStatsCode)
                .HasMaxLength(6)
                .HasColumnName("PST_STATS_CODE");
            entity.Property(e => e.PstStkCost)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("PST_STK_COST");
            entity.Property(e => e.PstSubsNo).HasColumnName("PST_SUBS_NO");
        });

        modelBuilder.Entity<PerSub>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PER_SUBS");

            entity.HasIndex(e => e.PsPerNo, "PS_PER_NOX");

            entity.HasIndex(e => e.PsSubsNo, "PS_SUBS_NOX").IsUnique();

            entity.HasIndex(e => e.PsSuppNo, "PS_SUPP_NOX");

            entity.Property(e => e.PsCircList).HasColumnName("PS_CIRC_LIST");
            entity.Property(e => e.PsComments)
                .HasMaxLength(250)
                .HasColumnName("PS_COMMENTS");
            entity.Property(e => e.PsCost)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("PS_COST");
            entity.Property(e => e.PsCostIssue)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("PS_COST_ISSUE");
            entity.Property(e => e.PsDate)
                .HasColumnType("datetime")
                .HasColumnName("PS_DATE");
            entity.Property(e => e.PsEndDate)
                .HasColumnType("datetime")
                .HasColumnName("PS_END_DATE");
            entity.Property(e => e.PsIssn)
                .HasMaxLength(12)
                .HasColumnName("PS_ISSN");
            entity.Property(e => e.PsLibGroup)
                .HasMaxLength(30)
                .HasColumnName("PS_LIB_GROUP");
            entity.Property(e => e.PsLlCode)
                .HasMaxLength(20)
                .HasColumnName("PS_LL_CODE");
            entity.Property(e => e.PsOrderLno).HasColumnName("PS_ORDER_LNO");
            entity.Property(e => e.PsOrderNo)
                .HasMaxLength(25)
                .HasColumnName("PS_ORDER_NO");
            entity.Property(e => e.PsPerNo).HasColumnName("PS_PER_NO");
            entity.Property(e => e.PsQtyIssues).HasColumnName("PS_QTY_ISSUES");
            entity.Property(e => e.PsQtySub).HasColumnName("PS_QTY_SUB");
            entity.Property(e => e.PsRenewDue)
                .HasColumnType("datetime")
                .HasColumnName("PS_RENEW_DUE");
            entity.Property(e => e.PsStartDate)
                .HasColumnType("datetime")
                .HasColumnName("PS_START_DATE");
            entity.Property(e => e.PsSubsNo).HasColumnName("PS_SUBS_NO");
            entity.Property(e => e.PsSuppNo)
                .HasMaxLength(25)
                .HasColumnName("PS_SUPP_NO");
            entity.Property(e => e.PsTitleFormat)
                .HasMaxLength(500)
                .HasColumnName("PS_TITLE_FORMAT");
            entity.Property(e => e.PsTitlePrefix)
                .HasMaxLength(200)
                .HasColumnName("PS_TITLE_PREFIX");
            entity.Property(e => e.PsTitleSuffix)
                .HasMaxLength(50)
                .HasColumnName("PS_TITLE_SUFFIX");
        });

        modelBuilder.Entity<PerSubsFormat>(entity =>
        {
            entity.ToTable("PER_SUBS_FORMAT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Format)
                .HasMaxLength(50)
                .HasColumnName("FORMAT");
        });

        modelBuilder.Entity<PerSubsInstruct>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PER_SUBS_INSTRUCTS");

            entity.Property(e => e.PsCopyNo).HasColumnName("PS_COPY_NO");
            entity.Property(e => e.PsInstructions)
                .HasMaxLength(100)
                .HasColumnName("PS_INSTRUCTIONS");
            entity.Property(e => e.PsPerNo).HasColumnName("PS_PER_NO");
            entity.Property(e => e.PsSubsNo).HasColumnName("PS_SUBS_NO");
        });

        modelBuilder.Entity<PerSupplier>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PER_SUPPLIER");

            entity.HasIndex(e => e.PsSuppNo, "PSSUPPNOX");

            entity.HasIndex(e => e.PsCompKey, "SUPKEYX");

            entity.HasIndex(e => e.PsCompany, "SUPPNAMEX");

            entity.Property(e => e.PsAddr1)
                .HasMaxLength(40)
                .HasColumnName("PS_ADDR1");
            entity.Property(e => e.PsAddr2)
                .HasMaxLength(40)
                .HasColumnName("PS_ADDR2");
            entity.Property(e => e.PsAddr3)
                .HasMaxLength(40)
                .HasColumnName("PS_ADDR3");
            entity.Property(e => e.PsAddr4)
                .HasMaxLength(40)
                .HasColumnName("PS_ADDR4");
            entity.Property(e => e.PsClaimCode)
                .HasMaxLength(3)
                .HasColumnName("PS_CLAIM_CODE");
            entity.Property(e => e.PsCompKey)
                .HasMaxLength(100)
                .HasColumnName("PS_COMP_KEY");
            entity.Property(e => e.PsCompany)
                .HasMaxLength(50)
                .HasColumnName("PS_COMPANY");
            entity.Property(e => e.PsContact)
                .HasMaxLength(50)
                .HasColumnName("PS_CONTACT");
            entity.Property(e => e.PsCoyNo)
                .HasMaxLength(25)
                .HasColumnName("PS_COY_NO");
            entity.Property(e => e.PsDatetime)
                .HasColumnType("datetime")
                .HasColumnName("PS_DATETIME");
            entity.Property(e => e.PsDiscount)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("PS_DISCOUNT");
            entity.Property(e => e.PsDiscountInd)
                .HasMaxLength(1)
                .HasColumnName("PS_DISCOUNT_IND");
            entity.Property(e => e.PsEanNo).HasColumnName("PS_EAN_NO");
            entity.Property(e => e.PsEdiEmail)
                .HasMaxLength(75)
                .HasColumnName("PS_EDI_EMAIL");
            entity.Property(e => e.PsEmail)
                .HasMaxLength(75)
                .HasColumnName("PS_EMAIL");
            entity.Property(e => e.PsFax)
                .HasMaxLength(20)
                .HasColumnName("PS_FAX");
            entity.Property(e => e.PsFccode)
                .HasMaxLength(4)
                .HasColumnName("PS_FCCODE");
            entity.Property(e => e.PsInstruct)
                .HasMaxLength(300)
                .HasColumnName("PS_INSTRUCT");
            entity.Property(e => e.PsInstructShow)
                .HasMaxLength(1)
                .HasColumnName("PS_INSTRUCT_SHOW");
            entity.Property(e => e.PsLeadTime).HasColumnName("PS_LEAD_TIME");
            entity.Property(e => e.PsMembership)
                .HasMaxLength(100)
                .HasColumnName("PS_MEMBERSHIP");
            entity.Property(e => e.PsOper)
                .HasMaxLength(25)
                .HasColumnName("PS_OPER");
            entity.Property(e => e.PsPostcode)
                .HasMaxLength(20)
                .HasColumnName("PS_POSTCODE");
            entity.Property(e => e.PsSanNo).HasColumnName("PS_SAN_NO");
            entity.Property(e => e.PsStreetAddr1)
                .HasMaxLength(40)
                .HasColumnName("PS_STREET_ADDR1");
            entity.Property(e => e.PsStreetAddr2)
                .HasMaxLength(40)
                .HasColumnName("PS_STREET_ADDR2");
            entity.Property(e => e.PsStreetAddr3)
                .HasMaxLength(40)
                .HasColumnName("PS_STREET_ADDR3");
            entity.Property(e => e.PsStreetPostcode)
                .HasMaxLength(20)
                .HasColumnName("PS_STREET_POSTCODE");
            entity.Property(e => e.PsSuppNo)
                .HasMaxLength(25)
                .HasColumnName("PS_SUPP_NO");
            entity.Property(e => e.PsTaxcode)
                .HasMaxLength(4)
                .HasColumnName("PS_TAXCODE");
            entity.Property(e => e.PsTelephone)
                .HasMaxLength(20)
                .HasColumnName("PS_TELEPHONE");
            entity.Property(e => e.PsTerms).HasColumnName("PS_TERMS");
            entity.Property(e => e.PsUseEdi)
                .HasMaxLength(1)
                .HasColumnName("PS_USE_EDI");
            entity.Property(e => e.PsUseEmail)
                .HasMaxLength(1)
                .HasColumnName("PS_USE_EMAIL");
            entity.Property(e => e.PsWebAddress)
                .HasMaxLength(75)
                .HasColumnName("PS_WEB_ADDRESS");
            entity.Property(e => e.PsWebLogin)
                .HasMaxLength(50)
                .HasColumnName("PS_WEB_LOGIN");
            entity.Property(e => e.PsWebPassword)
                .HasMaxLength(25)
                .HasColumnName("PS_WEB_PASSWORD");
        });

        modelBuilder.Entity<PerSystab>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PER_SYSTAB");

            entity.Property(e => e.CopyNumber).HasColumnName("COPY_NUMBER");
            entity.Property(e => e.IssueNumber).HasColumnName("ISSUE_NUMBER");
            entity.Property(e => e.PerNumber).HasColumnName("PER_NUMBER");
            entity.Property(e => e.SubsNumber).HasColumnName("SUBS_NUMBER");
        });

        modelBuilder.Entity<Periodical>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PERIODICAL");

            entity.HasIndex(e => e.PerCatNo, "PER_CAT_NOX");

            entity.HasIndex(e => e.PerIssn, "PER_ISSNX");

            entity.HasIndex(e => e.PerKey, "PER_KEYX");

            entity.HasIndex(e => e.PerNo, "PER_NOX").IsUnique();

            entity.Property(e => e.PerBrief)
                .HasMaxLength(250)
                .HasColumnName("PER_BRIEF");
            entity.Property(e => e.PerCatNo).HasColumnName("PER_CAT_NO");
            entity.Property(e => e.PerDatetime)
                .HasColumnType("datetime")
                .HasColumnName("PER_DATETIME");
            entity.Property(e => e.PerFreq)
                .HasMaxLength(3)
                .HasColumnName("PER_FREQ");
            entity.Property(e => e.PerIssn)
                .HasMaxLength(12)
                .HasColumnName("PER_ISSN");
            entity.Property(e => e.PerKey)
                .HasMaxLength(100)
                .HasColumnName("PER_KEY");
            entity.Property(e => e.PerLibGroup)
                .HasMaxLength(30)
                .HasColumnName("PER_LIB_GROUP");
            entity.Property(e => e.PerNo).HasColumnName("PER_NO");
            entity.Property(e => e.PerOper)
                .HasMaxLength(25)
                .HasColumnName("PER_OPER");
            entity.Property(e => e.PerPrevKey)
                .HasMaxLength(100)
                .HasColumnName("PER_PREV_KEY");
            entity.Property(e => e.PerPrevTitle)
                .HasMaxLength(120)
                .HasColumnName("PER_PREV_TITLE");
            entity.Property(e => e.PerRetention)
                .HasMaxLength(10)
                .HasColumnName("PER_RETENTION");
            entity.Property(e => e.PerStkCall)
                .HasMaxLength(20)
                .HasColumnName("PER_STK_CALL");
            entity.Property(e => e.PerStkCode)
                .HasMaxLength(6)
                .HasColumnName("PER_STK_CODE");
            entity.Property(e => e.PerStkForm)
                .HasMaxLength(3)
                .HasColumnName("PER_STK_FORM");
            entity.Property(e => e.PerTitle)
                .HasMaxLength(120)
                .HasColumnName("PER_TITLE");
        });

        modelBuilder.Entity<RepOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("REP_ORDER");

            entity.Property(e => e.RoColName)
                .HasMaxLength(30)
                .HasColumnName("RO_COL_NAME");
            entity.Property(e => e.RoColumn).HasColumnName("RO_COLUMN");
            entity.Property(e => e.RoOrder).HasColumnName("RO_ORDER");
            entity.Property(e => e.RoOrderNo).HasColumnName("RO_ORDER_NO");
            entity.Property(e => e.RoSortOrder)
                .HasMaxLength(4)
                .HasColumnName("RO_SORT_ORDER");
        });

        modelBuilder.Entity<RepPrint>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("REP_PRINTS");

            entity.Property(e => e.RepsExtrawhere)
                .HasMaxLength(300)
                .HasColumnName("REPS_EXTRAWHERE");
            entity.Property(e => e.RepsPrintNo).HasColumnName("REPS_PRINT_NO");
            entity.Property(e => e.RepsSql)
                .HasColumnType("ntext")
                .HasColumnName("REPS_SQL");
        });

        modelBuilder.Entity<RepPrintf>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("REP_PRINTF");

            entity.Property(e => e.RepfFormVars)
                .HasColumnType("ntext")
                .HasColumnName("REPF_FORM_VARS");
            entity.Property(e => e.RepfPrintNo).HasColumnName("REPF_PRINT_NO");
        });

        modelBuilder.Entity<RepPrintr>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("REP_PRINTR");

            entity.Property(e => e.RepCopies).HasColumnName("REP_COPIES");
            entity.Property(e => e.RepCreateHistory)
                .HasMaxLength(1)
                .HasColumnName("REP_CREATE_HISTORY");
            entity.Property(e => e.RepDatePrinted)
                .HasColumnType("datetime")
                .HasColumnName("REP_DATE_PRINTED");
            entity.Property(e => e.RepDateToPrint)
                .HasColumnType("datetime")
                .HasColumnName("REP_DATE_TO_PRINT");
            entity.Property(e => e.RepDatetime)
                .HasColumnType("datetime")
                .HasColumnName("REP_DATETIME");
            entity.Property(e => e.RepDescription)
                .HasMaxLength(100)
                .HasColumnName("REP_DESCRIPTION");
            entity.Property(e => e.RepDraft)
                .HasMaxLength(1)
                .HasColumnName("REP_DRAFT");
            entity.Property(e => e.RepFileDesc)
                .HasMaxLength(100)
                .HasColumnName("REP_FILE_DESC");
            entity.Property(e => e.RepFilename)
                .HasMaxLength(250)
                .HasColumnName("REP_FILENAME");
            entity.Property(e => e.RepLlCode)
                .HasMaxLength(20)
                .HasColumnName("REP_LL_CODE");
            entity.Property(e => e.RepNumber).HasColumnName("REP_NUMBER");
            entity.Property(e => e.RepOper)
                .HasMaxLength(25)
                .HasColumnName("REP_OPER");
            entity.Property(e => e.RepOverwriteFile)
                .HasMaxLength(1)
                .HasColumnName("REP_OVERWRITE_FILE");
            entity.Property(e => e.RepPageFrom).HasColumnName("REP_PAGE_FROM");
            entity.Property(e => e.RepPageTo).HasColumnName("REP_PAGE_TO");
            entity.Property(e => e.RepPrintNo).HasColumnName("REP_PRINT_NO");
            entity.Property(e => e.RepPrinter)
                .HasMaxLength(100)
                .HasColumnName("REP_PRINTER");
            entity.Property(e => e.RepPrintfile)
                .HasMaxLength(250)
                .HasColumnName("REP_PRINTFILE");
            entity.Property(e => e.RepProgress)
                .HasMaxLength(1)
                .HasColumnName("REP_PROGRESS");
            entity.Property(e => e.RepRepeat)
                .HasMaxLength(2)
                .HasColumnName("REP_REPEAT");
            entity.Property(e => e.RepReportVars)
                .HasColumnType("ntext")
                .HasColumnName("REP_REPORT_VARS");
            entity.Property(e => e.RepScreen)
                .HasMaxLength(35)
                .HasColumnName("REP_SCREEN");
            entity.Property(e => e.RepStatsCode).HasColumnName("REP_STATS_CODE");
            entity.Property(e => e.RepSubStats).HasColumnName("REP_SUB_STATS");
            entity.Property(e => e.RepType).HasColumnName("REP_TYPE");
            entity.Property(e => e.RepUpdate)
                .HasMaxLength(1)
                .HasColumnName("REP_UPDATE");
        });

        modelBuilder.Entity<RepSystab>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("REP_SYSTAB");

            entity.Property(e => e.RepFileNo).HasColumnName("REP_FILE_NO");
            entity.Property(e => e.RepNumber).HasColumnName("REP_NUMBER");
            entity.Property(e => e.RepPrintNo).HasColumnName("REP_PRINT_NO");
        });

        modelBuilder.Entity<RepTypeDef>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("REP_TYPE_DEF");

            entity.Property(e => e.RtdRtype).HasColumnName("RTD_RTYPE");
            entity.Property(e => e.RtdRtypeDesc)
                .HasMaxLength(300)
                .HasColumnName("RTD_RTYPE_DESC");
            entity.Property(e => e.RtdScreen)
                .HasMaxLength(35)
                .HasColumnName("RTD_SCREEN");
            entity.Property(e => e.RtdUserName)
                .HasMaxLength(25)
                .HasColumnName("RTD_USER_NAME");
        });

        modelBuilder.Entity<RepWhere>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("REP_WHERE");

            entity.Property(e => e.RepAddRight)
                .HasMaxLength(250)
                .HasColumnName("REP_ADD_RIGHT");
            entity.Property(e => e.RepColName)
                .HasMaxLength(30)
                .HasColumnName("REP_COL_NAME");
            entity.Property(e => e.RepDescription)
                .HasMaxLength(100)
                .HasColumnName("REP_DESCRIPTION");
            entity.Property(e => e.RepLeftbracket)
                .HasMaxLength(10)
                .HasColumnName("REP_LEFTBRACKET");
            entity.Property(e => e.RepOperEqual)
                .HasMaxLength(20)
                .HasColumnName("REP_OPER_EQUAL");
            entity.Property(e => e.RepOperJoin)
                .HasMaxLength(5)
                .HasColumnName("REP_OPER_JOIN");
            entity.Property(e => e.RepOrder).HasColumnName("REP_ORDER");
            entity.Property(e => e.RepRightbracket)
                .HasMaxLength(10)
                .HasColumnName("REP_RIGHTBRACKET");
            entity.Property(e => e.RepWhereNo).HasColumnName("REP_WHERE_NO");
        });

        modelBuilder.Entity<ReportControl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("REPORT_CONTROL");

            entity.Property(e => e.RcFieldNumber).HasColumnName("RC_FIELD_NUMBER");
            entity.Property(e => e.RcOrigRepNo).HasColumnName("RC_ORIG_REP_NO");
            entity.Property(e => e.RcParam1)
                .HasMaxLength(50)
                .HasColumnName("RC_PARAM1");
            entity.Property(e => e.RcParam2)
                .HasMaxLength(50)
                .HasColumnName("RC_PARAM2");
            entity.Property(e => e.RcParam3)
                .HasMaxLength(50)
                .HasColumnName("RC_PARAM3");
            entity.Property(e => e.RcParam4)
                .HasMaxLength(50)
                .HasColumnName("RC_PARAM4");
            entity.Property(e => e.RcRepNumber).HasColumnName("RC_REP_NUMBER");
            entity.Property(e => e.RcRepPrintNo).HasColumnName("RC_REP_PRINT_NO");
        });

        modelBuilder.Entity<ReportEmailAttachment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("REPORT_EMAIL_ATTACHMENT");

            entity.Property(e => e.ReaFileName)
                .HasMaxLength(300)
                .HasColumnName("REA_FILE_NAME");
            entity.Property(e => e.ReaRepNumber).HasColumnName("REA_REP_NUMBER");
        });

        modelBuilder.Entity<ReportFile>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("REPORT_FILES");

            entity.Property(e => e.ReportMessage)
                .HasMaxLength(120)
                .HasColumnName("REPORT_MESSAGE");
            entity.Property(e => e.RfCreateHistory)
                .HasMaxLength(1)
                .HasColumnName("RF_CREATE_HISTORY");
            entity.Property(e => e.RfDesc)
                .HasMaxLength(100)
                .HasColumnName("RF_DESC");
            entity.Property(e => e.RfFileNo).HasColumnName("RF_FILE_NO");
            entity.Property(e => e.RfFilename)
                .HasMaxLength(75)
                .HasColumnName("RF_FILENAME");
            entity.Property(e => e.RfLlCode)
                .HasMaxLength(20)
                .HasColumnName("RF_LL_CODE");
            entity.Property(e => e.RfMessage)
                .HasMaxLength(120)
                .HasColumnName("RF_MESSAGE");
            entity.Property(e => e.RfScreen)
                .HasMaxLength(35)
                .HasColumnName("RF_SCREEN");
            entity.Property(e => e.RfStatsCode).HasColumnName("RF_STATS_CODE");
            entity.Property(e => e.RfSubStats).HasColumnName("RF_SUB_STATS");
            entity.Property(e => e.RfType).HasColumnName("RF_TYPE");
            entity.Property(e => e.RfUpdate)
                .HasMaxLength(1)
                .HasColumnName("RF_UPDATE");
        });

        modelBuilder.Entity<ReportNoText>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("REPORT_NO_TEXT");

            entity.Property(e => e.RntLlCode)
                .HasMaxLength(20)
                .HasColumnName("RNT_LL_CODE");
            entity.Property(e => e.RntRepNumber).HasColumnName("RNT_REP_NUMBER");
            entity.Property(e => e.RntRepText)
                .HasColumnType("ntext")
                .HasColumnName("RNT_REP_TEXT");
        });

        modelBuilder.Entity<Reportw>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("REPORTW");

            entity.Property(e => e.RepCreateHistory)
                .HasMaxLength(1)
                .HasColumnName("REP_CREATE_HISTORY");
            entity.Property(e => e.RepDatetime)
                .HasColumnType("datetime")
                .HasColumnName("REP_DATETIME");
            entity.Property(e => e.RepDesc)
                .HasMaxLength(100)
                .HasColumnName("REP_DESC");
            entity.Property(e => e.RepFileNo).HasColumnName("REP_FILE_NO");
            entity.Property(e => e.RepLlCode)
                .HasMaxLength(20)
                .HasColumnName("REP_LL_CODE");
            entity.Property(e => e.RepNumber).HasColumnName("REP_NUMBER");
            entity.Property(e => e.RepOper)
                .HasMaxLength(25)
                .HasColumnName("REP_OPER");
            entity.Property(e => e.RepOrderNo).HasColumnName("REP_ORDER_NO");
            entity.Property(e => e.RepStatsCode).HasColumnName("REP_STATS_CODE");
            entity.Property(e => e.RepSubStats).HasColumnName("REP_SUB_STATS");
            entity.Property(e => e.RepUpdate)
                .HasMaxLength(1)
                .HasColumnName("REP_UPDATE");
            entity.Property(e => e.RepWhereNo).HasColumnName("REP_WHERE_NO");
        });

        modelBuilder.Entity<ResSystab>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RES_SYSTAB");

            entity.Property(e => e.ResNumber).HasColumnName("RES_NUMBER");
        });

        modelBuilder.Entity<Reservation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RESERVATION");

            entity.HasIndex(e => e.ResBorNo, "RESBORX");

            entity.HasIndex(e => e.ResStkItem, "RESSTKX");

            entity.HasIndex(e => e.ResNumber, "RES_NUMBERX");

            entity.Property(e => e.ResAllOrFirst)
                .HasMaxLength(1)
                .HasColumnName("RES_ALL_OR_FIRST");
            entity.Property(e => e.ResAllSameTitle)
                .HasMaxLength(1)
                .HasColumnName("RES_ALL_SAME_TITLE");
            entity.Property(e => e.ResBorAddrNo).HasColumnName("RES_BOR_ADDR_NO");
            entity.Property(e => e.ResBorNo)
                .HasMaxLength(75)
                .HasColumnName("RES_BOR_NO");
            entity.Property(e => e.ResCollLoc)
                .HasMaxLength(20)
                .HasColumnName("RES_COLL_LOC");
            entity.Property(e => e.ResDate)
                .HasColumnType("datetime")
                .HasColumnName("RES_DATE");
            entity.Property(e => e.ResExpiry)
                .HasColumnType("datetime")
                .HasColumnName("RES_EXPIRY");
            entity.Property(e => e.ResFutureRes)
                .HasMaxLength(1)
                .HasColumnName("RES_FUTURE_RES");
            entity.Property(e => e.ResNotifyDate)
                .HasColumnType("datetime")
                .HasColumnName("RES_NOTIFY_DATE");
            entity.Property(e => e.ResNumber).HasColumnName("RES_NUMBER");
            entity.Property(e => e.ResPlacedLoc)
                .HasMaxLength(20)
                .HasColumnName("RES_PLACED_LOC");
            entity.Property(e => e.ResPriority).HasColumnName("RES_PRIORITY");
            entity.Property(e => e.ResReqFrom)
                .HasColumnType("datetime")
                .HasColumnName("RES_REQ_FROM");
            entity.Property(e => e.ResReqTo)
                .HasColumnType("datetime")
                .HasColumnName("RES_REQ_TO");
            entity.Property(e => e.ResStatus)
                .HasMaxLength(15)
                .HasColumnName("RES_STATUS");
            entity.Property(e => e.ResStkItem)
                .HasMaxLength(25)
                .HasColumnName("RES_STK_ITEM");
            entity.Property(e => e.ResWhoPlaced)
                .HasMaxLength(25)
                .HasColumnName("RES_WHO_PLACED");
        });

        modelBuilder.Entity<RetentionCode>(entity =>
        {
            entity.HasKey(e => e.RetId).HasName("PK_RETENTION_CODES_1");

            entity.ToTable("RETENTION_CODES");

            entity.Property(e => e.RetId).HasColumnName("RET_ID");
            entity.Property(e => e.Indefinite)
                .HasMaxLength(3)
                .HasColumnName("INDEFINITE");
            entity.Property(e => e.LenDays).HasColumnName("LEN_DAYS");
            entity.Property(e => e.LenMonths).HasColumnName("LEN_MONTHS");
            entity.Property(e => e.LenYears).HasColumnName("LEN_YEARS");
            entity.Property(e => e.RetActive)
                .HasMaxLength(3)
                .HasColumnName("RET_ACTIVE");
            entity.Property(e => e.RetCode)
                .HasMaxLength(50)
                .HasColumnName("RET_CODE");
            entity.Property(e => e.RetCreated)
                .HasColumnType("datetime")
                .HasColumnName("RET_CREATED");
            entity.Property(e => e.RetDesc)
                .HasMaxLength(250)
                .HasColumnName("RET_DESC");
            entity.Property(e => e.RetPrefix)
                .HasMaxLength(5)
                .HasColumnName("RET_PREFIX");
        });

        modelBuilder.Entity<RotaScheduleHeader>(entity =>
        {
            entity.HasKey(e => e.ShId).HasName("PK_ROTA_SCHOOLGROUP_SCHEDULE_HEADER");

            entity.ToTable("ROTA_SCHEDULE_HEADER");

            entity.HasIndex(e => new { e.ShLibGroup, e.ShName }, "UQ_ROTA_SCHOOLGROUP_SCHEDULE_HEADER_LIB_GROUP_NAME").IsUnique();

            entity.HasIndex(e => new { e.ShLibGroup, e.ShId }, "UQ_ROTA_SCHOOLGROUP_SCHEDULE_LIB_GROUP").IsUnique();

            entity.Property(e => e.ShId).HasColumnName("SH_ID");
            entity.Property(e => e.SgId).HasColumnName("SG_ID");
            entity.Property(e => e.ShDeleted).HasColumnName("SH_DELETED");
            entity.Property(e => e.ShDescr)
                .HasMaxLength(500)
                .HasColumnName("SH_DESCR");
            entity.Property(e => e.ShEndDate).HasColumnName("SH_END_DATE");
            entity.Property(e => e.ShLibGroup)
                .HasMaxLength(30)
                .HasColumnName("SH_LIB_GROUP");
            entity.Property(e => e.ShName)
                .HasMaxLength(30)
                .HasColumnName("SH_NAME");
            entity.Property(e => e.ShStartDate).HasColumnName("SH_START_DATE");

            entity.HasOne(d => d.RotaSchoolGroup).WithMany(p => p.RotaScheduleHeaders)
                .HasPrincipalKey(p => new { p.SgLibGroup, p.SgId })
                .HasForeignKey(d => new { d.ShLibGroup, d.SgId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ROTA_SCHOOLGROUP_SCHEDULE_SCHOOLGRP");
        });

        modelBuilder.Entity<RotaScheduleItem>(entity =>
        {
            entity.HasKey(e => e.SiId).HasName("PK_ROTA_CALENDAR");

            entity.ToTable("ROTA_SCHEDULE_ITEM");

            entity.Property(e => e.SiId).HasColumnName("SI_ID");
            entity.Property(e => e.RsComments)
                .HasMaxLength(500)
                .HasColumnName("RS_COMMENTS");
            entity.Property(e => e.RsDate).HasColumnName("RS_DATE");
            entity.Property(e => e.RsLibGroup)
                .HasMaxLength(30)
                .HasColumnName("RS_LIB_GROUP");
            entity.Property(e => e.RsTimeFrom).HasColumnName("RS_TIME_FROM");
            entity.Property(e => e.RsTimeTo).HasColumnName("RS_TIME_TO");
            entity.Property(e => e.ShId).HasColumnName("SH_ID");

            entity.HasOne(d => d.RotaScheduleHeader).WithMany(p => p.RotaScheduleItems)
                .HasPrincipalKey(p => new { p.ShLibGroup, p.ShId })
                .HasForeignKey(d => new { d.RsLibGroup, d.ShId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ROTA_SCHEDULE_ITEM_ROTA_SCHOOL_GROUP");
        });

        modelBuilder.Entity<RotaScheduleItemHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ROTA_SCHEDULE_ITEM_HISTORY");

            entity.Property(e => e.DelDate).HasColumnName("DEL_DATE");
            entity.Property(e => e.DelUser)
                .HasMaxLength(100)
                .HasColumnName("DEL_USER");
            entity.Property(e => e.RsComments)
                .HasMaxLength(500)
                .HasColumnName("RS_COMMENTS");
            entity.Property(e => e.RsDate).HasColumnName("RS_DATE");
            entity.Property(e => e.RsLibGroup)
                .HasMaxLength(30)
                .HasColumnName("RS_LIB_GROUP");
            entity.Property(e => e.RsTimeFrom).HasColumnName("RS_TIME_FROM");
            entity.Property(e => e.RsTimeTo).HasColumnName("RS_TIME_TO");
            entity.Property(e => e.ShId).HasColumnName("SH_ID");
            entity.Property(e => e.SiId).HasColumnName("SI_ID");
        });

        modelBuilder.Entity<RotaSchool>(entity =>
        {
            entity.HasKey(e => new { e.SgId, e.BorNo });

            entity.ToTable("ROTA_SCHOOL");

            entity.Property(e => e.SgId).HasColumnName("SG_ID");
            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");
            entity.Property(e => e.RsComments)
                .HasMaxLength(500)
                .HasColumnName("RS_COMMENTS");
            entity.Property(e => e.RsOrder).HasColumnName("RS_ORDER");

            entity.HasOne(d => d.Sg).WithMany(p => p.RotaSchools)
                .HasForeignKey(d => d.SgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ROTA_SCHOOL_ROTA_SCHOOL_GROUP");
        });

        modelBuilder.Entity<RotaSchoolGroup>(entity =>
        {
            entity.HasKey(e => e.SgId);

            entity.ToTable("ROTA_SCHOOL_GROUP");

            entity.HasIndex(e => new { e.SgLibGroup, e.SgName }, "UQ_ROTA_SCHOOL_GROUP").IsUnique();

            entity.HasIndex(e => new { e.SgLibGroup, e.SgId }, "UQ_ROTA_SCHOOL_GROUP_ID").IsUnique();

            entity.Property(e => e.SgId).HasColumnName("SG_ID");
            entity.Property(e => e.SgDeleted).HasColumnName("SG_DELETED");
            entity.Property(e => e.SgDescr)
                .HasMaxLength(500)
                .HasColumnName("SG_DESCR");
            entity.Property(e => e.SgLibGroup)
                .HasMaxLength(30)
                .HasColumnName("SG_LIB_GROUP");
            entity.Property(e => e.SgName)
                .HasMaxLength(30)
                .HasColumnName("SG_NAME");
        });

        modelBuilder.Entity<RotaSchoolHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ROTA_SCHOOL_HISTORY");

            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");
            entity.Property(e => e.DelDate).HasColumnName("DEL_DATE");
            entity.Property(e => e.DelUser)
                .HasMaxLength(100)
                .HasColumnName("DEL_USER");
            entity.Property(e => e.RsComments)
                .HasMaxLength(500)
                .HasColumnName("RS_COMMENTS");
            entity.Property(e => e.RsOrder).HasColumnName("RS_ORDER");
            entity.Property(e => e.SgId).HasColumnName("SG_ID");
        });

        modelBuilder.Entity<RotaVehicle>(entity =>
        {
            entity.HasKey(e => e.RvId);

            entity.ToTable("ROTA_VEHICLE");

            entity.HasIndex(e => new { e.RvLibGroup, e.RvName }, "UQ_ROTA_VEHICLE").IsUnique();

            entity.HasIndex(e => new { e.RvLibGroup, e.RvId }, "UQ_ROTA_VEHICLE_ID").IsUnique();

            entity.Property(e => e.RvId).HasColumnName("RV_ID");
            entity.Property(e => e.RvDeleted).HasColumnName("RV_DELETED");
            entity.Property(e => e.RvDescr)
                .HasMaxLength(500)
                .HasColumnName("RV_DESCR");
            entity.Property(e => e.RvLibGroup)
                .HasMaxLength(30)
                .HasColumnName("RV_LIB_GROUP");
            entity.Property(e => e.RvName)
                .HasMaxLength(30)
                .HasColumnName("RV_NAME");
            entity.Property(e => e.RvWeight)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("RV_WEIGHT");
        });

        modelBuilder.Entity<RotaVehicleSchedule>(entity =>
        {
            entity.HasKey(e => new { e.RvId, e.ShId });

            entity.ToTable("ROTA_VEHICLE_SCHEDULE");

            entity.Property(e => e.RvId).HasColumnName("RV_ID");
            entity.Property(e => e.ShId).HasColumnName("SH_ID");
            entity.Property(e => e.RvsComments)
                .HasMaxLength(500)
                .HasColumnName("RVS_COMMENTS");
            entity.Property(e => e.RvsLibGroup)
                .HasMaxLength(30)
                .HasColumnName("RVS_LIB_GROUP");

            entity.HasOne(d => d.RotaVehicle).WithMany(p => p.RotaVehicleSchedules)
                .HasPrincipalKey(p => new { p.RvLibGroup, p.RvId })
                .HasForeignKey(d => new { d.RvsLibGroup, d.RvId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ROTA_VEHICLE_SCHEDULE_ROTA_VEHICLE");

            entity.HasOne(d => d.RotaScheduleHeader).WithMany(p => p.RotaVehicleSchedules)
                .HasPrincipalKey(p => new { p.ShLibGroup, p.ShId })
                .HasForeignKey(d => new { d.RvsLibGroup, d.ShId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ROTA_VEHICLE_SCHEDULE_ROTA_SCHEDULE_HEADER");
        });

        modelBuilder.Entity<RotaVehicleScheduleHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ROTA_VEHICLE_SCHEDULE_HISTORY");

            entity.Property(e => e.DelDate).HasColumnName("DEL_DATE");
            entity.Property(e => e.DelUser)
                .HasMaxLength(100)
                .HasColumnName("DEL_USER");
            entity.Property(e => e.RvId).HasColumnName("RV_ID");
            entity.Property(e => e.RvsComments)
                .HasMaxLength(500)
                .HasColumnName("RVS_COMMENTS");
            entity.Property(e => e.RvsLibGroup)
                .HasMaxLength(30)
                .HasColumnName("RVS_LIB_GROUP");
            entity.Property(e => e.ShId).HasColumnName("SH_ID");
        });

        modelBuilder.Entity<SalesItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SALES_ITEMS");

            entity.Property(e => e.FinTranNo).HasColumnName("FIN_TRAN_NO");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATED");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("PRICE");
            entity.Property(e => e.SalesUniqueNo).HasColumnName("SALES_UNIQUE_NO");
            entity.Property(e => e.StkDesc)
                .HasMaxLength(500)
                .HasColumnName("STK_DESC");
            entity.Property(e => e.StkLocation)
                .HasMaxLength(20)
                .HasColumnName("STK_LOCATION");
            entity.Property(e => e.StkUniqueNo).HasColumnName("STK_UNIQUE_NO");
        });

        modelBuilder.Entity<Service>(entity =>
        {
            entity.HasKey(e => e.ServicesId).HasName("PK_dbo.SERVICES");

            entity.ToTable("SERVICES");

            entity.Property(e => e.ServicesId).HasColumnName("SERVICES_ID");
            entity.Property(e => e.DisplayOrder).HasColumnName("DISPLAY_ORDER");
            entity.Property(e => e.ServiceNameId).HasColumnName("SERVICE_NAME_ID");
            entity.Property(e => e.SurveyId).HasColumnName("SURVEY_ID");

            entity.HasOne(d => d.ServiceName).WithMany(p => p.Services)
                .HasForeignKey(d => d.ServiceNameId)
                .HasConstraintName("FK_dbo.SERVICES_dbo.SERVICENAMES_SERVICE_NAME_ID");
        });

        modelBuilder.Entity<ServiceName>(entity =>
        {
            entity.HasKey(e => e.ServiceNameId).HasName("PK_dbo.SERVICE_NAMES");

            entity.ToTable("SERVICE_NAMES");

            entity.Property(e => e.ServiceNameId).HasColumnName("SERVICE_NAME_ID");
            entity.Property(e => e.Description)
                .HasMaxLength(450)
                .HasColumnName("DESCRIPTION");
        });

        modelBuilder.Entity<SmsMessage>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SMS_MESSAGE");

            entity.Property(e => e.BorBarNo)
                .HasMaxLength(75)
                .HasColumnName("BOR_BAR_NO");
            entity.Property(e => e.SmsMessage1)
                .HasMaxLength(160)
                .HasColumnName("SMS_MESSAGE");
        });

        modelBuilder.Entity<SrSystab>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SR_SYSTAB");

            entity.Property(e => e.SrId).HasColumnName("SR_ID");
        });

        modelBuilder.Entity<StatsCode>(entity =>
        {
            entity.HasKey(e => e.StatsType);

            entity.ToTable("STATS_CODES");

            entity.Property(e => e.StatsType)
                .ValueGeneratedNever()
                .HasColumnName("STATS_TYPE");
            entity.Property(e => e.StatsAreaCd)
                .HasMaxLength(1)
                .HasColumnName("STATS_AREA_CD");
            entity.Property(e => e.StatsBorrower)
                .HasMaxLength(1)
                .HasColumnName("STATS_BORROWER");
            entity.Property(e => e.StatsClass)
                .HasMaxLength(1)
                .HasColumnName("STATS_CLASS");
            entity.Property(e => e.StatsCount)
                .HasMaxLength(1)
                .HasColumnName("STATS_COUNT");
            entity.Property(e => e.StatsDay)
                .HasMaxLength(1)
                .HasColumnName("STATS_DAY");
            entity.Property(e => e.StatsDescription)
                .HasMaxLength(50)
                .HasColumnName("STATS_DESCRIPTION");
            entity.Property(e => e.StatsForm)
                .HasMaxLength(1)
                .HasColumnName("STATS_FORM");
            entity.Property(e => e.StatsGroup)
                .HasMaxLength(1)
                .HasColumnName("STATS_GROUP");
            entity.Property(e => e.StatsHour)
                .HasMaxLength(1)
                .HasColumnName("STATS_HOUR");
            entity.Property(e => e.StatsLocation)
                .HasMaxLength(1)
                .HasColumnName("STATS_LOCATION");
            entity.Property(e => e.StatsMoney)
                .HasMaxLength(1)
                .HasColumnName("STATS_MONEY");
            entity.Property(e => e.StatsMonth)
                .HasMaxLength(1)
                .HasColumnName("STATS_MONTH");
            entity.Property(e => e.StatsStkCode)
                .HasMaxLength(1)
                .HasColumnName("STATS_STK_CODE");
            entity.Property(e => e.StatsSuburb)
                .HasMaxLength(1)
                .HasColumnName("STATS_SUBURB");
            entity.Property(e => e.StatsWard)
                .HasMaxLength(1)
                .HasColumnName("STATS_WARD");
            entity.Property(e => e.StatsYear)
                .HasMaxLength(1)
                .HasColumnName("STATS_YEAR");
        });

        modelBuilder.Entity<StatsCodesOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("STATS_CODES_OLD");

            entity.HasIndex(e => e.StatsType, "ST_CODEX");

            entity.Property(e => e.StatsAreaCd)
                .HasMaxLength(1)
                .HasColumnName("STATS_AREA_CD");
            entity.Property(e => e.StatsBorrower)
                .HasMaxLength(1)
                .HasColumnName("STATS_BORROWER");
            entity.Property(e => e.StatsClass)
                .HasMaxLength(1)
                .HasColumnName("STATS_CLASS");
            entity.Property(e => e.StatsCount)
                .HasMaxLength(1)
                .HasColumnName("STATS_COUNT");
            entity.Property(e => e.StatsDay)
                .HasMaxLength(1)
                .HasColumnName("STATS_DAY");
            entity.Property(e => e.StatsDescription)
                .HasMaxLength(50)
                .HasColumnName("STATS_DESCRIPTION");
            entity.Property(e => e.StatsForm)
                .HasMaxLength(1)
                .HasColumnName("STATS_FORM");
            entity.Property(e => e.StatsGroup)
                .HasMaxLength(1)
                .HasColumnName("STATS_GROUP");
            entity.Property(e => e.StatsHour)
                .HasMaxLength(1)
                .HasColumnName("STATS_HOUR");
            entity.Property(e => e.StatsLocation)
                .HasMaxLength(1)
                .HasColumnName("STATS_LOCATION");
            entity.Property(e => e.StatsMoney)
                .HasMaxLength(1)
                .HasColumnName("STATS_MONEY");
            entity.Property(e => e.StatsMonth)
                .HasMaxLength(1)
                .HasColumnName("STATS_MONTH");
            entity.Property(e => e.StatsStkCode)
                .HasMaxLength(1)
                .HasColumnName("STATS_STK_CODE");
            entity.Property(e => e.StatsSuburb)
                .HasMaxLength(1)
                .HasColumnName("STATS_SUBURB");
            entity.Property(e => e.StatsType).HasColumnName("STATS_TYPE");
            entity.Property(e => e.StatsWard)
                .HasMaxLength(1)
                .HasColumnName("STATS_WARD");
            entity.Property(e => e.StatsYear)
                .HasMaxLength(1)
                .HasColumnName("STATS_YEAR");
        });

        modelBuilder.Entity<StatsCodesTranslation>(entity =>
        {
            entity.HasKey(e => new { e.Lcid, e.StatsType });

            entity.ToTable("STATS_CODES_TRANSLATION");

            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.StatsType).HasColumnName("STATS_TYPE");
            entity.Property(e => e.StatsDescription)
                .HasMaxLength(50)
                .HasColumnName("STATS_DESCRIPTION");

            entity.HasOne(d => d.StatsTypeNavigation).WithMany(p => p.StatsCodesTranslations)
                .HasForeignKey(d => d.StatsType)
                .HasConstraintName("FK_STATS_CODES_STATS_CODES_TRANSLATION");
        });

        modelBuilder.Entity<StkBookingEvent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("STK_BOOKING_EVENT");

            entity.Property(e => e.Allday).HasColumnName("ALLDAY");
            entity.Property(e => e.Anticipatedgrade)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ANTICIPATEDGRADE");
            entity.Property(e => e.ArrivedDateime)
                .HasColumnType("datetime")
                .HasColumnName("ARRIVED_DATEIME");
            entity.Property(e => e.BorBarNo)
                .HasMaxLength(75)
                .HasColumnName("BOR_BAR_NO");
            entity.Property(e => e.CancellationFee)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("CANCELLATION_FEE");
            entity.Property(e => e.DepartureDateime)
                .HasColumnType("datetime")
                .HasColumnName("DEPARTURE_DATEIME");
            entity.Property(e => e.EndDatetime)
                .HasColumnType("datetime")
                .HasColumnName("END_DATETIME");
            entity.Property(e => e.EventBorNo).HasColumnName("EVENT_BOR_NO");
            entity.Property(e => e.EventType)
                .HasMaxLength(3)
                .HasColumnName("EVENT_TYPE");
            entity.Property(e => e.Fee)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("FEE");
            entity.Property(e => e.Isprivate).HasColumnName("ISPRIVATE");
            entity.Property(e => e.Notes)
                .IsUnicode(false)
                .HasColumnName("NOTES");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.StartDatetime)
                .HasColumnType("datetime")
                .HasColumnName("START_DATETIME");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.StkItem)
                .HasMaxLength(25)
                .HasColumnName("STK_ITEM");
            entity.Property(e => e.UniqueEventId)
                .ValueGeneratedOnAdd()
                .HasColumnName("UNIQUE_EVENT_ID");
            entity.Property(e => e.UniqueItemNo).HasColumnName("UNIQUE_ITEM_NO");
            entity.Property(e => e.UnitPrice).HasColumnName("UNIT_PRICE");
        });

        modelBuilder.Entity<StkCheckMiss>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("STK_CHECK_MISS");

            entity.Property(e => e.StkDate)
                .HasColumnType("datetime")
                .HasColumnName("STK_DATE");
            entity.Property(e => e.StkItemNo)
                .HasMaxLength(25)
                .HasColumnName("STK_ITEM_NO");
        });

        modelBuilder.Entity<StkEventAttendance>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("STK_EVENT_ATTENDANCE");

            entity.Property(e => e.Anticipatedgrade)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ANTICIPATEDGRADE");
            entity.Property(e => e.BorBarNo)
                .HasMaxLength(70)
                .HasColumnName("BOR_BAR_NO");
            entity.Property(e => e.DateOfEvent).HasColumnName("DATE_OF_EVENT");
            entity.Property(e => e.Notes)
                .IsUnicode(false)
                .HasColumnName("NOTES");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.StkItemNo)
                .HasMaxLength(50)
                .HasColumnName("STK_ITEM_NO");
        });

        modelBuilder.Entity<StkFormsCopyrightNotice>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("STK_FORMS_COPYRIGHT_NOTICE");

            entity.Property(e => e.CopyrightNoticeId).HasColumnName("COPYRIGHT_NOTICE_ID");
            entity.Property(e => e.LlCode)
                .HasMaxLength(50)
                .HasColumnName("LL_CODE");
            entity.Property(e => e.LlGroup)
                .HasMaxLength(50)
                .HasColumnName("LL_GROUP");
            entity.Property(e => e.StkForm)
                .HasMaxLength(50)
                .HasColumnName("STK_FORM");
        });

        modelBuilder.Entity<StkHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("STK_HISTORY");

            entity.HasIndex(e => e.ShBorNo, "SHBOR_NOX");

            entity.HasIndex(e => new { e.ShStkItemNo, e.ShBorNo }, "SHSTKBORX");

            entity.HasIndex(e => new { e.ShDate, e.ShStkItemNo }, "SHSTKITEM_DTNOX");

            entity.HasIndex(e => e.ShStkItemNo, "SHSTKITEM_NOX");

            entity.HasIndex(e => e.ShResNo, "SH_RESNOX");

            entity.Property(e => e.ShBorNo)
                .HasMaxLength(75)
                .HasColumnName("SH_BOR_NO");
            entity.Property(e => e.ShComments)
                .HasMaxLength(300)
                .HasColumnName("SH_COMMENTS");
            entity.Property(e => e.ShDate)
                .HasColumnType("datetime")
                .HasColumnName("SH_DATE");
            entity.Property(e => e.ShResNo).HasColumnName("SH_RES_NO");
            entity.Property(e => e.ShStkItemNo)
                .HasMaxLength(25)
                .HasColumnName("SH_STK_ITEM_NO");
            entity.Property(e => e.ShType)
                .HasMaxLength(11)
                .HasColumnName("SH_TYPE");
            entity.Property(e => e.ShValue)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("SH_VALUE");
        });

        modelBuilder.Entity<StkIll>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("STK_ILL");

            entity.Property(e => e.StiBorBarNo)
                .HasMaxLength(75)
                .HasColumnName("STI_BOR_BAR_NO");
            entity.Property(e => e.StiBorName)
                .HasMaxLength(30)
                .HasColumnName("STI_BOR_NAME");
            entity.Property(e => e.StiColl)
                .HasMaxLength(20)
                .HasColumnName("STI_COLL");
            entity.Property(e => e.StiCollDesc)
                .HasMaxLength(30)
                .HasColumnName("STI_COLL_DESC");
            entity.Property(e => e.StiComment)
                .HasMaxLength(100)
                .HasColumnName("STI_COMMENT");
            entity.Property(e => e.StiDatelast)
                .HasColumnType("datetime")
                .HasColumnName("STI_DATELAST");
            entity.Property(e => e.StiIllsCode)
                .HasMaxLength(20)
                .HasColumnName("STI_ILLS_CODE");
            entity.Property(e => e.StiIllsCost)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("STI_ILLS_COST");
            entity.Property(e => e.StiItemNo)
                .HasMaxLength(25)
                .HasColumnName("STI_ITEM_NO");
            entity.Property(e => e.StiLocCode)
                .HasMaxLength(20)
                .HasColumnName("STI_LOC_CODE");
            entity.Property(e => e.StiLocDesc)
                .HasMaxLength(20)
                .HasColumnName("STI_LOC_DESC");
            entity.Property(e => e.StiOper)
                .HasMaxLength(20)
                .HasColumnName("STI_OPER");
            entity.Property(e => e.StiStatus)
                .HasMaxLength(20)
                .HasColumnName("STI_STATUS");
            entity.Property(e => e.StiStatusdate)
                .HasColumnType("datetime")
                .HasColumnName("STI_STATUSDATE");
            entity.Property(e => e.StiSupp1Code)
                .HasMaxLength(20)
                .HasColumnName("STI_SUPP1_CODE");
            entity.Property(e => e.StiSupp2Code)
                .HasMaxLength(20)
                .HasColumnName("STI_SUPP2_CODE");
            entity.Property(e => e.StiSupp3Code)
                .HasMaxLength(20)
                .HasColumnName("STI_SUPP3_CODE");
            entity.Property(e => e.StiUniqueNo).HasColumnName("STI_UNIQUE_NO");
        });

        modelBuilder.Entity<StkItem>(entity =>
        {
            entity.HasKey(e => e.StkItemNo);

            entity.ToTable("STK_ITEM");

            entity.HasIndex(e => new { e.StkLocPerm, e.StkItemNo }, "IX_STK_ITEM_LINES").HasFillFactor(80);

            entity.HasIndex(e => e.StkKey1, "STKLN1X");

            entity.HasIndex(e => e.StkKey2, "STKLN2X");

            entity.HasIndex(e => e.StkKey3, "STKLN3X");

            entity.HasIndex(e => e.StkKey4, "STKLN4X");

            entity.HasIndex(e => e.StkKey5, "STKLN5X");

            entity.HasIndex(e => e.StkKey6, "STKLN6X");

            entity.HasIndex(e => e.StkLocPerm, "STKLOCX");

            entity.HasIndex(e => e.StkLocPerm, "STKLOCX_");

            entity.HasIndex(e => e.StkBorBarNo, "STK_BORBARNOX");

            entity.HasIndex(e => e.StkCatRef, "STK_CATREFX");

            entity.HasIndex(e => e.StkDateAcc, "STK_DATE_ACCX");

            entity.HasIndex(e => e.StkDateDue, "STK_DATE_DUEX");

            entity.HasIndex(e => e.StkForm, "STK_FORMX");

            entity.HasIndex(e => e.StkIssDue, "STK_ISSDUEX");

            entity.HasIndex(e => e.StkItemNo, "STK_ITEMNOX").IsUnique();

            entity.HasIndex(e => e.StkRelatedNo, "STK_RELATEDNOX");

            entity.HasIndex(e => e.StkStatsCode, "STK_STATX");

            entity.HasIndex(e => e.UniqueItemNo, "STK_UNOX").IsUnique();

            entity.Property(e => e.StkItemNo)
                .HasMaxLength(25)
                .HasColumnName("STK_ITEM_NO");
            entity.Property(e => e.CnPrefix)
                .HasMaxLength(5)
                .HasColumnName("CN_PREFIX");
            entity.Property(e => e.CnSuffix).HasColumnName("CN_SUFFIX");
            entity.Property(e => e.DestructionDate)
                .HasColumnType("datetime")
                .HasColumnName("DESTRUCTION_DATE");
            entity.Property(e => e.RetId).HasColumnName("RET_ID");
            entity.Property(e => e.StkAvgRating).HasColumnName("STK_AVG_RATING");
            entity.Property(e => e.StkBorBarNo)
                .HasMaxLength(75)
                .HasColumnName("STK_BOR_BAR_NO");
            entity.Property(e => e.StkBorName)
                .HasMaxLength(20)
                .HasColumnName("STK_BOR_NAME");
            entity.Property(e => e.StkCallSet)
                .HasMaxLength(6)
                .HasColumnName("STK_CALL_SET");
            entity.Property(e => e.StkCatRef).HasColumnName("STK_CAT_REF");
            entity.Property(e => e.StkClass)
                .HasMaxLength(20)
                .HasColumnName("STK_CLASS");
            entity.Property(e => e.StkConvertValue)
                .HasMaxLength(50)
                .HasColumnName("STK_CONVERT_VALUE");
            entity.Property(e => e.StkCost)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("STK_COST");
            entity.Property(e => e.StkDateAcc)
                .HasColumnType("datetime")
                .HasColumnName("STK_DATE_ACC");
            entity.Property(e => e.StkDateDue)
                .HasColumnType("datetime")
                .HasColumnName("STK_DATE_DUE");
            entity.Property(e => e.StkDateRecd)
                .HasColumnType("datetime")
                .HasColumnName("STK_DATE_RECD");
            entity.Property(e => e.StkDatetime)
                .HasColumnType("datetime")
                .HasColumnName("STK_DATETIME");
            entity.Property(e => e.StkDescription)
                .HasMaxLength(250)
                .HasColumnName("STK_DESCRIPTION");
            entity.Property(e => e.StkEdition)
                .HasMaxLength(25)
                .HasColumnName("STK_EDITION");
            entity.Property(e => e.StkForLoan)
                .HasMaxLength(1)
                .HasColumnName("STK_FOR_LOAN");
            entity.Property(e => e.StkForm)
                .HasMaxLength(3)
                .HasColumnName("STK_FORM");
            entity.Property(e => e.StkIllDue)
                .HasColumnType("datetime")
                .HasColumnName("STK_ILL_DUE");
            entity.Property(e => e.StkIllRenew)
                .HasMaxLength(1)
                .HasColumnName("STK_ILL_RENEW");
            entity.Property(e => e.StkIllSupp)
                .HasMaxLength(10)
                .HasColumnName("STK_ILL_SUPP");
            entity.Property(e => e.StkIsOnLoan)
                .HasMaxLength(1)
                .HasColumnName("STK_IS_ON_LOAN");
            entity.Property(e => e.StkIsOnOrder)
                .HasMaxLength(1)
                .HasColumnName("STK_IS_ON_ORDER");
            entity.Property(e => e.StkIsReserved).HasColumnName("STK_IS_RESERVED");
            entity.Property(e => e.StkIssDate)
                .HasColumnType("datetime")
                .HasColumnName("STK_ISS_DATE");
            entity.Property(e => e.StkIssDue)
                .HasColumnType("datetime")
                .HasColumnName("STK_ISS_DUE");
            entity.Property(e => e.StkIssLoc)
                .HasMaxLength(20)
                .HasColumnName("STK_ISS_LOC");
            entity.Property(e => e.StkIssRenewed).HasColumnName("STK_ISS_RENEWED");
            entity.Property(e => e.StkIssueAddrNo).HasColumnName("STK_ISSUE_ADDR_NO");
            entity.Property(e => e.StkIssueType)
                .HasMaxLength(1)
                .HasColumnName("STK_ISSUE_TYPE");
            entity.Property(e => e.StkItemOrigin)
                .HasMaxLength(3)
                .HasColumnName("STK_ITEM_ORIGIN");
            entity.Property(e => e.StkItemType)
                .HasMaxLength(1)
                .HasColumnName("STK_ITEM_TYPE");
            entity.Property(e => e.StkKey1)
                .HasMaxLength(200)
                .HasColumnName("STK_KEY1");
            entity.Property(e => e.StkKey2)
                .HasMaxLength(200)
                .HasColumnName("STK_KEY2");
            entity.Property(e => e.StkKey3)
                .HasMaxLength(200)
                .HasColumnName("STK_KEY3");
            entity.Property(e => e.StkKey4)
                .HasMaxLength(200)
                .HasColumnName("STK_KEY4");
            entity.Property(e => e.StkKey5)
                .HasMaxLength(200)
                .HasColumnName("STK_KEY5");
            entity.Property(e => e.StkKey6)
                .HasMaxLength(200)
                .HasColumnName("STK_KEY6");
            entity.Property(e => e.StkLastDep)
                .HasColumnType("datetime")
                .HasColumnName("STK_LAST_DEP");
            entity.Property(e => e.StkLastResno).HasColumnName("STK_LAST_RESNO");
            entity.Property(e => e.StkLastTake)
                .HasColumnType("datetime")
                .HasColumnName("STK_LAST_TAKE");
            entity.Property(e => e.StkLastactive)
                .HasColumnType("datetime")
                .HasColumnName("STK_LASTACTIVE");
            entity.Property(e => e.StkLibGroup)
                .HasMaxLength(30)
                .HasColumnName("STK_LIB_GROUP");
            entity.Property(e => e.StkLine1)
                .HasMaxLength(250)
                .HasColumnName("STK_LINE1");
            entity.Property(e => e.StkLine2)
                .HasMaxLength(250)
                .HasColumnName("STK_LINE2");
            entity.Property(e => e.StkLine3)
                .HasMaxLength(250)
                .HasColumnName("STK_LINE3");
            entity.Property(e => e.StkLine4)
                .HasMaxLength(250)
                .HasColumnName("STK_LINE4");
            entity.Property(e => e.StkLine5)
                .HasMaxLength(250)
                .HasColumnName("STK_LINE5");
            entity.Property(e => e.StkLine6)
                .HasMaxLength(250)
                .HasColumnName("STK_LINE6");
            entity.Property(e => e.StkLoanType)
                .HasMaxLength(3)
                .HasColumnName("STK_LOAN_TYPE");
            entity.Property(e => e.StkLocFloor)
                .HasMaxLength(40)
                .HasColumnName("STK_LOC_FLOOR");
            entity.Property(e => e.StkLocFloorId).HasColumnName("STK_LOC_FLOOR_ID");
            entity.Property(e => e.StkLocPerm)
                .HasMaxLength(40)
                .HasColumnName("STK_LOC_PERM");
            entity.Property(e => e.StkLocTemp)
                .HasMaxLength(40)
                .HasColumnName("STK_LOC_TEMP");
            entity.Property(e => e.StkOpacShow)
                .HasMaxLength(1)
                .HasColumnName("STK_OPAC_SHOW");
            entity.Property(e => e.StkOper)
                .HasMaxLength(25)
                .HasColumnName("STK_OPER");
            entity.Property(e => e.StkOperAlert)
                .HasMaxLength(1)
                .HasColumnName("STK_OPER_ALERT");
            entity.Property(e => e.StkOrigCost)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("STK_ORIG_COST");
            entity.Property(e => e.StkOtherRef)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STK_OTHER_REF");
            entity.Property(e => e.StkProcess)
                .HasMaxLength(20)
                .HasColumnName("STK_PROCESS");
            entity.Property(e => e.StkProcessDate)
                .HasColumnType("datetime")
                .HasColumnName("STK_PROCESS_DATE");
            entity.Property(e => e.StkRecallDate)
                .HasColumnType("datetime")
                .HasColumnName("STK_RECALL_DATE");
            entity.Property(e => e.StkRelatedNo).HasColumnName("STK_RELATED_NO");
            entity.Property(e => e.StkRotationDate)
                .HasColumnType("datetime")
                .HasColumnName("STK_ROTATION_DATE");
            entity.Property(e => e.StkRotationLoCode)
                .HasMaxLength(20)
                .HasColumnName("STK_ROTATION_LO_CODE");
            entity.Property(e => e.StkRotationPlanId).HasColumnName("STK_ROTATION_PLAN_ID");
            entity.Property(e => e.StkRotationSeqNo).HasColumnName("STK_ROTATION_SEQ_NO");
            entity.Property(e => e.StkRotationTransit)
                .HasMaxLength(1)
                .HasColumnName("STK_ROTATION_TRANSIT");
            entity.Property(e => e.StkStatsCode)
                .HasMaxLength(6)
                .HasColumnName("STK_STATS_CODE");
            entity.Property(e => e.StkStockTake)
                .HasMaxLength(1)
                .HasColumnName("STK_STOCK_TAKE");
            entity.Property(e => e.StkTimesBorpr).HasColumnName("STK_TIMES_BORPR");
            entity.Property(e => e.StkTimesBorrowed).HasColumnName("STK_TIMES_BORROWED");
            entity.Property(e => e.StkTimesRenewed).HasColumnName("STK_TIMES_RENEWED");
            entity.Property(e => e.StkTimesRenpr).HasColumnName("STK_TIMES_RENPR");
            entity.Property(e => e.StkTimesReserved).HasColumnName("STK_TIMES_RESERVED");
            entity.Property(e => e.StkTimesResvpr).HasColumnName("STK_TIMES_RESVPR");
            entity.Property(e => e.StkVolume)
                .HasMaxLength(25)
                .HasColumnName("STK_VOLUME");
            entity.Property(e => e.TeamId).HasColumnName("TEAM_ID");
            entity.Property(e => e.UniqueItemNo).HasColumnName("UNIQUE_ITEM_NO");
        });

        modelBuilder.Entity<StkItem880>(entity =>
        {
            entity.HasKey(e => e.UniqueItemNo).HasName("STK_ITEM_880_pk");

            entity.ToTable("STK_ITEM_880");

            entity.HasIndex(e => e.UniqueItemNo, "IX_STK_ITEM_880_LINES").HasFillFactor(80);

            entity.Property(e => e.UniqueItemNo)
                .ValueGeneratedNever()
                .HasColumnName("UNIQUE_ITEM_NO");
            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.StkCost)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("STK_COST");
            entity.Property(e => e.StkEdition)
                .HasMaxLength(25)
                .HasColumnName("STK_EDITION");
            entity.Property(e => e.StkLine1)
                .HasMaxLength(250)
                .HasColumnName("STK_LINE1");
            entity.Property(e => e.StkLine2)
                .HasMaxLength(250)
                .HasColumnName("STK_LINE2");
            entity.Property(e => e.StkLine3)
                .HasMaxLength(250)
                .HasColumnName("STK_LINE3");
            entity.Property(e => e.StkLine4)
                .HasMaxLength(250)
                .HasColumnName("STK_LINE4");
            entity.Property(e => e.StkLine5)
                .HasMaxLength(250)
                .HasColumnName("STK_LINE5");
            entity.Property(e => e.StkLine6)
                .HasMaxLength(250)
                .HasColumnName("STK_LINE6");
            entity.Property(e => e.StkVolume)
                .HasMaxLength(25)
                .HasColumnName("STK_VOLUME");
        });

        modelBuilder.Entity<StkItemDiary>(entity =>
        {
            entity.HasKey(e => e.StkItemDiaryid).HasName("PK_dbo.STK_ITEM_DIARY");

            entity.ToTable("STK_ITEM_DIARY");

            entity.Property(e => e.StkItemDiaryid).HasColumnName("STK_ITEM_DIARYID");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("DATE");
            entity.Property(e => e.EndTime).HasColumnName("END_TIME");
            entity.Property(e => e.SlotDescription)
                .HasMaxLength(100)
                .HasColumnName("SLOT_DESCRIPTION");
            entity.Property(e => e.SlotEndDate)
                .HasColumnType("datetime")
                .HasColumnName("SLOT_END_DATE");
            entity.Property(e => e.SlotStartDate)
                .HasColumnType("datetime")
                .HasColumnName("SLOT_START_DATE");
            entity.Property(e => e.StartTime).HasColumnName("START_TIME");
            entity.Property(e => e.Status)
                .HasMaxLength(3)
                .HasColumnName("STATUS");
            entity.Property(e => e.UniqueItemNo).HasColumnName("UNIQUE_ITEM_NO");
            entity.Property(e => e.WeekId).HasColumnName("WEEK_ID");
        });

        modelBuilder.Entity<StkItemPotentialCharge>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("STK_ITEM_POTENTIAL_CHARGE");

            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");
            entity.Property(e => e.BorPotentialCharge)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("BOR_POTENTIAL_CHARGE");
            entity.Property(e => e.LastUpdatedTime)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATED_TIME");
            entity.Property(e => e.UniqueItemNo).HasColumnName("UNIQUE_ITEM_NO");
        });

        modelBuilder.Entity<StkMemo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("STK_MEMOS");

            entity.HasIndex(e => e.SmStkItemNo, "SM_ITEM_NOX");

            entity.HasIndex(e => e.SmType, "SM_TYPEX");

            entity.HasIndex(e => e.SmUniqueItemNo, "STKNOX");

            entity.Property(e => e.SmBorBarNo)
                .HasMaxLength(25)
                .HasColumnName("SM_BOR_BAR_NO");
            entity.Property(e => e.SmData)
                .HasColumnType("ntext")
                .HasColumnName("SM_DATA");
            entity.Property(e => e.SmDisplay)
                .HasMaxLength(1)
                .HasColumnName("SM_DISPLAY");
            entity.Property(e => e.SmEffDate)
                .HasColumnType("datetime")
                .HasColumnName("SM_EFF_DATE");
            entity.Property(e => e.SmEndDate)
                .HasColumnType("datetime")
                .HasColumnName("SM_END_DATE");
            entity.Property(e => e.SmStkItemNo)
                .HasMaxLength(25)
                .HasColumnName("SM_STK_ITEM_NO");
            entity.Property(e => e.SmType)
                .HasMaxLength(10)
                .HasColumnName("SM_TYPE");
            entity.Property(e => e.SmUniqueItemNo).HasColumnName("SM_UNIQUE_ITEM_NO");
            entity.Property(e => e.SmUniqueNo)
                .HasMaxLength(35)
                .HasColumnName("SM_UNIQUE_NO");
        });

        modelBuilder.Entity<StkReview>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("STK_REVIEWS");

            entity.HasIndex(e => e.SrId, "SR_IDX").IsUnique();

            entity.Property(e => e.SrBorBarNo)
                .HasMaxLength(75)
                .HasColumnName("SR_BOR_BAR_NO");
            entity.Property(e => e.SrCatNo).HasColumnName("SR_CAT_NO");
            entity.Property(e => e.SrId).HasColumnName("SR_ID");
            entity.Property(e => e.SrItemRating).HasColumnName("SR_ITEM_RATING");
            entity.Property(e => e.SrReview)
                .HasColumnType("ntext")
                .HasColumnName("SR_REVIEW");
            entity.Property(e => e.SrReviewApproved)
                .HasMaxLength(1)
                .HasColumnName("SR_REVIEW_APPROVED");
            entity.Property(e => e.SrReviewDate)
                .HasColumnType("datetime")
                .HasColumnName("SR_REVIEW_DATE");
            entity.Property(e => e.SrReviewRating).HasColumnName("SR_REVIEW_RATING");
        });

        modelBuilder.Entity<StkRotationPlan>(entity =>
        {
            entity.HasKey(e => e.RotationPlanId);

            entity.ToTable("STK_ROTATION_PLAN");

            entity.HasIndex(e => e.RotationName, "IX_STK_ROTATION_PLAN_NAME").IsUnique();

            entity.Property(e => e.RotationPlanId)
                .ValueGeneratedNever()
                .HasColumnName("ROTATION_PLAN_ID");
            entity.Property(e => e.RotationName)
                .HasMaxLength(50)
                .HasColumnName("ROTATION_NAME");
        });

        modelBuilder.Entity<StkRotationPlanTran>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("STK_ROTATION_PLAN_TRANS");

            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.RotationNameTrans)
                .HasMaxLength(50)
                .HasColumnName("ROTATION_NAME_TRANS");
            entity.Property(e => e.RotationPlanId).HasColumnName("ROTATION_PLAN_ID");
        });

        modelBuilder.Entity<StkRotationSequence>(entity =>
        {
            entity.HasKey(e => new { e.RotationPlanId, e.SequenceNo, e.BorNo });

            entity.ToTable("STK_ROTATION_SEQUENCE");

            entity.HasIndex(e => new { e.RotationPlanId, e.BorNo }, "IX_STK_ROTATION_BOR_NO").IsUnique();

            entity.HasIndex(e => new { e.RotationPlanId, e.SequenceNo }, "IX_STK_ROTATION_SEQUENCE").IsUnique();

            entity.Property(e => e.RotationPlanId).HasColumnName("ROTATION_PLAN_ID");
            entity.Property(e => e.SequenceNo).HasColumnName("SEQUENCE_NO");
            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");
            entity.Property(e => e.Period).HasColumnName("PERIOD");
            entity.Property(e => e.PeriodUnit).HasColumnName("PERIOD_UNIT");
        });

        modelBuilder.Entity<StkSubscriber>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("STK_SUBSCRIBER");

            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");
            entity.Property(e => e.CreateDatetime).HasColumnName("CREATE_DATETIME");
            entity.Property(e => e.UniqueItemNo).HasColumnName("UNIQUE_ITEM_NO");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(75)
                .HasColumnName("UPDATED_BY");
        });

        modelBuilder.Entity<StockTake>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("STOCK_TAKES");

            entity.Property(e => e.StActualCount).HasColumnName("ST_ACTUAL_COUNT");
            entity.Property(e => e.StCallFrom)
                .HasMaxLength(100)
                .HasColumnName("ST_CALL_FROM");
            entity.Property(e => e.StCallTo)
                .HasMaxLength(100)
                .HasColumnName("ST_CALL_TO");
            entity.Property(e => e.StClosed)
                .HasMaxLength(1)
                .HasColumnName("ST_CLOSED");
            entity.Property(e => e.StDateEnd)
                .HasColumnType("datetime")
                .HasColumnName("ST_DATE_END");
            entity.Property(e => e.StDateStart)
                .HasColumnType("datetime")
                .HasColumnName("ST_DATE_START");
            entity.Property(e => e.StLastCall)
                .HasMaxLength(100)
                .HasColumnName("ST_LAST_CALL");
            entity.Property(e => e.StLastItem)
                .HasMaxLength(25)
                .HasColumnName("ST_LAST_ITEM");
            entity.Property(e => e.StLine).HasColumnName("ST_LINE");
            entity.Property(e => e.StTakeNo).HasColumnName("ST_TAKE_NO");
            entity.Property(e => e.StTheoryCount).HasColumnName("ST_THEORY_COUNT");
        });

        modelBuilder.Entity<SupplierResponse>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SUPPLIER_RESPONSE");

            entity.Property(e => e.SurRespCode)
                .HasMaxLength(3)
                .HasColumnName("SUR_RESP_CODE");
            entity.Property(e => e.SurRespText)
                .HasMaxLength(100)
                .HasColumnName("SUR_RESP_TEXT");
        });

        modelBuilder.Entity<SupplierStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SUPPLIER_STATUS");

            entity.Property(e => e.SutCode)
                .HasMaxLength(3)
                .HasColumnName("SUT_CODE");
            entity.Property(e => e.SutDesc)
                .HasMaxLength(100)
                .HasColumnName("SUT_DESC");
        });

        modelBuilder.Entity<Survey>(entity =>
        {
            entity.HasKey(e => e.SurveyId).HasName("PK_surveys");

            entity.ToTable("SURVEY");

            entity.Property(e => e.SurveyId)
                .ValueGeneratedNever()
                .HasColumnName("SURVEY_ID");
            entity.Property(e => e.AllowComment).HasColumnName("ALLOW_COMMENT");
            entity.Property(e => e.Allowhidedetails).HasColumnName("ALLOWHIDEDETAILS");
            entity.Property(e => e.Comment).HasColumnName("COMMENT");
            entity.Property(e => e.Completeallquestions).HasColumnName("COMPLETEALLQUESTIONS");
            entity.Property(e => e.ConclusionUrl)
                .HasMaxLength(500)
                .HasColumnName("CONCLUSION_URL");
            entity.Property(e => e.CreationDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATION_DATE");
            entity.Property(e => e.DescHtml).HasColumnName("DESC_HTML");
            entity.Property(e => e.Description).HasColumnName("DESCRIPTION");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("END_DATE");
            entity.Property(e => e.Inlinedisplay).HasColumnName("INLINEDISPLAY");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATED");
            entity.Property(e => e.Libgroup)
                .HasMaxLength(50)
                .HasColumnName("LIBGROUP");
            entity.Property(e => e.Libloc)
                .HasMaxLength(50)
                .HasColumnName("LIBLOC");
            entity.Property(e => e.MasterFlag).HasColumnName("MASTER_FLAG");
            entity.Property(e => e.MasterId).HasColumnName("MASTER_ID");
            entity.Property(e => e.Oper)
                .HasMaxLength(25)
                .HasColumnName("OPER");
            entity.Property(e => e.OperUpdated)
                .HasMaxLength(25)
                .HasColumnName("OPER_UPDATED");
            entity.Property(e => e.Position).HasColumnName("POSITION");
            entity.Property(e => e.ProposalUrl)
                .HasMaxLength(500)
                .HasColumnName("PROPOSAL_URL");
            entity.Property(e => e.Restricted).HasColumnName("RESTRICTED");
            entity.Property(e => e.Showprogressbar).HasColumnName("SHOWPROGRESSBAR");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("START_DATE");
            entity.Property(e => e.StatusId).HasColumnName("STATUS_ID");
            entity.Property(e => e.SummaryUrl)
                .HasMaxLength(500)
                .HasColumnName("SUMMARY_URL");
            entity.Property(e => e.SurveyTitle)
                .HasMaxLength(1000)
                .HasColumnName("SURVEY_TITLE");
            entity.Property(e => e.Type).HasColumnName("TYPE");

            entity.HasOne(d => d.Status).WithMany(p => p.Surveys)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_surveys_surveys_status");
        });

        modelBuilder.Entity<SurveyCategory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SURVEY_CATEGORIES");

            entity.Property(e => e.CategoryDesc)
                .HasMaxLength(1000)
                .HasColumnName("CATEGORY_DESC");
            entity.Property(e => e.CategoryHtml).HasColumnName("CATEGORY_HTML");
            entity.Property(e => e.CategoryId)
                .HasMaxLength(50)
                .HasColumnName("CATEGORY_ID");
            entity.Property(e => e.SurveyType).HasColumnName("SURVEY_TYPE");
        });

        modelBuilder.Entity<SurveyRestriction>(entity =>
        {
            entity.HasKey(e => new { e.BorNo, e.SurveyId }).HasName("PK_survey_restrictions");

            entity.ToTable("SURVEY_RESTRICTION");

            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");
            entity.Property(e => e.SurveyId).HasColumnName("SURVEY_ID");
            entity.Property(e => e.DatetimeSent)
                .HasColumnType("datetime")
                .HasColumnName("DATETIME_SENT");
            entity.Property(e => e.Sentyn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SENTYN");

            entity.HasOne(d => d.BorNoNavigation).WithMany(p => p.SurveyRestrictions)
                .HasForeignKey(d => d.BorNo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_survey_restriction_BORROWER");

            entity.HasOne(d => d.Survey).WithMany(p => p.SurveyRestrictions)
                .HasForeignKey(d => d.SurveyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_survey_restriction_survey");
        });

        modelBuilder.Entity<SurveySmileyFaceImage>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SURVEY_SMILEY_FACE_IMAGES");

            entity.Property(e => e.ImgData).HasColumnName("IMG_DATA");
            entity.Property(e => e.ImgDataBw).HasColumnName("IMG_DATA_BW");
            entity.Property(e => e.ImgDataHc).HasColumnName("IMG_DATA_HC");
            entity.Property(e => e.ImgFilename)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("IMG_FILENAME");
            entity.Property(e => e.ImgFilenameBw)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("IMG_FILENAME_BW");
            entity.Property(e => e.ImgFilenameHc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("IMG_FILENAME_HC");
            entity.Property(e => e.ImgType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IMG_TYPE");
            entity.Property(e => e.ImgTypeBw)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IMG_TYPE_BW");
            entity.Property(e => e.ImgTypeHc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IMG_TYPE_HC");
            entity.Property(e => e.SmileyFaceDesc)
                .HasMaxLength(100)
                .HasColumnName("SMILEY_FACE_DESC");
            entity.Property(e => e.UniqueId)
                .ValueGeneratedOnAdd()
                .HasColumnName("UNIQUE_ID");
        });

        modelBuilder.Entity<SurveyType>(entity =>
        {
            entity.HasKey(e => e.TypeId);

            entity.ToTable("SURVEY_TYPES");

            entity.Property(e => e.TypeId)
                .ValueGeneratedNever()
                .HasColumnName("TYPE_ID");
            entity.Property(e => e.BorMembershipSurvey).HasColumnName("BOR_MEMBERSHIP_SURVEY");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.ScoringSurvey)
                .HasDefaultValue(false)
                .HasColumnName("SCORING_SURVEY");
            entity.Property(e => e.SmileyFaceSurvey)
                .HasDefaultValue(false)
                .HasColumnName("SMILEY_FACE_SURVEY");
        });

        modelBuilder.Entity<SurveyTypesTranslation>(entity =>
        {
            entity.HasKey(e => new { e.Lcid, e.TypeId });

            entity.ToTable("SURVEY_TYPES_TRANSLATION");

            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.TypeId).HasColumnName("TYPE_ID");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");

            entity.HasOne(d => d.Type).WithMany(p => p.SurveyTypesTranslations)
                .HasForeignKey(d => d.TypeId)
                .HasConstraintName("FK_SURVEY_TYPES_TRANSLATION");
        });

        modelBuilder.Entity<SurveysAnswer>(entity =>
        {
            entity.HasKey(e => new { e.AnswerId, e.SurveyId, e.QuestionId }).HasName("PK_surveys_answers");

            entity.ToTable("SURVEYS_ANSWER");

            entity.Property(e => e.AnswerId).HasColumnName("ANSWER_ID");
            entity.Property(e => e.SurveyId).HasColumnName("SURVEY_ID");
            entity.Property(e => e.QuestionId).HasColumnName("QUESTION_ID");
            entity.Property(e => e.AnswerText).HasColumnName("ANSWER_TEXT");
            entity.Property(e => e.AnswerText2)
                .HasColumnType("ntext")
                .HasColumnName("ANSWER_TEXT2");
            entity.Property(e => e.AnswerValue).HasColumnName("ANSWER_VALUE");
            entity.Property(e => e.NextQuestionId).HasColumnName("NEXT_QUESTION_ID");
            entity.Property(e => e.NextSurveyId).HasColumnName("NEXT_SURVEY_ID");
            entity.Property(e => e.Other).HasColumnName("OTHER");
            entity.Property(e => e.SmileyFaceId).HasColumnName("SMILEY_FACE_ID");

            entity.HasOne(d => d.SurveysQuestion).WithMany(p => p.SurveysAnswers)
                .HasForeignKey(d => new { d.QuestionId, d.SurveyId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_surveys_answer_surveys_question");
        });

        modelBuilder.Entity<SurveysQuestion>(entity =>
        {
            entity.HasKey(e => new { e.QuestionId, e.SurveyId }).HasName("PK_surveys_questions");

            entity.ToTable("SURVEYS_QUESTION");

            entity.Property(e => e.QuestionId).HasColumnName("QUESTION_ID");
            entity.Property(e => e.SurveyId).HasColumnName("SURVEY_ID");
            entity.Property(e => e.Benchmark).HasColumnName("BENCHMARK");
            entity.Property(e => e.Categoryid)
                .HasMaxLength(50)
                .HasColumnName("CATEGORYID");
            entity.Property(e => e.Note).HasColumnName("NOTE");
            entity.Property(e => e.QuestionNote).HasColumnName("QUESTION_NOTE");
            entity.Property(e => e.QuestionText).HasColumnName("QUESTION_TEXT");
            entity.Property(e => e.QuestionType).HasColumnName("QUESTION_TYPE");
            entity.Property(e => e.Weighting).HasColumnName("WEIGHTING");

            entity.HasOne(d => d.Survey).WithMany(p => p.SurveysQuestions)
                .HasForeignKey(d => d.SurveyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_surveys_question_survey");
        });

        modelBuilder.Entity<SurveysStatus>(entity =>
        {
            entity.HasKey(e => e.StatusId).HasName("PK_surveys_status");

            entity.ToTable("SURVEYS_STATUS");

            entity.Property(e => e.StatusId)
                .ValueGeneratedNever()
                .HasColumnName("STATUS_ID");
            entity.Property(e => e.StatusDescription)
                .HasMaxLength(1000)
                .HasColumnName("STATUS_DESCRIPTION");
            entity.Property(e => e.StatusName)
                .HasMaxLength(500)
                .HasColumnName("STATUS_NAME");
        });

        modelBuilder.Entity<SysHeader>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SYS_HEADER");

            entity.Property(e => e.InstCntLastBorr).HasColumnName("INST_CNT_LAST_BORR");
            entity.Property(e => e.InstOperMsg).HasColumnName("INST_OPER_MSG");
        });

        modelBuilder.Entity<SysSsheet>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SYS_SSHEET");

            entity.Property(e => e.ShtAreaCd)
                .HasMaxLength(100)
                .HasColumnName("SHT_AREA_CD");
            entity.Property(e => e.ShtBorc)
                .HasMaxLength(200)
                .HasColumnName("SHT_BORC");
            entity.Property(e => e.ShtBorg)
                .HasMaxLength(200)
                .HasColumnName("SHT_BORG");
            entity.Property(e => e.ShtBorr)
                .HasMaxLength(100)
                .HasColumnName("SHT_BORR");
            entity.Property(e => e.ShtDateFrom)
                .HasColumnType("datetime")
                .HasColumnName("SHT_DATE_FROM");
            entity.Property(e => e.ShtDateTo)
                .HasColumnType("datetime")
                .HasColumnName("SHT_DATE_TO");
            entity.Property(e => e.ShtDays)
                .HasMaxLength(100)
                .HasColumnName("SHT_DAYS");
            entity.Property(e => e.ShtDaysBack).HasColumnName("SHT_DAYS_BACK");
            entity.Property(e => e.ShtForm)
                .HasMaxLength(100)
                .HasColumnName("SHT_FORM");
            entity.Property(e => e.ShtHours)
                .HasMaxLength(100)
                .HasColumnName("SHT_HOURS");
            entity.Property(e => e.ShtLocn)
                .HasMaxLength(100)
                .HasColumnName("SHT_LOCN");
            entity.Property(e => e.ShtMonths)
                .HasMaxLength(100)
                .HasColumnName("SHT_MONTHS");
            entity.Property(e => e.ShtRef)
                .HasMaxLength(50)
                .HasColumnName("SHT_REF");
            entity.Property(e => e.ShtRefSeq).HasColumnName("SHT_REF_SEQ");
            entity.Property(e => e.ShtStartCol).HasColumnName("SHT_START_COL");
            entity.Property(e => e.ShtStartRow).HasColumnName("SHT_START_ROW");
            entity.Property(e => e.ShtStatsCodes)
                .HasMaxLength(100)
                .HasColumnName("SHT_STATS_CODES");
            entity.Property(e => e.ShtStkCodes)
                .HasMaxLength(100)
                .HasColumnName("SHT_STK_CODES");
            entity.Property(e => e.ShtSuburb)
                .HasMaxLength(100)
                .HasColumnName("SHT_SUBURB");
            entity.Property(e => e.ShtType)
                .HasMaxLength(1)
                .HasColumnName("SHT_TYPE");
            entity.Property(e => e.ShtWard)
                .HasMaxLength(100)
                .HasColumnName("SHT_WARD");
            entity.Property(e => e.ShtYears)
                .HasMaxLength(100)
                .HasColumnName("SHT_YEARS");
        });

        modelBuilder.Entity<Team>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TEAMS_1");

            entity.ToTable("TEAMS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DepId).HasColumnName("DEP_ID");
            entity.Property(e => e.TeamCode)
                .HasMaxLength(50)
                .HasColumnName("TEAM_CODE");
            entity.Property(e => e.TeamCreated)
                .HasColumnType("datetime")
                .HasColumnName("TEAM_CREATED");
            entity.Property(e => e.TeamDesc)
                .HasMaxLength(250)
                .HasColumnName("TEAM_DESC");
            entity.Property(e => e.TeamId).HasColumnName("TEAM_ID");
        });

        modelBuilder.Entity<TeamsRetCode>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TEAMS_RET_CODES_1");

            entity.ToTable("TEAMS_RET_CODES");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.RetId).HasColumnName("RET_ID");
            entity.Property(e => e.TeamId).HasColumnName("TEAM_ID");
        });

        modelBuilder.Entity<TempBorAddrImport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP_BOR_ADDR_IMPORT");

            entity.Property(e => e.Ba2Addr1)
                .HasMaxLength(150)
                .HasColumnName("BA2_ADDR1");
            entity.Property(e => e.Ba2Addr2)
                .HasMaxLength(150)
                .HasColumnName("BA2_ADDR2");
            entity.Property(e => e.Ba2Addr3)
                .HasMaxLength(150)
                .HasColumnName("BA2_ADDR3");
            entity.Property(e => e.Ba2Addr4)
                .HasMaxLength(150)
                .HasColumnName("BA2_ADDR4");
            entity.Property(e => e.Ba2AddressTypeId)
                .HasMaxLength(50)
                .HasColumnName("BA2_ADDRESS_TYPE_ID");
            entity.Property(e => e.Ba2ContactName)
                .HasMaxLength(50)
                .HasColumnName("BA2_CONTACT_NAME");
            entity.Property(e => e.Ba2Main)
                .HasMaxLength(50)
                .HasColumnName("BA2_MAIN");
            entity.Property(e => e.Ba2Pcode)
                .HasMaxLength(50)
                .HasColumnName("BA2_PCODE");
            entity.Property(e => e.Ba2Salutation)
                .HasMaxLength(50)
                .HasColumnName("BA2_SALUTATION");
            entity.Property(e => e.Ba2Telephone)
                .HasMaxLength(50)
                .HasColumnName("BA2_TELEPHONE");
            entity.Property(e => e.Ba2ValidFrom)
                .HasMaxLength(50)
                .HasColumnName("BA2_VALID_FROM");
            entity.Property(e => e.Ba2ValidTo)
                .HasMaxLength(50)
                .HasColumnName("BA2_VALID_TO");
            entity.Property(e => e.Ba3Addr1)
                .HasMaxLength(150)
                .HasColumnName("BA3_ADDR1");
            entity.Property(e => e.Ba3Addr2)
                .HasMaxLength(150)
                .HasColumnName("BA3_ADDR2");
            entity.Property(e => e.Ba3Addr3)
                .HasMaxLength(150)
                .HasColumnName("BA3_ADDR3");
            entity.Property(e => e.Ba3Addr4)
                .HasMaxLength(150)
                .HasColumnName("BA3_ADDR4");
            entity.Property(e => e.Ba3AddressTypeId)
                .HasMaxLength(50)
                .HasColumnName("BA3_ADDRESS_TYPE_ID");
            entity.Property(e => e.Ba3ContactName)
                .HasMaxLength(50)
                .HasColumnName("BA3_CONTACT_NAME");
            entity.Property(e => e.Ba3Main)
                .HasMaxLength(50)
                .HasColumnName("BA3_MAIN");
            entity.Property(e => e.Ba3Pcode)
                .HasMaxLength(50)
                .HasColumnName("BA3_PCODE");
            entity.Property(e => e.Ba3Telephone)
                .HasMaxLength(50)
                .HasColumnName("BA3_TELEPHONE");
            entity.Property(e => e.Ba3ValidFrom)
                .HasMaxLength(50)
                .HasColumnName("BA3_VALID_FROM");
            entity.Property(e => e.Ba3ValidTo)
                .HasMaxLength(50)
                .HasColumnName("BA3_VALID_TO");
            entity.Property(e => e.BaAddr1)
                .HasMaxLength(150)
                .HasColumnName("BA_ADDR1");
            entity.Property(e => e.BaAddr2)
                .HasMaxLength(150)
                .HasColumnName("BA_ADDR2");
            entity.Property(e => e.BaAddr3)
                .HasMaxLength(150)
                .HasColumnName("BA_ADDR3");
            entity.Property(e => e.BaAddr4)
                .HasMaxLength(150)
                .HasColumnName("BA_ADDR4");
            entity.Property(e => e.BaAddr5)
                .HasMaxLength(50)
                .HasColumnName("BA_ADDR5");
            entity.Property(e => e.BaAddressTypeId)
                .HasMaxLength(50)
                .HasColumnName("BA_ADDRESS_TYPE_ID");
            entity.Property(e => e.BaContactName)
                .HasMaxLength(50)
                .HasColumnName("BA_CONTACT_NAME");
            entity.Property(e => e.BaMain)
                .HasMaxLength(50)
                .HasColumnName("BA_MAIN");
            entity.Property(e => e.BaPcode)
                .HasMaxLength(50)
                .HasColumnName("BA_PCODE");
            entity.Property(e => e.BaSalutation)
                .HasMaxLength(50)
                .HasColumnName("BA_SALUTATION");
            entity.Property(e => e.BaTelephone)
                .HasMaxLength(50)
                .HasColumnName("BA_TELEPHONE");
            entity.Property(e => e.BaValidFrom)
                .HasMaxLength(50)
                .HasColumnName("BA_VALID_FROM");
            entity.Property(e => e.BaValidTo)
                .HasMaxLength(50)
                .HasColumnName("BA_VALID_TO");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.RecordedDatetime)
                .HasMaxLength(25)
                .HasColumnName("RECORDED_DATETIME");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .HasColumnName("STATUS");
            entity.Property(e => e.WondeId)
                .HasMaxLength(50)
                .HasColumnName("WONDE_ID");
        });

        modelBuilder.Entity<TempBorImport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP_BOR_IMPORT");

            entity.Property(e => e.BorAddr1No)
                .HasMaxLength(300)
                .HasColumnName("BOR_ADDR1_NO");
            entity.Property(e => e.BorAddr2No)
                .HasMaxLength(300)
                .HasColumnName("BOR_ADDR2_NO");
            entity.Property(e => e.BorAddr3No)
                .HasMaxLength(300)
                .HasColumnName("BOR_ADDR3_NO");
            entity.Property(e => e.BorAddr4No)
                .HasMaxLength(300)
                .HasColumnName("BOR_ADDR4_NO");
            entity.Property(e => e.BorBarNo)
                .HasMaxLength(75)
                .HasColumnName("BOR_BAR_NO");
            entity.Property(e => e.BorClass).HasColumnName("BOR_CLASS");
            entity.Property(e => e.BorDob)
                .HasMaxLength(45)
                .HasColumnName("BOR_DOB");
            entity.Property(e => e.BorEmail)
                .HasMaxLength(75)
                .HasColumnName("BOR_EMAIL");
            entity.Property(e => e.BorGiven)
                .HasMaxLength(40)
                .HasColumnName("BOR_GIVEN");
            entity.Property(e => e.BorGroup).HasColumnName("BOR_GROUP");
            entity.Property(e => e.BorImportId)
                .ValueGeneratedOnAdd()
                .HasColumnName("BOR_IMPORT_ID");
            entity.Property(e => e.BorInit)
                .HasMaxLength(25)
                .HasColumnName("BOR_INIT");
            entity.Property(e => e.BorLandlineTel)
                .HasMaxLength(30)
                .HasColumnName("BOR_LANDLINE_TEL");
            entity.Property(e => e.BorLocation)
                .HasMaxLength(100)
                .HasColumnName("BOR_LOCATION");
            entity.Property(e => e.BorMobileTel)
                .HasMaxLength(30)
                .HasColumnName("BOR_MOBILE_TEL");
            entity.Property(e => e.BorOper)
                .HasMaxLength(30)
                .HasColumnName("BOR_OPER");
            entity.Property(e => e.BorPhoneTel)
                .HasMaxLength(30)
                .HasColumnName("BOR_PHONE_TEL");
            entity.Property(e => e.BorPicData).HasColumnName("BOR_PIC_DATA");
            entity.Property(e => e.BorPostcode)
                .HasMaxLength(30)
                .HasColumnName("BOR_POSTCODE");
            entity.Property(e => e.BorRef1)
                .HasMaxLength(75)
                .HasColumnName("BOR_REF1");
            entity.Property(e => e.BorRef2)
                .HasMaxLength(150)
                .HasColumnName("BOR_REF2");
            entity.Property(e => e.BorRef3)
                .HasMaxLength(150)
                .HasColumnName("BOR_REF3");
            entity.Property(e => e.BorRegdate)
                .HasMaxLength(45)
                .HasColumnName("BOR_REGDATE");
            entity.Property(e => e.BorSex)
                .HasMaxLength(40)
                .HasColumnName("BOR_SEX");
            entity.Property(e => e.BorStartMship)
                .HasMaxLength(45)
                .HasColumnName("BOR_START_MSHIP");
            entity.Property(e => e.BorStatus)
                .HasMaxLength(30)
                .HasColumnName("BOR_STATUS");
            entity.Property(e => e.BorSurname)
                .HasMaxLength(100)
                .HasColumnName("BOR_SURNAME");
            entity.Property(e => e.BorTitle)
                .HasMaxLength(25)
                .HasColumnName("BOR_TITLE");
            entity.Property(e => e.BorType)
                .HasMaxLength(100)
                .HasColumnName("BOR_TYPE");
            entity.Property(e => e.ImportType)
                .HasMaxLength(1)
                .HasColumnName("IMPORT_TYPE");
            entity.Property(e => e.LibGroupId)
                .HasMaxLength(25)
                .HasColumnName("LIB_GROUP_ID");
            entity.Property(e => e.RecordedDatetime)
                .HasMaxLength(25)
                .HasColumnName("RECORDED_DATETIME");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .HasColumnName("STATUS");
            entity.Property(e => e.WondeId)
                .HasMaxLength(50)
                .HasColumnName("WONDE_ID");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK_dbo.Users");

            entity.HasIndex(e => e.Email, "User_Email_Index").IsUnique();

            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.Telephone).HasMaxLength(20);
        });

        modelBuilder.Entity<UserBorClass>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("USER_BOR_CLASSES");

            entity.HasIndex(e => new { e.BorNo, e.BcClass }, "IX_User_Bor_Classes_BorNo_Class");

            entity.Property(e => e.BcClass)
                .HasMaxLength(10)
                .HasColumnName("BC_CLASS");
            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<UserBorGroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("USER_BOR_GROUPS");

            entity.HasIndex(e => new { e.BorNo, e.BgGroup }, "IX_User_Bor_Groups_BorNo_Group");

            entity.Property(e => e.BgGroup)
                .HasMaxLength(10)
                .HasColumnName("BG_GROUP");
            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<UserListDatum>(entity =>
        {
            entity.HasKey(e => new { e.ListId, e.DataId }).HasName("PK__USER_LIS__F0E5C789E6424743");

            entity.ToTable("USER_LIST_DATA");

            entity.Property(e => e.ListId).HasColumnName("LIST_ID");
            entity.Property(e => e.DataId).HasColumnName("DATA_ID");
            entity.Property(e => e.DataSequence).HasColumnName("DATA_SEQUENCE");

            entity.HasOne(d => d.List).WithMany(p => p.UserListData)
                .HasForeignKey(d => d.ListId)
                .HasConstraintName("FK__USER_LIST__LIST___01741E54");
        });

        modelBuilder.Entity<UserListName>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__USER_LIS__3214EC279BA53408");

            entity.ToTable("USER_LIST_NAMES");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");
            entity.Property(e => e.ListDateCreated).HasColumnName("LIST_DATE_CREATED");
            entity.Property(e => e.ListDateUpdated).HasColumnName("LIST_DATE_UPDATED");
            entity.Property(e => e.ListDesc)
                .HasMaxLength(250)
                .HasColumnName("LIST_DESC");
            entity.Property(e => e.ListName)
                .HasMaxLength(50)
                .HasColumnName("LIST_NAME");
            entity.Property(e => e.ListQty).HasColumnName("LIST_QTY");
            entity.Property(e => e.ListType)
                .HasMaxLength(1)
                .HasColumnName("LIST_TYPE");
        });

        modelBuilder.Entity<VBorMainAddr>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_BOR_MAIN_ADDR");

            entity.Property(e => e.BorAddr1No).HasColumnName("BOR_ADDR1_NO");
            entity.Property(e => e.BorAddr1Txt)
                .HasMaxLength(1224)
                .HasColumnName("BOR_ADDR1_TXT");
            entity.Property(e => e.BorAddr2No).HasColumnName("BOR_ADDR2_NO");
            entity.Property(e => e.BorAddr2Txt)
                .HasMaxLength(1224)
                .HasColumnName("BOR_ADDR2_TXT");
            entity.Property(e => e.BorAddr3No).HasColumnName("BOR_ADDR3_NO");
            entity.Property(e => e.BorAddr3Txt)
                .HasMaxLength(1224)
                .HasColumnName("BOR_ADDR3_TXT");
            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");
        });

        modelBuilder.Entity<VBorrower>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_BORROWER");

            entity.Property(e => e.BorAddr1No).HasColumnName("BOR_ADDR1_NO");
            entity.Property(e => e.BorAddr1Txt)
                .HasMaxLength(85)
                .HasColumnName("BOR_ADDR1_TXT");
            entity.Property(e => e.BorAddr2No).HasColumnName("BOR_ADDR2_NO");
            entity.Property(e => e.BorAddr2Txt)
                .HasMaxLength(85)
                .HasColumnName("BOR_ADDR2_TXT");
            entity.Property(e => e.BorAddr3No).HasColumnName("BOR_ADDR3_NO");
            entity.Property(e => e.BorAddr3Txt)
                .HasMaxLength(85)
                .HasColumnName("BOR_ADDR3_TXT");
            entity.Property(e => e.BorApproved)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("BOR_APPROVED");
            entity.Property(e => e.BorBarNo)
                .HasMaxLength(75)
                .HasColumnName("BOR_BAR_NO");
            entity.Property(e => e.BorClass)
                .HasMaxLength(10)
                .HasColumnName("BOR_CLASS");
            entity.Property(e => e.BorDatetime).HasColumnName("BOR_DATETIME");
            entity.Property(e => e.BorDob).HasColumnName("BOR_DOB");
            entity.Property(e => e.BorEmail)
                .HasMaxLength(75)
                .HasColumnName("BOR_EMAIL");
            entity.Property(e => e.BorEmailPin)
                .HasMaxLength(1)
                .HasColumnName("BOR_EMAIL_PIN");
            entity.Property(e => e.BorEmailPinReset)
                .HasMaxLength(1)
                .HasColumnName("BOR_EMAIL_PIN_RESET");
            entity.Property(e => e.BorGiven)
                .HasMaxLength(40)
                .HasColumnName("BOR_GIVEN");
            entity.Property(e => e.BorGroup)
                .HasMaxLength(10)
                .HasColumnName("BOR_GROUP");
            entity.Property(e => e.BorInit)
                .HasMaxLength(25)
                .HasColumnName("BOR_INIT");
            entity.Property(e => e.BorLastactive).HasColumnName("BOR_LASTACTIVE");
            entity.Property(e => e.BorLibGroup)
                .HasMaxLength(30)
                .HasColumnName("BOR_LIB_GROUP");
            entity.Property(e => e.BorLocation)
                .HasMaxLength(20)
                .HasColumnName("BOR_LOCATION");
            entity.Property(e => e.BorMobUsfn)
                .HasMaxLength(1)
                .HasColumnName("BOR_MOB_USFN");
            entity.Property(e => e.BorMobileTel)
                .HasMaxLength(25)
                .HasColumnName("BOR_MOBILE_TEL");
            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");
            entity.Property(e => e.BorNoLoans).HasColumnName("BOR_NO_LOANS");
            entity.Property(e => e.BorNoOpacs).HasColumnName("BOR_NO_OPACS");
            entity.Property(e => e.BorNoRenews).HasColumnName("BOR_NO_RENEWS");
            entity.Property(e => e.BorNoReserves).HasColumnName("BOR_NO_RESERVES");
            entity.Property(e => e.BorNoSee).HasColumnName("BOR_NO_SEE");
            entity.Property(e => e.BorNoVisits).HasColumnName("BOR_NO_VISITS");
            entity.Property(e => e.BorOper)
                .HasMaxLength(25)
                .HasColumnName("BOR_OPER");
            entity.Property(e => e.BorOwing)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("BOR_OWING");
            entity.Property(e => e.BorPin)
                .HasMaxLength(25)
                .HasColumnName("BOR_PIN");
            entity.Property(e => e.BorPotentialCharge)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("BOR_POTENTIAL_CHARGE");
            entity.Property(e => e.BorRamdomKey)
                .HasMaxLength(8)
                .HasColumnName("BOR_RAMDOM_KEY");
            entity.Property(e => e.BorRef1)
                .HasMaxLength(75)
                .HasColumnName("BOR_REF1");
            entity.Property(e => e.BorRef2)
                .HasMaxLength(150)
                .HasColumnName("BOR_REF2");
            entity.Property(e => e.BorRef3)
                .HasMaxLength(150)
                .HasColumnName("BOR_REF3");
            entity.Property(e => e.BorRegdate).HasColumnName("BOR_REGDATE");
            entity.Property(e => e.BorRejectedEmail)
                .HasMaxLength(1)
                .HasColumnName("BOR_REJECTED_EMAIL");
            entity.Property(e => e.BorRelType)
                .HasMaxLength(1)
                .HasColumnName("BOR_REL_TYPE");
            entity.Property(e => e.BorReqPinChange)
                .HasMaxLength(1)
                .HasColumnName("BOR_REQ_PIN_CHANGE");
            entity.Property(e => e.BorSecurity).HasColumnName("BOR_SECURITY");
            entity.Property(e => e.BorSex)
                .HasMaxLength(1)
                .HasColumnName("BOR_SEX");
            entity.Property(e => e.BorSoundex)
                .HasMaxLength(35)
                .HasColumnName("BOR_SOUNDEX");
            entity.Property(e => e.BorStartLocation)
                .HasMaxLength(25)
                .HasColumnName("BOR_START_LOCATION");
            entity.Property(e => e.BorStartMship).HasColumnName("BOR_START_MSHIP");
            entity.Property(e => e.BorStatus)
                .HasMaxLength(10)
                .HasColumnName("BOR_STATUS");
            entity.Property(e => e.BorSurname)
                .HasMaxLength(100)
                .HasColumnName("BOR_SURNAME");
            entity.Property(e => e.BorSurnameKey)
                .HasMaxLength(100)
                .HasColumnName("BOR_SURNAME_KEY");
            entity.Property(e => e.BorTitle)
                .HasMaxLength(25)
                .HasColumnName("BOR_TITLE");
            entity.Property(e => e.BorType)
                .HasMaxLength(3)
                .HasColumnName("BOR_TYPE");
            entity.Property(e => e.BorUseEmail)
                .HasMaxLength(1)
                .HasColumnName("BOR_USE_EMAIL");
            entity.Property(e => e.ContactTel)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CONTACT_TEL");
            entity.Property(e => e.Isshowinitial).HasColumnName("ISSHOWINITIAL");
            entity.Property(e => e.PreBorNoSee).HasColumnName("PRE_BOR_NO_SEE");
            entity.Property(e => e.Primarycontact).HasColumnName("PRIMARYCONTACT");
            entity.Property(e => e.ReadingChallenge).HasColumnName("READING_CHALLENGE");
            entity.Property(e => e.ReceiveEmails)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RECEIVE_EMAILS");
            entity.Property(e => e.ReceiveInfoByPost)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RECEIVE_INFO_BY_POST");
            entity.Property(e => e.Salutation)
                .HasMaxLength(50)
                .HasColumnName("SALUTATION");
        });

        modelBuilder.Entity<VCashTill>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_CASH_TILL");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IS_ACTIVE");
            entity.Property(e => e.LlCode)
                .HasMaxLength(30)
                .HasColumnName("LL_CODE");
            entity.Property(e => e.Operator)
                .HasMaxLength(25)
                .HasColumnName("OPERATOR");
            entity.Property(e => e.TillName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TILL_NAME");
            entity.Property(e => e.TillNo)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("TILL_NO");
        });

        modelBuilder.Entity<VStkItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_STK_ITEM");

            entity.Property(e => e.StkAvgRating).HasColumnName("STK_AVG_RATING");
            entity.Property(e => e.StkBorBarNo)
                .HasMaxLength(75)
                .HasColumnName("STK_BOR_BAR_NO");
            entity.Property(e => e.StkBorName)
                .HasMaxLength(20)
                .HasColumnName("STK_BOR_NAME");
            entity.Property(e => e.StkCallSet)
                .HasMaxLength(6)
                .HasColumnName("STK_CALL_SET");
            entity.Property(e => e.StkCatRef).HasColumnName("STK_CAT_REF");
            entity.Property(e => e.StkClass)
                .HasMaxLength(20)
                .HasColumnName("STK_CLASS");
            entity.Property(e => e.StkConvertValue)
                .HasMaxLength(50)
                .HasColumnName("STK_CONVERT_VALUE");
            entity.Property(e => e.StkCost)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("STK_COST");
            entity.Property(e => e.StkDateAcc)
                .HasColumnType("datetime")
                .HasColumnName("STK_DATE_ACC");
            entity.Property(e => e.StkDateDue)
                .HasColumnType("datetime")
                .HasColumnName("STK_DATE_DUE");
            entity.Property(e => e.StkDateRecd)
                .HasColumnType("datetime")
                .HasColumnName("STK_DATE_RECD");
            entity.Property(e => e.StkDatetime)
                .HasColumnType("datetime")
                .HasColumnName("STK_DATETIME");
            entity.Property(e => e.StkDescription)
                .HasMaxLength(250)
                .HasColumnName("STK_DESCRIPTION");
            entity.Property(e => e.StkEdition)
                .HasMaxLength(25)
                .HasColumnName("STK_EDITION");
            entity.Property(e => e.StkForLoan)
                .HasMaxLength(1)
                .HasColumnName("STK_FOR_LOAN");
            entity.Property(e => e.StkForm)
                .HasMaxLength(3)
                .HasColumnName("STK_FORM");
            entity.Property(e => e.StkIllDue)
                .HasColumnType("datetime")
                .HasColumnName("STK_ILL_DUE");
            entity.Property(e => e.StkIllRenew)
                .HasMaxLength(1)
                .HasColumnName("STK_ILL_RENEW");
            entity.Property(e => e.StkIllSupp)
                .HasMaxLength(10)
                .HasColumnName("STK_ILL_SUPP");
            entity.Property(e => e.StkIsOnLoan)
                .HasMaxLength(1)
                .HasColumnName("STK_IS_ON_LOAN");
            entity.Property(e => e.StkIsOnOrder)
                .HasMaxLength(1)
                .HasColumnName("STK_IS_ON_ORDER");
            entity.Property(e => e.StkIsReserved).HasColumnName("STK_IS_RESERVED");
            entity.Property(e => e.StkIssDate)
                .HasColumnType("datetime")
                .HasColumnName("STK_ISS_DATE");
            entity.Property(e => e.StkIssDue)
                .HasColumnType("datetime")
                .HasColumnName("STK_ISS_DUE");
            entity.Property(e => e.StkIssLoc)
                .HasMaxLength(20)
                .HasColumnName("STK_ISS_LOC");
            entity.Property(e => e.StkIssRenewed).HasColumnName("STK_ISS_RENEWED");
            entity.Property(e => e.StkIssueAddrNo).HasColumnName("STK_ISSUE_ADDR_NO");
            entity.Property(e => e.StkIssueType)
                .HasMaxLength(1)
                .HasColumnName("STK_ISSUE_TYPE");
            entity.Property(e => e.StkItemNo)
                .HasMaxLength(25)
                .HasColumnName("STK_ITEM_NO");
            entity.Property(e => e.StkItemOrigin)
                .HasMaxLength(3)
                .HasColumnName("STK_ITEM_ORIGIN");
            entity.Property(e => e.StkItemType)
                .HasMaxLength(1)
                .HasColumnName("STK_ITEM_TYPE");
            entity.Property(e => e.StkKey1)
                .HasMaxLength(200)
                .HasColumnName("STK_KEY1");
            entity.Property(e => e.StkKey2)
                .HasMaxLength(200)
                .HasColumnName("STK_KEY2");
            entity.Property(e => e.StkKey3)
                .HasMaxLength(200)
                .HasColumnName("STK_KEY3");
            entity.Property(e => e.StkKey4)
                .HasMaxLength(200)
                .HasColumnName("STK_KEY4");
            entity.Property(e => e.StkKey5)
                .HasMaxLength(200)
                .HasColumnName("STK_KEY5");
            entity.Property(e => e.StkKey6)
                .HasMaxLength(200)
                .HasColumnName("STK_KEY6");
            entity.Property(e => e.StkLastDep)
                .HasColumnType("datetime")
                .HasColumnName("STK_LAST_DEP");
            entity.Property(e => e.StkLastResno).HasColumnName("STK_LAST_RESNO");
            entity.Property(e => e.StkLastTake)
                .HasColumnType("datetime")
                .HasColumnName("STK_LAST_TAKE");
            entity.Property(e => e.StkLastactive)
                .HasColumnType("datetime")
                .HasColumnName("STK_LASTACTIVE");
            entity.Property(e => e.StkLibGroup)
                .HasMaxLength(30)
                .HasColumnName("STK_LIB_GROUP");
            entity.Property(e => e.StkLine1)
                .HasMaxLength(250)
                .HasColumnName("STK_LINE1");
            entity.Property(e => e.StkLine2)
                .HasMaxLength(250)
                .HasColumnName("STK_LINE2");
            entity.Property(e => e.StkLine3)
                .HasMaxLength(250)
                .HasColumnName("STK_LINE3");
            entity.Property(e => e.StkLine4)
                .HasMaxLength(250)
                .HasColumnName("STK_LINE4");
            entity.Property(e => e.StkLine5)
                .HasMaxLength(250)
                .HasColumnName("STK_LINE5");
            entity.Property(e => e.StkLine6)
                .HasMaxLength(250)
                .HasColumnName("STK_LINE6");
            entity.Property(e => e.StkLoanType)
                .HasMaxLength(3)
                .HasColumnName("STK_LOAN_TYPE");
            entity.Property(e => e.StkLocFloor)
                .HasMaxLength(75)
                .HasColumnName("STK_LOC_FLOOR");
            entity.Property(e => e.StkLocFloorId).HasColumnName("STK_LOC_FLOOR_ID");
            entity.Property(e => e.StkLocPerm)
                .HasMaxLength(40)
                .HasColumnName("STK_LOC_PERM");
            entity.Property(e => e.StkLocTemp)
                .HasMaxLength(40)
                .HasColumnName("STK_LOC_TEMP");
            entity.Property(e => e.StkOpacShow)
                .HasMaxLength(1)
                .HasColumnName("STK_OPAC_SHOW");
            entity.Property(e => e.StkOper)
                .HasMaxLength(25)
                .HasColumnName("STK_OPER");
            entity.Property(e => e.StkOperAlert)
                .HasMaxLength(1)
                .HasColumnName("STK_OPER_ALERT");
            entity.Property(e => e.StkOrigCost)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("STK_ORIG_COST");
            entity.Property(e => e.StkOtherRef)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STK_OTHER_REF");
            entity.Property(e => e.StkProcess)
                .HasMaxLength(20)
                .HasColumnName("STK_PROCESS");
            entity.Property(e => e.StkProcessDate)
                .HasColumnType("datetime")
                .HasColumnName("STK_PROCESS_DATE");
            entity.Property(e => e.StkRecallDate)
                .HasColumnType("datetime")
                .HasColumnName("STK_RECALL_DATE");
            entity.Property(e => e.StkRelatedNo).HasColumnName("STK_RELATED_NO");
            entity.Property(e => e.StkRotationDate)
                .HasColumnType("datetime")
                .HasColumnName("STK_ROTATION_DATE");
            entity.Property(e => e.StkRotationLoCode)
                .HasMaxLength(20)
                .HasColumnName("STK_ROTATION_LO_CODE");
            entity.Property(e => e.StkRotationPlanId).HasColumnName("STK_ROTATION_PLAN_ID");
            entity.Property(e => e.StkRotationSeqNo).HasColumnName("STK_ROTATION_SEQ_NO");
            entity.Property(e => e.StkRotationTransit)
                .HasMaxLength(1)
                .HasColumnName("STK_ROTATION_TRANSIT");
            entity.Property(e => e.StkStatsCode)
                .HasMaxLength(6)
                .HasColumnName("STK_STATS_CODE");
            entity.Property(e => e.StkStockTake)
                .HasMaxLength(1)
                .HasColumnName("STK_STOCK_TAKE");
            entity.Property(e => e.StkTimesBorpr).HasColumnName("STK_TIMES_BORPR");
            entity.Property(e => e.StkTimesBorrowed).HasColumnName("STK_TIMES_BORROWED");
            entity.Property(e => e.StkTimesRenewed).HasColumnName("STK_TIMES_RENEWED");
            entity.Property(e => e.StkTimesRenpr).HasColumnName("STK_TIMES_RENPR");
            entity.Property(e => e.StkTimesReserved).HasColumnName("STK_TIMES_RESERVED");
            entity.Property(e => e.StkTimesResvpr).HasColumnName("STK_TIMES_RESVPR");
            entity.Property(e => e.StkVolume)
                .HasMaxLength(25)
                .HasColumnName("STK_VOLUME");
            entity.Property(e => e.UniqueItemNo).HasColumnName("UNIQUE_ITEM_NO");
        });

        modelBuilder.Entity<VisBackupDb>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VIS_BACKUP_DB");

            entity.Property(e => e.LastBackupDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_BACKUP_DATE");
        });

        modelBuilder.Entity<WaiveTran>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WAIVE_TRANS");

            entity.Property(e => e.WaiveAccYear).HasColumnName("WAIVE_ACC_YEAR");
            entity.Property(e => e.WaiveAccount)
                .HasMaxLength(10)
                .HasColumnName("WAIVE_ACCOUNT");
            entity.Property(e => e.WaiveAllocCode)
                .HasMaxLength(20)
                .HasColumnName("WAIVE_ALLOC_CODE");
            entity.Property(e => e.WaiveBorno).HasColumnName("WAIVE_BORNO");
            entity.Property(e => e.WaiveComments)
                .HasMaxLength(500)
                .HasColumnName("WAIVE_COMMENTS");
            entity.Property(e => e.WaiveCr)
                .HasMaxLength(2)
                .HasColumnName("WAIVE_CR");
            entity.Property(e => e.WaiveCurrRate)
                .HasColumnType("decimal(10, 4)")
                .HasColumnName("WAIVE_CURR_RATE");
            entity.Property(e => e.WaiveCurrency)
                .HasMaxLength(4)
                .HasColumnName("WAIVE_CURRENCY");
            entity.Property(e => e.WaiveDate)
                .HasColumnType("datetime")
                .HasColumnName("WAIVE_DATE");
            entity.Property(e => e.WaiveDateMod)
                .HasColumnType("datetime")
                .HasColumnName("WAIVE_DATE_MOD");
            entity.Property(e => e.WaiveInvDate)
                .HasColumnType("datetime")
                .HasColumnName("WAIVE_INV_DATE");
            entity.Property(e => e.WaiveInvNo)
                .HasMaxLength(12)
                .HasColumnName("WAIVE_INV_NO");
            entity.Property(e => e.WaiveItemno).HasColumnName("WAIVE_ITEMNO");
            entity.Property(e => e.WaiveLoc)
                .HasMaxLength(20)
                .HasColumnName("WAIVE_LOC");
            entity.Property(e => e.WaiveMarkfordelete)
                .HasMaxLength(1)
                .HasColumnName("WAIVE_MARKFORDELETE");
            entity.Property(e => e.WaiveName)
                .HasMaxLength(100)
                .HasColumnName("WAIVE_NAME");
            entity.Property(e => e.WaiveOper)
                .HasMaxLength(20)
                .HasColumnName("WAIVE_OPER");
            entity.Property(e => e.WaiveQty)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("WAIVE_QTY");
            entity.Property(e => e.WaiveSuppNo)
                .HasMaxLength(25)
                .HasColumnName("WAIVE_SUPP_NO");
            entity.Property(e => e.WaiveTitle)
                .HasMaxLength(250)
                .HasColumnName("WAIVE_TITLE");
            entity.Property(e => e.WaiveType)
                .HasMaxLength(15)
                .HasColumnName("WAIVE_TYPE");
            entity.Property(e => e.WaiveUniqueId).HasColumnName("WAIVE_UNIQUE_ID");
            entity.Property(e => e.WaiveValue)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("WAIVE_VALUE");
        });

        modelBuilder.Entity<WebHmtl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WEB_HMTL");

            entity.Property(e => e.WebArea)
                .HasMaxLength(1)
                .HasColumnName("WEB_AREA");
            entity.Property(e => e.WebBackground)
                .HasMaxLength(50)
                .HasColumnName("WEB_BACKGROUND");
            entity.Property(e => e.WebHtmFile)
                .HasMaxLength(300)
                .HasColumnName("WEB_HTM_FILE");
            entity.Property(e => e.WebLineList1)
                .HasMaxLength(240)
                .HasColumnName("WEB_LINE_LIST1");
            entity.Property(e => e.WebLineList2)
                .HasMaxLength(240)
                .HasColumnName("WEB_LINE_LIST2");
            entity.Property(e => e.WebLineList3)
                .HasMaxLength(240)
                .HasColumnName("WEB_LINE_LIST3");
            entity.Property(e => e.WebLinkCodeIn)
                .HasMaxLength(120)
                .HasColumnName("WEB_LINK_CODE_IN");
            entity.Property(e => e.WebLinkCodeOut)
                .HasMaxLength(120)
                .HasColumnName("WEB_LINK_CODE_OUT");
            entity.Property(e => e.WebNoteline)
                .HasMaxLength(1)
                .HasColumnName("WEB_NOTELINE");
            entity.Property(e => e.WebScreen).HasColumnName("WEB_SCREEN");
            entity.Property(e => e.WebSequence).HasColumnName("WEB_SEQUENCE");
            entity.Property(e => e.WebStatsCode).HasColumnName("WEB_STATS_CODE");
            entity.Property(e => e.WebTagList1)
                .HasMaxLength(60)
                .HasColumnName("WEB_TAG_LIST1");
            entity.Property(e => e.WebTagList2)
                .HasMaxLength(60)
                .HasColumnName("WEB_TAG_LIST2");
            entity.Property(e => e.WebTagList3)
                .HasMaxLength(60)
                .HasColumnName("WEB_TAG_LIST3");
            entity.Property(e => e.WebText1)
                .HasMaxLength(240)
                .HasColumnName("WEB_TEXT1");
            entity.Property(e => e.WebText2)
                .HasMaxLength(240)
                .HasColumnName("WEB_TEXT2");
            entity.Property(e => e.WebTextlink)
                .HasMaxLength(120)
                .HasColumnName("WEB_TEXTLINK");
            entity.Property(e => e.WebTlwidth).HasColumnName("WEB_TLWIDTH");
            entity.Property(e => e.WebTwidth1).HasColumnName("WEB_TWIDTH1");
            entity.Property(e => e.WebTwidth2).HasColumnName("WEB_TWIDTH2");
            entity.Property(e => e.WebType)
                .HasMaxLength(1)
                .HasColumnName("WEB_TYPE");
            entity.Property(e => e.WebUser)
                .HasMaxLength(10)
                .HasColumnName("WEB_USER");
        });

        modelBuilder.Entity<WindowName>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WINDOW_NAMES");

            entity.Property(e => e.SysType)
                .HasMaxLength(3)
                .HasColumnName("SYS_TYPE");
            entity.Property(e => e.WindowName1)
                .HasMaxLength(30)
                .HasColumnName("WINDOW_NAME");
            entity.Property(e => e.WnButton1)
                .HasMaxLength(16)
                .HasColumnName("WN_BUTTON1");
            entity.Property(e => e.WnButton10)
                .HasMaxLength(16)
                .HasColumnName("WN_BUTTON10");
            entity.Property(e => e.WnButton2)
                .HasMaxLength(16)
                .HasColumnName("WN_BUTTON2");
            entity.Property(e => e.WnButton3)
                .HasMaxLength(16)
                .HasColumnName("WN_BUTTON3");
            entity.Property(e => e.WnButton4)
                .HasMaxLength(16)
                .HasColumnName("WN_BUTTON4");
            entity.Property(e => e.WnButton5)
                .HasMaxLength(16)
                .HasColumnName("WN_BUTTON5");
            entity.Property(e => e.WnButton6)
                .HasMaxLength(16)
                .HasColumnName("WN_BUTTON6");
            entity.Property(e => e.WnButton7)
                .HasMaxLength(16)
                .HasColumnName("WN_BUTTON7");
            entity.Property(e => e.WnButton8)
                .HasMaxLength(16)
                .HasColumnName("WN_BUTTON8");
            entity.Property(e => e.WnButton9)
                .HasMaxLength(16)
                .HasColumnName("WN_BUTTON9");
            entity.Property(e => e.WnFilename)
                .HasMaxLength(76)
                .HasColumnName("WN_FILENAME");
            entity.Property(e => e.WnTbcolor).HasColumnName("WN_TBCOLOR");
            entity.Property(e => e.WnTitle1)
                .HasMaxLength(16)
                .HasColumnName("WN_TITLE1");
            entity.Property(e => e.WnTitle10)
                .HasMaxLength(16)
                .HasColumnName("WN_TITLE10");
            entity.Property(e => e.WnTitle2)
                .HasMaxLength(16)
                .HasColumnName("WN_TITLE2");
            entity.Property(e => e.WnTitle3)
                .HasMaxLength(16)
                .HasColumnName("WN_TITLE3");
            entity.Property(e => e.WnTitle4)
                .HasMaxLength(16)
                .HasColumnName("WN_TITLE4");
            entity.Property(e => e.WnTitle5)
                .HasMaxLength(16)
                .HasColumnName("WN_TITLE5");
            entity.Property(e => e.WnTitle6)
                .HasMaxLength(16)
                .HasColumnName("WN_TITLE6");
            entity.Property(e => e.WnTitle7)
                .HasMaxLength(16)
                .HasColumnName("WN_TITLE7");
            entity.Property(e => e.WnTitle8)
                .HasMaxLength(16)
                .HasColumnName("WN_TITLE8");
            entity.Property(e => e.WnTitle9)
                .HasMaxLength(16)
                .HasColumnName("WN_TITLE9");
            entity.Property(e => e.WnWindowType)
                .HasMaxLength(5)
                .HasColumnName("WN_WINDOW_TYPE");
        });

        modelBuilder.Entity<ZwebCache>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ZWEB_CACHE");

            entity.HasIndex(e => new { e.ZcType, e.ZcUniqueId }, "ZC_TYPEUNIQUEIDX").IsUnique();

            entity.Property(e => e.ZcData)
                .HasColumnType("ntext")
                .HasColumnName("ZC_DATA");
            entity.Property(e => e.ZcDatetime)
                .HasColumnType("datetime")
                .HasColumnName("ZC_DATETIME");
            entity.Property(e => e.ZcType)
                .HasMaxLength(10)
                .HasColumnName("ZC_TYPE");
            entity.Property(e => e.ZcUniqueId)
                .HasMaxLength(100)
                .HasColumnName("ZC_UNIQUE_ID");
        });

        modelBuilder.Entity<ZwebMarcDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ZWEB_MARC_DATA");

            entity.HasIndex(e => new { e.ZmdQueryId, e.ZmdServerId, e.ZmdRecord }, "ZMD_QIDSERVRECX").IsUnique();

            entity.Property(e => e.ZmdDatetime)
                .HasColumnType("datetime")
                .HasColumnName("ZMD_DATETIME");
            entity.Property(e => e.ZmdMarc)
                .HasColumnType("ntext")
                .HasColumnName("ZMD_MARC");
            entity.Property(e => e.ZmdQueryId)
                .HasMaxLength(100)
                .HasColumnName("ZMD_QUERY_ID");
            entity.Property(e => e.ZmdRecord).HasColumnName("ZMD_RECORD");
            entity.Property(e => e.ZmdServerId).HasColumnName("ZMD_SERVER_ID");
        });

        modelBuilder.Entity<ZwebOption>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ZWEB_OPTIONS");

            entity.Property(e => e.ZoCode)
                .HasMaxLength(50)
                .HasColumnName("ZO_CODE");
            entity.Property(e => e.ZoValue)
                .HasMaxLength(50)
                .HasColumnName("ZO_VALUE");
        });

        modelBuilder.Entity<ZwebPageCache>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ZWEB_PAGE_CACHE");

            entity.HasIndex(e => e.ZpcPageId, "ZPC_PAGE_IDX").IsUnique();

            entity.Property(e => e.ZpcDatetime)
                .HasColumnType("datetime")
                .HasColumnName("ZPC_DATETIME");
            entity.Property(e => e.ZpcHtml)
                .HasColumnType("ntext")
                .HasColumnName("ZPC_HTML");
            entity.Property(e => e.ZpcPageId)
                .HasMaxLength(100)
                .HasColumnName("ZPC_PAGE_ID");
        });

        modelBuilder.Entity<ZwebQuery>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ZWEB_QUERY");

            entity.HasIndex(e => e.ZqQueryId, "ZQ_QUERYIDX").IsUnique();

            entity.Property(e => e.ZqData)
                .HasColumnType("ntext")
                .HasColumnName("ZQ_DATA");
            entity.Property(e => e.ZqDatetime)
                .HasColumnType("datetime")
                .HasColumnName("ZQ_DATETIME");
            entity.Property(e => e.ZqQueryId)
                .HasMaxLength(100)
                .HasColumnName("ZQ_QUERY_ID");
        });

        modelBuilder.Entity<ZwebScanCache>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ZWEB_SCAN_CACHE");

            entity.Property(e => e.ZsAttrId).HasColumnName("ZS_ATTR_ID");
            entity.Property(e => e.ZsDatetime)
                .HasColumnType("datetime")
                .HasColumnName("ZS_DATETIME");
            entity.Property(e => e.ZsDisplay)
                .HasMaxLength(300)
                .HasColumnName("ZS_DISPLAY");
            entity.Property(e => e.ZsFound).HasColumnName("ZS_FOUND");
            entity.Property(e => e.ZsKey)
                .HasMaxLength(300)
                .HasColumnName("ZS_KEY");
            entity.Property(e => e.ZsServerDescription)
                .HasMaxLength(300)
                .HasColumnName("ZS_SERVER_DESCRIPTION");
            entity.Property(e => e.ZsServerId).HasColumnName("ZS_SERVER_ID");
            entity.Property(e => e.ZsUniqueId)
                .HasMaxLength(100)
                .HasColumnName("ZS_UNIQUE_ID");
        });

        modelBuilder.Entity<ZwebSystab>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ZWEB_SYSTAB");

            entity.Property(e => e.ZsUnique).HasColumnName("ZS_UNIQUE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

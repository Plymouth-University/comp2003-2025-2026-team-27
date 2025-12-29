using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Lms.Data.Models.Delocal;

public partial class DelocalContext : DbContext
{
    public DelocalContext()
    {
    }

    public DelocalContext(DbContextOptions<DelocalContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AdBorAddDataConfig> AdBorAddDataConfigs { get; set; }

    public virtual DbSet<AdOperatorLogin> AdOperatorLogins { get; set; }

    public virtual DbSet<Ans247libButton> Ans247libButtons { get; set; }

    public virtual DbSet<Ans247libButtonOper> Ans247libButtonOpers { get; set; }

    public virtual DbSet<Ans247libButtonProfile> Ans247libButtonProfiles { get; set; }

    public virtual DbSet<Ans247libCircdeskConfigProfile> Ans247libCircdeskConfigProfiles { get; set; }

    public virtual DbSet<Ans247libLabel> Ans247libLabels { get; set; }

    public virtual DbSet<Ans247libLabelsTran> Ans247libLabelsTrans { get; set; }

    public virtual DbSet<Ans247libScreen> Ans247libScreens { get; set; }

    public virtual DbSet<Ans247libScreenOper> Ans247libScreenOpers { get; set; }

    public virtual DbSet<Ans247libScreenProfile> Ans247libScreenProfiles { get; set; }

    public virtual DbSet<AnsActionSecurity> AnsActionSecurities { get; set; }

    public virtual DbSet<AnsActionSecurityOper> AnsActionSecurityOpers { get; set; }

    public virtual DbSet<AnsActionSecurityProfile> AnsActionSecurityProfiles { get; set; }

    public virtual DbSet<AnsProfile> AnsProfiles { get; set; }

    public virtual DbSet<AnsProfileOper> AnsProfileOpers { get; set; }

    public virtual DbSet<AnsSystemMessage> AnsSystemMessages { get; set; }

    public virtual DbSet<AnsSystemMessageArabic> AnsSystemMessageArabics { get; set; }

    public virtual DbSet<AnsSystemMessageOrig> AnsSystemMessageOrigs { get; set; }

    public virtual DbSet<AppointmentTag> AppointmentTags { get; set; }

    public virtual DbSet<Area> Areas { get; set; }

    public virtual DbSet<AreaOld> AreaOlds { get; set; }

    public virtual DbSet<AreaTranslation> AreaTranslations { get; set; }

    public virtual DbSet<AuthorityChild> AuthorityChildren { get; set; }

    public virtual DbSet<BorAddDataConfig> BorAddDataConfigs { get; set; }

    public virtual DbSet<BorAddDataDdlContent> BorAddDataDdlContents { get; set; }

    public virtual DbSet<BorAddDataDdlDescription> BorAddDataDdlDescriptions { get; set; }

    public virtual DbSet<BorClass> BorClasses { get; set; }

    public virtual DbSet<BorClassesOld> BorClassesOlds { get; set; }

    public virtual DbSet<BorClassesTranslation> BorClassesTranslations { get; set; }

    public virtual DbSet<BorEditCatalogue> BorEditCatalogues { get; set; }

    public virtual DbSet<BorGroup> BorGroups { get; set; }

    public virtual DbSet<BorGroupsOld> BorGroupsOlds { get; set; }

    public virtual DbSet<BorGroupsTranslation> BorGroupsTranslations { get; set; }

    public virtual DbSet<BorHistoryNotesCategory> BorHistoryNotesCategories { get; set; }

    public virtual DbSet<BorHistoryNotesGroup> BorHistoryNotesGroups { get; set; }

    public virtual DbSet<BorHistoryNotesResult> BorHistoryNotesResults { get; set; }

    public virtual DbSet<BorHistoryNotesType> BorHistoryNotesTypes { get; set; }

    public virtual DbSet<BorImportFormat> BorImportFormats { get; set; }

    public virtual DbSet<BorImportFormatColumn> BorImportFormatColumns { get; set; }

    public virtual DbSet<BorStatus> BorStatuses { get; set; }

    public virtual DbSet<BorStatusOld> BorStatusOlds { get; set; }

    public virtual DbSet<BorStatusTranslation> BorStatusTranslations { get; set; }

    public virtual DbSet<BorTitle> BorTitles { get; set; }

    public virtual DbSet<BorType> BorTypes { get; set; }

    public virtual DbSet<BorTypesOld> BorTypesOlds { get; set; }

    public virtual DbSet<BorTypesTranslation> BorTypesTranslations { get; set; }

    public virtual DbSet<Borvalidparam> Borvalidparams { get; set; }

    public virtual DbSet<Calendar> Calendars { get; set; }

    public virtual DbSet<CashDenomination> CashDenominations { get; set; }

    public virtual DbSet<CashTill> CashTills { get; set; }

    public virtual DbSet<CashTillOperator> CashTillOperators { get; set; }

    public virtual DbSet<CatalogueEngagement> CatalogueEngagements { get; set; }

    public virtual DbSet<CatdisplayTag> CatdisplayTags { get; set; }

    public virtual DbSet<CatdisplayTagsTranslation> CatdisplayTagsTranslations { get; set; }

    public virtual DbSet<CatleadthruTag> CatleadthruTags { get; set; }

    public virtual DbSet<CatleadthruTagsExtra> CatleadthruTagsExtras { get; set; }

    public virtual DbSet<CatleadthruTagsExtraOld> CatleadthruTagsExtraOlds { get; set; }

    public virtual DbSet<CatleadthruTagsExtraTranslation> CatleadthruTagsExtraTranslations { get; set; }

    public virtual DbSet<CatorderdateSfdef> CatorderdateSfdefs { get; set; }

    public virtual DbSet<CatorderdateSfdefTranslation> CatorderdateSfdefTranslations { get; set; }

    public virtual DbSet<CiCatdisplayTag> CiCatdisplayTags { get; set; }

    public virtual DbSet<CiCatleadthrutag> CiCatleadthrutags { get; set; }

    public virtual DbSet<CiFacStatsCode> CiFacStatsCodes { get; set; }

    public virtual DbSet<CiKwordDesc> CiKwordDescs { get; set; }

    public virtual DbSet<CiKwordStoplist> CiKwordStoplists { get; set; }

    public virtual DbSet<CiMWord> CiMWords { get; set; }

    public virtual DbSet<CiOpacTagdef> CiOpacTagdefs { get; set; }

    public virtual DbSet<CiOrgClass> CiOrgClasses { get; set; }

    public virtual DbSet<CiTagCatNice> CiTagCatNices { get; set; }

    public virtual DbSet<CiTagGroup> CiTagGroups { get; set; }

    public virtual DbSet<CiTagNice> CiTagNices { get; set; }

    public virtual DbSet<CiTagSfdef> CiTagSfdefs { get; set; }

    public virtual DbSet<CiTagTagdef> CiTagTagdefs { get; set; }

    public virtual DbSet<ClassType> ClassTypes { get; set; }

    public virtual DbSet<ClassTypesTranslation> ClassTypesTranslations { get; set; }

    public virtual DbSet<CopyInfoReal> CopyInfoReals { get; set; }

    public virtual DbSet<Copyinforealremovedup> Copyinforealremovedups { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<DbColumnDescription> DbColumnDescriptions { get; set; }

    public virtual DbSet<DbColumnDescriptionTranslation> DbColumnDescriptionTranslations { get; set; }

    public virtual DbSet<DbColumnLmsTabRelationship> DbColumnLmsTabRelationships { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<DiyFlag> DiyFlags { get; set; }

    public virtual DbSet<DiyFlagsOld> DiyFlagsOlds { get; set; }

    public virtual DbSet<DiyFlagsTranslation> DiyFlagsTranslations { get; set; }

    public virtual DbSet<EventAdditionalService> EventAdditionalServices { get; set; }

    public virtual DbSet<FinAlloc> FinAllocs { get; set; }

    public virtual DbSet<FinAllocTranslation> FinAllocTranslations { get; set; }

    public virtual DbSet<FinType> FinTypes { get; set; }

    public virtual DbSet<FinTypesOld> FinTypesOlds { get; set; }

    public virtual DbSet<FinTypesTranslation> FinTypesTranslations { get; set; }

    public virtual DbSet<GroupType> GroupTypes { get; set; }

    public virtual DbSet<GroupTypesTranslation> GroupTypesTranslations { get; set; }

    public virtual DbSet<IllDefault> IllDefaults { get; set; }

    public virtual DbSet<IllLibrary> IllLibraries { get; set; }

    public virtual DbSet<IllLibraryTranslation> IllLibraryTranslations { get; set; }

    public virtual DbSet<ImportBorClsGrpTemplateSysColumn> ImportBorClsGrpTemplateSysColumns { get; set; }

    public virtual DbSet<ImportBorSysColumn> ImportBorSysColumns { get; set; }

    public virtual DbSet<ImportBorTemplate> ImportBorTemplates { get; set; }

    public virtual DbSet<ImportBorTemplateDetail> ImportBorTemplateDetails { get; set; }

    public virtual DbSet<ImportBorTemplateSysColumn> ImportBorTemplateSysColumns { get; set; }

    public virtual DbSet<ImportWondeBorClassTemplate> ImportWondeBorClassTemplates { get; set; }

    public virtual DbSet<ImportWondeBorClassTemplateDetail> ImportWondeBorClassTemplateDetails { get; set; }

    public virtual DbSet<ImportWondeBorClassTemplateSysColumn> ImportWondeBorClassTemplateSysColumns { get; set; }

    public virtual DbSet<ImportWondeBorGrpTemplate> ImportWondeBorGrpTemplates { get; set; }

    public virtual DbSet<ImportWondeBorGrpTemplateDetail> ImportWondeBorGrpTemplateDetails { get; set; }

    public virtual DbSet<ImportWondeBorGrpTemplateSysColumn> ImportWondeBorGrpTemplateSysColumns { get; set; }

    public virtual DbSet<ImportWondeBorTemplate> ImportWondeBorTemplates { get; set; }

    public virtual DbSet<ImportWondeBorTemplateDetail> ImportWondeBorTemplateDetails { get; set; }

    public virtual DbSet<ImportWondeBorTemplateSysColumn> ImportWondeBorTemplateSysColumns { get; set; }

    public virtual DbSet<KwordDescription> KwordDescriptions { get; set; }

    public virtual DbSet<KwordDescriptionsTranslation> KwordDescriptionsTranslations { get; set; }

    public virtual DbSet<KwordStoplist> KwordStoplists { get; set; }

    public virtual DbSet<LibGroup> LibGroups { get; set; }

    public virtual DbSet<LibGroupPermit> LibGroupPermits { get; set; }

    public virtual DbSet<LibGroupsOld> LibGroupsOlds { get; set; }

    public virtual DbSet<LibGroupsTranslation> LibGroupsTranslations { get; set; }

    public virtual DbSet<LibLanguage> LibLanguages { get; set; }

    public virtual DbSet<LibLocFloor> LibLocFloors { get; set; }

    public virtual DbSet<LibLocFloorOld> LibLocFloorOlds { get; set; }

    public virtual DbSet<LibLocFloorTranslation> LibLocFloorTranslations { get; set; }

    public virtual DbSet<LibLocation> LibLocations { get; set; }

    public virtual DbSet<LibLocationsOld> LibLocationsOlds { get; set; }

    public virtual DbSet<LibLocationsTranslation> LibLocationsTranslations { get; set; }

    public virtual DbSet<LibMemo> LibMemos { get; set; }

    public virtual DbSet<LibMemosOld> LibMemosOlds { get; set; }

    public virtual DbSet<LibMemosTranslation> LibMemosTranslations { get; set; }

    public virtual DbSet<LibSection> LibSections { get; set; }

    public virtual DbSet<LibSectionsTranslation> LibSectionsTranslations { get; set; }

    public virtual DbSet<Llddcatdict> Llddcatdicts { get; set; }

    public virtual DbSet<LoanStrategy> LoanStrategies { get; set; }

    public virtual DbSet<LoanStrategyTranslation> LoanStrategyTranslations { get; set; }

    public virtual DbSet<LocHour> LocHours { get; set; }

    public virtual DbSet<LocMap> LocMaps { get; set; }

    public virtual DbSet<LocRepSmtp> LocRepSmtps { get; set; }

    public virtual DbSet<LocShelfMap> LocShelfMaps { get; set; }

    public virtual DbSet<LocalSystab> LocalSystabs { get; set; }

    public virtual DbSet<LocationTill> LocationTills { get; set; }

    public virtual DbSet<MWord> MWords { get; set; }

    public virtual DbSet<MWordsOld> MWordsOlds { get; set; }

    public virtual DbSet<MWordsTranslation> MWordsTranslations { get; set; }

    public virtual DbSet<MainMenuApp> MainMenuApps { get; set; }

    public virtual DbSet<MainMenuAppsOld> MainMenuAppsOlds { get; set; }

    public virtual DbSet<MainMenuAppsTranslation> MainMenuAppsTranslations { get; set; }

    public virtual DbSet<MeetingType> MeetingTypes { get; set; }

    public virtual DbSet<MeetingTypeDepartment> MeetingTypeDepartments { get; set; }

    public virtual DbSet<MeetingTypeFile> MeetingTypeFiles { get; set; }

    public virtual DbSet<NcipDataElement> NcipDataElements { get; set; }

    public virtual DbSet<NcipIndexCache> NcipIndexCaches { get; set; }

    public virtual DbSet<NcipMessage> NcipMessages { get; set; }

    public virtual DbSet<NcipMsgAttr> NcipMsgAttrs { get; set; }

    public virtual DbSet<NcipMsgHistory> NcipMsgHistories { get; set; }

    public virtual DbSet<NcipScheme> NcipSchemes { get; set; }

    public virtual DbSet<NcipSchemeRef> NcipSchemeRefs { get; set; }

    public virtual DbSet<NcipSchemeValue> NcipSchemeValues { get; set; }

    public virtual DbSet<NcipServerStatus> NcipServerStatuses { get; set; }

    public virtual DbSet<NcipSystab> NcipSystabs { get; set; }

    public virtual DbSet<NcipVersion> NcipVersions { get; set; }

    public virtual DbSet<NcipXpath> NcipXpaths { get; set; }

    public virtual DbSet<NcipXpathParam> NcipXpathParams { get; set; }

    public virtual DbSet<NetRestrict> NetRestricts { get; set; }

    public virtual DbSet<OpacApp> OpacApps { get; set; }

    public virtual DbSet<OpacAppsMenu> OpacAppsMenus { get; set; }

    public virtual DbSet<OpacButton> OpacButtons { get; set; }

    public virtual DbSet<OpacFormStat> OpacFormStats { get; set; }

    public virtual DbSet<OpacFormStatsOld> OpacFormStatsOlds { get; set; }

    public virtual DbSet<OpacFormStatsTranslation> OpacFormStatsTranslations { get; set; }

    public virtual DbSet<OpacLibGroupsStyle> OpacLibGroupsStyles { get; set; }

    public virtual DbSet<OpacMainMenu> OpacMainMenus { get; set; }

    public virtual DbSet<OpacMessage> OpacMessages { get; set; }

    public virtual DbSet<OpacNice> OpacNices { get; set; }

    public virtual DbSet<OpacOperator> OpacOperators { get; set; }

    public virtual DbSet<OpacOther> OpacOthers { get; set; }

    public virtual DbSet<OpacParam> OpacParams { get; set; }

    public virtual DbSet<OpacRestrict> OpacRestricts { get; set; }

    public virtual DbSet<OpacTagdef> OpacTagdefs { get; set; }

    public virtual DbSet<OpacTagdefOld> OpacTagdefOlds { get; set; }

    public virtual DbSet<OpacTagdefTranslation> OpacTagdefTranslations { get; set; }

    public virtual DbSet<OpacUserTypeMenu> OpacUserTypeMenus { get; set; }

    public virtual DbSet<Opacuserquery> Opacuserqueries { get; set; }

    public virtual DbSet<OpacuserquerySearchCatFilter> OpacuserquerySearchCatFilters { get; set; }

    public virtual DbSet<OpacuserquerySearchDefinition> OpacuserquerySearchDefinitions { get; set; }

    public virtual DbSet<OperDomainuser> OperDomainusers { get; set; }

    public virtual DbSet<OperMenuSecurity> OperMenuSecurities { get; set; }

    public virtual DbSet<OperSecurity> OperSecurities { get; set; }

    public virtual DbSet<Operator> Operators { get; set; }

    public virtual DbSet<OperatorLogonToken> OperatorLogonTokens { get; set; }

    public virtual DbSet<OrdCondition> OrdConditions { get; set; }

    public virtual DbSet<OrdConditionOld> OrdConditionOlds { get; set; }

    public virtual DbSet<OrdConditionTranslation> OrdConditionTranslations { get; set; }

    public virtual DbSet<OrdConvForm> OrdConvForms { get; set; }

    public virtual DbSet<OrdType> OrdTypes { get; set; }

    public virtual DbSet<OrdTypeOld> OrdTypeOlds { get; set; }

    public virtual DbSet<OrdTypeTranslation> OrdTypeTranslations { get; set; }

    public virtual DbSet<PasswordValidation> PasswordValidations { get; set; }

    public virtual DbSet<PaymentType> PaymentTypes { get; set; }

    public virtual DbSet<PerCode> PerCodes { get; set; }

    public virtual DbSet<PerCodesOld> PerCodesOlds { get; set; }

    public virtual DbSet<PerCodesTranslation> PerCodesTranslations { get; set; }

    public virtual DbSet<PredefinedQueryOption> PredefinedQueryOptions { get; set; }

    public virtual DbSet<PredefinedQueryOptionTranslation> PredefinedQueryOptionTranslations { get; set; }

    public virtual DbSet<Priorattaindict> Priorattaindicts { get; set; }

    public virtual DbSet<QueryOptionDate> QueryOptionDates { get; set; }

    public virtual DbSet<RetentionCode> RetentionCodes { get; set; }

    public virtual DbSet<RisRefType> RisRefTypes { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    public virtual DbSet<ServiceType> ServiceTypes { get; set; }

    public virtual DbSet<SoundTable> SoundTables { get; set; }

    public virtual DbSet<SoundTableOld> SoundTableOlds { get; set; }

    public virtual DbSet<SoundTableTranslation> SoundTableTranslations { get; set; }

    public virtual DbSet<StatsCode> StatsCodes { get; set; }

    public virtual DbSet<StatsCodesTranslation> StatsCodesTranslations { get; set; }

    public virtual DbSet<StkCallSet> StkCallSets { get; set; }

    public virtual DbSet<StkCallSetsOld> StkCallSetsOlds { get; set; }

    public virtual DbSet<StkCallSetsTranslation> StkCallSetsTranslations { get; set; }

    public virtual DbSet<StkClass> StkClasses { get; set; }

    public virtual DbSet<StkClassTranslation> StkClassTranslations { get; set; }

    public virtual DbSet<StkCode> StkCodes { get; set; }

    public virtual DbSet<StkCodesOld> StkCodesOlds { get; set; }

    public virtual DbSet<StkCodesTranslation> StkCodesTranslations { get; set; }

    public virtual DbSet<StkForm> StkForms { get; set; }

    public virtual DbSet<StkFormBor> StkFormBors { get; set; }

    public virtual DbSet<StkFormCat> StkFormCats { get; set; }

    public virtual DbSet<StkFormRecurringFeeBor> StkFormRecurringFeeBors { get; set; }

    public virtual DbSet<StkFormTcBor> StkFormTcBors { get; set; }

    public virtual DbSet<StkFormsOld> StkFormsOlds { get; set; }

    public virtual DbSet<StkFormsTranslation> StkFormsTranslations { get; set; }

    public virtual DbSet<StkIllStatus> StkIllStatuses { get; set; }

    public virtual DbSet<StkIllStatusOld> StkIllStatusOlds { get; set; }

    public virtual DbSet<StkIllStatusTranslation> StkIllStatusTranslations { get; set; }

    public virtual DbSet<StkItemOrigin> StkItemOrigins { get; set; }

    public virtual DbSet<StkItemOriginsOld> StkItemOriginsOlds { get; set; }

    public virtual DbSet<StkItemOriginsTranslation> StkItemOriginsTranslations { get; set; }

    public virtual DbSet<StkLoanType> StkLoanTypes { get; set; }

    public virtual DbSet<StkLoanTypesOld> StkLoanTypesOlds { get; set; }

    public virtual DbSet<StkLoanTypesTranslation> StkLoanTypesTranslations { get; set; }

    public virtual DbSet<StkLoantBor> StkLoantBors { get; set; }

    public virtual DbSet<StkProcess> StkProcesses { get; set; }

    public virtual DbSet<StkStatsBor> StkStatsBors { get; set; }

    public virtual DbSet<StkStatsCat> StkStatsCats { get; set; }

    public virtual DbSet<StkStatsCost> StkStatsCosts { get; set; }

    public virtual DbSet<StkStatsGroup> StkStatsGroups { get; set; }

    public virtual DbSet<StkStatsGroupOld> StkStatsGroupOlds { get; set; }

    public virtual DbSet<StkStatsGroupTranslation> StkStatsGroupTranslations { get; set; }

    public virtual DbSet<StkStoplist> StkStoplists { get; set; }

    public virtual DbSet<StkdisplayTag> StkdisplayTags { get; set; }

    public virtual DbSet<StkdisplayTagsOld> StkdisplayTagsOlds { get; set; }

    public virtual DbSet<StkdisplayTagsTranslation> StkdisplayTagsTranslations { get; set; }

    public virtual DbSet<Stkvalidparam> Stkvalidparams { get; set; }

    public virtual DbSet<Suburb> Suburbs { get; set; }

    public virtual DbSet<SuburbOld> SuburbOlds { get; set; }

    public virtual DbSet<SuburbTranslation> SuburbTranslations { get; set; }

    public virtual DbSet<SysPasswordValidation> SysPasswordValidations { get; set; }

    public virtual DbSet<TableViewConfig> TableViewConfigs { get; set; }

    public virtual DbSet<TagCatNice> TagCatNices { get; set; }

    public virtual DbSet<TagFixedParam> TagFixedParams { get; set; }

    public virtual DbSet<TagGroup> TagGroups { get; set; }

    public virtual DbSet<TagItemdef> TagItemdefs { get; set; }

    public virtual DbSet<TagItemdefTranslation> TagItemdefTranslations { get; set; }

    public virtual DbSet<TagItemdefTranslationBase> TagItemdefTranslationBases { get; set; }

    public virtual DbSet<TagNice> TagNices { get; set; }

    public virtual DbSet<TagSfdef> TagSfdefs { get; set; }

    public virtual DbSet<TagSfdefOld> TagSfdefOlds { get; set; }

    public virtual DbSet<TagSfdefTranslation> TagSfdefTranslations { get; set; }

    public virtual DbSet<TagTagdef> TagTagdefs { get; set; }

    public virtual DbSet<TagTagdefOld> TagTagdefOlds { get; set; }

    public virtual DbSet<TagTagdefTranslation> TagTagdefTranslations { get; set; }

    public virtual DbSet<Tagsfoundinimport> Tagsfoundinimports { get; set; }

    public virtual DbSet<Team> Teams { get; set; }

    public virtual DbSet<TeamsRetCode> TeamsRetCodes { get; set; }

    public virtual DbSet<TempFilelist> TempFilelists { get; set; }

    public virtual DbSet<VisitorType> VisitorTypes { get; set; }

    public virtual DbSet<Ward> Wards { get; set; }

    public virtual DbSet<WardOld> WardOlds { get; set; }

    public virtual DbSet<WardTranslation> WardTranslations { get; set; }

    public virtual DbSet<WebApp> WebApps { get; set; }

    public virtual DbSet<WebAppMsg> WebAppMsgs { get; set; }

    public virtual DbSet<WebAppScreen> WebAppScreens { get; set; }

    public virtual DbSet<WebButtonAllow> WebButtonAllows { get; set; }

    public virtual DbSet<WebButtonProgram> WebButtonPrograms { get; set; }

    public virtual DbSet<WebButtonUser> WebButtonUsers { get; set; }

    public virtual DbSet<WebMenu> WebMenus { get; set; }

    public virtual DbSet<WebMenuPermit> WebMenuPermits { get; set; }

    public virtual DbSet<WebTask> WebTasks { get; set; }

    public virtual DbSet<WebTaskSystab> WebTaskSystabs { get; set; }

    public virtual DbSet<WebUserMenu> WebUserMenus { get; set; }

    public virtual DbSet<Z3950Attr> Z3950Attrs { get; set; }

    public virtual DbSet<Z3950AttrLink> Z3950AttrLinks { get; set; }

    public virtual DbSet<Z3950AttrOld> Z3950AttrOlds { get; set; }

    public virtual DbSet<Z3950AttrTranslation> Z3950AttrTranslations { get; set; }

    public virtual DbSet<Z3950Group> Z3950Groups { get; set; }

    public virtual DbSet<Z3950GroupOld> Z3950GroupOlds { get; set; }

    public virtual DbSet<Z3950GroupTranslation> Z3950GroupTranslations { get; set; }

    public virtual DbSet<Z3950Option> Z3950Options { get; set; }

    public virtual DbSet<Z3950Server> Z3950Servers { get; set; }

    public virtual DbSet<Z3950ServerLink> Z3950ServerLinks { get; set; }

    public virtual DbSet<Z3950ServerOld> Z3950ServerOlds { get; set; }

    public virtual DbSet<Z3950ServerTranslation> Z3950ServerTranslations { get; set; }

    public virtual DbSet<Z3950Systab> Z3950Systabs { get; set; }

    public virtual DbSet<ZopacOperAttr> ZopacOperAttrs { get; set; }

    public virtual DbSet<ZopacOperServer> ZopacOperServers { get; set; }

    public virtual DbSet<ZopacOperator> ZopacOperators { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-04GVT4U;Database=DELOCAL;User Id=sa;Password=sql123;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AdBorAddDataConfig>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AD_BOR_ADD_DATA_CONFIG");

            entity.Property(e => e.Actiontime)
                .HasPrecision(3)
                .HasColumnName("ACTIONTIME");
            entity.Property(e => e.Actiontype)
                .HasMaxLength(10)
                .HasColumnName("ACTIONTYPE");
            entity.Property(e => e.BorClasses)
                .HasMaxLength(10)
                .HasDefaultValue("-1")
                .HasColumnName("BOR_CLASSES");
            entity.Property(e => e.BorGroups)
                .HasMaxLength(10)
                .HasColumnName("BOR_GROUPS");
            entity.Property(e => e.BorType)
                .HasMaxLength(3)
                .HasColumnName("BOR_TYPE");
            entity.Property(e => e.Checkedbydefault).HasColumnName("CHECKEDBYDEFAULT");
            entity.Property(e => e.Columnid).HasColumnName("COLUMNID");
            entity.Property(e => e.Ddltablenum).HasColumnName("DDLTABLENUM");
            entity.Property(e => e.Editdatatype).HasColumnName("EDITDATATYPE");
            entity.Property(e => e.Label)
                .HasMaxLength(300)
                .HasColumnName("LABEL");
            entity.Property(e => e.Placeholdertypeid).HasColumnName("PLACEHOLDERTYPEID");
            entity.Property(e => e.Rowid).HasColumnName("ROWID");
            entity.Property(e => e.TbColumnid)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_COLUMNID");
        });

        modelBuilder.Entity<AdOperatorLogin>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AD_OPERATOR_LOGIN");

            entity.Property(e => e.AuditId)
                .ValueGeneratedOnAdd()
                .HasColumnName("AUDIT_ID");
            entity.Property(e => e.LoginSite)
                .HasMaxLength(10)
                .HasColumnName("LOGIN_SITE");
            entity.Property(e => e.LoginStatus)
                .HasMaxLength(1)
                .HasColumnName("LOGIN_STATUS");
            entity.Property(e => e.LoginUsername)
                .HasMaxLength(35)
                .HasColumnName("LOGIN_USERNAME");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<Ans247libButton>(entity =>
        {
            entity.HasKey(e => new { e.ScreenName, e.ButtonName });

            entity.ToTable("ANS_247LIB_BUTTON");

            entity.Property(e => e.ScreenName)
                .HasMaxLength(60)
                .HasColumnName("SCREEN_NAME");
            entity.Property(e => e.ButtonName)
                .HasMaxLength(60)
                .HasColumnName("BUTTON_NAME");
            entity.Property(e => e.ButtonText)
                .HasMaxLength(50)
                .HasColumnName("BUTTON_TEXT");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(25)
                .HasColumnName("LAST_UPDATE_BY");
            entity.Property(e => e.LastUpdateOn)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATE_ON");

            entity.HasOne(d => d.ScreenNameNavigation).WithMany(p => p.Ans247libButtons)
                .HasForeignKey(d => d.ScreenName)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ANS_247LIB_BUTTON_SCREEN");
        });

        modelBuilder.Entity<Ans247libButtonOper>(entity =>
        {
            entity.HasKey(e => new { e.ScreenName, e.ButtonName, e.OperName });

            entity.ToTable("ANS_247LIB_BUTTON_OPER");

            entity.Property(e => e.ScreenName)
                .HasMaxLength(60)
                .HasColumnName("SCREEN_NAME");
            entity.Property(e => e.ButtonName)
                .HasMaxLength(60)
                .HasColumnName("BUTTON_NAME");
            entity.Property(e => e.OperName)
                .HasMaxLength(25)
                .HasColumnName("OPER_NAME");
            entity.Property(e => e.Allow).HasColumnName("ALLOW");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(25)
                .HasColumnName("LAST_UPDATE_BY");
            entity.Property(e => e.LastUpdateOn)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATE_ON");

            entity.HasOne(d => d.OperNameNavigation).WithMany(p => p.Ans247libButtonOpers)
                .HasForeignKey(d => d.OperName)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ANS_BUTTON_OPER_OPERATOR");

            entity.HasOne(d => d.Ans247libButton).WithMany(p => p.Ans247libButtonOpers)
                .HasForeignKey(d => new { d.ScreenName, d.ButtonName })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ANS_BUTTON_OPER");
        });

        modelBuilder.Entity<Ans247libButtonProfile>(entity =>
        {
            entity.HasKey(e => new { e.ProfileId, e.ScreenName, e.ButtonName }).HasName("PK_ANS_247LIB_BUTTON_PROFILE_1");

            entity.ToTable("ANS_247LIB_BUTTON_PROFILE");

            entity.Property(e => e.ProfileId).HasColumnName("PROFILE_ID");
            entity.Property(e => e.ScreenName)
                .HasMaxLength(60)
                .HasColumnName("SCREEN_NAME");
            entity.Property(e => e.ButtonName)
                .HasMaxLength(60)
                .HasColumnName("BUTTON_NAME");
            entity.Property(e => e.Allow).HasColumnName("ALLOW");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(25)
                .HasColumnName("LAST_UPDATE_BY");
            entity.Property(e => e.LastUpdateOn)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATE_ON");

            entity.HasOne(d => d.Profile).WithMany(p => p.Ans247libButtonProfiles)
                .HasForeignKey(d => d.ProfileId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ANS_247LIB_BUTTON_PROFILE");

            entity.HasOne(d => d.Ans247libButton).WithMany(p => p.Ans247libButtonProfiles)
                .HasForeignKey(d => new { d.ScreenName, d.ButtonName })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ANS_247LIB_BUTTON_PROFILE_M");
        });

        modelBuilder.Entity<Ans247libCircdeskConfigProfile>(entity =>
        {
            entity.HasKey(e => e.ConfigId).HasName("ANS_247LIB_CIRCDESK_CONFIG_PROFILE_pk");

            entity.ToTable("ANS_247LIB_CIRCDESK_CONFIG_PROFILE");

            entity.Property(e => e.ConfigId).HasColumnName("CONFIG_ID");
            entity.Property(e => e.BackgroundColour)
                .HasMaxLength(10)
                .HasDefaultValue("#00BCD4")
                .HasColumnName("BACKGROUND_COLOUR");
            entity.Property(e => e.BoxColor)
                .HasMaxLength(10)
                .HasDefaultValue("#00BCD4")
                .HasColumnName("BOX_COLOR");
            entity.Property(e => e.ButtonColor)
                .HasMaxLength(10)
                .HasDefaultValue("#00BCD4")
                .HasColumnName("BUTTON_COLOR");
            entity.Property(e => e.DisplayCharges)
                .HasMaxLength(1)
                .HasDefaultValue("Y")
                .IsFixedLength()
                .HasColumnName("DISPLAY_CHARGES");
            entity.Property(e => e.DisplayDob)
                .HasMaxLength(1)
                .HasDefaultValue("Y")
                .IsFixedLength()
                .HasColumnName("DISPLAY_DOB");
            entity.Property(e => e.DisplayEmail)
                .HasMaxLength(1)
                .HasDefaultValue("Y")
                .IsFixedLength()
                .HasColumnName("DISPLAY_EMAIL");
            entity.Property(e => e.DisplayGender)
                .HasMaxLength(1)
                .HasDefaultValue("Y")
                .IsFixedLength()
                .HasColumnName("DISPLAY_GENDER");
            entity.Property(e => e.DisplayLibrary)
                .HasMaxLength(1)
                .HasDefaultValue("Y")
                .IsFixedLength()
                .HasColumnName("DISPLAY_LIBRARY");
            entity.Property(e => e.DisplayMobileno)
                .HasMaxLength(1)
                .HasDefaultValue("Y")
                .IsFixedLength()
                .HasColumnName("DISPLAY_MOBILENO");
            entity.Property(e => e.DisplayRefs)
                .HasMaxLength(1)
                .HasDefaultValue("Y")
                .IsFixedLength()
                .HasColumnName("DISPLAY_REFS");
            entity.Property(e => e.DisplayReservations)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("DISPLAY_RESERVATIONS");
            entity.Property(e => e.DisplayStatus)
                .HasMaxLength(1)
                .HasDefaultValue("Y")
                .IsFixedLength()
                .HasColumnName("DISPLAY_STATUS");
            entity.Property(e => e.DisplayUserid)
                .HasMaxLength(1)
                .HasDefaultValue("Y")
                .IsFixedLength()
                .HasColumnName("DISPLAY_USERID");
            entity.Property(e => e.ForegroundColour)
                .HasMaxLength(10)
                .HasDefaultValue("#E0F7F7")
                .HasColumnName("FOREGROUND_COLOUR");
            entity.Property(e => e.ProfileId).HasColumnName("PROFILE_ID");
            entity.Property(e => e.SearchByBarcode)
                .HasMaxLength(1)
                .HasDefaultValue("Y")
                .IsFixedLength()
                .HasColumnName("SEARCH_BY_BARCODE");
            entity.Property(e => e.SearchByDob)
                .HasMaxLength(1)
                .HasDefaultValue("Y")
                .IsFixedLength()
                .HasColumnName("SEARCH_BY_DOB");
            entity.Property(e => e.SearchByName)
                .HasMaxLength(1)
                .HasDefaultValue("Y")
                .IsFixedLength()
                .HasColumnName("SEARCH_BY_NAME");
            entity.Property(e => e.TextColor)
                .HasMaxLength(10)
                .HasDefaultValue("#FFFFFF")
                .HasColumnName("TEXT_COLOR");

            entity.HasOne(d => d.Profile).WithMany(p => p.Ans247libCircdeskConfigProfiles)
                .HasForeignKey(d => d.ProfileId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ANS_247LIB_CIRCDESK_CONFIG_PROFILE_ANS_PROFILE_PROFILE_ID_fk");
        });

        modelBuilder.Entity<Ans247libLabel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ANS_247LIB_LABELS");

            entity.Property(e => e.LabelName)
                .HasMaxLength(100)
                .HasColumnName("LABEL_NAME");
            entity.Property(e => e.LabelText)
                .HasMaxLength(100)
                .HasColumnName("LABEL_TEXT");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(25)
                .HasColumnName("LAST_UPDATE_BY");
            entity.Property(e => e.LastUpdateOn)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATE_ON");
            entity.Property(e => e.RelatedControl)
                .HasMaxLength(100)
                .HasColumnName("RELATED_CONTROL");
            entity.Property(e => e.ScreenName)
                .HasMaxLength(60)
                .HasColumnName("SCREEN_NAME");
            entity.Property(e => e.Visible)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("VISIBLE");
        });

        modelBuilder.Entity<Ans247libLabelsTran>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ANS_247LIB_LABELS_TRANS");

            entity.Property(e => e.LabelName)
                .HasMaxLength(100)
                .HasColumnName("LABEL_NAME");
            entity.Property(e => e.LabelText)
                .HasMaxLength(100)
                .HasColumnName("LABEL_TEXT");
            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.ScreenName)
                .HasMaxLength(60)
                .HasColumnName("SCREEN_NAME");
        });

        modelBuilder.Entity<Ans247libScreen>(entity =>
        {
            entity.HasKey(e => e.ScreenName);

            entity.ToTable("ANS_247LIB_SCREEN");

            entity.Property(e => e.ScreenName)
                .HasMaxLength(60)
                .HasColumnName("SCREEN_NAME");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(25)
                .HasColumnName("LAST_UPDATE_BY");
            entity.Property(e => e.LastUpdateOn)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATE_ON");
            entity.Property(e => e.ScreenDescription)
                .HasMaxLength(240)
                .HasColumnName("SCREEN_DESCRIPTION");
        });

        modelBuilder.Entity<Ans247libScreenOper>(entity =>
        {
            entity.HasKey(e => new { e.ScreenName, e.OperName });

            entity.ToTable("ANS_247LIB_SCREEN_OPER");

            entity.Property(e => e.ScreenName)
                .HasMaxLength(60)
                .HasColumnName("SCREEN_NAME");
            entity.Property(e => e.OperName)
                .HasMaxLength(25)
                .HasColumnName("OPER_NAME");
            entity.Property(e => e.Allow).HasColumnName("ALLOW");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(25)
                .HasColumnName("LAST_UPDATE_BY");
            entity.Property(e => e.LastUpdateOn)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATE_ON");

            entity.HasOne(d => d.OperNameNavigation).WithMany(p => p.Ans247libScreenOpers)
                .HasForeignKey(d => d.OperName)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ANS_247LIB_SCREEN_OPER_OPERATOR");

            entity.HasOne(d => d.ScreenNameNavigation).WithMany(p => p.Ans247libScreenOpers)
                .HasForeignKey(d => d.ScreenName)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ANS_247LIB_SCREEN_OPER_ANS_247LIB_SCREEN");
        });

        modelBuilder.Entity<Ans247libScreenProfile>(entity =>
        {
            entity.HasKey(e => new { e.ProfileId, e.ScreenName });

            entity.ToTable("ANS_247LIB_SCREEN_PROFILE");

            entity.Property(e => e.ProfileId).HasColumnName("PROFILE_ID");
            entity.Property(e => e.ScreenName)
                .HasMaxLength(60)
                .HasColumnName("SCREEN_NAME");
            entity.Property(e => e.Allow).HasColumnName("ALLOW");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(25)
                .HasColumnName("LAST_UPDATE_BY");
            entity.Property(e => e.LastUpdateOn)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATE_ON");

            entity.HasOne(d => d.Profile).WithMany(p => p.Ans247libScreenProfiles)
                .HasForeignKey(d => d.ProfileId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ANS_247LIB_SCREEN_PROFILE_ANS_PROFILE");

            entity.HasOne(d => d.ScreenNameNavigation).WithMany(p => p.Ans247libScreenProfiles)
                .HasForeignKey(d => d.ScreenName)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ANS_247LIB_SCREEN_PROFILE_ANS_247LIB_SCREEN");
        });

        modelBuilder.Entity<AnsActionSecurity>(entity =>
        {
            entity.HasKey(e => e.ActionId);

            entity.ToTable("ANS_ACTION_SECURITY");

            entity.Property(e => e.ActionId)
                .ValueGeneratedNever()
                .HasColumnName("ACTION_ID");
            entity.Property(e => e.ActionDesc)
                .HasMaxLength(200)
                .HasColumnName("ACTION_DESC");
            entity.Property(e => e.ActionName)
                .HasMaxLength(50)
                .HasColumnName("ACTION_NAME");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(25)
                .HasColumnName("LAST_UPDATE_BY");
            entity.Property(e => e.LastUpdateOn)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATE_ON");
        });

        modelBuilder.Entity<AnsActionSecurityOper>(entity =>
        {
            entity.HasKey(e => new { e.ActionId, e.OperName });

            entity.ToTable("ANS_ACTION_SECURITY_OPER");

            entity.Property(e => e.ActionId).HasColumnName("ACTION_ID");
            entity.Property(e => e.OperName)
                .HasMaxLength(25)
                .HasColumnName("OPER_NAME");
            entity.Property(e => e.Allow).HasColumnName("ALLOW");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(25)
                .HasColumnName("LAST_UPDATE_BY");
            entity.Property(e => e.LastUpdateOn)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATE_ON");

            entity.HasOne(d => d.Action).WithMany(p => p.AnsActionSecurityOpers)
                .HasForeignKey(d => d.ActionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ANS_ACTION_SECURITY_OPER_M");

            entity.HasOne(d => d.OperNameNavigation).WithMany(p => p.AnsActionSecurityOpers)
                .HasForeignKey(d => d.OperName)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ANS_ACTION_SECURITY_OPER");
        });

        modelBuilder.Entity<AnsActionSecurityProfile>(entity =>
        {
            entity.HasKey(e => new { e.ProfileId, e.ActionId });

            entity.ToTable("ANS_ACTION_SECURITY_PROFILE");

            entity.Property(e => e.ProfileId).HasColumnName("PROFILE_ID");
            entity.Property(e => e.ActionId).HasColumnName("ACTION_ID");
            entity.Property(e => e.Allow).HasColumnName("ALLOW");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(25)
                .HasColumnName("LAST_UPDATE_BY");
            entity.Property(e => e.LastUpdateOn)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATE_ON");

            entity.HasOne(d => d.Action).WithMany(p => p.AnsActionSecurityProfiles)
                .HasForeignKey(d => d.ActionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ANS_ACTION_SECURITY_PRO_M");

            entity.HasOne(d => d.Profile).WithMany(p => p.AnsActionSecurityProfiles)
                .HasForeignKey(d => d.ProfileId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ANS_ACTION_SECURITY_PRO");
        });

        modelBuilder.Entity<AnsProfile>(entity =>
        {
            entity.HasKey(e => e.ProfileId);

            entity.ToTable("ANS_PROFILE");

            entity.Property(e => e.ProfileId)
                .ValueGeneratedNever()
                .HasColumnName("PROFILE_ID");
            entity.Property(e => e.Administrator).HasColumnName("ADMINISTRATOR");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(25)
                .HasColumnName("LAST_UPDATE_BY");
            entity.Property(e => e.LastUpdateOn)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATE_ON");
            entity.Property(e => e.ProfileName)
                .HasMaxLength(50)
                .HasColumnName("PROFILE_NAME");
        });

        modelBuilder.Entity<AnsProfileOper>(entity =>
        {
            entity.HasKey(e => new { e.ProfileId, e.OperName });

            entity.ToTable("ANS_PROFILE_OPER");

            entity.Property(e => e.ProfileId).HasColumnName("PROFILE_ID");
            entity.Property(e => e.OperName)
                .HasMaxLength(25)
                .HasColumnName("OPER_NAME");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(25)
                .HasColumnName("LAST_UPDATE_BY");
            entity.Property(e => e.LastUpdateOn)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATE_ON");

            entity.HasOne(d => d.OperNameNavigation).WithMany(p => p.AnsProfileOpers)
                .HasForeignKey(d => d.OperName)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ANS_PROFILE_OPER_OPERATOR");

            entity.HasOne(d => d.Profile).WithMany(p => p.AnsProfileOpers)
                .HasForeignKey(d => d.ProfileId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ANS_PROFILE_OPER_ANS_PROFILE");
        });

        modelBuilder.Entity<AnsSystemMessage>(entity =>
        {
            entity.HasKey(e => new { e.MessageId, e.Lcid }).HasName("PK_ANS_SYSTEM_MESSAGE_");

            entity.ToTable("ANS_SYSTEM_MESSAGE");

            entity.Property(e => e.MessageId)
                .HasMaxLength(50)
                .HasColumnName("MESSAGE_ID");
            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.CacheFlag).HasColumnName("CACHE_FLAG");
            entity.Property(e => e.ConfirmationFlag).HasColumnName("CONFIRMATION_FLAG");
            entity.Property(e => e.Error).HasColumnName("ERROR");
            entity.Property(e => e.Message)
                .HasMaxLength(500)
                .HasColumnName("MESSAGE");
            entity.Property(e => e.ModuleId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("MODULE_ID");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .HasColumnName("TITLE");
        });

        modelBuilder.Entity<AnsSystemMessageArabic>(entity =>
        {
            entity.HasKey(e => new { e.MessageId, e.Lcid });

            entity.ToTable("ANS_SYSTEM_MESSAGE_ARABIC");

            entity.Property(e => e.MessageId)
                .HasMaxLength(50)
                .HasColumnName("MESSAGE_ID");
            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.CacheFlag).HasColumnName("CACHE_FLAG");
            entity.Property(e => e.ConfirmationFlag).HasColumnName("CONFIRMATION_FLAG");
            entity.Property(e => e.Error).HasColumnName("ERROR");
            entity.Property(e => e.Message)
                .HasMaxLength(500)
                .HasColumnName("MESSAGE");
            entity.Property(e => e.ModuleId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("MODULE_ID");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .HasColumnName("TITLE");
        });

        modelBuilder.Entity<AnsSystemMessageOrig>(entity =>
        {
            entity.HasKey(e => new { e.MessageId, e.Lcid }).HasName("PK_ANS_SYSTEM_MESSAGE");

            entity.ToTable("ANS_SYSTEM_MESSAGE_ORIG");

            entity.Property(e => e.MessageId)
                .HasMaxLength(50)
                .HasColumnName("MESSAGE_ID");
            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.CacheFlag).HasColumnName("CACHE_FLAG");
            entity.Property(e => e.ConfirmationFlag).HasColumnName("CONFIRMATION_FLAG");
            entity.Property(e => e.Error).HasColumnName("ERROR");
            entity.Property(e => e.Message)
                .HasMaxLength(500)
                .HasColumnName("MESSAGE");
            entity.Property(e => e.ModuleId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("MODULE_ID");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .HasColumnName("TITLE");
        });

        modelBuilder.Entity<AppointmentTag>(entity =>
        {
            entity.HasKey(e => e.AppointmentTagsid).HasName("PK_dbo.APPOINTMENT_TAGS");

            entity.ToTable("APPOINTMENT_TAGS");

            entity.Property(e => e.AppointmentTagsid).HasColumnName("APPOINTMENT_TAGSID");
            entity.Property(e => e.DeleteFlag).HasColumnName("DELETE_FLAG");
            entity.Property(e => e.Description).HasColumnName("DESCRIPTION");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(250)
                .HasColumnName("LAST_UPDATED_BY");
            entity.Property(e => e.LastUpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATED_DATE");
            entity.Property(e => e.MeetingTypesid).HasColumnName("MEETING_TYPESID");

            entity.HasOne(d => d.MeetingTypes).WithMany(p => p.AppointmentTags)
                .HasForeignKey(d => d.MeetingTypesid)
                .HasConstraintName("FK_dbo.APPOINTMENT_TAGS_dbo.MEETING_TYPES_MEETING_TYPESID");
        });

        modelBuilder.Entity<Area>(entity =>
        {
            entity.HasKey(e => e.AreaCode);

            entity.ToTable("AREA");

            entity.Property(e => e.AreaCode)
                .HasMaxLength(10)
                .HasColumnName("AREA_CODE");
            entity.Property(e => e.AreaName)
                .HasMaxLength(75)
                .HasColumnName("AREA_NAME");
            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");
        });

        modelBuilder.Entity<AreaOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AREA_OLD");

            entity.Property(e => e.AreaCode)
                .HasMaxLength(10)
                .HasColumnName("AREA_CODE");
            entity.Property(e => e.AreaName)
                .HasMaxLength(75)
                .HasColumnName("AREA_NAME");
        });

        modelBuilder.Entity<AreaTranslation>(entity =>
        {
            entity.HasKey(e => new { e.AreaCode, e.Lcid });

            entity.ToTable("AREA_TRANSLATION");

            entity.Property(e => e.AreaCode)
                .HasMaxLength(10)
                .HasColumnName("AREA_CODE");
            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.AreaName)
                .HasMaxLength(75)
                .HasColumnName("AREA_NAME");

            entity.HasOne(d => d.AreaCodeNavigation).WithMany(p => p.AreaTranslations)
                .HasForeignKey(d => d.AreaCode)
                .HasConstraintName("FK_AREA_AREA_TRANSLATION");
        });

        modelBuilder.Entity<AuthorityChild>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AUTHORITY_CHILD");

            entity.HasIndex(e => e.AuthNoChild, "IX_AUTHORITY_CHILD_CHILD");

            entity.HasIndex(e => new { e.AuthNoChild, e.Lcid }, "IX_AUTHORITY_CHILD_CHILD_LCID");

            entity.HasIndex(e => e.AuthNoParent, "IX_AUTHORITY_CHILD_PARENT");

            entity.HasIndex(e => new { e.AuthNoParent, e.AuthNoChild, e.Lcid }, "UQ_AUTHORITY_CHILD").IsUnique();

            entity.Property(e => e.AuthNoChild).HasColumnName("AUTH_NO_CHILD");
            entity.Property(e => e.AuthNoParent).HasColumnName("AUTH_NO_PARENT");
            entity.Property(e => e.Lcid).HasColumnName("LCID");
        });

        modelBuilder.Entity<BorAddDataConfig>(entity =>
        {
            entity.HasKey(e => new { e.Rowid, e.Columnid, e.BorType, e.BorGroups, e.BorClasses });

            entity.ToTable("BOR_ADD_DATA_CONFIG");

            entity.Property(e => e.Rowid).HasColumnName("ROWID");
            entity.Property(e => e.Columnid).HasColumnName("COLUMNID");
            entity.Property(e => e.BorType)
                .HasMaxLength(10)
                .HasColumnName("BOR_TYPE");
            entity.Property(e => e.BorGroups)
                .HasMaxLength(10)
                .HasColumnName("BOR_GROUPS");
            entity.Property(e => e.BorClasses)
                .HasMaxLength(10)
                .HasDefaultValue("-1")
                .HasColumnName("BOR_CLASSES");
            entity.Property(e => e.Checkedbydefault).HasColumnName("CHECKEDBYDEFAULT");
            entity.Property(e => e.Ddltablenum).HasColumnName("DDLTABLENUM");
            entity.Property(e => e.Editdatatype).HasColumnName("EDITDATATYPE");
            entity.Property(e => e.Label)
                .HasMaxLength(300)
                .HasColumnName("LABEL");
            entity.Property(e => e.Placeholdertypeid).HasColumnName("PLACEHOLDERTYPEID");
            entity.Property(e => e.TbColumnid)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_COLUMNID");
        });

        modelBuilder.Entity<BorAddDataDdlContent>(entity =>
        {
            entity.HasKey(e => new { e.Ddltablenum, e.Id });

            entity.ToTable("BOR_ADD_DATA_DDL_CONTENT");

            entity.Property(e => e.Ddltablenum).HasColumnName("DDLTABLENUM");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Value)
                .HasMaxLength(300)
                .HasColumnName("VALUE");
        });

        modelBuilder.Entity<BorAddDataDdlDescription>(entity =>
        {
            entity.HasKey(e => e.Ddltablenum);

            entity.ToTable("BOR_ADD_DATA_DDL_DESCRIPTION");

            entity.Property(e => e.Ddltablenum).HasColumnName("DDLTABLENUM");
            entity.Property(e => e.Tabledescription)
                .HasMaxLength(300)
                .HasColumnName("TABLEDESCRIPTION");
        });

        modelBuilder.Entity<BorClass>(entity =>
        {
            entity.HasKey(e => e.BcClass);

            entity.ToTable("BOR_CLASSES");

            entity.Property(e => e.BcClass)
                .HasMaxLength(10)
                .HasColumnName("BC_CLASS");
            entity.Property(e => e.BcName)
                .HasMaxLength(75)
                .HasColumnName("BC_NAME");
            entity.Property(e => e.ClassTypeId).HasColumnName("CLASS_TYPE_ID");
            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");
        });

        modelBuilder.Entity<BorClassesOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BOR_CLASSES_OLD");

            entity.Property(e => e.BcClass)
                .HasMaxLength(10)
                .HasColumnName("BC_CLASS");
            entity.Property(e => e.BcName)
                .HasMaxLength(75)
                .HasColumnName("BC_NAME");
        });

        modelBuilder.Entity<BorClassesTranslation>(entity =>
        {
            entity.HasKey(e => new { e.BcClass, e.Lcid });

            entity.ToTable("BOR_CLASSES_TRANSLATION");

            entity.Property(e => e.BcClass)
                .HasMaxLength(10)
                .HasColumnName("BC_CLASS");
            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.BcName)
                .HasMaxLength(75)
                .HasColumnName("BC_NAME");

            entity.HasOne(d => d.BcClassNavigation).WithMany(p => p.BorClassesTranslations)
                .HasForeignKey(d => d.BcClass)
                .HasConstraintName("FK_BOR_CLASSES_BOR_CLASSES_TRANSLATION");
        });

        modelBuilder.Entity<BorEditCatalogue>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BOR_EDIT_CATALOGUE");

            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");
            entity.Property(e => e.CatNo).HasColumnName("CAT_NO");
            entity.Property(e => e.CreateDatetime).HasColumnName("CREATE_DATETIME");
            entity.Property(e => e.EditStatus)
                .HasMaxLength(5)
                .HasColumnName("EDIT_STATUS");
            entity.Property(e => e.LastUpdatedOn).HasColumnName("LAST_UPDATED_ON");
        });

        modelBuilder.Entity<BorGroup>(entity =>
        {
            entity.HasKey(e => e.BgGroup);

            entity.ToTable("BOR_GROUPS");

            entity.Property(e => e.BgGroup)
                .HasMaxLength(10)
                .HasColumnName("BG_GROUP");
            entity.Property(e => e.BgName)
                .HasMaxLength(75)
                .HasColumnName("BG_NAME");
            entity.Property(e => e.GroupTypeId).HasColumnName("GROUP_TYPE_ID");
            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");
        });

        modelBuilder.Entity<BorGroupsOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BOR_GROUPS_OLD");

            entity.Property(e => e.BgGroup)
                .HasMaxLength(10)
                .HasColumnName("BG_GROUP");
            entity.Property(e => e.BgName)
                .HasMaxLength(75)
                .HasColumnName("BG_NAME");
        });

        modelBuilder.Entity<BorGroupsTranslation>(entity =>
        {
            entity.HasKey(e => new { e.BgGroup, e.Lcid });

            entity.ToTable("BOR_GROUPS_TRANSLATION");

            entity.Property(e => e.BgGroup)
                .HasMaxLength(10)
                .HasColumnName("BG_GROUP");
            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.BgName)
                .HasMaxLength(75)
                .HasColumnName("BG_NAME");

            entity.HasOne(d => d.BgGroupNavigation).WithMany(p => p.BorGroupsTranslations)
                .HasForeignKey(d => d.BgGroup)
                .HasConstraintName("FK_BOR_GROUPS_BOR_GROUPS_TRANSLATION");
        });

        modelBuilder.Entity<BorHistoryNotesCategory>(entity =>
        {
            entity.HasKey(e => e.BhnCategoryId);

            entity.ToTable("BOR_HISTORY_NOTES_CATEGORY");

            entity.Property(e => e.BhnCategoryId).HasColumnName("BHN_CATEGORY_ID");
            entity.Property(e => e.BhnCategory)
                .HasMaxLength(100)
                .HasColumnName("BHN_CATEGORY");
        });

        modelBuilder.Entity<BorHistoryNotesGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_BOR_HISTORY_NOTES_GROUP_GROUP");

            entity.ToTable("BOR_HISTORY_NOTES_GROUP");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CategoryId).HasColumnName("CATEGORY_ID");
            entity.Property(e => e.Value)
                .HasMaxLength(1000)
                .HasColumnName("VALUE");

            entity.HasOne(d => d.Category).WithMany(p => p.BorHistoryNotesGroups)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_BOR_HISTORY_NOTES_GROUP_BHN_CATEGORY");
        });

        modelBuilder.Entity<BorHistoryNotesResult>(entity =>
        {
            entity.HasKey(e => e.BhnResultId);

            entity.ToTable("BOR_HISTORY_NOTES_RESULT");

            entity.Property(e => e.BhnResultId).HasColumnName("BHN_RESULT_ID");
            entity.Property(e => e.BhnResult)
                .HasMaxLength(100)
                .HasColumnName("BHN_RESULT");
        });

        modelBuilder.Entity<BorHistoryNotesType>(entity =>
        {
            entity.HasKey(e => e.BhnTypeId);

            entity.ToTable("BOR_HISTORY_NOTES_TYPE");

            entity.Property(e => e.BhnTypeId).HasColumnName("BHN_TYPE_ID");
            entity.Property(e => e.BhnType)
                .HasMaxLength(100)
                .HasColumnName("BHN_TYPE");
        });

        modelBuilder.Entity<BorImportFormat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BOR_IMPORT_FORMAT");

            entity.Property(e => e.CurrentTemplate).HasColumnName("CURRENT_TEMPLATE");
            entity.Property(e => e.TemplateDesc)
                .HasMaxLength(75)
                .HasColumnName("TEMPLATE_DESC");
            entity.Property(e => e.TemplateId)
                .ValueGeneratedOnAdd()
                .HasColumnName("TEMPLATE_ID");
        });

        modelBuilder.Entity<BorImportFormatColumn>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BOR_IMPORT_FORMAT_COLUMNS");

            entity.Property(e => e.TemplateId).HasColumnName("TEMPLATE_ID");
            entity.Property(e => e.UniqueId).HasColumnName("UNIQUE_ID");
        });

        modelBuilder.Entity<BorStatus>(entity =>
        {
            entity.HasKey(e => e.BsType);

            entity.ToTable("BOR_STATUS");

            entity.Property(e => e.BsType)
                .HasMaxLength(6)
                .HasColumnName("BS_TYPE");
            entity.Property(e => e.BsBanned)
                .HasMaxLength(1)
                .HasColumnName("BS_BANNED");
            entity.Property(e => e.BsName)
                .HasMaxLength(75)
                .HasColumnName("BS_NAME");
            entity.Property(e => e.BsOverride)
                .HasMaxLength(1)
                .HasColumnName("BS_OVERRIDE");
            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");
        });

        modelBuilder.Entity<BorStatusOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BOR_STATUS_OLD");

            entity.Property(e => e.BsBanned)
                .HasMaxLength(1)
                .HasColumnName("BS_BANNED");
            entity.Property(e => e.BsName)
                .HasMaxLength(75)
                .HasColumnName("BS_NAME");
            entity.Property(e => e.BsOverride)
                .HasMaxLength(1)
                .HasColumnName("BS_OVERRIDE");
            entity.Property(e => e.BsType)
                .HasMaxLength(6)
                .HasColumnName("BS_TYPE");
        });

        modelBuilder.Entity<BorStatusTranslation>(entity =>
        {
            entity.HasKey(e => new { e.BsType, e.Lcid });

            entity.ToTable("BOR_STATUS_TRANSLATION");

            entity.Property(e => e.BsType)
                .HasMaxLength(6)
                .HasColumnName("BS_TYPE");
            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.BsName)
                .HasMaxLength(75)
                .HasColumnName("BS_NAME");

            entity.HasOne(d => d.BsTypeNavigation).WithMany(p => p.BorStatusTranslations)
                .HasForeignKey(d => d.BsType)
                .HasConstraintName("FK_BOR_STATUS_BOR_STATUS_TRANSLATION");
        });

        modelBuilder.Entity<BorTitle>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BOR_TITLES");

            entity.Property(e => e.BtSex)
                .HasMaxLength(1)
                .HasColumnName("BT_SEX");
            entity.Property(e => e.BtTitle)
                .HasMaxLength(25)
                .HasColumnName("BT_TITLE");
            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");
        });

        modelBuilder.Entity<BorType>(entity =>
        {
            entity.HasKey(e => e.BtType);

            entity.ToTable("BOR_TYPES");

            entity.Property(e => e.BtType)
                .HasMaxLength(3)
                .HasColumnName("BT_TYPE");
            entity.Property(e => e.BtAgeFrom).HasColumnName("BT_AGE_FROM");
            entity.Property(e => e.BtAgeTo).HasColumnName("BT_AGE_TO");
            entity.Property(e => e.BtExpDate)
                .HasColumnType("datetime")
                .HasColumnName("BT_EXP_DATE");
            entity.Property(e => e.BtExpDays).HasColumnName("BT_EXP_DAYS");
            entity.Property(e => e.BtFee)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("BT_FEE");
            entity.Property(e => e.BtGroup)
                .HasMaxLength(10)
                .HasColumnName("BT_GROUP");
            entity.Property(e => e.BtInTransit)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BT_IN_TRANSIT");
            entity.Property(e => e.BtKeepHistory)
                .HasMaxLength(1)
                .HasColumnName("BT_KEEP_HISTORY");
            entity.Property(e => e.BtMaxItems).HasColumnName("BT_MAX_ITEMS");
            entity.Property(e => e.BtMaxReserves).HasColumnName("BT_MAX_RESERVES");
            entity.Property(e => e.BtName)
                .HasMaxLength(75)
                .HasColumnName("BT_NAME");
            entity.Property(e => e.BtOverdueEmailCharge)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("BT_OVERDUE_EMAIL_CHARGE");
            entity.Property(e => e.BtReturnDate)
                .HasColumnType("datetime")
                .HasColumnName("BT_RETURN_DATE");
            entity.Property(e => e.BtStats)
                .HasMaxLength(1)
                .HasColumnName("BT_STATS");
            entity.Property(e => e.BtThreshold)
                .HasDefaultValue(500)
                .HasColumnName("BT_THRESHOLD");
            entity.Property(e => e.BtUserFlag1)
                .HasMaxLength(10)
                .HasColumnName("BT_USER_FLAG1");
            entity.Property(e => e.BtUserFlag1Desc)
                .HasMaxLength(75)
                .HasColumnName("BT_USER_FLAG1_DESC");
            entity.Property(e => e.BtUserFlag2)
                .HasMaxLength(10)
                .HasColumnName("BT_USER_FLAG2");
            entity.Property(e => e.BtUserFlag2Desc)
                .HasMaxLength(75)
                .HasColumnName("BT_USER_FLAG2_DESC");
            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");
        });

        modelBuilder.Entity<BorTypesOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BOR_TYPES_OLD");

            entity.HasIndex(e => e.BtType, "BT_TYPEX");

            entity.Property(e => e.BtAgeFrom).HasColumnName("BT_AGE_FROM");
            entity.Property(e => e.BtAgeTo).HasColumnName("BT_AGE_TO");
            entity.Property(e => e.BtExpDate)
                .HasColumnType("datetime")
                .HasColumnName("BT_EXP_DATE");
            entity.Property(e => e.BtExpDays).HasColumnName("BT_EXP_DAYS");
            entity.Property(e => e.BtGroup)
                .HasMaxLength(10)
                .HasColumnName("BT_GROUP");
            entity.Property(e => e.BtKeepHistory)
                .HasMaxLength(1)
                .HasColumnName("BT_KEEP_HISTORY");
            entity.Property(e => e.BtMaxItems).HasColumnName("BT_MAX_ITEMS");
            entity.Property(e => e.BtMaxReserves).HasColumnName("BT_MAX_RESERVES");
            entity.Property(e => e.BtName)
                .HasMaxLength(75)
                .HasColumnName("BT_NAME");
            entity.Property(e => e.BtReturnDate)
                .HasColumnType("datetime")
                .HasColumnName("BT_RETURN_DATE");
            entity.Property(e => e.BtStats)
                .HasMaxLength(1)
                .HasColumnName("BT_STATS");
            entity.Property(e => e.BtType)
                .HasMaxLength(3)
                .HasColumnName("BT_TYPE");
        });

        modelBuilder.Entity<BorTypesTranslation>(entity =>
        {
            entity.HasKey(e => new { e.BtType, e.Lcid });

            entity.ToTable("BOR_TYPES_TRANSLATION");

            entity.Property(e => e.BtType)
                .HasMaxLength(3)
                .HasColumnName("BT_TYPE");
            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.BtName)
                .HasMaxLength(75)
                .HasColumnName("BT_NAME");

            entity.HasOne(d => d.BtTypeNavigation).WithMany(p => p.BorTypesTranslations)
                .HasForeignKey(d => d.BtType)
                .HasConstraintName("FK_BOR_TYPES_BOR_TYPES_TRANSLATION");
        });

        modelBuilder.Entity<Borvalidparam>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BORVALIDPARAM");

            entity.Property(e => e.BaAddr1)
                .HasMaxLength(1)
                .HasColumnName("BA_ADDR1");
            entity.Property(e => e.BaAddr2)
                .HasMaxLength(1)
                .HasColumnName("BA_ADDR2");
            entity.Property(e => e.BaAddr3)
                .HasMaxLength(1)
                .HasColumnName("BA_ADDR3");
            entity.Property(e => e.BaAddr4)
                .HasMaxLength(32)
                .HasColumnName("BA_ADDR4");
            entity.Property(e => e.BaAreaCd)
                .HasMaxLength(1)
                .HasColumnName("BA_AREA_CD");
            entity.Property(e => e.BaPcode)
                .HasMaxLength(1)
                .HasColumnName("BA_PCODE");
            entity.Property(e => e.BaSuburbCd)
                .HasMaxLength(1)
                .HasColumnName("BA_SUBURB_CD");
            entity.Property(e => e.BaWardCd)
                .HasMaxLength(1)
                .HasColumnName("BA_WARD_CD");
            entity.Property(e => e.BorClass)
                .HasMaxLength(1)
                .HasColumnName("BOR_CLASS");
            entity.Property(e => e.BorDob)
                .HasMaxLength(1)
                .HasColumnName("BOR_DOB");
            entity.Property(e => e.BorGiven)
                .HasMaxLength(1)
                .HasColumnName("BOR_GIVEN");
            entity.Property(e => e.BorGroup)
                .HasMaxLength(1)
                .HasColumnName("BOR_GROUP");
            entity.Property(e => e.BorLocation)
                .HasMaxLength(1)
                .HasColumnName("BOR_LOCATION");
            entity.Property(e => e.BorPinVal)
                .HasMaxLength(1)
                .HasColumnName("BOR_PIN_VAL");
            entity.Property(e => e.BorRef1)
                .HasMaxLength(1)
                .HasColumnName("BOR_REF1");
            entity.Property(e => e.BorRef2)
                .HasMaxLength(1)
                .HasColumnName("BOR_REF2");
            entity.Property(e => e.BorSex)
                .HasMaxLength(1)
                .HasColumnName("BOR_SEX");
            entity.Property(e => e.BorStatus)
                .HasMaxLength(1)
                .HasColumnName("BOR_STATUS");
            entity.Property(e => e.BorTitle)
                .HasMaxLength(1)
                .HasColumnName("BOR_TITLE");
            entity.Property(e => e.BtType)
                .HasMaxLength(3)
                .HasColumnName("BT_TYPE");
        });

        modelBuilder.Entity<Calendar>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CALENDAR");

            entity.HasIndex(e => new { e.CaInvalidDate, e.LlCode }, "CA_DATELOCX");

            entity.Property(e => e.CaDesc)
                .HasMaxLength(25)
                .HasColumnName("CA_DESC");
            entity.Property(e => e.CaInvalidDate)
                .HasColumnType("datetime")
                .HasColumnName("CA_INVALID_DATE");
            entity.Property(e => e.LlCode)
                .HasMaxLength(20)
                .HasColumnName("LL_CODE");
        });

        modelBuilder.Entity<CashDenomination>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CASH_DENOMINATION");

            entity.Property(e => e.CashId)
                .ValueGeneratedOnAdd()
                .HasColumnName("CASH_ID");
            entity.Property(e => e.CashValue)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("CASH_VALUE");
            entity.Property(e => e.DisplayText)
                .HasMaxLength(100)
                .HasColumnName("DISPLAY_TEXT");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IS_ACTIVE");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(25)
                .HasColumnName("LAST_UPDATED_BY");
            entity.Property(e => e.LastUpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATED_ON");
            entity.Property(e => e.SortOrder).HasColumnName("SORT_ORDER");
            entity.Property(e => e.Type)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TYPE");
        });

        modelBuilder.Entity<CashTill>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CASH_TILL");

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

        modelBuilder.Entity<CashTillOperator>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CASH_TILL_OPERATOR");

            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IS_ACTIVE");
            entity.Property(e => e.Operator)
                .HasMaxLength(25)
                .HasColumnName("OPERATOR");
            entity.Property(e => e.TillId).HasColumnName("TILL_ID");
        });

        modelBuilder.Entity<CatalogueEngagement>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CATALOGUE_ENGAGEMENTS");

            entity.Property(e => e.BorTypeId)
                .HasMaxLength(3)
                .HasColumnName("BOR_TYPE_ID");
            entity.Property(e => e.CanAddViews)
                .HasMaxLength(1)
                .HasColumnName("CAN_ADD_VIEWS");
            entity.Property(e => e.CanLike)
                .HasMaxLength(1)
                .HasColumnName("CAN_LIKE");
            entity.Property(e => e.CanPromote)
                .HasMaxLength(1)
                .HasColumnName("CAN_PROMOTE");
            entity.Property(e => e.CanRate)
                .HasMaxLength(1)
                .HasColumnName("CAN_RATE");
            entity.Property(e => e.CatTemplateId)
                .HasMaxLength(30)
                .HasColumnName("CAT_TEMPLATE_ID");
            entity.Property(e => e.EngPriority).HasColumnName("ENG_PRIORITY");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.LlCode)
                .HasMaxLength(30)
                .HasColumnName("LL_CODE");
            entity.Property(e => e.PromoteWeight).HasColumnName("PROMOTE_WEIGHT");
            entity.Property(e => e.RateWeight).HasColumnName("RATE_WEIGHT");
        });

        modelBuilder.Entity<CatdisplayTag>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CATDISPLAY_TAGS");

            entity.Property(e => e.CtLine1)
                .HasMaxLength(20)
                .HasColumnName("CT_LINE1");
            entity.Property(e => e.CtLine2)
                .HasMaxLength(20)
                .HasColumnName("CT_LINE2");
            entity.Property(e => e.CtLine3)
                .HasMaxLength(20)
                .HasColumnName("CT_LINE3");
            entity.Property(e => e.CtLine4)
                .HasMaxLength(20)
                .HasColumnName("CT_LINE4");
            entity.Property(e => e.CtLine5)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CT_LINE5");
            entity.Property(e => e.CtLine6)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CT_LINE6");
            entity.Property(e => e.CtLine7)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CT_LINE7");
            entity.Property(e => e.CtLine8)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CT_LINE8");
            entity.Property(e => e.CtNumber1)
                .HasMaxLength(20)
                .HasColumnName("CT_NUMBER1");
            entity.Property(e => e.CtNumber2)
                .HasMaxLength(20)
                .HasColumnName("CT_NUMBER2");
            entity.Property(e => e.CtTaglist1)
                .HasMaxLength(60)
                .HasColumnName("CT_TAGLIST1");
            entity.Property(e => e.CtTaglist10)
                .HasMaxLength(60)
                .HasColumnName("CT_TAGLIST10");
            entity.Property(e => e.CtTaglist2)
                .HasMaxLength(60)
                .HasColumnName("CT_TAGLIST2");
            entity.Property(e => e.CtTaglist3)
                .HasMaxLength(60)
                .HasColumnName("CT_TAGLIST3");
            entity.Property(e => e.CtTaglist4)
                .HasMaxLength(60)
                .HasColumnName("CT_TAGLIST4");
            entity.Property(e => e.CtTaglist5)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CT_TAGLIST5");
            entity.Property(e => e.CtTaglist6)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CT_TAGLIST6");
            entity.Property(e => e.CtTaglist7)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CT_TAGLIST7");
            entity.Property(e => e.CtTaglist8)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CT_TAGLIST8");
            entity.Property(e => e.CtTaglist9)
                .HasMaxLength(60)
                .HasColumnName("CT_TAGLIST9");
        });

        modelBuilder.Entity<CatdisplayTagsTranslation>(entity =>
        {
            entity.HasKey(e => e.Lcid).HasName("PK_CATDISPLAY_TAGS");

            entity.ToTable("CATDISPLAY_TAGS_TRANSLATION");

            entity.Property(e => e.Lcid)
                .ValueGeneratedNever()
                .HasColumnName("LCID");
            entity.Property(e => e.CtLine1)
                .HasMaxLength(20)
                .HasColumnName("CT_LINE1");
            entity.Property(e => e.CtLine2)
                .HasMaxLength(20)
                .HasColumnName("CT_LINE2");
            entity.Property(e => e.CtLine3)
                .HasMaxLength(20)
                .HasColumnName("CT_LINE3");
            entity.Property(e => e.CtLine4)
                .HasMaxLength(20)
                .HasColumnName("CT_LINE4");
            entity.Property(e => e.CtLine5)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CT_LINE5");
            entity.Property(e => e.CtLine6)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CT_LINE6");
            entity.Property(e => e.CtLine7)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CT_LINE7");
            entity.Property(e => e.CtLine8)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CT_LINE8");
            entity.Property(e => e.CtNumber1)
                .HasMaxLength(20)
                .HasColumnName("CT_NUMBER1");
            entity.Property(e => e.CtNumber2)
                .HasMaxLength(20)
                .HasColumnName("CT_NUMBER2");
        });

        modelBuilder.Entity<CatleadthruTag>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CATLEADTHRU_TAGS");

            entity.Property(e => e.ClDesc1)
                .HasMaxLength(20)
                .HasColumnName("CL_DESC1");
            entity.Property(e => e.ClDesc2)
                .HasMaxLength(20)
                .HasColumnName("CL_DESC2");
            entity.Property(e => e.ClDesc3)
                .HasMaxLength(20)
                .HasColumnName("CL_DESC3");
            entity.Property(e => e.ClDesc4)
                .HasMaxLength(20)
                .HasColumnName("CL_DESC4");
            entity.Property(e => e.ClDesc5)
                .HasMaxLength(20)
                .HasColumnName("CL_DESC5");
            entity.Property(e => e.ClDesc6)
                .HasMaxLength(20)
                .HasColumnName("CL_DESC6");
            entity.Property(e => e.ClDesc7)
                .HasMaxLength(20)
                .HasColumnName("CL_DESC7");
            entity.Property(e => e.ClDesc8)
                .HasMaxLength(20)
                .HasColumnName("CL_DESC8");
            entity.Property(e => e.ClDesc9)
                .HasMaxLength(20)
                .HasColumnName("CL_DESC9");
            entity.Property(e => e.ClTag11).HasColumnName("CL_TAG11");
            entity.Property(e => e.ClTag12).HasColumnName("CL_TAG12");
            entity.Property(e => e.ClTag13).HasColumnName("CL_TAG13");
            entity.Property(e => e.ClTag14).HasColumnName("CL_TAG14");
            entity.Property(e => e.ClTag15).HasColumnName("CL_TAG15");
            entity.Property(e => e.ClTag16).HasColumnName("CL_TAG16");
            entity.Property(e => e.ClTag17).HasColumnName("CL_TAG17");
            entity.Property(e => e.ClTag18).HasColumnName("CL_TAG18");
            entity.Property(e => e.ClTag19).HasColumnName("CL_TAG19");
            entity.Property(e => e.ClTag21).HasColumnName("CL_TAG21");
            entity.Property(e => e.ClTag22).HasColumnName("CL_TAG22");
            entity.Property(e => e.ClTag23).HasColumnName("CL_TAG23");
            entity.Property(e => e.ClTag24).HasColumnName("CL_TAG24");
            entity.Property(e => e.ClTag25).HasColumnName("CL_TAG25");
            entity.Property(e => e.ClTag26).HasColumnName("CL_TAG26");
            entity.Property(e => e.ClTag27).HasColumnName("CL_TAG27");
            entity.Property(e => e.ClTag28).HasColumnName("CL_TAG28");
            entity.Property(e => e.ClTag29).HasColumnName("CL_TAG29");
            entity.Property(e => e.ClTag31).HasColumnName("CL_TAG31");
            entity.Property(e => e.ClTag32).HasColumnName("CL_TAG32");
            entity.Property(e => e.ClTag33).HasColumnName("CL_TAG33");
            entity.Property(e => e.ClTag34).HasColumnName("CL_TAG34");
            entity.Property(e => e.ClTag35).HasColumnName("CL_TAG35");
            entity.Property(e => e.ClTag36).HasColumnName("CL_TAG36");
            entity.Property(e => e.ClTag37).HasColumnName("CL_TAG37");
            entity.Property(e => e.ClTag38).HasColumnName("CL_TAG38");
            entity.Property(e => e.ClTag39).HasColumnName("CL_TAG39");
            entity.Property(e => e.ClTag41).HasColumnName("CL_TAG41");
            entity.Property(e => e.ClTag42).HasColumnName("CL_TAG42");
            entity.Property(e => e.ClTag43).HasColumnName("CL_TAG43");
            entity.Property(e => e.ClTag44).HasColumnName("CL_TAG44");
            entity.Property(e => e.ClTag45).HasColumnName("CL_TAG45");
            entity.Property(e => e.ClTag46).HasColumnName("CL_TAG46");
            entity.Property(e => e.ClTag47).HasColumnName("CL_TAG47");
            entity.Property(e => e.ClTag48).HasColumnName("CL_TAG48");
            entity.Property(e => e.ClTag49).HasColumnName("CL_TAG49");
            entity.Property(e => e.ClTag51).HasColumnName("CL_TAG51");
            entity.Property(e => e.ClTag52).HasColumnName("CL_TAG52");
            entity.Property(e => e.ClTag53).HasColumnName("CL_TAG53");
            entity.Property(e => e.ClTag54).HasColumnName("CL_TAG54");
            entity.Property(e => e.ClTag55).HasColumnName("CL_TAG55");
            entity.Property(e => e.ClTag56).HasColumnName("CL_TAG56");
            entity.Property(e => e.ClTag57).HasColumnName("CL_TAG57");
            entity.Property(e => e.ClTag58).HasColumnName("CL_TAG58");
            entity.Property(e => e.ClTag59).HasColumnName("CL_TAG59");
            entity.Property(e => e.ClTag61).HasColumnName("CL_TAG61");
            entity.Property(e => e.ClTag62).HasColumnName("CL_TAG62");
            entity.Property(e => e.ClTag63).HasColumnName("CL_TAG63");
            entity.Property(e => e.ClTag64).HasColumnName("CL_TAG64");
            entity.Property(e => e.ClTag65).HasColumnName("CL_TAG65");
            entity.Property(e => e.ClTag66).HasColumnName("CL_TAG66");
            entity.Property(e => e.ClTag67).HasColumnName("CL_TAG67");
            entity.Property(e => e.ClTag68).HasColumnName("CL_TAG68");
            entity.Property(e => e.ClTag69).HasColumnName("CL_TAG69");
            entity.Property(e => e.ClTag71).HasColumnName("CL_TAG71");
            entity.Property(e => e.ClTag72).HasColumnName("CL_TAG72");
            entity.Property(e => e.ClTag73).HasColumnName("CL_TAG73");
            entity.Property(e => e.ClTag74).HasColumnName("CL_TAG74");
            entity.Property(e => e.ClTag75).HasColumnName("CL_TAG75");
            entity.Property(e => e.ClTag76).HasColumnName("CL_TAG76");
            entity.Property(e => e.ClTag77).HasColumnName("CL_TAG77");
            entity.Property(e => e.ClTag78).HasColumnName("CL_TAG78");
            entity.Property(e => e.ClTag79).HasColumnName("CL_TAG79");
            entity.Property(e => e.ClTag81).HasColumnName("CL_TAG81");
            entity.Property(e => e.ClTag82).HasColumnName("CL_TAG82");
            entity.Property(e => e.ClTag83).HasColumnName("CL_TAG83");
            entity.Property(e => e.ClTag84).HasColumnName("CL_TAG84");
            entity.Property(e => e.ClTag85).HasColumnName("CL_TAG85");
            entity.Property(e => e.ClTag86).HasColumnName("CL_TAG86");
            entity.Property(e => e.ClTag87).HasColumnName("CL_TAG87");
            entity.Property(e => e.ClTag88).HasColumnName("CL_TAG88");
            entity.Property(e => e.ClTag89).HasColumnName("CL_TAG89");
            entity.Property(e => e.ClTag91).HasColumnName("CL_TAG91");
            entity.Property(e => e.ClTag92).HasColumnName("CL_TAG92");
            entity.Property(e => e.ClTag93).HasColumnName("CL_TAG93");
            entity.Property(e => e.ClTag94).HasColumnName("CL_TAG94");
            entity.Property(e => e.ClTag95).HasColumnName("CL_TAG95");
            entity.Property(e => e.ClTag96).HasColumnName("CL_TAG96");
            entity.Property(e => e.ClTag97).HasColumnName("CL_TAG97");
            entity.Property(e => e.ClTag98).HasColumnName("CL_TAG98");
            entity.Property(e => e.ClTag99).HasColumnName("CL_TAG99");
            entity.Property(e => e.ClTags1)
                .HasMaxLength(160)
                .HasColumnName("CL_TAGS1");
            entity.Property(e => e.ClTags2)
                .HasMaxLength(160)
                .HasColumnName("CL_TAGS2");
            entity.Property(e => e.ClTags3)
                .HasMaxLength(160)
                .HasColumnName("CL_TAGS3");
            entity.Property(e => e.ClTags4)
                .HasMaxLength(160)
                .HasColumnName("CL_TAGS4");
            entity.Property(e => e.ClTags5)
                .HasMaxLength(160)
                .HasColumnName("CL_TAGS5");
            entity.Property(e => e.ClTags6)
                .HasMaxLength(160)
                .HasColumnName("CL_TAGS6");
            entity.Property(e => e.ClTags7)
                .HasMaxLength(160)
                .HasColumnName("CL_TAGS7");
            entity.Property(e => e.ClTags8)
                .HasMaxLength(160)
                .HasColumnName("CL_TAGS8");
            entity.Property(e => e.ClTags9)
                .HasMaxLength(160)
                .HasColumnName("CL_TAGS9");
        });

        modelBuilder.Entity<CatleadthruTagsExtra>(entity =>
        {
            entity.ToTable("CATLEADTHRU_TAGS_EXTRA");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ClDesc)
                .HasMaxLength(20)
                .HasColumnName("CL_DESC");
            entity.Property(e => e.ClTags)
                .HasMaxLength(160)
                .IsUnicode(false)
                .HasColumnName("CL_TAGS");
            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");
            entity.Property(e => e.Z3950default).HasColumnName("Z3950Default");
        });

        modelBuilder.Entity<CatleadthruTagsExtraOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CATLEADTHRU_TAGS_EXTRA_OLD");

            entity.Property(e => e.ClDesc)
                .HasMaxLength(20)
                .HasColumnName("CL_DESC");
            entity.Property(e => e.ClTags)
                .HasMaxLength(160)
                .IsUnicode(false)
                .HasColumnName("CL_TAGS");
            entity.Property(e => e.Z3950default).HasColumnName("Z3950Default");
        });

        modelBuilder.Entity<CatleadthruTagsExtraTranslation>(entity =>
        {
            entity.HasKey(e => new { e.Lcid, e.Id });

            entity.ToTable("CATLEADTHRU_TAGS_EXTRA_TRANSLATION");

            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.ClDesc)
                .HasMaxLength(20)
                .HasColumnName("CL_DESC");

            entity.HasOne(d => d.IdNavigation).WithMany(p => p.CatleadthruTagsExtraTranslations)
                .HasForeignKey(d => d.Id)
                .HasConstraintName("FK_CATLEADTHRU_TAGS_EXTRA_CATLEADTHRU_TAGS_EXTRA_TRANSLATION");
        });

        modelBuilder.Entity<CatorderdateSfdef>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CATORDERDATE_SFDEF");

            entity.Property(e => e.CodLabel1)
                .HasMaxLength(20)
                .HasColumnName("COD_LABEL1");
            entity.Property(e => e.CodLabel2)
                .HasMaxLength(20)
                .HasColumnName("COD_LABEL2");
            entity.Property(e => e.CodLabel3)
                .HasMaxLength(20)
                .HasColumnName("COD_LABEL3");
            entity.Property(e => e.CodLabel4)
                .HasMaxLength(20)
                .HasColumnName("COD_LABEL4");
            entity.Property(e => e.CodSf1)
                .HasMaxLength(1)
                .HasColumnName("COD_SF1");
            entity.Property(e => e.CodSf2)
                .HasMaxLength(1)
                .HasColumnName("COD_SF2");
            entity.Property(e => e.CodSf3)
                .HasMaxLength(1)
                .HasColumnName("COD_SF3");
            entity.Property(e => e.CodSf4)
                .HasMaxLength(1)
                .HasColumnName("COD_SF4");
            entity.Property(e => e.CodTagno1).HasColumnName("COD_TAGNO1");
            entity.Property(e => e.CodTagno2).HasColumnName("COD_TAGNO2");
            entity.Property(e => e.CodTagno3).HasColumnName("COD_TAGNO3");
            entity.Property(e => e.CodTagno4).HasColumnName("COD_TAGNO4");
        });

        modelBuilder.Entity<CatorderdateSfdefTranslation>(entity =>
        {
            entity.HasKey(e => e.Lcid);

            entity.ToTable("CATORDERDATE_SFDEF_TRANSLATION");

            entity.Property(e => e.Lcid)
                .ValueGeneratedNever()
                .HasColumnName("LCID");
            entity.Property(e => e.CodLabel1)
                .HasMaxLength(20)
                .HasColumnName("COD_LABEL1");
            entity.Property(e => e.CodLabel2)
                .HasMaxLength(20)
                .HasColumnName("COD_LABEL2");
            entity.Property(e => e.CodLabel3)
                .HasMaxLength(20)
                .HasColumnName("COD_LABEL3");
            entity.Property(e => e.CodLabel4)
                .HasMaxLength(20)
                .HasColumnName("COD_LABEL4");
        });

        modelBuilder.Entity<CiCatdisplayTag>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_CATDISPLAY_TAGS");

            entity.Property(e => e.CtLine1)
                .HasMaxLength(20)
                .HasColumnName("CT_LINE1");
            entity.Property(e => e.CtLine2)
                .HasMaxLength(20)
                .HasColumnName("CT_LINE2");
            entity.Property(e => e.CtLine3)
                .HasMaxLength(20)
                .HasColumnName("CT_LINE3");
            entity.Property(e => e.CtLine4)
                .HasMaxLength(20)
                .HasColumnName("CT_LINE4");
            entity.Property(e => e.CtTaglist1)
                .HasMaxLength(60)
                .HasColumnName("CT_TAGLIST1");
            entity.Property(e => e.CtTaglist2)
                .HasMaxLength(60)
                .HasColumnName("CT_TAGLIST2");
            entity.Property(e => e.CtTaglist3)
                .HasMaxLength(60)
                .HasColumnName("CT_TAGLIST3");
            entity.Property(e => e.CtTaglist4)
                .HasMaxLength(60)
                .HasColumnName("CT_TAGLIST4");
        });

        modelBuilder.Entity<CiCatleadthrutag>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_CATLEADTHRUTAGS");

            entity.Property(e => e.ClDesc1)
                .HasMaxLength(20)
                .HasColumnName("CL_DESC1");
            entity.Property(e => e.ClDesc2)
                .HasMaxLength(20)
                .HasColumnName("CL_DESC2");
            entity.Property(e => e.ClDesc3)
                .HasMaxLength(20)
                .HasColumnName("CL_DESC3");
            entity.Property(e => e.ClDesc4)
                .HasMaxLength(20)
                .HasColumnName("CL_DESC4");
            entity.Property(e => e.ClDesc5)
                .HasMaxLength(20)
                .HasColumnName("CL_DESC5");
            entity.Property(e => e.ClDesc6)
                .HasMaxLength(20)
                .HasColumnName("CL_DESC6");
            entity.Property(e => e.ClDesc7)
                .HasMaxLength(20)
                .HasColumnName("CL_DESC7");
            entity.Property(e => e.ClDesc8)
                .HasMaxLength(20)
                .HasColumnName("CL_DESC8");
            entity.Property(e => e.ClDesc9)
                .HasMaxLength(20)
                .HasColumnName("CL_DESC9");
            entity.Property(e => e.ClTag11).HasColumnName("CL_TAG11");
            entity.Property(e => e.ClTag12).HasColumnName("CL_TAG12");
            entity.Property(e => e.ClTag13).HasColumnName("CL_TAG13");
            entity.Property(e => e.ClTag14).HasColumnName("CL_TAG14");
            entity.Property(e => e.ClTag15).HasColumnName("CL_TAG15");
            entity.Property(e => e.ClTag16).HasColumnName("CL_TAG16");
            entity.Property(e => e.ClTag17).HasColumnName("CL_TAG17");
            entity.Property(e => e.ClTag18).HasColumnName("CL_TAG18");
            entity.Property(e => e.ClTag19).HasColumnName("CL_TAG19");
            entity.Property(e => e.ClTag21).HasColumnName("CL_TAG21");
            entity.Property(e => e.ClTag22).HasColumnName("CL_TAG22");
            entity.Property(e => e.ClTag23).HasColumnName("CL_TAG23");
            entity.Property(e => e.ClTag24).HasColumnName("CL_TAG24");
            entity.Property(e => e.ClTag25).HasColumnName("CL_TAG25");
            entity.Property(e => e.ClTag26).HasColumnName("CL_TAG26");
            entity.Property(e => e.ClTag27).HasColumnName("CL_TAG27");
            entity.Property(e => e.ClTag28).HasColumnName("CL_TAG28");
            entity.Property(e => e.ClTag29).HasColumnName("CL_TAG29");
            entity.Property(e => e.ClTag31).HasColumnName("CL_TAG31");
            entity.Property(e => e.ClTag32).HasColumnName("CL_TAG32");
            entity.Property(e => e.ClTag33).HasColumnName("CL_TAG33");
            entity.Property(e => e.ClTag34).HasColumnName("CL_TAG34");
            entity.Property(e => e.ClTag35).HasColumnName("CL_TAG35");
            entity.Property(e => e.ClTag36).HasColumnName("CL_TAG36");
            entity.Property(e => e.ClTag37).HasColumnName("CL_TAG37");
            entity.Property(e => e.ClTag38).HasColumnName("CL_TAG38");
            entity.Property(e => e.ClTag39).HasColumnName("CL_TAG39");
            entity.Property(e => e.ClTag41).HasColumnName("CL_TAG41");
            entity.Property(e => e.ClTag42).HasColumnName("CL_TAG42");
            entity.Property(e => e.ClTag43).HasColumnName("CL_TAG43");
            entity.Property(e => e.ClTag44).HasColumnName("CL_TAG44");
            entity.Property(e => e.ClTag45).HasColumnName("CL_TAG45");
            entity.Property(e => e.ClTag46).HasColumnName("CL_TAG46");
            entity.Property(e => e.ClTag47).HasColumnName("CL_TAG47");
            entity.Property(e => e.ClTag48).HasColumnName("CL_TAG48");
            entity.Property(e => e.ClTag49).HasColumnName("CL_TAG49");
            entity.Property(e => e.ClTag51).HasColumnName("CL_TAG51");
            entity.Property(e => e.ClTag52).HasColumnName("CL_TAG52");
            entity.Property(e => e.ClTag53).HasColumnName("CL_TAG53");
            entity.Property(e => e.ClTag54).HasColumnName("CL_TAG54");
            entity.Property(e => e.ClTag55).HasColumnName("CL_TAG55");
            entity.Property(e => e.ClTag56).HasColumnName("CL_TAG56");
            entity.Property(e => e.ClTag57).HasColumnName("CL_TAG57");
            entity.Property(e => e.ClTag58).HasColumnName("CL_TAG58");
            entity.Property(e => e.ClTag59).HasColumnName("CL_TAG59");
            entity.Property(e => e.ClTag61).HasColumnName("CL_TAG61");
            entity.Property(e => e.ClTag62).HasColumnName("CL_TAG62");
            entity.Property(e => e.ClTag63).HasColumnName("CL_TAG63");
            entity.Property(e => e.ClTag64).HasColumnName("CL_TAG64");
            entity.Property(e => e.ClTag65).HasColumnName("CL_TAG65");
            entity.Property(e => e.ClTag66).HasColumnName("CL_TAG66");
            entity.Property(e => e.ClTag67).HasColumnName("CL_TAG67");
            entity.Property(e => e.ClTag68).HasColumnName("CL_TAG68");
            entity.Property(e => e.ClTag69).HasColumnName("CL_TAG69");
            entity.Property(e => e.ClTag71).HasColumnName("CL_TAG71");
            entity.Property(e => e.ClTag72).HasColumnName("CL_TAG72");
            entity.Property(e => e.ClTag73).HasColumnName("CL_TAG73");
            entity.Property(e => e.ClTag74).HasColumnName("CL_TAG74");
            entity.Property(e => e.ClTag75).HasColumnName("CL_TAG75");
            entity.Property(e => e.ClTag76).HasColumnName("CL_TAG76");
            entity.Property(e => e.ClTag77).HasColumnName("CL_TAG77");
            entity.Property(e => e.ClTag78).HasColumnName("CL_TAG78");
            entity.Property(e => e.ClTag79).HasColumnName("CL_TAG79");
            entity.Property(e => e.ClTag81).HasColumnName("CL_TAG81");
            entity.Property(e => e.ClTag82).HasColumnName("CL_TAG82");
            entity.Property(e => e.ClTag83).HasColumnName("CL_TAG83");
            entity.Property(e => e.ClTag84).HasColumnName("CL_TAG84");
            entity.Property(e => e.ClTag85).HasColumnName("CL_TAG85");
            entity.Property(e => e.ClTag86).HasColumnName("CL_TAG86");
            entity.Property(e => e.ClTag87).HasColumnName("CL_TAG87");
            entity.Property(e => e.ClTag88).HasColumnName("CL_TAG88");
            entity.Property(e => e.ClTag89).HasColumnName("CL_TAG89");
            entity.Property(e => e.ClTag91).HasColumnName("CL_TAG91");
            entity.Property(e => e.ClTag92).HasColumnName("CL_TAG92");
            entity.Property(e => e.ClTag93).HasColumnName("CL_TAG93");
            entity.Property(e => e.ClTag94).HasColumnName("CL_TAG94");
            entity.Property(e => e.ClTag95).HasColumnName("CL_TAG95");
            entity.Property(e => e.ClTag96).HasColumnName("CL_TAG96");
            entity.Property(e => e.ClTag97).HasColumnName("CL_TAG97");
            entity.Property(e => e.ClTag98).HasColumnName("CL_TAG98");
            entity.Property(e => e.ClTag99).HasColumnName("CL_TAG99");
            entity.Property(e => e.ClTags1)
                .HasMaxLength(160)
                .HasColumnName("CL_TAGS1");
            entity.Property(e => e.ClTags2)
                .HasMaxLength(160)
                .HasColumnName("CL_TAGS2");
            entity.Property(e => e.ClTags3)
                .HasMaxLength(160)
                .HasColumnName("CL_TAGS3");
            entity.Property(e => e.ClTags4)
                .HasMaxLength(160)
                .HasColumnName("CL_TAGS4");
            entity.Property(e => e.ClTags5)
                .HasMaxLength(160)
                .HasColumnName("CL_TAGS5");
            entity.Property(e => e.ClTags6)
                .HasMaxLength(160)
                .HasColumnName("CL_TAGS6");
            entity.Property(e => e.ClTags7)
                .HasMaxLength(160)
                .HasColumnName("CL_TAGS7");
            entity.Property(e => e.ClTags8)
                .HasMaxLength(160)
                .HasColumnName("CL_TAGS8");
            entity.Property(e => e.ClTags9)
                .HasMaxLength(160)
                .HasColumnName("CL_TAGS9");
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

        modelBuilder.Entity<CiKwordDesc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_KWORD_DESC");

            entity.Property(e => e.KdCode)
                .HasMaxLength(2)
                .HasColumnName("KD_CODE");
            entity.Property(e => e.KdDesc)
                .HasMaxLength(30)
                .HasColumnName("KD_DESC");
        });

        modelBuilder.Entity<CiKwordStoplist>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_KWORD_STOPLIST");

            entity.Property(e => e.KsStop)
                .HasColumnType("ntext")
                .HasColumnName("KS_STOP");
        });

        modelBuilder.Entity<CiMWord>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_M_WORDS");

            entity.Property(e => e.MChangeto)
                .HasMaxLength(25)
                .HasColumnName("M_CHANGETO");
            entity.Property(e => e.MCharcount).HasColumnName("M_CHARCOUNT");
            entity.Property(e => e.MId).HasColumnName("M_ID");
            entity.Property(e => e.MLookfor)
                .HasMaxLength(25)
                .HasColumnName("M_LOOKFOR");
            entity.Property(e => e.MNotes)
                .HasMaxLength(250)
                .HasColumnName("M_NOTES");
            entity.Property(e => e.MType).HasColumnName("M_TYPE");
        });

        modelBuilder.Entity<CiOpacTagdef>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_OPAC_TAGDEF");

            entity.Property(e => e.TtTagdesc)
                .HasMaxLength(40)
                .HasColumnName("TT_TAGDESC");
            entity.Property(e => e.TtTagno).HasColumnName("TT_TAGNO");
        });

        modelBuilder.Entity<CiOrgClass>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_ORG_CLASS");

            entity.Property(e => e.OcDesc)
                .HasMaxLength(25)
                .HasColumnName("OC_DESC");
        });

        modelBuilder.Entity<CiTagCatNice>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_TAG_CAT_NICE");

            entity.Property(e => e.TnDesc)
                .HasMaxLength(50)
                .HasColumnName("TN_DESC");
            entity.Property(e => e.TnStoplist)
                .HasMaxLength(1)
                .HasColumnName("TN_STOPLIST");
            entity.Property(e => e.TnTagno).HasColumnName("TN_TAGNO");
            entity.Property(e => e.TnWhere)
                .HasMaxLength(100)
                .HasColumnName("TN_WHERE");
        });

        modelBuilder.Entity<CiTagGroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_TAG_GROUP");

            entity.Property(e => e.TgGroupNo)
                .HasMaxLength(3)
                .HasColumnName("TG_GROUP_NO");
            entity.Property(e => e.TgTagno).HasColumnName("TG_TAGNO");
        });

        modelBuilder.Entity<CiTagNice>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_TAG_NICE");

            entity.Property(e => e.TnDesc)
                .HasMaxLength(50)
                .HasColumnName("TN_DESC");
            entity.Property(e => e.TnStoplist)
                .HasMaxLength(1)
                .HasColumnName("TN_STOPLIST");
            entity.Property(e => e.TnTagno).HasColumnName("TN_TAGNO");
            entity.Property(e => e.TnWhere)
                .HasMaxLength(100)
                .HasColumnName("TN_WHERE");
        });

        modelBuilder.Entity<CiTagSfdef>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_TAG_SFDEF");

            entity.HasIndex(e => new { e.TsTagno, e.TsSequence }, "CI_TAG_SFNOX");

            entity.Property(e => e.TsAddSf)
                .HasMaxLength(1)
                .HasColumnName("TS_ADD_SF");
            entity.Property(e => e.TsAddTag).HasColumnName("TS_ADD_TAG");
            entity.Property(e => e.TsKey)
                .HasMaxLength(1)
                .HasColumnName("TS_KEY");
            entity.Property(e => e.TsKeyword)
                .HasMaxLength(1)
                .HasColumnName("TS_KEYWORD");
            entity.Property(e => e.TsMarc)
                .HasMaxLength(1)
                .HasColumnName("TS_MARC");
            entity.Property(e => e.TsRepeatable)
                .HasMaxLength(1)
                .HasColumnName("TS_REPEATABLE");
            entity.Property(e => e.TsSequence).HasColumnName("TS_SEQUENCE");
            entity.Property(e => e.TsSf)
                .HasMaxLength(1)
                .HasColumnName("TS_SF");
            entity.Property(e => e.TsSfDesc)
                .HasMaxLength(150)
                .HasColumnName("TS_SF_DESC");
            entity.Property(e => e.TsShared)
                .HasMaxLength(1)
                .HasColumnName("TS_SHARED");
            entity.Property(e => e.TsTagno).HasColumnName("TS_TAGNO");
            entity.Property(e => e.TsUnique)
                .HasMaxLength(1)
                .HasColumnName("TS_UNIQUE");
        });

        modelBuilder.Entity<CiTagTagdef>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_TAG_TAGDEF");

            entity.HasIndex(e => e.TtTagno, "CI_TAG_NOX");

            entity.Property(e => e.TtAllowCrossref)
                .HasMaxLength(60)
                .HasColumnName("TT_ALLOW_CROSSREF");
            entity.Property(e => e.TtAuthtagno).HasColumnName("TT_AUTHTAGNO");
            entity.Property(e => e.TtKdCode)
                .HasMaxLength(1)
                .HasColumnName("TT_KD_CODE");
            entity.Property(e => e.TtKeeptag).HasColumnName("TT_KEEPTAG");
            entity.Property(e => e.TtRepeatable)
                .HasMaxLength(1)
                .HasColumnName("TT_REPEATABLE");
            entity.Property(e => e.TtSfformat)
                .HasMaxLength(200)
                .HasColumnName("TT_SFFORMAT");
            entity.Property(e => e.TtTagdesc)
                .HasMaxLength(100)
                .HasColumnName("TT_TAGDESC");
            entity.Property(e => e.TtTagformat)
                .HasMaxLength(200)
                .HasColumnName("TT_TAGFORMAT");
            entity.Property(e => e.TtTagind1).HasColumnName("TT_TAGIND1");
            entity.Property(e => e.TtTagind2).HasColumnName("TT_TAGIND2");
            entity.Property(e => e.TtTagno).HasColumnName("TT_TAGNO");
            entity.Property(e => e.TtUniqueAuth)
                .HasMaxLength(1)
                .HasColumnName("TT_UNIQUE_AUTH");
        });

        modelBuilder.Entity<ClassType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CLASS_TYPES");

            entity.Property(e => e.CtDescription)
                .HasMaxLength(75)
                .HasColumnName("CT_DESCRIPTION");
            entity.Property(e => e.CtId)
                .ValueGeneratedOnAdd()
                .HasColumnName("CT_ID");
            entity.Property(e => e.CtName)
                .HasMaxLength(75)
                .HasColumnName("CT_NAME");
            entity.Property(e => e.LibGroupId).HasColumnName("LIB_GROUP_ID");
        });

        modelBuilder.Entity<ClassTypesTranslation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CLASS_TYPES_TRANSLATION");

            entity.Property(e => e.CtDescription)
                .HasMaxLength(75)
                .HasColumnName("CT_DESCRIPTION");
            entity.Property(e => e.CtName)
                .HasMaxLength(75)
                .HasColumnName("CT_NAME");
            entity.Property(e => e.Lcid).HasColumnName("LCID");
        });

        modelBuilder.Entity<CopyInfoReal>(entity =>
        {
            entity.ToTable("CopyInfoReal");

            entity.Property(e => e.AlreadyInDb)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("alreadyInDB");
            entity.Property(e => e.DateAddedInDb)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dateAddedInDB");
            entity.Property(e => e.ImportName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MarcTag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("marcTag");
            entity.Property(e => e.SubField)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("subField");
        });

        modelBuilder.Entity<Copyinforealremovedup>(entity =>
        {
            entity.ToTable("COPYINFOREALREMOVEDUP");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Alreadyindb)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ALREADYINDB");
            entity.Property(e => e.Dateaddedindb)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DATEADDEDINDB");
            entity.Property(e => e.Importname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IMPORTNAME");
            entity.Property(e => e.Marctag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MARCTAG");
            entity.Property(e => e.Subfield)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SUBFIELD");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.ToTable("COUNTRY");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<DbColumnDescription>(entity =>
        {
            entity.ToTable("DB_COLUMN_DESCRIPTION");

            entity.HasIndex(e => new { e.TableName, e.ColumnName }, "UNQ_DB_COLUMN_DESCRIPTION").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ColumnDescription)
                .HasMaxLength(100)
                .HasColumnName("COLUMN_DESCRIPTION");
            entity.Property(e => e.ColumnName)
                .HasMaxLength(50)
                .HasColumnName("COLUMN_NAME");
            entity.Property(e => e.TableName)
                .HasMaxLength(50)
                .HasColumnName("TABLE_NAME");
        });

        modelBuilder.Entity<DbColumnDescriptionTranslation>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Lcid });

            entity.ToTable("DB_COLUMN_DESCRIPTION_TRANSLATION");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.ColumnDescription)
                .HasMaxLength(150)
                .HasColumnName("COLUMN_DESCRIPTION");

            entity.HasOne(d => d.IdNavigation).WithMany(p => p.DbColumnDescriptionTranslations)
                .HasForeignKey(d => d.Id)
                .HasConstraintName("FK_DB_COLUMN_DESCRIPTION_TRANSLATION");
        });

        modelBuilder.Entity<DbColumnLmsTabRelationship>(entity =>
        {
            entity.ToTable("DB_COLUMN_LMS_TAB_RELATIONSHIP");

            entity.HasIndex(e => new { e.LmsTabName, e.DbColumnDescriptionId }, "UNQ_DB_COLUMN_LMS_TAB_RELATIONSHIP").IsUnique();

            entity.Property(e => e.DbColumnDescriptionId).HasColumnName("DB_COLUMN_DESCRIPTION_ID");
            entity.Property(e => e.LmsTabName)
                .HasMaxLength(50)
                .HasColumnName("LMS_TAB_NAME");
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

        modelBuilder.Entity<DiyFlag>(entity =>
        {
            entity.HasKey(e => new { e.DiyType, e.DiyNumber, e.DiyParamNumber });

            entity.ToTable("DIY_FLAGS");

            entity.Property(e => e.DiyType)
                .HasMaxLength(1)
                .HasColumnName("DIY_TYPE");
            entity.Property(e => e.DiyNumber).HasColumnName("DIY_NUMBER");
            entity.Property(e => e.DiyParamNumber).HasColumnName("DIY_PARAM_NUMBER");
            entity.Property(e => e.DiyComment)
                .HasMaxLength(30)
                .HasColumnName("DIY_COMMENT");
            entity.Property(e => e.DiyMessage)
                .HasMaxLength(250)
                .HasColumnName("DIY_MESSAGE");
            entity.Property(e => e.DiyProceed)
                .HasMaxLength(1)
                .HasColumnName("DIY_PROCEED");
            entity.Property(e => e.DiySound).HasColumnName("DIY_SOUND");
        });

        modelBuilder.Entity<DiyFlagsOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DIY_FLAGS_OLD");

            entity.Property(e => e.DiyComment)
                .HasMaxLength(30)
                .HasColumnName("DIY_COMMENT");
            entity.Property(e => e.DiyMessage)
                .HasMaxLength(250)
                .HasColumnName("DIY_MESSAGE");
            entity.Property(e => e.DiyNumber).HasColumnName("DIY_NUMBER");
            entity.Property(e => e.DiyParamNumber).HasColumnName("DIY_PARAM_NUMBER");
            entity.Property(e => e.DiyProceed)
                .HasMaxLength(1)
                .HasColumnName("DIY_PROCEED");
            entity.Property(e => e.DiySound).HasColumnName("DIY_SOUND");
            entity.Property(e => e.DiyType)
                .HasMaxLength(1)
                .HasColumnName("DIY_TYPE");
        });

        modelBuilder.Entity<DiyFlagsTranslation>(entity =>
        {
            entity.HasKey(e => new { e.Lcid, e.DiyType, e.DiyNumber, e.DiyParamNumber });

            entity.ToTable("DIY_FLAGS_TRANSLATION");

            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.DiyType)
                .HasMaxLength(1)
                .HasColumnName("DIY_TYPE");
            entity.Property(e => e.DiyNumber).HasColumnName("DIY_NUMBER");
            entity.Property(e => e.DiyParamNumber).HasColumnName("DIY_PARAM_NUMBER");
            entity.Property(e => e.DiyComment)
                .HasMaxLength(30)
                .HasColumnName("DIY_COMMENT");
            entity.Property(e => e.DiyMessage)
                .HasMaxLength(250)
                .HasColumnName("DIY_MESSAGE");

            entity.HasOne(d => d.DiyFlag).WithMany(p => p.DiyFlagsTranslations)
                .HasForeignKey(d => new { d.DiyType, d.DiyNumber, d.DiyParamNumber })
                .HasConstraintName("FK_DIY_FLAGS_DIY_FLAGS_TRANSLATION");
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

        modelBuilder.Entity<FinType>(entity =>
        {
            entity.HasKey(e => e.FinType1);

            entity.ToTable("FIN_TYPES");

            entity.Property(e => e.FinType1)
                .HasMaxLength(8)
                .HasColumnName("FIN_TYPE");
            entity.Property(e => e.FinAccno)
                .HasMaxLength(8)
                .HasColumnName("FIN_ACCNO");
            entity.Property(e => e.FinCrBf)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("FIN_CR_BF");
            entity.Property(e => e.FinCrCountBf).HasColumnName("FIN_CR_COUNT_BF");
            entity.Property(e => e.FinDbBf)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("FIN_DB_BF");
            entity.Property(e => e.FinDbCountBf).HasColumnName("FIN_DB_COUNT_BF");
            entity.Property(e => e.FinDesc)
                .HasMaxLength(25)
                .HasColumnName("FIN_DESC");
            entity.Property(e => e.FinIncludePercent)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("FIN_INCLUDE_PERCENT");
            entity.Property(e => e.FinStdCharge)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("FIN_STD_CHARGE");
            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");
        });

        modelBuilder.Entity<FinTypesOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FIN_TYPES_OLD");

            entity.Property(e => e.FinAccno)
                .HasMaxLength(8)
                .HasColumnName("FIN_ACCNO");
            entity.Property(e => e.FinCrBf)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("FIN_CR_BF");
            entity.Property(e => e.FinCrCountBf).HasColumnName("FIN_CR_COUNT_BF");
            entity.Property(e => e.FinDbBf)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("FIN_DB_BF");
            entity.Property(e => e.FinDbCountBf).HasColumnName("FIN_DB_COUNT_BF");
            entity.Property(e => e.FinDesc)
                .HasMaxLength(25)
                .HasColumnName("FIN_DESC");
            entity.Property(e => e.FinIncludePercent)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("FIN_INCLUDE_PERCENT");
            entity.Property(e => e.FinStdCharge)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("FIN_STD_CHARGE");
            entity.Property(e => e.FinType)
                .HasMaxLength(8)
                .HasColumnName("FIN_TYPE");
        });

        modelBuilder.Entity<FinTypesTranslation>(entity =>
        {
            entity.HasKey(e => new { e.FinType, e.Lcid });

            entity.ToTable("FIN_TYPES_TRANSLATION");

            entity.Property(e => e.FinType)
                .HasMaxLength(8)
                .HasColumnName("FIN_TYPE");
            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.FinDesc)
                .HasMaxLength(25)
                .HasColumnName("FIN_DESC");

            entity.HasOne(d => d.FinTypeNavigation).WithMany(p => p.FinTypesTranslations)
                .HasForeignKey(d => d.FinType)
                .HasConstraintName("FK_FIN_TYPES_FIN_TYPES_TRANSLATION");
        });

        modelBuilder.Entity<GroupType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GROUP_TYPES");

            entity.Property(e => e.GtDescription)
                .HasMaxLength(75)
                .HasColumnName("GT_DESCRIPTION");
            entity.Property(e => e.GtId)
                .ValueGeneratedOnAdd()
                .HasColumnName("GT_ID");
            entity.Property(e => e.GtName)
                .HasMaxLength(75)
                .HasColumnName("GT_NAME");
            entity.Property(e => e.LibGroupId).HasColumnName("LIB_GROUP_ID");
        });

        modelBuilder.Entity<GroupTypesTranslation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GROUP_TYPES_TRANSLATION");

            entity.Property(e => e.GtDescription)
                .HasMaxLength(75)
                .HasColumnName("GT_DESCRIPTION");
            entity.Property(e => e.GtName)
                .HasMaxLength(75)
                .HasColumnName("GT_NAME");
            entity.Property(e => e.Lcid).HasColumnName("LCID");
        });

        modelBuilder.Entity<IllDefault>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ILL_DEFAULTS");

            entity.Property(e => e.IllDefAlert)
                .HasMaxLength(1)
                .HasColumnName("ILL_DEF_ALERT");
            entity.Property(e => e.IllDefCode)
                .HasMaxLength(6)
                .HasColumnName("ILL_DEF_CODE");
            entity.Property(e => e.IllDefForm)
                .HasMaxLength(3)
                .HasColumnName("ILL_DEF_FORM");
            entity.Property(e => e.IllDefLoantype)
                .HasMaxLength(3)
                .HasColumnName("ILL_DEF_LOANTYPE");
            entity.Property(e => e.IllDefMhboryn)
                .HasMaxLength(1)
                .HasColumnName("ILL_DEF_MHBORYN");
            entity.Property(e => e.IllDefOpac)
                .HasMaxLength(1)
                .HasColumnName("ILL_DEF_OPAC");
            entity.Property(e => e.IllDefOrigin)
                .HasMaxLength(3)
                .HasColumnName("ILL_DEF_ORIGIN");
            entity.Property(e => e.IllDefPerm)
                .HasMaxLength(1)
                .HasColumnName("ILL_DEF_PERM");
            entity.Property(e => e.IllDefTemp)
                .HasMaxLength(1)
                .HasColumnName("ILL_DEF_TEMP");
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

        modelBuilder.Entity<ImportBorClsGrpTemplateSysColumn>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IMPORT_BOR_CLS_GRP_TEMPLATE_SYS_COLUMNS");

            entity.Property(e => e.ColDesc)
                .HasMaxLength(75)
                .HasColumnName("COL_DESC");
            entity.Property(e => e.ColName)
                .HasMaxLength(50)
                .HasColumnName("COL_NAME");
            entity.Property(e => e.ColType)
                .HasMaxLength(10)
                .HasColumnName("COL_TYPE");
            entity.Property(e => e.ColTypeDesc)
                .HasMaxLength(30)
                .HasColumnName("COL_TYPE_DESC");
            entity.Property(e => e.ImportObject)
                .HasMaxLength(10)
                .HasColumnName("IMPORT_OBJECT");
            entity.Property(e => e.Pkid)
                .ValueGeneratedOnAdd()
                .HasColumnName("PKID");
            entity.Property(e => e.SortId).HasColumnName("SORT_ID");
            entity.Property(e => e.TblName)
                .HasMaxLength(50)
                .HasColumnName("TBL_NAME");
            entity.Property(e => e.UseForImport).HasColumnName("USE_FOR_IMPORT");
        });

        modelBuilder.Entity<ImportBorSysColumn>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IMPORT_BOR_SYS_COLUMNS");

            entity.Property(e => e.ColumnDesc)
                .HasMaxLength(75)
                .HasColumnName("COLUMN_DESC");
            entity.Property(e => e.ColumnName)
                .HasMaxLength(25)
                .HasColumnName("COLUMN_NAME");
            entity.Property(e => e.TableName)
                .HasMaxLength(25)
                .HasColumnName("TABLE_NAME");
            entity.Property(e => e.UniqueId)
                .ValueGeneratedOnAdd()
                .HasColumnName("UNIQUE_ID");
        });

        modelBuilder.Entity<ImportBorTemplate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IMPORT_BOR_TEMPLATE");

            entity.Property(e => e.CreateDatetime).HasColumnName("CREATE_DATETIME");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.LibGroupId).HasColumnName("LIB_GROUP_ID");
            entity.Property(e => e.TemplateDesc)
                .HasMaxLength(200)
                .HasColumnName("TEMPLATE_DESC");
            entity.Property(e => e.TemplateId)
                .ValueGeneratedOnAdd()
                .HasColumnName("TEMPLATE_ID");
            entity.Property(e => e.TemplateName)
                .HasMaxLength(50)
                .HasColumnName("TEMPLATE_NAME");
        });

        modelBuilder.Entity<ImportBorTemplateDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IMPORT_BOR_TEMPLATE_DETAILS");

            entity.Property(e => e.ColId).HasColumnName("COL_ID");
            entity.Property(e => e.IsMandatory).HasColumnName("IS_MANDATORY");
            entity.Property(e => e.SortId).HasColumnName("SORT_ID");
            entity.Property(e => e.TemplateId).HasColumnName("TEMPLATE_ID");
        });

        modelBuilder.Entity<ImportBorTemplateSysColumn>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IMPORT_BOR_TEMPLATE_SYS_COLUMNS");

            entity.Property(e => e.ColDesc)
                .HasMaxLength(75)
                .HasColumnName("COL_DESC");
            entity.Property(e => e.ColName)
                .HasMaxLength(50)
                .HasColumnName("COL_NAME");
            entity.Property(e => e.ColType)
                .HasMaxLength(10)
                .HasColumnName("COL_TYPE");
            entity.Property(e => e.ColTypeDesc)
                .HasMaxLength(30)
                .HasColumnName("COL_TYPE_DESC");
            entity.Property(e => e.Pkid)
                .ValueGeneratedOnAdd()
                .HasColumnName("PKID");
            entity.Property(e => e.SortId).HasColumnName("SORT_ID");
            entity.Property(e => e.TblName)
                .HasMaxLength(50)
                .HasColumnName("TBL_NAME");
            entity.Property(e => e.UseForImport).HasColumnName("USE_FOR_IMPORT");
        });

        modelBuilder.Entity<ImportWondeBorClassTemplate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IMPORT_WONDE_BOR_CLASS_TEMPLATE");

            entity.Property(e => e.CreateDatetime).HasColumnName("CREATE_DATETIME");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.LibGroupId).HasColumnName("LIB_GROUP_ID");
            entity.Property(e => e.TemplateDesc)
                .HasMaxLength(200)
                .HasColumnName("TEMPLATE_DESC");
            entity.Property(e => e.TemplateId)
                .ValueGeneratedOnAdd()
                .HasColumnName("TEMPLATE_ID");
            entity.Property(e => e.TemplateName)
                .HasMaxLength(50)
                .HasColumnName("TEMPLATE_NAME");
        });

        modelBuilder.Entity<ImportWondeBorClassTemplateDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IMPORT_WONDE_BOR_CLASS_TEMPLATE_DETAILS");

            entity.Property(e => e.BorColId).HasColumnName("BOR_COL_ID");
            entity.Property(e => e.IsMandatory).HasColumnName("IS_MANDATORY");
            entity.Property(e => e.SortId).HasColumnName("SORT_ID");
            entity.Property(e => e.TemplateId).HasColumnName("TEMPLATE_ID");
            entity.Property(e => e.WonColId).HasColumnName("WON_COL_ID");
        });

        modelBuilder.Entity<ImportWondeBorClassTemplateSysColumn>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IMPORT_WONDE_BOR_CLASS_TEMPLATE_SYS_COLUMNS");

            entity.Property(e => e.ColDesc)
                .HasMaxLength(75)
                .HasColumnName("COL_DESC");
            entity.Property(e => e.ColName)
                .HasMaxLength(50)
                .HasColumnName("COL_NAME");
            entity.Property(e => e.ColType)
                .HasMaxLength(10)
                .HasColumnName("COL_TYPE");
            entity.Property(e => e.ColTypeDesc)
                .HasMaxLength(30)
                .HasColumnName("COL_TYPE_DESC");
            entity.Property(e => e.Pkid)
                .ValueGeneratedOnAdd()
                .HasColumnName("PKID");
            entity.Property(e => e.SortId).HasColumnName("SORT_ID");
            entity.Property(e => e.SysColId).HasColumnName("SYS_COL_ID");
            entity.Property(e => e.TblName)
                .HasMaxLength(50)
                .HasColumnName("TBL_NAME");
            entity.Property(e => e.UseForImport).HasColumnName("USE_FOR_IMPORT");
        });

        modelBuilder.Entity<ImportWondeBorGrpTemplate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IMPORT_WONDE_BOR_GRP_TEMPLATE");

            entity.Property(e => e.CreateDatetime).HasColumnName("CREATE_DATETIME");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.LibGroupId).HasColumnName("LIB_GROUP_ID");
            entity.Property(e => e.TemplateDesc)
                .HasMaxLength(200)
                .HasColumnName("TEMPLATE_DESC");
            entity.Property(e => e.TemplateId)
                .ValueGeneratedOnAdd()
                .HasColumnName("TEMPLATE_ID");
            entity.Property(e => e.TemplateName)
                .HasMaxLength(50)
                .HasColumnName("TEMPLATE_NAME");
        });

        modelBuilder.Entity<ImportWondeBorGrpTemplateDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IMPORT_WONDE_BOR_GRP_TEMPLATE_DETAILS");

            entity.Property(e => e.BorColId).HasColumnName("BOR_COL_ID");
            entity.Property(e => e.IsMandatory).HasColumnName("IS_MANDATORY");
            entity.Property(e => e.SortId).HasColumnName("SORT_ID");
            entity.Property(e => e.TemplateId).HasColumnName("TEMPLATE_ID");
            entity.Property(e => e.WonColId).HasColumnName("WON_COL_ID");
        });

        modelBuilder.Entity<ImportWondeBorGrpTemplateSysColumn>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IMPORT_WONDE_BOR_GRP_TEMPLATE_SYS_COLUMNS");

            entity.Property(e => e.ColDesc)
                .HasMaxLength(75)
                .HasColumnName("COL_DESC");
            entity.Property(e => e.ColName)
                .HasMaxLength(50)
                .HasColumnName("COL_NAME");
            entity.Property(e => e.ColType)
                .HasMaxLength(10)
                .HasColumnName("COL_TYPE");
            entity.Property(e => e.ColTypeDesc)
                .HasMaxLength(30)
                .HasColumnName("COL_TYPE_DESC");
            entity.Property(e => e.Pkid)
                .ValueGeneratedOnAdd()
                .HasColumnName("PKID");
            entity.Property(e => e.SortId).HasColumnName("SORT_ID");
            entity.Property(e => e.SysColId).HasColumnName("SYS_COL_ID");
            entity.Property(e => e.TblName)
                .HasMaxLength(50)
                .HasColumnName("TBL_NAME");
            entity.Property(e => e.UseForImport).HasColumnName("USE_FOR_IMPORT");
        });

        modelBuilder.Entity<ImportWondeBorTemplate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IMPORT_WONDE_BOR_TEMPLATE");

            entity.Property(e => e.ClassTemplateId).HasColumnName("CLASS_TEMPLATE_ID");
            entity.Property(e => e.CreateDatetime).HasColumnName("CREATE_DATETIME");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DefaultUserClass)
                .HasMaxLength(20)
                .HasColumnName("DEFAULT_USER_CLASS");
            entity.Property(e => e.DefaultUserGroup)
                .HasMaxLength(20)
                .HasColumnName("DEFAULT_USER_GROUP");
            entity.Property(e => e.DefaultUserLocation)
                .HasMaxLength(20)
                .HasColumnName("DEFAULT_USER_LOCATION");
            entity.Property(e => e.DefaultUserType)
                .HasMaxLength(20)
                .HasColumnName("DEFAULT_USER_TYPE");
            entity.Property(e => e.GroupTemplateId).HasColumnName("GROUP_TEMPLATE_ID");
            entity.Property(e => e.LibGroupId).HasColumnName("LIB_GROUP_ID");
            entity.Property(e => e.TemplateDesc)
                .HasMaxLength(200)
                .HasColumnName("TEMPLATE_DESC");
            entity.Property(e => e.TemplateId)
                .ValueGeneratedOnAdd()
                .HasColumnName("TEMPLATE_ID");
            entity.Property(e => e.TemplateName)
                .HasMaxLength(50)
                .HasColumnName("TEMPLATE_NAME");
        });

        modelBuilder.Entity<ImportWondeBorTemplateDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IMPORT_WONDE_BOR_TEMPLATE_DETAILS");

            entity.Property(e => e.BorColId).HasColumnName("BOR_COL_ID");
            entity.Property(e => e.IsMandatory).HasColumnName("IS_MANDATORY");
            entity.Property(e => e.SortId).HasColumnName("SORT_ID");
            entity.Property(e => e.TemplateId).HasColumnName("TEMPLATE_ID");
            entity.Property(e => e.WonColId).HasColumnName("WON_COL_ID");
        });

        modelBuilder.Entity<ImportWondeBorTemplateSysColumn>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IMPORT_WONDE_BOR_TEMPLATE_SYS_COLUMNS");

            entity.Property(e => e.ColDesc)
                .HasMaxLength(75)
                .HasColumnName("COL_DESC");
            entity.Property(e => e.ColName)
                .HasMaxLength(90)
                .HasColumnName("COL_NAME");
            entity.Property(e => e.ColType)
                .HasMaxLength(10)
                .HasColumnName("COL_TYPE");
            entity.Property(e => e.ColTypeDesc)
                .HasMaxLength(30)
                .HasColumnName("COL_TYPE_DESC");
            entity.Property(e => e.Pkid)
                .ValueGeneratedOnAdd()
                .HasColumnName("PKID");
            entity.Property(e => e.SortId).HasColumnName("SORT_ID");
            entity.Property(e => e.SysColId).HasColumnName("SYS_COL_ID");
            entity.Property(e => e.TblName)
                .HasMaxLength(50)
                .HasColumnName("TBL_NAME");
            entity.Property(e => e.UseForImport).HasColumnName("USE_FOR_IMPORT");
        });

        modelBuilder.Entity<KwordDescription>(entity =>
        {
            entity.HasKey(e => e.KdCode);

            entity.ToTable("KWORD_DESCRIPTIONS");

            entity.Property(e => e.KdCode)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("KD_CODE");
            entity.Property(e => e.KdDesc)
                .HasMaxLength(50)
                .HasColumnName("KD_DESC");
            entity.Property(e => e.KdStoplist)
                .HasMaxLength(1)
                .HasColumnName("KD_STOPLIST");
            entity.Property(e => e.OpacHomeSearch)
                .HasMaxLength(1)
                .HasColumnName("OPAC_HOME_SEARCH");
            entity.Property(e => e.OpacShow)
                .HasMaxLength(1)
                .HasColumnName("OPAC_SHOW");
            entity.Property(e => e.StatsType).HasColumnName("STATS_TYPE");
        });

        modelBuilder.Entity<KwordDescriptionsTranslation>(entity =>
        {
            entity.HasKey(e => new { e.KdCode, e.Lcid });

            entity.ToTable("KWORD_DESCRIPTIONS_TRANSLATION");

            entity.Property(e => e.KdCode)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("KD_CODE");
            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.KdDesc)
                .HasMaxLength(50)
                .HasColumnName("KD_DESC");

            entity.HasOne(d => d.KdCodeNavigation).WithMany(p => p.KwordDescriptionsTranslations)
                .HasForeignKey(d => d.KdCode)
                .HasConstraintName("FK_KWORD_DESCRIPTIONS_KWORD_DESCRIPTIONS_TRANSLATION");
        });

        modelBuilder.Entity<KwordStoplist>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("KWORD_STOPLIST");

            entity.Property(e => e.KsStop)
                .HasColumnType("ntext")
                .HasColumnName("KS_STOP");
        });

        modelBuilder.Entity<LibGroup>(entity =>
        {
            entity.HasKey(e => e.LgGroup);

            entity.ToTable("LIB_GROUPS");

            entity.Property(e => e.LgGroup)
                .HasMaxLength(30)
                .HasColumnName("LG_GROUP");
            entity.Property(e => e.LgAllowNgreturn)
                .HasMaxLength(1)
                .HasColumnName("LG_ALLOW_NGRETURN");
            entity.Property(e => e.LgLevel1)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("LG_LEVEL1");
            entity.Property(e => e.LgLevel2)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("LG_LEVEL2");
            entity.Property(e => e.LgLevel3)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("LG_LEVEL3");
            entity.Property(e => e.LgLevel4)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("LG_LEVEL4");
            entity.Property(e => e.LgMsgGreturn)
                .HasMaxLength(1)
                .HasColumnName("LG_MSG_GRETURN");
            entity.Property(e => e.LgPosition)
                .HasMaxLength(50)
                .HasColumnName("LG_POSITION");
            entity.Property(e => e.LgReturnHere)
                .HasMaxLength(1)
                .HasColumnName("LG_RETURN_HERE");
            entity.Property(e => e.LgRule)
                .HasMaxLength(150)
                .HasColumnName("LG_RULE");
            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");
        });

        modelBuilder.Entity<LibGroupPermit>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LIB_GROUP_PERMITS");

            entity.Property(e => e.LgpAction)
                .HasMaxLength(1)
                .HasColumnName("LGP_ACTION");
            entity.Property(e => e.LgpGivefromGroup)
                .HasMaxLength(30)
                .HasColumnName("LGP_GIVEFROM_GROUP");
            entity.Property(e => e.LgpGivetoGroup)
                .HasMaxLength(30)
                .HasColumnName("LGP_GIVETO_GROUP");
            entity.Property(e => e.LgpTable)
                .HasMaxLength(1)
                .HasColumnName("LGP_TABLE");
        });

        modelBuilder.Entity<LibGroupsOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LIB_GROUPS_OLD");

            entity.Property(e => e.LgAllowNgreturn)
                .HasMaxLength(1)
                .HasColumnName("LG_ALLOW_NGRETURN");
            entity.Property(e => e.LgGroup)
                .HasMaxLength(30)
                .HasColumnName("LG_GROUP");
            entity.Property(e => e.LgMsgGreturn)
                .HasMaxLength(1)
                .HasColumnName("LG_MSG_GRETURN");
            entity.Property(e => e.LgReturnHere)
                .HasMaxLength(1)
                .HasColumnName("LG_RETURN_HERE");
        });

        modelBuilder.Entity<LibGroupsTranslation>(entity =>
        {
            entity.HasKey(e => new { e.Lcid, e.LgGroup });

            entity.ToTable("LIB_GROUPS_TRANSLATION");

            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.LgGroup)
                .HasMaxLength(30)
                .HasColumnName("LG_GROUP");
            entity.Property(e => e.LgGroupTran)
                .HasMaxLength(50)
                .HasColumnName("LG_GROUP_TRAN");

            entity.HasOne(d => d.LgGroupNavigation).WithMany(p => p.LibGroupsTranslations)
                .HasForeignKey(d => d.LgGroup)
                .HasConstraintName("FK_LIB_GROUPS_LIB_GROUPS_TRANSLATION");
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
                .HasMaxLength(254)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Lcid).HasColumnName("LCID");
        });

        modelBuilder.Entity<LibLocFloor>(entity =>
        {
            entity.HasKey(e => e.LlfId);

            entity.ToTable("LIB_LOC_FLOOR");

            entity.Property(e => e.LlfId).HasColumnName("LLF_ID");
            entity.Property(e => e.LgGroup)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("LG_GROUP");
            entity.Property(e => e.LlCode)
                .HasMaxLength(30)
                .HasColumnName("LL_CODE");
            entity.Property(e => e.LlfCapacity)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("LLF_CAPACITY");
            entity.Property(e => e.LlfCode)
                .HasMaxLength(40)
                .HasColumnName("LLF_CODE");
            entity.Property(e => e.LlfDescription)
                .HasMaxLength(50)
                .HasColumnName("LLF_DESCRIPTION");
        });

        modelBuilder.Entity<LibLocFloorOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LIB_LOC_FLOOR_OLD");

            entity.Property(e => e.LlfCode)
                .HasMaxLength(20)
                .HasColumnName("LLF_CODE");
        });

        modelBuilder.Entity<LibLocFloorTranslation>(entity =>
        {
            entity.HasKey(e => new { e.Lcid, e.LlfId });

            entity.ToTable("LIB_LOC_FLOOR_TRANSLATION");

            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.LlfId).HasColumnName("LLF_ID");
            entity.Property(e => e.LlfCode)
                .HasMaxLength(75)
                .HasColumnName("LLF_CODE");

            entity.HasOne(d => d.Llf).WithMany(p => p.LibLocFloorTranslations)
                .HasForeignKey(d => d.LlfId)
                .HasConstraintName("FK_LIB_LOC_FLOOR_LIB_LOC_FLOOR_TRANSLATION");
        });

        modelBuilder.Entity<LibLocation>(entity =>
        {
            entity.HasKey(e => new { e.LlGroup, e.LlCode });

            entity.ToTable("LIB_LOCATIONS");

            entity.Property(e => e.LlGroup)
                .HasMaxLength(30)
                .HasColumnName("LL_GROUP");
            entity.Property(e => e.LlCode)
                .HasMaxLength(40)
                .HasColumnName("LL_CODE");
            entity.Property(e => e.AddressLine1)
                .HasMaxLength(85)
                .HasColumnName("ADDRESS_LINE1");
            entity.Property(e => e.AddressLine2)
                .HasMaxLength(85)
                .HasColumnName("ADDRESS_LINE2");
            entity.Property(e => e.AddressLine3)
                .HasMaxLength(85)
                .HasColumnName("ADDRESS_LINE3");
            entity.Property(e => e.AddressLine4)
                .HasMaxLength(85)
                .HasColumnName("ADDRESS_LINE4");
            entity.Property(e => e.ClusterName)
                .HasMaxLength(50)
                .HasColumnName("CLUSTER_NAME");
            entity.Property(e => e.DefaultStkClass)
                .HasMaxLength(20)
                .HasColumnName("DEFAULT_STK_CLASS");
            entity.Property(e => e.FaxNo)
                .HasMaxLength(25)
                .HasColumnName("FAX_NO");
            entity.Property(e => e.LlEmail)
                .HasMaxLength(75)
                .HasColumnName("LL_EMAIL");
            entity.Property(e => e.LlName)
                .HasMaxLength(50)
                .HasColumnName("LL_NAME");
            entity.Property(e => e.LocAlias)
                .HasMaxLength(10)
                .HasColumnName("LOC_ALIAS");
            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");
            entity.Property(e => e.Postcode)
                .HasMaxLength(20)
                .HasColumnName("POSTCODE");
            entity.Property(e => e.TelNo)
                .HasMaxLength(25)
                .HasColumnName("TEL_NO");
        });

        modelBuilder.Entity<LibLocationsOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LIB_LOCATIONS_OLD");

            entity.HasIndex(e => e.LlCode, "LL_CODEX");

            entity.Property(e => e.LlCode)
                .HasMaxLength(20)
                .HasColumnName("LL_CODE");
            entity.Property(e => e.LlGroup)
                .HasMaxLength(30)
                .HasColumnName("LL_GROUP");
            entity.Property(e => e.LlName)
                .HasMaxLength(50)
                .HasColumnName("LL_NAME");
        });

        modelBuilder.Entity<LibLocationsTranslation>(entity =>
        {
            entity.HasKey(e => new { e.Lcid, e.LlCode, e.LlGroup });

            entity.ToTable("LIB_LOCATIONS_TRANSLATION");

            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.LlCode)
                .HasMaxLength(40)
                .HasColumnName("LL_CODE");
            entity.Property(e => e.LlGroup)
                .HasMaxLength(30)
                .HasColumnName("LL_GROUP");
            entity.Property(e => e.LlName)
                .HasMaxLength(50)
                .HasColumnName("LL_NAME");

            entity.HasOne(d => d.LibLocation).WithMany(p => p.LibLocationsTranslations)
                .HasForeignKey(d => new { d.LlGroup, d.LlCode })
                .HasConstraintName("FK_LIB_LOCATIONS_LIB_LOCATIONS_TRANSLATION");
        });

        modelBuilder.Entity<LibMemo>(entity =>
        {
            entity.HasKey(e => new { e.LlGroup, e.LmType });

            entity.ToTable("LIB_MEMOS");

            entity.Property(e => e.LlGroup)
                .HasMaxLength(30)
                .HasDefaultValue("**")
                .HasColumnName("LL_GROUP");
            entity.Property(e => e.LmType)
                .HasMaxLength(10)
                .HasColumnName("LM_TYPE");
            entity.Property(e => e.LmDays).HasColumnName("LM_DAYS");
            entity.Property(e => e.LmDesc)
                .HasMaxLength(250)
                .HasColumnName("LM_DESC");
            entity.Property(e => e.LmShow)
                .HasMaxLength(1)
                .HasColumnName("LM_SHOW");
            entity.Property(e => e.LmShowonreturn)
                .HasMaxLength(1)
                .HasColumnName("LM_SHOWONRETURN");
            entity.Property(e => e.LmValidBor)
                .HasMaxLength(1)
                .HasColumnName("LM_VALID_BOR");
            entity.Property(e => e.LmValidStk)
                .HasMaxLength(1)
                .HasColumnName("LM_VALID_STK");
        });

        modelBuilder.Entity<LibMemosOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LIB_MEMOS_OLD");

            entity.Property(e => e.LmDays).HasColumnName("LM_DAYS");
            entity.Property(e => e.LmDesc)
                .HasMaxLength(250)
                .HasColumnName("LM_DESC");
            entity.Property(e => e.LmShow)
                .HasMaxLength(1)
                .HasColumnName("LM_SHOW");
            entity.Property(e => e.LmType)
                .HasMaxLength(10)
                .HasColumnName("LM_TYPE");
            entity.Property(e => e.LmValidBor)
                .HasMaxLength(1)
                .HasColumnName("LM_VALID_BOR");
            entity.Property(e => e.LmValidStk)
                .HasMaxLength(1)
                .HasColumnName("LM_VALID_STK");
        });

        modelBuilder.Entity<LibMemosTranslation>(entity =>
        {
            entity.HasKey(e => new { e.Lcid, e.LlGroup, e.LmType });

            entity.ToTable("LIB_MEMOS_TRANSLATION");

            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.LlGroup)
                .HasMaxLength(30)
                .HasDefaultValue("**")
                .HasColumnName("LL_GROUP");
            entity.Property(e => e.LmType)
                .HasMaxLength(10)
                .HasColumnName("LM_TYPE");
            entity.Property(e => e.LmDesc)
                .HasMaxLength(250)
                .HasColumnName("LM_DESC");

            entity.HasOne(d => d.LibMemo).WithMany(p => p.LibMemosTranslations)
                .HasForeignKey(d => new { d.LlGroup, d.LmType })
                .HasConstraintName("FK_LIB_MEMOS_LIB_MEMOS_TRANSLATION");
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
                .HasMaxLength(254)
                .HasColumnName("DESCRIPTION");
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
                .HasMaxLength(254)
                .HasColumnName("DESCRIPTION");

            entity.HasOne(d => d.Section).WithMany(p => p.LibSectionsTranslations)
                .HasForeignKey(d => d.SectionId)
                .HasConstraintName("FK_LIB_SECTIONS_LIB_SECTIONS_TRANSLATION");
        });

        modelBuilder.Entity<Llddcatdict>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LLDDCATDICT");

            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<LoanStrategy>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("LOAN_STRATEGY");

            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .HasColumnName("CODE");
            entity.Property(e => e.Name)
                .HasMaxLength(75)
                .HasColumnName("NAME");
            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");
        });

        modelBuilder.Entity<LoanStrategyTranslation>(entity =>
        {
            entity.HasKey(e => new { e.Code, e.Lcid });

            entity.ToTable("LOAN_STRATEGY_TRANSLATION");

            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .HasColumnName("CODE");
            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.Name)
                .HasMaxLength(75)
                .HasColumnName("NAME");

            entity.HasOne(d => d.CodeNavigation).WithMany(p => p.LoanStrategyTranslations)
                .HasForeignKey(d => d.Code)
                .HasConstraintName("FK_LOAN_STRATEGY_LOAN_STRATEGY_TRANSLATION");
        });

        modelBuilder.Entity<LocHour>(entity =>
        {
            entity.HasKey(e => e.LocHoursId).HasName("PK__LOC_HOUR__BEAE13CA7D8E6428");

            entity.ToTable("LOC_HOURS");

            entity.Property(e => e.LocHoursId).HasColumnName("LOC_HOURS_ID");
            entity.Property(e => e.LhCloseHour).HasColumnName("LH_CLOSE_HOUR");
            entity.Property(e => e.LhCloseMinute).HasColumnName("LH_CLOSE_MINUTE");
            entity.Property(e => e.LhDay)
                .HasMaxLength(10)
                .HasColumnName("LH_DAY");
            entity.Property(e => e.LhLocation)
                .HasMaxLength(20)
                .HasColumnName("LH_LOCATION");
            entity.Property(e => e.LhOpenHour).HasColumnName("LH_OPEN_HOUR");
            entity.Property(e => e.LhOpenMinute).HasColumnName("LH_OPEN_MINUTE");
        });

        modelBuilder.Entity<LocMap>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LOC_MAPS");

            entity.Property(e => e.LocCode)
                .HasMaxLength(20)
                .HasColumnName("LOC_CODE");
            entity.Property(e => e.LocMapCode)
                .HasMaxLength(10)
                .HasColumnName("LOC_MAP_CODE");
            entity.Property(e => e.LocMapDesc)
                .HasMaxLength(25)
                .HasColumnName("LOC_MAP_DESC");
            entity.Property(e => e.LocMapFile)
                .HasMaxLength(75)
                .HasColumnName("LOC_MAP_FILE");
            entity.Property(e => e.LocMapX).HasColumnName("LOC_MAP_X");
            entity.Property(e => e.LocMapY).HasColumnName("LOC_MAP_Y");
        });

        modelBuilder.Entity<LocRepSmtp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LOC_REP_SMTP");

            entity.Property(e => e.LrsBccEmail)
                .HasMaxLength(75)
                .HasColumnName("LRS_BCC_EMAIL");
            entity.Property(e => e.LrsLlCode)
                .HasMaxLength(20)
                .HasColumnName("LRS_LL_CODE");
            entity.Property(e => e.LrsRepScreen)
                .HasMaxLength(35)
                .HasColumnName("LRS_REP_SCREEN");
            entity.Property(e => e.LrsRtype).HasColumnName("LRS_RTYPE");
            entity.Property(e => e.LrsSenderEmail)
                .HasMaxLength(75)
                .HasColumnName("LRS_SENDER_EMAIL");
        });

        modelBuilder.Entity<LocShelfMap>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LOC_SHELF_MAPS");

            entity.Property(e => e.LocSmCallFrom)
                .HasMaxLength(25)
                .HasColumnName("LOC_SM_CALL_FROM");
            entity.Property(e => e.LocSmCallTo)
                .HasMaxLength(25)
                .HasColumnName("LOC_SM_CALL_TO");
            entity.Property(e => e.LocSmCode)
                .HasMaxLength(20)
                .HasColumnName("LOC_SM_CODE");
            entity.Property(e => e.LocSmMapCode)
                .HasMaxLength(10)
                .HasColumnName("LOC_SM_MAP_CODE");
            entity.Property(e => e.LocSmMapXend).HasColumnName("LOC_SM_MAP_XEND");
            entity.Property(e => e.LocSmMapXstart).HasColumnName("LOC_SM_MAP_XSTART");
            entity.Property(e => e.LocSmMapYend).HasColumnName("LOC_SM_MAP_YEND");
            entity.Property(e => e.LocSmMapYstart).HasColumnName("LOC_SM_MAP_YSTART");
        });

        modelBuilder.Entity<LocalSystab>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LOCAL_SYSTAB");

            entity.Property(e => e.UniqueNo).HasColumnName("UNIQUE_NO");
        });

        modelBuilder.Entity<LocationTill>(entity =>
        {
            entity.HasKey(e => e.UniqueTillNo);

            entity.ToTable("LOCATION_TILL");

            entity.Property(e => e.UniqueTillNo).HasColumnName("UNIQUE_TILL_NO");
            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IS_ACTIVE");
            entity.Property(e => e.TillGroup)
                .HasMaxLength(30)
                .HasColumnName("TILL_GROUP");
            entity.Property(e => e.TillIdentity)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TILL_IDENTITY");
            entity.Property(e => e.TillLocation)
                .HasMaxLength(40)
                .HasColumnName("TILL_LOCATION");
            entity.Property(e => e.TillName)
                .HasMaxLength(30)
                .HasColumnName("TILL_NAME");
        });

        modelBuilder.Entity<MWord>(entity =>
        {
            entity.HasKey(e => e.MId);

            entity.ToTable("M_WORDS");

            entity.HasIndex(e => new { e.MLookfor, e.MType }, "IX_M_WORDS_CLUSTERED").IsUnique();

            entity.Property(e => e.MId)
                .ValueGeneratedNever()
                .HasColumnName("M_ID");
            entity.Property(e => e.MChangeto)
                .HasMaxLength(25)
                .HasColumnName("M_CHANGETO");
            entity.Property(e => e.MCharcount).HasColumnName("M_CHARCOUNT");
            entity.Property(e => e.MLookfor)
                .HasMaxLength(25)
                .HasColumnName("M_LOOKFOR");
            entity.Property(e => e.MNotes)
                .HasMaxLength(250)
                .HasColumnName("M_NOTES");
            entity.Property(e => e.MPriority).HasColumnName("M_PRIORITY");
            entity.Property(e => e.MType).HasColumnName("M_TYPE");
        });

        modelBuilder.Entity<MWordsOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("M_WORDS_OLD");

            entity.Property(e => e.MChangeto)
                .HasMaxLength(25)
                .HasColumnName("M_CHANGETO");
            entity.Property(e => e.MCharcount).HasColumnName("M_CHARCOUNT");
            entity.Property(e => e.MId).HasColumnName("M_ID");
            entity.Property(e => e.MLookfor)
                .HasMaxLength(25)
                .HasColumnName("M_LOOKFOR");
            entity.Property(e => e.MNotes)
                .HasMaxLength(250)
                .HasColumnName("M_NOTES");
            entity.Property(e => e.MType).HasColumnName("M_TYPE");
        });

        modelBuilder.Entity<MWordsTranslation>(entity =>
        {
            entity.HasKey(e => new { e.Lcid, e.MId });

            entity.ToTable("M_WORDS_TRANSLATION");

            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.MId).HasColumnName("M_ID");
            entity.Property(e => e.MNotes)
                .HasMaxLength(75)
                .HasColumnName("M_NOTES");

            entity.HasOne(d => d.MIdNavigation).WithMany(p => p.MWordsTranslations)
                .HasForeignKey(d => d.MId)
                .HasConstraintName("FK_M_WORDS_M_WORDS_TRANSLATION");
        });

        modelBuilder.Entity<MainMenuApp>(entity =>
        {
            entity.HasKey(e => e.MmaUnique);

            entity.ToTable("MAIN_MENU_APPS");

            entity.Property(e => e.MmaUnique).HasColumnName("MMA_UNIQUE");
            entity.Property(e => e.MmaFilename)
                .HasMaxLength(15)
                .HasColumnName("MMA_FILENAME");
            entity.Property(e => e.MmaLocation)
                .HasMaxLength(20)
                .HasColumnName("MMA_LOCATION");
            entity.Property(e => e.MmaPath)
                .HasMaxLength(75)
                .HasColumnName("MMA_PATH");
            entity.Property(e => e.MmaText)
                .HasMaxLength(50)
                .HasColumnName("MMA_TEXT");
        });

        modelBuilder.Entity<MainMenuAppsOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MAIN_MENU_APPS_OLD");

            entity.Property(e => e.MmaFilename)
                .HasMaxLength(15)
                .HasColumnName("MMA_FILENAME");
            entity.Property(e => e.MmaLocation)
                .HasMaxLength(20)
                .HasColumnName("MMA_LOCATION");
            entity.Property(e => e.MmaPath)
                .HasMaxLength(75)
                .HasColumnName("MMA_PATH");
            entity.Property(e => e.MmaText)
                .HasMaxLength(50)
                .HasColumnName("MMA_TEXT");
            entity.Property(e => e.MmaUnique).HasColumnName("MMA_UNIQUE");
        });

        modelBuilder.Entity<MainMenuAppsTranslation>(entity =>
        {
            entity.HasKey(e => new { e.Lcid, e.MmaUnique });

            entity.ToTable("MAIN_MENU_APPS_TRANSLATION");

            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.MmaUnique).HasColumnName("MMA_UNIQUE");
            entity.Property(e => e.MmaText)
                .HasMaxLength(50)
                .HasColumnName("MMA_TEXT");

            entity.HasOne(d => d.MmaUniqueNavigation).WithMany(p => p.MainMenuAppsTranslations)
                .HasForeignKey(d => d.MmaUnique)
                .HasConstraintName("FK_MAIN_MENU_APPS_MAIN_MENU_APPS_TRANSLATION");
        });

        modelBuilder.Entity<MeetingType>(entity =>
        {
            entity.HasKey(e => e.MeetingTypesid).HasName("PK_dbo.MEETING_TYPES");

            entity.ToTable("MEETING_TYPES");

            entity.Property(e => e.MeetingTypesid).HasColumnName("MEETING_TYPESID");
            entity.Property(e => e.Colour)
                .HasMaxLength(250)
                .HasColumnName("COLOUR");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Orderid).HasColumnName("ORDERID");
            entity.Property(e => e.Servicesid).HasColumnName("SERVICESID");
            entity.Property(e => e.Visible).HasColumnName("VISIBLE");
        });

        modelBuilder.Entity<MeetingTypeDepartment>(entity =>
        {
            entity.HasKey(e => new { e.MeetingTypeid, e.Servicesid }).HasName("PK_dbo.MEETING_TYPE_DEPARTMENT");

            entity.ToTable("MEETING_TYPE_DEPARTMENT");

            entity.Property(e => e.MeetingTypeid).HasColumnName("MEETING_TYPEID");
            entity.Property(e => e.Servicesid).HasColumnName("SERVICESID");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Visible).HasColumnName("VISIBLE");

            entity.HasOne(d => d.MeetingType).WithMany(p => p.MeetingTypeDepartments)
                .HasForeignKey(d => d.MeetingTypeid)
                .HasConstraintName("FK_dbo.MEETING_TYPE_DEPARTMENT_dbo.MEETING_TYPES_MEETING_TYPEID");

            entity.HasOne(d => d.Services).WithMany(p => p.MeetingTypeDepartments)
                .HasForeignKey(d => d.Servicesid)
                .HasConstraintName("FK_dbo.MEETING_TYPE_DEPARTMENT_dbo.SERVICES_SERVICESID");
        });

        modelBuilder.Entity<MeetingTypeFile>(entity =>
        {
            entity.HasKey(e => e.MeetingTypeFileId).HasName("PK_dbo.MEETING_TYPE_FILE");

            entity.ToTable("MEETING_TYPE_FILE");

            entity.Property(e => e.MeetingTypeFileId).HasColumnName("MEETING_TYPE_FILE_ID");
            entity.Property(e => e.FileDesc).HasColumnName("FILE_DESC");
            entity.Property(e => e.FileId).HasColumnName("FILE_ID");
            entity.Property(e => e.Mandatory).HasColumnName("MANDATORY");
            entity.Property(e => e.MeetingType).HasColumnName("MEETING_TYPE");
        });

        modelBuilder.Entity<NcipDataElement>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NCIP_DATA_ELEMENTS");

            entity.HasIndex(e => e.NdeId, "NDE_IDX").IsUnique();

            entity.Property(e => e.NdeId).HasColumnName("NDE_ID");
            entity.Property(e => e.NdeIsClosedType).HasColumnName("NDE_IS_CLOSED_TYPE");
            entity.Property(e => e.NdeName)
                .HasMaxLength(254)
                .HasColumnName("NDE_NAME");
            entity.Property(e => e.NdeVersionId).HasColumnName("NDE_VERSION_ID");
        });

        modelBuilder.Entity<NcipIndexCache>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NCIP_INDEX_CACHE");

            entity.HasIndex(e => e.NicId, "NIC_IDX");

            entity.Property(e => e.NicId)
                .HasMaxLength(30)
                .HasColumnName("NIC_ID");
            entity.Property(e => e.NicIndexes)
                .HasColumnType("ntext")
                .HasColumnName("NIC_INDEXES");
            entity.Property(e => e.NicItem)
                .HasMaxLength(254)
                .HasColumnName("NIC_ITEM");
            entity.Property(e => e.NicOrder).HasColumnName("NIC_ORDER");
        });

        modelBuilder.Entity<NcipMessage>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NCIP_MESSAGES");

            entity.HasIndex(e => e.NmId, "NM_IDX").IsUnique();

            entity.Property(e => e.NmCached).HasColumnName("NM_CACHED");
            entity.Property(e => e.NmId).HasColumnName("NM_ID");
            entity.Property(e => e.NmMessage)
                .HasMaxLength(100)
                .HasColumnName("NM_MESSAGE");
            entity.Property(e => e.NmVersionId).HasColumnName("NM_VERSION_ID");
        });

        modelBuilder.Entity<NcipMsgAttr>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NCIP_MSG_ATTR");

            entity.HasIndex(e => e.NmaId, "NMA_IDX").IsUnique();

            entity.Property(e => e.NmaAttribute)
                .HasMaxLength(254)
                .HasColumnName("NMA_ATTRIBUTE");
            entity.Property(e => e.NmaId).HasColumnName("NMA_ID");
            entity.Property(e => e.NmaIsMessageId).HasColumnName("NMA_IS_MESSAGE_ID");
            entity.Property(e => e.NmaItemId).HasColumnName("NMA_ITEM_ID");
            entity.Property(e => e.NmaType)
                .HasMaxLength(3)
                .HasColumnName("NMA_TYPE");
            entity.Property(e => e.NmaValue)
                .HasMaxLength(254)
                .HasColumnName("NMA_VALUE");
        });

        modelBuilder.Entity<NcipMsgHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NCIP_MSG_HISTORY");

            entity.HasIndex(e => e.NmhId, "NMH_IDX").IsUnique();

            entity.Property(e => e.NmhApp).HasColumnName("NMH_APP");
            entity.Property(e => e.NmhDate)
                .HasColumnType("datetime")
                .HasColumnName("NMH_DATE");
            entity.Property(e => e.NmhDirection).HasColumnName("NMH_DIRECTION");
            entity.Property(e => e.NmhErrors)
                .HasMaxLength(254)
                .HasColumnName("NMH_ERRORS");
            entity.Property(e => e.NmhId).HasColumnName("NMH_ID");
            entity.Property(e => e.NmhIpAddress)
                .HasMaxLength(20)
                .HasColumnName("NMH_IP_ADDRESS");
            entity.Property(e => e.NmhMessage)
                .HasMaxLength(254)
                .HasColumnName("NMH_MESSAGE");
            entity.Property(e => e.NmhProtocol)
                .HasMaxLength(5)
                .HasColumnName("NMH_PROTOCOL");
            entity.Property(e => e.NmhXml)
                .HasColumnType("ntext")
                .HasColumnName("NMH_XML");
        });

        modelBuilder.Entity<NcipScheme>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NCIP_SCHEMES");

            entity.HasIndex(e => e.NsId, "NS_IDX").IsUnique();

            entity.Property(e => e.NsCommonName)
                .HasMaxLength(254)
                .HasColumnName("NS_COMMON_NAME");
            entity.Property(e => e.NsId).HasColumnName("NS_ID");
            entity.Property(e => e.NsScheme)
                .HasMaxLength(254)
                .HasColumnName("NS_SCHEME");
        });

        modelBuilder.Entity<NcipSchemeRef>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NCIP_SCHEME_REFS");

            entity.Property(e => e.NsrDataElementId).HasColumnName("NSR_DATA_ELEMENT_ID");
            entity.Property(e => e.NsrSchemeId).HasColumnName("NSR_SCHEME_ID");
        });

        modelBuilder.Entity<NcipSchemeValue>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NCIP_SCHEME_VALUES");

            entity.HasIndex(e => e.NsvId, "NSV_IDX").IsUnique();

            entity.Property(e => e.NsvDesc)
                .HasMaxLength(254)
                .HasColumnName("NSV_DESC");
            entity.Property(e => e.NsvId).HasColumnName("NSV_ID");
            entity.Property(e => e.NsvSchemeId).HasColumnName("NSV_SCHEME_ID");
            entity.Property(e => e.NsvValue)
                .HasMaxLength(254)
                .HasColumnName("NSV_VALUE");
        });

        modelBuilder.Entity<NcipServerStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NCIP_SERVER_STATUS");

            entity.Property(e => e.NssApp).HasColumnName("NSS_APP");
            entity.Property(e => e.NssIpAddress)
                .HasMaxLength(20)
                .HasColumnName("NSS_IP_ADDRESS");
            entity.Property(e => e.NssMessage)
                .HasMaxLength(254)
                .HasColumnName("NSS_MESSAGE");
            entity.Property(e => e.NssState).HasColumnName("NSS_STATE");
            entity.Property(e => e.NssStatus).HasColumnName("NSS_STATUS");
        });

        modelBuilder.Entity<NcipSystab>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NCIP_SYSTAB");

            entity.Property(e => e.NcipUniqueId).HasColumnName("NCIP_UNIQUE_ID");
            entity.Property(e => e.NdeId).HasColumnName("NDE_ID");
            entity.Property(e => e.NmId).HasColumnName("NM_ID");
            entity.Property(e => e.NmaId).HasColumnName("NMA_ID");
            entity.Property(e => e.NsId).HasColumnName("NS_ID");
            entity.Property(e => e.NsvId).HasColumnName("NSV_ID");
            entity.Property(e => e.NvId).HasColumnName("NV_ID");
            entity.Property(e => e.NxChoiceGroupId).HasColumnName("NX_CHOICE_GROUP_ID");
            entity.Property(e => e.NxId).HasColumnName("NX_ID");
            entity.Property(e => e.NxpId).HasColumnName("NXP_ID");
        });

        modelBuilder.Entity<NcipVersion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NCIP_VERSIONS");

            entity.HasIndex(e => e.NvId, "NV_IDX").IsUnique();

            entity.Property(e => e.NvId).HasColumnName("NV_ID");
            entity.Property(e => e.NvValid).HasColumnName("NV_VALID");
            entity.Property(e => e.NvVersion)
                .HasMaxLength(30)
                .HasColumnName("NV_VERSION");
            entity.Property(e => e.NvVersionDtd)
                .HasMaxLength(254)
                .HasColumnName("NV_VERSION_DTD");
            entity.Property(e => e.NvVersionXsd)
                .HasMaxLength(254)
                .HasColumnName("NV_VERSION_XSD");
        });

        modelBuilder.Entity<NcipXpath>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NCIP_XPATHS");

            entity.HasIndex(e => e.NxId, "NX_IDX").IsUnique();

            entity.HasIndex(e => new { e.NxMessageId, e.NxId }, "NX_MID_IDX");

            entity.HasIndex(e => e.NxXpath, "NX_XPATHIDX");

            entity.Property(e => e.NxCgIsOptional).HasColumnName("NX_CG_IS_OPTIONAL");
            entity.Property(e => e.NxChoiceGroupId).HasColumnName("NX_CHOICE_GROUP_ID");
            entity.Property(e => e.NxChoiceOption)
                .HasMaxLength(30)
                .HasColumnName("NX_CHOICE_OPTION");
            entity.Property(e => e.NxDataType)
                .HasMaxLength(30)
                .HasColumnName("NX_DATA_TYPE");
            entity.Property(e => e.NxId).HasColumnName("NX_ID");
            entity.Property(e => e.NxIsChoice).HasColumnName("NX_IS_CHOICE");
            entity.Property(e => e.NxIsOptional).HasColumnName("NX_IS_OPTIONAL");
            entity.Property(e => e.NxIsRepeatable).HasColumnName("NX_IS_REPEATABLE");
            entity.Property(e => e.NxMessageId).HasColumnName("NX_MESSAGE_ID");
            entity.Property(e => e.NxParentId).HasColumnName("NX_PARENT_ID");
            entity.Property(e => e.NxProblemType).HasColumnName("NX_PROBLEM_TYPE");
            entity.Property(e => e.NxXpath)
                .HasMaxLength(248)
                .HasColumnName("NX_XPATH");
        });

        modelBuilder.Entity<NcipXpathParam>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NCIP_XPATH_PARAMS");

            entity.HasIndex(e => e.NxpId, "NXP_IDX").IsUnique();

            entity.HasIndex(e => e.NxpXpathId, "NXP_XPATH_IDX");

            entity.Property(e => e.NxpId).HasColumnName("NXP_ID");
            entity.Property(e => e.NxpParam)
                .HasMaxLength(254)
                .HasColumnName("NXP_PARAM");
            entity.Property(e => e.NxpParamGroup).HasColumnName("NXP_PARAM_GROUP");
            entity.Property(e => e.NxpParamType).HasColumnName("NXP_PARAM_TYPE");
            entity.Property(e => e.NxpXpathId).HasColumnName("NXP_XPATH_ID");
        });

        modelBuilder.Entity<NetRestrict>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NET_RESTRICT");

            entity.Property(e => e.NetDay).HasColumnName("NET_DAY");
            entity.Property(e => e.NetEntCode)
                .HasMaxLength(25)
                .HasColumnName("NET_ENT_CODE");
            entity.Property(e => e.NetHourFrom).HasColumnName("NET_HOUR_FROM");
            entity.Property(e => e.NetHourTo).HasColumnName("NET_HOUR_TO");
            entity.Property(e => e.NetLlCode)
                .HasMaxLength(20)
                .HasColumnName("NET_LL_CODE");
            entity.Property(e => e.NetLowLogins).HasColumnName("NET_LOW_LOGINS");
            entity.Property(e => e.NetLowQty).HasColumnName("NET_LOW_QTY");
            entity.Property(e => e.NetQty).HasColumnName("NET_QTY");
        });

        modelBuilder.Entity<OpacApp>(entity =>
        {
            entity.HasKey(e => e.AppId).HasName("PK__OPAC_APP__F00E58043F46F94D");

            entity.ToTable("OPAC_APPS");

            entity.Property(e => e.AppId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("APP_ID");
            entity.Property(e => e.AppDesc)
                .HasMaxLength(50)
                .HasColumnName("APP_DESC");
            entity.Property(e => e.CreateDatetime)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATETIME");
        });

        modelBuilder.Entity<OpacAppsMenu>(entity =>
        {
            entity.HasKey(e => new { e.AppId, e.AppMenuId }).HasName("PK_OPAC_APP_MENUS");

            entity.ToTable("OPAC_APPS_MENUS");

            entity.Property(e => e.AppId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("APP_ID");
            entity.Property(e => e.AppMenuId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("APP_MENU_ID");
            entity.Property(e => e.AppMenuDesc)
                .HasMaxLength(50)
                .HasColumnName("APP_MENU_DESC");
            entity.Property(e => e.Show).HasColumnName("SHOW");

            entity.HasOne(d => d.App).WithMany(p => p.OpacAppsMenus)
                .HasForeignKey(d => d.AppId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__OPAC_APPS__APP_I__75435199");
        });

        modelBuilder.Entity<OpacButton>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OPAC_BUTTONS");

            entity.Property(e => e.ObButtonName)
                .HasMaxLength(20)
                .HasColumnName("OB_BUTTON_NAME");
            entity.Property(e => e.ObFileName)
                .HasMaxLength(75)
                .HasColumnName("OB_FILE_NAME");
            entity.Property(e => e.ObPosition).HasColumnName("OB_POSITION");
            entity.Property(e => e.ObPosx).HasColumnName("OB_POSX");
            entity.Property(e => e.ObPosy).HasColumnName("OB_POSY");
            entity.Property(e => e.ObScreenName)
                .HasMaxLength(25)
                .HasColumnName("OB_SCREEN_NAME");
            entity.Property(e => e.ObTitle)
                .HasMaxLength(15)
                .HasColumnName("OB_TITLE");
            entity.Property(e => e.ObUseFor)
                .HasMaxLength(20)
                .HasColumnName("OB_USE_FOR");
            entity.Property(e => e.ObVisible)
                .HasMaxLength(1)
                .HasColumnName("OB_VISIBLE");
        });

        modelBuilder.Entity<OpacFormStat>(entity =>
        {
            entity.HasKey(e => new { e.OfsForm, e.OfsStatsCode });

            entity.ToTable("OPAC_FORM_STATS");

            entity.Property(e => e.OfsForm)
                .HasMaxLength(3)
                .HasColumnName("OFS_FORM");
            entity.Property(e => e.OfsStatsCode)
                .HasMaxLength(6)
                .HasColumnName("OFS_STATS_CODE");
            entity.Property(e => e.OfsDescription)
                .HasMaxLength(50)
                .HasColumnName("OFS_DESCRIPTION");
        });

        modelBuilder.Entity<OpacFormStatsOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OPAC_FORM_STATS_OLD");

            entity.Property(e => e.OfsDescription)
                .HasMaxLength(50)
                .HasColumnName("OFS_DESCRIPTION");
            entity.Property(e => e.OfsForm)
                .HasMaxLength(3)
                .HasColumnName("OFS_FORM");
            entity.Property(e => e.OfsStatsCode)
                .HasMaxLength(6)
                .HasColumnName("OFS_STATS_CODE");
        });

        modelBuilder.Entity<OpacFormStatsTranslation>(entity =>
        {
            entity.HasKey(e => new { e.Lcid, e.OfsForm, e.OfsStatsCode });

            entity.ToTable("OPAC_FORM_STATS_TRANSLATION");

            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.OfsForm)
                .HasMaxLength(3)
                .HasColumnName("OFS_FORM");
            entity.Property(e => e.OfsStatsCode)
                .HasMaxLength(6)
                .HasColumnName("OFS_STATS_CODE");
            entity.Property(e => e.OfsDescription)
                .HasMaxLength(100)
                .HasColumnName("OFS_DESCRIPTION");

            entity.HasOne(d => d.OpacFormStat).WithMany(p => p.OpacFormStatsTranslations)
                .HasForeignKey(d => new { d.OfsForm, d.OfsStatsCode })
                .HasConstraintName("FK_OPAC_FORM_STATS_OPAC_FORM_STATS_TRANSLATION");
        });

        modelBuilder.Entity<OpacLibGroupsStyle>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OPAC_LIB_GROUPS_STYLE");

            entity.Property(e => e.ChartColorCode)
                .HasMaxLength(25)
                .HasColumnName("CHART_COLOR_CODE");
            entity.Property(e => e.LgGroup)
                .HasMaxLength(30)
                .HasColumnName("LG_GROUP");
            entity.Property(e => e.MainColor)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MAIN_COLOR");
            entity.Property(e => e.OpacDisplayGroup)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("OPAC_DISPLAY_GROUP");
            entity.Property(e => e.OpacShow).HasColumnName("OPAC_SHOW");
            entity.Property(e => e.OwnDefaultBookImages).HasColumnName("OWN_DEFAULT_BOOK_IMAGES");
            entity.Property(e => e.OwnLogo).HasColumnName("OWN_LOGO");
        });

        modelBuilder.Entity<OpacMainMenu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OPAC_MAIN_MENU");

            entity.Property(e => e.OpacBgColour).HasColumnName("OPAC_BG_COLOUR");
            entity.Property(e => e.OpacDesc)
                .HasMaxLength(150)
                .HasColumnName("OPAC_DESC");
            entity.Property(e => e.OpacFgColour).HasColumnName("OPAC_FG_COLOUR");
            entity.Property(e => e.OpacFunction).HasColumnName("OPAC_FUNCTION");
            entity.Property(e => e.OpacTitle)
                .HasMaxLength(25)
                .HasColumnName("OPAC_TITLE");
        });

        modelBuilder.Entity<OpacMessage>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OPAC_MESSAGES");

            entity.Property(e => e.OmDescription)
                .HasMaxLength(250)
                .HasColumnName("OM_DESCRIPTION");
            entity.Property(e => e.OmMsgNumber).HasColumnName("OM_MSG_NUMBER");
        });

        modelBuilder.Entity<OpacNice>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OPAC_NICE");

            entity.Property(e => e.OnAuthLimit).HasColumnName("ON_AUTH_LIMIT");
            entity.Property(e => e.OnAuthList)
                .HasMaxLength(1)
                .HasColumnName("ON_AUTH_LIST");
            entity.Property(e => e.OnBrAuthList)
                .HasMaxLength(1)
                .HasColumnName("ON_BR_AUTH_LIST");
            entity.Property(e => e.OnBrAuthTags)
                .HasMaxLength(50)
                .HasColumnName("ON_BR_AUTH_TAGS");
            entity.Property(e => e.OnBrDesc)
                .HasMaxLength(25)
                .HasColumnName("ON_BR_DESC");
            entity.Property(e => e.OnBrStkLines)
                .HasMaxLength(15)
                .HasColumnName("ON_BR_STK_LINES");
            entity.Property(e => e.OnBrStopList)
                .HasMaxLength(1)
                .HasColumnName("ON_BR_STOP_LIST");
            entity.Property(e => e.OnBrowse)
                .HasMaxLength(1)
                .HasColumnName("ON_BROWSE");
            entity.Property(e => e.OnDesc)
                .HasMaxLength(25)
                .HasColumnName("ON_DESC");
            entity.Property(e => e.OnItemSeq)
                .HasMaxLength(15)
                .HasColumnName("ON_ITEM_SEQ");
            entity.Property(e => e.OnKeyword)
                .HasMaxLength(1)
                .HasColumnName("ON_KEYWORD");
            entity.Property(e => e.OnKwAuthList)
                .HasMaxLength(1)
                .HasColumnName("ON_KW_AUTH_LIST");
            entity.Property(e => e.OnKwDesc)
                .HasMaxLength(25)
                .HasColumnName("ON_KW_DESC");
            entity.Property(e => e.OnKwcode)
                .HasMaxLength(15)
                .HasColumnName("ON_KWCODE");
            entity.Property(e => e.OnStats).HasColumnName("ON_STATS");
            entity.Property(e => e.OnStkLimit).HasColumnName("ON_STK_LIMIT");
            entity.Property(e => e.OnTagNo).HasColumnName("ON_TAG_NO");
            entity.Property(e => e.OnWhere)
                .HasMaxLength(200)
                .HasColumnName("ON_WHERE");
        });

        modelBuilder.Entity<OpacOperator>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OPAC_OPERATOR");

            entity.Property(e => e.OperCdrom)
                .HasMaxLength(1)
                .HasColumnName("OPER_CDROM");
            entity.Property(e => e.OperName)
                .HasMaxLength(25)
                .HasColumnName("OPER_NAME");
            entity.Property(e => e.OperPrinter)
                .HasMaxLength(1)
                .HasColumnName("OPER_PRINTER");
            entity.Property(e => e.OperThisLoc)
                .HasMaxLength(1)
                .HasColumnName("OPER_THIS_LOC");
            entity.Property(e => e.OperWeb)
                .HasMaxLength(76)
                .HasColumnName("OPER_WEB");
        });

        modelBuilder.Entity<OpacOther>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OPAC_OTHER");

            entity.Property(e => e.OpCommand)
                .HasMaxLength(250)
                .HasColumnName("OP_COMMAND");
            entity.Property(e => e.OpDesc)
                .HasMaxLength(150)
                .HasColumnName("OP_DESC");
            entity.Property(e => e.OpNo).HasColumnName("OP_NO");
            entity.Property(e => e.OpOperlist)
                .HasMaxLength(240)
                .HasColumnName("OP_OPERLIST");
            entity.Property(e => e.OpSecurity)
                .HasMaxLength(1)
                .HasColumnName("OP_SECURITY");
            entity.Property(e => e.OpSeqNum).HasColumnName("OP_SEQ_NUM");
        });

        modelBuilder.Entity<OpacParam>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OPAC_PARAMS");

            entity.Property(e => e.OpDesc)
                .HasMaxLength(100)
                .HasColumnName("OP_DESC");
            entity.Property(e => e.OpUnique).HasColumnName("OP_UNIQUE");
            entity.Property(e => e.OpValue)
                .HasMaxLength(50)
                .HasColumnName("OP_VALUE");
        });

        modelBuilder.Entity<OpacRestrict>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OPAC_RESTRICT");

            entity.Property(e => e.OrDesc)
                .HasMaxLength(100)
                .HasColumnName("OR_DESC");
            entity.Property(e => e.OrSequence).HasColumnName("OR_SEQUENCE");
            entity.Property(e => e.OrUnique).HasColumnName("OR_UNIQUE");
            entity.Property(e => e.OrWhere)
                .HasColumnType("ntext")
                .HasColumnName("OR_WHERE");
        });

        modelBuilder.Entity<OpacTagdef>(entity =>
        {
            entity.HasKey(e => e.TtTagno);

            entity.ToTable("OPAC_TAGDEF");

            entity.Property(e => e.TtTagno)
                .ValueGeneratedNever()
                .HasColumnName("TT_TAGNO");
            entity.Property(e => e.TtSequenceDetail).HasColumnName("TT_SEQUENCE_DETAIL");
            entity.Property(e => e.TtSequenceResult).HasColumnName("TT_SEQUENCE_RESULT");
            entity.Property(e => e.TtTagdesc)
                .HasMaxLength(100)
                .HasColumnName("TT_TAGDESC");
        });

        modelBuilder.Entity<OpacTagdefOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OPAC_TAGDEF_OLD");

            entity.Property(e => e.TtSequenceDetail).HasColumnName("TT_SEQUENCE_DETAIL");
            entity.Property(e => e.TtSequenceResult).HasColumnName("TT_SEQUENCE_RESULT");
            entity.Property(e => e.TtTagdesc)
                .HasMaxLength(100)
                .HasColumnName("TT_TAGDESC");
            entity.Property(e => e.TtTagno).HasColumnName("TT_TAGNO");
        });

        modelBuilder.Entity<OpacTagdefTranslation>(entity =>
        {
            entity.HasKey(e => new { e.Lcid, e.TtTagno });

            entity.ToTable("OPAC_TAGDEF_TRANSLATION");

            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.TtTagno).HasColumnName("TT_TAGNO");
            entity.Property(e => e.TtTagdesc)
                .HasMaxLength(100)
                .HasColumnName("TT_TAGDESC");

            entity.HasOne(d => d.TtTagnoNavigation).WithMany(p => p.OpacTagdefTranslations)
                .HasForeignKey(d => d.TtTagno)
                .HasConstraintName("FK_OPAC_TAGDEF_OPAC_TAGDEF_TRANSLATION");
        });

        modelBuilder.Entity<OpacUserTypeMenu>(entity =>
        {
            entity.ToTable("OPAC_USER_TYPE_MENUS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AppId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("APP_ID");
            entity.Property(e => e.AppMenuDesc)
                .HasMaxLength(50)
                .HasColumnName("APP_MENU_DESC");
            entity.Property(e => e.AppMenuId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("APP_MENU_ID");
            entity.Property(e => e.Show).HasColumnName("SHOW");
            entity.Property(e => e.UserType)
                .HasMaxLength(50)
                .HasColumnName("USER_TYPE");
        });

        modelBuilder.Entity<Opacuserquery>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OPACUSERQUERY");

            entity.Property(e => e.LlCode)
                .HasMaxLength(20)
                .HasColumnName("LL_CODE");
            entity.Property(e => e.OuqDate)
                .HasColumnType("datetime")
                .HasColumnName("OUQ_DATE");
            entity.Property(e => e.OuqLocation)
                .HasMaxLength(20)
                .HasColumnName("OUQ_LOCATION");
            entity.Property(e => e.OuqQuerydata)
                .HasMaxLength(250)
                .HasColumnName("OUQ_QUERYDATA");
            entity.Property(e => e.OuqResponse)
                .HasMaxLength(1)
                .HasColumnName("OUQ_RESPONSE");
            entity.Property(e => e.OuqType)
                .HasMaxLength(3)
                .HasColumnName("OUQ_TYPE");
            entity.Property(e => e.QuantityResult).HasColumnName("QUANTITY_RESULT");
            entity.Property(e => e.StkCode)
                .HasMaxLength(3)
                .HasColumnName("STK_CODE");
            entity.Property(e => e.StkForm)
                .HasMaxLength(3)
                .HasColumnName("STK_FORM");
            entity.Property(e => e.StkGroup)
                .HasMaxLength(30)
                .HasColumnName("STK_GROUP");
            entity.Property(e => e.StkIsOnLoan)
                .HasMaxLength(1)
                .HasColumnName("STK_IS_ON_LOAN");
            entity.Property(e => e.StkIsOnOrder)
                .HasMaxLength(1)
                .HasColumnName("STK_IS_ON_ORDER");
            entity.Property(e => e.StkIsReserved).HasColumnName("STK_IS_RESERVED");
        });

        modelBuilder.Entity<OpacuserquerySearchCatFilter>(entity =>
        {
            entity.HasKey(e => new { e.OuqLocation, e.OuqType, e.OuqDate, e.CatFilterId });

            entity.ToTable("OPACUSERQUERY_SEARCH_CAT_FILTER");

            entity.Property(e => e.OuqLocation)
                .HasMaxLength(20)
                .HasColumnName("OUQ_LOCATION");
            entity.Property(e => e.OuqType)
                .HasMaxLength(3)
                .HasColumnName("OUQ_TYPE");
            entity.Property(e => e.OuqDate)
                .HasColumnType("datetime")
                .HasColumnName("OUQ_DATE");
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
        });

        modelBuilder.Entity<OpacuserquerySearchDefinition>(entity =>
        {
            entity.HasKey(e => new { e.OuqLocation, e.OuqType, e.OuqDate, e.SubSearchId }).HasName("PK_A_OPAC_BOR_SEARCH_DEFINITION");

            entity.ToTable("OPACUSERQUERY_SEARCH_DEFINITION");

            entity.Property(e => e.OuqLocation)
                .HasMaxLength(20)
                .HasColumnName("OUQ_LOCATION");
            entity.Property(e => e.OuqType)
                .HasMaxLength(3)
                .HasColumnName("OUQ_TYPE");
            entity.Property(e => e.OuqDate)
                .HasColumnType("datetime")
                .HasColumnName("OUQ_DATE");
            entity.Property(e => e.SubSearchId).HasColumnName("SUB_SEARCH_ID");
            entity.Property(e => e.KdCode)
                .HasMaxLength(4)
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
        });

        modelBuilder.Entity<OperDomainuser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OPER_DOMAINUSER");

            entity.Property(e => e.DomainUsername)
                .HasMaxLength(254)
                .HasColumnName("DOMAIN_USERNAME");
            entity.Property(e => e.OperName)
                .HasMaxLength(25)
                .HasColumnName("OPER_NAME");
        });

        modelBuilder.Entity<OperMenuSecurity>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OPER_MENU_SECURITY");

            entity.HasIndex(e => new { e.OperName, e.OperType }, "OPSECOPTYX");

            entity.Property(e => e.OperName)
                .HasMaxLength(25)
                .HasColumnName("OPER_NAME");
            entity.Property(e => e.OperSec)
                .HasMaxLength(50)
                .HasColumnName("OPER_SEC");
            entity.Property(e => e.OperType)
                .HasMaxLength(3)
                .HasColumnName("OPER_TYPE");
        });

        modelBuilder.Entity<OperSecurity>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OPER_SECURITY");

            entity.HasIndex(e => new { e.OperName, e.OperType }, "OPSECUOPTYX");

            entity.Property(e => e.OperName)
                .HasMaxLength(25)
                .HasColumnName("OPER_NAME");
            entity.Property(e => e.OperSec)
                .HasMaxLength(250)
                .HasColumnName("OPER_SEC");
            entity.Property(e => e.OperType)
                .HasMaxLength(3)
                .HasColumnName("OPER_TYPE");
        });

        modelBuilder.Entity<Operator>(entity =>
        {
            entity.HasKey(e => e.OperName);

            entity.ToTable("OPERATOR");

            entity.Property(e => e.OperName)
                .HasMaxLength(25)
                .HasColumnName("OPER_NAME");
            entity.Property(e => e.AccessAllGroups)
                .HasMaxLength(1)
                .HasColumnName("ACCESS_ALL_GROUPS");
            entity.Property(e => e.Email)
                .HasMaxLength(75)
                .HasColumnName("EMAIL");
            entity.Property(e => e.FirstName)
                .HasMaxLength(40)
                .HasColumnName("FIRST_NAME");
            entity.Property(e => e.JobTitle)
                .HasMaxLength(32)
                .HasColumnName("JOB_TITLE");
            entity.Property(e => e.LastName)
                .HasMaxLength(40)
                .HasColumnName("LAST_NAME");
            entity.Property(e => e.LocalIdentifier)
                .HasMaxLength(32)
                .HasColumnName("LOCAL_IDENTIFIER");
            entity.Property(e => e.OperAlowAllocate)
                .HasMaxLength(1)
                .HasColumnName("OPER_ALOW_ALLOCATE");
            entity.Property(e => e.OperBor1)
                .HasMaxLength(25)
                .HasColumnName("OPER_BOR1");
            entity.Property(e => e.OperBor2)
                .HasMaxLength(25)
                .HasColumnName("OPER_BOR2");
            entity.Property(e => e.OperBor3)
                .HasMaxLength(25)
                .HasColumnName("OPER_BOR3");
            entity.Property(e => e.OperBorname1)
                .HasMaxLength(30)
                .HasColumnName("OPER_BORNAME1");
            entity.Property(e => e.OperBorname2)
                .HasMaxLength(30)
                .HasColumnName("OPER_BORNAME2");
            entity.Property(e => e.OperBorname3)
                .HasMaxLength(30)
                .HasColumnName("OPER_BORNAME3");
            entity.Property(e => e.OperCat1)
                .HasMaxLength(25)
                .HasColumnName("OPER_CAT1");
            entity.Property(e => e.OperCat2)
                .HasMaxLength(25)
                .HasColumnName("OPER_CAT2");
            entity.Property(e => e.OperCat3)
                .HasMaxLength(25)
                .HasColumnName("OPER_CAT3");
            entity.Property(e => e.OperCatline1)
                .HasMaxLength(30)
                .HasColumnName("OPER_CATLINE1");
            entity.Property(e => e.OperCatline2)
                .HasMaxLength(30)
                .HasColumnName("OPER_CATLINE2");
            entity.Property(e => e.OperCatline3)
                .HasMaxLength(30)
                .HasColumnName("OPER_CATLINE3");
            entity.Property(e => e.OperCreatedBy)
                .HasMaxLength(25)
                .HasColumnName("OPER_CREATED_BY");
            entity.Property(e => e.OperCreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("OPER_CREATED_ON");
            entity.Property(e => e.OperFixedLoc)
                .HasMaxLength(1)
                .HasColumnName("OPER_FIXED_LOC");
            entity.Property(e => e.OperHasSound)
                .HasMaxLength(1)
                .HasColumnName("OPER_HAS_SOUND");
            entity.Property(e => e.OperLastBor)
                .HasMaxLength(25)
                .HasColumnName("OPER_LAST_BOR");
            entity.Property(e => e.OperLastCat)
                .HasMaxLength(10)
                .HasColumnName("OPER_LAST_CAT");
            entity.Property(e => e.OperLastItem)
                .HasMaxLength(25)
                .HasColumnName("OPER_LAST_ITEM");
            entity.Property(e => e.OperLastScreen)
                .HasMaxLength(50)
                .HasColumnName("OPER_LAST_SCREEN");
            entity.Property(e => e.OperLevel).HasColumnName("OPER_LEVEL");
            entity.Property(e => e.OperLlCode)
                .HasMaxLength(40)
                .HasColumnName("OPER_LL_CODE");
            entity.Property(e => e.OperPassword)
                .HasMaxLength(32)
                .HasColumnName("OPER_PASSWORD");
            entity.Property(e => e.OperPwDue)
                .HasColumnType("datetime")
                .HasColumnName("OPER_PW_DUE");
            entity.Property(e => e.OperStk1)
                .HasMaxLength(25)
                .HasColumnName("OPER_STK1");
            entity.Property(e => e.OperStk2)
                .HasMaxLength(25)
                .HasColumnName("OPER_STK2");
            entity.Property(e => e.OperStk3)
                .HasMaxLength(25)
                .HasColumnName("OPER_STK3");
            entity.Property(e => e.OperStkline1)
                .HasMaxLength(30)
                .HasColumnName("OPER_STKLINE1");
            entity.Property(e => e.OperStkline2)
                .HasMaxLength(30)
                .HasColumnName("OPER_STKLINE2");
            entity.Property(e => e.OperStkline3)
                .HasMaxLength(30)
                .HasColumnName("OPER_STKLINE3");
            entity.Property(e => e.ParentConsentOverride)
                .HasMaxLength(1)
                .HasColumnName("PARENT_CONSENT_OVERRIDE");
            entity.Property(e => e.SupAccess)
                .HasMaxLength(1)
                .HasColumnName("SUP_ACCESS");
        });

        modelBuilder.Entity<OperatorLogonToken>(entity =>
        {
            entity.HasKey(e => e.Token).HasName("PK__OPERATOR__05BE64EC626B8EDA");

            entity.ToTable("OPERATOR_LOGON_TOKEN");

            entity.Property(e => e.Token)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("TOKEN");
            entity.Property(e => e.CreateDatetime)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATETIME");
            entity.Property(e => e.ExpiresOn)
                .HasColumnType("datetime")
                .HasColumnName("EXPIRES_ON");
            entity.Property(e => e.IssuedOn)
                .HasColumnType("datetime")
                .HasColumnName("ISSUED_ON");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATED");
            entity.Property(e => e.OperName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OPER_NAME");
        });

        modelBuilder.Entity<OrdCondition>(entity =>
        {
            entity.HasKey(e => e.OcCode);

            entity.ToTable("ORD_CONDITION");

            entity.Property(e => e.OcCode)
                .HasMaxLength(10)
                .HasColumnName("OC_CODE");
            entity.Property(e => e.OcDesc)
                .HasMaxLength(50)
                .HasColumnName("OC_DESC");
            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");
        });

        modelBuilder.Entity<OrdConditionOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ORD_CONDITION_OLD");

            entity.Property(e => e.OcCode)
                .HasMaxLength(10)
                .HasColumnName("OC_CODE");
            entity.Property(e => e.OcDesc)
                .HasMaxLength(50)
                .HasColumnName("OC_DESC");
        });

        modelBuilder.Entity<OrdConditionTranslation>(entity =>
        {
            entity.HasKey(e => new { e.Lcid, e.OcCode });

            entity.ToTable("ORD_CONDITION_TRANSLATION");

            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.OcCode)
                .HasMaxLength(10)
                .HasColumnName("OC_CODE");
            entity.Property(e => e.OcDesc)
                .HasMaxLength(50)
                .HasColumnName("OC_DESC");

            entity.HasOne(d => d.OcCodeNavigation).WithMany(p => p.OrdConditionTranslations)
                .HasForeignKey(d => d.OcCode)
                .HasConstraintName("FK_ORD_CONDITION_ORD_CONDITION_TRANSLATION");
        });

        modelBuilder.Entity<OrdConvForm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ORD_CONV_FORM");

            entity.Property(e => e.CfForm)
                .HasMaxLength(3)
                .HasColumnName("CF_FORM");
            entity.Property(e => e.CfFormat)
                .HasMaxLength(25)
                .HasColumnName("CF_FORMAT");
        });

        modelBuilder.Entity<OrdType>(entity =>
        {
            entity.HasKey(e => e.OtCode);

            entity.ToTable("ORD_TYPE");

            entity.Property(e => e.OtCode)
                .HasMaxLength(10)
                .HasColumnName("OT_CODE");
            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");
            entity.Property(e => e.OtDesc)
                .HasMaxLength(50)
                .HasColumnName("OT_DESC");
        });

        modelBuilder.Entity<OrdTypeOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ORD_TYPE_OLD");

            entity.Property(e => e.OtCode)
                .HasMaxLength(10)
                .HasColumnName("OT_CODE");
            entity.Property(e => e.OtDesc)
                .HasMaxLength(50)
                .HasColumnName("OT_DESC");
        });

        modelBuilder.Entity<OrdTypeTranslation>(entity =>
        {
            entity.HasKey(e => new { e.Lcid, e.OtCode });

            entity.ToTable("ORD_TYPE_TRANSLATION");

            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.OtCode)
                .HasMaxLength(10)
                .HasColumnName("OT_CODE");
            entity.Property(e => e.OtDesc)
                .HasMaxLength(50)
                .HasColumnName("OT_DESC");

            entity.HasOne(d => d.OtCodeNavigation).WithMany(p => p.OrdTypeTranslations)
                .HasForeignKey(d => d.OtCode)
                .HasConstraintName("FK_ORD_TYPE_ORD_TYPE_TRANSLATION");
        });

        modelBuilder.Entity<PasswordValidation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PASSWORD_VALIDATION");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.LibGroupId).HasColumnName("LIB_GROUP_ID");
            entity.Property(e => e.UserType)
                .HasMaxLength(10)
                .HasColumnName("USER_TYPE");
            entity.Property(e => e.ValidId).HasColumnName("VALID_ID");
            entity.Property(e => e.ValidIdValue).HasColumnName("VALID_ID_VALUE");
        });

        modelBuilder.Entity<PaymentType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PAYMENT_TYPE");

            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Type).HasColumnName("TYPE");
        });

        modelBuilder.Entity<PerCode>(entity =>
        {
            entity.HasKey(e => e.PcCode);

            entity.ToTable("PER_CODES");

            entity.Property(e => e.PcCode)
                .HasMaxLength(3)
                .HasColumnName("PC_CODE");
            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");
            entity.Property(e => e.PcDesc)
                .HasMaxLength(50)
                .HasColumnName("PC_DESC");
            entity.Property(e => e.PcUnit)
                .HasMaxLength(5)
                .HasColumnName("PC_UNIT");
            entity.Property(e => e.PcUnitLength)
                .HasColumnType("decimal(10, 4)")
                .HasColumnName("PC_UNIT_LENGTH");
        });

        modelBuilder.Entity<PerCodesOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PER_CODES_OLD");

            entity.Property(e => e.PcCode)
                .HasMaxLength(3)
                .HasColumnName("PC_CODE");
            entity.Property(e => e.PcDesc)
                .HasMaxLength(50)
                .HasColumnName("PC_DESC");
            entity.Property(e => e.PcUnit)
                .HasMaxLength(5)
                .HasColumnName("PC_UNIT");
            entity.Property(e => e.PcUnitLength)
                .HasColumnType("decimal(10, 4)")
                .HasColumnName("PC_UNIT_LENGTH");
        });

        modelBuilder.Entity<PerCodesTranslation>(entity =>
        {
            entity.HasKey(e => new { e.Lcid, e.PcCode });

            entity.ToTable("PER_CODES_TRANSLATION");

            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.PcCode)
                .HasMaxLength(3)
                .HasColumnName("PC_CODE");
            entity.Property(e => e.PcDesc)
                .HasMaxLength(50)
                .HasColumnName("PC_DESC");

            entity.HasOne(d => d.PcCodeNavigation).WithMany(p => p.PerCodesTranslations)
                .HasForeignKey(d => d.PcCode)
                .HasConstraintName("FK_PER_CODES_PER_CODES_TRANSLATION");
        });

        modelBuilder.Entity<PredefinedQueryOption>(entity =>
        {
            entity.HasKey(e => e.PqoId);

            entity.ToTable("PREDEFINED_QUERY_OPTION");

            entity.Property(e => e.PqoId)
                .ValueGeneratedNever()
                .HasColumnName("PQO_ID");
            entity.Property(e => e.PqoCondition)
                .HasMaxLength(50)
                .HasColumnName("PQO_CONDITION");
            entity.Property(e => e.PqoDesc)
                .HasMaxLength(50)
                .HasColumnName("PQO_DESC");
            entity.Property(e => e.PqoOpacHomeSearch)
                .HasMaxLength(1)
                .HasColumnName("PQO_OPAC_HOME_SEARCH");
            entity.Property(e => e.PqoOpacShow)
                .HasMaxLength(1)
                .HasColumnName("PQO_OPAC_SHOW");
            entity.Property(e => e.PqoStatsType).HasColumnName("PQO_STATS_TYPE");
            entity.Property(e => e.PqoType).HasColumnName("PQO_TYPE");
        });

        modelBuilder.Entity<PredefinedQueryOptionTranslation>(entity =>
        {
            entity.HasKey(e => new { e.Lcid, e.PqoId });

            entity.ToTable("PREDEFINED_QUERY_OPTION_TRANSLATION");

            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.PqoId).HasColumnName("PQO_ID");
            entity.Property(e => e.PqoDesc)
                .HasMaxLength(50)
                .HasColumnName("PQO_DESC");

            entity.HasOne(d => d.Pqo).WithMany(p => p.PredefinedQueryOptionTranslations)
                .HasForeignKey(d => d.PqoId)
                .HasConstraintName("FK_PREDEFINED_QUERY_OPTION_PREDEFINED_QUERY_OPTION_TRANSLATION");
        });

        modelBuilder.Entity<Priorattaindict>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PRIORATTAINDICT");

            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<QueryOptionDate>(entity =>
        {
            entity.HasKey(e => e.QodId);

            entity.ToTable("QUERY_OPTION_DATE");

            entity.Property(e => e.QodId)
                .ValueGeneratedNever()
                .HasColumnName("QOD_ID");
            entity.Property(e => e.QodDesc)
                .HasMaxLength(50)
                .HasColumnName("QOD_DESC");
            entity.Property(e => e.QodOpacShow)
                .HasMaxLength(1)
                .HasColumnName("QOD_OPAC_SHOW");
            entity.Property(e => e.QodTagNo).HasColumnName("QOD_TAG_NO");
            entity.Property(e => e.QodTagSf)
                .HasMaxLength(1)
                .HasColumnName("QOD_TAG_SF");
            entity.Property(e => e.QodType).HasColumnName("QOD_TYPE");
        });

        modelBuilder.Entity<RetentionCode>(entity =>
        {
            entity.HasKey(e => e.RetId).HasName("PK_RETENTIONS_1");

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

        modelBuilder.Entity<RisRefType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RIS_REF_TYPE");

            entity.Property(e => e.Abbreviation)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.RisType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RIS_TYPE");
        });

        modelBuilder.Entity<Service>(entity =>
        {
            entity.HasKey(e => e.Servicesid).HasName("PK_dbo.SERVICES");

            entity.ToTable("SERVICES");

            entity.Property(e => e.Servicesid).HasColumnName("SERVICESID");
            entity.Property(e => e.BgGroup)
                .HasMaxLength(10)
                .HasColumnName("BG_GROUP");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(200)
                .HasColumnName("EMAIL_ADDRESS");
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(500)
                .HasColumnName("IMAGE_URL");
            entity.Property(e => e.MajorService).HasColumnName("MAJOR_SERVICE");
            entity.Property(e => e.Phone)
                .HasMaxLength(25)
                .HasColumnName("PHONE");
            entity.Property(e => e.ServiceAddress)
                .HasMaxLength(120)
                .HasColumnName("SERVICE_ADDRESS");
            entity.Property(e => e.ServiceName)
                .HasMaxLength(500)
                .HasColumnName("SERVICE_NAME");
            entity.Property(e => e.ServiceSummary).HasColumnName("SERVICE_SUMMARY");

            entity.HasOne(d => d.BgGroupNavigation).WithMany(p => p.Services)
                .HasForeignKey(d => d.BgGroup)
                .HasConstraintName("FK_dbo.SERVICES_dbo.BOR_GROUPS_BG_GROUP");
        });

        modelBuilder.Entity<ServiceType>(entity =>
        {
            entity.HasKey(e => e.ServiceTypeid).HasName("PK_dbo.SERVICE_TYPE");

            entity.ToTable("SERVICE_TYPE");

            entity.Property(e => e.ServiceTypeid).HasColumnName("SERVICE_TYPEID");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Visible).HasColumnName("VISIBLE");
        });

        modelBuilder.Entity<SoundTable>(entity =>
        {
            entity.HasKey(e => e.StUniqueNo);

            entity.ToTable("SOUND_TABLE");

            entity.Property(e => e.StUniqueNo)
                .ValueGeneratedNever()
                .HasColumnName("ST_UNIQUE_NO");
            entity.Property(e => e.StActivated)
                .HasMaxLength(1)
                .HasColumnName("ST_ACTIVATED");
            entity.Property(e => e.StEvent)
                .HasMaxLength(100)
                .HasColumnName("ST_EVENT");
            entity.Property(e => e.StFileName)
                .HasMaxLength(25)
                .HasColumnName("ST_FILE_NAME");
            entity.Property(e => e.StPath)
                .HasMaxLength(50)
                .HasColumnName("ST_PATH");
        });

        modelBuilder.Entity<SoundTableOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SOUND_TABLE_OLD");

            entity.Property(e => e.StActivated)
                .HasMaxLength(1)
                .HasColumnName("ST_ACTIVATED");
            entity.Property(e => e.StEvent)
                .HasMaxLength(100)
                .HasColumnName("ST_EVENT");
            entity.Property(e => e.StFileName)
                .HasMaxLength(25)
                .HasColumnName("ST_FILE_NAME");
            entity.Property(e => e.StPath)
                .HasMaxLength(50)
                .HasColumnName("ST_PATH");
            entity.Property(e => e.StUniqueNo).HasColumnName("ST_UNIQUE_NO");
        });

        modelBuilder.Entity<SoundTableTranslation>(entity =>
        {
            entity.HasKey(e => new { e.Lcid, e.StUniqueNo });

            entity.ToTable("SOUND_TABLE_TRANSLATION");

            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.StUniqueNo).HasColumnName("ST_UNIQUE_NO");
            entity.Property(e => e.StEvent)
                .HasMaxLength(100)
                .HasColumnName("ST_EVENT");

            entity.HasOne(d => d.StUniqueNoNavigation).WithMany(p => p.SoundTableTranslations)
                .HasForeignKey(d => d.StUniqueNo)
                .HasConstraintName("FK_SOUND_TABLE_SOUND_TABLE_TRANSLATION");
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

        modelBuilder.Entity<StkCallSet>(entity =>
        {
            entity.HasKey(e => e.ScLineNo);

            entity.ToTable("STK_CALL_SETS");

            entity.Property(e => e.ScLineNo)
                .ValueGeneratedNever()
                .HasColumnName("SC_LINE_NO");
            entity.Property(e => e.ScCallFrom)
                .HasMaxLength(20)
                .HasColumnName("SC_CALL_FROM");
            entity.Property(e => e.ScCallTo)
                .HasMaxLength(20)
                .HasColumnName("SC_CALL_TO");
            entity.Property(e => e.ScCodeRef)
                .HasMaxLength(6)
                .HasColumnName("SC_CODE_REF");
            entity.Property(e => e.ScDesc)
                .HasMaxLength(50)
                .HasColumnName("SC_DESC");
        });

        modelBuilder.Entity<StkCallSetsOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("STK_CALL_SETS_OLD");

            entity.Property(e => e.ScCallFrom)
                .HasMaxLength(20)
                .HasColumnName("SC_CALL_FROM");
            entity.Property(e => e.ScCallTo)
                .HasMaxLength(20)
                .HasColumnName("SC_CALL_TO");
            entity.Property(e => e.ScCodeRef)
                .HasMaxLength(6)
                .HasColumnName("SC_CODE_REF");
            entity.Property(e => e.ScDesc)
                .HasMaxLength(50)
                .HasColumnName("SC_DESC");
            entity.Property(e => e.ScLineNo).HasColumnName("SC_LINE_NO");
        });

        modelBuilder.Entity<StkCallSetsTranslation>(entity =>
        {
            entity.HasKey(e => new { e.Lcid, e.ScLineNo });

            entity.ToTable("STK_CALL_SETS_TRANSLATION");

            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.ScLineNo).HasColumnName("SC_LINE_NO");
            entity.Property(e => e.ScCodeRef)
                .HasMaxLength(6)
                .HasColumnName("SC_CODE_REF");
            entity.Property(e => e.ScDesc)
                .HasMaxLength(50)
                .HasColumnName("SC_DESC");

            entity.HasOne(d => d.ScLineNoNavigation).WithMany(p => p.StkCallSetsTranslations)
                .HasForeignKey(d => d.ScLineNo)
                .HasConstraintName("FK_STK_CALL_SETS_STK_CALL_SETS_TRANSLATION");
        });

        modelBuilder.Entity<StkClass>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__STK_CLAS__AA1D4378B6947ABF");

            entity.ToTable("STK_CLASS");

            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("CODE");
            entity.Property(e => e.ClassDesc)
                .HasMaxLength(75)
                .HasColumnName("CLASS_DESC");
            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");
        });

        modelBuilder.Entity<StkClassTranslation>(entity =>
        {
            entity.HasKey(e => new { e.Lcid, e.Code });

            entity.ToTable("STK_CLASS_TRANSLATION");

            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("CODE");
            entity.Property(e => e.ClassDesc)
                .HasMaxLength(75)
                .HasColumnName("CLASS_DESC");
        });

        modelBuilder.Entity<StkCode>(entity =>
        {
            entity.HasKey(e => e.StkCode1);

            entity.ToTable("STK_CODES");

            entity.Property(e => e.StkCode1)
                .HasMaxLength(6)
                .HasColumnName("STK_CODE");
            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");
            entity.Property(e => e.StkAllowLoan)
                .HasMaxLength(1)
                .HasColumnName("STK_ALLOW_LOAN");
            entity.Property(e => e.StkCodeDesc)
                .HasMaxLength(50)
                .HasColumnName("STK_CODE_DESC");
            entity.Property(e => e.StkFloating)
                .HasMaxLength(1)
                .HasColumnName("STK_FLOATING");
            entity.Property(e => e.StkGroup)
                .HasMaxLength(3)
                .HasColumnName("STK_GROUP");
            entity.Property(e => e.StkJournalSearchShowyn)
                .HasMaxLength(1)
                .HasColumnName("STK_JOURNAL_SEARCH_SHOWYN");
        });

        modelBuilder.Entity<StkCodesOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("STK_CODES_OLD");

            entity.HasIndex(e => e.StkCode, "STK_CODE_IX");

            entity.Property(e => e.StkAllowLoan)
                .HasMaxLength(1)
                .HasColumnName("STK_ALLOW_LOAN");
            entity.Property(e => e.StkCode)
                .HasMaxLength(6)
                .HasColumnName("STK_CODE");
            entity.Property(e => e.StkCodeDesc)
                .HasMaxLength(50)
                .HasColumnName("STK_CODE_DESC");
            entity.Property(e => e.StkFloating)
                .HasMaxLength(1)
                .HasColumnName("STK_FLOATING");
            entity.Property(e => e.StkGroup)
                .HasMaxLength(3)
                .HasColumnName("STK_GROUP");
            entity.Property(e => e.StkJournalSearchShowyn)
                .HasMaxLength(1)
                .HasColumnName("STK_JOURNAL_SEARCH_SHOWYN");
        });

        modelBuilder.Entity<StkCodesTranslation>(entity =>
        {
            entity.HasKey(e => new { e.Lcid, e.StkCode });

            entity.ToTable("STK_CODES_TRANSLATION");

            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.StkCode)
                .HasMaxLength(6)
                .HasColumnName("STK_CODE");
            entity.Property(e => e.StkCodeDesc)
                .HasMaxLength(50)
                .HasColumnName("STK_CODE_DESC");

            entity.HasOne(d => d.StkCodeNavigation).WithMany(p => p.StkCodesTranslations)
                .HasForeignKey(d => d.StkCode)
                .HasConstraintName("FK_STK_CODES_STK_CODES_TRANSLATION");
        });

        modelBuilder.Entity<StkForm>(entity =>
        {
            entity.HasKey(e => new { e.StkForm1, e.LlCode, e.LlGroup }).HasName("pk_STK_FORM");

            entity.ToTable("STK_FORMS");

            entity.Property(e => e.StkForm1)
                .HasMaxLength(3)
                .HasColumnName("STK_FORM");
            entity.Property(e => e.LlCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("LL_CODE");
            entity.Property(e => e.LlGroup)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("LL_GROUP");
            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");
            entity.Property(e => e.StkAllowLoan)
                .HasMaxLength(1)
                .HasColumnName("STK_ALLOW_LOAN");
            entity.Property(e => e.StkCapacity)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("STK_CAPACITY");
            entity.Property(e => e.StkDiaryDayPlan).HasColumnName("STK_DIARY_DAY_PLAN");
            entity.Property(e => e.StkDiaryWeeklyPlan).HasColumnName("STK_DIARY_WEEKLY_PLAN");
            entity.Property(e => e.StkFloating)
                .HasMaxLength(1)
                .HasColumnName("STK_FLOATING");
            entity.Property(e => e.StkFormDesc)
                .HasMaxLength(25)
                .HasColumnName("STK_FORM_DESC");
            entity.Property(e => e.StkIsDiary)
                .HasMaxLength(1)
                .HasColumnName("STK_IS_DIARY");
            entity.Property(e => e.StkIsDigital)
                .HasMaxLength(1)
                .HasColumnName("STK_IS_DIGITAL");
            entity.Property(e => e.StkIsWatermarked)
                .HasMaxLength(1)
                .HasColumnName("STK_IS_WATERMARKED");
            entity.Property(e => e.StkIsevent)
                .HasMaxLength(1)
                .HasColumnName("STK_ISEVENT");
            entity.Property(e => e.StkIsrecurringfee)
                .HasMaxLength(1)
                .HasColumnName("STK_ISRECURRINGFEE");
            entity.Property(e => e.StkIssueType)
                .HasMaxLength(1)
                .HasColumnName("STK_ISSUE_TYPE");
        });

        modelBuilder.Entity<StkFormBor>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("STK_FORM_BOR");

            entity.HasIndex(e => new { e.BtType, e.LlCode }, "SFB_BTYPELOCX");

            entity.HasIndex(e => new { e.LlCode, e.BtType }, "SFB_LOCBTYPEX");

            entity.Property(e => e.BtAllowLoan)
                .HasMaxLength(1)
                .HasColumnName("BT_ALLOW_LOAN");
            entity.Property(e => e.BtAllowLostItemCharge)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BT_ALLOW_LOST_ITEM_CHARGE");
            entity.Property(e => e.BtAllowOverdueCharge)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BT_ALLOW_OVERDUE_CHARGE");
            entity.Property(e => e.BtAllowRenew)
                .HasMaxLength(1)
                .HasColumnName("BT_ALLOW_RENEW");
            entity.Property(e => e.BtAllowRenewReserved)
                .HasMaxLength(1)
                .HasColumnName("BT_ALLOW_RENEW_RESERVED");
            entity.Property(e => e.BtAllowReserve)
                .HasMaxLength(1)
                .HasColumnName("BT_ALLOW_RESERVE");
            entity.Property(e => e.BtDays).HasColumnName("BT_DAYS");
            entity.Property(e => e.BtEmailParent)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("BT_EMAIL_PARENT");
            entity.Property(e => e.BtGraceDays).HasColumnName("BT_GRACE_DAYS");
            entity.Property(e => e.BtGraceHours).HasColumnName("BT_GRACE_HOURS");
            entity.Property(e => e.BtHours)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("BT_HOURS");
            entity.Property(e => e.BtIssCharge)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("BT_ISS_CHARGE");
            entity.Property(e => e.BtLateMax)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("BT_LATE_MAX");
            entity.Property(e => e.BtLatePday)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("BT_LATE_PDAY");
            entity.Property(e => e.BtLatePhour)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("BT_LATE_PHOUR");
            entity.Property(e => e.BtLatePweek)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("BT_LATE_PWEEK");
            entity.Property(e => e.BtLostItemCharge)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("BT_LOST_ITEM_CHARGE");
            entity.Property(e => e.BtLostItemPer)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("BT_LOST_ITEM_PER");
            entity.Property(e => e.BtName)
                .HasMaxLength(25)
                .HasColumnName("BT_NAME");
            entity.Property(e => e.BtOfferCollection)
                .HasMaxLength(1)
                .HasDefaultValue("Y")
                .HasColumnName("BT_OFFER_COLLECTION");
            entity.Property(e => e.BtOfferDelivery)
                .HasMaxLength(1)
                .HasDefaultValue("N")
                .HasColumnName("BT_OFFER_DELIVERY");
            entity.Property(e => e.BtOverdueCharge)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("BT_OVERDUE_CHARGE");
            entity.Property(e => e.BtParentConsentRequired)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("BT_PARENT_CONSENT_REQUIRED");
            entity.Property(e => e.BtQty).HasColumnName("BT_QTY");
            entity.Property(e => e.BtQtyRenew).HasColumnName("BT_QTY_RENEW");
            entity.Property(e => e.BtQtyRes).HasColumnName("BT_QTY_RES");
            entity.Property(e => e.BtRecallSurchargePday)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("BT_RECALL_SURCHARGE_PDAY");
            entity.Property(e => e.BtRenCharge)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("BT_REN_CHARGE");
            entity.Property(e => e.BtResCharge)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("BT_RES_CHARGE");
            entity.Property(e => e.BtType)
                .HasMaxLength(3)
                .HasColumnName("BT_TYPE");
            entity.Property(e => e.LlCode)
                .HasMaxLength(40)
                .HasColumnName("LL_CODE");
            entity.Property(e => e.StkForm)
                .HasMaxLength(3)
                .HasColumnName("STK_FORM");
        });

        modelBuilder.Entity<StkFormCat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("STK_FORM_CAT");

            entity.Property(e => e.SfExclude)
                .HasMaxLength(30)
                .HasColumnName("SF_EXCLUDE");
            entity.Property(e => e.SfForm)
                .HasMaxLength(3)
                .HasColumnName("SF_FORM");
            entity.Property(e => e.SfInclude)
                .HasMaxLength(30)
                .HasColumnName("SF_INCLUDE");
            entity.Property(e => e.SfTag).HasColumnName("SF_TAG");
        });

        modelBuilder.Entity<StkFormRecurringFeeBor>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("STK_FORM_RECURRING_FEE_BOR");

            entity.Property(e => e.AdminFee)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("ADMIN_FEE");
            entity.Property(e => e.BtRenewalFreq)
                .HasMaxLength(3)
                .HasColumnName("BT_RENEWAL_FREQ");
            entity.Property(e => e.BtType)
                .HasMaxLength(3)
                .HasColumnName("BT_TYPE");
            entity.Property(e => e.CancellationFee)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("CANCELLATION_FEE");
            entity.Property(e => e.DiscountEnddate)
                .HasColumnType("datetime")
                .HasColumnName("DISCOUNT_ENDDATE");
            entity.Property(e => e.DiscountPercent)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("DISCOUNT_PERCENT");
            entity.Property(e => e.DiscountStartdate)
                .HasColumnType("datetime")
                .HasColumnName("DISCOUNT_STARTDATE");
            entity.Property(e => e.LlCode)
                .HasMaxLength(20)
                .HasColumnName("LL_CODE");
            entity.Property(e => e.LoyaltyBonus)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("LOYALTY_BONUS");
            entity.Property(e => e.StkForm)
                .HasMaxLength(3)
                .HasColumnName("STK_FORM");
        });

        modelBuilder.Entity<StkFormTcBor>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("STK_FORM_TC_BOR");

            entity.Property(e => e.BookableOnline)
                .HasMaxLength(1)
                .HasColumnName("BOOKABLE_ONLINE");
            entity.Property(e => e.BtAllowEvent)
                .HasMaxLength(1)
                .HasColumnName("BT_ALLOW_EVENT");
            entity.Property(e => e.BtType)
                .HasMaxLength(3)
                .HasColumnName("BT_TYPE");
            entity.Property(e => e.CancellationCharge)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("CANCELLATION_CHARGE");
            entity.Property(e => e.CancellationFeeApplies)
                .HasMaxLength(1)
                .HasColumnName("CANCELLATION_FEE_APPLIES");
            entity.Property(e => e.CancellationPerscent)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("CANCELLATION_PERSCENT");
            entity.Property(e => e.Fee)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("FEE");
            entity.Property(e => e.FeePayable)
                .HasMaxLength(1)
                .HasColumnName("FEE_PAYABLE");
            entity.Property(e => e.LlCode)
                .HasMaxLength(20)
                .HasColumnName("LL_CODE");
            entity.Property(e => e.StkForm)
                .HasMaxLength(3)
                .HasColumnName("STK_FORM");
        });

        modelBuilder.Entity<StkFormsOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("STK_FORMS_OLD");

            entity.Property(e => e.StkAllowLoan)
                .HasMaxLength(1)
                .HasColumnName("STK_ALLOW_LOAN");
            entity.Property(e => e.StkFloating)
                .HasMaxLength(1)
                .HasColumnName("STK_FLOATING");
            entity.Property(e => e.StkForm)
                .HasMaxLength(3)
                .HasColumnName("STK_FORM");
            entity.Property(e => e.StkFormDesc)
                .HasMaxLength(25)
                .HasColumnName("STK_FORM_DESC");
        });

        modelBuilder.Entity<StkFormsTranslation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("STK_FORMS_TRANSLATION");

            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.LlCode)
                .HasMaxLength(20)
                .HasColumnName("LL_CODE");
            entity.Property(e => e.LlGroup)
                .HasMaxLength(30)
                .HasColumnName("LL_GROUP");
            entity.Property(e => e.StkForm)
                .HasMaxLength(3)
                .HasColumnName("STK_FORM");
            entity.Property(e => e.StkFormDesc)
                .HasMaxLength(25)
                .HasColumnName("STK_FORM_DESC");
        });

        modelBuilder.Entity<StkIllStatus>(entity =>
        {
            entity.HasKey(e => e.SisCode);

            entity.ToTable("STK_ILL_STATUS");

            entity.Property(e => e.SisCode)
                .ValueGeneratedNever()
                .HasColumnName("SIS_CODE");
            entity.Property(e => e.SisDescription)
                .HasMaxLength(50)
                .HasColumnName("SIS_DESCRIPTION");
        });

        modelBuilder.Entity<StkIllStatusOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("STK_ILL_STATUS_OLD");

            entity.Property(e => e.SisCode).HasColumnName("SIS_CODE");
            entity.Property(e => e.SisDescription)
                .HasMaxLength(50)
                .HasColumnName("SIS_DESCRIPTION");
        });

        modelBuilder.Entity<StkIllStatusTranslation>(entity =>
        {
            entity.HasKey(e => new { e.Lcid, e.SisCode });

            entity.ToTable("STK_ILL_STATUS_TRANSLATION");

            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.SisCode).HasColumnName("SIS_CODE");
            entity.Property(e => e.SisDescription)
                .HasMaxLength(50)
                .HasColumnName("SIS_DESCRIPTION");

            entity.HasOne(d => d.SisCodeNavigation).WithMany(p => p.StkIllStatusTranslations)
                .HasForeignKey(d => d.SisCode)
                .HasConstraintName("FK_STK_ILL_STATUS_STK_ILL_STATUS_TRANSLATION");
        });

        modelBuilder.Entity<StkItemOrigin>(entity =>
        {
            entity.HasKey(e => e.StoItemOrigin);

            entity.ToTable("STK_ITEM_ORIGINS");

            entity.Property(e => e.StoItemOrigin)
                .HasMaxLength(3)
                .HasColumnName("STO_ITEM_ORIGIN");
            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");
            entity.Property(e => e.StoAllowDepr)
                .HasMaxLength(1)
                .HasColumnName("STO_ALLOW_DEPR");
            entity.Property(e => e.StoKeepDeprHist)
                .HasMaxLength(1)
                .HasColumnName("STO_KEEP_DEPR_HIST");
            entity.Property(e => e.StoNearestDoll)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("STO_NEAREST_DOLL");
            entity.Property(e => e.StoOriginDesc)
                .HasMaxLength(50)
                .HasColumnName("STO_ORIGIN_DESC");
            entity.Property(e => e.StoRoundDown)
                .HasMaxLength(1)
                .HasColumnName("STO_ROUND_DOWN");
            entity.Property(e => e.StoRoundUp)
                .HasMaxLength(1)
                .HasColumnName("STO_ROUND_UP");
        });

        modelBuilder.Entity<StkItemOriginsOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("STK_ITEM_ORIGINS_OLD");

            entity.Property(e => e.StoAllowDepr)
                .HasMaxLength(1)
                .HasColumnName("STO_ALLOW_DEPR");
            entity.Property(e => e.StoItemOrigin)
                .HasMaxLength(3)
                .HasColumnName("STO_ITEM_ORIGIN");
            entity.Property(e => e.StoKeepDeprHist)
                .HasMaxLength(1)
                .HasColumnName("STO_KEEP_DEPR_HIST");
            entity.Property(e => e.StoNearestDoll)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("STO_NEAREST_DOLL");
            entity.Property(e => e.StoOriginDesc)
                .HasMaxLength(50)
                .HasColumnName("STO_ORIGIN_DESC");
            entity.Property(e => e.StoRoundDown)
                .HasMaxLength(1)
                .HasColumnName("STO_ROUND_DOWN");
            entity.Property(e => e.StoRoundUp)
                .HasMaxLength(1)
                .HasColumnName("STO_ROUND_UP");
        });

        modelBuilder.Entity<StkItemOriginsTranslation>(entity =>
        {
            entity.HasKey(e => new { e.Lcid, e.StoItemOrigin });

            entity.ToTable("STK_ITEM_ORIGINS_TRANSLATION");

            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.StoItemOrigin)
                .HasMaxLength(3)
                .HasColumnName("STO_ITEM_ORIGIN");
            entity.Property(e => e.StoOriginDesc)
                .HasMaxLength(50)
                .HasColumnName("STO_ORIGIN_DESC");

            entity.HasOne(d => d.StoItemOriginNavigation).WithMany(p => p.StkItemOriginsTranslations)
                .HasForeignKey(d => d.StoItemOrigin)
                .HasConstraintName("FK_STK_ITEM_ORIGINS_STK_ITEM_ORIGINS_TRANSLATION");
        });

        modelBuilder.Entity<StkLoanType>(entity =>
        {
            entity.HasKey(e => new { e.StlLoanType, e.LlCode, e.LlGroup });

            entity.ToTable("STK_LOAN_TYPES");

            entity.Property(e => e.StlLoanType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("STL_LOAN_TYPE");
            entity.Property(e => e.LlCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("LL_CODE");
            entity.Property(e => e.LlGroup)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("LL_GROUP");
            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");
            entity.Property(e => e.StlAllowRenew)
                .HasMaxLength(1)
                .HasColumnName("STL_ALLOW_RENEW");
            entity.Property(e => e.StlDefaultDays).HasColumnName("STL_DEFAULT_DAYS");
            entity.Property(e => e.StlDefaultHours).HasColumnName("STL_DEFAULT_HOURS");
            entity.Property(e => e.StlLoanDesc)
                .HasMaxLength(25)
                .HasColumnName("STL_LOAN_DESC");
            entity.Property(e => e.StlLoanQty).HasColumnName("STL_LOAN_QTY");
            entity.Property(e => e.StlNeverForLoan)
                .HasMaxLength(1)
                .HasColumnName("STL_NEVER_FOR_LOAN");
            entity.Property(e => e.StlOvernightOnly)
                .HasMaxLength(1)
                .HasColumnName("STL_OVERNIGHT_ONLY");
            entity.Property(e => e.StlTimesRenew).HasColumnName("STL_TIMES_RENEW");
        });

        modelBuilder.Entity<StkLoanTypesOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("STK_LOAN_TYPES_OLD");

            entity.Property(e => e.StlAllowRenew)
                .HasMaxLength(1)
                .HasColumnName("STL_ALLOW_RENEW");
            entity.Property(e => e.StlDefaultDays).HasColumnName("STL_DEFAULT_DAYS");
            entity.Property(e => e.StlDefaultHours).HasColumnName("STL_DEFAULT_HOURS");
            entity.Property(e => e.StlLoanDesc)
                .HasMaxLength(25)
                .HasColumnName("STL_LOAN_DESC");
            entity.Property(e => e.StlLoanQty).HasColumnName("STL_LOAN_QTY");
            entity.Property(e => e.StlLoanType)
                .HasMaxLength(3)
                .HasColumnName("STL_LOAN_TYPE");
            entity.Property(e => e.StlNeverForLoan)
                .HasMaxLength(1)
                .HasColumnName("STL_NEVER_FOR_LOAN");
            entity.Property(e => e.StlOvernightOnly)
                .HasMaxLength(1)
                .HasColumnName("STL_OVERNIGHT_ONLY");
            entity.Property(e => e.StlTimesRenew).HasColumnName("STL_TIMES_RENEW");
        });

        modelBuilder.Entity<StkLoanTypesTranslation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("STK_LOAN_TYPES_TRANSLATION");

            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.StlLoanDesc)
                .HasMaxLength(25)
                .HasColumnName("STL_LOAN_DESC");
            entity.Property(e => e.StlLoanType)
                .HasMaxLength(3)
                .HasColumnName("STL_LOAN_TYPE");
        });

        modelBuilder.Entity<StkLoantBor>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("STK_LOANT_BOR");

            entity.HasIndex(e => new { e.BtType, e.LlCode }, "SLB_BTYPELOCX");

            entity.HasIndex(e => new { e.LlCode, e.BtType }, "SLB_LOCBTYPEX");

            entity.Property(e => e.BtAllowLoan)
                .HasMaxLength(1)
                .HasColumnName("BT_ALLOW_LOAN");
            entity.Property(e => e.BtAllowRenew)
                .HasMaxLength(1)
                .HasColumnName("BT_ALLOW_RENEW");
            entity.Property(e => e.BtAllowReserve)
                .HasMaxLength(1)
                .HasColumnName("BT_ALLOW_RESERVE");
            entity.Property(e => e.BtDays).HasColumnName("BT_DAYS");
            entity.Property(e => e.BtGraceDays).HasColumnName("BT_GRACE_DAYS");
            entity.Property(e => e.BtGraceHours).HasColumnName("BT_GRACE_HOURS");
            entity.Property(e => e.BtHours)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("BT_HOURS");
            entity.Property(e => e.BtIssCharge)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("BT_ISS_CHARGE");
            entity.Property(e => e.BtLateMax)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("BT_LATE_MAX");
            entity.Property(e => e.BtLatePday)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("BT_LATE_PDAY");
            entity.Property(e => e.BtLatePhour)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("BT_LATE_PHOUR");
            entity.Property(e => e.BtLatePweek)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("BT_LATE_PWEEK");
            entity.Property(e => e.BtName)
                .HasMaxLength(25)
                .HasColumnName("BT_NAME");
            entity.Property(e => e.BtQty).HasColumnName("BT_QTY");
            entity.Property(e => e.BtQtyRenew).HasColumnName("BT_QTY_RENEW");
            entity.Property(e => e.BtQtyRes).HasColumnName("BT_QTY_RES");
            entity.Property(e => e.BtRenCharge)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("BT_REN_CHARGE");
            entity.Property(e => e.BtResCharge)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("BT_RES_CHARGE");
            entity.Property(e => e.BtType)
                .HasMaxLength(3)
                .HasColumnName("BT_TYPE");
            entity.Property(e => e.LlCode)
                .HasMaxLength(20)
                .HasColumnName("LL_CODE");
            entity.Property(e => e.StlLoanType)
                .HasMaxLength(3)
                .HasColumnName("STL_LOAN_TYPE");
        });

        modelBuilder.Entity<StkProcess>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("STK_PROCESS");

            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");
            entity.Property(e => e.SpForLoan)
                .HasMaxLength(1)
                .HasColumnName("SP_FOR_LOAN");
            entity.Property(e => e.SpOpacShow)
                .HasMaxLength(1)
                .HasColumnName("SP_OPAC_SHOW");
            entity.Property(e => e.SpOperAlert)
                .HasMaxLength(1)
                .HasColumnName("SP_OPER_ALERT");
            entity.Property(e => e.SpProcess)
                .HasMaxLength(20)
                .HasColumnName("SP_PROCESS");
            entity.Property(e => e.SpRetRemove)
                .HasMaxLength(1)
                .HasColumnName("SP_RET_REMOVE");
        });

        modelBuilder.Entity<StkStatsBor>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("STK_STATS_BOR");

            entity.HasIndex(e => new { e.BtType, e.LlCode }, "SSB_BTYPELOCX");

            entity.HasIndex(e => new { e.LlCode, e.BtType }, "SSB_LOCBTYPEX");

            entity.HasIndex(e => e.StkCode, "SSB_STK_CODEX");

            entity.Property(e => e.BtAllowLoan)
                .HasMaxLength(1)
                .HasColumnName("BT_ALLOW_LOAN");
            entity.Property(e => e.BtAllowRenew)
                .HasMaxLength(1)
                .HasColumnName("BT_ALLOW_RENEW");
            entity.Property(e => e.BtAllowRenewReserved)
                .HasMaxLength(1)
                .HasColumnName("BT_ALLOW_RENEW_RESERVED");
            entity.Property(e => e.BtAllowReserve)
                .HasMaxLength(1)
                .HasColumnName("BT_ALLOW_RESERVE");
            entity.Property(e => e.BtDays).HasColumnName("BT_DAYS");
            entity.Property(e => e.BtGraceDays).HasColumnName("BT_GRACE_DAYS");
            entity.Property(e => e.BtGraceHours).HasColumnName("BT_GRACE_HOURS");
            entity.Property(e => e.BtHours)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("BT_HOURS");
            entity.Property(e => e.BtIssCharge)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("BT_ISS_CHARGE");
            entity.Property(e => e.BtLateMax)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("BT_LATE_MAX");
            entity.Property(e => e.BtLatePday)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("BT_LATE_PDAY");
            entity.Property(e => e.BtLatePhour).HasColumnName("BT_LATE_PHOUR");
            entity.Property(e => e.BtLatePweek)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("BT_LATE_PWEEK");
            entity.Property(e => e.BtName)
                .HasMaxLength(25)
                .HasColumnName("BT_NAME");
            entity.Property(e => e.BtOfferCollection)
                .HasMaxLength(1)
                .HasDefaultValue("Y")
                .HasColumnName("BT_OFFER_COLLECTION");
            entity.Property(e => e.BtOfferDelivery)
                .HasMaxLength(1)
                .HasDefaultValue("N")
                .HasColumnName("BT_OFFER_DELIVERY");
            entity.Property(e => e.BtQty).HasColumnName("BT_QTY");
            entity.Property(e => e.BtQtyRenew).HasColumnName("BT_QTY_RENEW");
            entity.Property(e => e.BtQtyRes).HasColumnName("BT_QTY_RES");
            entity.Property(e => e.BtRecallSurchargePday)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("BT_RECALL_SURCHARGE_PDAY");
            entity.Property(e => e.BtRenCharge)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("BT_REN_CHARGE");
            entity.Property(e => e.BtResCharge)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("BT_RES_CHARGE");
            entity.Property(e => e.BtType)
                .HasMaxLength(3)
                .HasColumnName("BT_TYPE");
            entity.Property(e => e.LlCode)
                .HasMaxLength(40)
                .HasColumnName("LL_CODE");
            entity.Property(e => e.StkCode)
                .HasMaxLength(6)
                .HasColumnName("STK_CODE");
        });

        modelBuilder.Entity<StkStatsCat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("STK_STATS_CAT");

            entity.Property(e => e.ScExclude)
                .HasMaxLength(30)
                .HasColumnName("SC_EXCLUDE");
            entity.Property(e => e.ScInclude)
                .HasMaxLength(30)
                .HasColumnName("SC_INCLUDE");
            entity.Property(e => e.ScNumber)
                .HasMaxLength(1)
                .HasColumnName("SC_NUMBER");
            entity.Property(e => e.ScStartsWith)
                .HasMaxLength(1)
                .HasColumnName("SC_STARTS_WITH");
            entity.Property(e => e.ScStkCode)
                .HasMaxLength(6)
                .HasColumnName("SC_STK_CODE");
            entity.Property(e => e.ScTag).HasColumnName("SC_TAG");
        });

        modelBuilder.Entity<StkStatsCost>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("STK_STATS_COST");

            entity.Property(e => e.StkAccStr)
                .HasMaxLength(250)
                .HasColumnName("STK_ACC_STR");
            entity.Property(e => e.StkAvgYear).HasColumnName("STK_AVG_YEAR");
            entity.Property(e => e.StkDepreciation)
                .HasColumnType("decimal(10, 4)")
                .HasColumnName("STK_DEPRECIATION");
            entity.Property(e => e.StkFirstYear).HasColumnName("STK_FIRST_YEAR");
            entity.Property(e => e.StkForm)
                .HasMaxLength(3)
                .HasColumnName("STK_FORM");
            entity.Property(e => e.StkGroup)
                .HasMaxLength(3)
                .HasColumnName("STK_GROUP");
            entity.Property(e => e.StkLastYear).HasColumnName("STK_LAST_YEAR");
            entity.Property(e => e.StkMinCost)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("STK_MIN_COST");
        });

        modelBuilder.Entity<StkStatsGroup>(entity =>
        {
            entity.HasKey(e => e.StkGroup);

            entity.ToTable("STK_STATS_GROUP");

            entity.Property(e => e.StkGroup)
                .HasMaxLength(3)
                .HasColumnName("STK_GROUP");
            entity.Property(e => e.StkDeprAccount)
                .HasMaxLength(8)
                .HasColumnName("STK_DEPR_ACCOUNT");
            entity.Property(e => e.StkGroupDesc)
                .HasMaxLength(50)
                .HasColumnName("STK_GROUP_DESC");
        });

        modelBuilder.Entity<StkStatsGroupOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("STK_STATS_GROUP_OLD");

            entity.Property(e => e.StkDeprAccount)
                .HasMaxLength(8)
                .HasColumnName("STK_DEPR_ACCOUNT");
            entity.Property(e => e.StkGroup)
                .HasMaxLength(3)
                .HasColumnName("STK_GROUP");
            entity.Property(e => e.StkGroupDesc)
                .HasMaxLength(50)
                .HasColumnName("STK_GROUP_DESC");
        });

        modelBuilder.Entity<StkStatsGroupTranslation>(entity =>
        {
            entity.HasKey(e => new { e.Lcid, e.StkGroup });

            entity.ToTable("STK_STATS_GROUP_TRANSLATION");

            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.StkGroup)
                .HasMaxLength(3)
                .HasColumnName("STK_GROUP");
            entity.Property(e => e.StkGroupDesc)
                .HasMaxLength(50)
                .HasColumnName("STK_GROUP_DESC");

            entity.HasOne(d => d.StkGroupNavigation).WithMany(p => p.StkStatsGroupTranslations)
                .HasForeignKey(d => d.StkGroup)
                .HasConstraintName("FK_STK_STATS_GROUP_STK_STATS_GROUP_TRANSLATION");
        });

        modelBuilder.Entity<StkStoplist>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("STK_STOPLIST");

            entity.Property(e => e.Ks1)
                .HasMaxLength(1)
                .HasColumnName("KS_1");
            entity.Property(e => e.Ks2)
                .HasMaxLength(1)
                .HasColumnName("KS_2");
            entity.Property(e => e.Ks3)
                .HasMaxLength(1)
                .HasColumnName("KS_3");
            entity.Property(e => e.Ks4)
                .HasMaxLength(1)
                .HasColumnName("KS_4");
            entity.Property(e => e.Ks5)
                .HasMaxLength(1)
                .HasColumnName("KS_5");
            entity.Property(e => e.Ks6)
                .HasMaxLength(1)
                .HasColumnName("KS_6");
            entity.Property(e => e.KsStop)
                .HasColumnType("ntext")
                .HasColumnName("KS_STOP");
        });

        modelBuilder.Entity<StkdisplayTag>(entity =>
        {
            entity.HasKey(e => e.StStkForm);

            entity.ToTable("STKDISPLAY_TAGS");

            entity.Property(e => e.StStkForm)
                .HasMaxLength(3)
                .HasColumnName("ST_STK_FORM");
            entity.Property(e => e.StAccessioned)
                .HasMaxLength(30)
                .HasColumnName("ST_ACCESSIONED");
            entity.Property(e => e.StEdline)
                .HasMaxLength(30)
                .HasColumnName("ST_EDLINE");
            entity.Property(e => e.StEdsf)
                .HasMaxLength(1)
                .HasColumnName("ST_EDSF");
            entity.Property(e => e.StEdtag).HasColumnName("ST_EDTAG");
            entity.Property(e => e.StLine1)
                .HasMaxLength(30)
                .HasColumnName("ST_LINE1");
            entity.Property(e => e.StLine2)
                .HasMaxLength(30)
                .HasColumnName("ST_LINE2");
            entity.Property(e => e.StLine3)
                .HasMaxLength(30)
                .HasColumnName("ST_LINE3");
            entity.Property(e => e.StLine4)
                .HasMaxLength(30)
                .HasColumnName("ST_LINE4");
            entity.Property(e => e.StLine5)
                .HasMaxLength(30)
                .HasColumnName("ST_LINE5");
            entity.Property(e => e.StLine6)
                .HasMaxLength(30)
                .HasColumnName("ST_LINE6");
            entity.Property(e => e.StPriceline)
                .HasMaxLength(30)
                .HasColumnName("ST_PRICELINE");
            entity.Property(e => e.StPricesf)
                .HasMaxLength(1)
                .HasColumnName("ST_PRICESF");
            entity.Property(e => e.StPricetag).HasColumnName("ST_PRICETAG");
            entity.Property(e => e.StReceived)
                .HasMaxLength(30)
                .HasColumnName("ST_RECEIVED");
            entity.Property(e => e.StTag11).HasColumnName("ST_TAG11");
            entity.Property(e => e.StTag12).HasColumnName("ST_TAG12");
            entity.Property(e => e.StTag13).HasColumnName("ST_TAG13");
            entity.Property(e => e.StTag21).HasColumnName("ST_TAG21");
            entity.Property(e => e.StTag22).HasColumnName("ST_TAG22");
            entity.Property(e => e.StTag23).HasColumnName("ST_TAG23");
            entity.Property(e => e.StTag31).HasColumnName("ST_TAG31");
            entity.Property(e => e.StTag32).HasColumnName("ST_TAG32");
            entity.Property(e => e.StTag33).HasColumnName("ST_TAG33");
            entity.Property(e => e.StTag41).HasColumnName("ST_TAG41");
            entity.Property(e => e.StTag42).HasColumnName("ST_TAG42");
            entity.Property(e => e.StTag43).HasColumnName("ST_TAG43");
            entity.Property(e => e.StTag51).HasColumnName("ST_TAG51");
            entity.Property(e => e.StTag52).HasColumnName("ST_TAG52");
            entity.Property(e => e.StTag53).HasColumnName("ST_TAG53");
            entity.Property(e => e.StTag61).HasColumnName("ST_TAG61");
            entity.Property(e => e.StTag62).HasColumnName("ST_TAG62");
            entity.Property(e => e.StTag63).HasColumnName("ST_TAG63");
            entity.Property(e => e.StTaglist1)
                .HasMaxLength(60)
                .HasColumnName("ST_TAGLIST1");
            entity.Property(e => e.StTaglist2)
                .HasMaxLength(60)
                .HasColumnName("ST_TAGLIST2");
            entity.Property(e => e.StTaglist3)
                .HasMaxLength(60)
                .HasColumnName("ST_TAGLIST3");
            entity.Property(e => e.StTaglist4)
                .HasMaxLength(60)
                .HasColumnName("ST_TAGLIST4");
            entity.Property(e => e.StTaglist5)
                .HasMaxLength(60)
                .HasColumnName("ST_TAGLIST5");
            entity.Property(e => e.StTaglist6)
                .HasMaxLength(60)
                .HasColumnName("ST_TAGLIST6");
            entity.Property(e => e.StVolline)
                .HasMaxLength(30)
                .HasColumnName("ST_VOLLINE");
            entity.Property(e => e.StVolsf)
                .HasMaxLength(1)
                .HasColumnName("ST_VOLSF");
            entity.Property(e => e.StVoltag).HasColumnName("ST_VOLTAG");
        });

        modelBuilder.Entity<StkdisplayTagsOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("STKDISPLAY_TAGS_OLD");

            entity.Property(e => e.StEdsf)
                .HasMaxLength(1)
                .HasColumnName("ST_EDSF");
            entity.Property(e => e.StEdtag).HasColumnName("ST_EDTAG");
            entity.Property(e => e.StLine1)
                .HasMaxLength(30)
                .HasColumnName("ST_LINE1");
            entity.Property(e => e.StLine2)
                .HasMaxLength(30)
                .HasColumnName("ST_LINE2");
            entity.Property(e => e.StLine3)
                .HasMaxLength(30)
                .HasColumnName("ST_LINE3");
            entity.Property(e => e.StLine4)
                .HasMaxLength(30)
                .HasColumnName("ST_LINE4");
            entity.Property(e => e.StLine5)
                .HasMaxLength(30)
                .HasColumnName("ST_LINE5");
            entity.Property(e => e.StLine6)
                .HasMaxLength(30)
                .HasColumnName("ST_LINE6");
            entity.Property(e => e.StPricesf)
                .HasMaxLength(1)
                .HasColumnName("ST_PRICESF");
            entity.Property(e => e.StPricetag).HasColumnName("ST_PRICETAG");
            entity.Property(e => e.StStkForm)
                .HasMaxLength(3)
                .HasColumnName("ST_STK_FORM");
            entity.Property(e => e.StTag11).HasColumnName("ST_TAG11");
            entity.Property(e => e.StTag12).HasColumnName("ST_TAG12");
            entity.Property(e => e.StTag13).HasColumnName("ST_TAG13");
            entity.Property(e => e.StTag21).HasColumnName("ST_TAG21");
            entity.Property(e => e.StTag22).HasColumnName("ST_TAG22");
            entity.Property(e => e.StTag23).HasColumnName("ST_TAG23");
            entity.Property(e => e.StTag31).HasColumnName("ST_TAG31");
            entity.Property(e => e.StTag32).HasColumnName("ST_TAG32");
            entity.Property(e => e.StTag33).HasColumnName("ST_TAG33");
            entity.Property(e => e.StTag41).HasColumnName("ST_TAG41");
            entity.Property(e => e.StTag42).HasColumnName("ST_TAG42");
            entity.Property(e => e.StTag43).HasColumnName("ST_TAG43");
            entity.Property(e => e.StTag51).HasColumnName("ST_TAG51");
            entity.Property(e => e.StTag52).HasColumnName("ST_TAG52");
            entity.Property(e => e.StTag53).HasColumnName("ST_TAG53");
            entity.Property(e => e.StTag61).HasColumnName("ST_TAG61");
            entity.Property(e => e.StTag62).HasColumnName("ST_TAG62");
            entity.Property(e => e.StTag63).HasColumnName("ST_TAG63");
            entity.Property(e => e.StTaglist1)
                .HasMaxLength(60)
                .HasColumnName("ST_TAGLIST1");
            entity.Property(e => e.StTaglist2)
                .HasMaxLength(60)
                .HasColumnName("ST_TAGLIST2");
            entity.Property(e => e.StTaglist3)
                .HasMaxLength(60)
                .HasColumnName("ST_TAGLIST3");
            entity.Property(e => e.StTaglist4)
                .HasMaxLength(60)
                .HasColumnName("ST_TAGLIST4");
            entity.Property(e => e.StTaglist5)
                .HasMaxLength(60)
                .HasColumnName("ST_TAGLIST5");
            entity.Property(e => e.StTaglist6)
                .HasMaxLength(60)
                .HasColumnName("ST_TAGLIST6");
            entity.Property(e => e.StVolsf)
                .HasMaxLength(1)
                .HasColumnName("ST_VOLSF");
            entity.Property(e => e.StVoltag).HasColumnName("ST_VOLTAG");
        });

        modelBuilder.Entity<StkdisplayTagsTranslation>(entity =>
        {
            entity.HasKey(e => new { e.Lcid, e.StStkForm });

            entity.ToTable("STKDISPLAY_TAGS_TRANSLATION");

            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.StStkForm)
                .HasMaxLength(3)
                .HasColumnName("ST_STK_FORM");
            entity.Property(e => e.StAccessioned)
                .HasMaxLength(30)
                .HasColumnName("ST_ACCESSIONED");
            entity.Property(e => e.StEdline)
                .HasMaxLength(30)
                .HasColumnName("ST_EDLINE");
            entity.Property(e => e.StLine1)
                .HasMaxLength(30)
                .HasColumnName("ST_LINE1");
            entity.Property(e => e.StLine2)
                .HasMaxLength(30)
                .HasColumnName("ST_LINE2");
            entity.Property(e => e.StLine3)
                .HasMaxLength(30)
                .HasColumnName("ST_LINE3");
            entity.Property(e => e.StLine4)
                .HasMaxLength(30)
                .HasColumnName("ST_LINE4");
            entity.Property(e => e.StLine5)
                .HasMaxLength(30)
                .HasColumnName("ST_LINE5");
            entity.Property(e => e.StLine6)
                .HasMaxLength(30)
                .HasColumnName("ST_LINE6");
            entity.Property(e => e.StLine7)
                .HasMaxLength(30)
                .HasColumnName("ST_LINE7");
            entity.Property(e => e.StLine8)
                .HasMaxLength(30)
                .HasColumnName("ST_LINE8");
            entity.Property(e => e.StPriceline)
                .HasMaxLength(30)
                .HasColumnName("ST_PRICELINE");
            entity.Property(e => e.StReceived)
                .HasMaxLength(30)
                .HasColumnName("ST_RECEIVED");
            entity.Property(e => e.StVolline)
                .HasMaxLength(30)
                .HasColumnName("ST_VOLLINE");

            entity.HasOne(d => d.StStkFormNavigation).WithMany(p => p.StkdisplayTagsTranslations)
                .HasForeignKey(d => d.StStkForm)
                .HasConstraintName("FK_STKDISPLAY_TAGS_STKDISPLAY_TAGS_TRANSLATION");
        });

        modelBuilder.Entity<Stkvalidparam>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("STKVALIDPARAM");

            entity.Property(e => e.StkCost)
                .HasMaxLength(1)
                .HasColumnName("STK_COST");
            entity.Property(e => e.StkDateAcc)
                .HasMaxLength(1)
                .HasColumnName("STK_DATE_ACC");
            entity.Property(e => e.StkDateRecd)
                .HasMaxLength(1)
                .HasColumnName("STK_DATE_RECD");
            entity.Property(e => e.StkForLoan)
                .HasMaxLength(1)
                .HasColumnName("STK_FOR_LOAN");
            entity.Property(e => e.StkForm)
                .HasMaxLength(3)
                .HasColumnName("STK_FORM");
            entity.Property(e => e.StkItemOrigin)
                .HasMaxLength(1)
                .HasColumnName("STK_ITEM_ORIGIN");
            entity.Property(e => e.StkLine1)
                .HasMaxLength(1)
                .HasColumnName("STK_LINE1");
            entity.Property(e => e.StkLine2)
                .HasMaxLength(1)
                .HasColumnName("STK_LINE2");
            entity.Property(e => e.StkLine3)
                .HasMaxLength(1)
                .HasColumnName("STK_LINE3");
            entity.Property(e => e.StkLine4)
                .HasMaxLength(1)
                .HasColumnName("STK_LINE4");
            entity.Property(e => e.StkLine5)
                .HasMaxLength(1)
                .HasColumnName("STK_LINE5");
            entity.Property(e => e.StkLine6)
                .HasMaxLength(1)
                .HasColumnName("STK_LINE6");
            entity.Property(e => e.StkLoanType)
                .HasMaxLength(1)
                .HasColumnName("STK_LOAN_TYPE");
            entity.Property(e => e.StkLocPerm)
                .HasMaxLength(1)
                .HasColumnName("STK_LOC_PERM");
            entity.Property(e => e.StkLocTemp)
                .HasMaxLength(1)
                .HasColumnName("STK_LOC_TEMP");
            entity.Property(e => e.StkStatsCode)
                .HasMaxLength(1)
                .HasColumnName("STK_STATS_CODE");
        });

        modelBuilder.Entity<Suburb>(entity =>
        {
            entity.HasKey(e => e.SuburbCode);

            entity.ToTable("SUBURB");

            entity.Property(e => e.SuburbCode)
                .HasMaxLength(3)
                .HasColumnName("SUBURB_CODE");
            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");
            entity.Property(e => e.SuburbLlCode)
                .HasMaxLength(20)
                .HasColumnName("SUBURB_LL_CODE");
            entity.Property(e => e.SuburbName)
                .HasMaxLength(75)
                .HasColumnName("SUBURB_NAME");
            entity.Property(e => e.SuburbPostcode)
                .HasMaxLength(20)
                .HasColumnName("SUBURB_POSTCODE");
        });

        modelBuilder.Entity<SuburbOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SUBURB_OLD");

            entity.Property(e => e.SuburbCode)
                .HasMaxLength(3)
                .HasColumnName("SUBURB_CODE");
            entity.Property(e => e.SuburbLlCode)
                .HasMaxLength(20)
                .HasColumnName("SUBURB_LL_CODE");
            entity.Property(e => e.SuburbName)
                .HasMaxLength(75)
                .HasColumnName("SUBURB_NAME");
            entity.Property(e => e.SuburbPostcode)
                .HasMaxLength(20)
                .HasColumnName("SUBURB_POSTCODE");
        });

        modelBuilder.Entity<SuburbTranslation>(entity =>
        {
            entity.HasKey(e => new { e.SuburbCode, e.Lcid });

            entity.ToTable("SUBURB_TRANSLATION");

            entity.Property(e => e.SuburbCode)
                .HasMaxLength(3)
                .HasColumnName("SUBURB_CODE");
            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.SuburbName)
                .HasMaxLength(75)
                .HasColumnName("SUBURB_NAME");

            entity.HasOne(d => d.SuburbCodeNavigation).WithMany(p => p.SuburbTranslations)
                .HasForeignKey(d => d.SuburbCode)
                .HasConstraintName("FK_SUBURB_SUBURB_TRANSLATION");
        });

        modelBuilder.Entity<SysPasswordValidation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SYS_PASS__3214EC2766D93574");

            entity.ToTable("SYS_PASSWORD_VALIDATION");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ErrorMsg)
                .HasMaxLength(100)
                .HasColumnName("ERROR_MSG");
            entity.Property(e => e.JavascriptRegex)
                .HasMaxLength(50)
                .HasColumnName("JAVASCRIPT_REGEX");
            entity.Property(e => e.MessageId)
                .HasMaxLength(50)
                .HasColumnName("MESSAGE_ID");
            entity.Property(e => e.MsgDisplayStatus)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("MSG_DISPLAY_STATUS");
            entity.Property(e => e.ValidDesc)
                .HasMaxLength(150)
                .HasColumnName("VALID_DESC");
            entity.Property(e => e.ValidRegex)
                .HasMaxLength(50)
                .HasColumnName("VALID_REGEX");
        });

        modelBuilder.Entity<TableViewConfig>(entity =>
        {
            entity.ToTable("TABLE_VIEW_CONFIG");

            entity.HasIndex(e => new { e.TabName, e.ColumnNum }, "UQ_TAB_NAME_COLUMN_NUM").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BorClasses)
                .HasMaxLength(10)
                .HasColumnName("BOR_CLASSES");
            entity.Property(e => e.BorGroups)
                .HasMaxLength(10)
                .HasColumnName("BOR_GROUPS");
            entity.Property(e => e.BorType)
                .HasMaxLength(3)
                .HasColumnName("BOR_TYPE");
            entity.Property(e => e.ColumnNum).HasColumnName("COLUMN_NUM");
            entity.Property(e => e.Columnid).HasColumnName("COLUMNID");
            entity.Property(e => e.DbColumnDescriptionId).HasColumnName("DB_COLUMN_DESCRIPTION_ID");
            entity.Property(e => e.Rowid).HasColumnName("ROWID");
            entity.Property(e => e.TabName)
                .HasMaxLength(50)
                .HasColumnName("TAB_NAME");

            entity.HasOne(d => d.DbColumnDescription).WithMany(p => p.TableViewConfigs)
                .HasForeignKey(d => d.DbColumnDescriptionId)
                .HasConstraintName("FK_DB_COLUMN_DESCRIPTION_TABLE_VIEW_CONFIG");
        });

        modelBuilder.Entity<TagCatNice>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TAG_CAT_NICE");

            entity.Property(e => e.OpacHomeSearch)
                .HasMaxLength(1)
                .HasColumnName("OPAC_HOME_SEARCH");
            entity.Property(e => e.OpacShow)
                .HasMaxLength(1)
                .HasColumnName("OPAC_SHOW");
            entity.Property(e => e.StatsType).HasColumnName("STATS_TYPE");
            entity.Property(e => e.TnAuthoritySearch)
                .HasDefaultValue((byte)1)
                .HasColumnName("TN_AUTHORITY_SEARCH");
            entity.Property(e => e.TnDesc)
                .HasMaxLength(50)
                .HasColumnName("TN_DESC");
            entity.Property(e => e.TnStoplist)
                .HasMaxLength(1)
                .HasColumnName("TN_STOPLIST");
            entity.Property(e => e.TnTagno).HasColumnName("TN_TAGNO");
            entity.Property(e => e.TnWhere)
                .HasMaxLength(100)
                .HasColumnName("TN_WHERE");
        });

        modelBuilder.Entity<TagFixedParam>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TAG_FIXED_PARAMS");

            entity.Property(e => e.TfpDesc)
                .HasMaxLength(100)
                .HasColumnName("TFP_DESC");
            entity.Property(e => e.TfpLength).HasColumnName("TFP_LENGTH");
            entity.Property(e => e.TfpMaterialType)
                .HasMaxLength(20)
                .HasColumnName("TFP_MATERIAL_TYPE");
            entity.Property(e => e.TfpOptionCode)
                .HasMaxLength(4)
                .HasColumnName("TFP_OPTION_CODE");
            entity.Property(e => e.TfpOptionDesc)
                .HasMaxLength(50)
                .HasColumnName("TFP_OPTION_DESC");
            entity.Property(e => e.TfpOptionSeq).HasColumnName("TFP_OPTION_SEQ");
            entity.Property(e => e.TfpPos).HasColumnName("TFP_POS");
            entity.Property(e => e.TfpTagno).HasColumnName("TFP_TAGNO");
            entity.Property(e => e.TfpUniqueNo).HasColumnName("TFP_UNIQUE_NO");
            entity.Property(e => e.TfpYearfr).HasColumnName("TFP_YEARFR");
            entity.Property(e => e.TfpYearto).HasColumnName("TFP_YEARTO");
        });

        modelBuilder.Entity<TagGroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TAG_GROUP");

            entity.Property(e => e.TgGroupNo)
                .HasMaxLength(3)
                .HasColumnName("TG_GROUP_NO");
            entity.Property(e => e.TgTagno).HasColumnName("TG_TAGNO");
        });

        modelBuilder.Entity<TagItemdef>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TAG_ITEMDEF");

            entity.Property(e => e.TiLength).HasColumnName("TI_LENGTH");
            entity.Property(e => e.TiLoadType)
                .HasMaxLength(1)
                .HasColumnName("TI_LOAD_TYPE");
            entity.Property(e => e.TiMarcType)
                .HasMaxLength(1)
                .HasColumnName("TI_MARC_TYPE");
            entity.Property(e => e.TiMarcVerify)
                .HasMaxLength(1)
                .HasColumnName("TI_MARC_VERIFY");
            entity.Property(e => e.TiOffset).HasColumnName("TI_OFFSET");
            entity.Property(e => e.TiSubfield)
                .HasMaxLength(1)
                .HasColumnName("TI_SUBFIELD");
            entity.Property(e => e.TiTagNo).HasColumnName("TI_TAG_NO");
            entity.Property(e => e.TiUnique).HasColumnName("TI_UNIQUE");
        });

        modelBuilder.Entity<TagItemdefTranslation>(entity =>
        {
            entity.HasKey(e => new { e.Lcid, e.TiUnique });

            entity.ToTable("TAG_ITEMDEF_TRANSLATION");

            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.TiUnique).HasColumnName("TI_UNIQUE");
            entity.Property(e => e.TiDescription)
                .HasMaxLength(75)
                .HasColumnName("TI_DESCRIPTION");
        });

        modelBuilder.Entity<TagItemdefTranslationBase>(entity =>
        {
            entity.HasKey(e => e.TiUnique);

            entity.ToTable("TAG_ITEMDEF_TRANSLATION_BASE");

            entity.Property(e => e.TiUnique)
                .ValueGeneratedNever()
                .HasColumnName("TI_UNIQUE");
            entity.Property(e => e.TiDescription)
                .HasMaxLength(75)
                .HasColumnName("TI_DESCRIPTION");
        });

        modelBuilder.Entity<TagNice>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TAG_NICE");

            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");
            entity.Property(e => e.StatsType).HasColumnName("STATS_TYPE");
            entity.Property(e => e.TnDesc)
                .HasMaxLength(50)
                .HasColumnName("TN_DESC");
            entity.Property(e => e.TnStoplist)
                .HasMaxLength(1)
                .HasColumnName("TN_STOPLIST");
            entity.Property(e => e.TnTagno).HasColumnName("TN_TAGNO");
            entity.Property(e => e.TnWhere)
                .HasMaxLength(200)
                .HasColumnName("TN_WHERE");
        });

        modelBuilder.Entity<TagSfdef>(entity =>
        {
            entity.HasKey(e => new { e.TsTagno, e.TsSf });

            entity.ToTable("TAG_SFDEF");

            entity.Property(e => e.TsTagno).HasColumnName("TS_TAGNO");
            entity.Property(e => e.TsSf)
                .HasMaxLength(1)
                .HasColumnName("TS_SF");
            entity.Property(e => e.RisCode)
                .HasMaxLength(2)
                .HasColumnName("RIS_CODE");
            entity.Property(e => e.RisDesc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RIS_DESC");
            entity.Property(e => e.TsAddSf)
                .HasMaxLength(1)
                .HasColumnName("TS_ADD_SF");
            entity.Property(e => e.TsAddTag).HasColumnName("TS_ADD_TAG");
            entity.Property(e => e.TsDatatype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TS_DATATYPE");
            entity.Property(e => e.TsDateFlag)
                .HasMaxLength(1)
                .HasColumnName("TS_DATE_FLAG");
            entity.Property(e => e.TsKey)
                .HasMaxLength(1)
                .HasColumnName("TS_KEY");
            entity.Property(e => e.TsKeyword)
                .HasMaxLength(1)
                .HasColumnName("TS_KEYWORD");
            entity.Property(e => e.TsMarc)
                .HasMaxLength(1)
                .HasColumnName("TS_MARC");
            entity.Property(e => e.TsRepeatable)
                .HasMaxLength(1)
                .HasColumnName("TS_REPEATABLE");
            entity.Property(e => e.TsSequence).HasColumnName("TS_SEQUENCE");
            entity.Property(e => e.TsSfDesc)
                .HasMaxLength(150)
                .HasColumnName("TS_SF_DESC");
            entity.Property(e => e.TsShared)
                .HasMaxLength(1)
                .HasColumnName("TS_SHARED");
            entity.Property(e => e.TsStoplist)
                .HasMaxLength(1)
                .HasColumnName("TS_STOPLIST");
            entity.Property(e => e.TsUnique)
                .HasMaxLength(1)
                .HasColumnName("TS_UNIQUE");
        });

        modelBuilder.Entity<TagSfdefOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TAG_SFDEF_OLD");

            entity.HasIndex(e => new { e.TsTagno, e.TsSequence }, "TAG_SFNOX");

            entity.Property(e => e.TsAddSf)
                .HasMaxLength(1)
                .HasColumnName("TS_ADD_SF");
            entity.Property(e => e.TsAddTag).HasColumnName("TS_ADD_TAG");
            entity.Property(e => e.TsDatatype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TS_DATATYPE");
            entity.Property(e => e.TsDateFlag)
                .HasMaxLength(1)
                .HasColumnName("TS_DATE_FLAG");
            entity.Property(e => e.TsKey)
                .HasMaxLength(1)
                .HasColumnName("TS_KEY");
            entity.Property(e => e.TsKeyword)
                .HasMaxLength(1)
                .HasColumnName("TS_KEYWORD");
            entity.Property(e => e.TsMarc)
                .HasMaxLength(1)
                .HasColumnName("TS_MARC");
            entity.Property(e => e.TsRepeatable)
                .HasMaxLength(1)
                .HasColumnName("TS_REPEATABLE");
            entity.Property(e => e.TsSequence).HasColumnName("TS_SEQUENCE");
            entity.Property(e => e.TsSf)
                .HasMaxLength(1)
                .HasColumnName("TS_SF");
            entity.Property(e => e.TsSfDesc)
                .HasMaxLength(150)
                .HasColumnName("TS_SF_DESC");
            entity.Property(e => e.TsShared)
                .HasMaxLength(1)
                .HasColumnName("TS_SHARED");
            entity.Property(e => e.TsTagno).HasColumnName("TS_TAGNO");
            entity.Property(e => e.TsUnique)
                .HasMaxLength(1)
                .HasColumnName("TS_UNIQUE");
        });

        modelBuilder.Entity<TagSfdefTranslation>(entity =>
        {
            entity.HasKey(e => new { e.TsTagno, e.TsSf, e.Lcid });

            entity.ToTable("TAG_SFDEF_TRANSLATION");

            entity.HasIndex(e => new { e.Lcid, e.TsTagno }, "IX_TAG_SFDEF_TRANSLATION_LCID");

            entity.Property(e => e.TsTagno).HasColumnName("TS_TAGNO");
            entity.Property(e => e.TsSf)
                .HasMaxLength(1)
                .HasColumnName("TS_SF");
            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.TsSfDesc)
                .HasMaxLength(150)
                .HasColumnName("TS_SF_DESC");

            entity.HasOne(d => d.TagSfdef).WithMany(p => p.TagSfdefTranslations)
                .HasForeignKey(d => new { d.TsTagno, d.TsSf })
                .HasConstraintName("FK_TAG_SFDEF_TAG_SFDEF_TRANSLATION");
        });

        modelBuilder.Entity<TagTagdef>(entity =>
        {
            entity.HasKey(e => e.TtTagno);

            entity.ToTable("TAG_TAGDEF");

            entity.Property(e => e.TtTagno)
                .ValueGeneratedNever()
                .HasColumnName("TT_TAGNO");
            entity.Property(e => e.TtAllowCrossref)
                .HasMaxLength(60)
                .HasColumnName("TT_ALLOW_CROSSREF");
            entity.Property(e => e.TtAuthtagno).HasColumnName("TT_AUTHTAGNO");
            entity.Property(e => e.TtKdCode)
                .HasMaxLength(1)
                .HasColumnName("TT_KD_CODE");
            entity.Property(e => e.TtKeeptag).HasColumnName("TT_KEEPTAG");
            entity.Property(e => e.TtRepeatable)
                .HasMaxLength(1)
                .HasColumnName("TT_REPEATABLE");
            entity.Property(e => e.TtSfformat)
                .HasMaxLength(200)
                .HasColumnName("TT_SFFORMAT");
            entity.Property(e => e.TtTagdesc)
                .HasMaxLength(100)
                .HasColumnName("TT_TAGDESC");
            entity.Property(e => e.TtTagformat)
                .HasMaxLength(200)
                .HasColumnName("TT_TAGFORMAT");
            entity.Property(e => e.TtTagind1).HasColumnName("TT_TAGIND1");
            entity.Property(e => e.TtTagind2).HasColumnName("TT_TAGIND2");
            entity.Property(e => e.TtUniqueAuth)
                .HasMaxLength(1)
                .HasColumnName("TT_UNIQUE_AUTH");
        });

        modelBuilder.Entity<TagTagdefOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TAG_TAGDEF_OLD");

            entity.HasIndex(e => e.TtTagno, "TAG_NOX");

            entity.Property(e => e.TtAllowCrossref)
                .HasMaxLength(60)
                .HasColumnName("TT_ALLOW_CROSSREF");
            entity.Property(e => e.TtAuthtagno).HasColumnName("TT_AUTHTAGNO");
            entity.Property(e => e.TtKdCode)
                .HasMaxLength(1)
                .HasColumnName("TT_KD_CODE");
            entity.Property(e => e.TtKeeptag).HasColumnName("TT_KEEPTAG");
            entity.Property(e => e.TtRepeatable)
                .HasMaxLength(1)
                .HasColumnName("TT_REPEATABLE");
            entity.Property(e => e.TtSfformat)
                .HasMaxLength(200)
                .HasColumnName("TT_SFFORMAT");
            entity.Property(e => e.TtTagdesc)
                .HasMaxLength(100)
                .HasColumnName("TT_TAGDESC");
            entity.Property(e => e.TtTagformat)
                .HasMaxLength(200)
                .HasColumnName("TT_TAGFORMAT");
            entity.Property(e => e.TtTagind1).HasColumnName("TT_TAGIND1");
            entity.Property(e => e.TtTagind2).HasColumnName("TT_TAGIND2");
            entity.Property(e => e.TtTagno).HasColumnName("TT_TAGNO");
            entity.Property(e => e.TtUniqueAuth)
                .HasMaxLength(1)
                .HasColumnName("TT_UNIQUE_AUTH");
        });

        modelBuilder.Entity<TagTagdefTranslation>(entity =>
        {
            entity.HasKey(e => new { e.TtTagno, e.Lcid });

            entity.ToTable("TAG_TAGDEF_TRANSLATION");

            entity.HasIndex(e => e.Lcid, "IX_TAG_TAGDEF_TRANSLATION_LCID");

            entity.Property(e => e.TtTagno).HasColumnName("TT_TAGNO");
            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.TtTagdesc)
                .HasMaxLength(100)
                .HasColumnName("TT_TAGDESC");

            entity.HasOne(d => d.TtTagnoNavigation).WithMany(p => p.TagTagdefTranslations)
                .HasForeignKey(d => d.TtTagno)
                .HasConstraintName("FK_TAG_TAGDEF_TAG_TAGDEF_TRANSLATION");
        });

        modelBuilder.Entity<Tagsfoundinimport>(entity =>
        {
            entity.ToTable("TAGSFOUNDINIMPORT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Marctag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MARCTAG");
            entity.Property(e => e.Subfield)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SUBFIELD");
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

        modelBuilder.Entity<TempFilelist>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tempFilelist");

            entity.Property(e => e.Screenname)
                .HasMaxLength(100)
                .HasColumnName("screenname");
        });

        modelBuilder.Entity<VisitorType>(entity =>
        {
            entity.HasKey(e => e.VisitorTypesid).HasName("PK_dbo.VISITOR_TYPES");

            entity.ToTable("VISITOR_TYPES");

            entity.Property(e => e.VisitorTypesid).HasColumnName("VISITOR_TYPESID");
            entity.Property(e => e.Description).HasColumnName("DESCRIPTION");
        });

        modelBuilder.Entity<Ward>(entity =>
        {
            entity.HasKey(e => e.WardCode);

            entity.ToTable("WARD");

            entity.Property(e => e.WardCode)
                .HasMaxLength(3)
                .HasColumnName("WARD_CODE");
            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");
            entity.Property(e => e.WardName)
                .HasMaxLength(75)
                .HasColumnName("WARD_NAME");
        });

        modelBuilder.Entity<WardOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WARD_OLD");

            entity.Property(e => e.WardCode)
                .HasMaxLength(3)
                .HasColumnName("WARD_CODE");
            entity.Property(e => e.WardName)
                .HasMaxLength(75)
                .HasColumnName("WARD_NAME");
        });

        modelBuilder.Entity<WardTranslation>(entity =>
        {
            entity.HasKey(e => new { e.WardCode, e.Lcid });

            entity.ToTable("WARD_TRANSLATION");

            entity.Property(e => e.WardCode)
                .HasMaxLength(3)
                .HasColumnName("WARD_CODE");
            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.WardName)
                .HasMaxLength(75)
                .HasColumnName("WARD_NAME");

            entity.HasOne(d => d.WardCodeNavigation).WithMany(p => p.WardTranslations)
                .HasForeignKey(d => d.WardCode)
                .HasConstraintName("FK_WARD_WARD_TRANSLATION");
        });

        modelBuilder.Entity<WebApp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WEB_APPS");

            entity.Property(e => e.WebAApp)
                .HasMaxLength(3)
                .HasColumnName("WEB_A_APP");
            entity.Property(e => e.WebAAppDesc)
                .HasMaxLength(75)
                .HasColumnName("WEB_A_APP_DESC");
            entity.Property(e => e.WebAHttp)
                .HasMaxLength(75)
                .HasColumnName("WEB_A_HTTP");
            entity.Property(e => e.WebAScrcount).HasColumnName("WEB_A_SCRCOUNT");
        });

        modelBuilder.Entity<WebAppMsg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WEB_APP_MSG");

            entity.Property(e => e.WamApp)
                .HasMaxLength(3)
                .HasColumnName("WAM_APP");
            entity.Property(e => e.WamDesc)
                .HasMaxLength(254)
                .HasColumnName("WAM_DESC");
            entity.Property(e => e.WamMsgNo).HasColumnName("WAM_MSG_NO");
            entity.Property(e => e.WamScreenNo).HasColumnName("WAM_SCREEN_NO");
            entity.Property(e => e.WamText)
                .HasColumnType("ntext")
                .HasColumnName("WAM_TEXT");
            entity.Property(e => e.WamUser)
                .HasMaxLength(25)
                .HasColumnName("WAM_USER");
        });

        modelBuilder.Entity<WebAppScreen>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WEB_APP_SCREENS");

            entity.HasIndex(e => new { e.WebAsApp, e.WebAsScrNo, e.WebAsUser }, "WEB_AS_SCREENX");

            entity.Property(e => e.WebAsApp)
                .HasMaxLength(3)
                .HasColumnName("WEB_AS_APP");
            entity.Property(e => e.WebAsHttp)
                .HasMaxLength(75)
                .HasColumnName("WEB_AS_HTTP");
            entity.Property(e => e.WebAsNwindow)
                .HasMaxLength(1)
                .HasColumnName("WEB_AS_NWINDOW");
            entity.Property(e => e.WebAsS1color)
                .HasMaxLength(10)
                .HasColumnName("WEB_AS_S1COLOR");
            entity.Property(e => e.WebAsS2color)
                .HasMaxLength(10)
                .HasColumnName("WEB_AS_S2COLOR");
            entity.Property(e => e.WebAsScrDesc)
                .HasMaxLength(75)
                .HasColumnName("WEB_AS_SCR_DESC");
            entity.Property(e => e.WebAsScrFile)
                .HasMaxLength(75)
                .HasColumnName("WEB_AS_SCR_FILE");
            entity.Property(e => e.WebAsScrNo).HasColumnName("WEB_AS_SCR_NO");
            entity.Property(e => e.WebAsScrbars)
                .HasMaxLength(3)
                .HasColumnName("WEB_AS_SCRBARS");
            entity.Property(e => e.WebAsScrdir)
                .HasMaxLength(3)
                .HasColumnName("WEB_AS_SCRDIR");
            entity.Property(e => e.WebAsScrheight).HasColumnName("WEB_AS_SCRHEIGHT");
            entity.Property(e => e.WebAsScrleft).HasColumnName("WEB_AS_SCRLEFT");
            entity.Property(e => e.WebAsScrloc)
                .HasMaxLength(3)
                .HasColumnName("WEB_AS_SCRLOC");
            entity.Property(e => e.WebAsScrmax)
                .HasMaxLength(3)
                .HasColumnName("WEB_AS_SCRMAX");
            entity.Property(e => e.WebAsScrmenu)
                .HasMaxLength(3)
                .HasColumnName("WEB_AS_SCRMENU");
            entity.Property(e => e.WebAsScrresize)
                .HasMaxLength(3)
                .HasColumnName("WEB_AS_SCRRESIZE");
            entity.Property(e => e.WebAsScrtbar)
                .HasMaxLength(3)
                .HasColumnName("WEB_AS_SCRTBAR");
            entity.Property(e => e.WebAsScrtop).HasColumnName("WEB_AS_SCRTOP");
            entity.Property(e => e.WebAsScrwidth).HasColumnName("WEB_AS_SCRWIDTH");
            entity.Property(e => e.WebAsUser)
                .HasMaxLength(25)
                .HasColumnName("WEB_AS_USER");
        });

        modelBuilder.Entity<WebButtonAllow>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WEB_BUTTON_ALLOW");

            entity.Property(e => e.WbaAllowUse)
                .HasMaxLength(1)
                .HasColumnName("WBA_ALLOW_USE");
            entity.Property(e => e.WbaApp)
                .HasMaxLength(3)
                .HasColumnName("WBA_APP");
            entity.Property(e => e.WbaButtonNo).HasColumnName("WBA_BUTTON_NO");
            entity.Property(e => e.WbaScreenNumber).HasColumnName("WBA_SCREEN_NUMBER");
            entity.Property(e => e.WbaUserName)
                .HasMaxLength(25)
                .HasColumnName("WBA_USER_NAME");
        });

        modelBuilder.Entity<WebButtonProgram>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WEB_BUTTON_PROGRAM");

            entity.Property(e => e.WbpApp)
                .HasMaxLength(3)
                .HasColumnName("WBP_APP");
            entity.Property(e => e.WbpButtonNo).HasColumnName("WBP_BUTTON_NO");
            entity.Property(e => e.WbpProgText)
                .HasMaxLength(32)
                .HasColumnName("WBP_PROG_TEXT");
            entity.Property(e => e.WbpScreenNumber).HasColumnName("WBP_SCREEN_NUMBER");
        });

        modelBuilder.Entity<WebButtonUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WEB_BUTTON_USER");

            entity.Property(e => e.WbuApp)
                .HasMaxLength(3)
                .HasColumnName("WBU_APP");
            entity.Property(e => e.WbuButtonNo).HasColumnName("WBU_BUTTON_NO");
            entity.Property(e => e.WbuScreenNumber).HasColumnName("WBU_SCREEN_NUMBER");
            entity.Property(e => e.WbuUserName)
                .HasMaxLength(25)
                .HasColumnName("WBU_USER_NAME");
            entity.Property(e => e.WbuUserText)
                .HasMaxLength(32)
                .HasColumnName("WBU_USER_TEXT");
        });

        modelBuilder.Entity<WebMenu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WEB_MENUS");

            entity.Property(e => e.WmApp)
                .HasMaxLength(3)
                .HasColumnName("WM_APP");
            entity.Property(e => e.WmProgMenu)
                .HasMaxLength(32)
                .HasColumnName("WM_PROG_MENU");
            entity.Property(e => e.WmSeq).HasColumnName("WM_SEQ");
        });

        modelBuilder.Entity<WebMenuPermit>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WEB_MENU_PERMITS");

            entity.Property(e => e.WmpAllowUse)
                .HasMaxLength(1)
                .HasColumnName("WMP_ALLOW_USE");
            entity.Property(e => e.WmpApp)
                .HasMaxLength(3)
                .HasColumnName("WMP_APP");
            entity.Property(e => e.WmpProgMenu)
                .HasMaxLength(32)
                .HasColumnName("WMP_PROG_MENU");
            entity.Property(e => e.WmpScreenNumber).HasColumnName("WMP_SCREEN_NUMBER");
            entity.Property(e => e.WmpUserName)
                .HasMaxLength(25)
                .HasColumnName("WMP_USER_NAME");
        });

        modelBuilder.Entity<WebTask>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WEB_TASK");

            entity.Property(e => e.TaskDescription)
                .HasMaxLength(100)
                .HasColumnName("TASK_DESCRIPTION");
            entity.Property(e => e.TaskFinishDate)
                .HasColumnType("datetime")
                .HasColumnName("TASK_FINISH_DATE");
            entity.Property(e => e.TaskItemsProcessed).HasColumnName("TASK_ITEMS_PROCESSED");
            entity.Property(e => e.TaskMaxItems).HasColumnName("TASK_MAX_ITEMS");
            entity.Property(e => e.TaskNextId).HasColumnName("TASK_NEXT_ID");
            entity.Property(e => e.TaskNo).HasColumnName("TASK_NO");
            entity.Property(e => e.TaskParams)
                .HasColumnType("ntext")
                .HasColumnName("TASK_PARAMS");
            entity.Property(e => e.TaskSavedFileNo).HasColumnName("TASK_SAVED_FILE_NO");
            entity.Property(e => e.TaskSerial).HasColumnName("TASK_SERIAL");
            entity.Property(e => e.TaskStartDate)
                .HasColumnType("datetime")
                .HasColumnName("TASK_START_DATE");
            entity.Property(e => e.TaskStatus)
                .HasMaxLength(1)
                .HasColumnName("TASK_STATUS");
            entity.Property(e => e.TaskType)
                .HasMaxLength(50)
                .HasColumnName("TASK_TYPE");
        });

        modelBuilder.Entity<WebTaskSystab>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WEB_TASK_SYSTAB");

            entity.Property(e => e.TaskNo).HasColumnName("TASK_NO");
        });

        modelBuilder.Entity<WebUserMenu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WEB_USER_MENUS");

            entity.Property(e => e.WumApp)
                .HasMaxLength(3)
                .HasColumnName("WUM_APP");
            entity.Property(e => e.WumProgMenu)
                .HasMaxLength(32)
                .HasColumnName("WUM_PROG_MENU");
            entity.Property(e => e.WumScreenNumber).HasColumnName("WUM_SCREEN_NUMBER");
            entity.Property(e => e.WumUserMenu)
                .HasMaxLength(32)
                .HasColumnName("WUM_USER_MENU");
            entity.Property(e => e.WumUserName)
                .HasMaxLength(25)
                .HasColumnName("WUM_USER_NAME");
        });

        modelBuilder.Entity<Z3950Attr>(entity =>
        {
            entity.HasKey(e => e.ZaUniqueNo);

            entity.ToTable("Z3950_ATTR");

            entity.HasIndex(e => e.ZaSequence, "IX_Z3950_ATTR").HasFillFactor(70);

            entity.Property(e => e.ZaUniqueNo)
                .ValueGeneratedNever()
                .HasColumnName("ZA_UNIQUE_NO");
            entity.Property(e => e.ZaAttr1).HasColumnName("ZA_ATTR1");
            entity.Property(e => e.ZaAttr2).HasColumnName("ZA_ATTR2");
            entity.Property(e => e.ZaAttr3).HasColumnName("ZA_ATTR3");
            entity.Property(e => e.ZaAttr4).HasColumnName("ZA_ATTR4");
            entity.Property(e => e.ZaAttr5).HasColumnName("ZA_ATTR5");
            entity.Property(e => e.ZaAttr6).HasColumnName("ZA_ATTR6");
            entity.Property(e => e.ZaDescription)
                .HasMaxLength(100)
                .HasColumnName("ZA_DESCRIPTION");
            entity.Property(e => e.ZaSequence).HasColumnName("ZA_SEQUENCE");
            entity.Property(e => e.ZaType)
                .HasMaxLength(20)
                .HasColumnName("ZA_TYPE");
        });

        modelBuilder.Entity<Z3950AttrLink>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Z3950_ATTR_LINK");

            entity.Property(e => e.ZalAttr1).HasColumnName("ZAL_ATTR1");
            entity.Property(e => e.ZalAttr2).HasColumnName("ZAL_ATTR2");
            entity.Property(e => e.ZalAttr3).HasColumnName("ZAL_ATTR3");
            entity.Property(e => e.ZalAttr4).HasColumnName("ZAL_ATTR4");
            entity.Property(e => e.ZalAttr5).HasColumnName("ZAL_ATTR5");
            entity.Property(e => e.ZalAttr6).HasColumnName("ZAL_ATTR6");
            entity.Property(e => e.ZalAttrNo).HasColumnName("ZAL_ATTR_NO");
            entity.Property(e => e.ZalServerNo).HasColumnName("ZAL_SERVER_NO");
        });

        modelBuilder.Entity<Z3950AttrOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Z3950_ATTR_OLD");

            entity.Property(e => e.ZaAttr1).HasColumnName("ZA_ATTR1");
            entity.Property(e => e.ZaAttr2).HasColumnName("ZA_ATTR2");
            entity.Property(e => e.ZaAttr3).HasColumnName("ZA_ATTR3");
            entity.Property(e => e.ZaAttr4).HasColumnName("ZA_ATTR4");
            entity.Property(e => e.ZaAttr5).HasColumnName("ZA_ATTR5");
            entity.Property(e => e.ZaAttr6).HasColumnName("ZA_ATTR6");
            entity.Property(e => e.ZaDescription)
                .HasMaxLength(100)
                .HasColumnName("ZA_DESCRIPTION");
            entity.Property(e => e.ZaSequence).HasColumnName("ZA_SEQUENCE");
            entity.Property(e => e.ZaType)
                .HasMaxLength(20)
                .HasColumnName("ZA_TYPE");
            entity.Property(e => e.ZaUniqueNo).HasColumnName("ZA_UNIQUE_NO");
        });

        modelBuilder.Entity<Z3950AttrTranslation>(entity =>
        {
            entity.HasKey(e => new { e.Lcid, e.ZaUniqueNo });

            entity.ToTable("Z3950_ATTR_TRANSLATION");

            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.ZaUniqueNo).HasColumnName("ZA_UNIQUE_NO");
            entity.Property(e => e.ZaDescription)
                .HasMaxLength(100)
                .HasColumnName("ZA_DESCRIPTION");

            entity.HasOne(d => d.ZaUniqueNoNavigation).WithMany(p => p.Z3950AttrTranslations)
                .HasForeignKey(d => d.ZaUniqueNo)
                .HasConstraintName("FK_Z3950_ATTR_Z3950_ATTR_TRANSLATION");
        });

        modelBuilder.Entity<Z3950Group>(entity =>
        {
            entity.HasKey(e => e.ZgUniqueNo);

            entity.ToTable("Z3950_GROUP");

            entity.HasIndex(e => e.ZgSequence, "IX_Z3950_GROUP").HasFillFactor(70);

            entity.Property(e => e.ZgUniqueNo)
                .ValueGeneratedNever()
                .HasColumnName("ZG_UNIQUE_NO");
            entity.Property(e => e.ZgDescription)
                .HasMaxLength(100)
                .HasColumnName("ZG_DESCRIPTION");
            entity.Property(e => e.ZgSequence).HasColumnName("ZG_SEQUENCE");
            entity.Property(e => e.ZgType)
                .HasMaxLength(1)
                .HasColumnName("ZG_TYPE");
        });

        modelBuilder.Entity<Z3950GroupOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Z3950_GROUP_OLD");

            entity.Property(e => e.ZgDescription)
                .HasMaxLength(100)
                .HasColumnName("ZG_DESCRIPTION");
            entity.Property(e => e.ZgSequence).HasColumnName("ZG_SEQUENCE");
            entity.Property(e => e.ZgType)
                .HasMaxLength(1)
                .HasColumnName("ZG_TYPE");
            entity.Property(e => e.ZgUniqueNo).HasColumnName("ZG_UNIQUE_NO");
        });

        modelBuilder.Entity<Z3950GroupTranslation>(entity =>
        {
            entity.HasKey(e => new { e.Lcid, e.ZgUniqueNo });

            entity.ToTable("Z3950_GROUP_TRANSLATION");

            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.ZgUniqueNo).HasColumnName("ZG_UNIQUE_NO");
            entity.Property(e => e.ZgDescription)
                .HasMaxLength(100)
                .HasColumnName("ZG_DESCRIPTION");

            entity.HasOne(d => d.ZgUniqueNoNavigation).WithMany(p => p.Z3950GroupTranslations)
                .HasForeignKey(d => d.ZgUniqueNo)
                .HasConstraintName("FK_Z3950_GROUP_Z3950_GROUP_TRANSLATION");
        });

        modelBuilder.Entity<Z3950Option>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Z3950_OPTIONS");

            entity.Property(e => e.ZoCode)
                .HasMaxLength(32)
                .HasColumnName("ZO_CODE");
            entity.Property(e => e.ZoValue)
                .HasMaxLength(100)
                .HasColumnName("ZO_VALUE");
        });

        modelBuilder.Entity<Z3950Server>(entity =>
        {
            entity.HasKey(e => e.ZsUniqueNo);

            entity.ToTable("Z3950_SERVER");

            entity.HasIndex(e => e.ZsSequence, "IX_Z3950_SERVER").HasFillFactor(70);

            entity.Property(e => e.ZsUniqueNo)
                .ValueGeneratedNever()
                .HasColumnName("ZS_UNIQUE_NO");
            entity.Property(e => e.ZsAllowHoldings)
                .HasMaxLength(1)
                .HasColumnName("ZS_ALLOW_HOLDINGS");
            entity.Property(e => e.ZsAllowImport)
                .HasMaxLength(1)
                .HasColumnName("ZS_ALLOW_IMPORT");
            entity.Property(e => e.ZsAllowScan)
                .HasMaxLength(1)
                .HasColumnName("ZS_ALLOW_SCAN");
            entity.Property(e => e.ZsDatabase)
                .HasMaxLength(50)
                .HasColumnName("ZS_DATABASE");
            entity.Property(e => e.ZsDescription)
                .HasMaxLength(100)
                .HasColumnName("ZS_DESCRIPTION");
            entity.Property(e => e.ZsDisplay)
                .HasMaxLength(1)
                .HasColumnName("ZS_DISPLAY");
            entity.Property(e => e.ZsHost)
                .HasMaxLength(250)
                .HasColumnName("ZS_HOST");
            entity.Property(e => e.ZsInitialFetch).HasColumnName("ZS_INITIAL_FETCH");
            entity.Property(e => e.ZsMaximumFetch).HasColumnName("ZS_MAXIMUM_FETCH");
            entity.Property(e => e.ZsMaximumSize).HasColumnName("ZS_MAXIMUM_SIZE");
            entity.Property(e => e.ZsPassword)
                .HasMaxLength(50)
                .HasColumnName("ZS_PASSWORD");
            entity.Property(e => e.ZsPort).HasColumnName("ZS_PORT");
            entity.Property(e => e.ZsPreferredSize).HasColumnName("ZS_PREFERRED_SIZE");
            entity.Property(e => e.ZsSequence).HasColumnName("ZS_SEQUENCE");
            entity.Property(e => e.ZsTimeout).HasColumnName("ZS_TIMEOUT");
            entity.Property(e => e.ZsType)
                .HasMaxLength(50)
                .HasColumnName("ZS_TYPE");
            entity.Property(e => e.ZsUserId)
                .HasMaxLength(50)
                .HasColumnName("ZS_USER_ID");
        });

        modelBuilder.Entity<Z3950ServerLink>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Z3950_SERVER_LINK");

            entity.Property(e => e.ZslGroupNo).HasColumnName("ZSL_GROUP_NO");
            entity.Property(e => e.ZslServerNo).HasColumnName("ZSL_SERVER_NO");
        });

        modelBuilder.Entity<Z3950ServerOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Z3950_SERVER_OLD");

            entity.Property(e => e.ZsAllowHoldings)
                .HasMaxLength(1)
                .HasColumnName("ZS_ALLOW_HOLDINGS");
            entity.Property(e => e.ZsAllowImport)
                .HasMaxLength(1)
                .HasColumnName("ZS_ALLOW_IMPORT");
            entity.Property(e => e.ZsAllowScan)
                .HasMaxLength(1)
                .HasColumnName("ZS_ALLOW_SCAN");
            entity.Property(e => e.ZsDatabase)
                .HasMaxLength(50)
                .HasColumnName("ZS_DATABASE");
            entity.Property(e => e.ZsDescription)
                .HasMaxLength(100)
                .HasColumnName("ZS_DESCRIPTION");
            entity.Property(e => e.ZsDisplay)
                .HasMaxLength(1)
                .HasColumnName("ZS_DISPLAY");
            entity.Property(e => e.ZsHost)
                .HasMaxLength(250)
                .HasColumnName("ZS_HOST");
            entity.Property(e => e.ZsInitialFetch).HasColumnName("ZS_INITIAL_FETCH");
            entity.Property(e => e.ZsMaximumFetch).HasColumnName("ZS_MAXIMUM_FETCH");
            entity.Property(e => e.ZsMaximumSize).HasColumnName("ZS_MAXIMUM_SIZE");
            entity.Property(e => e.ZsPassword)
                .HasMaxLength(50)
                .HasColumnName("ZS_PASSWORD");
            entity.Property(e => e.ZsPort).HasColumnName("ZS_PORT");
            entity.Property(e => e.ZsPreferredSize).HasColumnName("ZS_PREFERRED_SIZE");
            entity.Property(e => e.ZsSequence).HasColumnName("ZS_SEQUENCE");
            entity.Property(e => e.ZsTimeout).HasColumnName("ZS_TIMEOUT");
            entity.Property(e => e.ZsType)
                .HasMaxLength(50)
                .HasColumnName("ZS_TYPE");
            entity.Property(e => e.ZsUniqueNo).HasColumnName("ZS_UNIQUE_NO");
            entity.Property(e => e.ZsUserId)
                .HasMaxLength(50)
                .HasColumnName("ZS_USER_ID");
        });

        modelBuilder.Entity<Z3950ServerTranslation>(entity =>
        {
            entity.HasKey(e => new { e.Lcid, e.ZsUniqueNo });

            entity.ToTable("Z3950_SERVER_TRANSLATION");

            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.ZsUniqueNo).HasColumnName("ZS_UNIQUE_NO");
            entity.Property(e => e.ZsDescription)
                .HasMaxLength(100)
                .HasColumnName("ZS_DESCRIPTION");

            entity.HasOne(d => d.ZsUniqueNoNavigation).WithMany(p => p.Z3950ServerTranslations)
                .HasForeignKey(d => d.ZsUniqueNo)
                .HasConstraintName("FK_Z3950_SERVER_Z3950_SERVER_TRANSLATION");
        });

        modelBuilder.Entity<Z3950Systab>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Z3950_SYSTAB");

            entity.Property(e => e.UniqueNo).HasColumnName("UNIQUE_NO");
        });

        modelBuilder.Entity<ZopacOperAttr>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ZOPAC_OPER_ATTR");

            entity.Property(e => e.ZoaAttrNo).HasColumnName("ZOA_ATTR_NO");
            entity.Property(e => e.ZoaOperatorNo).HasColumnName("ZOA_OPERATOR_NO");
            entity.Property(e => e.ZoaSequence).HasColumnName("ZOA_SEQUENCE");
        });

        modelBuilder.Entity<ZopacOperServer>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ZOPAC_OPER_SERVER");

            entity.Property(e => e.ZosOperatorNo).HasColumnName("ZOS_OPERATOR_NO");
            entity.Property(e => e.ZosSequence).HasColumnName("ZOS_SEQUENCE");
            entity.Property(e => e.ZosServerNo).HasColumnName("ZOS_SERVER_NO");
        });

        modelBuilder.Entity<ZopacOperator>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ZOPAC_OPERATOR");

            entity.Property(e => e.ZoAuthlistSize).HasColumnName("ZO_AUTHLIST_SIZE");
            entity.Property(e => e.ZoDescription)
                .HasMaxLength(100)
                .HasColumnName("ZO_DESCRIPTION");
            entity.Property(e => e.ZoLoginId)
                .HasMaxLength(25)
                .HasColumnName("ZO_LOGIN_ID");
            entity.Property(e => e.ZoPassword)
                .HasMaxLength(25)
                .HasColumnName("ZO_PASSWORD");
            entity.Property(e => e.ZoSearchSize).HasColumnName("ZO_SEARCH_SIZE");
            entity.Property(e => e.ZoStyle).HasColumnName("ZO_STYLE");
            entity.Property(e => e.ZoUniqueNo).HasColumnName("ZO_UNIQUE_NO");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

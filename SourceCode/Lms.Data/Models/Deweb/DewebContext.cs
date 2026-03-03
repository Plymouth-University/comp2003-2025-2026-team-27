using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Lms.Data.Models.Deweb;

public partial class DewebContext : DbContext
{
    public DewebContext()
    {
    }

    public DewebContext(DbContextOptions<DewebContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CiWebAppDatum> CiWebAppData { get; set; }

    public virtual DbSet<CiWebAppLong> CiWebAppLongs { get; set; }

    public virtual DbSet<CiWebAppSession> CiWebAppSessions { get; set; }

    public virtual DbSet<CiWebAppSystab> CiWebAppSystabs { get; set; }

    public virtual DbSet<CiWebDatum> CiWebData { get; set; }

    public virtual DbSet<CiWebSystab> CiWebSystabs { get; set; }

    public virtual DbSet<ConferenceCareEmail> ConferenceCareEmails { get; set; }

    public virtual DbSet<FixedLayoutBibRecord> FixedLayoutBibRecords { get; set; }

    public virtual DbSet<MostPopularCatalogue> MostPopularCatalogues { get; set; }

    public virtual DbSet<RepSpineLabel> RepSpineLabels { get; set; }

    public virtual DbSet<StkItemReport> StkItemReports { get; set; }

    public virtual DbSet<VAccidentForm> VAccidentForms { get; set; }

    public virtual DbSet<VAccount> VAccounts { get; set; }

    public virtual DbSet<VAccountHeader> VAccountHeaders { get; set; }

    public virtual DbSet<VAccountTran> VAccountTrans { get; set; }

    public virtual DbSet<VAdABorPicture> VAdABorPictures { get; set; }

    public virtual DbSet<VAdAuthority> VAdAuthorities { get; set; }

    public virtual DbSet<VAdBorAddr> VAdBorAddrs { get; set; }

    public virtual DbSet<VAdBorHistory> VAdBorHistories { get; set; }

    public virtual DbSet<VAdBorLogin> VAdBorLogins { get; set; }

    public virtual DbSet<VAdBorrower> VAdBorrowers { get; set; }

    public virtual DbSet<VAdCatMarcLong> VAdCatMarcLongs { get; set; }

    public virtual DbSet<VAdCatalogue> VAdCatalogues { get; set; }

    public virtual DbSet<VAdOperatorLogin> VAdOperatorLogins { get; set; }

    public virtual DbSet<VAdStkHistory> VAdStkHistories { get; set; }

    public virtual DbSet<VAdStkItem> VAdStkItems { get; set; }

    public virtual DbSet<VArea> VAreas { get; set; }

    public virtual DbSet<VAuthSeeAlso> VAuthSeeAlsos { get; set; }

    public virtual DbSet<VAuthority> VAuthorities { get; set; }

    public virtual DbSet<VBorAddr> VBorAddrs { get; set; }

    public virtual DbSet<VBorClass> VBorClasses { get; set; }

    public virtual DbSet<VBorCoursePeriod> VBorCoursePeriods { get; set; }

    public virtual DbSet<VBorGroup> VBorGroups { get; set; }

    public virtual DbSet<VBorHistory> VBorHistories { get; set; }

    public virtual DbSet<VBorHistoryNote> VBorHistoryNotes { get; set; }

    public virtual DbSet<VBorMemo> VBorMemos { get; set; }

    public virtual DbSet<VBorPayment> VBorPayments { get; set; }

    public virtual DbSet<VBorPaymentFinTran> VBorPaymentFinTrans { get; set; }

    public virtual DbSet<VBorSubject> VBorSubjects { get; set; }

    public virtual DbSet<VBorSurvey> VBorSurveys { get; set; }

    public virtual DbSet<VBorType> VBorTypes { get; set; }

    public virtual DbSet<VBorrower> VBorrowers { get; set; }

    public virtual DbSet<VBorrowerAlt> VBorrowerAlts { get; set; }

    public virtual DbSet<VBorrowerInterestMatch> VBorrowerInterestMatches { get; set; }

    public virtual DbSet<VBorrowerLoc> VBorrowerLocs { get; set; }

    public virtual DbSet<VBorrowerSpecial> VBorrowerSpecials { get; set; }

    public virtual DbSet<VBudgetTotal> VBudgetTotals { get; set; }

    public virtual DbSet<VCashTill> VCashTills { get; set; }

    public virtual DbSet<VCatDynamicTemplateConfig> VCatDynamicTemplateConfigs { get; set; }

    public virtual DbSet<VCatSf> VCatSfs { get; set; }

    public virtual DbSet<VCatTag> VCatTags { get; set; }

    public virtual DbSet<VCatalogue> VCatalogues { get; set; }

    public virtual DbSet<VCatalogueDatum> VCatalogueData { get; set; }

    public virtual DbSet<VCatalogueRef> VCatalogueRefs { get; set; }

    public virtual DbSet<VCir1> VCir1s { get; set; }

    public virtual DbSet<VClassification> VClassifications { get; set; }

    public virtual DbSet<VEnquiry> VEnquiries { get; set; }

    public virtual DbSet<VFaultReport> VFaultReports { get; set; }

    public virtual DbSet<VFaultReportDetail> VFaultReportDetails { get; set; }

    public virtual DbSet<VFileCatDatum> VFileCatData { get; set; }

    public virtual DbSet<VFileCatName> VFileCatNames { get; set; }

    public virtual DbSet<VFileSetDatum> VFileSetData { get; set; }

    public virtual DbSet<VFileSetName> VFileSetNames { get; set; }

    public virtual DbSet<VFinTran> VFinTrans { get; set; }

    public virtual DbSet<VIllLibrary> VIllLibraries { get; set; }

    public virtual DbSet<VInvoiceComponent> VInvoiceComponents { get; set; }

    public virtual DbSet<VInvoiceHeader> VInvoiceHeaders { get; set; }

    public virtual DbSet<VLibLocation> VLibLocations { get; set; }

    public virtual DbSet<VLibMemo> VLibMemos { get; set; }

    public virtual DbSet<VMeeting> VMeetings { get; set; }

    public virtual DbSet<VMeetingDelegate> VMeetingDelegates { get; set; }

    public virtual DbSet<VMonthlyStat> VMonthlyStats { get; set; }

    public virtual DbSet<VMypc> VMypcs { get; set; }

    public virtual DbSet<VNearMissForm> VNearMissForms { get; set; }

    public virtual DbSet<VOpacusercomment> VOpacusercomments { get; set; }

    public virtual DbSet<VOpacuserreply> VOpacuserreplies { get; set; }

    public virtual DbSet<VOperator> VOperators { get; set; }

    public virtual DbSet<VOrdComponent> VOrdComponents { get; set; }

    public virtual DbSet<VOrdCondition> VOrdConditions { get; set; }

    public virtual DbSet<VOrdHeader> VOrdHeaders { get; set; }

    public virtual DbSet<VOrdStkItem> VOrdStkItems { get; set; }

    public virtual DbSet<VPaymentReceipt> VPaymentReceipts { get; set; }

    public virtual DbSet<VPerCopy> VPerCopies { get; set; }

    public virtual DbSet<VPerIssue> VPerIssues { get; set; }

    public virtual DbSet<VPerSub> VPerSubs { get; set; }

    public virtual DbSet<VPerSupplier> VPerSuppliers { get; set; }

    public virtual DbSet<VPeriodical> VPeriodicals { get; set; }

    public virtual DbSet<VPopularTitlesByClass> VPopularTitlesByClasses { get; set; }

    public virtual DbSet<VPopularTitlesByGroup> VPopularTitlesByGroups { get; set; }

    public virtual DbSet<VReport> VReports { get; set; }

    public virtual DbSet<VReportAction> VReportActions { get; set; }

    public virtual DbSet<VReportSummary> VReportSummaries { get; set; }

    public virtual DbSet<VReservation> VReservations { get; set; }

    public virtual DbSet<VReservationsCompleted> VReservationsCompleteds { get; set; }

    public virtual DbSet<VRiskAssessment> VRiskAssessments { get; set; }

    public virtual DbSet<VRiskAssessmentDetail> VRiskAssessmentDetails { get; set; }

    public virtual DbSet<VSeeAlsoAuth> VSeeAlsoAuths { get; set; }

    public virtual DbSet<VStat> VStats { get; set; }

    public virtual DbSet<VStatsCode> VStatsCodes { get; set; }

    public virtual DbSet<VStkBookingEvent> VStkBookingEvents { get; set; }

    public virtual DbSet<VStkCode> VStkCodes { get; set; }

    public virtual DbSet<VStkDefault> VStkDefaults { get; set; }

    public virtual DbSet<VStkForm> VStkForms { get; set; }

    public virtual DbSet<VStkHistory> VStkHistories { get; set; }

    public virtual DbSet<VStkHistoryReport> VStkHistoryReports { get; set; }

    public virtual DbSet<VStkIll> VStkIlls { get; set; }

    public virtual DbSet<VStkItem> VStkItems { get; set; }

    public virtual DbSet<VStkItem880> VStkItem880s { get; set; }

    public virtual DbSet<VStkItemAtEndOfRotation> VStkItemAtEndOfRotations { get; set; }

    public virtual DbSet<VStkItemCount> VStkItemCounts { get; set; }

    public virtual DbSet<VStkItemMaster> VStkItemMasters { get; set; }

    public virtual DbSet<VStkItemPotentialCharge> VStkItemPotentialCharges { get; set; }

    public virtual DbSet<VStkMemo> VStkMemos { get; set; }

    public virtual DbSet<VStkRotationPlan> VStkRotationPlans { get; set; }

    public virtual DbSet<VStkRotationSequence> VStkRotationSequences { get; set; }

    public virtual DbSet<VStkSubscriber> VStkSubscribers { get; set; }

    public virtual DbSet<VSuburb> VSuburbs { get; set; }

    public virtual DbSet<VSurvey> VSurveys { get; set; }

    public virtual DbSet<VSurveyAnswer> VSurveyAnswers { get; set; }

    public virtual DbSet<VSurveyQuestion> VSurveyQuestions { get; set; }

    public virtual DbSet<VSurveyResponse> VSurveyResponses { get; set; }

    public virtual DbSet<VSurveyRestriction> VSurveyRestrictions { get; set; }

    public virtual DbSet<VSurveyStatus> VSurveyStatuses { get; set; }

    public virtual DbSet<VSurveyType> VSurveyTypes { get; set; }

    public virtual DbSet<VSurveyTypeTranslation> VSurveyTypeTranslations { get; set; }

    public virtual DbSet<VTagTagdef> VTagTagdefs { get; set; }

    public virtual DbSet<VUserClass> VUserClasses { get; set; }

    public virtual DbSet<VUserGroup> VUserGroups { get; set; }

    public virtual DbSet<VVduAssessment> VVduAssessments { get; set; }

    public virtual DbSet<VVduAssessmentForm> VVduAssessmentForms { get; set; }

    public virtual DbSet<VVisited2year> VVisited2years { get; set; }

    public virtual DbSet<VWaiveTran> VWaiveTrans { get; set; }

    public virtual DbSet<VWard> VWards { get; set; }

    public virtual DbSet<View6xxMarcTag> View6xxMarcTags { get; set; }

    public virtual DbSet<WebAppDataLong> WebAppDataLongs { get; set; }

    public virtual DbSet<WebAppDatum> WebAppData { get; set; }

    public virtual DbSet<WebAppSession> WebAppSessions { get; set; }

    public virtual DbSet<WebAppSystab> WebAppSystabs { get; set; }

    public virtual DbSet<WebDatum> WebData { get; set; }

    public virtual DbSet<WebSystab> WebSystabs { get; set; }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CiWebAppDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_WEB_APP_DATA");

            entity.HasIndex(e => new { e.WebDate, e.WebApp }, "CI_WEB_ADATEX");

            entity.HasIndex(e => new { e.WebSerial, e.WebApp, e.WebSet }, "CI_WEB_ASERIALX");

            entity.Property(e => e.WebApp)
                .HasMaxLength(3)
                .HasColumnName("WEB_APP");
            entity.Property(e => e.WebDate)
                .HasColumnType("datetime")
                .HasColumnName("WEB_DATE");
            entity.Property(e => e.WebSerial).HasColumnName("WEB_SERIAL");
            entity.Property(e => e.WebSet)
                .HasMaxLength(12)
                .HasColumnName("WEB_SET");
            entity.Property(e => e.WebString)
                .HasMaxLength(240)
                .HasColumnName("WEB_STRING");
        });

        modelBuilder.Entity<CiWebAppLong>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_WEB_APP_LONG");

            entity.HasIndex(e => e.WebDate, "CI_WEB_ALDATEX");

            entity.HasIndex(e => new { e.WebSerial, e.WebSet }, "CI_WEB_ALSERIALX");

            entity.Property(e => e.WebApp)
                .HasMaxLength(3)
                .HasColumnName("WEB_APP");
            entity.Property(e => e.WebDate)
                .HasColumnType("datetime")
                .HasColumnName("WEB_DATE");
            entity.Property(e => e.WebSerial).HasColumnName("WEB_SERIAL");
            entity.Property(e => e.WebSet)
                .HasMaxLength(12)
                .HasColumnName("WEB_SET");
            entity.Property(e => e.WebString)
                .HasColumnType("ntext")
                .HasColumnName("WEB_STRING");
        });

        modelBuilder.Entity<CiWebAppSession>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_WEB_APP_SESSION");

            entity.Property(e => e.WebApp)
                .HasMaxLength(3)
                .HasColumnName("WEB_APP");
            entity.Property(e => e.WebAppClosed)
                .HasMaxLength(1)
                .HasColumnName("WEB_APP_CLOSED");
            entity.Property(e => e.WebDate)
                .HasColumnType("datetime")
                .HasColumnName("WEB_DATE");
            entity.Property(e => e.WebId)
                .HasMaxLength(110)
                .HasColumnName("WEB_ID");
            entity.Property(e => e.WebReload)
                .HasMaxLength(1)
                .HasColumnName("WEB_RELOAD");
            entity.Property(e => e.WebSession).HasColumnName("WEB_SESSION");
            entity.Property(e => e.WebStartSession)
                .HasColumnType("datetime")
                .HasColumnName("WEB_START_SESSION");
        });

        modelBuilder.Entity<CiWebAppSystab>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_WEB_APP_SYSTAB");

            entity.Property(e => e.WebSerial).HasColumnName("WEB_SERIAL");
        });

        modelBuilder.Entity<CiWebDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_WEB_DATA");

            entity.HasIndex(e => e.WebDate, "CI_WEB_DATEX");

            entity.HasIndex(e => new { e.WebSerial, e.WebSeqStart, e.WebSet }, "CI_WEB_SERIALX");

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

        modelBuilder.Entity<CiWebSystab>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_WEB_SYSTAB");

            entity.Property(e => e.WebSerial).HasColumnName("WEB_SERIAL");
        });

        modelBuilder.Entity<ConferenceCareEmail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CONFERENCE_CARE_EMAILS");

            entity.Property(e => e.ClientNumber).HasColumnName("CLIENT_NUMBER");
            entity.Property(e => e.ContactBirthday).HasColumnName("CONTACT_BIRTHDAY");
            entity.Property(e => e.ContactDept)
                .HasMaxLength(35)
                .HasColumnName("CONTACT_DEPT");
            entity.Property(e => e.ContactFaxNo)
                .HasMaxLength(18)
                .HasColumnName("CONTACT_FAX_NO");
            entity.Property(e => e.ContactGiven)
                .HasMaxLength(35)
                .HasColumnName("CONTACT_GIVEN");
            entity.Property(e => e.ContactName)
                .HasMaxLength(35)
                .HasColumnName("CONTACT_NAME");
            entity.Property(e => e.ContactNameNew)
                .HasMaxLength(35)
                .HasColumnName("CONTACT_NAME_NEW");
            entity.Property(e => e.ContactTelNo)
                .HasMaxLength(18)
                .HasColumnName("CONTACT_TEL_NO");
            entity.Property(e => e.EmailAddr)
                .HasMaxLength(100)
                .HasColumnName("EMAIL_ADDR");
            entity.Property(e => e.InactiveDate).HasColumnName("INACTIVE_DATE");
            entity.Property(e => e.JobTitle)
                .HasMaxLength(50)
                .HasColumnName("JOB_TITLE");
            entity.Property(e => e.SiteNumber).HasColumnName("SITE_NUMBER");
            entity.Property(e => e.XmasCardList).HasColumnName("XMAS_CARD_LIST");
        });

        modelBuilder.Entity<FixedLayoutBibRecord>(entity =>
        {
            entity.HasKey(e => e.RecordOrder).HasName("PK_TABLE1");

            entity.ToTable("FIXED_LAYOUT_BIB_RECORD");

            entity.Property(e => e.RecordOrder).HasColumnName("RECORD_ORDER");
            entity.Property(e => e.Field1)
                .HasMaxLength(250)
                .HasColumnName("FIELD1");
            entity.Property(e => e.Field10)
                .HasMaxLength(250)
                .HasColumnName("FIELD10");
            entity.Property(e => e.Field10a)
                .HasMaxLength(50)
                .HasColumnName("FIELD10A");
            entity.Property(e => e.Field11)
                .HasMaxLength(250)
                .HasColumnName("FIELD11");
            entity.Property(e => e.Field11a)
                .HasMaxLength(50)
                .HasColumnName("FIELD11A");
            entity.Property(e => e.Field12)
                .HasMaxLength(250)
                .HasColumnName("FIELD12");
            entity.Property(e => e.Field12a)
                .HasMaxLength(50)
                .HasColumnName("FIELD12A");
            entity.Property(e => e.Field13)
                .HasMaxLength(250)
                .HasColumnName("FIELD13");
            entity.Property(e => e.Field13a)
                .HasMaxLength(50)
                .HasColumnName("FIELD13A");
            entity.Property(e => e.Field14)
                .HasMaxLength(250)
                .HasColumnName("FIELD14");
            entity.Property(e => e.Field14a)
                .HasMaxLength(50)
                .HasColumnName("FIELD14A");
            entity.Property(e => e.Field15)
                .HasMaxLength(250)
                .HasColumnName("FIELD15");
            entity.Property(e => e.Field15a)
                .HasMaxLength(50)
                .HasColumnName("FIELD15A");
            entity.Property(e => e.Field16)
                .HasMaxLength(250)
                .HasColumnName("FIELD16");
            entity.Property(e => e.Field16a)
                .HasMaxLength(50)
                .HasColumnName("FIELD16A");
            entity.Property(e => e.Field17)
                .HasMaxLength(250)
                .HasColumnName("FIELD17");
            entity.Property(e => e.Field17a)
                .HasMaxLength(50)
                .HasColumnName("FIELD17A");
            entity.Property(e => e.Field18)
                .HasMaxLength(250)
                .HasColumnName("FIELD18");
            entity.Property(e => e.Field18a)
                .HasMaxLength(50)
                .HasColumnName("FIELD18A");
            entity.Property(e => e.Field19)
                .HasMaxLength(250)
                .HasColumnName("FIELD19");
            entity.Property(e => e.Field19a)
                .HasMaxLength(50)
                .HasColumnName("FIELD19A");
            entity.Property(e => e.Field1a)
                .HasMaxLength(50)
                .HasColumnName("FIELD1A");
            entity.Property(e => e.Field2)
                .HasMaxLength(250)
                .HasColumnName("FIELD2");
            entity.Property(e => e.Field20)
                .HasMaxLength(250)
                .HasColumnName("FIELD20");
            entity.Property(e => e.Field20a)
                .HasMaxLength(50)
                .HasColumnName("FIELD20A");
            entity.Property(e => e.Field21)
                .HasMaxLength(250)
                .HasColumnName("FIELD21");
            entity.Property(e => e.Field21a)
                .HasMaxLength(50)
                .HasColumnName("FIELD21A");
            entity.Property(e => e.Field22)
                .HasMaxLength(250)
                .HasColumnName("FIELD22");
            entity.Property(e => e.Field22a)
                .HasMaxLength(50)
                .HasColumnName("FIELD22A");
            entity.Property(e => e.Field23)
                .HasMaxLength(250)
                .HasColumnName("FIELD23");
            entity.Property(e => e.Field23a)
                .HasMaxLength(50)
                .HasColumnName("FIELD23A");
            entity.Property(e => e.Field24)
                .HasMaxLength(250)
                .HasColumnName("FIELD24");
            entity.Property(e => e.Field24a)
                .HasMaxLength(50)
                .HasColumnName("FIELD24A");
            entity.Property(e => e.Field25)
                .HasMaxLength(250)
                .HasColumnName("FIELD25");
            entity.Property(e => e.Field25a)
                .HasMaxLength(50)
                .HasColumnName("FIELD25A");
            entity.Property(e => e.Field2a)
                .HasMaxLength(50)
                .HasColumnName("FIELD2A");
            entity.Property(e => e.Field3)
                .HasMaxLength(250)
                .HasColumnName("FIELD3");
            entity.Property(e => e.Field3a)
                .HasMaxLength(50)
                .HasColumnName("FIELD3A");
            entity.Property(e => e.Field4)
                .HasMaxLength(250)
                .HasColumnName("FIELD4");
            entity.Property(e => e.Field4a)
                .HasMaxLength(50)
                .HasColumnName("FIELD4A");
            entity.Property(e => e.Field5)
                .HasMaxLength(250)
                .HasColumnName("FIELD5");
            entity.Property(e => e.Field5a)
                .HasMaxLength(50)
                .HasColumnName("FIELD5A");
            entity.Property(e => e.Field6)
                .HasMaxLength(250)
                .HasColumnName("FIELD6");
            entity.Property(e => e.Field6a)
                .HasMaxLength(50)
                .HasColumnName("FIELD6A");
            entity.Property(e => e.Field7)
                .HasMaxLength(250)
                .HasColumnName("FIELD7");
            entity.Property(e => e.Field7a)
                .HasMaxLength(50)
                .HasColumnName("FIELD7A");
            entity.Property(e => e.Field8)
                .HasMaxLength(250)
                .HasColumnName("FIELD8");
            entity.Property(e => e.Field8a)
                .HasMaxLength(50)
                .HasColumnName("FIELD8A");
            entity.Property(e => e.Field9)
                .HasMaxLength(250)
                .HasColumnName("FIELD9");
            entity.Property(e => e.Field9a)
                .HasMaxLength(50)
                .HasColumnName("FIELD9A");
            entity.Property(e => e.FromTagNo).HasColumnName("FROM_TAG_NO");
            entity.Property(e => e.Taglist)
                .HasMaxLength(250)
                .HasColumnName("TAGLIST");
            entity.Property(e => e.ToTagNo).HasColumnName("TO_TAG_NO");
        });

        modelBuilder.Entity<MostPopularCatalogue>(entity =>
        {
            entity.HasKey(e => new { e.StkLibGroup, e.StkLocPerm, e.StkFormType, e.StartDate, e.EndDate, e.CatNo }).HasFillFactor(70);

            entity.ToTable("MOST_POPULAR_CATALOGUES");

            entity.Property(e => e.StkLibGroup)
                .HasMaxLength(30)
                .HasColumnName("STK_LIB_GROUP");
            entity.Property(e => e.StkLocPerm)
                .HasMaxLength(20)
                .HasColumnName("STK_LOC_PERM");
            entity.Property(e => e.StkFormType)
                .HasMaxLength(3)
                .HasColumnName("STK_FORM_TYPE");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("START_DATE");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("END_DATE");
            entity.Property(e => e.CatNo).HasColumnName("CAT_NO");
            entity.Property(e => e.CatPicData).HasColumnName("CAT_PIC_DATA");
            entity.Property(e => e.CatStr1)
                .HasMaxLength(100)
                .HasColumnName("CAT_STR1");
            entity.Property(e => e.CatStr2)
                .HasMaxLength(300)
                .HasColumnName("CAT_STR2");
            entity.Property(e => e.CatStr3)
                .HasMaxLength(100)
                .HasColumnName("CAT_STR3");
            entity.Property(e => e.CatStr4)
                .HasMaxLength(100)
                .HasColumnName("CAT_STR4");
            entity.Property(e => e.IssuesNum).HasColumnName("ISSUES_NUM");
            entity.Property(e => e.Threshold).HasColumnName("THRESHOLD");
        });

        modelBuilder.Entity<RepSpineLabel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("REP_SPINE_LABEL");

            entity.Property(e => e.CrBeginingPosition).HasColumnName("CR_BEGINING_POSITION");
            entity.Property(e => e.CrCallNumLine)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("CR_CALL_NUM_LINE");
            entity.Property(e => e.CrColumnQty).HasColumnName("CR_COLUMN_QTY");
            entity.Property(e => e.CrFileNumber).HasColumnName("CR_FILE_NUMBER");
            entity.Property(e => e.CrFullStopPosition)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("CR_FULL_STOP_POSITION");
            entity.Property(e => e.CrMaxWidth).HasColumnName("CR_MAX_WIDTH");
            entity.Property(e => e.CrStkCallSet)
                .HasMaxLength(6)
                .HasColumnName("CR_STK_CALL_SET");
            entity.Property(e => e.CrStkCatRefFrom).HasColumnName("CR_STK_CAT_REF_FROM");
            entity.Property(e => e.CrStkCatRefTo).HasColumnName("CR_STK_CAT_REF_TO");
            entity.Property(e => e.CrStkCost)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("CR_STK_COST");
            entity.Property(e => e.CrStkDateAcc)
                .HasColumnType("datetime")
                .HasColumnName("CR_STK_DATE_ACC");
            entity.Property(e => e.CrStkDateDue)
                .HasColumnType("datetime")
                .HasColumnName("CR_STK_DATE_DUE");
            entity.Property(e => e.CrStkDateRecd)
                .HasColumnType("datetime")
                .HasColumnName("CR_STK_DATE_RECD");
            entity.Property(e => e.CrStkDescription)
                .HasMaxLength(100)
                .HasColumnName("CR_STK_DESCRIPTION");
            entity.Property(e => e.CrStkEdition)
                .HasMaxLength(8)
                .HasColumnName("CR_STK_EDITION");
            entity.Property(e => e.CrStkForLoan)
                .HasMaxLength(1)
                .HasColumnName("CR_STK_FOR_LOAN");
            entity.Property(e => e.CrStkForm)
                .HasMaxLength(3)
                .HasColumnName("CR_STK_FORM");
            entity.Property(e => e.CrStkIssLoc)
                .HasMaxLength(20)
                .HasColumnName("CR_STK_ISS_LOC");
            entity.Property(e => e.CrStkIssueType)
                .HasMaxLength(1)
                .HasColumnName("CR_STK_ISSUE_TYPE");
            entity.Property(e => e.CrStkItemNoFrom)
                .HasMaxLength(25)
                .HasColumnName("CR_STK_ITEM_NO_FROM");
            entity.Property(e => e.CrStkItemNoTo)
                .HasMaxLength(25)
                .HasColumnName("CR_STK_ITEM_NO_TO");
            entity.Property(e => e.CrStkItemType)
                .HasMaxLength(1)
                .HasColumnName("CR_STK_ITEM_TYPE");
            entity.Property(e => e.CrStkLastTake)
                .HasColumnType("datetime")
                .HasColumnName("CR_STK_LAST_TAKE");
            entity.Property(e => e.CrStkLibGroup)
                .HasMaxLength(30)
                .HasColumnName("CR_STK_LIB_GROUP");
            entity.Property(e => e.CrStkLine1)
                .HasMaxLength(250)
                .HasColumnName("CR_STK_LINE1");
            entity.Property(e => e.CrStkLine2)
                .HasMaxLength(250)
                .HasColumnName("CR_STK_LINE2");
            entity.Property(e => e.CrStkLine3)
                .HasMaxLength(250)
                .HasColumnName("CR_STK_LINE3");
            entity.Property(e => e.CrStkLine4)
                .HasMaxLength(250)
                .HasColumnName("CR_STK_LINE4");
            entity.Property(e => e.CrStkLine5)
                .HasMaxLength(250)
                .HasColumnName("CR_STK_LINE5");
            entity.Property(e => e.CrStkLine6)
                .HasMaxLength(250)
                .HasColumnName("CR_STK_LINE6");
            entity.Property(e => e.CrStkLoanType)
                .HasMaxLength(3)
                .HasColumnName("CR_STK_LOAN_TYPE");
            entity.Property(e => e.CrStkLocFloor)
                .HasMaxLength(20)
                .HasColumnName("CR_STK_LOC_FLOOR");
            entity.Property(e => e.CrStkLocPerm)
                .HasMaxLength(20)
                .HasColumnName("CR_STK_LOC_PERM");
            entity.Property(e => e.CrStkLocTemp)
                .HasMaxLength(20)
                .HasColumnName("CR_STK_LOC_TEMP");
            entity.Property(e => e.CrStkOpacShow)
                .HasMaxLength(1)
                .HasColumnName("CR_STK_OPAC_SHOW");
            entity.Property(e => e.CrStkProcess)
                .HasMaxLength(20)
                .HasColumnName("CR_STK_PROCESS");
            entity.Property(e => e.CrStkProcessDate)
                .HasColumnType("datetime")
                .HasColumnName("CR_STK_PROCESS_DATE");
            entity.Property(e => e.CrStkStatsCode)
                .HasMaxLength(6)
                .HasColumnName("CR_STK_STATS_CODE");
            entity.Property(e => e.CrStkVolume)
                .HasMaxLength(8)
                .HasColumnName("CR_STK_VOLUME");
            entity.Property(e => e.OperName)
                .HasMaxLength(25)
                .HasColumnName("OPER_NAME");
            entity.Property(e => e.SessionId)
                .HasMaxLength(50)
                .HasColumnName("SESSION_ID");
            entity.Property(e => e.StkLna10ItemNo)
                .HasMaxLength(25)
                .HasColumnName("STK_LNA10_ITEM_NO");
            entity.Property(e => e.StkLna10d1)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA10D1");
            entity.Property(e => e.StkLna10d10)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA10D10");
            entity.Property(e => e.StkLna10d2)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA10D2");
            entity.Property(e => e.StkLna10d3)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA10D3");
            entity.Property(e => e.StkLna10d4)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA10D4");
            entity.Property(e => e.StkLna10d5)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA10D5");
            entity.Property(e => e.StkLna10d6)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA10D6");
            entity.Property(e => e.StkLna10d7)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA10D7");
            entity.Property(e => e.StkLna10d8)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA10D8");
            entity.Property(e => e.StkLna10d9)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA10D9");
            entity.Property(e => e.StkLna1ItemNo)
                .HasMaxLength(25)
                .HasColumnName("STK_LNA1_ITEM_NO");
            entity.Property(e => e.StkLna1d1)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA1D1");
            entity.Property(e => e.StkLna1d10)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA1D10");
            entity.Property(e => e.StkLna1d2)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA1D2");
            entity.Property(e => e.StkLna1d3)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA1D3");
            entity.Property(e => e.StkLna1d4)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA1D4");
            entity.Property(e => e.StkLna1d5)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA1D5");
            entity.Property(e => e.StkLna1d6)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA1D6");
            entity.Property(e => e.StkLna1d7)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA1D7");
            entity.Property(e => e.StkLna1d8)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA1D8");
            entity.Property(e => e.StkLna1d9)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA1D9");
            entity.Property(e => e.StkLna2ItemNo)
                .HasMaxLength(25)
                .HasColumnName("STK_LNA2_ITEM_NO");
            entity.Property(e => e.StkLna2d1)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA2D1");
            entity.Property(e => e.StkLna2d10)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA2D10");
            entity.Property(e => e.StkLna2d2)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA2D2");
            entity.Property(e => e.StkLna2d3)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA2D3");
            entity.Property(e => e.StkLna2d4)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA2D4");
            entity.Property(e => e.StkLna2d5)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA2D5");
            entity.Property(e => e.StkLna2d6)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA2D6");
            entity.Property(e => e.StkLna2d7)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA2D7");
            entity.Property(e => e.StkLna2d8)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA2D8");
            entity.Property(e => e.StkLna2d9)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA2D9");
            entity.Property(e => e.StkLna3ItemNo)
                .HasMaxLength(25)
                .HasColumnName("STK_LNA3_ITEM_NO");
            entity.Property(e => e.StkLna3d1)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA3D1");
            entity.Property(e => e.StkLna3d10)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA3D10");
            entity.Property(e => e.StkLna3d2)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA3D2");
            entity.Property(e => e.StkLna3d3)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA3D3");
            entity.Property(e => e.StkLna3d4)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA3D4");
            entity.Property(e => e.StkLna3d5)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA3D5");
            entity.Property(e => e.StkLna3d6)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA3D6");
            entity.Property(e => e.StkLna3d7)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA3D7");
            entity.Property(e => e.StkLna3d8)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA3D8");
            entity.Property(e => e.StkLna3d9)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA3D9");
            entity.Property(e => e.StkLna4ItemNo)
                .HasMaxLength(25)
                .HasColumnName("STK_LNA4_ITEM_NO");
            entity.Property(e => e.StkLna4d1)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA4D1");
            entity.Property(e => e.StkLna4d10)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA4D10");
            entity.Property(e => e.StkLna4d2)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA4D2");
            entity.Property(e => e.StkLna4d3)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA4D3");
            entity.Property(e => e.StkLna4d4)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA4D4");
            entity.Property(e => e.StkLna4d5)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA4D5");
            entity.Property(e => e.StkLna4d6)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA4D6");
            entity.Property(e => e.StkLna4d7)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA4D7");
            entity.Property(e => e.StkLna4d8)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA4D8");
            entity.Property(e => e.StkLna4d9)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA4D9");
            entity.Property(e => e.StkLna5ItemNo)
                .HasMaxLength(25)
                .HasColumnName("STK_LNA5_ITEM_NO");
            entity.Property(e => e.StkLna5d1)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA5D1");
            entity.Property(e => e.StkLna5d10)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA5D10");
            entity.Property(e => e.StkLna5d2)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA5D2");
            entity.Property(e => e.StkLna5d3)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA5D3");
            entity.Property(e => e.StkLna5d4)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA5D4");
            entity.Property(e => e.StkLna5d5)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA5D5");
            entity.Property(e => e.StkLna5d6)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA5D6");
            entity.Property(e => e.StkLna5d7)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA5D7");
            entity.Property(e => e.StkLna5d8)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA5D8");
            entity.Property(e => e.StkLna5d9)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA5D9");
            entity.Property(e => e.StkLna6ItemNo)
                .HasMaxLength(25)
                .HasColumnName("STK_LNA6_ITEM_NO");
            entity.Property(e => e.StkLna6d1)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA6D1");
            entity.Property(e => e.StkLna6d10)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA6D10");
            entity.Property(e => e.StkLna6d2)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA6D2");
            entity.Property(e => e.StkLna6d3)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA6D3");
            entity.Property(e => e.StkLna6d4)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA6D4");
            entity.Property(e => e.StkLna6d5)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA6D5");
            entity.Property(e => e.StkLna6d6)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA6D6");
            entity.Property(e => e.StkLna6d7)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA6D7");
            entity.Property(e => e.StkLna6d8)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA6D8");
            entity.Property(e => e.StkLna6d9)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA6D9");
            entity.Property(e => e.StkLna7ItemNo)
                .HasMaxLength(25)
                .HasColumnName("STK_LNA7_ITEM_NO");
            entity.Property(e => e.StkLna7d1)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA7D1");
            entity.Property(e => e.StkLna7d10)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA7D10");
            entity.Property(e => e.StkLna7d2)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA7D2");
            entity.Property(e => e.StkLna7d3)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA7D3");
            entity.Property(e => e.StkLna7d4)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA7D4");
            entity.Property(e => e.StkLna7d5)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA7D5");
            entity.Property(e => e.StkLna7d6)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA7D6");
            entity.Property(e => e.StkLna7d7)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA7D7");
            entity.Property(e => e.StkLna7d8)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA7D8");
            entity.Property(e => e.StkLna7d9)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA7D9");
            entity.Property(e => e.StkLna8ItemNo)
                .HasMaxLength(25)
                .HasColumnName("STK_LNA8_ITEM_NO");
            entity.Property(e => e.StkLna8d1)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA8D1");
            entity.Property(e => e.StkLna8d10)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA8D10");
            entity.Property(e => e.StkLna8d2)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA8D2");
            entity.Property(e => e.StkLna8d3)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA8D3");
            entity.Property(e => e.StkLna8d4)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA8D4");
            entity.Property(e => e.StkLna8d5)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA8D5");
            entity.Property(e => e.StkLna8d6)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA8D6");
            entity.Property(e => e.StkLna8d7)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA8D7");
            entity.Property(e => e.StkLna8d8)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA8D8");
            entity.Property(e => e.StkLna8d9)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA8D9");
            entity.Property(e => e.StkLna9ItemNo)
                .HasMaxLength(25)
                .HasColumnName("STK_LNA9_ITEM_NO");
            entity.Property(e => e.StkLna9d1)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA9D1");
            entity.Property(e => e.StkLna9d10)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA9D10");
            entity.Property(e => e.StkLna9d2)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA9D2");
            entity.Property(e => e.StkLna9d3)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA9D3");
            entity.Property(e => e.StkLna9d4)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA9D4");
            entity.Property(e => e.StkLna9d5)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA9D5");
            entity.Property(e => e.StkLna9d6)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA9D6");
            entity.Property(e => e.StkLna9d7)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA9D7");
            entity.Property(e => e.StkLna9d8)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA9D8");
            entity.Property(e => e.StkLna9d9)
                .HasMaxLength(40)
                .HasColumnName("STK_LNA9D9");
        });

        modelBuilder.Entity<StkItemReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("STK_ITEM_REPORT");

            entity.Property(e => e.BaAddr1)
                .HasMaxLength(85)
                .HasColumnName("BA_ADDR1");
            entity.Property(e => e.BaAddr2)
                .HasMaxLength(85)
                .HasColumnName("BA_ADDR2");
            entity.Property(e => e.BaAddr3)
                .HasMaxLength(85)
                .HasColumnName("BA_ADDR3");
            entity.Property(e => e.BaAddr4)
                .HasMaxLength(85)
                .HasColumnName("BA_ADDR4");
            entity.Property(e => e.BaPcode)
                .HasMaxLength(10)
                .HasColumnName("BA_PCODE");
            entity.Property(e => e.BaTelephone)
                .HasMaxLength(25)
                .HasColumnName("BA_TELEPHONE");
            entity.Property(e => e.BorBarNo)
                .HasMaxLength(75)
                .HasColumnName("BOR_BAR_NO");
            entity.Property(e => e.BorChild)
                .HasMaxLength(50)
                .HasColumnName("BOR_CHILD");
            entity.Property(e => e.BorGiven)
                .HasMaxLength(20)
                .HasColumnName("BOR_GIVEN");
            entity.Property(e => e.BorLocation)
                .HasMaxLength(20)
                .HasColumnName("BOR_LOCATION");
            entity.Property(e => e.BorName)
                .HasMaxLength(50)
                .HasColumnName("BOR_NAME");
            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");
            entity.Property(e => e.BorSurname)
                .HasMaxLength(40)
                .HasColumnName("BOR_SURNAME");
            entity.Property(e => e.BorType)
                .HasMaxLength(3)
                .HasColumnName("BOR_TYPE");
            entity.Property(e => e.Psusername)
                .HasMaxLength(25)
                .HasColumnName("PSUSERNAME");
            entity.Property(e => e.Stk1Cost)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("STK1_COST");
            entity.Property(e => e.Stk1Due)
                .HasColumnType("datetime")
                .HasColumnName("STK1_DUE");
            entity.Property(e => e.Stk1Form)
                .HasMaxLength(3)
                .HasColumnName("STK1_FORM");
            entity.Property(e => e.Stk1ItemNo)
                .HasMaxLength(25)
                .HasColumnName("STK1_ITEM_NO");
            entity.Property(e => e.Stk1Line1)
                .HasMaxLength(250)
                .HasColumnName("STK1_LINE1");
            entity.Property(e => e.Stk1Line2)
                .HasMaxLength(250)
                .HasColumnName("STK1_LINE2");
            entity.Property(e => e.Stk1Loc)
                .HasMaxLength(20)
                .HasColumnName("STK1_LOC");
            entity.Property(e => e.Stk2Cost)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("STK2_COST");
            entity.Property(e => e.Stk2Due)
                .HasColumnType("datetime")
                .HasColumnName("STK2_DUE");
            entity.Property(e => e.Stk2Form)
                .HasMaxLength(3)
                .HasColumnName("STK2_FORM");
            entity.Property(e => e.Stk2ItemNo)
                .HasMaxLength(25)
                .HasColumnName("STK2_ITEM_NO");
            entity.Property(e => e.Stk2Line1)
                .HasMaxLength(250)
                .HasColumnName("STK2_LINE1");
            entity.Property(e => e.Stk2Line2)
                .HasMaxLength(250)
                .HasColumnName("STK2_LINE2");
            entity.Property(e => e.Stk2Loc)
                .HasMaxLength(20)
                .HasColumnName("STK2_LOC");
            entity.Property(e => e.Stk3Cost)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("STK3_COST");
            entity.Property(e => e.Stk3Due)
                .HasColumnType("datetime")
                .HasColumnName("STK3_DUE");
            entity.Property(e => e.Stk3Form)
                .HasMaxLength(3)
                .HasColumnName("STK3_FORM");
            entity.Property(e => e.Stk3ItemNo)
                .HasMaxLength(25)
                .HasColumnName("STK3_ITEM_NO");
            entity.Property(e => e.Stk3Line1)
                .HasMaxLength(250)
                .HasColumnName("STK3_LINE1");
            entity.Property(e => e.Stk3Line2)
                .HasMaxLength(250)
                .HasColumnName("STK3_LINE2");
            entity.Property(e => e.Stk3Loc)
                .HasMaxLength(20)
                .HasColumnName("STK3_LOC");
            entity.Property(e => e.Stk4Cost)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("STK4_COST");
            entity.Property(e => e.Stk4Due)
                .HasColumnType("datetime")
                .HasColumnName("STK4_DUE");
            entity.Property(e => e.Stk4Form)
                .HasMaxLength(3)
                .HasColumnName("STK4_FORM");
            entity.Property(e => e.Stk4ItemNo)
                .HasMaxLength(25)
                .HasColumnName("STK4_ITEM_NO");
            entity.Property(e => e.Stk4Line1)
                .HasMaxLength(250)
                .HasColumnName("STK4_LINE1");
            entity.Property(e => e.Stk4Line2)
                .HasMaxLength(250)
                .HasColumnName("STK4_LINE2");
            entity.Property(e => e.Stk4Loc)
                .HasMaxLength(20)
                .HasColumnName("STK4_LOC");
            entity.Property(e => e.Stk5Cost)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("STK5_COST");
            entity.Property(e => e.Stk5Due)
                .HasColumnType("datetime")
                .HasColumnName("STK5_DUE");
            entity.Property(e => e.Stk5Form)
                .HasMaxLength(3)
                .HasColumnName("STK5_FORM");
            entity.Property(e => e.Stk5ItemNo)
                .HasMaxLength(25)
                .HasColumnName("STK5_ITEM_NO");
            entity.Property(e => e.Stk5Line1)
                .HasMaxLength(250)
                .HasColumnName("STK5_LINE1");
            entity.Property(e => e.Stk5Line2)
                .HasMaxLength(250)
                .HasColumnName("STK5_LINE2");
            entity.Property(e => e.Stk5Loc)
                .HasMaxLength(20)
                .HasColumnName("STK5_LOC");
            entity.Property(e => e.Stk6Cost)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("STK6_COST");
            entity.Property(e => e.Stk6Due)
                .HasColumnType("datetime")
                .HasColumnName("STK6_DUE");
            entity.Property(e => e.Stk6Form)
                .HasMaxLength(3)
                .HasColumnName("STK6_FORM");
            entity.Property(e => e.Stk6ItemNo)
                .HasMaxLength(25)
                .HasColumnName("STK6_ITEM_NO");
            entity.Property(e => e.Stk6Line1)
                .HasMaxLength(250)
                .HasColumnName("STK6_LINE1");
            entity.Property(e => e.Stk6Line2)
                .HasMaxLength(250)
                .HasColumnName("STK6_LINE2");
            entity.Property(e => e.Stk6Loc)
                .HasMaxLength(20)
                .HasColumnName("STK6_LOC");
            entity.Property(e => e.Stk7Cost)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("STK7_COST");
            entity.Property(e => e.Stk7Due)
                .HasColumnType("datetime")
                .HasColumnName("STK7_DUE");
            entity.Property(e => e.Stk7Form)
                .HasMaxLength(3)
                .HasColumnName("STK7_FORM");
            entity.Property(e => e.Stk7ItemNo)
                .HasMaxLength(25)
                .HasColumnName("STK7_ITEM_NO");
            entity.Property(e => e.Stk7Line1)
                .HasMaxLength(250)
                .HasColumnName("STK7_LINE1");
            entity.Property(e => e.Stk7Line2)
                .HasMaxLength(250)
                .HasColumnName("STK7_LINE2");
            entity.Property(e => e.Stk7Loc)
                .HasMaxLength(20)
                .HasColumnName("STK7_LOC");
            entity.Property(e => e.Stk8Cost)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("STK8_COST");
            entity.Property(e => e.Stk8Due)
                .HasColumnType("datetime")
                .HasColumnName("STK8_DUE");
            entity.Property(e => e.Stk8Form)
                .HasMaxLength(3)
                .HasColumnName("STK8_FORM");
            entity.Property(e => e.Stk8ItemNo)
                .HasMaxLength(25)
                .HasColumnName("STK8_ITEM_NO");
            entity.Property(e => e.Stk8Line1)
                .HasMaxLength(250)
                .HasColumnName("STK8_LINE1");
            entity.Property(e => e.Stk8Line2)
                .HasMaxLength(250)
                .HasColumnName("STK8_LINE2");
            entity.Property(e => e.Stk8Loc)
                .HasMaxLength(20)
                .HasColumnName("STK8_LOC");
            entity.Property(e => e.StkIssloc)
                .HasMaxLength(20)
                .HasColumnName("STK_ISSLOC");
            entity.Property(e => e.UniqueNo).HasColumnName("UNIQUE_NO");
        });

        modelBuilder.Entity<VAccidentForm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_ACCIDENT_FORM");

            entity.Property(e => e.CatNo).HasColumnName("CAT_NO");
            entity.Property(e => e.MarcTag2000)
                .HasMaxLength(1000)
                .HasColumnName("MARC_TAG_2000");
            entity.Property(e => e.MarcTag2001)
                .HasMaxLength(1000)
                .HasColumnName("MARC_TAG_2001");
            entity.Property(e => e.MarcTag2002)
                .HasMaxLength(1000)
                .HasColumnName("MARC_TAG_2002");
            entity.Property(e => e.MarcTag2003)
                .HasMaxLength(1000)
                .HasColumnName("MARC_TAG_2003");
            entity.Property(e => e.MarcTag2004)
                .HasMaxLength(1000)
                .HasColumnName("MARC_TAG_2004");
            entity.Property(e => e.MarcTag2005)
                .HasMaxLength(1000)
                .HasColumnName("MARC_TAG_2005");
            entity.Property(e => e.MarcTag2006)
                .HasMaxLength(1000)
                .HasColumnName("MARC_TAG_2006");
            entity.Property(e => e.MarcTag2007)
                .HasMaxLength(1000)
                .HasColumnName("MARC_TAG_2007");
            entity.Property(e => e.MarcTag2008)
                .HasMaxLength(1000)
                .HasColumnName("MARC_TAG_2008");
            entity.Property(e => e.MarcTag2009)
                .HasMaxLength(1000)
                .HasColumnName("MARC_TAG_2009");
            entity.Property(e => e.MarcTag2010)
                .HasMaxLength(1000)
                .HasColumnName("MARC_TAG_2010");
            entity.Property(e => e.MarcTag2011)
                .HasMaxLength(1000)
                .HasColumnName("MARC_TAG_2011");
            entity.Property(e => e.MarcTag2012)
                .HasMaxLength(1000)
                .HasColumnName("MARC_TAG_2012");
            entity.Property(e => e.MarcTag2013)
                .HasMaxLength(1000)
                .HasColumnName("MARC_TAG_2013");
            entity.Property(e => e.MarcTag2014)
                .HasMaxLength(1000)
                .HasColumnName("MARC_TAG_2014");
        });

        modelBuilder.Entity<VAccount>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_ACCOUNT");

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

        modelBuilder.Entity<VAccountHeader>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_ACCOUNT_HEADER");

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

        modelBuilder.Entity<VAccountTran>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_ACCOUNT_TRANS");

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

        modelBuilder.Entity<VAdABorPicture>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_AD_A_BOR_PICTURE");

            entity.Property(e => e.AuditType)
                .HasMaxLength(1)
                .HasColumnName("AUDIT_TYPE");
            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");
            entity.Property(e => e.BorPicData).HasColumnName("BOR_PIC_DATA");
            entity.Property(e => e.BorPicFilename)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BOR_PIC_FILENAME");
            entity.Property(e => e.BorPicType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BOR_PIC_TYPE");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<VAdAuthority>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_AD_AUTHORITY");

            entity.Property(e => e.AuditType)
                .HasMaxLength(1)
                .HasColumnName("AUDIT_TYPE");
            entity.Property(e => e.AuthDatetime)
                .HasColumnType("datetime")
                .HasColumnName("AUTH_DATETIME");
            entity.Property(e => e.AuthHasSa)
                .HasMaxLength(1)
                .HasColumnName("AUTH_HAS_SA");
            entity.Property(e => e.AuthInd1)
                .HasMaxLength(1)
                .HasColumnName("AUTH_IND1");
            entity.Property(e => e.AuthInd2)
                .HasMaxLength(1)
                .HasColumnName("AUTH_IND2");
            entity.Property(e => e.AuthKey)
                .HasMaxLength(200)
                .HasColumnName("AUTH_KEY");
            entity.Property(e => e.AuthLibGroup)
                .HasMaxLength(30)
                .HasColumnName("AUTH_LIB_GROUP");
            entity.Property(e => e.AuthMarc)
                .HasMaxLength(250)
                .HasColumnName("AUTH_MARC");
            entity.Property(e => e.AuthNo).HasColumnName("AUTH_NO");
            entity.Property(e => e.AuthOper)
                .HasMaxLength(25)
                .HasColumnName("AUTH_OPER");
            entity.Property(e => e.AuthSecurity)
                .HasColumnType("decimal(2, 0)")
                .HasColumnName("AUTH_SECURITY");
            entity.Property(e => e.AuthSee).HasColumnName("AUTH_SEE");
            entity.Property(e => e.AuthSoundex)
                .HasMaxLength(90)
                .HasColumnName("AUTH_SOUNDEX");
            entity.Property(e => e.AuthTagNo).HasColumnName("AUTH_TAG_NO");
            entity.Property(e => e.SfFormat)
                .HasColumnType("ntext")
                .HasColumnName("SF_FORMAT");
        });

        modelBuilder.Entity<VAdBorAddr>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_AD_BOR_ADDR");

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
                .HasMaxLength(30)
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

        modelBuilder.Entity<VAdBorHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_AD_BOR_HISTORY");

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

        modelBuilder.Entity<VAdBorLogin>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_AD_BOR_LOGIN");

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

        modelBuilder.Entity<VAdBorrower>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_AD_BORROWER");

            entity.Property(e => e.AuditDate)
                .HasPrecision(2)
                .HasColumnName("AUDIT_DATE");
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

        modelBuilder.Entity<VAdCatMarcLong>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_AD_CAT_MARC_LONG");

            entity.Property(e => e.AuditId)
                .ValueGeneratedOnAdd()
                .HasColumnName("AUDIT_ID");
            entity.Property(e => e.AuditType)
                .HasMaxLength(1)
                .HasColumnName("AUDIT_TYPE");
            entity.Property(e => e.CmlData).HasColumnName("CML_DATA");
            entity.Property(e => e.TagUniqueNo).HasColumnName("TAG_UNIQUE_NO");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(25)
                .HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn).HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<VAdCatalogue>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_AD_CATALOGUE");

            entity.Property(e => e.AuditId)
                .ValueGeneratedOnAdd()
                .HasColumnName("AUDIT_ID");
            entity.Property(e => e.AuditType)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("AUDIT_TYPE");
            entity.Property(e => e.CatAvgRating)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("CAT_AVG_RATING");
            entity.Property(e => e.CatCreateDatetime)
                .HasColumnType("datetime")
                .HasColumnName("CAT_CREATE_DATETIME");
            entity.Property(e => e.CatCreateOper)
                .HasMaxLength(25)
                .HasColumnName("CAT_CREATE_OPER");
            entity.Property(e => e.CatDate1).HasColumnName("CAT_DATE1");
            entity.Property(e => e.CatDate2).HasColumnName("CAT_DATE2");
            entity.Property(e => e.CatDate3).HasColumnName("CAT_DATE3");
            entity.Property(e => e.CatDate4).HasColumnName("CAT_DATE4");
            entity.Property(e => e.CatDatetime)
                .HasColumnType("datetime")
                .HasColumnName("CAT_DATETIME");
            entity.Property(e => e.CatKey1)
                .HasMaxLength(100)
                .HasColumnName("CAT_KEY1");
            entity.Property(e => e.CatKey2)
                .HasMaxLength(1000)
                .HasColumnName("CAT_KEY2");
            entity.Property(e => e.CatKey3)
                .HasMaxLength(100)
                .HasColumnName("CAT_KEY3");
            entity.Property(e => e.CatKey4)
                .HasMaxLength(100)
                .HasColumnName("CAT_KEY4");
            entity.Property(e => e.CatLibGroup)
                .HasMaxLength(30)
                .HasColumnName("CAT_LIB_GROUP");
            entity.Property(e => e.CatNo).HasColumnName("CAT_NO");
            entity.Property(e => e.CatNo1).HasColumnName("CAT_NO1");
            entity.Property(e => e.CatNo2).HasColumnName("CAT_NO2");
            entity.Property(e => e.CatNo3).HasColumnName("CAT_NO3");
            entity.Property(e => e.CatNo4).HasColumnName("CAT_NO4");
            entity.Property(e => e.CatOper)
                .HasMaxLength(25)
                .HasColumnName("CAT_OPER");
            entity.Property(e => e.CatPicData).HasColumnName("CAT_PIC_DATA");
            entity.Property(e => e.CatPicFilename)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CAT_PIC_FILENAME");
            entity.Property(e => e.CatPicType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CAT_PIC_TYPE");
            entity.Property(e => e.CatRestrict)
                .HasMaxLength(1)
                .HasColumnName("CAT_RESTRICT");
            entity.Property(e => e.CatSecurity)
                .HasColumnType("decimal(2, 0)")
                .HasColumnName("CAT_SECURITY");
            entity.Property(e => e.CatStr1)
                .HasMaxLength(100)
                .HasColumnName("CAT_STR1");
            entity.Property(e => e.CatStr2)
                .HasMaxLength(1000)
                .HasColumnName("CAT_STR2");
            entity.Property(e => e.CatStr3)
                .HasMaxLength(100)
                .HasColumnName("CAT_STR3");
            entity.Property(e => e.CatStr4)
                .HasMaxLength(100)
                .HasColumnName("CAT_STR4");
            entity.Property(e => e.CatStr5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CAT_STR5");
            entity.Property(e => e.CatStr6)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CAT_STR6");
            entity.Property(e => e.CatStr7)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CAT_STR7");
            entity.Property(e => e.CatStr8)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CAT_STR8");
            entity.Property(e => e.CnPrefix)
                .HasMaxLength(5)
                .HasColumnName("CN_PREFIX");
            entity.Property(e => e.CnSuffix).HasColumnName("CN_SUFFIX");
            entity.Property(e => e.SeriesCatRefNo).HasColumnName("SERIES_CAT_REF_NO");
            entity.Property(e => e.SeriesType)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("SERIES_TYPE");
            entity.Property(e => e.TemplateId)
                .HasMaxLength(75)
                .HasColumnName("TEMPLATE_ID");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(75)
                .HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn).HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<VAdOperatorLogin>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_AD_OPERATOR_LOGIN");

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

        modelBuilder.Entity<VAdStkHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_AD_STK_HISTORY");

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

        modelBuilder.Entity<VAdStkItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_AD_STK_ITEM");

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
                .HasMaxLength(25)
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
                .HasMaxLength(6)
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

        modelBuilder.Entity<VArea>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_AREA");

            entity.Property(e => e.AreaCode)
                .HasMaxLength(10)
                .HasColumnName("AREA_CODE");
            entity.Property(e => e.AreaName)
                .HasMaxLength(75)
                .HasColumnName("AREA_NAME");
            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");
        });

        modelBuilder.Entity<VAuthSeeAlso>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_AUTH_SEE_ALSO");

            entity.Property(e => e.AuthDatetime)
                .HasColumnType("datetime")
                .HasColumnName("AUTH_DATETIME");
            entity.Property(e => e.AuthNo).HasColumnName("AUTH_NO");
            entity.Property(e => e.AuthOper)
                .HasMaxLength(25)
                .HasColumnName("AUTH_OPER");
            entity.Property(e => e.AuthSaTerm)
                .HasMaxLength(1)
                .HasColumnName("AUTH_SA_TERM");
            entity.Property(e => e.AuthSeeAlso).HasColumnName("AUTH_SEE_ALSO");
        });

        modelBuilder.Entity<VAuthority>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_AUTHORITY");

            entity.Property(e => e.AuthDatetime)
                .HasColumnType("datetime")
                .HasColumnName("AUTH_DATETIME");
            entity.Property(e => e.AuthHasSa)
                .HasMaxLength(1)
                .HasColumnName("AUTH_HAS_SA");
            entity.Property(e => e.AuthInd1)
                .HasMaxLength(1)
                .HasColumnName("AUTH_IND1");
            entity.Property(e => e.AuthInd2)
                .HasMaxLength(1)
                .HasColumnName("AUTH_IND2");
            entity.Property(e => e.AuthKeepNo).HasColumnName("AUTH_KEEP_NO");
            entity.Property(e => e.AuthKey)
                .HasMaxLength(200)
                .HasColumnName("AUTH_KEY");
            entity.Property(e => e.AuthLibGroup)
                .HasMaxLength(30)
                .HasColumnName("AUTH_LIB_GROUP");
            entity.Property(e => e.AuthMarc)
                .HasMaxLength(250)
                .HasColumnName("AUTH_MARC");
            entity.Property(e => e.AuthNo).HasColumnName("AUTH_NO");
            entity.Property(e => e.AuthNote)
                .HasMaxLength(1)
                .HasColumnName("AUTH_NOTE");
            entity.Property(e => e.AuthOper)
                .HasMaxLength(25)
                .HasColumnName("AUTH_OPER");
            entity.Property(e => e.AuthSecurity)
                .HasColumnType("decimal(2, 0)")
                .HasColumnName("AUTH_SECURITY");
            entity.Property(e => e.AuthSee).HasColumnName("AUTH_SEE");
            entity.Property(e => e.AuthSoundex)
                .HasMaxLength(90)
                .HasColumnName("AUTH_SOUNDEX");
            entity.Property(e => e.AuthTagNo).HasColumnName("AUTH_TAG_NO");
            entity.Property(e => e.AuthtempInd1).HasColumnName("AUTHTEMP_IND1");
            entity.Property(e => e.AuthtempInd2).HasColumnName("AUTHTEMP_IND2");
        });

        modelBuilder.Entity<VBorAddr>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_BOR_ADDR");

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
                .HasMaxLength(30)
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

        modelBuilder.Entity<VBorClass>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_BOR_CLASSES");

            entity.Property(e => e.BcClass)
                .HasMaxLength(10)
                .HasColumnName("BC_CLASS");
            entity.Property(e => e.BcName)
                .HasMaxLength(75)
                .HasColumnName("BC_NAME");
            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");
        });

        modelBuilder.Entity<VBorCoursePeriod>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_BOR_COURSE_PERIOD");

            entity.Property(e => e.BorCoCode)
                .HasMaxLength(20)
                .HasColumnName("BOR_CO_CODE");
            entity.Property(e => e.BorCpDateFrom)
                .HasColumnType("datetime")
                .HasColumnName("BOR_CP_DATE_FROM");
            entity.Property(e => e.BorCpDateTo)
                .HasColumnType("datetime")
                .HasColumnName("BOR_CP_DATE_TO");
            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");
            entity.Property(e => e.CoDescription)
                .HasMaxLength(100)
                .HasColumnName("CO_DESCRIPTION");
        });

        modelBuilder.Entity<VBorGroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_BOR_GROUPS");

            entity.Property(e => e.BgGroup)
                .HasMaxLength(10)
                .HasColumnName("BG_GROUP");
            entity.Property(e => e.BgName)
                .HasMaxLength(75)
                .HasColumnName("BG_NAME");
            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");
        });

        modelBuilder.Entity<VBorHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_BOR_HISTORY");

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

        modelBuilder.Entity<VBorHistoryNote>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_BOR_HISTORY_NOTES");

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
            entity.Property(e => e.HistoryId)
                .ValueGeneratedOnAdd()
                .HasColumnName("HISTORY_ID");
            entity.Property(e => e.Notes).HasColumnName("NOTES");
            entity.Property(e => e.ResultCode)
                .HasMaxLength(8)
                .HasColumnName("RESULT_CODE");
            entity.Property(e => e.ShortDesc)
                .HasMaxLength(200)
                .HasColumnName("SHORT_DESC");
        });

        modelBuilder.Entity<VBorMemo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_BOR_MEMOS");

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

        modelBuilder.Entity<VBorPayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_BOR_PAYMENT");

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
            entity.Property(e => e.PayNo).HasColumnName("PAY_NO");
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

        modelBuilder.Entity<VBorPaymentFinTran>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_BOR_PAYMENT_FIN_TRANS");

            entity.Property(e => e.FinTranNo).HasColumnName("FIN_TRAN_NO");
            entity.Property(e => e.PayNo).HasColumnName("PAY_NO");
            entity.Property(e => e.PayValue)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("PAY_VALUE");
        });

        modelBuilder.Entity<VBorSubject>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_BOR_SUBJECTS");

            entity.Property(e => e.AuthNo).HasColumnName("AUTH_NO");
            entity.Property(e => e.BorBarNo)
                .HasMaxLength(75)
                .HasColumnName("BOR_BAR_NO");
            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");
        });

        modelBuilder.Entity<VBorSurvey>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_BOR_SURVEY");

            entity.Property(e => e.AnonymousId).HasColumnName("ANONYMOUS_ID");
            entity.Property(e => e.Approve)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("APPROVE");
            entity.Property(e => e.ApproveBy)
                .HasMaxLength(50)
                .HasColumnName("APPROVE_BY");
            entity.Property(e => e.ApproveDate)
                .HasColumnType("datetime")
                .HasColumnName("APPROVE_DATE");
            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");
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
            entity.Property(e => e.SerialNum).HasColumnName("SERIAL_NUM");
            entity.Property(e => e.Showdetails)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("SHOWDETAILS");
            entity.Property(e => e.SurveyId).HasColumnName("SURVEY_ID");
        });

        modelBuilder.Entity<VBorType>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_BOR_TYPES");

            entity.Property(e => e.BtAgeFrom).HasColumnName("BT_AGE_FROM");
            entity.Property(e => e.BtAgeTo).HasColumnName("BT_AGE_TO");
            entity.Property(e => e.BtExpDate)
                .HasColumnType("datetime")
                .HasColumnName("BT_EXP_DATE");
            entity.Property(e => e.BtExpDays).HasColumnName("BT_EXP_DAYS");
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
            entity.Property(e => e.BtThreshold).HasColumnName("BT_THRESHOLD");
            entity.Property(e => e.BtType)
                .HasMaxLength(3)
                .HasColumnName("BT_TYPE");
            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");
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
            entity.Property(e => e.BorDobDt).HasColumnName("BOR_DOB_DT");
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
            entity.Property(e => e.BorPicData).HasColumnName("BOR_PIC_DATA");
            entity.Property(e => e.BorPicFilename)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BOR_PIC_FILENAME");
            entity.Property(e => e.BorPicType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BOR_PIC_TYPE");
            entity.Property(e => e.BorPin)
                .HasMaxLength(25)
                .HasColumnName("BOR_PIN");
            entity.Property(e => e.BorPotentialCharge)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("BOR_POTENTIAL_CHARGE");
            entity.Property(e => e.BorQrData).HasColumnName("BOR_QR_DATA");
            entity.Property(e => e.BorQrType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BOR_QR_TYPE");
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
        });

        modelBuilder.Entity<VBorrowerAlt>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_BORROWER_ALT");

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
            entity.Property(e => e.BorPicData).HasColumnName("BOR_PIC_DATA");
            entity.Property(e => e.BorPicFilename)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BOR_PIC_FILENAME");
            entity.Property(e => e.BorPicType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BOR_PIC_TYPE");
            entity.Property(e => e.BorPin)
                .HasMaxLength(25)
                .HasColumnName("BOR_PIN");
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
        });

        modelBuilder.Entity<VBorrowerInterestMatch>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_BORROWER_INTEREST_MATCHES");

            entity.Property(e => e.AuthMarc)
                .HasMaxLength(250)
                .HasColumnName("AUTH_MARC");
            entity.Property(e => e.AuthNo).HasColumnName("AUTH_NO");
            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");
            entity.Property(e => e.CatNo).HasColumnName("CAT_NO");
            entity.Property(e => e.CatStr1)
                .HasMaxLength(100)
                .HasColumnName("CAT_STR1");
            entity.Property(e => e.CatStr2)
                .HasMaxLength(1000)
                .HasColumnName("CAT_STR2");
            entity.Property(e => e.CatStr3)
                .HasMaxLength(100)
                .HasColumnName("CAT_STR3");
            entity.Property(e => e.CatStr4)
                .HasMaxLength(100)
                .HasColumnName("CAT_STR4");
        });

        modelBuilder.Entity<VBorrowerLoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_BORROWER_LOC");

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
            entity.Property(e => e.BorPicData).HasColumnName("BOR_PIC_DATA");
            entity.Property(e => e.BorPicFilename)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BOR_PIC_FILENAME");
            entity.Property(e => e.BorPicType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BOR_PIC_TYPE");
            entity.Property(e => e.BorPin)
                .HasMaxLength(25)
                .HasColumnName("BOR_PIN");
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
        });

        modelBuilder.Entity<VBorrowerSpecial>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_BORROWER_SPECIAL");

            entity.Property(e => e.BorBarNo)
                .HasMaxLength(75)
                .HasColumnName("BOR_BAR_NO");
            entity.Property(e => e.BorEmail)
                .HasMaxLength(75)
                .HasColumnName("BOR_EMAIL");
            entity.Property(e => e.BorGiven)
                .HasMaxLength(40)
                .HasColumnName("BOR_GIVEN");
            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");
            entity.Property(e => e.BorSurname)
                .HasMaxLength(100)
                .HasColumnName("BOR_SURNAME");
            entity.Property(e => e.BorTitle)
                .HasMaxLength(25)
                .HasColumnName("BOR_TITLE");
            entity.Property(e => e.CatOfProcedure)
                .HasMaxLength(50)
                .HasColumnName("CAT_OF_PROCEDURE");
            entity.Property(e => e.DateOfOperation)
                .HasColumnType("datetime")
                .HasColumnName("DATE_OF_OPERATION");
            entity.Property(e => e.SerialNum).HasColumnName("SERIAL_NUM");
            entity.Property(e => e.Surveyid).HasColumnName("SURVEYID");
        });

        modelBuilder.Entity<VBudgetTotal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_BUDGET_TOTALS");

            entity.Property(e => e.AccCommit)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("ACC_COMMIT");
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
            entity.Property(e => e.AchAccount)
                .HasMaxLength(30)
                .HasColumnName("ACH_ACCOUNT");
            entity.Property(e => e.AchUnique1).HasColumnName("ACH_UNIQUE1");
            entity.Property(e => e.AchUnique2).HasColumnName("ACH_UNIQUE2");
            entity.Property(e => e.AchUnique3).HasColumnName("ACH_UNIQUE3");
            entity.Property(e => e.AchUnique4).HasColumnName("ACH_UNIQUE4");
            entity.Property(e => e.AchYear).HasColumnName("ACH_YEAR");
            entity.Property(e => e.Actual)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("ACTUAL");
            entity.Property(e => e.Budget)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("BUDGET");
            entity.Property(e => e.Des)
                .HasMaxLength(50)
                .HasColumnName("DES");
            entity.Property(e => e.GroupLevel).HasColumnName("GROUP_LEVEL");
            entity.Property(e => e.LibGroup)
                .HasMaxLength(30)
                .HasColumnName("LIB_GROUP");
            entity.Property(e => e.UniqueNo).HasColumnName("UNIQUE_NO");
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

        modelBuilder.Entity<VCatDynamicTemplateConfig>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_CAT_DYNAMIC_TEMPLATE_CONFIG");

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

        modelBuilder.Entity<VCatSf>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_CAT_SF");

            entity.Property(e => e.CatSf)
                .HasMaxLength(1)
                .HasColumnName("CAT_SF");
            entity.Property(e => e.CatSfData)
                .HasMaxLength(250)
                .HasColumnName("CAT_SF_DATA");
            entity.Property(e => e.CatSfDiacritic)
                .HasMaxLength(1)
                .HasColumnName("CAT_SF_DIACRITIC");
            entity.Property(e => e.CatSfLongNo).HasColumnName("CAT_SF_LONG_NO");
            entity.Property(e => e.CatSfSequence).HasColumnName("CAT_SF_SEQUENCE");
            entity.Property(e => e.CatSfUniqueNo).HasColumnName("CAT_SF_UNIQUE_NO");
            entity.Property(e => e.CatTagNo).HasColumnName("CAT_TAG_NO");
            entity.Property(e => e.CatTagUniqueNo).HasColumnName("CAT_TAG_UNIQUE_NO");
        });

        modelBuilder.Entity<VCatTag>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_CAT_TAG");

            entity.Property(e => e.CatMarcLong).HasColumnName("CAT_MARC_LONG");
            entity.Property(e => e.Parent880).HasColumnName("PARENT_880");
            entity.Property(e => e.TagDatetime)
                .HasColumnType("datetime")
                .HasColumnName("TAG_DATETIME");
            entity.Property(e => e.TagInd1)
                .HasMaxLength(1)
                .HasColumnName("TAG_IND1");
            entity.Property(e => e.TagInd2)
                .HasMaxLength(1)
                .HasColumnName("TAG_IND2");
            entity.Property(e => e.TagKey)
                .HasMaxLength(250)
                .HasColumnName("TAG_KEY");
            entity.Property(e => e.TagLibGroup)
                .HasMaxLength(30)
                .HasColumnName("TAG_LIB_GROUP");
            entity.Property(e => e.TagMarc)
                .HasMaxLength(250)
                .HasColumnName("TAG_MARC");
            entity.Property(e => e.TagNo).HasColumnName("TAG_NO");
            entity.Property(e => e.TagOper)
                .HasMaxLength(25)
                .HasColumnName("TAG_OPER");
            entity.Property(e => e.TagSecurity)
                .HasColumnType("decimal(2, 0)")
                .HasColumnName("TAG_SECURITY");
            entity.Property(e => e.TagUniqueNo).HasColumnName("TAG_UNIQUE_NO");
        });

        modelBuilder.Entity<VCatalogue>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_CATALOGUE");

            entity.Property(e => e.CatAvgRating)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("CAT_AVG_RATING");
            entity.Property(e => e.CatCreateDatetime)
                .HasColumnType("datetime")
                .HasColumnName("CAT_CREATE_DATETIME");
            entity.Property(e => e.CatCreateOper)
                .HasMaxLength(25)
                .HasColumnName("CAT_CREATE_OPER");
            entity.Property(e => e.CatDate1).HasColumnName("CAT_DATE1");
            entity.Property(e => e.CatDate2).HasColumnName("CAT_DATE2");
            entity.Property(e => e.CatDate3).HasColumnName("CAT_DATE3");
            entity.Property(e => e.CatDate4).HasColumnName("CAT_DATE4");
            entity.Property(e => e.CatDatetime)
                .HasColumnType("datetime")
                .HasColumnName("CAT_DATETIME");
            entity.Property(e => e.CatKey1)
                .HasMaxLength(100)
                .HasColumnName("CAT_KEY1");
            entity.Property(e => e.CatKey2)
                .HasMaxLength(1000)
                .HasColumnName("CAT_KEY2");
            entity.Property(e => e.CatKey3)
                .HasMaxLength(100)
                .HasColumnName("CAT_KEY3");
            entity.Property(e => e.CatKey4)
                .HasMaxLength(100)
                .HasColumnName("CAT_KEY4");
            entity.Property(e => e.CatLibGroup)
                .HasMaxLength(30)
                .HasColumnName("CAT_LIB_GROUP");
            entity.Property(e => e.CatNo).HasColumnName("CAT_NO");
            entity.Property(e => e.CatNo1).HasColumnName("CAT_NO1");
            entity.Property(e => e.CatNo2).HasColumnName("CAT_NO2");
            entity.Property(e => e.CatNo3).HasColumnName("CAT_NO3");
            entity.Property(e => e.CatNo4).HasColumnName("CAT_NO4");
            entity.Property(e => e.CatOper)
                .HasMaxLength(25)
                .HasColumnName("CAT_OPER");
            entity.Property(e => e.CatPicData).HasColumnName("CAT_PIC_DATA");
            entity.Property(e => e.CatPicFilename)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CAT_PIC_FILENAME");
            entity.Property(e => e.CatPicType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CAT_PIC_TYPE");
            entity.Property(e => e.CatRestrict)
                .HasMaxLength(1)
                .HasColumnName("CAT_RESTRICT");
            entity.Property(e => e.CatSecurity)
                .HasColumnType("decimal(2, 0)")
                .HasColumnName("CAT_SECURITY");
            entity.Property(e => e.CatStr1)
                .HasMaxLength(100)
                .HasColumnName("CAT_STR1");
            entity.Property(e => e.CatStr2)
                .HasMaxLength(1000)
                .HasColumnName("CAT_STR2");
            entity.Property(e => e.CatStr3)
                .HasMaxLength(100)
                .HasColumnName("CAT_STR3");
            entity.Property(e => e.CatStr4)
                .HasMaxLength(100)
                .HasColumnName("CAT_STR4");
            entity.Property(e => e.CatStr5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CAT_STR5");
            entity.Property(e => e.CatStr6)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CAT_STR6");
            entity.Property(e => e.CatStr7)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CAT_STR7");
            entity.Property(e => e.CatStr8)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CAT_STR8");
            entity.Property(e => e.TemplateId)
                .HasMaxLength(75)
                .HasColumnName("TEMPLATE_ID");
        });

        modelBuilder.Entity<VCatalogueDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_CATALOGUE_DATA");

            entity.Property(e => e.Authority).HasColumnName("AUTHORITY");
            entity.Property(e => e.CatNo).HasColumnName("CAT_NO");
            entity.Property(e => e.CatSfLongNo).HasColumnName("CAT_SF_LONG_NO");
            entity.Property(e => e.ClData)
                .HasColumnType("ntext")
                .HasColumnName("CL_DATA");
            entity.Property(e => e.ClDataText).HasColumnName("CL_DATA_TEXT");
            entity.Property(e => e.Sf)
                .HasMaxLength(1)
                .HasColumnName("SF");
            entity.Property(e => e.SfData)
                .HasMaxLength(300)
                .HasColumnName("SF_DATA");
            entity.Property(e => e.SfSequence).HasColumnName("SF_SEQUENCE");
            entity.Property(e => e.TagNo).HasColumnName("TAG_NO");
            entity.Property(e => e.UniqueNo).HasColumnName("UNIQUE_NO");
        });

        modelBuilder.Entity<VCatalogueRef>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_CATALOGUE_REFS");

            entity.Property(e => e.AuthNo).HasColumnName("AUTH_NO");
            entity.Property(e => e.AuthOcc).HasColumnName("AUTH_OCC");
            entity.Property(e => e.CatNo).HasColumnName("CAT_NO");
            entity.Property(e => e.CatRefSequence).HasColumnName("CAT_REF_SEQUENCE");
            entity.Property(e => e.CattagNo).HasColumnName("CATTAG_NO");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.TagNo).HasColumnName("TAG_NO");
        });

        modelBuilder.Entity<VCir1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_CIR_1");

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
                .HasMaxLength(30)
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
            entity.Property(e => e.BorPicData).HasColumnName("BOR_PIC_DATA");
            entity.Property(e => e.BorPicFilename)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BOR_PIC_FILENAME");
            entity.Property(e => e.BorPicType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BOR_PIC_TYPE");
            entity.Property(e => e.BorPin)
                .HasMaxLength(25)
                .HasColumnName("BOR_PIN");
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
                .HasMaxLength(40)
                .HasColumnName("STK_LOC_FLOOR");
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
            entity.Property(e => e.VerifiedBy)
                .HasMaxLength(25)
                .HasColumnName("VERIFIED_BY");
            entity.Property(e => e.VerifyAddress).HasColumnName("VERIFY_ADDRESS");
        });

        modelBuilder.Entity<VClassification>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_CLASSIFICATION");

            entity.Property(e => e.A)
                .HasMaxLength(300)
                .HasColumnName("a");
            entity.Property(e => e.AuthMarc)
                .HasMaxLength(250)
                .HasColumnName("AUTH_MARC");
            entity.Property(e => e.AuthNo).HasColumnName("AUTH_NO");
            entity.Property(e => e.B)
                .HasMaxLength(300)
                .HasColumnName("b");
            entity.Property(e => e.C)
                .HasMaxLength(300)
                .HasColumnName("c");
            entity.Property(e => e.D)
                .HasMaxLength(300)
                .HasColumnName("d");
            entity.Property(e => e.E)
                .HasMaxLength(300)
                .HasColumnName("e");
            entity.Property(e => e.F)
                .HasMaxLength(300)
                .HasColumnName("f");
            entity.Property(e => e.G)
                .HasMaxLength(300)
                .HasColumnName("g");
            entity.Property(e => e.H)
                .HasMaxLength(300)
                .HasColumnName("h");
            entity.Property(e => e.I)
                .HasMaxLength(300)
                .HasColumnName("i");
            entity.Property(e => e.J)
                .HasMaxLength(300)
                .HasColumnName("j");
        });

        modelBuilder.Entity<VEnquiry>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_ENQUIRY");

            entity.Property(e => e.BorEmail)
                .HasMaxLength(75)
                .HasColumnName("BOR_EMAIL");
            entity.Property(e => e.BorGiven)
                .HasMaxLength(40)
                .HasColumnName("BOR_GIVEN");
            entity.Property(e => e.BorSurname)
                .HasMaxLength(100)
                .HasColumnName("BOR_SURNAME");
            entity.Property(e => e.BorTitle)
                .HasMaxLength(25)
                .HasColumnName("BOR_TITLE");
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
        });

        modelBuilder.Entity<VFaultReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_FAULT_REPORT");

            entity.Property(e => e.CatNo).HasColumnName("CAT_NO");
            entity.Property(e => e.MarcTag2032)
                .HasMaxLength(1000)
                .HasColumnName("MARC_TAG_2032");
            entity.Property(e => e.MarcTag2033)
                .HasMaxLength(1000)
                .HasColumnName("MARC_TAG_2033");
            entity.Property(e => e.MarcTag2034)
                .HasMaxLength(1000)
                .HasColumnName("MARC_TAG_2034");
            entity.Property(e => e.MarcTag2035)
                .HasMaxLength(1000)
                .HasColumnName("MARC_TAG_2035");
            entity.Property(e => e.MarcTag2036)
                .HasMaxLength(1000)
                .HasColumnName("MARC_TAG_2036");
            entity.Property(e => e.MarcTag2037)
                .HasMaxLength(1000)
                .HasColumnName("MARC_TAG_2037");
        });

        modelBuilder.Entity<VFaultReportDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_FAULT_REPORT_DETAIL");

            entity.Property(e => e.ActionDetail)
                .HasMaxLength(300)
                .HasColumnName("ACTION_DETAIL");
            entity.Property(e => e.ActionLabel)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("ACTION_LABEL");
            entity.Property(e => e.CatNo).HasColumnName("CAT_NO");
            entity.Property(e => e.SfSequence).HasColumnName("SF_SEQUENCE");
            entity.Property(e => e.UniqueNo).HasColumnName("UNIQUE_NO");
        });

        modelBuilder.Entity<VFileCatDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_FILE_CAT_DATA");

            entity.Property(e => e.FileNitem).HasColumnName("FILE_NITEM");
            entity.Property(e => e.FileNumber).HasColumnName("FILE_NUMBER");
            entity.Property(e => e.FileSequence).HasColumnName("FILE_SEQUENCE");
        });

        modelBuilder.Entity<VFileCatName>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_FILE_CAT_NAMES");

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
            entity.Property(e => e.ListType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LIST_TYPE");
        });

        modelBuilder.Entity<VFileSetDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_FILE_SET_DATA");

            entity.Property(e => e.FileItem)
                .HasMaxLength(75)
                .HasColumnName("FILE_ITEM");
            entity.Property(e => e.FileNitem).HasColumnName("FILE_NITEM");
            entity.Property(e => e.FileNumber).HasColumnName("FILE_NUMBER");
            entity.Property(e => e.FileSequence).HasColumnName("FILE_SEQUENCE");
        });

        modelBuilder.Entity<VFileSetName>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_FILE_SET_NAMES");

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

        modelBuilder.Entity<VFinTran>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_FIN_TRANS");

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
                .HasColumnType("decimal(11, 2)")
                .HasColumnName("FIN_OS");
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

        modelBuilder.Entity<VIllLibrary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_ILL_LIBRARY");

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

        modelBuilder.Entity<VInvoiceComponent>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_INVOICE_COMPONENT");

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

        modelBuilder.Entity<VInvoiceHeader>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_INVOICE_HEADER");

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

        modelBuilder.Entity<VLibLocation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_LIB_LOCATIONS");

            entity.Property(e => e.LlCode)
                .HasMaxLength(40)
                .HasColumnName("LL_CODE");
            entity.Property(e => e.LlGroup)
                .HasMaxLength(30)
                .HasColumnName("LL_GROUP");
            entity.Property(e => e.LlName)
                .HasMaxLength(50)
                .HasColumnName("LL_NAME");
            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");
        });

        modelBuilder.Entity<VLibMemo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_LIB_MEMOS");

            entity.Property(e => e.LlGroup)
                .HasMaxLength(30)
                .HasColumnName("LL_GROUP");
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

        modelBuilder.Entity<VMeeting>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_MEETING");

            entity.Property(e => e.LlCode)
                .HasMaxLength(40)
                .HasColumnName("LL_CODE");
            entity.Property(e => e.MeetingBarcode).HasColumnName("MEETING_BARCODE");
            entity.Property(e => e.MeetingDescription).HasColumnName("MEETING_DESCRIPTION");
            entity.Property(e => e.MeetingEndDate)
                .HasColumnType("datetime")
                .HasColumnName("MEETING_END_DATE");
            entity.Property(e => e.MeetingId)
                .ValueGeneratedOnAdd()
                .HasColumnName("MEETING_ID");
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

        modelBuilder.Entity<VMeetingDelegate>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_MEETING_DELEGATE");

            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");
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
            entity.Property(e => e.MeetingDelegateStatus).HasColumnName("MEETING_DELEGATE_STATUS");
            entity.Property(e => e.MeetingId).HasColumnName("MEETING_ID");
            entity.Property(e => e.UserMeetingBarcode)
                .HasMaxLength(50)
                .HasColumnName("USER_MEETING_BARCODE");
        });

        modelBuilder.Entity<VMonthlyStat>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_MONTHLY_STATS");

            entity.Property(e => e.MsCount).HasColumnName("MS_COUNT");
            entity.Property(e => e.MsLlCode)
                .HasMaxLength(20)
                .HasColumnName("MS_LL_CODE");
            entity.Property(e => e.MsMonth).HasColumnName("MS_MONTH");
            entity.Property(e => e.MsYear).HasColumnName("MS_YEAR");
            entity.Property(e => e.TransType).HasColumnName("TRANS_TYPE");
        });

        modelBuilder.Entity<VMypc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_MYPC");

            entity.Property(e => e.BorrowerId)
                .HasMaxLength(75)
                .HasColumnName("BorrowerID");
            entity.Property(e => e.Owing).HasColumnType("decimal(11, 2)");
        });

        modelBuilder.Entity<VNearMissForm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_NEAR_MISS_FORM");

            entity.Property(e => e.CatNo).HasColumnName("CAT_NO");
            entity.Property(e => e.MarcTag2039)
                .HasMaxLength(1000)
                .HasColumnName("MARC_TAG_2039");
            entity.Property(e => e.MarcTag2040)
                .HasMaxLength(1000)
                .HasColumnName("MARC_TAG_2040");
            entity.Property(e => e.MarcTag2041)
                .HasMaxLength(1000)
                .HasColumnName("MARC_TAG_2041");
            entity.Property(e => e.MarcTag2042)
                .HasMaxLength(1000)
                .HasColumnName("MARC_TAG_2042");
            entity.Property(e => e.MarcTag2043)
                .HasMaxLength(1000)
                .HasColumnName("MARC_TAG_2043");
            entity.Property(e => e.MarcTag2044)
                .HasMaxLength(1000)
                .HasColumnName("MARC_TAG_2044");
            entity.Property(e => e.MarcTag2045)
                .HasMaxLength(1000)
                .HasColumnName("MARC_TAG_2045");
            entity.Property(e => e.MarcTag2046)
                .HasMaxLength(1000)
                .HasColumnName("MARC_TAG_2046");
            entity.Property(e => e.MarcTag2047)
                .HasMaxLength(1000)
                .HasColumnName("MARC_TAG_2047");
            entity.Property(e => e.MarcTag2048)
                .HasMaxLength(1000)
                .HasColumnName("MARC_TAG_2048");
            entity.Property(e => e.MarcTag2049)
                .HasMaxLength(1000)
                .HasColumnName("MARC_TAG_2049");
        });

        modelBuilder.Entity<VOpacusercomment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_OPACUSERCOMMENT");

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

        modelBuilder.Entity<VOpacuserreply>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_OPACUSERREPLY");

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

        modelBuilder.Entity<VOperator>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_OPERATOR");

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
            entity.Property(e => e.OperName)
                .HasMaxLength(25)
                .HasColumnName("OPER_NAME");
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
        });

        modelBuilder.Entity<VOrdComponent>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_ORD_COMPONENT");

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
            entity.Property(e => e.OcQtyUndelievered)
                .HasColumnType("decimal(11, 2)")
                .HasColumnName("OC_QTY_UNDELIEVERED");
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

        modelBuilder.Entity<VOrdCondition>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_ORD_CONDITION");

            entity.Property(e => e.OcCode)
                .HasMaxLength(10)
                .HasColumnName("OC_CODE");
            entity.Property(e => e.OcDesc)
                .HasMaxLength(50)
                .HasColumnName("OC_DESC");
            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");
        });

        modelBuilder.Entity<VOrdHeader>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_ORD_HEADER");

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

        modelBuilder.Entity<VOrdStkItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_ORD_STK_ITEM");

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

        modelBuilder.Entity<VPaymentReceipt>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_PAYMENT_RECEIPT");

            entity.Property(e => e.BorOwing)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("bor_OWING");
            entity.Property(e => e.CashTill).HasColumnName("CASH_TILL");
            entity.Property(e => e.FinBor)
                .HasMaxLength(75)
                .HasColumnName("FIN_BOR");
            entity.Property(e => e.FinComments)
                .HasMaxLength(100)
                .HasColumnName("FIN_COMMENTS");
            entity.Property(e => e.FinDate)
                .HasColumnType("datetime")
                .HasColumnName("FIN_DATE");
            entity.Property(e => e.FinItem)
                .HasMaxLength(25)
                .HasColumnName("FIN_ITEM");
            entity.Property(e => e.FinLoc)
                .HasMaxLength(20)
                .HasColumnName("FIN_LOC");
            entity.Property(e => e.FinName)
                .HasMaxLength(100)
                .HasColumnName("FIN_NAME");
            entity.Property(e => e.FinPaid)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("FIN_PAID");
            entity.Property(e => e.FinTitle)
                .HasMaxLength(250)
                .HasColumnName("FIN_TITLE");
            entity.Property(e => e.FinType)
                .HasMaxLength(15)
                .HasColumnName("FIN_TYPE");
            entity.Property(e => e.FinValue)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("FIN_VALUE");
            entity.Property(e => e.PayLibGroup)
                .HasMaxLength(30)
                .HasColumnName("PAY_LIB_GROUP");
            entity.Property(e => e.PayLocation)
                .HasMaxLength(40)
                .HasColumnName("PAY_LOCATION");
            entity.Property(e => e.PayNo).HasColumnName("PAY_NO");
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

        modelBuilder.Entity<VPerCopy>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_PER_COPY");

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

        modelBuilder.Entity<VPerIssue>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_PER_ISSUES");

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

        modelBuilder.Entity<VPerSub>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_PER_SUBS");

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

        modelBuilder.Entity<VPerSupplier>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_PER_SUPPLIER");

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

        modelBuilder.Entity<VPeriodical>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_PERIODICAL");

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

        modelBuilder.Entity<VPopularTitlesByClass>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_POPULAR_TITLES_BY_CLASS");

            entity.Property(e => e.BcName)
                .HasMaxLength(75)
                .HasColumnName("BC_NAME");
            entity.Property(e => e.CatNo).HasColumnName("CAT_NO");
            entity.Property(e => e.Total).HasColumnName("TOTAL");
        });

        modelBuilder.Entity<VPopularTitlesByGroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_POPULAR_TITLES_BY_GROUP");

            entity.Property(e => e.BgName)
                .HasMaxLength(75)
                .HasColumnName("BG_NAME");
            entity.Property(e => e.CatNo).HasColumnName("CAT_NO");
            entity.Property(e => e.Total).HasColumnName("TOTAL");
        });

        modelBuilder.Entity<VReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_REPORT");

            entity.Property(e => e.AReport).HasColumnName("A_REPORT");
            entity.Property(e => e.AReportGroup).HasColumnName("A_REPORT_GROUP");
            entity.Property(e => e.AReportGroupDescription)
                .HasMaxLength(64)
                .HasColumnName("A_REPORT_GROUP_DESCRIPTION");
            entity.Property(e => e.ReportDescription)
                .HasMaxLength(500)
                .HasColumnName("REPORT_DESCRIPTION");
            entity.Property(e => e.ReportName)
                .HasMaxLength(80)
                .HasColumnName("REPORT_NAME");
        });

        modelBuilder.Entity<VReportAction>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_REPORT_ACTION");

            entity.Property(e => e.ActionInfo)
                .HasMaxLength(300)
                .HasColumnName("ACTION_INFO");
            entity.Property(e => e.ActionLabel)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("ACTION_LABEL");
            entity.Property(e => e.CatNo).HasColumnName("CAT_NO");
            entity.Property(e => e.SfSequence).HasColumnName("SF_SEQUENCE");
            entity.Property(e => e.UniqueNo).HasColumnName("UNIQUE_NO");
        });

        modelBuilder.Entity<VReportSummary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_REPORT_SUMMARY");

            entity.Property(e => e.CatNo).HasColumnName("CAT_NO");
            entity.Property(e => e.SfSequence).HasColumnName("SF_SEQUENCE");
            entity.Property(e => e.SummaryInfo)
                .HasMaxLength(300)
                .HasColumnName("SUMMARY_INFO");
            entity.Property(e => e.SummaryLabel)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("SUMMARY_LABEL");
            entity.Property(e => e.UniqueNo).HasColumnName("UNIQUE_NO");
        });

        modelBuilder.Entity<VReservation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_RESERVATION");

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

        modelBuilder.Entity<VReservationsCompleted>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_RESERVATIONS_COMPLETED");

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

        modelBuilder.Entity<VRiskAssessment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_RISK_ASSESSMENT");

            entity.Property(e => e.CatNo).HasColumnName("CAT_NO");
            entity.Property(e => e.MarcTag2027)
                .HasMaxLength(1000)
                .HasColumnName("MARC_TAG_2027");
            entity.Property(e => e.MarcTag2028)
                .HasMaxLength(1000)
                .HasColumnName("MARC_TAG_2028");
            entity.Property(e => e.MarcTag2029)
                .HasMaxLength(1000)
                .HasColumnName("MARC_TAG_2029");
            entity.Property(e => e.MarcTag2030)
                .HasMaxLength(1000)
                .HasColumnName("MARC_TAG_2030");
            entity.Property(e => e.MarcTag2031)
                .HasMaxLength(1000)
                .HasColumnName("MARC_TAG_2031");
        });

        modelBuilder.Entity<VRiskAssessmentDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_RISK_ASSESSMENT_DETAIL");

            entity.Property(e => e.CatNo).HasColumnName("CAT_NO");
            entity.Property(e => e.RiskDetail)
                .HasMaxLength(300)
                .HasColumnName("RISK_DETAIL");
            entity.Property(e => e.RiskLabel)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RISK_LABEL");
            entity.Property(e => e.SfSequence).HasColumnName("SF_SEQUENCE");
            entity.Property(e => e.UniqueNo).HasColumnName("UNIQUE_NO");
        });

        modelBuilder.Entity<VSeeAlsoAuth>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_SEE_ALSO_AUTH");

            entity.Property(e => e.AuthDatetime)
                .HasColumnType("datetime")
                .HasColumnName("AUTH_DATETIME");
            entity.Property(e => e.AuthHasSa)
                .HasMaxLength(1)
                .HasColumnName("AUTH_HAS_SA");
            entity.Property(e => e.AuthInd1)
                .HasMaxLength(1)
                .HasColumnName("AUTH_IND1");
            entity.Property(e => e.AuthInd2)
                .HasMaxLength(1)
                .HasColumnName("AUTH_IND2");
            entity.Property(e => e.AuthKeepNo).HasColumnName("AUTH_KEEP_NO");
            entity.Property(e => e.AuthKey)
                .HasMaxLength(200)
                .HasColumnName("AUTH_KEY");
            entity.Property(e => e.AuthLibGroup)
                .HasMaxLength(30)
                .HasColumnName("AUTH_LIB_GROUP");
            entity.Property(e => e.AuthMarc)
                .HasMaxLength(500)
                .HasColumnName("AUTH_MARC");
            entity.Property(e => e.AuthNo).HasColumnName("AUTH_NO");
            entity.Property(e => e.AuthNote)
                .HasMaxLength(1)
                .HasColumnName("AUTH_NOTE");
            entity.Property(e => e.AuthOper)
                .HasMaxLength(25)
                .HasColumnName("AUTH_OPER");
            entity.Property(e => e.AuthSecurity)
                .HasColumnType("decimal(2, 0)")
                .HasColumnName("AUTH_SECURITY");
            entity.Property(e => e.AuthSee).HasColumnName("AUTH_SEE");
            entity.Property(e => e.AuthSoundex)
                .HasMaxLength(90)
                .HasColumnName("AUTH_SOUNDEX");
            entity.Property(e => e.AuthTagNo).HasColumnName("AUTH_TAG_NO");
            entity.Property(e => e.AuthtempInd1).HasColumnName("AUTHTEMP_IND1");
            entity.Property(e => e.AuthtempInd2).HasColumnName("AUTHTEMP_IND2");
        });

        modelBuilder.Entity<VStat>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_STATS");

            entity.Property(e => e.StatsAreaCd)
                .HasMaxLength(8)
                .HasColumnName("STATS_AREA_CD");
            entity.Property(e => e.StatsBorClass)
                .HasMaxLength(10)
                .HasColumnName("STATS_BOR_CLASS");
            entity.Property(e => e.StatsBorGroup)
                .HasMaxLength(10)
                .HasColumnName("STATS_BOR_GROUP");
            entity.Property(e => e.StatsBorType)
                .HasMaxLength(3)
                .HasColumnName("STATS_BOR_TYPE");
            entity.Property(e => e.StatsCount).HasColumnName("STATS_COUNT");
            entity.Property(e => e.StatsDate)
                .HasColumnType("datetime")
                .HasColumnName("STATS_DATE");
            entity.Property(e => e.StatsDay).HasColumnName("STATS_DAY");
            entity.Property(e => e.StatsHour).HasColumnName("STATS_HOUR");
            entity.Property(e => e.StatsLlCode)
                .HasMaxLength(20)
                .HasColumnName("STATS_LL_CODE");
            entity.Property(e => e.StatsMoney)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("STATS_MONEY");
            entity.Property(e => e.StatsMonth).HasColumnName("STATS_MONTH");
            entity.Property(e => e.StatsStkCode)
                .HasMaxLength(6)
                .HasColumnName("STATS_STK_CODE");
            entity.Property(e => e.StatsStkForm)
                .HasMaxLength(3)
                .HasColumnName("STATS_STK_FORM");
            entity.Property(e => e.StatsSuburb)
                .HasMaxLength(4)
                .HasColumnName("STATS_SUBURB");
            entity.Property(e => e.StatsType).HasColumnName("STATS_TYPE");
            entity.Property(e => e.StatsUnique)
                .HasMaxLength(150)
                .HasColumnName("STATS_UNIQUE");
            entity.Property(e => e.StatsWard)
                .HasMaxLength(4)
                .HasColumnName("STATS_WARD");
            entity.Property(e => e.StatsYear).HasColumnName("STATS_YEAR");
        });

        modelBuilder.Entity<VStatsCode>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_STATS_CODES");

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

        modelBuilder.Entity<VStkBookingEvent>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_STK_BOOKING_EVENT");

            entity.Property(e => e.Anticipatedgrade)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ANTICIPATEDGRADE");
            entity.Property(e => e.BorBarNo)
                .HasMaxLength(75)
                .HasColumnName("BOR_BAR_NO");
            entity.Property(e => e.CancellationFee)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("CANCELLATION_FEE");
            entity.Property(e => e.Fee)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("FEE");
            entity.Property(e => e.Notes)
                .IsUnicode(false)
                .HasColumnName("NOTES");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.StkItem)
                .HasMaxLength(25)
                .HasColumnName("STK_ITEM");
            entity.Property(e => e.UniqueItemNo).HasColumnName("UNIQUE_ITEM_NO");
        });

        modelBuilder.Entity<VStkCode>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_STK_CODES");

            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");
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

        modelBuilder.Entity<VStkDefault>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_STK_DEFAULT");

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
            entity.Property(e => e.BorNoVisits).HasColumnName("BOR_NO_VISITS");
            entity.Property(e => e.BorOper)
                .HasMaxLength(25)
                .HasColumnName("BOR_OPER");
            entity.Property(e => e.BorOwing)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("BOR_OWING");
            entity.Property(e => e.BorPicData).HasColumnName("BOR_PIC_DATA");
            entity.Property(e => e.BorPicFilename)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BOR_PIC_FILENAME");
            entity.Property(e => e.BorPicType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BOR_PIC_TYPE");
            entity.Property(e => e.BorPin)
                .HasMaxLength(25)
                .HasColumnName("BOR_PIN");
            entity.Property(e => e.BorRef1)
                .HasMaxLength(75)
                .HasColumnName("BOR_REF1");
            entity.Property(e => e.BorRef2)
                .HasMaxLength(150)
                .HasColumnName("BOR_REF2");
            entity.Property(e => e.BorRegdate).HasColumnName("BOR_REGDATE");
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
            entity.Property(e => e.StkCode)
                .HasMaxLength(6)
                .HasColumnName("STK_CODE");
            entity.Property(e => e.StkCodeDesc)
                .HasMaxLength(50)
                .HasColumnName("STK_CODE_DESC");
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
            entity.Property(e => e.StkFormDesc)
                .HasMaxLength(25)
                .HasColumnName("STK_FORM_DESC");
            entity.Property(e => e.StkGroup)
                .HasMaxLength(3)
                .HasColumnName("STK_GROUP");
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
            entity.Property(e => e.StkJournalSearchShowyn)
                .HasMaxLength(1)
                .HasColumnName("STK_JOURNAL_SEARCH_SHOWYN");
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
            entity.Property(e => e.StkProcess)
                .HasMaxLength(20)
                .HasColumnName("STK_PROCESS");
            entity.Property(e => e.StkProcessDate)
                .HasColumnType("datetime")
                .HasColumnName("STK_PROCESS_DATE");
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
            entity.Property(e => e.StkcodeStkAllowLoan)
                .HasMaxLength(1)
                .HasColumnName("STKCODE_STK_ALLOW_LOAN");
            entity.Property(e => e.StkcodeStkFloating)
                .HasMaxLength(1)
                .HasColumnName("STKCODE_STK_FLOATING");
            entity.Property(e => e.StkformStkAllowLoan)
                .HasMaxLength(1)
                .HasColumnName("STKFORM_STK_ALLOW_LOAN");
            entity.Property(e => e.StkformStkFloating)
                .HasMaxLength(1)
                .HasColumnName("STKFORM_STK_FLOATING");
            entity.Property(e => e.StkformStkform)
                .HasMaxLength(3)
                .HasColumnName("STKFORM_STKFORM");
            entity.Property(e => e.StkitemStkForm)
                .HasMaxLength(3)
                .HasColumnName("STKITEM_STK_FORM");
            entity.Property(e => e.UniqueItemNo).HasColumnName("UNIQUE_ITEM_NO");
        });

        modelBuilder.Entity<VStkForm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_STK_FORMS");

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
            entity.Property(e => e.StkForm)
                .HasMaxLength(3)
                .HasColumnName("STK_FORM");
            entity.Property(e => e.StkFormDesc)
                .HasMaxLength(25)
                .HasColumnName("STK_FORM_DESC");
            entity.Property(e => e.StkIsDiary)
                .HasMaxLength(1)
                .HasColumnName("STK_IS_DIARY");
            entity.Property(e => e.StkIsevent)
                .HasMaxLength(1)
                .HasColumnName("STK_ISEVENT");
            entity.Property(e => e.StkIsrecurringfee)
                .HasMaxLength(1)
                .HasColumnName("STK_ISRECURRINGFEE");
        });

        modelBuilder.Entity<VStkHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_STK_HISTORY");

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

        modelBuilder.Entity<VStkHistoryReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_STK_HISTORY_REPORT");

            entity.Property(e => e.ShBorNo)
                .HasMaxLength(75)
                .HasColumnName("SH_BOR_NO");
            entity.Property(e => e.ShComments)
                .HasMaxLength(509)
                .HasColumnName("SH_COMMENTS");
            entity.Property(e => e.ShDate)
                .HasColumnType("datetime")
                .HasColumnName("SH_DATE");
            entity.Property(e => e.ShResNo).HasColumnName("SH_RES_NO");
            entity.Property(e => e.ShStkItemNo)
                .HasMaxLength(25)
                .HasColumnName("SH_STK_ITEM_NO");
            entity.Property(e => e.ShType)
                .HasMaxLength(10)
                .HasColumnName("SH_TYPE");
            entity.Property(e => e.ShValue)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("SH_VALUE");
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
                .HasMaxLength(100)
                .HasColumnName("STK_DESCRIPTION");
            entity.Property(e => e.StkEdition)
                .HasMaxLength(8)
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
                .HasMaxLength(20)
                .HasColumnName("STK_LOC_FLOOR");
            entity.Property(e => e.StkLocPerm)
                .HasMaxLength(20)
                .HasColumnName("STK_LOC_PERM");
            entity.Property(e => e.StkLocTemp)
                .HasMaxLength(20)
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
            entity.Property(e => e.StkProcess)
                .HasMaxLength(20)
                .HasColumnName("STK_PROCESS");
            entity.Property(e => e.StkProcessDate)
                .HasColumnType("datetime")
                .HasColumnName("STK_PROCESS_DATE");
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
                .HasMaxLength(8)
                .HasColumnName("STK_VOLUME");
            entity.Property(e => e.UniqueItemNo).HasColumnName("UNIQUE_ITEM_NO");
        });

        modelBuilder.Entity<VStkIll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_STK_ILL");

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

        modelBuilder.Entity<VStkItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_STK_ITEM");

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
            entity.Property(e => e.StkQrData).HasColumnName("STK_QR_DATA");
            entity.Property(e => e.StkQrType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STK_QR_TYPE");
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

        modelBuilder.Entity<VStkItem880>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_STK_ITEM_880");

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
            entity.Property(e => e.UniqueItemNo).HasColumnName("UNIQUE_ITEM_NO");
        });

        modelBuilder.Entity<VStkItemAtEndOfRotation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_STK_ITEM_AT_END_OF_ROTATION");

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
                .HasMaxLength(40)
                .HasColumnName("STK_LOC_FLOOR");
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

        modelBuilder.Entity<VStkItemCount>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_STK_ITEM_COUNTS");

            entity.Property(e => e.IsMissing).HasColumnName("IS_MISSING");
            entity.Property(e => e.OnLoan).HasColumnName("ON_LOAN");
            entity.Property(e => e.OnOrder).HasColumnName("ON_ORDER");
            entity.Property(e => e.Overdue).HasColumnName("OVERDUE");
            entity.Property(e => e.Reserved).HasColumnName("RESERVED");
            entity.Property(e => e.StkLocPerm)
                .HasMaxLength(40)
                .HasColumnName("STK_LOC_PERM");
        });

        modelBuilder.Entity<VStkItemMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_STK_ITEM_MASTER");

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
                .HasMaxLength(40)
                .HasColumnName("STK_LOC_FLOOR");
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

        modelBuilder.Entity<VStkItemPotentialCharge>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_STK_ITEM_POTENTIAL_CHARGE");

            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");
            entity.Property(e => e.BorPotentialCharge)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("BOR_POTENTIAL_CHARGE");
            entity.Property(e => e.LastUpdatedTime)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATED_TIME");
            entity.Property(e => e.UniqueItemNo).HasColumnName("UNIQUE_ITEM_NO");
        });

        modelBuilder.Entity<VStkMemo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_STK_MEMOS");

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

        modelBuilder.Entity<VStkRotationPlan>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_STK_ROTATION_PLAN");

            entity.Property(e => e.RotationName)
                .HasMaxLength(50)
                .HasColumnName("ROTATION_NAME");
            entity.Property(e => e.RotationPlanId).HasColumnName("ROTATION_PLAN_ID");
        });

        modelBuilder.Entity<VStkRotationSequence>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_STK_ROTATION_SEQUENCE");

            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");
            entity.Property(e => e.Period).HasColumnName("PERIOD");
            entity.Property(e => e.PeriodUnit).HasColumnName("PERIOD_UNIT");
            entity.Property(e => e.RotationPlanId).HasColumnName("ROTATION_PLAN_ID");
            entity.Property(e => e.SequenceNo).HasColumnName("SEQUENCE_NO");
        });

        modelBuilder.Entity<VStkSubscriber>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_STK_SUBSCRIBER");

            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");
            entity.Property(e => e.CreateDatetime).HasColumnName("CREATE_DATETIME");
            entity.Property(e => e.UniqueItemNo).HasColumnName("UNIQUE_ITEM_NO");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(75)
                .HasColumnName("UPDATED_BY");
        });

        modelBuilder.Entity<VSuburb>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_SUBURB");

            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");
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

        modelBuilder.Entity<VSurvey>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_SURVEY");

            entity.Property(e => e.AllowComment)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("ALLOW_COMMENT");
            entity.Property(e => e.Allowhidedetails)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("ALLOWHIDEDETAILS");
            entity.Property(e => e.Comment).HasColumnName("COMMENT");
            entity.Property(e => e.Completeallquestions)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("COMPLETEALLQUESTIONS");
            entity.Property(e => e.ConclusionUrl)
                .HasMaxLength(500)
                .HasColumnName("CONCLUSION_URL");
            entity.Property(e => e.CreationDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATION_DATE");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("END_DATE");
            entity.Property(e => e.Inlinedisplay)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("INLINEDISPLAY");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATED");
            entity.Property(e => e.Libgroup)
                .HasMaxLength(50)
                .HasColumnName("LIBGROUP");
            entity.Property(e => e.Libloc)
                .HasMaxLength(50)
                .HasColumnName("LIBLOC");
            entity.Property(e => e.MasterFlag)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("MASTER_FLAG");
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
            entity.Property(e => e.Restricted)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("RESTRICTED");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("START_DATE");
            entity.Property(e => e.StatusId).HasColumnName("STATUS_ID");
            entity.Property(e => e.SummaryUrl)
                .HasMaxLength(500)
                .HasColumnName("SUMMARY_URL");
            entity.Property(e => e.SurveyDescription).HasColumnName("SURVEY_DESCRIPTION");
            entity.Property(e => e.SurveyId).HasColumnName("SURVEY_ID");
            entity.Property(e => e.SurveyTitle)
                .HasMaxLength(1000)
                .HasColumnName("SURVEY_TITLE");
            entity.Property(e => e.Type).HasColumnName("TYPE");
        });

        modelBuilder.Entity<VSurveyAnswer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_SURVEY_ANSWER");

            entity.Property(e => e.AnswerId).HasColumnName("ANSWER_ID");
            entity.Property(e => e.AnswerText).HasColumnName("ANSWER_TEXT");
            entity.Property(e => e.AnswerText2)
                .HasColumnType("ntext")
                .HasColumnName("ANSWER_TEXT2");
            entity.Property(e => e.AnswerValue).HasColumnName("ANSWER_VALUE");
            entity.Property(e => e.NextQuestionId).HasColumnName("NEXT_QUESTION_ID");
            entity.Property(e => e.NextSurveyId).HasColumnName("NEXT_SURVEY_ID");
            entity.Property(e => e.Other)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("OTHER");
            entity.Property(e => e.QuestionId).HasColumnName("QUESTION_ID");
            entity.Property(e => e.SurveyId).HasColumnName("SURVEY_ID");
        });

        modelBuilder.Entity<VSurveyQuestion>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_SURVEY_QUESTION");

            entity.Property(e => e.Benchmark).HasColumnName("BENCHMARK");
            entity.Property(e => e.Note).HasColumnName("NOTE");
            entity.Property(e => e.QuestionId).HasColumnName("QUESTION_ID");
            entity.Property(e => e.QuestionNote)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("QUESTION_NOTE");
            entity.Property(e => e.QuestionText).HasColumnName("QUESTION_TEXT");
            entity.Property(e => e.QuestionType).HasColumnName("QUESTION_TYPE");
            entity.Property(e => e.SurveyId).HasColumnName("SURVEY_ID");
            entity.Property(e => e.Weighting).HasColumnName("WEIGHTING");
        });

        modelBuilder.Entity<VSurveyResponse>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_SURVEY_RESPONSE");

            entity.Property(e => e.AnonymousId).HasColumnName("ANONYMOUS_ID");
            entity.Property(e => e.AnswerId).HasColumnName("ANSWER_ID");
            entity.Property(e => e.ApprovalDate)
                .HasColumnType("datetime")
                .HasColumnName("APPROVAL_DATE");
            entity.Property(e => e.Approve)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("APPROVE");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(50)
                .HasColumnName("APPROVED_BY");
            entity.Property(e => e.Other)
                .HasMaxLength(500)
                .HasColumnName("OTHER");
            entity.Property(e => e.QuestionId).HasColumnName("QUESTION_ID");
            entity.Property(e => e.SerialNum).HasColumnName("SERIAL_NUM");
            entity.Property(e => e.SurveyId).HasColumnName("SURVEY_ID");
            entity.Property(e => e.UserId).HasColumnName("USER_ID");
        });

        modelBuilder.Entity<VSurveyRestriction>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_SURVEY_RESTRICTION");

            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");
            entity.Property(e => e.DatetimeSent)
                .HasColumnType("datetime")
                .HasColumnName("DATETIME_SENT");
            entity.Property(e => e.Sentyn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SENTYN");
            entity.Property(e => e.SurveyId).HasColumnName("SURVEY_ID");
        });

        modelBuilder.Entity<VSurveyStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_SURVEY_STATUS");

            entity.Property(e => e.StatusDescription)
                .HasMaxLength(1000)
                .HasColumnName("STATUS_DESCRIPTION");
            entity.Property(e => e.StatusId).HasColumnName("STATUS_ID");
            entity.Property(e => e.StatusName)
                .HasMaxLength(500)
                .HasColumnName("STATUS_NAME");
        });

        modelBuilder.Entity<VSurveyType>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_SURVEY_TYPE");

            entity.Property(e => e.BorMembershipSurvey)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("BOR_MEMBERSHIP_SURVEY");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.TypeId).HasColumnName("TYPE_ID");
        });

        modelBuilder.Entity<VSurveyTypeTranslation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_SURVEY_TYPE_TRANSLATION");

            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.TypeId).HasColumnName("TYPE_ID");
        });

        modelBuilder.Entity<VTagTagdef>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_TAG_TAGDEF");

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

        modelBuilder.Entity<VUserClass>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_USER_CLASS");

            entity.Property(e => e.BcClass)
                .HasMaxLength(10)
                .HasColumnName("BC_CLASS");
            entity.Property(e => e.BcName)
                .HasMaxLength(75)
                .HasColumnName("BC_NAME");
            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");
            entity.Property(e => e.CtId).HasColumnName("CT_ID");
            entity.Property(e => e.CtName)
                .HasMaxLength(75)
                .HasColumnName("CT_NAME");
            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");
        });

        modelBuilder.Entity<VUserGroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_USER_GROUP");

            entity.Property(e => e.BgGroup)
                .HasMaxLength(10)
                .HasColumnName("BG_GROUP");
            entity.Property(e => e.BgName)
                .HasMaxLength(75)
                .HasColumnName("BG_NAME");
            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");
            entity.Property(e => e.GtId).HasColumnName("GT_ID");
            entity.Property(e => e.GtName)
                .HasMaxLength(75)
                .HasColumnName("GT_NAME");
            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");
        });

        modelBuilder.Entity<VVduAssessment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_VDU_ASSESSMENT");

            entity.Property(e => e.CatNo).HasColumnName("CAT_NO");
            entity.Property(e => e._2015a)
                .HasMaxLength(300)
                .HasColumnName("2015a");
            entity.Property(e => e._2015b)
                .HasMaxLength(300)
                .HasColumnName("2015b");
            entity.Property(e => e._2015c)
                .HasMaxLength(300)
                .HasColumnName("2015c");
            entity.Property(e => e._2016a)
                .HasMaxLength(300)
                .HasColumnName("2016a");
            entity.Property(e => e._2016b)
                .HasMaxLength(300)
                .HasColumnName("2016b");
            entity.Property(e => e._2016c)
                .HasMaxLength(300)
                .HasColumnName("2016c");
            entity.Property(e => e._2016d)
                .HasMaxLength(300)
                .HasColumnName("2016d");
            entity.Property(e => e._2017a)
                .HasMaxLength(300)
                .HasColumnName("2017a");
            entity.Property(e => e._2017b)
                .HasMaxLength(300)
                .HasColumnName("2017b");
            entity.Property(e => e._2017c)
                .HasMaxLength(300)
                .HasColumnName("2017c");
            entity.Property(e => e._2017d)
                .HasMaxLength(300)
                .HasColumnName("2017d");
            entity.Property(e => e._2018a)
                .HasMaxLength(300)
                .HasColumnName("2018a");
            entity.Property(e => e._2018b)
                .HasMaxLength(300)
                .HasColumnName("2018b");
            entity.Property(e => e._2018c)
                .HasMaxLength(300)
                .HasColumnName("2018c");
            entity.Property(e => e._2018d)
                .HasMaxLength(300)
                .HasColumnName("2018d");
            entity.Property(e => e._2019a)
                .HasMaxLength(300)
                .HasColumnName("2019a");
            entity.Property(e => e._2019b)
                .HasMaxLength(300)
                .HasColumnName("2019b");
            entity.Property(e => e._2019c)
                .HasMaxLength(300)
                .HasColumnName("2019c");
            entity.Property(e => e._2019d)
                .HasMaxLength(300)
                .HasColumnName("2019d");
            entity.Property(e => e._2019e)
                .HasMaxLength(300)
                .HasColumnName("2019e");
            entity.Property(e => e._2019f)
                .HasMaxLength(300)
                .HasColumnName("2019f");
            entity.Property(e => e._2020a)
                .HasMaxLength(300)
                .HasColumnName("2020a");
            entity.Property(e => e._2020b)
                .HasMaxLength(300)
                .HasColumnName("2020b");
            entity.Property(e => e._2021a)
                .HasMaxLength(300)
                .HasColumnName("2021a");
            entity.Property(e => e._2021b)
                .HasMaxLength(300)
                .HasColumnName("2021b");
            entity.Property(e => e._2022a)
                .HasMaxLength(300)
                .HasColumnName("2022a");
            entity.Property(e => e._2022b)
                .HasMaxLength(300)
                .HasColumnName("2022b");
            entity.Property(e => e._2023a)
                .HasMaxLength(300)
                .HasColumnName("2023a");
            entity.Property(e => e._2023b)
                .HasMaxLength(300)
                .HasColumnName("2023b");
            entity.Property(e => e._2024a)
                .HasMaxLength(300)
                .HasColumnName("2024a");
            entity.Property(e => e._2025a)
                .HasMaxLength(300)
                .HasColumnName("2025a");
            entity.Property(e => e._2025b)
                .HasMaxLength(300)
                .HasColumnName("2025b");
            entity.Property(e => e._2025c)
                .HasMaxLength(300)
                .HasColumnName("2025c");
            entity.Property(e => e._2025d)
                .HasMaxLength(300)
                .HasColumnName("2025d");
            entity.Property(e => e._2025e)
                .HasMaxLength(300)
                .HasColumnName("2025e");
            entity.Property(e => e._2025f)
                .HasMaxLength(300)
                .HasColumnName("2025f");
            entity.Property(e => e._2025g)
                .HasMaxLength(300)
                .HasColumnName("2025g");
            entity.Property(e => e._2025h)
                .HasMaxLength(300)
                .HasColumnName("2025h");
            entity.Property(e => e._2026a)
                .HasMaxLength(300)
                .HasColumnName("2026a");
            entity.Property(e => e._2026b)
                .HasMaxLength(300)
                .HasColumnName("2026b");
            entity.Property(e => e._2026c)
                .HasMaxLength(300)
                .HasColumnName("2026c");
            entity.Property(e => e._2026d)
                .HasMaxLength(300)
                .HasColumnName("2026d");
        });

        modelBuilder.Entity<VVduAssessmentForm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_VDU_ASSESSMENT_FORM");

            entity.Property(e => e.CatNo).HasColumnName("CAT_NO");
            entity.Property(e => e.Mt2015a)
                .HasMaxLength(300)
                .HasColumnName("MT_2015a");
            entity.Property(e => e.Mt2015b)
                .HasMaxLength(300)
                .HasColumnName("MT_2015b");
            entity.Property(e => e.Mt2015c)
                .HasMaxLength(300)
                .HasColumnName("MT_2015c");
            entity.Property(e => e.Mt2016a)
                .HasMaxLength(300)
                .HasColumnName("MT_2016a");
            entity.Property(e => e.Mt2016b)
                .HasMaxLength(300)
                .HasColumnName("MT_2016b");
            entity.Property(e => e.Mt2016c)
                .HasMaxLength(300)
                .HasColumnName("MT_2016c");
            entity.Property(e => e.Mt2016d)
                .HasMaxLength(300)
                .HasColumnName("MT_2016d");
            entity.Property(e => e.Mt2017a)
                .HasMaxLength(300)
                .HasColumnName("MT_2017a");
            entity.Property(e => e.Mt2017b)
                .HasMaxLength(300)
                .HasColumnName("MT_2017b");
            entity.Property(e => e.Mt2017c)
                .HasMaxLength(300)
                .HasColumnName("MT_2017c");
            entity.Property(e => e.Mt2017d)
                .HasMaxLength(300)
                .HasColumnName("MT_2017d");
            entity.Property(e => e.Mt2018a)
                .HasMaxLength(300)
                .HasColumnName("MT_2018a");
            entity.Property(e => e.Mt2018b)
                .HasMaxLength(300)
                .HasColumnName("MT_2018b");
            entity.Property(e => e.Mt2018c)
                .HasMaxLength(300)
                .HasColumnName("MT_2018c");
            entity.Property(e => e.Mt2018d)
                .HasMaxLength(300)
                .HasColumnName("MT_2018d");
            entity.Property(e => e.Mt2019a)
                .HasMaxLength(300)
                .HasColumnName("MT_2019a");
            entity.Property(e => e.Mt2019b)
                .HasMaxLength(300)
                .HasColumnName("MT_2019b");
            entity.Property(e => e.Mt2019c)
                .HasMaxLength(300)
                .HasColumnName("MT_2019c");
            entity.Property(e => e.Mt2019d)
                .HasMaxLength(300)
                .HasColumnName("MT_2019d");
            entity.Property(e => e.Mt2019e)
                .HasMaxLength(300)
                .HasColumnName("MT_2019e");
            entity.Property(e => e.Mt2019f)
                .HasMaxLength(300)
                .HasColumnName("MT_2019f");
            entity.Property(e => e.Mt2020a)
                .HasMaxLength(300)
                .HasColumnName("MT_2020a");
            entity.Property(e => e.Mt2020b)
                .HasMaxLength(300)
                .HasColumnName("MT_2020b");
            entity.Property(e => e.Mt2021a)
                .HasMaxLength(300)
                .HasColumnName("MT_2021a");
            entity.Property(e => e.Mt2021b)
                .HasMaxLength(300)
                .HasColumnName("MT_2021b");
            entity.Property(e => e.Mt2022a)
                .HasMaxLength(300)
                .HasColumnName("MT_2022a");
            entity.Property(e => e.Mt2022b)
                .HasMaxLength(300)
                .HasColumnName("MT_2022b");
            entity.Property(e => e.Mt2023a)
                .HasMaxLength(300)
                .HasColumnName("MT_2023a");
            entity.Property(e => e.Mt2023b)
                .HasMaxLength(300)
                .HasColumnName("MT_2023b");
            entity.Property(e => e.Mt2024a)
                .HasMaxLength(300)
                .HasColumnName("MT_2024a");
            entity.Property(e => e.Mt2025a)
                .HasMaxLength(300)
                .HasColumnName("MT_2025a");
            entity.Property(e => e.Mt2025b)
                .HasMaxLength(300)
                .HasColumnName("MT_2025b");
            entity.Property(e => e.Mt2025c)
                .HasMaxLength(300)
                .HasColumnName("MT_2025c");
            entity.Property(e => e.Mt2025d)
                .HasMaxLength(300)
                .HasColumnName("MT_2025d");
            entity.Property(e => e.Mt2025e)
                .HasMaxLength(300)
                .HasColumnName("MT_2025e");
            entity.Property(e => e.Mt2025f)
                .HasMaxLength(300)
                .HasColumnName("MT_2025f");
            entity.Property(e => e.Mt2025g)
                .HasMaxLength(300)
                .HasColumnName("MT_2025g");
            entity.Property(e => e.Mt2025h)
                .HasMaxLength(300)
                .HasColumnName("MT_2025h");
            entity.Property(e => e.Mt2026a)
                .HasMaxLength(300)
                .HasColumnName("MT_2026a");
            entity.Property(e => e.Mt2026b)
                .HasMaxLength(300)
                .HasColumnName("MT_2026b");
            entity.Property(e => e.Mt2026c)
                .HasMaxLength(300)
                .HasColumnName("MT_2026c");
            entity.Property(e => e.Mt2026d)
                .HasMaxLength(300)
                .HasColumnName("MT_2026d");
        });

        modelBuilder.Entity<VVisited2year>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_VISITED_2YEARS");

            entity.Property(e => e.BorBarNo)
                .HasMaxLength(75)
                .HasColumnName("bor_bar_no");
            entity.Property(e => e.Name)
                .HasMaxLength(193)
                .HasColumnName("NAME");
            entity.Property(e => e.VisitedTotal).HasColumnName("visited_total");
        });

        modelBuilder.Entity<VWaiveTran>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_WAIVE_TRANS");

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

        modelBuilder.Entity<VWard>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_WARD");

            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");
            entity.Property(e => e.WardCode)
                .HasMaxLength(3)
                .HasColumnName("WARD_CODE");
            entity.Property(e => e.WardName)
                .HasMaxLength(75)
                .HasColumnName("WARD_NAME");
        });

        modelBuilder.Entity<View6xxMarcTag>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_6XX_MARC_TAG");

            entity.Property(e => e.CatNo).HasColumnName("cat_no");
            entity.Property(e => e.MarcTag610)
                .IsUnicode(false)
                .HasColumnName("MARC_TAG_610");
            entity.Property(e => e.MarcTag650)
                .IsUnicode(false)
                .HasColumnName("MARC_TAG_650");
            entity.Property(e => e.MarcTag651)
                .IsUnicode(false)
                .HasColumnName("MARC_TAG_651");
        });

        modelBuilder.Entity<WebAppDataLong>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WEB_APP_DATA_LONG");

            entity.HasIndex(e => new { e.WebDate, e.WebApp }, "WEB_ALDATEX");

            entity.HasIndex(e => new { e.WebSerial, e.WebApp, e.WebSet }, "WEB_ALSERIALX");

            entity.Property(e => e.WebApp)
                .HasMaxLength(3)
                .HasColumnName("WEB_APP");
            entity.Property(e => e.WebDate)
                .HasColumnType("datetime")
                .HasColumnName("WEB_DATE");
            entity.Property(e => e.WebSerial).HasColumnName("WEB_SERIAL");
            entity.Property(e => e.WebSet)
                .HasMaxLength(12)
                .HasColumnName("WEB_SET");
            entity.Property(e => e.WebString)
                .HasColumnType("ntext")
                .HasColumnName("WEB_STRING");
        });

        modelBuilder.Entity<WebAppDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WEB_APP_DATA");

            entity.HasIndex(e => new { e.WebDate, e.WebApp }, "WEB_ADATEX");

            entity.HasIndex(e => new { e.WebSerial, e.WebApp, e.WebSet }, "WEB_ASERIALX");

            entity.Property(e => e.WebApp)
                .HasMaxLength(3)
                .HasColumnName("WEB_APP");
            entity.Property(e => e.WebDate)
                .HasColumnType("datetime")
                .HasColumnName("WEB_DATE");
            entity.Property(e => e.WebSerial).HasColumnName("WEB_SERIAL");
            entity.Property(e => e.WebSet)
                .HasMaxLength(12)
                .HasColumnName("WEB_SET");
            entity.Property(e => e.WebString)
                .HasMaxLength(240)
                .HasColumnName("WEB_STRING");
        });

        modelBuilder.Entity<WebAppSession>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WEB_APP_SESSION");

            entity.Property(e => e.WebApp)
                .HasMaxLength(3)
                .HasColumnName("WEB_APP");
            entity.Property(e => e.WebAppClosed)
                .HasMaxLength(1)
                .HasColumnName("WEB_APP_CLOSED");
            entity.Property(e => e.WebDate)
                .HasColumnType("datetime")
                .HasColumnName("WEB_DATE");
            entity.Property(e => e.WebId)
                .HasMaxLength(110)
                .HasColumnName("WEB_ID");
            entity.Property(e => e.WebReload)
                .HasMaxLength(1)
                .HasColumnName("WEB_RELOAD");
            entity.Property(e => e.WebSession).HasColumnName("WEB_SESSION");
            entity.Property(e => e.WebStartSession)
                .HasColumnType("datetime")
                .HasColumnName("WEB_START_SESSION");
        });

        modelBuilder.Entity<WebAppSystab>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WEB_APP_SYSTAB");

            entity.Property(e => e.WebSerial).HasColumnName("WEB_SERIAL");
        });

        modelBuilder.Entity<WebDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WEB_DATA");

            entity.HasIndex(e => e.WebDate, "WB_DATEX");

            entity.HasIndex(e => e.WebSerial, "WB_SERIALX");

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

        modelBuilder.Entity<WebSystab>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WEB_SYSTAB");

            entity.Property(e => e.WebSerial).HasColumnName("WEB_SERIAL");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

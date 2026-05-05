using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Lms.Data.Models.Decat;

public partial class DecatContext : DbContext
{
    public DecatContext()
    {
    }

    public DecatContext(DbContextOptions<DecatContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AAuthPicture> AAuthPictures { get; set; }

    public virtual DbSet<ACatPicGallery> ACatPicGalleries { get; set; }

    public virtual DbSet<ACatPicture> ACatPictures { get; set; }

    public virtual DbSet<AdAuthority> AdAuthorities { get; set; }

    public virtual DbSet<AdCatMarcLong> AdCatMarcLongs { get; set; }

    public virtual DbSet<AdCatalogue> AdCatalogues { get; set; }

    public virtual DbSet<AuSystab> AuSystabs { get; set; }

    public virtual DbSet<AuthFileImport> AuthFileImports { get; set; }

    public virtual DbSet<AuthFileImportHdr> AuthFileImportHdrs { get; set; }

    public virtual DbSet<AuthFileImportList> AuthFileImportLists { get; set; }

    public virtual DbSet<AuthKeyword> AuthKeywords { get; set; }

    public virtual DbSet<AuthNote> AuthNotes { get; set; }

    public virtual DbSet<AuthSeeAlso> AuthSeeAlsos { get; set; }

    public virtual DbSet<AuthSeeAlso1> AuthSeeAlsos1 { get; set; }

    public virtual DbSet<Authority> Authorities { get; set; }

    public virtual DbSet<Authority1> Authorities1 { get; set; }

    public virtual DbSet<AuthorityChild> AuthorityChildren { get; set; }

    public virtual DbSet<BorSubject> BorSubjects { get; set; }

    public virtual DbSet<CatAllword> CatAllwords { get; set; }

    public virtual DbSet<CatDate> CatDates { get; set; }

    public virtual DbSet<CatLong> CatLongs { get; set; }

    public virtual DbSet<CatMaint> CatMaints { get; set; }

    public virtual DbSet<CatMarcLong> CatMarcLongs { get; set; }

    public virtual DbSet<CatSf> CatSfs { get; set; }

    public virtual DbSet<CatSystab> CatSystabs { get; set; }

    public virtual DbSet<CatTag> CatTags { get; set; }

    public virtual DbSet<Catalogue> Catalogues { get; set; }

    public virtual DbSet<CatalogueElectronic> CatalogueElectronics { get; set; }

    public virtual DbSet<CatalogueRef> CatalogueRefs { get; set; }

    public virtual DbSet<CatdisplayTag> CatdisplayTags { get; set; }

    public virtual DbSet<CiAdAuthority> CiAdAuthorities { get; set; }

    public virtual DbSet<CiAuSystab> CiAuSystabs { get; set; }

    public virtual DbSet<CiAuthKeyword> CiAuthKeywords { get; set; }

    public virtual DbSet<CiAuthNote> CiAuthNotes { get; set; }

    public virtual DbSet<CiAuthSeeAlso> CiAuthSeeAlsos { get; set; }

    public virtual DbSet<CiAuthority> CiAuthorities { get; set; }

    public virtual DbSet<CiCatAllword> CiCatAllwords { get; set; }

    public virtual DbSet<CiCatLong> CiCatLongs { get; set; }

    public virtual DbSet<CiCatSf> CiCatSfs { get; set; }

    public virtual DbSet<CiCatSystab> CiCatSystabs { get; set; }

    public virtual DbSet<CiCatTag> CiCatTags { get; set; }

    public virtual DbSet<CiCatalogue> CiCatalogues { get; set; }

    public virtual DbSet<CiCatalogueRef> CiCatalogueRefs { get; set; }

    public virtual DbSet<CiSfDatum> CiSfData { get; set; }

    public virtual DbSet<CiSfSystab> CiSfSystabs { get; set; }

    public virtual DbSet<CiWebAppDatum> CiWebAppData { get; set; }

    public virtual DbSet<CiWebAppLong> CiWebAppLongs { get; set; }

    public virtual DbSet<CiWebAppSession> CiWebAppSessions { get; set; }

    public virtual DbSet<CiWebAppSystab> CiWebAppSystabs { get; set; }

    public virtual DbSet<CiWebDatum> CiWebData { get; set; }

    public virtual DbSet<CiWebSystab> CiWebSystabs { get; set; }

    public virtual DbSet<DynamicPageTemplate> DynamicPageTemplates { get; set; }

    public virtual DbSet<DynamicWebpage> DynamicWebpages { get; set; }

    public virtual DbSet<DynamicWebpagesTranslation> DynamicWebpagesTranslations { get; set; }

    public virtual DbSet<FileCatDatum> FileCatData { get; set; }

    public virtual DbSet<FileCatName> FileCatNames { get; set; }

    public virtual DbSet<FileCatSystab> FileCatSystabs { get; set; }

    public virtual DbSet<FileKeyword> FileKeywords { get; set; }

    public virtual DbSet<FileKwOper> FileKwOpers { get; set; }

    public virtual DbSet<Helpdesk> Helpdesks { get; set; }

    public virtual DbSet<ImportLog> ImportLogs { get; set; }

    public virtual DbSet<MauritiusFileList> MauritiusFileLists { get; set; }

    public virtual DbSet<MissingMarcTag> MissingMarcTags { get; set; }

    public virtual DbSet<Number> Numbers { get; set; }

    public virtual DbSet<QueryStatus> QueryStatuses { get; set; }

    public virtual DbSet<Series> Series { get; set; }

    public virtual DbSet<SfDatum> SfData { get; set; }

    public virtual DbSet<SfSystab> SfSystabs { get; set; }

    public virtual DbSet<TempCatMarcImport> TempCatMarcImports { get; set; }

    public virtual DbSet<TempCatMarcImportDetail> TempCatMarcImportDetails { get; set; }

    public virtual DbSet<Tempno2401c> Tempno2401cs { get; set; }

    public virtual DbSet<Tempno2406c> Tempno2406cs { get; set; }

    public virtual DbSet<Tempno2410c> Tempno2410cs { get; set; }

    public virtual DbSet<UserKwCirc> UserKwCircs { get; set; }

    public virtual DbSet<UserKwConvert> UserKwConverts { get; set; }

    public virtual DbSet<UserKwJorge> UserKwJorges { get; set; }

    public virtual DbSet<UserKwNetopac> UserKwNetopacs { get; set; }

    public virtual DbSet<UserKwStaff> UserKwStaffs { get; set; }

    public virtual DbSet<UserKwSteel> UserKwSteels { get; set; }

    public virtual DbSet<UserKwTrevor> UserKwTrevors { get; set; }

    public virtual DbSet<VAuthority> VAuthorities { get; set; }

    public virtual DbSet<VAuthorityChild> VAuthorityChildren { get; set; }

    public virtual DbSet<VCatalogue> VCatalogues { get; set; }

    public virtual DbSet<VCatalogueDatum> VCatalogueData { get; set; }

    public virtual DbSet<VCatalogueIsbnstr> VCatalogueIsbnstrs { get; set; }

    public virtual DbSet<VisBackupCat> VisBackupCats { get; set; }

    public virtual DbSet<WebAppDataLong> WebAppDataLongs { get; set; }

    public virtual DbSet<WebAppDatum> WebAppData { get; set; }

    public virtual DbSet<WebAppSession> WebAppSessions { get; set; }

    public virtual DbSet<WebAppSystab> WebAppSystabs { get; set; }

    public virtual DbSet<WebDatum> WebData { get; set; }

    public virtual DbSet<WebSystab> WebSystabs { get; set; }

    public virtual DbSet<WebsiteElectronic> WebsiteElectronics { get; set; }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AAuthPicture>(entity =>
        {
            entity.HasKey(e => e.AuthNo);

            entity.ToTable("A_AUTH_PICTURE");

            entity.Property(e => e.AuthNo)
                .ValueGeneratedNever()
                .HasColumnName("AUTH_NO");
            entity.Property(e => e.AuthPicData).HasColumnName("AUTH_PIC_DATA");
            entity.Property(e => e.AuthPicFilename)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("AUTH_PIC_FILENAME");
            entity.Property(e => e.AuthPicType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AUTH_PIC_TYPE");
        });

        modelBuilder.Entity<ACatPicGallery>(entity =>
        {
            entity.HasKey(e => new { e.CatNo, e.CatPicFilename });

            entity.ToTable("A_CAT_PIC_GALLERY");

            entity.Property(e => e.CatNo).HasColumnName("CAT_NO");
            entity.Property(e => e.CatPicFilename)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CAT_PIC_FILENAME");
            entity.Property(e => e.CatPicData).HasColumnName("CAT_PIC_DATA");
            entity.Property(e => e.CatPicType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CAT_PIC_TYPE");
            entity.Property(e => e.MasterImg).HasColumnName("MASTER_IMG");
        });

        modelBuilder.Entity<ACatPicture>(entity =>
        {
            entity.HasKey(e => e.CatNo).HasName("PK_A_BOR_PICTURE");

            entity.ToTable("A_CAT_PICTURE");

            entity.Property(e => e.CatNo)
                .ValueGeneratedNever()
                .HasColumnName("CAT_NO");
            entity.Property(e => e.CatPicData).HasColumnName("CAT_PIC_DATA");
            entity.Property(e => e.CatPicFilename)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CAT_PIC_FILENAME");
            entity.Property(e => e.CatPicType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CAT_PIC_TYPE");
        });

        modelBuilder.Entity<AdAuthority>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AD_AUTHORITY");

            entity.HasIndex(e => e.AuthDatetime, "AUD_AUTHDATEX");

            entity.HasIndex(e => e.AuthKey, "AUD_AUTHKEYX");

            entity.HasIndex(e => e.AuthNo, "AUD_AUTHNOX");

            entity.Property(e => e.AuditId)
                .ValueGeneratedOnAdd()
                .HasColumnName("AUDIT_ID");
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

        modelBuilder.Entity<AdCatMarcLong>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AD_CAT_MARC_LONG");

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

        modelBuilder.Entity<AdCatalogue>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AD_CATALOGUE");

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

        modelBuilder.Entity<AuSystab>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AU_SYSTAB");

            entity.Property(e => e.AuthNo).HasColumnName("AUTH_NO");
        });

        modelBuilder.Entity<AuthFileImport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AUTH_FILE_IMPORT");

            entity.HasIndex(e => new { e.AfiNo, e.AfiUserSerial }, "AFISERIALX");

            entity.Property(e => e.AfiAuthNo).HasColumnName("AFI_AUTH_NO");
            entity.Property(e => e.AfiCatNo).HasColumnName("AFI_CAT_NO");
            entity.Property(e => e.AfiCurrStk)
                .HasMaxLength(240)
                .HasColumnName("AFI_CURR_STK");
            entity.Property(e => e.AfiCurrStkNext)
                .HasMaxLength(240)
                .HasColumnName("AFI_CURR_STK_NEXT");
            entity.Property(e => e.AfiCurrentFlags).HasColumnName("AFI_CURRENT_FLAGS");
            entity.Property(e => e.AfiData).HasColumnName("AFI_DATA");
            entity.Property(e => e.AfiDate)
                .HasColumnType("datetime")
                .HasColumnName("AFI_DATE");
            entity.Property(e => e.AfiDeleted).HasColumnName("AFI_DELETED");
            entity.Property(e => e.AfiDeprComments)
                .HasMaxLength(240)
                .HasColumnName("AFI_DEPR_COMMENTS");
            entity.Property(e => e.AfiLeader)
                .HasMaxLength(240)
                .HasColumnName("AFI_LEADER");
            entity.Property(e => e.AfiNo).HasColumnName("AFI_NO");
            entity.Property(e => e.AfiOrigStk)
                .HasMaxLength(240)
                .HasColumnName("AFI_ORIG_STK");
            entity.Property(e => e.AfiOrigStkNext)
                .HasMaxLength(240)
                .HasColumnName("AFI_ORIG_STK_NEXT");
            entity.Property(e => e.AfiOriginal)
                .HasMaxLength(1)
                .HasColumnName("AFI_ORIGINAL");
            entity.Property(e => e.AfiRecord).HasColumnName("AFI_RECORD");
            entity.Property(e => e.AfiType).HasColumnName("AFI_TYPE");
            entity.Property(e => e.AfiUserSerial).HasColumnName("AFI_USER_SERIAL");
        });

        modelBuilder.Entity<AuthFileImportHdr>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AUTH_FILE_IMPORT_HDR");

            entity.HasIndex(e => new { e.AfihNo, e.AfihUserSerial }, "AFIHSERIALX");

            entity.Property(e => e.AfihDate)
                .HasColumnType("datetime")
                .HasColumnName("AFIH_DATE");
            entity.Property(e => e.AfihHeader)
                .HasColumnType("ntext")
                .HasColumnName("AFIH_HEADER");
            entity.Property(e => e.AfihNo).HasColumnName("AFIH_NO");
            entity.Property(e => e.AfihOriginal)
                .HasMaxLength(1)
                .HasColumnName("AFIH_ORIGINAL");
            entity.Property(e => e.AfihUserSerial).HasColumnName("AFIH_USER_SERIAL");
        });

        modelBuilder.Entity<AuthFileImportList>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AUTH_FILE_IMPORT_LIST");

            entity.HasIndex(e => new { e.AfilNo, e.AfilUserSerial }, "AFILSERIALX");

            entity.Property(e => e.AfilDate)
                .HasColumnType("datetime")
                .HasColumnName("AFIL_DATE");
            entity.Property(e => e.AfilList)
                .HasColumnType("ntext")
                .HasColumnName("AFIL_LIST");
            entity.Property(e => e.AfilNo).HasColumnName("AFIL_NO");
            entity.Property(e => e.AfilOriginal)
                .HasMaxLength(1)
                .HasColumnName("AFIL_ORIGINAL");
            entity.Property(e => e.AfilUserSerial).HasColumnName("AFIL_USER_SERIAL");
        });

        modelBuilder.Entity<AuthKeyword>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AUTH_KEYWORD");

            entity.HasIndex(e => new { e.AuthNo, e.KwKeyword, e.KwType }, "AK_AKT_X");

            entity.HasIndex(e => new { e.KwKeyword, e.AuthNo, e.KwType }, "AK_KAT_X");

            entity.HasIndex(e => new { e.KwKeyword, e.KwType, e.AuthNo }, "AK_KTA_X");

            entity.HasIndex(e => e.UniqueSfNo, "AK_UNIQUE_SF_NOX");

            entity.Property(e => e.AuthNo).HasColumnName("AUTH_NO");
            entity.Property(e => e.KwKeyword)
                .HasMaxLength(100)
                .HasColumnName("KW_KEYWORD");
            entity.Property(e => e.KwPosition).HasColumnName("KW_POSITION");
            entity.Property(e => e.KwType)
                .HasMaxLength(1)
                .HasColumnName("KW_TYPE");
            entity.Property(e => e.UniqueSfNo).HasColumnName("UNIQUE_SF_NO");
        });

        modelBuilder.Entity<AuthNote>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AUTH_NOTE");

            entity.HasIndex(e => e.AuthNoteNo, "AUTHNOTEX").IsUnique();

            entity.Property(e => e.AuthNoteData).HasColumnName("AUTH_NOTE_DATA");
            entity.Property(e => e.AuthNoteDatetime)
                .HasColumnType("datetime")
                .HasColumnName("AUTH_NOTE_DATETIME");
            entity.Property(e => e.AuthNoteDiacrit)
                .HasMaxLength(1)
                .HasColumnName("AUTH_NOTE_DIACRIT");
            entity.Property(e => e.AuthNoteNo).HasColumnName("AUTH_NOTE_NO");
            entity.Property(e => e.AuthNoteOper)
                .HasMaxLength(25)
                .HasColumnName("AUTH_NOTE_OPER");
        });

        modelBuilder.Entity<AuthSeeAlso>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AUTH_SEE_ALSO");

            entity.HasIndex(e => e.AuthNo, "AUTHSEEAUTHX");

            entity.HasIndex(e => e.AuthSeeAlso1, "AUTHSEENOX");

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
            entity.Property(e => e.AuthSeeAlso1).HasColumnName("AUTH_SEE_ALSO");
        });

        modelBuilder.Entity<AuthSeeAlso1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AUTH_SEE_ALSO__");

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

        modelBuilder.Entity<Authority>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AUTHORITY");

            entity.HasIndex(e => new { e.AuthKey, e.AuthNo, e.AuthTagNo }, "AUTHKEYNOX");

            entity.HasIndex(e => new { e.AuthNo, e.AuthKey, e.AuthTagNo }, "AUTHNOKEYX");

            entity.HasIndex(e => e.AuthNo, "AUTHNOX").IsUnique();

            entity.HasIndex(e => new { e.AuthSee, e.AuthNo }, "AUTHSEEAUTHNOX");

            entity.HasIndex(e => e.AuthTagNo, "AUTHTAGNOX");

            entity.HasIndex(e => e.AuthTagNo, "INDEX_AUTHORITY_TAG_NO");

            entity.HasIndex(e => e.AuthTagNo, "INDEX_AUTHORITY_TAG_NO_LIBGROUP");

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
            entity.Property(e => e.Parent880).HasColumnName("PARENT_880");
        });

        modelBuilder.Entity<Authority1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AUTHORITY__");

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
            entity.Property(e => e.Parent880).HasColumnName("PARENT_880");
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

        modelBuilder.Entity<BorSubject>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BOR_SUBJECTS");

            entity.HasIndex(e => new { e.BorNo, e.AuthNo }, "XPKBOR_SUBJECTS").IsUnique();

            entity.Property(e => e.AuthNo).HasColumnName("AUTH_NO");
            entity.Property(e => e.BorBarNo)
                .HasMaxLength(75)
                .HasColumnName("BOR_BAR_NO");
            entity.Property(e => e.BorNo).HasColumnName("BOR_NO");
        });

        modelBuilder.Entity<CatAllword>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CAT_ALLWORDS");

            entity.HasIndex(e => e.CaAuthNo, "CA_AUTHNOX");

            entity.HasIndex(e => new { e.CaKeyword, e.CaType, e.CaTagNo, e.CaTitleKey, e.CaCatNo, e.CaAuthNo, e.CaCattagNo }, "CA_CAKTTCATX");

            entity.HasIndex(e => e.CaCatNo, "CA_CATNOX");

            entity.HasIndex(e => new { e.CaCatNo, e.CaType, e.CaKeyword, e.CaTitleKey, e.CaAuthNo, e.CaCattagNo }, "CA_CATTYKWTITX");

            entity.HasIndex(e => e.CaCattagNo, "CA_TAGUNIQUEX");

            entity.HasIndex(e => new { e.CaUniqueSfNo, e.CaAuthNo, e.CaCattagNo }, "CA_UNIQUE_SFX");

            entity.Property(e => e.CaAuthNo).HasColumnName("CA_AUTH_NO");
            entity.Property(e => e.CaCatNo).HasColumnName("CA_CAT_NO");
            entity.Property(e => e.CaCattagNo).HasColumnName("CA_CATTAG_NO");
            entity.Property(e => e.CaKeyword)
                .HasMaxLength(100)
                .HasColumnName("CA_KEYWORD");
            entity.Property(e => e.CaPosition).HasColumnName("CA_POSITION");
            entity.Property(e => e.CaTagNo).HasColumnName("CA_TAG_NO");
            entity.Property(e => e.CaTitleKey)
                .HasMaxLength(1)
                .HasColumnName("CA_TITLE_KEY");
            entity.Property(e => e.CaType)
                .HasMaxLength(1)
                .HasColumnName("CA_TYPE");
            entity.Property(e => e.CaUniqueSfNo).HasColumnName("CA_UNIQUE_SF_NO");
        });

        modelBuilder.Entity<CatDate>(entity =>
        {
            entity.HasKey(e => new { e.CdCatNo, e.CdTagNo, e.CdTagSf, e.CdDateFrom, e.CdDateTo });

            entity.ToTable("CAT_DATES");

            entity.Property(e => e.CdCatNo).HasColumnName("CD_CAT_NO");
            entity.Property(e => e.CdTagNo).HasColumnName("CD_TAG_NO");
            entity.Property(e => e.CdTagSf)
                .HasMaxLength(1)
                .HasColumnName("CD_TAG_SF");
            entity.Property(e => e.CdDateFrom).HasColumnName("CD_DATE_FROM");
            entity.Property(e => e.CdDateTo).HasColumnName("CD_DATE_TO");
        });

        modelBuilder.Entity<CatLong>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CAT_LONG");

            entity.HasIndex(e => new { e.ClUniqueNo, e.ClType }, "CL_UNIQUE_NOX");

            entity.Property(e => e.ClData)
                .HasColumnType("ntext")
                .HasColumnName("CL_DATA");
            entity.Property(e => e.ClType)
                .HasMaxLength(1)
                .HasColumnName("CL_TYPE");
            entity.Property(e => e.ClUniqueNo).HasColumnName("CL_UNIQUE_NO");
        });

        modelBuilder.Entity<CatMaint>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CAT_MAINT");

            entity.Property(e => e.CmAuthCat)
                .HasMaxLength(1)
                .HasColumnName("CM_AUTH_CAT");
            entity.Property(e => e.CmChangeType)
                .HasMaxLength(1)
                .HasColumnName("CM_CHANGE_TYPE");
            entity.Property(e => e.CmDate)
                .HasColumnType("datetime")
                .HasColumnName("CM_DATE");
            entity.Property(e => e.CmUniqueNo).HasColumnName("CM_UNIQUE_NO");
        });

        modelBuilder.Entity<CatMarcLong>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CAT_MARC_LONG", tb => tb.HasTrigger("trg_cat_marc_long_audit"));

            entity.Property(e => e.CmlData).HasColumnName("CML_DATA");
            entity.Property(e => e.TagUniqueNo).HasColumnName("TAG_UNIQUE_NO");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(25)
                .HasColumnName("UPDATED_BY");
        });

        modelBuilder.Entity<CatSf>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CAT_SF");

            entity.HasIndex(e => e.CatTagUniqueNo, "CSF_TAG_UNIQUE_NOX");

            entity.HasIndex(e => e.CatSfUniqueNo, "CSF_UNIQUE_NOX").IsUnique();

            entity.HasIndex(e => e.CatSf1, "INDEX_CAT_SF_CAT_DATA_TAG_UNIQUE_NO");

            entity.Property(e => e.CatSf1)
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

        modelBuilder.Entity<CatSystab>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CAT_SYSTAB");

            entity.Property(e => e.CatNo).HasColumnName("CAT_NO");
        });

        modelBuilder.Entity<CatTag>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CAT_TAG");

            entity.HasIndex(e => e.TagUniqueNo, "CATTAGNOX");

            entity.HasIndex(e => e.TagNo, "INDEX_CATTAG_TAG_NO_LIBGROUP");

            entity.HasIndex(e => e.TagNo, "INDEX_CAT_TAG_UNIQUE_ID");

            entity.HasIndex(e => e.TagKey, "IX_CAT_TAG_TAG_KEY");

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

        modelBuilder.Entity<Catalogue>(entity =>
        {
            entity.HasKey(e => e.CatNo);

            entity.ToTable("CATALOGUE", tb => tb.HasTrigger("trg_catalogue_audit"));

            entity.HasIndex(e => e.CatNo, "CATNOX").IsUnique();

            entity.HasIndex(e => e.CatNo, "CATNO_CLUST")
                .IsUnique()
                .IsClustered();

            entity.HasIndex(e => e.CatNo1, "CAT_NO1X");

            entity.HasIndex(e => e.CatNo2, "CAT_NO2X");

            entity.HasIndex(e => e.CatNo3, "CAT_NO3X");

            entity.HasIndex(e => e.CatNo4, "CAT_NO4X");

            entity.HasIndex(e => e.CatDate1, "IDX_CATALOGUE_DATE1");

            entity.HasIndex(e => e.CatDate2, "IDX_CATALOGUE_DATE2");

            entity.HasIndex(e => e.CatDate3, "IDX_CATALOGUE_DATE3");

            entity.HasIndex(e => e.CatDate4, "IDX_CATALOGUE_DATE4");

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
            entity.Property(e => e.CatLikes).HasColumnName("CAT_LIKES");
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
            entity.Property(e => e.CatPromote).HasColumnName("CAT_PROMOTE");
            entity.Property(e => e.CatRating).HasColumnName("CAT_RATING");
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
            entity.Property(e => e.ParentCatNo).HasColumnName("PARENT_CAT_NO");
            entity.Property(e => e.SeriesCatRefNo).HasColumnName("SERIES_CAT_REF_NO");
            entity.Property(e => e.SeriesType)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("SERIES_TYPE");
            entity.Property(e => e.TemplateId)
                .HasMaxLength(75)
                .HasColumnName("TEMPLATE_ID");
            entity.Property(e => e.TotalUsersRated).HasColumnName("TOTAL_USERS_RATED");
            entity.Property(e => e.TreeLevel).HasColumnName("TREE_LEVEL");
            entity.Property(e => e.TreeLevelSortOrder).HasColumnName("TREE_LEVEL_SORT_ORDER");
        });

        modelBuilder.Entity<CatalogueElectronic>(entity =>
        {
            entity.HasKey(e => e.CatElectronicId);

            entity.ToTable("CATALOGUE_ELECTRONIC");

            entity.Property(e => e.CatElectronicId)
                .ValueGeneratedNever()
                .HasColumnName("CAT_ELECTRONIC_ID");
            entity.Property(e => e.CattagAuthNo).HasColumnName("CATTAG_AUTH_NO");
            entity.Property(e => e.ContentType)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CONTENT_TYPE");
            entity.Property(e => e.FileData).HasColumnName("FILE_DATA");
            entity.Property(e => e.FileDatetime)
                .HasColumnType("datetime")
                .HasColumnName("FILE_DATETIME");
            entity.Property(e => e.FileLength).HasColumnName("FILE_LENGTH");
            entity.Property(e => e.Filename)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("FILENAME");
            entity.Property(e => e.FilterExtension)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FILTER_EXTENSION");
            entity.Property(e => e.PhysicalFileName)
                .HasMaxLength(25)
                .HasColumnName("PHYSICAL_FILE_NAME");
            entity.Property(e => e.UploadDatetime)
                .HasColumnType("datetime")
                .HasColumnName("UPLOAD_DATETIME");
        });

        modelBuilder.Entity<CatalogueRef>(entity =>
        {
            entity.ToTable("CATALOGUE_REFS");

            entity.HasIndex(e => new { e.AuthNo, e.CatNo, e.TagNo }, "CATR_ACT_X");

            entity.HasIndex(e => new { e.CatNo, e.AuthNo, e.TagNo }, "CATR_CAT_X");

            entity.HasIndex(e => new { e.CatNo, e.CattagNo, e.TagNo }, "CATR_CUT_X");

            entity.HasIndex(e => new { e.CattagNo, e.CatNo, e.TagNo }, "CATR_UCT_X");

            entity.HasIndex(e => e.TagNo, "INDEX_CAT_REFS_TAG_NO");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AuthNo).HasColumnName("AUTH_NO");
            entity.Property(e => e.AuthOcc).HasColumnName("AUTH_OCC");
            entity.Property(e => e.CatNo).HasColumnName("CAT_NO");
            entity.Property(e => e.CatRefSequence).HasColumnName("CAT_REF_SEQUENCE");
            entity.Property(e => e.CattagNo).HasColumnName("CATTAG_NO");
            entity.Property(e => e.TagNo).HasColumnName("TAG_NO");
        });

        modelBuilder.Entity<CatdisplayTag>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CATDISPLAY_TAGS");

            entity.Property(e => e.CtTag11).HasColumnName("CT_TAG11");
            entity.Property(e => e.CtTag12).HasColumnName("CT_TAG12");
            entity.Property(e => e.CtTag13).HasColumnName("CT_TAG13");
            entity.Property(e => e.CtTag14).HasColumnName("CT_TAG14");
            entity.Property(e => e.CtTag21).HasColumnName("CT_TAG21");
            entity.Property(e => e.CtTag22).HasColumnName("CT_TAG22");
            entity.Property(e => e.CtTag23).HasColumnName("CT_TAG23");
            entity.Property(e => e.CtTag24).HasColumnName("CT_TAG24");
            entity.Property(e => e.CtTag31).HasColumnName("CT_TAG31");
            entity.Property(e => e.CtTag32).HasColumnName("CT_TAG32");
            entity.Property(e => e.CtTag33).HasColumnName("CT_TAG33");
            entity.Property(e => e.CtTag34).HasColumnName("CT_TAG34");
            entity.Property(e => e.CtTag41).HasColumnName("CT_TAG41");
            entity.Property(e => e.CtTag42).HasColumnName("CT_TAG42");
            entity.Property(e => e.CtTag43).HasColumnName("CT_TAG43");
            entity.Property(e => e.CtTag44).HasColumnName("CT_TAG44");
        });

        modelBuilder.Entity<CiAdAuthority>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_AD_AUTHORITY");

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
            entity.Property(e => e.AuthtempInd1)
                .HasMaxLength(1)
                .HasColumnName("AUTHTEMP_IND1");
            entity.Property(e => e.AuthtempInd2)
                .HasMaxLength(1)
                .HasColumnName("AUTHTEMP_IND2");
            entity.Property(e => e.SfFormat)
                .HasColumnType("ntext")
                .HasColumnName("SF_FORMAT");
        });

        modelBuilder.Entity<CiAuSystab>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_AU_SYSTAB");

            entity.Property(e => e.AuthNo).HasColumnName("AUTH_NO");
        });

        modelBuilder.Entity<CiAuthKeyword>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_AUTH_KEYWORD");

            entity.HasIndex(e => new { e.AuthNo, e.KwKeyword, e.KwType }, "CI_AK_ATHKWTYPX");

            entity.HasIndex(e => new { e.KwKeyword, e.AuthNo, e.KwType }, "CI_AK_KWATHTYPX");

            entity.HasIndex(e => e.UniqueSfNo, "CI_AK_SF_UNOX");

            entity.Property(e => e.AuthNo).HasColumnName("AUTH_NO");
            entity.Property(e => e.KwKeyword)
                .HasMaxLength(20)
                .HasColumnName("KW_KEYWORD");
            entity.Property(e => e.KwPosition).HasColumnName("KW_POSITION");
            entity.Property(e => e.KwType)
                .HasMaxLength(1)
                .HasColumnName("KW_TYPE");
            entity.Property(e => e.UniqueSfNo).HasColumnName("UNIQUE_SF_NO");
        });

        modelBuilder.Entity<CiAuthNote>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_AUTH_NOTE");

            entity.Property(e => e.AuthNoteData)
                .HasColumnType("ntext")
                .HasColumnName("AUTH_NOTE_DATA");
            entity.Property(e => e.AuthNoteDatetime)
                .HasColumnType("datetime")
                .HasColumnName("AUTH_NOTE_DATETIME");
            entity.Property(e => e.AuthNoteDiacrit)
                .HasMaxLength(1)
                .HasColumnName("AUTH_NOTE_DIACRIT");
            entity.Property(e => e.AuthNoteNo).HasColumnName("AUTH_NOTE_NO");
            entity.Property(e => e.AuthNoteOper)
                .HasMaxLength(25)
                .HasColumnName("AUTH_NOTE_OPER");
        });

        modelBuilder.Entity<CiAuthSeeAlso>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_AUTH_SEE_ALSO");

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

        modelBuilder.Entity<CiAuthority>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_AUTHORITY");

            entity.HasIndex(e => e.AuthKey, "CI_AUTH_KEYX");

            entity.HasIndex(e => e.AuthNo, "CI_AUTH_NOX").IsUnique();

            entity.HasIndex(e => e.AuthTagNo, "CI_AUTH_TAG_CODEX");

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
                .HasMaxLength(100)
                .HasColumnName("AUTH_SOUNDEX");
            entity.Property(e => e.AuthTagNo).HasColumnName("AUTH_TAG_NO");
            entity.Property(e => e.AuthtempInd1).HasColumnName("AUTHTEMP_IND1");
            entity.Property(e => e.AuthtempInd2).HasColumnName("AUTHTEMP_IND2");
        });

        modelBuilder.Entity<CiCatAllword>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_CAT_ALLWORDS");

            entity.HasIndex(e => e.CaAuthNo, "CI_CA_AUTHNOX");

            entity.HasIndex(e => new { e.CaKeyword, e.CaType, e.CaTagNo, e.CaTitleKey, e.CaCatNo, e.CaAuthNo, e.CaCattagNo }, "CI_CA_CAKTTCATX");

            entity.HasIndex(e => e.CaCatNo, "CI_CA_CATNOX");

            entity.HasIndex(e => new { e.CaCatNo, e.CaType, e.CaKeyword, e.CaTitleKey, e.CaAuthNo, e.CaCattagNo }, "CI_CA_CATTYKWTITX");

            entity.HasIndex(e => e.CaCattagNo, "CI_CA_TAGUNIQUEX");

            entity.HasIndex(e => new { e.CaUniqueSfNo, e.CaAuthNo, e.CaCattagNo }, "CI_CA_UNIQUE_SFX");

            entity.Property(e => e.CaAuthNo).HasColumnName("CA_AUTH_NO");
            entity.Property(e => e.CaCatNo).HasColumnName("CA_CAT_NO");
            entity.Property(e => e.CaCattagNo).HasColumnName("CA_CATTAG_NO");
            entity.Property(e => e.CaKeyword)
                .HasMaxLength(20)
                .HasColumnName("CA_KEYWORD");
            entity.Property(e => e.CaPosition).HasColumnName("CA_POSITION");
            entity.Property(e => e.CaTagNo).HasColumnName("CA_TAG_NO");
            entity.Property(e => e.CaTitleKey)
                .HasMaxLength(1)
                .HasColumnName("CA_TITLE_KEY");
            entity.Property(e => e.CaType)
                .HasMaxLength(1)
                .HasColumnName("CA_TYPE");
            entity.Property(e => e.CaUniqueSfNo).HasColumnName("CA_UNIQUE_SF_NO");
        });

        modelBuilder.Entity<CiCatLong>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_CAT_LONG");

            entity.HasIndex(e => e.ClUniqueNo, "CI_CATLNGUNOX").IsUnique();

            entity.Property(e => e.ClData)
                .HasColumnType("ntext")
                .HasColumnName("CL_DATA");
            entity.Property(e => e.ClType)
                .HasMaxLength(1)
                .HasColumnName("CL_TYPE");
            entity.Property(e => e.ClUniqueNo).HasColumnName("CL_UNIQUE_NO");
        });

        modelBuilder.Entity<CiCatSf>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_CAT_SF");

            entity.HasIndex(e => e.CatSfUniqueNo, "CI_CSF_UNOX").IsUnique();

            entity.HasIndex(e => e.CatTagUniqueNo, "CI_SF_TAG_UNOX");

            entity.Property(e => e.CatSf)
                .HasMaxLength(1)
                .HasColumnName("CAT_SF");
            entity.Property(e => e.CatSfData)
                .HasMaxLength(300)
                .HasColumnName("CAT_SF_DATA");
            entity.Property(e => e.CatSfDiacritic)
                .HasMaxLength(1)
                .HasColumnName("CAT_SF_DIACRITIC");
            entity.Property(e => e.CatSfLongNo).HasColumnName("CAT_SF_LONG_NO");
            entity.Property(e => e.CatSfSequence).HasColumnName("CAT_SF_SEQUENCE");
            entity.Property(e => e.CatSfUniqueNo).HasColumnName("CAT_SF_UNIQUE_NO");
            entity.Property(e => e.CatTagNo).HasColumnName("CAT_TAG_NO");
            entity.Property(e => e.CatTagUniqueNo).HasColumnName("CAT_TAG_UNIQUE_NO");
            entity.Property(e => e.CsfData)
                .HasColumnType("ntext")
                .HasColumnName("CSF_DATA");
        });

        modelBuilder.Entity<CiCatSystab>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_CAT_SYSTAB");

            entity.Property(e => e.CatNo).HasColumnName("CAT_NO");
        });

        modelBuilder.Entity<CiCatTag>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_CAT_TAG");

            entity.HasIndex(e => e.TagNo, "CT_TAG_CODEX");

            entity.HasIndex(e => e.TagUniqueNo, "CT_UNIQUE_NOX").IsUnique();

            entity.Property(e => e.TagDatetime)
                .HasColumnType("datetime")
                .HasColumnName("TAG_DATETIME");
            entity.Property(e => e.TagInd1)
                .HasMaxLength(1)
                .HasColumnName("TAG_IND1");
            entity.Property(e => e.TagInd2)
                .HasMaxLength(1)
                .HasColumnName("TAG_IND2");
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
            entity.Property(e => e.TagtempInd1).HasColumnName("TAGTEMP_IND1");
            entity.Property(e => e.TagtempInd2).HasColumnName("TAGTEMP_IND2");
        });

        modelBuilder.Entity<CiCatalogue>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_CATALOGUE");

            entity.HasIndex(e => e.CatNo, "CI_CAT_NOX").IsUnique();

            entity.Property(e => e.CatClass)
                .HasMaxLength(25)
                .HasColumnName("CAT_CLASS");
            entity.Property(e => e.CatCreateDatetime)
                .HasColumnType("datetime")
                .HasColumnName("CAT_CREATE_DATETIME");
            entity.Property(e => e.CatCreateOper)
                .HasMaxLength(25)
                .HasColumnName("CAT_CREATE_OPER");
            entity.Property(e => e.CatDatetime)
                .HasColumnType("datetime")
                .HasColumnName("CAT_DATETIME");
            entity.Property(e => e.CatKey1)
                .HasMaxLength(100)
                .HasColumnName("CAT_KEY1");
            entity.Property(e => e.CatKey2)
                .HasMaxLength(100)
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
                .HasMaxLength(100)
                .HasColumnName("CAT_STR2");
            entity.Property(e => e.CatStr3)
                .HasMaxLength(100)
                .HasColumnName("CAT_STR3");
            entity.Property(e => e.CatStr4)
                .HasMaxLength(100)
                .HasColumnName("CAT_STR4");
            entity.Property(e => e.CatType).HasColumnName("CAT_TYPE");
        });

        modelBuilder.Entity<CiCatalogueRef>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_CATALOGUE_REFS");

            entity.HasIndex(e => e.AuthNo, "CR_AUTH_NOX");

            entity.HasIndex(e => e.CatNo, "CR_CAT_NOX");

            entity.Property(e => e.AuthNo).HasColumnName("AUTH_NO");
            entity.Property(e => e.AuthOcc).HasColumnName("AUTH_OCC");
            entity.Property(e => e.CatNo).HasColumnName("CAT_NO");
            entity.Property(e => e.CatRefSequence).HasColumnName("CAT_REF_SEQUENCE");
            entity.Property(e => e.CattagNo).HasColumnName("CATTAG_NO");
            entity.Property(e => e.TagNo).HasColumnName("TAG_NO");
        });

        modelBuilder.Entity<CiSfDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_SF_DATA");

            entity.HasIndex(e => e.SfAuthNo, "CI_SF_AUTH_NOX");

            entity.HasIndex(e => e.SfUniqueNo, "CI_SF_UNIQUE_NOX").IsUnique();

            entity.Property(e => e.Sf)
                .HasMaxLength(1)
                .HasColumnName("SF");
            entity.Property(e => e.SfAuthNo).HasColumnName("SF_AUTH_NO");
            entity.Property(e => e.SfData)
                .HasMaxLength(300)
                .HasColumnName("SF_DATA");
            entity.Property(e => e.SfDiacritic)
                .HasMaxLength(1)
                .HasColumnName("SF_DIACRITIC");
            entity.Property(e => e.SfSequence).HasColumnName("SF_SEQUENCE");
            entity.Property(e => e.SfUniqueNo).HasColumnName("SF_UNIQUE_NO");
        });

        modelBuilder.Entity<CiSfSystab>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_SF_SYSTAB");

            entity.Property(e => e.SfUniqueNo).HasColumnName("SF_UNIQUE_NO");
        });

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

        modelBuilder.Entity<DynamicPageTemplate>(entity =>
        {
            entity.HasKey(e => e.Templateid);

            entity.ToTable("DYNAMIC_PAGE_TEMPLATES");

            entity.Property(e => e.Templateid).HasColumnName("TEMPLATEID");
            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.TemplateContent)
                .IsUnicode(false)
                .HasColumnName("TEMPLATE_CONTENT");
            entity.Property(e => e.TemplateTitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TEMPLATE_TITLE");
        });

        modelBuilder.Entity<DynamicWebpage>(entity =>
        {
            entity.ToTable("DYNAMIC_WEBPAGES");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.Author)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AUTHOR");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.DemoUrlLink)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DEMO_URL_LINK");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.LibGroup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LIB_GROUP");
            entity.Property(e => e.Uniqueid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UNIQUEID");
            entity.Property(e => e.WebContent).HasColumnName("WEB_CONTENT");
        });

        modelBuilder.Entity<DynamicWebpagesTranslation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DYNAMIC_WEBPAGES_TRANSLATION");

            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.WebContentTrans).HasColumnName("WEB_CONTENT_TRANS");
        });

        modelBuilder.Entity<FileCatDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FILE_CAT_DATA");

            entity.HasIndex(e => new { e.FileNitem, e.FileNumber }, "FCD_ITEMNOX");

            entity.HasIndex(e => new { e.FileNumber, e.FileNitem }, "FCD_NOITEMX");

            entity.HasIndex(e => new { e.FileNumber, e.FileSequence }, "IX_FILE_CAT_DATA_FILE_NUMBER_FILE_SEQUENCE");

            entity.Property(e => e.FileNitem).HasColumnName("FILE_NITEM");
            entity.Property(e => e.FileNumber).HasColumnName("FILE_NUMBER");
            entity.Property(e => e.FileSequence).HasColumnName("FILE_SEQUENCE");
        });

        modelBuilder.Entity<FileCatName>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FILE_CAT_NAMES");

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

        modelBuilder.Entity<FileCatSystab>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FILE_CAT_SYSTAB");

            entity.Property(e => e.FileNumber).HasColumnName("FILE_NUMBER");
        });

        modelBuilder.Entity<FileKeyword>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FILE_KEYWORD");

            entity.HasIndex(e => new { e.FkFileNo, e.FkUniqueNo }, "FKWS_FILNOUNOX");

            entity.HasIndex(e => new { e.FkUniqueNo, e.FkFileNo }, "FKWS_UNOFILNOX");

            entity.Property(e => e.FkFileNo).HasColumnName("FK_FILE_NO");
            entity.Property(e => e.FkUniqueNo).HasColumnName("FK_UNIQUE_NO");
        });

        modelBuilder.Entity<FileKwOper>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FILE_KW_OPER");

            entity.HasIndex(e => new { e.FoOperName, e.FoFileNo }, "FKO_OPERNOX");

            entity.Property(e => e.FoDatetime)
                .HasColumnType("datetime")
                .HasColumnName("FO_DATETIME");
            entity.Property(e => e.FoFileNo).HasColumnName("FO_FILE_NO");
            entity.Property(e => e.FoOperName)
                .HasMaxLength(25)
                .HasColumnName("FO_OPER_NAME");
        });

        modelBuilder.Entity<Helpdesk>(entity =>
        {
            entity.HasKey(e => e.Helpdeskid).HasName("PK_HelpDesk");

            entity.ToTable("HELPDESK");

            entity.Property(e => e.Helpdeskid).HasColumnName("HELPDESKID");
            entity.Property(e => e.Assignedto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ASSIGNEDTO");
            entity.Property(e => e.Matchingticket)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MATCHINGTICKET");
            entity.Property(e => e.Prioritytype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PRIORITYTYPE");
            entity.Property(e => e.Replymessage)
                .IsUnicode(false)
                .HasColumnName("REPLYMESSAGE");
            entity.Property(e => e.Ticketmessage)
                .IsUnicode(false)
                .HasColumnName("TICKETMESSAGE");
            entity.Property(e => e.Ticketstaus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TICKETSTAUS");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USERNAME");
        });

        modelBuilder.Entity<ImportLog>(entity =>
        {
            entity.HasKey(e => e.LogId);

            entity.ToTable("IMPORT_LOG");

            entity.Property(e => e.LogId).HasColumnName("LOG_ID");
            entity.Property(e => e.LogDatetime)
                .HasColumnType("datetime")
                .HasColumnName("LOG_DATETIME");
            entity.Property(e => e.LogImportFileName).HasColumnName("LOG_IMPORT_FILE_NAME");
            entity.Property(e => e.LogMarc).HasColumnName("LOG_MARC");
            entity.Property(e => e.LogMessage).HasColumnName("LOG_MESSAGE");
            entity.Property(e => e.LogOperName)
                .HasMaxLength(50)
                .HasColumnName("LOG_OPER_NAME");
        });

        modelBuilder.Entity<MauritiusFileList>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MauritiusFileList");

            entity.Property(e => e.F1).HasMaxLength(255);
        });

        modelBuilder.Entity<MissingMarcTag>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.DateLogged)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime")
                .HasColumnName("DATE_LOGGED");
            entity.Property(e => e.MissingDesc)
                .HasMaxLength(100)
                .HasColumnName("MISSING_DESC");
            entity.Property(e => e.Sf)
                .HasMaxLength(10)
                .HasColumnName("SF");
            entity.Property(e => e.TagNo).HasColumnName("TAG_NO");
        });

        modelBuilder.Entity<Number>(entity =>
        {
            entity.HasKey(e => e.Num);

            entity.ToTable("numbers");

            entity.Property(e => e.Num)
                .ValueGeneratedNever()
                .HasColumnName("num");
        });

        modelBuilder.Entity<QueryStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("QUERY_STATUS");

            entity.Property(e => e.Activity)
                .HasMaxLength(50)
                .HasColumnName("ACTIVITY");
            entity.Property(e => e.CurrentItem).HasColumnName("CURRENT_ITEM");
            entity.Property(e => e.CurrentItem2).HasColumnName("CURRENT_ITEM2");
            entity.Property(e => e.DeleteFlag).HasColumnName("DELETE_FLAG");
            entity.Property(e => e.EndTime)
                .HasColumnType("datetime")
                .HasColumnName("END_TIME");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Iteration).HasColumnName("ITERATION");
            entity.Property(e => e.LastItem).HasColumnName("LAST_ITEM");
            entity.Property(e => e.LastItem2).HasColumnName("LAST_ITEM2");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATED");
            entity.Property(e => e.LlCode)
                .HasMaxLength(30)
                .HasColumnName("LL_CODE");
            entity.Property(e => e.Message)
                .HasMaxLength(450)
                .HasColumnName("MESSAGE");
            entity.Property(e => e.MethodName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("METHOD_NAME");
            entity.Property(e => e.Operator)
                .HasMaxLength(30)
                .HasColumnName("OPERATOR");
            entity.Property(e => e.QueryStatus1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("QUERY_STATUS");
            entity.Property(e => e.RowsUpdated).HasColumnName("ROWS_UPDATED");
            entity.Property(e => e.StartTime)
                .HasColumnType("datetime")
                .HasColumnName("START_TIME");
            entity.Property(e => e.TagNo).HasColumnName("TAG_NO");
        });

        modelBuilder.Entity<Series>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SERIES");

            entity.Property(e => e.ChildCatNo).HasColumnName("CHILD_CAT_NO");
            entity.Property(e => e.ParentCatNo).HasColumnName("PARENT_CAT_NO");
        });

        modelBuilder.Entity<SfDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SF_DATA");

            entity.HasIndex(e => e.Sf, "INDEX_SF_DATA_SF");

            entity.HasIndex(e => new { e.SfAuthNo, e.SfUniqueNo, e.Sf }, "SFD_AUTHNOUNOX");

            entity.HasIndex(e => new { e.SfUniqueNo, e.SfAuthNo, e.Sf }, "SFD_UNOAUTHNOX");

            entity.Property(e => e.Sf)
                .HasMaxLength(1)
                .HasColumnName("SF");
            entity.Property(e => e.SfAuthNo).HasColumnName("SF_AUTH_NO");
            entity.Property(e => e.SfData)
                .HasMaxLength(300)
                .HasColumnName("SF_DATA");
            entity.Property(e => e.SfDiacritic)
                .HasMaxLength(1)
                .HasColumnName("SF_DIACRITIC");
            entity.Property(e => e.SfSequence).HasColumnName("SF_SEQUENCE");
            entity.Property(e => e.SfUniqueNo).HasColumnName("SF_UNIQUE_NO");
        });

        modelBuilder.Entity<SfSystab>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SF_SYSTAB");

            entity.Property(e => e.SfUniqueNo).HasColumnName("SF_UNIQUE_NO");
        });

        modelBuilder.Entity<TempCatMarcImport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP_CAT_MARC_IMPORT");

            entity.HasIndex(e => new { e.UniqueId, e.InsertStatus, e.InsertCatNo }, "INDEX_TEMP_CAT_MARC_IMPORT_UNIQUE_ID");

            entity.Property(e => e.AuthFileId).HasColumnName("AUTH_FILE_ID");
            entity.Property(e => e.CatFileId).HasColumnName("CAT_FILE_ID");
            entity.Property(e => e.CatNoDeleteTags)
                .HasMaxLength(75)
                .HasColumnName("CAT_NO_DELETE_TAGS");
            entity.Property(e => e.CatNoImportTags)
                .HasMaxLength(75)
                .HasColumnName("CAT_NO_IMPORT_TAGS");
            entity.Property(e => e.CatTemplateId)
                .HasMaxLength(75)
                .HasColumnName("CAT_TEMPLATE_ID");
            entity.Property(e => e.FromZ3950Status)
                .HasMaxLength(1)
                .HasColumnName("FROM_Z3950_STATUS");
            entity.Property(e => e.ImportCatOption)
                .HasMaxLength(75)
                .HasColumnName("IMPORT_CAT_OPTION");
            entity.Property(e => e.ImportOption)
                .HasMaxLength(75)
                .HasColumnName("IMPORT_OPTION");
            entity.Property(e => e.ImportStkOption)
                .HasMaxLength(75)
                .HasColumnName("IMPORT_STK_OPTION");
            entity.Property(e => e.InsertCatNo).HasColumnName("INSERT_CAT_NO");
            entity.Property(e => e.InsertStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("INSERT_STATUS");
            entity.Property(e => e.IsExistsCat).HasColumnName("IS_EXISTS_CAT");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATED");
            entity.Property(e => e.Notes).HasColumnName("NOTES");
            entity.Property(e => e.StkFileId).HasColumnName("STK_FILE_ID");
            entity.Property(e => e.StkFormDf)
                .HasMaxLength(75)
                .HasColumnName("STK_FORM_DF");
            entity.Property(e => e.StkLocFloorDf)
                .HasMaxLength(75)
                .HasColumnName("STK_LOC_FLOOR_DF");
            entity.Property(e => e.StkLocPermDf)
                .HasMaxLength(75)
                .HasColumnName("STK_LOC_PERM_DF");
            entity.Property(e => e.StkProcess)
                .HasMaxLength(75)
                .HasColumnName("STK_PROCESS");
            entity.Property(e => e.StkRefreshExceptLineDf)
                .HasMaxLength(75)
                .HasColumnName("STK_REFRESH_EXCEPT_LINE_DF");
            entity.Property(e => e.StkStatsDf)
                .HasMaxLength(75)
                .HasColumnName("STK_STATS_DF");
            entity.Property(e => e.UniqueControlId).HasColumnName("UNIQUE_CONTROL_ID");
            entity.Property(e => e.UniqueId).HasColumnName("UNIQUE_ID");
        });

        modelBuilder.Entity<TempCatMarcImportDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP_CAT_MARC_IMPORT_DETAILS");

            entity.HasIndex(e => new { e.UniqueId, e.CatRefId }, "INDEX_TEMP_CAT_MARC_IMPORT_DETAILS");

            entity.HasIndex(e => e.UniqueId, "NonClusteredIndex-TEMP_CAT_MARC_IMPORT_DETAILS_UNIQUE_ID");

            entity.Property(e => e.CatRefId).HasColumnName("CAT_REF_ID");
            entity.Property(e => e.FromZ3950).HasColumnName("FROM_Z3950");
            entity.Property(e => e.Ind1)
                .HasMaxLength(10)
                .HasColumnName("IND_1");
            entity.Property(e => e.Ind2)
                .HasMaxLength(10)
                .HasColumnName("IND_2");
            entity.Property(e => e.Sf)
                .HasMaxLength(10)
                .HasColumnName("SF");
            entity.Property(e => e.SfData).HasColumnName("SF_DATA");
            entity.Property(e => e.StkImportGroup).HasColumnName("STK_IMPORT_GROUP");
            entity.Property(e => e.TagNo).HasColumnName("TAG_NO");
            entity.Property(e => e.UniqueId).HasColumnName("UNIQUE_ID");
        });

        modelBuilder.Entity<Tempno2401c>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMPNO2401C");

            entity.HasIndex(e => e.CatNo, "TEMPNO2401CX");

            entity.Property(e => e.CatNo).HasColumnName("CAT_NO");
        });

        modelBuilder.Entity<Tempno2406c>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMPNO2406C");

            entity.HasIndex(e => e.CatNo, "TEMPNO2406CX");

            entity.Property(e => e.CatNo).HasColumnName("CAT_NO");
        });

        modelBuilder.Entity<Tempno2410c>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMPNO2410C");

            entity.HasIndex(e => e.CatNo, "TEMPNO2410CX");

            entity.Property(e => e.CatNo).HasColumnName("CAT_NO");
        });

        modelBuilder.Entity<UserKwCirc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("USER_KW_CIRC");

            entity.Property(e => e.FkFileNo).HasColumnName("FK_FILE_NO");
            entity.Property(e => e.FkUniqueNo).HasColumnName("FK_UNIQUE_NO");
        });

        modelBuilder.Entity<UserKwConvert>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("USER_KW_CONVERT");

            entity.Property(e => e.FkFileNo).HasColumnName("FK_FILE_NO");
            entity.Property(e => e.FkUniqueNo).HasColumnName("FK_UNIQUE_NO");
        });

        modelBuilder.Entity<UserKwJorge>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("USER_KW_JORGE");

            entity.Property(e => e.FkFileNo).HasColumnName("FK_FILE_NO");
            entity.Property(e => e.FkUniqueNo).HasColumnName("FK_UNIQUE_NO");
        });

        modelBuilder.Entity<UserKwNetopac>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("USER_KW_NETOPACS");

            entity.Property(e => e.FkFileNo).HasColumnName("FK_FILE_NO");
            entity.Property(e => e.FkUniqueNo).HasColumnName("FK_UNIQUE_NO");
        });

        modelBuilder.Entity<UserKwStaff>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("USER_KW_STAFF");

            entity.Property(e => e.FkFileNo).HasColumnName("FK_FILE_NO");
            entity.Property(e => e.FkUniqueNo).HasColumnName("FK_UNIQUE_NO");
        });

        modelBuilder.Entity<UserKwSteel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("USER_KW_STEEL");

            entity.Property(e => e.FkFileNo).HasColumnName("FK_FILE_NO");
            entity.Property(e => e.FkUniqueNo).HasColumnName("FK_UNIQUE_NO");
        });

        modelBuilder.Entity<UserKwTrevor>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("USER_KW_TREVOR");

            entity.Property(e => e.FkFileNo).HasColumnName("FK_FILE_NO");
            entity.Property(e => e.FkUniqueNo).HasColumnName("FK_UNIQUE_NO");
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
            entity.Property(e => e.Parent880).HasColumnName("PARENT_880");
        });

        modelBuilder.Entity<VAuthorityChild>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_AUTHORITY_CHILD");

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
            entity.Property(e => e.AuthNoParent).HasColumnName("AUTH_NO_PARENT");
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
            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.Parent880).HasColumnName("PARENT_880");
        });

        modelBuilder.Entity<VCatalogue>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_CATALOGUE");

            entity.Property(e => e.CatNo).HasColumnName("CAT_NO");
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
            entity.Property(e => e.CatStr5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CAT_STR5");
            entity.Property(e => e.CatStr6)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CAT_STR6");
            entity.Property(e => e.Marc)
                .HasMaxLength(250)
                .HasColumnName("marc");
            entity.Property(e => e.Sf)
                .HasMaxLength(1)
                .HasColumnName("sf");
            entity.Property(e => e.SfData)
                .HasMaxLength(254)
                .HasColumnName("sf_data");
            entity.Property(e => e.TagNo).HasColumnName("TAG_NO");
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
            entity.Property(e => e.Id).HasColumnName("ID");
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

        modelBuilder.Entity<VCatalogueIsbnstr>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_CATALOGUE_ISBNSTR");

            entity.Property(e => e.CatNo).HasColumnName("CAT_NO");
            entity.Property(e => e.Isbnstr)
                .HasMaxLength(300)
                .HasColumnName("ISBNSTR");
            entity.Property(e => e.TagLibGroup)
                .HasMaxLength(30)
                .HasColumnName("TAG_LIB_GROUP");
        });

        modelBuilder.Entity<VisBackupCat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VIS_BACKUP_CAT");

            entity.Property(e => e.LastBackupDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_BACKUP_DATE");
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

        modelBuilder.Entity<WebsiteElectronic>(entity =>
        {
            entity.HasKey(e => e.ElectronicId);

            entity.ToTable("WEBSITE_ELECTRONIC");

            entity.Property(e => e.ElectronicId)
                .ValueGeneratedNever()
                .HasColumnName("ELECTRONIC_ID");
            entity.Property(e => e.ContentType)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CONTENT_TYPE");
            entity.Property(e => e.FileData).HasColumnName("FILE_DATA");
            entity.Property(e => e.FileLength).HasColumnName("FILE_LENGTH");
            entity.Property(e => e.Filename)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("FILENAME");
            entity.Property(e => e.LibGroup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LIB_GROUP");
            entity.Property(e => e.Path)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PATH");
            entity.Property(e => e.UploadDatetime)
                .HasColumnType("datetime")
                .HasColumnName("UPLOAD_DATETIME");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

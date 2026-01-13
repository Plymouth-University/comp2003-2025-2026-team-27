using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Lms.Data.Models.Dereport;

public partial class DereportContext : DbContext
{
    public DereportContext()
    {
    }

    public DereportContext(DbContextOptions<DereportContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AAnsUser> AAnsUsers { get; set; }

    public virtual DbSet<AAppFlagValue> AAppFlagValues { get; set; }

    public virtual DbSet<AAppTable> AAppTables { get; set; }

    public virtual DbSet<AAppTablePfile> AAppTablePfiles { get; set; }

    public virtual DbSet<AApplication> AApplications { get; set; }

    public virtual DbSet<AApplicationFlag> AApplicationFlags { get; set; }

    public virtual DbSet<AAuthority> AAuthorities { get; set; }

    public virtual DbSet<AClientReport> AClientReports { get; set; }

    public virtual DbSet<AColumnAlias> AColumnAliases { get; set; }

    public virtual DbSet<AColumnAliasOld> AColumnAliasOlds { get; set; }

    public virtual DbSet<AConfigurationParameter> AConfigurationParameters { get; set; }

    public virtual DbSet<ADatabase> ADatabases { get; set; }

    public virtual DbSet<ADbType> ADbTypes { get; set; }

    public virtual DbSet<ADrillDown> ADrillDowns { get; set; }

    public virtual DbSet<ADrillField> ADrillFields { get; set; }

    public virtual DbSet<AEmailRptAttachment> AEmailRptAttachments { get; set; }

    public virtual DbSet<AEmailTemplate> AEmailTemplates { get; set; }

    public virtual DbSet<AEmailTemplateClient> AEmailTemplateClients { get; set; }

    public virtual DbSet<AEvent> AEvents { get; set; }

    public virtual DbSet<ALoginHistory> ALoginHistories { get; set; }

    public virtual DbSet<ALookupParam> ALookupParams { get; set; }

    public virtual DbSet<APasswordHistory> APasswordHistories { get; set; }

    public virtual DbSet<AProfile> AProfiles { get; set; }

    public virtual DbSet<AProfileFlag> AProfileFlags { get; set; }

    public virtual DbSet<AProfileUser> AProfileUsers { get; set; }

    public virtual DbSet<AQbuildForm> AQbuildForms { get; set; }

    public virtual DbSet<ARef> ARefs { get; set; }

    public virtual DbSet<AReport> AReports { get; set; }

    public virtual DbSet<AReportBatch> AReportBatches { get; set; }

    public virtual DbSet<AReportBatchRp> AReportBatchRps { get; set; }

    public virtual DbSet<AReportColumnAlias> AReportColumnAliases { get; set; }

    public virtual DbSet<AReportEmail> AReportEmails { get; set; }

    public virtual DbSet<AReportEmailDet> AReportEmailDets { get; set; }

    public virtual DbSet<AReportFav> AReportFavs { get; set; }

    public virtual DbSet<AReportForm> AReportForms { get; set; }

    public virtual DbSet<AReportGroup> AReportGroups { get; set; }

    public virtual DbSet<AReportJoin> AReportJoins { get; set; }

    public virtual DbSet<AReportParam> AReportParams { get; set; }

    public virtual DbSet<AReportSchPostStoreProc> AReportSchPostStoreProcs { get; set; }

    public virtual DbSet<AReportSchPreStoreProc> AReportSchPreStoreProcs { get; set; }

    public virtual DbSet<AReportSession> AReportSessions { get; set; }

    public virtual DbSet<AReportSmtpServer> AReportSmtpServers { get; set; }

    public virtual DbSet<AReportTableAlias> AReportTableAliases { get; set; }

    public virtual DbSet<AReportType> AReportTypes { get; set; }

    public virtual DbSet<AReportTypeConfig> AReportTypeConfigs { get; set; }

    public virtual DbSet<AReportTypeLookup> AReportTypeLookups { get; set; }

    public virtual DbSet<ARole> ARoles { get; set; }

    public virtual DbSet<AScheduler> ASchedulers { get; set; }

    public virtual DbSet<ASchedulerLog> ASchedulerLogs { get; set; }

    public virtual DbSet<ASchedulerRecurrence> ASchedulerRecurrences { get; set; }

    public virtual DbSet<ASchedulerReport> ASchedulerReports { get; set; }

    public virtual DbSet<ASchedulerReportBatch> ASchedulerReportBatches { get; set; }

    public virtual DbSet<ASchedulerReportType> ASchedulerReportTypes { get; set; }

    public virtual DbSet<ASchedulerUtility> ASchedulerUtilities { get; set; }

    public virtual DbSet<ATableAlias> ATableAliases { get; set; }

    public virtual DbSet<AUserExclude> AUserExcludes { get; set; }

    public virtual DbSet<AValidEmailPlaceholder> AValidEmailPlaceholders { get; set; }

    public virtual DbSet<ActEmailLog> ActEmailLogs { get; set; }

    public virtual DbSet<ActFaxLog> ActFaxLogs { get; set; }

    public virtual DbSet<AnsSystemMessage> AnsSystemMessages { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Contact> Contacts { get; set; }

    public virtual DbSet<ReportImportDatabaseMapping> ReportImportDatabaseMappings { get; set; }

    public virtual DbSet<ReportUtility> ReportUtilities { get; set; }

    public virtual DbSet<Site> Sites { get; set; }

    public virtual DbSet<VBorActEmailLog> VBorActEmailLogs { get; set; }

    public virtual DbSet<VColumnAlias> VColumnAliases { get; set; }

    public virtual DbSet<VColumnAliasReportForm> VColumnAliasReportForms { get; set; }

    public virtual DbSet<VLookupParam> VLookupParams { get; set; }

    public virtual DbSet<VReport> VReports { get; set; }

    public virtual DbSet<VReportColumnAlias> VReportColumnAliases { get; set; }

    public virtual DbSet<VReportForm> VReportForms { get; set; }

    public virtual DbSet<VReportJoin> VReportJoins { get; set; }

    public virtual DbSet<VReportJoinRelated> VReportJoinRelateds { get; set; }

    public virtual DbSet<VReportParam> VReportParams { get; set; }

    public virtual DbSet<VReportTableAlias> VReportTableAliases { get; set; }

    public virtual DbSet<VReportType> VReportTypes { get; set; }

    public virtual DbSet<VTableAlias> VTableAliases { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-GAMOI1TA;Database=DEREPORT;User Id=sa;Password=password123;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<AAnsUser>(entity =>
        {
            entity.HasKey(e => e.AAnsUser1);

            entity.ToTable("A_ANS_USER");

            entity.HasIndex(e => new { e.ClientNumber, e.SiteNumber, e.ContactName }, "IX_A_ANS_USER");

            entity.Property(e => e.AAnsUser1)
                .ValueGeneratedNever()
                .HasComment("ANS USERS TABLE")
                .HasColumnName("A_ANS_USER");
            entity.Property(e => e.ClientNumber).HasColumnName("CLIENT_NUMBER");
            entity.Property(e => e.ContactName)
                .HasMaxLength(35)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("SQL_Latin1_General_CP1_CS_AS")
                .HasColumnName("CONTACT_NAME");
            entity.Property(e => e.DeleteFlag).HasColumnName("DELETE_FLAG");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("EMAIL");
            entity.Property(e => e.EmailFlag).HasColumnName("EMAIL_FLAG");
            entity.Property(e => e.FullName)
                .HasMaxLength(35)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("FULL_NAME");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(18)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("LAST_UPDATED_BY");
            entity.Property(e => e.LastUpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATED_ON");
            entity.Property(e => e.LocalId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("LOCAL_ID");
            entity.Property(e => e.OperLlCode)
                .HasMaxLength(40)
                .HasColumnName("OPER_LL_CODE");
            entity.Property(e => e.ResetPwToken)
                .HasMaxLength(35)
                .HasColumnName("RESET_PW_TOKEN");
            entity.Property(e => e.SiteNumber).HasColumnName("SITE_NUMBER");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_TIME");
            entity.Property(e => e.UpdateUser)
                .HasMaxLength(18)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("UPDATE_USER");
            entity.Property(e => e.UserPassword)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnType("text")
                .HasColumnName("USER_PASSWORD");
            entity.Property(e => e.UserPasswordHash)
                .HasMaxLength(10)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("USER_PASSWORD_HASH");
            entity.Property(e => e.Username)
                .HasMaxLength(70)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("USERNAME");
            entity.Property(e => e.ValidFrom)
                .HasColumnType("datetime")
                .HasColumnName("VALID_FROM");
            entity.Property(e => e.ValidTo)
                .HasColumnType("datetime")
                .HasColumnName("VALID_TO");

            entity.HasMany(d => d.AClientReports).WithMany(p => p.AAnsUsers)
                .UsingEntity<Dictionary<string, object>>(
                    "AAnsUserClientReport",
                    r => r.HasOne<AClientReport>().WithMany()
                        .HasForeignKey("AReport", "ClientNumber")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_A_ANS_USER_CLIENT_REPORT_A_CLIENT_REPORT"),
                    l => l.HasOne<AAnsUser>().WithMany()
                        .HasForeignKey("AAnsUser")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_A_ANS_USER_CLIENT_REPORT_A_ANS_USER"),
                    j =>
                    {
                        j.HasKey("AAnsUser", "AReport", "ClientNumber");
                        j.ToTable("A_ANS_USER_CLIENT_REPORT");
                        j.IndexerProperty<int>("AAnsUser").HasColumnName("A_ANS_USER");
                        j.IndexerProperty<int>("AReport").HasColumnName("A_REPORT");
                        j.IndexerProperty<int>("ClientNumber").HasColumnName("CLIENT_NUMBER");
                    });

            entity.HasMany(d => d.Schedulers).WithMany(p => p.AAnsUsers)
                .UsingEntity<Dictionary<string, object>>(
                    "AAnsUserSchedulerEmail",
                    r => r.HasOne<AScheduler>().WithMany()
                        .HasForeignKey("SchedulerId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_A_ANS_USER_SCH_EMAIL_A_SCH"),
                    l => l.HasOne<AAnsUser>().WithMany()
                        .HasForeignKey("AAnsUser")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_A_ANS_USER_SCHEDULER_EMAIL"),
                    j =>
                    {
                        j.HasKey("AAnsUser", "SchedulerId");
                        j.ToTable("A_ANS_USER_SCHEDULER_EMAIL");
                        j.IndexerProperty<int>("AAnsUser").HasColumnName("A_ANS_USER");
                        j.IndexerProperty<int>("SchedulerId").HasColumnName("SCHEDULER_ID");
                    });
        });

        modelBuilder.Entity<AAppFlagValue>(entity =>
        {
            entity.HasKey(e => e.AAppFlagValue1);

            entity.ToTable("A_APP_FLAG_VALUE");

            entity.Property(e => e.AAppFlagValue1)
                .ValueGeneratedNever()
                .HasColumnName("A_APP_FLAG_VALUE");
            entity.Property(e => e.AApplication).HasColumnName("A_APPLICATION");
            entity.Property(e => e.AApplicationFlag).HasColumnName("A_APPLICATION_FLAG");
            entity.Property(e => e.AQbuildForm).HasColumnName("A_QBUILD_FORM");
            entity.Property(e => e.AppFlagValue).HasColumnName("APP_FLAG_VALUE");
            entity.Property(e => e.ApplicationFlag).HasColumnName("APPLICATION_FLAG");
            entity.Property(e => e.Description)
                .HasMaxLength(18)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(8)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("LAST_UPDATED_BY");
            entity.Property(e => e.LastUpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATED_ON");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_TIME");
            entity.Property(e => e.UpdateUser)
                .HasMaxLength(18)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("UPDATE_USER");

            entity.HasOne(d => d.AApplicationFlagNavigation).WithMany(p => p.AAppFlagValues)
                .HasForeignKey(d => d.AApplicationFlag)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_A_APP_FLAG_VALUE_A_APPLICATION_FLAG");
        });

        modelBuilder.Entity<AAppTable>(entity =>
        {
            entity.HasKey(e => new { e.AAppTable1, e.AApplication });

            entity.ToTable("A_APP_TABLE");

            entity.Property(e => e.AAppTable1)
                .HasMaxLength(18)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("A_APP_TABLE");
            entity.Property(e => e.AApplication).HasColumnName("A_APPLICATION");
            entity.Property(e => e.Description)
                .HasMaxLength(30)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(8)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("LAST_UPDATED_BY");
            entity.Property(e => e.LastUpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATED_ON");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_TIME");
            entity.Property(e => e.UpdateUser)
                .HasMaxLength(18)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("UPDATE_USER");

            entity.HasOne(d => d.AApplicationNavigation).WithMany(p => p.AAppTables)
                .HasForeignKey(d => d.AApplication)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_A_APP_TABLE_A_APPLICATION");
        });

        modelBuilder.Entity<AAppTablePfile>(entity =>
        {
            entity.HasKey(e => new { e.AAppTable, e.AApplication, e.AProfile });

            entity.ToTable("A_APP_TABLE_PFILE");

            entity.Property(e => e.AAppTable)
                .HasMaxLength(18)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("A_APP_TABLE");
            entity.Property(e => e.AApplication).HasColumnName("A_APPLICATION");
            entity.Property(e => e.AProfile).HasColumnName("A_PROFILE");
            entity.Property(e => e.AAuthority).HasColumnName("A_AUTHORITY");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(8)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("LAST_UPDATED_BY");
            entity.Property(e => e.LastUpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATED_ON");
            entity.Property(e => e.Priority).HasColumnName("PRIORITY");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_TIME");
            entity.Property(e => e.UpdateUser)
                .HasMaxLength(18)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("UPDATE_USER");

            entity.HasOne(d => d.AAuthorityNavigation).WithMany(p => p.AAppTablePfiles)
                .HasForeignKey(d => d.AAuthority)
                .HasConstraintName("FK_A_APP_TABLE_PFILE_A_AUTHORITY");

            entity.HasOne(d => d.AProfileNavigation).WithMany(p => p.AAppTablePfiles)
                .HasForeignKey(d => d.AProfile)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_A_APP_TABLE_PFILE_A_PROFILE");

            entity.HasOne(d => d.AAppTableNavigation).WithMany(p => p.AAppTablePfiles)
                .HasForeignKey(d => new { d.AAppTable, d.AApplication })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_A_APP_TABLE_PFILE_A_APP_TABLE");
        });

        modelBuilder.Entity<AApplication>(entity =>
        {
            entity.HasKey(e => e.AApplication1);

            entity.ToTable("A_APPLICATION");

            entity.Property(e => e.AApplication1)
                .ValueGeneratedNever()
                .HasColumnName("A_APPLICATION");
            entity.Property(e => e.AQbuildApp).HasColumnName("A_QBUILD_APP");
            entity.Property(e => e.AnsApplication)
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("ANS_APPLICATION");
            entity.Property(e => e.ApplicationComment)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnType("text")
                .HasColumnName("APPLICATION_COMMENT");
            entity.Property(e => e.ApplicationName)
                .HasMaxLength(18)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("APPLICATION_NAME");
            entity.Property(e => e.DefPasswordDays).HasColumnName("DEF_PASSWORD_DAYS");
            entity.Property(e => e.Description)
                .HasMaxLength(30)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(8)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("LAST_UPDATED_BY");
            entity.Property(e => e.LastUpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATED_ON");
            entity.Property(e => e.Organisation)
                .HasMaxLength(30)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("ORGANISATION");
            entity.Property(e => e.PasswordRules)
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("PASSWORD_RULES");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_TIME");
            entity.Property(e => e.UpdateUser)
                .HasMaxLength(18)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("UPDATE_USER");
            entity.Property(e => e.UseAdmin)
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("USE_ADMIN");
            entity.Property(e => e.UseShadowLogin)
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("USE_SHADOW_LOGIN");
        });

        modelBuilder.Entity<AApplicationFlag>(entity =>
        {
            entity.HasKey(e => e.AApplicationFlag1);

            entity.ToTable("A_APPLICATION_FLAG");

            entity.Property(e => e.AApplicationFlag1)
                .ValueGeneratedNever()
                .HasColumnName("A_APPLICATION_FLAG");
            entity.Property(e => e.AApplication).HasColumnName("A_APPLICATION");
            entity.Property(e => e.AQbuildForm).HasColumnName("A_QBUILD_FORM");
            entity.Property(e => e.ApplicationFlag).HasColumnName("APPLICATION_FLAG");
            entity.Property(e => e.Description)
                .HasMaxLength(30)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(8)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("LAST_UPDATED_BY");
            entity.Property(e => e.LastUpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATED_ON");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_TIME");
            entity.Property(e => e.UpdateUser)
                .HasMaxLength(18)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("UPDATE_USER");
            entity.Property(e => e.ValueDefault).HasColumnName("VALUE_DEFAULT");

            entity.HasOne(d => d.AApplicationNavigation).WithMany(p => p.AApplicationFlags)
                .HasForeignKey(d => d.AApplication)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_A_APPLICATION_FLAG_A_APPLICATION");

            entity.HasOne(d => d.AQbuildFormNavigation).WithMany(p => p.AApplicationFlags)
                .HasForeignKey(d => d.AQbuildForm)
                .HasConstraintName("FK_A_APPLICATION_FLAG_A_QBUILD_FORM");
        });

        modelBuilder.Entity<AAuthority>(entity =>
        {
            entity.HasKey(e => e.AAuthority1);

            entity.ToTable("A_AUTHORITY");

            entity.Property(e => e.AAuthority1)
                .ValueGeneratedNever()
                .HasColumnName("A_AUTHORITY");
            entity.Property(e => e.Description)
                .HasMaxLength(30)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(8)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("LAST_UPDATED_BY");
            entity.Property(e => e.LastUpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATED_ON");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_TIME");
            entity.Property(e => e.UpdateUser)
                .HasMaxLength(18)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("UPDATE_USER");
        });

        modelBuilder.Entity<AClientReport>(entity =>
        {
            entity.HasKey(e => new { e.AReport, e.ClientNumber });

            entity.ToTable("A_CLIENT_REPORT");

            entity.Property(e => e.AReport).HasColumnName("A_REPORT");
            entity.Property(e => e.ClientNumber).HasColumnName("CLIENT_NUMBER");
            entity.Property(e => e.ADefaultProfile).HasColumnName("A_DEFAULT_PROFILE");

            entity.HasOne(d => d.ADefaultProfileNavigation).WithMany(p => p.AClientReports)
                .HasForeignKey(d => d.ADefaultProfile)
                .HasConstraintName("FK_A_CLIENT_REPORT_A_PROFILE");

            entity.HasOne(d => d.AReportNavigation).WithMany(p => p.AClientReports)
                .HasForeignKey(d => d.AReport)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_A_CLIENT_REPORT_A_REPORT");

            entity.HasOne(d => d.ClientNumberNavigation).WithMany(p => p.AClientReports)
                .HasForeignKey(d => d.ClientNumber)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_A_CLIENT_REPORT_CLIENT");
        });

        modelBuilder.Entity<AColumnAlias>(entity =>
        {
            entity.HasKey(e => new { e.ADatabase, e.TableName, e.ColumnName });

            entity.ToTable("A_COLUMN_ALIAS");

            entity.Property(e => e.ADatabase).HasColumnName("A_DATABASE");
            entity.Property(e => e.TableName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("TABLE_NAME");
            entity.Property(e => e.ColumnName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("COLUMN_NAME");
            entity.Property(e => e.Coltype).HasColumnName("COLTYPE");
            entity.Property(e => e.ColumnAlias)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("COLUMN_ALIAS");
            entity.Property(e => e.ColumnDesc)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("COLUMN_DESC");
            entity.Property(e => e.DataFormat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DATA_FORMAT");
            entity.Property(e => e.DefaultHeading)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DEFAULT_HEADING");
            entity.Property(e => e.DefaultWidth).HasColumnName("DEFAULT_WIDTH");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.TemplateField)
                .HasMaxLength(36)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("TEMPLATE_FIELD");

            entity.HasOne(d => d.ATableAlias).WithMany(p => p.AColumnAliases)
                .HasForeignKey(d => new { d.ADatabase, d.TableName })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_A_COLUMN_ALIAS_A_TABLE_ALIAS");

            entity.HasMany(d => d.AReportForms).WithMany(p => p.AColumnAliases)
                .UsingEntity<Dictionary<string, object>>(
                    "AColumnAliasReportForm",
                    r => r.HasOne<AReportForm>().WithMany()
                        .HasForeignKey("AReportForm")
                        .HasConstraintName("FK_A_COLUMN_ALIAS_REPORT_FORM_A_REPORT_FORM"),
                    l => l.HasOne<AColumnAlias>().WithMany()
                        .HasForeignKey("ADatabase", "TableName", "ColumnName")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_A_COLUMN_ALIAS_REPORT_FORM_A_COLUMN_ALIAS"),
                    j =>
                    {
                        j.HasKey("ADatabase", "TableName", "ColumnName", "AReportForm");
                        j.ToTable("A_COLUMN_ALIAS_REPORT_FORM");
                        j.IndexerProperty<short>("ADatabase").HasColumnName("A_DATABASE");
                        j.IndexerProperty<string>("TableName")
                            .HasMaxLength(50)
                            .IsUnicode(false)
                            .UseCollation("Latin1_General_CI_AS")
                            .HasColumnName("TABLE_NAME");
                        j.IndexerProperty<string>("ColumnName")
                            .HasMaxLength(50)
                            .IsUnicode(false)
                            .UseCollation("Latin1_General_CI_AS")
                            .HasColumnName("COLUMN_NAME");
                        j.IndexerProperty<int>("AReportForm").HasColumnName("A_REPORT_FORM");
                    });
        });

        modelBuilder.Entity<AColumnAliasOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("A_COLUMN_ALIAS_old");

            entity.Property(e => e.ADatabase).HasColumnName("A_DATABASE");
            entity.Property(e => e.Coltype).HasColumnName("COLTYPE");
            entity.Property(e => e.ColumnAlias)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("COLUMN_ALIAS");
            entity.Property(e => e.ColumnDesc)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("COLUMN_DESC");
            entity.Property(e => e.ColumnName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("COLUMN_NAME");
            entity.Property(e => e.DataFormat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DATA_FORMAT");
            entity.Property(e => e.DefaultHeading)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DEFAULT_HEADING");
            entity.Property(e => e.DefaultWidth).HasColumnName("DEFAULT_WIDTH");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.TableName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("TABLE_NAME");
            entity.Property(e => e.TemplateField)
                .HasMaxLength(36)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("TEMPLATE_FIELD");
        });

        modelBuilder.Entity<AConfigurationParameter>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("A_CONFIGURATION_PARAMETERS");

            entity.Property(e => e.ConfigParameterKey)
                .HasMaxLength(30)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("CONFIG_PARAMETER_KEY");
            entity.Property(e => e.ConfigParameterValue)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("CONFIG_PARAMETER_VALUE");
            entity.Property(e => e.ConfigurationDescription)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("CONFIGURATION_DESCRIPTION");
            entity.Property(e => e.DeleteFlag).HasColumnName("DELETE_FLAG");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATED");
            entity.Property(e => e.Username)
                .HasMaxLength(25)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("USERNAME");
        });

        modelBuilder.Entity<ADatabase>(entity =>
        {
            entity.HasKey(e => e.ADatabases);

            entity.ToTable("A_DATABASES");

            entity.Property(e => e.ADatabases)
                .ValueGeneratedNever()
                .HasColumnName("A_DATABASES");
            entity.Property(e => e.AnsDbType).HasColumnName("ANS_DB_TYPE");
            entity.Property(e => e.DatabaseInitialCatalog)
                .HasMaxLength(50)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DATABASE_INITIAL_CATALOG");
            entity.Property(e => e.DatabaseName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DATABASE_NAME");
            entity.Property(e => e.DefaultPassword)
                .HasMaxLength(100)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DEFAULT_PASSWORD");
            entity.Property(e => e.DefaultUser)
                .HasMaxLength(100)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DEFAULT_USER");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.ExtendedProperties)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("EXTENDED_PROPERTIES");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("LAST_UPDATED_BY");
            entity.Property(e => e.LastUpdatedOn)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("LAST_UPDATED_ON");
            entity.Property(e => e.Patch)
                .HasMaxLength(50)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("PATCH");
            entity.Property(e => e.Version)
                .HasMaxLength(50)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("VERSION");
        });

        modelBuilder.Entity<ADbType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("A_DB_TYPE");

            entity.Property(e => e.AnsDbType).HasColumnName("ANS_DB_TYPE");
            entity.Property(e => e.Description)
                .HasMaxLength(12)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Inactive).HasColumnName("INACTIVE");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("LAST_UPDATED_BY");
            entity.Property(e => e.LastUpdatedOn)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("LAST_UPDATED_ON");
            entity.Property(e => e.ProviderName)
                .HasMaxLength(100)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("PROVIDER_NAME");
        });

        modelBuilder.Entity<ADrillDown>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("A_DRILL_DOWN");

            entity.Property(e => e.ADrillDown1).HasColumnName("A_DRILL_DOWN");
            entity.Property(e => e.AReportDrillTo).HasColumnName("A_REPORT_DRILL_TO");
            entity.Property(e => e.AReportParent).HasColumnName("A_REPORT_PARENT");
        });

        modelBuilder.Entity<ADrillField>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("A_DRILL_FIELD");

            entity.Property(e => e.ADrillDown).HasColumnName("A_DRILL_DOWN");
            entity.Property(e => e.ADrillField1).HasColumnName("A_DRILL_FIELD");
            entity.Property(e => e.DrillToParam).HasColumnName("DRILL_TO_PARAM");
            entity.Property(e => e.Operator)
                .HasMaxLength(50)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("OPERATOR");
            entity.Property(e => e.ParentDataField)
                .HasMaxLength(254)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("PARENT_DATA_FIELD");
        });

        modelBuilder.Entity<AEmailRptAttachment>(entity =>
        {
            entity.HasKey(e => new { e.AttachmentId, e.AReport });

            entity.ToTable("A_EMAIL_RPT_ATTACHMENT");

            entity.Property(e => e.AttachmentId).HasColumnName("ATTACHMENT_ID");
            entity.Property(e => e.AReport).HasColumnName("A_REPORT");
            entity.Property(e => e.ContentStream).HasColumnName("CONTENT_STREAM");
            entity.Property(e => e.FileName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("FILE_NAME");
            entity.Property(e => e.MediaType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("MEDIA_TYPE");

            entity.HasOne(d => d.AReportNavigation).WithMany(p => p.AEmailRptAttachments)
                .HasForeignKey(d => d.AReport)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_A_EMAIL_RPT_ATTCH_A_RPT");
        });

        modelBuilder.Entity<AEmailTemplate>(entity =>
        {
            entity.HasKey(e => e.AName);

            entity.ToTable("A_EMAIL_TEMPLATE");

            entity.Property(e => e.AName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("A_NAME");
            entity.Property(e => e.AFooterValue)
                .IsUnicode(false)
                .HasColumnName("A_FOOTER_VALUE");
            entity.Property(e => e.AHeaderValue)
                .IsUnicode(false)
                .HasColumnName("A_HEADER_VALUE");
            entity.Property(e => e.AValue)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnType("text")
                .HasColumnName("A_VALUE");
            entity.Property(e => e.DefaultBccEmail)
                .HasMaxLength(75)
                .HasColumnName("DEFAULT_BCC_EMAIL");
            entity.Property(e => e.DefaultEmail)
                .HasMaxLength(75)
                .HasColumnName("DEFAULT_EMAIL");
            entity.Property(e => e.MultiplePart).HasColumnName("MULTIPLE_PART");
            entity.Property(e => e.ReportGroupId).HasColumnName("REPORT_GROUP_ID");
            entity.Property(e => e.TemplateSubject)
                .HasMaxLength(150)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("TEMPLATE_SUBJECT");
        });

        modelBuilder.Entity<AEmailTemplateClient>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("A_EMAIL_TEMPLATE_CLIENT");

            entity.Property(e => e.DefaultBccEmail)
                .HasMaxLength(75)
                .HasColumnName("DEFAULT_BCC_EMAIL");
            entity.Property(e => e.DefaultEmail)
                .HasMaxLength(75)
                .HasColumnName("DEFAULT_EMAIL");
            entity.Property(e => e.TemplateSubject)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TEMPLATE_SUBJECT");
            entity.Property(e => e.TemplateValue)
                .HasColumnType("text")
                .HasColumnName("TEMPLATE_VALUE");
            entity.Property(e => e.Uniqueid).HasColumnName("UNIQUEID");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<AEvent>(entity =>
        {
            entity.HasKey(e => new { e.AEvent1, e.AAnsUser, e.EventType, e.EventDate });

            entity.ToTable("A_EVENT");

            entity.Property(e => e.AEvent1).HasColumnName("A_EVENT");
            entity.Property(e => e.AAnsUser)
                .HasComment("USER ID")
                .HasColumnName("A_ANS_USER");
            entity.Property(e => e.EventType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("THE TYPE OF THE EVENT")
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("EVENT_TYPE");
            entity.Property(e => e.EventDate)
                .HasComment("DATE AND TIME WHEN THE EVENT TOOK PLACE")
                .HasColumnType("datetime")
                .HasColumnName("EVENT_DATE");
            entity.Property(e => e.ModEventDate)
                .HasComment("DATE AND TIME WHEN THE SAME EVENT WAS MODIFIED")
                .HasColumnType("datetime")
                .HasColumnName("MOD_EVENT_DATE");

            entity.HasOne(d => d.AAnsUserNavigation).WithMany(p => p.AEvents)
                .HasForeignKey(d => d.AAnsUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_A_EVENT_A_ANS_USER");
        });

        modelBuilder.Entity<ALoginHistory>(entity =>
        {
            entity.HasKey(e => new { e.AAnsUser, e.AccessDatetime });

            entity.ToTable("A_LOGIN_HISTORY");

            entity.Property(e => e.AAnsUser).HasColumnName("A_ANS_USER");
            entity.Property(e => e.AccessDatetime)
                .HasColumnType("datetime")
                .HasColumnName("ACCESS_DATETIME");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(32)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("LAST_UPDATED_BY");
            entity.Property(e => e.LastUpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATED_ON");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_TIME");
            entity.Property(e => e.UpdateUser)
                .HasMaxLength(32)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("UPDATE_USER");

            entity.HasOne(d => d.AAnsUserNavigation).WithMany(p => p.ALoginHistories)
                .HasForeignKey(d => d.AAnsUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_A_LOGIN_HISTORY_A_ANS_USER");
        });

        modelBuilder.Entity<ALookupParam>(entity =>
        {
            entity.ToTable("A_LOOKUP_PARAM");

            entity.Property(e => e.ALookupParamId)
                .ValueGeneratedNever()
                .HasColumnName("A_LOOKUP_PARAM_ID");
            entity.Property(e => e.ADatabase).HasColumnName("A_DATABASE");
            entity.Property(e => e.ALookupDefinition)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnType("text")
                .HasColumnName("A_LOOKUP_DEFINITION");
            entity.Property(e => e.ALookupParamName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("A_LOOKUP_PARAM_NAME");
            entity.Property(e => e.DeleteFlag).HasColumnName("DELETE_FLAG");
        });

        modelBuilder.Entity<APasswordHistory>(entity =>
        {
            entity.HasKey(e => new { e.APasswordHistory1, e.AAnsUser });

            entity.ToTable("A_PASSWORD_HISTORY");

            entity.Property(e => e.APasswordHistory1).HasColumnName("A_PASSWORD_HISTORY");
            entity.Property(e => e.AAnsUser).HasColumnName("A_ANS_USER");
            entity.Property(e => e.APassword)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnType("text")
                .HasColumnName("A_PASSWORD");
            entity.Property(e => e.Deleted)
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DELETED");
            entity.Property(e => e.UserName)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnType("text")
                .HasColumnName("USER_NAME");
            entity.Property(e => e.ValidFrom)
                .HasColumnType("datetime")
                .HasColumnName("VALID_FROM");
            entity.Property(e => e.ValidTo)
                .HasColumnType("datetime")
                .HasColumnName("VALID_TO");

            entity.HasOne(d => d.AAnsUserNavigation).WithMany(p => p.APasswordHistories)
                .HasForeignKey(d => d.AAnsUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_A_PASSWORD_HISTORY_A_ANS_USER");
        });

        modelBuilder.Entity<AProfile>(entity =>
        {
            entity.HasKey(e => e.AProfile1);

            entity.ToTable("A_PROFILE");

            entity.HasIndex(e => e.Description, "IX_A_PROFILE_DESCRIPTION").IsUnique();

            entity.Property(e => e.AProfile1)
                .ValueGeneratedNever()
                .HasColumnName("A_PROFILE");
            entity.Property(e => e.DataAccessLevel).HasColumnName("DATA_ACCESS_LEVEL");
            entity.Property(e => e.DeleteFlag).HasColumnName("DELETE_FLAG");
            entity.Property(e => e.Description)
                .HasMaxLength(30)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(18)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("LAST_UPDATED_BY");
            entity.Property(e => e.LastUpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATED_ON");
            entity.Property(e => e.LocalId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("LOCAL_ID");
            entity.Property(e => e.ProfilePassword)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnType("text")
                .HasColumnName("PROFILE_PASSWORD");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_TIME");
            entity.Property(e => e.UpdateUser)
                .HasMaxLength(18)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("UPDATE_USER");
            entity.Property(e => e.UserName)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnType("text")
                .HasColumnName("USER_NAME");
        });

        modelBuilder.Entity<AProfileFlag>(entity =>
        {
            entity.HasKey(e => new { e.AProfile, e.AApplicationFlag });

            entity.ToTable("A_PROFILE_FLAG");

            entity.Property(e => e.AProfile).HasColumnName("A_PROFILE");
            entity.Property(e => e.AApplicationFlag).HasColumnName("A_APPLICATION_FLAG");
            entity.Property(e => e.AAppFlagValue).HasColumnName("A_APP_FLAG_VALUE");
            entity.Property(e => e.AApplication).HasColumnName("A_APPLICATION");
            entity.Property(e => e.AQbuildForm).HasColumnName("A_QBUILD_FORM");
            entity.Property(e => e.AppFlagValue).HasColumnName("APP_FLAG_VALUE");
            entity.Property(e => e.ApplicationFlag).HasColumnName("APPLICATION_FLAG");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(8)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("LAST_UPDATED_BY");
            entity.Property(e => e.LastUpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATED_ON");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_TIME");
            entity.Property(e => e.UpdateUser)
                .HasMaxLength(18)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("UPDATE_USER");

            entity.HasOne(d => d.AApplicationFlagNavigation).WithMany(p => p.AProfileFlags)
                .HasForeignKey(d => d.AApplicationFlag)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_A_PROFILE_FLAG_A_APPLICATION_FLAG");

            entity.HasOne(d => d.AProfileNavigation).WithMany(p => p.AProfileFlags)
                .HasForeignKey(d => d.AProfile)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_A_PROFILE_FLAG_A_PROFILE");
        });

        modelBuilder.Entity<AProfileUser>(entity =>
        {
            entity.HasKey(e => new { e.AProfile, e.AAnsUser });

            entity.ToTable("A_PROFILE_USER");

            entity.Property(e => e.AProfile).HasColumnName("A_PROFILE");
            entity.Property(e => e.AAnsUser).HasColumnName("A_ANS_USER");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(8)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("LAST_UPDATED_BY");
            entity.Property(e => e.LastUpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATED_ON");
            entity.Property(e => e.Role)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("ROLE");

            entity.HasOne(d => d.AAnsUserNavigation).WithMany(p => p.AProfileUsers)
                .HasForeignKey(d => d.AAnsUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_A_PROFILE_USER_A_ANS_USER");

            entity.HasOne(d => d.AProfileNavigation).WithMany(p => p.AProfileUsers)
                .HasForeignKey(d => d.AProfile)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_A_PROFILE_USER_A_PROFILE");
        });

        modelBuilder.Entity<AQbuildForm>(entity =>
        {
            entity.HasKey(e => e.AQbuildForm1);

            entity.ToTable("A_QBUILD_FORM");

            entity.Property(e => e.AQbuildForm1)
                .ValueGeneratedNever()
                .HasColumnName("A_QBUILD_FORM");
            entity.Property(e => e.AQbuildApp).HasColumnName("A_QBUILD_APP");
            entity.Property(e => e.AQbuildFormGrp).HasColumnName("A_QBUILD_FORM_GRP");
            entity.Property(e => e.AutopopSearchFrm).HasColumnName("AUTOPOP_SEARCH_FRM");
            entity.Property(e => e.CompHtmlFile)
                .HasMaxLength(254)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("COMP_HTML_FILE");
            entity.Property(e => e.FormName)
                .HasMaxLength(254)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("FORM_NAME");
            entity.Property(e => e.FormPageHelp)
                .HasMaxLength(254)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("FORM_PAGE_HELP");
            entity.Property(e => e.FormPicklistSett)
                .HasMaxLength(80)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("FORM_PICKLIST_SETT");
            entity.Property(e => e.FormPicklistSql)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnType("text")
                .HasColumnName("FORM_PICKLIST_SQL");
            entity.Property(e => e.FormSequenceNo).HasColumnName("FORM_SEQUENCE_NO");
            entity.Property(e => e.FormType).HasColumnName("FORM_TYPE");
            entity.Property(e => e.HeaderFormula)
                .HasMaxLength(254)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("HEADER_FORMULA");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(8)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("LAST_UPDATED_BY");
            entity.Property(e => e.LastUpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATED_ON");
            entity.Property(e => e.MaxPlCount).HasColumnName("MAX_PL_COUNT");
            entity.Property(e => e.NoDuplicates)
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("NO_DUPLICATES");
            entity.Property(e => e.PicklistFields)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("PICKLIST_FIELDS");
            entity.Property(e => e.ProcedureParams)
                .HasMaxLength(254)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("PROCEDURE_PARAMS");
            entity.Property(e => e.RefreshAfterSp)
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("REFRESH_AFTER_SP");
            entity.Property(e => e.SearchFormType)
                .HasMaxLength(40)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("SEARCH_FORM_TYPE");
            entity.Property(e => e.SearchPageHelp)
                .HasMaxLength(254)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("SEARCH_PAGE_HELP");
            entity.Property(e => e.SpCallMode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("SP_CALL_MODE");
            entity.Property(e => e.SpCallOrder)
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("SP_CALL_ORDER");
            entity.Property(e => e.SpReturnError).HasColumnName("SP_RETURN_ERROR");
            entity.Property(e => e.StartForm).HasColumnName("START_FORM");
            entity.Property(e => e.StoredProc)
                .HasMaxLength(18)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("STORED_PROC");
            entity.Property(e => e.WebNullPlQuery)
                .HasMaxLength(254)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("WEB_NULL_PL_QUERY");
            entity.Property(e => e.WebRecsPerTab).HasColumnName("WEB_RECS_PER_TAB");
            entity.Property(e => e.WebRecsPicklist).HasColumnName("WEB_RECS_PICKLIST");
        });

        modelBuilder.Entity<ARef>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("A_REF");

            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(8)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("LAST_UPDATED_BY");
            entity.Property(e => e.LastUpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATED_ON");
            entity.Property(e => e.Ref)
                .HasMaxLength(32)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("REF");
            entity.Property(e => e.Value).HasColumnName("VALUE");
        });

        modelBuilder.Entity<AReport>(entity =>
        {
            entity.HasKey(e => e.AReport1);

            entity.ToTable("A_REPORT");

            entity.Property(e => e.AReport1)
                .ValueGeneratedNever()
                .HasColumnName("A_REPORT");
            entity.Property(e => e.ADatabase).HasColumnName("A_DATABASE");
            entity.Property(e => e.AReportGroup).HasColumnName("A_REPORT_GROUP");
            entity.Property(e => e.AuthLevel)
                .HasDefaultValue(0)
                .HasColumnName("AUTH_LEVEL");
            entity.Property(e => e.BatchSeqNo).HasColumnName("BATCH_SEQ_NO");
            entity.Property(e => e.BookField)
                .HasMaxLength(1)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("BOOK_FIELD");
            entity.Property(e => e.Bookmark)
                .HasMaxLength(254)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("BOOKMARK");
            entity.Property(e => e.ClientBaseReport).HasColumnName("CLIENT_BASE_REPORT");
            entity.Property(e => e.Crlf)
                .HasMaxLength(18)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("CRLF");
            entity.Property(e => e.CsvFilename)
                .HasMaxLength(50)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("CSV_FILENAME");
            entity.Property(e => e.CsvHeader)
                .HasMaxLength(1)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("CSV_HEADER");
            entity.Property(e => e.CsvOverwrite).HasColumnName("CSV_OVERWRITE");
            entity.Property(e => e.DateFormat)
                .HasMaxLength(40)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DATE_FORMAT");
            entity.Property(e => e.DefaultEmailSubject)
                .HasMaxLength(200)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DEFAULT_EMAIL_SUBJECT");
            entity.Property(e => e.Definition)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DEFINITION");
            entity.Property(e => e.DeleteFlag).HasColumnName("DELETE_FLAG");
            entity.Property(e => e.Delimiter)
                .HasMaxLength(18)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DELIMITER");
            entity.Property(e => e.DistinctFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DISTINCT_FLAG");
            entity.Property(e => e.EmailDeliveryReceipt).HasColumnName("EMAIL_DELIVERY_RECEIPT");
            entity.Property(e => e.EmailFlag).HasColumnName("EMAIL_FLAG");
            entity.Property(e => e.EmailReadReceipt).HasColumnName("EMAIL_READ_RECEIPT");
            entity.Property(e => e.EmailTemplate)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("EMAIL_TEMPLATE");
            entity.Property(e => e.FreeHandSqlFlag).HasColumnName("FREE_HAND_SQL_FLAG");
            entity.Property(e => e.Graphical).HasColumnName("GRAPHICAL");
            entity.Property(e => e.ImportId).HasColumnName("IMPORT_ID");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("LAST_UPDATED_BY");
            entity.Property(e => e.LastUpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATED_ON");
            entity.Property(e => e.MailFields)
                .HasMaxLength(1)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("MAIL_FIELDS");
            entity.Property(e => e.MailFrom)
                .HasMaxLength(100)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("MAIL_FROM");
            entity.Property(e => e.MailTo)
                .HasMaxLength(250)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("MAIL_TO");
            entity.Property(e => e.MailmergeFile)
                .HasMaxLength(250)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("MAILMERGE_FILE");
            entity.Property(e => e.NamingKey)
                .HasMaxLength(50)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("NAMING_KEY");
            entity.Property(e => e.NamingPrefix)
                .HasMaxLength(18)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("NAMING_PREFIX");
            entity.Property(e => e.PassParamsToQrp).HasColumnName("PASS_PARAMS_TO_QRP");
            entity.Property(e => e.PositionInGroup).HasColumnName("POSITION_IN_GROUP");
            entity.Property(e => e.PostStoredProc)
                .HasMaxLength(150)
                .HasColumnName("POST_STORED_PROC");
            entity.Property(e => e.PreStoredProc)
                .HasMaxLength(150)
                .HasColumnName("PRE_STORED_PROC");
            entity.Property(e => e.Priority).HasColumnName("PRIORITY");
            entity.Property(e => e.ProcParams)
                .HasMaxLength(254)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("PROC_PARAMS");
            entity.Property(e => e.RepQrpTitle1)
                .HasMaxLength(120)
                .HasColumnName("REP_QRP_TITLE1");
            entity.Property(e => e.RepQrpTitle2)
                .HasMaxLength(120)
                .HasColumnName("REP_QRP_TITLE2");
            entity.Property(e => e.ReportCrystal)
                .HasMaxLength(254)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("REPORT_CRYSTAL");
            entity.Property(e => e.ReportDesc)
                .HasMaxLength(500)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("REPORT_DESC");
            entity.Property(e => e.ReportName)
                .HasMaxLength(80)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("REPORT_NAME");
            entity.Property(e => e.ReportQrp)
                .HasMaxLength(254)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("REPORT_QRP");
            entity.Property(e => e.ReportTemplateFlag).HasColumnName("REPORT_TEMPLATE_FLAG");
            entity.Property(e => e.ReportTypeDef)
                .HasMaxLength(80)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("REPORT_TYPE_DEF");
            entity.Property(e => e.Separator)
                .HasMaxLength(18)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("SEPARATOR");
            entity.Property(e => e.SmtpServerId).HasColumnName("SMTP_SERVER_ID");
            entity.Property(e => e.StandardTextId).HasColumnName("STANDARD_TEXT_ID");
            entity.Property(e => e.StoredProc)
                .HasMaxLength(50)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("STORED_PROC");
            entity.Property(e => e.Switcher)
                .HasMaxLength(18)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("SWITCHER");
            entity.Property(e => e.SystemReport).HasColumnName("SYSTEM_REPORT");
            entity.Property(e => e.TableViewFlag).HasColumnName("TABLE_VIEW_FLAG");
            entity.Property(e => e.TargetDatabase)
                .HasMaxLength(18)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("TARGET_DATABASE");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_TIME");
            entity.Property(e => e.UpdateUser)
                .HasMaxLength(18)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("UPDATE_USER");
            entity.Property(e => e.WordTemplate)
                .HasMaxLength(254)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("WORD_TEMPLATE");
            entity.Property(e => e.XmlFilename)
                .HasMaxLength(50)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("XML_FILENAME");

            entity.HasOne(d => d.AReportGroupNavigation).WithMany(p => p.AReports)
                .HasForeignKey(d => d.AReportGroup)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_A_REPORT_A_REPORT_GROUP");

            entity.HasOne(d => d.SmtpServer).WithMany(p => p.AReports)
                .HasForeignKey(d => d.SmtpServerId)
                .HasConstraintName("FK_A_REPORT_SMTP_SERVER");

            entity.HasMany(d => d.AReportJoins).WithMany(p => p.AReports)
                .UsingEntity<Dictionary<string, object>>(
                    "AReportJoinRelated",
                    r => r.HasOne<AReportJoin>().WithMany()
                        .HasForeignKey("AReportJoin")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_A_REPORT_JOIN_RELATED_A_REPORT_JOINS"),
                    l => l.HasOne<AReport>().WithMany()
                        .HasForeignKey("AReport")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_A_REPORT_JOIN_RELATED_A_REPORT"),
                    j =>
                    {
                        j.HasKey("AReport", "AReportJoin");
                        j.ToTable("A_REPORT_JOIN_RELATED");
                        j.IndexerProperty<int>("AReport").HasColumnName("A_REPORT");
                        j.IndexerProperty<int>("AReportJoin").HasColumnName("A_REPORT_JOIN");
                    });
        });

        modelBuilder.Entity<AReportBatch>(entity =>
        {
            entity.HasKey(e => e.AReportBatch1);

            entity.ToTable("A_REPORT_BATCH");

            entity.Property(e => e.AReportBatch1)
                .ValueGeneratedNever()
                .HasColumnName("A_REPORT_BATCH");
            entity.Property(e => e.BatchGrpName)
                .HasMaxLength(80)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("BATCH_GRP_NAME");
            entity.Property(e => e.DeleteFlag).HasColumnName("DELETE_FLAG");
            entity.Property(e => e.Flag)
                .HasMaxLength(30)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("FLAG");
        });

        modelBuilder.Entity<AReportBatchRp>(entity =>
        {
            entity.HasKey(e => new { e.AReportBatch, e.AReport });

            entity.ToTable("A_REPORT_BATCH_RP");

            entity.Property(e => e.AReportBatch).HasColumnName("A_REPORT_BATCH");
            entity.Property(e => e.AReport).HasColumnName("A_REPORT");
            entity.Property(e => e.BatchSeqNo).HasColumnName("BATCH_SEQ_NO");
            entity.Property(e => e.OutputFilename)
                .HasMaxLength(50)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("OUTPUT_FILENAME");

            entity.HasOne(d => d.AReportNavigation).WithMany(p => p.AReportBatchRps)
                .HasForeignKey(d => d.AReport)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_A_REPORT_BATCH_A_REPORT");

            entity.HasOne(d => d.AReportBatchNavigation).WithMany(p => p.AReportBatchRps)
                .HasForeignKey(d => d.AReportBatch)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_A_REPORT_BATCH_RP");
        });

        modelBuilder.Entity<AReportColumnAlias>(entity =>
        {
            entity.HasKey(e => new { e.AReport, e.ADatabase, e.TableName, e.ColumnName, e.Position });

            entity.ToTable("A_REPORT_COLUMN_ALIAS");

            entity.HasIndex(e => e.AReport, "IX_A_REPORT_COLUMN_ALIAS");

            entity.Property(e => e.AReport).HasColumnName("A_REPORT");
            entity.Property(e => e.ADatabase).HasColumnName("A_DATABASE");
            entity.Property(e => e.TableName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("TABLE_NAME");
            entity.Property(e => e.ColumnName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("COLUMN_NAME");
            entity.Property(e => e.Position).HasColumnName("POSITION");
            entity.Property(e => e.AggFunction).HasColumnName("AGG_FUNCTION");
            entity.Property(e => e.DataFormat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DATA_FORMAT");
            entity.Property(e => e.EmailFlag).HasColumnName("EMAIL_FLAG");
            entity.Property(e => e.FootFunction).HasColumnName("FOOT_FUNCTION");
            entity.Property(e => e.FootLabel)
                .HasMaxLength(40)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("FOOT_LABEL");
            entity.Property(e => e.Heading)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("HEADING");
            entity.Property(e => e.SortOrder).HasColumnName("SORT_ORDER");
            entity.Property(e => e.TemplateField)
                .HasMaxLength(36)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("TEMPLATE_FIELD");
            entity.Property(e => e.Visible).HasColumnName("VISIBLE");
            entity.Property(e => e.Width).HasColumnName("WIDTH");

            entity.HasOne(d => d.AReportNavigation).WithMany(p => p.AReportColumnAliases)
                .HasForeignKey(d => d.AReport)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_A_REPORT_COLUMN_ALIAS_A_REPORT");

            entity.HasOne(d => d.AColumnAlias).WithMany(p => p.AReportColumnAliases)
                .HasForeignKey(d => new { d.ADatabase, d.TableName, d.ColumnName })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_A_REPORT_COLUMN_ALIAS_A_COLUMN_ALIAS");
        });

        modelBuilder.Entity<AReportEmail>(entity =>
        {
            entity.ToTable("A_REPORT_EMAIL");

            entity.Property(e => e.AReportEmailId)
                .ValueGeneratedNever()
                .HasColumnName("A_REPORT_EMAIL_ID");
            entity.Property(e => e.AReport).HasColumnName("A_REPORT");
            entity.Property(e => e.AddAttachments)
                .HasComment("A Boolean flag to indicate whether this email has attachments. If this field contains a 1 the ATTACH_FILE_NAMES column is parsed to figure out the filenames. If this column contains a 0 (default) then the ATTACH_FILE_NAMES column is ignored.")
                .HasColumnName("ADD_ATTACHMENTS");
            entity.Property(e => e.AttachFileNames)
                .HasComment("Specifies the filenames of attachments to be included. The files must exist in the directory configured by the AttachFileDir setting in the config.ini. If one is missing the email will fail. These documents will be deleted once the email is sent. Names must be separated by a semi-colon (“;”).")
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("ATTACH_FILE_NAMES");
            entity.Property(e => e.BccEmail)
                .HasComment("Comma separated list of email addresses to Bcc the email to. If you want to include real names in this list use the following format:")
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("BCC_EMAIL");
            entity.Property(e => e.BodyHtml)
                .HasComment("The HTML code used to send when sending an HTML email. The plaint text version of the email will be generated from this code. This field is ignored when sending a plain text only email.")
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("BODY_HTML");
            entity.Property(e => e.BodyText)
                .HasComment("The body text used when sending a plain text only email. Ignored when sending HTML emails. If IS_ICALENDAR (see below) is set to 1 this field contains the text representing the appointment being sent, in compliance with RFC2445. ")
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("BODY_TEXT");
            entity.Property(e => e.CcEmail)
                .HasComment("Comma separated list of email addresses to Cc the email to. If you want to include real names in this list use the following format:")
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("CC_EMAIL");
            entity.Property(e => e.DateTimeDelivery)
                .HasComment("This is the date time when you want to send this email out. If you want to send it out as soon as possible so we set it NULL or the time in the past.")
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_DELIVERY");
            entity.Property(e => e.DateTimeRequest)
                .HasComment("The date and time the request record was inserted in to the table. Should be populated by the calling application.")
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_REQUEST");
            entity.Property(e => e.DateTimeSent)
                .HasComment("The date and time that the Email Sender processed the request.")
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_SENT");
            entity.Property(e => e.DeliveryReceipt)
                .HasComment("Set to 1 to enable a \"delivery receipt\" for the email that is sent. Will get sent back to the email address in the FROM_EMAIL field")
                .HasColumnName("DELIVERY_RECEIPT");
            entity.Property(e => e.EmailSentBy)
                .HasMaxLength(70)
                .HasComment("The application user or module that placed the request. Can be free text, if not required just fill with an arbitrary string of your choice.")
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("EMAIL_SENT_BY");
            entity.Property(e => e.EmailStatus)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasComment("Status of the email request. Can contain one of the following values:")
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("EMAIL_STATUS");
            entity.Property(e => e.ErrorLog)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("ERROR_LOG");
            entity.Property(e => e.FromEmail)
                .HasMaxLength(100)
                .HasComment("Specify the source email address.")
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("FROM_EMAIL");
            entity.Property(e => e.FromName)
                .HasMaxLength(60)
                .HasComment("The visible “real name” of the sender of the email. Fill in the sender’s real name. You should avoid characters like “<” and “>”.")
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("FROM_NAME");
            entity.Property(e => e.IcalMime)
                .HasMaxLength(100)
                .HasComment("This field must be filled in with the additional section required by the iCalendar protocol (RFC 2447). This field represents the “method=xyz” part of the content type header. This field will be ignored unless IS_ICALENDAR (above) is set to 1.")
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("ICAL_MIME");
            entity.Property(e => e.IsIcalendar)
                .HasComment("Set this column to indicate that this email should be a specially formatted one used to send appointments to PIM applications (Outlook et al). Before using this setting we recommend that you become familiar with the Internet standard on iCalendar (RFCs 2445, 2446 and 2447). When this is set to 1 only BODY_TEXT, the addressing fields, ICAL_MIME and subject field are used when creating the email – all others are ignored. The ICAL_MIME field MUST also be filled in with the correct value (see RFC 2447) for the iCalendar object you are sending.")
                .HasColumnName("IS_ICALENDAR");
            entity.Property(e => e.NonMimeWarning)
                .HasMaxLength(254)
                .HasComment("The normally invisible warning text that is shown when a MIME email (i.e. an HTML or one with attachments) is viewed in a non-MIME email client.")
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("NON_MIME_WARNING");
            entity.Property(e => e.ReadReceipt)
                .HasComment("Set to 1 to enable a “read receipt” for the email that is sent. The read notification will get sent back to the email address in the FROM_EMAIL field")
                .HasColumnName("READ_RECEIPT");
            entity.Property(e => e.SchedulerId).HasColumnName("SCHEDULER_ID");
            entity.Property(e => e.SendHtml)
                .HasComment("A Boolean flag to indicate whether this email should be sent using HTML (and hence the text from BODY_HTML) or plain text (BODY_TEXT is then used). Valid value are 0 for plain text and 1 for HTML.")
                .HasColumnName("SEND_HTML");
            entity.Property(e => e.SmtpServerId)
                .HasComment("Foreign key for A_REPORT_SMTP_SERVER.")
                .HasColumnName("SMTP_SERVER_ID");
            entity.Property(e => e.Subject)
                .HasMaxLength(100)
                .HasComment("The subject of the email.")
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("SUBJECT");
            entity.Property(e => e.ToEmail)
                .HasMaxLength(100)
                .HasComment("Specify the destination email address.")
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("TO_EMAIL");
            entity.Property(e => e.ToName)
                .HasMaxLength(60)
                .HasComment("The visible “real name” of the intended recipient of the email. Fill in the recipient’s real name. You should avoid characters like “<” and “>”.")
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("TO_NAME");

            entity.HasOne(d => d.AReportNavigation).WithMany(p => p.AReportEmails)
                .HasForeignKey(d => d.AReport)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_A_REPORT_EMAIL_A_REPORT");

            entity.HasOne(d => d.Scheduler).WithMany(p => p.AReportEmails)
                .HasForeignKey(d => d.SchedulerId)
                .HasConstraintName("FK_A_REPORT_EMAIL_A_SCHEDULER");

            entity.HasOne(d => d.SmtpServer).WithMany(p => p.AReportEmails)
                .HasForeignKey(d => d.SmtpServerId)
                .HasConstraintName("FK_EMAIL_A_REPORT_SMTP");
        });

        modelBuilder.Entity<AReportEmailDet>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("A_REPORT_EMAIL_DET");

            entity.Property(e => e.AReportEmailDet1).HasColumnName("A_REPORT_EMAIL_DET");
            entity.Property(e => e.Username)
                .HasMaxLength(40)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("USERNAME");
            entity.Property(e => e.UsersEmail)
                .HasMaxLength(100)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("USERS_EMAIL");
            entity.Property(e => e.UsersName)
                .HasMaxLength(100)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("USERS_NAME");
        });

        modelBuilder.Entity<AReportFav>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("A_REPORT_FAVS");

            entity.Property(e => e.AReport).HasColumnName("A_REPORT");
            entity.Property(e => e.AReportFavs).HasColumnName("A_REPORT_FAVS");
            entity.Property(e => e.AReportGroup).HasColumnName("A_REPORT_GROUP");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.GroupDesc)
                .HasMaxLength(64)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("GROUP_DESC");
            entity.Property(e => e.Params)
                .HasColumnType("image")
                .HasColumnName("PARAMS");
            entity.Property(e => e.ReportDesc)
                .HasMaxLength(128)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("REPORT_DESC");
            entity.Property(e => e.Username)
                .HasMaxLength(40)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("USERNAME");
        });

        modelBuilder.Entity<AReportForm>(entity =>
        {
            entity.HasKey(e => e.AReportForm1);

            entity.ToTable("A_REPORT_FORM");

            entity.Property(e => e.AReportForm1)
                .ValueGeneratedNever()
                .HasColumnName("A_REPORT_FORM");
            entity.Property(e => e.ADatabase).HasColumnName("A_DATABASE");
            entity.Property(e => e.AReportFormDesc)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("A_REPORT_FORM_DESC");
            entity.Property(e => e.AReportFormName)
                .HasMaxLength(80)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("A_REPORT_FORM_NAME");

            entity.HasOne(d => d.ADatabaseNavigation).WithMany(p => p.AReportForms)
                .HasForeignKey(d => d.ADatabase)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_A_REPORT_FORM_A_DATABASES");
        });

        modelBuilder.Entity<AReportGroup>(entity =>
        {
            entity.HasKey(e => e.AReportGroup1);

            entity.ToTable("A_REPORT_GROUP");

            entity.Property(e => e.AReportGroup1)
                .ValueGeneratedNever()
                .HasColumnName("A_REPORT_GROUP");
            entity.Property(e => e.DefaultReport).HasColumnName("DEFAULT_REPORT");
            entity.Property(e => e.DeleteFlag).HasColumnName("DELETE_FLAG");
            entity.Property(e => e.Flag)
                .HasMaxLength(30)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("FLAG");
            entity.Property(e => e.IconContentType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("ICON_CONTENT_TYPE");
            entity.Property(e => e.IconData).HasColumnName("ICON_DATA");
            entity.Property(e => e.IconImageGroup)
                .HasMaxLength(30)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("ICON_IMAGE_GROUP");
            entity.Property(e => e.Position).HasColumnName("POSITION");
            entity.Property(e => e.ReportGrpName)
                .HasMaxLength(64)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("REPORT_GRP_NAME");
            entity.Property(e => e.StandardLetter)
                .HasMaxLength(15)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("STANDARD_LETTER");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_TIME");
            entity.Property(e => e.UpdateUser)
                .HasMaxLength(18)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("UPDATE_USER");
        });

        modelBuilder.Entity<AReportJoin>(entity =>
        {
            entity.HasKey(e => e.AReportJoin1);

            entity.ToTable("A_REPORT_JOINS");

            entity.Property(e => e.AReportJoin1)
                .ValueGeneratedNever()
                .HasColumnName("A_REPORT_JOIN");
            entity.Property(e => e.ADatabase).HasColumnName("A_DATABASE");
            entity.Property(e => e.JoinCondition)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("JOIN_CONDITION");
            entity.Property(e => e.Table1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("TABLE1");
            entity.Property(e => e.Table2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("TABLE2");

            entity.HasOne(d => d.ATableAlias).WithMany(p => p.AReportJoinATableAliases)
                .HasForeignKey(d => new { d.ADatabase, d.Table1 })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_A_REPORT_JOINS_A_TABLE_ALIAS");

            entity.HasOne(d => d.ATableAliasNavigation).WithMany(p => p.AReportJoinATableAliasNavigations)
                .HasForeignKey(d => new { d.ADatabase, d.Table2 })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_A_REPORT_JOINS_A_TABLE_ALIAS1");
        });

        modelBuilder.Entity<AReportParam>(entity =>
        {
            entity.HasKey(e => e.AReportParam1);

            entity.ToTable("A_REPORT_PARAM");

            entity.Property(e => e.AReportParam1)
                .ValueGeneratedNever()
                .HasColumnName("A_REPORT_PARAM");
            entity.Property(e => e.ALookupParamId).HasColumnName("A_LOOKUP_PARAM_ID");
            entity.Property(e => e.AReport).HasColumnName("A_REPORT");
            entity.Property(e => e.AndOrOperator)
                .HasMaxLength(3)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("AND_OR_OPERATOR");
            entity.Property(e => e.CloseBrace)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("CLOSE_BRACE");
            entity.Property(e => e.Coltype)
                .HasMaxLength(18)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("COLTYPE");
            entity.Property(e => e.DataEquation)
                .HasMaxLength(254)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DATA_EQUATION");
            entity.Property(e => e.DataField)
                .HasMaxLength(254)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DATA_FIELD");
            entity.Property(e => e.DefaultOperator)
                .HasMaxLength(15)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DEFAULT_OPERATOR");
            entity.Property(e => e.DefaultValue)
                .HasMaxLength(254)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DEFAULT_VALUE");
            entity.Property(e => e.DisplayOperator)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("Y")
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DISPLAY_OPERATOR");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(8)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("LAST_UPDATED_BY");
            entity.Property(e => e.LastUpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATED_ON");
            entity.Property(e => e.LookUp)
                .HasColumnType("image")
                .HasColumnName("LOOK_UP");
            entity.Property(e => e.Mandatory)
                .HasMaxLength(1)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("MANDATORY");
            entity.Property(e => e.NotOperator)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("NOT_OPERATOR");
            entity.Property(e => e.OpenBrace)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("OPEN_BRACE");
            entity.Property(e => e.ParamDesc)
                .HasMaxLength(254)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("PARAM_DESC");
            entity.Property(e => e.ParamName)
                .HasMaxLength(64)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("PARAM_NAME");
            entity.Property(e => e.PassToCrw)
                .HasMaxLength(1)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("PASS_TO_CRW");
            entity.Property(e => e.PassToSp)
                .HasMaxLength(1)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("PASS_TO_SP");
            entity.Property(e => e.PostParamOrderno).HasColumnName("POST_PARAM_ORDERNO");
            entity.Property(e => e.PostReportParam)
                .HasMaxLength(1)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("POST_REPORT_PARAM");
            entity.Property(e => e.PostStoredParam)
                .HasMaxLength(36)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("POST_STORED_PARAM");
            entity.Property(e => e.PostStoredProc)
                .HasMaxLength(35)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("POST_STORED_PROC");
            entity.Property(e => e.PreParamOrderno).HasColumnName("PRE_PARAM_ORDERNO");
            entity.Property(e => e.PreReportParam)
                .HasMaxLength(1)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("PRE_REPORT_PARAM");
            entity.Property(e => e.PreStoredParam)
                .HasMaxLength(36)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("PRE_STORED_PARAM");
            entity.Property(e => e.PreStoredProc)
                .HasMaxLength(35)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("PRE_STORED_PROC");
            entity.Property(e => e.SpParamOrderNo).HasColumnName("SP_PARAM_ORDER_NO");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_TIME");
            entity.Property(e => e.UpdateUser)
                .HasMaxLength(18)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("UPDATE_USER");

            entity.HasOne(d => d.ALookupParam).WithMany(p => p.AReportParams)
                .HasForeignKey(d => d.ALookupParamId)
                .HasConstraintName("FK_A_REPORT_PARAM_A_LOOKUP_PARAM");

            entity.HasOne(d => d.AReportNavigation).WithMany(p => p.AReportParams)
                .HasForeignKey(d => d.AReport)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_A_REPORT_PARAM_A_REPORT");
        });

        modelBuilder.Entity<AReportSchPostStoreProc>(entity =>
        {
            entity.HasKey(e => new { e.AReport, e.PostStoredProc });

            entity.ToTable("A_REPORT_SCH_POST_STORE_PROC");

            entity.Property(e => e.AReport).HasColumnName("A_REPORT");
            entity.Property(e => e.PostStoredProc)
                .HasMaxLength(35)
                .HasColumnName("POST_STORED_PROC");
            entity.Property(e => e.Position).HasColumnName("POSITION");

            entity.HasOne(d => d.AReportNavigation).WithMany(p => p.AReportSchPostStoreProcs)
                .HasForeignKey(d => d.AReport)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_A_REPORT_SCH_POST_STORE_PROC");
        });

        modelBuilder.Entity<AReportSchPreStoreProc>(entity =>
        {
            entity.HasKey(e => new { e.AReport, e.PreStoredProc });

            entity.ToTable("A_REPORT_SCH_PRE_STORE_PROC");

            entity.Property(e => e.AReport).HasColumnName("A_REPORT");
            entity.Property(e => e.PreStoredProc)
                .HasMaxLength(35)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("PRE_STORED_PROC");
            entity.Property(e => e.Position).HasColumnName("POSITION");

            entity.HasOne(d => d.AReportNavigation).WithMany(p => p.AReportSchPreStoreProcs)
                .HasForeignKey(d => d.AReport)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_A_REPORT_SCH_PRE_STORE_PROC");
        });

        modelBuilder.Entity<AReportSession>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("A_REPORT_SESSION");

            entity.Property(e => e.DatabaseName)
                .HasMaxLength(36)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DATABASE_NAME");
            entity.Property(e => e.FileFormat)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("FILE_FORMAT");
            entity.Property(e => e.Filename)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("FILENAME");
            entity.Property(e => e.Formats)
                .HasMaxLength(254)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("FORMATS");
            entity.Property(e => e.InputItems)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("INPUT_ITEMS");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(36)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("LAST_UPDATED_BY");
            entity.Property(e => e.LastUpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATED_ON");
            entity.Property(e => e.Password)
                .HasMaxLength(36)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("PASSWORD");
            entity.Property(e => e.ReportName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("REPORT_NAME");
            entity.Property(e => e.SessionId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("SESSION_ID");
            entity.Property(e => e.SqlSelect)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("SQL_SELECT");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("STATUS");
            entity.Property(e => e.Username)
                .HasMaxLength(32)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("USERNAME");
        });

        modelBuilder.Entity<AReportSmtpServer>(entity =>
        {
            entity.HasKey(e => e.SmtpServerId);

            entity.ToTable("A_REPORT_SMTP_SERVER");

            entity.Property(e => e.SmtpServerId)
                .ValueGeneratedNever()
                .HasColumnName("SMTP_SERVER_ID");
            entity.Property(e => e.ClientHost)
                .HasMaxLength(150)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("CLIENT_HOST");
            entity.Property(e => e.ClientPort).HasColumnName("CLIENT_PORT");
            entity.Property(e => e.DefaultPwd)
                .HasMaxLength(50)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DEFAULT_PWD");
            entity.Property(e => e.DefaultUser)
                .HasMaxLength(50)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DEFAULT_USER");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.EnableSsl).HasColumnName("ENABLE_SSL");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("NAME");
            entity.Property(e => e.RequireAuth).HasColumnName("REQUIRE_AUTH");
        });

        modelBuilder.Entity<AReportTableAlias>(entity =>
        {
            entity.HasKey(e => new { e.AReport, e.ADatabase, e.ATableName });

            entity.ToTable("A_REPORT_TABLE_ALIAS");

            entity.Property(e => e.AReport).HasColumnName("A_REPORT");
            entity.Property(e => e.ADatabase).HasColumnName("A_DATABASE");
            entity.Property(e => e.ATableName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("A_TABLE_NAME");
            entity.Property(e => e.TableOrder).HasColumnName("TABLE_ORDER");

            entity.HasOne(d => d.AReportNavigation).WithMany(p => p.AReportTableAliases)
                .HasForeignKey(d => d.AReport)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_A_REPORT_TABLE_ALIAS_A_REPORT");

            entity.HasOne(d => d.ATableAlias).WithMany(p => p.AReportTableAliases)
                .HasForeignKey(d => new { d.ADatabase, d.ATableName })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_A_REPORT_TABLE_ALIAS_A_TABLE_ALIAS");
        });

        modelBuilder.Entity<AReportType>(entity =>
        {
            entity.HasKey(e => new { e.AReportTypeId, e.AReport });

            entity.ToTable("A_REPORT_TYPE");

            entity.Property(e => e.AReportTypeId).HasColumnName("A_REPORT_TYPE_ID");
            entity.Property(e => e.AReport).HasColumnName("A_REPORT");
            entity.Property(e => e.CreateReadyFile).HasColumnName("CREATE_READY_FILE");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_TIME");
            entity.Property(e => e.UpdateUser)
                .HasMaxLength(18)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("UPDATE_USER");

            entity.HasOne(d => d.AReportNavigation).WithMany(p => p.AReportTypes)
                .HasForeignKey(d => d.AReport)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_A_REPORT_TYPE_A_REPORT");

            entity.HasOne(d => d.AReportTypeNavigation).WithMany(p => p.AReportTypes)
                .HasForeignKey(d => d.AReportTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_A_REPORT_TYPE_A_LOOKUP");
        });

        modelBuilder.Entity<AReportTypeConfig>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("A_REPORT_TYPE_CONFIG");

            entity.Property(e => e.AReportTypeId).HasColumnName("A_REPORT_TYPE_ID");
            entity.Property(e => e.Key)
                .HasMaxLength(64)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("key");
            entity.Property(e => e.Value)
                .HasMaxLength(256)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("value");
        });

        modelBuilder.Entity<AReportTypeLookup>(entity =>
        {
            entity.HasKey(e => e.AReportTypeId);

            entity.ToTable("A_REPORT_TYPE_LOOKUP");

            entity.Property(e => e.AReportTypeId)
                .ValueGeneratedNever()
                .HasColumnName("A_REPORT_TYPE_ID");
            entity.Property(e => e.AReportType)
                .HasMaxLength(80)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("A_REPORT_TYPE");
            entity.Property(e => e.DeleteFlag).HasColumnName("DELETE_FLAG");
            entity.Property(e => e.ReadyFile).HasColumnName("READY_FILE");
        });

        modelBuilder.Entity<ARole>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("A_ROLE");

            entity.Property(e => e.Role)
                .HasMaxLength(32)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("ROLE");
        });

        modelBuilder.Entity<AScheduler>(entity =>
        {
            entity.HasKey(e => e.SchedulerId);

            entity.ToTable("A_SCHEDULER");

            entity.Property(e => e.SchedulerId)
                .ValueGeneratedNever()
                .HasColumnName("SCHEDULER_ID");
            entity.Property(e => e.DeleteFlag).HasColumnName("DELETE_FLAG");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Enable).HasColumnName("ENABLE");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("END_DATE");
            entity.Property(e => e.LastExecutedOn)
                .HasColumnType("datetime")
                .HasColumnName("LAST_EXECUTED_ON");
            entity.Property(e => e.LastTriggeredOn)
                .HasColumnType("datetime")
                .HasColumnName("LAST_TRIGGERED_ON");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("NAME");
            entity.Property(e => e.NextExecuteOn)
                .HasColumnType("datetime")
                .HasColumnName("NEXT_EXECUTE_ON");
            entity.Property(e => e.NextRecurrenceOn)
                .HasColumnType("datetime")
                .HasColumnName("NEXT_RECURRENCE_ON");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("START_DATE");
        });

        modelBuilder.Entity<ASchedulerLog>(entity =>
        {
            entity.HasKey(e => new { e.ASchedulerLogId, e.ASchedulerId });

            entity.ToTable("A_SCHEDULER_LOG");

            entity.Property(e => e.ASchedulerLogId).HasColumnName("A_SCHEDULER_LOG_ID");
            entity.Property(e => e.ASchedulerId).HasColumnName("A_SCHEDULER_ID");
            entity.Property(e => e.EventDatetime)
                .HasColumnType("datetime")
                .HasColumnName("EVENT_DATETIME");
            entity.Property(e => e.LogDescription)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnType("text")
                .HasColumnName("LOG_DESCRIPTION");
            entity.Property(e => e.LogResultStatus)
                .HasMaxLength(1)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("LOG_RESULT_STATUS");

            entity.HasOne(d => d.AScheduler).WithMany(p => p.ASchedulerLogs)
                .HasForeignKey(d => d.ASchedulerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_A_SCHEDULER_LOG_A_SCHEDULER");
        });

        modelBuilder.Entity<ASchedulerRecurrence>(entity =>
        {
            entity.HasKey(e => e.SchedulerId).HasName("PK_A_SCHEDULER_RECURRENCE_1");

            entity.ToTable("A_SCHEDULER_RECURRENCE");

            entity.Property(e => e.SchedulerId)
                .ValueGeneratedNever()
                .HasColumnName("SCHEDULER_ID");
            entity.Property(e => e.April).HasColumnName("APRIL");
            entity.Property(e => e.August).HasColumnName("AUGUST");
            entity.Property(e => e.DayNo).HasColumnName("DAY_NO");
            entity.Property(e => e.December).HasColumnName("DECEMBER");
            entity.Property(e => e.February).HasColumnName("FEBRUARY");
            entity.Property(e => e.Frecuency).HasColumnName("FRECUENCY");
            entity.Property(e => e.Friday).HasColumnName("FRIDAY");
            entity.Property(e => e.Interval).HasColumnName("INTERVAL");
            entity.Property(e => e.January).HasColumnName("JANUARY");
            entity.Property(e => e.July).HasColumnName("JULY");
            entity.Property(e => e.June).HasColumnName("JUNE");
            entity.Property(e => e.March).HasColumnName("MARCH");
            entity.Property(e => e.May).HasColumnName("MAY");
            entity.Property(e => e.Monday).HasColumnName("MONDAY");
            entity.Property(e => e.November).HasColumnName("NOVEMBER");
            entity.Property(e => e.October).HasColumnName("OCTOBER");
            entity.Property(e => e.RepeatDuration).HasColumnName("REPEAT_DURATION");
            entity.Property(e => e.RepeatFlag).HasColumnName("REPEAT_FLAG");
            entity.Property(e => e.RepeatInterval).HasColumnName("REPEAT_INTERVAL");
            entity.Property(e => e.RepeatUnit).HasColumnName("REPEAT_UNIT");
            entity.Property(e => e.RepeatUnitDuration).HasColumnName("REPEAT_UNIT_DURATION");
            entity.Property(e => e.Saturday).HasColumnName("SATURDAY");
            entity.Property(e => e.September).HasColumnName("SEPTEMBER");
            entity.Property(e => e.Sunday).HasColumnName("SUNDAY");
            entity.Property(e => e.Thursday).HasColumnName("THURSDAY");
            entity.Property(e => e.Tuesday).HasColumnName("TUESDAY");
            entity.Property(e => e.Wednesday).HasColumnName("WEDNESDAY");
            entity.Property(e => e.WeekOfMonth).HasColumnName("WEEK_OF_MONTH");

            entity.HasOne(d => d.Scheduler).WithOne(p => p.ASchedulerRecurrence)
                .HasForeignKey<ASchedulerRecurrence>(d => d.SchedulerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_A_SCHEDULER_RECURRENCE_A_SCHEDULER");
        });

        modelBuilder.Entity<ASchedulerReport>(entity =>
        {
            entity.HasKey(e => new { e.SchedulerId, e.AReport }).HasName("PK_A_SCHEDULER_REPORT_1");

            entity.ToTable("A_SCHEDULER_REPORT");

            entity.Property(e => e.SchedulerId).HasColumnName("SCHEDULER_ID");
            entity.Property(e => e.AReport).HasColumnName("A_REPORT");
            entity.Property(e => e.OutputFilename)
                .HasMaxLength(50)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("OUTPUT_FILENAME");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("STATUS");

            entity.HasOne(d => d.Scheduler).WithMany(p => p.ASchedulerReports)
                .HasForeignKey(d => d.SchedulerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_A_SCHEDULER_REPORT_A_SCH");
        });

        modelBuilder.Entity<ASchedulerReportBatch>(entity =>
        {
            entity.HasKey(e => new { e.SchedulerId, e.AReportBatch, e.AReportTypeId });

            entity.ToTable("A_SCHEDULER_REPORT_BATCH");

            entity.Property(e => e.SchedulerId).HasColumnName("SCHEDULER_ID");
            entity.Property(e => e.AReportBatch).HasColumnName("A_REPORT_BATCH");
            entity.Property(e => e.AReportTypeId).HasColumnName("A_REPORT_TYPE_ID");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("STATUS");

            entity.HasOne(d => d.AReportBatchNavigation).WithMany(p => p.ASchedulerReportBatches)
                .HasForeignKey(d => d.AReportBatch)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_A_SCH_RPT_BATCH_A_RPT_BATCH");

            entity.HasOne(d => d.AReportType).WithMany(p => p.ASchedulerReportBatches)
                .HasForeignKey(d => d.AReportTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_A_SCH_RPT_BATCH_A_RPT_TYPE_LOOK");

            entity.HasOne(d => d.Scheduler).WithMany(p => p.ASchedulerReportBatches)
                .HasForeignKey(d => d.SchedulerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_A_SCHEDULER_RPT_BATCH_A_SCH");
        });

        modelBuilder.Entity<ASchedulerReportType>(entity =>
        {
            entity.HasKey(e => new { e.SchedulerId, e.AReport, e.AReportTypeId });

            entity.ToTable("A_SCHEDULER_REPORT_TYPE");

            entity.Property(e => e.SchedulerId).HasColumnName("SCHEDULER_ID");
            entity.Property(e => e.AReport).HasColumnName("A_REPORT");
            entity.Property(e => e.AReportTypeId).HasColumnName("A_REPORT_TYPE_ID");

            entity.HasOne(d => d.AReportNavigation).WithMany(p => p.ASchedulerReportTypes)
                .HasForeignKey(d => d.AReport)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_A_SCHEDULER_REPORT_TYPE_A_REPORT");

            entity.HasOne(d => d.AReportType).WithMany(p => p.ASchedulerReportTypes)
                .HasForeignKey(d => d.AReportTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_A_SCHEDULER_REPORT_TYPE_A_REPORT_TYPE_LOOKUP");

            entity.HasOne(d => d.ASchedulerReport).WithMany(p => p.ASchedulerReportTypes)
                .HasForeignKey(d => new { d.SchedulerId, d.AReport })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_A_SCHEDULER_REPORT_TYPE_A_SCHEDULER_REPORT");
        });

        modelBuilder.Entity<ASchedulerUtility>(entity =>
        {
            entity.HasKey(e => new { e.SchedulerId, e.UtilityId });

            entity.ToTable("A_SCHEDULER_UTILITY");

            entity.Property(e => e.SchedulerId).HasColumnName("SCHEDULER_ID");
            entity.Property(e => e.UtilityId).HasColumnName("UTILITY_ID");
            entity.Property(e => e.OutputFilename)
                .HasMaxLength(50)
                .HasColumnName("OUTPUT_FILENAME");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATUS");
        });

        modelBuilder.Entity<ATableAlias>(entity =>
        {
            entity.HasKey(e => new { e.ADatabase, e.TableName });

            entity.ToTable("A_TABLE_ALIAS");

            entity.Property(e => e.ADatabase).HasColumnName("A_DATABASE");
            entity.Property(e => e.TableName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("TABLE_NAME");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.TableAlias)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("TABLE_ALIAS");

            entity.HasOne(d => d.ADatabaseNavigation).WithMany(p => p.ATableAliases)
                .HasForeignKey(d => d.ADatabase)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_A_TABLE_ALIAS_A_DATABASES");
        });

        modelBuilder.Entity<AUserExclude>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("A_USER_EXCLUDE");

            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(8)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("LAST_UPDATED_BY");
            entity.Property(e => e.LastUpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATED_ON");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_TIME");
            entity.Property(e => e.UpdateUser)
                .HasMaxLength(18)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("UPDATE_USER");
            entity.Property(e => e.UserName)
                .HasMaxLength(18)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("USER_NAME");
        });

        modelBuilder.Entity<AValidEmailPlaceholder>(entity =>
        {
            entity.HasKey(e => e.HolderId).HasName("PK__A_VALID___B2D89BC93D7E1B63");

            entity.ToTable("A_VALID_EMAIL_PLACEHOLDER");

            entity.Property(e => e.HolderId)
                .ValueGeneratedNever()
                .HasColumnName("HOLDER_ID");
            entity.Property(e => e.Description)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.PlaceHolder)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PLACE_HOLDER");
            entity.Property(e => e.ReportGroupId).HasColumnName("REPORT_GROUP_ID");

            entity.HasOne(d => d.ReportGroup).WithMany(p => p.AValidEmailPlaceholders)
                .HasForeignKey(d => d.ReportGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__A_VALID_E__REPOR__3F6663D5");
        });

        modelBuilder.Entity<ActEmailLog>(entity =>
        {
            entity.HasKey(e => e.ActEmailLog1).HasName("PK__ACT_EMAIL_LOG__4F7CD00D");

            entity.ToTable("ACT_EMAIL_LOG");

            entity.HasIndex(e => e.ActEmailLog1, "ACT_EMAIL_LOG_PNDX").IsUnique();

            entity.HasIndex(e => e.DateTimeSent, "MAILOG_DSENT_SNDX");

            entity.Property(e => e.ActEmailLog1)
                .ValueGeneratedNever()
                .HasColumnName("ACT_EMAIL_LOG");
            entity.Property(e => e.AddAttachments).HasColumnName("ADD_ATTACHMENTS");
            entity.Property(e => e.AttachFileNames)
                .HasColumnType("image")
                .HasColumnName("ATTACH_FILE_NAMES");
            entity.Property(e => e.BccEmail)
                .HasColumnType("image")
                .HasColumnName("BCC_EMAIL");
            entity.Property(e => e.BodyHtml)
                .HasColumnType("image")
                .HasColumnName("BODY_HTML");
            entity.Property(e => e.BodyText)
                .HasColumnType("image")
                .HasColumnName("BODY_TEXT");
            entity.Property(e => e.CcEmail)
                .HasColumnType("image")
                .HasColumnName("CC_EMAIL");
            entity.Property(e => e.DateTimeRequest)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_REQUEST");
            entity.Property(e => e.DateTimeSent)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_SENT");
            entity.Property(e => e.EmailSentBy)
                .HasMaxLength(18)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("EMAIL_SENT_BY");
            entity.Property(e => e.EmailStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("EMAIL_STATUS");
            entity.Property(e => e.FromEmail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("FROM_EMAIL");
            entity.Property(e => e.FromName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("FROM_NAME");
            entity.Property(e => e.IcalMime)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("ICAL_MIME");
            entity.Property(e => e.IsIcalendar).HasColumnName("IS_ICALENDAR");
            entity.Property(e => e.NonMimeWarning)
                .HasMaxLength(254)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("NON_MIME_WARNING");
            entity.Property(e => e.NumbAttach).HasColumnName("NUMB_ATTACH");
            entity.Property(e => e.ReadReceipt).HasColumnName("READ_RECEIPT");
            entity.Property(e => e.SendHtml).HasColumnName("SEND_HTML");
            entity.Property(e => e.Subject)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("SUBJECT");
            entity.Property(e => e.ToEmail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("TO_EMAIL");
            entity.Property(e => e.ToName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("TO_NAME");
        });

        modelBuilder.Entity<ActFaxLog>(entity =>
        {
            entity.HasKey(e => e.AnsFaxId).HasName("PK__ACT_FAX_LOG__5070F446");

            entity.ToTable("ACT_FAX_LOG");

            entity.HasIndex(e => e.AnsFaxId, "ANS_FAX_LOG_PNDX").IsUnique();

            entity.HasIndex(e => e.DatetimeSent, "DATETIME_SENT_SNDX");

            entity.HasIndex(e => e.DatetimeSent, "FAXLOG_DSENT_SNDX");

            entity.HasIndex(e => e.FaxStatus, "FAX_STATUS_SNDX");

            entity.HasIndex(e => e.FaxSentBy, "SENT_BY_SNDX");

            entity.HasIndex(e => e.UpdatedOn, "UPDATED_ON_SNDX");

            entity.Property(e => e.AnsFaxId)
                .ValueGeneratedNever()
                .HasColumnName("ANS_FAX_ID");
            entity.Property(e => e.Company)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("COMPANY");
            entity.Property(e => e.Contact)
                .HasMaxLength(35)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("CONTACT");
            entity.Property(e => e.DatetimeSent)
                .HasColumnType("datetime")
                .HasColumnName("DATETIME_SENT");
            entity.Property(e => e.FaxNo)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("FAX_NO");
            entity.Property(e => e.FaxSentBy)
                .HasMaxLength(18)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("FAX_SENT_BY");
            entity.Property(e => e.FaxStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("FAX_STATUS");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<AnsSystemMessage>(entity =>
        {
            entity.HasKey(e => new { e.MessageId, e.Lcid });

            entity.ToTable("ANS_SYSTEM_MESSAGE");

            entity.Property(e => e.MessageId)
                .HasMaxLength(50)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("MESSAGE_ID");
            entity.Property(e => e.Lcid).HasColumnName("LCID");
            entity.Property(e => e.CacheFlag).HasColumnName("CACHE_FLAG");
            entity.Property(e => e.ConfirmationFlag).HasColumnName("CONFIRMATION_FLAG");
            entity.Property(e => e.Error).HasColumnName("ERROR");
            entity.Property(e => e.Message)
                .HasMaxLength(500)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("MESSAGE");
            entity.Property(e => e.ModuleId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("MODULE_ID");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("TITLE");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.ClientNumber).HasName("PK__CLIENT__5535A963");

            entity.ToTable("CLIENT");

            entity.HasIndex(e => e.ClientName, "CLIENT_NAME_INDX").IsUnique();

            entity.HasIndex(e => e.ClientNumber, "CLIENT_PNDX").IsUnique();

            entity.Property(e => e.ClientNumber)
                .ValueGeneratedNever()
                .HasColumnName("CLIENT_NUMBER");
            entity.Property(e => e.CliBillbackAc).HasColumnName("CLI_BILLBACK_AC");
            entity.Property(e => e.CliBillbackEv).HasColumnName("CLI_BILLBACK_EV");
            entity.Property(e => e.ClientComment)
                .HasColumnType("image")
                .HasColumnName("CLIENT_COMMENT");
            entity.Property(e => e.ClientName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("SQL_Latin1_General_CP1_CS_AS")
                .HasColumnName("CLIENT_NAME");
            entity.Property(e => e.CostCentreReqacc).HasColumnName("COST_CENTRE_REQACC");
            entity.Property(e => e.CostCentreReqev).HasColumnName("COST_CENTRE_REQEV");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.CreateOp)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("CREATE_OP");
            entity.Property(e => e.ExternalId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("EXTERNAL_ID");
            entity.Property(e => e.IndustryType)
                .HasMaxLength(35)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("INDUSTRY_TYPE");
            entity.Property(e => e.LastUpDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UP_DATE");
            entity.Property(e => e.LastUpOp)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("LAST_UP_OP");
            entity.Property(e => e.ParentNumber).HasColumnName("PARENT_NUMBER");
            entity.Property(e => e.ShowAccomSavings).HasColumnName("SHOW_ACCOM_SAVINGS");
            entity.Property(e => e.ShowEventSavings).HasColumnName("SHOW_EVENT_SAVINGS");
            entity.Property(e => e.WebbAddr)
                .HasMaxLength(254)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("WEBB_ADDR");
        });

        modelBuilder.Entity<Contact>(entity =>
        {
            entity.HasKey(e => new { e.ClientNumber, e.SiteNumber, e.ContactName }).HasName("PK__CONTACT__5AEE82B9");

            entity.ToTable("CONTACT");

            entity.HasIndex(e => e.ContactChase, "CONTACT_CHASE_SNDX");

            entity.HasIndex(e => e.ContactName, "CONTACT_INDX");

            entity.HasIndex(e => new { e.ClientNumber, e.SiteNumber, e.ContactName }, "CONTACT_PNDX").IsUnique();

            entity.HasIndex(e => new { e.ClientNumber, e.SiteNumber }, "CONT_FKCSNAME_SNDX");

            entity.HasIndex(e => new { e.ClientNumber, e.SiteNumber, e.ContactNameNew }, "CONT_NEW_PNDX").IsUnique();

            entity.Property(e => e.ClientNumber).HasColumnName("CLIENT_NUMBER");
            entity.Property(e => e.SiteNumber).HasColumnName("SITE_NUMBER");
            entity.Property(e => e.ContactName)
                .HasMaxLength(35)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("SQL_Latin1_General_CP1_CS_AS")
                .HasColumnName("CONTACT_NAME");
            entity.Property(e => e.BrochureSent)
                .HasColumnType("datetime")
                .HasColumnName("BROCHURE_SENT");
            entity.Property(e => e.CcExpGuar)
                .HasColumnType("datetime")
                .HasColumnName("CC_EXP_GUAR");
            entity.Property(e => e.CommEarnThisYr)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("COMM_EARN_THIS_YR");
            entity.Property(e => e.CommEarnToDate)
                .HasColumnType("decimal(13, 2)")
                .HasColumnName("COMM_EARN_TO_DATE");
            entity.Property(e => e.CommEstThisYr)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("COMM_EST_THIS_YR");
            entity.Property(e => e.CommEstToDate)
                .HasColumnType("decimal(13, 2)")
                .HasColumnName("COMM_EST_TO_DATE");
            entity.Property(e => e.CommPaidThisYr)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("COMM_PAID_THIS_YR");
            entity.Property(e => e.CommPaidToDate)
                .HasColumnType("decimal(13, 2)")
                .HasColumnName("COMM_PAID_TO_DATE");
            entity.Property(e => e.ContAccomAlert)
                .HasMaxLength(254)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("CONT_ACCOM_ALERT");
            entity.Property(e => e.ContBillbackAc).HasColumnName("CONT_BILLBACK_AC");
            entity.Property(e => e.ContBillbackBi)
                .HasMaxLength(254)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("CONT_BILLBACK_BI");
            entity.Property(e => e.ContBillbackCb).HasColumnName("CONT_BILLBACK_CB");
            entity.Property(e => e.ContBillbackEv).HasColumnName("CONT_BILLBACK_EV");
            entity.Property(e => e.ContChaseReason)
                .HasMaxLength(254)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("CONT_CHASE_REASON");
            entity.Property(e => e.ContDefaultBi)
                .HasMaxLength(254)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("CONT_DEFAULT_BI");
            entity.Property(e => e.ContEventAlert)
                .HasMaxLength(254)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("CONT_EVENT_ALERT");
            entity.Property(e => e.ContEventBi)
                .HasMaxLength(254)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("CONT_EVENT_BI");
            entity.Property(e => e.ContEvntBbBi)
                .HasMaxLength(254)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("CONT_EVNT_BB_BI");
            entity.Property(e => e.ContactBirthday)
                .HasColumnType("datetime")
                .HasColumnName("CONTACT_BIRTHDAY");
            entity.Property(e => e.ContactChase)
                .HasColumnType("datetime")
                .HasColumnName("CONTACT_CHASE");
            entity.Property(e => e.ContactComment)
                .HasColumnType("image")
                .HasColumnName("CONTACT_COMMENT");
            entity.Property(e => e.ContactDept)
                .HasMaxLength(35)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("CONTACT_DEPT");
            entity.Property(e => e.ContactFaxNo)
                .HasMaxLength(18)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("CONTACT_FAX_NO");
            entity.Property(e => e.ContactMobileNo)
                .HasMaxLength(18)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("CONTACT_MOBILE_NO");
            entity.Property(e => e.ContactNameNew)
                .HasMaxLength(35)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("SQL_Latin1_General_CP1_CS_AS")
                .HasColumnName("CONTACT_NAME_NEW");
            entity.Property(e => e.ContactTelNo)
                .HasMaxLength(18)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("CONTACT_TEL_NO");
            entity.Property(e => e.CostCentreReqacc).HasColumnName("COST_CENTRE_REQACC");
            entity.Property(e => e.CostCentreReqev).HasColumnName("COST_CENTRE_REQEV");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.CreateOp)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("CREATE_OP");
            entity.Property(e => e.CreditCardGuar)
                .HasMaxLength(16)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("CREDIT_CARD_GUAR");
            entity.Property(e => e.EmailAddr)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("EMAIL_ADDR");
            entity.Property(e => e.ExclFromMailshot).HasColumnName("EXCL_FROM_MAILSHOT");
            entity.Property(e => e.InactiveDate)
                .HasColumnType("datetime")
                .HasColumnName("INACTIVE_DATE");
            entity.Property(e => e.JobTitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("JOB_TITLE");
            entity.Property(e => e.LastUpDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UP_DATE");
            entity.Property(e => e.LastUpOp)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("LAST_UP_OP");
            entity.Property(e => e.LoyalEnrDate)
                .HasColumnType("datetime")
                .HasColumnName("LOYAL_ENR_DATE");
            entity.Property(e => e.LoyalExtId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("LOYAL_EXT_ID");
            entity.Property(e => e.LoyalVouchType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("LOYAL_VOUCH_TYPE");
            entity.Property(e => e.Source)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("SOURCE");
            entity.Property(e => e.TimeWasterDate)
                .HasColumnType("datetime")
                .HasColumnName("TIME_WASTER_DATE");
            entity.Property(e => e.VouchValThisYr)
                .HasColumnType("decimal(8, 0)")
                .HasColumnName("VOUCH_VAL_THIS_YR");
            entity.Property(e => e.VouchValToDate)
                .HasColumnType("decimal(9, 0)")
                .HasColumnName("VOUCH_VAL_TO_DATE");
            entity.Property(e => e.XmasCardList).HasColumnName("XMAS_CARD_LIST");

            entity.HasOne(d => d.Site).WithMany(p => p.Contacts)
                .HasForeignKey(d => new { d.ClientNumber, d.SiteNumber })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CONTACT_SITE");
        });

        modelBuilder.Entity<ReportImportDatabaseMapping>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("REPORT_IMPORT_DATABASE_MAPPING");

            entity.Property(e => e.ADatabase).HasColumnName("A_DATABASE");
            entity.Property(e => e.Dbname)
                .HasMaxLength(50)
                .HasColumnName("DBNAME");
            entity.Property(e => e.ReportSessionId).HasColumnName("REPORT_SESSION_ID");
        });

        modelBuilder.Entity<ReportUtility>(entity =>
        {
            entity.HasKey(e => e.UtilityId);

            entity.ToTable("REPORT_UTILITIES");

            entity.Property(e => e.UtilityId).HasColumnName("UTILITY_ID");
            entity.Property(e => e.TaskDescription)
                .IsUnicode(false)
                .HasColumnName("TASK_DESCRIPTION");
            entity.Property(e => e.TaskPath)
                .IsUnicode(false)
                .HasColumnName("TASK_PATH");
            entity.Property(e => e.TaskUniqueName)
                .HasMaxLength(50)
                .HasColumnName("TASK_UNIQUE_NAME");
        });

        modelBuilder.Entity<Site>(entity =>
        {
            entity.HasKey(e => new { e.ClientNumber, e.SiteNumber }).HasName("PK__SITE__6E01572D");

            entity.ToTable("SITE");

            entity.HasIndex(e => e.AccountMan, "ACC_MAN_SNDX");

            entity.HasIndex(e => e.ClientNumber, "SITE_FKCNAME_SNDX");

            entity.HasIndex(e => new { e.ClientNumber, e.SiteName }, "SITE_NAME_SNDX").IsUnique();

            entity.HasIndex(e => e.SiteNumber, "SITE_NUMBER_SNDX");

            entity.HasIndex(e => new { e.ClientNumber, e.SiteNumber }, "SITE_PNDX").IsUnique();

            entity.Property(e => e.ClientNumber).HasColumnName("CLIENT_NUMBER");
            entity.Property(e => e.SiteNumber).HasColumnName("SITE_NUMBER");
            entity.Property(e => e.AccountMan)
                .HasMaxLength(35)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("ACCOUNT_MAN");
            entity.Property(e => e.CommEarnThisYr)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("COMM_EARN_THIS_YR");
            entity.Property(e => e.CommEarnToDate)
                .HasColumnType("decimal(13, 2)")
                .HasColumnName("COMM_EARN_TO_DATE");
            entity.Property(e => e.CommEstThisYr)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("COMM_EST_THIS_YR");
            entity.Property(e => e.CommEstToDate)
                .HasColumnType("decimal(13, 2)")
                .HasColumnName("COMM_EST_TO_DATE");
            entity.Property(e => e.CommPaidThisYr)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("COMM_PAID_THIS_YR");
            entity.Property(e => e.CommPaidToDate)
                .HasColumnType("decimal(13, 2)")
                .HasColumnName("COMM_PAID_TO_DATE");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.CreateOp)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("CREATE_OP");
            entity.Property(e => e.LastUpDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UP_DATE");
            entity.Property(e => e.LastUpOp)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("LAST_UP_OP");
            entity.Property(e => e.LoyalContName)
                .HasMaxLength(35)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("LOYAL_CONT_NAME");
            entity.Property(e => e.LoyalEnrDate)
                .HasColumnType("datetime")
                .HasColumnName("LOYAL_ENR_DATE");
            entity.Property(e => e.ResAccMan)
                .HasMaxLength(35)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("RES_ACC_MAN");
            entity.Property(e => e.SiteAddrL2)
                .HasMaxLength(35)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("SITE_ADDR_L2");
            entity.Property(e => e.SiteAddrL3)
                .HasMaxLength(35)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("SITE_ADDR_L3");
            entity.Property(e => e.SiteBillbackAc).HasColumnName("SITE_BILLBACK_AC");
            entity.Property(e => e.SiteBillbackEv).HasColumnName("SITE_BILLBACK_EV");
            entity.Property(e => e.SiteComment)
                .HasColumnType("image")
                .HasColumnName("SITE_COMMENT");
            entity.Property(e => e.SiteCountry)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("SITE_COUNTRY");
            entity.Property(e => e.SiteCounty)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("SITE_COUNTY");
            entity.Property(e => e.SiteFaxNo)
                .HasMaxLength(18)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("SITE_FAX_NO");
            entity.Property(e => e.SiteName)
                .HasMaxLength(35)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("SITE_NAME");
            entity.Property(e => e.SitePostcode)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("SITE_POSTCODE");
            entity.Property(e => e.SiteTelNo)
                .HasMaxLength(18)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("SITE_TEL_NO");
            entity.Property(e => e.SiteTown)
                .HasMaxLength(35)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("SITE_TOWN");
            entity.Property(e => e.TrainServSite).HasColumnName("TRAIN_SERV_SITE");
            entity.Property(e => e.VouchValThisYr)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("VOUCH_VAL_THIS_YR");
            entity.Property(e => e.VouchValToDate)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("VOUCH_VAL_TO_DATE");

            entity.HasOne(d => d.ClientNumberNavigation).WithMany(p => p.Sites)
                .HasForeignKey(d => d.ClientNumber)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SITE_CLIENT");
        });

        modelBuilder.Entity<VBorActEmailLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_BOR_ACT_EMAIL_LOG");

            entity.Property(e => e.ActEmailLog)
                .ValueGeneratedOnAdd()
                .HasColumnName("ACT_EMAIL_LOG");
            entity.Property(e => e.AddAttachments).HasColumnName("ADD_ATTACHMENTS");
            entity.Property(e => e.AttachFileNames)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("ATTACH_FILE_NAMES");
            entity.Property(e => e.BccEmail)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("BCC_EMAIL");
            entity.Property(e => e.BodyHtml)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("BODY_HTML");
            entity.Property(e => e.BodyText)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("BODY_TEXT");
            entity.Property(e => e.CcEmail)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
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
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("EMAIL_SENT_BY");
            entity.Property(e => e.EmailStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("EMAIL_STATUS");
            entity.Property(e => e.FromEmail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("FROM_EMAIL");
            entity.Property(e => e.FromName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("FROM_NAME");
            entity.Property(e => e.IcalMime)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("ICAL_MIME");
            entity.Property(e => e.IsIcalendar).HasColumnName("IS_ICALENDAR");
            entity.Property(e => e.LastUpDate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("LAST_UP_DATE");
            entity.Property(e => e.NonMimeWarning)
                .HasMaxLength(254)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("NON_MIME_WARNING");
            entity.Property(e => e.NumbAttach).HasColumnName("NUMB_ATTACH");
            entity.Property(e => e.ReadReceipt).HasColumnName("READ_RECEIPT");
            entity.Property(e => e.SendHtml).HasColumnName("SEND_HTML");
            entity.Property(e => e.Subject)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("SUBJECT");
            entity.Property(e => e.ToEmail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("TO_EMAIL");
            entity.Property(e => e.ToName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("TO_NAME");
        });

        modelBuilder.Entity<VColumnAlias>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_COLUMN_ALIAS");

            entity.Property(e => e.Coltype).HasColumnName("COLTYPE");
            entity.Property(e => e.ColumnAlias)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("COLUMN_ALIAS");
            entity.Property(e => e.ColumnDesc)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("COLUMN_DESC");
            entity.Property(e => e.ColumnName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("COLUMN_NAME");
            entity.Property(e => e.DataFormat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DATA_FORMAT");
            entity.Property(e => e.Dbname)
                .HasMaxLength(50)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DBNAME");
            entity.Property(e => e.DefaultHeading)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DEFAULT_HEADING");
            entity.Property(e => e.DefaultWidth).HasColumnName("DEFAULT_WIDTH");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.TableName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("TABLE_NAME");
            entity.Property(e => e.TemplateField)
                .HasMaxLength(36)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("TEMPLATE_FIELD");
        });

        modelBuilder.Entity<VColumnAliasReportForm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_COLUMN_ALIAS_REPORT_FORM");

            entity.Property(e => e.AReportFormName)
                .HasMaxLength(80)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("A_REPORT_FORM_NAME");
            entity.Property(e => e.ColumnName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("COLUMN_NAME");
            entity.Property(e => e.Dbname)
                .HasMaxLength(50)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DBNAME");
            entity.Property(e => e.TableName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("TABLE_NAME");
        });

        modelBuilder.Entity<VLookupParam>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_LOOKUP_PARAM");

            entity.Property(e => e.ALookupDefinition)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnType("text")
                .HasColumnName("A_LOOKUP_DEFINITION");
            entity.Property(e => e.ALookupParamId).HasColumnName("A_LOOKUP_PARAM_ID");
            entity.Property(e => e.ALookupParamName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("A_LOOKUP_PARAM_NAME");
            entity.Property(e => e.Dbname)
                .HasMaxLength(50)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DBNAME");
            entity.Property(e => e.DeleteFlag).HasColumnName("DELETE_FLAG");
        });

        modelBuilder.Entity<VReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_REPORT");

            entity.Property(e => e.AReport).HasColumnName("A_REPORT");
            entity.Property(e => e.BatchSeqNo).HasColumnName("BATCH_SEQ_NO");
            entity.Property(e => e.BookField)
                .HasMaxLength(1)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("BOOK_FIELD");
            entity.Property(e => e.Bookmark)
                .HasMaxLength(254)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("BOOKMARK");
            entity.Property(e => e.ClientBaseReport).HasColumnName("CLIENT_BASE_REPORT");
            entity.Property(e => e.Crlf)
                .HasMaxLength(18)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("CRLF");
            entity.Property(e => e.CsvFilename)
                .HasMaxLength(50)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("CSV_FILENAME");
            entity.Property(e => e.CsvHeader)
                .HasMaxLength(1)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("CSV_HEADER");
            entity.Property(e => e.CsvOverwrite).HasColumnName("CSV_OVERWRITE");
            entity.Property(e => e.DateFormat)
                .HasMaxLength(40)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DATE_FORMAT");
            entity.Property(e => e.Dbname)
                .HasMaxLength(50)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DBNAME");
            entity.Property(e => e.DefaultEmailSubject)
                .HasMaxLength(200)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DEFAULT_EMAIL_SUBJECT");
            entity.Property(e => e.Definition)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DEFINITION");
            entity.Property(e => e.DeleteFlag).HasColumnName("DELETE_FLAG");
            entity.Property(e => e.Delimiter)
                .HasMaxLength(18)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DELIMITER");
            entity.Property(e => e.DistinctFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DISTINCT_FLAG");
            entity.Property(e => e.EmailDeliveryReceipt).HasColumnName("EMAIL_DELIVERY_RECEIPT");
            entity.Property(e => e.EmailFlag).HasColumnName("EMAIL_FLAG");
            entity.Property(e => e.EmailReadReceipt).HasColumnName("EMAIL_READ_RECEIPT");
            entity.Property(e => e.FreeHandSqlFlag).HasColumnName("FREE_HAND_SQL_FLAG");
            entity.Property(e => e.Graphical).HasColumnName("GRAPHICAL");
            entity.Property(e => e.ImportId).HasColumnName("IMPORT_ID");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("LAST_UPDATED_BY");
            entity.Property(e => e.LastUpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATED_ON");
            entity.Property(e => e.MailFields)
                .HasMaxLength(1)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("MAIL_FIELDS");
            entity.Property(e => e.MailFrom)
                .HasMaxLength(100)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("MAIL_FROM");
            entity.Property(e => e.MailTo)
                .HasMaxLength(250)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("MAIL_TO");
            entity.Property(e => e.MailmergeFile)
                .HasMaxLength(250)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("MAILMERGE_FILE");
            entity.Property(e => e.NamingKey)
                .HasMaxLength(50)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("NAMING_KEY");
            entity.Property(e => e.NamingPrefix)
                .HasMaxLength(18)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("NAMING_PREFIX");
            entity.Property(e => e.PositionInGroup).HasColumnName("POSITION_IN_GROUP");
            entity.Property(e => e.PostStoredProc)
                .HasMaxLength(35)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("POST_STORED_PROC");
            entity.Property(e => e.PreStoredProc)
                .HasMaxLength(35)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("PRE_STORED_PROC");
            entity.Property(e => e.Priority).HasColumnName("PRIORITY");
            entity.Property(e => e.ProcParams)
                .HasMaxLength(254)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("PROC_PARAMS");
            entity.Property(e => e.RepQrpTitle1)
                .HasMaxLength(120)
                .HasColumnName("REP_QRP_TITLE1");
            entity.Property(e => e.RepQrpTitle2)
                .HasMaxLength(120)
                .HasColumnName("REP_QRP_TITLE2");
            entity.Property(e => e.ReportCrystal)
                .HasMaxLength(254)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("REPORT_CRYSTAL");
            entity.Property(e => e.ReportDesc)
                .HasMaxLength(500)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("REPORT_DESC");
            entity.Property(e => e.ReportGrpName)
                .HasMaxLength(64)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("REPORT_GRP_NAME");
            entity.Property(e => e.ReportName)
                .HasMaxLength(80)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("REPORT_NAME");
            entity.Property(e => e.ReportQrp)
                .HasMaxLength(254)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("REPORT_QRP");
            entity.Property(e => e.ReportTemplateFlag).HasColumnName("REPORT_TEMPLATE_FLAG");
            entity.Property(e => e.ReportTypeDef)
                .HasMaxLength(80)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("REPORT_TYPE_DEF");
            entity.Property(e => e.Separator)
                .HasMaxLength(18)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("SEPARATOR");
            entity.Property(e => e.SmtpAuth).HasColumnName("SMTP_AUTH");
            entity.Property(e => e.SmtpDescription)
                .HasMaxLength(150)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("SMTP_DESCRIPTION");
            entity.Property(e => e.SmtpHost)
                .HasMaxLength(150)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("SMTP_HOST");
            entity.Property(e => e.SmtpName)
                .HasMaxLength(50)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("SMTP_NAME");
            entity.Property(e => e.SmtpPort).HasColumnName("SMTP_PORT");
            entity.Property(e => e.SmtpPwd)
                .HasMaxLength(50)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("SMTP_PWD");
            entity.Property(e => e.SmtpUser)
                .HasMaxLength(50)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("SMTP_USER");
            entity.Property(e => e.StandardTextId).HasColumnName("STANDARD_TEXT_ID");
            entity.Property(e => e.StoredProc)
                .HasMaxLength(50)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("STORED_PROC");
            entity.Property(e => e.Switcher)
                .HasMaxLength(18)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("SWITCHER");
            entity.Property(e => e.SystemReport).HasColumnName("SYSTEM_REPORT");
            entity.Property(e => e.TableViewFlag).HasColumnName("TABLE_VIEW_FLAG");
            entity.Property(e => e.TargetDatabase)
                .HasMaxLength(18)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("TARGET_DATABASE");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_TIME");
            entity.Property(e => e.UpdateUser)
                .HasMaxLength(18)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("UPDATE_USER");
            entity.Property(e => e.WordTemplate)
                .HasMaxLength(254)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("WORD_TEMPLATE");
            entity.Property(e => e.XmlFilename)
                .HasMaxLength(50)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("XML_FILENAME");
        });

        modelBuilder.Entity<VReportColumnAlias>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_REPORT_COLUMN_ALIAS");

            entity.Property(e => e.AReport).HasColumnName("A_REPORT");
            entity.Property(e => e.AggFunction).HasColumnName("AGG_FUNCTION");
            entity.Property(e => e.ColumnName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("COLUMN_NAME");
            entity.Property(e => e.DataFormat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DATA_FORMAT");
            entity.Property(e => e.Dbname)
                .HasMaxLength(50)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DBNAME");
            entity.Property(e => e.EmailFlag).HasColumnName("EMAIL_FLAG");
            entity.Property(e => e.FootFunction).HasColumnName("FOOT_FUNCTION");
            entity.Property(e => e.FootLabel)
                .HasMaxLength(40)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("FOOT_LABEL");
            entity.Property(e => e.Heading)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("HEADING");
            entity.Property(e => e.Position).HasColumnName("POSITION");
            entity.Property(e => e.SortOrder).HasColumnName("SORT_ORDER");
            entity.Property(e => e.TableName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("TABLE_NAME");
            entity.Property(e => e.TemplateField)
                .HasMaxLength(36)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("TEMPLATE_FIELD");
            entity.Property(e => e.Visible).HasColumnName("VISIBLE");
            entity.Property(e => e.Width).HasColumnName("WIDTH");
        });

        modelBuilder.Entity<VReportForm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_REPORT_FORM");

            entity.Property(e => e.AReportForm).HasColumnName("A_REPORT_FORM");
            entity.Property(e => e.AReportFormDesc)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("A_REPORT_FORM_DESC");
            entity.Property(e => e.AReportFormName)
                .HasMaxLength(80)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("A_REPORT_FORM_NAME");
            entity.Property(e => e.Dbname)
                .HasMaxLength(50)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DBNAME");
        });

        modelBuilder.Entity<VReportJoin>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_REPORT_JOINS");

            entity.Property(e => e.AReportJoin).HasColumnName("A_REPORT_JOIN");
            entity.Property(e => e.Dbname)
                .HasMaxLength(50)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DBNAME");
            entity.Property(e => e.JoinCondition)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("JOIN_CONDITION");
            entity.Property(e => e.Table1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("TABLE1");
            entity.Property(e => e.Table2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("TABLE2");
        });

        modelBuilder.Entity<VReportJoinRelated>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_REPORT_JOIN_RELATED");

            entity.Property(e => e.AReport).HasColumnName("A_REPORT");
            entity.Property(e => e.Dbname)
                .HasMaxLength(50)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DBNAME");
            entity.Property(e => e.JoinCondition)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("JOIN_CONDITION");
            entity.Property(e => e.Table1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("TABLE1");
            entity.Property(e => e.Table2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("TABLE2");
        });

        modelBuilder.Entity<VReportParam>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_REPORT_PARAM");

            entity.Property(e => e.ALookupDefinition)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnType("text")
                .HasColumnName("A_LOOKUP_DEFINITION");
            entity.Property(e => e.ALookupParamName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("A_LOOKUP_PARAM_NAME");
            entity.Property(e => e.AReport).HasColumnName("A_REPORT");
            entity.Property(e => e.AReportParam).HasColumnName("A_REPORT_PARAM");
            entity.Property(e => e.AndOrOperator)
                .HasMaxLength(3)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("AND_OR_OPERATOR");
            entity.Property(e => e.CloseBrace)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("CLOSE_BRACE");
            entity.Property(e => e.Coltype)
                .HasMaxLength(18)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("COLTYPE");
            entity.Property(e => e.DataEquation)
                .HasMaxLength(254)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DATA_EQUATION");
            entity.Property(e => e.DataField)
                .HasMaxLength(254)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DATA_FIELD");
            entity.Property(e => e.Dbname)
                .HasMaxLength(50)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DBNAME");
            entity.Property(e => e.DefaultOperator)
                .HasMaxLength(15)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DEFAULT_OPERATOR");
            entity.Property(e => e.DefaultValue)
                .HasMaxLength(254)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DEFAULT_VALUE");
            entity.Property(e => e.DisplayOperator)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DISPLAY_OPERATOR");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(8)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("LAST_UPDATED_BY");
            entity.Property(e => e.LastUpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATED_ON");
            entity.Property(e => e.LookUp)
                .HasColumnType("image")
                .HasColumnName("LOOK_UP");
            entity.Property(e => e.Mandatory)
                .HasMaxLength(1)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("MANDATORY");
            entity.Property(e => e.NotOperator)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("NOT_OPERATOR");
            entity.Property(e => e.OpenBrace)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("OPEN_BRACE");
            entity.Property(e => e.ParamDesc)
                .HasMaxLength(254)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("PARAM_DESC");
            entity.Property(e => e.ParamName)
                .HasMaxLength(64)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("PARAM_NAME");
            entity.Property(e => e.PassToCrw)
                .HasMaxLength(1)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("PASS_TO_CRW");
            entity.Property(e => e.PassToSp)
                .HasMaxLength(1)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("PASS_TO_SP");
            entity.Property(e => e.PostParamOrderno).HasColumnName("POST_PARAM_ORDERNO");
            entity.Property(e => e.PostReportParam)
                .HasMaxLength(1)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("POST_REPORT_PARAM");
            entity.Property(e => e.PostStoredParam)
                .HasMaxLength(36)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("POST_STORED_PARAM");
            entity.Property(e => e.PostStoredProc)
                .HasMaxLength(35)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("POST_STORED_PROC");
            entity.Property(e => e.PreParamOrderno).HasColumnName("PRE_PARAM_ORDERNO");
            entity.Property(e => e.PreReportParam)
                .HasMaxLength(1)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("PRE_REPORT_PARAM");
            entity.Property(e => e.PreStoredParam)
                .HasMaxLength(36)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("PRE_STORED_PARAM");
            entity.Property(e => e.PreStoredProc)
                .HasMaxLength(35)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("PRE_STORED_PROC");
            entity.Property(e => e.SpParamOrderNo).HasColumnName("SP_PARAM_ORDER_NO");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_TIME");
            entity.Property(e => e.UpdateUser)
                .HasMaxLength(18)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("UPDATE_USER");
        });

        modelBuilder.Entity<VReportTableAlias>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_REPORT_TABLE_ALIAS");

            entity.Property(e => e.AReport).HasColumnName("A_REPORT");
            entity.Property(e => e.ATableName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("A_TABLE_NAME");
            entity.Property(e => e.Dbname)
                .HasMaxLength(50)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DBNAME");
            entity.Property(e => e.TableOrder).HasColumnName("TABLE_ORDER");
        });

        modelBuilder.Entity<VReportType>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_REPORT_TYPE");

            entity.Property(e => e.AReport).HasColumnName("A_REPORT");
            entity.Property(e => e.AReportType)
                .HasMaxLength(80)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("A_REPORT_TYPE");
            entity.Property(e => e.CreateReadyFile).HasColumnName("CREATE_READY_FILE");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_TIME");
            entity.Property(e => e.UpdateUser)
                .HasMaxLength(18)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("UPDATE_USER");
        });

        modelBuilder.Entity<VTableAlias>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_TABLE_ALIAS");

            entity.Property(e => e.Dbname)
                .HasMaxLength(50)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DBNAME");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.TableAlias)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("TABLE_ALIAS");
            entity.Property(e => e.TableName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("TABLE_NAME");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

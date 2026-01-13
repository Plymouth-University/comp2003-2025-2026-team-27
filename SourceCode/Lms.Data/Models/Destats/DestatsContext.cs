using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Lms.Data.Models.Destats;

public partial class DestatsContext : DbContext
{
    public DestatsContext()
    {
    }

    public DestatsContext(DbContextOptions<DestatsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CiStat> CiStats { get; set; }

    public virtual DbSet<MonthlyStat> MonthlyStats { get; set; }

    public virtual DbSet<Stat> Stats { get; set; }

    public virtual DbSet<StatsDuplicate> StatsDuplicates { get; set; }

    public virtual DbSet<UserAccess> UserAccesses { get; set; }

    public virtual DbSet<UserLogon> UserLogons { get; set; }

    public virtual DbSet<UserSearch> UserSearches { get; set; }

    public virtual DbSet<VideoAnalytic> VideoAnalytics { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-GAMOI1TA;Database=DESTATS;User Id=sa;Password=password123;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CiStat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CI_STATS");

            entity.HasIndex(e => new { e.StatsDate, e.StatsHour, e.StatsType, e.StatsLlCode, e.StatsFacNo, e.StatsBorType, e.StatsFacEquip }, "CISTATSDATETX");

            entity.HasIndex(e => new { e.StatsType, e.StatsLlCode, e.StatsYear, e.StatsMonth, e.StatsDay, e.StatsHour, e.StatsBorType, e.StatsFacNo }, "CISTATSX");

            entity.HasIndex(e => new { e.StatsYear, e.StatsMonth, e.StatsDay, e.StatsHour, e.StatsType, e.StatsLlCode, e.StatsFacNo, e.StatsBorType, e.StatsFacEquip }, "CISTATSYEARTX");

            entity.Property(e => e.StatsAreaCd)
                .HasMaxLength(8)
                .HasColumnName("STATS_AREA_CD");
            entity.Property(e => e.StatsBorType)
                .HasMaxLength(3)
                .HasColumnName("STATS_BOR_TYPE");
            entity.Property(e => e.StatsClass)
                .HasMaxLength(6)
                .HasColumnName("STATS_CLASS");
            entity.Property(e => e.StatsCount).HasColumnName("STATS_COUNT");
            entity.Property(e => e.StatsDate)
                .HasColumnType("datetime")
                .HasColumnName("STATS_DATE");
            entity.Property(e => e.StatsDay).HasColumnName("STATS_DAY");
            entity.Property(e => e.StatsDiscCode)
                .HasMaxLength(10)
                .HasColumnName("STATS_DISC_CODE");
            entity.Property(e => e.StatsFacEquip)
                .HasMaxLength(1)
                .HasColumnName("STATS_FAC_EQUIP");
            entity.Property(e => e.StatsFacNo).HasColumnName("STATS_FAC_NO");
            entity.Property(e => e.StatsHour).HasColumnName("STATS_HOUR");
            entity.Property(e => e.StatsLlCode)
                .HasMaxLength(10)
                .HasColumnName("STATS_LL_CODE");
            entity.Property(e => e.StatsMoney)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("STATS_MONEY");
            entity.Property(e => e.StatsMonth).HasColumnName("STATS_MONTH");
            entity.Property(e => e.StatsSuburb)
                .HasMaxLength(4)
                .HasColumnName("STATS_SUBURB");
            entity.Property(e => e.StatsTax)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("STATS_TAX");
            entity.Property(e => e.StatsType).HasColumnName("STATS_TYPE");
            entity.Property(e => e.StatsWard)
                .HasMaxLength(4)
                .HasColumnName("STATS_WARD");
            entity.Property(e => e.StatsYear).HasColumnName("STATS_YEAR");
        });

        modelBuilder.Entity<MonthlyStat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MONTHLY_STATS");

            entity.HasIndex(e => new { e.MsLlCode, e.MsYear, e.MsMonth, e.TransType }, "XPKMONTHLYSTATS")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.MsCount).HasColumnName("MS_COUNT");
            entity.Property(e => e.MsLlCode)
                .HasMaxLength(20)
                .HasColumnName("MS_LL_CODE");
            entity.Property(e => e.MsMonth).HasColumnName("MS_MONTH");
            entity.Property(e => e.MsYear).HasColumnName("MS_YEAR");
            entity.Property(e => e.TransType).HasColumnName("TRANS_TYPE");
        });

        modelBuilder.Entity<Stat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("STATS");

            entity.HasIndex(e => new { e.StatsDate, e.StatsHour, e.StatsType, e.StatsLlCode, e.StatsStkCode, e.StatsStkForm, e.StatsBorType }, "STATSDATETX");

            entity.HasIndex(e => e.StatsUnique, "STATSUNIQUEX");

            entity.HasIndex(e => new { e.StatsType, e.StatsLlCode, e.StatsYear, e.StatsMonth, e.StatsDay, e.StatsHour, e.StatsBorType, e.StatsStkForm }, "STATSX");

            entity.HasIndex(e => new { e.StatsYear, e.StatsMonth, e.StatsDay, e.StatsHour, e.StatsType, e.StatsLlCode, e.StatsStkCode, e.StatsStkForm, e.StatsBorType }, "STATSYEARTX");

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
                .HasMaxLength(10)
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

        modelBuilder.Entity<StatsDuplicate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("STATS_DUPLICATES");

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
            entity.Property(e => e.StatsMoney).HasColumnName("STATS_MONEY");
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

        modelBuilder.Entity<UserAccess>(entity =>
        {
            entity.HasKey(e => e.UaId);

            entity.ToTable("USER_ACCESS");

            entity.HasIndex(e => new { e.UaDatetime, e.UaOperName }, "UA_DATENAMEX");

            entity.HasIndex(e => new { e.UaOperName, e.UaDatetime }, "UA_NAMEDATEX");

            entity.Property(e => e.UaId).HasColumnName("UA_ID");
            entity.Property(e => e.UaDatetime)
                .HasColumnType("datetime")
                .HasColumnName("UA_DATETIME");
            entity.Property(e => e.UaIpAddress)
                .HasMaxLength(36)
                .HasColumnName("UA_IP_ADDRESS");
            entity.Property(e => e.UaLocation)
                .HasMaxLength(20)
                .HasColumnName("UA_LOCATION");
            entity.Property(e => e.UaModule)
                .HasMaxLength(20)
                .HasColumnName("UA_MODULE");
            entity.Property(e => e.UaObjectDetails)
                .HasMaxLength(245)
                .HasColumnName("UA_OBJECT_DETAILS");
            entity.Property(e => e.UaObjectSecurity)
                .HasColumnType("decimal(2, 0)")
                .HasColumnName("UA_OBJECT_SECURITY");
            entity.Property(e => e.UaOperName)
                .HasMaxLength(25)
                .HasColumnName("UA_OPER_NAME");
            entity.Property(e => e.UaOperSecurity)
                .HasColumnType("decimal(3, 0)")
                .HasColumnName("UA_OPER_SECURITY");
        });

        modelBuilder.Entity<UserLogon>(entity =>
        {
            entity.HasKey(e => e.UlId);

            entity.ToTable("USER_LOGONS");

            entity.HasIndex(e => new { e.UlDatetime, e.UlOperName }, "UL_DATENAMEX");

            entity.HasIndex(e => new { e.UlOperName, e.UlDatetime }, "UL_NAMEDATEX");

            entity.Property(e => e.UlId).HasColumnName("UL_ID");
            entity.Property(e => e.UlDatetime)
                .HasColumnType("datetime")
                .HasColumnName("UL_DATETIME");
            entity.Property(e => e.UlIpAddress)
                .HasMaxLength(36)
                .HasColumnName("UL_IP_ADDRESS");
            entity.Property(e => e.UlLocation)
                .HasMaxLength(20)
                .HasColumnName("UL_LOCATION");
            entity.Property(e => e.UlModule)
                .HasMaxLength(20)
                .HasColumnName("UL_MODULE");
            entity.Property(e => e.UlOperName)
                .HasMaxLength(25)
                .HasColumnName("UL_OPER_NAME");
        });

        modelBuilder.Entity<UserSearch>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("USER_SEARCH");

            entity.HasIndex(e => new { e.UsDatetime, e.UsOperName }, "US_DATENAMEX");

            entity.HasIndex(e => new { e.UsOperName, e.UsDatetime }, "US_NAMEDATEX");

            entity.Property(e => e.UsDatetime)
                .HasColumnType("datetime")
                .HasColumnName("US_DATETIME");
            entity.Property(e => e.UsIpAddress)
                .HasMaxLength(36)
                .HasColumnName("US_IP_ADDRESS");
            entity.Property(e => e.UsLocation)
                .HasMaxLength(20)
                .HasColumnName("US_LOCATION");
            entity.Property(e => e.UsModule)
                .HasMaxLength(20)
                .HasColumnName("US_MODULE");
            entity.Property(e => e.UsOperName)
                .HasMaxLength(25)
                .HasColumnName("US_OPER_NAME");
            entity.Property(e => e.UsOperSecurity)
                .HasColumnType("decimal(3, 0)")
                .HasColumnName("US_OPER_SECURITY");
            entity.Property(e => e.UsSearchTerms)
                .HasMaxLength(245)
                .HasColumnName("US_SEARCH_TERMS");
            entity.Property(e => e.UsSearchType)
                .HasMaxLength(80)
                .HasColumnName("US_SEARCH_TYPE");
        });

        modelBuilder.Entity<VideoAnalytic>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VIDEO_AN__3214EC27FA687AB7");

            entity.ToTable("VIDEO_ANALYTICS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CatNo).HasColumnName("CAT_NO");
            entity.Property(e => e.CatTitle)
                .HasMaxLength(300)
                .HasColumnName("CAT_TITLE");
            entity.Property(e => e.CreateDatetime).HasColumnName("CREATE_DATETIME");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

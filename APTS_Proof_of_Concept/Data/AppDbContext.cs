using APTS_Proof_of_Concept.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace APTS_Proof_of_Concept.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ActiveYears> ActiveYears { get; set; }

    public virtual DbSet<AdditionalFields> AdditionalFields { get; set; }

    public virtual DbSet<AdditionalFieldsGroups> AdditionalFieldsGroups { get; set; }

    public virtual DbSet<AdditionalFieldsProgrammeDetails> AdditionalFieldsProgrammeDetails { get; set; }

    public virtual DbSet<AdditionalFieldsProgrammeFiles> AdditionalFieldsProgrammeFiles { get; set; }

    public virtual DbSet<AuditTrail> AuditTrail { get; set; }

    public virtual DbSet<DeliveryAndCesms> DeliveryAndCesms { get; set; }

    public virtual DbSet<DeliveryMode> DeliveryMode { get; set; }

    public virtual DbSet<DeliveryQualifications> DeliveryQualifications { get; set; }

    public virtual DbSet<DhetandHemis> DhetandHemis { get; set; }

    public virtual DbSet<DhetandHemis1> DhetandHemis1 { get; set; }

    public virtual DbSet<EntryRequirements> EntryRequirements { get; set; }

    public virtual DbSet<HedaAptsLookupCertification> HedaAptsLookupCertification { get; set; }

    public virtual DbSet<HedaAptsLookupModeOfProvisioning> HedaAptsLookupModeOfProvisioning { get; set; }

    public virtual DbSet<HedaAptsLookupPqmprogrammeType> HedaAptsLookupPqmprogrammeType { get; set; }

    public virtual DbSet<HedaAptsLookupStrategicPriorities> HedaAptsLookupStrategicPriorities { get; set; }

    public virtual DbSet<HeqcandChe> HeqcandChe { get; set; }

    public virtual DbSet<Heqcstatus> Heqcstatus { get; set; }

    public virtual DbSet<IcsLog> IcsLog { get; set; }

    public virtual DbSet<LearningActivities> LearningActivities { get; set; }

    public virtual DbSet<LevelMajors> LevelMajors { get; set; }

    public virtual DbSet<MandatoryUploads> MandatoryUploads { get; set; }

    public virtual DbSet<Module> Module { get; set; }

    public virtual DbSet<Nqf> Nqf { get; set; }

    public virtual DbSet<Nqf1> Nqf1 { get; set; }

    public virtual DbSet<NqfMapping> NqfMapping { get; set; }

    public virtual DbSet<Operations> Operations { get; set; }

    public virtual DbSet<OrgStaff> OrgStaff { get; set; }

    public virtual DbSet<OrgStructure> OrgStructure { get; set; }

    public virtual DbSet<PAdditionalFieldInPutType> PAdditionalFieldInPutType { get; set; }

    public virtual DbSet<PagerIndex> PagerIndex { get; set; }

    public virtual DbSet<Pqm> Pqm { get; set; }

    public virtual DbSet<PrgSelec> PrgSelec { get; set; }

    public virtual DbSet<PrgSelect> PrgSelect { get; set; }

    public virtual DbSet<ProgrammeInfoPqm> ProgrammeInfoPqm { get; set; }

    public virtual DbSet<ProgrammeTypes> ProgrammeTypes { get; set; }

    public virtual DbSet<Programmes> Programmes { get; set; }

    public virtual DbSet<ProgrammesSmu> ProgrammesSmu { get; set; }

    public virtual DbSet<ProgrammesUnlock> ProgrammesUnlock { get; set; }

    public virtual DbSet<Progress> Progress { get; set; }

    public virtual DbSet<ProgressDocuments> ProgressDocuments { get; set; }

    public virtual DbSet<QualificationDesignations> QualificationDesignations { get; set; }

    public virtual DbSet<Reports> Reports { get; set; }

    public virtual DbSet<Settings> Settings { get; set; }

    public virtual DbSet<ShortLearningProgramme> ShortLearningProgramme { get; set; }

    public virtual DbSet<SiteOfDelivery> SiteOfDelivery { get; set; }

    public virtual DbSet<SlpapplicationDetails> SlpapplicationDetails { get; set; }

    public virtual DbSet<SlpcalculationCriteria> SlpcalculationCriteria { get; set; }

    public virtual DbSet<Slpcampus> Slpcampus { get; set; }

    public virtual DbSet<SlpstrategicPriorities> SlpstrategicPriorities { get; set; }

    public virtual DbSet<StaffingPlan> StaffingPlan { get; set; }

    public virtual DbSet<StatusBlock> StatusBlock { get; set; }

    public virtual DbSet<StatusCategory> StatusCategory { get; set; }

    public virtual DbSet<StatusGroup> StatusGroup { get; set; }

    public virtual DbSet<StatusRoles> StatusRoles { get; set; }

    public virtual DbSet<StatusRolesLimited> StatusRolesLimited { get; set; }

    public virtual DbSet<Statusses> Statusses { get; set; }

    public virtual DbSet<Tally> Tally { get; set; }

    public virtual DbSet<TemplateArchive> TemplateArchive { get; set; }

    public virtual DbSet<TemplatePlaceholders> TemplatePlaceholders { get; set; }

    public virtual DbSet<Templates> Templates { get; set; }

    public virtual DbSet<TimeTable> TimeTable { get; set; }

    public virtual DbSet<TmplSelect> TmplSelect { get; set; }

    public virtual DbSet<ToolTips> ToolTips { get; set; }

    public virtual DbSet<TypeOfSlp> TypeOfSlp { get; set; }

    public virtual DbSet<UnlockList> UnlockList { get; set; }

    public virtual DbSet<UnlockTypeList> UnlockTypeList { get; set; }

    public virtual DbSet<UserParamaters> UserParamaters { get; set; }

    public virtual DbSet<VCampusAll> VCampusAll { get; set; }

    public virtual DbSet<VCampusGroupings> VCampusGroupings { get; set; }

    public virtual DbSet<VDataLinking> VDataLinking { get; set; }

    public virtual DbSet<VPersonnel> VPersonnel { get; set; }

    public virtual DbSet<VProgrammeLockedStatus> VProgrammeLockedStatus { get; set; }

    public virtual DbSet<VProgrammeLockedStatusTt> VProgrammeLockedStatusTt { get; set; }

    public virtual DbSet<VProgrammeStatusSummary> VProgrammeStatusSummary { get; set; }

    public virtual DbSet<VProgrammeStatusSummaryTt> VProgrammeStatusSummaryTt { get; set; }

    public virtual DbSet<VersionData> VersionData { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ActiveYears>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AyActive).HasColumnName("AY_ACtive");
            entity.Property(e => e.AyPk).HasColumnName("AY_PK");
            entity.Property(e => e.AyYear).HasColumnName("AY_Year");
        });

        modelBuilder.Entity<AdditionalFields>(entity =>
        {
            entity.HasKey(e => e.AfPk).HasName("PK__Addition__A6F8120DD2A4D05B");

            entity.Property(e => e.AfPk).HasColumnName("AF_PK");
            entity.Property(e => e.AfCore).HasColumnName("AF_Core");
            entity.Property(e => e.AfDefaultValue).HasColumnName("AF_DefaultValue");
            entity.Property(e => e.AfDropdownList)
                .HasMaxLength(500)
                .HasColumnName("AF_DropdownList");
            entity.Property(e => e.AfDropdownTypeRb)
                .HasMaxLength(10)
                .HasColumnName("AF_DropdownTypeRb");
            entity.Property(e => e.AfDynamicDropdownColumnName)
                .HasMaxLength(100)
                .HasColumnName("AF_DynamicDropdownColumnName");
            entity.Property(e => e.AfDynamicDropdownTblName)
                .HasMaxLength(100)
                .HasColumnName("AF_DynamicDropdownTblName");
            entity.Property(e => e.AfGrpFk).HasColumnName("AF_GRP_FK");
            entity.Property(e => e.AfInputType).HasColumnName("AF_InputType");
            entity.Property(e => e.AfName)
                .HasMaxLength(1000)
                .HasColumnName("AF_Name");
            entity.Property(e => e.AfOrder).HasColumnName("AF_Order");
            entity.Property(e => e.AfPiFk).HasColumnName("AF_PI_FK");
            entity.Property(e => e.AfTpFk).HasColumnName("AF_TP_FK");
            entity.Property(e => e.AfTtFk).HasColumnName("AF_TT_FK");

            entity.HasOne(d => d.AfGrpFkNavigation).WithMany(p => p.AdditionalFields)
                .HasForeignKey(d => d.AfGrpFk)
                .HasConstraintName("FK__Additiona__AF_GR__5FF32EF8");

            entity.HasOne(d => d.AfPiFkNavigation).WithMany(p => p.AdditionalFields)
                .HasForeignKey(d => d.AfPiFk)
                .HasConstraintName("FK__Additiona__AF_PI__61DB776A");

            entity.HasOne(d => d.AfTpFkNavigation).WithMany(p => p.AdditionalFields)
                .HasForeignKey(d => d.AfTpFk)
                .HasConstraintName("FK__Additiona__AF_TP__60E75331");

            entity.HasOne(d => d.AfTtFkNavigation).WithMany(p => p.AdditionalFields)
                .HasForeignKey(d => d.AfTtFk)
                .HasConstraintName("FK__Additiona__AF_TT__62CF9BA3");
        });

        modelBuilder.Entity<AdditionalFieldsGroups>(entity =>
        {
            entity.HasKey(e => e.AfgrpPk).HasName("PK__Addition__330BA7AF38E389B8");

            entity.Property(e => e.AfgrpPk).HasColumnName("AFGRP_PK");
            entity.Property(e => e.AfgrpName)
                .HasMaxLength(1000)
                .HasColumnName("AFGRP_NAME");
            entity.Property(e => e.AfgrpOrder).HasColumnName("AFGRP_ORDER");
        });

        modelBuilder.Entity<AdditionalFieldsProgrammeDetails>(entity =>
        {
            entity.HasKey(e => e.AfpdPk).HasName("PK__Addition__0F017B745442D7FB");

            entity.Property(e => e.AfpdPk).HasColumnName("AFPD_PK");
            entity.Property(e => e.AfpdAfFk).HasColumnName("AFPD_AF_Fk");
            entity.Property(e => e.AfpdIsTemplate).HasColumnName("AFPD_IsTemplate");
            entity.Property(e => e.AfpdPFk).HasColumnName("AFPD_P_Fk");
            entity.Property(e => e.AfpdValue).HasColumnName("AFPD_Value");
        });

        modelBuilder.Entity<AdditionalFieldsProgrammeFiles>(entity =>
        {
            entity.HasKey(e => e.AfpfPk).HasName("PK__Addition__3F804A8A6E851801");

            entity.Property(e => e.AfpfPk).HasColumnName("AFPF_PK");
            entity.Property(e => e.AfpfAfFk).HasColumnName("AFPF_AF_FK");
            entity.Property(e => e.AfpfContentType)
                .HasMaxLength(300)
                .HasColumnName("AFPF_ContentType");
            entity.Property(e => e.AfpfCreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AFPF_CreatedDate");
            entity.Property(e => e.AfpfFileByte).HasColumnName("AFPF_FileByte");
            entity.Property(e => e.AfpfFileExtension)
                .HasMaxLength(500)
                .HasColumnName("AFPF_FileExtension");
            entity.Property(e => e.AfpfFileName)
                .HasMaxLength(300)
                .HasColumnName("AFPF_FileName");
            entity.Property(e => e.AfpfFilePath)
                .HasMaxLength(1000)
                .HasColumnName("AFPF_FilePath");
            entity.Property(e => e.AfpfIsDownload).HasColumnName("AFPF_IsDownload");
            entity.Property(e => e.AfpfIsTemplate).HasColumnName("AFPF_IsTemplate");
            entity.Property(e => e.AfpfModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("AFPF_ModifiedDate");
            entity.Property(e => e.AfpfPFk).HasColumnName("AFPF_P_FK");
        });

        modelBuilder.Entity<AuditTrail>(entity =>
        {
            entity.HasKey(e => e.AtPk).HasName("PK__AuditTra__303311321A025AEB");

            entity.Property(e => e.AtPk).HasColumnName("AT_PK");
            entity.Property(e => e.AtActionType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("AT_ActionType");
            entity.Property(e => e.AtCategory)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("AT_Category");
            entity.Property(e => e.AtChangedKey)
                .IsUnicode(false)
                .HasColumnName("AT_ChangedKey");
            entity.Property(e => e.AtDate)
                .HasColumnType("datetime")
                .HasColumnName("AT_Date");
            entity.Property(e => e.AtDescription)
                .IsUnicode(false)
                .HasColumnName("AT_Description");
            entity.Property(e => e.AtItemKey).HasColumnName("AT_ItemKey");
            entity.Property(e => e.AtItemType).HasColumnName("AT_ItemType");
            entity.Property(e => e.AtNewValue)
                .IsUnicode(false)
                .HasColumnName("AT_NewValue");
            entity.Property(e => e.AtPrevValue)
                .IsUnicode(false)
                .HasColumnName("AT_PrevValue");
            entity.Property(e => e.AtSubCategory)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("AT_SubCategory");
            entity.Property(e => e.AtUser).HasColumnName("AT_User");
        });

        modelBuilder.Entity<DeliveryAndCesms>(entity =>
        {
            entity.HasKey(e => e.DcsmPk).HasName("PK__Delivery__7840F62E3E18CB7C");

            entity.Property(e => e.DcsmPk).HasColumnName("DCSM_PK");
            entity.Property(e => e.DcsmCesmFirstOrder)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DCSM_CESM_FirstOrder");
            entity.Property(e => e.DcsmCesmFirstOrderVerify).HasColumnName("DCSM_CESM_FirstOrder_Verify");
            entity.Property(e => e.DcsmCesmMfos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DCSM_CESM_MFOS");
            entity.Property(e => e.DcsmCesmSecondOrder)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DCSM_CESM_SecondOrder");
            entity.Property(e => e.DcsmCesmSecondOrderVerify).HasColumnName("DCSM_CESM_SecondOrder_Verify");
            entity.Property(e => e.DcsmCreateDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("DCSM_CreateDate");
            entity.Property(e => e.DcsmFtpt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DCSM_FTPT");
            entity.Property(e => e.DcsmModeOfDelivery).HasColumnName("DCSM_ModeOfDelivery");
            entity.Property(e => e.DcsmModifyDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("DCSM_ModifyDate");
            entity.Property(e => e.DcsmPFk).HasColumnName("DCSM_P_FK");
            entity.Property(e => e.DcsmQualificationDesc).HasColumnName("DCSM_QualificationDesc");
            entity.Property(e => e.DcsmSiteOfDelivery)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DCSM_SiteOfDelivery");

            entity.HasOne(d => d.DcsmPFkNavigation).WithMany(p => p.DeliveryAndCesms)
                .HasForeignKey(d => d.DcsmPFk)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ProgrammeKey");
        });

        modelBuilder.Entity<DeliveryMode>(entity =>
        {
            entity.HasKey(e => e.DmPk).HasName("PK__Delivery__22AD3DD4583F474A");

            entity.Property(e => e.DmPk).HasColumnName("DM_PK");
            entity.Property(e => e.DmActive)
                .HasDefaultValue(true)
                .HasColumnName("DM_Active");
            entity.Property(e => e.DmCreateDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("DM_CreateDate");
            entity.Property(e => e.DmDescription)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("DM_Description");
            entity.Property(e => e.DmModifyDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("DM_ModifyDate");
            entity.Property(e => e.DmName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DM_Name");
            entity.Property(e => e.DmPlaceholder)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DM_Placeholder");
        });

        modelBuilder.Entity<DeliveryQualifications>(entity =>
        {
            entity.HasKey(e => e.DqPk).HasName("PK__Delivery__56AC193DE9450B1D");

            entity.Property(e => e.DqPk).HasColumnName("DQ_PK");
            entity.Property(e => e.DqCreateDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("DQ_CreateDate");
            entity.Property(e => e.DqModifyDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("DQ_ModifyDate");
            entity.Property(e => e.DqName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DQ_Name");
            entity.Property(e => e.DqReplacement)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DQ_Replacement");
        });

        modelBuilder.Entity<DhetandHemis>(entity =>
        {
            entity.HasKey(e => e.DhetPk).HasName("PK__DHETandH__13E952318937F746");

            entity.ToTable("DHETandHEMIS");

            entity.Property(e => e.DhetPk).HasColumnName("DHET_PK");
            entity.Property(e => e.DhetCreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime")
                .HasColumnName("DHET_CreateDate");
            entity.Property(e => e.DhetExperiential).HasColumnName("DHET_Experiential");
            entity.Property(e => e.DhetFundingLevel).HasColumnName("DHET_FundingLevel");
            entity.Property(e => e.DhetMajorCourseLevel).HasColumnName("DHET_MajorCourseLevel");
            entity.Property(e => e.DhetMinTime).HasColumnName("DHET_MinTime");
            entity.Property(e => e.DhetMinWorkCredits).HasColumnName("DHET_MinWorkCredits");
            entity.Property(e => e.DhetModifyDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime")
                .HasColumnName("DHET_ModifyDate");
            entity.Property(e => e.DhetPFk).HasColumnName("DHET_P_FK");
            entity.Property(e => e.DhetQualCode)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DHET_QualCode");
            entity.Property(e => e.DhetResearchCredits).HasColumnName("DHET_ResearchCredits");
            entity.Property(e => e.DhetTotalSubsidy).HasColumnName("DHET_TotalSubsidy");
            entity.Property(e => e.DhetTotalTime).HasColumnName("DHET_TotalTime");
        });

        modelBuilder.Entity<DhetandHemis1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DHETandHEMIS", "prelim");

            entity.Property(e => e.DhetMinWorkCredits).HasColumnName("DHET_MinWorkCredits");
            entity.Property(e => e.DhetPFk).HasColumnName("DHET_P_FK");
            entity.Property(e => e.DhetResearchCredits).HasColumnName("DHET_ResearchCredits");
            entity.Property(e => e.DhetTotalSubsidy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DHET_TotalSubsidy");
        });

        modelBuilder.Entity<EntryRequirements>(entity =>
        {
            entity.HasKey(e => e.ErPk).HasName("PK__EntryReq__CF4BF16A67EEBB4C");

            entity.Property(e => e.ErPk).HasColumnName("ER_PK");
            entity.Property(e => e.ErEntryRequirement)
                .HasMaxLength(200)
                .HasColumnName("ER_EntryRequirement");
            entity.Property(e => e.ErModulesCode)
                .HasMaxLength(200)
                .HasColumnName("ER_ModulesCode");
            entity.Property(e => e.ErModulesName)
                .HasMaxLength(200)
                .HasColumnName("ER_ModulesName");
            entity.Property(e => e.ErModulesNqfcredit)
                .HasMaxLength(200)
                .HasColumnName("ER_ModulesNQFCredit");
            entity.Property(e => e.ErModulesNqflevels)
                .HasMaxLength(200)
                .HasColumnName("ER_ModulesNQFLevels");
            entity.Property(e => e.ErNonCreditBearing)
                .HasMaxLength(500)
                .HasColumnName("ER_NonCreditBearing");
            entity.Property(e => e.ErNqflevel)
                .HasMaxLength(200)
                .HasColumnName("ER_NQFLevel");
            entity.Property(e => e.ErQualificationCode)
                .HasMaxLength(500)
                .HasColumnName("ER_QualificationCode");
            entity.Property(e => e.ErQualificationName)
                .HasMaxLength(500)
                .HasColumnName("ER_QualificationName");
            entity.Property(e => e.ErSlpFk).HasColumnName("ER_SLP_FK");

            entity.HasOne(d => d.ErSlpFkNavigation).WithMany(p => p.EntryRequirements)
                .HasForeignKey(d => d.ErSlpFk)
                .HasConstraintName("FK__EntryRequ__ER_SL__2997E99E");
        });

        modelBuilder.Entity<HedaAptsLookupCertification>(entity =>
        {
            entity.HasKey(e => e.CertPk).HasName("PK__HEDA_APT__39D77167EA7D0355");

            entity.ToTable("HEDA_APTS.lookup.Certification");

            entity.HasIndex(e => e.CertName, "UQ__HEDA_APT__28B3DA1DADF85944").IsUnique();

            entity.Property(e => e.CertPk).HasColumnName("Cert_PK");
            entity.Property(e => e.CertActive).HasColumnName("Cert_Active");
            entity.Property(e => e.CertCreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime")
                .HasColumnName("Cert_CreateDate");
            entity.Property(e => e.CertModifiedDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("Cert_ModifiedDate");
            entity.Property(e => e.CertName)
                .HasMaxLength(100)
                .HasColumnName("Cert_Name");
        });

        modelBuilder.Entity<HedaAptsLookupModeOfProvisioning>(entity =>
        {
            entity.HasKey(e => e.MopPk).HasName("PK__HEDA_APT__CBD50D077D897F7D");

            entity.ToTable("HEDA_APTS.lookup.ModeOfProvisioning");

            entity.Property(e => e.MopPk)
                .ValueGeneratedNever()
                .HasColumnName("MOP_PK");
            entity.Property(e => e.MopCreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime")
                .HasColumnName("MOP_CreatedDate");
            entity.Property(e => e.MopModifiedDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("MOP_ModifiedDate");
            entity.Property(e => e.MopName)
                .HasMaxLength(200)
                .HasColumnName("MOP_Name");
        });

        modelBuilder.Entity<HedaAptsLookupPqmprogrammeType>(entity =>
        {
            entity.HasKey(e => e.PqmprogrammeTypePk).HasName("PK__HEDA_APT__837C7C49F95A0DC4");

            entity.ToTable("HEDA_APTS.lookup.PQMProgrammeType");

            entity.Property(e => e.PqmprogrammeTypePk).HasColumnName("PQMProgrammeType_PK");
            entity.Property(e => e.PqmprogrammeTypeActive).HasColumnName("PQMProgrammeType_Active");
            entity.Property(e => e.PqmprogrammeTypeCreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime")
                .HasColumnName("PQMProgrammeType_CreateDate");
            entity.Property(e => e.PqmprogrammeTypeModifiedDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("PQMProgrammeType_ModifiedDate");
            entity.Property(e => e.PqmprogrammeTypeName)
                .HasMaxLength(100)
                .HasColumnName("PQMProgrammeType_Name");
        });

        modelBuilder.Entity<HedaAptsLookupStrategicPriorities>(entity =>
        {
            entity.HasKey(e => e.SpPk).HasName("PK__HEDA_APT__AA24014A2DFC5B9F");

            entity.ToTable("HEDA_APTS.lookup.StrategicPriorities");

            entity.Property(e => e.SpPk).HasColumnName("SP_PK");
            entity.Property(e => e.SpActive).HasColumnName("SP_Active");
            entity.Property(e => e.SpCreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime")
                .HasColumnName("SP_CreateDate");
            entity.Property(e => e.SpModifiedDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("SP_ModifiedDate");
            entity.Property(e => e.SpName)
                .HasMaxLength(250)
                .HasColumnName("SP_Name");
        });

        modelBuilder.Entity<HeqcandChe>(entity =>
        {
            entity.HasKey(e => e.HeqcPk).HasName("PK__HEQCandC__94F4B67755723A23");

            entity.ToTable("HEQCandCHE");

            entity.Property(e => e.HeqcPk).HasColumnName("HEQC_Pk");
            entity.Property(e => e.HeqcCreateDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("HEQC_CreateDate");
            entity.Property(e => e.HeqcFinalAccreditation)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("HEQC_FinalAccreditation");
            entity.Property(e => e.HeqcIsPlagiarized)
                .HasDefaultValue(true)
                .HasColumnName("HEQC_IsPlagiarized");
            entity.Property(e => e.HeqcLevelDescriptors)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("HEQC_LevelDescriptors");
            entity.Property(e => e.HeqcModifyDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("HEQC_ModifyDate");
            entity.Property(e => e.HeqcOutstandingApprovals).HasColumnName("HEQC_OutstandingApprovals");
            entity.Property(e => e.HeqcOutstandingApprovalsDetail)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("HEQC_OutstandingApprovalsDetail");
            entity.Property(e => e.HeqcPFk).HasColumnName("HEQC_P_FK");
            entity.Property(e => e.HeqcReferenceNumber)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("HEQC_ReferenceNumber");
            entity.Property(e => e.HeqcSaqaid)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("HEQC_SAQAID");
            entity.Property(e => e.HeqcSubmissionDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("HEQC_SubmissionDate");

            entity.HasOne(d => d.HeqcPFkNavigation).WithMany(p => p.HeqcandChe)
                .HasForeignKey(d => d.HeqcPFk)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ProgrammeKey_HEQC");
        });

        modelBuilder.Entity<Heqcstatus>(entity =>
        {
            entity.HasKey(e => e.HsPk).HasName("PK__HEQCStat__76C82220E790EDD6");

            entity.ToTable("HEQCStatus");

            entity.Property(e => e.HsPk).HasColumnName("HS_Pk");
            entity.Property(e => e.HsCreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime")
                .HasColumnName("HS_CreateDate");
            entity.Property(e => e.HsModifyDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime")
                .HasColumnName("HS_ModifyDate");
            entity.Property(e => e.HsName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("HS_Name");
        });

        modelBuilder.Entity<IcsLog>(entity =>
        {
            entity.HasKey(e => e.LogPk).HasName("PK__ICS_Log__4364E1406C6065A1");

            entity.ToTable("ICS_Log");

            entity.Property(e => e.LogPk).HasColumnName("LOG_Pk");
            entity.Property(e => e.LogDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("LOG_DateTime");
            entity.Property(e => e.LogMessage).HasColumnName("LOG_Message");
            entity.Property(e => e.LogSeverity).HasColumnName("LOG_Severity");
            entity.Property(e => e.LogSource)
                .HasMaxLength(100)
                .HasColumnName("LOG_Source");
            entity.Property(e => e.LogUserPk).HasColumnName("LOG_UserPk");
        });

        modelBuilder.Entity<LearningActivities>(entity =>
        {
            entity.HasKey(e => e.LaPk).HasName("PK__Learning__A5628E4EAA6D5205");

            entity.Property(e => e.LaPk).HasColumnName("LA_PK");
            entity.Property(e => e.LaAssessmentContact)
                .HasMaxLength(200)
                .HasColumnName("LA_AssessmentContact");
            entity.Property(e => e.LaAssessmentDistance)
                .HasMaxLength(200)
                .HasColumnName("LA_AssessmentDistance");
            entity.Property(e => e.LaContactSessionContact)
                .HasMaxLength(200)
                .HasColumnName("LA_ContactSessionContact");
            entity.Property(e => e.LaContactSessionDistance)
                .HasMaxLength(200)
                .HasColumnName("LA_ContactSessionDistance");
            entity.Property(e => e.LaCreditBearingDistanceTotalCredits)
                .HasMaxLength(200)
                .HasColumnName("LA_CreditBearingDistanceTotalCredits");
            entity.Property(e => e.LaIndependentLearningContact)
                .HasMaxLength(200)
                .HasColumnName("LA_IndependentLearningContact");
            entity.Property(e => e.LaIndependentLearningDistance)
                .HasMaxLength(200)
                .HasColumnName("LA_IndependentLearningDistance");
            entity.Property(e => e.LaNonCreditBearingTotalHrs)
                .HasMaxLength(200)
                .HasColumnName("LA_NonCreditBearingTotalHrs");
            entity.Property(e => e.LaOtherContact)
                .HasMaxLength(200)
                .HasColumnName("LA_OtherContact");
            entity.Property(e => e.LaOtherDistance)
                .HasMaxLength(200)
                .HasColumnName("LA_OtherDistance");
            entity.Property(e => e.LaSlpFk).HasColumnName("LA_SLP_FK");
            entity.Property(e => e.LaStudentSupportContact)
                .HasMaxLength(200)
                .HasColumnName("LA_StudentSupportContact");
            entity.Property(e => e.LaStudentSupportDistance)
                .HasMaxLength(200)
                .HasColumnName("LA_StudentSupportDistance");
            entity.Property(e => e.LaTotalHrsContact)
                .HasMaxLength(200)
                .HasColumnName("LA_TotalHrsContact");
            entity.Property(e => e.LaTotalHrsDistance)
                .HasMaxLength(200)
                .HasColumnName("LA_TotalHrsDistance");
            entity.Property(e => e.LaWorkspaceContact)
                .HasMaxLength(200)
                .HasColumnName("LA_WorkspaceContact");
            entity.Property(e => e.LaWorkspaceDistance)
                .HasMaxLength(200)
                .HasColumnName("LA_WorkspaceDistance");

            entity.HasOne(d => d.LaSlpFkNavigation).WithMany(p => p.LearningActivities)
                .HasForeignKey(d => d.LaSlpFk)
                .HasConstraintName("FK__LearningA__LA_SL__26BB7CF3");
        });

        modelBuilder.Entity<LevelMajors>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.LmLabel)
                .HasMaxLength(255)
                .HasColumnName("LM_Label");
            entity.Property(e => e.LmPk)
                .ValueGeneratedOnAdd()
                .HasColumnName("LM_PK");
            entity.Property(e => e.LmValue).HasColumnName("LM_Value");
        });

        modelBuilder.Entity<MandatoryUploads>(entity =>
        {
            entity.HasKey(e => e.MuPk).HasName("PK__Mandator__562DDAC4EC09BA25");

            entity.Property(e => e.MuPk).HasColumnName("MU_PK");
            entity.Property(e => e.MuCreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime")
                .HasColumnName("MU_CreateDate");
            entity.Property(e => e.MuModifyDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime")
                .HasColumnName("MU_ModifyDate");
            entity.Property(e => e.MuName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("MU_Name");
            entity.Property(e => e.MuTab1Value).HasColumnName("MU_Tab1_Value");
            entity.Property(e => e.MuTab2Value).HasColumnName("MU_Tab2_Value");
            entity.Property(e => e.MuTab3Value).HasColumnName("MU_Tab3_Value");
            entity.Property(e => e.MuTab4Value).HasColumnName("MU_Tab4_Value");
        });

        modelBuilder.Entity<Module>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.MdlCode).HasColumnName("MDL_Code");
            entity.Property(e => e.MdlCompulsory).HasColumnName("MDL_Compulsory");
            entity.Property(e => e.MdlCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("MDL_CreateDate");
            entity.Property(e => e.MdlCredits).HasColumnName("MDL_Credits");
            entity.Property(e => e.MdlModifyDate)
                .HasColumnType("datetime")
                .HasColumnName("MDL_ModifyDate");
            entity.Property(e => e.MdlName)
                .HasMaxLength(255)
                .HasColumnName("MDL_Name");
            entity.Property(e => e.MdlNqfLevel).HasColumnName("MDL_NQF_Level");
            entity.Property(e => e.MdlPFk).HasColumnName("MDL_P_Fk");
            entity.Property(e => e.MdlPk)
                .ValueGeneratedOnAdd()
                .HasColumnName("MDL_Pk");
            entity.Property(e => e.MdlSemester)
                .HasDefaultValue(-1)
                .HasColumnName("MDL_Semester");
            entity.Property(e => e.MdlTotalCredits).HasColumnName("MDL_Total_Credits");
            entity.Property(e => e.MdlYear).HasColumnName("MDL_Year");
        });

        modelBuilder.Entity<Nqf>(entity =>
        {
            entity.HasKey(e => e.NqfPk).HasName("PK__NQF__5FEAF82BB1AA6476");

            entity.ToTable("NQF");

            entity.Property(e => e.NqfPk).HasColumnName("NQF_Pk");
            entity.Property(e => e.NqfCreateDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("NQF_CreateDate");
            entity.Property(e => e.NqfFinalYearNqfcreditsFirstQual)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("NQF_FinalYearNQFCreditsFirstQual");
            entity.Property(e => e.NqfFinalYearNqfcreditsSecondQual)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("NQF_FinalYearNQFCreditsSecondQual");
            entity.Property(e => e.NqfLevel)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("NQF_Level");
            entity.Property(e => e.NqfMinimumAdmissionReq)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("NQF_MinimumAdmissionReq");
            entity.Property(e => e.NqfMinimumCreditLevel)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("NQF_MinimumCreditLevel");
            entity.Property(e => e.NqfMinimumDurationforFt)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("NQF_MinimumDurationforFT");
            entity.Property(e => e.NqfMinimumNumberCredits)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("NQF_MinimumNumberCredits");
            entity.Property(e => e.NqfMinumumDurationPt)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("NQF_MinumumDurationPT");
            entity.Property(e => e.NqfModifyDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("NQF_ModifyDate");
            entity.Property(e => e.NqfPFk).HasColumnName("NQF_P_FK");
            entity.Property(e => e.NqfPercentageNqfcreditsFirstQual)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("NQF_PercentageNQFCreditsFirstQual");
            entity.Property(e => e.NqfPercentageNqfcreditsSecondQual)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("NQF_PercentageNQFCreditsSecondQual");
            entity.Property(e => e.NqfSelectionCriteria)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("NQF_SelectionCriteria");
            entity.Property(e => e.NqfTotalNumberCredits)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("NQF_TotalNumberCredits");
            entity.Property(e => e.NqfTotalResearchCredits)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("NQF_TotalResearchCredits");

            entity.HasOne(d => d.NqfPFkNavigation).WithMany(p => p.Nqf)
                .HasForeignKey(d => d.NqfPFk)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ProgrammeKey_NQF");
        });

        modelBuilder.Entity<Nqf1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NQF", "prelim");

            entity.Property(e => e.NqfLevel).HasColumnName("NQF_Level");
            entity.Property(e => e.NqfPFk).HasColumnName("NQF_P_FK");
            entity.Property(e => e.NqfTotalNumberCredits).HasColumnName("NQF_TotalNumberCredits");
        });

        modelBuilder.Entity<NqfMapping>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NQF_Mapping");

            entity.Property(e => e.AdjTimeFt).HasColumnName("ADJ_Time_FT");
            entity.Property(e => e.AdjTimePt).HasColumnName("ADJ_Time_PT");
            entity.Property(e => e.MinCreditsAtExitLevel).HasColumnName("Min_Credits_at_Exit_Level");
            entity.Property(e => e.MinTime).HasColumnName("Min_Time");
            entity.Property(e => e.MinTotalCredits).HasColumnName("Min_Total_Credits");
            entity.Property(e => e.NqfExitLevel).HasColumnName("NQF_Exit_Level");
            entity.Property(e => e.QualificationType)
                .HasMaxLength(66)
                .IsUnicode(false)
                .HasColumnName("Qualification_Type");
            entity.Property(e => e.QualificationTypeCode)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Qualification_Type_Code");
            entity.Property(e => e.Type)
                .HasMaxLength(27)
                .IsUnicode(false);
            entity.Property(e => e.Type2)
                .HasMaxLength(22)
                .IsUnicode(false);
            entity.Property(e => e.Type3)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Xltpk)
                .ValueGeneratedOnAdd()
                .HasColumnName("XLTPk");
        });

        modelBuilder.Entity<Operations>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.OprCreateDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("OPR_CreateDate");
            entity.Property(e => e.OprEnrolmentPlan)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("OPR_EnrolmentPlan");
            entity.Property(e => e.OprExp).HasColumnName("OPR_Exp");
            entity.Property(e => e.OprExpPlan).HasColumnName("OPR_ExpPlan");
            entity.Property(e => e.OprModifyDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("OPR_ModifyDate");
            entity.Property(e => e.OprPFk).HasColumnName("OPR_P_FK");
            entity.Property(e => e.OprPhEnrolment)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("OPR_PH_Enrolment");
            entity.Property(e => e.OprPk)
                .ValueGeneratedOnAdd()
                .HasColumnName("OPR_Pk");
            entity.Property(e => e.OprService).HasColumnName("OPR_Service");
            entity.Property(e => e.OprSize).HasColumnName("OPR_Size");
            entity.Property(e => e.OprSizePlan).HasColumnName("OPR_SizePlan");
            entity.Property(e => e.OprSuitable).HasColumnName("OPR_Suitable");
            entity.Property(e => e.OprVerified).HasColumnName("OPR_Verified");
        });

        modelBuilder.Entity<OrgStaff>(entity =>
        {
            entity.HasKey(e => e.OstPk).HasName("PK__OrgStaff__ED046E14C14E8BFC");

            entity.Property(e => e.OstPk).HasColumnName("OST_Pk");
            entity.Property(e => e.OstAuthFk)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OST_AUTH_Fk");
            entity.Property(e => e.OstCreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime")
                .HasColumnName("OST_CreateDate");
            entity.Property(e => e.OstModifyDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime")
                .HasColumnName("OST_ModifyDate");
            entity.Property(e => e.OstPFk).HasColumnName("OST_P_FK");
            entity.Property(e => e.OstPosition).HasColumnName("OST_Position");
        });

        modelBuilder.Entity<OrgStructure>(entity =>
        {
            entity.HasKey(e => e.OrgPk).HasName("PK__OrgStruc__666E3E067D380E0F");

            entity.Property(e => e.OrgPk).HasColumnName("ORG_PK");
            entity.Property(e => e.OrgCampus)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("ORG_Campus");
            entity.Property(e => e.OrgCreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime")
                .HasColumnName("ORG_CreateDate");
            entity.Property(e => e.OrgDepartment)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ORG_Department");
            entity.Property(e => e.OrgFaculty)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ORG_Faculty");
            entity.Property(e => e.OrgModifyDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime")
                .HasColumnName("ORG_ModifyDate");
            entity.Property(e => e.OrgPFk).HasColumnName("ORG_P_FK");

            entity.HasOne(d => d.OrgPFkNavigation).WithMany(p => p.OrgStructure)
                .HasForeignKey(d => d.OrgPFk)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ProgrammeKey_Org");
        });

        modelBuilder.Entity<PAdditionalFieldInPutType>(entity =>
        {
            entity.HasKey(e => e.InputPk).HasName("PK__P_Additi__4075412FE04C5605");

            entity.ToTable("P_AdditionalField_InPutType");

            entity.Property(e => e.InputPk).HasColumnName("Input_Pk");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.InputText)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.IsInActive).HasDefaultValue(false);
            entity.Property(e => e.ModofiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<PagerIndex>(entity =>
        {
            entity.HasKey(e => e.PiPk).HasName("PK__PagerInd__6973CCA0652FB7F1");

            entity.Property(e => e.PiPk).HasColumnName("PI_PK");
            entity.Property(e => e.PiIndex).HasColumnName("PI_Index");
            entity.Property(e => e.PiName)
                .HasMaxLength(100)
                .HasColumnName("PI_Name");
            entity.Property(e => e.PiPType).HasColumnName("PI_P_Type");

            entity.HasOne(d => d.PiPTypeNavigation).WithMany(p => p.PagerIndex)
                .HasForeignKey(d => d.PiPType)
                .HasConstraintName("FK__PagerInde__PI_P___5D16C24D");
        });

        modelBuilder.Entity<Pqm>(entity =>
        {
            entity.HasKey(e => e.PqmPk).HasName("PK__PQM__02A7C21615F0F377");

            entity.ToTable("PQM");

            entity.Property(e => e.PqmPk).HasColumnName("PQM_PK");
            entity.Property(e => e.PqmComment)
                .HasMaxLength(500)
                .HasColumnName("PQM_Comment");
            entity.Property(e => e.PqmCreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime")
                .HasColumnName("PQM_CreateDate");
            entity.Property(e => e.PqmFirstEnrolmentDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("PQM_FirstEnrolmentDate");
            entity.Property(e => e.PqmIsPart).HasColumnName("PQM_IsPart");
            entity.Property(e => e.PqmIsReplacement).HasColumnName("PQM_IsReplacement");
            entity.Property(e => e.PqmModifyDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime")
                .HasColumnName("PQM_ModifyDate");
            entity.Property(e => e.PqmPFk).HasColumnName("PQM_P_FK");
            entity.Property(e => e.PqmPqmprogrammeType).HasColumnName("PQM_PQMProgrammeType");
            entity.Property(e => e.PqmQualificationDesc).HasColumnName("PQM_QualificationDesc");
            entity.Property(e => e.PqmReplacement)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("PQM_Replacement");
            entity.Property(e => e.PqmSubmissionDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("PQM_SubmissionDate");

            entity.HasOne(d => d.PqmPFkNavigation).WithMany(p => p.Pqm)
                .HasForeignKey(d => d.PqmPFk)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ProgrammeKey_PQM");
        });

        modelBuilder.Entity<PrgSelec>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.PName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("P_Name");
            entity.Property(e => e.PPk).HasColumnName("P_PK");
            entity.Property(e => e.PType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("P_type");
            entity.Property(e => e.PTypeKey).HasColumnName("P_TypeKey");
        });

        modelBuilder.Entity<PrgSelect>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.PName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("P_Name");
            entity.Property(e => e.PPk).HasColumnName("P_PK");
            entity.Property(e => e.PType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("P_type");
            entity.Property(e => e.PTypeKey).HasColumnName("P_TypeKey");
        });

        modelBuilder.Entity<ProgrammeInfoPqm>(entity =>
        {
            entity.HasKey(e => e.PPk).HasName("PK__Programm__A343C295B7CD7F79");

            entity.ToTable("Programme_Info_PQM", "prelim");

            entity.Property(e => e.PPk).HasColumnName("P_PK");
            entity.Property(e => e.PAbbreviation)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("P_Abbreviation");
            entity.Property(e => e.PActive).HasColumnName("P_Active");
            entity.Property(e => e.PAlternativeDesignation)
                .HasMaxLength(33)
                .IsUnicode(false)
                .HasColumnName("P_AlternativeDesignation");
            entity.Property(e => e.PAptsnumber).HasColumnName("P_APTSNumber");
            entity.Property(e => e.PArticulation).HasColumnName("P_Articulation");
            entity.Property(e => e.PAssociatedAssessmentCriteria).HasColumnName("P_AssociatedAssessmentCriteria");
            entity.Property(e => e.PCesmcategory)
                .HasMaxLength(4000)
                .HasColumnName("P_CESMCategory");
            entity.Property(e => e.PCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("P_CreateDate");
            entity.Property(e => e.PCreator).HasColumnName("P_Creator");
            entity.Property(e => e.PDmFk).HasColumnName("P_DM_Fk");
            entity.Property(e => e.PEndorsement).HasColumnName("P_Endorsement");
            entity.Property(e => e.PExitLevelOutcome).HasColumnName("P_ExitLevelOutcome");
            entity.Property(e => e.PFirstQualifier)
                .HasMaxLength(4000)
                .HasColumnName("P_FirstQualifier");
            entity.Property(e => e.PFirstQualifierVerify).HasColumnName("P_FirstQualifier_Verify");
            entity.Property(e => e.PFtpt).HasColumnName("P_FTPT");
            entity.Property(e => e.PGoverance).HasColumnName("P_Goverance");
            entity.Property(e => e.PInstitutionName)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("P_InstitutionName");
            entity.Property(e => e.PInternationalCompatibility).HasColumnName("P_InternationalCompatibility");
            entity.Property(e => e.PIsEducated).HasColumnName("P_IsEducated");
            entity.Property(e => e.PJoinProgramme).HasColumnName("P_JoinProgramme");
            entity.Property(e => e.PModeOfProvisioning).HasColumnName("P_ModeOfProvisioning");
            entity.Property(e => e.PModifyDate).HasColumnName("P_ModifyDate");
            entity.Property(e => e.PMotivation).HasColumnName("P_Motivation");
            entity.Property(e => e.PMultiDisciplinary).HasColumnName("P_MultiDisciplinary");
            entity.Property(e => e.PName)
                .HasMaxLength(66)
                .IsUnicode(false)
                .HasColumnName("P_Name");
            entity.Property(e => e.PNonInternationalCompatibility).HasColumnName("P_NonInternationalCompatibility");
            entity.Property(e => e.POperationalQualCode).HasColumnName("P_Operational_QualCode");
            entity.Property(e => e.POrigin).HasColumnName("P_Origin");
            entity.Property(e => e.PPSource).HasColumnName("P_P_Source");
            entity.Property(e => e.PProgrammeCategory).HasColumnName("P_ProgrammeCategory");
            entity.Property(e => e.PPtFk).HasColumnName("P_PT_FK");
            entity.Property(e => e.PPurpose).HasColumnName("P_Purpose");
            entity.Property(e => e.PQualificationDesignation).HasColumnName("P_QualificationDesignation");
            entity.Property(e => e.PQualificationType).HasColumnName("P_QualificationType");
            entity.Property(e => e.PRationale).HasColumnName("P_Rationale");
            entity.Property(e => e.PRulesOfProgression).HasColumnName("P_RulesOfProgression");
            entity.Property(e => e.PSecondQualifier)
                .HasMaxLength(4000)
                .HasColumnName("P_SecondQualifier");
            entity.Property(e => e.PSecondQualifierVerify).HasColumnName("P_SecondQualifier_Verify");
            entity.Property(e => e.PSiteOfDelivery).HasColumnName("P_SiteOfDelivery");
            entity.Property(e => e.PThirdQualifier)
                .HasMaxLength(4000)
                .HasColumnName("P_ThirdQualifier");
            entity.Property(e => e.PThirdQualifierVerify).HasColumnName("P_ThirdQualifier_Verify");
            entity.Property(e => e.PUgpg)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("P_UGPG");
            entity.Property(e => e.PYear).HasColumnName("P_Year");
        });

        modelBuilder.Entity<ProgrammeTypes>(entity =>
        {
            entity.HasKey(e => e.PtPk).HasName("PK__Programm__68360B333ACB0961");

            entity.Property(e => e.PtPk).HasColumnName("PT_Pk");
            entity.Property(e => e.PtActive)
                .HasDefaultValue(true)
                .HasColumnName("PT_Active");
            entity.Property(e => e.PtCreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime")
                .HasColumnName("PT_CreateDate");
            entity.Property(e => e.PtModifyDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime")
                .HasColumnName("PT_ModifyDate");
            entity.Property(e => e.PtName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("PT_Name");
        });

        modelBuilder.Entity<Programmes>(entity =>
        {
            entity.HasKey(e => e.PPk).HasName("PK__Programm__A343C295B7CD7F78");

            entity.Property(e => e.PPk).HasColumnName("P_PK");
            entity.Property(e => e.PAbbreviation)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("P_Abbreviation");
            entity.Property(e => e.PActive)
                .HasDefaultValue(true)
                .HasColumnName("P_Active");
            entity.Property(e => e.PAlternativeDesignation)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("P_AlternativeDesignation");
            entity.Property(e => e.PAptsnumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("P_APTSNumber");
            entity.Property(e => e.PArticulation).HasColumnName("P_Articulation");
            entity.Property(e => e.PAssociatedAssessmentCriteria).HasColumnName("P_AssociatedAssessmentCriteria");
            entity.Property(e => e.PCesmcategory)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("P_CESMCategory");
            entity.Property(e => e.PCreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime")
                .HasColumnName("P_CreateDate");
            entity.Property(e => e.PCreator).HasColumnName("P_Creator");
            entity.Property(e => e.PDiagonalArticulation)
                .HasMaxLength(2000)
                .HasColumnName("P_DiagonalArticulation");
            entity.Property(e => e.PDmFk).HasColumnName("P_DM_Fk");
            entity.Property(e => e.PEndorsement)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("P_Endorsement");
            entity.Property(e => e.PExitLevelOutcome)
                .HasMaxLength(2000)
                .HasColumnName("P_ExitLevelOutcome");
            entity.Property(e => e.PFirstQualifier)
                .IsUnicode(false)
                .HasColumnName("P_FirstQualifier");
            entity.Property(e => e.PFirstQualifierVerify).HasColumnName("P_FirstQualifier_Verify");
            entity.Property(e => e.PFtpt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("P_FTPT");
            entity.Property(e => e.PGoverance).HasColumnName("P_Goverance");
            entity.Property(e => e.PHorizontalArticulation)
                .HasMaxLength(2000)
                .HasColumnName("P_HorizontalArticulation");
            entity.Property(e => e.PInstitutionName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("P_InstitutionName");
            entity.Property(e => e.PInternationalCompatibility).HasColumnName("P_InternationalCompatibility");
            entity.Property(e => e.PIsEducated)
                .HasDefaultValue(false)
                .HasColumnName("P_IsEducated");
            entity.Property(e => e.PJoinProgramme).HasColumnName("P_JoinProgramme");
            entity.Property(e => e.PLockReason)
                .HasMaxLength(1000)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("P_LockReason");
            entity.Property(e => e.PLocked)
                .HasDefaultValue(false)
                .HasColumnName("P_Locked");
            entity.Property(e => e.PModeOfProvisioning).HasColumnName("P_ModeOfProvisioning");
            entity.Property(e => e.PModifyDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime")
                .HasColumnName("P_ModifyDate");
            entity.Property(e => e.PMotivation)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("P_Motivation");
            entity.Property(e => e.PMultiDisciplinary).HasColumnName("P_MultiDisciplinary");
            entity.Property(e => e.PName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("P_Name");
            entity.Property(e => e.PNonInternationalCompatibility).HasColumnName("P_NonInternationalCompatibility");
            entity.Property(e => e.POperationalQualCode)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("P_Operational_QualCode");
            entity.Property(e => e.POrigin)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("P_Origin");
            entity.Property(e => e.PPSource).HasColumnName("P_P_Source");
            entity.Property(e => e.PProgrammeCategory)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("P_ProgrammeCategory");
            entity.Property(e => e.PPtFk).HasColumnName("P_PT_FK");
            entity.Property(e => e.PPurpose)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("P_Purpose");
            entity.Property(e => e.PQualificationDesignation)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("P_QualificationDesignation");
            entity.Property(e => e.PQualificationType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("P_QualificationType");
            entity.Property(e => e.PRationale)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("P_Rationale");
            entity.Property(e => e.PRulesOfProgression).HasColumnName("P_RulesOfProgression");
            entity.Property(e => e.PSecondQualifier)
                .IsUnicode(false)
                .HasColumnName("P_SecondQualifier");
            entity.Property(e => e.PSecondQualifierVerify).HasColumnName("P_SecondQualifier_Verify");
            entity.Property(e => e.PSiteOfDelivery)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("P_SiteOfDelivery");
            entity.Property(e => e.PThirdQualifier)
                .IsUnicode(false)
                .HasColumnName("P_ThirdQualifier");
            entity.Property(e => e.PThirdQualifierVerify).HasColumnName("P_ThirdQualifier_Verify");
            entity.Property(e => e.PUgpg)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("P_UGPG");
            entity.Property(e => e.PUnLockReason)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("P_UnLockReason");
            entity.Property(e => e.PUnLockVersion).HasColumnName("P_UnLockVersion");
            entity.Property(e => e.PVerticalArticulation)
                .HasMaxLength(2000)
                .HasColumnName("P_VerticalArticulation");
            entity.Property(e => e.PYear).HasColumnName("P_Year");

            entity.HasOne(d => d.PPtFkNavigation).WithMany(p => p.Programmes)
                .HasForeignKey(d => d.PPtFk)
                .HasConstraintName("FK__Programme__P_PT___1B0907CE");
        });

        modelBuilder.Entity<ProgrammesSmu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Programmes_SMU");

            entity.Property(e => e.AptsReferenceNumber).HasColumnName("APTS Reference Number");
            entity.Property(e => e.AuthorisedQualificationProgrammeName)
                .HasMaxLength(255)
                .HasColumnName("Authorised Qualification/Programme Name");
            entity.Property(e => e.CurrentProfessionalBoardAccreditationStatus)
                .HasMaxLength(255)
                .HasColumnName("Current Professional Board Accreditation Status");
            entity.Property(e => e.DateOfLastProfessionalBoardAccreditationVisit)
                .HasMaxLength(255)
                .HasColumnName("Date of last Professional Board Accreditation Visit");
            entity.Property(e => e.DateOfNextProfessionalBoardAccreditationVisit)
                .HasMaxLength(255)
                .HasColumnName("Date of Next Professional Board Accreditation Visit");
            entity.Property(e => e.DateOfNoticeForTheNextProfessionalBoardAccreditationVis)
                .HasMaxLength(255)
                .HasColumnName("Date of Notice for the Next Professional Board Accreditation Vis");
            entity.Property(e => e.DateProfessionalBoardAccreditationReportReceived)
                .HasMaxLength(255)
                .HasColumnName("Date Professional Board Accreditation Report Received");
            entity.Property(e => e.HeqcAccreditationOutcome)
                .HasMaxLength(255)
                .HasColumnName("HEQC Accreditation Outcome");
            entity.Property(e => e.HeqcHeqsfAccreditationReferenceNumber)
                .HasMaxLength(255)
                .HasColumnName("HEQC/HEQSF Accreditation Reference Number");
            entity.Property(e => e.IfYesNameOfTheProfessionalBodyOrIfNoNA)
                .HasMaxLength(255)
                .HasColumnName("If yes, Name of the Professional Body or If No, N/A");
            entity.Property(e => e.NameAndContactDetailsOfHeadOfDepartmentProgrammeCoordin)
                .HasMaxLength(255)
                .HasColumnName("Name and contact details of Head of Department/Programme Coordin");
            entity.Property(e => e.NqfCreditsAsPerPqm).HasColumnName("NQF Credits   (as per PQM)");
            entity.Property(e => e.NqfLevel).HasColumnName("NQF Level");
            entity.Property(e => e.OnTheUniversityDhetApprovedProgrammeQualificationMixP)
                .HasMaxLength(255)
                .HasColumnName("On the University DHET Approved Programme & qualification Mix (P");
            entity.Property(e => e.ProfessionalBoardRegulatedYesNo)
                .HasMaxLength(255)
                .HasColumnName("Professional Board Regulated (Yes/No)");
            entity.Property(e => e.ProgrammeStatusActiveInactive)
                .HasMaxLength(255)
                .HasColumnName("Programme Status  (Active / Inactive)");
            entity.Property(e => e.QipProgressToDate)
                .HasMaxLength(255)
                .HasColumnName("QIP Progress To date");
            entity.Property(e => e.QualityImprovementPlanQipDueDate)
                .HasMaxLength(255)
                .HasColumnName("Quality Improvement Plan (QIP) Due Date");
            entity.Property(e => e.SaqaRegistrationId).HasColumnName("SAQA Registration ID");
            entity.Property(e => e.SaqaRegistrationStatus)
                .HasMaxLength(255)
                .HasColumnName("SAQA registration Status");
            entity.Property(e => e.SchoolOf)
                .HasMaxLength(255)
                .HasColumnName("School of");
            entity.Property(e => e.SelfAssessmentQuestionnaireDueDate)
                .HasMaxLength(255)
                .HasColumnName("Self-Assessment Questionnaire  Due date ");
        });

        modelBuilder.Entity<ProgrammesUnlock>(entity =>
        {
            entity.HasKey(e => e.UnlockPPk).HasName("PK__Programm__D74312726F7920FB");

            entity.ToTable("Programmes_Unlock");

            entity.Property(e => e.UnlockPPk).HasColumnName("Unlock_P_Pk");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.ProgrammePPk).HasColumnName("Programme_P_Pk");
            entity.Property(e => e.UPk).HasColumnName("U_PK");
            entity.Property(e => e.UVal).HasColumnName("U_Val");
            entity.Property(e => e.UnlockPOrigin)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Unlock_P_Origin");

            entity.HasOne(d => d.ProgrammePPkNavigation).WithMany(p => p.ProgrammesUnlock)
                .HasForeignKey(d => d.ProgrammePPk)
                .HasConstraintName("Prg_PPk");

            entity.HasOne(d => d.UPkNavigation).WithMany(p => p.ProgrammesUnlock)
                .HasForeignKey(d => d.UPk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Prg_FK");
        });

        modelBuilder.Entity<Progress>(entity =>
        {
            entity.HasKey(e => e.PrgPk).HasName("PK__Progress__CC2BAE616D3E83DF");

            entity.Property(e => e.PrgPk).HasColumnName("PRG_Pk");
            entity.Property(e => e.PrgComment)
                .IsUnicode(false)
                .HasColumnName("PRG_Comment");
            entity.Property(e => e.PrgCreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("PRG_CreateDate");
            entity.Property(e => e.PrgDate)
                .HasColumnType("datetime")
                .HasColumnName("PRG_Date");
            entity.Property(e => e.PrgPFk).HasColumnName("PRG_P_Fk");
            entity.Property(e => e.PrgReferenceNumber)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("PRG_ReferenceNumber");
            entity.Property(e => e.PrgReportNote)
                .HasMaxLength(1000)
                .HasColumnName("PRG_ReportNote");
            entity.Property(e => e.PrgStFk).HasColumnName("PRG_ST_Fk");
            entity.Property(e => e.PrgUser).HasColumnName("PRG_User");
        });

        modelBuilder.Entity<ProgressDocuments>(entity =>
        {
            entity.HasKey(e => e.PrgdPk).HasName("PK__Progress__9EB2D61D46B9C000");

            entity.Property(e => e.PrgdPk).HasColumnName("PRGD_Pk");
            entity.Property(e => e.PrgdContentType)
                .HasMaxLength(300)
                .HasColumnName("PRGD_ContentType");
            entity.Property(e => e.PrgdCreateDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("PRGD_CreateDate");
            entity.Property(e => e.PrgdFileByte).HasColumnName("PRGD_FileByte");
            entity.Property(e => e.PrgdFileExtension)
                .HasMaxLength(100)
                .HasColumnName("PRGD_FileExtension");
            entity.Property(e => e.PrgdFileName)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("PRGD_FileName");
            entity.Property(e => e.PrgdFilePath)
                .IsUnicode(false)
                .HasColumnName("PRGD_FilePath");
            entity.Property(e => e.PrgdModifyDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("PRGD_ModifyDate");
            entity.Property(e => e.PrgdPFk).HasColumnName("PRGD_P_Fk");
            entity.Property(e => e.PrgdPrgFk).HasColumnName("PRGD_PRG_Fk");
            entity.Property(e => e.PrgdType).HasColumnName("PRGD_Type");
        });

        modelBuilder.Entity<QualificationDesignations>(entity =>
        {
            entity.HasKey(e => e.QdPk).HasName("PK__Qualific__CEAC3C8E6F4DF392");

            entity.Property(e => e.QdPk).HasColumnName("QD_PK");
            entity.Property(e => e.QdCreateDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("QD_CreateDate");
            entity.Property(e => e.QdDescription)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("QD_Description");
            entity.Property(e => e.QdDisabled)
                .HasDefaultValue(false)
                .HasColumnName("QD_Disabled");
            entity.Property(e => e.QdModifyDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("QD_ModifyDate");
            entity.Property(e => e.QdName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("QD_Name");
            entity.Property(e => e.QdOrdering).HasColumnName("QD_Ordering");
            entity.Property(e => e.QdPlaceholder)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("QD_Placeholder");
        });

        modelBuilder.Entity<Reports>(entity =>
        {
            entity.HasKey(e => e.RepPk).HasName("PK__Reports__D5D9BB4A53023185");

            entity.Property(e => e.RepPk).HasColumnName("REP_PK");
            entity.Property(e => e.RepCreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime")
                .HasColumnName("REP_CreateDate");
            entity.Property(e => e.RepEnabled)
                .HasDefaultValue(false)
                .HasColumnName("REP_Enabled");
            entity.Property(e => e.RepForAdmin)
                .HasDefaultValue(false)
                .HasColumnName("REP_ForAdmin");
            entity.Property(e => e.RepForUser)
                .HasDefaultValue(false)
                .HasColumnName("REP_ForUser");
            entity.Property(e => e.RepForViewer)
                .HasDefaultValue(false)
                .HasColumnName("REP_ForViewer");
            entity.Property(e => e.RepModifyDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime")
                .HasColumnName("REP_ModifyDate");
            entity.Property(e => e.RepName)
                .HasMaxLength(1000)
                .HasColumnName("REP_Name");
            entity.Property(e => e.RepUrl).HasColumnName("REP_URL");
        });

        modelBuilder.Entity<Settings>(entity =>
        {
            entity.HasKey(e => e.SsPk).HasName("PK__Settings__456FEDB759E35EE3");

            entity.Property(e => e.SsPk).HasColumnName("SS_PK");
            entity.Property(e => e.SsCreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime")
                .HasColumnName("SS_CreateDate");
            entity.Property(e => e.SsDescription)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("SS_Description");
            entity.Property(e => e.SsEncrypted).HasColumnName("SS_Encrypted");
            entity.Property(e => e.SsModifyDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime")
                .HasColumnName("SS_ModifyDate");
            entity.Property(e => e.SsName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("SS_Name");
            entity.Property(e => e.SsValue)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("SS_Value");
            entity.Property(e => e.SsValueDefault)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("SS_ValueDefault");
        });

        modelBuilder.Entity<ShortLearningProgramme>(entity =>
        {
            entity.HasKey(e => e.SlpPk).HasName("PK__ShortLea__13249CFCF3674B3D");

            entity.Property(e => e.SlpPk).HasColumnName("SLP_PK");
            entity.Property(e => e.SlpAbbreviation)
                .HasMaxLength(200)
                .HasColumnName("SLP_Abbreviation");
            entity.Property(e => e.SlpAdditionalVenuesAvailable).HasColumnName("SLP_AdditionalVenuesAvailable");
            entity.Property(e => e.SlpAdditionalVenuesDetails)
                .HasMaxLength(500)
                .HasColumnName("SLP_AdditionalVenuesDetails");
            entity.Property(e => e.SlpAdditionalVenuesRequired).HasColumnName("SLP_AdditionalVenuesRequired");
            entity.Property(e => e.SlpApprovedBy)
                .HasMaxLength(200)
                .HasColumnName("SLP_ApprovedBy");
            entity.Property(e => e.SlpAptsnumber)
                .HasMaxLength(100)
                .HasColumnName("SLP_APTSNumber");
            entity.Property(e => e.SlpAssessmentMethods)
                .HasMaxLength(1000)
                .HasColumnName("SLP_AssessmentMethods");
            entity.Property(e => e.SlpAttachment).HasColumnName("SLP_Attachment");
            entity.Property(e => e.SlpBriefDescriptionofContent)
                .HasMaxLength(1000)
                .HasColumnName("SLP_BriefDescriptionofContent");
            entity.Property(e => e.SlpBroaderBenfitsOfSlp)
                .HasMaxLength(1000)
                .HasColumnName("SLP_BroaderBenfitsOfSLP");
            entity.Property(e => e.SlpCertification).HasColumnName("SLP_Certification");
            entity.Property(e => e.SlpCesmfirstOrder)
                .HasMaxLength(100)
                .HasColumnName("SLP_CESMFirstOrder");
            entity.Property(e => e.SlpCesmsecondOrder)
                .HasMaxLength(100)
                .HasColumnName("SLP_CESMSecondOrder");
            entity.Property(e => e.SlpCesmthirdOrder)
                .HasMaxLength(100)
                .HasColumnName("SLP_CESMThirdOrder");
            entity.Property(e => e.SlpCompleteSlpinOneSem)
                .HasMaxLength(500)
                .HasColumnName("SLP_CompleteSLPInOneSem");
            entity.Property(e => e.SlpCompleteSlpinOneYear)
                .HasMaxLength(500)
                .HasColumnName("SLP_CompleteSLPInOneYear");
            entity.Property(e => e.SlpCreatedDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("SLP_CreatedDate");
            entity.Property(e => e.SlpDateOfSenateApproval)
                .HasColumnType("smalldatetime")
                .HasColumnName("SLP_DateOfSenateApproval");
            entity.Property(e => e.SlpDateOfSenexApproval)
                .HasColumnType("smalldatetime")
                .HasColumnName("SLP_DateOfSenexApproval");
            entity.Property(e => e.SlpDesignation)
                .HasMaxLength(200)
                .HasColumnName("SLP_Designation");
            entity.Property(e => e.SlpDurationOther)
                .HasMaxLength(500)
                .HasColumnName("SLP_DurationOther");
            entity.Property(e => e.SlpEvaluationCriteria)
                .HasMaxLength(1000)
                .HasColumnName("SLP_EvaluationCriteria");
            entity.Property(e => e.SlpExaminationMarkWeight)
                .HasMaxLength(100)
                .HasColumnName("SLP_ExaminationMarkWeight");
            entity.Property(e => e.SlpFeasibilityDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("SLP_FeasibilityDate");
            entity.Property(e => e.SlpFullPeriodMarkCalculationDescription)
                .HasMaxLength(500)
                .HasColumnName("SLP_FullPeriodMarkCalculationDescription");
            entity.Property(e => e.SlpFullPeriodMarkWeight)
                .HasMaxLength(100)
                .HasColumnName("SLP_FullPeriodMarkWeight");
            entity.Property(e => e.SlpIsActive)
                .HasDefaultValue(true)
                .HasColumnName("SLP_IsActive");
            entity.Property(e => e.SlpLocked)
                .HasDefaultValue(false)
                .HasColumnName("SLP_Locked");
            entity.Property(e => e.SlpMinFinalMarkToPass)
                .HasMaxLength(100)
                .HasColumnName("SLP_MinFinalMarkToPass");
            entity.Property(e => e.SlpMinFullPeriodMarksAdmission)
                .HasMaxLength(100)
                .HasColumnName("SLP_MinFullPeriodMarksAdmission");
            entity.Property(e => e.SlpModerationCreditBearing)
                .HasMaxLength(1000)
                .HasColumnName("SLP_ModerationCreditBearing");
            entity.Property(e => e.SlpModerationNonCreditBearing)
                .HasMaxLength(1000)
                .HasColumnName("SLP_ModerationNonCreditBearing");
            entity.Property(e => e.SlpModifiedDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("SLP_ModifiedDate");
            entity.Property(e => e.SlpNqflevelCreditBearing)
                .HasMaxLength(200)
                .HasColumnName("SLP_NQFLevelCreditBearing");
            entity.Property(e => e.SlpNqflevelNonCreditBearing)
                .HasMaxLength(200)
                .HasColumnName("SLP_NQFLevelNonCreditBearing");
            entity.Property(e => e.SlpNqflevelType)
                .HasMaxLength(10)
                .HasColumnName("SLP_NQFLevelType");
            entity.Property(e => e.SlpNqflevelofSlp)
                .HasMaxLength(50)
                .HasColumnName("SLP_NQFLevelofSLP");
            entity.Property(e => e.SlpOrigin)
                .HasMaxLength(100)
                .HasColumnName("SLP_Origin");
            entity.Property(e => e.SlpOutcomeCreditBearing)
                .HasMaxLength(1000)
                .HasColumnName("SLP_OutcomeCreditBearing");
            entity.Property(e => e.SlpOutcomeNonCreditBearing)
                .HasMaxLength(1000)
                .HasColumnName("SLP_OutcomeNonCreditBearing");
            entity.Property(e => e.SlpProgrammeName)
                .HasMaxLength(500)
                .HasColumnName("SLP_ProgrammeName");
            entity.Property(e => e.SlpPurposeOfStatement)
                .HasMaxLength(1000)
                .HasColumnName("SLP_PurposeOfStatement");
            entity.Property(e => e.SlpReasonForSlp)
                .HasMaxLength(1000)
                .HasColumnName("SLP_ReasonForSLP");
            entity.Property(e => e.SlpSecificBenefitsToUj)
                .HasMaxLength(1000)
                .HasColumnName("SLP_SecificBenefitsToUJ");
            entity.Property(e => e.SlpSignature)
                .HasMaxLength(200)
                .HasColumnName("SLP_Signature");
            entity.Property(e => e.SlpTeachingAndLearningMethods)
                .HasMaxLength(1000)
                .HasColumnName("SLP_TeachingAndLearningMethods");
            entity.Property(e => e.SlpTeachingAndLearningStrategy)
                .HasMaxLength(1000)
                .HasColumnName("SLP_TeachingAndLearningStrategy");
            entity.Property(e => e.SlpTypicalStudentDescription)
                .HasMaxLength(1000)
                .HasColumnName("SLP_TypicalStudentDescription");
            entity.Property(e => e.SlpUnLockVersion).HasColumnName("SLP_UnLockVersion");
            entity.Property(e => e.SlpValueForQualifyingStudent)
                .HasMaxLength(1000)
                .HasColumnName("SLP_ValueForQualifyingStudent");
        });

        modelBuilder.Entity<SiteOfDelivery>(entity =>
        {
            entity.HasKey(e => e.SodPk).HasName("PK__SiteOfDe__3B135B4F5282FC8D");

            entity.Property(e => e.SodPk).HasColumnName("SOD_PK");
            entity.Property(e => e.SodCreateDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("SOD_CreateDate");
            entity.Property(e => e.SodDescription)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("SOD_Description");
            entity.Property(e => e.SodModifyDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("SOD_ModifyDate");
            entity.Property(e => e.SodName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("SOD_Name");
        });

        modelBuilder.Entity<SlpapplicationDetails>(entity =>
        {
            entity.HasKey(e => e.SlpappPk).HasName("PK__SLPAppli__88914893222DDC83");

            entity.ToTable("SLPApplicationDetails");

            entity.Property(e => e.SlpappPk).HasColumnName("SLPApp_PK");
            entity.Property(e => e.SlpappDateSubmittedToCollegeBoard)
                .HasColumnType("smalldatetime")
                .HasColumnName("SLPAppDateSubmittedToCollegeBoard");
            entity.Property(e => e.SlpappDateSubmittedToPwg)
                .HasColumnType("smalldatetime")
                .HasColumnName("SLPAppDateSubmittedToPWG");
            entity.Property(e => e.SlpappDepartment)
                .HasMaxLength(100)
                .HasColumnName("SLPApp_Department");
            entity.Property(e => e.SlpappEmail)
                .HasMaxLength(200)
                .HasColumnName("SLPAppEmail");
            entity.Property(e => e.SlpappFaculty)
                .HasMaxLength(100)
                .HasColumnName("SLPApp_Faculty");
            entity.Property(e => e.SlpappSlpFk).HasColumnName("SLPApp_SLP_FK");

            entity.HasOne(d => d.SlpappSlpFkNavigation).WithMany(p => p.SlpapplicationDetails)
                .HasForeignKey(d => d.SlpappSlpFk)
                .HasConstraintName("FK__SLPApplic__SLPAp__2C745649");
        });

        modelBuilder.Entity<SlpcalculationCriteria>(entity =>
        {
            entity.HasKey(e => e.SlpcalPk).HasName("PK__SLPCalcu__10BE9D67FEE4369F");

            entity.ToTable("SLPCalculationCriteria");

            entity.Property(e => e.SlpcalPk).HasColumnName("SLPCal_PK");
            entity.Property(e => e.SlpMarks).HasColumnName("SLP_Marks");
            entity.Property(e => e.SlpcalAssessmentName)
                .HasMaxLength(100)
                .HasColumnName("SLPCal_AssessmentName");
            entity.Property(e => e.SlpcalNatureFormat1)
                .HasMaxLength(200)
                .HasColumnName("SLPCal_NatureFormat1");
            entity.Property(e => e.SlpcalNatureFormat2)
                .HasMaxLength(200)
                .HasColumnName("SLPCal_NatureFormat2");
            entity.Property(e => e.SlpcalNatureFormat3)
                .HasMaxLength(200)
                .HasColumnName("SLPCal_NatureFormat3");
            entity.Property(e => e.SlpcalSlpFk).HasColumnName("SLPCal_SLP_FK");

            entity.HasOne(d => d.SlpcalSlpFkNavigation).WithMany(p => p.SlpcalculationCriteria)
                .HasForeignKey(d => d.SlpcalSlpFk)
                .HasConstraintName("FK__SLPCalcul__SLPCa__3BB699D9");
        });

        modelBuilder.Entity<Slpcampus>(entity =>
        {
            entity.HasKey(e => e.SlpcPk).HasName("PK__SLPCampu__2E901EEE011973F8");

            entity.ToTable("SLPCampus");

            entity.Property(e => e.SlpcPk).HasColumnName("SLPC_PK");
            entity.Property(e => e.SlpCampus)
                .HasMaxLength(20)
                .HasColumnName("SLP_Campus");
            entity.Property(e => e.SlpcSlpFk).HasColumnName("SLPC_SLP_FK");

            entity.HasOne(d => d.SlpcSlpFkNavigation).WithMany(p => p.Slpcampus)
                .HasForeignKey(d => d.SlpcSlpFk)
                .HasConstraintName("FK__SLPCampus__SLPC___2F50C2F4");
        });

        modelBuilder.Entity<SlpstrategicPriorities>(entity =>
        {
            entity.HasKey(e => e.SlpSpPk).HasName("PK__SLPStrat__AADD7EF8DA263627");

            entity.ToTable("SLPStrategicPriorities");

            entity.Property(e => e.SlpSpPk).HasColumnName("SLP_SP_PK");
            entity.Property(e => e.TslpSlpFk).HasColumnName("TSLP_SLP_FK");
            entity.Property(e => e.TslpSpFk).HasColumnName("TSLP_SP_FK");

            entity.HasOne(d => d.TslpSlpFkNavigation).WithMany(p => p.SlpstrategicPriorities)
                .HasForeignKey(d => d.TslpSlpFk)
                .HasConstraintName("FK__SLPStrate__TSLP___35099C4A");
        });

        modelBuilder.Entity<StaffingPlan>(entity =>
        {
            entity.HasKey(e => e.SpPk).HasName("PK__Staffing__AA24014A929CC264");

            entity.Property(e => e.SpPk).HasColumnName("SP_PK");
            entity.Property(e => e.SpContentType)
                .HasMaxLength(300)
                .HasColumnName("SP_ContentType");
            entity.Property(e => e.SpCreateDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("SP_CreateDate");
            entity.Property(e => e.SpFileByte).HasColumnName("SP_FileByte");
            entity.Property(e => e.SpFileExtension)
                .HasMaxLength(100)
                .HasColumnName("SP_FileExtension");
            entity.Property(e => e.SpFileName)
                .HasMaxLength(500)
                .HasColumnName("SP_FileName");
            entity.Property(e => e.SpFilePath)
                .HasMaxLength(1000)
                .HasColumnName("SP_FilePath");
            entity.Property(e => e.SpModifyDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("SP_ModifyDate");
            entity.Property(e => e.SpPFk).HasColumnName("SP_P_FK");
            entity.Property(e => e.SpType).HasColumnName("SP_Type");
        });

        modelBuilder.Entity<StatusBlock>(entity =>
        {
            entity.HasKey(e => e.SbPk).HasName("PK__StatusBl__2CC83917574DAF04");

            entity.Property(e => e.SbPk)
                .ValueGeneratedNever()
                .HasColumnName("SB_PK");
            entity.Property(e => e.SbAltCategory).HasColumnName("SB_AltCategory");
            entity.Property(e => e.SbAptsStatus).HasColumnName("SB_APTS_Status");
            entity.Property(e => e.SbClosed).HasColumnName("SB_Closed");
            entity.Property(e => e.SbColour)
                .HasMaxLength(100)
                .HasColumnName("SB_Colour");
            entity.Property(e => e.SbCreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("SB_CreateDate");
            entity.Property(e => e.SbDefault).HasColumnName("SB_Default");
            entity.Property(e => e.SbDescription)
                .HasMaxLength(500)
                .HasColumnName("SB_Description");
            entity.Property(e => e.SbEditable).HasColumnName("SB_Editable");
            entity.Property(e => e.SbEnabled).HasColumnName("SB_Enabled");
            entity.Property(e => e.SbLocked).HasColumnName("SB_Locked");
            entity.Property(e => e.SbModifyDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("SB_ModifyDate");
            entity.Property(e => e.SbName)
                .HasMaxLength(500)
                .HasColumnName("SB_Name");
            entity.Property(e => e.SbOrdering).HasColumnName("SB_Ordering");
            entity.Property(e => e.SbScFk).HasColumnName("SB_SC_FK");
        });

        modelBuilder.Entity<StatusCategory>(entity =>
        {
            entity.HasKey(e => e.ScPk).HasName("PK__StatusCa__C405A2409546EC66");

            entity.Property(e => e.ScPk)
                .ValueGeneratedNever()
                .HasColumnName("SC_Pk");
            entity.Property(e => e.ScAltCategory)
                .HasDefaultValue(false)
                .HasColumnName("SC_AltCategory");
            entity.Property(e => e.ScAptsStatus)
                .HasDefaultValue(false)
                .HasColumnName("SC_APTS_Status");
            entity.Property(e => e.ScClosed).HasColumnName("SC_Closed");
            entity.Property(e => e.ScColour)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SC_Colour");
            entity.Property(e => e.ScCreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("SC_CreateDate");
            entity.Property(e => e.ScDefault)
                .HasDefaultValue(false)
                .HasColumnName("SC_Default");
            entity.Property(e => e.ScDescription)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SC_Description");
            entity.Property(e => e.ScEditable).HasColumnName("SC_Editable");
            entity.Property(e => e.ScEnabled).HasColumnName("SC_Enabled");
            entity.Property(e => e.ScGroupId).HasColumnName("SC_Group_Id");
            entity.Property(e => e.ScLocked).HasColumnName("SC_Locked");
            entity.Property(e => e.ScModifyDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("SC_ModifyDate");
            entity.Property(e => e.ScName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("SC_Name");
            entity.Property(e => e.ScOrdering).HasColumnName("SC_Ordering");
            entity.Property(e => e.ScPrevPk).HasColumnName("SC_PrevPK");

            entity.HasOne(d => d.ScGroup).WithMany(p => p.StatusCategory)
                .HasForeignKey(d => d.ScGroupId)
                .HasConstraintName("FK_StatusCategory_StatusGroup");
        });

        modelBuilder.Entity<StatusGroup>(entity =>
        {
            entity.HasKey(e => e.GroupId).HasName("PK__Status_G__319812094428467A");

            entity.ToTable("Status_Group");

            entity.Property(e => e.GroupId)
                .ValueGeneratedNever()
                .HasColumnName("Group_Id");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Created_Date");
            entity.Property(e => e.GroupBgColor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Group_Bg_Color");
            entity.Property(e => e.GroupName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Group_Name");
            entity.Property(e => e.GroupOrder).HasColumnName("Group_Order");
            entity.Property(e => e.GroupTColor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Group_T_Color");
        });

        modelBuilder.Entity<StatusRoles>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.SrCrFk).HasColumnName("SR_CR_FK");
            entity.Property(e => e.SrCreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime")
                .HasColumnName("SR_CreateDate");
            entity.Property(e => e.SrModifyDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime")
                .HasColumnName("SR_ModifyDate");
            entity.Property(e => e.SrPk).HasColumnName("SR_Pk");
            entity.Property(e => e.SrSFk).HasColumnName("SR_S_FK");
        });

        modelBuilder.Entity<StatusRolesLimited>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.SrlCrFk).HasColumnName("SRL_CR_FK");
            entity.Property(e => e.SrlCreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime")
                .HasColumnName("SRL_CreateDate");
            entity.Property(e => e.SrlModifyDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime")
                .HasColumnName("SRL_ModifyDate");
            entity.Property(e => e.SrlPk)
                .ValueGeneratedOnAdd()
                .HasColumnName("SRL_Pk");
            entity.Property(e => e.SrlSFk).HasColumnName("SRL_S_FK");
        });

        modelBuilder.Entity<Statusses>(entity =>
        {
            entity.HasKey(e => e.SPk).HasName("PK__Statusse__A3DCB447A7B36CFC");

            entity.Property(e => e.SPk).HasColumnName("S_Pk");
            entity.Property(e => e.SAltCategory)
                .HasDefaultValue(false)
                .HasColumnName("S_AltCategory");
            entity.Property(e => e.SAptsStatus)
                .HasDefaultValue(false)
                .HasColumnName("S_APTS_Status");
            entity.Property(e => e.SClosed).HasColumnName("S_Closed");
            entity.Property(e => e.SColour)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("S_Colour");
            entity.Property(e => e.SCreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime")
                .HasColumnName("S_CreateDate");
            entity.Property(e => e.SDefault)
                .HasDefaultValue(false)
                .HasColumnName("S_Default");
            entity.Property(e => e.SDescription)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("S_Description");
            entity.Property(e => e.SEditable).HasColumnName("S_Editable");
            entity.Property(e => e.SEnabled).HasColumnName("S_Enabled");
            entity.Property(e => e.SGroupId).HasColumnName("S_Group_Id");
            entity.Property(e => e.SIsInActive).HasColumnName("S_IsInActive");
            entity.Property(e => e.SLocked).HasColumnName("S_Locked");
            entity.Property(e => e.SModifyDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime")
                .HasColumnName("S_ModifyDate");
            entity.Property(e => e.SName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("S_Name");
            entity.Property(e => e.SOrdering).HasColumnName("S_Ordering");
            entity.Property(e => e.SSFk).HasColumnName("S_S_Fk");
            entity.Property(e => e.SSystemReference)
                .HasMaxLength(500)
                .HasColumnName("S_SystemReference");

            entity.HasOne(d => d.SGroup).WithMany(p => p.Statusses)
                .HasForeignKey(d => d.SGroupId)
                .HasConstraintName("FK_Statusses_StatusGroup");
        });

        modelBuilder.Entity<Tally>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<TemplateArchive>(entity =>
        {
            entity.HasKey(e => e.TaPk).HasName("PK__Template__2F621646A211E78C");

            entity.Property(e => e.TaPk).HasColumnName("TA_PK");
            entity.Property(e => e.TaCreateDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("TA_CreateDate");
            entity.Property(e => e.TaModifyDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("TA_ModifyDate");
            entity.Property(e => e.TaName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TA_Name");
            entity.Property(e => e.TaPFk).HasColumnName("TA_P_Fk");
            entity.Property(e => e.TaPath)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TA_Path");
            entity.Property(e => e.TaTFk).HasColumnName("TA_T_FK");
            entity.Property(e => e.TaUser).HasColumnName("TA_User");
        });

        modelBuilder.Entity<TemplatePlaceholders>(entity =>
        {
            entity.HasKey(e => e.TpPk).HasName("PK__Template__81012B4402BA7154");

            entity.Property(e => e.TpPk).HasColumnName("TP_Pk");
            entity.Property(e => e.TpDefinition)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TP_Definition");
            entity.Property(e => e.TpLocation)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TP_Location");
            entity.Property(e => e.TpPlaceholder)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TP_Placeholder");
        });

        modelBuilder.Entity<Templates>(entity =>
        {
            entity.HasKey(e => e.TPk).HasName("PK__Template__83BB2010B16999F6");

            entity.Property(e => e.TPk).HasColumnName("T_PK");
            entity.Property(e => e.TCreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime")
                .HasColumnName("T_CreateDate");
            entity.Property(e => e.TDescription)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("T_Description");
            entity.Property(e => e.TEnabled).HasColumnName("T_Enabled");
            entity.Property(e => e.TModifyDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime")
                .HasColumnName("T_ModifyDate");
            entity.Property(e => e.TName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("T_Name");
            entity.Property(e => e.TPath)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("T_Path");
            entity.Property(e => e.TVersion)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("T_Version");
        });

        modelBuilder.Entity<TimeTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TimeTable", "tt");

            entity.Property(e => e.TtCComment).HasColumnName("TT_C_Comment");
            entity.Property(e => e.TtCPeriodGroups).HasColumnName("TT_C_PeriodGroups");
            entity.Property(e => e.TtCVenueSize).HasColumnName("TT_C_VenueSize");
            entity.Property(e => e.TtCVenueType).HasColumnName("TT_C_VenueType");
            entity.Property(e => e.TtCampus)
                .HasMaxLength(100)
                .HasColumnName("TT_Campus");
            entity.Property(e => e.TtMdlFk).HasColumnName("TT_MDL_Fk");
            entity.Property(e => e.TtPComment).HasColumnName("TT_P_Comment");
            entity.Property(e => e.TtPPeriodGroups).HasColumnName("TT_P_PeriodGroups");
            entity.Property(e => e.TtPVenueSize).HasColumnName("TT_P_VenueSize");
            entity.Property(e => e.TtPVenueType).HasColumnName("TT_P_VenueType");
            entity.Property(e => e.TtPk)
                .ValueGeneratedOnAdd()
                .HasColumnName("TT_PK");
            entity.Property(e => e.TtTComment).HasColumnName("TT_T_Comment");
            entity.Property(e => e.TtTPeriodGroups).HasColumnName("TT_T_PeriodGroups");
            entity.Property(e => e.TtTVenueSize).HasColumnName("TT_T_VenueSize");
            entity.Property(e => e.TtTVenueType).HasColumnName("TT_T_VenueType");
            entity.Property(e => e.TtTotalStudents).HasColumnName("TT_Total#_Students");
        });

        modelBuilder.Entity<TmplSelect>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.DrivePath)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Path)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Pk).HasColumnName("PK");
            entity.Property(e => e.Version)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ToolTips>(entity =>
        {
            entity.HasKey(e => e.TtPk).HasName("PK__ToolTips__E9D6D4F363E6FE7E");

            entity.Property(e => e.TtPk).HasColumnName("TT_Pk");
            entity.Property(e => e.TtCategory)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TT_Category");
            entity.Property(e => e.TtCreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime")
                .HasColumnName("TT_CreateDate");
            entity.Property(e => e.TtIdentifier)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TT_Identifier");
            entity.Property(e => e.TtModifyDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime")
                .HasColumnName("TT_ModifyDate");
            entity.Property(e => e.TtTooltip)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("TT_Tooltip");
        });

        modelBuilder.Entity<TypeOfSlp>(entity =>
        {
            entity.HasKey(e => e.TslpPk).HasName("PK__TypeOfSL__FC0D29785E69D33C");

            entity.ToTable("TypeOfSLP");

            entity.Property(e => e.TslpPk).HasColumnName("TSLP_PK");
            entity.Property(e => e.TslpAssessStudentCompetencies).HasColumnName("TSLP_AssessStudentCompetencies");
            entity.Property(e => e.TslpCostAssociated)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("TSLP_CostAssociated");
            entity.Property(e => e.TslpCreditBearing).HasColumnName("TSLP_CreditBearing");
            entity.Property(e => e.TslpIsCollaborativeJointSlp).HasColumnName("TSLP_IsCollaborativeJointSLP");
            entity.Property(e => e.TslpIsSlpacceptedForCpd).HasColumnName("TSLP_IsSLPAcceptedForCPD");
            entity.Property(e => e.TslpIsSlpthirdPartyCollab).HasColumnName("TSLP_IsSLPThirdPartyCollab");
            entity.Property(e => e.TslpIsSlpthirdPartyCollabCpd).HasColumnName("TSLP_IsSLPThirdPartyCollabCPD");
            entity.Property(e => e.TslpModeOfProvisioning).HasColumnName("TSLP_ModeOfProvisioning");
            entity.Property(e => e.TslpNonCreditBearing).HasColumnName("TSLP_NonCreditBearing");
            entity.Property(e => e.TslpParticipantsAttendanceRequired).HasColumnName("TSLP_ParticipantsAttendanceRequired");
            entity.Property(e => e.TslpSlpFk).HasColumnName("TSLP_SLP_FK");
            entity.Property(e => e.TslpThirdPartyCollabName)
                .HasMaxLength(200)
                .HasColumnName("TSLP_ThirdPartyCollabName");
            entity.Property(e => e.TslpThirdPartyCollabNameCpd)
                .HasMaxLength(200)
                .HasColumnName("TSLP_ThirdPartyCollabNameCPD");

            entity.HasOne(d => d.TslpSlpFkNavigation).WithMany(p => p.TypeOfSlp)
                .HasForeignKey(d => d.TslpSlpFk)
                .HasConstraintName("FK__TypeOfSLP__TSLP___322D2F9F");
        });

        modelBuilder.Entity<UnlockList>(entity =>
        {
            entity.HasKey(e => e.UPk).HasName("Unlock_P_Key");

            entity.ToTable("Unlock_List");

            entity.Property(e => e.UPk).HasColumnName("U_PK");
            entity.Property(e => e.UCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("U_CreateDate");
            entity.Property(e => e.UText)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("U_Text");
            entity.Property(e => e.UVal).HasColumnName("U_Val");
        });

        modelBuilder.Entity<UnlockTypeList>(entity =>
        {
            entity.HasKey(e => e.UPk).HasName("Unlock_T_P_Key");

            entity.ToTable("Unlock_Type_List");

            entity.Property(e => e.UPk).HasColumnName("U_PK");
            entity.Property(e => e.UCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("U_CreateDate");
            entity.Property(e => e.UText)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("U_Text");
            entity.Property(e => e.UVal).HasColumnName("U_Val");
        });

        modelBuilder.Entity<UserParamaters>(entity =>
        {
            entity.HasKey(e => e.UpPk).HasName("PK__UserPara__86D3F041D3D12999");

            entity.Property(e => e.UpPk).HasColumnName("UP_Pk");
            entity.Property(e => e.UpCreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime")
                .HasColumnName("UP_CreateDate");
            entity.Property(e => e.UpModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime")
                .HasColumnName("UP_ModifiedDate");
            entity.Property(e => e.UpParameterKey).HasColumnName("UP_ParameterKey");
            entity.Property(e => e.UpParameterName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("UP_ParameterName");
            entity.Property(e => e.UpUserName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("UP_UserName");
            entity.Property(e => e.UpValue)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("UP_Value");
        });

        modelBuilder.Entity<VCampusAll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_Campus_All");

            entity.Property(e => e.Label)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Value)
                .HasMaxLength(259)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VCampusGroupings>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_CampusGroupings");

            entity.Property(e => e.CampusGroup)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CampusGroupKey)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VDataLinking>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_DataLinking");

            entity.Property(e => e.HemisQualificationTypeCode)
                .HasMaxLength(15)
                .HasColumnName("HEMIS Qualification Type Code");
            entity.Property(e => e.HemisQualificationTypeDescription)
                .HasMaxLength(1024)
                .HasColumnName("HEMIS Qualification Type Description");
            entity.Property(e => e.ItsNqfLevel)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("ITS NQF Level");
            entity.Property(e => e.ItsNqfLevelDescription)
                .HasMaxLength(1024)
                .HasColumnName("ITS NQF Level Description");
            entity.Property(e => e.ItsPostGraduateCode)
                .HasMaxLength(1)
                .HasColumnName("ITS Post Graduate Code");
            entity.Property(e => e.ItsPostGraduateDescription)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("ITS Post Graduate Description");
            entity.Property(e => e.ItsPostGraduateOrderBy).HasColumnName("ITS Post Graduate Order by");
            entity.Property(e => e.ItsQualificationTypeCode)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("ITS Qualification Type Code");
            entity.Property(e => e.ItsQualificationTypeDescription)
                .HasMaxLength(30)
                .HasColumnName("ITS Qualification Type Description");
            entity.Property(e => e.MinimumTotalTime).HasColumnName("Minimum Total Time");
            entity.Property(e => e.QualificationTypeCohortAnalysisGrouping)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("Qualification Type Cohort Analysis Grouping");
            entity.Property(e => e.QualificationTypeGrouping)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("Qualification Type Grouping");
            entity.Property(e => e.QualificationTypeGrouping2)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("Qualification Type Grouping2");
            entity.Property(e => e.QualificationTypeGrouping2OrderBy).HasColumnName("Qualification Type Grouping2 Order by");
            entity.Property(e => e.QualificationTypeGroupingOrderBy).HasColumnName("Qualification Type Grouping Order by");
        });

        modelBuilder.Entity<VPersonnel>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_Personnel");

            entity.Property(e => e.AuthDepartment)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("AUTH_Department");
            entity.Property(e => e.AuthEmail)
                .HasMaxLength(109)
                .IsUnicode(false)
                .HasColumnName("AUTH_Email");
            entity.Property(e => e.AuthFaculty)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("AUTH_Faculty");
            entity.Property(e => e.AuthGender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("AUTH_Gender");
            entity.Property(e => e.AuthGroup)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("AUTH_Group");
            entity.Property(e => e.AuthInstitution)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("AUTH_Institution");
            entity.Property(e => e.AuthName)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("AUTH_Name");
            entity.Property(e => e.AuthNationality)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("AUTH_Nationality");
            entity.Property(e => e.AuthPk)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("Auth_Pk");
            entity.Property(e => e.AuthReferenceNumber)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("AUTH_ReferenceNumber");
            entity.Property(e => e.AuthSurname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("AUTH_Surname");
            entity.Property(e => e.AuthTitle)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("AUTH_Title");
            entity.Property(e => e.AuthYear).HasColumnName("AUTH_Year");
        });

        modelBuilder.Entity<VProgrammeLockedStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_Programme_LockedStatus");

            entity.Property(e => e.PrgPFk).HasColumnName("PRG_P_FK");
        });

        modelBuilder.Entity<VProgrammeLockedStatusTt>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_Programme_LockedStatus_TT");

            entity.Property(e => e.PrgPFk).HasColumnName("PRG_P_FK");
        });

        modelBuilder.Entity<VProgrammeStatusSummary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_Programme_StatusSummary");

            entity.Property(e => e.Locked).HasColumnName("LOCKED");
            entity.Property(e => e.PrgDate)
                .HasColumnType("datetime")
                .HasColumnName("PRG_Date");
            entity.Property(e => e.PrgPFk).HasColumnName("PRG_P_Fk");
            entity.Property(e => e.PrgStFk).HasColumnName("PRG_ST_Fk");
            entity.Property(e => e.Rn).HasColumnName("RN");
            entity.Property(e => e.SSFk).HasColumnName("S_S_Fk");
        });

        modelBuilder.Entity<VProgrammeStatusSummaryTt>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_Programme_StatusSummary_TT");

            entity.Property(e => e.Locked).HasColumnName("LOCKED");
            entity.Property(e => e.PrgDate)
                .HasColumnType("datetime")
                .HasColumnName("PRG_Date");
            entity.Property(e => e.PrgPFk).HasColumnName("PRG_P_FK");
            entity.Property(e => e.PrgStFk).HasColumnName("PRG_ST_Fk");
            entity.Property(e => e.Rn).HasColumnName("RN");
            entity.Property(e => e.SSFk).HasColumnName("S_S_FK");
        });

        modelBuilder.Entity<VersionData>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("versionData");

            entity.Property(e => e.Columns)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Programme1)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.VersionProgramme1)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.VersionProgramme2)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    public override int SaveChanges()
    {
        throw new NotSupportedException("This DbContext is read-only.");
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        throw new NotSupportedException("This DbContext is read-only.");
    }
}

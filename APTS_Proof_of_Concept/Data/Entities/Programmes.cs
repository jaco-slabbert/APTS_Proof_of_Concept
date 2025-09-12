using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class Programmes
{
    public int PPk { get; set; }

    public string? PName { get; set; }

    public string? PAbbreviation { get; set; }

    public int? PPtFk { get; set; }

    public int? PYear { get; set; }

    public bool? PActive { get; set; }

    public string? PAptsnumber { get; set; }

    public string? PUgpg { get; set; }

    public string? PQualificationType { get; set; }

    public string? PQualificationDesignation { get; set; }

    public string? PCesmcategory { get; set; }

    public string? PFirstQualifier { get; set; }

    public string? PSecondQualifier { get; set; }

    public bool? PFirstQualifierVerify { get; set; }

    public bool? PSecondQualifierVerify { get; set; }

    public string? PAlternativeDesignation { get; set; }

    public string? PMotivation { get; set; }

    public bool? PGoverance { get; set; }

    public string? PProgrammeCategory { get; set; }

    public string? PEndorsement { get; set; }

    public int? PDmFk { get; set; }

    public bool? PMultiDisciplinary { get; set; }

    public string? PSiteOfDelivery { get; set; }

    public string? PFtpt { get; set; }

    public int? PPSource { get; set; }

    public DateTime? PCreateDate { get; set; }

    public DateTime? PModifyDate { get; set; }

    public string? PRationale { get; set; }

    public string? PPurpose { get; set; }

    public bool? PJoinProgramme { get; set; }

    public string? PInstitutionName { get; set; }

    public int? PCreator { get; set; }

    public string? POperationalQualCode { get; set; }

    public string? POrigin { get; set; }

    public string? PExitLevelOutcome { get; set; }

    public string? PArticulation { get; set; }

    public string? PAssociatedAssessmentCriteria { get; set; }

    public string? PRulesOfProgression { get; set; }

    public string? PInternationalCompatibility { get; set; }

    public string? PNonInternationalCompatibility { get; set; }

    public string? PModeOfProvisioning { get; set; }

    public bool? PIsEducated { get; set; }

    public string? PThirdQualifier { get; set; }

    public bool? PThirdQualifierVerify { get; set; }

    public bool? PLocked { get; set; }

    public string? PLockReason { get; set; }

    public string? PUnLockReason { get; set; }

    public int? PUnLockVersion { get; set; }

    public string? PHorizontalArticulation { get; set; }

    public string? PVerticalArticulation { get; set; }

    public string? PDiagonalArticulation { get; set; }

    public virtual ICollection<DeliveryAndCesms> DeliveryAndCesms { get; set; } = new List<DeliveryAndCesms>();

    public virtual ICollection<HeqcandChe> HeqcandChe { get; set; } = new List<HeqcandChe>();

    public virtual ICollection<Nqf> Nqf { get; set; } = new List<Nqf>();

    public virtual ICollection<OrgStructure> OrgStructure { get; set; } = new List<OrgStructure>();

    public virtual ProgrammeTypes? PPtFkNavigation { get; set; }

    public virtual ICollection<Pqm> Pqm { get; set; } = new List<Pqm>();

    public virtual ICollection<ProgrammesUnlock> ProgrammesUnlock { get; set; } = new List<ProgrammesUnlock>();
}

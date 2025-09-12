using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class ProgrammeInfoPqm
{
    public int PPk { get; set; }

    public string? PName { get; set; }

    public string? PAbbreviation { get; set; }

    public int PPtFk { get; set; }

    public int PYear { get; set; }

    public int PActive { get; set; }

    public int? PAptsnumber { get; set; }

    public string? PUgpg { get; set; }

    public double? PQualificationType { get; set; }

    public int PQualificationDesignation { get; set; }

    public string? PCesmcategory { get; set; }

    public string? PFirstQualifier { get; set; }

    public string? PSecondQualifier { get; set; }

    public string? PThirdQualifier { get; set; }

    public int PFirstQualifierVerify { get; set; }

    public int PSecondQualifierVerify { get; set; }

    public int PThirdQualifierVerify { get; set; }

    public string? PAlternativeDesignation { get; set; }

    public int? PMotivation { get; set; }

    public int? PGoverance { get; set; }

    public int? PProgrammeCategory { get; set; }

    public int? PEndorsement { get; set; }

    public int? PDmFk { get; set; }

    public int? PMultiDisciplinary { get; set; }

    public int? PSiteOfDelivery { get; set; }

    public int? PFtpt { get; set; }

    public int PPSource { get; set; }

    public DateTime PCreateDate { get; set; }

    public int? PModifyDate { get; set; }

    public int? PRationale { get; set; }

    public int? PPurpose { get; set; }

    public int? PJoinProgramme { get; set; }

    public string PInstitutionName { get; set; } = null!;

    public int PCreator { get; set; }

    public int? POperationalQualCode { get; set; }

    public int? POrigin { get; set; }

    public int? PExitLevelOutcome { get; set; }

    public int? PArticulation { get; set; }

    public int? PAssociatedAssessmentCriteria { get; set; }

    public int? PRulesOfProgression { get; set; }

    public int? PInternationalCompatibility { get; set; }

    public int? PNonInternationalCompatibility { get; set; }

    public int? PModeOfProvisioning { get; set; }

    public int PIsEducated { get; set; }
}

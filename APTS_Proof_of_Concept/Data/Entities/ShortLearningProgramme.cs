using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class ShortLearningProgramme
{
    public int SlpPk { get; set; }

    public string? SlpProgrammeName { get; set; }

    public string? SlpAbbreviation { get; set; }

    public string? SlpNqflevelofSlp { get; set; }

    public string? SlpNqflevelCreditBearing { get; set; }

    public string? SlpNqflevelNonCreditBearing { get; set; }

    public string? SlpCompleteSlpinOneSem { get; set; }

    public string? SlpCompleteSlpinOneYear { get; set; }

    public string? SlpDurationOther { get; set; }

    public bool? SlpAdditionalVenuesRequired { get; set; }

    public bool? SlpAdditionalVenuesAvailable { get; set; }

    public string? SlpAdditionalVenuesDetails { get; set; }

    public string? SlpApprovedBy { get; set; }

    public string? SlpDesignation { get; set; }

    public string? SlpSignature { get; set; }

    public DateTime? SlpFeasibilityDate { get; set; }

    public string? SlpAttachment { get; set; }

    public string? SlpReasonForSlp { get; set; }

    public string? SlpTypicalStudentDescription { get; set; }

    public string? SlpValueForQualifyingStudent { get; set; }

    public string? SlpBroaderBenfitsOfSlp { get; set; }

    public string? SlpSecificBenefitsToUj { get; set; }

    public string? SlpPurposeOfStatement { get; set; }

    public string? SlpBriefDescriptionofContent { get; set; }

    public string? SlpOutcomeCreditBearing { get; set; }

    public string? SlpOutcomeNonCreditBearing { get; set; }

    public string? SlpTeachingAndLearningStrategy { get; set; }

    public string? SlpTeachingAndLearningMethods { get; set; }

    public string? SlpAssessmentMethods { get; set; }

    public string? SlpModerationCreditBearing { get; set; }

    public string? SlpModerationNonCreditBearing { get; set; }

    public string? SlpEvaluationCriteria { get; set; }

    public int? SlpCertification { get; set; }

    public DateTime? SlpDateOfSenexApproval { get; set; }

    public DateTime? SlpDateOfSenateApproval { get; set; }

    public DateTime? SlpCreatedDate { get; set; }

    public DateTime? SlpModifiedDate { get; set; }

    public bool? SlpLocked { get; set; }

    public string? SlpAptsnumber { get; set; }

    public string? SlpOrigin { get; set; }

    public bool? SlpIsActive { get; set; }

    public int? SlpUnLockVersion { get; set; }

    public string? SlpCesmfirstOrder { get; set; }

    public string? SlpCesmsecondOrder { get; set; }

    public string? SlpCesmthirdOrder { get; set; }

    public string? SlpNqflevelType { get; set; }

    public string? SlpFullPeriodMarkCalculationDescription { get; set; }

    public string? SlpMinFullPeriodMarksAdmission { get; set; }

    public string? SlpFullPeriodMarkWeight { get; set; }

    public string? SlpExaminationMarkWeight { get; set; }

    public string? SlpMinFinalMarkToPass { get; set; }

    public virtual ICollection<EntryRequirements> EntryRequirements { get; set; } = new List<EntryRequirements>();

    public virtual ICollection<LearningActivities> LearningActivities { get; set; } = new List<LearningActivities>();

    public virtual ICollection<SlpapplicationDetails> SlpapplicationDetails { get; set; } = new List<SlpapplicationDetails>();

    public virtual ICollection<SlpcalculationCriteria> SlpcalculationCriteria { get; set; } = new List<SlpcalculationCriteria>();

    public virtual ICollection<Slpcampus> Slpcampus { get; set; } = new List<Slpcampus>();

    public virtual ICollection<SlpstrategicPriorities> SlpstrategicPriorities { get; set; } = new List<SlpstrategicPriorities>();

    public virtual ICollection<TypeOfSlp> TypeOfSlp { get; set; } = new List<TypeOfSlp>();
}

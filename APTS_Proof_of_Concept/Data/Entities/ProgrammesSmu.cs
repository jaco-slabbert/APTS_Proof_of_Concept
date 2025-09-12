using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class ProgrammesSmu
{
    public string? AuthorisedQualificationProgrammeName { get; set; }

    public double? AptsReferenceNumber { get; set; }

    public string? SchoolOf { get; set; }

    public double? NqfLevel { get; set; }

    public double? NqfCreditsAsPerPqm { get; set; }

    public string? ProgrammeStatusActiveInactive { get; set; }

    public string? OnTheUniversityDhetApprovedProgrammeQualificationMixP { get; set; }

    public string? HeqcAccreditationOutcome { get; set; }

    public string? HeqcHeqsfAccreditationReferenceNumber { get; set; }

    public string? SaqaRegistrationStatus { get; set; }

    public double? SaqaRegistrationId { get; set; }

    public string? ProfessionalBoardRegulatedYesNo { get; set; }

    public string? IfYesNameOfTheProfessionalBodyOrIfNoNA { get; set; }

    public string? DateOfLastProfessionalBoardAccreditationVisit { get; set; }

    public string? CurrentProfessionalBoardAccreditationStatus { get; set; }

    public string? DateProfessionalBoardAccreditationReportReceived { get; set; }

    public string? QualityImprovementPlanQipDueDate { get; set; }

    public string? QipProgressToDate { get; set; }

    public string? DateOfNoticeForTheNextProfessionalBoardAccreditationVis { get; set; }

    public string? DateOfNextProfessionalBoardAccreditationVisit { get; set; }

    public string? SelfAssessmentQuestionnaireDueDate { get; set; }

    public string? NameAndContactDetailsOfHeadOfDepartmentProgrammeCoordin { get; set; }
}

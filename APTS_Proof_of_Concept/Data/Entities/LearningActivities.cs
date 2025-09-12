using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class LearningActivities
{
    public int LaPk { get; set; }

    public int? LaSlpFk { get; set; }

    public string? LaContactSessionContact { get; set; }

    public string? LaContactSessionDistance { get; set; }

    public string? LaWorkspaceContact { get; set; }

    public string? LaWorkspaceDistance { get; set; }

    public string? LaIndependentLearningContact { get; set; }

    public string? LaIndependentLearningDistance { get; set; }

    public string? LaAssessmentContact { get; set; }

    public string? LaAssessmentDistance { get; set; }

    public string? LaStudentSupportContact { get; set; }

    public string? LaStudentSupportDistance { get; set; }

    public string? LaOtherContact { get; set; }

    public string? LaOtherDistance { get; set; }

    public string? LaTotalHrsContact { get; set; }

    public string? LaTotalHrsDistance { get; set; }

    public string? LaNonCreditBearingTotalHrs { get; set; }

    public string? LaCreditBearingDistanceTotalCredits { get; set; }

    public virtual ShortLearningProgramme? LaSlpFkNavigation { get; set; }
}

using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class SlpcalculationCriteria
{
    public int SlpcalPk { get; set; }

    public int? SlpcalSlpFk { get; set; }

    public string? SlpcalAssessmentName { get; set; }

    public string? SlpcalNatureFormat1 { get; set; }

    public string? SlpcalNatureFormat2 { get; set; }

    public string? SlpcalNatureFormat3 { get; set; }

    public int? SlpMarks { get; set; }

    public virtual ShortLearningProgramme? SlpcalSlpFkNavigation { get; set; }
}

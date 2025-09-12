using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class DhetandHemis
{
    public int DhetPk { get; set; }

    public int? DhetPFk { get; set; }

    public string? DhetQualCode { get; set; }

    public double? DhetMajorCourseLevel { get; set; }

    public double? DhetFundingLevel { get; set; }

    public double? DhetMinTime { get; set; }

    public double? DhetMinWorkCredits { get; set; }

    public double? DhetResearchCredits { get; set; }

    public double? DhetTotalSubsidy { get; set; }

    public double? DhetTotalTime { get; set; }

    public DateTime? DhetCreateDate { get; set; }

    public DateTime? DhetModifyDate { get; set; }

    public double? DhetExperiential { get; set; }
}

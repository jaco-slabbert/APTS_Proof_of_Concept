using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class VDataLinking
{
    public decimal? ItsQualificationTypeCode { get; set; }

    public string? ItsQualificationTypeDescription { get; set; }

    public string? ItsPostGraduateCode { get; set; }

    public string ItsPostGraduateDescription { get; set; } = null!;

    public int ItsPostGraduateOrderBy { get; set; }

    public decimal? ItsNqfLevel { get; set; }

    public string? ItsNqfLevelDescription { get; set; }

    public string? HemisQualificationTypeCode { get; set; }

    public string? HemisQualificationTypeDescription { get; set; }

    public string? QualificationTypeGrouping { get; set; }

    public int? QualificationTypeGroupingOrderBy { get; set; }

    public string? QualificationTypeGrouping2 { get; set; }

    public int? QualificationTypeGrouping2OrderBy { get; set; }

    public string? QualificationTypeCohortAnalysisGrouping { get; set; }

    public int? MinimumTotalTime { get; set; }
}

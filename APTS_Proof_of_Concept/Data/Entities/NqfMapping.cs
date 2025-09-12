using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class NqfMapping
{
    public int Xltpk { get; set; }

    public string? QualificationTypeCode { get; set; }

    public string? QualificationType { get; set; }

    public string? Type { get; set; }

    public string? Type2 { get; set; }

    public string? Type3 { get; set; }

    public double? NqfExitLevel { get; set; }

    public double? MinTotalCredits { get; set; }

    public double? MinCreditsAtExitLevel { get; set; }

    public int? MinTime { get; set; }

    public double AdjTimeFt { get; set; }

    public double AdjTimePt { get; set; }
}

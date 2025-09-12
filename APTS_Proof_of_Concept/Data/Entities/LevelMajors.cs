using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class LevelMajors
{
    public int LmPk { get; set; }

    public string? LmLabel { get; set; }

    public int? LmValue { get; set; }
}

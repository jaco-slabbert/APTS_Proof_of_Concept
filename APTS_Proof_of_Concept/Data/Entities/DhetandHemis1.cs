using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class DhetandHemis1
{
    public int DhetPFk { get; set; }

    public double DhetMinWorkCredits { get; set; }

    public double DhetResearchCredits { get; set; }

    public string DhetTotalSubsidy { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class VProgrammeStatusSummary
{
    public int PrgPFk { get; set; }

    public DateTime? PrgDate { get; set; }

    public int? SSFk { get; set; }

    public int? PrgStFk { get; set; }

    public long? Rn { get; set; }

    public int Locked { get; set; }
}

using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class VProgrammeLockedStatusTt
{
    public int? PrgPFk { get; set; }

    public int Locked { get; set; }
}

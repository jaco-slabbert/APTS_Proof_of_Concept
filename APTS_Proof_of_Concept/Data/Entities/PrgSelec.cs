using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class PrgSelec
{
    public int? PPk { get; set; }

    public string? PName { get; set; }

    public string? PType { get; set; }

    public int? PTypeKey { get; set; }
}

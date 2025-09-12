using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class TmplSelect
{
    public int? Pk { get; set; }

    public string? Name { get; set; }

    public string? Version { get; set; }

    public string? Path { get; set; }

    public string? DrivePath { get; set; }
}

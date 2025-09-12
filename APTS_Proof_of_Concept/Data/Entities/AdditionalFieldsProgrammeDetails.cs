using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class AdditionalFieldsProgrammeDetails
{
    public int AfpdPk { get; set; }

    public int AfpdPFk { get; set; }

    public int AfpdAfFk { get; set; }

    public string? AfpdValue { get; set; }

    public bool? AfpdIsTemplate { get; set; }
}

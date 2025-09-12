using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class ActiveYears
{
    public int? AyPk { get; set; }

    public int? AyYear { get; set; }

    public bool? AyActive { get; set; }
}

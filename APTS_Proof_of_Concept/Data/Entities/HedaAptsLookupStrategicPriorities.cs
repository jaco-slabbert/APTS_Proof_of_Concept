using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class HedaAptsLookupStrategicPriorities
{
    public int SpPk { get; set; }

    public string SpName { get; set; } = null!;

    public bool? SpActive { get; set; }

    public DateTime? SpCreateDate { get; set; }

    public DateTime? SpModifiedDate { get; set; }
}

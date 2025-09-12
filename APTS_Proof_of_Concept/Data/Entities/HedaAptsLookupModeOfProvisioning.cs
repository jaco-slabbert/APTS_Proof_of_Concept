using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class HedaAptsLookupModeOfProvisioning
{
    public int MopPk { get; set; }

    public string? MopName { get; set; }

    public bool? IsInActive { get; set; }

    public DateTime? MopCreatedDate { get; set; }

    public DateTime? MopModifiedDate { get; set; }
}

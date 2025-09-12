using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class HedaAptsLookupPqmprogrammeType
{
    public int PqmprogrammeTypePk { get; set; }

    public string PqmprogrammeTypeName { get; set; } = null!;

    public bool? PqmprogrammeTypeActive { get; set; }

    public DateTime? PqmprogrammeTypeCreateDate { get; set; }

    public DateTime? PqmprogrammeTypeModifiedDate { get; set; }
}

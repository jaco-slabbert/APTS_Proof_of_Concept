using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class AuditTrail
{
    public int AtPk { get; set; }

    public string? AtActionType { get; set; }

    public int? AtUser { get; set; }

    public string? AtCategory { get; set; }

    public string? AtSubCategory { get; set; }

    public string? AtDescription { get; set; }

    public int? AtItemKey { get; set; }

    public int? AtItemType { get; set; }

    public string? AtChangedKey { get; set; }

    public string? AtPrevValue { get; set; }

    public string? AtNewValue { get; set; }

    public DateTime? AtDate { get; set; }
}

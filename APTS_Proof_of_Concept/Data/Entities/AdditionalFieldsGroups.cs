using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class AdditionalFieldsGroups
{
    public int AfgrpPk { get; set; }

    public string? AfgrpName { get; set; }

    public int? AfgrpOrder { get; set; }

    public virtual ICollection<AdditionalFields> AdditionalFields { get; set; } = new List<AdditionalFields>();
}

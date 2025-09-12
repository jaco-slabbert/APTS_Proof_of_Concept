using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class QualificationDesignations
{
    public int QdPk { get; set; }

    public string? QdName { get; set; }

    public string? QdDescription { get; set; }

    public int? QdOrdering { get; set; }

    public string? QdPlaceholder { get; set; }

    public DateTime? QdCreateDate { get; set; }

    public DateTime? QdModifyDate { get; set; }

    public bool? QdDisabled { get; set; }
}

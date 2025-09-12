using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class TemplatePlaceholders
{
    public int TpPk { get; set; }

    public string? TpDefinition { get; set; }

    public string? TpPlaceholder { get; set; }

    public string? TpLocation { get; set; }

    public virtual ICollection<AdditionalFields> AdditionalFields { get; set; } = new List<AdditionalFields>();
}

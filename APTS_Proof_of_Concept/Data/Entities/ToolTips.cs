using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class ToolTips
{
    public int TtPk { get; set; }

    public string? TtCategory { get; set; }

    public string? TtIdentifier { get; set; }

    public string? TtTooltip { get; set; }

    public DateTime? TtCreateDate { get; set; }

    public DateTime? TtModifyDate { get; set; }

    public virtual ICollection<AdditionalFields> AdditionalFields { get; set; } = new List<AdditionalFields>();
}

using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class StatusGroup
{
    public string? GroupName { get; set; }

    public int? GroupOrder { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? GroupBgColor { get; set; }

    public string? GroupTColor { get; set; }

    public long GroupId { get; set; }

    public virtual ICollection<StatusCategory> StatusCategory { get; set; } = new List<StatusCategory>();

    public virtual ICollection<Statusses> Statusses { get; set; } = new List<Statusses>();
}

using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class PagerIndex
{
    public int PiPk { get; set; }

    public int? PiPType { get; set; }

    public int? PiIndex { get; set; }

    public string? PiName { get; set; }

    public virtual ICollection<AdditionalFields> AdditionalFields { get; set; } = new List<AdditionalFields>();

    public virtual ProgrammeTypes? PiPTypeNavigation { get; set; }
}

using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class ProgrammeTypes
{
    public int PtPk { get; set; }

    public string? PtName { get; set; }

    public bool? PtActive { get; set; }

    public DateTime? PtCreateDate { get; set; }

    public DateTime? PtModifyDate { get; set; }

    public virtual ICollection<PagerIndex> PagerIndex { get; set; } = new List<PagerIndex>();

    public virtual ICollection<Programmes> Programmes { get; set; } = new List<Programmes>();
}

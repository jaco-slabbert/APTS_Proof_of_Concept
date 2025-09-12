using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class UnlockTypeList
{
    public int UPk { get; set; }

    public int UVal { get; set; }

    public string UText { get; set; } = null!;

    public DateTime UCreateDate { get; set; }

    public virtual ICollection<ProgrammesUnlock> ProgrammesUnlock { get; set; } = new List<ProgrammesUnlock>();
}

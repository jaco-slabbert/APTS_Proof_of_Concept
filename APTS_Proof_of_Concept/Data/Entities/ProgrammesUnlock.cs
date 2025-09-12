using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class ProgrammesUnlock
{
    public int UnlockPPk { get; set; }

    public int UPk { get; set; }

    public int UVal { get; set; }

    public string? UnlockPOrigin { get; set; }

    public int? ProgrammePPk { get; set; }

    public DateTime? CreateDate { get; set; }

    public virtual Programmes? ProgrammePPkNavigation { get; set; }

    public virtual UnlockTypeList UPkNavigation { get; set; } = null!;
}

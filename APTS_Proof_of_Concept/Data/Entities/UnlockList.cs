using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class UnlockList
{
    public int UPk { get; set; }

    public int UVal { get; set; }

    public string UText { get; set; } = null!;

    public DateTime UCreateDate { get; set; }
}

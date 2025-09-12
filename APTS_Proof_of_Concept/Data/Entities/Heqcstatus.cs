using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class Heqcstatus
{
    public int HsPk { get; set; }

    public string? HsName { get; set; }

    public DateTime? HsCreateDate { get; set; }

    public DateTime? HsModifyDate { get; set; }
}

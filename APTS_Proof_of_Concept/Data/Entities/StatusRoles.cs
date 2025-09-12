using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class StatusRoles
{
    public int? SrPk { get; set; }

    public int? SrSFk { get; set; }

    public int? SrCrFk { get; set; }

    public DateTime? SrCreateDate { get; set; }

    public DateTime? SrModifyDate { get; set; }
}

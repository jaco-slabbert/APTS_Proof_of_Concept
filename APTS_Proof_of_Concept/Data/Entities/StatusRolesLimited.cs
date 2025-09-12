using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class StatusRolesLimited
{
    public int SrlPk { get; set; }

    public int? SrlSFk { get; set; }

    public int? SrlCrFk { get; set; }

    public DateTime? SrlCreateDate { get; set; }

    public DateTime? SrlModifyDate { get; set; }
}

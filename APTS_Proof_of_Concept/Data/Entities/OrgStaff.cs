using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class OrgStaff
{
    public int OstPk { get; set; }

    public int? OstPFk { get; set; }

    public string? OstAuthFk { get; set; }

    public int? OstPosition { get; set; }

    public DateTime? OstCreateDate { get; set; }

    public DateTime? OstModifyDate { get; set; }
}

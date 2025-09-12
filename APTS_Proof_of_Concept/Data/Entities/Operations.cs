using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class Operations
{
    public int OprPk { get; set; }

    public int OprPFk { get; set; }

    public bool? OprExp { get; set; }

    public bool? OprExpPlan { get; set; }

    public bool? OprSuitable { get; set; }

    public bool? OprService { get; set; }

    public bool? OprVerified { get; set; }

    public bool? OprSize { get; set; }

    public bool? OprSizePlan { get; set; }

    public DateTime? OprCreateDate { get; set; }

    public DateTime? OprModifyDate { get; set; }

    public string? OprEnrolmentPlan { get; set; }

    public string? OprPhEnrolment { get; set; }
}

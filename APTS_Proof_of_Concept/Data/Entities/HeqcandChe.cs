using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class HeqcandChe
{
    public int HeqcPk { get; set; }

    public int? HeqcPFk { get; set; }

    public string? HeqcLevelDescriptors { get; set; }

    public string? HeqcReferenceNumber { get; set; }

    public DateTime? HeqcSubmissionDate { get; set; }

    public string? HeqcFinalAccreditation { get; set; }

    public bool? HeqcOutstandingApprovals { get; set; }

    public string? HeqcOutstandingApprovalsDetail { get; set; }

    public bool? HeqcIsPlagiarized { get; set; }

    public string? HeqcSaqaid { get; set; }

    public DateTime? HeqcCreateDate { get; set; }

    public DateTime? HeqcModifyDate { get; set; }

    public virtual Programmes? HeqcPFkNavigation { get; set; }
}

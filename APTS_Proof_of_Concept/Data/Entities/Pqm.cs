using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class Pqm
{
    public int PqmPk { get; set; }

    public int? PqmPFk { get; set; }

    public bool? PqmIsPart { get; set; }

    public bool? PqmIsReplacement { get; set; }

    public string? PqmReplacement { get; set; }

    public DateTime? PqmSubmissionDate { get; set; }

    public DateTime? PqmFirstEnrolmentDate { get; set; }

    public int? PqmQualificationDesc { get; set; }

    public DateTime? PqmCreateDate { get; set; }

    public DateTime? PqmModifyDate { get; set; }

    public string? PqmComment { get; set; }

    public int? PqmPqmprogrammeType { get; set; }

    public virtual Programmes? PqmPFkNavigation { get; set; }
}

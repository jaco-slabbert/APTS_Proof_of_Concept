using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class Progress
{
    public int PrgPk { get; set; }

    public int? PrgPFk { get; set; }

    public int? PrgStFk { get; set; }

    public int? PrgUser { get; set; }

    public string? PrgComment { get; set; }

    public string? PrgReferenceNumber { get; set; }

    public DateTime PrgDate { get; set; }

    public DateTime? PrgCreateDate { get; set; }

    public string? PrgReportNote { get; set; }
}

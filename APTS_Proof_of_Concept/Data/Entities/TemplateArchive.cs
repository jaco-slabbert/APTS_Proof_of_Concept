using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class TemplateArchive
{
    public int TaPk { get; set; }

    public int? TaTFk { get; set; }

    public string? TaName { get; set; }

    public string? TaPath { get; set; }

    public int? TaUser { get; set; }

    public DateTime? TaCreateDate { get; set; }

    public DateTime? TaModifyDate { get; set; }

    public int? TaPFk { get; set; }
}

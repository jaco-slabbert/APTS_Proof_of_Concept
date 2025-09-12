using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class StaffingPlan
{
    public int SpPk { get; set; }

    public int? SpPFk { get; set; }

    public string? SpFileName { get; set; }

    public string? SpFilePath { get; set; }

    public DateTime? SpCreateDate { get; set; }

    public DateTime? SpModifyDate { get; set; }

    public int? SpType { get; set; }

    public byte[]? SpFileByte { get; set; }

    public string? SpContentType { get; set; }

    public string? SpFileExtension { get; set; }
}

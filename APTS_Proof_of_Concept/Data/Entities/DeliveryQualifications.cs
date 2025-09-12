using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class DeliveryQualifications
{
    public int DqPk { get; set; }

    public string? DqName { get; set; }

    public string? DqReplacement { get; set; }

    public DateTime? DqCreateDate { get; set; }

    public DateTime? DqModifyDate { get; set; }
}

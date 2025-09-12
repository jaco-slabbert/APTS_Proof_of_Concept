using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class Templates
{
    public int TPk { get; set; }

    public string? TName { get; set; }

    public string? TPath { get; set; }

    public string? TDescription { get; set; }

    public bool? TEnabled { get; set; }

    public DateTime? TCreateDate { get; set; }

    public DateTime? TModifyDate { get; set; }

    public string? TVersion { get; set; }
}

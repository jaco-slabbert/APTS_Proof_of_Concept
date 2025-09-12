using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class Settings
{
    public int SsPk { get; set; }

    public string? SsName { get; set; }

    public string? SsDescription { get; set; }

    public string? SsValue { get; set; }

    public string? SsValueDefault { get; set; }

    public bool? SsEncrypted { get; set; }

    public DateTime? SsCreateDate { get; set; }

    public DateTime? SsModifyDate { get; set; }
}

using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class MandatoryUploads
{
    public int MuPk { get; set; }

    public string? MuName { get; set; }

    public bool? MuTab1Value { get; set; }

    public bool? MuTab2Value { get; set; }

    public bool? MuTab3Value { get; set; }

    public bool? MuTab4Value { get; set; }

    public DateTime? MuCreateDate { get; set; }

    public DateTime? MuModifyDate { get; set; }
}

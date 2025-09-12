using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class Module
{
    public int MdlPk { get; set; }

    public int MdlPFk { get; set; }

    public string? MdlName { get; set; }

    public int? MdlNqfLevel { get; set; }

    public int? MdlCredits { get; set; }

    public int? MdlCompulsory { get; set; }

    public int? MdlYear { get; set; }

    public int? MdlTotalCredits { get; set; }

    public DateTime? MdlCreateDate { get; set; }

    public DateTime? MdlModifyDate { get; set; }

    public int? MdlSemester { get; set; }

    public string? MdlCode { get; set; }
}

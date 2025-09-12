using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class SlpapplicationDetails
{
    public int SlpappPk { get; set; }

    public int? SlpappSlpFk { get; set; }

    public string? SlpappFaculty { get; set; }

    public string? SlpappDepartment { get; set; }

    public string? SlpappEmail { get; set; }

    public DateTime? SlpappDateSubmittedToCollegeBoard { get; set; }

    public DateTime? SlpappDateSubmittedToPwg { get; set; }

    public virtual ShortLearningProgramme? SlpappSlpFkNavigation { get; set; }
}

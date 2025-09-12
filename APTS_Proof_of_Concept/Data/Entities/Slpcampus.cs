using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class Slpcampus
{
    public int SlpcPk { get; set; }

    public int? SlpcSlpFk { get; set; }

    public string? SlpCampus { get; set; }

    public virtual ShortLearningProgramme? SlpcSlpFkNavigation { get; set; }
}

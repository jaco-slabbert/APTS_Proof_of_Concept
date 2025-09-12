using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class SlpstrategicPriorities
{
    public int SlpSpPk { get; set; }

    public int? TslpSlpFk { get; set; }

    public int? TslpSpFk { get; set; }

    public virtual ShortLearningProgramme? TslpSlpFkNavigation { get; set; }
}

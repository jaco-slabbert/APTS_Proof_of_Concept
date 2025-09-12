using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class EntryRequirements
{
    public int ErPk { get; set; }

    public int? ErSlpFk { get; set; }

    public string? ErNonCreditBearing { get; set; }

    public string? ErQualificationName { get; set; }

    public string? ErQualificationCode { get; set; }

    public string? ErNqflevel { get; set; }

    public string? ErModulesName { get; set; }

    public string? ErModulesCode { get; set; }

    public string? ErModulesNqflevels { get; set; }

    public string? ErModulesNqfcredit { get; set; }

    public string? ErEntryRequirement { get; set; }

    public virtual ShortLearningProgramme? ErSlpFkNavigation { get; set; }
}

using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class IcsLog
{
    public int LogPk { get; set; }

    public string LogSource { get; set; } = null!;

    public DateTime LogDateTime { get; set; }

    public int? LogUserPk { get; set; }

    public string LogMessage { get; set; } = null!;

    public int LogSeverity { get; set; }
}

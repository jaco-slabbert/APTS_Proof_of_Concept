using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class Reports
{
    public int RepPk { get; set; }

    public string? RepName { get; set; }

    public string? RepUrl { get; set; }

    public bool? RepForAdmin { get; set; }

    public bool? RepForUser { get; set; }

    public bool? RepForViewer { get; set; }

    public bool? RepEnabled { get; set; }

    public DateTime? RepCreateDate { get; set; }

    public DateTime? RepModifyDate { get; set; }
}

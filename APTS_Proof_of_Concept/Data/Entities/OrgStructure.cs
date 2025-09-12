using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class OrgStructure
{
    public int OrgPk { get; set; }

    public int? OrgPFk { get; set; }

    public string? OrgCampus { get; set; }

    public string? OrgFaculty { get; set; }

    public string? OrgDepartment { get; set; }

    public DateTime? OrgCreateDate { get; set; }

    public DateTime? OrgModifyDate { get; set; }

    public virtual Programmes? OrgPFkNavigation { get; set; }
}

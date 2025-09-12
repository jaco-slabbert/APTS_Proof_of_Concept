using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class AdditionalFields
{
    public int AfPk { get; set; }

    public string? AfName { get; set; }

    public int? AfGrpFk { get; set; }

    public int? AfTpFk { get; set; }

    public int? AfPiFk { get; set; }

    public int? AfTtFk { get; set; }

    public int? AfOrder { get; set; }

    public bool? AfCore { get; set; }

    public string? AfDefaultValue { get; set; }

    public int? AfInputType { get; set; }

    public string? AfDropdownTypeRb { get; set; }

    public string? AfDynamicDropdownTblName { get; set; }

    public string? AfDynamicDropdownColumnName { get; set; }

    public string? AfDropdownList { get; set; }

    public virtual AdditionalFieldsGroups? AfGrpFkNavigation { get; set; }

    public virtual PagerIndex? AfPiFkNavigation { get; set; }

    public virtual TemplatePlaceholders? AfTpFkNavigation { get; set; }

    public virtual ToolTips? AfTtFkNavigation { get; set; }
}

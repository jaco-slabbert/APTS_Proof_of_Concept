using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class AdditionalFieldsProgrammeFiles
{
    public int AfpfPk { get; set; }

    public int? AfpfPFk { get; set; }

    public int? AfpfAfFk { get; set; }

    public string? AfpfFilePath { get; set; }

    public DateTime? AfpfCreatedDate { get; set; }

    public DateTime? AfpfModifiedDate { get; set; }

    public bool? AfpfIsTemplate { get; set; }

    public bool? AfpfIsDownload { get; set; }

    public string? AfpfFileName { get; set; }

    public byte[]? AfpfFileByte { get; set; }

    public string? AfpfContentType { get; set; }

    public string? AfpfFileExtension { get; set; }
}

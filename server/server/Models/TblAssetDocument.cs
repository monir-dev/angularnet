using System;
using System.Collections.Generic;

namespace server.Models
{
    public partial class TblAssetDocument
    {
        public long Id { get; set; }
        public long AssetInfoId { get; set; }
        public string DocumentName { get; set; }
        public string DocumentPath { get; set; }
        public string Description { get; set; }
        public string Transcription { get; set; }
        public DateTime? DocumentExpiryDate { get; set; }
        public DateTime? DocumentExpiryNoticeSentDate { get; set; }
        public string IsActive { get; set; }
        public string Iuser { get; set; }
        public DateTime? Idate { get; set; }
        public string Euser { get; set; }
        public DateTime? Edate { get; set; }
        public DateTime? DocumentStartDate { get; set; }

        public virtual TblAssetInfo AssetInfo { get; set; }
    }
}

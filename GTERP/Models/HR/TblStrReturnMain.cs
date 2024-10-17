﻿using System;
using System.Collections.Generic;

namespace GTERP_DAP_Model.CustomModels
{
    public partial class TblStrReturnMain
    {
        public TblStrReturnMain()
        {
            TblStrReturnSub = new HashSet<TblStrReturnSub>();
        }

        public int RtnId { get; set; }
        public byte ComId { get; set; }
        public string RtnNo { get; set; }
        public DateTime DtRtn { get; set; }
        public long IssueId { get; set; }
        public string Remarks { get; set; }
        public int SubsectId { get; set; }
        public int LuserId { get; set; }
        public byte IsPosted { get; set; }
        public string Pcname { get; set; }
        public int AId { get; set; }
        public Guid WId { get; set; }
        public int? LuserIdApprove { get; set; }
        public DateTime? DtApprove { get; set; }
        public byte? Status { get; set; }
        public DateTime? DtTime { get; set; }
        public string RemarksApprove { get; set; }

        public virtual ICollection<TblStrReturnSub> TblStrReturnSub { get; set; }
    }
}

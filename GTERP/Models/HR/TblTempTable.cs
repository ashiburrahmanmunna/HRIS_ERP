﻿using System;
using System.Collections.Generic;

namespace GTERP_DAP_Model.CustomModels
{
    public partial class TblTempTable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte? Comid { get; set; }
        public int? Userid { get; set; }
        public int? SeatQty { get; set; }
        public string Prdimage { get; set; }
        public int? PosX { get; set; }
        public int? PosY { get; set; }
        public int? TableId { get; set; }
        public byte? Status { get; set; }
    }
}

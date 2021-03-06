﻿using System.ComponentModel.DataAnnotations;

namespace TradingLicense.Entities
{
    public class HAReqDoc
    {
        [Key]
        public int HAReqDocID { get; set; }

        public int RequiredDocID { get; set; }

        public virtual RequiredDoc RequiredDoc { get; set; }
    }
}

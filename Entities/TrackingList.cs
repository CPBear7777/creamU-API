﻿using System;
using System.Collections.Generic;

namespace creamU_API.Entities
{
    public partial class TrackingList
    {
        public int MemberId { get; set; }
        public int ProductId { get; set; }
        public string? TrackingDate { get; set; }

        public virtual Member Member { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}

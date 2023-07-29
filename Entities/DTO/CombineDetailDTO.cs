﻿namespace creamU_API.Entities.DTO
{
    public class CombineDetailDTO
    {
        public int CombineId { get; set; }
        public int? Chead { get; set; }
        public int? Cbody { get; set; }
        public int? Clhand { get; set; }
        public int? Crhand { get; set; }
        public int? Clfoot { get; set; }
        public int? Crfoot { get; set; }
        public int? SubTotal { get; set; }
        public string? Type { get; set; }

        public virtual Component? CbodyNavigation { get; set; }
        public virtual Component? CheadNavigation { get; set; }
        public virtual Component? ClfootNavigation { get; set; }
        public virtual Component? ClhandNavigation { get; set; }
        public virtual Component? CrfootNavigation { get; set; }
        public virtual Component? CrhandNavigation { get; set; }
    }
}

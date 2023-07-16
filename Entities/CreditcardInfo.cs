using System;
using System.Collections.Generic;

namespace creamU_API.Entities
{
    public partial class CreditcardInfo
    {
        public int CreditCardId { get; set; }
        public int? MemberId { get; set; }
        public string? CardholderName { get; set; }
        public string? CardNumber { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string? Cvv { get; set; }
        public string? CardType { get; set; }
        public ulong? IsDefault { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Notes { get; set; }

        public virtual Member? Member { get; set; }
    }
}

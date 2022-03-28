using RaptoreumWallet.Common.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace RaptoreumWallet.Models
{
    public enum TransactionType
    {
        Receive, Send
    }
    public class TransactionModel : ModelBase
    {
        public DateTime Time { get; set; }
        public decimal Value { get; set; }
        public decimal Usd { get; set; }
        public TransactionType TransactionType { get; set; }
    }
}

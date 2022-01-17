using RaptoreumWallet.Common.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace RaptoreumWallet.Models
{
    public class WordModel : ModelBase
    {
        public int Index { get; set; } // start with 1
        public string Word { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guildmate.Models
{
    public class BankItem
    {
        public int BankItemId { get; set; }
        public int BankId { get; set; }
        public int ItemId { get; set; }
    }
}

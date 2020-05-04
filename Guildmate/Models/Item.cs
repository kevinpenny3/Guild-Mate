using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guildmate.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int CharacterId { get; set; }
        public int ItemTypeId { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateRemoved { get; set; }
    }
}

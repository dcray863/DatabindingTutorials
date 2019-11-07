using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Data
{
    public class World
    {
        public List<Player> Players { get; set; }
        public List<Item> Items { get; set; }
    }
}

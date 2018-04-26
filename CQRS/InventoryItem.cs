using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS
{
    public class InventoryItem
    {
        public static int Seed = 0;
        public int Id;
        public string Name;
        public string Category { get; set; }

        public InventoryItem() { }

        public InventoryItem(string name, string category)
        {
            Name = name;
            Category = category;
            Id = ++Seed;
        }
    }
}

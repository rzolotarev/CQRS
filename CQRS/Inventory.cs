using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CQRS
{
    public class Inventory
    {
        private CommandStore store;

        public int InventoryItemSeed
        {
            get { return InventoryItem.Seed; }
            set { InventoryItem.Seed = value; }
        }

        public List<InventoryItem> items
        {
            get { return itemsByKey.Values.ToList(); }
            set { itemsByKey = value.ToDictionary(ii => ii.Id, ii => ii); }
        }

        internal void AddItem(InventoryItem item)
        {
            itemsByKey.Add(item.Id, item);
            store.Add(new CreateInventoryItemCommand(item));
        }

        private Dictionary<int, InventoryItem> itemsByKey = new Dictionary<int, InventoryItem>();

        public Inventory(CommandStore store)
        {
            this.store = store;
        }

        public void ProcessCommand(InventoryItemCommand command)
        {
            var ciic = command as CreateInventoryItemCommand;
            if(ciic != null)
            {
                var item = ciic.Item;
            }            
        }
    }
}

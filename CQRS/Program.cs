using System;
using System.Collections.Generic;

namespace CQRS
{
   

    class Program
    {
        static Inventory inventory;
        static CommandStore store;

        static void Main(string[] args)
        {
            store = CommandStoreHelper.Load();
            inventory = InventoryHelper.Load(store);
         

            var phone = new InventoryItem("xing", "Mobile");
            inventory.AddItem(phone);

            InventoryHelper.Save(inventory);
            CommandStoreHelper.Save(store);
        }
    }
}

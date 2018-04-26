using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS
{
    public class CreateInventoryItemCommand : InventoryItemCommand
    {
        public InventoryItem Item { get; set; }

        public CreateInventoryItemCommand()
        {
            Type = InventoryCommandType.Create;
        }

        public CreateInventoryItemCommand(InventoryItem item) : this()
        {            
            Item = item;
        }
    }
}

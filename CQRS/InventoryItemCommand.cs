using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace CQRS
{
    [XmlInclude(typeof(CreateInventoryItemCommand))]
    public class InventoryItemCommand
    {       
        public InventoryCommandType Type { get; set; }
    }
}

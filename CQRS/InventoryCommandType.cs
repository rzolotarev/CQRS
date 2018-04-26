using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS
{
    public enum InventoryCommandType
    {
        Create,
        Update,
        Delete
    }
}

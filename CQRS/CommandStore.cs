﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Xml.Serialization;

namespace CQRS
{
    public class CommandStore : Collection<InventoryItemCommand>
    {

    }
}

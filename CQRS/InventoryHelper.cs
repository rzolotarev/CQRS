using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace CQRS
{
    public class InventoryHelper
    {
        private static string filename = "inventory.txt";

        public static Inventory Load(CommandStore store)
        {
            if (!File.Exists(filename)) return new Inventory(store);

            var xs = new XmlSerializer(typeof(Inventory));
            using(var fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                return (Inventory)xs.Deserialize(fs);
            }
        }

        public static void Save(Inventory inventory)
        {   
            var xs = new XmlSerializer(typeof(Inventory));
            using (var fs = new FileStream(filename, FileMode.Create, FileAccess.Write))
            {
                xs.Serialize(fs, inventory);
            }
        }

        public static Inventory LoadFromStore(CommandStore store)
        {
            var i = new Inventory(store);
            foreach(var e in store)
            {
                i.ProcessCommand(e);
            }
        }
    }
}

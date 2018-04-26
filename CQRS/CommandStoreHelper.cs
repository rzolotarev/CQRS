using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace CQRS
{
    public class CommandStoreHelper
    {
        private static string filename = "store.txt";

        public static CommandStore Load()
        {
            if (!File.Exists(filename)) return new CommandStore();

            var xs = new XmlSerializer(typeof(CommandStore));
            using (var fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                return (CommandStore)xs.Deserialize(fs);
            }
        }

        public static void Save(CommandStore store)
        {
            var xs = new XmlSerializer(typeof(CommandStore));
            using (var fs = new FileStream(filename, FileMode.Create, FileAccess.Write))
            {
                xs.Serialize(fs, store);
            }
        }
    }
}

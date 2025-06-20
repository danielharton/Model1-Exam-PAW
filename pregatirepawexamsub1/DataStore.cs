using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace pregatirepawexamsub1
{
    public static class DataStore
    {
        public static List<AccessPackage> AccessPackages { get; private set; } = new List<AccessPackage>();
        public static List<Registration> Registrations { get; private set; } = new List<Registration>();
        private static readonly string packagesFile = "AccessPackages.txt";
        private static readonly string registrationsFile = "Registrations.xml";

        public static void LoadPackages()
        {
            AccessPackages.Clear();
            if (!File.Exists(packagesFile)) return;
            foreach (var line in File.ReadAllLines(packagesFile))
            {
                var parts = line.Split(';');
                if (parts.Length == 3
                    && int.TryParse(parts[0], out int id)
                    && double.TryParse(parts[2], out double price))
                {
                    AccessPackages.Add(new AccessPackage(id, parts[1], price));
                }
            }
        }

        public static void LoadRegistrations()
        {
            Registrations.Clear();
            if (!File.Exists(registrationsFile)) return;
            var serializer = new XmlSerializer(typeof(List<Registration>));
            using (var fs = new FileStream(registrationsFile, FileMode.Open))
                Registrations = (List<Registration>)serializer.Deserialize(fs);
        }

        public static void SaveRegistrations()
        {
            var serializer = new XmlSerializer(typeof(List<Registration>));
            using (var fs = new FileStream(registrationsFile, FileMode.Create))
                serializer.Serialize(fs, Registrations);
        }
    }
}

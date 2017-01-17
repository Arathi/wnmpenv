using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wnmpenv.PhpIniParser
{
    public class Section
    {
        public string Name;
        public IList<Property> Properties;
        public IDictionary<string, int> PropertyNameIndex;

        public Section(string name)
        {
            Name = name;
            Properties = new List<Property>();
            PropertyNameIndex = new Dictionary<string, int>();
        }

        public virtual void AddProperty(Property prop)
        {
            Properties.Add(prop);
            int propIndex = Properties.Count() - 1;
            if (!prop.DescriptionOnly)
            {
                // if (PropertyNameIndex.ContainsKey(prop.Key))
                // {
                //     // 去重
                // }
                if (prop.Key == "extension") return;
                PropertyNameIndex[prop.Key] = propIndex;
            }
        }

        public virtual string Output()
        {
            string output = "[" + Name + "]" + "\r\n";
            
            foreach (Property prop in Properties)
            {
                output += prop.Output() + "\r\n";
            }
            return output;
        }
    }
}

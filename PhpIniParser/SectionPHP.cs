using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wnmpenv.PhpIniParser
{
    public class SectionPHP : Section
    {
        public IDictionary<string, Extension> Extensions;

        public SectionPHP(string name) : base(name)
        {
            Extensions = new Dictionary<string, Extension>();
        }

        public override void AddProperty(Property prop)
        {
            base.AddProperty(prop);

            if (prop.Key == "extension")
            {
                Extension ext = (Extension)prop;
                Extensions[ext.ExtName] = ext;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wnmpenv.PhpIniParser
{
    public class Extension : Property
    {
        public string FileName
        {
            get
            {
                return Value;
            }
        }

        public string ExtName
        {
            get
            {
                return Value;
            }
        }

        public override string ToString()
        {
            string result = "";
            if (!Enable) result += ";";
            result += "extension=" + FileName;
            if (Comment != null && Comment.Length > 0)
            {
                result += "  " + Comment;
            }
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace wnmpenv.PhpIniParser
{
    public class Property
    {
        public const string PATTERN_PROPERTY = @"^;{0,1}([0-9A-Za-z_\.]+)\s*=(.*?)(; .*)?$";

        public bool DescriptionOnly { get; set; }  // 只有说明
        public bool Enable { get; set; }           // 是否启用
        public string Description { get; set; }    // 说明
        public string Key { get; set; }            // 键
        public string Value { get; set; }          // 值
        public string Comment { get; set; }        // 注释（当前行）

        public override string ToString()
        {
            string result = "";
            if (!Enable) result += ";";
            result += Key + " =";
            if (Value == null || Value.Length>0)
            {
                result += " " + Value;
            }
            if (Comment != null && Comment.Length>0)
            {
                result += "  " + Comment;
            }
            return result;
        }

        public virtual string Output()
        {
            string output = Description;
            if (!DescriptionOnly)
            {
                output += ToString();
            }
            return output;
        }

        public static Property Parse(string line)
        {
            Regex regex = new Regex(PATTERN_PROPERTY);
            Match match = regex.Match(line);
            if (match.Success)
            {
                bool enable = !match.Value.StartsWith(";");
                string key = match.Groups[1].Value;
                Property p = null;
                if (key == "extension")
                {
                    p = new Extension();
                }
                else
                {
                    p = new Property();
                }
                p.Enable = enable;
                p.Key = key;
                p.Value = match.Groups[2].Value.Trim();
                p.Comment = match.Groups[3].Value;
                return p;
            }
            return null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace wnmpenv.PhpIniParser
{
    public class PhpIni
    {
        public const string PATTERN_SECTION = @"^\[(.*)\]$";

        public const int PARSE_SUCCESS = 0;
        public const int PARSE_ERROR_FILE_NOT_EXISTS = 1;

        public string FileName { get; set; }
        public IList<string> Lines { get; set; }

        public IList<Section> Sections { get; set; }
        
        public IDictionary<string, int> SectionFileLine { get; set; }

        public PhpIni(string filename)
        {
            FileName = filename;
        }

        public int Parse()
        {
            FileInfo file = new FileInfo(FileName);
            if (!file.Exists) return PARSE_ERROR_FILE_NOT_EXISTS;  // 文件不存在

            StreamReader reader = new StreamReader(FileName);
            Lines = new List<string>();
            SectionFileLine = new Dictionary<string, int>();
            Sections = new List<Section>();

            Regex regexSection = new Regex(PATTERN_SECTION);
            Section currentSection = null;
            string currentDescription = "";

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                Lines.Add(line);

                int lineNo = Lines.Count();
                // 检查Section
                Match match = regexSection.Match(line);
                if (match.Success)
                {
                    if (currentSection != null)
                    {
                        Sections.Add(currentSection);
                    }

                    string sectionName = match.Groups[1].Value;
                    SectionFileLine[sectionName] = lineNo;
                    if (sectionName == "PHP")
                    {
                        currentSection = new SectionPHP(sectionName);
                    }
                    else
                    {
                        currentSection = new Section(sectionName);
                    }
                    continue;
                }

                // 检查Property
                Property property = Property.Parse(line);
                if (property != null)
                {
                    property.Description = currentDescription;
                    currentDescription = "";
                    currentSection.AddProperty(property);
                    continue;
                }

                // 检查注释
                if (line == "")
                {
                    Property comment = new CommentParagraph(currentDescription);
                    currentSection.AddProperty(comment);

                    currentDescription = "";
                }
                else
                {
                    currentDescription += line + "\r\n";
                }
            }

            // 保存最后的section
            Sections.Add(currentSection);

            reader.Close();
            return PARSE_SUCCESS;
        }

        public void Rebuild()
        {
            string content = "";
            foreach (Section section in Sections)
            {
                content += section.Output();
            }
            string[] splitors = { "\r\n" };
            Lines = content.Split(splitors, StringSplitOptions.None);
        }

        public void Save(string path = null)
        {
            if (path == null || path == "") path = FileName;
            StreamWriter writer = new StreamWriter(path);
            foreach (string line in Lines)
            {
                writer.WriteLine(line);
            }
            writer.Close();
        }
    }
}

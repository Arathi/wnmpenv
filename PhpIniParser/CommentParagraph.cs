using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wnmpenv.PhpIniParser
{
    class CommentParagraph : Property
    {
        public CommentParagraph(string description) : base()
        {
            DescriptionOnly = true;
            Description = description;
        }

        public override string Output()
        {
            return Description;
        }
    }
}

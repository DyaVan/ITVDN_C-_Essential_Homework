using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Title : BookPart, IBookPart
    {
        public Title (string title)
        {
            Color = ConsoleColor.Red;
            Content = title;
        }
    }
}

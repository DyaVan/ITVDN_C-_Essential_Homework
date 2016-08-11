using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Content : BookPart, IBookPart
    {
        public Content(string content)
        {
            Color = ConsoleColor.Green;
            Content = content;
        }
    }
}

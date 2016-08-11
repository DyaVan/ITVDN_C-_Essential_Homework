using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Author : BookPart, IBookPart
    {
        public Author (string author) 
        {
            Color = ConsoleColor.Yellow;
            Content = author;
        }

        public override void Show() 
        {
            
        }

    }
}

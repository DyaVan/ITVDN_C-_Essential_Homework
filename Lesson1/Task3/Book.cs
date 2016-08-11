using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Book
    {
        List<IBookPart> BookParts = new List<IBookPart>();


        public Book(string author, string title,string content )
        {
            BookParts.Add(new Author(author));
            BookParts.Add(new Title(title));
            BookParts.Add(new Content(content));
        }

        public void Show()
        {
            foreach (var v in BookParts)
            {
                v.Show();
            }
        }
    }
}

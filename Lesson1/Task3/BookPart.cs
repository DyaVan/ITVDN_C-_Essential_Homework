using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class BookPart 
    {
        public string Content { get; set; }

        private ConsoleColor color = ConsoleColor.Gray;

        protected ConsoleColor Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }
        
        public virtual void Show()
        {
            Console.WriteLine(Content, Console.ForegroundColor = Color);
            
        }
    }
}

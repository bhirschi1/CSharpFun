using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFun
{
    class PrintStuff
    {
        private string language = "";
        //Constructor
        public PrintStuff (string temp)
        {
            language = temp;
        }
        public void PrintName(string name)
        {
            if (language == "EN")
            {
                Console.WriteLine("Hello, " + name);
                Console.WriteLine("blah");
            }
            if (language == "PT")
            {
                Console.WriteLine("Oi, " + name);
            }
        }
        
    }
}

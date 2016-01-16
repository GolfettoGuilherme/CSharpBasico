using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "abc";
            string string2 = "def";
            StringBuilder sb = new StringBuilder();

            sb.Append(string1); //junta strings
            sb.Append(" "); // uma concatenação
            sb.Append(string2); //mais bonita
            sb.Append(" ");
            sb.Append("gui");

            Console.WriteLine("{0}",sb.ToString()); //ToString();
            Console.ReadKey();

        }
    }
}

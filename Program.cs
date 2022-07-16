using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory_requirements_for_data_types
{
    internal class Program
    {
        class size
        {
            static void Main(string[] args)
            {
                Console.WriteLine("\nA bytes is {0} byte(s)", sizeof(byte));
                Console.WriteLine("A sbytes is {0} byte(s)", sizeof(sbyte));
                Console.WriteLine("A char is {0} byte(s)", sizeof(char));
                Console.WriteLine("\nA short is {0} byte(s)", sizeof(short));
                Console.WriteLine("A ushort is {0} byte(s)", sizeof(ushort));
                Console.WriteLine("\nAn int is {0} byte(s)", sizeof(int));
                Console.WriteLine("An uint is {0} byte(s)", sizeof(uint));
                Console.WriteLine("\nAn long is {0} byte(s)", sizeof(long));
                Console.WriteLine("A ulong is {0} byte(s)", sizeof(ulong));
                Console.WriteLine("\nA float is {0} byte(s)", sizeof(float));
                Console.WriteLine("A double is {0} byte(s)", sizeof(double));
                Console.WriteLine("\nA decimal is {0} byte(s)", sizeof(decimal));
                Console.WriteLine("\nA boolean is {0} byte(s)", sizeof(bool));
            }
        }
    }
}

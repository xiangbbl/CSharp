using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    
    class Program
    {
        const int con = 1;
        static void Main(string[] args)
        {
            int i = 0;
            i = con;
            i = 999;
            int[] arr = { 1, 2, 3, 4};
            for (int j = 0; j < 4; j++) {
                Console.WriteLine("Hello {0} yes{0}", arr[j], con);
            }
            Console.WriteLine($"Hello world{i}.....{con}");
            Console.ReadKey();
        }
    }
}

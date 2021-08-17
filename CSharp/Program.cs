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
            Cars c = new Cars("BMW", 2021);
            //c.Model = "Mazda";
            //c.Year = 2020;
            Console.WriteLine($"Hello world {c.Model} " +
                $"and {c.Year}");
            Console.ReadKey();
            

        }
    }
}

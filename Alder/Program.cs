using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert name");
            string name = Console.ReadLine();

            Console.WriteLine("Insert age");
            byte age = Convert.ToByte(Console.ReadLine());

            if (age < 3)
            {
                Console.WriteLine("Camilla, du må gå med ble");
            }
            else if (age >= 3 && age <= 15)
            {
                Console.WriteLine("Camilla, du må ingenting");
            }
            else if(age > 15 && age < 18)
            {
                Console.WriteLine("Camilla, du må drikke");
            }
            else if (age >= 18)
            {
                Console.WriteLine("Camilla, du må stemme og køre bil");
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace broini
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zapishete desetichno chislo: ");
            int desetichno = int.Parse(Console.ReadLine());
            string dvoichno = Convert.ToString(desetichno,2);
            Console.WriteLine("dvoichno: " + dvoichno);
        }
    }
}

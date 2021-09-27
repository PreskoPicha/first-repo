using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            string chislo = "17";
            int desetichno = Convert.ToInt32(chislo, 16);
            string dvoichno = Convert.ToString(desetichno, 2);
            Console.WriteLine(dvoichno);
        }
    }
}

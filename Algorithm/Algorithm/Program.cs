using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();

            Dichotomy.StartDichotomy(CommonService.GetOrderArr(),int.Parse(x));
            Console.ReadLine();
        }
    }
}

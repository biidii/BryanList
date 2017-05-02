using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BryanList
{
    class Program
    {
        static void Main(string[] args)
        {
            var bryanlist = new BryanList();

            bryanlist.Add(1);
            bryanlist.Add(1);
            bryanlist.Add(1);

            if(bryanlist.PrintOutList() == "1,1,1")
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}

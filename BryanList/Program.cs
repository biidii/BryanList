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

            DeterminePassOrFail(bryanlist.PrintOutList() == "1,1,1");
            
            bryanlist.Clear();

            DeterminePassOrFail(bryanlist.PrintOutList() == "");

            bryanlist.Add(1);
            bryanlist.Add(2);
            bryanlist.Add(3);

            var index = bryanlist.GetIndexOf(2);

            DeterminePassOrFail(index == 1);

            var atIndex2 = bryanlist.GetAtIndex(2);

            DeterminePassOrFail(atIndex2 == 2);

            var count = bryanlist.Count();

            DeterminePassOrFail(count == 3);

            var first = bryanlist.First();

            DeterminePassOrFail(first == 1);

            var last = bryanlist.Last();

            DeterminePassOrFail(last == 3);

            bryanlist.Remove(2);

            DeterminePassOrFail(bryanlist.PrintOutList() == "1,3");

            count = bryanlist.Count();

            DeterminePassOrFail(count == 2);

            bryanlist.Add(4);

            atIndex2 = bryanlist.GetAtIndex(2);

            DeterminePassOrFail(atIndex2 == 4);

            bryanlist.SetAtIndex(1, 5);

            DeterminePassOrFail(bryanlist.PrintOutList() == "1,5,4");

            var newBryanList = new BryanList();
            newBryanList.Add(6);
            newBryanList.Add(7);

            bryanlist.Copy(newBryanList);

            count = bryanlist.Count();

            DeterminePassOrFail(count == 5);
            DeterminePassOrFail(bryanlist.PrintOutList() == "1,5,4,6,7");
        }

        public static void DeterminePassOrFail(bool assertion)
        {
            if (assertion)
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

using Interfaces;
using System;

namespace Sorter
{
    public class Sorter1: ISorter{
        public int Run(){
            Console.WriteLine("Running Sorter1");
            return 1;
        }
        public int Done(){
            Console.WriteLine("Done Sorter1");
            return 1;
        }
        public void Instructions(){
            Console.WriteLine("Sorter 11111111111111 Instructions");
        }
    }
}
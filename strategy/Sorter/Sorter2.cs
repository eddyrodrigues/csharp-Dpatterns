using Interfaces;
using System;

namespace Sorter
{
    public class Sorter2: ISorter{
        public int Run(){
            Console.WriteLine("Running Sorter2");
            return 2;
        }
        public int Done(){
            Console.WriteLine("Done Sorter2");
            return 2;
        }
        public void Instructions(){
            Console.WriteLine("Sorter 22222222222222 Instructions");
        }
    }
}
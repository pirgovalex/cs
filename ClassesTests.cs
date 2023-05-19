using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp
{
    public class ClassesTests
    {
        public static string EvenOrOdd(int number){
    
        return number%2==0?"Even" : "Odd";
        
    }
        static void Main(string[] args){
            int number=int.Parse(Console.ReadLine());
            Console.WriteLine(EvenOrOdd(number));
        }
    }
    
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace csharp
{
    public class pishacoudc
    {
       static void Main(string[] args)
        {
            int[,] pache={{1,2,3}
                         ,{4,5,6}
                         ,{7,8,9}};
          int diagonalSum = Enumerable.Range(0, pache.GetLength(0))
            .Sum(i => pache[i, i]);
            Console.WriteLine(diagonalSum);
         }
        } 
    }
    

    
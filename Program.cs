using System;

namespace ConsoleApp
{
    class Program
    {
      static int Getpow(int x,int y)
      {
        int result=1;
        for(int i=0;i<y;i++)
        {
          result*=x;
        }
        Console.WriteLine(result);
        return result;
      }
      static long GetPowBig(long x,long y)
      {
        long result=1;
        for(long i=0;i<y;i++)
        {
          result*=x;
        }
        Console.WriteLine(result);
        Console.WriteLine("IM BIG BABE");
        return result;
      }
        static void Main (string[] args)
        {
          int a,b;
          a=int.Parse(Console.ReadLine());
          b=int.Parse(Console.ReadLine());
          if (a>long.MaxValue||b>long.MaxValue)
          {
            GetPowBig(a,b);
          }
          else{
          Getpow(a,b);
          }
        }
    }
}

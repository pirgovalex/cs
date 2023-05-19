using System;
using System.Collections.Generic;

namespace csharp
{
    public class pishacoudc
    {
        static void Calc(int x,int y,out int s,out int pr)
        {
         s=x+y;pr=x*y;   

        }
       static void Main(string[] args)
        {
         int a=3,b=8,c=0,d=0;
         Calc(a,b,out c,out d);
         Console.Write(c+"\n"+d);
         }
        } 
    }
    

    
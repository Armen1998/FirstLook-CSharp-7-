using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLook
{
    class PatternMatching
    {
        public void PrintSum(object o)
        {
            if (o is null) return;
            if (!(o is int i)) return;

            for (int k = 0; k <= i; k++)
                Console.WriteLine(k);
        }

        //In C# 7 you can use PatternMatching.
        public void PrintSum2(object o)
        {
            //Following condition says if o is type of int or type of string and you 
            //can parse it to int, hold o's value in i.
            if (o is int i || o is string s && int.TryParse(s, out i))
            {
                for (int k = 0; k <= i; k++)
                    Console.WriteLine(k);
            }

        }
    }
}

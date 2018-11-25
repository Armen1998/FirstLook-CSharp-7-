using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLook
{
    class LocalFunctions
    {

        /// <summary>
        /// In C# 7 We can create local functions.
        /// </summary>
        public int ReturnSum(int n)
        {
            //Local function PrintEachStep
            void PrintEachStep(int sumEachStep)
            {
                Console.WriteLine(sumEachStep);
            }

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += i;
                //We can call Local function
                PrintEachStep(sum);
            }

            return sum;


        }
    }
}

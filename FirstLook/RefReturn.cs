using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLook
{
    class RefReturn
    {
        /// <summary>
        /// In C# 7 we can return the reference. 
        /// </summary>        
        public ref int GetSpecifiedValue(int value, int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == value)
                {
                    return ref numbers[i];
                }
            }
            throw new ArgumentOutOfRangeException("Not Exist");
        }
    }
}

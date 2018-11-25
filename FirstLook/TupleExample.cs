using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLook
{
    class TupleExample
    {
        /// <summary>
        /// In C# 7, function can return more than one element.
        /// It can do with System.Tuple static class.
        /// </summary>
        /// <returns>Function returns object which have Item1, Item2, Item3, ... elements</returns> 
        public (int, int, int) GetTime()
        {
            return (1, 35, 20); // tuples literals
        }

        /// <summary>
        /// But in fact we can set names to our returned elements.
        /// </summary>
        /// <returns>In this case Function returns objects which have hour, minutes, seconds elements</returns>
        public (int hour, int minutes, int seconds) GetTime2()
        {
            return (1, 35, 20);
        }
    }
}

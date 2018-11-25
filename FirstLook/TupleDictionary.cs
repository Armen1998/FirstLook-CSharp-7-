using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLook
{
    class TupleDictionary
    {
        /// <summary>
        /// Creating a Dictionary with a Tumple as the key.
        /// </summary>
        Dictionary<(string, int), string> tupleDictionary = new Dictionary<(string, int), string>();
        public void SetObject((string name, int age) key, string job)
        {
            tupleDictionary.Add((key.name, key.age), job);
        }

        public string GetJob((string name, int age) key)
        {
            return tupleDictionary[(key.name, key.age)];
        }
    }
}

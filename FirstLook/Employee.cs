using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLook
{
    class Employee
    {
        private string Name { get; set; }

        /// <summary>
        /// In Constructor we can use Lambda Expressions.
        /// </summary>
        /// <param name="name"></param>
        public Employee(string name) => Name = name ?? throw new ArgumentNullException("Value cannot be null");

        public string GetName() => Name;
    }
}

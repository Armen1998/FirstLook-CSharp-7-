using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//In C# 7 you can include static Classes. For example System.Console, System.Math, ...
using static System.Console; 


namespace FirstLook
{           
       
    class Program
    {
        static void Main(string[] args)
        {

            TupleExample tapleExamples = new TupleExample();
            var obj = tapleExamples.GetTime();
            //When we calling GetTime() function which returns 3 element
            //C# automaticly hold that values in Item1, Item2, Item3, ...
            WriteLine($"Hour: {obj.Item1}, Minute: {obj.Item2} , Seconds: {obj.Item3}");
            //Now we will call GetTime2() function.
            var obj2 = tapleExamples.GetTime2();
            WriteLine($"Hour: {obj2.hour}, Minute: {obj2.minutes} , Seconds: {obj2.seconds}");

            //we can declare new variebles to hold returned values.
            var (hour, minutes, seconds) = tapleExamples.GetTime();
            WriteLine($"Hour: {hour}, Minute: {minutes} , Seconds: {seconds}");

            //Now we use TupleDictionary class
            TupleDictionary tupleDictionary = new TupleDictionary();
            tupleDictionary.SetObject(("Armen", 19), "Programmer");
            tupleDictionary.SetObject(("Poxos", 22), "Tester");
            tupleDictionary.SetObject(("Poxosuhi", 23), "Designer");
            WriteLine(tupleDictionary.GetJob(("Armen", 19)));

            LocalFunctions localFunctions = new LocalFunctions();
            localFunctions.ReturnSum(7);


            RefReturn refReturn = new RefReturn();
            int[] numbers = { 1, 7, 8, 10, 5, 4 };
            ref int result = ref refReturn.GetSpecifiedValue(10, numbers);
            result = -10;
            WriteLine("Use of ref Return.");
            WriteLine(numbers[3]);

            WriteLine("Use of Employee Constructor");
            Employee employee = new Employee("Armen");
            WriteLine(employee.GetName());

            //Following code will throw ArgumentNullException
            //Employee employee2 = new Employee(null);
            //WriteLine(employee2.GetName()); 

            ReadKey();
        }

    }
}

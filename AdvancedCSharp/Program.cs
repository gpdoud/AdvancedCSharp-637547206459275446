using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace AdvancedCSharp {
    class Program {

        Mathematics<double> coll = new Mathematics<double>();

        private void TestCollection() {
            coll.Add(1.5);
            coll.Add(7.37);
            coll.Add(-22.123);
        }



        // Lambda in Methods
        //private int Add(int a, int b) {
        //    return a + b;
        //}
        private int Add(int a, int b) => a + b;

        // Rethrowing Exceptions
        private void RethrowingExceptions() {
            try {
                throw new BootcampException("Throw this exception");
                // var ex = new BootcampExcetion("Throw this exception");
                // throw ex;
            } catch (BootcampException ex) {
                // if we cannot handle the exception
                throw;
            }
        }










        // Collection Initializers
        // List<int>
        List<int> ints = new List<int> { 1, 2, 3, 4, 5 };

        // Dictionary<int, Bootcamp>
        Dictionary<string, Bootcamp> bootcamps = new Dictionary<string, Bootcamp> {
            ["CSharp"] = new Bootcamp(),
            ["Java"] = new Bootcamp()
        };
        void AccessDictionary() {
            var csharpBc = bootcamps["CSharp"];
        }

        int i = 10;
        string a = "ABC";

        static void Elena() {
            Console.WriteLine("Hi Elena!");
        }

        static void Main(string[] args) {
            Program.Elena();
            var program = new Program();
            program.Run();
        }
        void Run() {

            var stateCode = "OH";
            var stateName = "";
            switch(stateCode) {
                case "OH": stateName = "Ohio"; break;
                case "KY": stateName = "Kentucky"; break;
                case "IN": stateName = "Indiana"; break;
                default: stateName = "I Don't know"; break;
            }
            stateName = stateCode switch
            {
                "OH" => "Ohio",
                "KY" => "Kentucky",
                "IN" => "Indiana",
                _ => "I don't know"
            };

            //var ac = new AbstractClass();

            TestCollection();

            RethrowingExceptions();

            var nbrStr = "123";
            int nbr;
            var ok = int.TryParse(nbrStr, out nbr);

            Console.WriteLine($"Before increment a is {a}");
            Concat(ref a);
            Console.WriteLine($"Before increment a is {a}");

            Console.WriteLine($"Before increment i is {i}");
            Add1(ref i);
            Console.WriteLine($"After increment i is {i}");
        }
        void Concat(ref string s) {
            s += "XXX";
        }
        void Add1(ref int n) {
            n++;
        }

    }
}

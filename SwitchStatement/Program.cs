using System;

namespace SwitchStatement {
    class Program {
        static void Main(string[] args) {

            Console.Write("Enter state code : ");
            var statecode = Console.ReadLine();
            var stcd = statecode.ToLower();

            switch(stcd) {
                case "oh": Console.WriteLine($"State is Ohio"); break;
                case "mt": Console.WriteLine($"State is Montana"); break;
                case "az": Console.WriteLine($"State is Arizona"); break;
                default: Console.WriteLine($"State code is not found"); break;

            }

        }
    }
}

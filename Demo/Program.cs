using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Scriptor;
using Scriptor.Standard;


namespace Demo {
    class Program {
        static void Main(string[] args) {

            Executor exec = new Executor(new ConsoleLog());

            exec.DeffineCommand(new HelpCommand());

            bool run = true;
            while (run) {
                exec.Execute(Console.ReadLine());
            }

        }
    }
}

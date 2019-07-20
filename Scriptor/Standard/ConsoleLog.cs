using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scriptor.Standard {
    public class ConsoleLog : OutputLog {
        public override void Clear() {
            Console.Clear();
        }

        public override void Write(string str) {
            Console.Write(str);
        }
    }
}

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

        public override void ResetColor() {
            Console.ResetColor();
        }

        public override void TextBackColor(Colors c) {
            Console.BackgroundColor = (ConsoleColor)c;
        }

        public override void TextColor(Colors c) {
            Console.ForegroundColor = (ConsoleColor)c;
        }

        public override void Write(string str) {
            Console.Write(str);
        }
    }
}

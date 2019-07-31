using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scriptor {
    public abstract class OutputLog {
        

        public abstract void TextColor(Colors c);
        public abstract void TextBackColor(Colors c);
        public abstract void ResetColor();

        public abstract void Write(string str);

        public virtual void WriteLine(string str) {
            Write(str + "\n");
        }

        public void WriteException(Exception e) {
            Exception exc = e;
            int tabs = 0;
            TextColor(Colors.Red);
            do {
                for (int i = 0; i < tabs; i++) {
                    Write("  ");

                }
                WriteLine(exc.GetType().Name + " - " + exc.Message);
                exc = exc.InnerException;
                tabs++;
            } while (exc != null);
            ResetColor();
        }

        public abstract void Clear();

    }
}

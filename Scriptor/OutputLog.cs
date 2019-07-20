using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scriptor {
    public abstract class OutputLog {

        public abstract void Write(string str);

        public virtual void WriteLine(string str) {
            Write(str + "\n");
        }

        public void WriteException(Exception e) {
            Exception exc = e;
            int tabs = 0;
            do {
                for (int i = 0; i < tabs; i++) {
                    Write("  ");

                }
                WriteLine(exc.Message);
                exc = exc.InnerException;
                tabs++;
            } while (exc != null);
        }

        public abstract void Clear();

    }
}

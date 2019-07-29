using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scriptor {
    public abstract class Expression<T> : Command {

        public T Result { get; private set; }

        public Expression(string name) : base(name) {

        }

        public override void Execute(string args) {
            Reset();
            Result = Evaluate(args);
        }

        private void Reset() {
            Result = default(T);
        }

        protected abstract T Evaluate(string args);

    }
}

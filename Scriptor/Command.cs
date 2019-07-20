using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scriptor {
    public abstract class Command {

        public const string Command_regex = "(?<name>\\w+) ?(?<args>.+)?";

        protected Executor Exec { get; private set; }
        protected OutputLog Output => Exec.Output;

        public string Name { get; protected set; }
        public string Description { get; protected set; }

        public Command(string name) {
            Name = name;
        }

        internal void Init(Executor e) {
            Exec = e; 
        }

        public abstract void Execute(string args);
    }
}

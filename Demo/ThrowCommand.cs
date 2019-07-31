using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Scriptor;

namespace Demo {
    class ThrowCommand : Command {

        public ThrowCommand() : base("throw") {

        }

        public override void Execute(string args) {
            throw new Exception(args);
        }
    }
}

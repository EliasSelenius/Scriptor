using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scriptor.Standard {
    public class ExecuteCommand : Command {

        public ExecuteCommand() : base("exec") {

        }


        public override void Execute(string args) {
            foreach (var item in args.Split('\n')) {
                Exec.Execute(item);
            }
        }
    }
}

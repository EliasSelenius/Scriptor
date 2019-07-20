using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scriptor.Standard {
    public class HelpCommand : Command {

        public HelpCommand() : base("help") {
            Description = "Displays all deffined commands";
        }

        public override void Execute(string args) {
            foreach (var c in Exec.Commands) {
                Output.WriteLine(c.Key + " - " + c.Value.GetType().Name + " - " + c.Value.Description);
            }
        }
    }
}

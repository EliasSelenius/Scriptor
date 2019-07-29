using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scriptor {
    public class Executor {

        public readonly Dictionary<string, Command> Commands = new Dictionary<string, Command>();

        public OutputLog Output { get; protected set; }

        public Executor(OutputLog io) {
            Output = io;
        }

        public void DeffineCommand(Command com, string name = null) {
            Commands.Add(name ?? com.Name, com);
            com.Init(this);
        }

        public void Execute(string cmd) {
            var m = System.Text.RegularExpressions.Regex.Match(cmd, Command.Command_regex);
            var name = m.Groups["name"].Value;
            var args = m.Groups["args"].Value;

            if (Commands.ContainsKey(name)) {
                try {
                    Commands[name].Execute(args);
                } catch (Exception e) {
                    Output.WriteException(e);
                }
            } else {
                Output.WriteLine("not recognized!");
            }

        }
    }
}

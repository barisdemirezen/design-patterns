using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command
{
    class Invoker
    {
        private Queue<ICommand> _commands = new();

        public void AddCommand(ICommand command)
        {
            _commands.Enqueue(command);
        }

        public void ExecuteAll()
        {
            Console.WriteLine($"Starting to execute {_commands.Count} commands\n");

            while (_commands.Count > 0)
                _commands.Dequeue().Execute();

            Console.WriteLine($"\nCompleted execution of commands");
        }
    }
}

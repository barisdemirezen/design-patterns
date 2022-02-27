using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command
{
    class Upper : ICommand
    {
        private string _payload = String.Empty;
        public Upper(string payload)
        {
            _payload = payload;
        }
        public void Execute()
        {
            Console.WriteLine($"Upper Text : {_payload.ToUpper()}");
        }

    }
}

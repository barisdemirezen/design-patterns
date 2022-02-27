using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command
{
    class Lower : ICommand
    {
        private string _payload = String.Empty;
        public Lower(string payload)
        {
            _payload = payload;
        }
        public void Execute()
        {
            Console.WriteLine($"Lower Text : {_payload.ToLower()}");
        }
    }
}

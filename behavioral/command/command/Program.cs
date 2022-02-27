using command;

string payload = "THİS is my text";

Invoker invoker = new();

invoker.AddCommand(new Upper(payload));
invoker.AddCommand(new Lower(payload));

invoker.ExecuteAll();

Console.ReadLine();
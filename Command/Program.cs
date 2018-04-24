using System;

namespace Command
{
    partial class Program
    {
        static void Main(string[] args)
        {
            // Create receiver, command, and invoker

            Receiver receiver = new Receiver();
            ICommand command = new ConcreteCommand(receiver);
            Invoker invoker = new Invoker();

            // Set and execute command

            invoker.SetCommand(command);
            invoker.ExecuteCommand();

            // Wait for user

            Console.ReadKey();
        }
    }
}

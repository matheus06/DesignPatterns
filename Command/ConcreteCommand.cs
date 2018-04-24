namespace Command
{
        /// <summary>

        /// The 'ConcreteCommand' class

        /// </summary>

        class ConcreteCommand : ICommand

        {
            private Receiver _receiver;
            // Constructor

            public ConcreteCommand(Receiver receiver)
            {
                _receiver = receiver;
            }

            public void Execute()
            {
                _receiver.Action();
            }
        }
}

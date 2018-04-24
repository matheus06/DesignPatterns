namespace Command
{
        /// <summary>

        /// The 'Invoker' class

        /// </summary>

        class Invoker

        {
            private ICommand _command;

            public void SetCommand(ICommand command)
            {
                this._command = command;
            }

            public void ExecuteCommand()
            {
                _command.Execute();
            }
        }

}

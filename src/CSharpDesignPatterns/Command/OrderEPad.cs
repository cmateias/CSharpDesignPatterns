namespace Command
{
    public class OrderEPad
    {
        private ICommand[] _commands;

        public OrderEPad()
        {
            _commands = new ICommand[6];
        }

        public void SetCommand(int slot, ICommand command)
        {
            _commands[slot] = command;
        }
        
        public object OnTrigger(int slot)
        {
            return _commands[slot].Execute();
        }
    }
}
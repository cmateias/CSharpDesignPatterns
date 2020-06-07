namespace Strategy
{
    public class HostingTask : IPerformTask
    {
        public string Perform()
        {
            return "I'm ready to greet the customers and take them to their table.";
        }
    }
}
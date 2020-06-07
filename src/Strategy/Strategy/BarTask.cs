namespace Strategy
{
    public class BarTask : IPerformTask
    {
        public string Perform()
        {
            return "I'm ready to prepare coffees, cocktails etc.";
        }
    }
}
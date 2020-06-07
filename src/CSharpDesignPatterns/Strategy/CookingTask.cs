namespace Strategy
{
    public class CookingTask : IPerformTask
    {
        public string Perform()
        {
            return "I'm ready to cook any item on the menu";
        }
    }
}
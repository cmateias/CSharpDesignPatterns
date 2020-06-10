namespace Template
{
    public class BartenderOrderProcess : OrderProcess
    {
        public override string GatherIngredients()
        {
            return "Gathering the cocktail ingredients needed for the order\n";
        }

        public override string Prepare()
        {
            return "Mixing the drinks\n";
        }

        public override string Finalise()
        {
            return "Pouring the drinks in glasses\n";
        }
    }
}
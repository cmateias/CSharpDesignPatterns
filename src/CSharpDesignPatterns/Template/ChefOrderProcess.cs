namespace Template
{
    public class ChefOrderProcess : OrderProcess
    {
        public override string GatherIngredients()
        {
            return "Gathering the cooking ingredients needed for the order\n";
        }

        public override string Prepare()
        {
            return "Cooking the meal\n";
        }

        public override string Finalise()
        {
            return "Plating the food\n";
        }
    }
}
namespace AbstractFactory
{
    public class ComplimentaryDrink : ICustomerComplimentary
    {
        public string GetComplimentary()
        {
            return "Able to offer complimentary drinks";
        }
    }
}
namespace AbstractFactory
{
    public class CustomerServiceRole : IStaffRole
    {
        public string GetRole()
        {
            return "CustomerService";
        }
    }
}
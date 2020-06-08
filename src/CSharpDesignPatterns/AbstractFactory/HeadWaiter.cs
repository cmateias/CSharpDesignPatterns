using System.Text;

namespace AbstractFactory
{
    public class HeadWaiter : Staff
    {
        private readonly IStaffDetailsFactory _staffDetailsFactory;

        public HeadWaiter(IStaffDetailsFactory staffDetailsFactory)
        {
            _staffDetailsFactory = staffDetailsFactory;
        }

        public override string GetInfo()
        {
            Name = _staffDetailsFactory.CreateName();
            Experience = _staffDetailsFactory.CreateExperience();
            Role = _staffDetailsFactory.CreateRole();
            WineKnowledge = _staffDetailsFactory.CreateWineKnowledge();
            CustomerComplimentary = _staffDetailsFactory.CreateCustomerComplimentary();

            var sb = new StringBuilder();

            sb.Append("Name: " + Name.GetName() + "\n");
            sb.Append("Experience: " + Experience.GetExperience() + "\n");
            sb.Append("Role: " + Role.GetRole() + "\n");
            sb.Append("Wine Knowledge: " + WineKnowledge.GetWineKnowledge() + "\n");
            sb.Append("Customer Complimentary: " + CustomerComplimentary.GetComplimentary() + "\n");

            return sb.ToString();
        }
    }
}
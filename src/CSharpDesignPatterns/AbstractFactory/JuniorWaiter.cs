using System.Text;

namespace AbstractFactory
{
    public class JuniorWaiter : Staff
    {
        private readonly IStaffDetailsFactory _staffDetailsFactory;

        public JuniorWaiter(IStaffDetailsFactory staffDetailsFactory)
        {
            _staffDetailsFactory = staffDetailsFactory;
        }

        public override string GetInfo()
        {
            Name = _staffDetailsFactory.CreateName();
            Experience = _staffDetailsFactory.CreateExperience();
            Role = _staffDetailsFactory.CreateRole();

            var sb = new StringBuilder();

            sb.Append("Name: " + Name.GetName() + "\n");
            sb.Append("Experience: " + Experience.GetExperience() + "\n");
            sb.Append("Role: " + Role.GetRole() + "\n");

            return sb.ToString();
        }
    }
}
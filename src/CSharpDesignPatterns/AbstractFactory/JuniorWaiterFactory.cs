namespace AbstractFactory
{
    public class JuniorWaiterFactory : IStaffDetailsFactory
    {
        public IStaffName CreateName()
        {
            return new MarkName();
        }

        public IStaffExperience CreateExperience()
        {
            return new BeginnerExperience();
        }

        public IStaffRole CreateRole()
        {
            return new CustomerServiceRole();
        }

        public IStaffWineKnowledge CreateWineKnowledge()
        {
            return null;
        }

        public ICustomerComplimentary CreateCustomerComplimentary()
        {
            return null;
        }
    }
}
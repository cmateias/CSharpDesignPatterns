namespace AbstractFactory
{
    public class WaiterFactory : IStaffDetailsFactory
    {
        public IStaffName CreateName()
        {
            return new JackName();
        }

        public IStaffExperience CreateExperience()
        {
            return new AdvancedExperience();
        }

        public IStaffRole CreateRole()
        {
            return new AssistantLeadRole();
        }

        public IStaffWineKnowledge CreateWineKnowledge()
        {
            return new FrenchWineKnowledge();
        }

        public ICustomerComplimentary CreateCustomerComplimentary()
        {
            return null;
        }
    }
}
namespace AbstractFactory
{
    public class HeadWaiterFactory : IStaffDetailsFactory
    {
        public IStaffName CreateName()
        {
            return new AliceName();
        }

        public IStaffExperience CreateExperience()
        {
            return new WorldClassExperience();
        }

        public IStaffRole CreateRole()
        {
            return new TeamLeadRole();
        }

        public IStaffWineKnowledge CreateWineKnowledge()
        {
            return new ItalianWineKnowledge();
        }

        public ICustomerComplimentary CreateCustomerComplimentary()
        {
            return new ComplimentaryDrink();
        }
    }
}
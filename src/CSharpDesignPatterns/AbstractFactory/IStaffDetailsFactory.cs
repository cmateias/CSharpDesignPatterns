namespace AbstractFactory
{
    public interface IStaffDetailsFactory
    {
        IStaffName CreateName();
        IStaffExperience CreateExperience();
        IStaffRole CreateRole();
        IStaffWineKnowledge CreateWineKnowledge();
        ICustomerComplimentary CreateCustomerComplimentary();
    }
}
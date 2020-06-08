namespace AbstractFactory
{
    public class FrenchWineKnowledge : IStaffWineKnowledge
    {
        public string GetWineKnowledge()
        {
            return "Expert in French Wines";
        }
    }
}
using System.Text;

namespace AbstractFactory
{
    public abstract class Staff
    {
        protected IStaffExperience Experience;
        protected IStaffName Name;
        protected IStaffRole Role;
        protected IStaffWineKnowledge WineKnowledge;
        protected ICustomerComplimentary CustomerComplimentary;

        public abstract string GetInfo();

        public virtual string Introduce()
        {
            return "Good evening, I'll be your waiter tonight.";
        }

        public virtual string RetrieveOrder()
        {
            return "Can I take your order, please?";
        }

        public virtual string ServeOrder()
        {
            return "Enjoy!";
        }

        public virtual string GetPayment()
        {
            return "Would you like to pay by cash or card?";
        }

        public virtual string SayGoodbye()
        {
            return "Thank you and hope to see you again soon!";
        }
    }
}
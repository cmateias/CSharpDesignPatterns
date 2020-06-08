using System.Text;

namespace Factory
{
    public abstract class Staff
    {
        protected string Experience;
        protected string Name;
        protected string Role;

        public string GetInfo()
        {
            var sb = new StringBuilder();

            sb.Append("Name: " + Name + "\n");
            sb.Append("Experience: " + Experience + "\n");
            sb.Append("Role: " + Role + "\n");

            return sb.ToString();
        }

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
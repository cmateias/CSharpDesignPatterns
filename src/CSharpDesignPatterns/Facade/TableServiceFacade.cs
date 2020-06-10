using System.Text;

namespace Facade
{
    public class TableServiceFacade
    {
        private readonly HeadChef _headChef;
        private readonly HeadWaiter _headWaiter;
        private readonly SousChef _sousChef;
        private readonly Waiter _waiter;

        public TableServiceFacade(HeadWaiter headWaiter, HeadChef headChef, Waiter waiter, SousChef sousChef)
        {
            _headWaiter = headWaiter;
            _headChef = headChef;
            _waiter = waiter;
            _sousChef = sousChef;
        }

        public string BeginService()
        {
            var service = new StringBuilder();

            service.Append(_headWaiter.TakeOrder() + "\n");
            service.Append(_headChef.DelegateTask() + "\n");
            service.Append(_sousChef.TakeFoodOrder() + "\n");
            service.Append(_sousChef.PrepareFood() + "\n");
            service.Append(_headChef.FinalChecks() + "\n");
            service.Append(_waiter.Serve());

            return service.ToString();
        }

        public string EndService()
        {
            var service = new StringBuilder();

            service.Append(_sousChef.ClearCookingArea() + "\n");
            service.Append(_headWaiter.TakePayment() + "\n");
            service.Append(_waiter.ClearTable() + "\n");

            return service.ToString();
        }
    }
}
namespace State
{
    public interface IState
    {
        string Order();
        string ItemRunOut();
        string Pay();
        string CollectOrder();
    }
}
namespace Singleton
{
    public class MenuSingleton
    {
        private static volatile MenuSingleton _uniqueInstance;
        private static readonly object SyncRoot = new object();

        private MenuSingleton()
        {
        }

        public int StarterItems { get; set; } = 8;

        public int MainItems { get; set; } = 17;

        public static MenuSingleton GetInstance()
        {
            if (_uniqueInstance == null)
                lock (SyncRoot)
                {
                    if (_uniqueInstance == null) _uniqueInstance = new MenuSingleton();
                }

            return _uniqueInstance;
        }
    }
}
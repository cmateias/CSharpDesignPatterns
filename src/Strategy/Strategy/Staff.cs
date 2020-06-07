namespace Strategy
{
    public abstract class Staff
    {
        protected IPerformTask performTask;
        protected IWorkingSchedule workingSchedule;

        public IPerformTask PerformTask
        {
            get => performTask;
            set => performTask = value;
        }

        public IWorkingSchedule WorkingSchedule
        {
            get => workingSchedule;
            set => workingSchedule = value;
        }

        public abstract object ShowDetails();

        public string Performing()
        {
            return PerformTask.Perform();
        }

        public string Scheduling()
        {
            return WorkingSchedule.Working();
        }

        public string SignIn()
        {
            return "All staff must sign in before shift starts";
        }
    }
}
namespace CreationalDesignPatterns.Entities.Singleton
{
    using System.Diagnostics;

    public class SingletonThreadSafe2
    {
        SingletonThreadSafe2()
        {
        }

        public void DoSomething()
        {
            Debug.WriteLine(this.GetHashCode());
        }

        private static readonly object padlock = new object();
        private static SingletonThreadSafe2 instance = null;
        public static SingletonThreadSafe2 Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new SingletonThreadSafe2();
                        }
                    }
                }
                return instance;
            }
        }
    }
}

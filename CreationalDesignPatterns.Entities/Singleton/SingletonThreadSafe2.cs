namespace CreationalDesignPatterns.Entities.Singleton
{
    public  class SingletonThreadSafe2
    {
        SingletonThreadSafe2()
        {
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

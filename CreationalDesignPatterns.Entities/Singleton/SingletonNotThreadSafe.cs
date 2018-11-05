using System.Diagnostics;

namespace CreationalDesignPatterns.Entities.Singleton
{
    public class SingletonNotThreadSafe
    {

        private static SingletonNotThreadSafe instance = null;

        private SingletonNotThreadSafe()
        {
        }

        public void DoSomething()
        {
            Debug.WriteLine(this.GetHashCode());
        }

        public static SingletonNotThreadSafe Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SingletonNotThreadSafe();
                }
                return instance;
            }
        }
    }
}

using System.Diagnostics;

namespace CreationalDesignPatterns.Entities.Singleton
{
    public class SingletonThreadSafe3
    {
        private SingletonThreadSafe3()
        {

        }

        public void DoSomething()
        {
            Debug.WriteLine(this.GetHashCode());
        }

        public static SingletonThreadSafe3 Instance
        {
            get { return Nested.instance; }
        }

        private class Nested
        {
            static Nested()
            {

            }

            internal static readonly SingletonThreadSafe3 instance = new SingletonThreadSafe3();

        }
    }
}

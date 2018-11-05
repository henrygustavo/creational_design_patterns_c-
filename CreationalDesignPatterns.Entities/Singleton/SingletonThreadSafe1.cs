using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CreationalDesignPatterns.Entities.Singleton
{
    public class SingletonThreadSafe1
    {

        SingletonThreadSafe1()
        {
        }

        public void DoSomething()
        {
            Debug.WriteLine(this.GetHashCode());
        }

        private static readonly object padlock = new object();
        private static SingletonThreadSafe1 instance = null;
        public static SingletonThreadSafe1 Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new SingletonThreadSafe1();
                    }
                    return instance;
                }
            }
        }
    }
}

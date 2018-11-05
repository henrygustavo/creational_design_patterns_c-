namespace CreationalDesignPatterns.Test
{
    using System.Diagnostics;
    using Entities.Singleton;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SingletonTest
    {
        [TestMethod]
        public void MethodNotThreadSafe()
        {
            SingletonNotThreadSafe instance = SingletonNotThreadSafe.Instance;
            Debug.WriteLine(instance);
            SingletonNotThreadSafe anotherInstance = SingletonNotThreadSafe.Instance;
            Debug.WriteLine(anotherInstance);

            Assert.AreEqual(instance, anotherInstance);
        }

        [TestMethod]
        public void MethodSingletonThreadSafe1()
        {
            SingletonThreadSafe1 instance = SingletonThreadSafe1.Instance;
            Debug.WriteLine(instance);
            SingletonThreadSafe1 anotherInstance = SingletonThreadSafe1.Instance;
            Debug.WriteLine(anotherInstance);

            Assert.AreEqual(instance, anotherInstance);
        }

        [TestMethod]
        public void MethodSingletonThreadSafe2()
        {
            SingletonThreadSafe2 instance = SingletonThreadSafe2.Instance;
            Debug.WriteLine(instance);
            SingletonThreadSafe2 anotherInstance = SingletonThreadSafe2.Instance;
            Debug.WriteLine(anotherInstance);

            Assert.AreEqual(instance, anotherInstance);
        }

        [TestMethod]
        public void MethodSingletonThreadSafe3()
        {
            SingletonThreadSafe3 instance = SingletonThreadSafe3.Instance;
            Debug.WriteLine(instance);
            SingletonThreadSafe3 anotherInstance = SingletonThreadSafe3.Instance;
            Debug.WriteLine(anotherInstance);

            Assert.AreEqual(instance, anotherInstance);
        }
    }
}

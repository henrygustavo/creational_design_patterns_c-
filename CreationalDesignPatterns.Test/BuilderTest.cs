using System;
using System.Diagnostics;
using CreationalDesignPatterns.Entities.Builder.Ordenacion;
using CreationalDesignPatterns.Entities.Builder.Sandwich;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CreationalDesignPatterns.Test
{
    [TestClass]
    public class BuilderTest
    {
        [TestMethod]
        public void TestVersion01()
        {
            SandwichDirector sandwichDirector = new SandwichDirector(new MySandwichBuilder());
            sandwichDirector.BuildSandwich();
            Sandwich sandwich1 = sandwichDirector.Sandwhich;
            sandwich1.Display();

            SandwichDirector sandwichDirector2 = new SandwichDirector(new ClubSandwichBuilder());
            sandwichDirector2.BuildSandwich();
            Sandwich sandwich2 = sandwichDirector2.Sandwhich;
            sandwich2.Display();
        }

        [TestMethod]
        public void TestVersion02()
        {
            string[] datos = new string[] { "d", "g", "a", "b", "c", "h", "k" };
            OrdenacionFactory factory = new OrdenacionFactory();
            OrdenacionBuilder builder = factory.GetOrdenacionBuilder("QS");
            OrdenacionDirector director = new OrdenacionDirector(builder);
            director.Build(datos);
            for (int i = 0; i < datos.Length; i++)
            {
                Debug.WriteLine(datos[i]);
            }
        }
    }
}

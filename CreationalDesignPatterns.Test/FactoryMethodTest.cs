using System.Diagnostics;
using CreationalDesignPatterns.Entities.FactoryMethod.Cars;
using CreationalDesignPatterns.Entities.FactoryMethod.Fecha;
using CreationalDesignPatterns.Entities.FactoryMethod.Logger;
using CreationalDesignPatterns.Entities.FactoryMethod.Pizza;
using CreationalDesignPatterns.Entities.FactoryMethod.Validar;
using CreationalDesignPatterns.Entities.FactoryMethod.WebSite;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CreationalDesignPatterns.Test
{
    [TestClass]
    public class FactoryMethodTest
    {
        [TestInitialize]
        public void Initialize()
        {
            System.Environment.SetEnvironmentVariable("FileLogging", "ON");
        }

        [TestMethod]
        public void TestVersion01()
        {
            LoggerFactory factory = new LoggerFactory();
            var logger = factory.Logger;
            logger.Log("A Message to Log");
        }

        [TestMethod]
        [DataRow("auditts")]
        public void TestVersion02(string carName)
        {
            AutoFactory factory = new AutoFactory();

            IAuto car = factory.CreateInstance(carName);

            car.TurnOn();
            car.TurnOff();
        }

        [TestMethod]
        public void TestVersion03()
        {
            ValidaNombre validaNombre = NombreCompletoFactory.ObtenerValidador("Juan Pérez");
            Debug.WriteLine("Class Name: " + validaNombre.GetType().Name);
            Debug.WriteLine("Nombre: " + validaNombre.ObtenerNombre());
            Debug.WriteLine("Apellido: " + validaNombre.ObtenerApellido());

            Debug.WriteLine("***************************************************");

            validaNombre = NombreCompletoFactory.ObtenerValidador("Pérez, Juan");
            Debug.WriteLine("Class Name: " + validaNombre.GetType().Name);
            Debug.WriteLine("Nombre: " + validaNombre.ObtenerNombre());
            Debug.WriteLine("Apellido: " + validaNombre.ObtenerApellido());
        }

        [TestMethod]
        [DataRow("LA")]
        public void TestVersion04(string region)
        {

            ConfiguracionRegional configuracionRegional = ConfiguracionRegional.Instancia;
            configuracionRegional.Region = region;
            FechasFactory fFecha = new FechasFactory();
            FechaGenerica fechaHoy = fFecha.ObtenerFecha();

            Debug.WriteLine(region + ": " + fechaHoy.ObtenerFecha());
        }

        [TestMethod]
        public void TestVersion06()
        {

            Website site = WebsiteFactory.GetWebsite(WebsiteType.BLOG);

            Debug.WriteLine("Blog Pages: " + site.Pages);

            site = WebsiteFactory.GetWebsite(WebsiteType.SHOP);

            Debug.WriteLine("Shop Pages: " + site.Pages);

        }

        [TestMethod]
        public void TestVersion08()
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.OrderPizza("cheese");
            Debug.WriteLine("Ethan ordered a " + pizza.Name + "\n");

            pizza = chicagoStore.OrderPizza("cheese");
            Debug.WriteLine("Joel ordered a " + pizza.Name + "\n");

            pizza = nyStore.OrderPizza("clam");
            Debug.WriteLine("Ethan ordered a " + pizza.Name + "\n");

            pizza = chicagoStore.OrderPizza("clam");
            Debug.WriteLine("Joel ordered a " + pizza.Name + "\n");

            pizza = nyStore.OrderPizza("pepperoni");
            Debug.WriteLine("Ethan ordered a " + pizza.Name + "\n");

            pizza = chicagoStore.OrderPizza("pepperoni");
            Debug.WriteLine("Joel ordered a " + pizza.Name + "\n");

            pizza = nyStore.OrderPizza("veggie");
            Debug.WriteLine("Ethan ordered a " + pizza.Name + "\n");

            pizza = chicagoStore.OrderPizza("veggie");
            Debug.WriteLine("Joel ordered a " + pizza.Name + "\n");

        }
    }
}

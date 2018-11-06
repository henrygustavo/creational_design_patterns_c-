using CreationalDesignPatterns.Entities.AbstractFactory.CreditCard;

namespace CreationalDesignPatterns.Test
{
    using System;
    using System.Diagnostics;
    using Entities.AbstractFactory.Auto;
    using Entities.AbstractFactory.Hosting;
    using Entities.AbstractFactory.Pizza;
    using Entities.AbstractFactory.Vehicle;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class AbstractFactoryTest
    {
        [TestMethod]
        [DataRow("Windows")]
        public void TestVersion01(string hostingPlan)
        {
            HostingPlanAbstractFactory hostingFactory = HostingPlanAbstractFactory.GetHostingFactory(hostingPlan);

            EconomyHostingPlan economyHostingPlan = hostingFactory.CreateEconomyHosting();
            Debug.WriteLine(economyHostingPlan.GetFeatures());

            DeluxeHostingPlan deluxeHostingPlan = hostingFactory.CreateDeluxeHosting();
            Debug.WriteLine(deluxeHostingPlan.GetFeatures());

            UltimateHostingPlan ultimateHostingPlan = hostingFactory.CreateUltimateHosting();
            Debug.WriteLine(ultimateHostingPlan.GetFeatures());
        }

        [TestMethod]
        [DataRow("Luxury","Car")]
        public void TestVersion02(string vehicleCategory, string vehicleType)
        {
            const string Car = "Car";
            const string SUV = "SUV";

            string searchResult = null;
          
            VehicleFactory vehicleFactory = VehicleFactory.GetVehicleFactory(vehicleCategory);

            if (vehicleType.Equals(Car))
            {
                Car car = vehicleFactory.GetCar();
                searchResult = "Name: " + car.GetCarName() + "\nFeatures: " + car.GetCarFeatures();
            }
            else if (vehicleType.Equals(SUV))
            {
                SUV suv = vehicleFactory.GetSUV();
                searchResult = "Name: " + suv.GetSUVName() + "\nFeatures: " + suv.GetSUVFeatures();
            }
            Debug.WriteLine(searchResult);
        }

        [TestMethod]
        [DataRow("CreationalDesignPatterns.Entities.AbstractFactory.Auto.BMWFactory,CreationalDesignPatterns.Entities")]
        public void TestVersion03(string factoryName)
        {
            IAutoFactory factory = LoadFactory(factoryName);

            PrintHeader("SPORTS CAR");
            IAutoMobile car = factory.CreateSportsCar();
            car.TurnOn();
            car.TurnOff();

            PrintHeader("LUXURY CAR");
            car = factory.CreateLuxuryCar();
            car.TurnOn();
            car.TurnOff();

            PrintHeader("ECONOMY CAR");
            car = factory.CreateEconomyCar();
            car.TurnOn();
            car.TurnOff();
        }

        [TestMethod]
        public void TestVersion04()
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.OrderPizza("cheese");
            Debug.WriteLine("Ethan ordered a " + pizza + "\n");

            pizza = chicagoStore.OrderPizza("cheese");
            Debug.WriteLine("Joel ordered a " + pizza + "\n");

            pizza = nyStore.OrderPizza("clam");
            Debug.WriteLine("Ethan ordered a " + pizza + "\n");

            pizza = chicagoStore.OrderPizza("clam");
            Debug.WriteLine("Joel ordered a " + pizza + "\n");

            pizza = nyStore.OrderPizza("pepperoni");
            Debug.WriteLine("Ethan ordered a " + pizza + "\n");

            pizza = chicagoStore.OrderPizza("pepperoni");
            Debug.WriteLine("Joel ordered a " + pizza + "\n");

            pizza = nyStore.OrderPizza("veggie");
            Debug.WriteLine("Ethan ordered a " + pizza + "\n");

            pizza = chicagoStore.OrderPizza("veggie");
            Debug.WriteLine("Joel ordered a " + pizza + "\n");
        }

        [TestMethod]
        public void TestVersion05()
        {
            CreditCardFactory abstractFactory = CreditCardFactory.GetCreditCardFactory(775);

            CreditCard card = abstractFactory.GetCreditCard(CardType.PLATINUM);

            Debug.WriteLine(card.GetType());

            abstractFactory = CreditCardFactory.GetCreditCardFactory(600);

            CreditCard card2 = abstractFactory.GetCreditCard(CardType.GOLD);

            Debug.WriteLine(card2.GetType());
        }

        private static IAutoFactory LoadFactory(string factoryName)
        {
            IAutoFactory autoFactory = null;

            try
            {
                var t = System.Activator.CreateInstance(Type.GetType(factoryName));
                autoFactory = (IAutoFactory)Activator.CreateInstance(Type.GetType(factoryName));
            }
            catch (Exception ex)
            {
            }
            return autoFactory;
        }

        public static void PrintHeader(string title)
        {
            Debug.WriteLine("++++++++++++++++ {0} ++++++++++++++++++\n", title);
        }
    }
}

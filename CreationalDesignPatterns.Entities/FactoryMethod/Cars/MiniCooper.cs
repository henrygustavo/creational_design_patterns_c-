using System.Diagnostics;

namespace CreationalDesignPatterns.Entities.FactoryMethod.Cars
{
    public class MiniCooper : IAuto
    {

        public string GetName()
        {
            return "Mini Cooper";

        }

        public  void TurnOn()
        {
            Debug.WriteLine("The Mini Cooper is on! 1.6 Liters of brutal force is churning.");
        }

        public  void TurnOff()
        {
            Debug.WriteLine("The Mini Cooper is has turned off.");
        }
    }
}
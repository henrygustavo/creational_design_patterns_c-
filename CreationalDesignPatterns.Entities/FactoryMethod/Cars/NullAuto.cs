namespace CreationalDesignPatterns.Entities.FactoryMethod.Cars
{
    public class NullAuto : IAuto
    {
        public string GetName()
        {
            return "empty";
        }

        public void TurnOn()
        {
            
        }

        public void TurnOff()
        {

        }
    }
}

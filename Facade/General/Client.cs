namespace Facade
{
    public class Client
    {
        public void TakeSomething()
        {
            var facade = new Facade();
            var something = facade.Order();
        }
    }
}

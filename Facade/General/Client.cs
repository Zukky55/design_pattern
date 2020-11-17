namespace Facade
{
    public class Client
    {
        public void Request()
        {
            var facade = new Facade();
            var something = facade.Order();
        }
    }
}

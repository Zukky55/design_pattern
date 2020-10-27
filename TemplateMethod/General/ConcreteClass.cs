namespace TemplateMethod
{
    public class ConcreteClass : AbstractClass
    {
        protected override void method01()
        {
            System.Console.WriteLine($"flow01");
        }

        protected override void method02()
        {
            System.Console.WriteLine($"flow02");
        }
    }
}
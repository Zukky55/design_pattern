namespace Facade
{
    public class Facade
    {
        private ClassA classA = new ClassA();
        private ClassB classB =new ClassB();
        private ClassC classC =new ClassC();

        public object Order()
        {
            classA.a();
            classB.b();
            classC.c();
            return new object();
        }
    }
}

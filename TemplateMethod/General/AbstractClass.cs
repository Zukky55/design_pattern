namespace TemplateMethod{
public abstract class AbstractClass
{
    protected abstract void method01();
    protected abstract void method02();
    public void TemplateMethod(){
        method01();
        method02();
    }
}
}
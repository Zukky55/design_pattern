using System;
using Singleton;
using UseTM = TemplateMethod.Use;
using NotUseTM = TemplateMethod.NotUse;
using UseFacade = Facade.Use;
using NotUseFacade = Facade.NotUse;

class DesignPattern
{
    static void Main(string[] args)
    {
        DesignPattern dp = new DesignPattern();
        // dp.PlaySingleton();
        // dp.ExampleTemplateMethod();
        dp.ExampleFacade();
        
    }

    private void ExampleTemplateMethod()
    {

        NotUseTM.RookieTeacher poorTeacher = new NotUseTM.RookieTeacher();
        poorTeacher.Teach();

        UseTM.RookieTeacher smartTeacher = new UseTM.RookieTeacher();
        smartTeacher.Teach();

        TemplateMethod.ConcreteClass concreteClass = new TemplateMethod.ConcreteClass();
        concreteClass.TemplateMethod();
    }

    private void ExampleSingleton()
    {
        var notUse1 = new NotUseSingleton();
        Console.WriteLine($"{typeof(NotUseSingleton)}のインスタンスID: {notUse1.GetInstanceID()}");
        // 同じインスタンスのIDを参照しているつもり。
        var notUse2 = new NotUseSingleton();
        Console.WriteLine($"{typeof(NotUseSingleton)}のインスタンスID: {notUse2.GetInstanceID()}");
        Console.WriteLine($"Same instance?: {notUse1 == notUse2}");

        var use1 = UseSingleton.GetInstance();
        Console.WriteLine($"{typeof(UseSingleton)}のインスタンスID: {use1.GetInstanceID()}");
        // UseSingletonに一意が保障されたインスタンスが存在するのでそれを取得
        var use2 = UseSingleton.GetInstance();
        Console.WriteLine($"{typeof(UseSingleton)}のインスタンスID: {use2.GetInstanceID()}");
        Console.WriteLine($"Same instance?: {use1 == use2}");
    }

    private void ExampleFacade(){
        Console.WriteLine($"======\n");
        var notFacadeSando = new NotUseFacade.Sando();
        notFacadeSando.TripToFindBook();
        Console.WriteLine($"======\n");
        var facadeSando = new UseFacade.Sando();
        facadeSando.TripToFindBook();
    }
}

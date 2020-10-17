using System;
using Singleton;
using TM = TemplateMethod;

class DesignPattern
{
    static void Main(string[] args)
    {
        DesignPattern dp = new DesignPattern();
        // dp.PlaySingleton();
        
        dp.ExampleTemplateMethod();

    }

    private void ExampleTemplateMethod(){
        TM.UnityLesson unityLesson = new TM.UnityLesson();
        unityLesson.ConductLesson();

        TM.UnrealEngineLesson ueLesson = new TM.UnrealEngineLesson();
        ueLesson.ConductLesson();
    }

    private void ExampleSingleton(){
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
}

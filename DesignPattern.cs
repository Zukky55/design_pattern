using System;
using Singleton;
using UseTM = TemplateMethod.Use;
using NotUseTM = TemplateMethod.NotUse;

class DesignPattern
{
    static void Main(string[] args)
    {
        DesignPattern dp = new DesignPattern();
        // dp.PlaySingleton();
        
        dp.ExampleTemplateMethod();

    }

    private void ExampleTemplateMethod(){

        NotUseTM.UnityLesson rookieUnityTeacher = new NotUseTM.UnityLesson();
        rookieUnityTeacher.Lecture();
        rookieUnityTeacher.Test();
        rookieUnityTeacher.ResultsAnnounce();

        NotUseTM.UnrealEngineLesson rookieUeTeacher = new NotUseTM.UnrealEngineLesson();
        rookieUeTeacher.Teach(); // 名称が違ったり
        // notUseUeLesson.Test(); // テストし忘れていたりして安定的な授業を提供できない。
        rookieUeTeacher.ResultsAnnounce();
            

        // 授業のフローのテンプレートが存在する為、
        UseTM.UnityLesson rookieUnityTeacher2 = new UseTM.UnityLesson();
        rookieUnityTeacher2.ConductLesson(); 

        UseTM.UnrealEngineLesson rookieUeTeacher = new UseTM.UnrealEngineLesson();
        rookieUeTeacher.ConductLesson();
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

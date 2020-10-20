using System;

namespace TemplateMethod.NotUse
{
    public class UnityLesson
    {
        private CSharpLesson cSharpLesson = new CSharpLesson();
        public  void Lecture()
        {
            Console.WriteLine($"=====");
            Console.WriteLine($"Unityのレッスンしまーす。まずはC#のレッスンしてもらいますー。");
            cSharpLesson.Lecture();
            cSharpLesson.Test();
            Console.WriteLine($"Unityレクチャー中...");
        }

        public  void Test()
        {
            Console.WriteLine($"=====");
            Console.WriteLine($"出来る様になったかテストしますー。C#の後はUnity。");
            cSharpLesson.Test();
            Console.WriteLine($"Unityテスト中...");
        }
        public  void ResultsAnnounce()
        {
            Console.WriteLine($"=====");
            Console.WriteLine($"C#とUnityの結果を発表しますー.");
            cSharpLesson.ResultsAnnounce();
            Console.WriteLine($"Unityは全員合格!素晴らしい！");
        }
    }
}
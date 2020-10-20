using System;

namespace TemplateMethod.NotUse
{
    public class UnrealEngineLesson 
    {        
        private CppLesson cppLesson = new CppLesson();
        
        public void Teach()
        {
            Console.WriteLine($"=====");
            Console.WriteLine($"UEのレッスンしまーす。まずはC++のレッスンしてもらいますー。");
            cppLesson.Lecture();
            cppLesson.Test();
            Console.WriteLine($"UEレクチャー中...");
        }

        public void Test()
        {
            Console.WriteLine($"=====");
            Console.WriteLine($"出来る様になったかテストしますー。C++の後はUE。");
            cppLesson.Test();
            Console.WriteLine($"UEテスト中...");
        }
        public  void ResultsAnnounce()
        {
            Console.WriteLine($"=====");
            Console.WriteLine($"C++とUEの結果を発表しますー.");
            cppLesson.ResultsAnnounce();
            Console.WriteLine($"UEの合格者は0!最初からやり直し！！！");
        }
    }
}
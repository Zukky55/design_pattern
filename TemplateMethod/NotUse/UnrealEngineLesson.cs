using System;

namespace TemplateMethod.NotUse
{
    public class UnrealEngineLesson 
    {        
        public void Teach()
        {
            Console.WriteLine($"=====");
            Console.WriteLine($"UEのレッスンしまーす。");
            Console.WriteLine($"UEレクチャー中...");
        }

        public void Test()
        {
            Console.WriteLine($"=====");
            Console.WriteLine($"出来る様になったかテストしますー。");
            Console.WriteLine($"UEテスト中...");
        }
        
        // public  void ResultsAnnounce()
        // {
        //     Console.WriteLine($"=====");
        //     Console.WriteLine($"UEの結果を発表しますー.");
        //     Console.WriteLine($"UEの合格者は0!最初からやり直し！！！");
        // }
    }
}
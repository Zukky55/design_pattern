using System;

namespace TemplateMethod.Use
{
    public class UnrealEngineLesson : TemplateLesson
    {
        public override void Lecture()
        {
            Console.WriteLine($"=====");
            Console.WriteLine($"UEのレッスンしまーす。");
            Console.WriteLine($"UEレクチャー中...");
        }

        public override void Test()
        {
            Console.WriteLine($"=====");
            Console.WriteLine($"出来る様になったかテストしますー。");
            Console.WriteLine($"UEテスト中...");
        }

        public override void ResultsAnnounce()
        {
            Console.WriteLine($"=====");
            Console.WriteLine($"UEの結果を発表しますー.");
            Console.WriteLine($"UEの合格者は0!最初からやり直し！！！");
        }
    }
}
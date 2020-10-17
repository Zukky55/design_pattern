using System;

namespace TemplateMethod
{
    public class CppLesson : TemplateLesson
    {
        public override void Lecture()
        {
            Console.WriteLine($"=====");
            Console.WriteLine($"C++のレッスンしまーす。");
            Console.WriteLine($"C++レクチャー中...");
        }

        public override void Test()
        {
            Console.WriteLine($"=====");
            Console.WriteLine($"出来る様になったかテストしますー。");
            Console.WriteLine($"C++テスト中...");
        }
        public override void ResultsAnnounce()
        {
            Console.WriteLine($"=====");
            Console.WriteLine($"C++の結果を発表しますー.");
            Console.WriteLine($"C++の合格者は半分...大丈夫？");
        }
    }
}
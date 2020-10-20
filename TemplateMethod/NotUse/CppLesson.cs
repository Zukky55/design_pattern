using System;

namespace TemplateMethod.NotUse
{
    public class CppLesson
    {
        public  void Lecture()
        {
            Console.WriteLine($"=====");
            Console.WriteLine($"C++のレッスンしまーす。");
            Console.WriteLine($"C++レクチャー中...");
        }

        public  void Test()
        {
            Console.WriteLine($"=====");
            Console.WriteLine($"出来る様になったかテストしますー。");
            Console.WriteLine($"C++テスト中...");
        }
        public  void ResultsAnnounce()
        {
            Console.WriteLine($"=====");
            Console.WriteLine($"C++の結果を発表しますー.");
            Console.WriteLine($"C++の合格者は半分...大丈夫？");
        }
    }
}
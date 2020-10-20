using System;

namespace TemplateMethod.Use
{
    public class CSharpLesson : TemplateLesson
    {        public override void Lecture()
        {
            Console.WriteLine($"C#のレッスン");
        }

        public override void Test()
        {
            Console.WriteLine($"C#テスト");
        }
        public override void ResultsAnnounce()
        {
            Console.WriteLine($"C#の結果を発表.");
        }
    }
}
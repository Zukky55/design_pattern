namespace TemplateMethod.NotUse
{
    public class RookieTeacher
    {
        public void Teach(){
            // cppの授業
            var cppLesson = new CppLesson();
            cppLesson.Lecture();
            // テストし忘れ
            // cppLesson.Test(); 
            cppLesson.ResultsAnnounce();
            // ueの授業
            var ueLesson = new UnrealEngineLesson();
            ueLesson.Teach(); // なんか名前違う。中身は同じ処理なのか？
            ueLesson.Test();
            // ueLesson.ResultsAnnounce(); // 結果通知の処理が存在しない。
        }
    }
}
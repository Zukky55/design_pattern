namespace TemplateMethod.NotUse
{
    public class RookieTeacher
    {
        private UnrealEngineLesson ueLesson;
        private CppLesson cppLesson;

        public void Teach(){
            // cppの授業
            cppLesson.Lecture();
            cppLesson.Test();
            cppLesson.ResultsAnnounce();
            // ueの授業
            ueLesson.Lecture();
            ueLesson.Test();
            ueLesson.ResultsAnnounce();
        }
    }
}
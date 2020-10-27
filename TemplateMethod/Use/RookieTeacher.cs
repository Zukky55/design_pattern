namespace TemplateMethod.Use
{
    public class RookieTeacher
    {

        public void Teach(){
            // cppの授業
            var cppLesson = new CppLesson();
            cppLesson.ConductLesson(); // ベースにロジックが実装されているので授業のやり方を詳細に意識しなくても正しく授業が行える
            // ueの授業
            var ueLesson = new UnrealEngineLesson();
            ueLesson.ConductLesson();
        }
    }
}
namespace TemplateMethod
{
    public abstract class TemplateLesson
    {
        public void ConductLesson(){
            Lecture();
            Test();
            ResultsAnnounce();
        }
        public abstract void Lecture();
        public abstract void Test();
        public abstract void ResultsAnnounce();
    }
}
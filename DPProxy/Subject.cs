namespace DPProxy
{
    internal class Subject : ISubject
    {
        public string Request()
        {
            return $"Subject.Request()";
        }
    }
}
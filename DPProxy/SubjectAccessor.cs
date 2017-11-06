namespace DPProxy
{
    class SubjectAccessor
    {
        public interface ISubject
        {
            string Request();
        }
        private class Subject
        {
            public string Request()
            {
                return $"Subject.Request : Left door is choosen";
            }
        }

        public class Proxy : ISubject
        {
            Subject subject;
            public string Request()
            {
                if(subject == null)
                {
                    System.Console.WriteLine("Subject Inactive");
                    subject = new Subject();
                }
                System.Console.WriteLine("Subject Active");
                return $"Proxy call to {subject.Request()}";
            }
        }

        public class ProtectionProxy : ISubject
        {
            Subject subject;
            private string password = "Password";

            public string Authenticate(string password)
            {
                if(password == this.password)
                {
                    subject = new Subject();
                    return $"Protection Proxy: Authenticated ...";
                }
                else
                {
                    return $"Protection Proxy: Access denied ...";
                }
            }
            public string Request()
            {
                if(subject == null)
                {
                    return $"Protection Proxy: Authenticate first !";
                }
                else
                {
                    return $"Protection Proxy: Call to {subject.Request()}";
                }
            }
        }
    }
}
namespace DPProxy
{
    internal class Client : ISubject
    {
        private ISubject subject;

        public Client(ISubject subject)
        {
            this.subject = subject;
        }

        public string Request()
        {            
            return $"Client.Request() {subject.Request()}";
        }
    }
}
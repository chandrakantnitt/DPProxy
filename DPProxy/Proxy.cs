namespace DPProxy
{
    internal class Proxy : ISubject
    {
        private ISubject subject;

        public string Request()
        {
            // Subject instanciated when the request is made and not when the ctor is called
            // in other words the instanciation is delayed and restricted with Proxy
            // what if there are a bunch of clients ????
            if (subject == null)
                subject = new Subject();
            return $"Proxy.Request() {subject.Request()}";
        }
    }
}
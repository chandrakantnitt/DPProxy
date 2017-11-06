using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPProxy
{
    class Program : SubjectAccessor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proxy Pattern ... ");

            ISubject subject = new Proxy();
            Console.WriteLine(subject.Request());
            Console.WriteLine(subject.Request());

            //ProtectionProxy subject = new ProtectionProxy();
            //Console.WriteLine(subject.Request());
            //Console.WriteLine((subject as ProtectionProxy).Authenticate("Guessing"));
            //Console.WriteLine((subject as ProtectionProxy).Authenticate("Password"));
            //Console.WriteLine(subject.Request());
            
            //SubjectAccessor
            //ISubject subject = new Subject();
            //ISubject proxy = new Proxy();
            //ISubject client = new Client(proxy);
            //Console.WriteLine(client.Request());
            Console.ReadKey();
        }
    }
}

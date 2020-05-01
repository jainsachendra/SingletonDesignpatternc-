using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                ()=>NewMethod(),
                ()=>NewMethod1()
                ) ;

         
            
            Console.ReadLine();
        }

        private static void NewMethod1()
        {
            Signleton s2 = Signleton.getinstance;
            s2.printmessage("secondobj");
        }

        private static void NewMethod()
        {
            Signleton s1 = Signleton.getinstance;
            s1.printmessage("firstobj");
        }
    }
}

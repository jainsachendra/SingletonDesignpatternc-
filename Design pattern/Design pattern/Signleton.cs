using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_pattern
{
   public sealed class Signleton
    {
        private static int counter = 0;
        private static Signleton instance = null;
        private static readonly object obj = new object();
        public static Signleton getinstance
        {
            get
            {
                lock (obj)
                {
                       if (instance == null)
                    {
                        instance = new Signleton();
                    }
                }
                return instance;
                
            }
        }
        private Signleton()
        {
            counter++;
            Console.WriteLine("conter" + counter.ToString() );

        }
        public void printmessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}

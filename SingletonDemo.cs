using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    class SingletonDemo
    {
        private static SingletonDemo currentInstance;

        private SingletonDemo()
        {
        }

        public static SingletonDemo GetInstance()
        {
            if (currentInstance == null)
                currentInstance = new SingletonDemo();
            
            return currentInstance;
        }

        public void DoSomethingWiththeSingleton()
        {
            Console.WriteLine("Singleton doing something.");
        }



    }
}

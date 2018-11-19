using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    //Intent: ensure a class has one instance and provide a global point of access to it.
    /*
     -----------------------
     |Singleton            |
     -----------------------
     |static Instance()    |
     |SingletonOperation() |    
     |GetSingletonData()   |    
     -----------------------
     |static uniqueInstance|
     |singletonData        |
     -----------------------
         
         */

    class Program
    {
        static void Main(string[] args)
        {
            var singletonObject = SingletonDemo.GetInstance();

            singletonObject.DoSomethingWiththeSingleton();

        }
    }
}

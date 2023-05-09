using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class GenericClass<T>
    {
        //Variable of type T
        public T data;

        //This is my generic Constructor 
        public GenericClass(T data)
        {
            this.data = data;
            Console.WriteLine("Data :"+this.data);
        }
        //This is normal 
        public void DemoData(T data)
        {
            Console.WriteLine("Data :" + data);
        }

        public void DemData<T>(T data)
        {
            Console.WriteLine("Data :" + data);
        }
    }
}

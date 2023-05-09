using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class Program
    {
        //Generic means general form a and do not have return 
        //it means not specific or perticular data type
        //<> this is angle bracket with type name
        //TypeName<T> T is here type parameter 
        //Generic allow us to create single class or method that can be used with different data type
        //Advantage : we can reuse our code
        static void Main(string[] args)
        {
            //GenericClass<string> genericClass = new GenericClass<string>("Nk");

            //GenericClass<int> generic = new GenericClass<int>(8);
            //GenericClass<double> dGeneric = new GenericClass<double>(8.2);

            //generic.DemoData(5);
            //dGeneric.DemoData(5.5);
            //genericClass.DemoData("hello");

            //generic.DemData<int>(6);
            //dGeneric.DemData<double>(5.5);

            Merge merge = new Merge();
            merge.MergeSortArray();


            Console.ReadLine();

        }
    }
}

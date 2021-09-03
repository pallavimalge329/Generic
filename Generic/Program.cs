using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class GenericClass<T>
    {
        T myvariable;
        //using properties

        public T myproperty
        {
            get
            {
                return myvariable;
            }
            set
            {
                myvariable = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generic Demo");
            GenericClass<string> str = new GenericClass<string>();
            str.myproperty = "Pallavi";
            Console.WriteLine(str.myproperty);


            GenericClass<int> objint = new GenericClass<int>();
            objint.myproperty = 23;
            Console.WriteLine(objint.myproperty);
            Console.ReadKey();

        }
    }

}

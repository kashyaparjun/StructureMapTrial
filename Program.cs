using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructureMap;

namespace StructuringAMap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type1");
            typeOne();
            Console.WriteLine("Type2");
            typeTwo();
            Console.ReadLine();
        }

        static void typeOne()
        {
            var container = new Container(_ =>
            {
                _.For<IBus>().Use<Bus>();
                _.For<ICar>().Use<Car>();
            });

            var bus = container.GetInstance<IBus>();
            bus.printType();

            var car = container.GetInstance<ICar>();
            car.printType();
        }

        static void typeTwo()
        {
            var container = new Container(_ =>
            {
                _.Scan(x =>
                {
                    x.TheCallingAssembly();
                    x.WithDefaultConventions();
                });
            });

            var bus = container.GetInstance<IBus>();
            bus.printType();

            var car = container.GetInstance<ICar>();
            car.printType();

        }
    }
}

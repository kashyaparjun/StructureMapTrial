using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuringAMap
{
    public interface ICar
    {
        void printType();
    }

    public class Car: ICar
    {
        string model { get; set; }
        public Car()
        {
            this.model = "maruti";
        }
        public void printType()
        {
            Console.WriteLine(this.model+" Car");
        }
    }
}

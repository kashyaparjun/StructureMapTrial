using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuringAMap
{
    public interface IBus
    {
        void printType();
    }

    public class Bus:IBus
    {
        string model { get; set; }
        public Bus()
        {
            this.model = "volvo";
        }
        public void printType()
        {
            Console.WriteLine(this.model+" Bus");
        }
    }
}

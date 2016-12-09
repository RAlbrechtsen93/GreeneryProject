using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreeneryConsole.ServiceReference1;

namespace GreeneryConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client client = new Service1Client("BasicHttpBinding_IService1");

            var getalldata = client.GetAllData();
            Console.WriteLine(getalldata);

            Console.ReadKey();
        }
    }
}

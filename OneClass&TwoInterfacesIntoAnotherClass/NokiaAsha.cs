using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneClass_TwoInterfacesIntoAnotherClass
{
    // internal class NokiaAsha : INokia1, INokia2, MyClass
    //NOTE:MyClass ALWAYS WRITTEN BEFORE INTERFCES IN INHERITENCE PROCESS.OTHERWISE IT WILL THROW ERROR.
    internal class NokiaAsha : MyClass,INokia1, INokia2
    {
        public void Bluetooth()
        {
            Console.WriteLine("I am using blueetooth");
        }

        public void calling()
        {
            Console.WriteLine("CALLING FROM NOKIA1100 MOBILE");
        }

        public void endcall()
        {
            Console.WriteLine("call ended by 1100");
        }

        public void receiving()
        {
            Console.WriteLine("call recieved by 1100");
        }

        public void sendmessage()
        {
            Console.WriteLine("message is sending from nokia1100");
        }

        public void Wifi()
        {
            Console.WriteLine("call  by Wifi");
        }
    }
}

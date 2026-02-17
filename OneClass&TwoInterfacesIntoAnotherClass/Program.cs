using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneClass_TwoInterfacesIntoAnotherClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
//We cannot create object for interface but we can create a reference variable for interface.
//Syntax:Interfacename refrenceVariablename=new Childclassname()
            //FirstWay of accessing Nokia1100 vlass methods 
            INokia1 objinokia1 = new Nokia1100();
            objinokia1.calling();
            objinokia1.receiving();
            objinokia1.endcall();
            objinokia1.sendmessage();
            objinokia1 = new NokiaAsha();
            objinokia1.calling();
            objinokia1.receiving();
            objinokia1.endcall();
            objinokia1.sendmessage();
            objinokia1 = null;//here we are destroying/removing the object
            INokia2 objinokia2 = new NokiaAsha();
            objinokia2.Bluetooth();
            objinokia2.Wifi();
            objinokia2 = null;
            NokiaAsha objinokiaasha = new NokiaAsha();
            objinokiaasha.Wifi();
            objinokiaasha.print();

            //==================(OR)//SECOND WAY CALLING METHODS BY USING CREATE DIRECT OBJECT OF THE CHILD CLASS====================
            //Create the object for child classes and we can access those methods.
            Nokia1100 nokia1100Obj = new Nokia1100();
            nokia1100Obj.calling();
            nokia1100Obj.endcall();
            nokia1100Obj.sendmessage();
            nokia1100Obj.receiving();


            NokiaAsha nokiaAshaObj = new NokiaAsha();
           
            nokiaAshaObj.endcall();
            nokiaAshaObj.sendmessage();
            nokiaAshaObj.receiving();
            nokiaAshaObj.endcall();
            nokiaAshaObj.sendmessage();

            //=====================*******
            //we can inherit hybrid inheritence into another child clas also...
            //inheritence always inherit the members from baase to derived calss.
            Sample samObj = new Sample();
            samObj.Bluetooth();
            samObj.endcall();
            samObj.calling();
            samObj.receiving();
            samObj.Bluetooth();
            samObj.print();




            Console.ReadLine();
        }
    }
}

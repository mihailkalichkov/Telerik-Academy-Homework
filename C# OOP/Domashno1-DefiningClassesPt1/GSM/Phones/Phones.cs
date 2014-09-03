using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MobilePhone.Common;
using MobilePhone.Test;

namespace Phones
{
    class Phones
    {
        static void Main(string[] args)
        {
            var gsms = new List<GSM>();
            gsms.Add(new GSM("Samsung", "Galaxy"));
            gsms.Add(new GSM("Nokia", "2520", new Battery("JKS", 72, 2000)));
            gsms.Add(new GSM("Mtel", "T300", 300, "Pesho", new Battery("FBN"), new Display(7, 256)));

            var bat = new Battery("GHK");
            bat.BatteryType = AssignType.NiCd;
            Console.WriteLine(bat);
            Console.WriteLine();

            Console.WriteLine("---------- Test result ----------");
            GSMTest test = new GSMTest();
            test.AddGSM(gsms);
            test.DisplayTest();
            Console.WriteLine("---------- End of test result ----------");

            Console.WriteLine();
            GSMCallHistoryTest testCalls = new GSMCallHistoryTest();
            Console.WriteLine("----- Calls tester -----");
            testCalls.TestCallHistory();

            Console.WriteLine();
            Console.WriteLine(GSM.Iphone4s);
        }
    }
}
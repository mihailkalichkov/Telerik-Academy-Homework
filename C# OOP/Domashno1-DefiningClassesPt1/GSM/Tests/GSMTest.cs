using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MobilePhone.Common;

namespace MobilePhone.Test
{
    public class GSMTest
    {
        private List<GSM> phones = new List<GSM>();

        public void AddGSM(GSM phone)
        {
            this.phones.Add(phone);
        }

        public void AddGSM(List<GSM> phones)
        {
            this.phones.AddRange(phones);
        }

        public void DisplayTest()
        {
            foreach (var gsm in this.phones)
            {
                Console.WriteLine(gsm.ToString());
                Console.WriteLine();
            }

            Console.WriteLine("--- Static property ---");
            Console.WriteLine(GSM.Iphone4s);

            Console.WriteLine("----- End of statis property -----");
        }
    }
}
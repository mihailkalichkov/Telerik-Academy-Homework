using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MobilePhone.Common;

namespace MobilePhone.Test
{
    public class GSMCallHistoryTest
    {
        public void TestCallHistory()
        {
            var phone = new GSM("Nokia", "5056");
            phone.AddCall(new Call("0888555666", new DateTime(2013, 1, 12), 121));
            phone.AddCall(new Call("027895623", new DateTime(2013, 1, 29), 65));
            phone.AddCall(new Call("0998456123", new DateTime(2013, 1, 2), 50));
            phone.AddCall(new Call("+4481654411", new DateTime(2013, 1, 5), 100));

            Console.WriteLine("Four calls made:");
            foreach (var call in phone.CallHistory)
            {
                Console.WriteLine(call.ToString());
            }

            double totalPrice = phone.TotalPriceOfCalls(0.37);
            Console.WriteLine("Total price of calls made: {0}", totalPrice);

            int maxCall = 0; var longestCall = new Call();
            foreach (var call in phone.CallHistory)
            {
                if (call.Duration > maxCall)
                {
                    maxCall = call.Duration;
                    longestCall = call;
                }
            }
            Console.WriteLine("Longest call removed: {0}", longestCall);
            phone.DeleteCall(longestCall);
            totalPrice = phone.TotalPriceOfCalls(0.37);
            Console.WriteLine("Total price of calls made: {0}", totalPrice);

            Console.WriteLine("Clear call history");
            phone.ClearCallHistory();
            Console.WriteLine("Print call history:");
            foreach (var call in phone.CallHistory)
            {
                Console.WriteLine(call.ToString());
            }
        }
    }
}
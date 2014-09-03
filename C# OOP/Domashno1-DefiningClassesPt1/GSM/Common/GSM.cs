using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilePhone.Common
{
    public class GSM
    {
        private List<Call> callHistory = new List<Call>();
        private string gsmManifacturer = null;
        private string gsmModel = null;
        private int? gsmPrice = null;
        private string gsmOwner = null;
        private Battery gsmBattery = null;
        private Display gsmDisplay = null;
        private static GSM iphone4s = new GSM("Iphone", "Apple");

        // Constructor
        public GSM(string gsmManifacturer, string gsmModel)
        {
            this.gsmManifacturer = gsmManifacturer;
            this.gsmModel = gsmModel;
        }

        // Constructor
        public GSM(string gsmManifacturer, string gsmModel, Battery gsmBattery)
        {
            this.gsmManifacturer = gsmManifacturer;
            this.gsmModel = gsmModel;
            this.gsmBattery = gsmBattery;
        }

        // Constructor
        public GSM(string gsmManifacturer, string gsmModel, Battery gsmBattery, Display gsmDisplay)
        {
            this.gsmManifacturer = gsmManifacturer;
            this.gsmModel = gsmModel;
            this.gsmBattery = gsmBattery;
            this.gsmDisplay = gsmDisplay;
        }

        // Constructor
        public GSM(string gsmManifacturer, string gsmModel, int gsmPrice, string gsmOwner, Battery gsmBattery, Display gsmDisplay)
        {
            this.gsmManifacturer = gsmManifacturer;
            this.gsmModel = gsmModel;
            this.gsmPrice = gsmPrice;
            this.gsmOwner = gsmOwner;
            this.gsmBattery = gsmBattery;
            this.gsmDisplay = gsmDisplay;
        }

        // Properties
        public static GSM Iphone4s // static property
        {
            get
            {
                return iphone4s;
            }
        }

        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
        }

        public Display GsmDisplay
        {
            get
            {
                return this.gsmDisplay;
            }
            set
            {
                this.gsmDisplay = value;
            }
        }

        public Battery GsmBattery
        {
            get
            {
                return this.gsmBattery;
            }
            set
            {
                this.gsmBattery = value;
            }
        }

        public string GsmManifacturer // Mandatory
        {
            get
            {
                return this.gsmManifacturer;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(gsmManifacturer))
                {
                    throw new ArgumentException("Incorrect gsm manifacturer!");
                }
                this.gsmManifacturer = value;
            }
        }

        public string GsmModel  // Mandatory
        {
            get
            {
                return this.gsmModel;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(gsmModel))
                {
                    throw new ArgumentException("Incorrect gsm model!");
                }
                this.gsmModel = value;
            }
        }

        public int? GsmPrice
        {
            get
            {
                return this.gsmPrice;
            }
            set
            {
                if (gsmPrice < 0)
                {
                    throw new ArgumentException("Price cannot be negative!");
                }
                this.gsmPrice = value;
            }
        }

        public string GsmOwner
        {
            get
            {
                return this.gsmOwner;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(gsmOwner))
                {
                    throw new ArgumentException("Incorrect gsm owner!");
                }
                this.gsmOwner = value;
            }
        }

        // Methods
        public override string ToString()
        {
            var toString = new StringBuilder();
            toString.AppendLine("GSM:");
            toString.AppendFormat("manufacturer - {0}\n", gsmManifacturer);
            toString.AppendFormat("model - {0}\n", gsmModel);
            toString.AppendFormat("price - {0}\n", gsmPrice);
            toString.AppendFormat("owner - {0}\n", gsmOwner);
            toString.AppendFormat("{0}\n", gsmBattery);
            toString.AppendFormat("{0}", gsmDisplay);

            return toString.ToString().Trim();
        }

        public void AddCall(Call newCall)
        {
            this.callHistory.Add(newCall);
        }

        public void DeleteCall(Call call)
        {
            this.callHistory.Remove(call);
        }

        public void ClearCallHistory()
        {
            this.callHistory.Clear();
            Console.WriteLine("Call history cleared!");
        }

        public double TotalPriceOfCalls(double pricePerMinute)
        {
            double price = 0;
            foreach (var call in callHistory)
            {
                price += Math.Ceiling((double)call.Duration / 60) * pricePerMinute;
            }
            return price;
        }
    }
}
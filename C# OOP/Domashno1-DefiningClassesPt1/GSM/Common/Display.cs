using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilePhone.Common
{
    public class Display
    {
        private int? displaySize = null;
        private int? displayNumOfColours = null;

        public Display()
        {
        }

        public Display(int displaySize, int displayNumOfColours)
        {
            this.displaySize = displaySize;
            this.displayNumOfColours = displayNumOfColours;
        }

        public int? DisplaySize
        {
            get
            {
                return this.displaySize;
            }
            set
            {
                if (displaySize < 0)
                {
                    throw new ArgumentException("Size cannot be negative!");
                }
                this.displaySize = value;
            }
        }
        public int? DisplayNumOfColours
        {
            get
            {
                return this.displayNumOfColours;
            }
            set
            {
                if (displayNumOfColours < 0)
                {
                    throw new ArgumentException("Number of colours cannot be negative!");
                }
                this.displayNumOfColours = value;
            }
        }

        public override string ToString()
        {
            var toString = new StringBuilder();
            toString.AppendLine("Display:");
            toString.AppendFormat("size - {0}\n", DisplaySize);
            toString.AppendFormat("number of colours - {0}", DisplayNumOfColours);

            return toString.ToString().Trim();
        }
    }
}
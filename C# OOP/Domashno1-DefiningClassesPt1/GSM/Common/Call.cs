using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilePhone.Common
{
    public class Call
    {
        private DateTime callDate;
        private int duration = 0;
        private string dialedNum = null;

        public Call(string number, DateTime callDate, int duration)
        {
            this.dialedNum = number;
            this.callDate = callDate;
            this.duration = duration;
        }

        public Call()
        {
        }

        public DateTime CallDate
        {
            get
            {
                return this.callDate;
            }
            set
            {
                this.callDate = value;
            }
        }

        public int Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                this.duration = value;
            }
        }

        public string DialedNum
        {
            get
            {
                return this.dialedNum;
            }
            set
            {
                this.dialedNum = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Phone-{0}, Call date-{1}, Duration-{2}s", this.DialedNum, this.CallDate.ToShortDateString(), this.Duration);
        }
    }
}
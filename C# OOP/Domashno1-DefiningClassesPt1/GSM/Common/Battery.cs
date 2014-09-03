using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilePhone.Common
{
    public enum AssignType : byte
    {
        missing,
        Li_Ion,
        NiMH,
        NiCd
    };

    public class Battery
    {
        private AssignType batteryType;
        private string batteryModel = null;
        private int? idleHours = null;
        private int? talkHours = null;

        public AssignType BatteryType
        {
            get
            {
                return batteryType;
            }
            set
            {
                batteryType = value;
            }
        }

        public Battery(string batteryModel)
        {
            this.batteryModel = batteryModel;
        }

        public Battery(string batteryModel, int idleHours, int talkHours)
        {
            this.batteryModel = batteryModel;
            this.idleHours = idleHours;
            this.talkHours = talkHours;
        }

        public string BatteryModel  // Mandatory
        {
            get
            {
                return this.batteryModel;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(batteryModel))
                {
                    throw new ArgumentException("Incorrect battery model!");
                }
                this.batteryModel = value;
            }
        }

        public int? IdleHours
        {
            get
            {
                return this.idleHours;
            }
            set
            {
                if (idleHours < 0)
                {
                    throw new ArgumentException("Hours cannot be negative!");
                }
                this.idleHours = value;
            }
        }

        public int? TalkHours
        {
            get
            {
                return this.talkHours;
            }
            set
            {
                if (talkHours < 0)
                {
                    throw new ArgumentException("Hours cannot be negative!");
                }
                this.talkHours = value;
            }
        }

        public override string ToString()
        {
            var toString = new StringBuilder();
            toString.AppendLine("Battery:");
            toString.AppendFormat("model - {0}\n", BatteryModel);
            toString.AppendFormat("type - {0}\n", batteryType);
            toString.AppendFormat("idel hours - {0}\n", IdleHours);
            toString.AppendFormat("talk hours - {0}", TalkHours);
            return toString.ToString().Trim();
        }
    }
}
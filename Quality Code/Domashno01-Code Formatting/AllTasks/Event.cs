namespace AllTasks
{
    using System;
    using System.Text;

    public class Event : IComparable
    {
        private DateTime date;
        private string title;
        private string location;

        public Event(DateTime date, string title, string location)
        {
            this.date = date;
            this.title = title;
            this.location = location;
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }

            private set
            {
                this.date = value;
            }
        }

        public string Title
        {
            get
            {
                return this.title;
            }

            private set
            {
                this.title = value;
            }
        }

        public string Location
        {
            get
            {
                return this.location;
            }

            private set
            {
                this.location = value;
            }
        }

        public int CompareTo(object otherObject)
        {
            Event otherEvent = otherObject as Event;

            if (this == null)
            {
                if (otherEvent == null)
                {
                    return 0; 
                }
                else
                {
                    return -1;
                }
            }
            else if (otherEvent == null)
            {
                return 1;
            }
            else
            {
                int byDate = this.Date.CompareTo(otherEvent.Date);
                int byTitle = this.Title.CompareTo(otherEvent.Title);
                int byLocation = this.Location.CompareTo(otherEvent.Location);
                if (byDate == 0)
                {
                    if (byTitle == 0)
                    {
                        return byLocation;
                    }
                    else
                    {
                        return byTitle;
                    }
                }
                else
                {
                    return byDate;
                }
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(this.date.ToString("yyyy-MM-ddTHH:mm:ss"));
            stringBuilder.Append(" | " + this.title);
            if (this.location != null && this.location != string.Empty)
            {
                stringBuilder.Append(" | " + this.location);
            }

            return stringBuilder.ToString();
        }
    }
}
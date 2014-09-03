using System;

namespace Task11_LinkedListImplementation
{
    class LinkedListImplementation<T>
    {
        private ListItem<T> firstElement;

        public ListItem<T> FirstElement
        {
            get
            {
                return this.firstElement;
            }
            set
            {
                this.firstElement = value;
            }
        }

        public LinkedListImplementation()
        {
            this.FirstElement = null;
        }

        public void AddAfter(ListItem<T> item, T value)
        {
            ListItem<T> next = this.FirstElement;

            while (next.NextItem != item)
            {
                next = next.NextItem;
            }

            next = next.NextItem;

            ListItem<T> newItem = new ListItem<T>(value);
            newItem.NextItem = next.NextItem;
            next.NextItem = newItem;
        }

        public void AddBefore(ListItem<T> item, T value)
        {
            if (this.FirstElement == item)
            {
                ListItem<T> newItem = new ListItem<T>(value);
                newItem.NextItem = this.FirstElement;
                this.FirstElement = newItem;
            }
            else
            {
                ListItem<T> next = this.FirstElement;

                while (next.NextItem != item)
                {
                    next = next.NextItem;
                }

                ListItem<T> newItem = new ListItem<T>(value);
                newItem.NextItem = next.NextItem;
                next.NextItem = newItem;
            }
        }
        public void AddFirst(T value)
        {
            if (this.FirstElement == null)
            {
                this.FirstElement = new ListItem<T>(value);
            }
            else
            {
                ListItem<T> newFirstElement = new ListItem<T>(value);
                newFirstElement.NextItem = this.FirstElement;
                this.FirstElement = newFirstElement;
            }
        }
        public void AddLast(T value)
        {
            if (this.FirstElement == null)
            {
                this.FirstElement = new ListItem<T>(value);
            }
            else
            {
                ListItem<T> next = this.FirstElement;

                while (next.NextItem != null)
                {
                    next = next.NextItem;
                }

                next.NextItem = new ListItem<T>(value);
            }
        }
        public void RemoveFirst()
        {
            this.FirstElement = this.FirstElement.NextItem;
        }
        public void RemoveLast()
        {
            ListItem<T> next = this.FirstElement;

            while (next.NextItem.NextItem != null)
            {
                next = next.NextItem;
            }

            next.NextItem = null;
        }

        public int Count
        {
            get
            {
                int count;
                if (this.FirstElement == null)
                {
                    count = 0;
                }
                else
                {
                    count = 1;
                    ListItem<T> next = this.FirstElement;

                    while (next.NextItem != null)
                    {
                        next = next.NextItem;
                        count++;
                    }

                }

                return count;
            }
            private set { }
        }
    }
}

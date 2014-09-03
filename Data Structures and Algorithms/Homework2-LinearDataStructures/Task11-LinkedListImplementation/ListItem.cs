﻿using System;

namespace Task11_LinkedListImplementation
{
    class ListItem<T>
    {
        private T value;

        private ListItem<T> nextItem = null;

        public T Value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = value;
            }
        }

        public ListItem<T> NextItem
        {
            get
            {
                return this.nextItem;
            }
            set
            {
                this.nextItem = value;
            }
        }

        public ListItem(T value, ListItem<T> nextItem = null)
        {
            this.Value = value;
            this.NextItem = nextItem;
        }
    }
}

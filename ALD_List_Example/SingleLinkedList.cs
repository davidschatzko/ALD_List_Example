using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALD_List_Example
{
    class SingleLinkedList<T> : IList
    {

        ListElement<T> First;
        ListElement<T> Last;
        int Count = 0;


        private class ListElement<T1>
        {
            T1 Content;
            public ListElement<T1> Next;

            public ListElement(T1 content, ListElement<T1> next)
            {
                Content = content;
                Next = next;
            }
        }

        public SingleLinkedList()
        {

        }


        public void PrintSingleList()
        {

        }

        public object this[int index] { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

        public bool IsReadOnly => throw new NotImplementedException();

        public int Add(object value)
        {
            if (First == null)
            {
                First = new ListElement<T>((T)value, null);
                Last = First;
            }
            else
            {
                Last.Next = new ListElement<T>((T)value, null);
                Last = Last.Next;
            }

            return ++Count;
        }

        public bool Contains(object value)
        {
            throw new NotImplementedException();
        }
    }
}

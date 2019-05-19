using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretAgent
{

    class MyUniqueList
    {
        List<int> list = new List<int>();

        public MyUniqueList()
        {
         
        }

        public bool Add(int item)
        {
            if (!list.Contains(item))
            {
                list.Add(item);
                return true;
            }

            if(list.Contains(item))
            {
                throw new ItemAlreadyExsistsException();
            }

            return false;
        }

        public bool Remove(int item)
        {
            if (list.Contains(item))
            {
                list.Remove(item);
                return true;
            }
            if(!list.Contains(item))
            {
                throw new ItemNotFoundException();
            }
            return false;
        }

        public int Peek(int index)
        {
            if(index > list.Count)
            {
                throw new IndexOutOfRangeException();
            }

            return list[index];

        }

        public int this[int index]
        {
            get
            {
                return this.list[index];
            }
            set
            {
                if (list[index] == value)
                    return;
                if (list.Contains(value))
                    return;
                list[index] = value;
            }
        }
    }
}
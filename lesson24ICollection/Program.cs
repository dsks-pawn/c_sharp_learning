using System;
using System.Collections;
using System.Collections.Generic;

namespace lesson24ICollection
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] arr = new object[4];
            arr[0] = "dsa";
            arr[1] = 3;
            arr[2] = "g";
            arr[3] = "Geeks";
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }


            MyArrayList testArr = new MyArrayList();
            MyArrayList testArr2 = new MyArrayList(5);
            MyArrayList testArr3 = new MyArrayList(arr);
            foreach (object item in testArr3)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }

    public class MyArrayList : ICollection
    {
        private object[] lstObj; // mảng giá trị
        private int count; // số lượng phần tử
        private const int MAXCOUNT = 100; // số lượng phần tử tối đa

        public MyArrayList()
        {
            Count = -1;
            lstObj = new object[MAXCOUNT];
        }

        public MyArrayList(int count)
        {
            Count = count;
            lstObj = new object[count];
        }

        public MyArrayList(Array array)
        {
            array.CopyTo(lstObj, 0);
            Count = array.Length;
        }

        public void CopyTo(Array array, int index)
        {
            // thực hiện copy các phần tử trong lstObj từ vị trí index đến cuối sang mảng array.
            lstObj.CopyTo(array, index);
        }

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        public bool IsSynchronized
        {
            get { throw new NotImplementedException(); }
        }

        public object SyncRoot
        {
            get { throw new NotImplementedException(); }
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

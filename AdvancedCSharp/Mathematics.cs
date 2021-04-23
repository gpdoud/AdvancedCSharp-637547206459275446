using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedCSharp {

    public class Mathematics<T> {

        T[] collection = new T[10];
        int NbrOfItems = 0;

        public void Add(T item) {
            if (NbrOfItems >= collection.Length) {
                collection = new T[20];
                return;
            }
            collection[NbrOfItems] = item;
            NbrOfItems++;
        }
    }
}

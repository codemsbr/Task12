using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    internal class Gallery
    {
        public string Name { get; set; }
        static Cars[] myArray;

        public static Cars[] GetmyArray => myArray;

        public Gallery()
        {
            myArray = new Cars[0];
        }

        public Cars this[int index]
        {
            get {

                if (myArray.Length > index)
                    return myArray[index];
                return null;
            }
            set
            {
                if (myArray.Length > index)
                    myArray[index] = value;
            }
        }

        public bool this[string name]
        {
            get
            {
                if(myArray.Length > 0)
                    foreach (Cars myItem in myArray)
                    {
                        if (myItem.Name == name)
                            return true;
                    }
                return false;
            }
        }

        public void CarAdd(Cars car)
        {
            Array.Resize(ref myArray, myArray.Length + 1);
            myArray[myArray.Length - 1] = car;
        }

    }
}

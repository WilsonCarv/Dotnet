using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace concepts_review.ArraysReview
{
    public static class ArraysReview
    {
        public static void PrintArrayList()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Hello");
            arrayList.Add("World");
            Console.WriteLine("ArrayList: {0}", string.Join(", ", arrayList));
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}

using System.Collections;

namespace concepts_review.ArraysReview
{
    public static class ArraysReview
    {
        public static void PrintArrayList()
        {
            ArrayList arrayList = ["Hello", "World"];
            Console.WriteLine("ArrayList: {0}", string.Join(", ", arrayList));
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}

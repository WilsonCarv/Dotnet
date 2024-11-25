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
        public static void PrintList()
        {
            List<int> numbers = new List<int>() { 1, 2, 3,4,5,6,7,8,9};

            var evenNumbers = from number in numbers  where number % 2 == 0 select number;
            evenNumbers.GroupBy(x => x).Select(x=> x.Key).ToList().ForEach(x => Console.WriteLine(x));
            foreach(var number in evenNumbers)
            {
                Console.WriteLine(number);
            }
             Console.ReadKey();
        }
        public static void PrintMultiDimensionalArray()
        {
            int[,] array2D = new int[,]
            {
                {11, 12, 13 },
                {21, 22, 23 },
                {31, 32, 33 }
            };
            int rowLength = array2D.GetLength(0);
            int colLength = array2D.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
               
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(array2D[i,j] + " ");
                }
                Console.Write(Environment.NewLine + Environment.NewLine);

            }
        }
    }
}

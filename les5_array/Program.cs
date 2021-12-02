using System;

namespace les5_array
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            //1-usul
            int[] numbers1 = { 5, 6, 7, 8 };

            //2-usul
            var numbers2 = new int[] {1, 2, 3, 4};

            //3-usul
            int[] numbers3;
            numbers3 = new int[] {3, 4, 5, 6};

            //4-usul
            int[] numbers4 = new int[4];

            for(int i = 0; i < numbers4.Length; i++)
            {
                Console.WriteLine(numbers4[i]);
            }

            string[] texts = new string[3];

            for (int j = 0; j < texts.Length; j++)
            {
                Console.WriteLine(texts[j]);
            }

            /*********************************************************************************************************************/
            Console.WriteLine("Hello world!");

            int[] newNumbers = { 5, 2, 6, 1, 7, 9 };

            /*
            Array.Sort(newNumbers);
            for (int k = 0; k < newNumbers.Length; k++)
            {
                Console.Write(newNumbers[k]);
            }
            */

            Console.WriteLine(Array.IndexOf(newNumbers, 1));

            int firstHeght = Array.Find(newNumbers, heihgt => heihgt > 1);
            Console.WriteLine(firstHeght);

            /*
            Array.Reverse(newNumbers);
            Console.WriteLine(newNumbers);
            for (int k = 0; k < newNumbers.Length; k++)
            {
                Console.Write(newNumbers[k]);
            }
            */

            var newNumbersCopy = new string[newNumbers.Length];
            Array.Copy(newNumbers, newNumbersCopy, newNumbers.Length);

            for (int l = 0; l < newNumbersCopy.Length; l++)
            {
                Console.WriteLine(newNumbersCopy[l]);
            }


        }
    }
}

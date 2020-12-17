using System;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sum = new int[5];
            int[] mass1 = new int[5];
            int[] mass2 = new int[5];
            Generationmass();
            summass();
            void Generationmass()
            {
                Random rnd = new Random();
                for (int i = 0; i < mass1.Length; i++)
                {
                    mass1[i] = rnd.Next(1, 10);
                    mass2[i] = rnd.Next(1, 10);

                }

            }
            void summass()
            {

                for (int i = 0; i < mass1.Length; i++)
                {
                    sum[i] = mass1[i] + mass2[i];

                }


            }
            int buffer;
            for (int i = 0; i < sum.Length; i++)
            {


                for (int j = 0; j < sum.Length - 1; j++)
                {
                    if (sum[j] > sum[j + 1])
                    {
                        buffer = sum[j];
                        sum[j] = sum[j + 1];
                        sum[j + 1] = buffer;

                    }

                }

            }
            for (int i = 0; i < sum.Length; i++)
            {
                Console.WriteLine(sum[i]);
            }

        }



    }
}

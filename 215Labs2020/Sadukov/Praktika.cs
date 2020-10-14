using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Sadukov
{
    class Praktika
    {
        public string name;
        private int raiting;
        public int Raiting
        {
            get
            { return raiting; }  
            set
            {if(value > 5)
                { raiting = 5; }
            else if(value < 2)
                { raiting = 2; }
            else { raiting = value;}
            }
            

        }
        public static void Data()
        {
            Praktika[] a = new Praktika[5];
            Praktika[] ball = new Praktika[4];
            for (int i = 0; i < a.Length; i++)
            {

                a[i] = new Praktika();

            }
            for (int i = 0; i < ball.Length; i++)
            {

                ball[i] = new Praktika();

            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Student");
                a[i].name = Console.ReadLine();
                Console.WriteLine("первый предмет");
                ball[0].Raiting = int.Parse(Console.ReadLine());
                Console.WriteLine("второй предмет");
                ball[1].Raiting = int.Parse(Console.ReadLine());
                Console.WriteLine("третий предмет");
                ball[2].Raiting = int.Parse(Console.ReadLine());
                Console.WriteLine("четвертый предмет");
                ball[3].Raiting = int.Parse(Console.ReadLine());
                Console.WriteLine($"{a[i].name}    {ball[0].Raiting}    {ball[1].Raiting}    {ball[2].Raiting}   {ball[3].Raiting}");

            }

       }    
    }
}

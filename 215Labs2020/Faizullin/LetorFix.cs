//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace _215Labs2020.Faizullin
//{
//    class LetorFix
//    {
//        private string name;
//        private int inf;
//        private int programmy;
//        private int math;
//        public string Name
//        {
//            get
//            {
//                return name;
//            }
//            set
//            {
//                name = value;
//            }
//        }
//        public int Inf
//        {
//            get
//            {
//                return inf;
//            }
//            set
//            {
//                if (value >= 6) value = 5;
//                if (value < 2) value = 2;
//                if (value <= 5) inf = value;
//                if (value >= 2) inf = value;
//            }
//        }
//        public int Programmy
//        {
//            get
//            {
//                return programmy;
//            }
//            set
//            {
//                if (value >= 6) value = 5;
//                if (value < 2) value = 2;
//                if (value <= 5) programmy = value;
//                if (value >= 2) programmy = value;
//            }
//        }
//        public int Math
//        {
//            get
//            {
//                return math;
//            }
//            set
//            {
//                if (value >= 6) value = 5;
//                if (value < 2) value = 2;
//                if (value <= 5) math = value;
//                if (value >= 2) math = value;
//            }
//        }
//        static void Main(string[] args)
//        {
//            int a = int.Parse(Console.ReadLine());
//            Console.WriteLine("Enter number student");
//            double score = 0;
//            LetorFix[] marcs = new LetorFix[a];
//            for (int i = 0; i < marcs.Length; i++)
//            {
//                marcs[i] = new LetorFix();
//            }
//            for (int i = 0; i < marcs.Length; i++)
//            {
//                if (i < a + 1) Console.WriteLine("Enter student name");


//                if (i < a + 1) marcs[i].Name = Console.ReadLine();


//                if (i < a + 1) Console.WriteLine("Enter inf mark");


//                if (i < a + 1) marcs[i].inf = int.Parse(Console.ReadLine());


//                if (i < a + 1) Console.WriteLine("Enter programmy mark");


//                if (i < a + 1) marcs[i].programmy = int.Parse(Console.ReadLine());


//                if (i < a + 1) Console.WriteLine("Enter math mark");


//                if (i < a + 1) marcs[i].math = int.Parse(Console.ReadLine());
//            }
//            Console.WriteLine("Enter sr Ball");
//            double ball = double.Parse(Console.ReadLine());
//            for (int i = 0; i < marcs.Length; i++)
//            {
//                if (i < a + 1) score = marcs[i].inf + marcs[i].programmy + marcs[i].math;
//                if (i < a + 1) score = a / 3;
//                if (ball <= score)
//                    Console.WriteLine($"{marcs[i].Name} {score}");
//            }
//        }
//    }
//}

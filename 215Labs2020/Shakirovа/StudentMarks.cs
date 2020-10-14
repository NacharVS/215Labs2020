using System;


namespace _215Labs2020.Shakirovа
{
    class StudentMarks
    {
        public string Surname;
        private int Math;
        private int Rus;
        private int Eng;

        public int _Math
        {
            get
            {
                return Math;
            }
            set
            {
                if (value <= 2)
                {
                    Math = 2;
                }
                if (value >= 5)
                {
                    Math = 5;
                }
                else Math = value;
            }
        }
       
        public int _Rus
        {
            get
            {
                return Rus;
            }
            set
            {
                if (value <= 2)
                {
                    Rus = 2;
                }
                if (value >= 5)
                {
                    Rus = 5;
                }
                else Rus = value;

            }
        }

        public int _Eng
        {
            get
            {
                return Eng;
                 
            }
            set
            {
                if (value <= 2)
                {
                    Eng = 2;
                }
                if (value >= 5)
                {
                    Eng = 5;
                }
                else Eng = value;

            }
        }
    }
}

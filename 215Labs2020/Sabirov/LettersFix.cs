using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Sabirov
{
    class LettersFix
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                
                string a = value[0].ToString();
              
                    if (a != a.ToUpper())
                    {
                    string v = value[0].ToString().ToUpper();
                    name = v;

                }
                    else name = value; 
            }
        }
     public static void imya()
        {
            LettersFix[] names = new LettersFix[3];
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = new LettersFix();
            }
            for (int i = 0; i < names.Length; i++)
            {
                names[i].name = Console.ReadLine();
                Console.WriteLine(names[i].Name);
            }


           
            
        }  
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Shakirovа.delegates
{
    class Branch
    {
        public delegate void Handler(int[] array, int[] array2);

        public void Invoke(int[] array)
        {
            Handler handler = General.max;
            handler += General.max;
            handler += General.summ;

        }
    }
}

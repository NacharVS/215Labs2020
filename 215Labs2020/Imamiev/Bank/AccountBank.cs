using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Imamiev
{
    class AccountBank
    {
        public delegate void AccountHandler(string message);
        private event AccountHandler Notify;
        public AccountBank(int sum)
        {
            Sum = sum;
        }
        public int Sum { get; private set; }
        public void Put(int sum)
        {
            Sum += sum;
            Notify?.Invoke($"The account received:{sum}");
        }
        public void Take(int sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
                Notify?.Invoke($"Withdrawn from the account; {sum}");
            }
            else
            {
                Notify?.Invoke($"Not enough money.Wthe current balance:{Sum}");
            }
        }
    }
}

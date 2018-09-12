using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4
{
    class Money
    {
        int _nominal;
        int _amount;
        int _product;
        int Summa = 0;

        public Money(int nominal, int amount)
        {
            _nominal = nominal;
            _amount = amount;
        }

        public void showMoney()
        {
            Console.WriteLine(string.Format($"Номинал купюр:= { _nominal},Количество купюр:={ _amount}"));
            Console.WriteLine(string.Format($"Общая сумма:={_nominal * _amount}"));
        }

        public void SetSumma(int nominal, int amount)
        {
            _nominal = nominal;
            _amount = amount;
        }
        public int GetSumma()
        {

            Summa = _nominal * _amount;
            return Summa;
        }
        public void SetProduct(int product)
        {
            _product = product;
        }

        public int GetProduct()
        {
            return _product;
        }

        public void Purchase()
        {
            int Summa = _amount * _nominal;
            if (Summa < _product)
            {
                Console.WriteLine("У вас не хватить денежных средств на этот товар");
            }
            else
            {
                Console.WriteLine("У вас хватить денежных средств на этот товар");
            }

        }


        public int CountProduct()
        {
            int count = 0;
            int Summa = _amount * _nominal;
            while (Summa >= _product)
            {
                Summa -= _product;
                count++;
            }
            return count;
        }


    }
}

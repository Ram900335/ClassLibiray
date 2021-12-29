using System;

namespace Classlibray
{
    public class Class1
    {
        String[,] _Inventory;

        int _count;

        public int count
        {
            get{return _count;}
            set{_count = value;}
        }

        public Class1()
        {
            _Inventory = new string[,]
            {{"Title","1"}
            ,{"Author(s)","2"}
            ,{"Isbn","3"}
            ,{"Number of copies available","4"}
            ,{"Selling price in rupees","5"}
            ,{"Cost price in rupees","6"}
            ,{"Discount","7"}
            ,{"Seller Name","8"}
            };
        }


        public void AddBook(string name)
        {
            _Inventory[count,count] = name;
            count++;
        }

        public void OnDiscount()
        {
            for(int i = 0; i < _Inventory.Length; i++)
            {
                for(int j = 0; j < _Inventory.Length; j++)
                {
                    if(_Inventory[i,j] == "Discount")
                    {
                        System.Console.WriteLine(_Inventory[i,j]);
                    }
                }
            }
        }

        public void Print()
        {
            for(int i = 0; i < _Inventory.GetLength(0); i++)
            {
                for(int j = 0 ; j < _Inventory.GetLength(1); j++)
                {
                    System.Console.WriteLine(_Inventory[i,j]);
                }
            }
        }
    }
}

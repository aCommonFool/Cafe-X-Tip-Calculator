using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_X_Tip_Calculator
{
    public class BillCalculator
    {
        public const string COLA = "Cola";
        public const float COLA_PRICE = 0.5F;

        public const string COFFEE = "Coffee";
        public const float COFFEE_PRICE = 1.0F;

        public const string CHEESE = "Cheese Sandwich";
        public const float CHEESE_PRICE = 2.0F;

        public const string STEAK = "Steak Sandwich";
        public const float STEAK_PRICE = 4.5F;

        public float Calculate(List<String> a_Bill)
        {
            float l_Total = 0.0F;

            foreach (string l_Item in a_Bill)
            {
                switch(l_Item)
                {
                    case COLA:
                        l_Total += COLA_PRICE;
                        break;

                    case COFFEE:
                        l_Total += COFFEE_PRICE;
                        break;

                    case CHEESE:
                        l_Total += CHEESE_PRICE;
                        break;

                    case STEAK:
                        l_Total += STEAK_PRICE;
                        break;
                }
            }

            return l_Total;
        }
    }
}

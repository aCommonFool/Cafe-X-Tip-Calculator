using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_X_Tip_Calculator
{
    public class BillCalculator
    {
        const string COLA = "Cola";
        const double COLA_PRICE = 0.5;

        const string COFFEE = "Coffee";
        const double COFFEE_PRICE = 1.0;

        const string CHEESE = "Cheese Sandwich";
        const double CHEESE_PRICE = 2.0;

        const string STEAK = "Steak Sandwich";
        const double STEAK_PRICE = 4.5;

        const int HOT_FOOD_CHARGE = 20;
        const int FOOD_CHARGE = 10;

        bool m_HasFood = false;
        bool m_HasHotFood = false;

        // Calculates Bill
        public double Calculate(List<String> a_Bill)
        {
            double l_Total = 0.0;
            
            foreach (string l_Item in a_Bill)
            {
                switch(l_Item)
                {
                    case COLA:
                        l_Total += COLA_PRICE;
                        continue;

                    case COFFEE:
                        l_Total += COFFEE_PRICE;
                        continue;

                    case CHEESE:
                        l_Total += CHEESE_PRICE;
                        m_HasFood = true;
                        continue;

                    case STEAK:
                        l_Total += STEAK_PRICE;
                        m_HasHotFood = true;
                        continue;
                }
            }

            return AddServiceCharge(l_Total);
        }

        // Adds appropriate service charge
        private double AddServiceCharge(double a_Total)
        {
            if(m_HasHotFood)
            {
                AddPecentage(ref a_Total, HOT_FOOD_CHARGE);
            } 
            else if (m_HasFood)
            {
                AddPecentage(ref a_Total, FOOD_CHARGE);
            }

            //Round to two decimal places
            return Math.Round(a_Total, 2);
        }

        // Increases a_Value by % a_Percent
        private void AddPecentage(ref double a_Value, int a_Percent)
        {
            a_Value += ( (a_Value / 100) * a_Percent );
        }
    }
}

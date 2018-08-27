using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChangeCalculator
{
    class ChangeDollars
    {
        public static string Change(decimal Amount)
        {
            decimal result = Amount * 100;
            string Change="";
            List<KeyValuePair<string, int>> list = new List<KeyValuePair<string, int>>();
            foreach (int i in Enum.GetValues(typeof(Currency)))
            {
                string name = Enum.GetName(typeof(Currency), i);
                list.Add(new KeyValuePair<string, int>(name, i));
            }
            var CurrList = list.OrderByDescending(o => o.Value).ToList();
            int Qty = 0;
            while (result > 0)
            {
                foreach (var c in CurrList)
                {
                    Qty = 0;
                    while (result >= c.Value)
                    {
                        Qty++;
                        result = result - c.Value;
                    }
                    if (Qty != 0)
                    {
                        Change += Qty.ToString() + " " + c.Key.ToString().Substring(4, c.Key.ToString().Length - 4).Replace("_"," ") + "\r\n";
                    }
                }
            }
            return Change;
        }
        
    }

    public enum Currency
    {
        BILL100_Dollar_Bill = 10000,
        Bill50_Dollar_Bill = 5000,
        Bill20_Dollar_Bill = 2000,
        Bill10_Dollar_Bill = 1000,
        Bill5_Dollar_Bill = 500,
        Bill1_Dollar_Bill = 100,
        Centquarters = 25,
        Centdimes = 10,
        Centnickels = 5,
        Centpennies = 1
    }
    
}

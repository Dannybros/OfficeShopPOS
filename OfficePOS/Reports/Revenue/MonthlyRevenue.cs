using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficePOS
{
    public class MonthlyRevenue
    {
        public string Month { get; set; }
        public double Revenue { get; set; }
        public double Expenditure { get; set; }
        public double Profit { get; set; }

        public MonthlyRevenue(string month, double revenue, double expenditure)
        {
            Month = month;
            Revenue = revenue;
            Expenditure = expenditure;
            Profit = revenue - expenditure;
        }
    }
}

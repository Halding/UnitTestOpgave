using System;
using System.IO;

namespace UnitTestOpgave
{
    public class Price : IPrice
    {
        private readonly double startFee = 130;
        private readonly double under100km = 3.20;
        private readonly double inbetween100To500below12 = 2.75;
        private readonly double inbetween100To500NotBelow12 = 3.00;
        private readonly double over500 = 2.25;
        private double _totalprice = 0;


        public double TotalPrice(int noPassenger, double km)
        {
            if (noPassenger < 0) throw new Exception();
            
            if (km < 100)
            {
                Under100(km);
            }
            if (km > 100 && km < 500 && noPassenger < 12)
            {
                InBetween100To500Below12(noPassenger, km);
            }

            if (km > 100 && km < 500 && noPassenger >= 12)
            {
                InBetween100To500Not12(noPassenger, km);
            }

            if (km > 500)
            {
                Over500(km);
            }

            return _totalprice;

        }

        public double Under100(double km)
        {
            return _totalprice = km * under100km + startFee;
        }

        public double InBetween100To500Below12(int noPassenger, double km)
        {
            return _totalprice = startFee + (inbetween100To500below12 * km);
        }

        public double InBetween100To500Not12(int noPassenger, double km)
        {
            return _totalprice = startFee + (inbetween100To500NotBelow12 * km);
        }

        public double Over500(double km)
        {
            return _totalprice = startFee + (over500 * km);
        }
        
        
    }
}
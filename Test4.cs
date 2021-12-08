using System;

namespace Test
{
    public class Test4
    {
        public String GetTotalMetersBetweenTwoPoints(Point point1, Point point2)
        {
            var R = 6378137; // Earth’s radius in meter
            var dLat = rad(point2.Latitude - point1.Latitude);
            var dLong = rad(point2.Longitude - point1.Longitude);
            var a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                Math.Cos(rad(point1.Latitude)) * Math.Cos(rad(point2.Latitude)) *
                Math.Sin(dLong / 2) * Math.Sin(dLong / 2);
            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            var d = R * c;
            return $"{d} m";
        }
        private double rad(double x) => x * Math.PI / 180;
    }


    public class Point 
    {
        public double Latitude { get; set; }

        public double Longitude { get; set; }
    }
}
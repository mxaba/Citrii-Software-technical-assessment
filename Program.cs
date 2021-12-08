using System;

namespace Test
{
    class Program
    {
        /*
        Test 1 
        Fix the code for Test1
        Expected output 
                    #
                   ##
                  ###
                 ####
                #####

        Test 2

        Improve the algorithm for test 1
        Show execution times

        Test 3 Expected output 
        Validate if a sentence is a palindrome
            Eg.    step on no pets
                   Hi my name is Bob

        Test 4 Expected output 
        The total meters between two latitude and longitude points
            Eg.    point 1 =  -33.93758083398224, 18.85560933777421 
                   point 2 =  -34.101290896639355, 18.853087865159306
                   Result  = 18204.335806567509 m

        */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Test1.staircase(60);
            // Test1Improved.improvedTest1(6);
            // Test3.palindrome("Hi my name is Bob");
            var result = new Test4();
            var point1 = new Point();
            // point1(-33.93758083398224, 18.85560933777421);

            var result2 =result.GetTotalMetersBetweenTwoPoints(new Point{Latitude =-33.93758083398224, Longitude=18.85560933777421}, new Point{Latitude =-34.101290896639355, Longitude=18.853087865159306});
            Console.WriteLine(result2);
        }
    }
}

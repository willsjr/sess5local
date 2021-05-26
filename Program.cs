using System;

namespace session_5
{
    class Program
    {
        static double planet_age = 0;
        static double earth_age;
        static double earth_sec = 31557600;
        static double space_sec = 631154000;

        static void Main(string[] args)
        {           
            
            
            Program.GetEarthAge(space_sec,earth_sec);
            Program.GetPlanetAge(earth_age);

            
        }
        public static double GetEarthAge(double space_sec, double earth_sec)
        {
            earth_age = Convert.ToDouble(space_sec/earth_sec);
            Console.WriteLine("Earth age: " + Math.Round(earth_age,3));
            return earth_age;
        }
        
        public static double GetPlanetAge(double earth_age)
        {
            string [] planet = new string [4];
            planet [0] = "Mercury";
            planet [1] = "Mars";
            planet [2] = "Saturn";
            planet [3] = "Uranus";
            
            double [] planet_years = new double [4];
            planet_years [0] = 0.2408467;
            planet_years [1] = 1.8808158;
            planet_years [2] = 29.447498;
            planet_years [3] = 84.016846;
                        
            for (int i = 0; i < planet.Length; i++)
            {
                double planet_age = Math.Round(earth_age/planet_years[i],3); 
                Console.WriteLine("Earth age: " + Math.Round(earth_age,3) + " Earth-years old- " + planet[i] + ": " + planet_age + " Earth-years old");
            }

            return planet_age;
        }

        
    }
}

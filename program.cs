using System;
namespace Myapplication
{
    class program
    {
        static int space_time=631154000;
        static int Earth_time=31557600;
        static float  Age1;
        static double Age2;      
        static void Main(string[] args)
        {
            program.Ageonearth( space_time, Earth_time);
            program.Ageonplanet(Age1);
        }
        public static  double Ageonearth(int space_time,int Earth_time)
        {
            Age1=space_time/Earth_time;
             Console.WriteLine("Earth Age:"+"\t"+ Age1+"  "+"years old");
            return Age1;
        }
        public static double Ageonplanet(double Age1)
        {
            string[] planets ={"Venus","Mars","Jupiter","Neptune"};
            float [] time = {0.61519726f,1.8808158f,11.862615f,164.79132f};
             for (int i = 0; i < planets.Length; i++)
            {
               Age2=Math.Round(Age1/time[i],2); 
               Console.WriteLine(planets[i] +"\t"+"age:"+"\t"+Age2+"  "+"years old" );
            }
            return Age2;
        }
    }
}
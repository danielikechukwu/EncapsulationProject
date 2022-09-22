using System;

namespace Circle_Area_Encapsuled

{
    class Circle_Area
    {

        public double Pi;

        public double Radius;

        public double GetArea()
        {
            return Pi * Math.Pow(Radius, 2);
        }

        public void Display()
        {

            Console.WriteLine(" Radius : {0}", Radius);

            Console.WriteLine(" Pi : {0}", Pi);

            Console.WriteLine(" Total : {0}", GetArea());

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle_Area area = new Circle_Area();

            area.Radius = 4.0;

            area.Pi = 1.141592654;

            area.Display();

            Console.ReadLine();
        }

    }

}
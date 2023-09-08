using System.Formats.Asn1;

namespace ClassLibrary
{
    abstract class Figure
    {
        string Name { get; }
        double Area { get; set; }
        double Lenght { get; set; }

        public abstract double MathArea();
        public abstract double MathLenght();

        public Figure( string name)
        {
            Name = name;
        }

        public Figure(string name, double area, double lenght)
        {
            Name = name;    
            Area = area;
            Lenght = lenght;
        }
    }

    class Triangle : Figure
    {
        double SideA { get; }
        double SideB { get; }
        double SideC { get; }


        public Triangle(string name) : base(name)
        {

        }

        public Triangle(string name, double a, double b, double c) 
            : base(name)
        {
            SideA = a;
            SideB = b;
            SideC = c;
        }

        public override double MathArea()
        { 
            double a = SideA;
            double b = SideB;
            double c = SideC;
            double p = (a+b+c)/2;

            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }

        public override double MathLenght() => SideA + SideB + SideC;
        
    }
}
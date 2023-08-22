using System.Formats.Asn1;

namespace ClassLibrary
{
    public class Figure
    {
        public double Area { get; set; }

        public double Lenght { get; set; }

        public Figure(double area, double lenght)
        {
            Area = area;
            Lenght = lenght;
        }
    }

    public class Triangle : Figure
    {
        public static double area;//площадь

        public static double lenght;//периметр

        public string TypeTriangle { get; set; }// тип периметра

        private string DefinitionType(int idType)
        {
            string typeTriangle = "";
                
            switch (idType)
            {
                case 1:
                    return typeTriangle = "right triangle";
                case 2:
                    return typeTriangle = "obtuse triangle";
                case 3:
                    return typeTriangle = "acute triangle";
            }
            return typeTriangle = "right triangle";
        }

        private double MathArea(double a, double h)
        {
            return area = h * a * 0.5;
        }

        private double MathLenght(double a, double b, double c)
        {
            return lenght = a+b+c;
        }

        public Triangle(int idType, double h,double a, double b, double c) 
            : base(area,lenght)
        {
            TypeTriangle = DefinitionType(idType);
        }
    }



}
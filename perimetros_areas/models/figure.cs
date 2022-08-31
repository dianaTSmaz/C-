using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TYPE OF DESIGN : COMPOSITE

namespace perimetros_areas.models
{
    //Parent class
    public abstract class Figure
    {
        //Constructors
        public decimal Side { get; set; }
        public decimal Height { get; set; }

        protected String _Name { get; set; }

        public decimal Radio { get; set; }

        //External constructor
        public decimal _Perimeter { get; set; }

        public decimal _Area { get; set; }


        //Abstract methods to calculate Perimeter and areas.
        public abstract decimal CalculatePerimeter();

        public abstract decimal CalculateArea();

        public abstract string PrintName();

        
       


        //Figure's son class to calculate Square area and perimeter.
        public class Square : Figure
        {
            public override string PrintName()
            {
                return _Name = "Square";
            }
            public override decimal CalculateArea()
            {
                _Area = Side * Side;
                return _Area;

            }

            public override decimal CalculatePerimeter()
            {
                _Perimeter = 4 * this.Side;
                return _Perimeter;
            }
        }


        //Figure's son class to calculate Rectangle area and perimeter.
        public class Rectangle : Figure
        {

            public override string PrintName()
            {
                return _Name = "Rectangle";
            }
            public override decimal CalculateArea()
            {
                _Area = Side * Height;
                return _Area;
            }

            public override decimal CalculatePerimeter()
            {
                _Perimeter = (2 * Side) + (2 * Height);
                return _Perimeter;
            }

        }
        //Figure's son class to calculate Triangle area and perimeter.
        public class Triangle : Figure
        {
            public override string PrintName()
            {
                return _Name = "Triangle";
            }
            public override decimal CalculateArea()
            {
                _Area = (Side * Height) / 2;
                return _Area;
            }
            public override decimal CalculatePerimeter()
            {
                _Perimeter = 3 * Side;
                return _Perimeter;
            }
        }

        //Figure's son class to calculate Circle area and perimeter.
        public class Circle : Figure
        {
            public override string PrintName()
            {
                return _Name = "Circle";
            }
            public override decimal CalculateArea()
            {
                _Area = ((decimal)(Math.PI)) * Radio * Radio;
                return _Area;
            }
            public override decimal CalculatePerimeter()
            {
                _Perimeter = ((decimal)(Math.PI)) * 2 * Radio;
                return _Perimeter;

            }

        }

       



    }
    /*public class Figura
    {
        public (decimal, decimal) CasesFigure(String UserInput)
        {

            switch (UserInput)
            {
                case "Square":

                    Figure.Square _Square = new Figure.Square();
                    Console.WriteLine("Type the length:");
                    _Square.Side = decimal.Parse(Console.ReadLine());
                    return (_Square._Area, _Square._Perimeter);
                    break;

                case "Triangle":
                    Figure.Triangle _Triangle = new Figure.Triangle();
                    Console.WriteLine("Type the lenght");
                    _Triangle.Side = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Type the height");
                    _Triangle.Height = decimal.Parse(Console.ReadLine());
                    return (_Triangle._Area, _Triangle._Perimeter);
                    break;

                case "Rectangle":
                    Figure _Rectangle = new Figure.Rectangle();
                    Console.WriteLine("Type the lenght: ");
                    _Rectangle.Side = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Type the height");
                    _Rectangle.Height = decimal.Parse(Console.ReadLine());
                    return (_Rectangle._Area, _Rectangle._Perimeter);
                    break;

                case "Circle":
                    Figure.Circle _Circle = new Figure.Circle();
                    Console.WriteLine("Type the radio: ");
                    _Circle.Radio = decimal.Parse(Console.ReadLine());
                    //Console.WriteLine("Perimeter: " + _Circle.CalculatePerimeter());
                    //Console.WriteLine("Area: " + _Circle.CalculateArea());
                    return (_Circle._Area, _Circle._Perimeter);
                    break;

                default:
                    Console.WriteLine("Type a correct option and try again!");
                    return (0, 0);
                    break;


            }


        }

    }*/
}


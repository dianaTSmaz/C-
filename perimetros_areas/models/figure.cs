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
      
        //Attributes
        public decimal  Side { get; set; }
        public decimal   Height { get; set; }

        protected String  _Name { get; set; }

        public decimal  Radio { get; set; }

        public static List<Figure> ShapeList = new List<Figure>();

        //External Attributes
        public decimal  _Perimeter { get; set; }

        public decimal   _Area { get; set; }

       


        //Abstract methods to calculate Perimeter and areas.
        public abstract  decimal  CalculatePerimeter();

        public abstract decimal   CalculateArea();

        public abstract string PrintName();


        //Figure's son class to calculate Square area and perimeter.
        public class  Square : Figure
        {
            public override string PrintName()
            {
                return _Name = "Square";
            }
            public override decimal  CalculateArea()
            {
                  _Area = Side * Side;
                 return (Math.Round(_Area,2));

            }

            public override decimal  CalculatePerimeter()
            {
                _Perimeter = 4 * this.Side;
                return (Math.Round(_Perimeter, 2));
            }

            
        }


        //Figure's son class to calculate Rectangle area and perimeter.
        public class Rectangle : Figure
        {

            public override string  PrintName()
            {
                return _Name = "Rectangle";
            }
            public override decimal   CalculateArea()
            {
                _Area = Side * Height;
                return (Math.Round(_Area, 2));
            }

            public override decimal  CalculatePerimeter()
            {
                _Perimeter = (2 * Side) + (2 * Height);
                return (Math.Round(_Perimeter, 2));
            }

        }
        //Figure's son class to calculate Triangle area and perimeter.
        public class Triangle : Figure
        {
            public override string PrintName()
            {
                return _Name = "Triangle";
            }
            public override decimal  CalculateArea()
            {
                _Area = (Side * Height) / 2;
                return (Math.Round(_Area, 2));
            }
            public override decimal  CalculatePerimeter()
            {
                _Perimeter = 3 * Side;
                return (Math.Round(_Perimeter, 2));
            }
        }

        //Figure's son class to calculate Circle area and perimeter.
        public class Circle : Figure
        {
            public override string PrintName()
            {
                return _Name = "Circle";
            }
            public override decimal  CalculateArea()
            {
                _Area = ((decimal)(Math.PI)) * Radio * Radio;
                return (Math.Round(_Area, 2));
            }
            public override decimal  CalculatePerimeter()
            {
                _Perimeter = ((decimal)(Math.PI)) * 2 * Radio;
                return (Math.Round(_Perimeter, 2));

            }

        }

       



    }

}


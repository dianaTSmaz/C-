
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perimetros_areas.models
{

   


    public class FigureProcess
    {

     

        public Figure CasesFigure(String UserInput)
        {


            switch (UserInput)

            {
                case "Square":
                    Figure.Square _Square = new Figure.Square();
                    Console.WriteLine("Type the lenght");
                    _Square.Side = decimal.Parse(Console.ReadLine());
                    return _Square;
                    break;

                case "Triangle":
                    Figure.Triangle _Triangle = new Figure.Triangle();
                    Console.WriteLine("Type the lenght");
                    _Triangle.Side = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Type the height");
                    _Triangle.Height = decimal.Parse(Console.ReadLine());
                    return _Triangle;
                    break;

                case "Rectangle":
                    Figure _Rectangle = new Figure.Rectangle();
                    Console.WriteLine("Type the lenght: ");
                    _Rectangle.Side = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Type the height");
                    _Rectangle.Height = decimal.Parse(Console.ReadLine());
                    return _Rectangle;
                    break;

                case "Circle":

                    Figure.Circle _Circle = new Figure.Circle();
                    Console.WriteLine("Type the radio: ");
                    _Circle.Radio = decimal.Parse(Console.ReadLine());
                    return _Circle;
                    break;

                default:
                    Console.WriteLine("Invalid Option");
                    //Maostrar nuevamente el menu
                  
                    return null;
                  
                    
                    break;
             }


                

        }  
        public static List<Figure> AddElementToList(Figure  figurita)
        { 
            
                Figure.ShapeList.Add(figurita);
                Console.WriteLine("Figuras en lista: " + Figure.ShapeList.Count);
                return Figure.ShapeList;



            
        }
          
        public static void PrintList(List<Figure> figuras)
        { 
            foreach(Figure item in figuras)
            {
                Console.WriteLine("Figure type is :  "+item.PrintName()+" its area is: "+ item.CalculateArea() + "and its perimeter is: " + item.CalculatePerimeter());
            }
        }




    }

    
}
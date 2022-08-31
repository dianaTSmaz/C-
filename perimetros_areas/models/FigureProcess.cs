
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perimetros_areas.models
{

    

    public class FigureProcess
    {

        protected List<Figure> FigurasList = new List<Figure>();
     

        public Figure CasesFigure(String UserInput)
        {

          
             switch (UserInput)

                {
                    case "Square":
                        Figure.Square _Square = new Figure.Square();
                        Console.WriteLine("Type the lenght");
                        _Square.Side = decimal.Parse(Console.ReadLine());
                    //FigurasList.Add(_Square);
                    //FigurasList = GetList();
                    //PrintList(FigurasList);
                    return _Square;
                     break;

                    case "Triangle":
                        Figure.Triangle _Triangle = new Figure.Triangle();
                        Console.WriteLine("Type the lenght");
                        _Triangle.Side = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Type the height");
                        _Triangle.Height = decimal.Parse(Console.ReadLine());
                        FigurasList.Add(_Triangle);
                        //List<Figure> ListFinal 
                        //FigurasList = GetList(_Triangle);
                    //PrintList(FigurasList, Input);
                       return _Triangle;
                    break;

                    case "Rectangle":
                        Figure _Rectangle = new Figure.Rectangle();
                        Console.WriteLine("Type the lenght: ");
                        _Rectangle.Side = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Type the height");
                        _Rectangle.Height = decimal.Parse(Console.ReadLine());
                        FigurasList.Add(_Rectangle);
                        //PrintList(FigurasList, Input);
                        //FigurasList.Add(_Rectangle);
                        return _Rectangle;
                        break;

                    case "Circle":
                        
                        Figure.Circle _Circle = new Figure.Circle();
                        Console.WriteLine("Type the radio: ");
                        _Circle.Radio = decimal.Parse(Console.ReadLine());
                       // FigurasList.Add(_Circle);
                        //PrintList(FigurasList, Input);
                        //FigurasList.Add(_Circle);
                        return _Circle;
                        break;

                    default:
                        return null;
                        break;
             }


                //List<Figure> ListFinal = new List<Figure>(); 
                //ListFinal=GetList();
                //PrintList(FigurasList);

                


        }

            








        public List<Figure> GetList(Figure figurita)
        {
            List<Figure> figuras = new List<Figure>();
            figuras.Add(figurita);
            return figuras;

        }
          
        public void PrintList(List<Figure> figuras)
        {
            //Agregar lista como un atributo...

            foreach(Figure item in figuras)
            {
                Console.WriteLine("Figure type is :  "+item.PrintName()+" its area is: "+item.CalculateArea()+ "and its perimeter is: "+item.CalculatePerimeter());
            }
        }




    }

    
}
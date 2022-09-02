
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perimetros_areas.models
{

    


    public class FigureProcess
    {

        static Figure?  figureSelected = null;

        public Figure CasesFigure(String UserInputSelected)
        {


            switch (UserInputSelected)

            {
                case "Square":
                    figureSelected = new Figure.Square();
                    Console.WriteLine("Type the lenght");
                    figureSelected.Side = decimal.Parse(Console.ReadLine());
                    return figureSelected;
                    break;

                case "Triangle":
                    figureSelected  = new Figure.Triangle();
                    Console.WriteLine("Type the lenght");
                    figureSelected.Side = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Type the heiht");
                    figureSelected.Height = decimal.Parse(Console.ReadLine());
                    return figureSelected;
                    break;

                case "Rectangle":
                    figureSelected = new Figure.Rectangle();
                    Console.WriteLine("Type the lenght: ");
                    figureSelected.Side = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Type the height");
                    figureSelected.Height = decimal.Parse(Console.ReadLine());
                    return figureSelected;
                    break;

                case "Circle":
                    figureSelected = new Figure.Circle();
                    Console.WriteLine("Type the radio: ");
                    figureSelected.Radio = decimal.Parse(Console.ReadLine());
                    return figureSelected;
                    break;

                default:
                    Console.WriteLine("Invalid Option");
              
                    return null;
                    break;
             
             }

        }  
        public static List<Figure> AddElementToList()
        { 
            //ASK IF FIGURESELECTED IS NOT NULL IS GOING TO ADD SOMETHING TO THE LIST
             if(figureSelected is not  null){
                
                Figure.ShapeList.Add(figureSelected);
               // Console.WriteLine("Figuras en lista: " + Figure.ShapeList.Count);
                return Figure.ShapeList;


            }

            return Figure.ShapeList;

        }
          
        public static void PrintList()

        { 
            foreach(Figure item in Figure.ShapeList)
            {
                Console.WriteLine("Figure type is :  "+item.PrintName()+" its area is: "+ item.CalculateArea() + "and its perimeter is: " + item.CalculatePerimeter());
            }
        }




    }

    
}
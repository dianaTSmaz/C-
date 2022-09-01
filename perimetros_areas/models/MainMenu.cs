using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perimetros_areas.models
{
    public class MainMenu{

        String figure_name = "";
          public void UserMenu(int _UserInput)

          {


            switch (_UserInput)
            {
                case 1:

                    Console.WriteLine("****Menu****");
                    Console.WriteLine("Write the figure you want to evalaute:");
                    Console.WriteLine($"Triangle{Environment.NewLine} Square{Environment.NewLine} Rectangle{Environment.NewLine} Circle{Environment.NewLine} *******");
                    figure_name = Console.ReadLine();
                    //Class and method used to obtain the information of the shapes
                    FigureProcess answer = new FigureProcess();
                    
                    //Hacer anullable a 
                    Figure ? _ShapeUser = answer.CasesFigure(figure_name);

                    if(_ShapeUser != null)
                    {
                        Console.WriteLine("The Shape:" + _ShapeUser.PrintName() + " its Area is: " + _ShapeUser.CalculateArea() + " its Perimeter: " + _ShapeUser.CalculatePerimeter());
                        FigureProcess.AddElementToList(_ShapeUser);

                    }
                    else{
                        BeginingPage.StartUserPage();
                    }

                    break;
                
                case 2:

                    if(Figure.ShapeList.Count == 0)
                    {
                        throw new ArgumentException("You must enter a valid Shape, The list is empty");
                    }
                    FigureProcess.PrintList(Figure.ShapeList);
                    break;
                
                default:
                    throw new Exception("You entered an invalid option, 1.To Type a new shape or 2. To Display your shape list");
                    break;

            }
              
            


            
          


          }


    }
      

        
        
                  
                 
    
}

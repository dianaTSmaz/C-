using perimetros_areas.models;
using System;





namespace perimetros_areas
{
    
    class Pogram

    {
      
        static void Main(string[] args)

        {
            int _answerToContinue = 1;
          


            //Start the try catch block to identiry all exceptions could be generated in the program
            try
            {
           
                //Cycle while do to maintain fluently the program
                while (_answerToContinue == 1)


                {

                    BeginingPage.StartUserPage();
                    Console.WriteLine("Would you like to continue?");
                    _answerToContinue = int.Parse(Console.ReadLine());
                    #region AttendsToPrintMessages
                    /*Console.WriteLine("1. To Add & Evaluate a shape , 2. To See your Shape List");
                    int UserInput = int.Parse(Console.ReadLine());
                    MainMenu attend = new MainMenu();
                    attend.UserMenu(UserInput);*/
                    #endregion
                    #region ListWroking
                    /*Console.WriteLine("****Menu****");
                    Console.WriteLine("Write the figure you want to evalaute:");
                    Console.WriteLine($"Triangle{Environment.NewLine} Square{Environment.NewLine} Rectangle{Environment.NewLine} Circle{Environment.NewLine} *******");
                   String figure_name = Console.ReadLine();

                    //Class and method used to obtain the information of the shapes
                    FigureProcess answer = new FigureProcess();
                    Figure figura = answer.CasesFigure(figure_name);
                    //answer.CasesFigure(figure_name);
                    List<Figure> Lista = FigureProcess.GetList(figura);
                    FigureProcess.PrintList(Lista);*/
                    #endregion
                    #region Attend
                    //ONE ATTEND TO OBTAIN ALL FIGURES, IT DOES NOT WORK...
                    /*List<Figure> figuras = new List<Figure>();
                    figuras.Add(answer.CasesFigure(figure_name));
                    foreach (Figure figura in figuras)
                    {
                       Console.WriteLine("Figura es:" + figure_name + " Su perimetro:" + figura.CalculatePerimeter() + "Su area:" + figura.CalculateArea());

                    }*/
                    #endregion

                }

                Console.WriteLine("Bye Bye to here!");
               

            }
            //Catch to show the specific exception to the user
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
               
               
            }
            




        }


    }
}







using perimetros_areas.models;
using System;





namespace perimetros_areas
{

    class Pogram
    {
        static void Main(string[] args)

        {
            string _AnswerToContinue = "yes";

            //Start the try catch block to identiry all exceptions could be generated in the program
            try
            {

                //Declare the local variables
               
                string figure_name = "";

                //Cycle while do to maintain fluently the program
                while (_AnswerToContinue != "no")
                {
                    Console.WriteLine("****Menu****");
                    Console.WriteLine("Write the figure you want to evalaute:");
                    Console.WriteLine($"Triangle{Environment.NewLine} Square{Environment.NewLine} Rectangle{Environment.NewLine} Circle{Environment.NewLine} *******");
                    figure_name = Console.ReadLine();

                    //Class and method used to obtain the information of the shapes
                    FigureProcess answer = new FigureProcess();
                    //answer.CasesFigure(figure_name);
                    List<Figure> Latest = answer.GetList(answer.CasesFigure(figure_name));
                    answer.PrintList(Latest);
                    #region Attend
                    //ONE ATTEND TO OBTAIN ALL FIGURES, IT DOES NOT WORK...
                    /*List<Figure> figuras = new List<Figure>();
                    figuras.Add(answer.CasesFigure(figure_name));
                    foreach (Figure figura in figuras)
                    {
                       Console.WriteLine("Figura es:" + figure_name + " Su perimetro:" + figura.CalculatePerimeter() + "Su area:" + figura.CalculateArea());

                    }*/
                    #endregion


                    Console.WriteLine("Would you like to continue?");
                    _AnswerToContinue = Console.ReadLine();

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







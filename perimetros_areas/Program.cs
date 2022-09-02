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
                    Console.WriteLine($"Would you like to continue?{Environment.NewLine}Prees 1. To CONTINUE {Environment.NewLine}Press any keyboard to EXIT");
                    _answerToContinue = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Bye Bye to here!");


            }
            //Catch to show the specific exception to the user
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                _answerToContinue = 1;


            }





        }


    }
}








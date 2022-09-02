using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perimetros_areas.models
{
    internal class BeginingPage
    {

        //Static because always is going to show the same
        public static void StartUserPage() 
        {

            try
            {
                Console.WriteLine("1. To Add & Evaluate a shape , 2. To See your Shape List");
                int UserInput = int.Parse(Console.ReadLine());
                MainMenu attend = new MainMenu();
                attend.UserMenu(UserInput);

            }catch(Exception error)
            {
                Console.WriteLine("Error: Invalid input argument");
                StartUserPage();

            }
            
        }
    }
}

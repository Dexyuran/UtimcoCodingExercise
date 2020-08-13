using System;
using Duran.UtimcoCodingExercise.JsonMenuLoader;
using Duran.UtimcoCodingExercise.MenuActions;

namespace Duran.UtimcoCodingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //read input
            var fileURI = args[0];
            var jsonLoader = new JsonMenuLoaderFactory().GetJsonMenuLoader(fileURI);
            var menuContainer = jsonLoader.LoadJsonMenu(fileURI);

            //define action
            var menuIDCalculator = new MenuCalculationSumIDs();

            //act
            foreach (var parentMenu in menuContainer)
            {
                Console.WriteLine(menuIDCalculator.Calculate(parentMenu.menu));
            }
            
            Console.ReadKey();
        }
    }
}

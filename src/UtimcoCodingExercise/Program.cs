using System;
using System.Collections.Generic;
using System.IO;
using Duran.UtimcoCodingExercise.Serialization;
using Newtonsoft.Json;

namespace Duran.UtimcoCodingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var jsonMenuObject = ParseJsonMenuFile(args[0]);
            foreach (var parentMenu in jsonMenuObject)
            {
                Console.WriteLine(CalculateMenuIDs(parentMenu));
            }
            
            Console.ReadKey();
        }

        /// <summary>
        /// Open a valid JSON menu file, deserialize.
        /// </summary>
        /// <param name="fileURI">valid file path</param>
        /// <returns>A JsonMenuContainer List</returns>
        private static IEnumerable<JsonMenuContainer> ParseJsonMenuFile(string fileURI)
        {
            // need some basic file validation and error handling.
            var jsonInput = File.ReadAllText(fileURI);
            return JsonConvert.DeserializeObject<IEnumerable<JsonMenuContainer>>(jsonInput);
        }

        /// <summary>
        /// get the sum of IDs for a given menu container
        /// </summary>
        /// <param name="parentMenu"></param>
        /// <returns></returns>
        private static int CalculateMenuIDs(JsonMenuContainer parentMenu)
        {
            // calculate the sum of IDs
            var idSum = 0;
            foreach (var menuItem in parentMenu.menu.items)
            {
                // skip if no label
                if (string.IsNullOrEmpty(menuItem?.label)) continue;
                idSum += menuItem.id;
            }

            return idSum;
        }
    }
}

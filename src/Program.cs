using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Duran.UtimcoCodingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //deserialize
            var filePath = @"E:\code\UtimcoCodingExercise\scripts\example.json";
            var jsonInput = File.ReadAllText(filePath);
            var jsonList = JsonConvert.DeserializeObject<List<jsonMenuContainer>>(jsonInput);

            //calculate sum with given conditions
            foreach (var parentMenu in jsonList)
            {
                var idSum = 0;
                foreach (var menuItem in parentMenu.menu.items)
                {
                    if (string.IsNullOrEmpty(menuItem?.label)) continue;
                    idSum += menuItem.id;
                }

                Console.WriteLine(idSum);
            }

            //end
            Console.ReadKey();
        }
    }

    public class jsonMenuContainer
    {
        public jsonMenu menu;
    }

    public class jsonMenu
    {
        public string header;
        public List<jsonItem> items;
    }

    public class jsonItem
    {
        public int id;
        public string label;
    }
}

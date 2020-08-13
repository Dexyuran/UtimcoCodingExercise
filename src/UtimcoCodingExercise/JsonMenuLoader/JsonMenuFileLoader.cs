using System.Collections.Generic;
using System.IO;
using Duran.UtimcoCodingExercise.Serialization;
using Newtonsoft.Json;

namespace Duran.UtimcoCodingExercise.JsonMenuLoader
{
    public class JsonMenuFileLoader : IJsonMenuLoader
    {
        public IEnumerable<JsonMenuContainer> LoadJsonMenu(string jsonMenu)
        {
            // need some basic file validation and error handling.
            var jsonInput = File.ReadAllText(jsonMenu);
            return JsonConvert.DeserializeObject<IEnumerable<JsonMenuContainer>>(jsonInput);
        }
    }
}

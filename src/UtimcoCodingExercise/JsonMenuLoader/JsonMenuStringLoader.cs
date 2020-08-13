using System.Collections.Generic;
using Duran.UtimcoCodingExercise.Serialization;
using Newtonsoft.Json;

namespace Duran.UtimcoCodingExercise.JsonMenuLoader
{
    public class JsonMenuStringLoader : IJsonMenuLoader
    {
        public IEnumerable<JsonMenuContainer> LoadJsonMenu(string jsonMenu)
        {
            return JsonConvert.DeserializeObject<IEnumerable<JsonMenuContainer>>(jsonMenu);
        }
    }
}

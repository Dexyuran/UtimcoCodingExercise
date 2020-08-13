using System.Collections.Generic;
using Duran.UtimcoCodingExercise.Serialization;

namespace Duran.UtimcoCodingExercise.JsonMenuLoader
{
    public interface IJsonMenuLoader
    {
        IEnumerable<JsonMenuContainer> LoadJsonMenu(string jsonMenu);
    }
}

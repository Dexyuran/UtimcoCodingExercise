using System.Collections.Generic;

// JSON deserialization classes based on the sample input
namespace Duran.UtimcoCodingExercise.Serialization
{
    public class JsonMenuContainer
    {
        public JsonMenu menu;
    }

    public class JsonMenu
    {
        public string header;
        public List<JsonItem> items;
    }

    public class JsonItem
    {
        public int id;
        public string label;
    }
}
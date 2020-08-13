using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duran.UtimcoCodingExercise.JsonMenuLoader
{
    public class JsonMenuLoaderFactory
    {
        public IJsonMenuLoader GetJsonMenuLoader(string jsonMenuSource)
        {
            // check if source is a file, string, or whatever.
            if (File.Exists(jsonMenuSource))
            {
                return new JsonMenuFileLoader();
            }
            else
            {
                return new JsonMenuStringLoader();
            }
        }
    }
}

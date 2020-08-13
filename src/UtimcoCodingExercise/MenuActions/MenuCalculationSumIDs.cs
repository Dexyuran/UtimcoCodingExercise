using Duran.UtimcoCodingExercise.Serialization;

namespace Duran.UtimcoCodingExercise.MenuActions
{
    public class MenuCalculationSumIDs : IMenuCalculation
    {
        public int Calculate(JsonMenu menu)
        {
            // calculate the sum of IDs
            var idSum = 0;
            foreach (var menuItem in menu.items)
            {
                // skip if no label
                if (string.IsNullOrEmpty(menuItem?.label)) continue;
                idSum += menuItem.id;
            }

            return idSum;
        }
    }
}

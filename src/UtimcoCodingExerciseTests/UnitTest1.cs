using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Duran.UtimcoCodingExercise.JsonMenuLoader;
using Duran.UtimcoCodingExercise.MenuActions;

namespace Duran.UtimcoCodingExerciseTests
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Calculate the SUM of the IDs of all "items",
        /// as long as a "label" exists for that item.
        /// </summary>
        /// <remarks>
        /// I've not much exp in test units. hope this is good ^_^;
        /// </remarks>
        [TestMethod]
        public void SumMenuIDs46()
        {
            TestSumIDs(JsonMenuStringSumShouldBe46(), 46);
        }

        [TestMethod]
        public void SumMenuIDs0()
        {
            TestSumIDs(JsonMenuStringSumShouldBe0(), 0);
        }

        [TestMethod]
        public void SumMenuIDs248()
        {
            TestSumIDs(JsonMenuStringSumShouldBe248(), 248);
        }

        private void TestSumIDs(string jsonInput, int expectedSum)
        {
            var menuLoader = new JsonMenuLoaderFactory().GetJsonMenuLoader(jsonInput);
            var menuContainer = menuLoader.LoadJsonMenu(jsonInput);
            var actualSum = new MenuCalculationSumIDs().Calculate(menuContainer.FirstOrDefault()?.menu);
            Assert.AreEqual(actualSum, expectedSum);
        }

        private string JsonMenuStringSumShouldBe46() =>  @"[{""menu"":{""header"":""menu"",""items"":[{""id"":27},{""id"":0,""label"":""Label 0""},null,{""id"":93},{""id"":85},{""id"":54},null,{""id"":46,""label"":""Label 46""}]}}]";
        private string JsonMenuStringSumShouldBe0() => @"[{""menu"": {""header"": ""menu"",""items"": [{""id"": 81}]}}]";
        private string JsonMenuStringSumShouldBe248() => @"[{""menu"": {""header"": ""menu"",""items"": [{""id"": 70,""label"": ""Label 70""},{""id"": 85,""label"": ""Label 85""},{""id"": 93,""label"": ""Label 93""},{""id"": 2}]}}]";
    }
}

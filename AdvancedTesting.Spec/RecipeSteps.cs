using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using NUnit.Framework;
using TechTalk.SpecFlow;
using WatiN.Core;
using Table = TechTalk.SpecFlow.Table;

[assembly: RequiresSTA]

namespace AdvancedTesting.Spec
{
    [Binding]
    public class RecipeSteps
    {
        private IE Browser { get; set; }

        [BeforeScenario]
        public void BeforeScenario()
        {
            Browser = new IE();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Browser.Close();
        }

        private static Dictionary<string, string> _Pages = new Dictionary<string, string>
        {
            {"Index", "http://localhost:64091/"},
            {"Login", "http://localhost:64091/Account/Login"},
            {"Recipe", "http://localhost:64091/Recipe"}
        };

        private static Dictionary<string, string> Users = new Dictionary<string, string>
        {
            {"user", "123456"}
        };

        [Given(@"I am on the ""(.*)"" page")]
        public void GivenIAmOnThePage(string page)
        {
            var url = _Pages[page];
            Browser.GoTo(url);
        }

        [When(@"I have entered my credentials")]
        public void WhenIHaveEnteredMyCredentials(Table table)
        {
            var user = table.Rows[0]["user"];
            var password = table.Rows[0]["password"];

            Browser.TextField(x => x.Id == "UserName").Value = user;
            Browser.TextField(x => x.Id == "Password").Value = password;
        }

        [When(@"I have pressed ""(.*)"" button")]
        public void WhenIHavePressedButton(string buttonLabel)
        {
            Browser.Button(x => x.Value == buttonLabel).Click();
        }
        
        [Then(@"I should be on ""(.*)"" page")]
        public void ThenIShouldBeOnPage(string page)
        {
            Assert.AreEqual(Browser.Url, _Pages[page]);
        }
        
        [Then(@"I should see the text ""(.*)""")]
        public void ThenIShouldSeeTheText(string text)
        {
            var textOnPage = Browser.FindText(new Regex(text));
            Assert.NotNull(textOnPage);
        }

        [Given(@"I am logged as ""(.*)""")]
        public void GivenIAmLoggedAs(string username)
        {
            string[] header = { "user", "password" };
            string[] row = { username, Users[username] };
            var table = new Table(header);
            table.AddRow(row);
            GivenIAmOnThePage("Login");
            WhenIHaveEnteredMyCredentials(table);
            WhenIHavePressedButton("Log in");
        }

        [When(@"I put text ""(.*)"" to ""(.*)"" field")]
        public void WhenIPutTextToField(string text, string field)
        {
            Browser.TextField(x => x.Name == field).Value = text;
        }

        [When(@"I have selected ""(.*)"" from ingredients")]
        [Given(@"I have selected ""(.*)"" from ingredients")]
        public void GivenIHaveSelectedFromIngredients(string value)
        {
            Browser.SelectList(x => x.Id == "ingredient-list").SelectByValue(value);
        }
    }
}

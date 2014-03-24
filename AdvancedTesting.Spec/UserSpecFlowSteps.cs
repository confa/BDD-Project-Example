using Calculator;
using NUnit.Framework;
using TechTalk.SpecFlow;
using WatiN.Core;

namespace AdvancedTesting.Spec
{
    [Binding]
    public class UserSpecFlowSteps
    {
        private CalculatorContext CalculatorContext { get; set; }

        public UserSpecFlowSteps(CalculatorContext calculatorContext)
        {
            CalculatorContext = calculatorContext;
        }

        [Given(@"I have entered (.*)")]
        public void GivenIHaveEntered(int value)
        {
            CalculatorContext.Values.Add(value);
        }
        
        [When(@"I press = button")]
        public void WhenIPressButton()
        {
            CalculatorContext.Result = CalculatorContext.Lets.Multiply(CalculatorContext.Values.ToArray());
        }
        
        [Then(@"result should be (.*)")]
        public void ThenResultShouldBe(int result)
        {
            Assert.AreEqual(CalculatorContext.Result, result);
        }
    }
}

using Calculator;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace AdvancedTesting.Spec
{
    [Binding]
    public class SpecFlowFeatureSteps
    {
        private CalculatorContext CalculatorContext { get; set; }

        public SpecFlowFeatureSteps(CalculatorContext calculatorContext)
        {
            CalculatorContext = calculatorContext;
        }

        [Given(@"I have entered ""(.*)"" and ""(.*)"" for calculation")]
        public void GivenIHaveEnteredAndForCalculation(int a, int b)
        {
            CalculatorContext.Values.Add(a);
            CalculatorContext.Values.Add(b);
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            CalculatorContext.Result = CalculatorContext.Lets.Sum(CalculatorContext.Values.ToArray());
        }
        
        [Then(@"the result should be ""(.*)"" on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int b)
        {
            Assert.AreEqual(CalculatorContext.Result, b);
        }
    }
}

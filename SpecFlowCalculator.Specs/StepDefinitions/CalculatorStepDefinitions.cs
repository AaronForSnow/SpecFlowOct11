using System.Security.Policy;
using FluentAssertions;

namespace SpecFlowCalculator.Specs.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        private readonly Calculator _calculator = new Calculator();
        private int _result;
        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _calculator.FirstNumber = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _calculator.SecondNumber = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _result = _calculator.Add();
        }

        [When("the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            _result = _calculator.Subtract();
        }

        [When("the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            _result = _calculator.Mult();
        }

        [When(@"operation \+ is done to the number (.*)")]
        public void OperationPlusIsDoneToTheNumber(int number)
        {
            _calculator.Plus(number);
            _result = _calculator.FirstNumber;
        }

        [When(@"operation / is done to the number (.*)")]
        public void OperationDivideIsDoneToTheNumber(int number)
        {
            _calculator.Divide(number);
            _result = _calculator.FirstNumber;
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            _result.Should().Be(result);
        }

        [When(@"operation \- is done to the number (.*)")]
        public void OperationMinusIsDoneToTheNumber(int number)
        {
            _calculator.Minus(number);
            _result = _calculator.FirstNumber;
        }

        [When(@"operation % is done to the number (.*)")]
        public void OperationModIsDoneToTheNumber(int number)
        {
            _calculator.Mod(number);
            _result = _calculator.FirstNumber;
        }
    }
}
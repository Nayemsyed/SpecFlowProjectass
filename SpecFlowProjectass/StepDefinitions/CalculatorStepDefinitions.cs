namespace SpecFlowProjectass.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private readonly ScenarioContext scenarioContext;
        private readonly Calculator calculator;
        private int result;
        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
            this.calculator = new Calculator();
        }
            // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

            [Given("the first number is (.*)")]

            public void GivenTheFirstNumberIs(int number)

            {
                calculator.Fnum = number;
                //TODO: implement arrange (precondition) logic
                // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
                // To use the multiline text or the table argument of the scenario,
                // additional string/Table parameters can be defined on the step definition
                // method. 
            }

            [Given("the second number is (.*)")]
            public void GivenTheSecondNumberIs(int number)
            {
                calculator.Snum=number;
                //TODO: implement arrange (precondition) logic

                
            }

            [When("the two numbers are divided")]
            public void WhenTheTwoNumbersAredivided()
            {
                result = calculator.div();
                //TODO: implement act (action) logic

                
            }

            [Then("the result should be (.*)")]
            public void ThenTheResultShouldBe(int result)
            {
                result.Should().Be(result);
                //TODO: implement assert (verification) logic

                
            }
        }
    }


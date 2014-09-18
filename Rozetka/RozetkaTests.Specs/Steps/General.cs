

using Etna.QA.TestAutomation.Framework.Tests;
using NUnit.Framework;
using TechTalk.SpecFlow;
using RozetkaTest.PageObjects.Pages;
using RozetkaTest.Specs.Context;

namespace RozetkaTest.Specs.Steps
{
    [Binding]
    public class General : WebDriverTestsBase<MainPage>
    {
        private bool _initialized; 

        private readonly WebTestContext _Context;

        public General(WebTestContext context)
        {
            _Context = context;
        }
		

        [BeforeScenario]
        public override void SetUp()
        {
            Initialize();
        }

        private void Initialize()
        {
            if (_initialized)
            {
                return;
            }
			
            base.SetUp();
			
            _Context.WebDriverContext = WebDriverContext;
            _initialized = true;
        }

        [AfterScenario]
        public override void TearDown()
        {
            base.TearDown();
        }
    }
}

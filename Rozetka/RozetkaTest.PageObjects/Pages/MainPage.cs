using Etna.QA.TestAutomation.Framework.Attributes;

using Etna.QA.TestAutomation.Framework.PageObjects;
using Etna.QA.TestAutomation.Framework.WebDriver;

using System;
using RozetkaTest.PageObjects.PageElements;


namespace RozetkaTest.PageObjects.Pages
{
	/// <summary>
	/// Класс, содержащий базовые элементы UI всех страниц по-умолчанию.
	/// </summary>
    public class MainPage : Page
    {
        
        
        [PageElement]
        public MainNavigation Navigation { get; set; }

        
		public MainPage()
		{
			WebDriverContext.Current.WebDriver.Manage().Timeouts().ImplicitlyWait(System.TimeSpan.FromSeconds(5));
		}

		public new Page WaitUntilLoaded(bool withElements = true)
		{
			throw new Exception();
		}
	
    }
}


using Etna.QA.TestAutomation.Framework.WebDriver;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;


namespace RozetkaTest.PageObjects.PageElements
{
    public class MainNavigation
    {

        [FindsBy(How = How.Id, Using = "main_menu")]
        private IWebElement _Container { get; set; }

        public bool HoverMenuItem(string name)
        {
            try
            {
                var menuItem = this._Container.FindElement(By.XPath(string.Format("//a[@name='active-elem']/span[text()='{0}']", name)));
                _hoverElement(menuItem);
            }
            catch (NoSuchElementException)
            {return false;}
            return true;
        }

        private void _hoverElement(IWebElement element)
        {
            new Actions(WebDriverContext.Current.WebDriver).MoveToElement(element).Perform();
        }
        

        public bool GoTo(string name)
        {
            var menuItem = this._Container.FindElement(By.XPath(string.Format("//div[@name='drop-elem']//a[text()='{0}']",name)));
            menuItem.Click();
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls.WebParts;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace RozetkaTest.PageObjects.Pages
{
    public class PortalPage:MainPage
    {
        [FindsBy(How = How.ClassName, Using = "portal-page")]
        private IWebElement ContainerThingsByGroups { get; set; }

        public bool ClickLinkInGroup(string name)
        {
            ContainerThingsByGroups.FindElement(By.XPath(string.Format("//a[contains(text(),'{0}')]",name))).Click();
            return true;
        }
        
    }
}

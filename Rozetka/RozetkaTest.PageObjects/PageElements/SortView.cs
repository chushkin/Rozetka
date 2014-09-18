using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace RozetkaTest.PageObjects.PageElements
{
    public class SortView
    {
        [FindsBy(How = How.ClassName, Using = "sort-view")]
        private IWebElement _Container { get; set; }

        [FindsBy(How = How.Id, Using = "sort_view")]
        private IWebElement _SortView { get; set; } // /a/i

        public bool SelectSortView(string nameSort)
        {
            this._Container.FindElement(By.XPath("//div[@id='sort_view']/a/i")).Click();
            this._SortView.FindElement(By.XPath(string.Format("//a[@class='lightblue' and text()='{0}']",nameSort))).Click();
            return true;
        }

    }
}

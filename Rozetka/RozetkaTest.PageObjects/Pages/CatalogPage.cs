using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Etna.QA.TestAutomation.Framework.Attributes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RozetkaTest.PageObjects.PageElements;

namespace RozetkaTest.PageObjects.Pages
{
    public class CatalogPage:MainPage
    {
        [FindsBy(How = How.ClassName, Using = "c-middle")]
        private IWebElement _MiddleContainer { get; set; }

        [PageElement]
        public SortView SortPanel { get; set; }

        [PageElement]
        public BlockWithGoods Goods { get; set; }
    }
}

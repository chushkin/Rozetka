using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace RozetkaTest.PageObjects.PageElements
{
    public class BlockWithGoods
    {
        [FindsBy(How = How.Id, Using = "block_with_goods")]
        private IWebElement _Container { get; set; }

       public string GetPriceTheFirstGood()
        {
            return
                _Container.FindElement(By.XPath("//div[1][@class='gtile-i-wrap']//div[@class='g-price-uah']"))
                    .Text.Trim();
        }
    }
}

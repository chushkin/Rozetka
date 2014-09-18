using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TechTalk.SpecFlow;
using RozetkaTest.PageObjects.Pages;
using RozetkaTest.Specs.Context;

namespace RozetkaTest.Specs.Steps.Sections
{
    [Binding]
    public class Catalog:StepsBase
    {
        public Catalog(WebTestContext context) : base(context)
        {
        }

        [When(@"я на странице каталога нажимаю на ссылку (.*)")]
        public void ЕслиЯНаСтраницеКаталогаНажимаюНаСсылку(string nameLink)
        {
            var page = Context.GetPage<PortalPage>();
            Assert.IsTrue(page.ClickLinkInGroup(nameLink), "Не найдена ссыдка: ", nameLink);
        }
        [When(@"я а странице выбираю сортировку (.*)")]
        public void ЕслиЯАСтраницеВыбираюСортировку(string typeOfSort)
        {
            var page = Context.GetPage<CatalogPage>();
            Assert.IsTrue(page.SortPanel.SelectSortView(typeOfSort), "Не удалось отсортировать: ", typeOfSort);

        }

        [Then(@"на странице нахожу самый дорогой ноубук с ценой (.*)")]
        public void ТоНаСтраницеНахожуСамыйДорогойНоубукСЦеной(string price)
        {
            var page = Context.GetPage<CatalogPage>();
            Assert.AreEqual(price.Trim(), page.Goods.GetPriceTheFirstGood(),"Цена не соответствует");
        }


    }
}

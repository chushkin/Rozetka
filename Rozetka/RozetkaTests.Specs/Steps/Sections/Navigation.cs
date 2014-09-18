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
    public class Navigation:StepsBase
    {
        public Navigation(WebTestContext context) : base(context)
        {
        }

        [When(@"я навожу курсор мыши на (.*)")]
        public void ЕслиЯНавожуКурсорМышиНа(string nameMenuItem)
        {
            var page = Context.GetPage<MainPage>();
            Assert.IsTrue(page.Navigation.HoverMenuItem(nameMenuItem), "Не удалось навести курсор на меню: ", nameMenuItem);
        }

        [When(@"я в аскрывающемся меню выбираю (.*)")]
        public void ЕслиЯВАскрывающемсяМенюВыбираю(string nameMenuItem)
        {
            var page = Context.GetPage<MainPage>();
            Assert.IsTrue(page.Navigation.GoTo(nameMenuItem), "Не найден пункт меню: ", nameMenuItem);
        }

    }
}

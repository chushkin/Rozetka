

using System;
using Etna.QA.TestAutomation.Framework.Configuration;
using Etna.QA.TestAutomation.Framework.PageObjects;
using Etna.QA.TestAutomation.Framework.WebDriver;

namespace RozetkaTest.Specs.Context
{
    public class WebTestContext
    {
       
        public WebDriverContext WebDriverContext { get; set; }

		private Page _Page;
		public Page Page { get { return _Page; } }

        public UserElement User { get; set; }
		public AppElement App { get; set; }
		public string Url
		{
			get { return this.WebDriverContext.WebDriver.Url; }
			set 
			{
				var url = new Uri(value);
				this.WebDriverContext.WebDriver.Navigate().GoToUrl(url);
			}
		}

		public void DropPage()
		{
			this._Page = null;
		}
        public T GetPage<T>()
            where T : Page, new()
        {
			this._Page = Page is T ? (T)Page : CreatePage<T>();
			return (T)Page;            
        }

        private T CreatePage<T>()
            where T : Page, new()
        {
			return WebDriverContext.CreateCurrentPage<T>();
        } 

       
    }
}

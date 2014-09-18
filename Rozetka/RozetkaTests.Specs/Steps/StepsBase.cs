using NUnit.Framework;
using RozetkaTest.PageObjects.Pages;
using RozetkaTest.Specs.Context;

namespace RozetkaTest.Specs.Steps
{
	public class StepsBase
	{
		protected WebTestContext Context;

		public StepsBase(WebTestContext context)
		{
			Context = context;
		}	
	}
}
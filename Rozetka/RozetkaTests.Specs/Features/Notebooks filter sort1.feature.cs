﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.34014
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace RozetkaTest.Specs.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Фильтр сортировки ноутбуков")]
    public partial class ФильтрСортировкиНоутбуковFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Notebooks filter sort.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("ru-RU"), "Фильтр сортировки ноутбуков", "Для проверки сортировки на портале \r\nКак обычный пользователь \r\nЯ хочу зайти в ра" +
                    "здел ноутбуков и выбрать нужную сортировку", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Проверка сортировки от дорогих к дешевым")]
        [NUnit.Framework.CategoryAttribute("new")]
        public virtual void ПроверкаСортировкиОтДорогихКДешевым()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Проверка сортировки от дорогих к дешевым", new string[] {
                        "new"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line 9
 testRunner.When("я навожу курсор мыши на Ноутбуки, планшеты и компьютеры", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Когда ");
#line 10
 testRunner.And("я в аскрывающемся меню выбираю Ноутбуки", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line 11
 testRunner.And("я на странице каталога нажимаю на ссылку Ноутбуки", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line 12
 testRunner.When("я а странице выбираю сортировку от дорогих к дешевым", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Когда ");
#line 13
 testRunner.Then("на странице нахожу самый дорогой ноубук с ценой 61 199 грн.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Тогда ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
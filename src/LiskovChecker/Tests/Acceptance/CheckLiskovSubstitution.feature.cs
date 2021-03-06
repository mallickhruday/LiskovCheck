// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.4.0.0
//      Runtime Version:4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
namespace LiskovChecker.Tests.Acceptance
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Semi-automatic check for adherence to the Liskov Substitution Principle.")]
    public partial class Semi_AutomaticCheckForAdherenceToTheLiskovSubstitutionPrinciple_Feature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CheckLiskovSubstitution.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Semi-automatic check for adherence to the Liskov Substitution Principle.", @"Definition of the Liskov Substitution Principle:

""Liskov substitution principle (LSP) is a particular definition of a
subtyping relation, called (strong) behavioral subtyping,""

(from http://en.wikipedia.org/wiki/Liskov_substitution_principle)

...also known as:

""If it looks like a duck, quacks like a duck, but needs batteries – you probably have the wrong abstraction.""

(from http://www.lostechies.com/blogs/derickbailey/archive/2009/02/11/solid-development-principles-in-motivational-pictures.aspx )

For more information, see http://birding.about.com/od/birdprofiles/tp/typesofducks.htm", GenerationTargetLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A subtype is more likely to adhere to the Liskov Substitution Principle")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void ASubtypeIsMoreLikelyToAdhereToTheLiskovSubstitutionPrinciple()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A subtype is more likely to adhere to the Liskov Substitution Principle", new string[] {
                        "mytag"});
#line 19
this.ScenarioSetup(scenarioInfo);
#line 20
 testRunner.Given("a DLL named Zoo.dll with a \"Duck\" class which inherits from \"Animal\"");
#line 21
 testRunner.When("I run \"liskovcheck Zoo.dll\"");
#line 22
 testRunner.Then("the words \"It looks like a Duck and behaves like an Animal\" should be on the scre" +
                    "en.");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A subtype is less likely to adhere to the Liskov Substitution Principle")]
        public virtual void ASubtypeIsLessLikelyToAdhereToTheLiskovSubstitutionPrinciple()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A subtype is less likely to adhere to the Liskov Substitution Principle", ((string[])(null)));
#line 24
this.ScenarioSetup(scenarioInfo);
#line 25
 testRunner.Given("a DLL named Zoo.dll with a \"MerganserDuck\" class which inherits from \"TransistorR" +
                    "adio\"");
#line 26
 testRunner.When("I run liskovcheck.exe with the argument \'Zoo.dll\'\"");
#line 27
 testRunner.Then("the words \"It looks like a MerganserDuck and behaves like a TransistorRadio\" shou" +
                    "ld be on the screen.");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("No file exists at the assembly DLL location specified in the command line.")]
        public virtual void NoFileExistsAtTheAssemblyDLLLocationSpecifiedInTheCommandLine_()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("No file exists at the assembly DLL location specified in the command line.", ((string[])(null)));
#line 29
this.ScenarioSetup(scenarioInfo);
#line 30
 testRunner.Given("a DLL named SomeAssembly.dll which doesn\'t exist");
#line 31
 testRunner.When("I run \"liskovcheck SomeAssembly.dll\"");
#line 32
 testRunner.Then("the message \"No file found at \'SomeAssembly.dll\'\"");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Help information is displayed.")]
        public virtual void HelpInformationIsDisplayed_()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Help information is displayed.", ((string[])(null)));
#line 34
this.ScenarioSetup(scenarioInfo);
#line 35
 testRunner.Given("no command line arguments");
#line 36
 testRunner.When("I run \"liskovcheck\"");
#line 37
 testRunner.Then("I should see \"Usage example: \'liskovcheck \'c:\\path\\to\\assembly\\MyAssembly.dll\'\"");
#line 38
 testRunner.And("\"Semi-automatic check for adherence to the Liskov Substitution Principle\"");
#line hidden
            testRunner.CollectScenarioErrors();
        }
    }
}
#endregion

﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.296
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace NPIRemediation.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("NPIRemediation")]
    public partial class NPIRemediationFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "NPIRemediation.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "NPIRemediation", "In order ensure that no unsecure data is migrated\r\nAs a CapOne V1 Administrator\r\n" +
                    "I want all strings matching secure data patterns to be masked", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Mask a Credit Card Number")]
        [NUnit.Framework.CategoryAttribute("maskacreditcard")]
        public virtual void MaskACreditCardNumber()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Mask a Credit Card Number", new string[] {
                        "maskacreditcard"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("I have supplied a string of \"This is a valid CC 4111 2231 2312 2322\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.And("I scan using this pattern \"\\b((67\\d{2})|(4\\d{3})|(5[1-5]\\d{2})|(6011))-?\\s?\\d{4}-" +
                    "?\\s?\\d{4}-?\\s?\\d{4}\\b\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.When("I find a match", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then("the result should be a string of \"This is a valid CC XXXX XXXX XXXX XXXX\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Mask Multiple Credit Card Numbers")]
        [NUnit.Framework.CategoryAttribute("maskmultiplecreditcards")]
        public virtual void MaskMultipleCreditCardNumbers()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Mask Multiple Credit Card Numbers", new string[] {
                        "maskmultiplecreditcards"});
#line 14
this.ScenarioSetup(scenarioInfo);
#line 15
 testRunner.Given("I have supplied a string of \"This is a valid CC 4111 2231 2312 2322 and so is 411" +
                    "1 2323 1232 4444\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 16
 testRunner.And("I scan using this pattern \"\\b((67\\d{2})|(4\\d{3})|(5[1-5]\\d{2})|(6011))-?\\s?\\d{4}-" +
                    "?\\s?\\d{4}-?\\s?\\d{4}\\b\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
 testRunner.When("I find a match", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
 testRunner.Then("the result should be a string of \"This is a valid CC XXXX XXXX XXXX XXXX and so i" +
                    "s XXXX XXXX XXXX XXXX\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Do not Mask a Credit Card Number")]
        [NUnit.Framework.CategoryAttribute("dontmaskacreditcard")]
        public virtual void DoNotMaskACreditCardNumber()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Do not Mask a Credit Card Number", new string[] {
                        "dontmaskacreditcard"});
#line 21
this.ScenarioSetup(scenarioInfo);
#line 22
 testRunner.Given("I have supplied a string of \"This is an invalid CC 41 2231 2312 2322\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 23
 testRunner.And("I scan using this pattern \"\\b((67\\d{2})|(4\\d{3})|(5[1-5]\\d{2})|(6011))-?\\s?\\d{4}-" +
                    "?\\s?\\d{4}-?\\s?\\d{4}\\b\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
 testRunner.When("I don\'t find a match", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 25
 testRunner.Then("the result should be a string of \"This is an invalid CC 41 2231 2312 2322\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Mask a Social Security Number")]
        [NUnit.Framework.CategoryAttribute("maskasocialsecuritynumber")]
        public virtual void MaskASocialSecurityNumber()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Mask a Social Security Number", new string[] {
                        "maskasocialsecuritynumber"});
#line 28
this.ScenarioSetup(scenarioInfo);
#line 29
 testRunner.Given("I have supplied a string of \"This is a valid SSN 256-59-8889\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 30
 testRunner.And("I scan using this pattern \"\\b([0-6]\\d{2}|7[0-6]\\d|77[0-2])(\\s|\\-)?(\\d{2})\\2(\\d{4}" +
                    ")\\b\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
 testRunner.When("I find a match", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
 testRunner.Then("the result should be a string of \"This is a valid SSN XXX-XX-XXXX\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Do not Mask a Social Security Number")]
        [NUnit.Framework.CategoryAttribute("dontmaskasocialsecuritynumber")]
        public virtual void DoNotMaskASocialSecurityNumber()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Do not Mask a Social Security Number", new string[] {
                        "dontmaskasocialsecuritynumber"});
#line 35
this.ScenarioSetup(scenarioInfo);
#line 36
 testRunner.Given("I have supplied a string of \"This is an invalid SSN 996-59-8889\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 37
 testRunner.And("I scan using this pattern \"\\b([0-6]\\d{2}|7[0-6]\\d|77[0-2])(\\s|\\-)?(\\d{2})\\2(\\d{4}" +
                    ")\\b\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.When("I don\'t find a match", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 39
 testRunner.Then("the result should be a string of \"This is an invalid SSN 996-59-8889\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Mask a Customer Number")]
        [NUnit.Framework.CategoryAttribute("maskacustomernumber")]
        public virtual void MaskACustomerNumber()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Mask a Customer Number", new string[] {
                        "maskacustomernumber"});
#line 42
this.ScenarioSetup(scenarioInfo);
#line 43
 testRunner.Given("I have supplied a string of \"This is a valid eight digit C# 43453342\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 44
 testRunner.And("I scan using this pattern \"\\b[0-9]{8}\\b\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
 testRunner.When("I find a match", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 46
 testRunner.Then("the result should be a string of \"This is a valid eight digit C# XXXXXXXX\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Do not Mask a Customer Number")]
        [NUnit.Framework.CategoryAttribute("dontmaskacustomernumber")]
        public virtual void DoNotMaskACustomerNumber()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Do not Mask a Customer Number", new string[] {
                        "dontmaskacustomernumber"});
#line 49
this.ScenarioSetup(scenarioInfo);
#line 50
 testRunner.Given("I have supplied a string of \"This is an invalid eight digit C# AA453342\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 51
 testRunner.And("I scan using this pattern \"\\b[0-9]{8}\\b\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
 testRunner.When("I don\'t find a match", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 53
 testRunner.Then("the result should be a string of \"This is an invalid eight digit C# AA453342\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Array of Patterns Match")]
        [NUnit.Framework.CategoryAttribute("multipleitemsmatch")]
        public virtual void ArrayOfPatternsMatch()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Array of Patterns Match", new string[] {
                        "multipleitemsmatch"});
#line 56
this.ScenarioSetup(scenarioInfo);
#line 57
 testRunner.Given("I have supplied a string of \"This has 4111 2321 3323 5454 and 321 2322 23223 33 a" +
                    "nd 255-65-8739 and 12345678 and 123456789 and 777-88-9999\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 58
 testRunner.When("I have an array of patterns to match", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 59
 testRunner.Then("the result should be \"This has XXXX XXXX XXXX XXXX and 321 2322 23223 33 and XXX-" +
                    "XX-XXXX and XXXXXXXX and 123456789 and 777-88-9999\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

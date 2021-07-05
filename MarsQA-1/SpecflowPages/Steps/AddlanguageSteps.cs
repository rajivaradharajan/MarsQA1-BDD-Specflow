using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQA_1.SpecflowPages.Steps
{
    [Binding]
    public class AddlanguageSteps
    {
    

        [Given(@"I am in the profile page")]
        public void GivenIAmInTheProfilePage()
        {
            //option 1
            //This Checks that if the profile page is displayed
            true.Equals(Driver.driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/span[1]")).Displayed);

             //option2
            //////Validate if profile page is visible
            //var element = Driver.driver.FindElement(By.XPath(".//*[@data-tab='first']"));

            //if (!string.IsNullOrEmpty(element.Text))
            //{
            //    Console.WriteLine(element + "Profile Page is Visible");
            //}
            //else
            //{
            //    Console.WriteLine("Text is absent");
            //}
            //////Assert.That(element, Is.EqualTo("Share Skill"), "Test Failed");
        }

        [When(@"i add language")]
        public void WhenIAddLanguage()
        {
            ExcelLibHelper.PopulateInCollection($@"{ConstantHelpers.path}\SpecflowTests\Data\\Data.xlsx", "Language");
            //Call the language class
            Language.AddLanguage();
            Thread.Sleep(2000);
        }
        
        [When(@"i Update Language")]
        public void WhenIUpdateLanguage()
        {
            ExcelLibHelper.PopulateInCollection($@"{ConstantHelpers.path}\SpecflowTests\Data\\Data.xlsx", "Language");
            //Call the language class
            Language.UpdateLanguage();
            Thread.Sleep(2000);

                      
        }
        
        [When(@"i Delete language")]
        public void WhenIDeleteLanguage()
        {
            ExcelLibHelper.PopulateInCollection($@"{ConstantHelpers.path}\SpecflowTests\Data\\Data.xlsx", "Language");
            //Call the language class
            Language.DeleteLanguage();
            Thread.Sleep(2000);
        }
        
        [Then(@"the language should be added successfully")]
        public void ThenTheLanguageShouldBeAddedSuccessfully()
        {
            Thread.Sleep(3000); 
            string lang = Driver.driver.FindElement(By.XPath($"//td[normalize-space()='{ExcelLibHelper.ReadData(2, "Language")}']")).Text;
            Thread.Sleep(1000);

            Assert.That(lang, Is.EqualTo("French"), "Language not added, Test Failed");
            Console.WriteLine("Language added");

        }
        
        [Then(@"the language should be updated successfully")]
        public void ThenTheLanguageShouldBeUpdatedSuccessfully()
        {
            //Thread.Sleep(1000);
            //string lang = Driver.driver.FindElement(By.XPath($"//td[normalize-space()='{ExcelLibHelper.ReadData(4, "Language")}']")).Text;
            //Thread.Sleep(1000);

            //Assert.That(lang, Is.EqualTo("English"), "language not updated Test Failed");

            Thread.Sleep(1000);
            Language.ValidateLanglevelUpdated();
           


        }
        
        [Then(@"the language should be deleted successfully")]
        public  void ThenTheLanguageShouldBeDeletedSuccessfully()
        {
            
                //Language.ValidateLangdeleted();
                //Console.WriteLine("language is deleted");
            }
    }
}

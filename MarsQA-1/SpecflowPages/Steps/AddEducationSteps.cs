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
    public class AddEducationSteps
    {
        [When(@"i add Education")]
        public void WhenIAddEducation()
        {
            ExcelLibHelper.PopulateInCollection($@"{ConstantHelpers.path}\SpecflowTests\Data\\Data.xlsx", "Education");
            //Call the Education class
            Education.AddEducation();
            Thread.Sleep(2000);
        }
        
        [When(@"i Update Education")]
        public void WhenIUpdateEducation()
        {
            ExcelLibHelper.PopulateInCollection($@"{ConstantHelpers.path}\SpecflowTests\Data\\Data.xlsx", "Education");
            //Call the Education class
            Education.UpdateEducation();
            Thread.Sleep(2000);
        }
        
        [When(@"i Delete Education")]
        public void WhenIDeleteEducation()
        {
            ExcelLibHelper.PopulateInCollection($@"{ConstantHelpers.path}\SpecflowTests\Data\\Data.xlsx", "Education");
            //Call the Education class
            Education.DeleteEducation();
            Thread.Sleep(2000);
        }
        
        [Then(@"the Education should be added successfully")]
        public void ThenTheEducationShouldBeAddedSuccessfully()
        {
            Thread.Sleep(3000);
            string lang = Driver.driver.FindElement(By.XPath($"//td[normalize-space()='{ExcelLibHelper.ReadData(4, "University")}']")).Text;
            Thread.Sleep(1000);

            Assert.That(lang, Is.EqualTo("Massey University"), "Education not added, Test Failed");
            Console.WriteLine("Education added");
        }
        
        [Then(@"the Education should be updated successfully")]
        public void ThenTheEducationShouldBeUpdatedSuccessfully()
        {
            string lang = Driver.driver.FindElement(By.XPath($"//td[normalize-space()='{ExcelLibHelper.ReadData(5, "University")}']")).Text;
            Thread.Sleep(1000);

            Assert.That(lang, Is.EqualTo("Nehru University"), "Education not updated, Test Failed");
            Console.WriteLine("Education updated");
        }
        
        [Then(@"the Education should be deleted successfully")]
        public void ThenTheEducationShouldBeDeletedSuccessfully()
        {
            //string lang = Driver.driver.FindElement(By.XPath($"//td[normalize-space()='{ExcelLibHelper.ReadData(2, "Certification")}']")).Text;
            //Thread.Sleep(1000);

            //Assert.That(lang, Is.EqualTo("ISTQB"), "Certification not updated, Test Failed");
            //Console.WriteLine("Education deleted");
        }
    }
}

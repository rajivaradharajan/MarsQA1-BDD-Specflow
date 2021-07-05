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
    public class FeatureAddCertificationsSteps
    {
        [When(@"i add Certifications")]
        public void WhenIAddCertifications()
        {
            ExcelLibHelper.PopulateInCollection($@"{ConstantHelpers.path}\SpecflowTests\Data\\Data.xlsx", "Certifications");
            //Call the Certification class
            Certifications.AddCertification();
            Thread.Sleep(2000);
        }

        [When(@"i Update Certifications")]
        public void WhenIUpdateCertifications()
        {
            ExcelLibHelper.PopulateInCollection($@"{ConstantHelpers.path}\SpecflowTests\Data\\Data.xlsx", "Certifications");
            //Call the Certification class
            Certifications.UpdateCertification();
            Thread.Sleep(2000);
        }

        [When(@"i Delete Certifications")]
        public void WhenIDeleteCertifications()
        {
            ExcelLibHelper.PopulateInCollection($@"{ConstantHelpers.path}\SpecflowTests\Data\\Data.xlsx", "Certifications");
            //Call the Certification class
            Certifications.DeleteCertification();
            Thread.Sleep(2000);
        }

        [Then(@"the Certifications should be added successfully")]
        public void ThenTheCertificationsShouldBeAddedSuccessfully()
        {
            Thread.Sleep(3000);
            string lang = Driver.driver.FindElement(By.XPath($"//td[normalize-space()='{ExcelLibHelper.ReadData(3, "Certification")}']")).Text;
            Thread.Sleep(1000);

            Assert.That(lang, Is.EqualTo("API Testing"), "Certification not added, Test Failed");
            Console.WriteLine("Certification added");
        }

        [Then(@"the Certifications should be updated successfully")]
        public void ThenTheCertificationsShouldBeUpdatedSuccessfully()
        {
            string lang = Driver.driver.FindElement(By.XPath($"//td[normalize-space()='{ExcelLibHelper.ReadData(4, "Certification")}']")).Text;
            Thread.Sleep(1000);

            Assert.That(lang, Is.EqualTo("Jmeter"), "Certification not updated, Test Failed");
            Console.WriteLine("Certification updated");
        }

        [Then(@"the Certifications should be deleted successfully")]
        public void ThenTheCertificationsShouldBeDeletedSuccessfully()
        {
            //string lang = Driver.driver.FindElement(By.XPath($"//td[normalize-space()='{ExcelLibHelper.ReadData(2, "Certification")}']")).Text;
            //Thread.Sleep(1000);

            //Assert.That(lang, Is.EqualTo("ISTQB"), "Certification not updated, Test Failed");
            //Console.WriteLine("Certification updated");
        }
    }
}

using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MarsQA_1.SpecflowPages.Pages
{
    public class Language
    {

        private static IWebElement AddNewBtn => Driver.driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[3]/div[1]"));

        private static IWebElement AddLang => Driver.driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/input[1]"));
        private static IWebElement chooselevel => Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown']"));
        private static IWebElement AddBtn => Driver.driver.FindElement(By.XPath(".//*[@value='Add']"));
        private static IWebElement EditBtn => Driver.driver.FindElement(By.XPath("//td[@class='right aligned']//i[@class='outline write icon']"));
        private static IWebElement UpdateBtn => Driver.driver.FindElement(By.XPath("//input[@value='Update']"));
        private static IWebElement UpdatedLevel => Driver.driver.FindElement(By.XPath("//td[contains(text(),'Fluent')]"));
        private static IWebElement UpdateLang => Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
        private static IWebElement DeleteBtn => Driver.driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[3]/tr[1]/td[3]/span[2]/i[1]"));
        public static void AddLanguage()
        {

            AddNewBtn.Click();
            Thread.Sleep(1000);
            //Input language value from excel
            AddLang.SendKeys(ExcelLibHelper.ReadData(2, "Language"));
            chooselevel.Click();
            //read data from excel and select language level and click on it
            Driver.driver.FindElement(By.XPath($"//option[@value='{ExcelLibHelper.ReadData(3, "Level")}']")).Click();
            Thread.Sleep(2000);
            //Click on Add button 
            AddBtn.Click();
            Thread.Sleep(3000);
            AddNewBtn.Click();
            Thread.Sleep(1000);
            //Input language value from excel
            AddLang.SendKeys(ExcelLibHelper.ReadData(3, "Language"));
            chooselevel.Click();
            //read data from excel and select language level and click on it
            Driver.driver.FindElement(By.XPath($"//option[@value='{ExcelLibHelper.ReadData(4, "Level")}']")).Click();
            Thread.Sleep(2000);
            //Click on Add button 
            AddBtn.Click();
            Thread.Sleep(3000);
            AddNewBtn.Click();
            Thread.Sleep(1000);
            //Input language value from excel
            AddLang.SendKeys(ExcelLibHelper.ReadData(5, "Language"));
            chooselevel.Click();
            //read data from excel and select language level and click on it
            Driver.driver.FindElement(By.XPath($"//option[@value='{ExcelLibHelper.ReadData(3, "Level")}']")).Click();
            Thread.Sleep(2000);
            //Click on Add button 
            AddBtn.Click();



        }

        public static void ValidateLangadded()
        {
            string actuallangadded = Driver.driver.FindElement(By.XPath("//td[contains(text(),'Japanese')]")).Text;
            //Verify if language is addded 
            if (actuallangadded == "Japanese")
            {
                Assert.Pass("Test Passed");

            }
            else
            {
                Assert.Fail("Test Failed");

            }
        }
        public static void UpdateLanguage()
        {
            Thread.Sleep(3000);
            //Click on write icon to edit
            EditBtn.Click();
            // Expect delay
            Thread.Sleep(1000);
            UpdateLang.Click();
            Thread.Sleep(1000);
            UpdateLang.Clear();
            //Input language value from excel
            UpdateLang.SendKeys(ExcelLibHelper.ReadData(4, "Language"));
            //click on choose level dropdown
            chooselevel.Click();
            //read data from excel and select language level and click on it
            Driver.driver.FindElement(By.XPath($"//option[@value='{ExcelLibHelper.ReadData(4, "Level")}']")).Click();
            Thread.Sleep(2000);
            //Click on Update button 
            UpdateBtn.Click();


        }

        public static void  ValidateLanglevelUpdated()
        {
           //Verify if language level is updated  
            IWebElement Actuallevel = UpdatedLevel;

            // option 1
            Assert.That(Actuallevel.Text, Is.EqualTo("Fluent"), "Test Failed");
            Console.WriteLine("language  is updated");

            ////// option 2
            //if (Actuallevel.Text == "Fluent")
            //{

            //    //Assert.Pass("Language level updated, test passed");
            //    return true;
            //}
            //else
            //{
            //    return false;
            //    //Assert.Fail("test failed");
            //}
        }
        public static void DeleteLanguage()
        {
            Thread.Sleep(2000);
            DeleteBtn.Click();
            //Thread.Sleep(1000);


        }

        public static void ValidateLangdeleted()
        {

           
            

            //string actuallang = Driver.driver.FindElement(By.XPath("//td[contains(text(),'Tamil')]")).Text;
            ////Verify if language is deleted
            //if (actuallang != "Tamil")
            //    {
            //        Assert.Pass("Language not found and deleted successfully, Test Passed");

            //    }
            //    else
            //    {
            //        Assert.Fail("Test Failed");

            //    }
        }


    }
}

    





 
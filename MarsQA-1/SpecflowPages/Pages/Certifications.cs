using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    class Certifications
    {
        private static IWebElement Certificationtab => Driver.driver.FindElement(By.XPath("//a[normalize-space()='Certifications']"));
        private static IWebElement AddNewBtn => Driver.driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[5]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[4]/div[1]"));
        private static IWebElement EnterCertAward => Driver.driver.FindElement(By.XPath("//input[@placeholder='Certificate or Award']"));

        private static IWebElement EnterCertifiedFrom => Driver.driver.FindElement(By.XPath("//input[@placeholder='Certified From (e.g. Adobe)']"));
        private static IWebElement SelYear => Driver.driver.FindElement(By.XPath("//select[@name='certificationYear']"));


        private static IWebElement AddBtn => Driver.driver.FindElement(By.XPath("//input[@value='Add']"));
        private static IWebElement EditBtn => Driver.driver.FindElement(By.XPath("//tbody/tr/td[4]/span[1]/i[1]"));
        private static IWebElement UpdateBtn => Driver.driver.FindElement(By.XPath("//input[@value='Update']"));
        private static IWebElement DeleteBtn => Driver.driver.FindElement(By.XPath("//tbody/tr/td[4]/span[2]/i[1]")); 

        public static void AddCertification()
        {
            Thread.Sleep(2000);
            Certificationtab.Click();
            AddNewBtn.Click();
            Thread.Sleep(2000);
            EnterCertAward.SendKeys((ExcelLibHelper.ReadData(2, "Certification")));
            Thread.Sleep(2000);
            EnterCertifiedFrom.SendKeys((ExcelLibHelper.ReadData(2, "Certified From")));
            Thread.Sleep(1000);
            SelYear.Click();
            Driver.driver.FindElement(By.XPath($"//option[@value='{ExcelLibHelper.ReadData(2, "Year")}']")).Click();
            Thread.Sleep(2000);
            AddBtn.Click();
            //Add another record
            AddNewBtn.Click();
            Thread.Sleep(2000);
            EnterCertAward.SendKeys((ExcelLibHelper.ReadData(3, "Certification")));
            Thread.Sleep(2000);
            EnterCertifiedFrom.SendKeys((ExcelLibHelper.ReadData(3, "Certified From")));
            Thread.Sleep(1000);
            SelYear.Click();
            Driver.driver.FindElement(By.XPath($"//option[@value='{ExcelLibHelper.ReadData(3, "Year")}']")).Click();
            Thread.Sleep(2000);
            AddBtn.Click();
            //add another record
            AddNewBtn.Click();
            Thread.Sleep(3000);
            EnterCertAward.SendKeys((ExcelLibHelper.ReadData(4, "Certification")));
            Thread.Sleep(2000);
            EnterCertifiedFrom.SendKeys((ExcelLibHelper.ReadData(4, "Certified From")));
            Thread.Sleep(1000);
            SelYear.Click();
            Driver.driver.FindElement(By.XPath($"//option[@value='{ExcelLibHelper.ReadData(4, "Year")}']")).Click();
            Thread.Sleep(2000);
            AddBtn.Click();

        }
        public static void UpdateCertification()
        {
            Thread.Sleep(5000);
            Certificationtab.Click();
            //Click on write icon to edit
            EditBtn.Click();
            //Expect delay
            Thread.Sleep(1000);
            EnterCertAward.Click();
            Thread.Sleep(1000);
            EnterCertAward.Clear();
            //Input value from excel
            EnterCertAward.SendKeys(ExcelLibHelper.ReadData(5, "Certification"));
            Thread.Sleep(2000);
            EnterCertifiedFrom.Clear();
            Thread.Sleep(2000);
            EnterCertifiedFrom.SendKeys((ExcelLibHelper.ReadData(5, "Certified From")));
            //click on year dropdown
            SelYear.Click();
            SelYear.SendKeys(ExcelLibHelper.ReadData(5, "Year"));
            Thread.Sleep(2000);
            //Click on Update button
            UpdateBtn.Click();
        }

        public static void DeleteCertification()
        {
            Certificationtab.Click();
            Thread.Sleep(2000);
            DeleteBtn.Click();
            Thread.Sleep(1000);


        }
    }
}
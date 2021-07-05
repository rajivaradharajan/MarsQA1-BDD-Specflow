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

namespace MarsQA_1.SpecflowPages.Pages
{
    class Education
    {
       //identify education tab
        private static IWebElement Educationtab => Driver.driver.FindElement(By.XPath("//a[normalize-space()='Education']"));
        private static IWebElement AddNewBtn => Driver.driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[6]/div[1]"));
        private static IWebElement EntercollUniv => Driver.driver.FindElement(By.XPath("//input[@placeholder='College/University Name']"));
        
        private static IWebElement SelCountryofcoll => Driver.driver.FindElement(By.XPath("//select[@name='country']"));
        private static IWebElement SelTitle => Driver.driver.FindElement(By.XPath("//select[@name='title']"));

        private static IWebElement EnterDegree => Driver.driver.FindElement(By.XPath("//input[@placeholder='Degree']"));
        private static IWebElement SelYearofgrad => Driver.driver.FindElement(By.XPath("//select[@name='yearOfGraduation']"));
        private static IWebElement AddBtn => Driver.driver.FindElement(By.XPath("//input[@value='Add']"));
        private static IWebElement EditBtn => Driver.driver.FindElement(By.XPath("//tbody/tr[1]/td[6]/span[1]/i[1]"));
        private static IWebElement UpdateBtn => Driver.driver.FindElement(By.XPath("//input[@value='Update']"));
        private static IWebElement DeleteBtn => Driver.driver.FindElement(By.XPath("//tbody[1]/tr[1]/td[6]/span[2]/i[1]"));
         

        //public static void Selfromdropdown()
        //{
        //    SelectElement drpcountry = new SelectElement(Driver.driver.FindElement(By.XPath("//option[@value='Australia']")));
        //    drpcountry.SelectByValue("Australia");
        //    SelectElement Titledrpdown = new SelectElement(Driver.driver.FindElement(By.XPath("//option[@value='B.Tech']")));
        //    Titledrpdown.SelectByValue("B.Tech");
        //}
        public static void AddEducation()
        {
            Thread.Sleep(2000);
            //Find education tab and click
            Educationtab.Click();
            //click on add new button
            AddNewBtn.Click();
            //Expect delay
            Thread.Sleep(2000);
            //Click on enter college /uni textbox and input value from excel
            EntercollUniv.SendKeys((ExcelLibHelper.ReadData(2, "University"))); 
            Thread.Sleep(2000);
            //Click on country dropdown
            SelCountryofcoll.Click();
            Thread.Sleep(2000);
            //input and read data from excel 
            Driver.driver.FindElement(By.XPath($"//option[@value='{ExcelLibHelper.ReadData(2, "Country")}']")).Click();
            Thread.Sleep(2000);
            //Click on title dropdown
            SelTitle.Click();
            //input and read data from excel
            Driver.driver.FindElement(By.XPath($"//option[@value='{ExcelLibHelper.ReadData(2, "Title")}']")).Click();
            Thread.Sleep(2000);

            //SelectElement drpcountry = new SelectElement(Driver.driver.FindElement(By.XPath("//option[@value='Australia']")));
            //Thread.Sleep(2000);
            //drpcountry.SelectByValue("Australia");
            //Thread.Sleep(2000);
            //SelectElement Titledrpdown = new SelectElement(Driver.driver.FindElement(By.XPath("//option[@value='B.Tech']")));
            //Thread.Sleep(2000);
            //Titledrpdown.SelectByValue("B.Tech");
            //Thread.Sleep(2000);

            //input value from excel 
            EnterDegree.SendKeys(ExcelLibHelper.ReadData(2, "Degree"));
            Thread.Sleep(2000);
            SelYearofgrad.Click();
            Thread.Sleep(2000);
            Driver.driver.FindElement(By.XPath($"//option[@value='{ExcelLibHelper.ReadData(2, "Graduation Year")}']")).Click();
            //SelectElement yeardrpdown = new SelectElement(Driver.driver.FindElement(By.XPath("//option[@value='2017']")));
            //yeardrpdown.SelectByValue("2017");
            Thread.Sleep(2000);
            AddBtn.Click();

            //add another record
            Thread.Sleep(2000);
            AddNewBtn.Click();
            Thread.Sleep(2000);
            EntercollUniv.SendKeys((ExcelLibHelper.ReadData(3, "University")));
            Thread.Sleep(2000);
            SelCountryofcoll.Click();
            Thread.Sleep(2000);
            Driver.driver.FindElement(By.XPath($"//option[@value='{ExcelLibHelper.ReadData(3, "Country")}']")).Click();
            Thread.Sleep(2000);
            SelTitle.Click();
            Driver.driver.FindElement(By.XPath($"//option[@value='{ExcelLibHelper.ReadData(3, "Title")}']")).Click();
            Thread.Sleep(2000);
            EnterDegree.SendKeys(ExcelLibHelper.ReadData(3, "Degree"));
            Thread.Sleep(2000);
            SelYearofgrad.Click();
            Thread.Sleep(2000);
            Driver.driver.FindElement(By.XPath($"//option[@value='{ExcelLibHelper.ReadData(3, "Graduation Year")}']")).Click();
            Thread.Sleep(2000);
            AddBtn.Click();

            //Add another record
            Thread.Sleep(2000);
            AddNewBtn.Click();
            Thread.Sleep(2000);
            EntercollUniv.SendKeys((ExcelLibHelper.ReadData(4, "University")));
            Thread.Sleep(2000);
            SelCountryofcoll.Click();
            Thread.Sleep(2000);
            Driver.driver.FindElement(By.XPath($"//option[@value='{ExcelLibHelper.ReadData(4, "Country")}']")).Click();
            Thread.Sleep(2000);
            SelTitle.Click();
            Driver.driver.FindElement(By.XPath($"//option[@value='{ExcelLibHelper.ReadData(4, "Title")}']")).Click();
            Thread.Sleep(2000);
            EnterDegree.SendKeys(ExcelLibHelper.ReadData(4, "Degree"));
            Thread.Sleep(2000);
            SelYearofgrad.Click();
            Thread.Sleep(2000);
            Driver.driver.FindElement(By.XPath($"//option[@value='{ExcelLibHelper.ReadData(4, "Graduation Year")}']")).Click();
            Thread.Sleep(2000);
            AddBtn.Click();

        }
        public static void UpdateEducation()
        {
            Thread.Sleep(2000);
            Educationtab.Click();
            Thread.Sleep(1000);
            //Click on write icon to edit
            EditBtn.Click();
            // Expect delay
            Thread.Sleep(1000);
            EntercollUniv.Click();
            Thread.Sleep(1000);
            EntercollUniv.Clear();
            //Input language value from excel
            EntercollUniv.SendKeys(ExcelLibHelper.ReadData(5, "University"));
            //click on choose country dropdown
            SelCountryofcoll.Click();
            Thread.Sleep(2000);
            Driver.driver.FindElement(By.XPath($"//option[@value='{ExcelLibHelper.ReadData(5, "Country")}']")).Click();
            Thread.Sleep(2000);
            EnterDegree.Clear();
            EnterDegree.SendKeys(ExcelLibHelper.ReadData(5, "Degree"));
            Thread.Sleep(2000);
            Driver.driver.FindElement(By.XPath($"//option[@value='{ExcelLibHelper.ReadData(5, "Graduation Year")}']")).Click();
            Thread.Sleep(2000);
            //Click on Update button 
            UpdateBtn.Click();
        }

            public static void DeleteEducation()
            {
            Educationtab.Click();
            Thread.Sleep(2000);
                DeleteBtn.Click();
                //Thread.Sleep(1000);


            }
        }
    }

    




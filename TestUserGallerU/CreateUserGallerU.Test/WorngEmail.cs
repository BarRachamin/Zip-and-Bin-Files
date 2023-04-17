using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using TestUserGallerU;

namespace CreateUserGallerU.Test
{
 
    public class WorngEmail
    {

        public void Pause(int mili = 3000)
        {
            System.Threading.Thread.Sleep(mili);
        }

        [Test]
        public void ErrorCheck()
        {
            User user = new User();
            string url = "https://blue-field-01c0eaf03.3.azurestaticapps.net/";

            using (IWebDriver driver = new ChromeDriver())
            {

                driver.Navigate().GoToUrl(url);

                Pause();

                IWebElement aTag = driver.FindElement(By.CssSelector("button[class='button-0-2-2']"));

                if (aTag != null)
                {
                    aTag.Click();

                    IWebElement Email = driver.FindElement(By.CssSelector("input[inputmode='email']"));

                    if (Email != null)
                    {
                        Email.SendKeys(user.Email.Replace(".", ""));

                    }

                    IWebElement continueToPass = driver.FindElement(By.CssSelector("button[type='submit']"));

                    if (continueToPass != null)
                    {
                        continueToPass.Click();

                    }

                    IWebElement ErrorEmail = driver.FindElement(By.CssSelector("span[id='error-element-username']"));

                    if (!ErrorEmail.Text.Contains("Email is not valid"))
                    {
                        Assert.Fail("was excepted error massege");
                    }


                    IWebElement Password = driver.FindElement(By.CssSelector("input[id='password']"));

                    if (Password != null)
                    {
                        Password.SendKeys("Bar123456!");
                    }

                    IWebElement Submit = driver.FindElement(By.CssSelector("button[type='submit']"));

                    if (Submit != null)
                    {
                        Submit.Click();
                        Pause();
                    }

                }
            }

          
        }
    }
}

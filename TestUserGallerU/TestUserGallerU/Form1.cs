using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestUserGallerU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        
        }
        public User user = new User();
        public void Pause(int mili = 3000)
        {
            System.Threading.Thread.Sleep(mili);
        }
        
        string url = ConfigurationSettings.AppSettings["url"].ToString();
        private void NewUser(object sender, EventArgs e)
        {
           



            using (IWebDriver driver = new ChromeDriver())
            {


                driver.Navigate().GoToUrl(url);


                Pause();

                IWebElement aTag = driver.FindElement(By.CssSelector("button[class='button-0-2-2']"));

                if (aTag != null)
                {
                    aTag.Click();

                    IWebElement SignUp = driver.FindElement(By.CssSelector("a[class='c8d123439 ce1bebd2d']"));

                    if (SignUp != null)
                    {
                        SignUp.Click();
                    }

                    IWebElement Email = driver.FindElement(By.CssSelector("input[id='email']"));

                    if (Email != null)
                    {
                        Email.SendKeys($"bartry2@gmail.com");
                    }

                    IWebElement continueToPass = driver.FindElement(By.CssSelector("button[type='submit']"));

                    if (continueToPass != null)
                    {
                        continueToPass.Click();

                    }
                    IWebElement Password = driver.FindElement(By.CssSelector("input[id='password']"));

                    if (Password != null)
                    {
                        Password.SendKeys("Bar423456!");
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

        private void ExistsUser(object sender, EventArgs e)
        {
         



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
                        Email.SendKeys(user.Email);

                    }

                    IWebElement continueToPass = driver.FindElement(By.CssSelector("button[type='submit']"));

                    if (continueToPass != null)
                    {
                        continueToPass.Click();

                    }

                    IWebElement Password = driver.FindElement(By.CssSelector("input[id='password']"));

                    if (Password != null)
                    {
                        Password.SendKeys(user.Password);
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

        private void WorngEmail_Click(object sender, EventArgs e)
        {
         



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
                        Email.SendKeys(user.Email.Replace(".",""));

                    }

                    IWebElement continueToPass = driver.FindElement(By.CssSelector("button[type='submit']"));

                    if (continueToPass != null)
                    {
                        continueToPass.Click();

                    }

                    IWebElement ErrorEmail = driver.FindElement(By.CssSelector("span[id='error-element-username']"));

                    if (!ErrorEmail.Text.Contains("Email is not valid"))
                    {
                        
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

        private void WorngPass_Click(object sender, EventArgs e)
        {
          

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
                        Email.SendKeys($"bartry1@gmail.com");

                    }

                    IWebElement continueToPass = driver.FindElement(By.CssSelector("button[type='submit']"));

                    if (continueToPass != null)
                    {
                        continueToPass.Click();

                    }

                    IWebElement Password = driver.FindElement(By.CssSelector("input[id='password']"));

                    if (Password != null)
                    {
                        Password.SendKeys(user.Password.Replace("B","b"));
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

        private void EmailNotExists_Click(object sender, EventArgs e)
        {
           

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
                        Email.SendKeys(user.Email.Replace("bartry1","kuku"));

                    }

                    IWebElement continueToPass = driver.FindElement(By.CssSelector("button[type='submit']"));

                    if (continueToPass != null)
                    {
                        continueToPass.Click();

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

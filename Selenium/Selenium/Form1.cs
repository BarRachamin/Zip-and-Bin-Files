using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Selenium
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Pause(int mili =3000)
        {
            System.Threading.Thread.Sleep(mili);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = "https://zionet-selenium.bubbleapps.io/version-test";


            for (int i = 3; i < 13; i++)
            {
                using (IWebDriver driver = new ChromeDriver())
                {
               
               
                driver.Navigate().GoToUrl(url);

                    
                  Pause();

                IWebElement aTag= driver.FindElement(By.CssSelector("div[class='clickable-element bubble-element Group baTaGzaS bubble-r-container flex row']"));

                    if (aTag != null)
                    {
                        aTag.Click();

                        IWebElement UserName = driver.FindElement(By.CssSelector("input[placeholder='Username']"));

                        if (UserName != null)
                        {
                            UserName.SendKeys("Bar rachamin");
                        }

                        IWebElement Email = driver.FindElement(By.CssSelector("input[placeholder='Email Address']"));

                        if (Email != null)
                        {
                            Email.SendKeys($"bar.rachamin{i}@gmail.com");
                        }

                        IWebElement Password = driver.FindElement(By.CssSelector("input[placeholder='Password']"));

                        if (Password != null)
                        {
                            Password.SendKeys("bar123456789");
                        }

                        IWebElement ConfirmPassword = driver.FindElement(By.CssSelector("input[placeholder='Confirm Password']"));

                        if (ConfirmPassword != null)
                        {
                            ConfirmPassword.SendKeys("bar123456789");
                        }

                        IWebElement CreateAccount = driver.FindElement(By.CssSelector("div[class='bubble-element Text baTaHaMaI bubble-r-vertical-center clickable-element']"));

                        if (CreateAccount != null)
                        {
                            CreateAccount.Click();

                            Pause();
                        }
                
                        
                    }
                    driver.Quit();
                }

            }
        }
    }
}

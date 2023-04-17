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

namespace Auth0CheckUser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Pause(int mili = 3000)
        {
            System.Threading.Thread.Sleep(mili);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = "https://tic-tac-toe-of-achiya.netlify.app/";


            for (int i = 6; i < 16; i++)
            {
                using (IWebDriver driver = new ChromeDriver())
                {


                    driver.Navigate().GoToUrl(url);


                    Pause();

                    IWebElement aTag = driver.FindElement(By.CssSelector("button[class='btn btn-primary w-100']"));

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
                            Email.SendKeys($"bar.rachamin{i}@gmail.com");
                        }

                        IWebElement Password = driver.FindElement(By.CssSelector("input[id='password']"));

                        if (Password != null)
                        {
                            Password.SendKeys("Bar123456789!");
                        }

                        IWebElement Submit = driver.FindElement(By.CssSelector("button[type='submit']"));

                        if (Submit != null)
                        {
                            Submit.Click();
                            Pause();
                        }

                      


                    }
                    driver.Quit();
                }
            }
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            
            IWebDriver chrome = new ChromeDriver();
            chrome.Manage().Window.Maximize();
            chrome.Url = "https://www.google.com.br/?gws_rd=ssl";
            Assert.AreEqual("TESTE","ESTE","ERRO");

        }
    }
}

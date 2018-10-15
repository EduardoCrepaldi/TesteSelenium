using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod, TestCategory("BuildAutomation")]
        public void TestMethod1()
        {
            
            IWebDriver chrome = new ChromeDriver();
            chrome.Manage().Window.Maximize();
            chrome.Url = "https://www.google.com.br/?gws_rd=ssl";
            chrome.Quit();

        }
        [TestMethod, TestCategory("BuildAutomation")]
        public void LoginErrado()
        {
            IWebDriver chrome = new ChromeDriver();
            try{
            chrome.Manage().Window.Maximize();
            chrome.Url = "https://www.google.com.br/?gws_rd=ssl";
            Assert.AreEqual("TESTE1","TESTE2","ERRO NO TESTE");
            }catch(Exception ex){
                throw ex;
            }finally{
                chrome.Quit();
            }
        }
    }
}

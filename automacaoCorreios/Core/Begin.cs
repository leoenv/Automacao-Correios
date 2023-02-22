using System;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace automacaoCorreios.Core
{
	public class Begin : DSL 
    {

        [SetUp]
        public void InicioTeste()
		{
            driver = new ChromeDriver(@"/Users/leonardobardelin/Projects/automacaoCorreios/automacaoCorreios/Driver");
            driver.Navigate().GoToUrl("https://www.correios.com.br/");
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void FimDoTeste()
        {
            var todayDate = DateTime.Now;
            var localtime = todayDate.ToString("yy-MM-dd HH:mm:ss");
            var testName = TestContext.CurrentContext.Test.Name;

            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success != true)
            {
                var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                var filePath = "/Users/leonardobardelin/Projects/Correios-Automacao/automacaoCorreios/ScreenshotReport/";
                screenshot.SaveAsFile(filePath + "Sucesso - " + testName + ".jpeg " + localtime);
            }
                else
                {
                    var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                    var filePath = "/Users/leonardobardelin/Projects/Correios-Automacao/automacaoCorreios/ScreenshotReport/";
                    screenshot.SaveAsFile(filePath + "Falha - " + testName + ".jpeg " + localtime);
                }

            if (driverQuit) driver.Quit();
        }
    }
}


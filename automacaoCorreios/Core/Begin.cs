using System;
using System.IO;
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
            driver = new ChromeDriver(@"C:\Users\Pichau\Desktop\Projetos\automacao-correios\automacaoCorreios\Driver\");
            driver.Navigate().GoToUrl("https://www.correios.com.br/");
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void FimDoTeste()
        {
            var todayDate = DateTime.Now;
            var localtime = todayDate.ToString("yy_MM_dd HH-mm-ss");
            var testName = TestContext.CurrentContext.Test.Name;

            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success != true)
            {
                var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                var filePath = @"C:\Users\Pichau\Desktop\Projetos\automacao-correios\automacaoCorreios\ScreenshotReport\";
                screenshot.SaveAsFile(filePath + @"\Sucesso - " + testName + ".jpeg " + localtime);
            }
                else
                {
                    var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                    var filePath = @"C:\Users\Pichau\Desktop\Projetos\automacao-correios\automacaoCorreios\ScreenshotReport\";
                    screenshot.SaveAsFile(filePath + @"\Falha - " + testName + ".jpeg " + localtime);
                }

            if (driverQuit) driver.Quit();
        }
    }
}


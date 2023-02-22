using System;
using System.IO;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using OpenQA.Selenium;

namespace automacaoCorreios.Core
{
	public class DSL : GlobalVariables
	{
		public void EscreveTexto(string id, string value)
		{
			driver.FindElement(By.Id(id)).SendKeys(value);
        }

		public void Clica(string xpath)
        {
			driver.FindElement(By.XPath(xpath)).Click();
		}

        public void TeclaEnter(string id)
        {
            driver.FindElement(By.Id(id)).Submit();
        }

        public void ValidaInformacao(string cssselector, string value)
        {
            Assert.That(driver.FindElement(By.CssSelector(cssselector)).Text, Is.EqualTo(value));
        }

        public void MudarGuiaNavegador(int numeroGuia)
		{
            driver.SwitchTo().Window(driver.WindowHandles[numeroGuia]);
        }

        public void FecharGuiaNavegador()
        {
            driver.Close();
        }
    }
}


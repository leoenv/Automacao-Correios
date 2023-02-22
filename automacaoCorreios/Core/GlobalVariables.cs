using System;
using OpenQA.Selenium;

namespace automacaoCorreios.Core
{
	public class GlobalVariables
	{
        // Define 'driver' como gatilho para os WebElements
        public IWebDriver driver;

        // Define 'Fechar navegador ao finalizar o teste'  como padrão
        public bool driverQuit = true;
    }
}


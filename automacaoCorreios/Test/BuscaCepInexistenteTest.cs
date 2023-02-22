using System;
using automacaoCorreios.Page;
using NUnit.Framework;

namespace automacaoCorreios.Test
{
	class BuscaCepInexistenteTest : BuscaCepInexistentePage
	{
        [Test]
        public void BuscaCepInexistente()
        {
            PreencheCep();
            TeclaEnter();
            TrocaGuia();
            ValidaInformacao();
        }
    }
}


using System;
using automacaoCorreios.Page;
using NUnit.Framework;

namespace automacaoCorreios.Test
{
	class BuscaCodigoInexistenteTest : BuscaCodigoRastreioInexistentePage
	{
        // No final do fluxo do teste é requerido um captcha para poder realizar a pesquisa, porém não consegui quebrar o mesmo. Por isso o teste irá falhar na validação final.
        [Test]
        public void BuscaCodigoRastreioInexistente()
        {
            PreencheCodigo();
            TeclaEnter();
            TrocaGuia();
            ClicaBotaoPesquisar();
            ValidaInformacao();
        }
    }
}


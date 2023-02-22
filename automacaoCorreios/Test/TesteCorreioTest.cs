using System;
using automacaoCorreios.Page;
using NUnit.Framework;

namespace automacaoCorreios.Test
{
    class TesteCorreioTest : TesteCorreioPage
	{
		[Test]
		public void TesteCompletoCorreio()
		{
			// Buscar cep Existente
			PreencheCepExistente();
			TeclaEnterCepExistente();
			TrocaGuiaNavegador();
			ValidaInformacaoCepExistente();
			FecharGuiaCepExistente();
			RetornarGuiaSiteCorreios();

            // Buscar cep Inexistente
            PreencheCepInexistente();
			TeclaEnterCepInexistente();
			TrocaGuiaNavegador();
			ValidaInformacaoCepInexistente();
			FecharGuiaCepInexistente();
			RetornarGuiaSiteCorreios();

            // Buscar código rastreio inexistente
            // No final do fluxo do teste é requerido um captcha para poder realizar a pesquisa, porém não consegui quebrar o mesmo. Por isso o teste irá falhar na validação final.
            PreencheCodigoInexistente();
            TeclaEnterCodigoInexistente();
            TrocaGuiaCodigoInexistente();
            ClicaBotaoPesquisar();
            ValidaInformacaoCodigoInexistente();
        }
	}
}


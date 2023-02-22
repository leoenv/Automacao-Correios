using System;
using automacaoCorreios.Page;
using NUnit.Framework;

namespace automacaoCorreios.Test
{
	class BuscaCepTest : BuscaCepPage
	{
		[Test]
		public void BuscaCep()
		{
			PreencheCep();
			TeclaEnter();
			TrocaGuia();
			ValidaInformacao();
		}
	}
}


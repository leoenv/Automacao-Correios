using System;
using automacaoCorreios.Core;

namespace automacaoCorreios.Page
{
	class BuscaCepPage : Begin
	{
		public void PreencheCep()
        {
			EscreveTexto("relaxation", "01013-001");
		}

		public void TeclaEnter()
		{
			TeclaEnter("relaxation");
        }

		public void TrocaGuia()
		{
			MudarGuiaNavegador(1);
		}

		public void ValidaInformacao()
		{
			ValidaInformacao("#resultado-DNEC > tbody > tr > td:nth-child(1)", "Rua Quinze de Novembro - lado ímpar");
		}
	}
}


using System;
using automacaoCorreios.Core;

namespace automacaoCorreios.Page
{
	class BuscaCepInexistentePage : Begin
	{
        public void PreencheCep()
        {
            EscreveTexto("relaxation", "80700000");
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
            ValidaInformacao("#mensagem-resultado", "Não há dados a serem exibidos");
        }
    }
}


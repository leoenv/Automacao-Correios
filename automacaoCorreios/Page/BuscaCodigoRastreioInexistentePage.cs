using System;
using automacaoCorreios.Core;

namespace automacaoCorreios.Page
{
	class BuscaCodigoRastreioInexistentePage : Begin
	{
        public void PreencheCodigo()
        {
            EscreveTexto("objetos", "SS987654321BR");
        }

        public void TeclaEnter()
        {
            TeclaEnter("objetos");
        }

        public void TrocaGuia()
        {
            MudarGuiaNavegador(1);
        }

        public void ClicaBotaoPesquisar()
        {
            Clica("//*[@id=\"b-pesquisar\"]");
        }

        public void ValidaInformacao()
        {
            ValidaInformacao("#alerta > div.msg", "Objeto não encontrado na base de dados dos Correios.");
        }
    }
}


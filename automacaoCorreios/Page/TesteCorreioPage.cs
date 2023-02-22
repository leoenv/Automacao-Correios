using System;
using automacaoCorreios.Core;

namespace automacaoCorreios.Page
{
	class TesteCorreioPage : Begin
	{
        public void PreencheCepExistente()
        {
            EscreveTexto("relaxation", "01013-001");
        }

        public void TeclaEnterCepExistente()
        {
            TeclaEnter("relaxation");
        }

        public void TrocaGuiaNavegador()
        {
            MudarGuiaNavegador(1);
        }

        public void ValidaInformacaoCepExistente()
        {
            ValidaInformacao("#resultado-DNEC > tbody > tr > td:nth-child(1)", "Rua Quinze de Novembro - lado ímpar");
        }

        public void FecharGuiaCepExistente()
        {
            FecharGuiaNavegador();
        }

        public void RetornarGuiaSiteCorreios()
        {
            MudarGuiaNavegador(0);
        }

        public void PreencheCepInexistente()
        {
            EscreveTexto("relaxation", "80700000");
        }

        public void TeclaEnterCepInexistente()
        {
            TeclaEnter("relaxation");
        }

        public void ValidaInformacaoCepInexistente()
        {
            ValidaInformacao("#mensagem-resultado", "Não há dados a serem exibidos");
        }

        public void FecharGuiaCepInexistente()
        {
            FecharGuiaNavegador();
        }

        public void PreencheCodigoInexistente()
        {
            EscreveTexto("objetos", "SS987654321BR");
        }

        public void TeclaEnterCodigoInexistente()
        {
            TeclaEnter("objetos");
        }

        public void TrocaGuiaCodigoInexistente()
        {
            MudarGuiaNavegador(1);
        }

        public void ClicaBotaoPesquisar()
        {
            Clica("//*[@id=\"b-pesquisar\"]");
        }

        public void ValidaInformacaoCodigoInexistente()
        {
            ValidaInformacao("#alerta > div.msg", "Objeto não encontrado na base de dados dos Correios.");
        }
    }
}


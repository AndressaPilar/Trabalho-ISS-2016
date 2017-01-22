using System;
using TechTalk.SpecFlow;

namespace ProjetoArtCouro.Selenium.Operacoes
{
    [Binding]
    public class EfetuarOCRUDDeContaPagarSteps
    {
        private readonly ContaPagarPageObjects _pageObjects;

        public EfetuarOCRUDDeContaPagarSteps(FeatureContext featureContext)
        {
            _pageObjects = new ContaPagarPageObjects(featureContext);
        }

        [Given(@"que eu acesse a funcionalidade de Conta a Pagar")]
        public void DadoQueEuAcesseAFuncionalidadeDeContaAPagar()
        {
            _pageObjects.AcessaFuncionalidadeContaPagar();
        }

        [Given(@"selecione o Status Aberto")]
        public void DadoSelecioneOStatusAberto()
        {
            _pageObjects.SelecionarStatusContaPagar();
        }

        [Given(@"clique no botão Pesquisar de Conta a Pagar")]
        public void DadoCliqueNoBotaoPesquisarDeContaAPagar()
        {
            _pageObjects.ClicarBotaoPesquisarContaPagar();
        }

        

        [Given(@"selecione a Conta a Pagar filtrada")]
        public void DadoSelecioneAContaAPagarFiltrada()
        {
           // _pageObjects.SelecionarContaPagarFiltrada();
        }

        [Given(@"clique no botão Pagar de Conta a Pagar")]
        public void DadoCliqueNoBotaoPagarDeContaAPagar()
        {
           // _pageObjects.ClicarBotaoPagarContaPagar();
        }

    }
}

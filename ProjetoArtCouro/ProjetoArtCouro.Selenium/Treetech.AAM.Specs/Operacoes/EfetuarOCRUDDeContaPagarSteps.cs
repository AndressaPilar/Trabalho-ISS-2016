using System;
using TechTalk.SpecFlow;

namespace Treetech.AAM.Specs.Operacoes
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
    }
}

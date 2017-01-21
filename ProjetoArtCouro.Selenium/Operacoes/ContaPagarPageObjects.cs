using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ProjetoArtCouro.Selenium.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace ProjetoArtCouro.Selenium.Operacoes
{
    public class ContaPagarPageObjects : BasePageObjects
    {
        private readonly string _urlListagemContaPagar;
        private readonly string _urlManutencaoContaPagar;

        public ContaPagarPageObjects(FeatureContext featureContext) : base(featureContext)
        {
            _urlListagemContaPagar = $"{UrlHelpers.Main}/ContaPagar/PesquisaContaPagar";
            _urlManutencaoContaPagar = $"{UrlHelpers.Main}/ContaPagar/NovaContaPagar";
        }

        public void AcessaFuncionalidadeContaPagar()
        {
            Driver.Navigate().GoToUrl(_urlListagemContaPagar);
        }
    }
}
